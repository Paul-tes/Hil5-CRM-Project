using System;
using System.Windows.Forms;

namespace Hil5_CRM_Project
{
    public partial class TaskForm : Form
    {
        public TaskForm()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DialogBox.AddTask addevent = new DialogBox.AddTask();
            addevent.StartPosition = FormStartPosition.CenterParent;
            addevent.ShowDialog();
        }
    }
}
