using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SerialPortAssistant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbx_COMport_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = cbx_COMport.Text;
        }

        private void cbx_Paritv_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbx_Paritv.Text)
            {
                case "Odd":
                    serialPort1.Parity = System.IO.Ports.Parity.Odd;
                    break;
                case "Even":
                    serialPort1.Parity = System.IO.Ports.Parity.Even;
                    break;
                case "Space":
                    serialPort1.Parity = System.IO.Ports.Parity.Space;
                    break;
                case "Mark":
                    serialPort1.Parity = System.IO.Ports.Parity.Mark;
                    break;
                default:
                    serialPort1.Parity = System.IO.Ports.Parity.None;
                    break;

            }
            
        }

        private void cbx_BaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.BaudRate = int.Parse(cbx_BaudRate.Text);
        }

        private void cbx_DataBits_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num = int.Parse(cbx_DataBits.Text);
            if (num >= 5 && num <= 8) serialPort1.DataBits = num;
            else
            {
                serialPort1.DataBits = 8;
                cbx_DataBits.Text = "8";
            }
        }

        private void cbx_StopBits_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbx_StopBits.Text)
            {
                case "1.5":
                    serialPort1.StopBits = System.IO.Ports.StopBits.OnePointFive;
                    break;
                case "2":
                    serialPort1.StopBits = System.IO.Ports.StopBits.Two;
                    break;
                default:
                    serialPort1.StopBits = System.IO.Ports.StopBits.One;
                    break;
            }
        }

        private void rbn_Char_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbn_Hex_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_detect_Click(object sender, EventArgs e)
        {
            cbx_COMport.Items.Clear();
            cbx_COMport.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
        }

        private void btn_saveFile_Click(object sender, EventArgs e)
        {
            sfd_rec.Filter = "Normal text file (*.txt)|*.txt";
            sfd_rec.FilterIndex = 1;
            sfd_rec.RestoreDirectory = true;
            sfd_rec.FileName =DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss");
            if (sfd_rec.ShowDialog() == DialogResult.OK)
            {
                string fullpath = sfd_rec.FileName;
                MessageBox.Show(fullpath);
                if (fullpath != "")
                {
                    FileInfo fi = new FileInfo(fullpath);
                    //FileStream字节流写入
                    using(FileStream fs = new FileStream(fi.FullName, FileMode.CreateNew, FileAccess.Write, FileShare.None))
                    {
                        string str = tbx_Rec.Text;
                        byte[] buffer = System.Text.Encoding.UTF8.GetBytes(str);
                        fs.Write(buffer, 0, buffer.Length);
                        fs.Flush();
                    }

                    //字符流读出
                    using (StreamReader rs = new StreamReader(fi.FullName))
                    {
                        string line = "";
                        while ((line = rs.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("取消保存","保存结果");
                return;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            tbx_Rec.Clear();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            string line = tbx_send.Text;
            if (line == "") return;
            try
            {
                byte[] temp=Encoding.UTF8.GetBytes(line);
                byte[] send = new byte[temp.Length + 1];
                send[0] = (int)ComTag.NormalTag;
                for (int i = 0; i < temp.Length; i++) send[i + 1] = temp[i];
                serialPort1.Write(send,0,send.Length);
                tbx_send.Clear();
            }
            catch(Exception)
            {
                MessageBox.Show("发送数据失败，检查端口是否成功打开");
            }
            
        }

        private void btn_openPort_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();
                    btn_openPort.Text = "打开串口";
                    btn_openPort.ForeColor = Color.Black;
                }
                catch
                {
                    MessageBox.Show("端口关闭失败！");
                    return;
                }
            }
            else
            {
                try
                {
                    serialPort1.Open();
                    btn_openPort.Text = "关闭串口";
                    btn_openPort.ForeColor = Color.Red;
                }
                catch
                {
                    if (System.IO.Ports.SerialPort.GetPortNames().Length == 0)
                    {
                        MessageBox.Show("串口"+serialPort1.PortName+"打开失败，指定串口不存在！");
                    }else
                    {
                        MessageBox.Show("串口" + serialPort1.PortName + "打开失败，串口被占用！");
                    }
                    return;
                }
            }
        }

        static FileStream fsRec;
        static FileInfo fiRec;
        static FileStream fsSend;
        static FileInfo fiSend;
        static long fileLength;
        static long filePosition;
        static int previousTag = (int)ComTag.NormalTag;
        static bool cancelFlag=false;
        

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //System.Threading.Thread.Sleep(100);
            if (serialPort1.BytesToRead == 0) return;
            int comTag = serialPort1.ReadByte();
            //Console.WriteLine("本次读取字节"+serialPort1.BytesToRead);
            switch (comTag)
            {
                case (int)ComTag.NormalTag:
                    //解析为普通信息并显示
                    updateMessage();
                    break;
                case (int)ComTag.FileNameTag:
                    //解析为文件名，并选择存储位置
                    praseFileName();
                    break;
                case (int)ComTag.DataReceivedTag:
                    //收到数据块确认，继续发送下一个数据块
                    dataTransfer();
                    break;
                case (int)ComTag.DataSendTag:
                    //解析为数据块，保存入打开的文件
                    saveData();
                    byte[] echo = { (int)ComTag.DataReceivedTag };
                    serialPort1.Write(echo, 0, 1);
                    previousTag = (int)ComTag.DataReceivedTag;
                    break;
                case (int)ComTag.FinalDataSendTag:
                    //收到最后的数据块，保存如打开的文件，并发送收到信息，停止接收文件
                    saveData();
                    fsRec.Dispose();
                    byte[] fecho = { (int)ComTag.FinalDataReceivedTag };
                    serialPort1.Write(fecho, 0, 1);
                    previousTag = (int)ComTag.NormalTag;
                    MessageBox.Show("文件接收完成！");
                    Invoke((EventHandler)(delegate
                    {
                        pgb_file.Value = 0;
                        pgb_file.PerformStep();
                    }));
                    break;
                case (int)ComTag.FinalDataReceivedTag:
                    //收到最后的数据块确认信息，停止发送数据块
                    previousTag = (int)ComTag.NormalTag;
                    MessageBox.Show("文件发送完成！");
                    Invoke((EventHandler)(delegate
                    {
                        pgb_file.Value = 0;
                        pgb_file.PerformStep();
                        btn_fileSend.ForeColor = Color.Black;
                        btn_fileSend.Text = "发送文件";
                    }));
                    break;
                default:
                    if (previousTag == (int)ComTag.DataSendTag) cancelFileSend();
                    else if (previousTag == (int)ComTag.DataReceivedTag) cancelFileRec();
                    break;
            }
            if (cancelFlag)
            {
                byte[] eliminate = { (int)ComTag.CancelTag };
                serialPort1.Write(eliminate, 0, 1);
                fsSend.Dispose();
                previousTag = (int)ComTag.NormalTag;
                Invoke((EventHandler)(delegate
                {
                    pgb_file.Value = 0;
                    pgb_file.PerformStep();
                }));
            }
            

        }
        enum ComTag
        {
            FileNameTag=1,
            DataReceivedTag=2,
            DataSendTag=3,
            FinalDataSendTag=4,
            FinalDataReceivedTag=5,
            NormalTag=6,
            CancelTag=7
        }
        //普通文本信息通信
        private void updateMessage()
        {
            Invoke((EventHandler)(delegate {
                //读取字节流
                int count = serialPort1.BytesToRead;
                byte[] buffer = new byte[count];
                serialPort1.Read(buffer, 0, count);
                StringBuilder line = new StringBuilder();
                //字符解码
                if (rbn_Char.Checked)
                {
                    line.Append(Encoding.UTF8.GetString(buffer));
                }
                //Hex解码
                else if (rbn_Hex.Checked)
                    for (int i = 0; i < count; i++)
                        line.Append(
                            Convert.ToString(buffer[i], 16) + " ");
                tbx_Rec.Text += System.Environment.NewLine + line;
                Console.WriteLine(line);
            }));
        }
        //处理文件名信息
        private void praseFileName()
        {
            Invoke((EventHandler)(delegate
            {
                serialPort1.Encoding = Encoding.UTF8;
                string fileName = serialPort1.ReadLine().Trim();
                fileLength = long.Parse(serialPort1.ReadExisting());
                DialogResult dr =
                    MessageBox.Show(fileName, "收到文件", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    sfd_rec.Filter = "All types (*.*)|*.*";
                    sfd_rec.FilterIndex = 1;
                    sfd_rec.RestoreDirectory = true;
                    sfd_rec.FileName = fileName;
                    if (sfd_rec.ShowDialog() == DialogResult.OK)
                    {
                        string fullpath = sfd_rec.FileName;
                        MessageBox.Show(fullpath);
                        if (fullpath != "")
                        {
                            //FileStream字节流写入
                            fsRec = new FileStream(fullpath, FileMode.Create, FileAccess.Write, FileShare.None);
                            byte[] mecho = { (int)ComTag.DataReceivedTag };
                            serialPort1.Write(mecho, 0, 1);
                            previousTag = (int)ComTag.FileNameTag;
                            return;
                        }
                    }

                }
                MessageBox.Show("取消保存", "保存结果");
                byte[] echo = { (int)ComTag.CancelTag };
                serialPort1.Write(echo, 0, 1);
                previousTag = (int)ComTag.NormalTag;
                return;
            }));
            
        }
        //取消文件传输信息处理
        private void cancelFileSend()
        {
            MessageBox.Show("中止文件发送");
            fsSend.Dispose();
            previousTag = (int)ComTag.NormalTag;
            Invoke((EventHandler)(delegate
            {
                pgb_file.Value = 0;
                pgb_file.PerformStep();
            }));
        }
        private void cancelFileRec()
        {
            MessageBox.Show("中止文件接收");
            fsRec.Dispose();
            filePosition = 0;
            previousTag = (int)ComTag.NormalTag;
            Invoke((EventHandler)(delegate
            {
                pgb_file.Value = 0;
                pgb_file.PerformStep();
            }));
        }

        private void btn_fileSelect_Click(object sender, EventArgs e)
        {
            ofd_send.RestoreDirectory = true;
            if (ofd_send.ShowDialog() == DialogResult.OK)
            {
                string fullpath = ofd_send.FileName;
                Console.WriteLine(fullpath);
                tbx_sendFIle.Text = fullpath;
            }
            else
            {
                MessageBox.Show("取消读取", "保存结果");
                return;
            }
        }
        //传输数据块
        private void dataTransfer()
        {
            if (fsSend != null&fsSend.CanRead)
            {
                Invoke((EventHandler)(delegate
                {
                    pgb_file.Value = (int)(100 * fsSend.Position / fsSend.Length);
                    pgb_file.PerformStep();
                }));
                byte[] temp;
                byte[] send;
                if (fsSend.Length-fsSend.Position >= 2048)
                {
                    temp= new byte[2047];
                    send = new byte[2048];
                    send[0] = (int)ComTag.DataSendTag;
                    previousTag = (int)ComTag.DataSendTag;
                    fsSend.Read(temp, 0, temp.Length);
                }
                else {
                    temp = new byte[fsSend.Length-fsSend.Position];
                    send = new byte[temp.Length + 1];
                    send[0] = (int)ComTag.FinalDataSendTag;
                    previousTag = (int)ComTag.FinalDataSendTag;
                    fsSend.Read(temp, 0, temp.Length);
                    fsSend.Dispose();
                    Console.WriteLine("发送文件为空？"+fsSend == null);
                }
                for (int i = 0; i < temp.Length; i++) send[i + 1] = temp[i];
                serialPort1.Write(send, 0, send.Length);
            }
        }

        //保存数据块
        private void saveData()
        {
            if (fsRec != null && fsRec.CanWrite)
            {
                byte[] buffer = new byte[serialPort1.BytesToRead];
                serialPort1.Read(buffer, 0, buffer.Length);
                fsRec.Write(buffer, 0, buffer.Length);
                fsRec.Flush();
                filePosition += buffer.Length;
                Invoke((EventHandler)(delegate
                {
                    pgb_file.Value = (int)(100 * filePosition / fileLength);
                    pgb_file.PerformStep();
                }));
            }
        }
        private void btn_clearSend_Click(object sender, EventArgs e)
        {
            tbx_send.Clear();
        }

        private void btn_fileSend_Click(object sender, EventArgs e)
        {
            if (fsSend==null||!fsSend.CanRead)
            {
                cancelFlag = false;
                if (tbx_sendFIle.Text.Trim() == "") return;
                try
                {
                    fiSend = new FileInfo(tbx_sendFIle.Text);
                    fsSend = new FileStream(tbx_sendFIle.Text, FileMode.Open, FileAccess.Read, FileShare.None);
                    byte[] temp = Encoding.UTF8.GetBytes(fiSend.Name + Environment.NewLine + fsSend.Length.ToString());
                    byte[] send = new byte[temp.Length + 1];
                    send[0] = (int)ComTag.FileNameTag;
                    for (int i = 0; i < temp.Length; i++) send[i + 1] = temp[i];
                    serialPort1.Write(send, 0, send.Length);
                    previousTag = (int)ComTag.DataSendTag;
                    btn_fileSend.ForeColor = Color.Red;
                    btn_fileSend.Text = "中止发送";
                }
                catch
                {
                    MessageBox.Show("串口未打开！");
                    fsSend.Dispose();
                    return;
                }
                
            }
            else
            {
                cancelFlag = true;
                btn_fileSend.ForeColor = Color.Black;
                btn_fileSend.Text = "发送文件";
            }
        }
    }
}
