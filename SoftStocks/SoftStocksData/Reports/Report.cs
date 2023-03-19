namespace SoftStocksData.Reports
{
    public abstract class Report
    {
        public int Id;
        public DateTime CreationTimestamp = DateTime.Now;

        public abstract string Create(ReportFormat format);
        public abstract void Delete();
        public abstract void Download();
    }
}

