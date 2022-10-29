using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Hil5_CRM_Project.model;
using System.Data;

namespace Hil5_CRM_Project
{

    internal class DbAccess
    {
        string con = String.Format("server ={0}; Database = {1};Integrated security = {2}; uid = {3}; pwd = {4};", "DESKTOP-V03ADMS", "CRM_PROJECT", "false", "TeamAdmin Login", "txt_pswd.Text");

        // No: of Evetns.
        public int NoEvents()
        {
            SqlHelper sqlhelper = new SqlHelper(con);

            if (sqlhelper.isConnected())
            {
                // do database operation





            }
            sqlhelper.close();
            return 0;
        }
        // No: of Tasks.
        public int NoTasks()
        {
            SqlHelper sqlhelper = new SqlHelper(con);

            if (sqlhelper.isConnected())
            {
                // do database operation





            }
            sqlhelper.close();
            return 0;
        }
        // No: of Customers.
        public int NoCustomers()
        {
            SqlHelper sqlhelper = new SqlHelper(con);

            if (sqlhelper.isConnected())
            {
                // do database operation





            }
            sqlhelper.close();
            return 0;
        }
        //No: Leads.
        public int NoLeads()
        {
            SqlHelper sqlhelper = new SqlHelper(con);

            if (sqlhelper.isConnected())
            {
                // do database operation





            }
            sqlhelper.close();
            return 0;
        }
        // ----------------------------------------------------------Customer DB Access methods-------------------------------------------------------------
        // All Customers
        public List<Customers> GetAllCustomers()
        {
            SqlHelper sqlhelper = new SqlHelper(con);

            if (sqlhelper.isConnected())
            {
                // do database operation





            }
            sqlhelper.close();
            return new List<Customers>();
        }
        // Active Customers.
        public List<Customers> GetActiveCustomers()
        {
            SqlHelper sqlhelper = new SqlHelper(con);

            if (sqlhelper.isConnected())
            {
                // do database operation





            }
            sqlhelper.close();
            return new List<Customers>();
        }
        // On Leave Customer.
        public List<Customers> GetOnLeavCustomers()
        {
            SqlHelper sqlhelper = new SqlHelper(con);

            if (sqlhelper.isConnected())
            {
                // do database operation





            }
            sqlhelper.close();
            return new List<Customers>();
        }
        // Promoted Customer
        public List<Customers> GetPromotedCustomers()
        {
            SqlHelper sqlhelper = new SqlHelper(con);

            if (sqlhelper.isConnected())
            {
                // do database operation





            }
            sqlhelper.close();
            return new List<Customers>();
        }
        // search by id from customers record.
        public List<Customers> SearchCustomers(int id)
        {
            SqlHelper sqlhelper = new SqlHelper(con);

            if (sqlhelper.isConnected())
            {
                // do database operation





            }
            sqlhelper.close();
            return new List<Customers>();
        }
        // search by name from customers record.
        public List<Customers> SearchCustomers(string name)
        {
            SqlHelper sqlhelper = new SqlHelper(con);

            if (sqlhelper.isConnected())
            {
                // do database operation





            }
            sqlhelper.close();
            return new List<Customers>();
        }
        // Add new Customer
        public void AddCustomer(Customers cust)
        {
            
            SqlHelper sqlhelper = new SqlHelper(con);

                if (sqlhelper.isConnected())
                {
                /*
                 * @name varchar(255),
	@email varchar(255),
	@mobile varchar(255),
	@city varchar(255),
	@zip varchar(255),
	@country varchar(255),
	@added_date datetime,
	@photo varbinary(max),
	@website varchar(255),
	@status bit,
	@promoted_leadsId int,
	@addedBy_teamId int
                 */

                SqlCommand cmd = new SqlCommand("Add Customers", sqlhelper.connection());
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                // store procedure parameters.
                cmd.Parameters.Add("@name", SqlDbType.VarChar);
                cmd.Parameters.Add("@email", SqlDbType.VarChar);
                cmd.Parameters.Add("@mobile", SqlDbType.VarChar);
                cmd.Parameters.Add("@city", SqlDbType.VarChar);
                cmd.Parameters.Add("@zip", SqlDbType.VarChar);
                cmd.Parameters.Add("@country", SqlDbType.VarChar);
                cmd.Parameters.Add("@added_date", SqlDbType.DateTime);
                cmd.Parameters.Add("@photo", SqlDbType.VarBinary);
                cmd.Parameters.Add("@website", SqlDbType.VarChar);
                cmd.Parameters.Add("@status", SqlDbType.Bit);
                cmd.Parameters.Add("@addedBy_teamId", SqlDbType.Int);

                string pho = "photo"; 
                // parameter values.
                cmd.Parameters["@name"].Value = "abel";
                cmd.Parameters["@email"].Value = "email";
                cmd.Parameters["@mobile"].Value = "mobile";
                cmd.Parameters["@city"].Value = "city";
                cmd.Parameters["@zip"].Value = "zip";
                cmd.Parameters["@country"].Value = "country";
                cmd.Parameters["@added_date"].Value = DateTime.Now;
                cmd.Parameters["@photo"].Value = Properties.Resources.personjpj;
                cmd.Parameters["@website"].Value = "web";
                cmd.Parameters["@status"].Value = 1;
                cmd.Parameters["@addedBy_teamId"].Value = 1;

                cmd.ExecuteNonQuery();


            }
            sqlhelper.close();

        }
        // update existing customer.
        public void UpdateCustomer(object cust)
        {
            SqlHelper sqlhelper = new SqlHelper(con);

            if (sqlhelper.isConnected())
            {
                // do database operation





            }
            sqlhelper.close();

        }
    
