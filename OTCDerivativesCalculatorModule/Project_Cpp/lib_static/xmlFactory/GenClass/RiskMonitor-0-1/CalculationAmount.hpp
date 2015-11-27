// CalculationAmount.hpp 
#ifndef FpmlSerialized_CalculationAmount_hpp
#define FpmlSerialized_CalculationAmount_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <built_in_type/XsdTypeDouble.hpp>

namespace FpmlSerialized {

class CalculationAmount : public ISerialized { 
   public: 
       CalculationAmount(TiXmlNode* xmlNode);

       bool isCurrency(){return this->currencyIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCurrency();


       bool isAmount(){return this->amountIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getAmount();


   protected: 
       boost::shared_ptr<XsdTypeToken> currency_;
       
       bool currencyIsNull_;
       boost::shared_ptr<XsdTypeDouble> amount_;
       
       bool amountIsNull_;

};

} //namespaceFpmlSerialized end
#endif

