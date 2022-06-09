namespace WindowsFormsApp1
{
    partial class list_of_admin
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
            this.list_box_name_admin = new System.Windows.Forms.ListBox();
            this.button_add_admin = new System.Windows.Forms.Button();
            this.button_delete_name_admin = new System.Windows.Forms.Button();
            this.text_box_name_admin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // list_box_name_admin
            // 
            this.list_box_name_admin.FormattingEnabled = true;
            this.list_box_name_admin.Location = new System.Drawing.Point(14, 127);
            this.list_box_name_admin.Name = "list_box_name_admin";
            this.list_box_name_admin.Size = new System.Drawing.Size(211, 160);
            this.list_box_name_admin.TabIndex = 0;
            this.list_box_name_admin.SelectedIndexChanged += new System.EventHandler(this.list_box_name_admin_SelectedIndexChanged);
            // 
            // button_add_admin
            // 
            this.button_add_admin.Location = new System.Drawing.Point(240, 32);
            this.button_add_admin.Name = "button_add_admin";
            this.button_add_admin.Size = new System.Drawing.Size(153, 37);
            this.button_add_admin.TabIndex = 1;
            this.button_add_admin.Text = "Добавить системного администатора";
            this.button_add_admin.UseVisualStyleBackColor = true;
            this.button_add_admin.Click += new System.EventHandler(this.button_add_admin_Click);
            // 
            // button_delete_name_admin
            // 
            this.button_delete_name_admin.Location = new System.Drawing.Point(240, 127);
            this.button_delete_name_admin.Name = "button_delete_name_admin";
            this.button_delete_name_admin.Size = new System.Drawing.Size(153, 35);
            this.button_delete_name_admin.TabIndex = 2;
            this.button_delete_name_admin.Text = "Удалить системного администратора";
            this.button_delete_name_admin.UseVisualStyleBackColor = true;
            this.button_delete_name_admin.Click += new System.EventHandler(this.button_delete_name_admin_Click);
            // 
            // text_box_name_admin
            // 
            this.text_box_name_admin.Location = new System.Drawing.Point(15, 32);
            this.text_box_name_admin.Name = "text_box_name_admin";
            this.text_box_name_admin.Size = new System.Drawing.Size(210, 20);
            this.text_box_name_admin.TabIndex = 3;
            // 
            // list_of_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 386);
            this.Controls.Add(this.text_box_name_admin);
            this.Controls.Add(this.button_delete_name_admin);
            this.Controls.Add(this.button_add_admin);
            this.Controls.Add(this.list_box_name_admin);
            this.Name = "list_of_admin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список системных администраторов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list_box_name_admin;
        private System.Windows.Forms.Button button_add_admin;
        private System.Windows.Forms.Button button_delete_name_admin;
        private System.Windows.Forms.TextBox text_box_name_admin;
    }
}