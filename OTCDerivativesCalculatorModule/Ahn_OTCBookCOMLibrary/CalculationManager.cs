using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using Excel_Interface;

namespace Ahn_OTCBookCOMLibrary
{
    [ClassInterface(ClassInterfaceType.AutoDual)]
    public class CalculationManager
    {

        public string availableCore()
        {
            return "";
        }

        public string set_calculationDate(DateTime refDate)
        {
            return "";
        }

        public string calculateStart()
        {
            return "";
        }

        public string calculateStop()
        {
            return "";
        }

        public string add_queue(string itemCode)
        {
            return "";
        }

        public string get_queueList()
        {
            return "";
        }

        public string clear_queue()
        {
            return "";
        }

    }
}