        // Delete Customer
        public void DelCustomer(int id)
        {
            SqlHelper sqlhelper = new SqlHelper(con);

            if (sqlhelper.isConnected())
            {
                // do database operation





            }
            sqlhelper.close();
        }

        // -------------------------------------------------------  Task DB Access methods------------------------------------------------------------------- 
        // Task Database access methods.
        // All Tasks.
        public List<model.Task> GetAllTasks()
        {
            SqlHelper sqlhelper = new SqlHelper(con);

            if (sqlhelper.isConnected())
            {
                // do database operation





            }
            sqlhelper.close();
            return new List<model.Task>();
        }
        // On Progress Task.
        public List<model.Task> GetProgressTask()
        {
            SqlHelper sqlhelper = new SqlHelper(con);

            if (sqlhelper.isConnected())
            {
                // do database operation





            }
            sqlhelper.close();
            return new List<model.Task>();
        }
        // Done Tasks
        public List<model.Task> GetDoneTasks()
        {
            SqlHelper sqlhelper = new SqlHelper(con);

            if (sqlhelper.isConnected())
            {
                // do database operation





            }
            sqlhelper.close();
            return new List<model.Task>();
        }
        // search by id from Tasks record.
        public List<model.Task> SearchTasks(int id)
        {
            SqlHelper sqlhelper = new SqlHelper(con);

            if (sqlhelper.isConnected())
            {
                // do database operation





            }
            sqlhelper.close();
            return new List<model.Task>();
        }
        // search by name from Tasks record.
        public List<model.Task> SearchTasks(string name)
        {
            SqlHelper sqlhelper = new SqlHelper(con);

            if (sqlhelper.isConnected())
            {
                // do database operation





            }
            sqlhelper.close();
            return new List<model.Task>();
        }
        // Add new Task
        public void AddTask(int id, string name, string addedby, string status, string referType, string referName, string priority, string note)
        {
            SqlHelper sqlhelper = new SqlHelper(con);

            if (sqlhelper.isConnected())
            {
                // do database operation





            }
            sqlhelper.close();
        }
        // update existing Tasks.
        public void UpdateCustomer(int id, string name, string addedby, string status, string referType, string referName, string priority, string note)
        {
            SqlHelper sqlhelper = new SqlHelper(con);

            if (sqlhelper.isConnected())
            {
                // do database operation





            }
            sqlhelper.close();
        }
        // Delete Tasks
        public void DelTask(int id)
        {
            SqlHelper sqlhelper = new SqlHelper(con);

            if (sqlhelper.isConnected())
            {
                // do database operation





            }
            sqlhelper.close();
        }

        // -------------------------------------------------------  Leads DB Access methods------------------------------------------------------------------- 
        // All Leads.
        public List<Leads> GetAllLeads()
        {
            SqlHelper sqlhelper = new SqlHelper(con);

            if (sqlhelper.isConnected())
            {
                // do database operation





            }
            sqlhelper.close();
            return new List<Leads>();
        }
        // Active Leads.
        public List<Leads> GetActiveLeads()
        {
            SqlHelper sqlhelper = new SqlHelper(con);

            if (sqlhelper.isConnected())
            {
                // do database operation





            }
            sqlhelper.close();
            return new List<Leads>();
        }

