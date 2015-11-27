// OptionStrike.hpp 
#ifndef FpmlSerialized_OptionStrike_hpp
#define FpmlSerialized_OptionStrike_hpp

#include <fpml-option-shared-5-4/OptionNumericStrike.hpp>
#include <fpml-shared-5-4/Currency.hpp>

namespace FpmlSerialized {

class OptionStrike : public OptionNumericStrike { 
   public: 
       OptionStrike(TiXmlNode* xmlNode);

       bool isCurrency(){return this->currencyIsNull_;}
       boost::shared_ptr<Currency> getCurrency();
      std::string getCurrencyIDRef(){return currencyIDRef_;}

   protected: 
       boost::shared_ptr<Currency> currency_;
       std::string currencyIDRef_;
       bool currencyIsNull_;

};

} //namespaceFpmlSerialized end
#endif

