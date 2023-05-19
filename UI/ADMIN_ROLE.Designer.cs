namespace ATBMTHTTT
{
    partial class ADMIN_ROLE
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
            this.label_roles = new System.Windows.Forms.Label();
            this.dgv_role = new System.Windows.Forms.DataGridView();
            this.button_them = new System.Windows.Forms.Button();
            this.button_xem = new System.Windows.Forms.Button();
            this.comboBox_rolename = new System.Windows.Forms.ComboBox();
            this.label_rolename = new System.Windows.Forms.Label();
            this.button_xoa = new System.Windows.Forms.Button();
            this.button_rf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_role)).BeginInit();
            this.SuspendLayout();
            // 
            // label_roles
            // 
            this.label_roles.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_roles.Font = new System.Drawing.Font("Cambria", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_roles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.label_roles.Location = new System.Drawing.Point(0, 0);
            this.label_roles.Name = "label_roles";
            this.label_roles.Size = new System.Drawing.Size(982, 50);
            this.label_roles.TabIndex = 1;
            this.label_roles.Text = "Danh Sách Roles";
            this.label_roles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_role
            // 
            this.dgv_role.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_role.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.dgv_role.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_role.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_role.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_role.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.dgv_role.Location = new System.Drawing.Point(0, 312);
            this.dgv_role.Name = "dgv_role";
            this.dgv_role.RowHeadersWidth = 51;
            this.dgv_role.RowTemplate.Height = 24;
            this.dgv_role.Size = new System.Drawing.Size(982, 314);
            this.dgv_role.TabIndex = 2;
            this.dgv_role.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_role_CellClick);
            // 
            // button_them
            // 
            this.button_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(151)))), ((int)(((byte)(108)))));
            this.button_them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_them.FlatAppearance.BorderSize = 0;
            this.button_them.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.button_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_them.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_them.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.button_them.Location = new System.Drawing.Point(581, 145);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(231, 50);
            this.button_them.TabIndex = 16;
            this.button_them.Text = "Thêm";
            this.button_them.UseVisualStyleBackColor = false;
            this.button_them.Click += new System.EventHandler(this.button_them_Click);
            // 
            // button_xem
            // 
            this.button_xem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(151)))), ((int)(((byte)(108)))));
            this.button_xem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_xem.FlatAppearance.BorderSize = 0;
            this.button_xem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.button_xem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_xem.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_xem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.button_xem.Location = new System.Drawing.Point(581, 89);
            this.button_xem.Name = "button_xem";
            this.button_xem.Size = new System.Drawing.Size(231, 50);
            this.button_xem.TabIndex = 15;
            this.button_xem.Text = "Xem Quyền và Users";
            this.button_xem.UseVisualStyleBackColor = false;
            this.button_xem.Click += new System.EventHandler(this.button_xem_Click);
            // 
            // comboBox_rolename
            // 
            this.comboBox_rolename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.comboBox_rolename.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox_rolename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.comboBox_rolename.FormattingEnabled = true;
            this.comboBox_rolename.Location = new System.Drawing.Point(116, 156);
            this.comboBox_rolename.Name = "comboBox_rolename";
            this.comboBox_rolename.Size = new System.Drawing.Size(269, 31);
            this.comboBox_rolename.TabIndex = 13;
            // 
            // label_rolename
            // 
            this.label_rolename.AutoSize = true;
            this.label_rolename.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_rolename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.label_rolename.Location = new System.Drawing.Point(27, 159);
            this.label_rolename.Name = "label_rolename";
            this.label_rolename.Size = new System.Drawing.Size(83, 23);
            this.label_rolename.TabIndex = 11;
            this.label_rolename.Text = "Tên Role";
            // 
            // button_xoa
            // 
            this.button_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(151)))), ((int)(((byte)(108)))));
            this.button_xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_xoa.FlatAppearance.BorderSize = 0;
            this.button_xoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.button_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_xoa.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_xoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.button_xoa.Location = new System.Drawing.Point(581, 201);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(231, 50);
            this.button_xoa.TabIndex = 17;
            this.button_xoa.Text = "Xóa";
            this.button_xoa.UseVisualStyleBackColor = false;
            this.button_xoa.Click += new System.EventHandler(this.button_xoa_Click);
            // 
            // button_rf
            // 
            this.button_rf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(151)))), ((int)(((byte)(108)))));
            this.button_rf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_rf.FlatAppearance.BorderSize = 0;
            this.button_rf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.button_rf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_rf.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_rf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.button_rf.Location = new System.Drawing.Point(31, 201);
            this.button_rf.Name = "button_rf";
            this.button_rf.Size = new System.Drawing.Size(200, 50);
            this.button_rf.TabIndex = 18;
            this.button_rf.Text = "Làm Mới";
            this.button_rf.UseVisualStyleBackColor = false;
            this.button_rf.Click += new System.EventHandler(this.button_rf_Click);
            // 
            // ADMIN_ROLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(982, 626);
            this.Controls.Add(this.button_rf);
            this.Controls.Add(this.button_xoa);
            this.Controls.Add(this.button_them);
            this.Controls.Add(this.button_xem);
            this.Controls.Add(this.comboBox_rolename);
            this.Controls.Add(this.label_rolename);
            this.Controls.Add(this.dgv_role);
            this.Controls.Add(this.label_roles);
            this.Name = "ADMIN_ROLE";
            this.Text = "ADMIN_ROLE";
            this.Load += new System.EventHandler(this.ADMIN_ROLE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_role)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_roles;
        private System.Windows.Forms.DataGridView dgv_role;
        private System.Windows.Forms.Button button_them;
        private System.Windows.Forms.Button button_xem;
        private System.Windows.Forms.ComboBox comboBox_rolename;
        private System.Windows.Forms.Label label_rolename;
        private System.Windows.Forms.Button button_xoa;
        private System.Windows.Forms.Button button_rf;
    }
}