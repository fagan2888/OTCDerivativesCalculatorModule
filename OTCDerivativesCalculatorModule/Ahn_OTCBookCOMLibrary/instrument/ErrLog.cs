using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ahn_OTCBookCOMLibrary
{
    public class ErrLog
    {
        private List<string> logs_;

        public ErrLog()
        {
            logs_ = new List<string>();

        }

        public void add(string err)
        {
            this.logs_.Add(err);
        }

        public string getErrList()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in this.logs_)
            {
                sb.AppendLine(item);
            }

            return sb.ToString();
        }
        

    }
}
