namespace KeyManage
{
    partial class frmManageSite
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
            this.cboFloor2 = new System.Windows.Forms.ComboBox();
            this.lblFloor2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFloor1 = new System.Windows.Forms.Label();
            this.btnFloorDelete = new System.Windows.Forms.Button();
            this.btnFloorAdd = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtRoomC3 = new System.Windows.Forms.TextBox();
            this.lblRoomC3 = new System.Windows.Forms.Label();
            this.btnSiteAdd = new System.Windows.Forms.Button();
            this.lblName3 = new System.Windows.Forms.Label();
            this.lblRoom3 = new System.Windows.Forms.Label();
            this.lblFloor3 = new System.Windows.Forms.Label();
            this.txtName3 = new System.Windows.Forms.TextBox();
            this.txtRoom3 = new System.Windows.Forms.TextBox();
            this.cboFloor3 = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtRoomC4 = new System.Windows.Forms.TextBox();
            this.lblRoomC4 = new System.Windows.Forms.Label();
            this.btnSiteDelate = new System.Windows.Forms.Button();
            this.btnSiteUpdate = new System.Windows.Forms.Button();
            this.lblName4 = new System.Windows.Forms.Label();
            this.lblRoom4 = new System.Windows.Forms.Label();
            this.lblFloor4 = new System.Windows.Forms.Label();
            this.txtName4 = new System.Windows.Forms.TextBox();
            this.txtRoom4 = new System.Windows.Forms.TextBox();
            this.cboFloor4 = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstSite
            // 
            this.lstSite.FormattingEnabled = true;
            this.lstSite.ItemHeight = 15;
            this.lstSite.Location = new System.Drawing.Point(57, 80);
            this.lstSite.Name = "lstSite";
            this.lstSite.Size = new System.Drawing.Size(363, 379);
            this.lstSite.TabIndex = 0;
            this.lstSite.SelectedIndexChanged += new System.EventHandler(this.lstSite_SelectedIndexChanged);
            // 
            // cboFloor2
            // 
            this.cboFloor2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFloor2.FormattingEnabled = true;
            this.cboFloor2.Location = new System.Drawing.Point(150, 38);
            this.cboFloor2.Name = "cboFloor2";
            this.cboFloor2.Size = new System.Drawing.Size(218, 23);
            this.cboFloor2.TabIndex = 8;
            this.cboFloor2.SelectedIndexChanged += new System.EventHandler(this.cboFloor2_SelectedIndexChanged);
            // 
            // lblFloor2
            // 
            this.lblFloor2.AutoSize = true;
            this.lblFloor2.Location = new System.Drawing.Point(92, 41);
            this.lblFloor2.Name = "lblFloor2";
            this.lblFloor2.Size = new System.Drawing.Size(52, 15);
            this.lblFloor2.TabIndex = 2;
            this.lblFloor2.Text = "楼层：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblFloor2);
            this.groupBox2.Controls.Add(this.cboFloor2);
            this.groupBox2.Controls.Add(this.lstSite);
            this.groupBox2.Location = new System.Drawing.Point(53, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(477, 479);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "查询教室信息";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFloor1);
            this.groupBox1.Controls.Add(this.btnFloorDelete);
            this.groupBox1.Controls.Add(this.btnFloorAdd);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Location = new System.Drawing.Point(53, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 132);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "添加或移除楼层信息";
            // 
            // lblFloor1
            // 
            this.lblFloor1.AutoSize = true;
            this.lblFloor1.Location = new System.Drawing.Point(87, 59);
            this.lblFloor1.Name = "lblFloor1";
            this.lblFloor1.Size = new System.Drawing.Size(82, 15);
            this.lblFloor1.TabIndex = 3;
            this.lblFloor1.Text = "选择层数：";
            // 
            // btnFloorDelete
            // 
            this.btnFloorDelete.Location = new System.Drawing.Point(284, 81);
            this.btnFloorDelete.Name = "btnFloorDelete";
            this.btnFloorDelete.Size = new System.Drawing.Size(72, 43);
            this.btnFloorDelete.TabIndex = 2;
            this.btnFloorDelete.Text = "移除";
            this.btnFloorDelete.UseVisualStyleBackColor = true;
            this.btnFloorDelete.Click += new System.EventHandler(this.btnFloorDelete_Click);
            // 
            // btnFloorAdd
            // 
            this.btnFloorAdd.Location = new System.Drawing.Point(284, 15);
            this.btnFloorAdd.Name = "btnFloorAdd";
            this.btnFloorAdd.Size = new System.Drawing.Size(72, 45);
            this.btnFloorAdd.TabIndex = 1;
            this.btnFloorAdd.Text = "添加";
            this.btnFloorAdd.UseVisualStyleBackColor = true;
            this.btnFloorAdd.Click += new System.EventHandler(this.btnFloorAdd_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(175, 57);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(59, 25);
            this.numericUpDown1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtRoomC3);
            this.groupBox3.Controls.Add(this.lblRoomC3);
            this.groupBox3.Controls.Add(this.btnSiteAdd);
            this.groupBox3.Controls.Add(this.lblName3);
            this.groupBox3.Controls.Add(this.lblRoom3);
            this.groupBox3.Controls.Add(this.lblFloor3);
            this.groupBox3.Controls.Add(this.txtName3);
            this.groupBox3.Controls.Add(this.txtRoom3);
            this.groupBox3.Controls.Add(this.cboFloor3);
            this.groupBox3.Location = new System.Drawing.Point(575, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(421, 249);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "添加新的教室";
            // 
            // txtRoomC3
            // 
            this.txtRoomC3.Location = new System.Drawing.Point(305, 114);
            this.txtRoomC3.Name = "txtRoomC3";
            this.txtRoomC3.Size = new System.Drawing.Size(92, 25);
            this.txtRoomC3.TabIndex = 6;
            // 
            // lblRoomC3
            // 
            this.lblRoomC3.AutoSize = true;
            this.lblRoomC3.Location = new System.Drawing.Point(208, 117);
            this.lblRoomC3.Name = "lblRoomC3";
            this.lblRoomC3.Size = new System.Drawing.Size(91, 15);
            this.lblRoomC3.TabIndex = 7;
            this.lblRoomC3.Text = "IO关闭数据:";
            // 
            // btnSiteAdd
            // 
            this.btnSiteAdd.Location = new System.Drawing.Point(143, 169);
            this.btnSiteAdd.Name = "btnSiteAdd";
            this.btnSiteAdd.Size = new System.Drawing.Size(118, 52);
            this.btnSiteAdd.TabIndex = 7;
            this.btnSiteAdd.Text = "添加教室";
            this.btnSiteAdd.UseVisualStyleBackColor = true;
            this.btnSiteAdd.Click += new System.EventHandler(this.btnSiteAdd_Click);
            // 
            // lblName3
            // 
            this.lblName3.AutoSize = true;
            this.lblName3.Location = new System.Drawing.Point(232, 52);
            this.lblName3.Name = "lblName3";
            this.lblName3.Size = new System.Drawing.Size(67, 15);
            this.lblName3.TabIndex = 5;
            this.lblName3.Text = "门牌号：";
            // 
            // lblRoom3
            // 
            this.lblRoom3.AutoSize = true;
            this.lblRoom3.Location = new System.Drawing.Point(6, 117);
            this.lblRoom3.Name = "lblRoom3";
            this.lblRoom3.Size = new System.Drawing.Size(91, 15);
            this.lblRoom3.TabIndex = 4;
            this.lblRoom3.Text = "IO打开数据:";
            // 
            // lblFloor3
            // 
            this.lblFloor3.AutoSize = true;
            this.lblFloor3.Location = new System.Drawing.Point(37, 52);
            this.lblFloor3.Name = "lblFloor3";
            this.lblFloor3.Size = new System.Drawing.Size(52, 15);
            this.lblFloor3.TabIndex = 3;
            this.lblFloor3.Text = "楼层：";
            // 
            // txtName3
            // 
            this.txtName3.Location = new System.Drawing.Point(305, 49);
            this.txtName3.Name = "txtName3";
            this.txtName3.Size = new System.Drawing.Size(104, 25);
            this.txtName3.TabIndex = 4;
            // 
            // txtRoom3
            // 
            this.txtRoom3.Location = new System.Drawing.Point(103, 114);
            this.txtRoom3.Name = "txtRoom3";
            this.txtRoom3.Size = new System.Drawing.Size(83, 25);
            this.txtRoom3.TabIndex = 5;
            this.txtRoom3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRoom3_KeyPress);
            // 
            // cboFloor3
            // 
            this.cboFloor3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFloor3.FormattingEnabled = true;
            this.cboFloor3.Location = new System.Drawing.Point(95, 49);
            this.cboFloor3.Name = "cboFloor3";
            this.cboFloor3.Size = new System.Drawing.Size(82, 23);
            this.cboFloor3.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtRoomC4);
            this.groupBox4.Controls.Add(this.lblRoomC4);
            this.groupBox4.Controls.Add(this.btnSiteDelate);
            this.groupBox4.Controls.Add(this.btnSiteUpdate);
            this.groupBox4.Controls.Add(this.lblName4);
            this.groupBox4.Controls.Add(this.lblRoom4);
            this.groupBox4.Controls.Add(this.lblFloor4);
            this.groupBox4.Controls.Add(this.txtName4);
            this.groupBox4.Controls.Add(this.txtRoom4);
            this.groupBox4.Controls.Add(this.cboFloor4);
            this.groupBox4.Location = new System.Drawing.Point(575, 282);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(421, 384);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "修改或删除教室";
            // 
            // txtRoomC4
            // 
            this.txtRoomC4.Location = new System.Drawing.Point(317, 139);
            this.txtRoomC4.Name = "txtRoomC4";
            this.txtRoomC4.Size = new System.Drawing.Size(92, 25);
            this.txtRoomC4.TabIndex = 11;
            // 
            // lblRoomC4
            // 
            this.lblRoomC4.AutoSize = true;
            this.lblRoomC4.Location = new System.Drawing.Point(227, 143);
            this.lblRoomC4.Name = "lblRoomC4";
            this.lblRoomC4.Size = new System.Drawing.Size(91, 15);
            this.lblRoomC4.TabIndex = 14;
            this.lblRoomC4.Text = "IO关闭数据:";
            // 
            // btnSiteDelate
            // 
            this.btnSiteDelate.Location = new System.Drawing.Point(223, 266);
            this.btnSiteDelate.Name = "btnSiteDelate";
            this.btnSiteDelate.Size = new System.Drawing.Size(125, 63);
            this.btnSiteDelate.TabIndex = 14;
            this.btnSiteDelate.Text = "删除";
            this.btnSiteDelate.UseVisualStyleBackColor = true;
            this.btnSiteDelate.Click += new System.EventHandler(this.btnSiteDelate_Click);
            // 
            // btnSiteUpdate
            // 
            this.btnSiteUpdate.Location = new System.Drawing.Point(43, 266);
            this.btnSiteUpdate.Name = "btnSiteUpdate";
            this.btnSiteUpdate.Size = new System.Drawing.Size(125, 63);
            this.btnSiteUpdate.TabIndex = 13;
            this.btnSiteUpdate.Text = "修改";
            this.btnSiteUpdate.UseVisualStyleBackColor = true;
            this.btnSiteUpdate.Click += new System.EventHandler(this.btnSiteUpdate_Click);
            // 
            // lblName4
            // 
            this.lblName4.AutoSize = true;
            this.lblName4.Location = new System.Drawing.Point(70, 197);
            this.lblName4.Name = "lblName4";
            this.lblName4.Size = new System.Drawing.Size(67, 15);
            this.lblName4.TabIndex = 11;
            this.lblName4.Text = "门牌号：";
            // 
            // lblRoom4
            // 
            this.lblRoom4.AutoSize = true;
            this.lblRoom4.Location = new System.Drawing.Point(6, 143);
            this.lblRoom4.Name = "lblRoom4";
            this.lblRoom4.Size = new System.Drawing.Size(91, 15);
            this.lblRoom4.TabIndex = 10;
            this.lblRoom4.Text = "IO打开数据:";
            // 
            // lblFloor4
            // 
            this.lblFloor4.AutoSize = true;
            this.lblFloor4.Location = new System.Drawing.Point(85, 86);
            this.lblFloor4.Name = "lblFloor4";
            this.lblFloor4.Size = new System.Drawing.Size(52, 15);
            this.lblFloor4.TabIndex = 9;
            this.lblFloor4.Text = "楼层：";
            // 
            // txtName4
            // 
            this.txtName4.Location = new System.Drawing.Point(143, 197);
            this.txtName4.Name = "txtName4";
            this.txtName4.Size = new System.Drawing.Size(175, 25);
            this.txtName4.TabIndex = 12;
            // 
            // txtRoom4
            // 
            this.txtRoom4.Location = new System.Drawing.Point(103, 140);
            this.txtRoom4.Name = "txtRoom4";
            this.txtRoom4.Size = new System.Drawing.Size(91, 25);
            this.txtRoom4.TabIndex = 10;
            this.txtRoom4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRoom4_KeyPress);
            // 
            // cboFloor4
            // 
            this.cboFloor4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFloor4.FormattingEnabled = true;
            this.cboFloor4.Location = new System.Drawing.Point(143, 83);
            this.cboFloor4.Name = "cboFloor4";
            this.cboFloor4.Size = new System.Drawing.Size(129, 23);
            this.cboFloor4.TabIndex = 9;
            // 
            // frmManageSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 678);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmManageSite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "教室管理";
            this.Load += new System.EventHandler(this.frmManageSite_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstSite;
        private System.Windows.Forms.ComboBox cboFloor2;
        private System.Windows.Forms.Label lblFloor2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFloorDelete;
        private System.Windows.Forms.Button btnFloorAdd;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblFloor1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblFloor3;
        private System.Windows.Forms.TextBox txtName3;
        private System.Windows.Forms.TextBox txtRoom3;
        private System.Windows.Forms.ComboBox cboFloor3;
        private System.Windows.Forms.Label lblName3;
        private System.Windows.Forms.Label lblRoom3;
        private System.Windows.Forms.Button btnSiteAdd;
        private System.Windows.Forms.Button btnSiteDelate;
        private System.Windows.Forms.Button btnSiteUpdate;
        private System.Windows.Forms.Label lblName4;
        private System.Windows.Forms.Label lblRoom4;
        private System.Windows.Forms.Label lblFloor4;
        private System.Windows.Forms.TextBox txtName4;
        private System.Windows.Forms.TextBox txtRoom4;
        private System.Windows.Forms.ComboBox cboFloor4;
        private System.Windows.Forms.Label lblRoomC3;
        private System.Windows.Forms.TextBox txtRoomC3;
        private System.Windows.Forms.TextBox txtRoomC4;
        private System.Windows.Forms.Label lblRoomC4;
    }
}