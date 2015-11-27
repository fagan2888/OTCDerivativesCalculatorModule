using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpCodeGen
{
    public enum TypeSym
    { None, BoostPtr, Ptr, Ref }

    public class Variable
    {
        const string tap = "	   ";
        public static List<string> built_in_type;

        public Variable(string varType,
                         string varName,
                         bool isVector,
                         bool choice,
                         bool substitute = false) 
        {
            //여기다 박기로... 이거 함수로 빼서 수정.
            // std::vector<>
            this.isVector = isVector;
            this.choice = choice;
            this.substitute = substitute;

            Basic_varType = varType;
            m_varType = varType;

            if (isVector)
            {
                m_varType = "List<" + varType + ">";
            }

            m_varName = varName;
            

            if (built_in_type.Contains(varType))
            {
                StringBuilder upperChange = new StringBuilder(varType);
                upperChange[0] = varType.ToUpper()[0];
                Basic_varType = "XsdType" + upperChange;

                if (isVector)
                {
                    m_varType = "List<XsdType" + upperChange + ">";
                }
                else 
                {
                    m_varType = "XsdType" + upperChange ;
                }

                isBuiltInType = true;
            }
        }

        //private bool isBuiltInType = false;
        
        public string m_varType {get; set;}
        public string m_varName { get; set; }
        
        #region CppCode
        private string cppCode;
        public string CppCode
        {
            get { return this.cppCode; }
            set
            {
                if (this.cppCode != value)
                {
                    this.cppCode = value;
                }
            }
        }
        #endregion

        #region IDRefCode
        private string idRefCode;
        public string IDRefCode
        {
            get { return this.idRefCode; }
            set
            {
                if (this.idRefCode != value)
                {
                    this.idRefCode = value;
                    //this.RaisePropertyChanged("IDRefCode");
                }
            }
        }
        #endregion

        #region Choice
        private bool choice;
        public bool Choice
        {
            get { return this.choice; }
            set
            {
                if (this.choice != value)
                {
                    this.choice = value;
                    //this.RaisePropertyChanged("Choice");
                }
            }
        }
        #endregion

        #region IsVector
        private bool isVector;
        public bool IsVector
        {
            get { return this.isVector; }
            set
            {
                if (this.isVector != value)
                {
                    this.isVector = value;
                    //this.RaisePropertyChanged("isVector");
                }
            }
        }
        #endregion

        #region SubstitudeStr
        private string substitudeStr;
        public string SubstitudeStr
        {
            get { return this.substitudeStr; }
            set
            {
                if (this.substitudeStr != value)
                {
                    this.substitudeStr = value;
                    //this.RaisePropertyChanged("SubstitudeVar");
                }
            }
        }
        #endregion

        public string Basic_varType { get; set; }

        public bool isBuiltInType { get; set; }

        public bool substitute { get; set; }


        public string ConstructorInitialCode() 
        {
            StringBuilder sb = new StringBuilder();

            string IDRefStr = m_varName + "IDRef_";
            string nodeListStr = m_varName + "NodeList";
            string m_varNameNode = m_varName + "Node";
            StringBuilder underBar_m_varName = new StringBuilder(m_varName + "_");

            if (IsVector == true)
            {
                sb.AppendLine("XmlNodeList " + nodeListStr + " = xmlNode.SelectNodes(\"" + m_varName + "\");");
                sb.AppendLine();
                sb.AppendLine("if (" + nodeListStr + " != null)");
                sb.AppendLine("{");
                sb.AppendLine("    this." + underBar_m_varName + " = new " + m_varType + "();");
                sb.AppendLine("    foreach (XmlNode item in " + nodeListStr + ")");
                sb.AppendLine("    {");
                sb.AppendLine("        if (item.Attributes[\"href\"] != null || item.Attributes[\"id\"] != null) ");
                sb.AppendLine("        {");
                sb.AppendLine("            if (item.Attributes[\"id\"] != null) ");
                sb.AppendLine("            {");
                sb.AppendLine("                " + IDRefStr + " = item.Attributes[\"id\"].Value;");
                sb.AppendLine("                " + underBar_m_varName + ".Add(new " + Basic_varType + "(item));");
                sb.AppendLine("                IDManager.SetID(" + IDRefStr + ", " + underBar_m_varName + "["+underBar_m_varName+".Count - 1 ]);");
                sb.AppendLine("            }");
                sb.AppendLine("            else if (item.Attributes[\"href\"] != null)");
                sb.AppendLine("            {");
                sb.AppendLine("                " + IDRefStr + " = item.Attributes[\"href\"].Value;");
                //sb.AppendLine("                " + underBar_m_varName + ".Add(IDManager.getID( " + IDRefStr + " ) as " + Basic_varType + ");");
                sb.AppendLine("            }");
                sb.AppendLine("            else");
                sb.AppendLine("            {");
                sb.AppendLine("            " + underBar_m_varName + ".Add(new " + Basic_varType + "(item));");
                sb.AppendLine("            }");
                sb.AppendLine("        }");
                sb.AppendLine("        else");
                sb.AppendLine("        {");
                sb.AppendLine("            " + underBar_m_varName + ".Add(new " + Basic_varType + "(item));");
                sb.AppendLine("        }");
                sb.AppendLine("    }");
                sb.AppendLine("}");
            }
            else 
            {
                string nodeStr = m_varName + "Node";

                sb.AppendLine("XmlNode " + m_varNameNode + " = xmlNode.SelectSingleNode(\"" + m_varName + "\");");
                sb.AppendLine();
                sb.AppendLine("if (" + m_varNameNode + " != null)");
                sb.AppendLine("{");
                sb.AppendLine("    if (" + m_varNameNode + ".Attributes[\"href\"] != null || " + m_varNameNode + ".Attributes[\"id\"] != null) ");
                sb.AppendLine("    {");
                sb.AppendLine("        if (" + m_varNameNode + ".Attributes[\"id\"] != null) ");
                sb.AppendLine("        {");
                sb.AppendLine("            " + IDRefStr + " = " + m_varNameNode + ".Attributes[\"id\"].Value;");
                sb.AppendLine("            " + m_varType + " ob = new " + m_varType + "(" + m_varNameNode + ");");
                sb.AppendLine("            IDManager.SetID(" + IDRefStr + ", ob);");
                sb.AppendLine("        }");
                sb.AppendLine("        else if (" + m_varNameNode + ".Attributes[\"href\"] != null)");
                sb.AppendLine("        {");
                sb.AppendLine("            " + IDRefStr + " = " + m_varNameNode + ".Attributes[\"href\"].Value;");
                //sb.AppendLine("            " + underBar_m_varName + " = IDManager.getID( " + IDRefStr + " ) as " + Basic_varType + ";");
                sb.AppendLine("        }");
                sb.AppendLine("        else");
                sb.AppendLine("        {");
                sb.AppendLine("            " + underBar_m_varName + " = new " + Basic_varType + "(" + m_varNameNode + ");");
                sb.AppendLine("        }");
                sb.AppendLine("    }");
                sb.AppendLine("    else");
                sb.AppendLine("    {");
                sb.AppendLine("        " + underBar_m_varName + " = new " + Basic_varType + "(" + m_varNameNode + ");");
                sb.AppendLine("    }");
                sb.AppendLine("}");
            }

            return sb.ToString();
        
        }

        public string PropertyCode()
        {
            StringBuilder sb = new StringBuilder();
            
            StringBuilder UpperStr = new StringBuilder(m_varName);
            UpperStr[0] = m_varName.ToUpper()[0];

            StringBuilder underBar_m_varName = new StringBuilder(m_varName + "_");
            StringBuilder underBar_UpperStr = new StringBuilder(UpperStr + "_");

            //if (substitute) { sb.AppendLine("     // substitude"); }

            sb.AppendLine("#region " + underBar_UpperStr);
            sb.AppendLine("private " + m_varType + " " + underBar_m_varName + ";");
            sb.AppendLine("public " + m_varType + " " + underBar_UpperStr);
            sb.AppendLine("{");
            sb.AppendLine("    get");
            sb.AppendLine("    {");
            sb.AppendLine("        if (this." + underBar_m_varName + " != null)");
            sb.AppendLine("        {");
            sb.AppendLine("            return this." + underBar_m_varName + "; ");
            sb.AppendLine("        }");
            sb.AppendLine("        else if (this." + m_varName + "IDRef_ != null)");
            sb.AppendLine("        {");

            if (isVector == false)
            {
                sb.AppendLine("            " + underBar_m_varName + " = IDManager.getID(" + m_varName + "IDRef_) as " + m_varType + ";");
            }

            sb.AppendLine("            return this." + underBar_m_varName + "; ");
            sb.AppendLine("        }");
            sb.AppendLine("        else");
            sb.AppendLine("        {");
            //sb.AppendLine("            throw new NotImplementedException();");
            sb.AppendLine("              return this." + underBar_m_varName + "; ");
            sb.AppendLine("        }");
            sb.AppendLine("    }");
            sb.AppendLine("    set");
            sb.AppendLine("    {");
            sb.AppendLine("        if (this." + underBar_m_varName + " != value)");
            sb.AppendLine("        {");
            sb.AppendLine("            this." + underBar_m_varName + " = value;");
            sb.AppendLine("        }");
            sb.AppendLine("    }");
            sb.AppendLine("}");
            sb.AppendLine("#endregion");

            return sb.ToString();
        }

        public string IDRefFieldCode()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("public string " + m_varName + "IDRef_ { get; set; }");

            if (substitute) { sb.Append("     // substitude"); }

            return sb.ToString();
        }

    }
}
