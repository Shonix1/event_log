using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class list_of_admin : Form
    {
        public list_of_admin()
        {
            InitializeComponent();
        }

        private void button_add_admin_Click(object sender, EventArgs e)
        {
            
            list_box_name_admin.Items.Add(text_box_name_admin.Text);
            text_box_name_admin.Clear();
        }

        private void button_delete_name_admin_Click(object sender, EventArgs e)
        {
            list_box_name_admin.Items.Remove(list_box_name_admin.SelectedItem);
        }

        private void list_box_name_admin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
