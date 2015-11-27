// SwaptionPhysicalSettlement.cpp 
#include "SwaptionPhysicalSettlement.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

SwaptionPhysicalSettlement::SwaptionPhysicalSettlement(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //clearedPhysicalSettlementNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* clearedPhysicalSettlementNode = xmlNode->FirstChildElement("clearedPhysicalSettlement");

   if(clearedPhysicalSettlementNode){clearedPhysicalSettlementIsNull_ = false;}
   else{clearedPhysicalSettlementIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- clearedPhysicalSettlementNode , address : " << clearedPhysicalSettlementNode << std::endl;
   #endif
   if(clearedPhysicalSettlementNode)
   {
      if(clearedPhysicalSettlementNode->Attribute("href") || clearedPhysicalSettlementNode->Attribute("id"))
      {
          if(clearedPhysicalSettlementNode->Attribute("id"))
          {
             clearedPhysicalSettlementIDRef_ = clearedPhysicalSettlementNode->Attribute("id");
             clearedPhysicalSettlement_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(clearedPhysicalSettlementNode));
             clearedPhysicalSettlement_->setID(clearedPhysicalSettlementIDRef_);
             IDManager::instance().setID(clearedPhysicalSettlementIDRef_,clearedPhysicalSettlement_);
          }
          else if(clearedPhysicalSettlementNode->Attribute("href")) { clearedPhysicalSettlementIDRef_ = clearedPhysicalSettlementNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { clearedPhysicalSettlement_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(clearedPhysicalSettlementNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeBoolean> SwaptionPhysicalSettlement::getClearedPhysicalSettlement()
{
   if(!this->clearedPhysicalSettlementIsNull_){
        if(clearedPhysicalSettlementIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(clearedPhysicalSettlementIDRef_));
        }else{
             return this->clearedPhysicalSettlement_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
}

