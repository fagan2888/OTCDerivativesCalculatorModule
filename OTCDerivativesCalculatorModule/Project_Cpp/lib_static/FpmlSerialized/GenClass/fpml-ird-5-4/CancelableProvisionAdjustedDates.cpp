// CancelableProvisionAdjustedDates.cpp 
#include "CancelableProvisionAdjustedDates.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CancelableProvisionAdjustedDates::CancelableProvisionAdjustedDates(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //cancellationEventNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* cancellationEventNode = xmlNode->FirstChildElement("cancellationEvent");

   if(cancellationEventNode){cancellationEventIsNull_ = false;}
   else{cancellationEventIsNull_ = true;}

   if(cancellationEventNode)
   {
      for(cancellationEventNode; cancellationEventNode; cancellationEventNode = cancellationEventNode->NextSiblingElement("cancellationEvent")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- cancellationEventNode , address : " << cancellationEventNode << std::endl;
          #endif
          if(cancellationEventNode->Attribute("href") || cancellationEventNode->Attribute("id"))
          {
              if(cancellationEventNode->Attribute("id"))
              {
                  cancellationEventIDRef_ = cancellationEventNode->Attribute("id");
                  cancellationEvent_.push_back(boost::shared_ptr<CancellationEvent>(new CancellationEvent(cancellationEventNode)));
                  cancellationEvent_.back()->setID(cancellationEventIDRef_);
                  IDManager::instance().setID(cancellationEventIDRef_, cancellationEvent_.back());
              }
              else if(cancellationEventNode->Attribute("href")) { cancellationEventIDRef_ = cancellationEventNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { cancellationEvent_.push_back(boost::shared_ptr<CancellationEvent>(new CancellationEvent(cancellationEventNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- cancellationEventNode , address : " << cancellationEventNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<CancellationEvent>> CancelableProvisionAdjustedDates::getCancellationEvent()
{
   if(!this->cancellationEventIsNull_){
        if(cancellationEventIDRef_ != ""){
             return this->cancellationEvent_;
        }else{
             return this->cancellationEvent_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<CancellationEvent>>();
   }
}
}

