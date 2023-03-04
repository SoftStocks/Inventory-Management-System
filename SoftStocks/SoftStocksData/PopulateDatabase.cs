using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftStocksData
{
    internal static class PopulateDatabase
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
                        string[] fields = parser.ReadFields();

                        // what are the fields stored in the database?
                        // switch the table depending on which fields have been discovered

                        //Read the file
                        //Create dbContext record based on the parsed data
                        db.Staff.Add(new Staff());
                        //Save changes
                        db.SaveChanges();
                    }
                }
                
            }
        }
    }
}
