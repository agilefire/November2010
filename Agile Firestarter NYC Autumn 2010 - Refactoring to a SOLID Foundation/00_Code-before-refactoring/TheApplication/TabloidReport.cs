using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.SOLID
{
    public class TabloidReport : Report
    {
        public override void Print()
        {
            ReportPrinter reportPrinter = new TabloidReportPrinter();
            reportPrinter.Print();
        }
    }
}
