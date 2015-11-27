// RequestMessageHeader.cpp 
#include "RequestMessageHeader.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

RequestMessageHeader::RequestMessageHeader(TiXmlNode* xmlNode)
: MessageHeader(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //sentByNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* sentByNode = xmlNode->FirstChildElement("sentBy");

   if(sentByNode){sentByIsNull_ = false;}
   else{sentByIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- sentByNode , address : " << sentByNode << std::endl;
   #endif
   if(sentByNode)
   {
      if(sentByNode->Attribute("href") || sentByNode->Attribute("id"))
      {
          if(sentByNode->Attribute("id"))
          {
             sentByIDRef_ = sentByNode->Attribute("id");
             sentBy_ = boost::shared_ptr<MessageAddress>(new MessageAddress(sentByNode));
             sentBy_->setID(sentByIDRef_);
             IDManager::instance().setID(sentByIDRef_,sentBy_);
          }
          else if(sentByNode->Attribute("href")) { sentByIDRef_ = sentByNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { sentBy_ = boost::shared_ptr<MessageAddress>(new MessageAddress(sentByNode));}
   }

   //sendToNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* sendToNode = xmlNode->FirstChildElement("sendTo");

   if(sendToNode){sendToIsNull_ = false;}
   else{sendToIsNull_ = true;}

   if(sendToNode)
   {
      for(sendToNode; sendToNode; sendToNode = sendToNode->NextSiblingElement("sendTo")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- sendToNode , address : " << sendToNode << std::endl;
          #endif
          if(sendToNode->Attribute("href") || sendToNode->Attribute("id"))
          {
              if(sendToNode->Attribute("id"))
              {
                  sendToIDRef_ = sendToNode->Attribute("id");
                  sendTo_.push_back(boost::shared_ptr<MessageAddress>(new MessageAddress(sendToNode)));
                  sendTo_.back()->setID(sendToIDRef_);
                  IDManager::instance().setID(sendToIDRef_, sendTo_.back());
              }
              else if(sendToNode->Attribute("href")) { sendToIDRef_ = sendToNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { sendTo_.push_back(boost::shared_ptr<MessageAddress>(new MessageAddress(sendToNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- sendToNode , address : " << sendToNode << std::endl;
       #endif
   }

   //copyToNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* copyToNode = xmlNode->FirstChildElement("copyTo");

   if(copyToNode){copyToIsNull_ = false;}
   else{copyToIsNull_ = true;}

   if(copyToNode)
   {
      for(copyToNode; copyToNode; copyToNode = copyToNode->NextSiblingElement("copyTo")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- copyToNode , address : " << copyToNode << std::endl;
          #endif
          if(copyToNode->Attribute("href") || copyToNode->Attribute("id"))
          {
              if(copyToNode->Attribute("id"))
              {
                  copyToIDRef_ = copyToNode->Attribute("id");
                  copyTo_.push_back(boost::shared_ptr<MessageAddress>(new MessageAddress(copyToNode)));
                  copyTo_.back()->setID(copyToIDRef_);
                  IDManager::instance().setID(copyToIDRef_, copyTo_.back());
              }
              else if(copyToNode->Attribute("href")) { copyToIDRef_ = copyToNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { copyTo_.push_back(boost::shared_ptr<MessageAddress>(new MessageAddress(copyToNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- copyToNode , address : " << copyToNode << std::endl;
       #endif
   }

   //creationTimestampNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* creationTimestampNode = xmlNode->FirstChildElement("creationTimestamp");

   if(creationTimestampNode){creationTimestampIsNull_ = false;}
   else{creationTimestampIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- creationTimestampNode , address : " << creationTimestampNode << std::endl;
   #endif
   if(creationTimestampNode)
   {
      if(creationTimestampNode->Attribute("href") || creationTimestampNode->Attribute("id"))
      {
          if(creationTimestampNode->Attribute("id"))
          {
             creationTimestampIDRef_ = creationTimestampNode->Attribute("id");
             creationTimestamp_ = boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(creationTimestampNode));
             creationTimestamp_->setID(creationTimestampIDRef_);
             IDManager::instance().setID(creationTimestampIDRef_,creationTimestamp_);
          }
          else if(creationTimestampNode->Attribute("href")) { creationTimestampIDRef_ = creationTimestampNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { creationTimestamp_ = boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(creationTimestampNode));}
   }

   //expiryTimestampNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* expiryTimestampNode = xmlNode->FirstChildElement("expiryTimestamp");

   if(expiryTimestampNode){expiryTimestampIsNull_ = false;}
   else{expiryTimestampIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- expiryTimestampNode , address : " << expiryTimestampNode << std::endl;
   #endif
   if(expiryTimestampNode)
   {
      if(expiryTimestampNode->Attribute("href") || expiryTimestampNode->Attribute("id"))
      {
          if(expiryTimestampNode->Attribute("id"))
          {
             expiryTimestampIDRef_ = expiryTimestampNode->Attribute("id");
             expiryTimestamp_ = boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(expiryTimestampNode));
             expiryTimestamp_->setID(expiryTimestampIDRef_);
             IDManager::instance().setID(expiryTimestampIDRef_,expiryTimestamp_);
          }
          else if(expiryTimestampNode->Attribute("href")) { expiryTimestampIDRef_ = expiryTimestampNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { expiryTimestamp_ = boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(expiryTimestampNode));}
   }

   //implementationSpecificationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* implementationSpecificationNode = xmlNode->FirstChildElement("implementationSpecification");

   if(implementationSpecificationNode){implementationSpecificationIsNull_ = false;}
   else{implementationSpecificationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- implementationSpecificationNode , address : " << implementationSpecificationNode << std::endl;
   #endif
   if(implementationSpecificationNode)
   {
      if(implementationSpecificationNode->Attribute("href") || implementationSpecificationNode->Attribute("id"))
      {
          if(implementationSpecificationNode->Attribute("id"))
          {
             implementationSpecificationIDRef_ = implementationSpecificationNode->Attribute("id");
             implementationSpecification_ = boost::shared_ptr<ImplementationSpecification>(new ImplementationSpecification(implementationSpecificationNode));
             implementationSpecification_->setID(implementationSpecificationIDRef_);
             IDManager::instance().setID(implementationSpecificationIDRef_,implementationSpecification_);
          }
          else if(implementationSpecificationNode->Attribute("href")) { implementationSpecificationIDRef_ = implementationSpecificationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { implementationSpecification_ = boost::shared_ptr<ImplementationSpecification>(new ImplementationSpecification(implementationSpecificationNode));}
   }

   //partyMessageInformationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* partyMessageInformationNode = xmlNode->FirstChildElement("partyMessageInformation");

   if(partyMessageInformationNode){partyMessageInformationIsNull_ = false;}
   else{partyMessageInformationIsNull_ = true;}

   if(partyMessageInformationNode)
   {
      for(partyMessageInformationNode; partyMessageInformationNode; partyMessageInformationNode = partyMessageInformationNode->NextSiblingElement("partyMessageInformation")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- partyMessageInformationNode , address : " << partyMessageInformationNode << std::endl;
          #endif
          if(partyMessageInformationNode->Attribute("href") || partyMessageInformationNode->Attribute("id"))
          {
              if(partyMessageInformationNode->Attribute("id"))
              {
                  partyMessageInformationIDRef_ = partyMessageInformationNode->Attribute("id");
                  partyMessageInformation_.push_back(boost::shared_ptr<PartyMessageInformation>(new PartyMessageInformation(partyMessageInformationNode)));
                  partyMessageInformation_.back()->setID(partyMessageInformationIDRef_);
                  IDManager::instance().setID(partyMessageInformationIDRef_, partyMessageInformation_.back());
              }
              else if(partyMessageInformationNode->Attribute("href")) { partyMessageInformationIDRef_ = partyMessageInformationNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { partyMessageInformation_.push_back(boost::shared_ptr<PartyMessageInformation>(new PartyMessageInformation(partyMessageInformationNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- partyMessageInformationNode , address : " << partyMessageInformationNode << std::endl;
       #endif
   }

   //SignatureNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* SignatureNode = xmlNode->FirstChildElement("Signature");

   if(SignatureNode){SignatureIsNull_ = false;}
   else{SignatureIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- SignatureNode , address : " << SignatureNode << std::endl;
   #endif
   if(SignatureNode)
   {
      if(SignatureNode->Attribute("href") || SignatureNode->Attribute("id"))
      {
          if(SignatureNode->Attribute("id"))
          {
             SignatureIDRef_ = SignatureNode->Attribute("id");
             Signature_ = boost::shared_ptr<SignatureType>(new SignatureType(SignatureNode));
             Signature_->setID(SignatureIDRef_);
             IDManager::instance().setID(SignatureIDRef_,Signature_);
          }
          else if(SignatureNode->Attribute("href")) { SignatureIDRef_ = SignatureNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { Signature_ = boost::shared_ptr<SignatureType>(new SignatureType(SignatureNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<MessageAddress> RequestMessageHeader::getSentBy()
{
   if(!this->sentByIsNull_){
        if(sentByIDRef_ != ""){
             return boost::shared_static_cast<MessageAddress>(IDManager::instance().getID(sentByIDRef_));
        }else{
             return this->sentBy_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<MessageAddress>();
   }
}
std::vector<boost::shared_ptr<MessageAddress>> RequestMessageHeader::getSendTo()
{
   if(!this->sendToIsNull_){
        if(sendToIDRef_ != ""){
             return this->sendTo_;
        }else{
             return this->sendTo_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<MessageAddress>>();
   }
}
std::vector<boost::shared_ptr<MessageAddress>> RequestMessageHeader::getCopyTo()
{
   if(!this->copyToIsNull_){
        if(copyToIDRef_ != ""){
             return this->copyTo_;
        }else{
             return this->copyTo_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<MessageAddress>>();
   }
}
boost::shared_ptr<XsdTypeDateTime> RequestMessageHeader::getCreationTimestamp()
{
   if(!this->creationTimestampIsNull_){
        if(creationTimestampIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDateTime>(IDManager::instance().getID(creationTimestampIDRef_));
        }else{
             return this->creationTimestamp_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDateTime>();
   }
}
boost::shared_ptr<XsdTypeDateTime> RequestMessageHeader::getExpiryTimestamp()
{
   if(!this->expiryTimestampIsNull_){
        if(expiryTimestampIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDateTime>(IDManager::instance().getID(expiryTimestampIDRef_));
        }else{
             return this->expiryTimestamp_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDateTime>();
   }
}
boost::shared_ptr<ImplementationSpecification> RequestMessageHeader::getImplementationSpecification()
{
   if(!this->implementationSpecificationIsNull_){
        if(implementationSpecificationIDRef_ != ""){
             return boost::shared_static_cast<ImplementationSpecification>(IDManager::instance().getID(implementationSpecificationIDRef_));
        }else{
             return this->implementationSpecification_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ImplementationSpecification>();
   }
}
std::vector<boost::shared_ptr<PartyMessageInformation>> RequestMessageHeader::getPartyMessageInformation()
{
   if(!this->partyMessageInformationIsNull_){
        if(partyMessageInformationIDRef_ != ""){
             return this->partyMessageInformation_;
        }else{
             return this->partyMessageInformation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<PartyMessageInformation>>();
   }
}
boost::shared_ptr<SignatureType> RequestMessageHeader::getSignature()
{
   if(!this->SignatureIsNull_){
        if(SignatureIDRef_ != ""){
             return boost::shared_static_cast<SignatureType>(IDManager::instance().getID(SignatureIDRef_));
        }else{
             return this->Signature_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<SignatureType>();
   }
}
}

