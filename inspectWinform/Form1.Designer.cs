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
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.plcIp1 = new System.Windows.Forms.TextBox();
			this.plcPort1 = new System.Windows.Forms.TextBox();
			this.plcPort2 = new System.Windows.Forms.TextBox();
			this.plcIp2 = new System.Windows.Forms.TextBox();
			this.plcPort3 = new System.Windows.Forms.TextBox();
			this.plcIp3 = new System.Windows.Forms.TextBox();
			this.connectAll = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.trigger1 = new System.Windows.Forms.TextBox();
			this.trigger2 = new System.Windows.Forms.TextBox();
			this.trigger3 = new System.Windows.Forms.TextBox();
			this.result1 = new System.Windows.Forms.TextBox();
			this.result2 = new System.Windows.Forms.TextBox();
			this.result3 = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.autoConTimeSet = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.trigger1State = new InspectWinform.CircleLabel();
			this.label21 = new System.Windows.Forms.Label();
			this.conn1En = new System.Windows.Forms.CheckBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.trigger2State = new InspectWinform.CircleLabel();
			this.label22 = new System.Windows.Forms.Label();
			this.conn2En = new System.Windows.Forms.CheckBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.trigger3State = new InspectWinform.CircleLabel();
			this.label23 = new System.Windows.Forms.Label();
			this.conn3En = new System.Windows.Forms.CheckBox();
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
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
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
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label5.Location = new System.Drawing.Point(6, 17);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(68, 32);
			this.label5.TabIndex = 4;
			this.label5.Text = "IP:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label6.Location = new System.Drawing.Point(6, 17);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(68, 32);
			this.label6.TabIndex = 5;
			this.label6.Text = "IP:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label7.Location = new System.Drawing.Point(6, 17);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(68, 32);
			this.label7.TabIndex = 6;
			this.label7.Text = "IP:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label8.Location = new System.Drawing.Point(238, 16);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(74, 32);
			this.label8.TabIndex = 4;
			this.label8.Text = "PORT:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label9.Location = new System.Drawing.Point(238, 16);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(74, 32);
			this.label9.TabIndex = 7;
			this.label9.Text = "PORT:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label10.Location = new System.Drawing.Point(238, 16);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(74, 32);
			this.label10.TabIndex = 8;
			this.label10.Text = "PORT:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// plcIp1
			// 
			this.plcIp1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.plcIp1.Location = new System.Drawing.Point(80, 20);
			this.plcIp1.Name = "plcIp1";
			this.plcIp1.Size = new System.Drawing.Size(152, 29);
			this.plcIp1.TabIndex = 6;
			this.plcIp1.Text = "192.168.0.3";
			// 
			// plcPort1
			// 
			this.plcPort1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.plcPort1.Location = new System.Drawing.Point(318, 20);
			this.plcPort1.Name = "plcPort1";
			this.plcPort1.Size = new System.Drawing.Size(152, 29);
			this.plcPort1.TabIndex = 9;
			this.plcPort1.Text = "12289";
			// 
			// plcPort2
			// 
			this.plcPort2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.plcPort2.Location = new System.Drawing.Point(318, 20);
			this.plcPort2.Name = "plcPort2";
			this.plcPort2.Size = new System.Drawing.Size(152, 29);
			this.plcPort2.TabIndex = 11;
			this.plcPort2.Text = "12289";
			// 
			// plcIp2
			// 
			this.plcIp2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.plcIp2.Location = new System.Drawing.Point(80, 20);
			this.plcIp2.Name = "plcIp2";
			this.plcIp2.Size = new System.Drawing.Size(152, 29);
			this.plcIp2.TabIndex = 10;
			this.plcIp2.Text = "192.168.0.4";
			// 
			// plcPort3
			// 
			this.plcPort3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.plcPort3.Location = new System.Drawing.Point(318, 20);
			this.plcPort3.Name = "plcPort3";
			this.plcPort3.Size = new System.Drawing.Size(152, 29);
			this.plcPort3.TabIndex = 13;
			this.plcPort3.Text = "12289";
			// 
			// plcIp3
			// 
			this.plcIp3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.plcIp3.Location = new System.Drawing.Point(80, 20);
			this.plcIp3.Name = "plcIp3";
			this.plcIp3.Size = new System.Drawing.Size(152, 29);
			this.plcIp3.TabIndex = 12;
			this.plcIp3.Text = "192.168.0.5";
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
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label11.Location = new System.Drawing.Point(14, 69);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(105, 32);
			this.label11.TabIndex = 15;
			this.label11.Text = "触发地址：";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label12.Location = new System.Drawing.Point(14, 66);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(105, 32);
			this.label12.TabIndex = 16;
			this.label12.Text = "触发地址：";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label13.Location = new System.Drawing.Point(14, 67);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(105, 32);
			this.label13.TabIndex = 17;
			this.label13.Text = "触发地址：";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label14.Location = new System.Drawing.Point(238, 69);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(105, 32);
			this.label14.TabIndex = 18;
			this.label14.Text = "结果地址：";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label15
			// 
			this.label15.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label15.Location = new System.Drawing.Point(238, 66);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(105, 32);
			this.label15.TabIndex = 19;
			this.label15.Text = "结果地址：";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label16
			// 
			this.label16.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label16.Location = new System.Drawing.Point(238, 67);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(105, 32);
			this.label16.TabIndex = 20;
			this.label16.Text = "结果地址：";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// trigger1
			// 
			this.trigger1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.trigger1.Location = new System.Drawing.Point(125, 69);
			this.trigger1.Name = "trigger1";
			this.trigger1.Size = new System.Drawing.Size(107, 29);
			this.trigger1.TabIndex = 21;
			this.trigger1.Text = "6030";
			// 
			// trigger2
			// 
			this.trigger2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.trigger2.Location = new System.Drawing.Point(125, 70);
			this.trigger2.Name = "trigger2";
			this.trigger2.Size = new System.Drawing.Size(107, 29);
			this.trigger2.TabIndex = 23;
			this.trigger2.Text = "8030";
			// 
			// trigger3
			// 
			this.trigger3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.trigger3.Location = new System.Drawing.Point(125, 71);
			this.trigger3.Name = "trigger3";
			this.trigger3.Size = new System.Drawing.Size(107, 29);
			this.trigger3.TabIndex = 25;
			this.trigger3.Text = "10030";
			// 
			// result1
			// 
			this.result1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.result1.Location = new System.Drawing.Point(349, 69);
			this.result1.Name = "result1";
			this.result1.Size = new System.Drawing.Size(119, 29);
			this.result1.TabIndex = 22;
			this.result1.Text = "6032";
			// 
			// result2
			// 
			this.result2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.result2.Location = new System.Drawing.Point(349, 69);
			this.result2.Name = "result2";
			this.result2.Size = new System.Drawing.Size(119, 29);
			this.result2.TabIndex = 24;
			this.result2.Text = "8032";
			// 
			// result3
			// 
			this.result3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.result3.Location = new System.Drawing.Point(349, 67);
			this.result3.Name = "result3";
			this.result3.Size = new System.Drawing.Size(119, 29);
			this.result3.TabIndex = 26;
			this.result3.Text = "10032";
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
			this.groupBox2.Controls.Add(this.trigger1State);
			this.groupBox2.Controls.Add(this.label21);
			this.groupBox2.Controls.Add(this.conn1En);
			this.groupBox2.Controls.Add(this.plcIp1);
			this.groupBox2.Controls.Add(this.trigger1);
			this.groupBox2.Controls.Add(this.label14);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.result1);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.plcPort1);
			this.groupBox2.Location = new System.Drawing.Point(263, 56);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(563, 114);
			this.groupBox2.TabIndex = 30;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "工位 1 参数";
			// 
			// trigger1State
			// 
			this.trigger1State.BackColor = System.Drawing.Color.Silver;
			this.trigger1State.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.trigger1State.Location = new System.Drawing.Point(524, 68);
			this.trigger1State.Name = "trigger1State";
			this.trigger1State.Size = new System.Drawing.Size(30, 30);
			this.trigger1State.TabIndex = 24;
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(475, 76);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(53, 12);
			this.label21.TabIndex = 25;
			this.label21.Text = "触发状态";
			// 
			// conn1En
			// 
			this.conn1En.Checked = true;
			this.conn1En.CheckState = System.Windows.Forms.CheckState.Checked;
			this.conn1En.Location = new System.Drawing.Point(476, 20);
			this.conn1En.Name = "conn1En";
			this.conn1En.Size = new System.Drawing.Size(78, 24);
			this.conn1En.TabIndex = 23;
			this.conn1En.Text = "勾选启用";
			this.conn1En.UseVisualStyleBackColor = true;
			this.conn1En.CheckedChanged += new System.EventHandler(this.conn1En_CheckedChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.trigger2State);
			this.groupBox3.Controls.Add(this.label22);
			this.groupBox3.Controls.Add(this.conn2En);
			this.groupBox3.Controls.Add(this.plcIp2);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.plcPort2);
			this.groupBox3.Controls.Add(this.label12);
			this.groupBox3.Controls.Add(this.label15);
			this.groupBox3.Controls.Add(this.trigger2);
			this.groupBox3.Controls.Add(this.result2);
			this.groupBox3.Location = new System.Drawing.Point(263, 188);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(563, 114);
			this.groupBox3.TabIndex = 31;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "工位 2 参数";
			// 
			// trigger2State
			// 
			this.trigger2State.BackColor = System.Drawing.Color.Silver;
			this.trigger2State.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.trigger2State.Location = new System.Drawing.Point(522, 70);
			this.trigger2State.Name = "trigger2State";
			this.trigger2State.Size = new System.Drawing.Size(30, 30);
			this.trigger2State.TabIndex = 25;
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(472, 79);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(53, 12);
			this.label22.TabIndex = 26;
			this.label22.Text = "触发状态";
			// 
			// conn2En
			// 
			this.conn2En.Checked = true;
			this.conn2En.CheckState = System.Windows.Forms.CheckState.Checked;
			this.conn2En.Location = new System.Drawing.Point(476, 21);
			this.conn2En.Name = "conn2En";
			this.conn2En.Size = new System.Drawing.Size(78, 24);
			this.conn2En.TabIndex = 24;
			this.conn2En.Text = "勾选启用";
			this.conn2En.UseVisualStyleBackColor = true;
			this.conn2En.CheckedChanged += new System.EventHandler(this.conn2En_CheckedChanged);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.trigger3State);
			this.groupBox4.Controls.Add(this.label23);
			this.groupBox4.Controls.Add(this.conn3En);
			this.groupBox4.Controls.Add(this.plcIp3);
			this.groupBox4.Controls.Add(this.label7);
			this.groupBox4.Controls.Add(this.label10);
			this.groupBox4.Controls.Add(this.plcPort3);
			this.groupBox4.Controls.Add(this.label13);
			this.groupBox4.Controls.Add(this.label16);
			this.groupBox4.Controls.Add(this.result3);
			this.groupBox4.Controls.Add(this.trigger3);
			this.groupBox4.Location = new System.Drawing.Point(263, 319);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(563, 114);
			this.groupBox4.TabIndex = 31;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "工位 3 参数";
			// 
			// trigger3State
			// 
			this.trigger3State.BackColor = System.Drawing.Color.Silver;
			this.trigger3State.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.trigger3State.Location = new System.Drawing.Point(524, 67);
			this.trigger3State.Name = "trigger3State";
			this.trigger3State.Size = new System.Drawing.Size(30, 30);
			this.trigger3State.TabIndex = 27;
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Location = new System.Drawing.Point(475, 76);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(53, 12);
			this.label23.TabIndex = 28;
			this.label23.Text = "触发状态";
			// 
			// conn3En
			// 
			this.conn3En.Checked = true;
			this.conn3En.CheckState = System.Windows.Forms.CheckState.Checked;
			this.conn3En.Location = new System.Drawing.Point(476, 20);
			this.conn3En.Name = "conn3En";
			this.conn3En.Size = new System.Drawing.Size(78, 24);
			this.conn3En.TabIndex = 25;
			this.conn3En.Text = "勾选启用";
			this.conn3En.UseVisualStyleBackColor = true;
			this.conn3En.CheckedChanged += new System.EventHandler(this.conn3En_CheckedChanged);
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
			this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(251, 502);
			this.panel1.TabIndex = 35;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.testMsg);
			this.groupBox1.Location = new System.Drawing.Point(22, 259);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(836, 501);
			this.Controls.Add(this.overTime);
			this.Controls.Add(this.autoConTimeSet);
			this.Controls.Add(this.label24);
			this.Controls.Add(this.label25);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.autoStartInspectTime);
			this.Controls.Add(this.label20);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.connectAll);
			this.Controls.Add(this.label2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Location = new System.Drawing.Point(15, 15);
			this.Name = "Form1";
			this.Text = "检测程序通信工具";
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
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

        private System.Windows.Forms.CheckBox conn1En;
        private System.Windows.Forms.CheckBox conn2En;
        private System.Windows.Forms.CheckBox conn3En;

        private System.Windows.Forms.CheckBox checkBox1;

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;

        private System.Windows.Forms.Label label18;

        private System.Windows.Forms.Label label17;

        private System.Windows.Forms.Button savePath;

        private System.Windows.Forms.Button save;

        private System.Windows.Forms.TextBox trigger2;
        private System.Windows.Forms.TextBox trigger3;
        private System.Windows.Forms.TextBox result1;
        private System.Windows.Forms.TextBox result2;
        private System.Windows.Forms.TextBox result3;

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox trigger1;

        private System.Windows.Forms.Label label11;

        private System.Windows.Forms.Button ExitButton;

        private System.Windows.Forms.Button cmdCam1;
        private System.Windows.Forms.Button cmdCam2;
        private System.Windows.Forms.Button cmdCam3;

        private System.Windows.Forms.TextBox inspectPort;
        private System.Windows.Forms.TextBox plcIp2;
        private System.Windows.Forms.TextBox plcIp3;
        private System.Windows.Forms.TextBox plcPort1;
        private System.Windows.Forms.TextBox plcPort2;
        private System.Windows.Forms.TextBox plcPort3;

        private System.Windows.Forms.Button connectAll;

        private System.Windows.Forms.TextBox plcIp1;

        private System.Windows.Forms.TextBox inspectIp;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox autoConTimeSet;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label1;

		#endregion

		private CircleLabel trigger1State;
		private System.Windows.Forms.Label label21;
		private CircleLabel trigger2State;
		private System.Windows.Forms.Label label22;
		private CircleLabel trigger3State;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.TextBox overTime;
		private System.Windows.Forms.Label label25;
	}
}