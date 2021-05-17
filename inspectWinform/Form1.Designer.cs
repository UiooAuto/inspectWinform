namespace inspectWinform
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.conn1En = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.conn2En = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.conn3En = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.savePath);
            this.groupBox1.Controls.Add(this.save);
            this.groupBox1.Controls.Add(this.ExitButton);
            this.groupBox1.Controls.Add(this.cmdCam3);
            this.groupBox1.Controls.Add(this.cmdCam2);
            this.groupBox1.Controls.Add(this.cmdCam1);
            this.groupBox1.Controls.Add(this.inspectPort);
            this.groupBox1.Controls.Add(this.inspectIp);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(261, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // savePath
            // 
            this.savePath.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.savePath.Location = new System.Drawing.Point(27, 353);
            this.savePath.Name = "savePath";
            this.savePath.Size = new System.Drawing.Size(214, 33);
            this.savePath.TabIndex = 11;
            this.savePath.Text = "打开连接参数地址";
            this.savePath.UseVisualStyleBackColor = true;
            this.savePath.Click += new System.EventHandler(this.savePath_Click);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.save.Location = new System.Drawing.Point(27, 314);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(214, 33);
            this.save.TabIndex = 10;
            this.save.Text = "保存连接参数";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Red;
            this.ExitButton.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(27, 392);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(214, 37);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // cmdCam3
            // 
            this.cmdCam3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.cmdCam3.Location = new System.Drawing.Point(27, 258);
            this.cmdCam3.Name = "cmdCam3";
            this.cmdCam3.Size = new System.Drawing.Size(214, 35);
            this.cmdCam3.TabIndex = 8;
            this.cmdCam3.Text = "相机3触发测试";
            this.cmdCam3.UseVisualStyleBackColor = true;
            this.cmdCam3.Click += new System.EventHandler(this.cmdCam3_Click);
            // 
            // cmdCam2
            // 
            this.cmdCam2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.cmdCam2.Location = new System.Drawing.Point(27, 217);
            this.cmdCam2.Name = "cmdCam2";
            this.cmdCam2.Size = new System.Drawing.Size(214, 35);
            this.cmdCam2.TabIndex = 7;
            this.cmdCam2.Text = "相机2触发测试";
            this.cmdCam2.UseVisualStyleBackColor = true;
            this.cmdCam2.Click += new System.EventHandler(this.cmdCam2_Click);
            // 
            // cmdCam1
            // 
            this.cmdCam1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.cmdCam1.Location = new System.Drawing.Point(27, 176);
            this.cmdCam1.Name = "cmdCam1";
            this.cmdCam1.Size = new System.Drawing.Size(214, 35);
            this.cmdCam1.TabIndex = 6;
            this.cmdCam1.Text = "相机1触发测试";
            this.cmdCam1.UseVisualStyleBackColor = true;
            this.cmdCam1.Click += new System.EventHandler(this.cmdCam1_Click);
            // 
            // inspectPort
            // 
            this.inspectPort.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.inspectPort.Location = new System.Drawing.Point(107, 127);
            this.inspectPort.Name = "inspectPort";
            this.inspectPort.Size = new System.Drawing.Size(134, 29);
            this.inspectPort.TabIndex = 5;
            this.inspectPort.Text = "5024";
            // 
            // inspectIp
            // 
            this.inspectIp.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.inspectIp.Location = new System.Drawing.Point(107, 79);
            this.inspectIp.Name = "inspectIp";
            this.inspectIp.Size = new System.Drawing.Size(134, 29);
            this.inspectIp.TabIndex = 4;
            this.inspectIp.Text = "127.0.0.1";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label4.Location = new System.Drawing.Point(27, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "PORT:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label3.Location = new System.Drawing.Point(27, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "IP:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label1.Location = new System.Drawing.Point(47, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inspect连接";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label2.Location = new System.Drawing.Point(433, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "PLC连接";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label5.Location = new System.Drawing.Point(6, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "IP:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label6.Location = new System.Drawing.Point(6, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "IP:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label7.Location = new System.Drawing.Point(6, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 32);
            this.label7.TabIndex = 6;
            this.label7.Text = "IP:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label8.Location = new System.Drawing.Point(238, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 32);
            this.label8.TabIndex = 4;
            this.label8.Text = "PORT:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label9.Location = new System.Drawing.Point(238, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 32);
            this.label9.TabIndex = 7;
            this.label9.Text = "PORT:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label10.Location = new System.Drawing.Point(238, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 32);
            this.label10.TabIndex = 8;
            this.label10.Text = "PORT:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plcIp1
            // 
            this.plcIp1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.plcIp1.Location = new System.Drawing.Point(80, 20);
            this.plcIp1.Name = "plcIp1";
            this.plcIp1.Size = new System.Drawing.Size(152, 29);
            this.plcIp1.TabIndex = 6;
            this.plcIp1.Text = "192.168.0.3";
            // 
            // plcPort1
            // 
            this.plcPort1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.plcPort1.Location = new System.Drawing.Point(318, 20);
            this.plcPort1.Name = "plcPort1";
            this.plcPort1.Size = new System.Drawing.Size(152, 29);
            this.plcPort1.TabIndex = 9;
            this.plcPort1.Text = "12289";
            // 
            // plcPort2
            // 
            this.plcPort2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.plcPort2.Location = new System.Drawing.Point(318, 20);
            this.plcPort2.Name = "plcPort2";
            this.plcPort2.Size = new System.Drawing.Size(152, 29);
            this.plcPort2.TabIndex = 11;
            this.plcPort2.Text = "12289";
            // 
            // plcIp2
            // 
            this.plcIp2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.plcIp2.Location = new System.Drawing.Point(80, 20);
            this.plcIp2.Name = "plcIp2";
            this.plcIp2.Size = new System.Drawing.Size(152, 29);
            this.plcIp2.TabIndex = 10;
            this.plcIp2.Text = "192.168.0.4";
            // 
            // plcPort3
            // 
            this.plcPort3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.plcPort3.Location = new System.Drawing.Point(318, 20);
            this.plcPort3.Name = "plcPort3";
            this.plcPort3.Size = new System.Drawing.Size(152, 29);
            this.plcPort3.TabIndex = 13;
            this.plcPort3.Text = "12289";
            // 
            // plcIp3
            // 
            this.plcIp3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.plcIp3.Location = new System.Drawing.Point(80, 20);
            this.plcIp3.Name = "plcIp3";
            this.plcIp3.Size = new System.Drawing.Size(152, 29);
            this.plcIp3.TabIndex = 12;
            this.plcIp3.Text = "192.168.0.5";
            // 
            // connectAll
            // 
            this.connectAll.BackColor = System.Drawing.Color.Silver;
            this.connectAll.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.connectAll.Location = new System.Drawing.Point(286, 403);
            this.connectAll.Name = "connectAll";
            this.connectAll.Size = new System.Drawing.Size(453, 38);
            this.connectAll.TabIndex = 0;
            this.connectAll.Text = "连接";
            this.connectAll.UseVisualStyleBackColor = false;
            this.connectAll.Click += new System.EventHandler(this.connectAll_Click);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label11.Location = new System.Drawing.Point(14, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 32);
            this.label11.TabIndex = 15;
            this.label11.Text = "触发地址：";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label12.Location = new System.Drawing.Point(14, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 32);
            this.label12.TabIndex = 16;
            this.label12.Text = "触发地址：";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label13.Location = new System.Drawing.Point(14, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 32);
            this.label13.TabIndex = 17;
            this.label13.Text = "触发地址：";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label14.Location = new System.Drawing.Point(238, 69);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 32);
            this.label14.TabIndex = 18;
            this.label14.Text = "结果地址：";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label15.Location = new System.Drawing.Point(238, 66);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 32);
            this.label15.TabIndex = 19;
            this.label15.Text = "结果地址：";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label16.Location = new System.Drawing.Point(238, 67);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(105, 32);
            this.label16.TabIndex = 20;
            this.label16.Text = "结果地址：";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trigger1
            // 
            this.trigger1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.trigger1.Location = new System.Drawing.Point(125, 69);
            this.trigger1.Name = "trigger1";
            this.trigger1.Size = new System.Drawing.Size(107, 29);
            this.trigger1.TabIndex = 21;
            this.trigger1.Text = "6030";
            // 
            // trigger2
            // 
            this.trigger2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.trigger2.Location = new System.Drawing.Point(125, 70);
            this.trigger2.Name = "trigger2";
            this.trigger2.Size = new System.Drawing.Size(107, 29);
            this.trigger2.TabIndex = 23;
            this.trigger2.Text = "8030";
            // 
            // trigger3
            // 
            this.trigger3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.trigger3.Location = new System.Drawing.Point(125, 71);
            this.trigger3.Name = "trigger3";
            this.trigger3.Size = new System.Drawing.Size(107, 29);
            this.trigger3.TabIndex = 25;
            this.trigger3.Text = "10030";
            // 
            // result1
            // 
            this.result1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.result1.Location = new System.Drawing.Point(349, 69);
            this.result1.Name = "result1";
            this.result1.Size = new System.Drawing.Size(119, 29);
            this.result1.TabIndex = 22;
            this.result1.Text = "6032";
            // 
            // result2
            // 
            this.result2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.result2.Location = new System.Drawing.Point(349, 69);
            this.result2.Name = "result2";
            this.result2.Size = new System.Drawing.Size(119, 29);
            this.result2.TabIndex = 24;
            this.result2.Text = "8032";
            // 
            // result3
            // 
            this.result3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.result3.Location = new System.Drawing.Point(349, 67);
            this.result3.Name = "result3";
            this.result3.Size = new System.Drawing.Size(119, 29);
            this.result3.TabIndex = 26;
            this.result3.Text = "10032";
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(635, 18);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 23);
            this.label17.TabIndex = 27;
            this.label17.Text = "自动连接等待";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // autoConTimeSet
            // 
            this.autoConTimeSet.Location = new System.Drawing.Point(712, 19);
            this.autoConTimeSet.Name = "autoConTimeSet";
            this.autoConTimeSet.Size = new System.Drawing.Size(23, 21);
            this.autoConTimeSet.TabIndex = 28;
            this.autoConTimeSet.Text = "10";
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(735, 18);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(23, 23);
            this.label18.TabIndex = 29;
            this.label18.Text = "秒";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.conn1En);
            this.groupBox2.Controls.Add(this.plcIp1);
            this.groupBox2.Controls.Add(this.trigger1);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.result1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.plcPort1);
            this.groupBox2.Location = new System.Drawing.Point(264, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(563, 114);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "工位 1 参数";
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
            this.groupBox3.Controls.Add(this.conn2En);
            this.groupBox3.Controls.Add(this.plcIp2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.plcPort2);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.trigger2);
            this.groupBox3.Controls.Add(this.result2);
            this.groupBox3.Location = new System.Drawing.Point(264, 164);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(563, 114);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "工位 2 参数";
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
            this.groupBox4.Controls.Add(this.conn3En);
            this.groupBox4.Controls.Add(this.plcIp3);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.plcPort3);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.result3);
            this.groupBox4.Controls.Add(this.trigger3);
            this.groupBox4.Location = new System.Drawing.Point(264, 284);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(563, 114);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "工位 3 参数";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(830, 449);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.autoConTimeSet);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.connectAll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.Text = "Inspect连接工具";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

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

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}