namespace SoftStocksData.Reports
{
    public abstract class Report
    {
        public int Id;
        public DateTime CreationTimestamp = DateTime.Now;
        public Admin requestor; //TODO: get Admin object created 

        public abstract string Create(ReportFormat format);
        public abstract void Delete();
        public abstract void Download();
    }
}

