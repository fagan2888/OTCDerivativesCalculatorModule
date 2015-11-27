// UpperBarrierEventCal.hpp 
#ifndef FpmlSerialized_UpperBarrierEventCal_hpp
#define FpmlSerialized_UpperBarrierEventCal_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/DateInformation.hpp>
#include <built_in_type/XsdTypeDouble.hpp>
#include <RiskMonitor-0-1/ReferenceCalculationInfo.hpp>

namespace FpmlSerialized {

class UpperBarrierEventCal : public ISerialized { 
   public: 
       UpperBarrierEventCal(TiXmlNode* xmlNode);

       bool isDateInformation(){return this->dateInformationIsNull_;}
       std::vector<boost::shared_ptr<DateInformation>> getDateInformation();


       bool isUpperTrigger(){return this->upperTriggerIsNull_;}
       std::vector<boost::shared_ptr<XsdTypeDouble>> getUpperTrigger();


       bool isReferenceCalculationInfo(){return this->referenceCalculationInfoIsNull_;}
       boost::shared_ptr<ReferenceCalculationInfo> getReferenceCalculationInfo();


   protected: 
       std::vector<boost::shared_ptr<DateInformation>> dateInformation_;
       
       bool dateInformationIsNull_;
       std::vector<boost::shared_ptr<XsdTypeDouble>> upperTrigger_;
       
       bool upperTriggerIsNull_;
       boost::shared_ptr<ReferenceCalculationInfo> referenceCalculationInfo_;
       
       bool referenceCalculationInfoIsNull_;

};

} //namespaceFpmlSerialized end
#endif

