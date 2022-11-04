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
    public partial class EditCustomers : Form
    {
        public EditCustomers(Customers cust)
        {
            InitializeComponent();
            txt_Name.Text = cust.name;
            txt_email.Text = cust.email;
            txt_city.Text = cust.city;
            txt_country.Text = cust.country;
            txt_phone.Text = cust.mobile;
            if (cust.website != null)
            txt_WebUrl.Text = cust.website;
            if (cust.photo != null)
                pictureBox_customer.Image = ConvertByteArrayToImage(cust.photo);
            txt_zip.Text = cust.zip;
            List<int> idListOfTeam = new List<int>() { 1, 2, 3 };
            cmb_addedby.DataSource = idListOfTeam;
            dtp_addedDate.Value = cust.addedDate;
            cmb_addedby.SelectedItem = cust.addedBy;

            lbl_id.Text = cust.id.ToString(); 
        }
       
        private void btn_edit_Click(object sender, EventArgs e)
        {
            Customers cust = new Customers();
            cust.id = int.Parse(lbl_id.Text);
            cust.name = txt_Name.Text;
            cust.email = txt_email.Text;    
            cust.city = txt_city.Text;
            cust.country = txt_country.Text;
            cust.addedDate = dtp_addedDate.Value;
            cust.addedBy = (int)cmb_addedby.SelectedItem;
            if (chk_status.Checked)
                cust.status = true;
            else
                cust.status = false;
            cust.mobile = txt_phone.Text;
            if (txt_WebUrl.Text != null)
                cust.website = txt_WebUrl.Text;
            else
                cust.website = null;

            if (pictureBox_customer != null)
                cust.photo = ConvertImageToBytes(pictureBox_customer.Image);
            cust.zip = txt_zip.Text;
            DbAccess dbaccess = new DbAccess();
            dbaccess.UpdateCustomer(cust);
        }

        //image to array
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

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
