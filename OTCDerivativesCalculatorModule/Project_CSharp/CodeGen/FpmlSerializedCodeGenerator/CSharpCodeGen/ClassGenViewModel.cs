using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpCodeGen
{
    public class ClassGenViewModel
    {
        public static List<string> built_in_type;

        public ClassGenViewModel()
        {
            //this.namespaceCode = "FpmlSerializedCSharp";
            this.namespaceCode = "Excel_Interface";
            choiceStr = new List<string>();
        }

        private List<string> memberVariableString;

        #region MemberVariable
        private List<Variable> memberVariable;
        public List<Variable> MemberVariable
        {
            get { return this.memberVariable; }
            set
            {
                if (this.memberVariable != value)
                {
                    memberVariable = new List<Variable>();
                    memberVariableString = new List<string>();
                    foreach (Variable item in value)
                    {
                        if (!memberVariableString.Contains(item.m_varName))
                        {
                            memberVariable.Add(item);
                        }
                        memberVariableString.Add(item.m_varName);
                    }

                    //this.RaisePropertyChanged("MemberVariable");
                }
            }
        }
        #endregion

        #region ChoiceStr
        private List<string> choiceStr;
        public List<string> ChoiceStr
        {
            get { return this.choiceStr; }
            set
            {
                if (this.choiceStr != value)
                {
                    this.choiceStr = value;
                    //this.RaisePropertyChanged("ChoiceStr");
                }
            }
        }
        #endregion

        #region CName
        private string cName;
        public string CName
        {
            get { return this.cName; }
            set
            {
                if (this.cName != value)
                {
                    this.cName = value;
                    //this.RaisePropertyChanged("CName");
                }
            }
        }
        #endregion

        #region BaseName
        private string baseName;
        public string BaseName
        {
            get { return this.baseName; }
            set
            {
                if (this.baseName != value)
                {
                    this.baseName = value;
                    //this.RaisePropertyChanged("BaseName");
                }
            }
        }
        #endregion

        #region BasePathName
        private string basePathName;
        public string BasePathName
        {
            get { return this.basePathName; }
            set
            {
                if (this.basePathName != value)
                {
                    this.basePathName = value;
                    //this.RaisePropertyChanged("BaseName");
                }
            }
        }
        #endregion

        #region CsCode
        private string csCode;
        public string CsCode
        {
            get { return this.csCode; }
            set
            {
                if (this.csCode != value)
                {
                    this.csCode = value;
                }
            }
        }
        #endregion

        #region Path
        private string path;
        public string Path
        {
            get { return this.path; }
            set
            {
                if (this.path != value)
                {
                    this.path = value;
                    //this.RaisePropertyChanged("Path");
                }
            }
        }
        #endregion

        // Category subDirectory 가 만들어져서 거기에 들어감

        #region Category
        private string category;
        public string Category
        {
            get { return this.category; }
            set
            {
                if (this.category != value)
                {
                    this.category = value;
                    //this.RaisePropertyChanged("Category");
                }
            }
        }
        #endregion

        public string BaseID_ { get; set; }

        private void MakeCsCode()
        {
            StringBuilder sb = new StringBuilder();

            //this.BaseID_ = "testBaseID";

            //this.builtInTypeConv();

            sb.AppendLine(this.UsingGen());

            StringBuilder classSB = new StringBuilder();

            string convBaseID = BaseID_;

            if (BaseID_ != "IXmlData")
            {
                convBaseID = BaseID_ + "ViewModel";
            }


            if (ChoiceStr.Count > 0)
            {
                classSB.AppendLine("public abstract class " + cName + "ViewModel" + " : " + convBaseID );
            }
            else
            {
                classSB.AppendLine("public class " + cName + "ViewModel" + " : " + convBaseID);
            }

            classSB.AppendLine("{");

            //classSB.AppendLine(Wrapper.TapCode(this.overrideMemberGen()));

            //classSB.AppendLine(Wrapper.TapCode(this.ViewGen()));
            classSB.Append(Wrapper.TapCode(this.EventGen()));
            classSB.Append(Wrapper.TapCode(this.ConstructorGen()));
            classSB.AppendLine(Wrapper.TapCode(this.MemberFieldGen()));
            classSB.AppendLine(Wrapper.TapCode(this.MemberFunctionGen()));

            if (ChoiceStr.Count == 0)
            {
                classSB.AppendLine(Wrapper.TapCode(this.SelectFieldAndFunctionGen()));
            }

            classSB.AppendLine(Wrapper.TapCode(this.MemberCreateFunGen()));

            classSB.AppendLine("}");

            sb.Append(Wrapper.WrapNameSpace(classSB, namespaceCode));

            CsCode = sb.ToString();

        }

        private string MemberCreateFunGen()
        {
            StringBuilder sb = new StringBuilder();

            List<Variable> exceptBuiltIn = new List<Variable>();

            foreach (Variable item in memberVariable)
            {
                if (!item.isBuiltInType)
                {
                    exceptBuiltIn.Add(item);
                }
            }

            if (ChoiceStr.Count > 0)
            {
                StringBuilder baseIDUpperStr = new StringBuilder(this.BaseID_);
                baseIDUpperStr[0] = this.BaseID_.ToUpper()[0];

                StringBuilder serial_baseID = new StringBuilder("serial_" + this.BaseID_);

                StringBuilder cNameUpperStr = new StringBuilder(this.cName);
                cNameUpperStr[0] = this.cName.ToUpper()[0];

                StringBuilder serial_cName = new StringBuilder("serial_" + this.cName);
                StringBuilder underBar_cName = new StringBuilder(this.cName + "_");
                StringBuilder view_cName = new StringBuilder(this.cName + "View");
                StringBuilder upper_cNameVM = new StringBuilder(cNameUpperStr + "ViewModel");
                StringBuilder type_cNameStr = new StringBuilder(this.cName + "Type");

                sb.AppendLine("public static " + upper_cNameVM + " Create" + cNameUpperStr + "(string typeStr)");
                sb.AppendLine("{");
                sb.AppendLine("    if ( typeStr == \"" + exceptBuiltIn[0].m_varName + "\")");
                sb.AppendLine("    {");
                sb.AppendLine("        return new " + exceptBuiltIn[0].upperStr + "ViewModel();");
                sb.AppendLine("    }");

                for (int i = 1; i < exceptBuiltIn.Count; i++)
                {
                    sb.AppendLine("    else if ( typeStr == \"" + exceptBuiltIn[i].m_varName + "\")");
                    sb.AppendLine("    {");
                    sb.AppendLine("        return new " + exceptBuiltIn[i].upperStr + "ViewModel();");
                    sb.AppendLine("    }");
                }

                sb.AppendLine("    else");
                sb.AppendLine("    {");
                sb.AppendLine("    throw new NotImplementedException();");
                sb.AppendLine("    }");
                sb.AppendLine("}");

                sb.AppendLine();

                //sb.AppendLine("public static " + upper_cNameVM + " Create" + cNameUpperStr + "(FpmlSerializedCSharp.ISerialized serial_Class)");
                //sb.AppendLine("{");
                //sb.AppendLine("    FpmlSerializedCSharp." + this.cName + " " + serial_cName + " = serial_Class as FpmlSerializedCSharp." + this.cName + ";");
                //sb.AppendLine("    string typeStr = " + serial_cName + ".Excel_type_.ValueStr;");
                //sb.AppendLine("    return " + upper_cNameVM + ".Create" + cNameUpperStr + "(typeStr);");
                //sb.AppendLine("}");
            }
            return sb.ToString();
        }

        private string UsingGen()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("using System;");
            sb.AppendLine("using System.Text;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine("using System.Xml;");
            sb.AppendLine("using System.Windows.Controls;");
            sb.AppendLine("using System.ComponentModel;");
            sb.AppendLine("using System.Collections.ObjectModel;");
            //sb.AppendLine("using RiskMonitor;");

            //sb.AppendLine("using CSharpCodeGen;");

            return sb.ToString();
        }

        private string ViewGen()
        {
            StringBuilder sb = new StringBuilder();

            if (BaseID_ != "IXmlData")
            {
                sb.AppendLine("#region View_");
                sb.AppendLine("protected Control view_;");
                sb.AppendLine("public Control View_");
                sb.AppendLine("{");
                sb.AppendLine("    get { return this.view_; }");
                sb.AppendLine("    set");
                sb.AppendLine("    {");
                sb.AppendLine("        if (this.view_ != value)");
                sb.AppendLine("        {");
                sb.AppendLine("            this.view_ = value;");
                sb.AppendLine("            this.NotifyPropertyChanged(" + "\"View_\"" + ");");
                sb.AppendLine("        }");
                sb.AppendLine("    }");
                sb.AppendLine("}");
                sb.AppendLine("#endregion");
            }
            else
            {
                
            }



            return sb.ToString();
        }

        private string EventGen()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("#region Event");
            sb.AppendLine("public event PropertyChangedEventHandler PropertyChanged;");
            sb.AppendLine();
            sb.AppendLine("protected void NotifyPropertyChanged(string propertyName)");
            sb.AppendLine("{");
            sb.AppendLine("    if (PropertyChanged != null)");
            sb.AppendLine("    {");
            sb.AppendLine("        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));");
            sb.AppendLine("    }");
            sb.AppendLine("}");
            sb.AppendLine("#endregion");

            return sb.ToString();
        }

        private string MemberFunctionGen()
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder baseIDUpperStr = new StringBuilder(this.BaseID_);
            baseIDUpperStr[0] = this.BaseID_.ToUpper()[0];

            StringBuilder baseIDLowerStr = new StringBuilder(this.BaseID_);
            baseIDLowerStr[0] = this.BaseID_.ToLower()[0];

            StringBuilder serial_baseID = new StringBuilder("serial_" + this.BaseID_);

            StringBuilder cNameUpperStr = new StringBuilder(this.cName);
            cNameUpperStr[0] = this.cName.ToUpper()[0];

            StringBuilder cNameLowerStr = new StringBuilder(this.cName);
            cNameLowerStr[0] = this.cName.ToLower()[0];

            StringBuilder serial_cName = new StringBuilder("serial_" + this.cName);
            StringBuilder underBar_cName = new StringBuilder(this.cName+"_");
            StringBuilder view_cName = new StringBuilder(this.cName + "View");

            if (ChoiceStr.Count > 0 &&  BaseID_ == "IXmlData")
            {
                sb.AppendLine("public abstract void buildXml(System.Xml.XmlWriter xmlWriter);");
                sb.AppendLine("public abstract void setFromXml(System.Xml.XmlNode node);");
                sb.AppendLine("public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);");
            }
            //else if (BaseID_ == "IXmlData")
            //{
            //    sb.AppendLine("public abstract void buildXml(System.Xml.XmlWriter xmlWriter);");
            //    sb.AppendLine("public abstract void setFromXml(System.Xml.XmlNode node);");
            //    sb.AppendLine("public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);");
            //}
            else if (ChoiceStr.Count > 0 && BaseID_ != "IXmlData")
            { 
            
            }
            else
            {

                sb.AppendLine("public override void buildXml(System.Xml.XmlWriter xmlWriter)");
                sb.AppendLine("{");

                sb.AppendLine("    xmlWriter.WriteStartElement(\"" + baseIDLowerStr + "\");");
                sb.AppendLine("        xmlWriter.WriteElementString(\"excel_type\" , \"" + cNameLowerStr + "\");");
                sb.AppendLine("        xmlWriter.WriteStartElement(\"" + cNameLowerStr + "\");");

                Wrapper.makeTapStr(12);

                foreach (Variable item in memberVariable)
                {
                    if (!item.isBuiltInType)
                    {
                        sb.Append(Wrapper.TapCode(item.buildXmlCodeVM(BaseID_, CName)));
                    }
                    else
                    {
                        sb.Append(Wrapper.TapCode(item.buildXmlCode(BaseID_, CName)));
                    }
                }

                Wrapper.makeTapStr(4);

                sb.AppendLine("        xmlWriter.WriteEndElement();");
                sb.AppendLine("    xmlWriter.WriteEndElement();");

                sb.AppendLine("}");

                sb.AppendLine();

                sb.AppendLine("public override void setFromXml(System.Xml.XmlNode node)");
                sb.AppendLine("{");
                sb.AppendLine("    throw new NotImplementedException();");
                sb.AppendLine("}");
                sb.AppendLine();

                sb.AppendLine("public override Control view()");
                sb.AppendLine("{");
                sb.AppendLine("    Control v = new " + view_cName + "();");
                sb.AppendLine("    v.DataContext = this;");
                sb.AppendLine("    return v;");
                sb.AppendLine("}");
                sb.AppendLine();

                sb.AppendLine("public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)");
                sb.AppendLine("{");

                if (BaseID_ != "IXmlData")
                {
                    sb.AppendLine("    FpmlSerializedCSharp." + baseIDUpperStr + " " + serial_baseID + " = serial_Class as FpmlSerializedCSharp." + baseIDUpperStr + ";");
                    sb.AppendLine("    FpmlSerializedCSharp." + cNameUpperStr + " " + serial_cName + " = " + serial_baseID + "." + underBar_cName + ";");
                }
                else 
                {
                    sb.AppendLine("    FpmlSerializedCSharp." + cNameUpperStr + " " + serial_cName + " = serial_Class as FpmlSerializedCSharp." + cNameUpperStr + ";");
                }

                sb.AppendLine();

                foreach (Variable item in memberVariable)
                {
                    if (!item.isBuiltInType)
                    {
                        sb.Append(Wrapper.TapCode(item.SetFromSerialCodeVM(BaseID_, CName)));
                    }
                    else
                    {
                        sb.Append(Wrapper.TapCode(item.SetFromSerialCode(BaseID_, CName)));
                    }
                }

                //sb.AppendLine("    this.view_ = new " + view_cName + "();");
                //sb.AppendLine("    this.view_.DataContext = this;");

                sb.AppendLine("}");
                sb.AppendLine();
            }

            // 그냥 짜집 코드 사후 수정 ㅡ.ㅡ;; 인터페이스 에서 내리는거는 override가 없어야함
            if ( BaseID_ == "IXmlData" )
            {
                sb.Replace("override", "");
            }

            return sb.ToString();

        }

        private string MemberFieldGen()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Variable item in memberVariable)
            {
                if (!item.isBuiltInType)
                {
                    sb.AppendLine(item.PropertyViewModelCode());
                }
                else 
                {
                    sb.AppendLine(item.PropertyCodePropType());
                }
                
            }

            if (ChoiceStr.Count > 0)
            {
                foreach (string item in ChoiceStr)
                {
                    sb.AppendLine("public string " + item + ";");
                }
            }

            return sb.ToString();
        }

        private string SelectFieldAndFunctionGen()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Variable item in memberVariable)
            {
                if (!item.isBuiltInType)
                {
                    sb.Append(Wrapper.TapCode(item.selectField()));
                    sb.Append(Wrapper.TapCode(item.selectFunction()));
                }
            }

            return sb.ToString();
        }

        // namespace랑 등등 싸는 작업
        public void BuildCode()
        {
            this.MakeCsCode();
        }

        private string ConstructorGen()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("public " + cName + "ViewModel() { }");
            
            //sb.AppendLine("public " + cName + "(XmlNode xmlNode)");
            
            //if (BaseName != null)
            //{
            //sb.AppendLine(": base(xmlNode)");
            //}

            //sb.AppendLine("{");

            //foreach (Variable item in memberVariable)
            //{
            //    sb.AppendLine(Wrapper.TapCode(item.ConstructorInitialCode()));
            //}

            //sb.AppendLine("}");

            return sb.ToString();

        }

        private void builtInTypeConv()
        {
            if (built_in_type.Contains(baseName))
            {
                StringBuilder upperChange = new StringBuilder(baseName);
                upperChange[0] = baseName.ToUpper()[0];
                baseName = "XsdType" + upperChange;
            }
        }

        #region NamespaceCode
        private string namespaceCode;
        public string NamespaceCode
        {
            get { return this.namespaceCode; }
            set
            {
                if (this.namespaceCode != value)
                {
                    this.namespaceCode = value;
                    //this.RaisePropertyChanged("NamespaceCode");
                }
            }
        }
        #endregion

        public string ConstructorContent { get; set; }
        public string IsPublic { get; set; }
    }
}
