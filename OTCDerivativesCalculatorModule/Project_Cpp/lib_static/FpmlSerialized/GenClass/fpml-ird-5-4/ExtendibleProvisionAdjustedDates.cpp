// ExtendibleProvisionAdjustedDates.cpp 
#include "ExtendibleProvisionAdjustedDates.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ExtendibleProvisionAdjustedDates::ExtendibleProvisionAdjustedDates(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //extensionEventNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* extensionEventNode = xmlNode->FirstChildElement("extensionEvent");

   if(extensionEventNode){extensionEventIsNull_ = false;}
   else{extensionEventIsNull_ = true;}

   if(extensionEventNode)
   {
      for(extensionEventNode; extensionEventNode; extensionEventNode = extensionEventNode->NextSiblingElement("extensionEvent")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- extensionEventNode , address : " << extensionEventNode << std::endl;
          #endif
          if(extensionEventNode->Attribute("href") || extensionEventNode->Attribute("id"))
          {
              if(extensionEventNode->Attribute("id"))
              {
                  extensionEventIDRef_ = extensionEventNode->Attribute("id");
                  extensionEvent_.push_back(boost::shared_ptr<ExtensionEvent>(new ExtensionEvent(extensionEventNode)));
                  extensionEvent_.back()->setID(extensionEventIDRef_);
                  IDManager::instance().setID(extensionEventIDRef_, extensionEvent_.back());
              }
              else if(extensionEventNode->Attribute("href")) { extensionEventIDRef_ = extensionEventNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { extensionEvent_.push_back(boost::shared_ptr<ExtensionEvent>(new ExtensionEvent(extensionEventNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- extensionEventNode , address : " << extensionEventNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<ExtensionEvent>> ExtendibleProvisionAdjustedDates::getExtensionEvent()
{
   if(!this->extensionEventIsNull_){
        if(extensionEventIDRef_ != ""){
             return this->extensionEvent_;
        }else{
             return this->extensionEvent_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<ExtensionEvent>>();
   }
}
}

