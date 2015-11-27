// FeeLeg.hpp 
#ifndef FpmlSerialized_FeeLeg_hpp
#define FpmlSerialized_FeeLeg_hpp

#include <fpml-shared-5-4/Leg.hpp>
#include <fpml-cd-5-4/InitialPayment.hpp>
#include <fpml-cd-5-4/SinglePayment.hpp>
#include <fpml-cd-5-4/PeriodicPayment.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-enum-5-4/QuotationStyleEnum.hpp>

namespace FpmlSerialized {

class FeeLeg : public Leg { 
   public: 
       FeeLeg(TiXmlNode* xmlNode);

       bool isInitialPayment(){return this->initialPaymentIsNull_;}
       boost::shared_ptr<InitialPayment> getInitialPayment();
      std::string getInitialPaymentIDRef(){return initialPaymentIDRef_;}

       bool isSinglePayment(){return this->singlePaymentIsNull_;}
       std::vector<boost::shared_ptr<SinglePayment>> getSinglePayment();
      std::string getSinglePaymentIDRef(){return singlePaymentIDRef_;}

       bool isPeriodicPayment(){return this->periodicPaymentIsNull_;}
       boost::shared_ptr<PeriodicPayment> getPeriodicPayment();
      std::string getPeriodicPaymentIDRef(){return periodicPaymentIDRef_;}

       bool isMarketFixedRate(){return this->marketFixedRateIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getMarketFixedRate();
      std::string getMarketFixedRateIDRef(){return marketFixedRateIDRef_;}

       bool isPaymentDelay(){return this->paymentDelayIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getPaymentDelay();
      std::string getPaymentDelayIDRef(){return paymentDelayIDRef_;}

       bool isInitialPoints(){return this->initialPointsIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getInitialPoints();
      std::string getInitialPointsIDRef(){return initialPointsIDRef_;}

       bool isQuotationStyle(){return this->quotationStyleIsNull_;}
       boost::shared_ptr<QuotationStyleEnum> getQuotationStyle();
      std::string getQuotationStyleIDRef(){return quotationStyleIDRef_;}

   protected: 
       boost::shared_ptr<InitialPayment> initialPayment_;
       std::string initialPaymentIDRef_;
       bool initialPaymentIsNull_;
       std::vector<boost::shared_ptr<SinglePayment>> singlePayment_;
       std::string singlePaymentIDRef_;
       bool singlePaymentIsNull_;
       boost::shared_ptr<PeriodicPayment> periodicPayment_;
       std::string periodicPaymentIDRef_;
       bool periodicPaymentIsNull_;
       boost::shared_ptr<XsdTypeDecimal> marketFixedRate_;
       std::string marketFixedRateIDRef_;
       bool marketFixedRateIsNull_;
       boost::shared_ptr<XsdTypeBoolean> paymentDelay_;
       std::string paymentDelayIDRef_;
       bool paymentDelayIsNull_;
       boost::shared_ptr<XsdTypeDecimal> initialPoints_;
       std::string initialPointsIDRef_;
       bool initialPointsIsNull_;
       boost::shared_ptr<QuotationStyleEnum> quotationStyle_;
       std::string quotationStyleIDRef_;
       bool quotationStyleIsNull_;

};

} //namespaceFpmlSerialized end
#endif

