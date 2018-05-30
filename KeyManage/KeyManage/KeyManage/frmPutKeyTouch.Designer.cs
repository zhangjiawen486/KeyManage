namespace KeyManage
{
    partial class frmPutKeyTouch
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
            this.lblSite = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lstKey = new System.Windows.Forms.ListBox();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(74, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 237);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Location = new System.Drawing.Point(439, 83);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(45, 15);
            this.lblSite.TabIndex = 1;
            this.lblSite.Text = "教室:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(439, 142);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 15);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "姓名:";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(439, 203);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(45, 15);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "学号:";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(415, 261);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(45, 15);
            this.lblClass.TabIndex = 4;
            this.lblClass.Text = "班级:";
            // 
            // lstKey
            // 
            this.lstKey.FormattingEnabled = true;
            this.lstKey.ItemHeight = 15;
            this.lstKey.Location = new System.Drawing.Point(74, 361);
            this.lstKey.Name = "lstKey";
            this.lstKey.Size = new System.Drawing.Size(301, 139);
            this.lstKey.TabIndex = 5;
            this.lstKey.SelectedIndexChanged += new System.EventHandler(this.lstKey_SelectedIndexChanged);
            // 
            // txtSite
            // 
            this.txtSite.Location = new System.Drawing.Point(500, 80);
            this.txtSite.Name = "txtSite";
            this.txtSite.ReadOnly = true;
            this.txtSite.Size = new System.Drawing.Size(152, 25);
            this.txtSite.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(500, 139);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(152, 25);
            this.txtName.TabIndex = 7;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(500, 200);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.ReadOnly = true;
            this.txtNumber.Size = new System.Drawing.Size(152, 25);
            this.txtNumber.TabIndex = 8;
            // 
            // txtClass
            // 
            this.txtClass.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtClass.Location = new System.Drawing.Point(466, 258);
            this.txtClass.Name = "txtClass";
            this.txtClass.ReadOnly = true;
            this.txtClass.Size = new System.Drawing.Size(256, 22);
            this.txtClass.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "请选择信息!";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(409, 416);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(98, 57);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(564, 416);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 57);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(460, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 13;
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 2400;
            this.serialPort1.PortName = "COM3";
            // 
            // frmPutKeyTouch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtSite);
            this.Controls.Add(this.lstKey);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblSite);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmPutKeyTouch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "退还钥匙";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPutKeyTouch_FormClosed);
            this.Load += new System.EventHandler(this.frmPutKeyTouch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ListBox lstKey;
        private System.Windows.Forms.TextBox txtSite;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.IO.Ports.SerialPort serialPort1;
    }
}