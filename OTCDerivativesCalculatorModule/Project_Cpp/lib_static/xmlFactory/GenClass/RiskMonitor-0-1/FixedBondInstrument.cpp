// FixedBondInstrument.cpp 
#include "FixedBondInstrument.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FixedBondInstrument::FixedBondInstrument(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //bondInformationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* bondInformationNode = xmlNode->FirstChildElement("bondInformation");

   if(bondInformationNode){bondInformationIsNull_ = false;}
   else{bondInformationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- bondInformationNode , address : " << bondInformationNode << std::endl;
   #endif
   if(bondInformationNode)
   {
       bondInformation_ = boost::shared_ptr<BondInformation>(new BondInformation(bondInformationNode));
   }

   //bondCouponInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* bondCouponInfoNode = xmlNode->FirstChildElement("bondCouponInfo");

   if(bondCouponInfoNode){bondCouponInfoIsNull_ = false;}
   else{bondCouponInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- bondCouponInfoNode , address : " << bondCouponInfoNode << std::endl;
   #endif
   if(bondCouponInfoNode)
   {
       bondCouponInfo_ = boost::shared_ptr<BondCouponInfo>(new BondCouponInfo(bondCouponInfoNode));
   }

   //payoffInfoAnalyticNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* payoffInfoAnalyticNode = xmlNode->FirstChildElement("payoffInfoAnalytic");

   if(payoffInfoAnalyticNode){payoffInfoAnalyticIsNull_ = false;}
   else{payoffInfoAnalyticIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- payoffInfoAnalyticNode , address : " << payoffInfoAnalyticNode << std::endl;
   #endif
   if(payoffInfoAnalyticNode)
   {
       payoffInfoAnalytic_ = boost::shared_ptr<PayoffInfoAnalytic>(new PayoffInfoAnalytic(payoffInfoAnalyticNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<BondInformation> FixedBondInstrument::getBondInformation()
{
   if(!this->bondInformationIsNull_){
        return this->bondInformation_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BondInformation>();
   }
}
boost::shared_ptr<BondCouponInfo> FixedBondInstrument::getBondCouponInfo()
{
   if(!this->bondCouponInfoIsNull_){
        return this->bondCouponInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BondCouponInfo>();
   }
}
boost::shared_ptr<PayoffInfoAnalytic> FixedBondInstrument::getPayoffInfoAnalytic()
{
   if(!this->payoffInfoAnalyticIsNull_){
        return this->payoffInfoAnalytic_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PayoffInfoAnalytic>();
   }
}
}

