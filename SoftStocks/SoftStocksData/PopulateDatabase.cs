using Microsoft.VisualBasic.FileIO;
using SoftStocksData.Entities.Keyboards;
using SoftStocksData.Entities.Purchases;
using SoftStocksData.Entities.StaffMember;
using SoftStocksData.Entities.Suppliers;
using SoftStocksData.Keyboards;
using System.Data;
using System.Globalization;

namespace SoftStocksData
{
    public static class PopulateDatabase
    {
        private static void FromCSVFile(string fileName)
        {
            using(TextFieldParser parser = new TextFieldParser(fileName))
            {
                using (SoftStocksDBContext db = new SoftStocksDBContext())
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");

                    string[] header = parser.ReadFields();

                    // database fields
                    string[] staffHeader = { "id", "title", "first_name", "last_name", "email_address", "role", "date_of_birth", "salary" };
                    string[] credentialsHeader = { "username", "staff_id", "password" };
                    string[] keyboardHeader = { "model_number", "supplier_id", "quantity", "description", "price" };
                    string[] supplierHeader = { "id", "name", "contact_number", "primary_contact", "business_address"};
                    string[] purchaseRequestHeader = {"id", "keyboard_requestid", "quantity", "staff_id"};
                    string[] keyboardRequestHeader = { "id", "model_number", "purchase_request_id" };
                    string[] purchaseTransactionHeader = { "id", "purchase_requestid", "type" };

                    while (!parser.EndOfData)
                    {
                        // what are the fields stored in the database?
                        string[] fields = parser.ReadFields();

                        // switch the table depending on which fields have been discovered
                        if (header.SequenceEqual(staffHeader))
                        {
                            Staff newStaff = new Staff {
                                Id = int.Parse(fields[0]),
                                Title = fields[1],
                                FirstName = fields[2],
                                LastName = fields[3],
                                EmailAddress = fields[4],
                                Role = fields[5],
                                DateOfBirth = DateTime.Parse(fields[6], new CultureInfo("en-GB")),
                                Salary = float.Parse(fields[7], CultureInfo.InvariantCulture.NumberFormat)
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
                                Id = int.Parse(fields[0]),
                                Name = fields[1],
                                ContactNumber = fields[2],
                                PrimaryContact = fields[3],
                                BusinessAddress = fields[4]
                            };
                            db.Suppliers.Add(newSupplier);
                        }
                        else if(header.SequenceEqual(purchaseRequestHeader))
                        {
                            PurchaseRequest newPurchaseRequest = new PurchaseRequest
                            {
                                Id = int.Parse(fields[0]),
                                KeyboardRequestId = int.Parse(fields[1]),
                                Quantity = int.Parse(fields[2]),
                                StaffId = int.Parse(fields[3])
                            };
                            db.PurchaseRequests.Add(newPurchaseRequest);
                        }
                        else if(header.SequenceEqual(keyboardRequestHeader))
                        {
                            KeyboardRequest newKeyboardRequest = new KeyboardRequest
                            {
                                Id = int.Parse(fields[0]),
                                ModelNumber = int.Parse(fields[1]),
                                PurchaseRequestId = int.Parse(fields[2])
                            };
                            db.KeyboardRequests.Add(newKeyboardRequest);
                        }
                        else if(header.SequenceEqual(purchaseTransactionHeader))
                        {
                            PurchaseTransaction newPurchaseTransaction = new PurchaseTransaction
                            {
                                Id = int.Parse(fields[0]),
                                PurchaseRequestId = int.Parse(fields[1]),
                                Type = fields[2]
                            };
                            db.PurchaseTransactions.Add(newPurchaseTransaction);
                        }

                        db.SaveChanges();
                    }
                }
            }
        }

        private static void Clear()
        {
            using (var context = new SoftStocksDBContext())
            {
                context.Staff.RemoveRange(context.Staff);
                context.Credentials.RemoveRange(context.Credentials);
                context.Suppliers.RemoveRange(context.Suppliers);
                context.Keyboards.RemoveRange(context.Keyboards);
                context.PurchaseRequests.RemoveRange(context.PurchaseRequests);
                context.KeyboardRequests.RemoveRange(context.KeyboardRequests);
                context.PurchaseTransactions.RemoveRange(context.PurchaseTransactions);


                context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('dbo.Staffs', RESEED, 0)");
                context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('dbo.Suppliers', RESEED, 0)");
                context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('dbo.PurchaseRequests', RESEED, 0)");
                context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('dbo.KeyboardRequests', RESEED, 0)");
                context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('dbo.PurchaseTransactions', RESEED, 0)");
                
                context.SaveChanges();
            }
        }

        public static void SetUp()
        {
            string[] tables = { "staff", "credentials", "keyboard", "supplier", "keyboardRequest", "purchaseRequest", "purchaseTransaction" };

            Clear();
            foreach (var table in tables)
            {
				string path = Path.Combine(Directory.GetCurrentDirectory(), @$"CSV data\{table}_data.csv");
				FromCSVFile(path);
            }
        }
    }
}
