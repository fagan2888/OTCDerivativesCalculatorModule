// MoneyBase.hpp 
#ifndef FpmlSerialized_MoneyBase_hpp
#define FpmlSerialized_MoneyBase_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/Currency.hpp>

namespace FpmlSerialized {

class MoneyBase : public ISerialized { 
   public: 
       MoneyBase(TiXmlNode* xmlNode);

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

