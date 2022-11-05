using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private byte[] _pic;
        public byte[] Pic
        {
            get { return _pic; }

            set { _pic = value; if(value != null)pic_team.Image = ConvertByteArrayToImage(value); }
        }
        byte[] ConvertImageToBytes(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        // array to image
        public Image ConvertByteArrayToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
        public TeamCard()
        {
            InitializeComponent();
            
        }

       
    }
}
