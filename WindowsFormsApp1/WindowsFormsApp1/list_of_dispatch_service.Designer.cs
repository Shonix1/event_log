namespace WindowsFormsApp1
{
    partial class list_of_dispatch_service
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
            this.text_box_dispatch_service = new System.Windows.Forms.TextBox();
            this.list_box_dispatch_service = new System.Windows.Forms.ListBox();
            this.button_add_new_dispatch_servece = new System.Windows.Forms.Button();
            this.delete_dispatch_service = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_box_dispatch_service
            // 
            this.text_box_dispatch_service.Location = new System.Drawing.Point(45, 39);
            this.text_box_dispatch_service.Name = "text_box_dispatch_service";
            this.text_box_dispatch_service.Size = new System.Drawing.Size(154, 20);
            this.text_box_dispatch_service.TabIndex = 0;
            // 
            // list_box_dispatch_service
            // 
            this.list_box_dispatch_service.FormattingEnabled = true;
            this.list_box_dispatch_service.Location = new System.Drawing.Point(45, 121);
            this.list_box_dispatch_service.Name = "list_box_dispatch_service";
            this.list_box_dispatch_service.Size = new System.Drawing.Size(161, 290);
            this.list_box_dispatch_service.TabIndex = 1;
            // 
            // button_add_new_dispatch_servece
            // 
            this.button_add_new_dispatch_servece.Location = new System.Drawing.Point(245, 39);
            this.button_add_new_dispatch_servece.Name = "button_add_new_dispatch_servece";
            this.button_add_new_dispatch_servece.Size = new System.Drawing.Size(111, 36);
            this.button_add_new_dispatch_servece.TabIndex = 2;
            this.button_add_new_dispatch_servece.Text = "Добавить службу";
            this.button_add_new_dispatch_servece.UseVisualStyleBackColor = true;
            this.button_add_new_dispatch_servece.Click += new System.EventHandler(this.button_add_new_dispatch_servece_Click);
            // 
            // delete_dispatch_service
            // 
            this.delete_dispatch_service.Location = new System.Drawing.Point(245, 121);
            this.delete_dispatch_service.Name = "delete_dispatch_service";
            this.delete_dispatch_service.Size = new System.Drawing.Size(111, 39);
            this.delete_dispatch_service.TabIndex = 3;
            this.delete_dispatch_service.Text = "Удалить службу";
            this.delete_dispatch_service.UseVisualStyleBackColor = true;
            this.delete_dispatch_service.Click += new System.EventHandler(this.delete_dispatch_service_Click);
            // 
            // list_of_dispatch_service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 443);
            this.Controls.Add(this.delete_dispatch_service);
            this.Controls.Add(this.button_add_new_dispatch_servece);
            this.Controls.Add(this.list_box_dispatch_service);
            this.Controls.Add(this.text_box_dispatch_service);
            this.Name = "list_of_dispatch_service";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Службы ДДС/ЕДДС";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_box_dispatch_service;
        private System.Windows.Forms.ListBox list_box_dispatch_service;
        private System.Windows.Forms.Button button_add_new_dispatch_servece;
        private System.Windows.Forms.Button delete_dispatch_service;
    }
}