#ifndef FpmlSerialized_CryptoBinary_hpp
#define FpmlSerialized_CryptoBinary_hpp

#include <string>
#include <iserialized.hpp>
#include <ql/time/date.hpp>

using namespace QuantLib;
namespace FpmlSerialized {

class CryptoBinary : public ISerialized {

   public:
       CryptoBinary(TiXmlNode* xmlNode)
       : ISerialized(xmlNode){
             TiXmlElement* xmlElem = xmlNode->ToElement();
             const char *pKey = xmlElem->Value();
             const char *pText = xmlElem->GetText();

             if( pText ) { this->valueStr = pText; }
             else if( xmlElem->NoChildren() ) { this->valueStr = "NULL ( empty value )"; }
             else { this->valueStr = "NULL value ( Node has Children )"; }
             #ifdef ConsolePrint
                FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "   " << xmlNode->Value() << " : " << this->valueStr.c_str() << std::endl;
             #endif
       }

   public:
       std::string SValue(){return this->valueStr;}
       double DValue(){return (double)(atof(this->valueStr.c_str()));}
       int IValue(){return (int)(atoi(this->valueStr.c_str()));}
       unsigned int UIValue(){return (unsigned int)(atoi(this->valueStr.c_str()));}
       long LValue(){return (long)(atol(this->valueStr.c_str()));}
       bool BValue()
       {
           std::string str = this->valueStr.c_str();
           if(str == "true" || str == "1"){return true;}
           else if(str == "false" || str == "0"){return false;}
           else {return false;}
       }
       QuantLib::Date dateValue()
       {
           Year year = 1;
           Month month = Month(1);
           Day day = 1;
           if( valueStr.length() == 10 ){
               year = atoi(valueStr.substr(0,4).c_str());
               month = Month(atoi(valueStr.substr(5,2).c_str()));;
               day = atoi(valueStr.substr(8,4).c_str());;
           }else
           {
               QL_FAIL(valueStr);
           }
           return Date(day,month,year);
        }

   private:
       std::string valueStr;
};

}
#endif

