// AdjustedPaymentDates.hpp 
#ifndef FpmlSerialized_AdjustedPaymentDates_hpp
#define FpmlSerialized_AdjustedPaymentDates_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <fpml-shared-5-4/Money.hpp>

namespace FpmlSerialized {

class AdjustedPaymentDates : public ISerialized { 
   public: 
       AdjustedPaymentDates(TiXmlNode* xmlNode);

       bool isAdjustedPaymentDate(){return this->adjustedPaymentDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getAdjustedPaymentDate();
      std::string getAdjustedPaymentDateIDRef(){return adjustedPaymentDateIDRef_;}

       bool isPaymentAmount(){return this->paymentAmountIsNull_;}
       boost::shared_ptr<Money> getPaymentAmount();
      std::string getPaymentAmountIDRef(){return paymentAmountIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeDate> adjustedPaymentDate_;
       std::string adjustedPaymentDateIDRef_;
       bool adjustedPaymentDateIsNull_;
       boost::shared_ptr<Money> paymentAmount_;
       std::string paymentAmountIDRef_;
       bool paymentAmountIsNull_;

};

} //namespaceFpmlSerialized end
#endif

