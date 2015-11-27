using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class SQL_Logger
    {
        public static List<string> log_;

        public static void addLog(string sql)
        {
            log_.Add(sql);
        }

        public static void exportFile(string fileName)
        { 
            
        }

    }
}
