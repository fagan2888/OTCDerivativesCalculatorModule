// EquityOptionTermination.hpp 
#ifndef FpmlSerialized_EquityOptionTermination_hpp
#define FpmlSerialized_EquityOptionTermination_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/AdjustableDate.hpp>
#include <fpml-shared-5-4/NonNegativeMoney.hpp>

namespace FpmlSerialized {

class EquityOptionTermination : public ISerialized { 
   public: 
       EquityOptionTermination(TiXmlNode* xmlNode);

       bool isSettlementAmountPaymentDate(){return this->settlementAmountPaymentDateIsNull_;}
       boost::shared_ptr<AdjustableDate> getSettlementAmountPaymentDate();
      std::string getSettlementAmountPaymentDateIDRef(){return settlementAmountPaymentDateIDRef_;}

       bool isSettlementAmount(){return this->settlementAmountIsNull_;}
       boost::shared_ptr<NonNegativeMoney> getSettlementAmount();
      std::string getSettlementAmountIDRef(){return settlementAmountIDRef_;}

   protected: 
       boost::shared_ptr<AdjustableDate> settlementAmountPaymentDate_;
       std::string settlementAmountPaymentDateIDRef_;
       bool settlementAmountPaymentDateIsNull_;
       boost::shared_ptr<NonNegativeMoney> settlementAmount_;
       std::string settlementAmountIDRef_;
       bool settlementAmountIsNull_;

};

} //namespaceFpmlSerialized end
#endif

