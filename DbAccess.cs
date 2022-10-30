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
        // This works fine
        public void AddCustomer(Customers cust)
        {
            
            SqlHelper sqlhelper = new SqlHelper(con);

                if (sqlhelper.isConnected())
                {

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
                cmd.Parameters.Add("@promoted_leadsId", SqlDbType.Int);
                cmd.Parameters.Add("@addedBy_teamId", SqlDbType.Int);

                // string pho = "photo"; 
                // parameter values.
                cmd.Parameters["@name"].Value = cust.name;
                cmd.Parameters["@email"].Value = cust.email;
                cmd.Parameters["@mobile"].Value = cust.mobile;
                cmd.Parameters["@city"].Value = cust.city;
                cmd.Parameters["@zip"].Value = cust.zip;
                cmd.Parameters["@country"].Value = cust.country;
                cmd.Parameters["@added_date"].Value = cust.addedDate;
                cmd.Parameters["@photo"].Value = DBNull.Value;
                cmd.Parameters["@website"].Value = DBNull.Value;
                cmd.Parameters["@status"].Value = cust.status;
                cmd.Parameters["@promoted_leadsId"].Value = DBNull.Value;
                cmd.Parameters["@addedBy_teamId"].Value = cust.addedBy;

                int rowsaffected = cmd.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show(rowsaffected + "row affected");

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
        //This works fine
        public void AddLead(Leads lead)
        {
            SqlHelper sqlhelper = new SqlHelper(con);

            if (sqlhelper.isConnected())
            {
                SqlCommand cmd = new SqlCommand("Add Leads", sqlhelper.connection());
                cmd.CommandType = System.Data.CommandType.StoredProcedure;


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

                System.Windows.Forms.MessageBox.Show(affectedRows + " row affected");



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
        // This needs fix on DateTime types
        public void AddEvent(Events events)
        {
            SqlHelper sqlhelper = new SqlHelper(con);

            /*
                     @topic varchar(255),
	                 @type varchar(255),
	                 @status varchar(255),
	                 @note varchar(max),
                     @startDate date,
                     @startTime time,
	                 @endDate date,
                     @endTime time,
	                 @addedBy_teamId int
             */


            if (sqlhelper.isConnected())
            {
                SqlCommand cmd = new SqlCommand("Add Events", sqlhelper.connection());
                cmd.CommandType = System.Data.CommandType.StoredProcedure;


                // store procedure parameters.
                cmd.Parameters.Add("@topic", SqlDbType.VarChar);
                cmd.Parameters.Add("@type", SqlDbType.VarChar);
                cmd.Parameters.Add("@status", SqlDbType.VarChar);
                cmd.Parameters.Add("@note", SqlDbType.VarChar);
                cmd.Parameters.Add("@startDate", SqlDbType.Date);
                cmd.Parameters.Add("@startTime", SqlDbType.Time);
                cmd.Parameters.Add("@endDate", SqlDbType.Date);
                cmd.Parameters.Add("@endTime", SqlDbType.Time);
                cmd.Parameters.Add("@addedBy_teamId", SqlDbType.Int);


                // parameter values.
                cmd.Parameters["@topic"].Value = events.topic;
                cmd.Parameters["@type"].Value = events.type;
                cmd.Parameters["@status"].Value = events.status;
                cmd.Parameters["@note"].Value = events.note;
                cmd.Parameters["@startDate"].Value = events.startDate;
                cmd.Parameters["@startTime"].Value = events.startTime;
                cmd.Parameters["@endDate"].Value = events.endDate;
                cmd.Parameters["@endTime"].Value = events.endTime;
                cmd.Parameters["@addedBy_teamId"].Value = events.addedBy;
            


                int affectedRows = cmd.ExecuteNonQuery();

                System.Windows.Forms.MessageBox.Show(affectedRows + " row affected");



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
