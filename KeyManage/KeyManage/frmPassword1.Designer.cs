namespace KeyManage
{
    partial class frmPassword1
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
            this.btnOk = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPassword1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(355, 54);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(128, 89);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(128, 65);
            this.txtPassword.MaxLength = 18;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(201, 25);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtPassword1
            // 
            this.txtPassword1.Location = new System.Drawing.Point(128, 118);
            this.txtPassword1.MaxLength = 18;
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.Size = new System.Drawing.Size(201, 25);
            this.txtPassword1.TabIndex = 3;
            this.txtPassword1.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "新密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "确认密码：";
            // 
            // frmPassword1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 214);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtPassword);
            this.Name = "frmPassword1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "请输入新密码！";
            this.Load += new System.EventHandler(this.frmPassword1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPassword1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}