// ReturnSwapPaymentDates.hpp 
#ifndef FpmlSerialized_ReturnSwapPaymentDates_hpp
#define FpmlSerialized_ReturnSwapPaymentDates_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/AdjustableOrRelativeDates.hpp>
#include <fpml-shared-5-4/AdjustableOrRelativeDate.hpp>

namespace FpmlSerialized {

class ReturnSwapPaymentDates : public ISerialized { 
   public: 
       ReturnSwapPaymentDates(TiXmlNode* xmlNode);

       bool isPaymentDatesInterim(){return this->paymentDatesInterimIsNull_;}
       boost::shared_ptr<AdjustableOrRelativeDates> getPaymentDatesInterim();
      std::string getPaymentDatesInterimIDRef(){return paymentDatesInterimIDRef_;}

       bool isPaymentDateFinal(){return this->paymentDateFinalIsNull_;}
       boost::shared_ptr<AdjustableOrRelativeDate> getPaymentDateFinal();
      std::string getPaymentDateFinalIDRef(){return paymentDateFinalIDRef_;}

   protected: 
       boost::shared_ptr<AdjustableOrRelativeDates> paymentDatesInterim_;
       std::string paymentDatesInterimIDRef_;
       bool paymentDatesInterimIsNull_;
       boost::shared_ptr<AdjustableOrRelativeDate> paymentDateFinal_;
       std::string paymentDateFinalIDRef_;
       bool paymentDateFinalIsNull_;

};

} //namespaceFpmlSerialized end
#endif

