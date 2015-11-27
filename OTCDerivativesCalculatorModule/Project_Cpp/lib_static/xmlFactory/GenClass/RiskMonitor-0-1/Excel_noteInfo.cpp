// Excel_noteInfo.cpp 
#include "Excel_noteInfo.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_noteInfo::Excel_noteInfo(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //tradeDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* tradeDateNode = xmlNode->FirstChildElement("tradeDate");

   if(tradeDateNode){tradeDateIsNull_ = false;}
   else{tradeDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- tradeDateNode , address : " << tradeDateNode << std::endl;
   #endif
   if(tradeDateNode)
   {
       tradeDate_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(tradeDateNode));
   }

   //effectiveDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* effectiveDateNode = xmlNode->FirstChildElement("effectiveDate");

   if(effectiveDateNode){effectiveDateIsNull_ = false;}
   else{effectiveDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- effectiveDateNode , address : " << effectiveDateNode << std::endl;
   #endif
   if(effectiveDateNode)
   {
       effectiveDate_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(effectiveDateNode));
   }

   //maturityDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* maturityDateNode = xmlNode->FirstChildElement("maturityDate");

   if(maturityDateNode){maturityDateIsNull_ = false;}
   else{maturityDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- maturityDateNode , address : " << maturityDateNode << std::endl;
   #endif
   if(maturityDateNode)
   {
       maturityDate_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(maturityDateNode));
   }

   //notionalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* notionalNode = xmlNode->FirstChildElement("notional");

   if(notionalNode){notionalIsNull_ = false;}
   else{notionalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- notionalNode , address : " << notionalNode << std::endl;
   #endif
   if(notionalNode)
   {
       notional_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(notionalNode));
   }

   //currencyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* currencyNode = xmlNode->FirstChildElement("currency");

   if(currencyNode){currencyIsNull_ = false;}
   else{currencyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- currencyNode , address : " << currencyNode << std::endl;
   #endif
   if(currencyNode)
   {
       currency_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(currencyNode));
   }

   //premiumNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* premiumNode = xmlNode->FirstChildElement("premium");

   if(premiumNode){premiumIsNull_ = false;}
   else{premiumIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- premiumNode , address : " << premiumNode << std::endl;
   #endif
   if(premiumNode)
   {
       premium_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(premiumNode));
   }

   //includeNotionalPaymentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* includeNotionalPaymentNode = xmlNode->FirstChildElement("includeNotionalPayment");

   if(includeNotionalPaymentNode){includeNotionalPaymentIsNull_ = false;}
   else{includeNotionalPaymentIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- includeNotionalPaymentNode , address : " << includeNotionalPaymentNode << std::endl;
   #endif
   if(includeNotionalPaymentNode)
   {
       includeNotionalPayment_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(includeNotionalPaymentNode));
   }

   //vba_descriptionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* vba_descriptionNode = xmlNode->FirstChildElement("vba_description");

   if(vba_descriptionNode){vba_descriptionIsNull_ = false;}
   else{vba_descriptionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- vba_descriptionNode , address : " << vba_descriptionNode << std::endl;
   #endif
   if(vba_descriptionNode)
   {
       vba_description_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(vba_descriptionNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_noteInfo::getTradeDate()
{
   if(!this->tradeDateIsNull_){
        return this->tradeDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_noteInfo::getEffectiveDate()
{
   if(!this->effectiveDateIsNull_){
        return this->effectiveDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_noteInfo::getMaturityDate()
{
   if(!this->maturityDateIsNull_){
        return this->maturityDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_noteInfo::getNotional()
{
   if(!this->notionalIsNull_){
        return this->notional_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_noteInfo::getCurrency()
{
   if(!this->currencyIsNull_){
        return this->currency_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_noteInfo::getPremium()
{
   if(!this->premiumIsNull_){
        return this->premium_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_noteInfo::getIncludeNotionalPayment()
{
   if(!this->includeNotionalPaymentIsNull_){
        return this->includeNotionalPayment_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_noteInfo::getVba_description()
{
   if(!this->vba_descriptionIsNull_){
        return this->vba_description_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

