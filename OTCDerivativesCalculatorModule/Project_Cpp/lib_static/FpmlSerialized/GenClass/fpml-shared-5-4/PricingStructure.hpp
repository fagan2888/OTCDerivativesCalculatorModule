// PricingStructure.hpp 
#ifndef FpmlSerialized_PricingStructure_hpp
#define FpmlSerialized_PricingStructure_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeNormalizedString.hpp>
#include <fpml-shared-5-4/Currency.hpp>

namespace FpmlSerialized {

class PricingStructure : public ISerialized { 
   public: 
       PricingStructure(TiXmlNode* xmlNode);

       bool isName(){return this->nameIsNull_;}
       boost::shared_ptr<XsdTypeNormalizedString> getName();
      std::string getNameIDRef(){return nameIDRef_;}

       bool isCurrency(){return this->currencyIsNull_;}
       boost::shared_ptr<Currency> getCurrency();
      std::string getCurrencyIDRef(){return currencyIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeNormalizedString> name_;
       std::string nameIDRef_;
       bool nameIsNull_;
       boost::shared_ptr<Currency> currency_;
       std::string currencyIDRef_;
       bool currencyIsNull_;

};

} //namespaceFpmlSerialized end
#endif

