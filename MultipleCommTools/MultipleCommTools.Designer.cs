namespace MultipleCommTools
{
    partial class MultipleCommTools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultipleCommTools));
            this.MultipletabCtrlPage = new System.Windows.Forms.TabControl();
            this.tabPageSerialPort = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStripSerialPort = new System.Windows.Forms.StatusStrip();
            this.contextMenuStripStatus = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearRxTxCntToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabelPortStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelRxCnt = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTxCnt = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelCurTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.PortSendtabControl = new System.Windows.Forms.TabControl();
            this.PortTxBasetabPage = new System.Windows.Forms.TabPage();
            this.groupBoxPortTxParam = new System.Windows.Forms.GroupBox();
            this.btnCalTool = new System.Windows.Forms.Button();
            this.checkBoxTxRxData = new System.Windows.Forms.CheckBox();
            this.textBoxSerialportTxTick = new System.Windows.Forms.TextBox();
            this.checkBoxSerialportAutoTx = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxSerialportTxedEmpty = new System.Windows.Forms.CheckBox();
            this.textBoxPortTxData = new System.Windows.Forms.TextBox();
            this.contextMenuStripTxData = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hexToASCIIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calCheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modbusRTUCRCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calXORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calCRCSumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calCRCSumWORDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSerialportTxFile = new System.Windows.Forms.Button();
            this.btnSerialportTxCtrl = new System.Windows.Forms.Button();
            this.btnSerialportBrowerFile = new System.Windows.Forms.Button();
            this.textBoxSerialPortFilePath = new System.Windows.Forms.TextBox();
            this.PortTxPulsetabPage = new System.Windows.Forms.TabPage();
            this.PortToolsArytabPage = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxPortRxParam = new System.Windows.Forms.GroupBox();
            this.checkBoxSerialportRxHexFormat = new System.Windows.Forms.CheckBox();
            this.supperTercheckBox = new System.Windows.Forms.CheckBox();
            this.checkBoxSerialportRxAppendLine = new System.Windows.Forms.CheckBox();
            this.checkBoxSerialRxShowCtrl = new System.Windows.Forms.CheckBox();
            this.checkBoxSerialportShowRxTime = new System.Windows.Forms.CheckBox();
            this.textBoxPortRxData = new System.Windows.Forms.TextBox();
            this.contextMenuStripRx = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemClearRX = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSaveRxData = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxPortCtrlParam = new System.Windows.Forms.GroupBox();
            this.picBoxClosePort = new System.Windows.Forms.PictureBox();
            this.labelStopbit = new System.Windows.Forms.Label();
            this.picBoxOpenPort = new System.Windows.Forms.PictureBox();
            this.labelPortName = new System.Windows.Forms.Label();
            this.labelDatabit = new System.Windows.Forms.Label();
            this.btnCtrlSerialport = new System.Windows.Forms.Button();
            this.labelParity = new System.Windows.Forms.Label();
            this.cbBoxPort = new System.Windows.Forms.ComboBox();
            this.labelBaund = new System.Windows.Forms.Label();
            this.cbBoxbaundRate = new System.Windows.Forms.ComboBox();
            this.cbBoxParity = new System.Windows.Forms.ComboBox();
            this.cbBoxStopbits = new System.Windows.Forms.ComboBox();
            this.cbBoxDatabits = new System.Windows.Forms.ComboBox();
            this.NetToolstabPage = new System.Windows.Forms.TabPage();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SerialToolAutoTxTimer = new System.Windows.Forms.Timer(this.components);
            this.TimerShowTick = new System.Windows.Forms.Timer(this.components);
            this.clearTxDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MultipletabCtrlPage.SuspendLayout();
            this.tabPageSerialPort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStripSerialPort.SuspendLayout();
            this.contextMenuStripStatus.SuspendLayout();
            this.PortSendtabControl.SuspendLayout();
            this.PortTxBasetabPage.SuspendLayout();
            this.groupBoxPortTxParam.SuspendLayout();
            this.contextMenuStripTxData.SuspendLayout();
            this.PortToolsArytabPage.SuspendLayout();
            this.groupBoxPortRxParam.SuspendLayout();
            this.contextMenuStripRx.SuspendLayout();
            this.groupBoxPortCtrlParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxClosePort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOpenPort)).BeginInit();
            this.SuspendLayout();
            // 
            // MultipletabCtrlPage
            // 
            this.MultipletabCtrlPage.Controls.Add(this.tabPageSerialPort);
            this.MultipletabCtrlPage.Controls.Add(this.NetToolstabPage);
            this.MultipletabCtrlPage.Location = new System.Drawing.Point(-5, -1);
            this.MultipletabCtrlPage.Name = "MultipletabCtrlPage";
            this.MultipletabCtrlPage.SelectedIndex = 0;
            this.MultipletabCtrlPage.Size = new System.Drawing.Size(714, 566);
            this.MultipletabCtrlPage.TabIndex = 0;
            // 
            // tabPageSerialPort
            // 
            this.tabPageSerialPort.Controls.Add(this.pictureBox1);
            this.tabPageSerialPort.Controls.Add(this.statusStripSerialPort);
            this.tabPageSerialPort.Controls.Add(this.PortSendtabControl);
            this.tabPageSerialPort.Controls.Add(this.groupBoxPortRxParam);
            this.tabPageSerialPort.Controls.Add(this.textBoxPortRxData);
            this.tabPageSerialPort.Controls.Add(this.groupBoxPortCtrlParam);
            this.tabPageSerialPort.Location = new System.Drawing.Point(4, 22);
            this.tabPageSerialPort.Name = "tabPageSerialPort";
            this.tabPageSerialPort.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSerialPort.Size = new System.Drawing.Size(706, 540);
            this.tabPageSerialPort.TabIndex = 1;
            this.tabPageSerialPort.Text = "串口调试助手";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MultipleCommTools.Properties.Resources.Avatar;
            this.pictureBox1.Location = new System.Drawing.Point(552, 345);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // statusStripSerialPort
            // 
            this.statusStripSerialPort.ContextMenuStrip = this.contextMenuStripStatus;
            this.statusStripSerialPort.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelPortStatus,
            this.toolStripStatusLabelRxCnt,
            this.toolStripStatusLabelTxCnt,
            this.toolStripStatusLabelCurTime});
            this.statusStripSerialPort.Location = new System.Drawing.Point(3, 511);
            this.statusStripSerialPort.Name = "statusStripSerialPort";
            this.statusStripSerialPort.Size = new System.Drawing.Size(700, 26);
            this.statusStripSerialPort.TabIndex = 13;
            // 
            // contextMenuStripStatus
            // 
            this.contextMenuStripStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearRxTxCntToolStripMenuItem});
            this.contextMenuStripStatus.Name = "contextMenuStripStatus";
            this.contextMenuStripStatus.Size = new System.Drawing.Size(125, 26);
            // 
            // clearRxTxCntToolStripMenuItem
            // 
            this.clearRxTxCntToolStripMenuItem.Name = "clearRxTxCntToolStripMenuItem";
            this.clearRxTxCntToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.clearRxTxCntToolStripMenuItem.Text = "清空计数";
            this.clearRxTxCntToolStripMenuItem.Click += new System.EventHandler(this.clearRxTxCntToolStripMenuItem_Click);
            // 
            // toolStripStatusLabelPortStatus
            // 
            this.toolStripStatusLabelPortStatus.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelPortStatus.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.toolStripStatusLabelPortStatus.Name = "toolStripStatusLabelPortStatus";
            this.toolStripStatusLabelPortStatus.Size = new System.Drawing.Size(171, 21);
            this.toolStripStatusLabelPortStatus.Spring = true;
            // 
            // toolStripStatusLabelRxCnt
            // 
            this.toolStripStatusLabelRxCnt.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelRxCnt.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.toolStripStatusLabelRxCnt.Name = "toolStripStatusLabelRxCnt";
            this.toolStripStatusLabelRxCnt.Size = new System.Drawing.Size(171, 21);
            this.toolStripStatusLabelRxCnt.Spring = true;
            this.toolStripStatusLabelRxCnt.Text = "RX:";
            // 
            // toolStripStatusLabelTxCnt
            // 
            this.toolStripStatusLabelTxCnt.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelTxCnt.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.toolStripStatusLabelTxCnt.Name = "toolStripStatusLabelTxCnt";
            this.toolStripStatusLabelTxCnt.Size = new System.Drawing.Size(171, 21);
            this.toolStripStatusLabelTxCnt.Spring = true;
            this.toolStripStatusLabelTxCnt.Text = "TX:";
            // 
            // toolStripStatusLabelCurTime
            // 
            this.toolStripStatusLabelCurTime.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelCurTime.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.toolStripStatusLabelCurTime.Name = "toolStripStatusLabelCurTime";
            this.toolStripStatusLabelCurTime.Size = new System.Drawing.Size(171, 21);
            this.toolStripStatusLabelCurTime.Spring = true;
            // 
            // PortSendtabControl
            // 
            this.PortSendtabControl.Controls.Add(this.PortTxBasetabPage);
            this.PortSendtabControl.Controls.Add(this.PortTxPulsetabPage);
            this.PortSendtabControl.Controls.Add(this.PortToolsArytabPage);
            this.PortSendtabControl.Location = new System.Drawing.Point(3, 323);
            this.PortSendtabControl.Name = "PortSendtabControl";
            this.PortSendtabControl.SelectedIndex = 0;
            this.PortSendtabControl.Size = new System.Drawing.Size(543, 173);
            this.PortSendtabControl.TabIndex = 12;
            // 
            // PortTxBasetabPage
            // 
            this.PortTxBasetabPage.BackColor = System.Drawing.SystemColors.Control;
            this.PortTxBasetabPage.Controls.Add(this.groupBoxPortTxParam);
            this.PortTxBasetabPage.Controls.Add(this.textBoxPortTxData);
            this.PortTxBasetabPage.Controls.Add(this.btnSerialportTxFile);
            this.PortTxBasetabPage.Controls.Add(this.btnSerialportTxCtrl);
            this.PortTxBasetabPage.Controls.Add(this.btnSerialportBrowerFile);
            this.PortTxBasetabPage.Controls.Add(this.textBoxSerialPortFilePath);
            this.PortTxBasetabPage.Location = new System.Drawing.Point(4, 22);
            this.PortTxBasetabPage.Name = "PortTxBasetabPage";
            this.PortTxBasetabPage.Padding = new System.Windows.Forms.Padding(3);
            this.PortTxBasetabPage.Size = new System.Drawing.Size(535, 147);
            this.PortTxBasetabPage.TabIndex = 0;
            this.PortTxBasetabPage.Text = "基本发送区";
            // 
            // groupBoxPortTxParam
            // 
            this.groupBoxPortTxParam.Controls.Add(this.btnCalTool);
            this.groupBoxPortTxParam.Controls.Add(this.checkBoxTxRxData);
            this.groupBoxPortTxParam.Controls.Add(this.textBoxSerialportTxTick);
            this.groupBoxPortTxParam.Controls.Add(this.checkBoxSerialportAutoTx);
            this.groupBoxPortTxParam.Controls.Add(this.label1);
            this.groupBoxPortTxParam.Controls.Add(this.checkBoxSerialportTxedEmpty);
            this.groupBoxPortTxParam.Location = new System.Drawing.Point(3, 6);
            this.groupBoxPortTxParam.Name = "groupBoxPortTxParam";
            this.groupBoxPortTxParam.Size = new System.Drawing.Size(132, 128);
            this.groupBoxPortTxParam.TabIndex = 6;
            this.groupBoxPortTxParam.TabStop = false;
            this.groupBoxPortTxParam.Text = "发送区设置";
            // 
            // btnCalTool
            // 
            this.btnCalTool.Location = new System.Drawing.Point(4, 102);
            this.btnCalTool.Name = "btnCalTool";
            this.btnCalTool.Size = new System.Drawing.Size(55, 23);
            this.btnCalTool.TabIndex = 7;
            this.btnCalTool.Text = "计算器";
            this.btnCalTool.UseVisualStyleBackColor = true;
            this.btnCalTool.Click += new System.EventHandler(this.btnCalTool_Click);
            // 
            // checkBoxTxRxData
            // 
            this.checkBoxTxRxData.AutoSize = true;
            this.checkBoxTxRxData.Location = new System.Drawing.Point(3, 43);
            this.checkBoxTxRxData.Name = "checkBoxTxRxData";
            this.checkBoxTxRxData.Size = new System.Drawing.Size(108, 16);
            this.checkBoxTxRxData.TabIndex = 6;
            this.checkBoxTxRxData.Text = "发送收到的数据";
            this.checkBoxTxRxData.UseVisualStyleBackColor = true;
            this.checkBoxTxRxData.CheckedChanged += new System.EventHandler(this.checkBoxTxRxData_CheckedChanged);
            // 
            // textBoxSerialportTxTick
            // 
            this.textBoxSerialportTxTick.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxSerialportTxTick.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSerialportTxTick.Location = new System.Drawing.Point(51, 63);
            this.textBoxSerialportTxTick.Name = "textBoxSerialportTxTick";
            this.textBoxSerialportTxTick.Size = new System.Drawing.Size(40, 21);
            this.textBoxSerialportTxTick.TabIndex = 4;
            // 
            // checkBoxSerialportAutoTx
            // 
            this.checkBoxSerialportAutoTx.AutoSize = true;
            this.checkBoxSerialportAutoTx.Location = new System.Drawing.Point(4, 65);
            this.checkBoxSerialportAutoTx.Name = "checkBoxSerialportAutoTx";
            this.checkBoxSerialportAutoTx.Size = new System.Drawing.Size(48, 16);
            this.checkBoxSerialportAutoTx.TabIndex = 2;
            this.checkBoxSerialportAutoTx.Text = "间隔";
            this.checkBoxSerialportAutoTx.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(97, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "毫秒";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkBoxSerialportTxedEmpty
            // 
            this.checkBoxSerialportTxedEmpty.AutoSize = true;
            this.checkBoxSerialportTxedEmpty.Location = new System.Drawing.Point(4, 20);
            this.checkBoxSerialportTxedEmpty.Name = "checkBoxSerialportTxedEmpty";
            this.checkBoxSerialportTxedEmpty.Size = new System.Drawing.Size(108, 16);
            this.checkBoxSerialportTxedEmpty.TabIndex = 1;
            this.checkBoxSerialportTxedEmpty.Text = "发送完自动清空";
            this.checkBoxSerialportTxedEmpty.UseVisualStyleBackColor = true;
            // 
            // textBoxPortTxData
            // 
            this.textBoxPortTxData.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxPortTxData.ContextMenuStrip = this.contextMenuStripTxData;
            this.textBoxPortTxData.Location = new System.Drawing.Point(142, 6);
            this.textBoxPortTxData.Multiline = true;
            this.textBoxPortTxData.Name = "textBoxPortTxData";
            this.textBoxPortTxData.Size = new System.Drawing.Size(303, 81);
            this.textBoxPortTxData.TabIndex = 7;
            this.textBoxPortTxData.TextChanged += new System.EventHandler(this.textBoxPortTxData_TextChanged);
            this.textBoxPortTxData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPortTxData_KeyPress);
            // 
            // contextMenuStripTxData
            // 
            this.contextMenuStripTxData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hexToASCIIToolStripMenuItem,
            this.calCheckToolStripMenuItem,
            this.clearTxDataToolStripMenuItem});
            this.contextMenuStripTxData.Name = "contextMenuStripTxData";
            this.contextMenuStripTxData.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStripTxData.ShowImageMargin = false;
            this.contextMenuStripTxData.Size = new System.Drawing.Size(124, 70);
            // 
            // hexToASCIIToolStripMenuItem
            // 
            this.hexToASCIIToolStripMenuItem.Name = "hexToASCIIToolStripMenuItem";
            this.hexToASCIIToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.hexToASCIIToolStripMenuItem.Text = "转换为HEX";
            this.hexToASCIIToolStripMenuItem.Click += new System.EventHandler(this.hexToASCIIToolStripMenuItem_Click);
            // 
            // calCheckToolStripMenuItem
            // 
            this.calCheckToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modbusRTUCRCToolStripMenuItem,
            this.calXORToolStripMenuItem,
            this.calCRCSumToolStripMenuItem,
            this.calCRCSumWORDToolStripMenuItem});
            this.calCheckToolStripMenuItem.Name = "calCheckToolStripMenuItem";
            this.calCheckToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.calCheckToolStripMenuItem.Text = "校验计算";
            this.calCheckToolStripMenuItem.Visible = false;
            // 
            // modbusRTUCRCToolStripMenuItem
            // 
            this.modbusRTUCRCToolStripMenuItem.Name = "modbusRTUCRCToolStripMenuItem";
            this.modbusRTUCRCToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modbusRTUCRCToolStripMenuItem.Text = "ModbusRTU";
            this.modbusRTUCRCToolStripMenuItem.Click += new System.EventHandler(this.modbusRTUCRCToolStripMenuItem_Click);
            // 
            // calXORToolStripMenuItem
            // 
            this.calXORToolStripMenuItem.Name = "calXORToolStripMenuItem";
            this.calXORToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.calXORToolStripMenuItem.Text = "XOR";
            this.calXORToolStripMenuItem.Click += new System.EventHandler(this.calXORToolStripMenuItem_Click);
            // 
            // calCRCSumToolStripMenuItem
            // 
            this.calCRCSumToolStripMenuItem.Name = "calCRCSumToolStripMenuItem";
            this.calCRCSumToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.calCRCSumToolStripMenuItem.Text = "校验和(1Byte)";
            this.calCRCSumToolStripMenuItem.Click += new System.EventHandler(this.calCRCSumToolStripMenuItem_Click);
            // 
            // calCRCSumWORDToolStripMenuItem
            // 
            this.calCRCSumWORDToolStripMenuItem.Name = "calCRCSumWORDToolStripMenuItem";
            this.calCRCSumWORDToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.calCRCSumWORDToolStripMenuItem.Text = "校验和(2byte)";
            this.calCRCSumWORDToolStripMenuItem.Click += new System.EventHandler(this.calCRCSumWORDToolStripMenuItem_Click);
            // 
            // btnSerialportTxFile
            // 
            this.btnSerialportTxFile.Location = new System.Drawing.Point(451, 109);
            this.btnSerialportTxFile.Name = "btnSerialportTxFile";
            this.btnSerialportTxFile.Size = new System.Drawing.Size(75, 23);
            this.btnSerialportTxFile.TabIndex = 11;
            this.btnSerialportTxFile.Text = "发送文件";
            this.btnSerialportTxFile.UseVisualStyleBackColor = true;
            this.btnSerialportTxFile.Click += new System.EventHandler(this.btnSerialportTxFile_Click);
            // 
            // btnSerialportTxCtrl
            // 
            this.btnSerialportTxCtrl.Location = new System.Drawing.Point(451, 6);
            this.btnSerialportTxCtrl.Name = "btnSerialportTxCtrl";
            this.btnSerialportTxCtrl.Size = new System.Drawing.Size(75, 81);
            this.btnSerialportTxCtrl.TabIndex = 8;
            this.btnSerialportTxCtrl.Text = "发送数据";
            this.btnSerialportTxCtrl.UseVisualStyleBackColor = true;
            this.btnSerialportTxCtrl.Click += new System.EventHandler(this.btnSerialportTxCtrl_Click);
            // 
            // btnSerialportBrowerFile
            // 
            this.btnSerialportBrowerFile.Location = new System.Drawing.Point(141, 111);
            this.btnSerialportBrowerFile.Name = "btnSerialportBrowerFile";
            this.btnSerialportBrowerFile.Size = new System.Drawing.Size(68, 23);
            this.btnSerialportBrowerFile.TabIndex = 10;
            this.btnSerialportBrowerFile.Text = "浏览文件";
            this.btnSerialportBrowerFile.UseVisualStyleBackColor = true;
            this.btnSerialportBrowerFile.Click += new System.EventHandler(this.btnSerialportBrowerFile_Click);
            // 
            // textBoxSerialPortFilePath
            // 
            this.textBoxSerialPortFilePath.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxSerialPortFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSerialPortFilePath.Location = new System.Drawing.Point(216, 111);
            this.textBoxSerialPortFilePath.Name = "textBoxSerialPortFilePath";
            this.textBoxSerialPortFilePath.Size = new System.Drawing.Size(229, 21);
            this.textBoxSerialPortFilePath.TabIndex = 9;
            // 
            // PortTxPulsetabPage
            // 
            this.PortTxPulsetabPage.BackColor = System.Drawing.SystemColors.Control;
            this.PortTxPulsetabPage.Location = new System.Drawing.Point(4, 22);
            this.PortTxPulsetabPage.Name = "PortTxPulsetabPage";
            this.PortTxPulsetabPage.Padding = new System.Windows.Forms.Padding(3);
            this.PortTxPulsetabPage.Size = new System.Drawing.Size(535, 147);
            this.PortTxPulsetabPage.TabIndex = 1;
            this.PortTxPulsetabPage.Text = "高级发送区";
            // 
            // PortToolsArytabPage
            // 
            this.PortToolsArytabPage.BackColor = System.Drawing.SystemColors.Control;
            this.PortToolsArytabPage.Controls.Add(this.textBox1);
            this.PortToolsArytabPage.Controls.Add(this.button1);
            this.PortToolsArytabPage.Location = new System.Drawing.Point(4, 22);
            this.PortToolsArytabPage.Name = "PortToolsArytabPage";
            this.PortToolsArytabPage.Padding = new System.Windows.Forms.Padding(3);
            this.PortToolsArytabPage.Size = new System.Drawing.Size(535, 147);
            this.PortToolsArytabPage.TabIndex = 2;
            this.PortToolsArytabPage.Text = "串口小工具集";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 21);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBoxPortRxParam
            // 
            this.groupBoxPortRxParam.Controls.Add(this.checkBoxSerialportRxHexFormat);
            this.groupBoxPortRxParam.Controls.Add(this.supperTercheckBox);
            this.groupBoxPortRxParam.Controls.Add(this.checkBoxSerialportRxAppendLine);
            this.groupBoxPortRxParam.Controls.Add(this.checkBoxSerialRxShowCtrl);
            this.groupBoxPortRxParam.Controls.Add(this.checkBoxSerialportShowRxTime);
            this.groupBoxPortRxParam.Location = new System.Drawing.Point(3, 187);
            this.groupBoxPortRxParam.Name = "groupBoxPortRxParam";
            this.groupBoxPortRxParam.Size = new System.Drawing.Size(139, 130);
            this.groupBoxPortRxParam.TabIndex = 5;
            this.groupBoxPortRxParam.TabStop = false;
            this.groupBoxPortRxParam.Text = "接收区设置";
            // 
            // checkBoxSerialportRxHexFormat
            // 
            this.checkBoxSerialportRxHexFormat.AutoSize = true;
            this.checkBoxSerialportRxHexFormat.Location = new System.Drawing.Point(4, 86);
            this.checkBoxSerialportRxHexFormat.Name = "checkBoxSerialportRxHexFormat";
            this.checkBoxSerialportRxHexFormat.Size = new System.Drawing.Size(72, 16);
            this.checkBoxSerialportRxHexFormat.TabIndex = 5;
            this.checkBoxSerialportRxHexFormat.Text = "HEX 显示";
            this.checkBoxSerialportRxHexFormat.UseVisualStyleBackColor = true;
            // 
            // supperTercheckBox
            // 
            this.supperTercheckBox.AutoSize = true;
            this.supperTercheckBox.Location = new System.Drawing.Point(4, 108);
            this.supperTercheckBox.Name = "supperTercheckBox";
            this.supperTercheckBox.Size = new System.Drawing.Size(72, 16);
            this.supperTercheckBox.TabIndex = 4;
            this.supperTercheckBox.Text = "超级终端";
            this.supperTercheckBox.UseVisualStyleBackColor = true;
            // 
            // checkBoxSerialportRxAppendLine
            // 
            this.checkBoxSerialportRxAppendLine.AutoSize = true;
            this.checkBoxSerialportRxAppendLine.Location = new System.Drawing.Point(4, 64);
            this.checkBoxSerialportRxAppendLine.Name = "checkBoxSerialportRxAppendLine";
            this.checkBoxSerialportRxAppendLine.Size = new System.Drawing.Size(72, 16);
            this.checkBoxSerialportRxAppendLine.TabIndex = 3;
            this.checkBoxSerialportRxAppendLine.Text = "自动换行";
            this.checkBoxSerialportRxAppendLine.UseVisualStyleBackColor = true;
            // 
            // checkBoxSerialRxShowCtrl
            // 
            this.checkBoxSerialRxShowCtrl.AutoSize = true;
            this.checkBoxSerialRxShowCtrl.Location = new System.Drawing.Point(4, 20);
            this.checkBoxSerialRxShowCtrl.Name = "checkBoxSerialRxShowCtrl";
            this.checkBoxSerialRxShowCtrl.Size = new System.Drawing.Size(72, 16);
            this.checkBoxSerialRxShowCtrl.TabIndex = 2;
            this.checkBoxSerialRxShowCtrl.Text = "暂停显示";
            this.checkBoxSerialRxShowCtrl.UseVisualStyleBackColor = true;
            this.checkBoxSerialRxShowCtrl.CheckedChanged += new System.EventHandler(this.checkBoxSerialRxShowCtrl_CheckedChanged);
            // 
            // checkBoxSerialportShowRxTime
            // 
            this.checkBoxSerialportShowRxTime.AutoSize = true;
            this.checkBoxSerialportShowRxTime.Location = new System.Drawing.Point(4, 42);
            this.checkBoxSerialportShowRxTime.Name = "checkBoxSerialportShowRxTime";
            this.checkBoxSerialportShowRxTime.Size = new System.Drawing.Size(72, 16);
            this.checkBoxSerialportShowRxTime.TabIndex = 1;
            this.checkBoxSerialportShowRxTime.Text = "显示时间";
            this.checkBoxSerialportShowRxTime.UseVisualStyleBackColor = true;
            this.checkBoxSerialportShowRxTime.CheckedChanged += new System.EventHandler(this.checkBoxSerialportShowRxTime_CheckedChanged);
            // 
            // textBoxPortRxData
            // 
            this.textBoxPortRxData.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxPortRxData.ContextMenuStrip = this.contextMenuStripRx;
            this.textBoxPortRxData.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPortRxData.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBoxPortRxData.Location = new System.Drawing.Point(148, 12);
            this.textBoxPortRxData.Multiline = true;
            this.textBoxPortRxData.Name = "textBoxPortRxData";
            this.textBoxPortRxData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPortRxData.Size = new System.Drawing.Size(562, 305);
            this.textBoxPortRxData.TabIndex = 4;
            // 
            // contextMenuStripRx
            // 
            this.contextMenuStripRx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemClearRX,
            this.ToolStripMenuItemSaveRxData});
            this.contextMenuStripRx.Name = "contextMenuStripTxData";
            this.contextMenuStripRx.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStripRx.ShowImageMargin = false;
            this.contextMenuStripRx.Size = new System.Drawing.Size(100, 48);
            // 
            // toolStripMenuItemClearRX
            // 
            this.toolStripMenuItemClearRX.Name = "toolStripMenuItemClearRX";
            this.toolStripMenuItemClearRX.Size = new System.Drawing.Size(99, 22);
            this.toolStripMenuItemClearRX.Text = "清空数据";
            this.toolStripMenuItemClearRX.Click += new System.EventHandler(this.toolStripMenuItemClearRX_Click);
            // 
            // ToolStripMenuItemSaveRxData
            // 
            this.ToolStripMenuItemSaveRxData.Name = "ToolStripMenuItemSaveRxData";
            this.ToolStripMenuItemSaveRxData.Size = new System.Drawing.Size(99, 22);
            this.ToolStripMenuItemSaveRxData.Text = "保存数据";
            this.ToolStripMenuItemSaveRxData.Click += new System.EventHandler(this.ToolStripMenuItemSaveRxData_Click);
            // 
            // groupBoxPortCtrlParam
            // 
            this.groupBoxPortCtrlParam.Controls.Add(this.picBoxClosePort);
            this.groupBoxPortCtrlParam.Controls.Add(this.labelStopbit);
            this.groupBoxPortCtrlParam.Controls.Add(this.picBoxOpenPort);
            this.groupBoxPortCtrlParam.Controls.Add(this.labelPortName);
            this.groupBoxPortCtrlParam.Controls.Add(this.labelDatabit);
            this.groupBoxPortCtrlParam.Controls.Add(this.btnCtrlSerialport);
            this.groupBoxPortCtrlParam.Controls.Add(this.labelParity);
            this.groupBoxPortCtrlParam.Controls.Add(this.cbBoxPort);
            this.groupBoxPortCtrlParam.Controls.Add(this.labelBaund);
            this.groupBoxPortCtrlParam.Controls.Add(this.cbBoxbaundRate);
            this.groupBoxPortCtrlParam.Controls.Add(this.cbBoxParity);
            this.groupBoxPortCtrlParam.Controls.Add(this.cbBoxStopbits);
            this.groupBoxPortCtrlParam.Controls.Add(this.cbBoxDatabits);
            this.groupBoxPortCtrlParam.Location = new System.Drawing.Point(3, 6);
            this.groupBoxPortCtrlParam.Name = "groupBoxPortCtrlParam";
            this.groupBoxPortCtrlParam.Size = new System.Drawing.Size(139, 175);
            this.groupBoxPortCtrlParam.TabIndex = 3;
            this.groupBoxPortCtrlParam.TabStop = false;
            this.groupBoxPortCtrlParam.Text = "串口参数";
            // 
            // picBoxClosePort
            // 
            this.picBoxClosePort.Image = ((System.Drawing.Image)(resources.GetObject("picBoxClosePort.Image")));
            this.picBoxClosePort.Location = new System.Drawing.Point(14, 145);
            this.picBoxClosePort.Name = "picBoxClosePort";
            this.picBoxClosePort.Size = new System.Drawing.Size(21, 23);
            this.picBoxClosePort.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxClosePort.TabIndex = 2;
            this.picBoxClosePort.TabStop = false;
            // 
            // labelStopbit
            // 
            this.labelStopbit.AutoSize = true;
            this.labelStopbit.Location = new System.Drawing.Point(6, 122);
            this.labelStopbit.Name = "labelStopbit";
            this.labelStopbit.Size = new System.Drawing.Size(41, 12);
            this.labelStopbit.TabIndex = 11;
            this.labelStopbit.Text = "停止位";
            // 
            // picBoxOpenPort
            // 
            this.picBoxOpenPort.Image = ((System.Drawing.Image)(resources.GetObject("picBoxOpenPort.Image")));
            this.picBoxOpenPort.Location = new System.Drawing.Point(14, 145);
            this.picBoxOpenPort.Name = "picBoxOpenPort";
            this.picBoxOpenPort.Size = new System.Drawing.Size(21, 23);
            this.picBoxOpenPort.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxOpenPort.TabIndex = 1;
            this.picBoxOpenPort.TabStop = false;
            // 
            // labelPortName
            // 
            this.labelPortName.AutoSize = true;
            this.labelPortName.Location = new System.Drawing.Point(6, 17);
            this.labelPortName.Name = "labelPortName";
            this.labelPortName.Size = new System.Drawing.Size(41, 12);
            this.labelPortName.TabIndex = 7;
            this.labelPortName.Text = "串口号";
            // 
            // labelDatabit
            // 
            this.labelDatabit.AutoSize = true;
            this.labelDatabit.Location = new System.Drawing.Point(6, 96);
            this.labelDatabit.Name = "labelDatabit";
            this.labelDatabit.Size = new System.Drawing.Size(41, 12);
            this.labelDatabit.TabIndex = 10;
            this.labelDatabit.Text = "数据位";
            // 
            // btnCtrlSerialport
            // 
            this.btnCtrlSerialport.Location = new System.Drawing.Point(60, 146);
            this.btnCtrlSerialport.Name = "btnCtrlSerialport";
            this.btnCtrlSerialport.Size = new System.Drawing.Size(73, 23);
            this.btnCtrlSerialport.TabIndex = 1;
            this.btnCtrlSerialport.Text = "打开";
            this.btnCtrlSerialport.UseVisualStyleBackColor = true;
            this.btnCtrlSerialport.Click += new System.EventHandler(this.btnCtrlSerialport_Click);
            // 
            // labelParity
            // 
            this.labelParity.AutoSize = true;
            this.labelParity.Location = new System.Drawing.Point(6, 69);
            this.labelParity.Name = "labelParity";
            this.labelParity.Size = new System.Drawing.Size(41, 12);
            this.labelParity.TabIndex = 9;
            this.labelParity.Text = "检验位";
            // 
            // cbBoxPort
            // 
            this.cbBoxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxPort.FormattingEnabled = true;
            this.cbBoxPort.Location = new System.Drawing.Point(60, 14);
            this.cbBoxPort.Name = "cbBoxPort";
            this.cbBoxPort.Size = new System.Drawing.Size(73, 20);
            this.cbBoxPort.TabIndex = 2;
            this.cbBoxPort.DropDown += new System.EventHandler(this.cbBoxPort_DropDown);
            // 
            // labelBaund
            // 
            this.labelBaund.AutoSize = true;
            this.labelBaund.Location = new System.Drawing.Point(6, 43);
            this.labelBaund.Name = "labelBaund";
            this.labelBaund.Size = new System.Drawing.Size(41, 12);
            this.labelBaund.TabIndex = 8;
            this.labelBaund.Text = "波特率";
            // 
            // cbBoxbaundRate
            // 
            this.cbBoxbaundRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxbaundRate.FormattingEnabled = true;
            this.cbBoxbaundRate.Location = new System.Drawing.Point(60, 40);
            this.cbBoxbaundRate.Name = "cbBoxbaundRate";
            this.cbBoxbaundRate.Size = new System.Drawing.Size(73, 20);
            this.cbBoxbaundRate.TabIndex = 3;
            this.cbBoxbaundRate.SelectedIndexChanged += new System.EventHandler(this.cbBoxbaundRate_SelectedIndexChanged);
            // 
            // cbBoxParity
            // 
            this.cbBoxParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxParity.FormattingEnabled = true;
            this.cbBoxParity.Location = new System.Drawing.Point(60, 66);
            this.cbBoxParity.Name = "cbBoxParity";
            this.cbBoxParity.Size = new System.Drawing.Size(73, 20);
            this.cbBoxParity.TabIndex = 4;
            // 
            // cbBoxStopbits
            // 
            this.cbBoxStopbits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxStopbits.FormattingEnabled = true;
            this.cbBoxStopbits.Location = new System.Drawing.Point(60, 119);
            this.cbBoxStopbits.Name = "cbBoxStopbits";
            this.cbBoxStopbits.Size = new System.Drawing.Size(73, 20);
            this.cbBoxStopbits.TabIndex = 6;
            // 
            // cbBoxDatabits
            // 
            this.cbBoxDatabits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxDatabits.FormattingEnabled = true;
            this.cbBoxDatabits.Location = new System.Drawing.Point(60, 93);
            this.cbBoxDatabits.Name = "cbBoxDatabits";
            this.cbBoxDatabits.Size = new System.Drawing.Size(73, 20);
            this.cbBoxDatabits.TabIndex = 5;
            // 
            // NetToolstabPage
            // 
            this.NetToolstabPage.BackColor = System.Drawing.SystemColors.Control;
            this.NetToolstabPage.Location = new System.Drawing.Point(4, 22);
            this.NetToolstabPage.Name = "NetToolstabPage";
            this.NetToolstabPage.Padding = new System.Windows.Forms.Padding(3);
            this.NetToolstabPage.Size = new System.Drawing.Size(706, 540);
            this.NetToolstabPage.TabIndex = 2;
            this.NetToolstabPage.Text = "网络调试助手";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // SerialToolAutoTxTimer
            // 
            this.SerialToolAutoTxTimer.Tick += new System.EventHandler(this.SerialToolAutoTxTimer_Tick);
            // 
            // TimerShowTick
            // 
            this.TimerShowTick.Interval = 1000;
            this.TimerShowTick.Tick += new System.EventHandler(this.TimerShowTick_Tick);
            // 
            // clearTxDataToolStripMenuItem
            // 
            this.clearTxDataToolStripMenuItem.Name = "clearTxDataToolStripMenuItem";
            this.clearTxDataToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.clearTxDataToolStripMenuItem.Text = "清空发送数据";
            this.clearTxDataToolStripMenuItem.Click += new System.EventHandler(this.clearTxDataToolStripMenuItem_Click);
            // 
            // MultipleCommTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(710, 561);
            this.Controls.Add(this.MultipletabCtrlPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MultipleCommTools";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "多功能调试助手";
            this.Load += new System.EventHandler(this.MultipleCommTools_Load);
            this.MultipletabCtrlPage.ResumeLayout(false);
            this.tabPageSerialPort.ResumeLayout(false);
            this.tabPageSerialPort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStripSerialPort.ResumeLayout(false);
            this.statusStripSerialPort.PerformLayout();
            this.contextMenuStripStatus.ResumeLayout(false);
            this.PortSendtabControl.ResumeLayout(false);
            this.PortTxBasetabPage.ResumeLayout(false);
            this.PortTxBasetabPage.PerformLayout();
            this.groupBoxPortTxParam.ResumeLayout(false);
            this.groupBoxPortTxParam.PerformLayout();
            this.contextMenuStripTxData.ResumeLayout(false);
            this.PortToolsArytabPage.ResumeLayout(false);
            this.PortToolsArytabPage.PerformLayout();
            this.groupBoxPortRxParam.ResumeLayout(false);
            this.groupBoxPortRxParam.PerformLayout();
            this.contextMenuStripRx.ResumeLayout(false);
            this.groupBoxPortCtrlParam.ResumeLayout(false);
            this.groupBoxPortCtrlParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxClosePort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOpenPort)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MultipletabCtrlPage;
        private System.Windows.Forms.TabPage tabPageSerialPort;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBoxPortRxParam;
        private System.Windows.Forms.CheckBox checkBoxSerialportRxAppendLine;
        private System.Windows.Forms.CheckBox checkBoxSerialRxShowCtrl;
        private System.Windows.Forms.CheckBox checkBoxSerialportShowRxTime;
        private System.Windows.Forms.TextBox textBoxPortRxData;
        private System.Windows.Forms.GroupBox groupBoxPortCtrlParam;
        private System.Windows.Forms.PictureBox picBoxClosePort;
        private System.Windows.Forms.Label labelStopbit;
        private System.Windows.Forms.PictureBox picBoxOpenPort;
        private System.Windows.Forms.Label labelPortName;
        private System.Windows.Forms.Label labelDatabit;
        private System.Windows.Forms.Button btnCtrlSerialport;
        private System.Windows.Forms.Label labelParity;
        private System.Windows.Forms.ComboBox cbBoxPort;
        private System.Windows.Forms.Label labelBaund;
        private System.Windows.Forms.ComboBox cbBoxbaundRate;
        private System.Windows.Forms.ComboBox cbBoxParity;
        private System.Windows.Forms.ComboBox cbBoxStopbits;
        private System.Windows.Forms.ComboBox cbBoxDatabits;
        private System.Windows.Forms.TabPage NetToolstabPage;
        private System.Windows.Forms.GroupBox groupBoxPortTxParam;
        private System.Windows.Forms.TextBox textBoxSerialportTxTick;
        private System.Windows.Forms.CheckBox checkBoxSerialportTxedEmpty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSerialportTxCtrl;
        private System.Windows.Forms.TextBox textBoxPortTxData;
        private System.Windows.Forms.Button btnSerialportBrowerFile;
        private System.Windows.Forms.TextBox textBoxSerialPortFilePath;
        private System.Windows.Forms.Button btnSerialportTxFile;
        private System.Windows.Forms.CheckBox supperTercheckBox;
        private System.Windows.Forms.TabControl PortSendtabControl;
        private System.Windows.Forms.TabPage PortTxBasetabPage;
        private System.Windows.Forms.TabPage PortTxPulsetabPage;
        private System.Windows.Forms.StatusStrip statusStripSerialPort;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelPortStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelRxCnt;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTxCnt;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCurTime;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTxData;
        private System.Windows.Forms.ToolStripMenuItem hexToASCIIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calCheckToolStripMenuItem;
        private System.Windows.Forms.Timer SerialToolAutoTxTimer;
        private System.Windows.Forms.CheckBox checkBoxSerialportAutoTx;
        private System.Windows.Forms.CheckBox checkBoxSerialportRxHexFormat;
        private System.Windows.Forms.ToolStripMenuItem calCRCSumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calCRCSumWORDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calXORToolStripMenuItem;
        private System.Windows.Forms.TabPage PortToolsArytabPage;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripRx;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemClearRX;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSaveRxData;
        private System.Windows.Forms.Timer TimerShowTick;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripStatus;
        private System.Windows.Forms.ToolStripMenuItem clearRxTxCntToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBoxTxRxData;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem modbusRTUCRCToolStripMenuItem;
        private System.Windows.Forms.Button btnCalTool;
        private System.Windows.Forms.ToolStripMenuItem clearTxDataToolStripMenuItem;
    }
}

