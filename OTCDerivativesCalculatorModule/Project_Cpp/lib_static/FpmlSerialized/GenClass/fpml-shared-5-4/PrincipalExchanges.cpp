// PrincipalExchanges.cpp 
#include "PrincipalExchanges.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

PrincipalExchanges::PrincipalExchanges(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //initialExchangeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* initialExchangeNode = xmlNode->FirstChildElement("initialExchange");

   if(initialExchangeNode){initialExchangeIsNull_ = false;}
   else{initialExchangeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- initialExchangeNode , address : " << initialExchangeNode << std::endl;
   #endif
   if(initialExchangeNode)
   {
      if(initialExchangeNode->Attribute("href") || initialExchangeNode->Attribute("id"))
      {
          if(initialExchangeNode->Attribute("id"))
          {
             initialExchangeIDRef_ = initialExchangeNode->Attribute("id");
             initialExchange_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(initialExchangeNode));
             initialExchange_->setID(initialExchangeIDRef_);
             IDManager::instance().setID(initialExchangeIDRef_,initialExchange_);
          }
          else if(initialExchangeNode->Attribute("href")) { initialExchangeIDRef_ = initialExchangeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { initialExchange_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(initialExchangeNode));}
   }

   //finalExchangeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* finalExchangeNode = xmlNode->FirstChildElement("finalExchange");

   if(finalExchangeNode){finalExchangeIsNull_ = false;}
   else{finalExchangeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- finalExchangeNode , address : " << finalExchangeNode << std::endl;
   #endif
   if(finalExchangeNode)
   {
      if(finalExchangeNode->Attribute("href") || finalExchangeNode->Attribute("id"))
      {
          if(finalExchangeNode->Attribute("id"))
          {
             finalExchangeIDRef_ = finalExchangeNode->Attribute("id");
             finalExchange_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(finalExchangeNode));
             finalExchange_->setID(finalExchangeIDRef_);
             IDManager::instance().setID(finalExchangeIDRef_,finalExchange_);
          }
          else if(finalExchangeNode->Attribute("href")) { finalExchangeIDRef_ = finalExchangeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { finalExchange_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(finalExchangeNode));}
   }

   //intermediateExchangeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* intermediateExchangeNode = xmlNode->FirstChildElement("intermediateExchange");

   if(intermediateExchangeNode){intermediateExchangeIsNull_ = false;}
   else{intermediateExchangeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- intermediateExchangeNode , address : " << intermediateExchangeNode << std::endl;
   #endif
   if(intermediateExchangeNode)
   {
      if(intermediateExchangeNode->Attribute("href") || intermediateExchangeNode->Attribute("id"))
      {
          if(intermediateExchangeNode->Attribute("id"))
          {
             intermediateExchangeIDRef_ = intermediateExchangeNode->Attribute("id");
             intermediateExchange_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(intermediateExchangeNode));
             intermediateExchange_->setID(intermediateExchangeIDRef_);
             IDManager::instance().setID(intermediateExchangeIDRef_,intermediateExchange_);
          }
          else if(intermediateExchangeNode->Attribute("href")) { intermediateExchangeIDRef_ = intermediateExchangeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { intermediateExchange_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(intermediateExchangeNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeBoolean> PrincipalExchanges::getInitialExchange()
{
   if(!this->initialExchangeIsNull_){
        if(initialExchangeIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(initialExchangeIDRef_));
        }else{
             return this->initialExchange_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> PrincipalExchanges::getFinalExchange()
{
   if(!this->finalExchangeIsNull_){
        if(finalExchangeIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(finalExchangeIDRef_));
        }else{
             return this->finalExchange_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> PrincipalExchanges::getIntermediateExchange()
{
   if(!this->intermediateExchangeIsNull_){
        if(intermediateExchangeIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(intermediateExchangeIDRef_));
        }else{
             return this->intermediateExchange_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
}

