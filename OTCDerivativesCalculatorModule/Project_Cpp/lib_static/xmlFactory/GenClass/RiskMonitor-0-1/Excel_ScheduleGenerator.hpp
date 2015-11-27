// Excel_ScheduleGenerator.hpp 
#ifndef FpmlSerialized_Excel_ScheduleGenerator_hpp
#define FpmlSerialized_Excel_ScheduleGenerator_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class Excel_ScheduleGenerator : public ISerialized { 
   public: 
       Excel_ScheduleGenerator(TiXmlNode* xmlNode);

       bool isEffectiveDate(){return this->effectiveDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getEffectiveDate();


       bool isMaturityDate(){return this->maturityDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getMaturityDate();


       bool isTenor(){return this->tenorIsNull_;}
       boost::shared_ptr<XsdTypeToken> getTenor();


       bool isPaymentDays(){return this->paymentDaysIsNull_;}
       boost::shared_ptr<XsdTypeToken> getPaymentDays();


       bool isCalendars(){return this->calendarsIsNull_;}
       std::vector<boost::shared_ptr<XsdTypeToken>> getCalendars();


       bool isBusinessDayConvention(){return this->businessDayConventionIsNull_;}
       boost::shared_ptr<XsdTypeToken> getBusinessDayConvention();


       bool isDateGeneration(){return this->dateGenerationIsNull_;}
       boost::shared_ptr<XsdTypeToken> getDateGeneration();


   protected: 
       boost::shared_ptr<XsdTypeToken> effectiveDate_;
       
       bool effectiveDateIsNull_;
       boost::shared_ptr<XsdTypeToken> maturityDate_;
       
       bool maturityDateIsNull_;
       boost::shared_ptr<XsdTypeToken> tenor_;
       
       bool tenorIsNull_;
       boost::shared_ptr<XsdTypeToken> paymentDays_;
       
       bool paymentDaysIsNull_;
       std::vector<boost::shared_ptr<XsdTypeToken>> calendars_;
       
       bool calendarsIsNull_;
       boost::shared_ptr<XsdTypeToken> businessDayConvention_;
       
       bool businessDayConventionIsNull_;
       boost::shared_ptr<XsdTypeToken> dateGeneration_;
       
       bool dateGenerationIsNull_;

};

} //namespaceFpmlSerialized end
#endif

