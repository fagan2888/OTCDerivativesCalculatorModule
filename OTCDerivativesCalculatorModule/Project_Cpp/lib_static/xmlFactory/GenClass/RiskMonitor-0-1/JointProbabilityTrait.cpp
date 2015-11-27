// JointProbabilityTrait.cpp 
#include "JointProbabilityTrait.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

JointProbabilityTrait::JointProbabilityTrait(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //typeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* typeNode = xmlNode->FirstChildElement("type");

   if(typeNode){typeIsNull_ = false;}
   else{typeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- typeNode , address : " << typeNode << std::endl;
   #endif
   if(typeNode)
   {
       type_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(typeNode));
   }

   //nthDefaultTraitNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* nthDefaultTraitNode = xmlNode->FirstChildElement("nthDefaultTrait");

   if(nthDefaultTraitNode){nthDefaultTraitIsNull_ = false;}
   else{nthDefaultTraitIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- nthDefaultTraitNode , address : " << nthDefaultTraitNode << std::endl;
   #endif
   if(nthDefaultTraitNode)
   {
       nthDefaultTrait_ = boost::shared_ptr<NthDefaultTrait>(new NthDefaultTrait(nthDefaultTraitNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> JointProbabilityTrait::getType()
{
   if(!this->typeIsNull_){
        return this->type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<NthDefaultTrait> JointProbabilityTrait::getNthDefaultTrait()
{
   if(!this->nthDefaultTraitIsNull_){
        return this->nthDefaultTrait_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NthDefaultTrait>();
   }
}
}

