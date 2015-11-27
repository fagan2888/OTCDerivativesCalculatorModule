// JointEventCalculation.cpp 
#include "JointEventCalculation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

JointEventCalculation::JointEventCalculation(TiXmlNode* xmlNode)
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

   //andEventCalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* andEventCalNode = xmlNode->FirstChildElement("andEventCal");

   if(andEventCalNode){andEventCalIsNull_ = false;}
   else{andEventCalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- andEventCalNode , address : " << andEventCalNode << std::endl;
   #endif
   if(andEventCalNode)
   {
       andEventCal_ = boost::shared_ptr<AndEventCal>(new AndEventCal(andEventCalNode));
   }

   //orEventCalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* orEventCalNode = xmlNode->FirstChildElement("orEventCal");

   if(orEventCalNode){orEventCalIsNull_ = false;}
   else{orEventCalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- orEventCalNode , address : " << orEventCalNode << std::endl;
   #endif
   if(orEventCalNode)
   {
       orEventCal_ = boost::shared_ptr<OrEventCal>(new OrEventCal(orEventCalNode));
   }

   //atLeastEventCalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* atLeastEventCalNode = xmlNode->FirstChildElement("atLeastEventCal");

   if(atLeastEventCalNode){atLeastEventCalIsNull_ = false;}
   else{atLeastEventCalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- atLeastEventCalNode , address : " << atLeastEventCalNode << std::endl;
   #endif
   if(atLeastEventCalNode)
   {
       atLeastEventCal_ = boost::shared_ptr<AtLeastEventCal>(new AtLeastEventCal(atLeastEventCalNode));
   }

   //atMostEventCalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* atMostEventCalNode = xmlNode->FirstChildElement("atMostEventCal");

   if(atMostEventCalNode){atMostEventCalIsNull_ = false;}
   else{atMostEventCalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- atMostEventCalNode , address : " << atMostEventCalNode << std::endl;
   #endif
   if(atMostEventCalNode)
   {
       atMostEventCal_ = boost::shared_ptr<AtMostEventCal>(new AtMostEventCal(atMostEventCalNode));
   }

   //countEventCalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* countEventCalNode = xmlNode->FirstChildElement("countEventCal");

   if(countEventCalNode){countEventCalIsNull_ = false;}
   else{countEventCalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- countEventCalNode , address : " << countEventCalNode << std::endl;
   #endif
   if(countEventCalNode)
   {
       countEventCal_ = boost::shared_ptr<CountEventCal>(new CountEventCal(countEventCalNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> JointEventCalculation::getType()
{
   if(!this->typeIsNull_){
        return this->type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<AndEventCal> JointEventCalculation::getAndEventCal()
{
   if(!this->andEventCalIsNull_){
        return this->andEventCal_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AndEventCal>();
   }
}
boost::shared_ptr<OrEventCal> JointEventCalculation::getOrEventCal()
{
   if(!this->orEventCalIsNull_){
        return this->orEventCal_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<OrEventCal>();
   }
}
boost::shared_ptr<AtLeastEventCal> JointEventCalculation::getAtLeastEventCal()
{
   if(!this->atLeastEventCalIsNull_){
        return this->atLeastEventCal_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AtLeastEventCal>();
   }
}
boost::shared_ptr<AtMostEventCal> JointEventCalculation::getAtMostEventCal()
{
   if(!this->atMostEventCalIsNull_){
        return this->atMostEventCal_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AtMostEventCal>();
   }
}
boost::shared_ptr<CountEventCal> JointEventCalculation::getCountEventCal()
{
   if(!this->countEventCalIsNull_){
        return this->countEventCal_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CountEventCal>();
   }
}
}

