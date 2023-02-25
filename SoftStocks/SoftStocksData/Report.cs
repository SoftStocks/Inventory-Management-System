using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SoftStocksData
{
    internal class Report
    {
        private string Id;
        private DateTime CreationTimestamp;

        public Report(string id)
        {
            this.Id = id;
            this.CreationTimestamp = DateTime.Now;

        }

        public object Generate(ReportFormat format)
        {
            return true;
        }

        public void Destroy()
        {

        }
    }
}
