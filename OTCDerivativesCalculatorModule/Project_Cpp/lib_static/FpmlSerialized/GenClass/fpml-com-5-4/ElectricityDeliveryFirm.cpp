// ElectricityDeliveryFirm.cpp 
#include "ElectricityDeliveryFirm.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ElectricityDeliveryFirm::ElectricityDeliveryFirm(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //forceMajeureNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* forceMajeureNode = xmlNode->FirstChildElement("forceMajeure");

   if(forceMajeureNode){forceMajeureIsNull_ = false;}
   else{forceMajeureIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- forceMajeureNode , address : " << forceMajeureNode << std::endl;
   #endif
   if(forceMajeureNode)
   {
      if(forceMajeureNode->Attribute("href") || forceMajeureNode->Attribute("id"))
      {
          if(forceMajeureNode->Attribute("id"))
          {
             forceMajeureIDRef_ = forceMajeureNode->Attribute("id");
             forceMajeure_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(forceMajeureNode));
             forceMajeure_->setID(forceMajeureIDRef_);
             IDManager::instance().setID(forceMajeureIDRef_,forceMajeure_);
          }
          else if(forceMajeureNode->Attribute("href")) { forceMajeureIDRef_ = forceMajeureNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { forceMajeure_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(forceMajeureNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeBoolean> ElectricityDeliveryFirm::getForceMajeure()
{
   if(!this->forceMajeureIsNull_){
        if(forceMajeureIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(forceMajeureIDRef_));
        }else{
             return this->forceMajeure_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
}

