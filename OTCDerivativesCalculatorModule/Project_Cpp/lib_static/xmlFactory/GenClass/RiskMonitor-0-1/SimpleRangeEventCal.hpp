// SimpleRangeEventCal.hpp 
#ifndef FpmlSerialized_SimpleRangeEventCal_hpp
#define FpmlSerialized_SimpleRangeEventCal_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/Range1D.hpp>
#include <RiskMonitor-0-1/ReferenceCalculationInfo.hpp>
#include <RiskMonitor-0-1/DateInformation.hpp>
#include <RiskMonitor-0-1/JointSimpleCalculation.hpp>

namespace FpmlSerialized {

class SimpleRangeEventCal : public ISerialized { 
   public: 
       SimpleRangeEventCal(TiXmlNode* xmlNode);

       bool isRange1D(){return this->range1DIsNull_;}
       boost::shared_ptr<Range1D> getRange1D();


       bool isReferenceCalculationInfo(){return this->referenceCalculationInfoIsNull_;}
       boost::shared_ptr<ReferenceCalculationInfo> getReferenceCalculationInfo();


       bool isDateInformation(){return this->dateInformationIsNull_;}
       boost::shared_ptr<DateInformation> getDateInformation();


       bool isJointSimpleCalculation(){return this->jointSimpleCalculationIsNull_;}
       boost::shared_ptr<JointSimpleCalculation> getJointSimpleCalculation();


   protected: 
       boost::shared_ptr<Range1D> range1D_;
       
       bool range1DIsNull_;
       boost::shared_ptr<ReferenceCalculationInfo> referenceCalculationInfo_;
       
       bool referenceCalculationInfoIsNull_;
       boost::shared_ptr<DateInformation> dateInformation_;
       
       bool dateInformationIsNull_;
       boost::shared_ptr<JointSimpleCalculation> jointSimpleCalculation_;
       
       bool jointSimpleCalculationIsNull_;

};

} //namespaceFpmlSerialized end
#endif

