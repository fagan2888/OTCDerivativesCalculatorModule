// ContactInformation.cpp 
#include "ContactInformation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ContactInformation::ContactInformation(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //telephoneNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* telephoneNode = xmlNode->FirstChildElement("telephone");

   if(telephoneNode){telephoneIsNull_ = false;}
   else{telephoneIsNull_ = true;}

   if(telephoneNode)
   {
      for(telephoneNode; telephoneNode; telephoneNode = telephoneNode->NextSiblingElement("telephone")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- telephoneNode , address : " << telephoneNode << std::endl;
          #endif
          if(telephoneNode->Attribute("href") || telephoneNode->Attribute("id"))
          {
              if(telephoneNode->Attribute("id"))
              {
                  telephoneIDRef_ = telephoneNode->Attribute("id");
                  telephone_.push_back(boost::shared_ptr<TelephoneNumber>(new TelephoneNumber(telephoneNode)));
                  telephone_.back()->setID(telephoneIDRef_);
                  IDManager::instance().setID(telephoneIDRef_, telephone_.back());
              }
              else if(telephoneNode->Attribute("href")) { telephoneIDRef_ = telephoneNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { telephone_.push_back(boost::shared_ptr<TelephoneNumber>(new TelephoneNumber(telephoneNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- telephoneNode , address : " << telephoneNode << std::endl;
       #endif
   }

   //emailNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* emailNode = xmlNode->FirstChildElement("email");

   if(emailNode){emailIsNull_ = false;}
   else{emailIsNull_ = true;}

   if(emailNode)
   {
      for(emailNode; emailNode; emailNode = emailNode->NextSiblingElement("email")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- emailNode , address : " << emailNode << std::endl;
          #endif
          if(emailNode->Attribute("href") || emailNode->Attribute("id"))
          {
              if(emailNode->Attribute("id"))
              {
                  emailIDRef_ = emailNode->Attribute("id");
                  email_.push_back(boost::shared_ptr<XsdTypeNormalizedString>(new XsdTypeNormalizedString(emailNode)));
                  email_.back()->setID(emailIDRef_);
                  IDManager::instance().setID(emailIDRef_, email_.back());
              }
              else if(emailNode->Attribute("href")) { emailIDRef_ = emailNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { email_.push_back(boost::shared_ptr<XsdTypeNormalizedString>(new XsdTypeNormalizedString(emailNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- emailNode , address : " << emailNode << std::endl;
       #endif
   }

   //addressNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* addressNode = xmlNode->FirstChildElement("address");

   if(addressNode){addressIsNull_ = false;}
   else{addressIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- addressNode , address : " << addressNode << std::endl;
   #endif
   if(addressNode)
   {
      if(addressNode->Attribute("href") || addressNode->Attribute("id"))
      {
          if(addressNode->Attribute("id"))
          {
             addressIDRef_ = addressNode->Attribute("id");
             address_ = boost::shared_ptr<Address>(new Address(addressNode));
             address_->setID(addressIDRef_);
             IDManager::instance().setID(addressIDRef_,address_);
          }
          else if(addressNode->Attribute("href")) { addressIDRef_ = addressNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { address_ = boost::shared_ptr<Address>(new Address(addressNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<TelephoneNumber>> ContactInformation::getTelephone()
{
   if(!this->telephoneIsNull_){
        if(telephoneIDRef_ != ""){
             return this->telephone_;
        }else{
             return this->telephone_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<TelephoneNumber>>();
   }
}
std::vector<boost::shared_ptr<XsdTypeNormalizedString>> ContactInformation::getEmail()
{
   if(!this->emailIsNull_){
        if(emailIDRef_ != ""){
             return this->email_;
        }else{
             return this->email_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<XsdTypeNormalizedString>>();
   }
}
boost::shared_ptr<Address> ContactInformation::getAddress()
{
   if(!this->addressIsNull_){
        if(addressIDRef_ != ""){
             return boost::shared_static_cast<Address>(IDManager::instance().getID(addressIDRef_));
        }else{
             return this->address_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Address>();
   }
}
}

