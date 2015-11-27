// Excel_forwardModel.hpp 
#ifndef FpmlSerialized_Excel_forwardModel_hpp
#define FpmlSerialized_Excel_forwardModel_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/Excel_yieldCurve.hpp>

namespace FpmlSerialized {

class Excel_forwardModel : public ISerialized { 
   public: 
       Excel_forwardModel(TiXmlNode* xmlNode);

       bool isCurrentValue(){return this->currentValueIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCurrentValue();


       bool isTenor(){return this->tenorIsNull_;}
       boost::shared_ptr<XsdTypeToken> getTenor();


       bool isLinkedCurveCode(){return this->linkedCurveCodeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getLinkedCurveCode();


       bool isExcel_yieldCurve(){return this->excel_yieldCurveIsNull_;}
       boost::shared_ptr<Excel_yieldCurve> getExcel_yieldCurve();


       bool isVba_description(){return this->vba_descriptionIsNull_;}
       boost::shared_ptr<XsdTypeToken> getVba_description();


   protected: 
       boost::shared_ptr<XsdTypeToken> currentValue_;
       
       bool currentValueIsNull_;
       boost::shared_ptr<XsdTypeToken> tenor_;
       
       bool tenorIsNull_;
       boost::shared_ptr<XsdTypeToken> linkedCurveCode_;
       
       bool linkedCurveCodeIsNull_;
       boost::shared_ptr<Excel_yieldCurve> excel_yieldCurve_;
       
       bool excel_yieldCurveIsNull_;
       boost::shared_ptr<XsdTypeToken> vba_description_;
       
       bool vba_descriptionIsNull_;

};

} //namespaceFpmlSerialized end
#endif

