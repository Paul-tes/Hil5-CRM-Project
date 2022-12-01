using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
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

            // after adding the task referesh the data grid view.
            List<model.Task> tasks = null;
            DbAccess data = new DbAccess();
            tasks = data.GetAllTasks();
            RefereshDGV(tasks);
        }

        private void btn_pdfExport_Click(object sender, EventArgs e)
        {
            if (dgv_tasks.Rows.Count > 0)
            {
                // dialog box on screen......
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = "tasks.pdf";
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
                            PdfPTable Ptable = new PdfPTable(dgv_tasks.Columns.Count);
                            Ptable.DefaultCell.Padding = 2;
                            Ptable.WidthPercentage = 100;
                            Ptable.HorizontalAlignment = Element.ALIGN_LEFT;
                            // writing on pdf sheet.
                            // header (Columens) (Atribures)
                            foreach (DataGridViewColumn col in dgv_tasks.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                Ptable.AddCell(pCell);
                            }
                            // writing on pdf sheet.
                            // each records or rows.
                            foreach (DataGridViewRow row in dgv_tasks.Rows)
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
        public void RefereshDGV(List<model.Task> tasks)
        {
            dgv_tasks.Rows.Clear();
            foreach (model.Task task in tasks)
            {
                dgv_tasks.Rows.Add(new object[]
                {
                    imageList.Images[0],
                    task.id,
                    task.name,
                    task.status,
                    task.referType,
                    task.referName,
                    task.priority,
                    task.note,
                    DateTime.Now,
                    task.addedBy,
                    task.status == "In Progress" || task.status == "New" ? imageList.Images[1] : imageList.Images[2]
                });
            }
            int numRows = dgv_tasks.Rows.Count;
            lb_taskFilter.Text = numRows.ToString();
        }
        private void TaskForm_Load(object sender, EventArgs e)
        {
            List<model.Task> tasks = null;
            DbAccess data = new DbAccess();
            tasks = data.GetAllTasks();
            RefereshDGV(tasks);
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            List<model.Task> tasks = null;
            DbAccess data = new DbAccess();
            tasks = data.GetAllTasks();
            RefereshDGV(tasks);

        }

        private void btn_active_Click(object sender, EventArgs e)
        {
            List<model.Task> tasks = null;
            DbAccess data = new DbAccess();
            tasks = data.GetProgressTask();
            RefereshDGV(tasks);
        }

        private void btn_onleave_Click(object sender, EventArgs e)
        {
            List<model.Task> tasks = null;
            DbAccess data = new DbAccess();
            tasks = data.GetDoneTasks();
            RefereshDGV(tasks);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            // finding the id of which row are selected.
            int id = 0;
            if (dgv_tasks.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgv_tasks.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgv_tasks.Rows[selectedrowindex];
                string value = Convert.ToString(selectedRow.Cells["col_id"].Value);
                id = Int32.Parse(value);
            }

            // edit task process.
            model.Task task = new model.Task();
            DbAccess access = new DbAccess();
            task = access.SearchTasks(id);
            Edit.EditTask editTask = new Edit.EditTask(task);
            editTask.ShowDialog();

            // after update the task referesh the data grid view.
            List<model.Task> tasks = null;
            DbAccess data = new DbAccess();
            tasks = data.GetAllTasks();
            RefereshDGV(tasks);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            // finding the id of which row are selected.
            int id = 0;
            if (dgv_tasks.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgv_tasks.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgv_tasks.Rows[selectedrowindex];
                string value = Convert.ToString(selectedRow.Cells["col_id"].Value);
                id = Int32.Parse(value);
            }

            // delete from the database.
            DbAccess access = new DbAccess();
            access.DelTask(id);

            // after update the task referesh the data grid view.
            List<model.Task> tasks = null;
            DbAccess data = new DbAccess();
            tasks = data.GetAllTasks();
            RefereshDGV(tasks);

        }
    }
}
            