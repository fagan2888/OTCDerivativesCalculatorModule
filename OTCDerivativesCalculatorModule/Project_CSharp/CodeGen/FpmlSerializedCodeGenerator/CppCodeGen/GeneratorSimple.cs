using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Schema;

namespace CppCodeGen
{
    
    public class GeneratorSimple
    {
        public const string includes = "#include <string>\r\n";

        public GeneratorSimple(XmlSchemaSimpleType xsSimType) 
        {
            this.setXsd(xsSimType.Name);
        }

        public GeneratorSimple(string xsSimName)
        {
            this.setXsd(xsSimName);
        }

        private ClassGen m_ClassGen = new ClassGen();

        private List<Variable> m_MemberVariable = new List<Variable>();
        private List<MemberFunction> m_MemberFunction = new List<MemberFunction>();
        
        public string CName { get; set; }

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
                    //this.RaisePropertyChanged("Code");
                }
            }
        }
        #endregion


        private void setXsd(string xsSimName)
        {
            CName = xsSimName;
            code += "#ifndef FpmlSerialized_" + CName + "_hpp\r\n";
            code += "#define FpmlSerialized_" + CName + "_hpp\r\n";
            code += "\r\n";
            code += "#include <string>\r\n";
            code += "#include <iserialized.hpp>\r\n";
            code += "#include <ql/time/date.hpp>\r\n";
            code += "#include <boost/algorithm/string/case_conv.hpp>\r\n";
            code += "\r\n";
            code += "using namespace QuantLib;\r\n";
            code += "namespace FpmlSerialized {\r\n";
            code += "\r\n";
            code += "class " + CName + " : public ISerialized {\r\n";

            this.setConstructCode();
            this.setGetterCode();
            this.setVarCode();
            code += "};\r\n";
            code += "\r\n";
            code += "}\r\n";
            code += "#endif\r\n";

        }

        private void setConstructCode()
        {
            code += "\r\n";
            code += "   public:\r\n";
            code += "       " + CName + "(TiXmlNode* xmlNode)\r\n";
            code += "       : ISerialized(xmlNode){\r\n";
            code += "             TiXmlElement* xmlElem = xmlNode->ToElement();\r\n";
            code += "             const char *pKey = xmlElem->Value();\r\n";
            code += "             const char *pText = xmlElem->GetText();\r\n";
            code += "\r\n";
            code += "             if( pText ) { this->valueStr = pText; }\r\n";
            code += "             else if( xmlElem->NoChildren() ) { this->valueStr = \"NULL ( empty value )\"; }\r\n";
            code += "             else { this->valueStr = \"NULL value ( Node has Children )\"; }\r\n";
            code += "             #ifdef ConsolePrint\r\n";
            code += "                FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << \"   \" << xmlNode->Value() << \" : \" << this->valueStr.c_str() << std::endl;\r\n";
            code += "             #endif\r\n";
            //code += "           " + "this->valueStr = str;\r\n";
            code += "       }\r\n";
        }

        private void setGetterCode() 
        {
            code += "\r\n";
            code += "   public:\r\n";
            code += "       std::string SValue(){return this->valueStr;}\r\n";
            code += "       double DValue(){return (double)(atof(this->valueStr.c_str()));}\r\n";
            code += "       int IValue(){return (int)(atoi(this->valueStr.c_str()));}\r\n";
            code += "       unsigned int UIValue(){return (unsigned int)(atoi(this->valueStr.c_str()));}\r\n";
            code += "       long LValue(){return (long)(atol(this->valueStr.c_str()));}\r\n";
            code += "       bool BValue()\r\n";
            code += "       {\r\n";
            code += "           std::string str = this->valueStr.c_str();\r\n";
            code += "   		std::string upperStr = boost::to_upper_copy(str);\r\n";
            code += "           if(upperStr == \"TRUE\" || upperStr == \"1\"){return true;}\r\n";
            code += "           else if(upperStr == \"FALSE\" || upperStr == \"0\"){return false;}\r\n";
            code += "           else {return false;}\r\n";
            code += "       }\r\n";
            code += "       QuantLib::Date dateValue()\r\n";
            code += "       {\r\n";
            code += "           Year year = 1;\r\n";
            code += "           Month month = Month(1);\r\n";
            code += "           Day day = 1;\r\n";
            code += "           if( valueStr.length() == 10 ){\r\n";
            code += "               year = atoi(valueStr.substr(0,4).c_str());\r\n";
            code += "               month = Month(atoi(valueStr.substr(5,2).c_str()));;\r\n";
            code += "               day = atoi(valueStr.substr(8,4).c_str());;\r\n";
            code += "           }else\r\n";
            code += "           {\r\n";
            code += "               QL_FAIL(valueStr);\r\n";
            code += "           }\r\n";
            code += "           return Date(day,month,year);\r\n";
            code += "        }\r\n";


        }

        private void setVarCode()
        {
            code += "\r\n";
            code += "   private:\r\n";
            code += "       " + "std::string valueStr;\r\n";
        }


        
    }
}
