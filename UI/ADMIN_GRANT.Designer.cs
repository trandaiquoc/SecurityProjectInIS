namespace ATBMTHTTT
{
    partial class ADMIN_GRANT
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
            this.comboBox_priv = new System.Windows.Forms.ComboBox();
            this.label_privilege = new System.Windows.Forms.Label();
            this.comboBox_view = new System.Windows.Forms.ComboBox();
            this.label_view = new System.Windows.Forms.Label();
            this.comboBox_table = new System.Windows.Forms.ComboBox();
            this.label_table = new System.Windows.Forms.Label();
            this.comboBox_procedure = new System.Windows.Forms.ComboBox();
            this.label_procedure = new System.Windows.Forms.Label();
            this.button_grant = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.comboBox_Att = new System.Windows.Forms.ComboBox();
            this.label_Att = new System.Windows.Forms.Label();
            this.comboBox_role = new System.Windows.Forms.ComboBox();
            this.label_role = new System.Windows.Forms.Label();
            this.checkBox_ask = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // comboBox_priv
            // 
            this.comboBox_priv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.comboBox_priv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_priv.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox_priv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.comboBox_priv.FormattingEnabled = true;
            this.comboBox_priv.Items.AddRange(new object[] {
            "PUBLIC",
            "ALL PRIVILEGES",
            "SELECT",
            "INSERT",
            "UPDATE",
            "DELETE",
            "EXECUTE"});
            this.comboBox_priv.Location = new System.Drawing.Point(12, 63);
            this.comboBox_priv.Name = "comboBox_priv";
            this.comboBox_priv.Size = new System.Drawing.Size(221, 31);
            this.comboBox_priv.TabIndex = 16;
            this.comboBox_priv.SelectedIndexChanged += new System.EventHandler(this.comboBox_priv_SelectedIndexChanged);
            // 
            // label_privilege
            // 
            this.label_privilege.AutoSize = true;
            this.label_privilege.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_privilege.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.label_privilege.Location = new System.Drawing.Point(8, 26);
            this.label_privilege.Name = "label_privilege";
            this.label_privilege.Size = new System.Drawing.Size(65, 23);
            this.label_privilege.TabIndex = 15;
            this.label_privilege.Text = "Quyền";
            // 
            // comboBox_view
            // 
            this.comboBox_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.comboBox_view.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_view.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox_view.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.comboBox_view.FormattingEnabled = true;
            this.comboBox_view.Location = new System.Drawing.Point(12, 373);
            this.comboBox_view.Name = "comboBox_view";
            this.comboBox_view.Size = new System.Drawing.Size(221, 31);
            this.comboBox_view.TabIndex = 18;
            // 
            // label_view
            // 
            this.label_view.AutoSize = true;
            this.label_view.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_view.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.label_view.Location = new System.Drawing.Point(8, 336);
            this.label_view.Name = "label_view";
            this.label_view.Size = new System.Drawing.Size(53, 23);
            this.label_view.TabIndex = 17;
            this.label_view.Text = "View";
            // 
            // comboBox_table
            // 
            this.comboBox_table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.comboBox_table.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_table.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox_table.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.comboBox_table.FormattingEnabled = true;
            this.comboBox_table.Location = new System.Drawing.Point(12, 294);
            this.comboBox_table.Name = "comboBox_table";
            this.comboBox_table.Size = new System.Drawing.Size(221, 31);
            this.comboBox_table.TabIndex = 20;
            this.comboBox_table.SelectedIndexChanged += new System.EventHandler(this.comboBox_table_SelectedIndexChanged);
            // 
            // label_table
            // 
            this.label_table.AutoSize = true;
            this.label_table.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_table.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.label_table.Location = new System.Drawing.Point(8, 257);
            this.label_table.Name = "label_table";
            this.label_table.Size = new System.Drawing.Size(56, 23);
            this.label_table.TabIndex = 19;
            this.label_table.Text = "Table";
            // 
            // comboBox_procedure
            // 
            this.comboBox_procedure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.comboBox_procedure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_procedure.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox_procedure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.comboBox_procedure.FormattingEnabled = true;
            this.comboBox_procedure.Location = new System.Drawing.Point(289, 294);
            this.comboBox_procedure.Name = "comboBox_procedure";
            this.comboBox_procedure.Size = new System.Drawing.Size(221, 31);
            this.comboBox_procedure.TabIndex = 23;
            // 
            // label_procedure
            // 
            this.label_procedure.AutoSize = true;
            this.label_procedure.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_procedure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.label_procedure.Location = new System.Drawing.Point(285, 257);
            this.label_procedure.Name = "label_procedure";
            this.label_procedure.Size = new System.Drawing.Size(99, 23);
            this.label_procedure.TabIndex = 22;
            this.label_procedure.Text = "Procedure";
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
            this.button_grant.Location = new System.Drawing.Point(33, 162);
            this.button_grant.Name = "button_grant";
            this.button_grant.Size = new System.Drawing.Size(200, 50);
            this.button_grant.TabIndex = 24;
            this.button_grant.Text = "Xác Nhận";
            this.button_grant.UseVisualStyleBackColor = false;
            this.button_grant.Click += new System.EventHandler(this.button_grant_Click);
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
            this.button_exit.Location = new System.Drawing.Point(289, 162);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(200, 50);
            this.button_exit.TabIndex = 25;
            this.button_exit.Text = "Thoát";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // comboBox_Att
            // 
            this.comboBox_Att.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.comboBox_Att.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Att.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox_Att.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.comboBox_Att.FormattingEnabled = true;
            this.comboBox_Att.Location = new System.Drawing.Point(289, 373);
            this.comboBox_Att.Name = "comboBox_Att";
            this.comboBox_Att.Size = new System.Drawing.Size(221, 31);
            this.comboBox_Att.TabIndex = 27;
            // 
            // label_Att
            // 
            this.label_Att.AutoSize = true;
            this.label_Att.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_Att.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.label_Att.Location = new System.Drawing.Point(285, 336);
            this.label_Att.Name = "label_Att";
            this.label_Att.Size = new System.Drawing.Size(89, 23);
            this.label_Att.TabIndex = 26;
            this.label_Att.Text = "Attribute";
            // 
            // comboBox_role
            // 
            this.comboBox_role.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.comboBox_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_role.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox_role.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.comboBox_role.FormattingEnabled = true;
            this.comboBox_role.Location = new System.Drawing.Point(289, 63);
            this.comboBox_role.Name = "comboBox_role";
            this.comboBox_role.Size = new System.Drawing.Size(221, 31);
            this.comboBox_role.TabIndex = 29;
            // 
            // label_role
            // 
            this.label_role.AutoSize = true;
            this.label_role.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_role.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.label_role.Location = new System.Drawing.Point(285, 26);
            this.label_role.Name = "label_role";
            this.label_role.Size = new System.Drawing.Size(48, 23);
            this.label_role.TabIndex = 28;
            this.label_role.Text = "Role";
            // 
            // checkBox_ask
            // 
            this.checkBox_ask.AutoSize = true;
            this.checkBox_ask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_ask.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.checkBox_ask.Location = new System.Drawing.Point(157, 115);
            this.checkBox_ask.Name = "checkBox_ask";
            this.checkBox_ask.Size = new System.Drawing.Size(217, 27);
            this.checkBox_ask.TabIndex = 30;
            this.checkBox_ask.Text = "WITH GRANT OPTION";
            this.checkBox_ask.UseVisualStyleBackColor = true;
            // 
            // ADMIN_GRANT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(552, 468);
            this.Controls.Add(this.checkBox_ask);
            this.Controls.Add(this.comboBox_role);
            this.Controls.Add(this.label_role);
            this.Controls.Add(this.comboBox_Att);
            this.Controls.Add(this.label_Att);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_grant);
            this.Controls.Add(this.comboBox_procedure);
            this.Controls.Add(this.label_procedure);
            this.Controls.Add(this.comboBox_table);
            this.Controls.Add(this.label_table);
            this.Controls.Add(this.comboBox_view);
            this.Controls.Add(this.label_view);
            this.Controls.Add(this.comboBox_priv);
            this.Controls.Add(this.label_privilege);
            this.Name = "ADMIN_GRANT";
            this.Text = "ADMIN_GRANT";
            this.Load += new System.EventHandler(this.ADMIN_GRANT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_priv;
        private System.Windows.Forms.Label label_privilege;
        private System.Windows.Forms.ComboBox comboBox_view;
        private System.Windows.Forms.Label label_view;
        private System.Windows.Forms.ComboBox comboBox_table;
        private System.Windows.Forms.Label label_table;
        private System.Windows.Forms.ComboBox comboBox_procedure;
        private System.Windows.Forms.Label label_procedure;
        private System.Windows.Forms.Button button_grant;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.ComboBox comboBox_Att;
        private System.Windows.Forms.Label label_Att;
        private System.Windows.Forms.ComboBox comboBox_role;
        private System.Windows.Forms.Label label_role;
        private System.Windows.Forms.CheckBox checkBox_ask;
    }
}