// AbstractEvent.cpp 
#include "AbstractEvent.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

AbstractEvent::AbstractEvent(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //eventIdentifierNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* eventIdentifierNode = xmlNode->FirstChildElement("eventIdentifier");

   if(eventIdentifierNode){eventIdentifierIsNull_ = false;}
   else{eventIdentifierIsNull_ = true;}

   if(eventIdentifierNode)
   {
      for(eventIdentifierNode; eventIdentifierNode; eventIdentifierNode = eventIdentifierNode->NextSiblingElement("eventIdentifier")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- eventIdentifierNode , address : " << eventIdentifierNode << std::endl;
          #endif
          if(eventIdentifierNode->Attribute("href") || eventIdentifierNode->Attribute("id"))
          {
              if(eventIdentifierNode->Attribute("id"))
              {
                  eventIdentifierIDRef_ = eventIdentifierNode->Attribute("id");
                  eventIdentifier_.push_back(boost::shared_ptr<BusinessEventIdentifier>(new BusinessEventIdentifier(eventIdentifierNode)));
                  eventIdentifier_.back()->setID(eventIdentifierIDRef_);
                  IDManager::instance().setID(eventIdentifierIDRef_, eventIdentifier_.back());
              }
              else if(eventIdentifierNode->Attribute("href")) { eventIdentifierIDRef_ = eventIdentifierNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { eventIdentifier_.push_back(boost::shared_ptr<BusinessEventIdentifier>(new BusinessEventIdentifier(eventIdentifierNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- eventIdentifierNode , address : " << eventIdentifierNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<BusinessEventIdentifier>> AbstractEvent::getEventIdentifier()
{
   if(!this->eventIdentifierIsNull_){
        if(eventIdentifierIDRef_ != ""){
             return this->eventIdentifier_;
        }else{
             return this->eventIdentifier_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<BusinessEventIdentifier>>();
   }
}
}

