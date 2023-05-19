namespace ATBMTHTTT
{
    partial class TP_PC
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.b_t = new System.Windows.Forms.Button();
            this.b_s = new System.Windows.Forms.Button();
            this.b_x = new System.Windows.Forms.Button();
            this.cbb_mnv = new System.Windows.Forms.ComboBox();
            this.label_tablename = new System.Windows.Forms.Label();
            this.cbb_mda = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_tg = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.dgv.Location = new System.Drawing.Point(0, 312);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(982, 314);
            this.dgv.TabIndex = 7;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Cambria", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(982, 50);
            this.label1.TabIndex = 6;
            this.label1.Text = "Phân Công";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // b_t
            // 
            this.b_t.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(151)))), ((int)(((byte)(108)))));
            this.b_t.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_t.FlatAppearance.BorderSize = 0;
            this.b_t.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.b_t.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_t.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.b_t.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.b_t.Location = new System.Drawing.Point(721, 90);
            this.b_t.Name = "b_t";
            this.b_t.Size = new System.Drawing.Size(200, 50);
            this.b_t.TabIndex = 14;
            this.b_t.Text = "Thêm";
            this.b_t.UseVisualStyleBackColor = false;
            this.b_t.Click += new System.EventHandler(this.b_t_Click);
            // 
            // b_s
            // 
            this.b_s.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(151)))), ((int)(((byte)(108)))));
            this.b_s.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_s.FlatAppearance.BorderSize = 0;
            this.b_s.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.b_s.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_s.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.b_s.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.b_s.Location = new System.Drawing.Point(721, 155);
            this.b_s.Name = "b_s";
            this.b_s.Size = new System.Drawing.Size(200, 50);
            this.b_s.TabIndex = 15;
            this.b_s.Text = "Sửa";
            this.b_s.UseVisualStyleBackColor = false;
            this.b_s.Click += new System.EventHandler(this.b_s_Click);
            // 
            // b_x
            // 
            this.b_x.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(151)))), ((int)(((byte)(108)))));
            this.b_x.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_x.FlatAppearance.BorderSize = 0;
            this.b_x.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.b_x.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_x.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.b_x.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.b_x.Location = new System.Drawing.Point(721, 222);
            this.b_x.Name = "b_x";
            this.b_x.Size = new System.Drawing.Size(200, 50);
            this.b_x.TabIndex = 16;
            this.b_x.Text = "Xóa";
            this.b_x.UseVisualStyleBackColor = false;
            this.b_x.Click += new System.EventHandler(this.b_x_Click);
            // 
            // cbb_mnv
            // 
            this.cbb_mnv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.cbb_mnv.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbb_mnv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.cbb_mnv.FormattingEnabled = true;
            this.cbb_mnv.Location = new System.Drawing.Point(192, 101);
            this.cbb_mnv.Name = "cbb_mnv";
            this.cbb_mnv.Size = new System.Drawing.Size(221, 31);
            this.cbb_mnv.TabIndex = 18;
            // 
            // label_tablename
            // 
            this.label_tablename.AutoSize = true;
            this.label_tablename.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_tablename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.label_tablename.Location = new System.Drawing.Point(47, 104);
            this.label_tablename.Name = "label_tablename";
            this.label_tablename.Size = new System.Drawing.Size(129, 23);
            this.label_tablename.TabIndex = 17;
            this.label_tablename.Text = "Mã Nhân Viên";
            // 
            // cbb_mda
            // 
            this.cbb_mda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.cbb_mda.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbb_mda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.cbb_mda.FormattingEnabled = true;
            this.cbb_mda.Location = new System.Drawing.Point(192, 166);
            this.cbb_mda.Name = "cbb_mda";
            this.cbb_mda.Size = new System.Drawing.Size(221, 31);
            this.cbb_mda.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.label2.Location = new System.Drawing.Point(47, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Mã Đề Án";
            // 
            // cbb_tg
            // 
            this.cbb_tg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.cbb_tg.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbb_tg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.cbb_tg.FormattingEnabled = true;
            this.cbb_tg.Location = new System.Drawing.Point(192, 233);
            this.cbb_tg.Name = "cbb_tg";
            this.cbb_tg.Size = new System.Drawing.Size(221, 31);
            this.cbb_tg.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.label3.Location = new System.Drawing.Point(47, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Thời Gian(h)";
            // 
            // TP_PC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(982, 626);
            this.Controls.Add(this.cbb_tg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbb_mda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbb_mnv);
            this.Controls.Add(this.label_tablename);
            this.Controls.Add(this.b_x);
            this.Controls.Add(this.b_s);
            this.Controls.Add(this.b_t);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label1);
            this.Name = "TP_PC";
            this.Text = "TP_PC";
            this.Load += new System.EventHandler(this.TP_PC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_t;
        private System.Windows.Forms.Button b_s;
        private System.Windows.Forms.Button b_x;
        private System.Windows.Forms.ComboBox cbb_mnv;
        private System.Windows.Forms.Label label_tablename;
        private System.Windows.Forms.ComboBox cbb_mda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_tg;
        private System.Windows.Forms.Label label3;
    }
}