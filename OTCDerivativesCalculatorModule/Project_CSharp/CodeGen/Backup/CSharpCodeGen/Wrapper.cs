using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CSharpCodeGen
{
    public static class Wrapper
    {

        private static string tapStr = "";
        
        public static void makeTapStr(int tapSize) 
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < tapSize; i++)
			{
                sb.Append(" "); 
			}

            Wrapper.tapStr = sb.ToString();
        }

        public static string TapCode(string code) 
        {
            StringBuilder sb = new StringBuilder();

            string[] tokens = Regex.Split(code, @"\r?\n|\r");

            foreach (string item in tokens)
            {
                sb.AppendLine(tapStr + item);
            }


            return sb.ToString();            
        }

        public static string TapCode(StringBuilder code)
        {
            StringBuilder sb = new StringBuilder();

            string[] tokens = Regex.Split(code.ToString(), @"\r?\n|\r");

            foreach (string item in tokens)
            {
                sb.AppendLine(tapStr + item);
            }

            return sb.ToString();
        }

        public static string WrapCode(string code)
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine("{");
            string[] tokens = Regex.Split(code, @"\r?\n|\r");

            foreach (string item in tokens)
            {
                sb.AppendLine(tapStr + item);
            }
            
            sb.AppendLine("}");

            return sb.ToString();
            //return code;
        }

        public static string WrapCode(StringBuilder code) 
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("{\r\n");
            string[] tokens = Regex.Split(code.ToString(), @"\r?\n|\r");

            foreach (string item in tokens)
            {
                sb.Append(tapStr + item);
                sb.Append("\r\n");
            }

            sb.Append("}\r\n");

            return sb.ToString();

        }

        public static string WrapNameSpace(string code, string nameStr)
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine("{");
            string[] tokens = Regex.Split(code, @"\r?\n|\r");

            foreach (string item in tokens)
            {
                sb.AppendLine(tapStr + item);
            }
            
            sb.AppendLine("}");

            return sb.ToString();
        }

        public static string WrapNameSpace(StringBuilder code, StringBuilder nameStr)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("namespace ");
            sb.AppendLine(nameStr.ToString());
            sb.Append(Wrapper.WrapCode(code));

            return sb.ToString();
        }

        public static string WrapNameSpace(StringBuilder code, string nameStr)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("namespace ");
            sb.AppendLine(nameStr);
            sb.Append(Wrapper.WrapCode(code));

            return sb.ToString();
        }
    }
}
