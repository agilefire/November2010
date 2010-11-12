using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.SOLID
{
    public class TabloidReportFormatter : ReportFormatter
    {
        public override void FormatReport()
        {
            Console.WriteLine("\nFormatting Report for 11x17...");
        }

    }
}
