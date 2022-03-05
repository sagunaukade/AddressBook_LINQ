using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Address Book LINQ");
            //Create Object for DataTable
            ContactDataManager contactDataManager = new ContactDataManager();
            ContactDataManager contactDataManagers = new ContactDataManager();
            DataTableManager dataTableManger = new DataTableManager();
            dataTableManger.CreateDataTable();

            //Insert Values into Table
            contactDataManager.FirstName = "Saguna";
            contactDataManager.LastName = "Ukade";
            contactDataManager.PhoneNumber = 9842905050;
            contactDataManager.Email = "saguna34@gmail.com";
            contactDataManager.Address = "404,B Block,Shivane";
            contactDataManager.City = "Pune";
            contactDataManager.State = "MH";
            contactDataManager.zip = 411032;
            dataTableManger.InsertintoDataTable(contactDataManager);

            //Insert Values into Table
            contactDataManagers.FirstName = "Amruta";
            contactDataManagers.LastName = "Sharma";
            contactDataManagers.PhoneNumber = 7742905050;
            contactDataManagers.Email = "Amruta@gmail.com";
            contactDataManagers.Address = "54 street,Sangli";
            contactDataManagers.City = "Sangli";
            contactDataManagers.State = "MH";
            contactDataManagers.zip = 427801;
            dataTableManger.InsertintoDataTable(contactDataManagers);
            dataTableManger.Display();
            //Modify
            int varl = dataTableManger.EditDataTable("lalita", "Lastname");
            Console.WriteLine("Success" + varl);

        }
    }
}




       