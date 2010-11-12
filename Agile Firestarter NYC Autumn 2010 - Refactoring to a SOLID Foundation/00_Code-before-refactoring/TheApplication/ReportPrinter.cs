using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.SOLID
{
    public class TabloidReportPrinter : ReportPrinter
    {
        public override void Print()
        {
            DataAccess dataAccess = new DataAccess();
            ReportFormatter reportFormatter = new TabloidReportFormatter();

            dataAccess.GetData();
            reportFormatter.FormatReport();
            Console.WriteLine("\nPrinting Report to Dot Matrix Printer...");
        }
    }
    public abstract class ReportPrinter
    {
        public abstract void Print();
    }
    public class LetterReportPrinter : ReportPrinter
    {
        public override void Print()
        {
            DataAccess dataAccess = new DataAccess();
            ReportFormatter reportFormatter = new LetterReportFormatter();

            dataAccess.GetData();
            reportFormatter.FormatReport();
            Console.WriteLine("\nPrinting Report to Laser Printer...");
        }
    }
}
