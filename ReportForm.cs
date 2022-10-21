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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void pieChart_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {
            pieChart.ChildChanged -= pieChart_ChildChanged;
        }
    }
}
