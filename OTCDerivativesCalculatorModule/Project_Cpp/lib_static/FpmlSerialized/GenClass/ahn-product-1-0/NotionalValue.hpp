// NotionalValue.hpp 
#ifndef FpmlSerialized_NotionalValue_hpp
#define FpmlSerialized_NotionalValue_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>

namespace FpmlSerialized {

class NotionalValue : public ISerialized { 
   public: 
       NotionalValue(TiXmlNode* xmlNode);

       bool isNotionalAmount(){return this->notionalAmountIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getNotionalAmount();
      std::string getNotionalAmountIDRef(){return notionalAmountIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeDecimal> notionalAmount_;
       std::string notionalAmountIDRef_;
       bool notionalAmountIsNull_;

};

} //namespaceFpmlSerialized end
#endif

