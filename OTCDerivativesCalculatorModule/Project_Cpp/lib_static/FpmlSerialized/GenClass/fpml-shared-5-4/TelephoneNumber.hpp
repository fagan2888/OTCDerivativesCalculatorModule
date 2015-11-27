// TelephoneNumber.hpp 
#ifndef FpmlSerialized_TelephoneNumber_hpp
#define FpmlSerialized_TelephoneNumber_hpp

#include <ISerialized.hpp>
#include <fpml-enum-5-4/TelephoneTypeEnum.hpp>
#include <built_in_type/XsdTypeString.hpp>

namespace FpmlSerialized {

class TelephoneNumber : public ISerialized { 
   public: 
       TelephoneNumber(TiXmlNode* xmlNode);

       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<TelephoneTypeEnum> getType();
      std::string getTypeIDRef(){return typeIDRef_;}

       bool isNumber(){return this->numberIsNull_;}
       boost::shared_ptr<XsdTypeString> getNumber();
      std::string getNumberIDRef(){return numberIDRef_;}

   protected: 
       boost::shared_ptr<TelephoneTypeEnum> type_;
       std::string typeIDRef_;
       bool typeIsNull_;
       boost::shared_ptr<XsdTypeString> number_;
       std::string numberIDRef_;
       bool numberIsNull_;

};

} //namespaceFpmlSerialized end
#endif

