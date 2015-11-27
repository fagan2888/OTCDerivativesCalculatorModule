// Exception.cpp 
#include "Exception.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Exception::Exception(TiXmlNode* xmlNode)
: Message(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //headerNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* headerNode = xmlNode->FirstChildElement("header");

   if(headerNode){headerIsNull_ = false;}
   else{headerIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- headerNode , address : " << headerNode << std::endl;
   #endif
   if(headerNode)
   {
      if(headerNode->Attribute("href") || headerNode->Attribute("id"))
      {
          if(headerNode->Attribute("id"))
          {
             headerIDRef_ = headerNode->Attribute("id");
             header_ = boost::shared_ptr<ExceptionMessageHeader>(new ExceptionMessageHeader(headerNode));
             header_->setID(headerIDRef_);
             IDManager::instance().setID(headerIDRef_,header_);
          }
          else if(headerNode->Attribute("href")) { headerIDRef_ = headerNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { header_ = boost::shared_ptr<ExceptionMessageHeader>(new ExceptionMessageHeader(headerNode));}
   }

   //validationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* validationNode = xmlNode->FirstChildElement("validation");

   if(validationNode){validationIsNull_ = false;}
   else{validationIsNull_ = true;}

   if(validationNode)
   {
      for(validationNode; validationNode; validationNode = validationNode->NextSiblingElement("validation")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- validationNode , address : " << validationNode << std::endl;
          #endif
          if(validationNode->Attribute("href") || validationNode->Attribute("id"))
          {
              if(validationNode->Attribute("id"))
              {
                  validationIDRef_ = validationNode->Attribute("id");
                  validation_.push_back(boost::shared_ptr<Validation>(new Validation(validationNode)));
                  validation_.back()->setID(validationIDRef_);
                  IDManager::instance().setID(validationIDRef_, validation_.back());
              }
              else if(validationNode->Attribute("href")) { validationIDRef_ = validationNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { validation_.push_back(boost::shared_ptr<Validation>(new Validation(validationNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- validationNode , address : " << validationNode << std::endl;
       #endif
   }

   //parentCorrelationIdNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* parentCorrelationIdNode = xmlNode->FirstChildElement("parentCorrelationId");

   if(parentCorrelationIdNode){parentCorrelationIdIsNull_ = false;}
   else{parentCorrelationIdIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- parentCorrelationIdNode , address : " << parentCorrelationIdNode << std::endl;
   #endif
   if(parentCorrelationIdNode)
   {
      if(parentCorrelationIdNode->Attribute("href") || parentCorrelationIdNode->Attribute("id"))
      {
          if(parentCorrelationIdNode->Attribute("id"))
          {
             parentCorrelationIdIDRef_ = parentCorrelationIdNode->Attribute("id");
             parentCorrelationId_ = boost::shared_ptr<CorrelationId>(new CorrelationId(parentCorrelationIdNode));
             parentCorrelationId_->setID(parentCorrelationIdIDRef_);
             IDManager::instance().setID(parentCorrelationIdIDRef_,parentCorrelationId_);
          }
          else if(parentCorrelationIdNode->Attribute("href")) { parentCorrelationIdIDRef_ = parentCorrelationIdNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { parentCorrelationId_ = boost::shared_ptr<CorrelationId>(new CorrelationId(parentCorrelationIdNode));}
   }

   //correlationIdNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* correlationIdNode = xmlNode->FirstChildElement("correlationId");

   if(correlationIdNode){correlationIdIsNull_ = false;}
   else{correlationIdIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- correlationIdNode , address : " << correlationIdNode << std::endl;
   #endif
   if(correlationIdNode)
   {
      if(correlationIdNode->Attribute("href") || correlationIdNode->Attribute("id"))
      {
          if(correlationIdNode->Attribute("id"))
          {
             correlationIdIDRef_ = correlationIdNode->Attribute("id");
             correlationId_ = boost::shared_ptr<CorrelationId>(new CorrelationId(correlationIdNode));
             correlationId_->setID(correlationIdIDRef_);
             IDManager::instance().setID(correlationIdIDRef_,correlationId_);
          }
          else if(correlationIdNode->Attribute("href")) { correlationIdIDRef_ = correlationIdNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { correlationId_ = boost::shared_ptr<CorrelationId>(new CorrelationId(correlationIdNode));}
   }

   //sequenceNumberNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* sequenceNumberNode = xmlNode->FirstChildElement("sequenceNumber");

   if(sequenceNumberNode){sequenceNumberIsNull_ = false;}
   else{sequenceNumberIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- sequenceNumberNode , address : " << sequenceNumberNode << std::endl;
   #endif
   if(sequenceNumberNode)
   {
      if(sequenceNumberNode->Attribute("href") || sequenceNumberNode->Attribute("id"))
      {
          if(sequenceNumberNode->Attribute("id"))
          {
             sequenceNumberIDRef_ = sequenceNumberNode->Attribute("id");
             sequenceNumber_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(sequenceNumberNode));
             sequenceNumber_->setID(sequenceNumberIDRef_);
             IDManager::instance().setID(sequenceNumberIDRef_,sequenceNumber_);
          }
          else if(sequenceNumberNode->Attribute("href")) { sequenceNumberIDRef_ = sequenceNumberNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { sequenceNumber_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(sequenceNumberNode));}
   }

   //reasonNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* reasonNode = xmlNode->FirstChildElement("reason");

   if(reasonNode){reasonIsNull_ = false;}
   else{reasonIsNull_ = true;}

   if(reasonNode)
   {
      for(reasonNode; reasonNode; reasonNode = reasonNode->NextSiblingElement("reason")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- reasonNode , address : " << reasonNode << std::endl;
          #endif
          if(reasonNode->Attribute("href") || reasonNode->Attribute("id"))
          {
              if(reasonNode->Attribute("id"))
              {
                  reasonIDRef_ = reasonNode->Attribute("id");
                  reason_.push_back(boost::shared_ptr<Reason>(new Reason(reasonNode)));
                  reason_.back()->setID(reasonIDRef_);
                  IDManager::instance().setID(reasonIDRef_, reason_.back());
              }
              else if(reasonNode->Attribute("href")) { reasonIDRef_ = reasonNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { reason_.push_back(boost::shared_ptr<Reason>(new Reason(reasonNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- reasonNode , address : " << reasonNode << std::endl;
       #endif
   }

   //additionalDataNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* additionalDataNode = xmlNode->FirstChildElement("additionalData");

   if(additionalDataNode){additionalDataIsNull_ = false;}
   else{additionalDataIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- additionalDataNode , address : " << additionalDataNode << std::endl;
   #endif
   if(additionalDataNode)
   {
      if(additionalDataNode->Attribute("href") || additionalDataNode->Attribute("id"))
      {
          if(additionalDataNode->Attribute("id"))
          {
             additionalDataIDRef_ = additionalDataNode->Attribute("id");
             additionalData_ = boost::shared_ptr<AdditionalData>(new AdditionalData(additionalDataNode));
             additionalData_->setID(additionalDataIDRef_);
             IDManager::instance().setID(additionalDataIDRef_,additionalData_);
          }
          else if(additionalDataNode->Attribute("href")) { additionalDataIDRef_ = additionalDataNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { additionalData_ = boost::shared_ptr<AdditionalData>(new AdditionalData(additionalDataNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<ExceptionMessageHeader> Exception::getHeader()
{
   if(!this->headerIsNull_){
        if(headerIDRef_ != ""){
             return boost::shared_static_cast<ExceptionMessageHeader>(IDManager::instance().getID(headerIDRef_));
        }else{
             return this->header_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ExceptionMessageHeader>();
   }
}
std::vector<boost::shared_ptr<Validation>> Exception::getValidation()
{
   if(!this->validationIsNull_){
        if(validationIDRef_ != ""){
             return this->validation_;
        }else{
             return this->validation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Validation>>();
   }
}
boost::shared_ptr<CorrelationId> Exception::getParentCorrelationId()
{
   if(!this->parentCorrelationIdIsNull_){
        if(parentCorrelationIdIDRef_ != ""){
             return boost::shared_static_cast<CorrelationId>(IDManager::instance().getID(parentCorrelationIdIDRef_));
        }else{
             return this->parentCorrelationId_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CorrelationId>();
   }
}
boost::shared_ptr<CorrelationId> Exception::getCorrelationId()
{
   if(!this->correlationIdIsNull_){
        if(correlationIdIDRef_ != ""){
             return boost::shared_static_cast<CorrelationId>(IDManager::instance().getID(correlationIdIDRef_));
        }else{
             return this->correlationId_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CorrelationId>();
   }
}
boost::shared_ptr<XsdTypePositiveInteger> Exception::getSequenceNumber()
{
   if(!this->sequenceNumberIsNull_){
        if(sequenceNumberIDRef_ != ""){
             return boost::shared_static_cast<XsdTypePositiveInteger>(IDManager::instance().getID(sequenceNumberIDRef_));
        }else{
             return this->sequenceNumber_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypePositiveInteger>();
   }
}
std::vector<boost::shared_ptr<Reason>> Exception::getReason()
{
   if(!this->reasonIsNull_){
        if(reasonIDRef_ != ""){
             return this->reason_;
        }else{
             return this->reason_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Reason>>();
   }
}
boost::shared_ptr<AdditionalData> Exception::getAdditionalData()
{
   if(!this->additionalDataIsNull_){
        if(additionalDataIDRef_ != ""){
             return boost::shared_static_cast<AdditionalData>(IDManager::instance().getID(additionalDataIDRef_));
        }else{
             return this->additionalData_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdditionalData>();
   }
}
}

