using System;
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
    }
}
