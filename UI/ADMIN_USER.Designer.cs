namespace ATBMTHTTT
{
    partial class ADMIN_USER
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_user = new System.Windows.Forms.DataGridView();
            this.label_username = new System.Windows.Forms.Label();
            this.comboBox_username = new System.Windows.Forms.ComboBox();
            this.button_them = new System.Windows.Forms.Button();
            this.button_xem = new System.Windows.Forms.Button();
            this.button_sua = new System.Windows.Forms.Button();
            this.button_xoa = new System.Windows.Forms.Button();
            this.button_rf = new System.Windows.Forms.Button();
            this.label_mk = new System.Windows.Forms.Label();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Cambria", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(982, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Users";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_user
            // 
            this.dgv_user.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_user.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.dgv_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_user.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_user.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_user.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_user.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.dgv_user.Location = new System.Drawing.Point(0, 352);
            this.dgv_user.Name = "dgv_user";
            this.dgv_user.RowHeadersWidth = 51;
            this.dgv_user.RowTemplate.Height = 24;
            this.dgv_user.Size = new System.Drawing.Size(982, 274);
            this.dgv_user.TabIndex = 1;
            this.dgv_user.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_user_CellClick);
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.label_username.Location = new System.Drawing.Point(29, 166);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(85, 23);
            this.label_username.TabIndex = 2;
            this.label_username.Text = "Tên User";
            // 
            // comboBox_username
            // 
            this.comboBox_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.comboBox_username.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.comboBox_username.FormattingEnabled = true;
            this.comboBox_username.Location = new System.Drawing.Point(174, 163);
            this.comboBox_username.Name = "comboBox_username";
            this.comboBox_username.Size = new System.Drawing.Size(221, 31);
            this.comboBox_username.TabIndex = 5;
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
            this.button_them.Location = new System.Drawing.Point(507, 94);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(200, 50);
            this.button_them.TabIndex = 9;
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
            this.button_xem.Location = new System.Drawing.Point(736, 242);
            this.button_xem.Name = "button_xem";
            this.button_xem.Size = new System.Drawing.Size(200, 50);
            this.button_xem.TabIndex = 8;
            this.button_xem.Text = "Xem Quyền";
            this.button_xem.UseVisualStyleBackColor = false;
            this.button_xem.Click += new System.EventHandler(this.button_xem_Click);
            // 
            // button_sua
            // 
            this.button_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(151)))), ((int)(((byte)(108)))));
            this.button_sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_sua.FlatAppearance.BorderSize = 0;
            this.button_sua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.button_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sua.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_sua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.button_sua.Location = new System.Drawing.Point(736, 94);
            this.button_sua.Name = "button_sua";
            this.button_sua.Size = new System.Drawing.Size(200, 50);
            this.button_sua.TabIndex = 11;
            this.button_sua.Text = "Sửa";
            this.button_sua.UseVisualStyleBackColor = false;
            this.button_sua.Click += new System.EventHandler(this.button_sua_Click);
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
            this.button_xoa.Location = new System.Drawing.Point(505, 242);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(200, 50);
            this.button_xoa.TabIndex = 10;
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
            this.button_rf.Location = new System.Drawing.Point(33, 242);
            this.button_rf.Name = "button_rf";
            this.button_rf.Size = new System.Drawing.Size(200, 50);
            this.button_rf.TabIndex = 19;
            this.button_rf.Text = "Làm Mới";
            this.button_rf.UseVisualStyleBackColor = false;
            this.button_rf.Click += new System.EventHandler(this.button_rf_Click);
            // 
            // label_mk
            // 
            this.label_mk.AutoSize = true;
            this.label_mk.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_mk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.label_mk.Location = new System.Drawing.Point(501, 169);
            this.label_mk.Name = "label_mk";
            this.label_mk.Size = new System.Drawing.Size(92, 23);
            this.label_mk.TabIndex = 20;
            this.label_mk.Text = "Mật Khẩu";
            // 
            // textBox_pass
            // 
            this.textBox_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.textBox_pass.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.textBox_pass.Location = new System.Drawing.Point(599, 166);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.Size = new System.Drawing.Size(349, 31);
            this.textBox_pass.TabIndex = 21;
            // 
            // ADMIN_USER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(982, 626);
            this.Controls.Add(this.textBox_pass);
            this.Controls.Add(this.label_mk);
            this.Controls.Add(this.button_rf);
            this.Controls.Add(this.button_sua);
            this.Controls.Add(this.button_xoa);
            this.Controls.Add(this.button_them);
            this.Controls.Add(this.button_xem);
            this.Controls.Add(this.comboBox_username);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.dgv_user);
            this.Controls.Add(this.label1);
            this.Name = "ADMIN_USER";
            this.Text = "ADMIN_USER";
            this.Load += new System.EventHandler(this.ADMIN_USER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_user;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.ComboBox comboBox_username;
        private System.Windows.Forms.Button button_them;
        private System.Windows.Forms.Button button_xem;
        private System.Windows.Forms.Button button_sua;
        private System.Windows.Forms.Button button_xoa;
        private System.Windows.Forms.Button button_rf;
        private System.Windows.Forms.Label label_mk;
        private System.Windows.Forms.TextBox textBox_pass;
    }
}