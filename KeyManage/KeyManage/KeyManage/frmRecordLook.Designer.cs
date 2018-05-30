namespace KeyManage
{
    partial class frmRecordLook
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtIDCard = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblIDCard = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.rdoFamale = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(47, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 302);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(468, 56);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.ReadOnly = true;
            this.txtNumber.Size = new System.Drawing.Size(139, 25);
            this.txtNumber.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(468, 96);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(139, 25);
            this.txtName.TabIndex = 2;
            // 
            // txtIDCard
            // 
            this.txtIDCard.Location = new System.Drawing.Point(468, 218);
            this.txtIDCard.Name = "txtIDCard";
            this.txtIDCard.ReadOnly = true;
            this.txtIDCard.Size = new System.Drawing.Size(197, 25);
            this.txtIDCard.TabIndex = 3;
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(468, 176);
            this.txtClass.Name = "txtClass";
            this.txtClass.ReadOnly = true;
            this.txtClass.Size = new System.Drawing.Size(197, 25);
            this.txtClass.TabIndex = 4;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(468, 136);
            this.txtTel.Name = "txtTel";
            this.txtTel.ReadOnly = true;
            this.txtTel.Size = new System.Drawing.Size(139, 25);
            this.txtTel.TabIndex = 5;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(410, 59);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(52, 15);
            this.lblNumber.TabIndex = 6;
            this.lblNumber.Text = "学号：";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(410, 99);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 15);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "姓名：";
            // 
            // lblIDCard
            // 
            this.lblIDCard.AutoSize = true;
            this.lblIDCard.Location = new System.Drawing.Point(395, 221);
            this.lblIDCard.Name = "lblIDCard";
            this.lblIDCard.Size = new System.Drawing.Size(67, 15);
            this.lblIDCard.TabIndex = 8;
            this.lblIDCard.Text = "身份证：";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(410, 179);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(52, 15);
            this.lblClass.TabIndex = 9;
            this.lblClass.Text = "班级：";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(410, 139);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(52, 15);
            this.lblTel.TabIndex = 10;
            this.lblTel.Text = "手机：";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(468, 289);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(133, 60);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdoMale
            // 
            this.rdoMale.AutoCheck = false;
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(468, 259);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(43, 19);
            this.rdoMale.TabIndex = 12;
            this.rdoMale.TabStop = true;
            this.rdoMale.Tag = "1";
            this.rdoMale.Text = "男";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFamale
            // 
            this.rdoFamale.AutoCheck = false;
            this.rdoFamale.AutoSize = true;
            this.rdoFamale.Location = new System.Drawing.Point(556, 259);
            this.rdoFamale.Name = "rdoFamale";
            this.rdoFamale.Size = new System.Drawing.Size(43, 19);
            this.rdoFamale.TabIndex = 13;
            this.rdoFamale.TabStop = true;
            this.rdoFamale.Tag = "1";
            this.rdoFamale.Text = "女";
            this.rdoFamale.UseVisualStyleBackColor = true;
            // 
            // frmRecordLook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 395);
            this.Controls.Add(this.rdoFamale);
            this.Controls.Add(this.rdoMale);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblIDCard);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.txtIDCard);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmRecordLook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRecordLook";
            this.Load += new System.EventHandler(this.frmRecordLook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtIDCard;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblIDCard;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoFamale;
    }
}