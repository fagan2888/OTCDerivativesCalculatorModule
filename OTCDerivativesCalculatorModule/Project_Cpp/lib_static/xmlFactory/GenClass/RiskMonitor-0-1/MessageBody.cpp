// MessageBody.cpp 
#include "MessageBody.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

MessageBody::MessageBody(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //msg_typeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* msg_typeNode = xmlNode->FirstChildElement("msg_type");

   if(msg_typeNode){msg_typeIsNull_ = false;}
   else{msg_typeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- msg_typeNode , address : " << msg_typeNode << std::endl;
   #endif
   if(msg_typeNode)
   {
       msg_type_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(msg_typeNode));
   }

   //maturityNotificationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* maturityNotificationNode = xmlNode->FirstChildElement("maturityNotification");

   if(maturityNotificationNode){maturityNotificationIsNull_ = false;}
   else{maturityNotificationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- maturityNotificationNode , address : " << maturityNotificationNode << std::endl;
   #endif
   if(maturityNotificationNode)
   {
       maturityNotification_ = boost::shared_ptr<MaturityNotification>(new MaturityNotification(maturityNotificationNode));
   }

   //gridCalculationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* gridCalculationNode = xmlNode->FirstChildElement("gridCalculation");

   if(gridCalculationNode){gridCalculationIsNull_ = false;}
   else{gridCalculationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- gridCalculationNode , address : " << gridCalculationNode << std::endl;
   #endif
   if(gridCalculationNode)
   {
       gridCalculation_ = boost::shared_ptr<GridCalculation>(new GridCalculation(gridCalculationNode));
   }

   //clearQueueNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* clearQueueNode = xmlNode->FirstChildElement("clearQueue");

   if(clearQueueNode){clearQueueIsNull_ = false;}
   else{clearQueueIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- clearQueueNode , address : " << clearQueueNode << std::endl;
   #endif
   if(clearQueueNode)
   {
       clearQueue_ = boost::shared_ptr<ClearQueue>(new ClearQueue(clearQueueNode));
   }

   //gridCalculationStartNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* gridCalculationStartNode = xmlNode->FirstChildElement("gridCalculationStart");

   if(gridCalculationStartNode){gridCalculationStartIsNull_ = false;}
   else{gridCalculationStartIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- gridCalculationStartNode , address : " << gridCalculationStartNode << std::endl;
   #endif
   if(gridCalculationStartNode)
   {
       gridCalculationStart_ = boost::shared_ptr<GridCalculationStart>(new GridCalculationStart(gridCalculationStartNode));
   }

   //calculationServerInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calculationServerInfoNode = xmlNode->FirstChildElement("calculationServerInfo");

   if(calculationServerInfoNode){calculationServerInfoIsNull_ = false;}
   else{calculationServerInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationServerInfoNode , address : " << calculationServerInfoNode << std::endl;
   #endif
   if(calculationServerInfoNode)
   {
       calculationServerInfo_ = boost::shared_ptr<CalculationServerInfo>(new CalculationServerInfo(calculationServerInfoNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> MessageBody::getMsg_type()
{
   if(!this->msg_typeIsNull_){
        return this->msg_type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<MaturityNotification> MessageBody::getMaturityNotification()
{
   if(!this->maturityNotificationIsNull_){
        return this->maturityNotification_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<MaturityNotification>();
   }
}
boost::shared_ptr<GridCalculation> MessageBody::getGridCalculation()
{
   if(!this->gridCalculationIsNull_){
        return this->gridCalculation_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<GridCalculation>();
   }
}
boost::shared_ptr<ClearQueue> MessageBody::getClearQueue()
{
   if(!this->clearQueueIsNull_){
        return this->clearQueue_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ClearQueue>();
   }
}
boost::shared_ptr<GridCalculationStart> MessageBody::getGridCalculationStart()
{
   if(!this->gridCalculationStartIsNull_){
        return this->gridCalculationStart_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<GridCalculationStart>();
   }
}
boost::shared_ptr<CalculationServerInfo> MessageBody::getCalculationServerInfo()
{
   if(!this->calculationServerInfoIsNull_){
        return this->calculationServerInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CalculationServerInfo>();
   }
}
}

