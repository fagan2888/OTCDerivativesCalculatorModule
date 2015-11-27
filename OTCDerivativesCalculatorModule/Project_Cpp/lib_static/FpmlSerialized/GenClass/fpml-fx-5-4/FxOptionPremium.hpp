// FxOptionPremium.hpp 
#ifndef FpmlSerialized_FxOptionPremium_hpp
#define FpmlSerialized_FxOptionPremium_hpp

#include <fpml-shared-5-4/NonNegativePayment.hpp>
#include <fpml-shared-5-4/SettlementInformation.hpp>
#include <fpml-fx-5-4/PremiumQuote.hpp>

namespace FpmlSerialized {

class FxOptionPremium : public NonNegativePayment { 
   public: 
       FxOptionPremium(TiXmlNode* xmlNode);

       bool isSettlementInformation(){return this->settlementInformationIsNull_;}
       boost::shared_ptr<SettlementInformation> getSettlementInformation();
      std::string getSettlementInformationIDRef(){return settlementInformationIDRef_;}

       bool isQuote(){return this->quoteIsNull_;}
       boost::shared_ptr<PremiumQuote> getQuote();
      std::string getQuoteIDRef(){return quoteIDRef_;}

   protected: 
       boost::shared_ptr<SettlementInformation> settlementInformation_;
       std::string settlementInformationIDRef_;
       bool settlementInformationIsNull_;
       boost::shared_ptr<PremiumQuote> quote_;
       std::string quoteIDRef_;
       bool quoteIsNull_;

};

} //namespaceFpmlSerialized end
#endif

