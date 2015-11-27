// PositiveAmountSchedule.hpp 
#ifndef FpmlSerialized_PositiveAmountSchedule_hpp
#define FpmlSerialized_PositiveAmountSchedule_hpp

#include <fpml-shared-5-4/PositiveSchedule.hpp>
#include <fpml-shared-5-4/Currency.hpp>

namespace FpmlSerialized {

class PositiveAmountSchedule : public PositiveSchedule { 
   public: 
       PositiveAmountSchedule(TiXmlNode* xmlNode);

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

