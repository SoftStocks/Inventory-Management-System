using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SoftStocksData
{
    internal class Report
    {
        public int Id;
        public DateTime CreationTimestamp;

        public object Generate(ReportFormat format)
        {
            return true;
        }

        public void Destroy()
        {

        }
    }

    internal class StaffReport : Report
    {
        public int Title;
        public string FirstName;
        public string LastName;
        public string Role;
        public DateTime DateOfBirth;
        public float Salary;

        public StaffReport(int Title, string FirstName, string LastName, string Role, DateTime DateOfBirth, float salary)
        {
            this.Id = base.Id;
            this.CreationTimestamp = base.CreationTimestamp;
            this.Title = Title;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Role = Role;
            this.DateOfBirth = DateOfBirth;
            this.Salary = salary;

        }

        public object Generate(ReportFormat format) {
            return format switch
            {
                ReportFormat.Pdf => true,
                ReportFormat.Email => true,
                ReportFormat.Notification => true,
                _ => (object)false,
            };
        }
    }
}

