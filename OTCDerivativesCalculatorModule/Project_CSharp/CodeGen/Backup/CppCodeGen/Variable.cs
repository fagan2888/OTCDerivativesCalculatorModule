using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CppCodeGen
{
    public enum TypeSym
    { None, BoostPtr, Ptr, Ref }

    public class Variable
    {
        const string tap = "	   ";
        public static List<string> built_in_type;

        public Variable(string varType,
                         string varName,
                         string includePath,
                         bool isVector,
                         bool choice,
                         bool substitute = false) 
        {
            //여기다 박기로... 이거 함수로 빼서 수정.
            // std::vector<>

            m_varType = varType;
            Basic_varType = varType;

            m_varName = varName;

            m_includePath = includePath;

            this.isVector = isVector;
            this.choice = choice;
            this.substitute = substitute;

            PtrType = TypeSym.BoostPtr;

            if (built_in_type.Contains(varType))
            {
                StringBuilder upperChange = new StringBuilder(varType);
                upperChange[0] = varType.ToUpper()[0];
                Basic_varType = "XsdType" + upperChange;
                m_varType = "XsdType" + upperChange;
                isBuiltInType = true;
                PtrType = TypeSym.BoostPtr;
            }

            this.wrapType();

            if (isVector)
            {
                this.wrapVector();
            }


            this.makeHppCode();
            this.xmlParsingGen();
            this.IDRefCodeGen();
            this.getterHppCodeGen();
            this.getterCppCodeGen();
            this.isNullHppCodeGen();
            this.isNullMethodCodeGen();

        }

        private void getterHppCodeGen()
        {
            string IDRefName = m_varName + "IDRef_";

            StringBuilder upperChange = new StringBuilder(m_varName);
            upperChange[0] = m_varName.ToUpper()[0];

            GetterHppCode += m_varType + " get" + upperChange + "();";
            GetterHppCode += "\r\n";

            GetterHppCode += "      std::string get" + upperChange + "IDRef(){return " + IDRefName + ";}";
            GetterHppCode += "\r\n";

        }

        private void getterCppCodeGen()
        {
            string IDRefName = m_varName + "IDRef_";

            GetterCppCode += "   if(!this->" + m_varName + "IsNull_){\r\n";
            GetterCppCode += "        if(" + IDRefName + " != \"\"){\r\n";
            if (!isVector)
            {
                GetterCppCode += "             return boost::shared_static_cast<" + Basic_varType + ">(IDManager::instance().getID(" + IDRefName + "));\r\n";
            }
            else
            {
                GetterCppCode += "             return this->" + m_varName + "_;\r\n";
                //GetterCppCode += "             QL_FAIL(\"vector id ref is not implemented\");\r\n";
            }
            GetterCppCode += "        }else{\r\n";
            GetterCppCode += "             return this->" + m_varName + "_;\r\n";
            GetterCppCode += "        }\r\n";
            
            //if (!isVector)
            //{
            //    GetterCppCode += "      return boost::shared_static_cast<" + Basic_varType + ">(IDManager::instance().getID(" + IDRefName + "));\r\n";
            //}
            //else 
            //{
            //    GetterCppCode += "      QL_FAIL(\"vector id ref is not implemented\");\r\n";
            //    //GetterCppCode += "      std::vector<boost::shared_ptr<ISerialized>> " + m_varName + "Clone = IDManager::instance().getVID(" + IDRefName + ");\r\n";
            //    //GetterCppCode += "	    for(unsigned int i=0;i<" + m_varName+ "Clone.size();++i){\r\n";
            //    //GetterCppCode += "          " + m_varName + "_.push_back(boost::shared_static_cast<" + Basic_varType + ">(" + m_varName + "Clone[i]));\r\n";
            //    //GetterCppCode += "      }\r\n";
            //    //GetterCppCode += "      return this->" + m_varName + "_;\r\n";
            //    //GetterCppCode += "   \r\n";
            //}

            GetterCppCode += "   }else\r\n";
            GetterCppCode += "   {\r\n";
            GetterCppCode += "      QL_FAIL(\"null Ptr\");\r\n";
            GetterCppCode += "      return " + m_varType + "();\r\n";
            GetterCppCode += "   }\r\n";
           

        }

        private void isNullMethodCodeGen() 
        {
            StringBuilder upperChange = new StringBuilder(m_varName);
            upperChange[0] = m_varName.ToUpper()[0];
            isNullMethodCode += "bool is" + upperChange + "(){return this->" + m_varName + "IsNull_;}";

        }

        private void isNullHppCodeGen() 
        {

            isNullCode += "bool " + m_varName + "IsNull_;";
        }

        private void IDRefCodeGen()
        {
            idRefCode += "std::string " + m_varName + "IDRef_;";
        }

        //private bool isBuiltInType = false;
        
        public string m_varType {get; set;}
        public string m_varName { get; set; }
        public string m_includePath { get; set; }
        

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

        #region GetterHppCode
        private string getterHppCode;
        public string GetterHppCode
        {
            get { return this.getterHppCode; }
            set
            {
                if (this.getterHppCode != value)
                {
                    this.getterHppCode = value;
                    //this.RaisePropertyChanged("GetterCode");
                }
            }
        }
        #endregion

        #region GetterCppCode
        private string getterCppCode;
        public string GetterCppCode
        {
            get { return this.getterCppCode; }
            set
            {
                if (this.getterCppCode != value)
                {
                    this.getterCppCode = value;
                    //this.RaisePropertyChanged("GetterCode");
                }
            }
        }
        #endregion

        #region XmlParsingCppCode
        private string xmlParsingCppCode;
        public string XmlParsingCppCode
        {
            get { return this.xmlParsingCppCode; }
            set
            {
                if (this.xmlParsingCppCode != value)
                {
                    this.xmlParsingCppCode = value;
                    //this.RaisePropertyChanged("XmlParsingCppCode");
                }
            }
        }
        #endregion

        #region XmlParsingHppCode
        private string xmlParsingHppCode;
        public string XmlParsingHppCode
        {
            get { return this.xmlParsingHppCode; }
            set
            {
                if (this.xmlParsingHppCode != value)
                {
                    this.xmlParsingHppCode = value;
                   // this.RaisePropertyChanged("XmlParsingHppCode");
                }
            }
        }
        #endregion

        #region PtrType
        private TypeSym ptrType;
        public TypeSym PtrType
        {
            get { return this.ptrType; }
            set
            {
                if (this.ptrType != value)
                {
                    this.ptrType = value;
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

        #region EmptyFunction   
        private string emptyFunction;
        public string EmptyFunction
        {
            get { return this.emptyFunction; }
            set
            {
                if (this.emptyFunction != value)
                {
                    this.emptyFunction = value;
                    //this.RaisePropertyChanged("Choice");
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

        //public string getIsEmptyFunction() 
        //{
        //    StringBuilder upperChange = new StringBuilder(m_varName);
        //    upperChange[0] = m_varName.ToUpper()[0];
        //    EmptyFunction += "is" + upperChange + "()";
        //    EmptyFunction += "{\r\n";
        //    EmptyFunction += "  if(this->" + m_varName + "){";
        //    EmptyFunction += "return ";
        //    EmptyFunction += "  }\r\n";
        //    EmptyFunction += "}\r\n";


        //    return EmptyFunction;
        
        //}

        private void wrapVector() 
        {
            m_varType = "std::vector<" + m_varType + ">";
        
        }

        public void wrapType()
        {
        
            switch (ptrType)
            {
                case TypeSym.None:
                    break;
                case TypeSym.BoostPtr:
                    m_varType = "boost::shared_ptr<" + m_varType + ">";
                    break;
                case TypeSym.Ptr:
                    break;
                case TypeSym.Ref:
                    break;
                default:
                    break;
            }
            
        }

        public void makeHppCode() 
        {
            if (choice)
            {
                HppCode += "  ";
            }

            HppCode += m_varType + " " + m_varName + "_;";

            if (choice)
            {
                HppCode += "     //choice";
            }

            if (substitute) 
            {
                HppCode += "     //substitude " + SubstitudeStr; 
            }
        
        }

        private void xmlParsingGen() 
        {
            //if (!isBuiltInType)
            //{

            string nodeName = m_varName + "Node";
            string IDRefName = m_varName + "IDRef_";
            
            XmlParsingCppCode += "   //" + nodeName + " ----------------------------------------------------------------------------------------------------------------------\r\n";
            // 여기에 description 이 들어갈거임..
            if(!isVector){
                XmlParsingCppCode += "   TiXmlElement* " + nodeName + " = xmlNode->FirstChildElement(\"" + m_varName + "\");\r\n";
                XmlParsingCppCode += "\r\n";
                XmlParsingCppCode += "   if(" + nodeName + "){" + m_varName + "IsNull_ " + "= false;}\r\n";
                XmlParsingCppCode += "   else{" + m_varName + "IsNull_ " + "= true;}\r\n";
                XmlParsingCppCode += "\r\n";
                XmlParsingCppCode += "   #ifdef ConsolePrint\r\n";
                XmlParsingCppCode += "      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << \"- " + nodeName + " , address : \" << " + nodeName + " << std::endl;\r\n";
                XmlParsingCppCode += "   #endif\r\n";
                XmlParsingCppCode += "   if(" + nodeName + ")\r\n";
                XmlParsingCppCode += "   {\r\n";
                XmlParsingCppCode += "      if(" + nodeName + "->Attribute(\"href\") || " + nodeName + "->Attribute(\"id\"))\r\n";
                XmlParsingCppCode += "      {\r\n";
                XmlParsingCppCode += "          if("+ nodeName + "->Attribute(\"id\"))\r\n";
                XmlParsingCppCode += "          {\r\n";
                XmlParsingCppCode += "             " + IDRefName + " = " + nodeName + "->Attribute(\"id\");\r\n";
                XmlParsingCppCode += "             " + m_varName + "_ = boost::shared_ptr<" + Basic_varType + ">(new " + Basic_varType + "(" + nodeName + "));\r\n";
                XmlParsingCppCode += "             " + m_varName + "_->setID(" + IDRefName + ");\r\n";
                XmlParsingCppCode += "             IDManager::instance().setID(" + IDRefName + "," + m_varName + "_);\r\n";
                XmlParsingCppCode += "          }\r\n";
                XmlParsingCppCode += "          else if(" + nodeName + "->Attribute(\"href\")) { " + IDRefName + " = " + nodeName + "->Attribute(\"href\");}\r\n";
                XmlParsingCppCode += "          else { QL_FAIL(\"id or href error\"); }\r\n";
                XmlParsingCppCode += "      }\r\n";
                XmlParsingCppCode += "      else { " + m_varName + "_ = boost::shared_ptr<" + Basic_varType + ">(new " + Basic_varType + "(" + nodeName + "));}\r\n";
                XmlParsingCppCode += "   }\r\n";
            }else{

                XmlParsingCppCode += "   TiXmlElement* " + nodeName + " = xmlNode->FirstChildElement(\"" + m_varName + "\");\r\n";
                XmlParsingCppCode += "\r\n";
                XmlParsingCppCode += "   if(" + nodeName + "){" + m_varName + "IsNull_ " + "= false;}\r\n";
                XmlParsingCppCode += "   else{" + m_varName + "IsNull_ " + "= true;}\r\n";
                XmlParsingCppCode += "\r\n";
                XmlParsingCppCode += "   if(" + nodeName + ")\r\n";
                XmlParsingCppCode += "   {\r\n";
                XmlParsingCppCode += "      for(" + nodeName + "; " + nodeName + "; " + nodeName + " = " + nodeName + "->NextSiblingElement(\"" + m_varName + "\")){\r\n";
                XmlParsingCppCode += "          #ifdef ConsolePrint\r\n";
                XmlParsingCppCode += "              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << \"- " + nodeName + " , address : \" << " + nodeName + " << std::endl;\r\n";
                XmlParsingCppCode += "          #endif\r\n";
                XmlParsingCppCode += "          if(" + nodeName + "->Attribute(\"href\") || " + nodeName + "->Attribute(\"id\"))\r\n";
                XmlParsingCppCode += "          {\r\n";
                XmlParsingCppCode += "              if("+ nodeName + "->Attribute(\"id\"))\r\n";
                XmlParsingCppCode += "              {\r\n";
                XmlParsingCppCode += "                  " + IDRefName + " = " + nodeName + "->Attribute(\"id\");\r\n";
                XmlParsingCppCode += "                  " + m_varName + "_.push_back(boost::shared_ptr<" + Basic_varType + ">(new " + Basic_varType + "(" + nodeName + ")));\r\n";
                XmlParsingCppCode += "                  " + m_varName + "_.back()->setID(" + IDRefName + ");\r\n";
                XmlParsingCppCode += "                  IDManager::instance().setID(" + IDRefName + ", " + m_varName + "_.back());\r\n";
                XmlParsingCppCode += "              }\r\n";
                XmlParsingCppCode += "              else if(" + nodeName + "->Attribute(\"href\")) { " + IDRefName + " = " + nodeName + "->Attribute(\"href\");}\r\n";
                XmlParsingCppCode += "              else { QL_FAIL(\"id or href error\"); }\r\n";
                XmlParsingCppCode += "          }\r\n";
                XmlParsingCppCode += "          else { " + m_varName + "_.push_back(boost::shared_ptr<" + Basic_varType + ">(new " + Basic_varType + "(" + nodeName + ")));}\r\n";
                XmlParsingCppCode += "      }\r\n";
                XmlParsingCppCode += "   }\r\n";
                //vector 일경우 null일때도 찍어야하므로 여기다가 넣음.
                XmlParsingCppCode += "   else {\r\n";
                XmlParsingCppCode += "       #ifdef ConsolePrint\r\n";
                XmlParsingCppCode += "           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << \"- " + nodeName + " , address : \" << " + nodeName + " << std::endl;\r\n";
                XmlParsingCppCode += "       #endif\r\n";
                XmlParsingCppCode += "   }\r\n";

            }
            

        }

        public string Basic_varType { get; set; }

        public string isNullMethodCode { get; set; }

        public string isNullCode { get; set; }

        public bool isBuiltInType { get; set; }

        public bool substitute { get; set; }
    }
}
