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
        public Variable(string varType,
                         string varName,
                         bool choice) 
        {
            m_varType = varType;
            m_varName = varName;
            this.choice = choice;
            
            PtrType = TypeSym.BoostPtr;

            if (built_in_type.Contains(varType))
            {
                isBuiltInType = true;
                PtrType = TypeSym.None;
            }
            this.xmlParsingGen();

        }

        private static List<string> built_in_type 
            = new List<string>() { "boolean", 
                                   "decimal",
                                   "string",
                                   "negativeInteger",
                                   "long",
                                   "int"
                                 }; //static 외부
        private bool isBuiltInType = false;
        
        private string m_varType;
        private string m_varName;

        #region Code
        private string code;
        public string Code
        {
            get { return this.code; }
            set
            {
                if (this.code != value)
                {
                    this.code = value;
                }
            }
        }
        #endregion

        #region XmlParsingCode
        private string xmlParsingCode;
        public string XmlParsingCode
        {
            get { return this.xmlParsingCode; }
            set
            {
                if (this.xmlParsingCode != value)
                {
                    this.xmlParsingCode = value;
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


        public string getParametor()
        {
            if (choice)
            {
                Code += "  ";
            }

            switch (ptrType)
            {
                case TypeSym.None:
                    Code += m_varType + " " + m_varName + ";";
                    
                    break;
                case TypeSym.BoostPtr:
                    Code += "boost::shared_ptr<" + m_varType + "> " + m_varName + ";";
                    
                    break;
                case TypeSym.Ptr:
                    Code += m_varType + "* " + m_varName + ";";
                    break;
                case TypeSym.Ref:
                    Code += m_varType + "& " + m_varName + ";";
                    break;
                default:
                    Code += m_varType + " " + m_varName + ";";
                    break;
                
            }
            if (choice)
            {
                Code += "     //choice";
            }
            return Code;

        }

        private void xmlParsingGen() 
        {
            if (!isBuiltInType)
            {

                string nodeName = m_varName + "Node";
                XmlParsingCode += "              " + "TiXmlElement* " + nodeName + " = xmlNode->FirstChildElement(\"" + m_varName + "\");\r\n";
                XmlParsingCode += "              " + m_varName + " = boost::shared_ptr<" + m_varType + ">(\r\n";
                XmlParsingCode += "                           " + "new " + m_varType + "(" + nodeName + "));\r\n";
            }
            else 
            {

                string nodeName = m_varName + "Node";
                XmlParsingCode += "              " + "TiXmlElement* " + nodeName + " = xmlNode->FirstChildElement(\"" + m_varName + "\");\r\n";
                XmlParsingCode += "              " + m_varName + " = static_cast<" + m_varType + ">(" + nodeName + "->ValueStr());\r\n"; 
                
            }
        }

    }
}
