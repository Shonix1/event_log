namespace WindowsFormsApp1
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.опцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокСистемныхАдминистраторовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокДДСЕДДСToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.event_log = new System.Windows.Forms.DataGridView();
            this.combo_box_name_admin = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.event_log)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.опцииToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1902, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // опцииToolStripMenuItem
            // 
            this.опцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокСистемныхАдминистраторовToolStripMenuItem,
            this.списокДДСЕДДСToolStripMenuItem});
            this.опцииToolStripMenuItem.Name = "опцииToolStripMenuItem";
            this.опцииToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.опцииToolStripMenuItem.Text = "Опции";
            // 
            // списокСистемныхАдминистраторовToolStripMenuItem
            // 
            this.списокСистемныхАдминистраторовToolStripMenuItem.Name = "списокСистемныхАдминистраторовToolStripMenuItem";
            this.списокСистемныхАдминистраторовToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.списокСистемныхАдминистраторовToolStripMenuItem.Text = "Список системных администраторов";
            this.списокСистемныхАдминистраторовToolStripMenuItem.Click += new System.EventHandler(this.списокСистемныхАдминистраторовToolStripMenuItem_Click);
            // 
            // списокДДСЕДДСToolStripMenuItem
            // 
            this.списокДДСЕДДСToolStripMenuItem.Name = "списокДДСЕДДСToolStripMenuItem";
            this.списокДДСЕДДСToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.списокДДСЕДДСToolStripMenuItem.Text = "Список ДДС/ЕДДС";
            this.списокДДСЕДДСToolStripMenuItem.Click += new System.EventHandler(this.списокДДСЕДДСToolStripMenuItem_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(51, 134);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(51, 61);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // event_log
            // 
            this.event_log.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.event_log.Location = new System.Drawing.Point(276, 61);
            this.event_log.Name = "event_log";
            this.event_log.Size = new System.Drawing.Size(901, 435);
            this.event_log.TabIndex = 3;
            this.event_log.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.event_log_CellContentClick);
            // 
            // combo_box_name_admin
            // 
            this.combo_box_name_admin.FormattingEnabled = true;
            this.combo_box_name_admin.Location = new System.Drawing.Point(51, 356);
            this.combo_box_name_admin.Name = "combo_box_name_admin";
            this.combo_box_name_admin.Size = new System.Drawing.Size(200, 21);
            this.combo_box_name_admin.TabIndex = 4;
            this.combo_box_name_admin.SelectedIndexChanged += new System.EventHandler(this.combo_box_name_admin_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 991);
            this.Controls.Add(this.combo_box_name_admin);
            this.Controls.Add(this.event_log);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1918, 1030);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Журнал событий";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.event_log)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem опцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокСистемныхАдминистраторовToolStripMenuItem;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ToolStripMenuItem списокДДСЕДДСToolStripMenuItem;
        private System.Windows.Forms.DataGridView event_log;
        private System.Windows.Forms.ComboBox combo_box_name_admin;
    }
}

