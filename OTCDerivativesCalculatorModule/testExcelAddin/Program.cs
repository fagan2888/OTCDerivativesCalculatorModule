using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excel_Interface;

namespace testExcelAddin
{
    class Program
    {
        static void Main(string[] args)
        {
            DataInterfaceManager dim = new DataInterfaceManager();

            DateTime refDate = new DateTime();

            dim.generateParaXml(refDate);
        }
    }
}
