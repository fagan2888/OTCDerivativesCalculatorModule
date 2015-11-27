// SwapStreamPara.cpp 
#include "SwapStreamPara.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

SwapStreamPara::SwapStreamPara(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //notionalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* notionalNode = xmlNode->FirstChildElement("notional");

   if(notionalNode){notionalIsNull_ = false;}
   else{notionalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- notionalNode , address : " << notionalNode << std::endl;
   #endif
   if(notionalNode)
   {
       notional_ = boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(notionalNode));
   }

   //discountCurve_paraNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* discountCurve_paraNode = xmlNode->FirstChildElement("discountCurve_para");

   if(discountCurve_paraNode){discountCurve_paraIsNull_ = false;}
   else{discountCurve_paraIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- discountCurve_paraNode , address : " << discountCurve_paraNode << std::endl;
   #endif
   if(discountCurve_paraNode)
   {
       discountCurve_para_ = boost::shared_ptr<DiscountCurve_para>(new DiscountCurve_para(discountCurve_paraNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDouble> SwapStreamPara::getNotional()
{
   if(!this->notionalIsNull_){
        return this->notional_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDouble>();
   }
}
boost::shared_ptr<DiscountCurve_para> SwapStreamPara::getDiscountCurve_para()
{
   if(!this->discountCurve_paraIsNull_){
        return this->discountCurve_para_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DiscountCurve_para>();
   }
}
}

