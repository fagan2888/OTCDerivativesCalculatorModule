// DividendPeriodPayment.hpp 
#ifndef FpmlSerialized_DividendPeriodPayment_hpp
#define FpmlSerialized_DividendPeriodPayment_hpp

#include <fpml-eq-shared-5-4/DividendPeriod.hpp>
#include <fpml-shared-5-4/PositiveDecimal.hpp>
#include <fpml-shared-5-4/AdjustableOrRelativeDate.hpp>

namespace FpmlSerialized {

class DividendPeriodPayment : public DividendPeriod { 
   public: 
       DividendPeriodPayment(TiXmlNode* xmlNode);

       bool isFixedStrike(){return this->fixedStrikeIsNull_;}
       boost::shared_ptr<PositiveDecimal> getFixedStrike();
      std::string getFixedStrikeIDRef(){return fixedStrikeIDRef_;}

       bool isPaymentDate(){return this->paymentDateIsNull_;}
       boost::shared_ptr<AdjustableOrRelativeDate> getPaymentDate();
      std::string getPaymentDateIDRef(){return paymentDateIDRef_;}

       bool isValuationDate(){return this->valuationDateIsNull_;}
       boost::shared_ptr<AdjustableOrRelativeDate> getValuationDate();
      std::string getValuationDateIDRef(){return valuationDateIDRef_;}

   protected: 
       boost::shared_ptr<PositiveDecimal> fixedStrike_;
       std::string fixedStrikeIDRef_;
       bool fixedStrikeIsNull_;
       boost::shared_ptr<AdjustableOrRelativeDate> paymentDate_;
       std::string paymentDateIDRef_;
       bool paymentDateIsNull_;
       boost::shared_ptr<AdjustableOrRelativeDate> valuationDate_;
       std::string valuationDateIDRef_;
       bool valuationDateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

