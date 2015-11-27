// OptionalEarlyTerminationAdjustedDates.cpp 
#include "OptionalEarlyTerminationAdjustedDates.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

OptionalEarlyTerminationAdjustedDates::OptionalEarlyTerminationAdjustedDates(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //earlyTerminationEventNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* earlyTerminationEventNode = xmlNode->FirstChildElement("earlyTerminationEvent");

   if(earlyTerminationEventNode){earlyTerminationEventIsNull_ = false;}
   else{earlyTerminationEventIsNull_ = true;}

   if(earlyTerminationEventNode)
   {
      for(earlyTerminationEventNode; earlyTerminationEventNode; earlyTerminationEventNode = earlyTerminationEventNode->NextSiblingElement("earlyTerminationEvent")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- earlyTerminationEventNode , address : " << earlyTerminationEventNode << std::endl;
          #endif
          if(earlyTerminationEventNode->Attribute("href") || earlyTerminationEventNode->Attribute("id"))
          {
              if(earlyTerminationEventNode->Attribute("id"))
              {
                  earlyTerminationEventIDRef_ = earlyTerminationEventNode->Attribute("id");
                  earlyTerminationEvent_.push_back(boost::shared_ptr<EarlyTerminationEvent>(new EarlyTerminationEvent(earlyTerminationEventNode)));
                  earlyTerminationEvent_.back()->setID(earlyTerminationEventIDRef_);
                  IDManager::instance().setID(earlyTerminationEventIDRef_, earlyTerminationEvent_.back());
              }
              else if(earlyTerminationEventNode->Attribute("href")) { earlyTerminationEventIDRef_ = earlyTerminationEventNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { earlyTerminationEvent_.push_back(boost::shared_ptr<EarlyTerminationEvent>(new EarlyTerminationEvent(earlyTerminationEventNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- earlyTerminationEventNode , address : " << earlyTerminationEventNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<EarlyTerminationEvent>> OptionalEarlyTerminationAdjustedDates::getEarlyTerminationEvent()
{
   if(!this->earlyTerminationEventIsNull_){
        if(earlyTerminationEventIDRef_ != ""){
             return this->earlyTerminationEvent_;
        }else{
             return this->earlyTerminationEvent_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<EarlyTerminationEvent>>();
   }
}
}

