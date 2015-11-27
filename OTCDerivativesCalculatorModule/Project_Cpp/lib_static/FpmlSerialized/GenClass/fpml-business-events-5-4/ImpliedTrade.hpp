// ImpliedTrade.hpp 
#ifndef FpmlSerialized_ImpliedTrade_hpp
#define FpmlSerialized_ImpliedTrade_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/OriginatingEvent.hpp>
#include <fpml-doc-5-4/Trade.hpp>
#include <fpml-shared-5-4/NonNegativePayment.hpp>

namespace FpmlSerialized {

class ImpliedTrade : public ISerialized { 
   public: 
       ImpliedTrade(TiXmlNode* xmlNode);

       bool isOriginatingEvent(){return this->originatingEventIsNull_;}
       boost::shared_ptr<OriginatingEvent> getOriginatingEvent();
      std::string getOriginatingEventIDRef(){return originatingEventIDRef_;}

       bool isTrade(){return this->tradeIsNull_;}
       boost::shared_ptr<Trade> getTrade();
      std::string getTradeIDRef(){return tradeIDRef_;}

       bool isPayment(){return this->paymentIsNull_;}
       boost::shared_ptr<NonNegativePayment> getPayment();
      std::string getPaymentIDRef(){return paymentIDRef_;}

   protected: 
       boost::shared_ptr<OriginatingEvent> originatingEvent_;
       std::string originatingEventIDRef_;
       bool originatingEventIsNull_;
       boost::shared_ptr<Trade> trade_;
       std::string tradeIDRef_;
       bool tradeIsNull_;
       boost::shared_ptr<NonNegativePayment> payment_;
       std::string paymentIDRef_;
       bool paymentIsNull_;

};

} //namespaceFpmlSerialized end
#endif

