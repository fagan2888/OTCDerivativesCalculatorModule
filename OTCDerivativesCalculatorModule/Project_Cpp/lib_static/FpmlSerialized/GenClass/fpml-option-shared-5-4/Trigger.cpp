// Trigger.cpp 
#include "Trigger.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Trigger::Trigger(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //levelNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* levelNode = xmlNode->FirstChildElement("level");

   if(levelNode){levelIsNull_ = false;}
   else{levelIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- levelNode , address : " << levelNode << std::endl;
   #endif
   if(levelNode)
   {
      if(levelNode->Attribute("href") || levelNode->Attribute("id"))
      {
          if(levelNode->Attribute("id"))
          {
             levelIDRef_ = levelNode->Attribute("id");
             level_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(levelNode));
             level_->setID(levelIDRef_);
             IDManager::instance().setID(levelIDRef_,level_);
          }
          else if(levelNode->Attribute("href")) { levelIDRef_ = levelNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { level_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(levelNode));}
   }

   //levelPercentageNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* levelPercentageNode = xmlNode->FirstChildElement("levelPercentage");

   if(levelPercentageNode){levelPercentageIsNull_ = false;}
   else{levelPercentageIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- levelPercentageNode , address : " << levelPercentageNode << std::endl;
   #endif
   if(levelPercentageNode)
   {
      if(levelPercentageNode->Attribute("href") || levelPercentageNode->Attribute("id"))
      {
          if(levelPercentageNode->Attribute("id"))
          {
             levelPercentageIDRef_ = levelPercentageNode->Attribute("id");
             levelPercentage_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(levelPercentageNode));
             levelPercentage_->setID(levelPercentageIDRef_);
             IDManager::instance().setID(levelPercentageIDRef_,levelPercentage_);
          }
          else if(levelPercentageNode->Attribute("href")) { levelPercentageIDRef_ = levelPercentageNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { levelPercentage_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(levelPercentageNode));}
   }

   //creditEventsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* creditEventsNode = xmlNode->FirstChildElement("creditEvents");

   if(creditEventsNode){creditEventsIsNull_ = false;}
   else{creditEventsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- creditEventsNode , address : " << creditEventsNode << std::endl;
   #endif
   if(creditEventsNode)
   {
      if(creditEventsNode->Attribute("href") || creditEventsNode->Attribute("id"))
      {
          if(creditEventsNode->Attribute("id"))
          {
             creditEventsIDRef_ = creditEventsNode->Attribute("id");
             creditEvents_ = boost::shared_ptr<CreditEvents>(new CreditEvents(creditEventsNode));
             creditEvents_->setID(creditEventsIDRef_);
             IDManager::instance().setID(creditEventsIDRef_,creditEvents_);
          }
          else if(creditEventsNode->Attribute("href")) { creditEventsIDRef_ = creditEventsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { creditEvents_ = boost::shared_ptr<CreditEvents>(new CreditEvents(creditEventsNode));}
   }

   //creditEventsReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* creditEventsReferenceNode = xmlNode->FirstChildElement("creditEventsReference");

   if(creditEventsReferenceNode){creditEventsReferenceIsNull_ = false;}
   else{creditEventsReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- creditEventsReferenceNode , address : " << creditEventsReferenceNode << std::endl;
   #endif
   if(creditEventsReferenceNode)
   {
      if(creditEventsReferenceNode->Attribute("href") || creditEventsReferenceNode->Attribute("id"))
      {
          if(creditEventsReferenceNode->Attribute("id"))
          {
             creditEventsReferenceIDRef_ = creditEventsReferenceNode->Attribute("id");
             creditEventsReference_ = boost::shared_ptr<CreditEventsReference>(new CreditEventsReference(creditEventsReferenceNode));
             creditEventsReference_->setID(creditEventsReferenceIDRef_);
             IDManager::instance().setID(creditEventsReferenceIDRef_,creditEventsReference_);
          }
          else if(creditEventsReferenceNode->Attribute("href")) { creditEventsReferenceIDRef_ = creditEventsReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { creditEventsReference_ = boost::shared_ptr<CreditEventsReference>(new CreditEventsReference(creditEventsReferenceNode));}
   }

   //triggerTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* triggerTypeNode = xmlNode->FirstChildElement("triggerType");

   if(triggerTypeNode){triggerTypeIsNull_ = false;}
   else{triggerTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- triggerTypeNode , address : " << triggerTypeNode << std::endl;
   #endif
   if(triggerTypeNode)
   {
      if(triggerTypeNode->Attribute("href") || triggerTypeNode->Attribute("id"))
      {
          if(triggerTypeNode->Attribute("id"))
          {
             triggerTypeIDRef_ = triggerTypeNode->Attribute("id");
             triggerType_ = boost::shared_ptr<TriggerTypeEnum>(new TriggerTypeEnum(triggerTypeNode));
             triggerType_->setID(triggerTypeIDRef_);
             IDManager::instance().setID(triggerTypeIDRef_,triggerType_);
          }
          else if(triggerTypeNode->Attribute("href")) { triggerTypeIDRef_ = triggerTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { triggerType_ = boost::shared_ptr<TriggerTypeEnum>(new TriggerTypeEnum(triggerTypeNode));}
   }

   //triggerTimeTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* triggerTimeTypeNode = xmlNode->FirstChildElement("triggerTimeType");

   if(triggerTimeTypeNode){triggerTimeTypeIsNull_ = false;}
   else{triggerTimeTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- triggerTimeTypeNode , address : " << triggerTimeTypeNode << std::endl;
   #endif
   if(triggerTimeTypeNode)
   {
      if(triggerTimeTypeNode->Attribute("href") || triggerTimeTypeNode->Attribute("id"))
      {
          if(triggerTimeTypeNode->Attribute("id"))
          {
             triggerTimeTypeIDRef_ = triggerTimeTypeNode->Attribute("id");
             triggerTimeType_ = boost::shared_ptr<TriggerTimeTypeEnum>(new TriggerTimeTypeEnum(triggerTimeTypeNode));
             triggerTimeType_->setID(triggerTimeTypeIDRef_);
             IDManager::instance().setID(triggerTimeTypeIDRef_,triggerTimeType_);
          }
          else if(triggerTimeTypeNode->Attribute("href")) { triggerTimeTypeIDRef_ = triggerTimeTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { triggerTimeType_ = boost::shared_ptr<TriggerTimeTypeEnum>(new TriggerTimeTypeEnum(triggerTimeTypeNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDecimal> Trigger::getLevel()
{
   if(!this->levelIsNull_){
        if(levelIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(levelIDRef_));
        }else{
             return this->level_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<XsdTypeDecimal> Trigger::getLevelPercentage()
{
   if(!this->levelPercentageIsNull_){
        if(levelPercentageIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(levelPercentageIDRef_));
        }else{
             return this->levelPercentage_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<CreditEvents> Trigger::getCreditEvents()
{
   if(!this->creditEventsIsNull_){
        if(creditEventsIDRef_ != ""){
             return boost::shared_static_cast<CreditEvents>(IDManager::instance().getID(creditEventsIDRef_));
        }else{
             return this->creditEvents_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CreditEvents>();
   }
}
boost::shared_ptr<CreditEventsReference> Trigger::getCreditEventsReference()
{
   if(!this->creditEventsReferenceIsNull_){
        if(creditEventsReferenceIDRef_ != ""){
             return boost::shared_static_cast<CreditEventsReference>(IDManager::instance().getID(creditEventsReferenceIDRef_));
        }else{
             return this->creditEventsReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CreditEventsReference>();
   }
}
boost::shared_ptr<TriggerTypeEnum> Trigger::getTriggerType()
{
   if(!this->triggerTypeIsNull_){
        if(triggerTypeIDRef_ != ""){
             return boost::shared_static_cast<TriggerTypeEnum>(IDManager::instance().getID(triggerTypeIDRef_));
        }else{
             return this->triggerType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<TriggerTypeEnum>();
   }
}
boost::shared_ptr<TriggerTimeTypeEnum> Trigger::getTriggerTimeType()
{
   if(!this->triggerTimeTypeIsNull_){
        if(triggerTimeTypeIDRef_ != ""){
             return boost::shared_static_cast<TriggerTimeTypeEnum>(IDManager::instance().getID(triggerTimeTypeIDRef_));
        }else{
             return this->triggerTimeType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<TriggerTimeTypeEnum>();
   }
}
}

