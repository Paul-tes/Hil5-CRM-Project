using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddTeam
{
    public partial class TeamCard : UserControl
    {

        private string _names;

        public string Names
        {
            set { _names = value; lbl_name.Text = value; }
            get { return _names; }
        }

        private string _gender;

        public string Gender
        {
            get { return _gender; }
            set { _gender = value; lbl_gender.Text = value; }
        }

        private string _dept;

        public string Dept
        {
            get { return _dept; }
            set { _dept = value; lbl_dept.Text = value; }
        }
        public TeamCard()
        {
            InitializeComponent();
        }
    }
}
