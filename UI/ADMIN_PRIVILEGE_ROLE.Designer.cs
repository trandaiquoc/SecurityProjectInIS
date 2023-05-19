namespace ATBMTHTTT
{
    partial class ADMIN_PRIVILEGE_ROLE
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_exit = new System.Windows.Forms.Button();
            this.label_privilege = new System.Windows.Forms.Label();
            this.button_revoke = new System.Windows.Forms.Button();
            this.button_grant = new System.Windows.Forms.Button();
            this.dgv_privilege = new System.Windows.Forms.DataGridView();
            this.panel_MENU = new System.Windows.Forms.Panel();
            this.button_ROLE = new System.Windows.Forms.Button();
            this.button_SYS = new System.Windows.Forms.Button();
            this.button_TAB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_privilege)).BeginInit();
            this.panel_MENU.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(151)))), ((int)(((byte)(108)))));
            this.button_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_exit.FlatAppearance.BorderSize = 0;
            this.button_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.button_exit.Location = new System.Drawing.Point(754, 53);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(200, 50);
            this.button_exit.TabIndex = 10;
            this.button_exit.Text = "Thoát";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // label_privilege
            // 
            this.label_privilege.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_privilege.Font = new System.Drawing.Font("Cambria", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_privilege.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.label_privilege.Location = new System.Drawing.Point(0, 0);
            this.label_privilege.Name = "label_privilege";
            this.label_privilege.Size = new System.Drawing.Size(982, 50);
            this.label_privilege.TabIndex = 11;
            this.label_privilege.Text = "Danh Sách Quyền";
            this.label_privilege.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_revoke
            // 
            this.button_revoke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(151)))), ((int)(((byte)(108)))));
            this.button_revoke.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_revoke.FlatAppearance.BorderSize = 0;
            this.button_revoke.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.button_revoke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_revoke.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_revoke.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.button_revoke.Location = new System.Drawing.Point(547, 205);
            this.button_revoke.Name = "button_revoke";
            this.button_revoke.Size = new System.Drawing.Size(200, 50);
            this.button_revoke.TabIndex = 15;
            this.button_revoke.Text = "Thu Hồi Quyền";
            this.button_revoke.UseVisualStyleBackColor = false;
            this.button_revoke.Click += new System.EventHandler(this.button_revoke_Click);
            // 
            // button_grant
            // 
            this.button_grant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(151)))), ((int)(((byte)(108)))));
            this.button_grant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_grant.FlatAppearance.BorderSize = 0;
            this.button_grant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.button_grant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_grant.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_grant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.button_grant.Location = new System.Drawing.Point(206, 205);
            this.button_grant.Name = "button_grant";
            this.button_grant.Size = new System.Drawing.Size(200, 50);
            this.button_grant.TabIndex = 14;
            this.button_grant.Text = "Thêm Quyền";
            this.button_grant.UseVisualStyleBackColor = false;
            this.button_grant.Click += new System.EventHandler(this.button_grant_Click);
            // 
            // dgv_privilege
            // 
            this.dgv_privilege.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.dgv_privilege.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_privilege.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_privilege.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.dgv_privilege.Location = new System.Drawing.Point(0, 302);
            this.dgv_privilege.Name = "dgv_privilege";
            this.dgv_privilege.RowHeadersWidth = 51;
            this.dgv_privilege.RowTemplate.Height = 24;
            this.dgv_privilege.Size = new System.Drawing.Size(982, 260);
            this.dgv_privilege.TabIndex = 13;
            this.dgv_privilege.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_privilege_CellClick);
            // 
            // panel_MENU
            // 
            this.panel_MENU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(151)))), ((int)(((byte)(108)))));
            this.panel_MENU.Controls.Add(this.button_ROLE);
            this.panel_MENU.Controls.Add(this.button_SYS);
            this.panel_MENU.Controls.Add(this.button_TAB);
            this.panel_MENU.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_MENU.Location = new System.Drawing.Point(0, 559);
            this.panel_MENU.Name = "panel_MENU";
            this.panel_MENU.Size = new System.Drawing.Size(982, 67);
            this.panel_MENU.TabIndex = 16;
            // 
            // button_ROLE
            // 
            this.button_ROLE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(151)))), ((int)(((byte)(108)))));
            this.button_ROLE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ROLE.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_ROLE.FlatAppearance.BorderSize = 0;
            this.button_ROLE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.button_ROLE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.button_ROLE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ROLE.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_ROLE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.button_ROLE.Location = new System.Drawing.Point(327, 0);
            this.button_ROLE.Name = "button_ROLE";
            this.button_ROLE.Size = new System.Drawing.Size(328, 67);
            this.button_ROLE.TabIndex = 7;
            this.button_ROLE.Text = "User Trong Role";
            this.button_ROLE.UseVisualStyleBackColor = false;
            this.button_ROLE.Click += new System.EventHandler(this.button_ROLE_Click);
            // 
            // button_SYS
            // 
            this.button_SYS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(151)))), ((int)(((byte)(108)))));
            this.button_SYS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_SYS.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_SYS.FlatAppearance.BorderSize = 0;
            this.button_SYS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.button_SYS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.button_SYS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SYS.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_SYS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.button_SYS.Location = new System.Drawing.Point(655, 0);
            this.button_SYS.Name = "button_SYS";
            this.button_SYS.Size = new System.Drawing.Size(327, 67);
            this.button_SYS.TabIndex = 6;
            this.button_SYS.Text = "Quyền Trên Hệ Thống";
            this.button_SYS.UseVisualStyleBackColor = false;
            this.button_SYS.Click += new System.EventHandler(this.button_SYS_Click);
            // 
            // button_TAB
            // 
            this.button_TAB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(151)))), ((int)(((byte)(108)))));
            this.button_TAB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_TAB.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_TAB.FlatAppearance.BorderSize = 0;
            this.button_TAB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.button_TAB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.button_TAB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_TAB.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_TAB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.button_TAB.Location = new System.Drawing.Point(0, 0);
            this.button_TAB.Name = "button_TAB";
            this.button_TAB.Size = new System.Drawing.Size(327, 67);
            this.button_TAB.TabIndex = 4;
            this.button_TAB.Text = "Quyền Trên Bảng";
            this.button_TAB.UseVisualStyleBackColor = false;
            this.button_TAB.Click += new System.EventHandler(this.button_TAB_Click);
            // 
            // ADMIN_PRIVILEGE_ROLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(982, 626);
            this.Controls.Add(this.panel_MENU);
            this.Controls.Add(this.button_revoke);
            this.Controls.Add(this.button_grant);
            this.Controls.Add(this.label_privilege);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.dgv_privilege);
            this.Name = "ADMIN_PRIVILEGE_ROLE";
            this.Text = "ADMIN_PRIVILEGE_ROLE";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_privilege)).EndInit();
            this.panel_MENU.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Label label_privilege;
        private System.Windows.Forms.Button button_revoke;
        private System.Windows.Forms.Button button_grant;
        private System.Windows.Forms.DataGridView dgv_privilege;
        private System.Windows.Forms.Panel panel_MENU;
        private System.Windows.Forms.Button button_ROLE;
        private System.Windows.Forms.Button button_SYS;
        private System.Windows.Forms.Button button_TAB;
    }
}