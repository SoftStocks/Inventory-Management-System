using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace SoftStocksData
{
    public static class PopulateDatabase
    {
        public static void FromCSVFile(string fileName)
        {
            using(TextFieldParser parser = new TextFieldParser(fileName))
            {
                using (SoftStocksDBContext db = new SoftStocksDBContext())
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");

                    string[] header = parser.ReadFields();

                    // database fields
                    string[] staffHeader = { "title", "first_name", "last_name", "role", "date_of_birth", "salary" };
                    string[] credentialsHeader = { "username", "staff_id", "password" };
                    string[] keyboardHeader = { "model_number", "supplier_id", "quantity", "description", "price" };
                    string[] supplierHeader = { "id", "name", "contact_number", "primary_contact", "business_address", "number_of_purchases" };
                    string[] purchaseRequestHeader = { "id", "keyboard_requestid", "quantity", "staff_id", "approved" };
                    string[] keyboardRequestHeader = { "id", "model_number", "purchase_request_id" };


                    while (!parser.EndOfData)
                    {
                        // what are the fields stored in the database?
                        string[] fields = parser.ReadFields();

                        
                        // switch the table depending on which fields have been discovered
                        if (header.SequenceEqual(staffHeader))
                        {
                            Console.WriteLine("STAFF");
                        }
                        else if (header.SequenceEqual(credentialsHeader))
                        {
                            //db.Credentials.Add(new Credential { });
                        }
                        else if(header.SequenceEqual(staffHeader))
                        {
                            //db.KeyboardRequests.Add(new KeyboardRequest { });
                        }
                        else if (header.SequenceEqual(staffHeader))
                        {
                            //db.Suppliers.Add(new Supplier { });
                        }
                        else if(header.SequenceEqual(staffHeader))
                        {
                            //db.PurchaseRequests.Add(new PurchaseRequest { });
                        }
                        else if(header.SequenceEqual(staffHeader))
                        {
                            //db.KeyboardRequests.Add(new KeyboardRequest { });
                        }

                        // Save changes
                        db.SaveChanges();
                    }
                }
                
            }
        }
    }
}
