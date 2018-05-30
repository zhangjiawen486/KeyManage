namespace SqlFile
{
    partial class frmConfig
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
            this.btnSave = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.chkShow = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(190, 320);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 51);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(106, 249);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(52, 15);
            this.lblPassword.TabIndex = 25;
            this.lblPassword.Text = "密码：";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(91, 192);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(67, 15);
            this.lblUserName.TabIndex = 24;
            this.lblUserName.Text = "用户名：";
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Location = new System.Drawing.Point(91, 141);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(67, 15);
            this.lblDatabase.TabIndex = 23;
            this.lblDatabase.Text = "数据库：";
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(91, 82);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(67, 15);
            this.lblServer.TabIndex = 22;
            this.lblServer.Text = "服务器：";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(164, 246);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(192, 25);
            this.txtPassword.TabIndex = 21;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(164, 189);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(192, 25);
            this.txtUserName.TabIndex = 20;
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(164, 131);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(192, 25);
            this.txtDatabase.TabIndex = 19;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(164, 79);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(192, 25);
            this.txtServer.TabIndex = 18;
            // 
            // chkShow
            // 
            this.chkShow.AutoSize = true;
            this.chkShow.Location = new System.Drawing.Point(362, 248);
            this.chkShow.Name = "chkShow";
            this.chkShow.Size = new System.Drawing.Size(89, 19);
            this.chkShow.TabIndex = 27;
            this.chkShow.Text = "显示密码";
            this.chkShow.UseVisualStyleBackColor = true;
            this.chkShow.CheckedChanged += new System.EventHandler(this.chkShow_CheckedChanged);
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(489, 419);
            this.Controls.Add(this.chkShow);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblDatabase);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.txtServer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "服务器配置";
            this.Load += new System.EventHandler(this.frmConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.CheckBox chkShow;
    }
}