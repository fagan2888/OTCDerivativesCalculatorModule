// Deposit.hpp 
#ifndef FpmlSerialized_Deposit_hpp
#define FpmlSerialized_Deposit_hpp

#include <fpml-asset-5-4/UnderlyingAsset.hpp>
#include <fpml-shared-5-4/Period.hpp>
#include <fpml-shared-5-4/DayCountFraction.hpp>

namespace FpmlSerialized {

class Deposit : public UnderlyingAsset { 
   public: 
       Deposit(TiXmlNode* xmlNode);

       bool isTerm(){return this->termIsNull_;}
       boost::shared_ptr<Period> getTerm();
      std::string getTermIDRef(){return termIDRef_;}

       bool isPaymentFrequency(){return this->paymentFrequencyIsNull_;}
       boost::shared_ptr<Period> getPaymentFrequency();
      std::string getPaymentFrequencyIDRef(){return paymentFrequencyIDRef_;}

       bool isDayCountFraction(){return this->dayCountFractionIsNull_;}
       boost::shared_ptr<DayCountFraction> getDayCountFraction();
      std::string getDayCountFractionIDRef(){return dayCountFractionIDRef_;}

   protected: 
       boost::shared_ptr<Period> term_;
       std::string termIDRef_;
       bool termIsNull_;
       boost::shared_ptr<Period> paymentFrequency_;
       std::string paymentFrequencyIDRef_;
       bool paymentFrequencyIsNull_;
       boost::shared_ptr<DayCountFraction> dayCountFraction_;
       std::string dayCountFractionIDRef_;
       bool dayCountFractionIsNull_;

};

} //namespaceFpmlSerialized end
#endif

