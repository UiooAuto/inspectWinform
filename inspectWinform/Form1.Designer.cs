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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
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
            // inspectPort
            // 
            this.inspectPort.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.inspectPort.Location = new System.Drawing.Point(92, 198);
            this.inspectPort.Name = "inspectPort";
            this.inspectPort.Size = new System.Drawing.Size(134, 29);
            this.inspectPort.TabIndex = 5;
            this.inspectPort.Text = "5024";
            // 
            // inspectIp
            // 
            this.inspectIp.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.inspectIp.Location = new System.Drawing.Point(92, 118);
            this.inspectIp.Name = "inspectIp";
            this.inspectIp.Size = new System.Drawing.Size(134, 29);
            this.inspectIp.TabIndex = 4;
            this.inspectIp.Text = "127.0.0.1";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label4.Location = new System.Drawing.Point(12, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "PORT:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label3.Location = new System.Drawing.Point(12, 114);
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
            this.label2.Location = new System.Drawing.Point(454, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "PLC连接";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label5.Location = new System.Drawing.Point(275, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "IP:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label6.Location = new System.Drawing.Point(275, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "IP:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label7.Location = new System.Drawing.Point(275, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 32);
            this.label7.TabIndex = 6;
            this.label7.Text = "IP:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label8.Location = new System.Drawing.Point(499, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 32);
            this.label8.TabIndex = 4;
            this.label8.Text = "PORT:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label9.Location = new System.Drawing.Point(499, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 32);
            this.label9.TabIndex = 7;
            this.label9.Text = "PORT:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label10.Location = new System.Drawing.Point(499, 292);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 32);
            this.label10.TabIndex = 8;
            this.label10.Text = "PORT:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plcIp1
            // 
            this.plcIp1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.plcIp1.Location = new System.Drawing.Point(341, 93);
            this.plcIp1.Name = "plcIp1";
            this.plcIp1.Size = new System.Drawing.Size(152, 29);
            this.plcIp1.TabIndex = 6;
            this.plcIp1.Text = "192.168.0.3";
            // 
            // plcPort1
            // 
            this.plcPort1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.plcPort1.Location = new System.Drawing.Point(579, 93);
            this.plcPort1.Name = "plcPort1";
            this.plcPort1.Size = new System.Drawing.Size(152, 29);
            this.plcPort1.TabIndex = 9;
            this.plcPort1.Text = "12289";
            // 
            // plcPort2
            // 
            this.plcPort2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.plcPort2.Location = new System.Drawing.Point(579, 198);
            this.plcPort2.Name = "plcPort2";
            this.plcPort2.Size = new System.Drawing.Size(152, 29);
            this.plcPort2.TabIndex = 11;
            this.plcPort2.Text = "12289";
            // 
            // plcIp2
            // 
            this.plcIp2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.plcIp2.Location = new System.Drawing.Point(341, 198);
            this.plcIp2.Name = "plcIp2";
            this.plcIp2.Size = new System.Drawing.Size(152, 29);
            this.plcIp2.TabIndex = 10;
            this.plcIp2.Text = "192.168.0.4";
            // 
            // plcPort3
            // 
            this.plcPort3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.plcPort3.Location = new System.Drawing.Point(579, 296);
            this.plcPort3.Name = "plcPort3";
            this.plcPort3.Size = new System.Drawing.Size(152, 29);
            this.plcPort3.TabIndex = 13;
            this.plcPort3.Text = "12289";
            // 
            // plcIp3
            // 
            this.plcIp3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.plcIp3.Location = new System.Drawing.Point(341, 296);
            this.plcIp3.Name = "plcIp3";
            this.plcIp3.Size = new System.Drawing.Size(152, 29);
            this.plcIp3.TabIndex = 12;
            this.plcIp3.Text = "192.168.0.5";
            // 
            // connectAll
            // 
            this.connectAll.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.connectAll.Location = new System.Drawing.Point(307, 360);
            this.connectAll.Name = "connectAll";
            this.connectAll.Size = new System.Drawing.Size(424, 38);
            this.connectAll.TabIndex = 14;
            this.connectAll.Text = "连接";
            this.connectAll.UseVisualStyleBackColor = true;
            this.connectAll.Click += new System.EventHandler(this.connectAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.connectAll);
            this.Controls.Add(this.plcPort3);
            this.Controls.Add(this.plcIp3);
            this.Controls.Add(this.plcPort2);
            this.Controls.Add(this.plcIp2);
            this.Controls.Add(this.plcPort1);
            this.Controls.Add(this.plcIp1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.Text = "Inspect连接工具";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox inspectPort;
        private System.Windows.Forms.TextBox plcIp2;
        private System.Windows.Forms.TextBox plcIp3;
        private System.Windows.Forms.TextBox plcPort1;
        private System.Windows.Forms.TextBox plcPort2;
        private System.Windows.Forms.TextBox plcPort3;

        private System.Windows.Forms.Button connectAll;

        private System.Windows.Forms.TextBox textBox2;

        private System.Windows.Forms.TextBox plcIp1;

        private System.Windows.Forms.TextBox inspectIp;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}