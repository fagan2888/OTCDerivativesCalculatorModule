using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface 
{
    //public class StringValueAttribute : System.Attribute
    //{

    //    private string _value;

    //    public StringValueAttribute(string value)
    //    {
    //        _value = value;
    //    }

    //    public string Value
    //    {
    //    get { return _value; }
    //    }

    //}

    public enum SystemVariable 
    {
        //[StringValue("POSITION_LASTDATE")]
        POSITION_LASTDATE,

        //[StringValue("POSITION_LASTCALCULATED_DATE")]
        POSITION_LASTCALCULATED_DATE,

        //[StringValue("PL_BATCH_END_FLAG")]
        PL_BATCH_END_FLAG,

        //[StringValue("CALCULATION_BATCH_END_FLAG")]
        CALCULATION_BATCH_END_FLAG

    }

    public class SystemVariableManager
    {
        private static DateTime LoadedTime_ = new DateTime();
        private static Dictionary<string, List<string>> variables_ = new Dictionary<string, List<string>>();

        public static void load()
        {
            SystemVariableManager.LoadedTime_ = DateTime.Now;
            SystemVariableManager.variables_.Clear();

            List<string> testLIst = new List<string>();

            testLIst.Add("date");
            testLIst.Add("test Date");

            SystemVariableManager.variables_.Add("testVar",testLIst);

        }

        public static string getValue(SystemVariable sv)
        {
            // 첫번째 있는게 value
            string keyValue = sv.ToString();
            return (SystemVariableManager.variables_[keyValue])[0];
        }

        public static bool getFlag(SystemVariable sv)
        {
            // 첫번째 있는게 value
            string keyValue = sv.ToString();

            string tf = (SystemVariableManager.variables_[keyValue])[0];

            return Convert.ToBoolean(tf);
        }
    }
}
