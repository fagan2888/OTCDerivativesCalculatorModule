// DualBarrierEventCal.hpp 
#ifndef FpmlSerialized_DualBarrierEventCal_hpp
#define FpmlSerialized_DualBarrierEventCal_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/DateInformation.hpp>
#include <built_in_type/XsdTypeDouble.hpp>
#include <RiskMonitor-0-1/ReferenceCalculationInfo.hpp>
#include <RiskMonitor-0-1/JointSimpleCalculation.hpp>

namespace FpmlSerialized {

class DualBarrierEventCal : public ISerialized { 
   public: 
       DualBarrierEventCal(TiXmlNode* xmlNode);

       bool isDateInformation(){return this->dateInformationIsNull_;}
       std::vector<boost::shared_ptr<DateInformation>> getDateInformation();


       bool isUpperTrigger(){return this->upperTriggerIsNull_;}
       std::vector<boost::shared_ptr<XsdTypeDouble>> getUpperTrigger();


       bool isLowerTrigger(){return this->lowerTriggerIsNull_;}
       std::vector<boost::shared_ptr<XsdTypeDouble>> getLowerTrigger();


       bool isReferenceCalculationInfo(){return this->referenceCalculationInfoIsNull_;}
       std::vector<boost::shared_ptr<ReferenceCalculationInfo>> getReferenceCalculationInfo();


       bool isJointSimpleCalculation(){return this->jointSimpleCalculationIsNull_;}
       boost::shared_ptr<JointSimpleCalculation> getJointSimpleCalculation();


   protected: 
       std::vector<boost::shared_ptr<DateInformation>> dateInformation_;
       
       bool dateInformationIsNull_;
       std::vector<boost::shared_ptr<XsdTypeDouble>> upperTrigger_;
       
       bool upperTriggerIsNull_;
       std::vector<boost::shared_ptr<XsdTypeDouble>> lowerTrigger_;
       
       bool lowerTriggerIsNull_;
       std::vector<boost::shared_ptr<ReferenceCalculationInfo>> referenceCalculationInfo_;
       
       bool referenceCalculationInfoIsNull_;
       boost::shared_ptr<JointSimpleCalculation> jointSimpleCalculation_;
       
       bool jointSimpleCalculationIsNull_;

};

} //namespaceFpmlSerialized end
#endif

