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
            contactDataManager.PhoneNumber = 9977668754;
            contactDataManager.Email = "saguna98@gmail.com";
            contactDataManager.Address = "503,B Block,Shivane";
            contactDataManager.City = "Pune";
            contactDataManager.State = "Maharashtra";
            contactDataManager.zip = 411023;
            dataTableManger.InsertintoDataTable(contactDataManager);

            //Insert Values into Table
            contactDataManagers.FirstName = "Amruta";
            contactDataManagers.LastName = "Sharma";
            contactDataManagers.PhoneNumber = 8867543212;
            contactDataManagers.Email = "amruta23@gmail.com";
            contactDataManagers.Address = "78 street,Kolhapur";
            contactDataManagers.City = "Kolhapur";
            contactDataManagers.State = "Maharashtra";
            contactDataManagers.zip = 4321981;
            dataTableManger.InsertintoDataTable(contactDataManagers);
            dataTableManger.Display();
        }
    }
}
       