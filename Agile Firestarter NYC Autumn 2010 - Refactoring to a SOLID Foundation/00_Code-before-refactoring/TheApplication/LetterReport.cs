using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.SOLID
{
    public class LetterReport : Report
    {

        public override void Print()
        {
            LetterReportPrinter reportPrinter = new LetterReportPrinter();
            reportPrinter.Print();

        }



    }
}
