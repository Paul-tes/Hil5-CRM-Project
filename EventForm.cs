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
    public partial class EventForm : Form
    {
        public EventForm()
        {
            InitializeComponent();
        }

      
        private void btn_add_Click(object sender, EventArgs e)
        {
            DialogBox.AddEvent addevent = new DialogBox.AddEvent();
            addevent.StartPosition = FormStartPosition.CenterScreen;
            addevent.ShowDialog();
        }

        private void btn_pdfExport_Click(object sender, EventArgs e)
        {

        }
    }
}
