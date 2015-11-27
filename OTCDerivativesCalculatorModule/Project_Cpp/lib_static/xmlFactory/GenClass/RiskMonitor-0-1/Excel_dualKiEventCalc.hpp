// Excel_dualKiEventCalc.hpp 
#ifndef FpmlSerialized_Excel_dualKiEventCalc_hpp
#define FpmlSerialized_Excel_dualKiEventCalc_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/Excel_eventCalcInfo.hpp>

namespace FpmlSerialized {

class Excel_dualKiEventCalc : public ISerialized { 
   public: 
       Excel_dualKiEventCalc(TiXmlNode* xmlNode);

       bool isVba_description(){return this->vba_descriptionIsNull_;}
       boost::shared_ptr<XsdTypeToken> getVba_description();


       bool isExcel_eventCalcInfo(){return this->excel_eventCalcInfoIsNull_;}
       std::vector<boost::shared_ptr<Excel_eventCalcInfo>> getExcel_eventCalcInfo();


   protected: 
       boost::shared_ptr<XsdTypeToken> vba_description_;
       
       bool vba_descriptionIsNull_;
       std::vector<boost::shared_ptr<Excel_eventCalcInfo>> excel_eventCalcInfo_;
       
       bool excel_eventCalcInfoIsNull_;

};

} //namespaceFpmlSerialized end
#endif

