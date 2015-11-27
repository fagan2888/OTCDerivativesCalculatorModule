// CdsSpreadTermstructure.hpp 
#ifndef FpmlSerialized_CdsSpreadTermstructure_hpp
#define FpmlSerialized_CdsSpreadTermstructure_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/RateData.hpp>

namespace FpmlSerialized {

class CdsSpreadTermstructure : public ISerialized { 
   public: 
       CdsSpreadTermstructure(TiXmlNode* xmlNode);

       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getType();


       bool isInterpolation(){return this->interpolationIsNull_;}
       boost::shared_ptr<XsdTypeToken> getInterpolation();


       bool isDaycounter(){return this->daycounterIsNull_;}
       boost::shared_ptr<XsdTypeToken> getDaycounter();


       bool isCalendar(){return this->calendarIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCalendar();


       bool isBusinessDayConvention(){return this->businessDayConventionIsNull_;}
       boost::shared_ptr<XsdTypeToken> getBusinessDayConvention();


       bool isRateData(){return this->rateDataIsNull_;}
       std::vector<boost::shared_ptr<RateData>> getRateData();


       bool isDateGeneration(){return this->dateGenerationIsNull_;}
       boost::shared_ptr<XsdTypeToken> getDateGeneration();


       bool isRecoveryRate(){return this->recoveryRateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getRecoveryRate();


   protected: 
       boost::shared_ptr<XsdTypeToken> type_;
       
       bool typeIsNull_;
       boost::shared_ptr<XsdTypeToken> interpolation_;
       
       bool interpolationIsNull_;
       boost::shared_ptr<XsdTypeToken> daycounter_;
       
       bool daycounterIsNull_;
       boost::shared_ptr<XsdTypeToken> calendar_;
       
       bool calendarIsNull_;
       boost::shared_ptr<XsdTypeToken> businessDayConvention_;
       
       bool businessDayConventionIsNull_;
       std::vector<boost::shared_ptr<RateData>> rateData_;
       
       bool rateDataIsNull_;
       boost::shared_ptr<XsdTypeToken> dateGeneration_;
       
       bool dateGenerationIsNull_;
       boost::shared_ptr<XsdTypeToken> recoveryRate_;
       
       bool recoveryRateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

