// BondInformation.hpp 
#ifndef FpmlSerialized_BondInformation_hpp
#define FpmlSerialized_BondInformation_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class BondInformation : public ISerialized { 
   public: 
       BondInformation(TiXmlNode* xmlNode);

       bool isIrFrequency(){return this->irFrequencyIsNull_;}
       boost::shared_ptr<XsdTypeToken> getIrFrequency();


       bool isNotional(){return this->notionalIsNull_;}
       boost::shared_ptr<XsdTypeToken> getNotional();


       bool isIssueDate(){return this->issueDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getIssueDate();


       bool isMaturityDate(){return this->maturityDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getMaturityDate();


       bool isDayCounter(){return this->dayCounterIsNull_;}
       boost::shared_ptr<XsdTypeToken> getDayCounter();


       bool isBusinessDayConvention(){return this->businessDayConventionIsNull_;}
       boost::shared_ptr<XsdTypeToken> getBusinessDayConvention();


       bool isCalendar(){return this->calendarIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCalendar();


   protected: 
       boost::shared_ptr<XsdTypeToken> irFrequency_;
       
       bool irFrequencyIsNull_;
       boost::shared_ptr<XsdTypeToken> notional_;
       
       bool notionalIsNull_;
       boost::shared_ptr<XsdTypeToken> issueDate_;
       
       bool issueDateIsNull_;
       boost::shared_ptr<XsdTypeToken> maturityDate_;
       
       bool maturityDateIsNull_;
       boost::shared_ptr<XsdTypeToken> dayCounter_;
       
       bool dayCounterIsNull_;
       boost::shared_ptr<XsdTypeToken> businessDayConvention_;
       
       bool businessDayConventionIsNull_;
       boost::shared_ptr<XsdTypeToken> calendar_;
       
       bool calendarIsNull_;

};

} //namespaceFpmlSerialized end
#endif

