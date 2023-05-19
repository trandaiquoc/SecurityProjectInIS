namespace ATBMTHTTT
{
    partial class ADMIN_TABLE
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_table = new System.Windows.Forms.Label();
            this.comboBox_tablename = new System.Windows.Forms.ComboBox();
            this.label_tablename = new System.Windows.Forms.Label();
            this.dgv_table = new System.Windows.Forms.DataGridView();
            this.button_them = new System.Windows.Forms.Button();
            this.button_rf = new System.Windows.Forms.Button();
            this.button_xoa = new System.Windows.Forms.Button();
            this.oracleDataAdapter1 = new Oracle.ManagedDataAccess.Client.OracleDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).BeginInit();
            this.SuspendLayout();
            // 
            // label_table
            // 
            this.label_table.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_table.Font = new System.Drawing.Font("Cambria", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_table.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.label_table.Location = new System.Drawing.Point(0, 0);
            this.label_table.Name = "label_table";
            this.label_table.Size = new System.Drawing.Size(982, 50);
            this.label_table.TabIndex = 7;
            this.label_table.Text = "Danh Sách Tables";
            this.label_table.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_tablename
            // 
            this.comboBox_tablename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.comboBox_tablename.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox_tablename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.comboBox_tablename.FormattingEnabled = true;
            this.comboBox_tablename.Location = new System.Drawing.Point(166, 163);
            this.comboBox_tablename.Name = "comboBox_tablename";
            this.comboBox_tablename.Size = new System.Drawing.Size(221, 31);
            this.comboBox_tablename.TabIndex = 12;
            // 
            // label_tablename
            // 
            this.label_tablename.AutoSize = true;
            this.label_tablename.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_tablename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.label_tablename.Location = new System.Drawing.Point(21, 166);
            this.label_tablename.Name = "label_tablename";
            this.label_tablename.Size = new System.Drawing.Size(91, 23);
            this.label_tablename.TabIndex = 11;
            this.label_tablename.Text = "Tên Table";
            // 
            // dgv_table
            // 
            this.dgv_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_table.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.dgv_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_table.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_table.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_table.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.dgv_table.Location = new System.Drawing.Point(0, 352);
            this.dgv_table.Name = "dgv_table";
            this.dgv_table.RowHeadersWidth = 51;
            this.dgv_table.RowTemplate.Height = 24;
            this.dgv_table.Size = new System.Drawing.Size(982, 274);
            this.dgv_table.TabIndex = 10;
            this.dgv_table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_table_CellClick);
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
            this.button_them.Location = new System.Drawing.Point(645, 125);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(200, 50);
            this.button_them.TabIndex = 13;
            this.button_them.Text = "Thêm";
            this.button_them.UseVisualStyleBackColor = false;
            this.button_them.Click += new System.EventHandler(this.button_them_Click);
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
            this.button_rf.Location = new System.Drawing.Point(25, 214);
            this.button_rf.Name = "button_rf";
            this.button_rf.Size = new System.Drawing.Size(200, 50);
            this.button_rf.TabIndex = 19;
            this.button_rf.Text = "Làm Mới";
            this.button_rf.UseVisualStyleBackColor = false;
            this.button_rf.Click += new System.EventHandler(this.button_rf_Click);
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
            this.button_xoa.Location = new System.Drawing.Point(645, 187);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(200, 50);
            this.button_xoa.TabIndex = 20;
            this.button_xoa.Text = "Xoá";
            this.button_xoa.UseVisualStyleBackColor = false;
            this.button_xoa.Click += new System.EventHandler(this.button_xoa_Click);
            // 
            // ADMIN_TABLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(982, 626);
            this.Controls.Add(this.button_xoa);
            this.Controls.Add(this.button_rf);
            this.Controls.Add(this.button_them);
            this.Controls.Add(this.comboBox_tablename);
            this.Controls.Add(this.label_tablename);
            this.Controls.Add(this.dgv_table);
            this.Controls.Add(this.label_table);
            this.Name = "ADMIN_TABLE";
            this.Text = "ADMIN_TABLE";
            this.Load += new System.EventHandler(this.ADMIN_TABLE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_table;
        private System.Windows.Forms.ComboBox comboBox_tablename;
        private System.Windows.Forms.Label label_tablename;
        private System.Windows.Forms.DataGridView dgv_table;
        private System.Windows.Forms.Button button_them;
        private System.Windows.Forms.Button button_rf;
        private System.Windows.Forms.Button button_xoa;
        private Oracle.ManagedDataAccess.Client.OracleDataAdapter oracleDataAdapter1;
    }
}