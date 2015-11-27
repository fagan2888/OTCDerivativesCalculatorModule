// SpecifiedCurrency.hpp 
#ifndef FpmlSerialized_SpecifiedCurrency_hpp
#define FpmlSerialized_SpecifiedCurrency_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-shared-5-4/Currency.hpp>

namespace FpmlSerialized {

class SpecifiedCurrency : public ISerialized { 
   public: 
       SpecifiedCurrency(TiXmlNode* xmlNode);

       bool isApplicable(){return this->applicableIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getApplicable();
      std::string getApplicableIDRef(){return applicableIDRef_;}

       bool isCurrency(){return this->currencyIsNull_;}
       std::vector<boost::shared_ptr<Currency>> getCurrency();
      std::string getCurrencyIDRef(){return currencyIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeBoolean> applicable_;
       std::string applicableIDRef_;
       bool applicableIsNull_;
       std::vector<boost::shared_ptr<Currency>> currency_;
       std::string currencyIDRef_;
       bool currencyIsNull_;

};

} //namespaceFpmlSerialized end
#endif
