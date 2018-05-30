namespace KeyManage
{
    partial class frmManageKey
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
            this.lstSite = new System.Windows.Forms.ListBox();
            this.cboFloor = new System.Windows.Forms.ComboBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.lblFloor = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstSite
            // 
            this.lstSite.FormattingEnabled = true;
            this.lstSite.ItemHeight = 15;
            this.lstSite.Location = new System.Drawing.Point(81, 134);
            this.lstSite.Name = "lstSite";
            this.lstSite.Size = new System.Drawing.Size(340, 304);
            this.lstSite.TabIndex = 0;
            this.lstSite.SelectedIndexChanged += new System.EventHandler(this.lstSite_SelectedIndexChanged);
            // 
            // cboFloor
            // 
            this.cboFloor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFloor.FormattingEnabled = true;
            this.cboFloor.Location = new System.Drawing.Point(161, 81);
            this.cboFloor.Name = "cboFloor";
            this.cboFloor.Size = new System.Drawing.Size(220, 23);
            this.cboFloor.TabIndex = 1;
            this.cboFloor.SelectedIndexChanged += new System.EventHandler(this.cboFloor_SelectedIndexChanged);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(591, 224);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(142, 25);
            this.txtKey.TabIndex = 2;
            this.txtKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKey_KeyPress);
            // 
            // lblFloor
            // 
            this.lblFloor.AutoSize = true;
            this.lblFloor.Location = new System.Drawing.Point(103, 84);
            this.lblFloor.Name = "lblFloor";
            this.lblFloor.Size = new System.Drawing.Size(52, 15);
            this.lblFloor.TabIndex = 3;
            this.lblFloor.Text = "楼层：";
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(518, 227);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(67, 15);
            this.lblKey.TabIndex = 4;
            this.lblKey.Text = "钥匙数：";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(575, 302);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 58);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmManageKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 502);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.lblFloor);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.cboFloor);
            this.Controls.Add(this.lstSite);
            this.Name = "frmManageKey";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "钥匙与IO管理";
            this.Load += new System.EventHandler(this.frmManageKey_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSite;
        private System.Windows.Forms.ComboBox cboFloor;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label lblFloor;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Button btnUpdate;

    }
}