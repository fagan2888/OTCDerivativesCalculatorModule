// JointSimpleCalculation.cpp 
#include "JointSimpleCalculation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

JointSimpleCalculation::JointSimpleCalculation(TiXmlNode* xmlNode)
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

   //andSimpleCalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* andSimpleCalNode = xmlNode->FirstChildElement("andSimpleCal");

   if(andSimpleCalNode){andSimpleCalIsNull_ = false;}
   else{andSimpleCalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- andSimpleCalNode , address : " << andSimpleCalNode << std::endl;
   #endif
   if(andSimpleCalNode)
   {
       andSimpleCal_ = boost::shared_ptr<AndSimpleCal>(new AndSimpleCal(andSimpleCalNode));
   }

   //singeSimpleCalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* singeSimpleCalNode = xmlNode->FirstChildElement("singeSimpleCal");

   if(singeSimpleCalNode){singeSimpleCalIsNull_ = false;}
   else{singeSimpleCalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- singeSimpleCalNode , address : " << singeSimpleCalNode << std::endl;
   #endif
   if(singeSimpleCalNode)
   {
       singeSimpleCal_ = boost::shared_ptr<SingeSimpleCal>(new SingeSimpleCal(singeSimpleCalNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> JointSimpleCalculation::getType()
{
   if(!this->typeIsNull_){
        return this->type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<AndSimpleCal> JointSimpleCalculation::getAndSimpleCal()
{
   if(!this->andSimpleCalIsNull_){
        return this->andSimpleCal_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AndSimpleCal>();
   }
}
boost::shared_ptr<SingeSimpleCal> JointSimpleCalculation::getSingeSimpleCal()
{
   if(!this->singeSimpleCalIsNull_){
        return this->singeSimpleCal_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<SingeSimpleCal>();
   }
}
}

