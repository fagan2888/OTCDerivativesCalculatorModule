// Excel_hullWhiteOneFactor.hpp 
#ifndef FpmlSerialized_Excel_hullWhiteOneFactor_hpp
#define FpmlSerialized_Excel_hullWhiteOneFactor_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/Excel_rateInfo.hpp>
#include <RiskMonitor-0-1/Excel_yieldCurve.hpp>

namespace FpmlSerialized {

class Excel_hullWhiteOneFactor : public ISerialized { 
   public: 
       Excel_hullWhiteOneFactor(TiXmlNode* xmlNode);

       bool isCurrentValue(){return this->currentValueIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCurrentValue();


       bool isAlpha(){return this->alphaIsNull_;}
       boost::shared_ptr<XsdTypeToken> getAlpha();


       bool isVolatility(){return this->volatilityIsNull_;}
       boost::shared_ptr<XsdTypeToken> getVolatility();


       bool isExcel_rateInfo(){return this->excel_rateInfoIsNull_;}
       boost::shared_ptr<Excel_rateInfo> getExcel_rateInfo();


       bool isLinkedCurveCode(){return this->linkedCurveCodeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getLinkedCurveCode();


       bool isExcel_yieldCurve(){return this->excel_yieldCurveIsNull_;}
       boost::shared_ptr<Excel_yieldCurve> getExcel_yieldCurve();


       bool isVba_description(){return this->vba_descriptionIsNull_;}
       boost::shared_ptr<XsdTypeToken> getVba_description();


   protected: 
       boost::shared_ptr<XsdTypeToken> currentValue_;
       
       bool currentValueIsNull_;
       boost::shared_ptr<XsdTypeToken> alpha_;
       
       bool alphaIsNull_;
       boost::shared_ptr<XsdTypeToken> volatility_;
       
       bool volatilityIsNull_;
       boost::shared_ptr<Excel_rateInfo> excel_rateInfo_;
       
       bool excel_rateInfoIsNull_;
       boost::shared_ptr<XsdTypeToken> linkedCurveCode_;
       
       bool linkedCurveCodeIsNull_;
       boost::shared_ptr<Excel_yieldCurve> excel_yieldCurve_;
       
       bool excel_yieldCurveIsNull_;
       boost::shared_ptr<XsdTypeToken> vba_description_;
       
       bool vba_descriptionIsNull_;

};

} //namespaceFpmlSerialized end
#endif

