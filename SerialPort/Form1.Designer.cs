namespace 袁朝阳
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCOM = new System.Windows.Forms.ComboBox();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxParity = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxDataBit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxStopBits = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBoxRecieve = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button_closeOrOpenSerial = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.视图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.单极性ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.温度传感器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.其他ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.双极性ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.温度传感器ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.其他ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.反馈ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.contextMenuStripSavePicture = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.保存图像ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.checkBoxHex = new System.Windows.Forms.CheckBox();
            this.pictureBoxFileOpen = new System.Windows.Forms.PictureBox();
            this.textBoxADC = new System.Windows.Forms.TextBox();
            this.contextMenuStripSaveTxt = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.保存数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxSingleSend = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.contextMenuStripSavePicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFileOpen)).BeginInit();
            this.contextMenuStripSaveTxt.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM5";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(709, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "发送";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Send_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBoxSend
            // 
            this.textBoxSend.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.textBoxSend.Location = new System.Drawing.Point(389, 28);
            this.textBoxSend.MinimumSize = new System.Drawing.Size(4, 25);
            this.textBoxSend.Multiline = true;
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSend.Size = new System.Drawing.Size(370, 261);
            this.textBoxSend.TabIndex = 3;
            this.textBoxSend.Text = "Data Sender";
            this.textBoxSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSend_KeyDown);
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Location = new System.Drawing.Point(603, 293);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(50, 50);
            this.buttonClearAll.TabIndex = 5;
            this.buttonClearAll.Text = "清空";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(8, 295);
            this.label1.MinimumSize = new System.Drawing.Size(0, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "端口号";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxCOM
            // 
            this.comboBoxCOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCOM.FormattingEnabled = true;
            this.comboBoxCOM.Location = new System.Drawing.Point(55, 295);
            this.comboBoxCOM.Name = "comboBoxCOM";
            this.comboBoxCOM.Size = new System.Drawing.Size(121, 20);
            this.comboBoxCOM.TabIndex = 7;
            this.comboBoxCOM.SelectedIndexChanged += new System.EventHandler(this.comboBoxCOM_SelectedIndexChanged);
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Items.AddRange(new object[] {
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200",
            "128000"});
            this.comboBoxBaudRate.Location = new System.Drawing.Point(55, 321);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(121, 20);
            this.comboBoxBaudRate.TabIndex = 9;
            this.comboBoxBaudRate.SelectedIndexChanged += new System.EventHandler(this.comboBoxBaudRate_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(8, 321);
            this.label2.MinimumSize = new System.Drawing.Size(0, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "波特率";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxParity
            // 
            this.comboBoxParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxParity.FormattingEnabled = true;
            this.comboBoxParity.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxParity.Location = new System.Drawing.Point(55, 347);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(121, 20);
            this.comboBoxParity.TabIndex = 11;
            this.comboBoxParity.SelectedIndexChanged += new System.EventHandler(this.comboBoxParity_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(8, 347);
            this.label3.MinimumSize = new System.Drawing.Size(0, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "校验位";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxDataBit
            // 
            this.comboBoxDataBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDataBit.FormattingEnabled = true;
            this.comboBoxDataBit.Items.AddRange(new object[] {
            "7",
            "8"});
            this.comboBoxDataBit.Location = new System.Drawing.Point(55, 373);
            this.comboBoxDataBit.Name = "comboBoxDataBit";
            this.comboBoxDataBit.Size = new System.Drawing.Size(121, 20);
            this.comboBoxDataBit.TabIndex = 13;
            this.comboBoxDataBit.SelectedIndexChanged += new System.EventHandler(this.comboBoxDataBit_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(8, 373);
            this.label4.MinimumSize = new System.Drawing.Size(0, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "数据位";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxStopBits
            // 
            this.comboBoxStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStopBits.FormattingEnabled = true;
            this.comboBoxStopBits.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "1.5"});
            this.comboBoxStopBits.Location = new System.Drawing.Point(55, 399);
            this.comboBoxStopBits.Name = "comboBoxStopBits";
            this.comboBoxStopBits.Size = new System.Drawing.Size(121, 20);
            this.comboBoxStopBits.TabIndex = 15;
            this.comboBoxStopBits.SelectedIndexChanged += new System.EventHandler(this.comboBoxStopBits_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(8, 399);
            this.label5.MinimumSize = new System.Drawing.Size(0, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "中止位";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBoxRecieve
            // 
            this.richTextBoxRecieve.Font = new System.Drawing.Font("Consolas", 10F);
            this.richTextBoxRecieve.HideSelection = false;
            this.richTextBoxRecieve.Location = new System.Drawing.Point(12, 28);
            this.richTextBoxRecieve.Name = "richTextBoxRecieve";
            this.richTextBoxRecieve.ReadOnly = true;
            this.richTextBoxRecieve.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxRecieve.Size = new System.Drawing.Size(371, 261);
            this.richTextBoxRecieve.TabIndex = 16;
            this.richTextBoxRecieve.Text = "Data Receiver\n";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(442, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 17;
            this.button2.Text = "1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_send1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(496, 293);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 18;
            this.button3.Text = "2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_send2_Click);
            // 
            // button_closeOrOpenSerial
            // 
            this.button_closeOrOpenSerial.Location = new System.Drawing.Point(550, 293);
            this.button_closeOrOpenSerial.Name = "button_closeOrOpenSerial";
            this.button_closeOrOpenSerial.Size = new System.Drawing.Size(50, 50);
            this.button_closeOrOpenSerial.TabIndex = 19;
            this.button_closeOrOpenSerial.Text = "关闭\r\n\r\n串口\r\n";
            this.button_closeOrOpenSerial.UseVisualStyleBackColor = true;
            this.button_closeOrOpenSerial.Click += new System.EventHandler(this.button_closeOrOpenSerial_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.视图ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(765, 25);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 视图ToolStripMenuItem
            // 
            this.视图ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.单极性ToolStripMenuItem1,
            this.双极性ToolStripMenuItem1});
            this.视图ToolStripMenuItem.Name = "视图ToolStripMenuItem";
            this.视图ToolStripMenuItem.Size = new System.Drawing.Size(69, 21);
            this.视图ToolStripMenuItem.Text = "ADC视图";
            // 
            // 单极性ToolStripMenuItem1
            // 
            this.单极性ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.温度传感器ToolStripMenuItem,
            this.其他ToolStripMenuItem2});
            this.单极性ToolStripMenuItem1.Name = "单极性ToolStripMenuItem1";
            this.单极性ToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.单极性ToolStripMenuItem1.Text = "单极性";
            // 
            // 温度传感器ToolStripMenuItem
            // 
            this.温度传感器ToolStripMenuItem.Name = "温度传感器ToolStripMenuItem";
            this.温度传感器ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.温度传感器ToolStripMenuItem.Text = "温度传感器";
            this.温度传感器ToolStripMenuItem.Click += new System.EventHandler(this.内部温度_Unipolar_ToolStripMenuItem_Click);
            // 
            // 其他ToolStripMenuItem2
            // 
            this.其他ToolStripMenuItem2.Name = "其他ToolStripMenuItem2";
            this.其他ToolStripMenuItem2.Size = new System.Drawing.Size(136, 22);
            this.其他ToolStripMenuItem2.Text = "其他";
            // 
            // 双极性ToolStripMenuItem1
            // 
            this.双极性ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.温度传感器ToolStripMenuItem1,
            this.其他ToolStripMenuItem3});
            this.双极性ToolStripMenuItem1.Name = "双极性ToolStripMenuItem1";
            this.双极性ToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.双极性ToolStripMenuItem1.Text = "双极性";
            // 
            // 温度传感器ToolStripMenuItem1
            // 
            this.温度传感器ToolStripMenuItem1.Name = "温度传感器ToolStripMenuItem1";
            this.温度传感器ToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.温度传感器ToolStripMenuItem1.Text = "温度传感器";
            this.温度传感器ToolStripMenuItem1.Click += new System.EventHandler(this.内部温度_Bipolar_ToolStripMenuItem1_Click);
            // 
            // 其他ToolStripMenuItem3
            // 
            this.其他ToolStripMenuItem3.Name = "其他ToolStripMenuItem3";
            this.其他ToolStripMenuItem3.Size = new System.Drawing.Size(136, 22);
            this.其他ToolStripMenuItem3.Text = "其他";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看帮助ToolStripMenuItem,
            this.反馈ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 查看帮助ToolStripMenuItem
            // 
            //this.查看帮助ToolStripMenuItem.Image = global::SerialPort.Properties.Resources.helpp;
            this.查看帮助ToolStripMenuItem.Name = "查看帮助ToolStripMenuItem";
            this.查看帮助ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.查看帮助ToolStripMenuItem.Text = "查看帮助";
            this.查看帮助ToolStripMenuItem.Click += new System.EventHandler(this.查看帮助ToolStripMenuItem_Click);
            // 
            // 反馈ToolStripMenuItem
            // 
            this.反馈ToolStripMenuItem.Name = "反馈ToolStripMenuItem";
            this.反馈ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.反馈ToolStripMenuItem.Text = "发送反馈";
            this.反馈ToolStripMenuItem.Click += new System.EventHandler(this.反馈ToolStripMenuItem_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.ContextMenuStrip = this.contextMenuStripSavePicture;
            legend1.Name = "Temperature";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(765, 28);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Temperature";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(383, 300);
            this.chart1.TabIndex = 21;
            this.chart1.Text = "chart1";
            // 
            // contextMenuStripSavePicture
            // 
            this.contextMenuStripSavePicture.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存图像ToolStripMenuItem});
            this.contextMenuStripSavePicture.Name = "contextMenuStrip1";
            this.contextMenuStripSavePicture.Size = new System.Drawing.Size(125, 26);
            // 
            // 保存图像ToolStripMenuItem
            // 
            this.保存图像ToolStripMenuItem.Name = "保存图像ToolStripMenuItem";
            this.保存图像ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.保存图像ToolStripMenuItem.Text = "保存图像";
            this.保存图像ToolStripMenuItem.Click += new System.EventHandler(this.保存图像ToolStripMenuItem_Click);
            // 
            // buttonRestart
            // 
            this.buttonRestart.Location = new System.Drawing.Point(389, 293);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(50, 50);
            this.buttonRestart.TabIndex = 22;
            this.buttonRestart.Text = "重启";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // checkBoxHex
            // 
            this.checkBoxHex.Font = new System.Drawing.Font("宋体", 10F);
            this.checkBoxHex.Location = new System.Drawing.Point(204, 299);
            this.checkBoxHex.Name = "checkBoxHex";
            this.checkBoxHex.Size = new System.Drawing.Size(75, 18);
            this.checkBoxHex.TabIndex = 0;
            this.checkBoxHex.Text = "Hex显示";
            this.checkBoxHex.UseVisualStyleBackColor = true;
            // 
            // pictureBoxFileOpen
            // 
            this.pictureBoxFileOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxFileOpen.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFileOpen.Image")));
            this.pictureBoxFileOpen.Location = new System.Drawing.Point(656, 293);
            this.pictureBoxFileOpen.Name = "pictureBoxFileOpen";
            this.pictureBoxFileOpen.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxFileOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFileOpen.TabIndex = 4;
            this.pictureBoxFileOpen.TabStop = false;
            this.pictureBoxFileOpen.Click += new System.EventHandler(this.pictureBoxFileOpen_Click);
            // 
            // textBoxADC
            // 
            this.textBoxADC.ContextMenuStrip = this.contextMenuStripSaveTxt;
            this.textBoxADC.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.textBoxADC.Location = new System.Drawing.Point(765, 334);
            this.textBoxADC.MinimumSize = new System.Drawing.Size(4, 25);
            this.textBoxADC.Multiline = true;
            this.textBoxADC.Name = "textBoxADC";
            this.textBoxADC.ReadOnly = true;
            this.textBoxADC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxADC.Size = new System.Drawing.Size(383, 82);
            this.textBoxADC.TabIndex = 24;
            // 
            // contextMenuStripSaveTxt
            // 
            this.contextMenuStripSaveTxt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存数据ToolStripMenuItem});
            this.contextMenuStripSaveTxt.Name = "contextMenuStripSaveTxt";
            this.contextMenuStripSaveTxt.Size = new System.Drawing.Size(125, 26);
            // 
            // 保存数据ToolStripMenuItem
            // 
            this.保存数据ToolStripMenuItem.Name = "保存数据ToolStripMenuItem";
            this.保存数据ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.保存数据ToolStripMenuItem.Text = "保存数据";
            this.保存数据ToolStripMenuItem.Click += new System.EventHandler(this.保存数据ToolStripMenuItem_Click);
            // 
            // checkBoxSingleSend
            // 
            this.checkBoxSingleSend.Checked = true;
            this.checkBoxSingleSend.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSingleSend.Font = new System.Drawing.Font("宋体", 10F);
            this.checkBoxSingleSend.Location = new System.Drawing.Point(204, 322);
            this.checkBoxSingleSend.Name = "checkBoxSingleSend";
            this.checkBoxSingleSend.Size = new System.Drawing.Size(112, 18);
            this.checkBoxSingleSend.TabIndex = 26;
            this.checkBoxSingleSend.Text = "单字节发送";
            this.checkBoxSingleSend.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 426);
            this.Controls.Add(this.checkBoxSingleSend);
            this.Controls.Add(this.textBoxADC);
            this.Controls.Add(this.checkBoxHex);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button_closeOrOpenSerial);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.richTextBoxRecieve);
            this.Controls.Add(this.comboBoxStopBits);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxDataBit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxParity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxBaudRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxCOM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonClearAll);
            this.Controls.Add(this.pictureBoxFileOpen);
            this.Controls.Add(this.textBoxSend);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "袁朝阳 - serialPort";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.contextMenuStripSavePicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFileOpen)).EndInit();
            this.contextMenuStripSaveTxt.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.PictureBox pictureBoxFileOpen;
        private System.Windows.Forms.Button buttonClearAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCOM;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxParity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxDataBit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxStopBits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBoxRecieve;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_closeOrOpenSerial;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 视图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 反馈ToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.CheckBox checkBoxHex;
        private System.Windows.Forms.ToolStripMenuItem 单极性ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 温度传感器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 其他ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 双极性ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 温度传感器ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 其他ToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 查看帮助ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripSavePicture;
        private System.Windows.Forms.ToolStripMenuItem 保存图像ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxADC;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripSaveTxt;
        private System.Windows.Forms.ToolStripMenuItem 保存数据ToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxSingleSend;
    }
}

