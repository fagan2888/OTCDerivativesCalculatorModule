using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Excel_Interface
{
    public class QueryStr
    {

        public QueryStr(FileInfo fileInfo)
        {
            this.FileInfo_ = fileInfo;
            this.VariableMap_ = new Dictionary<string, string>();

            //load
            try
            {
                StreamReader sr = new StreamReader(this.FileInfo_.FullName);
                this.Text_ = sr.ReadToEnd();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public FileInfo FileInfo_ { get; private set; }

        public List<string> Variable_ { get; set;}
        public Dictionary<string, string> VariableMap_ { get; set; }
        
        public string Text_ { get; set; }

        public string getQuery()
        {
            StringBuilder sb = new StringBuilder(this.Text_);
            foreach (var item in VariableMap_)
	        {
                sb.Replace("@" + item.Key + "@", item.Value);
	        }

            return sb.ToString();
        }

        public static string wrapComma(string s)
        {
            s = "'" + s + "'";
            return s;
        }

        
        //public void

    }
}
