namespace KeyManage
{
    partial class frmOutKeyTouch
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lbClass = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTouch = new System.Windows.Forms.Button();
            this.lblSite = new System.Windows.Forms.Label();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(35, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(74, 288);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(45, 15);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "学号:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(74, 348);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 15);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "姓名:";
            // 
            // lbClass
            // 
            this.lbClass.AutoSize = true;
            this.lbClass.Location = new System.Drawing.Point(48, 407);
            this.lbClass.Name = "lbClass";
            this.lbClass.Size = new System.Drawing.Size(45, 15);
            this.lbClass.TabIndex = 3;
            this.lbClass.Text = "班级:";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(125, 285);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.ReadOnly = true;
            this.txtNumber.Size = new System.Drawing.Size(195, 25);
            this.txtNumber.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(125, 345);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(195, 25);
            this.txtName.TabIndex = 5;
            // 
            // txtClass
            // 
            this.txtClass.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtClass.Location = new System.Drawing.Point(99, 404);
            this.txtClass.Name = "txtClass";
            this.txtClass.ReadOnly = true;
            this.txtClass.Size = new System.Drawing.Size(296, 22);
            this.txtClass.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtClass);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtNumber);
            this.groupBox1.Controls.Add(this.lbClass);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblNumber);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(15, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 477);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "学生信息";
            // 
            // btnTouch
            // 
            this.btnTouch.Location = new System.Drawing.Point(542, 186);
            this.btnTouch.Name = "btnTouch";
            this.btnTouch.Size = new System.Drawing.Size(132, 58);
            this.btnTouch.TabIndex = 8;
            this.btnTouch.Text = "确认身份";
            this.btnTouch.UseVisualStyleBackColor = true;
            this.btnTouch.Click += new System.EventHandler(this.btnTouch_Click);
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Location = new System.Drawing.Point(486, 105);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(135, 15);
            this.lblSite.TabIndex = 9;
            this.lblSite.Text = "你所要取的教室为:";
            // 
            // txtSite
            // 
            this.txtSite.Location = new System.Drawing.Point(627, 102);
            this.txtSite.Name = "txtSite";
            this.txtSite.ReadOnly = true;
            this.txtSite.Size = new System.Drawing.Size(84, 25);
            this.txtSite.TabIndex = 10;
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(489, 396);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(108, 59);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "确认";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(627, 396);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 59);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(542, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 13;
            this.label1.Tag = "";
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 2400;
            this.serialPort1.PortName = "COM3";
            // 
            // frmOutKeyTouch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 510);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtSite);
            this.Controls.Add(this.lblSite);
            this.Controls.Add(this.btnTouch);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmOutKeyTouch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "请输入指纹！";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmOutKeyTouch_FormClosed);
            this.Load += new System.EventHandler(this.frmOutKeyTouch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lbClass;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTouch;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.TextBox txtSite;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serialPort1;
    }
}