// PositiveMoney.hpp 
#ifndef FpmlSerialized_PositiveMoney_hpp
#define FpmlSerialized_PositiveMoney_hpp

#include <fpml-shared-5-4/MoneyBase.hpp>
#include <fpml-shared-5-4/PositiveDecimal.hpp>

namespace FpmlSerialized {

class PositiveMoney : public MoneyBase { 
   public: 
       PositiveMoney(TiXmlNode* xmlNode);

       bool isAmount(){return this->amountIsNull_;}
       boost::shared_ptr<PositiveDecimal> getAmount();
      std::string getAmountIDRef(){return amountIDRef_;}

   protected: 
       boost::shared_ptr<PositiveDecimal> amount_;
       std::string amountIDRef_;
       bool amountIsNull_;

};

} //namespaceFpmlSerialized end
#endif

