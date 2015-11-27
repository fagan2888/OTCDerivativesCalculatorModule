// Excel_interpolation.hpp 
#ifndef FpmlSerialized_Excel_interpolation_hpp
#define FpmlSerialized_Excel_interpolation_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class Excel_interpolation : public ISerialized { 
   public: 
       Excel_interpolation(TiXmlNode* xmlNode);

       bool isInterpolation(){return this->interpolationIsNull_;}
       boost::shared_ptr<XsdTypeToken> getInterpolation();


       bool isDaycounter(){return this->daycounterIsNull_;}
       boost::shared_ptr<XsdTypeToken> getDaycounter();


       bool isCalendar(){return this->calendarIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCalendar();


       bool isBusinessDayConvention(){return this->businessDayConventionIsNull_;}
       boost::shared_ptr<XsdTypeToken> getBusinessDayConvention();


   protected: 
       boost::shared_ptr<XsdTypeToken> interpolation_;
       
       bool interpolationIsNull_;
       boost::shared_ptr<XsdTypeToken> daycounter_;
       
       bool daycounterIsNull_;
       boost::shared_ptr<XsdTypeToken> calendar_;
       
       bool calendarIsNull_;
       boost::shared_ptr<XsdTypeToken> businessDayConvention_;
       
       bool businessDayConventionIsNull_;

};

} //namespaceFpmlSerialized end
#endif

