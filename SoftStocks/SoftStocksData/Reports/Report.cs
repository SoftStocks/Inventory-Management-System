using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SoftStocksData.Reports
{
    public abstract class Report
    {
        public int Id;
        public DateTime CreationTimestamp;

        public abstract string Generate(ReportFormat format);
        public abstract void Destroy();
    }
}

