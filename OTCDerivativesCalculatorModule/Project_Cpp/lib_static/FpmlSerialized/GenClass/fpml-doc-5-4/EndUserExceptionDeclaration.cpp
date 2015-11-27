// EndUserExceptionDeclaration.cpp 
#include "EndUserExceptionDeclaration.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

EndUserExceptionDeclaration::EndUserExceptionDeclaration(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //creditDocumentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* creditDocumentNode = xmlNode->FirstChildElement("creditDocument");

   if(creditDocumentNode){creditDocumentIsNull_ = false;}
   else{creditDocumentIsNull_ = true;}

   if(creditDocumentNode)
   {
      for(creditDocumentNode; creditDocumentNode; creditDocumentNode = creditDocumentNode->NextSiblingElement("creditDocument")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- creditDocumentNode , address : " << creditDocumentNode << std::endl;
          #endif
          if(creditDocumentNode->Attribute("href") || creditDocumentNode->Attribute("id"))
          {
              if(creditDocumentNode->Attribute("id"))
              {
                  creditDocumentIDRef_ = creditDocumentNode->Attribute("id");
                  creditDocument_.push_back(boost::shared_ptr<CreditDocument>(new CreditDocument(creditDocumentNode)));
                  creditDocument_.back()->setID(creditDocumentIDRef_);
                  IDManager::instance().setID(creditDocumentIDRef_, creditDocument_.back());
              }
              else if(creditDocumentNode->Attribute("href")) { creditDocumentIDRef_ = creditDocumentNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { creditDocument_.push_back(boost::shared_ptr<CreditDocument>(new CreditDocument(creditDocumentNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- creditDocumentNode , address : " << creditDocumentNode << std::endl;
       #endif
   }

   //organizationCharacteristicNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* organizationCharacteristicNode = xmlNode->FirstChildElement("organizationCharacteristic");

   if(organizationCharacteristicNode){organizationCharacteristicIsNull_ = false;}
   else{organizationCharacteristicIsNull_ = true;}

   if(organizationCharacteristicNode)
   {
      for(organizationCharacteristicNode; organizationCharacteristicNode; organizationCharacteristicNode = organizationCharacteristicNode->NextSiblingElement("organizationCharacteristic")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- organizationCharacteristicNode , address : " << organizationCharacteristicNode << std::endl;
          #endif
          if(organizationCharacteristicNode->Attribute("href") || organizationCharacteristicNode->Attribute("id"))
          {
              if(organizationCharacteristicNode->Attribute("id"))
              {
                  organizationCharacteristicIDRef_ = organizationCharacteristicNode->Attribute("id");
                  organizationCharacteristic_.push_back(boost::shared_ptr<OrganizationCharacteristic>(new OrganizationCharacteristic(organizationCharacteristicNode)));
                  organizationCharacteristic_.back()->setID(organizationCharacteristicIDRef_);
                  IDManager::instance().setID(organizationCharacteristicIDRef_, organizationCharacteristic_.back());
              }
              else if(organizationCharacteristicNode->Attribute("href")) { organizationCharacteristicIDRef_ = organizationCharacteristicNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { organizationCharacteristic_.push_back(boost::shared_ptr<OrganizationCharacteristic>(new OrganizationCharacteristic(organizationCharacteristicNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- organizationCharacteristicNode , address : " << organizationCharacteristicNode << std::endl;
       #endif
   }

   //transactionCharacteristicNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* transactionCharacteristicNode = xmlNode->FirstChildElement("transactionCharacteristic");

   if(transactionCharacteristicNode){transactionCharacteristicIsNull_ = false;}
   else{transactionCharacteristicIsNull_ = true;}

   if(transactionCharacteristicNode)
   {
      for(transactionCharacteristicNode; transactionCharacteristicNode; transactionCharacteristicNode = transactionCharacteristicNode->NextSiblingElement("transactionCharacteristic")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- transactionCharacteristicNode , address : " << transactionCharacteristicNode << std::endl;
          #endif
          if(transactionCharacteristicNode->Attribute("href") || transactionCharacteristicNode->Attribute("id"))
          {
              if(transactionCharacteristicNode->Attribute("id"))
              {
                  transactionCharacteristicIDRef_ = transactionCharacteristicNode->Attribute("id");
                  transactionCharacteristic_.push_back(boost::shared_ptr<TransactionCharacteristic>(new TransactionCharacteristic(transactionCharacteristicNode)));
                  transactionCharacteristic_.back()->setID(transactionCharacteristicIDRef_);
                  IDManager::instance().setID(transactionCharacteristicIDRef_, transactionCharacteristic_.back());
              }
              else if(transactionCharacteristicNode->Attribute("href")) { transactionCharacteristicIDRef_ = transactionCharacteristicNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { transactionCharacteristic_.push_back(boost::shared_ptr<TransactionCharacteristic>(new TransactionCharacteristic(transactionCharacteristicNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- transactionCharacteristicNode , address : " << transactionCharacteristicNode << std::endl;
       #endif
   }

   //supervisorRegistrationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* supervisorRegistrationNode = xmlNode->FirstChildElement("supervisorRegistration");

   if(supervisorRegistrationNode){supervisorRegistrationIsNull_ = false;}
   else{supervisorRegistrationIsNull_ = true;}

   if(supervisorRegistrationNode)
   {
      for(supervisorRegistrationNode; supervisorRegistrationNode; supervisorRegistrationNode = supervisorRegistrationNode->NextSiblingElement("supervisorRegistration")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- supervisorRegistrationNode , address : " << supervisorRegistrationNode << std::endl;
          #endif
          if(supervisorRegistrationNode->Attribute("href") || supervisorRegistrationNode->Attribute("id"))
          {
              if(supervisorRegistrationNode->Attribute("id"))
              {
                  supervisorRegistrationIDRef_ = supervisorRegistrationNode->Attribute("id");
                  supervisorRegistration_.push_back(boost::shared_ptr<SupervisorRegistration>(new SupervisorRegistration(supervisorRegistrationNode)));
                  supervisorRegistration_.back()->setID(supervisorRegistrationIDRef_);
                  IDManager::instance().setID(supervisorRegistrationIDRef_, supervisorRegistration_.back());
              }
              else if(supervisorRegistrationNode->Attribute("href")) { supervisorRegistrationIDRef_ = supervisorRegistrationNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { supervisorRegistration_.push_back(boost::shared_ptr<SupervisorRegistration>(new SupervisorRegistration(supervisorRegistrationNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- supervisorRegistrationNode , address : " << supervisorRegistrationNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<CreditDocument>> EndUserExceptionDeclaration::getCreditDocument()
{
   if(!this->creditDocumentIsNull_){
        if(creditDocumentIDRef_ != ""){
             return this->creditDocument_;
        }else{
             return this->creditDocument_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<CreditDocument>>();
   }
}
std::vector<boost::shared_ptr<OrganizationCharacteristic>> EndUserExceptionDeclaration::getOrganizationCharacteristic()
{
   if(!this->organizationCharacteristicIsNull_){
        if(organizationCharacteristicIDRef_ != ""){
             return this->organizationCharacteristic_;
        }else{
             return this->organizationCharacteristic_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<OrganizationCharacteristic>>();
   }
}
std::vector<boost::shared_ptr<TransactionCharacteristic>> EndUserExceptionDeclaration::getTransactionCharacteristic()
{
   if(!this->transactionCharacteristicIsNull_){
        if(transactionCharacteristicIDRef_ != ""){
             return this->transactionCharacteristic_;
        }else{
             return this->transactionCharacteristic_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<TransactionCharacteristic>>();
   }
}
std::vector<boost::shared_ptr<SupervisorRegistration>> EndUserExceptionDeclaration::getSupervisorRegistration()
{
   if(!this->supervisorRegistrationIsNull_){
        if(supervisorRegistrationIDRef_ != ""){
             return this->supervisorRegistration_;
        }else{
             return this->supervisorRegistration_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<SupervisorRegistration>>();
   }
}
}

