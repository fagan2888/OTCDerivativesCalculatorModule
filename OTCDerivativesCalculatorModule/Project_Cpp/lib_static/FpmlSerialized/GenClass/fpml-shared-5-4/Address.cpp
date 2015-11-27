// Address.cpp 
#include "Address.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Address::Address(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //streetAddressNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* streetAddressNode = xmlNode->FirstChildElement("streetAddress");

   if(streetAddressNode){streetAddressIsNull_ = false;}
   else{streetAddressIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- streetAddressNode , address : " << streetAddressNode << std::endl;
   #endif
   if(streetAddressNode)
   {
      if(streetAddressNode->Attribute("href") || streetAddressNode->Attribute("id"))
      {
          if(streetAddressNode->Attribute("id"))
          {
             streetAddressIDRef_ = streetAddressNode->Attribute("id");
             streetAddress_ = boost::shared_ptr<StreetAddress>(new StreetAddress(streetAddressNode));
             streetAddress_->setID(streetAddressIDRef_);
             IDManager::instance().setID(streetAddressIDRef_,streetAddress_);
          }
          else if(streetAddressNode->Attribute("href")) { streetAddressIDRef_ = streetAddressNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { streetAddress_ = boost::shared_ptr<StreetAddress>(new StreetAddress(streetAddressNode));}
   }

   //cityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* cityNode = xmlNode->FirstChildElement("city");

   if(cityNode){cityIsNull_ = false;}
   else{cityIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- cityNode , address : " << cityNode << std::endl;
   #endif
   if(cityNode)
   {
      if(cityNode->Attribute("href") || cityNode->Attribute("id"))
      {
          if(cityNode->Attribute("id"))
          {
             cityIDRef_ = cityNode->Attribute("id");
             city_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(cityNode));
             city_->setID(cityIDRef_);
             IDManager::instance().setID(cityIDRef_,city_);
          }
          else if(cityNode->Attribute("href")) { cityIDRef_ = cityNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { city_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(cityNode));}
   }

   //stateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* stateNode = xmlNode->FirstChildElement("state");

   if(stateNode){stateIsNull_ = false;}
   else{stateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- stateNode , address : " << stateNode << std::endl;
   #endif
   if(stateNode)
   {
      if(stateNode->Attribute("href") || stateNode->Attribute("id"))
      {
          if(stateNode->Attribute("id"))
          {
             stateIDRef_ = stateNode->Attribute("id");
             state_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(stateNode));
             state_->setID(stateIDRef_);
             IDManager::instance().setID(stateIDRef_,state_);
          }
          else if(stateNode->Attribute("href")) { stateIDRef_ = stateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { state_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(stateNode));}
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

   //postalCodeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* postalCodeNode = xmlNode->FirstChildElement("postalCode");

   if(postalCodeNode){postalCodeIsNull_ = false;}
   else{postalCodeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- postalCodeNode , address : " << postalCodeNode << std::endl;
   #endif
   if(postalCodeNode)
   {
      if(postalCodeNode->Attribute("href") || postalCodeNode->Attribute("id"))
      {
          if(postalCodeNode->Attribute("id"))
          {
             postalCodeIDRef_ = postalCodeNode->Attribute("id");
             postalCode_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(postalCodeNode));
             postalCode_->setID(postalCodeIDRef_);
             IDManager::instance().setID(postalCodeIDRef_,postalCode_);
          }
          else if(postalCodeNode->Attribute("href")) { postalCodeIDRef_ = postalCodeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { postalCode_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(postalCodeNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<StreetAddress> Address::getStreetAddress()
{
   if(!this->streetAddressIsNull_){
        if(streetAddressIDRef_ != ""){
             return boost::shared_static_cast<StreetAddress>(IDManager::instance().getID(streetAddressIDRef_));
        }else{
             return this->streetAddress_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<StreetAddress>();
   }
}
boost::shared_ptr<XsdTypeString> Address::getCity()
{
   if(!this->cityIsNull_){
        if(cityIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeString>(IDManager::instance().getID(cityIDRef_));
        }else{
             return this->city_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeString>();
   }
}
boost::shared_ptr<XsdTypeString> Address::getState()
{
   if(!this->stateIsNull_){
        if(stateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeString>(IDManager::instance().getID(stateIDRef_));
        }else{
             return this->state_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeString>();
   }
}
boost::shared_ptr<CountryCode> Address::getCountry()
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
boost::shared_ptr<XsdTypeString> Address::getPostalCode()
{
   if(!this->postalCodeIsNull_){
        if(postalCodeIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeString>(IDManager::instance().getID(postalCodeIDRef_));
        }else{
             return this->postalCode_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeString>();
   }
}
}

