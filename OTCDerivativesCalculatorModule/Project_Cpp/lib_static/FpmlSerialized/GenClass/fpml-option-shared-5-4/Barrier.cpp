// Barrier.cpp 
#include "Barrier.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Barrier::Barrier(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //barrierCapNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* barrierCapNode = xmlNode->FirstChildElement("barrierCap");

   if(barrierCapNode){barrierCapIsNull_ = false;}
   else{barrierCapIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- barrierCapNode , address : " << barrierCapNode << std::endl;
   #endif
   if(barrierCapNode)
   {
      if(barrierCapNode->Attribute("href") || barrierCapNode->Attribute("id"))
      {
          if(barrierCapNode->Attribute("id"))
          {
             barrierCapIDRef_ = barrierCapNode->Attribute("id");
             barrierCap_ = boost::shared_ptr<TriggerEvent>(new TriggerEvent(barrierCapNode));
             barrierCap_->setID(barrierCapIDRef_);
             IDManager::instance().setID(barrierCapIDRef_,barrierCap_);
          }
          else if(barrierCapNode->Attribute("href")) { barrierCapIDRef_ = barrierCapNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { barrierCap_ = boost::shared_ptr<TriggerEvent>(new TriggerEvent(barrierCapNode));}
   }

   //barrierFloorNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* barrierFloorNode = xmlNode->FirstChildElement("barrierFloor");

   if(barrierFloorNode){barrierFloorIsNull_ = false;}
   else{barrierFloorIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- barrierFloorNode , address : " << barrierFloorNode << std::endl;
   #endif
   if(barrierFloorNode)
   {
      if(barrierFloorNode->Attribute("href") || barrierFloorNode->Attribute("id"))
      {
          if(barrierFloorNode->Attribute("id"))
          {
             barrierFloorIDRef_ = barrierFloorNode->Attribute("id");
             barrierFloor_ = boost::shared_ptr<TriggerEvent>(new TriggerEvent(barrierFloorNode));
             barrierFloor_->setID(barrierFloorIDRef_);
             IDManager::instance().setID(barrierFloorIDRef_,barrierFloor_);
          }
          else if(barrierFloorNode->Attribute("href")) { barrierFloorIDRef_ = barrierFloorNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { barrierFloor_ = boost::shared_ptr<TriggerEvent>(new TriggerEvent(barrierFloorNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<TriggerEvent> Barrier::getBarrierCap()
{
   if(!this->barrierCapIsNull_){
        if(barrierCapIDRef_ != ""){
             return boost::shared_static_cast<TriggerEvent>(IDManager::instance().getID(barrierCapIDRef_));
        }else{
             return this->barrierCap_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<TriggerEvent>();
   }
}
boost::shared_ptr<TriggerEvent> Barrier::getBarrierFloor()
{
   if(!this->barrierFloorIsNull_){
        if(barrierFloorIDRef_ != ""){
             return boost::shared_static_cast<TriggerEvent>(IDManager::instance().getID(barrierFloorIDRef_));
        }else{
             return this->barrierFloor_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<TriggerEvent>();
   }
}
}

