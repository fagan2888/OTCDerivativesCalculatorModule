// BrokerEquityOption.cpp 
#include "BrokerEquityOption.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

BrokerEquityOption::BrokerEquityOption(TiXmlNode* xmlNode)
: EquityDerivativeShortFormBase(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //deltaCrossedNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* deltaCrossedNode = xmlNode->FirstChildElement("deltaCrossed");

   if(deltaCrossedNode){deltaCrossedIsNull_ = false;}
   else{deltaCrossedIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- deltaCrossedNode , address : " << deltaCrossedNode << std::endl;
   #endif
   if(deltaCrossedNode)
   {
      if(deltaCrossedNode->Attribute("href") || deltaCrossedNode->Attribute("id"))
      {
          if(deltaCrossedNode->Attribute("id"))
          {
             deltaCrossedIDRef_ = deltaCrossedNode->Attribute("id");
             deltaCrossed_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(deltaCrossedNode));
             deltaCrossed_->setID(deltaCrossedIDRef_);
             IDManager::instance().setID(deltaCrossedIDRef_,deltaCrossed_);
          }
          else if(deltaCrossedNode->Attribute("href")) { deltaCrossedIDRef_ = deltaCrossedNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { deltaCrossed_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(deltaCrossedNode));}
   }

   //brokerageFeeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* brokerageFeeNode = xmlNode->FirstChildElement("brokerageFee");

   if(brokerageFeeNode){brokerageFeeIsNull_ = false;}
   else{brokerageFeeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- brokerageFeeNode , address : " << brokerageFeeNode << std::endl;
   #endif
   if(brokerageFeeNode)
   {
      if(brokerageFeeNode->Attribute("href") || brokerageFeeNode->Attribute("id"))
      {
          if(brokerageFeeNode->Attribute("id"))
          {
             brokerageFeeIDRef_ = brokerageFeeNode->Attribute("id");
             brokerageFee_ = boost::shared_ptr<Money>(new Money(brokerageFeeNode));
             brokerageFee_->setID(brokerageFeeIDRef_);
             IDManager::instance().setID(brokerageFeeIDRef_,brokerageFee_);
          }
          else if(brokerageFeeNode->Attribute("href")) { brokerageFeeIDRef_ = brokerageFeeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { brokerageFee_ = boost::shared_ptr<Money>(new Money(brokerageFeeNode));}
   }

   //brokerNotesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* brokerNotesNode = xmlNode->FirstChildElement("brokerNotes");

   if(brokerNotesNode){brokerNotesIsNull_ = false;}
   else{brokerNotesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- brokerNotesNode , address : " << brokerNotesNode << std::endl;
   #endif
   if(brokerNotesNode)
   {
      if(brokerNotesNode->Attribute("href") || brokerNotesNode->Attribute("id"))
      {
          if(brokerNotesNode->Attribute("id"))
          {
             brokerNotesIDRef_ = brokerNotesNode->Attribute("id");
             brokerNotes_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(brokerNotesNode));
             brokerNotes_->setID(brokerNotesIDRef_);
             IDManager::instance().setID(brokerNotesIDRef_,brokerNotes_);
          }
          else if(brokerNotesNode->Attribute("href")) { brokerNotesIDRef_ = brokerNotesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { brokerNotes_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(brokerNotesNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeBoolean> BrokerEquityOption::getDeltaCrossed()
{
   if(!this->deltaCrossedIsNull_){
        if(deltaCrossedIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(deltaCrossedIDRef_));
        }else{
             return this->deltaCrossed_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<Money> BrokerEquityOption::getBrokerageFee()
{
   if(!this->brokerageFeeIsNull_){
        if(brokerageFeeIDRef_ != ""){
             return boost::shared_static_cast<Money>(IDManager::instance().getID(brokerageFeeIDRef_));
        }else{
             return this->brokerageFee_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Money>();
   }
}
boost::shared_ptr<XsdTypeString> BrokerEquityOption::getBrokerNotes()
{
   if(!this->brokerNotesIsNull_){
        if(brokerNotesIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeString>(IDManager::instance().getID(brokerNotesIDRef_));
        }else{
             return this->brokerNotes_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeString>();
   }
}
}

