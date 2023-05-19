namespace ATBMTHTTT
{
    partial class ADMIN_VIEW
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
            this.comboBox_viewname = new System.Windows.Forms.ComboBox();
            this.label_viewname = new System.Windows.Forms.Label();
            this.dgv_view = new System.Windows.Forms.DataGridView();
            this.label_view = new System.Windows.Forms.Label();
            this.button_xoá = new System.Windows.Forms.Button();
            this.button_rf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_view)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_viewname
            // 
            this.comboBox_viewname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.comboBox_viewname.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox_viewname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.comboBox_viewname.FormattingEnabled = true;
            this.comboBox_viewname.Location = new System.Drawing.Point(166, 173);
            this.comboBox_viewname.Name = "comboBox_viewname";
            this.comboBox_viewname.Size = new System.Drawing.Size(221, 31);
            this.comboBox_viewname.TabIndex = 9;
            // 
            // label_viewname
            // 
            this.label_viewname.AutoSize = true;
            this.label_viewname.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_viewname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.label_viewname.Location = new System.Drawing.Point(21, 176);
            this.label_viewname.Name = "label_viewname";
            this.label_viewname.Size = new System.Drawing.Size(88, 23);
            this.label_viewname.TabIndex = 8;
            this.label_viewname.Text = "Tên View";
            // 
            // dgv_view
            // 
            this.dgv_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_view.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.dgv_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_view.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_view.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_view.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.dgv_view.Location = new System.Drawing.Point(0, 352);
            this.dgv_view.Name = "dgv_view";
            this.dgv_view.RowHeadersWidth = 51;
            this.dgv_view.RowTemplate.Height = 24;
            this.dgv_view.Size = new System.Drawing.Size(982, 274);
            this.dgv_view.TabIndex = 7;
            this.dgv_view.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_view_CellClick);
            // 
            // label_view
            // 
            this.label_view.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_view.Font = new System.Drawing.Font("Cambria", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_view.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.label_view.Location = new System.Drawing.Point(0, 0);
            this.label_view.Name = "label_view";
            this.label_view.Size = new System.Drawing.Size(982, 50);
            this.label_view.TabIndex = 6;
            this.label_view.Text = "Danh Sách Views";
            this.label_view.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_xoá
            // 
            this.button_xoá.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(151)))), ((int)(((byte)(108)))));
            this.button_xoá.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_xoá.FlatAppearance.BorderSize = 0;
            this.button_xoá.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.button_xoá.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_xoá.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_xoá.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.button_xoá.Location = new System.Drawing.Point(451, 162);
            this.button_xoá.Name = "button_xoá";
            this.button_xoá.Size = new System.Drawing.Size(200, 50);
            this.button_xoá.TabIndex = 14;
            this.button_xoá.Text = "Xoá";
            this.button_xoá.UseVisualStyleBackColor = false;
            this.button_xoá.Click += new System.EventHandler(this.button_xoá_Click);
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
            this.button_rf.Location = new System.Drawing.Point(25, 229);
            this.button_rf.Name = "button_rf";
            this.button_rf.Size = new System.Drawing.Size(200, 50);
            this.button_rf.TabIndex = 20;
            this.button_rf.Text = "Làm Mới";
            this.button_rf.UseVisualStyleBackColor = false;
            this.button_rf.Click += new System.EventHandler(this.button_rf_Click);
            // 
            // ADMIN_VIEW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(982, 626);
            this.Controls.Add(this.button_rf);
            this.Controls.Add(this.button_xoá);
            this.Controls.Add(this.comboBox_viewname);
            this.Controls.Add(this.label_viewname);
            this.Controls.Add(this.dgv_view);
            this.Controls.Add(this.label_view);
            this.Name = "ADMIN_VIEW";
            this.Text = "ADMIN_VIEW";
            this.Load += new System.EventHandler(this.ADMIN_VIEW_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_viewname;
        private System.Windows.Forms.Label label_viewname;
        private System.Windows.Forms.DataGridView dgv_view;
        private System.Windows.Forms.Label label_view;
        private System.Windows.Forms.Button button_xoá;
        private System.Windows.Forms.Button button_rf;
    }
}