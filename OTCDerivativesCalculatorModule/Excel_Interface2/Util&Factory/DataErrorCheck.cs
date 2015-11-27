using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Excel_Interface
{
    public class DataErrorCheck
    {
        public static bool check(string type, string owner, string value)
        {

            bool tf = true;

            if (type.ToUpper() == "NULL")
            {
                if (value == null)
                {
                    tf = false;
                    MessageBox.Show(owner + " : need value");
                }
            }

            return tf;
        }
    }
}
