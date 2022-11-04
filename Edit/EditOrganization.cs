using Hil5_CRM_Project.model;
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

namespace Hil5_CRM_Project.Edit
{
    public partial class EditOrganization : Form
    {
        public EditOrganization(Organization org)
        {
            InitializeComponent();
            txt_name.Text = org.name;
            txt_email.Text = org.email;
            txt_phone.Text = org.phone;
            txt_address.Text = org.addres;
            lbl_id.Text = org.id.ToString();
            if (org.logo != null)
                pictureBox_Logo.Image = ConvertByteArrayToImage(org.logo);
           
        }
        string imgLocation = "";

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Organization org = new Organization();
            org.id = int.Parse(lbl_id.Text);
            org.name = txt_name.Text;
            org.email = txt_email.Text;

            //logo
            org.logo = null;
            if (imgLocation != "")
            {
                FileStream fs = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(fs);
                org.logo = brs.ReadBytes((int)fs.Length);
            }
            else
            {
                org.logo = null;
            }

            org.phone = txt_phone.Text;
            org.addres = txt_address.Text;
            DbAccess dbaccess = new DbAccess();
            dbaccess.UpdateOrganization(org);
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

        private void btn_attach_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(.*jpg)| *.jpg | PNG files(.*png) | *.png | All Files(*.*) | *.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imgLocation = dialog.FileName;
                    pictureBox_Logo.ImageLocation = imgLocation;

                }
            }
            catch (Exception)
            {
                msg_dialogError.Show("An error has occured");
            }
        }
    }
}
