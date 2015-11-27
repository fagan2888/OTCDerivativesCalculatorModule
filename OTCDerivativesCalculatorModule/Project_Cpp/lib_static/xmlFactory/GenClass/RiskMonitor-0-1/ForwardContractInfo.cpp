// ForwardContractInfo.cpp 
#include "ForwardContractInfo.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ForwardContractInfo::ForwardContractInfo(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //calculationDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calculationDateNode = xmlNode->FirstChildElement("calculationDate");

   if(calculationDateNode){calculationDateIsNull_ = false;}
   else{calculationDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationDateNode , address : " << calculationDateNode << std::endl;
   #endif
   if(calculationDateNode)
   {
       calculationDate_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(calculationDateNode));
   }

   //settlementDaysNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* settlementDaysNode = xmlNode->FirstChildElement("settlementDays");

   if(settlementDaysNode){settlementDaysIsNull_ = false;}
   else{settlementDaysIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settlementDaysNode , address : " << settlementDaysNode << std::endl;
   #endif
   if(settlementDaysNode)
   {
       settlementDays_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(settlementDaysNode));
   }

   //settlementDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* settlementDateNode = xmlNode->FirstChildElement("settlementDate");

   if(settlementDateNode){settlementDateIsNull_ = false;}
   else{settlementDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settlementDateNode , address : " << settlementDateNode << std::endl;
   #endif
   if(settlementDateNode)
   {
       settlementDate_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(settlementDateNode));
   }

   //forwardPointNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* forwardPointNode = xmlNode->FirstChildElement("forwardPoint");

   if(forwardPointNode){forwardPointIsNull_ = false;}
   else{forwardPointIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- forwardPointNode , address : " << forwardPointNode << std::endl;
   #endif
   if(forwardPointNode)
   {
       forwardPoint_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(forwardPointNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> ForwardContractInfo::getCalculationDate()
{
   if(!this->calculationDateIsNull_){
        return this->calculationDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> ForwardContractInfo::getSettlementDays()
{
   if(!this->settlementDaysIsNull_){
        return this->settlementDays_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> ForwardContractInfo::getSettlementDate()
{
   if(!this->settlementDateIsNull_){
        return this->settlementDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> ForwardContractInfo::getForwardPoint()
{
   if(!this->forwardPointIsNull_){
        return this->forwardPoint_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

