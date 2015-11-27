// ConvertibleBond.cpp 
#include "ConvertibleBond.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ConvertibleBond::ConvertibleBond(TiXmlNode* xmlNode)
: Bond(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //underlyingEquityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* underlyingEquityNode = xmlNode->FirstChildElement("underlyingEquity");

   if(underlyingEquityNode){underlyingEquityIsNull_ = false;}
   else{underlyingEquityIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- underlyingEquityNode , address : " << underlyingEquityNode << std::endl;
   #endif
   if(underlyingEquityNode)
   {
      if(underlyingEquityNode->Attribute("href") || underlyingEquityNode->Attribute("id"))
      {
          if(underlyingEquityNode->Attribute("id"))
          {
             underlyingEquityIDRef_ = underlyingEquityNode->Attribute("id");
             underlyingEquity_ = boost::shared_ptr<EquityAsset>(new EquityAsset(underlyingEquityNode));
             underlyingEquity_->setID(underlyingEquityIDRef_);
             IDManager::instance().setID(underlyingEquityIDRef_,underlyingEquity_);
          }
          else if(underlyingEquityNode->Attribute("href")) { underlyingEquityIDRef_ = underlyingEquityNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { underlyingEquity_ = boost::shared_ptr<EquityAsset>(new EquityAsset(underlyingEquityNode));}
   }

   //redemptionDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* redemptionDateNode = xmlNode->FirstChildElement("redemptionDate");

   if(redemptionDateNode){redemptionDateIsNull_ = false;}
   else{redemptionDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- redemptionDateNode , address : " << redemptionDateNode << std::endl;
   #endif
   if(redemptionDateNode)
   {
      if(redemptionDateNode->Attribute("href") || redemptionDateNode->Attribute("id"))
      {
          if(redemptionDateNode->Attribute("id"))
          {
             redemptionDateIDRef_ = redemptionDateNode->Attribute("id");
             redemptionDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(redemptionDateNode));
             redemptionDate_->setID(redemptionDateIDRef_);
             IDManager::instance().setID(redemptionDateIDRef_,redemptionDate_);
          }
          else if(redemptionDateNode->Attribute("href")) { redemptionDateIDRef_ = redemptionDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { redemptionDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(redemptionDateNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<EquityAsset> ConvertibleBond::getUnderlyingEquity()
{
   if(!this->underlyingEquityIsNull_){
        if(underlyingEquityIDRef_ != ""){
             return boost::shared_static_cast<EquityAsset>(IDManager::instance().getID(underlyingEquityIDRef_));
        }else{
             return this->underlyingEquity_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EquityAsset>();
   }
}
boost::shared_ptr<XsdTypeDate> ConvertibleBond::getRedemptionDate()
{
   if(!this->redemptionDateIsNull_){
        if(redemptionDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(redemptionDateIDRef_));
        }else{
             return this->redemptionDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
}

