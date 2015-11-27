using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpCodeGen
{
    public class ClassGen
    {
        public static List<string> built_in_type;

        public ClassGen()
        {
            this.namespaceCode = "FpmlSerializedCSharp";
            //this.namespaceCode = "RiskMonitor";
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

        private void MakeCsCode()
        {
            StringBuilder sb = new StringBuilder();

            this.builtInTypeConv();

            sb.AppendLine(this.UsingGen());

            StringBuilder classSB = new StringBuilder();

            if (BaseName != null)
            {
                classSB.AppendLine("public class " + cName + " : " + BaseName);
            }
            else 
            {
                classSB.AppendLine("public class " + cName + " : ISerialized");
            }

            classSB.AppendLine("{");

            classSB.AppendLine(Wrapper.TapCode(this.ConstructorGen()));

            classSB.AppendLine(Wrapper.TapCode(this.MemberFieldGen()));

            classSB.AppendLine(Wrapper.TapCode(this.MemberFunctionGen()));

            classSB.AppendLine("}");

            sb.Append(Wrapper.WrapNameSpace(classSB, namespaceCode));

            CsCode = sb.ToString();

        }

        private string UsingGen()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("using System;");
            sb.AppendLine("using System.Text;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine("using System.Xml;");
            //sb.AppendLine("using CSharpCodeGen;");

            return sb.ToString();
        }

        private string MemberFunctionGen()
        {
            StringBuilder sb = new StringBuilder();

            return sb.ToString();

            //List<string> memberList = new List<string>();

        }

        private string MemberFieldGen()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Variable item in memberVariable)
            {
                sb.AppendLine(item.PropertyCode());
                sb.AppendLine(item.IDRefFieldCode());
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

        // namespace랑 등등 싸는 작업
        public void BuildCode()
        {
            this.MakeCsCode();
            
        }

        private string ConstructorGen()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("public " + cName + "() { }");
            sb.AppendLine("public " + cName + "(XmlNode xmlNode)");

            //if (BaseName != null)
            //{
            sb.AppendLine(": base(xmlNode)");
            //}

            sb.AppendLine("{");

            foreach (Variable item in memberVariable)
            {
                sb.AppendLine(Wrapper.TapCode(item.ConstructorInitialCode()));
            }

            sb.AppendLine("}");

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
