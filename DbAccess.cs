using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Hil5_CRM_Project.model;
using System.Data;
using System.IO;

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
        public Customers SearchCustomers(int id)
        {
            Customers cust;
            Byte[] img1 = null;
            SqlHelper sqlhelper = new SqlHelper(con);
           
            if (sqlhelper.isConnected())
            {
                SqlCommand cmd = new SqlCommand("spGet_customerBy_id", sqlhelper.connection());
                cmd.CommandType = System.Data.CommandType.StoredProcedure;


                // store procedure parameters.
                cmd.Parameters.Add("@idOrName", SqlDbType.VarChar);

                // parameter values.
                cmd.Parameters["@idOrName"].Value = id;

                SqlDataReader custReader = cmd.ExecuteReader(CommandBehavior.SingleRow);
                if (custReader.Read())
                {
                    cust = new Customers();
                    cust.id = custReader.GetInt32(0);
                    cust.name = custReader.GetString(1);
                    cust.email = custReader.GetString(2);
                    cust.mobile = custReader.GetString(3);
                    cust.city = custReader.GetString(4);
                    cust.zip = custReader.GetString(5);
                    cust.country = custReader.GetString(6);
                    cust.addedDate = custReader.GetDateTime(7);
                    if (custReader["photo"] != DBNull.Value)
                    {
                        img1 = (byte[])(custReader["photo"]);
                        MemoryStream ms = new MemoryStream(img1);
                        cust.photo = img1;
                    }
                    else
                    {
                        cust.photo = null;
                    }
                    if (custReader["website"] != DBNull.Value)
                    {
                        cust.website = custReader.GetString(9);
                    }
                    else
                    {
                        cust.website = null;
                    }
                    cust.status = custReader.GetBoolean(10);
                    cust.addedBy = (int)custReader["addedBy_teamId"];
                    return cust;
                    System.Windows.Forms.MessageBox.Show("success");
                }
                else
                {
                    return null;
                }

            }
            sqlhelper.close();
            return null;
          
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
               
                if (cust.photo == null)
                {
                    cmd.Parameters["@photo"].Value = DBNull.Value;
                }
                else {
                    cmd.Parameters["@photo"].Value = cust.photo;
                }
               
                if (cust.website == null)
                {
                    cmd.Parameters["@website"].Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters["@website"].Value = cust.website;
                }
             
                cmd.Parameters["@status"].Value = cust.status;
                cmd.Parameters["@promoted_leadsId"].Value = DBNull.Value;
                cmd.Parameters["@addedBy_teamId"].Value = cust.addedBy;

                int rowsaffected = cmd.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show(rowsaffected + "row affected");

            }
            sqlhelper.close();

        }
        // update existing customer.
        public void UpdateCustomer(Customers cust)
        {
            SqlHelper sqlhelper = new SqlHelper(con);

            if (sqlhelper.isConnected())
            {

                SqlCommand cmd = new SqlCommand("Update Customers_byId", sqlhelper.connection());
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                // store procedure parameters.
                cmd.Parameters.Add("@customerId", SqlDbType.Int);
                cmd.Parameters.Add("@newName", SqlDbType.VarChar);
                cmd.Parameters.Add("@newEmail", SqlDbType.VarChar);
                cmd.Parameters.Add("@newMobile", SqlDbType.VarChar);
                cmd.Parameters.Add("@newCity", SqlDbType.VarChar);
                cmd.Parameters.Add("@newZip", SqlDbType.VarChar);
                cmd.Parameters.Add("@newCountry", SqlDbType.VarChar);
                cmd.Parameters.Add("@newAdded_date", SqlDbType.DateTime);
                cmd.Parameters.Add("@newPhoto", SqlDbType.VarBinary);
                cmd.Parameters.Add("@newWebsite", SqlDbType.VarChar);
                cmd.Parameters.Add("@newStatus", SqlDbType.Bit);
                cmd.Parameters.Add("@newPromoted_leadsId", SqlDbType.Int);
                cmd.Parameters.Add("@newAddedBy_teamId", SqlDbType.Int);

                // string pho = "photo"; 
                // parameter values.
                cmd.Parameters["@customerId"].Value = cust.id;
                cmd.Parameters["@newName"].Value = cust.name;
                cmd.Parameters["@newName"].Value = cust.name;
                cmd.Parameters["@newEmail"].Value = cust.email;
                cmd.Parameters["@newMobile"].Value = cust.mobile;
                cmd.Parameters["@newCity"].Value = cust.city;
                cmd.Parameters["@newZip"].Value = cust.zip;
                cmd.Parameters["@newCountry"].Value = cust.country;
                cmd.Parameters["@newAdded_date"].Value = cust.addedDate;

                if (cust.photo == null)
                {
                    cmd.Parameters["@newPhoto"].Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters["@newPhoto"].Value = cust.photo;
                }

                if (cust.website == null)
                {
                    cmd.Parameters["@newWebsite"].Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters["@newWebsite"].Value = cust.website;
                }

                cmd.Parameters["@newStatus"].Value = cust.status;
                cmd.Parameters["@newPromoted_leadsId"].Value = DBNull.Value;
                cmd.Parameters["@newAddedBy_teamId"].Value = cust.addedBy;

                int rowsaffected = cmd.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show(rowsaffected + "row affected");




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
        public void AddTask(Hil5_CRM_Project.model.Task task)
        {
            SqlHelper sqlhelper = new SqlHelper(con);

            if (sqlhelper.isConnected())
            {

                SqlCommand cmd = new SqlCommand("Add Tasks", sqlhelper.connection());
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                /*
                   @name varchar(255),
	                @status varchar(255),
	                @refer_type varchar(255),
	                @refer_name varchar(255),
	                @priority varchar(255),
	                @note varchar(max),
	                @addedBy_teamId int
                 */

                // store procedure parameters.

               
                cmd.Parameters.Add("@name", SqlDbType.VarChar);
                cmd.Parameters.Add("@status", SqlDbType.VarChar);
                cmd.Parameters.Add("@refer_type", SqlDbType.VarChar);
                cmd.Parameters.Add("@refer_name", SqlDbType.VarChar);
                cmd.Parameters.Add("@priority", SqlDbType.VarChar);
                cmd.Parameters.Add("@note", SqlDbType.VarChar);
                cmd.Parameters.Add("@addedBy_teamId", SqlDbType.VarChar);
 
                // parameter values.
                
                cmd.Parameters["@name"].Value = task.name;
                cmd.Parameters["@status"].Value = task.status;
                cmd.Parameters["@refer_type"].Value = task.referType;
                cmd.Parameters["@refer_name"].Value = task.referName;
                cmd.Parameters["@priority"].Value = task.priority;
                cmd.Parameters["@note"].Value = task.note;
                cmd.Parameters["@addedBy_teamId"].Value = task.addedBy;
                int affectedRows = cmd.ExecuteNonQuery();

                System.Windows.Forms.MessageBox.Show(affectedRows + " row affected");



            }
            sqlhelper.close();
        }
        // update existing Tasks.
        public void UpdateCustomer(Hil5_CRM_Project.model.Task task)
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
              //  cmd.Parameters.Add("@startTime", SqlDbType.Time);
                cmd.Parameters.Add("@endDate", SqlDbType.Date);
              //  cmd.Parameters.Add("@endTime", SqlDbType.Time);
                cmd.Parameters.Add("@addedBy_teamId", SqlDbType.Int);


                // parameter values.
                cmd.Parameters["@topic"].Value = events.topic;
                cmd.Parameters["@type"].Value = events.type;
                cmd.Parameters["@status"].Value = events.status;
                cmd.Parameters["@note"].Value = events.note;
                cmd.Parameters["@startDate"].Value = events.startDate;
              //  cmd.Parameters["@startTime"].Value = events.startTime;
                cmd.Parameters["@endDate"].Value = events.endDate;
              //  cmd.Parameters["@endTime"].Value = events.endTime;
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



        // -------------------------------------------------------  Organization DB Access methods------------------------------------------------------------------- 
        
        // search by name from Leads record.
        public Organization SearchOrganization(int id)
        {
            Organization org;
            Byte[] img1 = null;
            SqlHelper sqlhelper = new SqlHelper(con);

            if (sqlhelper.isConnected())
            {
                SqlCommand cmd = new SqlCommand("spGet_organizationBy_id", sqlhelper.connection());
                cmd.CommandType = System.Data.CommandType.StoredProcedure;


                // store procedure parameters.
                cmd.Parameters.Add("@idOrName", SqlDbType.VarChar);

                // parameter values.
                cmd.Parameters["@idOrName"].Value = id;

                SqlDataReader orgReader = cmd.ExecuteReader(CommandBehavior.SingleRow);
                if (orgReader.Read())
                {
                    org = new Organization();
                    org.id = orgReader.GetInt32(0);
                    if (orgReader["logo"] != DBNull.Value)
                    {
                        img1 = (byte[])(orgReader["logo"]);
                        MemoryStream ms = new MemoryStream(img1);
                        org.logo = img1;
                    }
                    else
                    {
                        org.logo = null;
                    }
                    org.name = orgReader.GetString(2);
                    org.email = orgReader.GetString(3);
                    org.phone = orgReader.GetString(4);
                    org.addres = orgReader.GetString(5);
                    return org;
                    System.Windows.Forms.MessageBox.Show("success");
                }
                else
                {
                    return null;
                }

            }
            sqlhelper.close();
            return null;
        }
        // Add new Org
        //This works fine
        public void AddOrganization(Organization org)
        {
            SqlHelper sqlhelper = new SqlHelper(con);

            if (sqlhelper.isConnected())
            {

                SqlCommand cmd = new SqlCommand("Add organization", sqlhelper.connection());
                cmd.CommandType = System.Data.CommandType.StoredProcedure;



                // store procedure parameters.

                cmd.Parameters.Add("@logo", SqlDbType.VarBinary);
                cmd.Parameters.Add("@name", SqlDbType.VarChar);
                cmd.Parameters.Add("@email", SqlDbType.VarChar);
                cmd.Parameters.Add("@phone", SqlDbType.VarChar);
                cmd.Parameters.Add("@address", SqlDbType.VarChar);
                // parameter values.
                if (org.logo == null)
                {
                    cmd.Parameters["@logo"].Value = DBNull.Value;
                }
                else 
                {
                    cmd.Parameters["@logo"].Value = org.logo;
                }
           
                cmd.Parameters["@name"].Value = org.name;
                cmd.Parameters["@email"].Value = org.email;
                cmd.Parameters["@phone"].Value = org.phone;
                cmd.Parameters["@address"].Value = org.addres;

                int affectedRows = cmd.ExecuteNonQuery();

                System.Windows.Forms.MessageBox.Show(affectedRows + " row affected");



            }
            sqlhelper.close();
        }
        // update existing Organization.
        public void UpdateOrganization(Organization org)
        {
            SqlHelper sqlhelper = new SqlHelper(con);

            if (sqlhelper.isConnected())
            {
                /*
                    @newName varchar(255),
                      @newEmail varchar(255),
                      @newPhone varchar(255),
                      @newAddress varchar(255)
                 */

                SqlCommand cmd = new SqlCommand("spUpdateOrganization_byIdOrName", sqlhelper.connection());
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                // store procedure parameters.
                cmd.Parameters.Add("@orgIdOrName", SqlDbType.Int);
                cmd.Parameters.Add("@newLogo", SqlDbType.VarBinary);
                cmd.Parameters.Add("@newName", SqlDbType.VarChar);
                cmd.Parameters.Add("@newEmail", SqlDbType.VarChar);
                cmd.Parameters.Add("@newPhone", SqlDbType.VarChar);
                cmd.Parameters.Add("@newAddress", SqlDbType.VarChar);

                // string pho = "photo"; 
                // parameter values.
                cmd.Parameters["@orgIdOrName"].Value = org.id;

                if (org.logo == null)
                {
                    cmd.Parameters["@newLogo"].Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters["@newLogo"].Value = org.logo;
                }

                cmd.Parameters["@newName"].Value = org.name;
                cmd.Parameters["@newEmail"].Value = org.email;
                cmd.Parameters["@newPhone"].Value = org.phone;
                cmd.Parameters["@newAddress"].Value = org.addres;
               

                int rowsaffected = cmd.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show(rowsaffected + "row affected");




            }
            sqlhelper.close();
        }
        // Delete org
        public void DeleteOrganization(int id)
        {
            SqlHelper sqlhelper = new SqlHelper(con);

            if (sqlhelper.isConnected())
            {
                // do database operation





            }
            sqlhelper.close();
        }





        // -------------------------------------------------------  Team DB Access methods------------------------------------------------------------------- 

        // search by name from Team record.
        public List<Team> searchTeam(string name)
        {
            SqlHelper sqlhelper = new SqlHelper(con);

            if (sqlhelper.isConnected())
            {
                // do database operation





            }
            sqlhelper.close();
            return new List<Team>();
        }
        // Add new Team
        //This works fine
        public void AddTeam(Team team)
        {
            SqlHelper sqlhelper = new SqlHelper(con);

            if (sqlhelper.isConnected())
            {

                SqlCommand cmd = new SqlCommand("Add Team", sqlhelper.connection());
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                /*
                    @picture varbinary(max),
                    @name varchar(255),
	                @gender varchar(255),
	                @email varchar(255),
	                @password varchar(255),
	                @type varchar(255),
	                @department varchar(255),
	                @role varchar(255),
	                @status bit
                 */

                // store procedure parameters.

                cmd.Parameters.Add("@picture", SqlDbType.VarBinary);
                cmd.Parameters.Add("@name", SqlDbType.VarChar);
                cmd.Parameters.Add("@gender", SqlDbType.VarChar);
                cmd.Parameters.Add("@email", SqlDbType.VarChar);
                cmd.Parameters.Add("@password", SqlDbType.VarChar);
                cmd.Parameters.Add("@type", SqlDbType.VarChar);
                cmd.Parameters.Add("@department", SqlDbType.VarChar);
                cmd.Parameters.Add("@role", SqlDbType.VarChar);
                cmd.Parameters.Add("@status", SqlDbType.Bit);
                
                // parameter values.
                if (team.picture == null)
                {
                    cmd.Parameters["@picture"].Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters["@picture"].Value = team.picture;
                }

                cmd.Parameters["@name"].Value = team.name;
                cmd.Parameters["@gender"].Value = team.gender;
                cmd.Parameters["@email"].Value = team.email;
                cmd.Parameters["@password"].Value = team.password;
                cmd.Parameters["@type"].Value = team.type;
                cmd.Parameters["@department"].Value = team.departement;
                cmd.Parameters["@role"].Value = team.role;
                cmd.Parameters["@status"].Value = team.status;

                int affectedRows = cmd.ExecuteNonQuery();

                System.Windows.Forms.MessageBox.Show(affectedRows + " row affected");



            }
            sqlhelper.close();
        }
        // update existing Team.
        public void updateTeam(Team team)
        {
            SqlHelper sqlhelper = new SqlHelper(con);

            if (sqlhelper.isConnected())
            {
                // do database operation





            }
            sqlhelper.close();
        }
        // Delete org
        public void DeleteTeam(int id)
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
