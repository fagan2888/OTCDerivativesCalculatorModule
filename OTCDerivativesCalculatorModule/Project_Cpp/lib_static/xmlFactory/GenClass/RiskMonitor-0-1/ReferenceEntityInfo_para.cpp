// ReferenceEntityInfo_para.cpp 
#include "ReferenceEntityInfo_para.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ReferenceEntityInfo_para::ReferenceEntityInfo_para(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //referenceCurveListNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* referenceCurveListNode = xmlNode->FirstChildElement("referenceCurveList");

   if(referenceCurveListNode){referenceCurveListIsNull_ = false;}
   else{referenceCurveListIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- referenceCurveListNode , address : " << referenceCurveListNode << std::endl;
   #endif
   if(referenceCurveListNode)
   {
       referenceCurveList_ = boost::shared_ptr<ReferenceCurveList>(new ReferenceCurveList(referenceCurveListNode));
   }

   //jointProbabilityTraitNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* jointProbabilityTraitNode = xmlNode->FirstChildElement("jointProbabilityTrait");

   if(jointProbabilityTraitNode){jointProbabilityTraitIsNull_ = false;}
   else{jointProbabilityTraitIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- jointProbabilityTraitNode , address : " << jointProbabilityTraitNode << std::endl;
   #endif
   if(jointProbabilityTraitNode)
   {
       jointProbabilityTrait_ = boost::shared_ptr<JointProbabilityTrait>(new JointProbabilityTrait(jointProbabilityTraitNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<ReferenceCurveList> ReferenceEntityInfo_para::getReferenceCurveList()
{
   if(!this->referenceCurveListIsNull_){
        return this->referenceCurveList_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ReferenceCurveList>();
   }
}
boost::shared_ptr<JointProbabilityTrait> ReferenceEntityInfo_para::getJointProbabilityTrait()
{
   if(!this->jointProbabilityTraitIsNull_){
        return this->jointProbabilityTrait_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<JointProbabilityTrait>();
   }
}
}

