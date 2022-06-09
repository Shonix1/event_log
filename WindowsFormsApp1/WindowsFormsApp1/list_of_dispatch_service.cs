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
    public partial class list_of_dispatch_service : Form
    {
        public list_of_dispatch_service()
        {
            InitializeComponent();
        }

        private void button_add_new_dispatch_servece_Click(object sender, EventArgs e)
        {
            list_box_dispatch_service.Items.Add(text_box_dispatch_service.Text);
            text_box_dispatch_service.Clear();
        }

        private void delete_dispatch_service_Click(object sender, EventArgs e)
        {
            list_box_dispatch_service.Items.Remove(list_box_dispatch_service.SelectedItem);
        }
    }
}
