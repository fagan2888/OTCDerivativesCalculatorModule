// NonNegativeAmountSchedule.hpp 
#ifndef FpmlSerialized_NonNegativeAmountSchedule_hpp
#define FpmlSerialized_NonNegativeAmountSchedule_hpp

#include <fpml-shared-5-4/NonNegativeSchedule.hpp>
#include <fpml-shared-5-4/Currency.hpp>

namespace FpmlSerialized {

class NonNegativeAmountSchedule : public NonNegativeSchedule { 
   public: 
       NonNegativeAmountSchedule(TiXmlNode* xmlNode);

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

