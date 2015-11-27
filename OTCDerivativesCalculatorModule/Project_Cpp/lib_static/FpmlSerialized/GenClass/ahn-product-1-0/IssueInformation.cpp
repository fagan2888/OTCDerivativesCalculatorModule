// IssueInformation.cpp 
#include "IssueInformation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

IssueInformation::IssueInformation(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //productTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* productTypeNode = xmlNode->FirstChildElement("productType");

   if(productTypeNode){productTypeIsNull_ = false;}
   else{productTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- productTypeNode , address : " << productTypeNode << std::endl;
   #endif
   if(productTypeNode)
   {
      if(productTypeNode->Attribute("href") || productTypeNode->Attribute("id"))
      {
          if(productTypeNode->Attribute("id"))
          {
             productTypeIDRef_ = productTypeNode->Attribute("id");
             productType_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(productTypeNode));
             productType_->setID(productTypeIDRef_);
             IDManager::instance().setID(productTypeIDRef_,productType_);
          }
          else if(productTypeNode->Attribute("href")) { productTypeIDRef_ = productTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { productType_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(productTypeNode));}
   }

   //instrumentIDNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* instrumentIDNode = xmlNode->FirstChildElement("instrumentID");

   if(instrumentIDNode){instrumentIDIsNull_ = false;}
   else{instrumentIDIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- instrumentIDNode , address : " << instrumentIDNode << std::endl;
   #endif
   if(instrumentIDNode)
   {
      if(instrumentIDNode->Attribute("href") || instrumentIDNode->Attribute("id"))
      {
          if(instrumentIDNode->Attribute("id"))
          {
             instrumentIDIDRef_ = instrumentIDNode->Attribute("id");
             instrumentID_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(instrumentIDNode));
             instrumentID_->setID(instrumentIDIDRef_);
             IDManager::instance().setID(instrumentIDIDRef_,instrumentID_);
          }
          else if(instrumentIDNode->Attribute("href")) { instrumentIDIDRef_ = instrumentIDNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { instrumentID_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(instrumentIDNode));}
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
      if(notionalNode->Attribute("href") || notionalNode->Attribute("id"))
      {
          if(notionalNode->Attribute("id"))
          {
             notionalIDRef_ = notionalNode->Attribute("id");
             notional_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(notionalNode));
             notional_->setID(notionalIDRef_);
             IDManager::instance().setID(notionalIDRef_,notional_);
          }
          else if(notionalNode->Attribute("href")) { notionalIDRef_ = notionalNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { notional_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(notionalNode));}
   }

   //issueDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* issueDateNode = xmlNode->FirstChildElement("issueDate");

   if(issueDateNode){issueDateIsNull_ = false;}
   else{issueDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- issueDateNode , address : " << issueDateNode << std::endl;
   #endif
   if(issueDateNode)
   {
      if(issueDateNode->Attribute("href") || issueDateNode->Attribute("id"))
      {
          if(issueDateNode->Attribute("id"))
          {
             issueDateIDRef_ = issueDateNode->Attribute("id");
             issueDate_ = boost::shared_ptr<EventDate>(new EventDate(issueDateNode));
             issueDate_->setID(issueDateIDRef_);
             IDManager::instance().setID(issueDateIDRef_,issueDate_);
          }
          else if(issueDateNode->Attribute("href")) { issueDateIDRef_ = issueDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { issueDate_ = boost::shared_ptr<EventDate>(new EventDate(issueDateNode));}
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
      if(maturityDateNode->Attribute("href") || maturityDateNode->Attribute("id"))
      {
          if(maturityDateNode->Attribute("id"))
          {
             maturityDateIDRef_ = maturityDateNode->Attribute("id");
             maturityDate_ = boost::shared_ptr<EventDate>(new EventDate(maturityDateNode));
             maturityDate_->setID(maturityDateIDRef_);
             IDManager::instance().setID(maturityDateIDRef_,maturityDate_);
          }
          else if(maturityDateNode->Attribute("href")) { maturityDateIDRef_ = maturityDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { maturityDate_ = boost::shared_ptr<EventDate>(new EventDate(maturityDateNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> IssueInformation::getProductType()
{
   if(!this->productTypeIsNull_){
        if(productTypeIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeToken>(IDManager::instance().getID(productTypeIDRef_));
        }else{
             return this->productType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> IssueInformation::getInstrumentID()
{
   if(!this->instrumentIDIsNull_){
        if(instrumentIDIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeToken>(IDManager::instance().getID(instrumentIDIDRef_));
        }else{
             return this->instrumentID_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeDecimal> IssueInformation::getNotional()
{
   if(!this->notionalIsNull_){
        if(notionalIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(notionalIDRef_));
        }else{
             return this->notional_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<EventDate> IssueInformation::getIssueDate()
{
   if(!this->issueDateIsNull_){
        if(issueDateIDRef_ != ""){
             return boost::shared_static_cast<EventDate>(IDManager::instance().getID(issueDateIDRef_));
        }else{
             return this->issueDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EventDate>();
   }
}
boost::shared_ptr<EventDate> IssueInformation::getMaturityDate()
{
   if(!this->maturityDateIsNull_){
        if(maturityDateIDRef_ != ""){
             return boost::shared_static_cast<EventDate>(IDManager::instance().getID(maturityDateIDRef_));
        }else{
             return this->maturityDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EventDate>();
   }
}
}

