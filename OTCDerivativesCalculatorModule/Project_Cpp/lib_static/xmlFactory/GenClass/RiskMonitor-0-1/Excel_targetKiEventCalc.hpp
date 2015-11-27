// Excel_targetKiEventCalc.hpp 
#ifndef FpmlSerialized_Excel_targetKiEventCalc_hpp
#define FpmlSerialized_Excel_targetKiEventCalc_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/Excel_eventCalcInfo.hpp>

namespace FpmlSerialized {

class Excel_targetKiEventCalc : public ISerialized { 
   public: 
       Excel_targetKiEventCalc(TiXmlNode* xmlNode);

       bool isEventDate(){return this->eventDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getEventDate();


       bool isVba_description(){return this->vba_descriptionIsNull_;}
       boost::shared_ptr<XsdTypeToken> getVba_description();


       bool isTargetCount(){return this->targetCountIsNull_;}
       boost::shared_ptr<XsdTypeToken> getTargetCount();


       bool isExcel_eventCalcInfo(){return this->excel_eventCalcInfoIsNull_;}
       boost::shared_ptr<Excel_eventCalcInfo> getExcel_eventCalcInfo();


   protected: 
       boost::shared_ptr<XsdTypeToken> eventDate_;
       
       bool eventDateIsNull_;
       boost::shared_ptr<XsdTypeToken> vba_description_;
       
       bool vba_descriptionIsNull_;
       boost::shared_ptr<XsdTypeToken> targetCount_;
       
       bool targetCountIsNull_;
       boost::shared_ptr<Excel_eventCalcInfo> excel_eventCalcInfo_;
       
       bool excel_eventCalcInfoIsNull_;

};

} //namespaceFpmlSerialized end
#endif

