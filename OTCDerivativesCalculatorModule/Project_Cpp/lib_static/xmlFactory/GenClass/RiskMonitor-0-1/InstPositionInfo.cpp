// InstPositionInfo.cpp 
#include "InstPositionInfo.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

InstPositionInfo::InstPositionInfo(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //krCodeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* krCodeNode = xmlNode->FirstChildElement("krCode");

   if(krCodeNode){krCodeIsNull_ = false;}
   else{krCodeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- krCodeNode , address : " << krCodeNode << std::endl;
   #endif
   if(krCodeNode)
   {
       krCode_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(krCodeNode));
   }

   //instNameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* instNameNode = xmlNode->FirstChildElement("instName");

   if(instNameNode){instNameIsNull_ = false;}
   else{instNameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- instNameNode , address : " << instNameNode << std::endl;
   #endif
   if(instNameNode)
   {
       instName_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(instNameNode));
   }

   //instCodeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* instCodeNode = xmlNode->FirstChildElement("instCode");

   if(instCodeNode){instCodeIsNull_ = false;}
   else{instCodeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- instCodeNode , address : " << instCodeNode << std::endl;
   #endif
   if(instCodeNode)
   {
       instCode_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(instCodeNode));
   }

   //instTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* instTypeNode = xmlNode->FirstChildElement("instType");

   if(instTypeNode){instTypeIsNull_ = false;}
   else{instTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- instTypeNode , address : " << instTypeNode << std::endl;
   #endif
   if(instTypeNode)
   {
       instType_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(instTypeNode));
   }

   //bookedDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* bookedDateNode = xmlNode->FirstChildElement("bookedDate");

   if(bookedDateNode){bookedDateIsNull_ = false;}
   else{bookedDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- bookedDateNode , address : " << bookedDateNode << std::endl;
   #endif
   if(bookedDateNode)
   {
       bookedDate_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(bookedDateNode));
   }

   //unBookedDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* unBookedDateNode = xmlNode->FirstChildElement("unBookedDate");

   if(unBookedDateNode){unBookedDateIsNull_ = false;}
   else{unBookedDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- unBookedDateNode , address : " << unBookedDateNode << std::endl;
   #endif
   if(unBookedDateNode)
   {
       unBookedDate_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(unBookedDateNode));
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

   //fileNameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fileNameNode = xmlNode->FirstChildElement("fileName");

   if(fileNameNode){fileNameIsNull_ = false;}
   else{fileNameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fileNameNode , address : " << fileNameNode << std::endl;
   #endif
   if(fileNameNode)
   {
       fileName_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(fileNameNode));
   }

   //positionNameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* positionNameNode = xmlNode->FirstChildElement("positionName");

   if(positionNameNode){positionNameIsNull_ = false;}
   else{positionNameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- positionNameNode , address : " << positionNameNode << std::endl;
   #endif
   if(positionNameNode)
   {
       positionName_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(positionNameNode));
   }

   //counterPartyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* counterPartyNode = xmlNode->FirstChildElement("counterParty");

   if(counterPartyNode){counterPartyIsNull_ = false;}
   else{counterPartyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- counterPartyNode , address : " << counterPartyNode << std::endl;
   #endif
   if(counterPartyNode)
   {
       counterParty_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(counterPartyNode));
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

   //fundCodeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fundCodeNode = xmlNode->FirstChildElement("fundCode");

   if(fundCodeNode){fundCodeIsNull_ = false;}
   else{fundCodeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fundCodeNode , address : " << fundCodeNode << std::endl;
   #endif
   if(fundCodeNode)
   {
       fundCode_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(fundCodeNode));
   }

   //fundNameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fundNameNode = xmlNode->FirstChildElement("fundName");

   if(fundNameNode){fundNameIsNull_ = false;}
   else{fundNameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fundNameNode , address : " << fundNameNode << std::endl;
   #endif
   if(fundNameNode)
   {
       fundName_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(fundNameNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> InstPositionInfo::getKrCode()
{
   if(!this->krCodeIsNull_){
        return this->krCode_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> InstPositionInfo::getInstName()
{
   if(!this->instNameIsNull_){
        return this->instName_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> InstPositionInfo::getInstCode()
{
   if(!this->instCodeIsNull_){
        return this->instCode_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> InstPositionInfo::getInstType()
{
   if(!this->instTypeIsNull_){
        return this->instType_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> InstPositionInfo::getBookedDate()
{
   if(!this->bookedDateIsNull_){
        return this->bookedDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> InstPositionInfo::getUnBookedDate()
{
   if(!this->unBookedDateIsNull_){
        return this->unBookedDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> InstPositionInfo::getMaturityDate()
{
   if(!this->maturityDateIsNull_){
        return this->maturityDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> InstPositionInfo::getFileName()
{
   if(!this->fileNameIsNull_){
        return this->fileName_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> InstPositionInfo::getPositionName()
{
   if(!this->positionNameIsNull_){
        return this->positionName_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> InstPositionInfo::getCounterParty()
{
   if(!this->counterPartyIsNull_){
        return this->counterParty_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> InstPositionInfo::getNotional()
{
   if(!this->notionalIsNull_){
        return this->notional_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> InstPositionInfo::getCurrency()
{
   if(!this->currencyIsNull_){
        return this->currency_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> InstPositionInfo::getFundCode()
{
   if(!this->fundCodeIsNull_){
        return this->fundCode_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> InstPositionInfo::getFundName()
{
   if(!this->fundNameIsNull_){
        return this->fundName_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

