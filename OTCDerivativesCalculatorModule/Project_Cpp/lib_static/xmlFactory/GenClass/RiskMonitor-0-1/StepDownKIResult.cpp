// StepDownKIResult.cpp 
#include "StepDownKIResult.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

StepDownKIResult::StepDownKIResult(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //underylingInfoResultNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* underylingInfoResultNode = xmlNode->FirstChildElement("underylingInfoResult");

   if(underylingInfoResultNode){underylingInfoResultIsNull_ = false;}
   else{underylingInfoResultIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- underylingInfoResultNode , address : " << underylingInfoResultNode << std::endl;
   #endif
   if(underylingInfoResultNode)
   {
       underylingInfoResult_ = boost::shared_ptr<UnderylingInfoResult>(new UnderylingInfoResult(underylingInfoResultNode));
   }

   //cashFlowInfoResultNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* cashFlowInfoResultNode = xmlNode->FirstChildElement("cashFlowInfoResult");

   if(cashFlowInfoResultNode){cashFlowInfoResultIsNull_ = false;}
   else{cashFlowInfoResultIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- cashFlowInfoResultNode , address : " << cashFlowInfoResultNode << std::endl;
   #endif
   if(cashFlowInfoResultNode)
   {
       cashFlowInfoResult_ = boost::shared_ptr<CashFlowInfoResult>(new CashFlowInfoResult(cashFlowInfoResultNode));
   }

   //thetaNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* thetaNode = xmlNode->FirstChildElement("theta");

   if(thetaNode){thetaIsNull_ = false;}
   else{thetaIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- thetaNode , address : " << thetaNode << std::endl;
   #endif
   if(thetaNode)
   {
       theta_ = boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(thetaNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<UnderylingInfoResult> StepDownKIResult::getUnderylingInfoResult()
{
   if(!this->underylingInfoResultIsNull_){
        return this->underylingInfoResult_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<UnderylingInfoResult>();
   }
}
boost::shared_ptr<CashFlowInfoResult> StepDownKIResult::getCashFlowInfoResult()
{
   if(!this->cashFlowInfoResultIsNull_){
        return this->cashFlowInfoResult_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CashFlowInfoResult>();
   }
}
boost::shared_ptr<XsdTypeDouble> StepDownKIResult::getTheta()
{
   if(!this->thetaIsNull_){
        return this->theta_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDouble>();
   }
}
}

