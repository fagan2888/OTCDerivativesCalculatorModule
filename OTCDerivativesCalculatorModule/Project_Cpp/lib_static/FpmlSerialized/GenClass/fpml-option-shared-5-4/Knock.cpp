// Knock.cpp 
#include "Knock.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Knock::Knock(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //knockInNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* knockInNode = xmlNode->FirstChildElement("knockIn");

   if(knockInNode){knockInIsNull_ = false;}
   else{knockInIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- knockInNode , address : " << knockInNode << std::endl;
   #endif
   if(knockInNode)
   {
      if(knockInNode->Attribute("href") || knockInNode->Attribute("id"))
      {
          if(knockInNode->Attribute("id"))
          {
             knockInIDRef_ = knockInNode->Attribute("id");
             knockIn_ = boost::shared_ptr<TriggerEvent>(new TriggerEvent(knockInNode));
             knockIn_->setID(knockInIDRef_);
             IDManager::instance().setID(knockInIDRef_,knockIn_);
          }
          else if(knockInNode->Attribute("href")) { knockInIDRef_ = knockInNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { knockIn_ = boost::shared_ptr<TriggerEvent>(new TriggerEvent(knockInNode));}
   }

   //knockOutNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* knockOutNode = xmlNode->FirstChildElement("knockOut");

   if(knockOutNode){knockOutIsNull_ = false;}
   else{knockOutIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- knockOutNode , address : " << knockOutNode << std::endl;
   #endif
   if(knockOutNode)
   {
      if(knockOutNode->Attribute("href") || knockOutNode->Attribute("id"))
      {
          if(knockOutNode->Attribute("id"))
          {
             knockOutIDRef_ = knockOutNode->Attribute("id");
             knockOut_ = boost::shared_ptr<TriggerEvent>(new TriggerEvent(knockOutNode));
             knockOut_->setID(knockOutIDRef_);
             IDManager::instance().setID(knockOutIDRef_,knockOut_);
          }
          else if(knockOutNode->Attribute("href")) { knockOutIDRef_ = knockOutNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { knockOut_ = boost::shared_ptr<TriggerEvent>(new TriggerEvent(knockOutNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<TriggerEvent> Knock::getKnockIn()
{
   if(!this->knockInIsNull_){
        if(knockInIDRef_ != ""){
             return boost::shared_static_cast<TriggerEvent>(IDManager::instance().getID(knockInIDRef_));
        }else{
             return this->knockIn_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<TriggerEvent>();
   }
}
boost::shared_ptr<TriggerEvent> Knock::getKnockOut()
{
   if(!this->knockOutIsNull_){
        if(knockOutIDRef_ != ""){
             return boost::shared_static_cast<TriggerEvent>(IDManager::instance().getID(knockOutIDRef_));
        }else{
             return this->knockOut_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<TriggerEvent>();
   }
}
}

