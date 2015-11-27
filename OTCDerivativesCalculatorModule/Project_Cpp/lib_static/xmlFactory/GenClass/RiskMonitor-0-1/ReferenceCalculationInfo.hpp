// ReferenceCalculationInfo.hpp 
#ifndef FpmlSerialized_ReferenceCalculationInfo_hpp
#define FpmlSerialized_ReferenceCalculationInfo_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/FixingInformation.hpp>
#include <RiskMonitor-0-1/ReferenceCalculation.hpp>
#include <RiskMonitor-0-1/OperatorND.hpp>
#include <RiskMonitor-0-1/PostCalculation.hpp>
#include <RiskMonitor-0-1/RefVariable_referenceValue.hpp>

namespace FpmlSerialized {

class ReferenceCalculationInfo : public ISerialized { 
   public: 
       ReferenceCalculationInfo(TiXmlNode* xmlNode);

       bool isFixingInformation(){return this->fixingInformationIsNull_;}
       boost::shared_ptr<FixingInformation> getFixingInformation();


       bool isReferenceCalculation(){return this->referenceCalculationIsNull_;}
       std::vector<boost::shared_ptr<ReferenceCalculation>> getReferenceCalculation();


       bool isOperatorND(){return this->operatorNDIsNull_;}
       boost::shared_ptr<OperatorND> getOperatorND();


       bool isPostCalculation(){return this->postCalculationIsNull_;}
       boost::shared_ptr<PostCalculation> getPostCalculation();


       bool isRefVariable_referenceValue(){return this->refVariable_referenceValueIsNull_;}
       boost::shared_ptr<RefVariable_referenceValue> getRefVariable_referenceValue();


   protected: 
       boost::shared_ptr<FixingInformation> fixingInformation_;
       
       bool fixingInformationIsNull_;
       std::vector<boost::shared_ptr<ReferenceCalculation>> referenceCalculation_;
       
       bool referenceCalculationIsNull_;
       boost::shared_ptr<OperatorND> operatorND_;
       
       bool operatorNDIsNull_;
       boost::shared_ptr<PostCalculation> postCalculation_;
       
       bool postCalculationIsNull_;
       boost::shared_ptr<RefVariable_referenceValue> refVariable_referenceValue_;
       
       bool refVariable_referenceValueIsNull_;

};

} //namespaceFpmlSerialized end
#endif

