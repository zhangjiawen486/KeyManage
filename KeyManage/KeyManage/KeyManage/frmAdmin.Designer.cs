namespace KeyManage
{
    partial class frmAdmin
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.取钥匙ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.还钥匙ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.钥匙管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.教室管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.记录日志ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.服务器配置1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.服务器配置2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.取钥匙ToolStripMenuItem,
            this.还钥匙ToolStripMenuItem,
            this.管理员ToolStripMenuItem,
            this.记录日志ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1040, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 取钥匙ToolStripMenuItem
            // 
            this.取钥匙ToolStripMenuItem.Name = "取钥匙ToolStripMenuItem";
            this.取钥匙ToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.取钥匙ToolStripMenuItem.Text = "取钥匙";
            this.取钥匙ToolStripMenuItem.Click += new System.EventHandler(this.取钥匙ToolStripMenuItem_Click);
            // 
            // 还钥匙ToolStripMenuItem
            // 
            this.还钥匙ToolStripMenuItem.Name = "还钥匙ToolStripMenuItem";
            this.还钥匙ToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.还钥匙ToolStripMenuItem.Text = "还钥匙";
            this.还钥匙ToolStripMenuItem.Click += new System.EventHandler(this.还钥匙ToolStripMenuItem_Click);
            // 
            // 管理员ToolStripMenuItem
            // 
            this.管理员ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.钥匙管理ToolStripMenuItem,
            this.教室管理ToolStripMenuItem,
            this.修改密码ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.管理员ToolStripMenuItem.Name = "管理员ToolStripMenuItem";
            this.管理员ToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.管理员ToolStripMenuItem.Text = "管理员";
            this.管理员ToolStripMenuItem.Click += new System.EventHandler(this.管理员ToolStripMenuItem_Click);
            // 
            // 钥匙管理ToolStripMenuItem
            // 
            this.钥匙管理ToolStripMenuItem.Name = "钥匙管理ToolStripMenuItem";
            this.钥匙管理ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.钥匙管理ToolStripMenuItem.Text = "钥匙管理";
            this.钥匙管理ToolStripMenuItem.Visible = false;
            this.钥匙管理ToolStripMenuItem.Click += new System.EventHandler(this.钥匙管理ToolStripMenuItem_Click);
            // 
            // 教室管理ToolStripMenuItem
            // 
            this.教室管理ToolStripMenuItem.Name = "教室管理ToolStripMenuItem";
            this.教室管理ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.教室管理ToolStripMenuItem.Text = "教室管理";
            this.教室管理ToolStripMenuItem.Visible = false;
            this.教室管理ToolStripMenuItem.Click += new System.EventHandler(this.房间管理ToolStripMenuItem_Click);
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.修改密码ToolStripMenuItem.Text = "修改密码";
            this.修改密码ToolStripMenuItem.Visible = false;
            this.修改密码ToolStripMenuItem.Click += new System.EventHandler(this.修改密码ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Visible = false;
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 记录日志ToolStripMenuItem
            // 
            this.记录日志ToolStripMenuItem.Name = "记录日志ToolStripMenuItem";
            this.记录日志ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.记录日志ToolStripMenuItem.Text = "记录日志";
            this.记录日志ToolStripMenuItem.Click += new System.EventHandler(this.记录日志ToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.服务器配置1ToolStripMenuItem,
            this.服务器配置2ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(163, 52);
            // 
            // 服务器配置1ToolStripMenuItem
            // 
            this.服务器配置1ToolStripMenuItem.Name = "服务器配置1ToolStripMenuItem";
            this.服务器配置1ToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.服务器配置1ToolStripMenuItem.Text = "服务器配置1";
            this.服务器配置1ToolStripMenuItem.Click += new System.EventHandler(this.服务器配置ToolStripMenuItem_Click);
            // 
            // 服务器配置2ToolStripMenuItem
            // 
            this.服务器配置2ToolStripMenuItem.Name = "服务器配置2ToolStripMenuItem";
            this.服务器配置2ToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.服务器配置2ToolStripMenuItem.Text = "服务器配置2";
            this.服务器配置2ToolStripMenuItem.Click += new System.EventHandler(this.服务器配置2ToolStripMenuItem_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1040, 641);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAdmin";
            this.Text = "管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 取钥匙ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 还钥匙ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 管理员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 钥匙管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 教室管理ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 服务器配置1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 记录日志ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 服务器配置2ToolStripMenuItem;
    }
}

