using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CppCodeGen
{
    public class ClassGen
    {
        public static List<string> built_in_type;

        public ClassGen()
        {
            this.namespaceCode = "FpmlSerialized";
            choiceStr = new List<string>();
            choiceStrMember = new Dictionary<string, List<string>>();

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

        #region ChoiceStrMember
        private Dictionary<string,List<string>> choiceStrMember;
        public Dictionary<string, List<string>> ChoiceStrMember
        {
            get { return this.choiceStrMember; }
            set
            {
                if (this.choiceStrMember != value)
                {
                    this.choiceStrMember = value;
                    //this.RaisePropertyChanged("ChoiceStrMember");
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

        #region HppCode
        private string hppCode;
        public string HppCode
        {
            get { return this.hppCode; }
            set
            {
                if (this.hppCode != value)
                {
                    this.hppCode = value;
                }
            }
        }
        #endregion

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

        #region ConstructorHppCode
        private string constructorHppCode;
        public string ConstructorHppCode
        {
            get { return this.constructorHppCode; }
            set
            {
                if (this.constructorHppCode != value)
                {
                    this.constructorHppCode = value;
                }
            }
        }
        #endregion

        #region ConstructorCppCode
        private string constructorCppCode;
        public string ConstructorCppCode
        {
            get { return this.constructorCppCode; }
            set
            {
                if (this.constructorCppCode != value)
                {
                    this.constructorCppCode = value;
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

        public void makeHppCode()
        {
            //this.includeGen();
            HppCode += "// " + cName + ".hpp \r\n";
            this.builtInTypeConv();

            this.includeHppGen();

            // 부모클래스 정의
            string baseClass = "";

            if (this.baseName != null){baseClass += " : public " + baseName;}
            else{baseClass += " : public ISerialized";}

            HppCode += "class " + cName + baseClass + " { \r\n";
            HppCode += "   public: \r\n";

            this.ConstructorHppGen();

            HppCode += constructorHppCode;
            HppCode += "\r\n";

            List<string> memberList = new List<string>();

            foreach (Variable item in MemberVariable)
            {
                HppCode += "       ";
                HppCode += item.isNullMethodCode;
                HppCode += "\r\n";
                HppCode += "       ";
                HppCode += item.GetterHppCode;
                HppCode += "\r\n";
            }

            foreach (string item in ChoiceStr)
            {
                StringBuilder upperChange = new StringBuilder(item);
                upperChange[0] = item.ToUpper()[0];
                HppCode += "       std::string get" + upperChange + "(){\r\n";
                HppCode += "           std::string str;\r\n";
                HppCode += "           int count = 0;\r\n";

                List<string> choiceStrMemberName = choiceStrMember[item];
                foreach (string memberItem in choiceStrMemberName)
                {

                    HppCode += "           if(!" + memberItem + "IsNull_){\r\n";
                    HppCode += "                count += 1;\r\n";
                    HppCode += "                str = \"" + memberItem + "\" ;\r\n";
                    HppCode += "           }\r\n";
                }

                HppCode += "           QL_REQUIRE(count == 1 , \"too many choice\" << count);\r\n";
                HppCode += "           " + item + "_ = str ;\r\n";
                HppCode += "           return " + item + "_;\r\n";
                HppCode += "       }\r\n";

            }


            //foreach (Constructor item in m_Constructor)
            //{
            //    Code += item.getDeclareCode();    
            //}

            HppCode += "   protected: \r\n";

            foreach (Variable item in MemberVariable)
            {
                HppCode += "       ";
                HppCode += item.HppCode;
                HppCode += "\r\n";
                HppCode += "       ";
                HppCode += item.IDRefCode;
                HppCode += "\r\n";
                HppCode += "       ";
                HppCode += item.isNullCode;
                HppCode += "\r\n";

            }

            if (ChoiceStr.Count > 0)
            {
                HppCode += "\r\n";
                HppCode += "       //choiceStr \r\n";
            }
            foreach (string item in ChoiceStr)
            {
                HppCode += "       std::string " + item + "_;\r\n";
                
            }

            HppCode += "\r\n";

            //foreach (MemberFunction item in m_MemberFunction)
            //{
            //    Code += item.getDeclareCode();
            //}

            HppCode += "};\r\n";
            HppCode += "\r\n";
            HppCode += "} //namespace" + namespaceCode + " end\r\n";
            HppCode += "#endif\r\n";

        }

        public void makeCppCode()
        {
            //this.includeGen();
            CppCode += "// " + cName + ".cpp \r\n";

            this.ConstructorCppGen();
            this.includeCppGen();

            CppCode += constructorCppCode + "{\r\n";
            CppCode += "    #ifdef ConsolePrint\r\n";
            CppCode += "        std::string initialtap_ = FileManager::instance().tap_;\r\n";
            CppCode += "        FileManager::instance().tap_.append(\"   \");\r\n";
            CppCode += "    #endif \r\n";

            foreach (Variable item in memberVariable)
            {
                CppCode += item.XmlParsingCppCode;
                CppCode += "\r\n";
            }

            CppCode += "    #ifdef ConsolePrint\r\n";
            CppCode += "        FileManager::instance().tap_ = initialtap_;\r\n";
            CppCode += "    #endif \r\n";

            CppCode += "}\r\n"; //class contructor end

            foreach (Variable item in memberVariable)
            {
                StringBuilder upperChange = new StringBuilder(item.m_varName);
                upperChange[0] = item.m_varName.ToUpper()[0];

                CppCode += item.m_varType + " " + CName + "::get" + upperChange + "()\r\n";
                CppCode += "{\r\n";
                CppCode += item.GetterCppCode;
                CppCode += "}";
                CppCode += "\r\n";

            }

 

            CppCode += "}\r\n"; //class cpp end
            
        }

        private void includeHppGen() 
        {

            HppCode += "#ifndef " + namespaceCode +"_" + cName + "_hpp\r\n";
            HppCode += "#define " + namespaceCode +"_" + cName + "_hpp\r\n";
            HppCode += "\r\n";
            if (baseName != null)
            {
                HppCode += "#include <" + basePathName + "/" + baseName + ".hpp>\r\n";
            }
            else {
                HppCode += "#include <ISerialized.hpp>\r\n";
            }
            List<string> recordType = new List<string>();

            foreach (Variable item in MemberVariable)
            {

                if (!recordType.Contains(item.Basic_varType))
                {
                    
                        HppCode += "#include <" + item.m_includePath + "/" + item.Basic_varType + ".hpp>\r\n";

                }

                recordType.Add(item.Basic_varType);
            }
            
            
            HppCode += "\r\n";

            HppCode += "namespace " + namespaceCode + " {\r\n";
            HppCode += "\r\n";
            //foreach (var item in collection)
            //{
            //    Code += "#inlucde <" + path;    
            //}
        }
        
        private void includeCppGen()
        {

            CppCode += "#include \"" + cName + ".hpp\"\r\n";

            CppCode += "#ifdef ConsolePrint\r\n";
            CppCode += "    #include <iostream>\r\n";
            CppCode += "#endif \r\n";


            CppCode += "\r\n";
            CppCode += "namespace " + namespaceCode + " {";
            CppCode += "\r\n";
            CppCode += "\r\n";

            //foreach (var item in collection)
            //{
            //    Code += "#inlucde <" + path;    
            //}
        }

        private void ConstructorHppGen()
        {
            constructorHppCode += "       " + cName + "(TiXmlNode* xmlNode);\r\n";
        }
        private void ConstructorCppGen() 
        {
            constructorCppCode += cName + "::" + cName + "(TiXmlNode* xmlNode)\r\n";
            if (baseName == null)
            {
                constructorCppCode += ": ISerialized(xmlNode)\r\n";
            }
            else 
            {
                constructorCppCode += ": " + baseName + "(xmlNode)\r\n";
            }
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

    }
}
