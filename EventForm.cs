using iTextSharp.text;
using iTextSharp.text.pdf;
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
            if (dgv_event.Rows.Count > 0)
            {
                // dialog box on screen......
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = "events.pdf";
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
                            PdfPTable Ptable = new PdfPTable(dgv_event.Columns.Count);
                            Ptable.DefaultCell.Padding = 2;
                            Ptable.WidthPercentage = 100;
                            Ptable.HorizontalAlignment = Element.ALIGN_LEFT;
                            // writing on pdf sheet.
                            // header (Columens) (Atribures)
                            foreach (DataGridViewColumn col in dgv_event.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                Ptable.AddCell(pCell);
                            }
                            // writing on pdf sheet.
                            // each records or rows.
                            foreach (DataGridViewRow row in dgv_event.Rows)
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
        private void RefereshDgv(List<model.Events> events)
        {
            // before populating the data grid view clear all rows.
            dgv_event.Rows.Clear();

            //List<model.Events> events = null;
           // DbAccess data = new DbAccess();
            //dgv_event.DataSource = events;
            foreach (model.Events eve in events)
            {
                dgv_event.Rows.Add(new object[]
                {
                   imageList.Images[0],
                    eve.id,
                    eve.topic,
                    eve.type,
                    eve.addedBy,
                    eve.note,
                    eve.startDate,
                    eve.endDate,
                    eve.status == "passed" ? imageList.Images[2] : imageList.Images[1]
                }); ;

            }
            int numRows = dgv_event.Rows.Count;
            lb_eventFilter.Text = numRows.ToString();
        }
        private void EventForm_Load(object sender, EventArgs e)
        {
            // Ehen the form Loads by Default all events are populated on the data grid view.
            List<model.Events> events = null;
            DbAccess data = new DbAccess();
            events = data.GetAllEvents();
            RefereshDgv(events);


        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            // All button populates all events to the data grid view
            List<model.Events> events = null;
            DbAccess data = new DbAccess();
            events = data.GetAllEvents();
            RefereshDgv(events);

        }

        private void btn_active_Click(object sender, EventArgs e)
        {
            // Active button populates all active events to the data grid view.
            List<model.Events> events = null;
            DbAccess data = new DbAccess();
            events = data.GetUpCommingEvents();
            RefereshDgv(events);
        }

        private void btn_onleave_Click(object sender, EventArgs e)
        {
            // On leave button populates all onleave events are populated in to the data grid view.
            List<model.Events> events = null;
            DbAccess data = new DbAccess();
            events = data.GetUpCommingEvents();
            RefereshDgv(events);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }
    }
}
