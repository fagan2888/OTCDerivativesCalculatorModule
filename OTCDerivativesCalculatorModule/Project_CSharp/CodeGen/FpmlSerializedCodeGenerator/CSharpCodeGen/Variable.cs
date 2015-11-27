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

            this.upperStr = new StringBuilder(m_varName);
            upperStr[0] = m_varName.ToUpper()[0];

            this.underBar_m_varName_VM = new StringBuilder(m_varName + "ViewModel_");
            this.underBar_UpperStr_VM = new StringBuilder(upperStr + "ViewModel_");
            this.upperStr_VM = new StringBuilder(upperStr + "ViewModel");


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

        public StringBuilder upperStr { get; set; }

        public StringBuilder underBar_m_varName_VM { get; set; }
        public StringBuilder underBar_UpperStr_VM { get; set; }
        public StringBuilder upperStr_VM { get; set; }
        

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
            sb.AppendLine("            throw new Exception( \""+ m_varName + "_Node no exist!"+ "\");");
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

        public string PropertyViewModelCode()
        {
            StringBuilder sb = new StringBuilder();

            //if (substitute) { sb.AppendLine("     // substitude"); }
            if (this.isVector)
            {
                sb.AppendLine("#region " + underBar_UpperStr_VM);
                sb.AppendLine("private " + "ObservableCollection<" + upperStr_VM + "> " + underBar_m_varName_VM + ";");
                sb.AppendLine("public " + "ObservableCollection<" + upperStr_VM + "> " + underBar_UpperStr_VM);
                sb.AppendLine("{");
                sb.AppendLine("    get { return this." + underBar_m_varName_VM + "; }");
                sb.AppendLine("    set");
                sb.AppendLine("    {");
                sb.AppendLine("        if (this." + underBar_m_varName_VM + " != value)");
                sb.AppendLine("        {");
                sb.AppendLine("            this." + underBar_m_varName_VM + " = value;");
                sb.AppendLine("            this.NotifyPropertyChanged(" + "\"" + underBar_UpperStr_VM + "\"" + ");");
                sb.AppendLine("        }");
                sb.AppendLine("    }");
                sb.AppendLine("}");
                sb.AppendLine("#endregion");
            }
            else 
            {
                sb.AppendLine("#region " + underBar_UpperStr_VM);

      
                sb.AppendLine("private " + upperStr_VM + " " + underBar_m_varName_VM + ";");
                sb.AppendLine("public " + upperStr_VM + " " + underBar_UpperStr_VM);
      

                

                sb.AppendLine("{");
                sb.AppendLine("    get { return this." + underBar_m_varName_VM + "; }");
                sb.AppendLine("    set");
                sb.AppendLine("    {");
                sb.AppendLine("        if (this." + underBar_m_varName_VM + " != value)");
                sb.AppendLine("        {");
                sb.AppendLine("            this." + underBar_m_varName_VM + " = value;");
                sb.AppendLine("            this.NotifyPropertyChanged(" + "\"" + underBar_UpperStr_VM + "\"" + ");");
                sb.AppendLine("        }");
                sb.AppendLine("    }");
                sb.AppendLine("}");
                sb.AppendLine("#endregion");
            }
            

            return sb.ToString();
        }

        public string PropertyCodePropType()
        {
            StringBuilder sb = new StringBuilder();

            StringBuilder UpperStr = new StringBuilder(m_varName);
            UpperStr[0] = m_varName.ToUpper()[0];

            StringBuilder underBar_m_varName = new StringBuilder(m_varName + "_");
            StringBuilder underBar_UpperStr = new StringBuilder(UpperStr + "_");
            //StringBuilder upperStr = new StringBuilder(UpperStr + "_");

            StringBuilder typeStr;

            if (isVector)
            {
                typeStr = new StringBuilder("ObservableCollection<string>");
            }
            else 
            {
                typeStr = new StringBuilder("string");
            }

            //if (substitute) { sb.AppendLine("     // substitude"); }

            sb.AppendLine("#region " + underBar_UpperStr);

            if (m_varName.Length > 4)
            {
                if (m_varName.Substring(m_varName.Length - 4, 4).ToUpper() == "DATE")
                {
                    sb.AppendLine("private DateTime " + underBar_m_varName + ";");
                    sb.AppendLine("public DateTime " + underBar_UpperStr);
                }
                else
                {
                    sb.AppendLine("private " + typeStr + " " + underBar_m_varName + ";");
                    sb.AppendLine("public " + typeStr + " " + underBar_UpperStr);
                }
            }
            else
            {
                sb.AppendLine("private " + typeStr + " " + underBar_m_varName + ";");
                sb.AppendLine("public " + typeStr + " " + underBar_UpperStr);
            }

            sb.AppendLine("{");
            sb.AppendLine("    get { return this." + underBar_m_varName + "; }");
            sb.AppendLine("    set");
            sb.AppendLine("    {");
            sb.AppendLine("        if (this." + underBar_m_varName + " != value)");
            sb.AppendLine("        {");
            sb.AppendLine("            this." + underBar_m_varName + " = value;");
            sb.AppendLine("            this.NotifyPropertyChanged(" + "\"" + underBar_UpperStr + "\"" + ");");
            sb.AppendLine("        }");
            sb.AppendLine("    }");
            sb.AppendLine("}");
            sb.AppendLine("#endregion");

            return sb.ToString();
        }

        public string SetFromSerialCodeVM(string parent,string thisClass)
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder UpperStr = new StringBuilder(m_varName);
            UpperStr[0] = m_varName.ToUpper()[0];

            StringBuilder underBar_m_varName = new StringBuilder(m_varName + "_");
            StringBuilder underBar_m_varName_VM = new StringBuilder(m_varName + "ViewModel_");
            StringBuilder underBar_UpperStr = new StringBuilder(UpperStr + "_");
            StringBuilder underBar_UpperStr_VM = new StringBuilder(UpperStr + "ViewModel_");
            StringBuilder upperStrViewModel = new StringBuilder(UpperStr + "ViewModel");
            StringBuilder serial_m_varName = new StringBuilder("serial_" + m_varName);
            StringBuilder typeStr = new StringBuilder(m_varName + "type");
            StringBuilder serial_parent = new StringBuilder("serial_" + parent);
            StringBuilder serial_this = new StringBuilder("serial_" + thisClass);

            if (this.isVector)
            {
                sb.AppendLine("List<FpmlSerializedCSharp." + UpperStr + "> " + serial_m_varName + " = " + serial_this + "." + underBar_UpperStr + ";");
                sb.AppendLine("this."+underBar_m_varName_VM+" = new ObservableCollection<"+upperStrViewModel+">();");
                sb.AppendLine("foreach (var item in " + serial_m_varName + ")");
                sb.AppendLine("{");
                sb.AppendLine("    string type = item.Excel_type_.ValueStr;");
                sb.AppendLine("    " + upperStrViewModel + " viewModel = " + upperStrViewModel + ".Create" + UpperStr + "(type);");
                sb.AppendLine("    viewModel.setFromSerial(item);");
                sb.AppendLine("    this."+underBar_m_varName_VM+".Add(viewModel);");
                sb.AppendLine("}");
            }
            else
            {
                sb.AppendLine("FpmlSerializedCSharp." + UpperStr + " " + serial_m_varName + " = " + serial_this + "." + underBar_UpperStr + ";");

                sb.AppendLine("string " + typeStr + " = " + serial_m_varName + ".Excel_type_.ValueStr;");
                sb.AppendLine("this." + underBar_m_varName_VM + " = " + upperStrViewModel + ".Create" + UpperStr + "(" + typeStr + ");");

                sb.AppendLine("this." + underBar_m_varName_VM + ".setFromSerial(" + serial_m_varName + ");");
            }
            

            return sb.ToString();
        }

        public string selectFunction()
        {
            StringBuilder sb = new StringBuilder();
            //StringBuilder UpperStr = new StringBuilder(m_varName);
            //UpperStr[0] = m_varName.ToUpper()[0];

            //StringBuilder selectStr = new StringBuilder("select" + UpperStr + "Info");
            //StringBuilder underBar_m_varName = new StringBuilder(m_varName + "_");
            //StringBuilder upperStrViewModel = new StringBuilder(UpperStr + "ViewModel");
            //StringBuilder underBar_m_varName_VM = new StringBuilder(m_varName + "ViewModel_");

            //sb.AppendLine("public void " + selectStr + "(string typeStr)");
            //sb.AppendLine("{");
            //sb.AppendLine("    this." + underBar_m_varName_VM + " = " + upperStrViewModel + ".Create" + UpperStr + "(typeStr);");
            //sb.AppendLine("    this.view_.DataContext = this;");
            //sb.AppendLine("}");

            return sb.ToString();
        }

        public string selectField()
        {
            StringBuilder sb = new StringBuilder();
            
            //StringBuilder UpperStr = new StringBuilder(m_varName);
            //UpperStr[0] = m_varName.ToUpper()[0];

            //StringBuilder upperSelectStr = new StringBuilder("Select" + UpperStr + "Info_");
            //StringBuilder selectStr = new StringBuilder("select" + UpperStr + "Info_");
            

            //sb.AppendLine("#region " + upperSelectStr);
            //sb.AppendLine("private string " + selectStr + ";");
            //sb.AppendLine("public string " + upperSelectStr);
            //sb.AppendLine("{");
            //sb.AppendLine("    get { return this." + selectStr + "; }");
            //sb.AppendLine("    set");
            //sb.AppendLine("    {");
            //sb.AppendLine("        if (this." + selectStr + " != value)");
            //sb.AppendLine("        {");
            //sb.AppendLine("            this." + selectStr + " = value;");
            //sb.AppendLine("            this.NotifyPropertyChanged(" + "\"" + upperSelectStr + "\"" + ");");
            //sb.AppendLine("        }");
            //sb.AppendLine("    }");
            //sb.AppendLine("}");
            //sb.AppendLine("#endregion");

            return sb.ToString();
        }

        public string IDRefFieldCode()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("public string " + m_varName + "IDRef_ { get; set; }");

            if (substitute) { sb.Append("     // substitude"); }

            return sb.ToString();
        }


        public string SetFromSerialCode(string parent, string thisClass)
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder UpperStr = new StringBuilder(m_varName);
            UpperStr[0] = m_varName.ToUpper()[0];

            StringBuilder underBar_m_varName = new StringBuilder(m_varName + "_");
            StringBuilder underBar_m_varName_VM = new StringBuilder(m_varName + "ViewModel_");
            StringBuilder underBar_UpperStr = new StringBuilder(UpperStr + "_");
            StringBuilder underBar_UpperStr_VM = new StringBuilder(UpperStr + "ViewModel_");
            StringBuilder upperStrViewModel = new StringBuilder(UpperStr + "ViewModel");
            StringBuilder serial_m_varName = new StringBuilder("serial_" + m_varName);
            StringBuilder typeStr = new StringBuilder(m_varName + "type");
            StringBuilder serial_parent = new StringBuilder("serial_" + parent);
            StringBuilder serial_this = new StringBuilder("serial_" + thisClass);

            if (isVector)
            {
                sb.AppendLine("this." + underBar_m_varName_VM + " = new ObservableCollection<" + upperStrViewModel + ">();");
                sb.AppendLine("foreach (var item in "+serial_this+"."+underBar_UpperStr+")");
                sb.AppendLine("{");
                sb.AppendLine("    this.value_.Add(item.ValueStr);");
                sb.AppendLine("}");
            }
            else
            {
                if (m_varName.Length > 4)
                {
                    if (m_varName.Substring(m_varName.Length - 4, 4).ToUpper() == "DATE")
                    {
                        sb.AppendLine("this." + underBar_m_varName + " = StringConverter.xmlDateToDateTime(" + serial_this + "." + underBar_UpperStr + ".ValueStr);");
                    }
                    else
                    {
                        sb.AppendLine("this." + underBar_m_varName + " = " + serial_this + "." + underBar_UpperStr + ".ValueStr;");
                    }
                }
                else
                {
                    sb.AppendLine("this." + underBar_m_varName + " = " + serial_this + "." + underBar_UpperStr + ".ValueStr;");
                }

                
                
            }

            return sb.ToString();
        }

        public string buildXmlCodeVM(string BaseID_, string CName)
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder underBar_m_varName = new StringBuilder(m_varName + "_");

            if (isVector)
            {
                sb.AppendLine("foreach (var item in " + underBar_m_varName_VM + ")");
                sb.AppendLine("{");
                sb.AppendLine("    item.buildXml(xmlWriter);");
                sb.AppendLine("}");
            }
            else
            {
                sb.AppendLine(underBar_m_varName_VM + ".buildXml(xmlWriter);");
            }

            return sb.ToString();

        }

        public string buildXmlCode(string BaseID_, string CName)
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder underBar_m_varName = new StringBuilder(m_varName + "_");

            if (m_varName.Length > 4)
            {
                if (m_varName.Substring(m_varName.Length - 4, 4).ToUpper() == "DATE")
                {
                    sb.AppendLine("xmlWriter.WriteElementString(\"" + m_varName + "\" , StringConverter.xmlDateTimeToDateString(this." + underBar_m_varName + "));");
                }
                else
                {
                    sb.AppendLine("xmlWriter.WriteElementString(\"" + m_varName + "\" , this." + underBar_m_varName + ");");
                }
            }
            else
            {
                sb.AppendLine("xmlWriter.WriteElementString(\"" + m_varName + "\" , this." + underBar_m_varName + ");");
            }

            return sb.ToString();
        }
    }
}
