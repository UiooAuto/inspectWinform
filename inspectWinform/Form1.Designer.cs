namespace InspectWinform
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.handStartInspect = new System.Windows.Forms.Button();
            this.minForm = new System.Windows.Forms.Button();
            this.savePath = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.cmdCam3 = new System.Windows.Forms.Button();
            this.cmdCam2 = new System.Windows.Forms.Button();
            this.cmdCam1 = new System.Windows.Forms.Button();
            this.inspectPort = new System.Windows.Forms.TextBox();
            this.inspectIp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.connectAll = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.autoConTimeSet = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_EnCam1 = new System.Windows.Forms.CheckBox();
            this.cb_EnCam3 = new System.Windows.Forms.CheckBox();
            this.cb_EnCam2 = new System.Windows.Forms.CheckBox();
            this.gb_Cam1 = new System.Windows.Forms.GroupBox();
            this.result1 = new System.Windows.Forms.TextBox();
            this.trigger1State = new InspectWinform.CircleLabel();
            this.label21 = new System.Windows.Forms.Label();
            this.trigger1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gb_Cam2 = new System.Windows.Forms.GroupBox();
            this.result2 = new System.Windows.Forms.TextBox();
            this.trigger2 = new System.Windows.Forms.TextBox();
            this.trigger2State = new InspectWinform.CircleLabel();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.gb_Cam3 = new System.Windows.Forms.GroupBox();
            this.trigger3 = new System.Windows.Forms.TextBox();
            this.result3 = new System.Windows.Forms.TextBox();
            this.trigger3State = new InspectWinform.CircleLabel();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.autoStartInspectTime = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.testMsg = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.overTime = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.plcIp1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.plcPort1 = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.gb_Cam1.SuspendLayout();
            this.gb_Cam2.SuspendLayout();
            this.gb_Cam3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // handStartInspect
            // 
            this.handStartInspect.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.handStartInspect.Location = new System.Drawing.Point(18, 44);
            this.handStartInspect.Name = "handStartInspect";
            this.handStartInspect.Size = new System.Drawing.Size(214, 30);
            this.handStartInspect.TabIndex = 13;
            this.handStartInspect.Text = "手动启动检测程序";
            this.handStartInspect.UseVisualStyleBackColor = true;
            this.handStartInspect.Click += new System.EventHandler(this.handStartInspect_Click);
            // 
            // minForm
            // 
            this.minForm.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.minForm.Location = new System.Drawing.Point(18, 421);
            this.minForm.Name = "minForm";
            this.minForm.Size = new System.Drawing.Size(214, 30);
            this.minForm.TabIndex = 12;
            this.minForm.Text = "最小化到系统托盘";
            this.minForm.UseVisualStyleBackColor = true;
            this.minForm.Click += new System.EventHandler(this.minForm_Click);
            // 
            // savePath
            // 
            this.savePath.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.savePath.Location = new System.Drawing.Point(18, 371);
            this.savePath.Name = "savePath";
            this.savePath.Size = new System.Drawing.Size(214, 30);
            this.savePath.TabIndex = 11;
            this.savePath.Text = "打开连接参数地址";
            this.savePath.UseVisualStyleBackColor = true;
            this.savePath.Click += new System.EventHandler(this.savePath_Click);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.save.Location = new System.Drawing.Point(18, 335);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(214, 30);
            this.save.TabIndex = 10;
            this.save.Text = "保存连接参数";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Red;
            this.ExitButton.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(18, 455);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(214, 37);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // cmdCam3
            // 
            this.cmdCam3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmdCam3.Location = new System.Drawing.Point(22, 224);
            this.cmdCam3.Name = "cmdCam3";
            this.cmdCam3.Size = new System.Drawing.Size(214, 30);
            this.cmdCam3.TabIndex = 8;
            this.cmdCam3.Text = "相机3触发测试";
            this.cmdCam3.UseVisualStyleBackColor = true;
            this.cmdCam3.Click += new System.EventHandler(this.cmdCam3_Click);
            // 
            // cmdCam2
            // 
            this.cmdCam2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmdCam2.Location = new System.Drawing.Point(22, 188);
            this.cmdCam2.Name = "cmdCam2";
            this.cmdCam2.Size = new System.Drawing.Size(214, 30);
            this.cmdCam2.TabIndex = 7;
            this.cmdCam2.Text = "相机2触发测试";
            this.cmdCam2.UseVisualStyleBackColor = true;
            this.cmdCam2.Click += new System.EventHandler(this.cmdCam2_Click);
            // 
            // cmdCam1
            // 
            this.cmdCam1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmdCam1.Location = new System.Drawing.Point(22, 152);
            this.cmdCam1.Name = "cmdCam1";
            this.cmdCam1.Size = new System.Drawing.Size(214, 30);
            this.cmdCam1.TabIndex = 6;
            this.cmdCam1.Text = "相机1触发测试";
            this.cmdCam1.UseVisualStyleBackColor = true;
            this.cmdCam1.Click += new System.EventHandler(this.cmdCam1_Click);
            // 
            // inspectPort
            // 
            this.inspectPort.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.inspectPort.Location = new System.Drawing.Point(98, 112);
            this.inspectPort.Name = "inspectPort";
            this.inspectPort.Size = new System.Drawing.Size(134, 29);
            this.inspectPort.TabIndex = 5;
            this.inspectPort.Text = "5024";
            // 
            // inspectIp
            // 
            this.inspectIp.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.inspectIp.Location = new System.Drawing.Point(98, 80);
            this.inspectIp.Name = "inspectIp";
            this.inspectIp.Size = new System.Drawing.Size(134, 29);
            this.inspectIp.TabIndex = 4;
            this.inspectIp.Text = "127.0.0.1";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(18, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "PORT:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(18, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "IP:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "检测程序连接";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(303, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "PLC连接";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // connectAll
            // 
            this.connectAll.BackColor = System.Drawing.Color.Silver;
            this.connectAll.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.connectAll.Location = new System.Drawing.Point(313, 455);
            this.connectAll.Name = "connectAll";
            this.connectAll.Size = new System.Drawing.Size(453, 38);
            this.connectAll.TabIndex = 0;
            this.connectAll.Text = "连接";
            this.connectAll.UseVisualStyleBackColor = false;
            this.connectAll.Click += new System.EventHandler(this.connectAll_Click);
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(607, 19);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 23);
            this.label17.TabIndex = 27;
            this.label17.Text = "自动连接等待";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // autoConTimeSet
            // 
            this.autoConTimeSet.Location = new System.Drawing.Point(685, 21);
            this.autoConTimeSet.Name = "autoConTimeSet";
            this.autoConTimeSet.Size = new System.Drawing.Size(23, 21);
            this.autoConTimeSet.TabIndex = 28;
            this.autoConTimeSet.Text = "10";
            this.autoConTimeSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(707, 19);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(23, 23);
            this.label18.TabIndex = 29;
            this.label18.Text = "秒";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_EnCam1);
            this.groupBox2.Controls.Add(this.cb_EnCam3);
            this.groupBox2.Controls.Add(this.cb_EnCam2);
            this.groupBox2.Controls.Add(this.gb_Cam1);
            this.groupBox2.Controls.Add(this.gb_Cam2);
            this.groupBox2.Controls.Add(this.gb_Cam3);
            this.groupBox2.Location = new System.Drawing.Point(263, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(561, 351);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "相机选择";
            // 
            // cb_EnCam1
            // 
            this.cb_EnCam1.Checked = true;
            this.cb_EnCam1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_EnCam1.Location = new System.Drawing.Point(52, 32);
            this.cb_EnCam1.Name = "cb_EnCam1";
            this.cb_EnCam1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cb_EnCam1.Size = new System.Drawing.Size(78, 24);
            this.cb_EnCam1.TabIndex = 45;
            this.cb_EnCam1.Text = "勾选启用";
            this.cb_EnCam1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_EnCam1.UseVisualStyleBackColor = true;
            this.cb_EnCam1.CheckedChanged += new System.EventHandler(this.cb_EnCam1_CheckedChanged);
            // 
            // cb_EnCam3
            // 
            this.cb_EnCam3.Checked = true;
            this.cb_EnCam3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_EnCam3.Location = new System.Drawing.Point(52, 262);
            this.cb_EnCam3.Name = "cb_EnCam3";
            this.cb_EnCam3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cb_EnCam3.Size = new System.Drawing.Size(78, 24);
            this.cb_EnCam3.TabIndex = 48;
            this.cb_EnCam3.Text = "勾选启用";
            this.cb_EnCam3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_EnCam3.UseVisualStyleBackColor = true;
            this.cb_EnCam3.CheckedChanged += new System.EventHandler(this.cb_EnCam3_CheckedChanged);
            // 
            // cb_EnCam2
            // 
            this.cb_EnCam2.Checked = true;
            this.cb_EnCam2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_EnCam2.Location = new System.Drawing.Point(52, 147);
            this.cb_EnCam2.Name = "cb_EnCam2";
            this.cb_EnCam2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cb_EnCam2.Size = new System.Drawing.Size(78, 24);
            this.cb_EnCam2.TabIndex = 49;
            this.cb_EnCam2.Text = "勾选启用";
            this.cb_EnCam2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_EnCam2.UseVisualStyleBackColor = true;
            this.cb_EnCam2.CheckedChanged += new System.EventHandler(this.cb_EnCam2_CheckedChanged);
            // 
            // gb_Cam1
            // 
            this.gb_Cam1.Controls.Add(this.result1);
            this.gb_Cam1.Controls.Add(this.trigger1State);
            this.gb_Cam1.Controls.Add(this.label21);
            this.gb_Cam1.Controls.Add(this.trigger1);
            this.gb_Cam1.Controls.Add(this.label14);
            this.gb_Cam1.Controls.Add(this.label11);
            this.gb_Cam1.Location = new System.Drawing.Point(10, 37);
            this.gb_Cam1.Name = "gb_Cam1";
            this.gb_Cam1.Size = new System.Drawing.Size(545, 73);
            this.gb_Cam1.TabIndex = 41;
            this.gb_Cam1.TabStop = false;
            this.gb_Cam1.Text = "相机1";
            // 
            // result1
            // 
            this.result1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.result1.Location = new System.Drawing.Point(321, 26);
            this.result1.Name = "result1";
            this.result1.Size = new System.Drawing.Size(119, 29);
            this.result1.TabIndex = 29;
            this.result1.Text = "6032";
            // 
            // trigger1State
            // 
            this.trigger1State.BackColor = System.Drawing.Color.Silver;
            this.trigger1State.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trigger1State.Location = new System.Drawing.Point(507, 25);
            this.trigger1State.Name = "trigger1State";
            this.trigger1State.Size = new System.Drawing.Size(30, 30);
            this.trigger1State.TabIndex = 30;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(458, 34);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(53, 12);
            this.label21.TabIndex = 31;
            this.label21.Text = "触发状态";
            // 
            // trigger1
            // 
            this.trigger1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.trigger1.Location = new System.Drawing.Point(103, 26);
            this.trigger1.Name = "trigger1";
            this.trigger1.Size = new System.Drawing.Size(107, 29);
            this.trigger1.TabIndex = 28;
            this.trigger1.Text = "6030";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(221, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 32);
            this.label14.TabIndex = 27;
            this.label14.Text = "结果地址：";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(1, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 32);
            this.label11.TabIndex = 26;
            this.label11.Text = "触发地址：";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gb_Cam2
            // 
            this.gb_Cam2.Controls.Add(this.result2);
            this.gb_Cam2.Controls.Add(this.trigger2);
            this.gb_Cam2.Controls.Add(this.trigger2State);
            this.gb_Cam2.Controls.Add(this.label26);
            this.gb_Cam2.Controls.Add(this.label27);
            this.gb_Cam2.Controls.Add(this.label28);
            this.gb_Cam2.Location = new System.Drawing.Point(10, 152);
            this.gb_Cam2.Name = "gb_Cam2";
            this.gb_Cam2.Size = new System.Drawing.Size(545, 73);
            this.gb_Cam2.TabIndex = 40;
            this.gb_Cam2.TabStop = false;
            this.gb_Cam2.Text = "相机2";
            // 
            // result2
            // 
            this.result2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.result2.Location = new System.Drawing.Point(321, 26);
            this.result2.Name = "result2";
            this.result2.Size = new System.Drawing.Size(119, 29);
            this.result2.TabIndex = 36;
            this.result2.Text = "8032";
            // 
            // trigger2
            // 
            this.trigger2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.trigger2.Location = new System.Drawing.Point(103, 26);
            this.trigger2.Name = "trigger2";
            this.trigger2.Size = new System.Drawing.Size(107, 29);
            this.trigger2.TabIndex = 35;
            this.trigger2.Text = "8030";
            // 
            // trigger2State
            // 
            this.trigger2State.BackColor = System.Drawing.Color.Silver;
            this.trigger2State.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trigger2State.Location = new System.Drawing.Point(507, 25);
            this.trigger2State.Name = "trigger2State";
            this.trigger2State.Size = new System.Drawing.Size(30, 30);
            this.trigger2State.TabIndex = 37;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(458, 34);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(53, 12);
            this.label26.TabIndex = 38;
            this.label26.Text = "触发状态";
            // 
            // label27
            // 
            this.label27.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label27.Location = new System.Drawing.Point(1, 24);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(105, 32);
            this.label27.TabIndex = 33;
            this.label27.Text = "触发地址：";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            this.label28.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label28.Location = new System.Drawing.Point(221, 24);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(105, 32);
            this.label28.TabIndex = 34;
            this.label28.Text = "结果地址：";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gb_Cam3
            // 
            this.gb_Cam3.Controls.Add(this.trigger3);
            this.gb_Cam3.Controls.Add(this.result3);
            this.gb_Cam3.Controls.Add(this.trigger3State);
            this.gb_Cam3.Controls.Add(this.label29);
            this.gb_Cam3.Controls.Add(this.label30);
            this.gb_Cam3.Controls.Add(this.label31);
            this.gb_Cam3.Location = new System.Drawing.Point(10, 267);
            this.gb_Cam3.Name = "gb_Cam3";
            this.gb_Cam3.Size = new System.Drawing.Size(545, 73);
            this.gb_Cam3.TabIndex = 39;
            this.gb_Cam3.TabStop = false;
            this.gb_Cam3.Text = "相机3";
            // 
            // trigger3
            // 
            this.trigger3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.trigger3.Location = new System.Drawing.Point(103, 26);
            this.trigger3.Name = "trigger3";
            this.trigger3.Size = new System.Drawing.Size(107, 29);
            this.trigger3.TabIndex = 41;
            this.trigger3.Text = "10030";
            // 
            // result3
            // 
            this.result3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.result3.Location = new System.Drawing.Point(321, 26);
            this.result3.Name = "result3";
            this.result3.Size = new System.Drawing.Size(119, 29);
            this.result3.TabIndex = 42;
            this.result3.Text = "10032";
            // 
            // trigger3State
            // 
            this.trigger3State.BackColor = System.Drawing.Color.Silver;
            this.trigger3State.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trigger3State.Location = new System.Drawing.Point(507, 25);
            this.trigger3State.Name = "trigger3State";
            this.trigger3State.Size = new System.Drawing.Size(30, 30);
            this.trigger3State.TabIndex = 43;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(458, 34);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(53, 12);
            this.label29.TabIndex = 44;
            this.label29.Text = "触发状态";
            // 
            // label30
            // 
            this.label30.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label30.Location = new System.Drawing.Point(1, 24);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(105, 32);
            this.label30.TabIndex = 39;
            this.label30.Text = "触发地址：";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label31
            // 
            this.label31.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label31.Location = new System.Drawing.Point(221, 24);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(105, 32);
            this.label31.TabIndex = 40;
            this.label31.Text = "结果地址：";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(585, 19);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(23, 23);
            this.label19.TabIndex = 34;
            this.label19.Text = "秒";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // autoStartInspectTime
            // 
            this.autoStartInspectTime.Location = new System.Drawing.Point(562, 21);
            this.autoStartInspectTime.Name = "autoStartInspectTime";
            this.autoStartInspectTime.Size = new System.Drawing.Size(23, 21);
            this.autoStartInspectTime.TabIndex = 33;
            this.autoStartInspectTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(439, 19);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(125, 23);
            this.label20.TabIndex = 32;
            this.label20.Text = "自动启动检测程序延时";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "检测程序通信工具";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.handStartInspect);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.minForm);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.inspectIp);
            this.panel1.Controls.Add(this.savePath);
            this.panel1.Controls.Add(this.inspectPort);
            this.panel1.Controls.Add(this.cmdCam1);
            this.panel1.Controls.Add(this.save);
            this.panel1.Controls.Add(this.cmdCam2);
            this.panel1.Controls.Add(this.cmdCam3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 502);
            this.panel1.TabIndex = 35;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.testMsg);
            this.groupBox1.Location = new System.Drawing.Point(22, 259);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(210, 62);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "测试结果";
            // 
            // testMsg
            // 
            this.testMsg.BackColor = System.Drawing.Color.Silver;
            this.testMsg.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.testMsg.Location = new System.Drawing.Point(11, 13);
            this.testMsg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.testMsg.Name = "testMsg";
            this.testMsg.Size = new System.Drawing.Size(187, 42);
            this.testMsg.TabIndex = 0;
            this.testMsg.Text = "无";
            this.testMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.Location = new System.Drawing.Point(817, 19);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(23, 23);
            this.label24.TabIndex = 38;
            this.label24.Text = "秒";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // overTime
            // 
            this.overTime.Location = new System.Drawing.Point(789, 21);
            this.overTime.Name = "overTime";
            this.overTime.Size = new System.Drawing.Size(29, 21);
            this.overTime.TabIndex = 37;
            this.overTime.Text = "1";
            this.overTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label25
            // 
            this.label25.Location = new System.Drawing.Point(738, 19);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(55, 23);
            this.label25.TabIndex = 36;
            this.label25.Text = "触发超时";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // plcIp1
            // 
            this.plcIp1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plcIp1.Location = new System.Drawing.Point(343, 63);
            this.plcIp1.Name = "plcIp1";
            this.plcIp1.Size = new System.Drawing.Size(152, 29);
            this.plcIp1.TabIndex = 41;
            this.plcIp1.Text = "192.168.0.3";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(269, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 32);
            this.label6.TabIndex = 39;
            this.label6.Text = "IP:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(501, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 32);
            this.label7.TabIndex = 40;
            this.label7.Text = "PORT:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plcPort1
            // 
            this.plcPort1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plcPort1.Location = new System.Drawing.Point(581, 63);
            this.plcPort1.Name = "plcPort1";
            this.plcPort1.Size = new System.Drawing.Size(152, 29);
            this.plcPort1.TabIndex = 42;
            this.plcPort1.Text = "12289";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(836, 501);
            this.Controls.Add(this.plcIp1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.plcPort1);
            this.Controls.Add(this.overTime);
            this.Controls.Add(this.autoConTimeSet);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.autoStartInspectTime);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.connectAll);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.Text = "检测程序通信工具 v2.0.0";
            this.groupBox2.ResumeLayout(false);
            this.gb_Cam1.ResumeLayout(false);
            this.gb_Cam1.PerformLayout();
            this.gb_Cam2.ResumeLayout(false);
            this.gb_Cam2.PerformLayout();
            this.gb_Cam3.ResumeLayout(false);
            this.gb_Cam3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label testMsg;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.NotifyIcon notifyIcon1;

        private System.Windows.Forms.Button minForm;
        private System.Windows.Forms.Button handStartInspect;

        private System.Windows.Forms.TextBox autoStartInspectTime;

        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;

        private System.Windows.Forms.CheckBox checkBox1;

        private System.Windows.Forms.GroupBox groupBox2;

        private System.Windows.Forms.Label label18;

        private System.Windows.Forms.Label label17;

        private System.Windows.Forms.Button savePath;

        private System.Windows.Forms.Button save;

        private System.Windows.Forms.Button ExitButton;

        private System.Windows.Forms.Button cmdCam1;
        private System.Windows.Forms.Button cmdCam2;
        private System.Windows.Forms.Button cmdCam3;

        private System.Windows.Forms.TextBox inspectPort;

        private System.Windows.Forms.Button connectAll;

        private System.Windows.Forms.TextBox inspectIp;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox autoConTimeSet;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label1;

		#endregion
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.TextBox overTime;
		private System.Windows.Forms.Label label25;
        private System.Windows.Forms.GroupBox gb_Cam3;
        private System.Windows.Forms.TextBox trigger3;
        private System.Windows.Forms.TextBox result3;
        private CircleLabel trigger3State;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox plcIp1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox plcPort1;
        private System.Windows.Forms.CheckBox cb_EnCam1;
        private System.Windows.Forms.GroupBox gb_Cam1;
        private System.Windows.Forms.TextBox result1;
        private CircleLabel trigger1State;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox trigger1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gb_Cam2;
        private System.Windows.Forms.CheckBox cb_EnCam2;
        private System.Windows.Forms.TextBox result2;
        private System.Windows.Forms.TextBox trigger2;
        private CircleLabel trigger2State;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.CheckBox cb_EnCam3;
    }
}