using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        DataTable table;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void списокСистемныхАдминистраторовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(list_of_admin frm = new list_of_admin())
            {
                frm.ShowDialog();
            }
        }

        private void списокДДСЕДДСToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (list_of_dispatch_service frm = new list_of_dispatch_service())
            {
                frm.ShowDialog();
            }
        }

        private void event_log_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("");
        }

        private void combo_box_name_admin_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
