// Excel_fixedBond_subSchedule.hpp 
#ifndef FpmlSerialized_Excel_fixedBond_subSchedule_hpp
#define FpmlSerialized_Excel_fixedBond_subSchedule_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class Excel_fixedBond_subSchedule : public ISerialized { 
   public: 
       Excel_fixedBond_subSchedule(TiXmlNode* xmlNode);

       bool isEventDate(){return this->eventDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getEventDate();


       bool isCalculationStartDate(){return this->calculationStartDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCalculationStartDate();


       bool isCalculationEndDate(){return this->calculationEndDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCalculationEndDate();


       bool isPaymentDate(){return this->paymentDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getPaymentDate();


       bool isFixedRate(){return this->fixedRateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getFixedRate();


   protected: 
       boost::shared_ptr<XsdTypeToken> eventDate_;
       
       bool eventDateIsNull_;
       boost::shared_ptr<XsdTypeToken> calculationStartDate_;
       
       bool calculationStartDateIsNull_;
       boost::shared_ptr<XsdTypeToken> calculationEndDate_;
       
       bool calculationEndDateIsNull_;
       boost::shared_ptr<XsdTypeToken> paymentDate_;
       
       bool paymentDateIsNull_;
       boost::shared_ptr<XsdTypeToken> fixedRate_;
       
       bool fixedRateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

