// FxOptionPayout.hpp 
#ifndef FpmlSerialized_FxOptionPayout_hpp
#define FpmlSerialized_FxOptionPayout_hpp

#include <fpml-shared-5-4/NonNegativeMoney.hpp>
#include <fpml-enum-5-4/PayoutEnum.hpp>
#include <fpml-shared-5-4/SettlementInformation.hpp>

namespace FpmlSerialized {

class FxOptionPayout : public NonNegativeMoney { 
   public: 
       FxOptionPayout(TiXmlNode* xmlNode);

       bool isPayoutStyle(){return this->payoutStyleIsNull_;}
       boost::shared_ptr<PayoutEnum> getPayoutStyle();
      std::string getPayoutStyleIDRef(){return payoutStyleIDRef_;}

       bool isSettlementInformation(){return this->settlementInformationIsNull_;}
       boost::shared_ptr<SettlementInformation> getSettlementInformation();
      std::string getSettlementInformationIDRef(){return settlementInformationIDRef_;}

   protected: 
       boost::shared_ptr<PayoutEnum> payoutStyle_;
       std::string payoutStyleIDRef_;
       bool payoutStyleIsNull_;
       boost::shared_ptr<SettlementInformation> settlementInformation_;
       std::string settlementInformationIDRef_;
       bool settlementInformationIsNull_;

};

} //namespaceFpmlSerialized end
#endif

