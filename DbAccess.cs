using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hil5_CRM_Project.model;

namespace Hil5_CRM_Project
{
    internal class DbAccess
    {
        // No: of Evetns.
        public int NoEvents()
        {
            return 0;
        }
        // No: of Tasks.
        public int NoTasks()
        {
            return 0;
        }
        // No: of Customers.
        public int NoCustomers()
        {
            return 0;
        }
        //No: Leads.
        public int NoLeads()
        {   
            return 0;
        }
        // ----------------------------------------------------------Customer DB Access methods-------------------------------------------------------------
        // All Customers
        public List<Customers> GetAllCustomers()
        {
            return new List<Customers>();
        }
        // Active Customers.
        public List<Customers> GetActiveCustomers()
        {
            return new List<Customers>();
        }
        // On Leave Customer.
        public List<Customers> GetOnLeavCustomers()
        {
            return new List<Customers>();
        }
        // Promoted Customer
        public List<Customers> GetPromotedCustomers()
        {
            return new List<Customers>();
        }
        // search by id from customers record.
        public List<Customers> SearchCustomers(int id)
        {
            return new List<Customers>();
        }
        // search by name from customers record.
        public List<Customers> SearchCustomers(string name)
        {
            return new List<Customers>();
        }
        // Add new Customer
        public void AddCustomer(int id, string name, string email, string mobile, string city, string state, string zip, string county, string addedby, DateTime addedDate, byte[] photo, string website, int promoted, bool active)
        {
            
        }
        // update existing customer.
        public void UpdateCustomer(int id, string name, string email, string mobile, string city, string state, string zip, string county, string addedby, DateTime addedDate, byte[] photo, string website, int promoted, bool active)
        {

        }
        // Delete Customer
        public void DelCustomer(int id)
        {
            
        }

        // -------------------------------------------------------  Task DB Access methods------------------------------------------------------------------- 
        // Task Database access methods.
        // All Tasks.
        public List<model.Task> GetAllTasks()
        {
            return new List<model.Task>();
        }
        // On Progress Task.
        public List<model.Task> GetProgressTask()
        {
            return new List<model.Task>();
        }
        // Done Tasks
        public List<model.Task> GetDoneTasks()
        {
            return new List<model.Task>();
        }
        // search by id from Tasks record.
        public List<model.Task> SearchTasks(int id)
        {
            return new List<model.Task>();
        }
        // search by name from Tasks record.
        public List<model.Task> SearchTasks(string name)
        {
            return new List<model.Task>();
        }
        // Add new Task
        public void AddTask(int id, string name, string addedby, string status, string referType, string referName, string priority, string note)
        {
          
        }
        // update existing Tasks.
        public void UpdateCustomer(int id, string name, string addedby, string status, string referType, string referName, string priority, string note)
        {

        }
        // Delete Tasks
        public void DelTask(int id)
        {

        }

        // -------------------------------------------------------  Leads DB Access methods------------------------------------------------------------------- 
        // All Leads.
        public List<Leads> GetAllLeads()
        {
            return new List<Leads>();
        }
        // Active Leads.
        public List<Leads> GetActiveLeads()
        {
            return new List<Leads>();
        }

        // Closed Leads
        public List<Leads> GetClosedLeads()
        {
            return new List<Leads>();
        }
        // search by id from Lead record.
        public List<Leads> SearchLeads(int id)
        {
            return new List<Leads>();
        }
        // search by name from Leads record.
        public List<Leads> SearchLeads(string name)
        {
            return new List<Leads>();
        }
        // Add new Lead
        public void AddLead(int id, string name, string email,string source, string status, string addedby, string note, DateTime creteDAte)
        {
         
        }
        // update existing Lead.
        public void UpdateLead(int id, string name, string addedby, string status, string referType, string referName, string priority, string note)
        {

        }
        // Delete Lead
        public void DelLead(int id)
        {

        }


        // -------------------------------------------------------  Events DB Access methods------------------------------------------------------------------- 

        // All Events.
        public List<Events> GetAllEvents()
        {
            return new List<Events>();
        }
        // Passed Events.
        public List<Events> GetPassedEvents()
        {
            return new List<Events>();
        }

        // UpComming Events
        public List<Events> GetUpCommingEvents()
        {
            return new List<Events>();
        }
        // search by id from Events record.
        public List<Events> SearchEvents(int id)
        {
            return new List<Events>();
        }
        // search by name from Events record.
        public List<Events> SearchEvnets(string name)
        {
            return new List<Events>();
        }
        // Add new Event
        public void AddLead(int id, string topic, string type, string status, string note, DateTime startDate, DateTime startTime, DateTime endTime , int addedby)
        {
         
        }
        // update existing Lead.
        public void UpdateEvent(int id, string topic, string type, string status, string note, DateTime startDate, DateTime startTime, DateTime endTime , int addedby)
        {

        }
        // Delete Lead
        public void DelEvent(int id)
        {

        }
        // -------------------------------------------------------  Guest DB Access methods------------------------------------------------------------------- 


        // -------------------------------------------------------  Reports DB Access methods------------------------------------------------------------------- 

    }
}
