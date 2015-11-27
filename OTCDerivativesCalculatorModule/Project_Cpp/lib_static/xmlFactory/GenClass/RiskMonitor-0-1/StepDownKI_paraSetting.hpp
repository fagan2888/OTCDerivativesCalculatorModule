// StepDownKI_paraSetting.hpp 
#ifndef FpmlSerialized_StepDownKI_paraSetting_hpp
#define FpmlSerialized_StepDownKI_paraSetting_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/GeometricBM_paraSetting.hpp>
#include <RiskMonitor-0-1/HullWhite_paraSetting.hpp>
#include <RiskMonitor-0-1/DiscountCurve_paraSetting.hpp>

namespace FpmlSerialized {

class StepDownKI_paraSetting : public ISerialized { 
   public: 
       StepDownKI_paraSetting(TiXmlNode* xmlNode);

       bool isGeometricBM_paraSetting(){return this->geometricBM_paraSettingIsNull_;}
       boost::shared_ptr<GeometricBM_paraSetting> getGeometricBM_paraSetting();


       bool isHullWhite_paraSetting(){return this->hullWhite_paraSettingIsNull_;}
       boost::shared_ptr<HullWhite_paraSetting> getHullWhite_paraSetting();


       bool isDiscountCurve_paraSetting(){return this->discountCurve_paraSettingIsNull_;}
       boost::shared_ptr<DiscountCurve_paraSetting> getDiscountCurve_paraSetting();


   protected: 
       boost::shared_ptr<GeometricBM_paraSetting> geometricBM_paraSetting_;
       
       bool geometricBM_paraSettingIsNull_;
       boost::shared_ptr<HullWhite_paraSetting> hullWhite_paraSetting_;
       
       bool hullWhite_paraSettingIsNull_;
       boost::shared_ptr<DiscountCurve_paraSetting> discountCurve_paraSetting_;
       
       bool discountCurve_paraSettingIsNull_;

};

} //namespaceFpmlSerialized end
#endif

