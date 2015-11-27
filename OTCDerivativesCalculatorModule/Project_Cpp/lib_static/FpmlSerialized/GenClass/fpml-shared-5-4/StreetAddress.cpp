// StreetAddress.cpp 
#include "StreetAddress.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

StreetAddress::StreetAddress(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //streetLineNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* streetLineNode = xmlNode->FirstChildElement("streetLine");

   if(streetLineNode){streetLineIsNull_ = false;}
   else{streetLineIsNull_ = true;}

   if(streetLineNode)
   {
      for(streetLineNode; streetLineNode; streetLineNode = streetLineNode->NextSiblingElement("streetLine")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- streetLineNode , address : " << streetLineNode << std::endl;
          #endif
          if(streetLineNode->Attribute("href") || streetLineNode->Attribute("id"))
          {
              if(streetLineNode->Attribute("id"))
              {
                  streetLineIDRef_ = streetLineNode->Attribute("id");
                  streetLine_.push_back(boost::shared_ptr<XsdTypeString>(new XsdTypeString(streetLineNode)));
                  streetLine_.back()->setID(streetLineIDRef_);
                  IDManager::instance().setID(streetLineIDRef_, streetLine_.back());
              }
              else if(streetLineNode->Attribute("href")) { streetLineIDRef_ = streetLineNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { streetLine_.push_back(boost::shared_ptr<XsdTypeString>(new XsdTypeString(streetLineNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- streetLineNode , address : " << streetLineNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<XsdTypeString>> StreetAddress::getStreetLine()
{
   if(!this->streetLineIsNull_){
        if(streetLineIDRef_ != ""){
             return this->streetLine_;
        }else{
             return this->streetLine_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<XsdTypeString>>();
   }
}
}

