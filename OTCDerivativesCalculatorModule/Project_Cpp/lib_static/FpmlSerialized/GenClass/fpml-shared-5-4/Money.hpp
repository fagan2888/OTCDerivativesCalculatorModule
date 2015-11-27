// Money.hpp 
#ifndef FpmlSerialized_Money_hpp
#define FpmlSerialized_Money_hpp

#include <fpml-shared-5-4/MoneyBase.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>

namespace FpmlSerialized {

class Money : public MoneyBase { 
   public: 
       Money(TiXmlNode* xmlNode);

       bool isAmount(){return this->amountIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getAmount();
      std::string getAmountIDRef(){return amountIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeDecimal> amount_;
       std::string amountIDRef_;
       bool amountIsNull_;

};

} //namespaceFpmlSerialized end
#endif

