using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RiskMonitor
{
    public static class ErrorManager
    {
        [ThreadStatic]
        private static List<Error> ErrorList_ = new List<Error>();

        [ThreadStatic]
        private static int errNum_ = 0;

        public static void setError(Error err)
        {
            ErrorList_.Add(err);
            errNum_ += 1;
        }

        public static void setError(Exception e)
        {
            string errText = e.Source + " , "+ e.Message;
            ErrorList_.Add(new Error(errText));
            errNum_ += 1;
        }

        public static string errStr()
        {
            string err = "";
            int errNum = 1;


            err += "Entire Err Log" + "\n";

            foreach (var item in ErrorList_)
            {

                err += errNum + " : " + item.Message + "\n";
                errNum += 1;

            }

            return err;

        }

        public static string clear()
        {
            int removedNum = errNum_;
            errNum_ = 0;

            ErrorList_ = new List<Error>();

            return removedNum + " errLog removed";
        }
    }
}
