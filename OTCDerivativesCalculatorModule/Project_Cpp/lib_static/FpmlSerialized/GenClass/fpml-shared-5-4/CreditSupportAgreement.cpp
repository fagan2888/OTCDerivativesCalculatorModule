// CreditSupportAgreement.cpp 
#include "CreditSupportAgreement.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CreditSupportAgreement::CreditSupportAgreement(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //typeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* typeNode = xmlNode->FirstChildElement("type");

   if(typeNode){typeIsNull_ = false;}
   else{typeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- typeNode , address : " << typeNode << std::endl;
   #endif
   if(typeNode)
   {
      if(typeNode->Attribute("href") || typeNode->Attribute("id"))
      {
          if(typeNode->Attribute("id"))
          {
             typeIDRef_ = typeNode->Attribute("id");
             type_ = boost::shared_ptr<CreditSupportAgreementType>(new CreditSupportAgreementType(typeNode));
             type_->setID(typeIDRef_);
             IDManager::instance().setID(typeIDRef_,type_);
          }
          else if(typeNode->Attribute("href")) { typeIDRef_ = typeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { type_ = boost::shared_ptr<CreditSupportAgreementType>(new CreditSupportAgreementType(typeNode));}
   }

   //dateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dateNode = xmlNode->FirstChildElement("date");

   if(dateNode){dateIsNull_ = false;}
   else{dateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dateNode , address : " << dateNode << std::endl;
   #endif
   if(dateNode)
   {
      if(dateNode->Attribute("href") || dateNode->Attribute("id"))
      {
          if(dateNode->Attribute("id"))
          {
             dateIDRef_ = dateNode->Attribute("id");
             date_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(dateNode));
             date_->setID(dateIDRef_);
             IDManager::instance().setID(dateIDRef_,date_);
          }
          else if(dateNode->Attribute("href")) { dateIDRef_ = dateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { date_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(dateNode));}
   }

   //identifierNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* identifierNode = xmlNode->FirstChildElement("identifier");

   if(identifierNode){identifierIsNull_ = false;}
   else{identifierIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- identifierNode , address : " << identifierNode << std::endl;
   #endif
   if(identifierNode)
   {
      if(identifierNode->Attribute("href") || identifierNode->Attribute("id"))
      {
          if(identifierNode->Attribute("id"))
          {
             identifierIDRef_ = identifierNode->Attribute("id");
             identifier_ = boost::shared_ptr<CreditSupportAgreementIdentifier>(new CreditSupportAgreementIdentifier(identifierNode));
             identifier_->setID(identifierIDRef_);
             IDManager::instance().setID(identifierIDRef_,identifier_);
          }
          else if(identifierNode->Attribute("href")) { identifierIDRef_ = identifierNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { identifier_ = boost::shared_ptr<CreditSupportAgreementIdentifier>(new CreditSupportAgreementIdentifier(identifierNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<CreditSupportAgreementType> CreditSupportAgreement::getType()
{
   if(!this->typeIsNull_){
        if(typeIDRef_ != ""){
             return boost::shared_static_cast<CreditSupportAgreementType>(IDManager::instance().getID(typeIDRef_));
        }else{
             return this->type_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CreditSupportAgreementType>();
   }
}
boost::shared_ptr<XsdTypeDate> CreditSupportAgreement::getDate()
{
   if(!this->dateIsNull_){
        if(dateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(dateIDRef_));
        }else{
             return this->date_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<CreditSupportAgreementIdentifier> CreditSupportAgreement::getIdentifier()
{
   if(!this->identifierIsNull_){
        if(identifierIDRef_ != ""){
             return boost::shared_static_cast<CreditSupportAgreementIdentifier>(IDManager::instance().getID(identifierIDRef_));
        }else{
             return this->identifier_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CreditSupportAgreementIdentifier>();
   }
}
}

