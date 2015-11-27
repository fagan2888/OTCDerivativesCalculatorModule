// NonNegativeMoney.hpp 
#ifndef FpmlSerialized_NonNegativeMoney_hpp
#define FpmlSerialized_NonNegativeMoney_hpp

#include <fpml-shared-5-4/MoneyBase.hpp>
#include <fpml-shared-5-4/NonNegativeDecimal.hpp>

namespace FpmlSerialized {

class NonNegativeMoney : public MoneyBase { 
   public: 
       NonNegativeMoney(TiXmlNode* xmlNode);

       bool isAmount(){return this->amountIsNull_;}
       boost::shared_ptr<NonNegativeDecimal> getAmount();
      std::string getAmountIDRef(){return amountIDRef_;}

   protected: 
       boost::shared_ptr<NonNegativeDecimal> amount_;
       std::string amountIDRef_;
       bool amountIsNull_;

};

} //namespaceFpmlSerialized end
#endif

