using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Hil5_CRM_Project.DialogBox;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Hil5_CRM_Project
{
    public partial class LeadsForm : Form
    {
        public LeadsForm()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddLead addlead = new AddLead();
            addlead.StartPosition = FormStartPosition.CenterScreen;
            addlead.ShowDialog();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (dgv_leads.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgv_leads.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgv_leads.Rows[selectedrowindex];
                string value = Convert.ToString(selectedRow.Cells["col_id"].Value);
                id = Int32.Parse(value);
            }
            // edit lead process.
            model.Leads lead = new model.Leads();
            DbAccess access = new DbAccess();
            lead = access.SearchLeads(id);
            Edit.EditLead editLead = new Edit.EditLead(lead);
            editLead.ShowDialog();

            // after update the lead referesh the data grid view.
            List<model.Leads> leads = null;
            DbAccess data = new DbAccess();
            leads = data.GetAllLeads();
           
            RefereshDGV(leads);
        }

        private void btn_pdfExport_Click(object sender, EventArgs e)
        {
            if (dgv_leads.Rows.Count > 0)
            {
                // dialog box on screen......
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = "leads.pdf";
                bool _errorMessage = false;

                // if the dilog box appears on the screen....
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            // if file are exist the same name ? : Dekete the file.
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            _errorMessage = true;
                            MessageBox.Show(ex.Message, "file error");
                        }
                    }
                    // if there is no error 
                    if (!_errorMessage)
                    {
                        try
                        {
                            PdfPTable Ptable = new PdfPTable(dgv_leads.Columns.Count);
                            Ptable.DefaultCell.Padding = 2;
                            Ptable.WidthPercentage = 100;
                            Ptable.HorizontalAlignment = Element.ALIGN_LEFT;
                            // writing on pdf sheet.
                            // header (Columens) (Atribures)
                            foreach (DataGridViewColumn col in dgv_leads.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                Ptable.AddCell(pCell);
                            }
                            // writing on pdf sheet.
                            // each records or rows.
                            foreach (DataGridViewRow row in dgv_leads.Rows)
                            {
                                foreach (DataGridViewCell dCell in row.Cells)
                                {
                                    Ptable.AddCell(dCell.Value.ToString());
                                }
                            }
                            // wirte on disk.
                            // opening the file stream.
                            // automatic closing by using using block.
                            using (FileStream filestream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document doc = new Document(PageSize.A4, 6f, 8f, 8f, 6f);
                                doc.Open();
                                doc.Add(Ptable);
                                doc.Close();
                                filestream.Close();
                                MessageBox.Show("Customer File saaved.", "info");
                            };
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "export error");
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("No reccord Found", "info");
            }
        }
        private void RefereshDGV(List<model.Leads> leads)
        {
            dgv_leads.Rows.Clear();
            foreach (model.Leads lead in leads)
            {
                dgv_leads.Rows.Add(new object[]
                {
                    imageList.Images[0],
                    lead.id,
                    lead.name,
                    lead.email,
                    lead.source,
                    lead.status,
                    lead.note,
                    lead.createDate,
                    lead.addedBy,
                    lead.status == "Lost" ? imageList.Images[1] : imageList.Images[2]
                });
            }
            int numRows = dgv_leads.Rows.Count;
            lb_leadFilter.Text = numRows.ToString();
        }
        private void LeadsForm_Load(object sender, EventArgs e)
        {
            List<model.Leads> leads = null;
            DbAccess data = new DbAccess();
            leads = data.GetAllLeads();
            RefereshDGV(leads);
        }

        private void btn_active_Click(object sender, EventArgs e)
        {
            List<model.Leads> leads = null;
            DbAccess data = new DbAccess();
            leads = data.GetActiveLeads();
            RefereshDGV(leads);
        }

        private void btn_closed_Click(object sender, EventArgs e)
        {
            List<model.Leads> leads = null;
            DbAccess data = new DbAccess();
            leads = data.GetClosedLeads();
            RefereshDGV(leads);
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            List<model.Leads> leads = null;
            DbAccess data = new DbAccess();
            leads = data.GetAllLeads();
            RefereshDGV(leads);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            // finding the id of which row are selected.
            int id = 0;
            if (dgv_leads.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgv_leads.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgv_leads.Rows[selectedrowindex];
                string value = Convert.ToString(selectedRow.Cells["col_id"].Value);
                id = Int32.Parse(value);
            }

            // delete from the database.
            DbAccess access = new DbAccess();
            access.DelLead(id);

            // refresh the data grid view.
            List<model.Leads> leads = null;
            DbAccess data = new DbAccess();
            leads = data.GetAllLeads();
            RefereshDGV(leads);
        }
    }
}
    