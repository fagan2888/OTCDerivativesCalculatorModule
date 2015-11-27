// ReferenceEntityInfo_para.hpp 
#ifndef FpmlSerialized_ReferenceEntityInfo_para_hpp
#define FpmlSerialized_ReferenceEntityInfo_para_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/ReferenceCurveList.hpp>
#include <RiskMonitor-0-1/JointProbabilityTrait.hpp>

namespace FpmlSerialized {

class ReferenceEntityInfo_para : public ISerialized { 
   public: 
       ReferenceEntityInfo_para(TiXmlNode* xmlNode);

       bool isReferenceCurveList(){return this->referenceCurveListIsNull_;}
       boost::shared_ptr<ReferenceCurveList> getReferenceCurveList();


       bool isJointProbabilityTrait(){return this->jointProbabilityTraitIsNull_;}
       boost::shared_ptr<JointProbabilityTrait> getJointProbabilityTrait();


   protected: 
       boost::shared_ptr<ReferenceCurveList> referenceCurveList_;
       
       bool referenceCurveListIsNull_;
       boost::shared_ptr<JointProbabilityTrait> jointProbabilityTrait_;
       
       bool jointProbabilityTraitIsNull_;

};

} //namespaceFpmlSerialized end
#endif

