// YieldTermstructure.hpp 
#ifndef FpmlSerialized_YieldTermstructure_hpp
#define FpmlSerialized_YieldTermstructure_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/RateData.hpp>

namespace FpmlSerialized {

class YieldTermstructure : public ISerialized { 
   public: 
       YieldTermstructure(TiXmlNode* xmlNode);

       bool isCurveType(){return this->curveTypeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCurveType();


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


   protected: 
       boost::shared_ptr<XsdTypeToken> curveType_;
       
       bool curveTypeIsNull_;
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

};

} //namespaceFpmlSerialized end
#endif

