namespace SerialPortAssistant
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pgb_file = new System.Windows.Forms.ProgressBar();
            this.btn_openPort = new System.Windows.Forms.Button();
            this.btn_detect = new System.Windows.Forms.Button();
            this.rbn_Hex = new System.Windows.Forms.RadioButton();
            this.rbn_Char = new System.Windows.Forms.RadioButton();
            this.cbx_StopBits = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_DataBits = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_BaudRate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_Paritv = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_COMport = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_clearRec = new System.Windows.Forms.Button();
            this.btn_saveFile = new System.Windows.Forms.Button();
            this.tbx_Rec = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_clearSend = new System.Windows.Forms.Button();
            this.tbx_send = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.sfd_rec = new System.Windows.Forms.SaveFileDialog();
            this.ofd_send = new System.Windows.Forms.OpenFileDialog();
            this.gbx_file = new System.Windows.Forms.GroupBox();
            this.btn_fileSend = new System.Windows.Forms.Button();
            this.btn_fileSelect = new System.Windows.Forms.Button();
            this.tbx_sendFIle = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbx_file.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pgb_file);
            this.groupBox1.Controls.Add(this.btn_openPort);
            this.groupBox1.Controls.Add(this.btn_detect);
            this.groupBox1.Controls.Add(this.rbn_Hex);
            this.groupBox1.Controls.Add(this.rbn_Char);
            this.groupBox1.Controls.Add(this.cbx_StopBits);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbx_DataBits);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbx_BaudRate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbx_Paritv);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbx_COMport);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(780, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口设置";
            // 
            // pgb_file
            // 
            this.pgb_file.Location = new System.Drawing.Point(664, 102);
            this.pgb_file.Name = "pgb_file";
            this.pgb_file.Size = new System.Drawing.Size(90, 23);
            this.pgb_file.Step = 0;
            this.pgb_file.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgb_file.TabIndex = 17;
            // 
            // btn_openPort
            // 
            this.btn_openPort.BackColor = System.Drawing.SystemColors.Control;
            this.btn_openPort.Location = new System.Drawing.Point(664, 67);
            this.btn_openPort.Name = "btn_openPort";
            this.btn_openPort.Size = new System.Drawing.Size(90, 23);
            this.btn_openPort.TabIndex = 13;
            this.btn_openPort.Text = "打开串口";
            this.btn_openPort.UseVisualStyleBackColor = false;
            this.btn_openPort.Click += new System.EventHandler(this.btn_openPort_Click);
            // 
            // btn_detect
            // 
            this.btn_detect.BackColor = System.Drawing.SystemColors.Control;
            this.btn_detect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_detect.Location = new System.Drawing.Point(664, 32);
            this.btn_detect.Name = "btn_detect";
            this.btn_detect.Size = new System.Drawing.Size(90, 23);
            this.btn_detect.TabIndex = 12;
            this.btn_detect.Text = "串口检测";
            this.btn_detect.UseVisualStyleBackColor = false;
            this.btn_detect.Click += new System.EventHandler(this.btn_detect_Click);
            // 
            // rbn_Hex
            // 
            this.rbn_Hex.AutoSize = true;
            this.rbn_Hex.Location = new System.Drawing.Point(420, 106);
            this.rbn_Hex.Name = "rbn_Hex";
            this.rbn_Hex.Size = new System.Drawing.Size(79, 19);
            this.rbn_Hex.TabIndex = 11;
            this.rbn_Hex.Text = "HEX显示";
            this.rbn_Hex.UseVisualStyleBackColor = true;
            this.rbn_Hex.CheckedChanged += new System.EventHandler(this.rbn_Hex_CheckedChanged);
            // 
            // rbn_Char
            // 
            this.rbn_Char.AutoSize = true;
            this.rbn_Char.Checked = true;
            this.rbn_Char.Location = new System.Drawing.Point(323, 106);
            this.rbn_Char.Name = "rbn_Char";
            this.rbn_Char.Size = new System.Drawing.Size(85, 19);
            this.rbn_Char.TabIndex = 10;
            this.rbn_Char.TabStop = true;
            this.rbn_Char.Text = "字符显示";
            this.rbn_Char.UseVisualStyleBackColor = true;
            this.rbn_Char.CheckedChanged += new System.EventHandler(this.rbn_Char_CheckedChanged);
            // 
            // cbx_StopBits
            // 
            this.cbx_StopBits.FormattingEnabled = true;
            this.cbx_StopBits.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.cbx_StopBits.Location = new System.Drawing.Point(120, 102);
            this.cbx_StopBits.Name = "cbx_StopBits";
            this.cbx_StopBits.Size = new System.Drawing.Size(120, 23);
            this.cbx_StopBits.TabIndex = 9;
            this.cbx_StopBits.Text = "1";
            this.cbx_StopBits.SelectedIndexChanged += new System.EventHandler(this.cbx_StopBits_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(20, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "停止位：";
            // 
            // cbx_DataBits
            // 
            this.cbx_DataBits.FormattingEnabled = true;
            this.cbx_DataBits.Items.AddRange(new object[] {
            "8",
            "7",
            "6",
            "5"});
            this.cbx_DataBits.Location = new System.Drawing.Point(420, 67);
            this.cbx_DataBits.Name = "cbx_DataBits";
            this.cbx_DataBits.Size = new System.Drawing.Size(120, 23);
            this.cbx_DataBits.TabIndex = 7;
            this.cbx_DataBits.Text = "8";
            this.cbx_DataBits.SelectedIndexChanged += new System.EventHandler(this.cbx_DataBits_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(320, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "数据位：";
            // 
            // cbx_BaudRate
            // 
            this.cbx_BaudRate.FormattingEnabled = true;
            this.cbx_BaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.cbx_BaudRate.Location = new System.Drawing.Point(120, 67);
            this.cbx_BaudRate.Name = "cbx_BaudRate";
            this.cbx_BaudRate.Size = new System.Drawing.Size(120, 23);
            this.cbx_BaudRate.TabIndex = 5;
            this.cbx_BaudRate.Text = "9600";
            this.cbx_BaudRate.SelectedIndexChanged += new System.EventHandler(this.cbx_BaudRate_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(20, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "波特率：";
            // 
            // cbx_Paritv
            // 
            this.cbx_Paritv.FormattingEnabled = true;
            this.cbx_Paritv.Items.AddRange(new object[] {
            "Odd",
            "Even",
            "Mark",
            "Space",
            "None"});
            this.cbx_Paritv.Location = new System.Drawing.Point(420, 32);
            this.cbx_Paritv.Name = "cbx_Paritv";
            this.cbx_Paritv.Size = new System.Drawing.Size(120, 23);
            this.cbx_Paritv.TabIndex = 3;
            this.cbx_Paritv.Text = "None";
            this.cbx_Paritv.SelectedIndexChanged += new System.EventHandler(this.cbx_Paritv_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(320, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "奇偶校验：";
            // 
            // cbx_COMport
            // 
            this.cbx_COMport.FormattingEnabled = true;
            this.cbx_COMport.Location = new System.Drawing.Point(120, 32);
            this.cbx_COMport.Name = "cbx_COMport";
            this.cbx_COMport.Size = new System.Drawing.Size(120, 23);
            this.cbx_COMport.TabIndex = 1;
            this.cbx_COMport.Text = "COM1";
            this.cbx_COMport.SelectedIndexChanged += new System.EventHandler(this.cbx_COMport_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "串口号：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_clearRec);
            this.groupBox2.Controls.Add(this.btn_saveFile);
            this.groupBox2.Controls.Add(this.tbx_Rec);
            this.groupBox2.Location = new System.Drawing.Point(10, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(780, 200);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据接收";
            // 
            // btn_clearRec
            // 
            this.btn_clearRec.BackColor = System.Drawing.SystemColors.Control;
            this.btn_clearRec.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_clearRec.Location = new System.Drawing.Point(664, 78);
            this.btn_clearRec.Name = "btn_clearRec";
            this.btn_clearRec.Size = new System.Drawing.Size(90, 23);
            this.btn_clearRec.TabIndex = 17;
            this.btn_clearRec.Text = "清空数据";
            this.btn_clearRec.UseVisualStyleBackColor = false;
            this.btn_clearRec.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_saveFile
            // 
            this.btn_saveFile.BackColor = System.Drawing.SystemColors.Control;
            this.btn_saveFile.Location = new System.Drawing.Point(664, 123);
            this.btn_saveFile.Name = "btn_saveFile";
            this.btn_saveFile.Size = new System.Drawing.Size(90, 23);
            this.btn_saveFile.TabIndex = 16;
            this.btn_saveFile.Text = "保存文件";
            this.btn_saveFile.UseVisualStyleBackColor = false;
            this.btn_saveFile.Click += new System.EventHandler(this.btn_saveFile_Click);
            // 
            // tbx_Rec
            // 
            this.tbx_Rec.Location = new System.Drawing.Point(20, 40);
            this.tbx_Rec.Multiline = true;
            this.tbx_Rec.Name = "tbx_Rec";
            this.tbx_Rec.ReadOnly = true;
            this.tbx_Rec.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_Rec.Size = new System.Drawing.Size(600, 140);
            this.tbx_Rec.TabIndex = 1;
            this.tbx_Rec.Text = "你好世界！\r\n橘子最漂亮，橘子最可爱，最喜欢橘子了！";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_send);
            this.groupBox3.Controls.Add(this.btn_clearSend);
            this.groupBox3.Controls.Add(this.tbx_send);
            this.groupBox3.Location = new System.Drawing.Point(10, 380);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(780, 150);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "数据发送";
            // 
            // btn_send
            // 
            this.btn_send.BackColor = System.Drawing.SystemColors.Control;
            this.btn_send.Location = new System.Drawing.Point(664, 78);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(90, 23);
            this.btn_send.TabIndex = 15;
            this.btn_send.Text = "发送数据";
            this.btn_send.UseVisualStyleBackColor = false;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_clearSend
            // 
            this.btn_clearSend.BackColor = System.Drawing.SystemColors.Control;
            this.btn_clearSend.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_clearSend.Location = new System.Drawing.Point(664, 43);
            this.btn_clearSend.Name = "btn_clearSend";
            this.btn_clearSend.Size = new System.Drawing.Size(90, 23);
            this.btn_clearSend.TabIndex = 14;
            this.btn_clearSend.Text = "清空数据";
            this.btn_clearSend.UseVisualStyleBackColor = false;
            this.btn_clearSend.Click += new System.EventHandler(this.btn_clearSend_Click);
            // 
            // tbx_send
            // 
            this.tbx_send.Location = new System.Drawing.Point(20, 30);
            this.tbx_send.Multiline = true;
            this.tbx_send.Name = "tbx_send";
            this.tbx_send.Size = new System.Drawing.Size(600, 100);
            this.tbx_send.TabIndex = 0;
            // 
            // serialPort1
            // 
            this.serialPort1.Parity = System.IO.Ports.Parity.Odd;
            this.serialPort1.StopBits = System.IO.Ports.StopBits.Two;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // ofd_send
            // 
            this.ofd_send.FileName = "openFileDialog1";
            // 
            // gbx_file
            // 
            this.gbx_file.Controls.Add(this.btn_fileSend);
            this.gbx_file.Controls.Add(this.btn_fileSelect);
            this.gbx_file.Controls.Add(this.tbx_sendFIle);
            this.gbx_file.Location = new System.Drawing.Point(10, 540);
            this.gbx_file.Name = "gbx_file";
            this.gbx_file.Size = new System.Drawing.Size(780, 50);
            this.gbx_file.TabIndex = 16;
            this.gbx_file.TabStop = false;
            this.gbx_file.Text = "文件发送";
            // 
            // btn_fileSend
            // 
            this.btn_fileSend.BackColor = System.Drawing.SystemColors.Control;
            this.btn_fileSend.Location = new System.Drawing.Point(664, 20);
            this.btn_fileSend.Name = "btn_fileSend";
            this.btn_fileSend.Size = new System.Drawing.Size(90, 25);
            this.btn_fileSend.TabIndex = 16;
            this.btn_fileSend.Text = "发送文件";
            this.btn_fileSend.UseVisualStyleBackColor = false;
            this.btn_fileSend.Click += new System.EventHandler(this.btn_fileSend_Click);
            // 
            // btn_fileSelect
            // 
            this.btn_fileSelect.Location = new System.Drawing.Point(570, 20);
            this.btn_fileSelect.Name = "btn_fileSelect";
            this.btn_fileSelect.Size = new System.Drawing.Size(50, 25);
            this.btn_fileSelect.TabIndex = 1;
            this.btn_fileSelect.Text = "...";
            this.btn_fileSelect.UseVisualStyleBackColor = true;
            this.btn_fileSelect.Click += new System.EventHandler(this.btn_fileSelect_Click);
            // 
            // tbx_sendFIle
            // 
            this.tbx_sendFIle.Location = new System.Drawing.Point(20, 20);
            this.tbx_sendFIle.Name = "tbx_sendFIle";
            this.tbx_sendFIle.Size = new System.Drawing.Size(540, 25);
            this.tbx_sendFIle.TabIndex = 0;
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.gbx_file);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "串口调试程序";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbx_file.ResumeLayout(false);
            this.gbx_file.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbn_Hex;
        private System.Windows.Forms.RadioButton rbn_Char;
        private System.Windows.Forms.ComboBox cbx_StopBits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbx_DataBits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbx_BaudRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_Paritv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_COMport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_openPort;
        private System.Windows.Forms.Button btn_detect;
        private System.Windows.Forms.TextBox tbx_Rec;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btn_clearSend;
        private System.Windows.Forms.TextBox tbx_send;
        private System.Windows.Forms.Button btn_saveFile;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.SaveFileDialog sfd_rec;
        private System.Windows.Forms.Button btn_clearRec;
        private System.Windows.Forms.OpenFileDialog ofd_send;
        private System.Windows.Forms.GroupBox gbx_file;
        private System.Windows.Forms.Button btn_fileSend;
        private System.Windows.Forms.Button btn_fileSelect;
        private System.Windows.Forms.TextBox tbx_sendFIle;
        private System.Windows.Forms.ProgressBar pgb_file;
    }
}

