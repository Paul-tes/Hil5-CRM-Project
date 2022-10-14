using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hil5_CRM_Project
{
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                dgv_customor.Rows.Add(new object[]
                {
                    imageList1.Images[0]
                });
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                dgv_customor.Rows.Add(new object[]
                {
                    imageList1.Images[0]
                });
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }
    }
}
