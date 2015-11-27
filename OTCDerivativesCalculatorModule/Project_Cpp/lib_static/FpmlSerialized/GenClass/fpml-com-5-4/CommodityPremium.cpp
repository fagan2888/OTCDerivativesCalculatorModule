// CommodityPremium.cpp 
#include "CommodityPremium.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CommodityPremium::CommodityPremium(TiXmlNode* xmlNode)
: NonNegativePayment(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //premiumPerUnitNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* premiumPerUnitNode = xmlNode->FirstChildElement("premiumPerUnit");

   if(premiumPerUnitNode){premiumPerUnitIsNull_ = false;}
   else{premiumPerUnitIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- premiumPerUnitNode , address : " << premiumPerUnitNode << std::endl;
   #endif
   if(premiumPerUnitNode)
   {
      if(premiumPerUnitNode->Attribute("href") || premiumPerUnitNode->Attribute("id"))
      {
          if(premiumPerUnitNode->Attribute("id"))
          {
             premiumPerUnitIDRef_ = premiumPerUnitNode->Attribute("id");
             premiumPerUnit_ = boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(premiumPerUnitNode));
             premiumPerUnit_->setID(premiumPerUnitIDRef_);
             IDManager::instance().setID(premiumPerUnitIDRef_,premiumPerUnit_);
          }
          else if(premiumPerUnitNode->Attribute("href")) { premiumPerUnitIDRef_ = premiumPerUnitNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { premiumPerUnit_ = boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(premiumPerUnitNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<NonNegativeMoney> CommodityPremium::getPremiumPerUnit()
{
   if(!this->premiumPerUnitIsNull_){
        if(premiumPerUnitIDRef_ != ""){
             return boost::shared_static_cast<NonNegativeMoney>(IDManager::instance().getID(premiumPerUnitIDRef_));
        }else{
             return this->premiumPerUnit_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NonNegativeMoney>();
   }
}
}

