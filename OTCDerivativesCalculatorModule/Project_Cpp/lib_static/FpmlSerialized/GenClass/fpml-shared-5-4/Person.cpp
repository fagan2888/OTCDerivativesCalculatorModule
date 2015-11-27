// Person.cpp 
#include "Person.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Person::Person(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //honorificNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* honorificNode = xmlNode->FirstChildElement("honorific");

   if(honorificNode){honorificIsNull_ = false;}
   else{honorificIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- honorificNode , address : " << honorificNode << std::endl;
   #endif
   if(honorificNode)
   {
      if(honorificNode->Attribute("href") || honorificNode->Attribute("id"))
      {
          if(honorificNode->Attribute("id"))
          {
             honorificIDRef_ = honorificNode->Attribute("id");
             honorific_ = boost::shared_ptr<XsdTypeNormalizedString>(new XsdTypeNormalizedString(honorificNode));
             honorific_->setID(honorificIDRef_);
             IDManager::instance().setID(honorificIDRef_,honorific_);
          }
          else if(honorificNode->Attribute("href")) { honorificIDRef_ = honorificNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { honorific_ = boost::shared_ptr<XsdTypeNormalizedString>(new XsdTypeNormalizedString(honorificNode));}
   }

   //firstNameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* firstNameNode = xmlNode->FirstChildElement("firstName");

   if(firstNameNode){firstNameIsNull_ = false;}
   else{firstNameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- firstNameNode , address : " << firstNameNode << std::endl;
   #endif
   if(firstNameNode)
   {
      if(firstNameNode->Attribute("href") || firstNameNode->Attribute("id"))
      {
          if(firstNameNode->Attribute("id"))
          {
             firstNameIDRef_ = firstNameNode->Attribute("id");
             firstName_ = boost::shared_ptr<XsdTypeNormalizedString>(new XsdTypeNormalizedString(firstNameNode));
             firstName_->setID(firstNameIDRef_);
             IDManager::instance().setID(firstNameIDRef_,firstName_);
          }
          else if(firstNameNode->Attribute("href")) { firstNameIDRef_ = firstNameNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { firstName_ = boost::shared_ptr<XsdTypeNormalizedString>(new XsdTypeNormalizedString(firstNameNode));}
   }

   //middleNameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* middleNameNode = xmlNode->FirstChildElement("middleName");

   if(middleNameNode){middleNameIsNull_ = false;}
   else{middleNameIsNull_ = true;}

   if(middleNameNode)
   {
      for(middleNameNode; middleNameNode; middleNameNode = middleNameNode->NextSiblingElement("middleName")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- middleNameNode , address : " << middleNameNode << std::endl;
          #endif
          if(middleNameNode->Attribute("href") || middleNameNode->Attribute("id"))
          {
              if(middleNameNode->Attribute("id"))
              {
                  middleNameIDRef_ = middleNameNode->Attribute("id");
                  middleName_.push_back(boost::shared_ptr<XsdTypeNormalizedString>(new XsdTypeNormalizedString(middleNameNode)));
                  middleName_.back()->setID(middleNameIDRef_);
                  IDManager::instance().setID(middleNameIDRef_, middleName_.back());
              }
              else if(middleNameNode->Attribute("href")) { middleNameIDRef_ = middleNameNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { middleName_.push_back(boost::shared_ptr<XsdTypeNormalizedString>(new XsdTypeNormalizedString(middleNameNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- middleNameNode , address : " << middleNameNode << std::endl;
       #endif
   }

   //initialNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* initialNode = xmlNode->FirstChildElement("initial");

   if(initialNode){initialIsNull_ = false;}
   else{initialIsNull_ = true;}

   if(initialNode)
   {
      for(initialNode; initialNode; initialNode = initialNode->NextSiblingElement("initial")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- initialNode , address : " << initialNode << std::endl;
          #endif
          if(initialNode->Attribute("href") || initialNode->Attribute("id"))
          {
              if(initialNode->Attribute("id"))
              {
                  initialIDRef_ = initialNode->Attribute("id");
                  initial_.push_back(boost::shared_ptr<Initial>(new Initial(initialNode)));
                  initial_.back()->setID(initialIDRef_);
                  IDManager::instance().setID(initialIDRef_, initial_.back());
              }
              else if(initialNode->Attribute("href")) { initialIDRef_ = initialNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { initial_.push_back(boost::shared_ptr<Initial>(new Initial(initialNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- initialNode , address : " << initialNode << std::endl;
       #endif
   }

   //surnameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* surnameNode = xmlNode->FirstChildElement("surname");

   if(surnameNode){surnameIsNull_ = false;}
   else{surnameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- surnameNode , address : " << surnameNode << std::endl;
   #endif
   if(surnameNode)
   {
      if(surnameNode->Attribute("href") || surnameNode->Attribute("id"))
      {
          if(surnameNode->Attribute("id"))
          {
             surnameIDRef_ = surnameNode->Attribute("id");
             surname_ = boost::shared_ptr<XsdTypeNormalizedString>(new XsdTypeNormalizedString(surnameNode));
             surname_->setID(surnameIDRef_);
             IDManager::instance().setID(surnameIDRef_,surname_);
          }
          else if(surnameNode->Attribute("href")) { surnameIDRef_ = surnameNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { surname_ = boost::shared_ptr<XsdTypeNormalizedString>(new XsdTypeNormalizedString(surnameNode));}
   }

   //suffixNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* suffixNode = xmlNode->FirstChildElement("suffix");

   if(suffixNode){suffixIsNull_ = false;}
   else{suffixIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- suffixNode , address : " << suffixNode << std::endl;
   #endif
   if(suffixNode)
   {
      if(suffixNode->Attribute("href") || suffixNode->Attribute("id"))
      {
          if(suffixNode->Attribute("id"))
          {
             suffixIDRef_ = suffixNode->Attribute("id");
             suffix_ = boost::shared_ptr<XsdTypeNormalizedString>(new XsdTypeNormalizedString(suffixNode));
             suffix_->setID(suffixIDRef_);
             IDManager::instance().setID(suffixIDRef_,suffix_);
          }
          else if(suffixNode->Attribute("href")) { suffixIDRef_ = suffixNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { suffix_ = boost::shared_ptr<XsdTypeNormalizedString>(new XsdTypeNormalizedString(suffixNode));}
   }

   //personIdNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* personIdNode = xmlNode->FirstChildElement("personId");

   if(personIdNode){personIdIsNull_ = false;}
   else{personIdIsNull_ = true;}

   if(personIdNode)
   {
      for(personIdNode; personIdNode; personIdNode = personIdNode->NextSiblingElement("personId")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- personIdNode , address : " << personIdNode << std::endl;
          #endif
          if(personIdNode->Attribute("href") || personIdNode->Attribute("id"))
          {
              if(personIdNode->Attribute("id"))
              {
                  personIdIDRef_ = personIdNode->Attribute("id");
                  personId_.push_back(boost::shared_ptr<PersonId>(new PersonId(personIdNode)));
                  personId_.back()->setID(personIdIDRef_);
                  IDManager::instance().setID(personIdIDRef_, personId_.back());
              }
              else if(personIdNode->Attribute("href")) { personIdIDRef_ = personIdNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { personId_.push_back(boost::shared_ptr<PersonId>(new PersonId(personIdNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- personIdNode , address : " << personIdNode << std::endl;
       #endif
   }

   //businessUnitReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* businessUnitReferenceNode = xmlNode->FirstChildElement("businessUnitReference");

   if(businessUnitReferenceNode){businessUnitReferenceIsNull_ = false;}
   else{businessUnitReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- businessUnitReferenceNode , address : " << businessUnitReferenceNode << std::endl;
   #endif
   if(businessUnitReferenceNode)
   {
      if(businessUnitReferenceNode->Attribute("href") || businessUnitReferenceNode->Attribute("id"))
      {
          if(businessUnitReferenceNode->Attribute("id"))
          {
             businessUnitReferenceIDRef_ = businessUnitReferenceNode->Attribute("id");
             businessUnitReference_ = boost::shared_ptr<BusinessUnitReference>(new BusinessUnitReference(businessUnitReferenceNode));
             businessUnitReference_->setID(businessUnitReferenceIDRef_);
             IDManager::instance().setID(businessUnitReferenceIDRef_,businessUnitReference_);
          }
          else if(businessUnitReferenceNode->Attribute("href")) { businessUnitReferenceIDRef_ = businessUnitReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { businessUnitReference_ = boost::shared_ptr<BusinessUnitReference>(new BusinessUnitReference(businessUnitReferenceNode));}
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
boost::shared_ptr<XsdTypeNormalizedString> Person::getHonorific()
{
   if(!this->honorificIsNull_){
        if(honorificIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeNormalizedString>(IDManager::instance().getID(honorificIDRef_));
        }else{
             return this->honorific_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeNormalizedString>();
   }
}
boost::shared_ptr<XsdTypeNormalizedString> Person::getFirstName()
{
   if(!this->firstNameIsNull_){
        if(firstNameIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeNormalizedString>(IDManager::instance().getID(firstNameIDRef_));
        }else{
             return this->firstName_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeNormalizedString>();
   }
}
std::vector<boost::shared_ptr<XsdTypeNormalizedString>> Person::getMiddleName()
{
   if(!this->middleNameIsNull_){
        if(middleNameIDRef_ != ""){
             return this->middleName_;
        }else{
             return this->middleName_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<XsdTypeNormalizedString>>();
   }
}
std::vector<boost::shared_ptr<Initial>> Person::getInitial()
{
   if(!this->initialIsNull_){
        if(initialIDRef_ != ""){
             return this->initial_;
        }else{
             return this->initial_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Initial>>();
   }
}
boost::shared_ptr<XsdTypeNormalizedString> Person::getSurname()
{
   if(!this->surnameIsNull_){
        if(surnameIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeNormalizedString>(IDManager::instance().getID(surnameIDRef_));
        }else{
             return this->surname_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeNormalizedString>();
   }
}
boost::shared_ptr<XsdTypeNormalizedString> Person::getSuffix()
{
   if(!this->suffixIsNull_){
        if(suffixIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeNormalizedString>(IDManager::instance().getID(suffixIDRef_));
        }else{
             return this->suffix_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeNormalizedString>();
   }
}
std::vector<boost::shared_ptr<PersonId>> Person::getPersonId()
{
   if(!this->personIdIsNull_){
        if(personIdIDRef_ != ""){
             return this->personId_;
        }else{
             return this->personId_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<PersonId>>();
   }
}
boost::shared_ptr<BusinessUnitReference> Person::getBusinessUnitReference()
{
   if(!this->businessUnitReferenceIsNull_){
        if(businessUnitReferenceIDRef_ != ""){
             return boost::shared_static_cast<BusinessUnitReference>(IDManager::instance().getID(businessUnitReferenceIDRef_));
        }else{
             return this->businessUnitReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BusinessUnitReference>();
   }
}
boost::shared_ptr<ContactInformation> Person::getContactInfo()
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
boost::shared_ptr<CountryCode> Person::getCountry()
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

