#ifndef FpmlSerialized_SignatureType_hpp
#define FpmlSerialized_SignatureType_hpp

#include <string>
#include <iserialized.hpp>

namespace FpmlSerialized {

class SignatureType : public ISerialized {

   public:
       SignatureType(TiXmlNode* xmlNode)
       : ISerialized(xmlNode){
             this->valueStr = xmlNode->Value();
       }

   public:
       std::string SValue(){return this->valueStr;}
       double DValue(){return (double)(atof(this->valueStr.c_str()));}
       int IValue(){return (int)(atoi(this->valueStr.c_str()));}
       long LValue(){return (long)(atol(this->valueStr.c_str()));}
       //QuantLib::Date dateValue(){return this->valueStr.c_str();}

   private:
       std::string valueStr;
};

};
#endif

