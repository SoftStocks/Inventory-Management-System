using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                    while (!parser.EndOfData)
                    {
                        // what are the fields stored in the database?
                        string[] fields = parser.ReadFields();

                        // database fields
                        string[] staffFields = {"title", "first_name", "last_name", "role", "date_of_birth", "salary"};
                        string[] credentialsFields = {"username", "staff_id", "password"};
                        string[] keyboardFields = {"model_number", "supplier_id", "quantity", "description", "price"};
                        string[] supplierFields = {"id", "name", "contact_number", "primary_contact", "business_address", "number_of_purchases"};
                        string[] purchaseRequestFields = {"id", "keyboard_requestid", "quantity", "staff_id", "approved"};
                        string[] keyboardRequestFields = {"id", "model_number", "purchase_request_id"};

                        // switch the table depending on which fields have been discovered
                        if (fields.SequenceEqual(staffFields))
                        {
                            db.Staff.Add(new Staff { });
                        }
                        else if (fields.SequenceEqual(credentialsFields))
                        {
                            db.Credentials.Add(new Credential { });
                        }
                        else if(fields.SequenceEqual(keyboardFields))
                        {
                            db.KeyboardRequests.Add(new KeyboardRequest { });
                        }
                        else if (fields.SequenceEqual(supplierFields))
                        {
                            db.Suppliers.Add(new Supplier { });
                        }
                        else if(fields.SequenceEqual(purchaseRequestFields))
                        {
                            db.PurchaseRequests.Add(new PurchaseRequest { });
                        }
                        else if(fields.SequenceEqual(keyboardRequestFields))
                        {
                            db.KeyboardRequests.Add(new KeyboardRequest { });
                        }

                        // Save changes
                        db.SaveChanges();
                    }
                }
                
            }
        }
    }
}
