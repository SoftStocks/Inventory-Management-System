using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
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
                            Staff newStaff = new Staff {
                                Title = fields[0],
                                FirstName = fields[1],
                                LastName = fields[2],
                                Role = fields[3],
                                DateOfBirth = DateTime.Parse(fields[4], new CultureInfo("en-GB")),
                                Salary = float.Parse(fields[5], CultureInfo.InvariantCulture.NumberFormat)
                            };
                            db.Staff.Add(newStaff);
                        }
                        else if (header.SequenceEqual(credentialsHeader))
                        {
                            Credential newCredential = new Credential
                            {
                                Username = fields[0],
                                StaffId = int.Parse(fields[1]),
                                Password = fields[2]
                            };
                            db.Credentials.Add(newCredential);
                        }
                        else if(header.SequenceEqual(keyboardHeader))
                        {
                            Keyboard newKeyboard = new Keyboard
                            {
                                ModelNumber = int.Parse(fields[0]),
                                SupplierId = int.Parse(fields[1]),
                                Quantity = int.Parse(fields[2]),
                                Description = fields[3],
                                Price = (System.Data.SqlTypes.SqlMoney)float.Parse(fields[4])
                            };
                            db.Keyboards.Add(newKeyboard);
                        }
                        else if (header.SequenceEqual(supplierHeader))
                        {
                            Supplier newSupplier = new Supplier
                            {
                                Name = fields[0],
                                ContactNumber = fields[1],
                                PrimaryContact = fields[2],
                                BusinessAddress = fields[3],
                                NumberOfPurchases = int.Parse(fields[4])
                            };
                            db.Suppliers.Add(newSupplier);
                        }
                        else if(header.SequenceEqual(purchaseRequestHeader))
                        {
                            PurchaseRequest newPurchaseRequest = new PurchaseRequest
                            {
                                KeyboardRequestId = int.Parse(fields[0]),
                                Quantity = int.Parse(fields[1]),
                                StaffId = int.Parse(fields[2]),
                                Approved = bool.Parse(fields[3])
                            };
                            db.PurchaseRequests.Add(newPurchaseRequest);
                        }
                        else if(header.SequenceEqual(keyboardRequestHeader))
                        {
                            KeyboardRequest newKeyboardRequest = new KeyboardRequest
                            {
                                ModelNumber = fields[0],
                                PurchaseRequestId = int.Parse(fields[1])
                            };
                            db.KeyboardRequests.Add(newKeyboardRequest);
                        }

                        db.SaveChanges();
                    }
                }
                
            }
        }

        public static void ClearFrom(string table)
        {
            using (var context = new SoftStocksDBContext())
            {
                context.Database.ExecuteSqlCommand($"TRUNCATE TABLE {table}");
                context.SaveChanges();
            }
        }
    }
}
