// AmountSchedule.hpp 
#ifndef FpmlSerialized_AmountSchedule_hpp
#define FpmlSerialized_AmountSchedule_hpp

#include <fpml-shared-5-4/Schedule.hpp>
#include <fpml-shared-5-4/Currency.hpp>

namespace FpmlSerialized {

class AmountSchedule : public Schedule { 
   public: 
       AmountSchedule(TiXmlNode* xmlNode);

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

