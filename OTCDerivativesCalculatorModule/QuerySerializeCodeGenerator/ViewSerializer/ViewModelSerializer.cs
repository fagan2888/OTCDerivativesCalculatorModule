using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuerySerializeCodeGenerator
{
    public class ViewModelSerializer
    {
        private QueryBuilder qm_;

        public ViewModelSerializer(QueryBuilder qm)
        {
            // TODO: Complete member initialization
            this.qm_ = qm;
        }

        public string build()
        {
            StringBuilder sb = new StringBuilder();

            //sb.Append(this.constructor());
            sb.Append(this.property());
            sb.Append(this.setFromDAOMethod());
            sb.Append(this.buildDAOMethod());

            return sb.ToString();

        }

        private string constructor()
        {
            StringBuilder sb = new StringBuilder();

            return sb.ToString();
        }

        private string setFromDAOMethod()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("public void setFromDAO(" + qm_.TableName_ + "_Table_DAO dao)");
            sb.AppendLine("{");
            sb.AppendLine("// bussiness logic here");

            foreach (var item in this.qm_.ColumnList_)
            {
                string lowerItem = item.ToLower();
                string upperItem = item.ToUpper();
                string fus = this.FirstUpperStr(lowerItem);
                string s = (item.Substring(item.Length - 4, 4)).ToUpper();
                
                if (s == "DATE")
                {
                    sb.AppendLine("this." + fus + "_ = DateTime.ParseExact(dao." + upperItem + "_, \"" + StringFormat.DateString_ + "\", null);");
                }
                else
                {
                    sb.AppendLine("this." + lowerItem + "_" + " =  dao." + upperItem + "_;");
                }
                

                
            }

            sb.AppendLine("}");
            sb.AppendLine();

            return sb.ToString();
        }

        private string buildDAOMethod()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("public void buildDAO()");
            sb.AppendLine("{");
            sb.AppendLine("// bussiness logic here");

            sb.AppendLine("" + qm_.TableName_ + "_Table_DAO insertDao = new " + qm_.TableName_ + "_Table_DAO();");

            foreach (var item in this.qm_.ColumnList_)
            {
                string lowerItem = item.ToLower();
                string upperItem = item.ToUpper();
                string fus = this.FirstUpperStr(lowerItem);
                string s = (item.Substring(item.Length - 4, 4)).ToUpper();

                if (s == "DATE")
                {
                    sb.AppendLine("insertDao." + upperItem + "_ = this." + fus + "_.ToString(\"yyyyMMdd\");");
                }
                else
                {
                    sb.AppendLine("insertDao." + upperItem + "_ = this." + fus + "_;");
                }

            }

            sb.AppendLine("}");
            sb.AppendLine();

            return sb.ToString();
        }

        private string property()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("#region Properties");
            sb.AppendLine();

            foreach (var item in this.qm_.ColumnList_)
            {
                string lowerItem = item.ToLower();
                string upperItem = item.ToUpper();

                string fus = this.FirstUpperStr(lowerItem);
                string s = (item.Substring(item.Length - 4, 4)).ToUpper();
                
                string typeStr = "";

                if (s == "DATE")
                {
                    typeStr = "DateTime";
                }
                else
                {
                    typeStr = "string";
                }

                sb.AppendLine("#region " + fus + "_");
                sb.AppendLine("private " + typeStr + " " + lowerItem + "_;");
                sb.AppendLine("public " + typeStr + " " + fus + "_");
                sb.AppendLine("{");
                sb.AppendLine("get { return this." + lowerItem + "_; }");
                    sb.AppendLine("set");
                    sb.AppendLine("{");
                    sb.AppendLine("if (this." + lowerItem + "_ != value)");
                        sb.AppendLine("{");
                        sb.AppendLine("this." + lowerItem + "_ = value;");
                        sb.AppendLine("this.NotifyPropertyChanged(\"" + fus + "_\");");
                        sb.AppendLine("}");
                    sb.AppendLine("}");
                sb.AppendLine("}");
                sb.AppendLine("#endregion");
                sb.AppendLine();
            }

            sb.AppendLine();

            sb.AppendLine("#endregion");

            sb.AppendLine();

            return sb.ToString();
        }

        private string FirstUpperStr(string s)
        {
            StringBuilder UpperStr = new StringBuilder(s);
            UpperStr[0] = s.ToUpper()[0];

            return UpperStr.ToString();
        }
    }
}