        // Closed Leads
        public List<Leads> GetClosedLeads()
        {
            SqlHelper sqlhelper = new SqlHelper(con);

            if (sqlhelper.isConnected())
            {
                // do database operation





            }
            sqlhelper.close();
            return new List<Leads>();
        }
        // search by id from Lead record.
        public List<Leads> SearchLeads(int id)
        {
            SqlHelper sqlhelper = new SqlHelper(con);

            if (sqlhelper.isConnected())
            {
                // do database operation





            }
            sqlhelper.close();
            return new List<Leads>();
        }
        // search by name from Leads record.
        public List<Leads> SearchLeads(string name)
        {
            SqlHelper sqlhelper = new SqlHelper(con);

            if (sqlhelper.isConnected())
            {
                // do database operation





            }
            sqlhelper.close();
            return new List<Leads>();
        }
        // Add new Lead
        public void AddLead(Leads lead)
        {
            SqlHelper sqlhelper = new SqlHelper(con);

            if (sqlhelper.isConnected())
            {
                SqlCommand cmd = new SqlCommand("Add Leads", sqlhelper.connection());
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                /*
                     @name varchar(255),
	@email varchar(255),
	@source varchar(255),
	@status varchar(255),
	@note varchar(max),
	@createdDate datetime,
	@addedBy_teamId int,
	@customerId int
                 */


                // store procedure parameters.
                cmd.Parameters.Add("@name", SqlDbType.VarChar);
                cmd.Parameters.Add("@email", SqlDbType.VarChar);
                cmd.Parameters.Add("@source", SqlDbType.VarChar);
                cmd.Parameters.Add("@status", SqlDbType.VarChar);
                cmd.Parameters.Add("@note", SqlDbType.VarChar);
                cmd.Parameters.Add("@createdDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@addedBy_teamId", SqlDbType.Int);
                cmd.Parameters.Add("@customerId", SqlDbType.Int);
         
                // parameter values.
                cmd.Parameters["@name"].Value = lead.name;
                cmd.Parameters["@email"].Value = lead.email;
                cmd.Parameters["@source"].Value = lead.source;
                cmd.Parameters["@status"].Value = lead.status;
                cmd.Parameters["@note"].Value = lead.note;
                cmd.Parameters["@createdDate"].Value = lead.createDate;
                cmd.Parameters["@addedBy_teamId"].Value = lead.addedBy;
                cmd.Parameters["@customerId"].Value = DBNull.Value;
              

                int affectedRows = cmd.ExecuteNonQuery();




            }
            sqlhelper.close();
        }
        // update existing Lead.
        public void UpdateLead(int id, string name, string addedby, string status, string referType, string referName, string priority, string note)
        {
            SqlHelper sqlhelper = new SqlHelper(con);

            if (sqlhelper.isConnected())
            {
                // do database operation





            }
            sqlhelper.close();
        }
        // Delete Lead
        public void DelLead(int id)
        {
            SqlHelper sqlhelper = new SqlHelper(con);

            if (sqlhelper.isConnected())
            {
                // do database operation





            }
            sqlhelper.close();
        }


        // -------------------------------------------------------  Events DB Access methods------------------------------------------------------------------- 

        // All Events.
        public List<Events> GetAllEvents()
        {
            SqlHelper sqlhelper = new SqlHelper(con);

            if (sqlhelper.isConnected())
            {
                // do database operation





            }
            sqlhelper.close();
            return new List<Events>();
        }
        // Passed Events.
        public List<Events> GetPassedEvents()
        {
            SqlHelper sqlhelper = new SqlHelper(con);

            if (sqlhelper.isConnected())
            {
                // do database operation





            }
            sqlhelper.close();
            return new List<Events>();
        }

        // UpComming Events
        public List<Events> GetUpCommingEvents()
        {
            SqlHelper sqlhelper = new SqlHelper(con);

            if (sqlhelper.isConnected())
            {
                // do database operation





            }
            sqlhelper.close();
            return new List<Events>();
        }
        // search by id from Events record.
        public List<Events> SearchEvents(int id)
        {
            SqlHelper sqlhelper = new SqlHelper(con);

            if (sqlhelper.isConnected())
            {
                // do database operation





            }
            sqlhelper.close();
            return new List<Events>();
        }
        // search by name from Events record.
        public List<Events> SearchEvnets(string name)
        {
            SqlHelper sqlhelper = new SqlHelper(con);

            if (sqlhelper.isConnected())
            {
                // do database operation





            }
            sqlhelper.close();
            return new List<Events>();
        }
        // Add new Event
        public void AddLead(int id, string topic, string type, string status, string note, DateTime startDate, DateTime startTime, DateTime endTime , int addedby)
        {
            SqlHelper sqlhelper = new SqlHelper(con);

            if (sqlhelper.isConnected())
            {
                // do database operation





            }
            sqlhelper.close();
        }
        // update existing Lead.
        public void UpdateEvent(int id, string topic, string type, string status, string note, DateTime startDate, DateTime startTime, DateTime endTime , int addedby)
        {

            SqlHelper sqlhelper = new SqlHelper(con);

            if (sqlhelper.isConnected())
            {
                // do database operation





            }
            sqlhelper.close();
        }
        // Delete Lead
        public void DelEvent(int id)
        {
            SqlHelper sqlhelper = new SqlHelper(con);

            if (sqlhelper.isConnected())
            {
                // do database operation





            }
            sqlhelper.close();
        }
        // -------------------------------------------------------  Guest DB Access methods------------------------------------------------------------------- 


        // -------------------------------------------------------  Reports DB Access methods------------------------------------------------------------------- 

    }
}
