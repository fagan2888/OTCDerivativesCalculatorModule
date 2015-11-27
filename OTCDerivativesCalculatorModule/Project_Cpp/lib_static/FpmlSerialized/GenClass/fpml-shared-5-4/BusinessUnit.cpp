// BusinessUnit.cpp 
#include "BusinessUnit.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

BusinessUnit::BusinessUnit(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //nameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* nameNode = xmlNode->FirstChildElement("name");

   if(nameNode){nameIsNull_ = false;}
   else{nameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- nameNode , address : " << nameNode << std::endl;
   #endif
   if(nameNode)
   {
      if(nameNode->Attribute("href") || nameNode->Attribute("id"))
      {
          if(nameNode->Attribute("id"))
          {
             nameIDRef_ = nameNode->Attribute("id");
             name_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(nameNode));
             name_->setID(nameIDRef_);
             IDManager::instance().setID(nameIDRef_,name_);
          }
          else if(nameNode->Attribute("href")) { nameIDRef_ = nameNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { name_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(nameNode));}
   }

   //businessUnitIdNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* businessUnitIdNode = xmlNode->FirstChildElement("businessUnitId");

   if(businessUnitIdNode){businessUnitIdIsNull_ = false;}
   else{businessUnitIdIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- businessUnitIdNode , address : " << businessUnitIdNode << std::endl;
   #endif
   if(businessUnitIdNode)
   {
      if(businessUnitIdNode->Attribute("href") || businessUnitIdNode->Attribute("id"))
      {
          if(businessUnitIdNode->Attribute("id"))
          {
             businessUnitIdIDRef_ = businessUnitIdNode->Attribute("id");
             businessUnitId_ = boost::shared_ptr<Unit>(new Unit(businessUnitIdNode));
             businessUnitId_->setID(businessUnitIdIDRef_);
             IDManager::instance().setID(businessUnitIdIDRef_,businessUnitId_);
          }
          else if(businessUnitIdNode->Attribute("href")) { businessUnitIdIDRef_ = businessUnitIdNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { businessUnitId_ = boost::shared_ptr<Unit>(new Unit(businessUnitIdNode));}
   }

   //contactInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* contactInfoNode = xmlNode->FirstChildElement("contactInfo");

   if(contactInfoNode){contactInfoIsNull_ = false;}
   else{contactInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- contactInfoNode , address : " << contactInfoNode << std::endl;
   #endif
   if(contactInfoNode)
   {
      if(contactInfoNode->Attribute("href") || contactInfoNode->Attribute("id"))
      {
          if(contactInfoNode->Attribute("id"))
          {
             contactInfoIDRef_ = contactInfoNode->Attribute("id");
             contactInfo_ = boost::shared_ptr<ContactInformation>(new ContactInformation(contactInfoNode));
             contactInfo_->setID(contactInfoIDRef_);
             IDManager::instance().setID(contactInfoIDRef_,contactInfo_);
          }
          else if(contactInfoNode->Attribute("href")) { contactInfoIDRef_ = contactInfoNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { contactInfo_ = boost::shared_ptr<ContactInformation>(new ContactInformation(contactInfoNode));}
   }

   //countryNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* countryNode = xmlNode->FirstChildElement("country");

   if(countryNode){countryIsNull_ = false;}
   else{countryIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- countryNode , address : " << countryNode << std::endl;
   #endif
   if(countryNode)
   {
      if(countryNode->Attribute("href") || countryNode->Attribute("id"))
      {
          if(countryNode->Attribute("id"))
          {
             countryIDRef_ = countryNode->Attribute("id");
             country_ = boost::shared_ptr<CountryCode>(new CountryCode(countryNode));
             country_->setID(countryIDRef_);
             IDManager::instance().setID(countryIDRef_,country_);
          }
          else if(countryNode->Attribute("href")) { countryIDRef_ = countryNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { country_ = boost::shared_ptr<CountryCode>(new CountryCode(countryNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeString> BusinessUnit::getName()
{
   if(!this->nameIsNull_){
        if(nameIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeString>(IDManager::instance().getID(nameIDRef_));
        }else{
             return this->name_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeString>();
   }
}
boost::shared_ptr<Unit> BusinessUnit::getBusinessUnitId()
{
   if(!this->businessUnitIdIsNull_){
        if(businessUnitIdIDRef_ != ""){
             return boost::shared_static_cast<Unit>(IDManager::instance().getID(businessUnitIdIDRef_));
        }else{
             return this->businessUnitId_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Unit>();
   }
}
boost::shared_ptr<ContactInformation> BusinessUnit::getContactInfo()
{
   if(!this->contactInfoIsNull_){
        if(contactInfoIDRef_ != ""){
             return boost::shared_static_cast<ContactInformation>(IDManager::instance().getID(contactInfoIDRef_));
        }else{
             return this->contactInfo_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ContactInformation>();
   }
}
boost::shared_ptr<CountryCode> BusinessUnit::getCountry()
{
   if(!this->countryIsNull_){
        if(countryIDRef_ != ""){
             return boost::shared_static_cast<CountryCode>(IDManager::instance().getID(countryIDRef_));
        }else{
             return this->country_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CountryCode>();
   }
}
}

