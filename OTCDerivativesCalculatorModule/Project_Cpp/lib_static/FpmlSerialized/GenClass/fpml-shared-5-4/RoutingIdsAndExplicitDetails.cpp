// RoutingIdsAndExplicitDetails.cpp 
#include "RoutingIdsAndExplicitDetails.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

RoutingIdsAndExplicitDetails::RoutingIdsAndExplicitDetails(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //routingIdsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* routingIdsNode = xmlNode->FirstChildElement("routingIds");

   if(routingIdsNode){routingIdsIsNull_ = false;}
   else{routingIdsIsNull_ = true;}

   if(routingIdsNode)
   {
      for(routingIdsNode; routingIdsNode; routingIdsNode = routingIdsNode->NextSiblingElement("routingIds")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- routingIdsNode , address : " << routingIdsNode << std::endl;
          #endif
          if(routingIdsNode->Attribute("href") || routingIdsNode->Attribute("id"))
          {
              if(routingIdsNode->Attribute("id"))
              {
                  routingIdsIDRef_ = routingIdsNode->Attribute("id");
                  routingIds_.push_back(boost::shared_ptr<RoutingIds>(new RoutingIds(routingIdsNode)));
                  routingIds_.back()->setID(routingIdsIDRef_);
                  IDManager::instance().setID(routingIdsIDRef_, routingIds_.back());
              }
              else if(routingIdsNode->Attribute("href")) { routingIdsIDRef_ = routingIdsNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { routingIds_.push_back(boost::shared_ptr<RoutingIds>(new RoutingIds(routingIdsNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- routingIdsNode , address : " << routingIdsNode << std::endl;
       #endif
   }

   //routingNameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* routingNameNode = xmlNode->FirstChildElement("routingName");

   if(routingNameNode){routingNameIsNull_ = false;}
   else{routingNameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- routingNameNode , address : " << routingNameNode << std::endl;
   #endif
   if(routingNameNode)
   {
      if(routingNameNode->Attribute("href") || routingNameNode->Attribute("id"))
      {
          if(routingNameNode->Attribute("id"))
          {
             routingNameIDRef_ = routingNameNode->Attribute("id");
             routingName_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(routingNameNode));
             routingName_->setID(routingNameIDRef_);
             IDManager::instance().setID(routingNameIDRef_,routingName_);
          }
          else if(routingNameNode->Attribute("href")) { routingNameIDRef_ = routingNameNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { routingName_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(routingNameNode));}
   }

   //routingAddressNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* routingAddressNode = xmlNode->FirstChildElement("routingAddress");

   if(routingAddressNode){routingAddressIsNull_ = false;}
   else{routingAddressIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- routingAddressNode , address : " << routingAddressNode << std::endl;
   #endif
   if(routingAddressNode)
   {
      if(routingAddressNode->Attribute("href") || routingAddressNode->Attribute("id"))
      {
          if(routingAddressNode->Attribute("id"))
          {
             routingAddressIDRef_ = routingAddressNode->Attribute("id");
             routingAddress_ = boost::shared_ptr<Address>(new Address(routingAddressNode));
             routingAddress_->setID(routingAddressIDRef_);
             IDManager::instance().setID(routingAddressIDRef_,routingAddress_);
          }
          else if(routingAddressNode->Attribute("href")) { routingAddressIDRef_ = routingAddressNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { routingAddress_ = boost::shared_ptr<Address>(new Address(routingAddressNode));}
   }

   //routingAccountNumberNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* routingAccountNumberNode = xmlNode->FirstChildElement("routingAccountNumber");

   if(routingAccountNumberNode){routingAccountNumberIsNull_ = false;}
   else{routingAccountNumberIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- routingAccountNumberNode , address : " << routingAccountNumberNode << std::endl;
   #endif
   if(routingAccountNumberNode)
   {
      if(routingAccountNumberNode->Attribute("href") || routingAccountNumberNode->Attribute("id"))
      {
          if(routingAccountNumberNode->Attribute("id"))
          {
             routingAccountNumberIDRef_ = routingAccountNumberNode->Attribute("id");
             routingAccountNumber_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(routingAccountNumberNode));
             routingAccountNumber_->setID(routingAccountNumberIDRef_);
             IDManager::instance().setID(routingAccountNumberIDRef_,routingAccountNumber_);
          }
          else if(routingAccountNumberNode->Attribute("href")) { routingAccountNumberIDRef_ = routingAccountNumberNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { routingAccountNumber_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(routingAccountNumberNode));}
   }

   //routingReferenceTextNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* routingReferenceTextNode = xmlNode->FirstChildElement("routingReferenceText");

   if(routingReferenceTextNode){routingReferenceTextIsNull_ = false;}
   else{routingReferenceTextIsNull_ = true;}

   if(routingReferenceTextNode)
   {
      for(routingReferenceTextNode; routingReferenceTextNode; routingReferenceTextNode = routingReferenceTextNode->NextSiblingElement("routingReferenceText")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- routingReferenceTextNode , address : " << routingReferenceTextNode << std::endl;
          #endif
          if(routingReferenceTextNode->Attribute("href") || routingReferenceTextNode->Attribute("id"))
          {
              if(routingReferenceTextNode->Attribute("id"))
              {
                  routingReferenceTextIDRef_ = routingReferenceTextNode->Attribute("id");
                  routingReferenceText_.push_back(boost::shared_ptr<XsdTypeString>(new XsdTypeString(routingReferenceTextNode)));
                  routingReferenceText_.back()->setID(routingReferenceTextIDRef_);
                  IDManager::instance().setID(routingReferenceTextIDRef_, routingReferenceText_.back());
              }
              else if(routingReferenceTextNode->Attribute("href")) { routingReferenceTextIDRef_ = routingReferenceTextNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { routingReferenceText_.push_back(boost::shared_ptr<XsdTypeString>(new XsdTypeString(routingReferenceTextNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- routingReferenceTextNode , address : " << routingReferenceTextNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<RoutingIds>> RoutingIdsAndExplicitDetails::getRoutingIds()
{
   if(!this->routingIdsIsNull_){
        if(routingIdsIDRef_ != ""){
             return this->routingIds_;
        }else{
             return this->routingIds_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<RoutingIds>>();
   }
}
boost::shared_ptr<XsdTypeString> RoutingIdsAndExplicitDetails::getRoutingName()
{
   if(!this->routingNameIsNull_){
        if(routingNameIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeString>(IDManager::instance().getID(routingNameIDRef_));
        }else{
             return this->routingName_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeString>();
   }
}
boost::shared_ptr<Address> RoutingIdsAndExplicitDetails::getRoutingAddress()
{
   if(!this->routingAddressIsNull_){
        if(routingAddressIDRef_ != ""){
             return boost::shared_static_cast<Address>(IDManager::instance().getID(routingAddressIDRef_));
        }else{
             return this->routingAddress_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Address>();
   }
}
boost::shared_ptr<XsdTypeString> RoutingIdsAndExplicitDetails::getRoutingAccountNumber()
{
   if(!this->routingAccountNumberIsNull_){
        if(routingAccountNumberIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeString>(IDManager::instance().getID(routingAccountNumberIDRef_));
        }else{
             return this->routingAccountNumber_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeString>();
   }
}
std::vector<boost::shared_ptr<XsdTypeString>> RoutingIdsAndExplicitDetails::getRoutingReferenceText()
{
   if(!this->routingReferenceTextIsNull_){
        if(routingReferenceTextIDRef_ != ""){
             return this->routingReferenceText_;
        }else{
             return this->routingReferenceText_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<XsdTypeString>>();
   }
}
}

