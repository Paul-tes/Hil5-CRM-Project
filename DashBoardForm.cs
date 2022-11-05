using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AddTeam;
using Hil5_CRM_Project.DialogBox;
namespace Hil5_CRM_Project
{
    public partial class DashBoardForm : Form
    {
        string con = "";
        public DashBoardForm()
        {
            InitializeComponent();
        }

        private void DashBoardForm_Load(object sender, EventArgs e)
        {
            SqlHelper sqlhelper = new SqlHelper(con);

            if (sqlhelper.isConnected())
            {
                SqlCommand cmd = new SqlCommand("SELECT COUNT(id) FROM customers;", sqlhelper.connection());
                lb_NoCustomers.Text = cmd.ExecuteScalar().ToString();
                cmd = new SqlCommand("SELECT COUNT(id) FROM leads;", sqlhelper.connection());
                lb_NoLeads.Text = cmd.ExecuteScalar().ToString();
                cmd = new SqlCommand("SELECT COUNT(id) FROM events;", sqlhelper.connection());
                lb_NoEvents.Text = cmd.ExecuteScalar().ToString();
                cmd = new SqlCommand("SELECT COUNT(id) FROM tasks;", sqlhelper.connection());
                lb_NoTasks.Text = cmd.ExecuteScalar().ToString();
            }
            sqlhelper.close();
        }

        private void btn_addTeam_Click(object sender, EventArgs e)
        {
            DialogBox.AddTeam addTeam = new DialogBox.AddTeam();
            addTeam.ShowDialog();
        }

        private void btn_showTeam_Click(object sender, EventArgs e)
        {
            /*
              model.Leads lead = new model.Leads();
            DbAccess access = new DbAccess();
            lead = access.SearchLeads(id);
            Edit.EditLead editLead = new Edit.EditLead(lead);
            editLead.ShowDialog();

            // after update the lead referesh the data grid view.
            List<model.Leads> leads = null;
            DbAccess data = new DbAccess();
            leads = data.GetAllLeads();
             */
            // Team custom car operations.
            int i = 0;
            int j = -1;
        
            List<model.Team> teams = new List<model.Team>();
           // teams = .getAllTeam();
            DbAccess data = new DbAccess();
            teams = data.GetAllTeam();
            TeamDetails[] teamDetails = new TeamDetails[teams.Count];
            flp_team.Controls.Clear();
            foreach (var item in teams)
            {

                TeamCard teamC = new TeamCard();
                teamC.Dept = item.departement;
                teamC.Gender = item.gender;
                teamC.Names = item.name;
                if(item.picture != null)
                    teamC.Pic = item.picture;
                ++j;
                if(j % 4 == 0)
                {
                    teamC.BackColor = Color.FromArgb(20, 170, 249);
                }
               
                else if (j % 4 == 1)
                {
                    teamC.BackColor = Color.FromArgb(105, 40, 201);
                }
            
                else if (j % 4 == 2)
                {
                    teamC.BackColor = Color.FromArgb(150, 26, 16);
                }
                    
                else if (j % 4 == 3)
                {
                    teamC.BackColor = Color.FromArgb(31, 172, 82);
                }
                 

                teamC.Click += (Object o, EventArgs ea) =>
                {
                    teamDetails[i] = new TeamDetails(item);
                    //teamDetails[i].Hide();
                    teamDetails[i].Show();
                    //MessageBox.Show("Hello " + teamC.Names +  "\n" + teamC.Gender);
                    if (i < teams.Count - 1)
                        i++;
                };
                flp_team.Controls.Add(teamC);
            }
        }
    }
    }

