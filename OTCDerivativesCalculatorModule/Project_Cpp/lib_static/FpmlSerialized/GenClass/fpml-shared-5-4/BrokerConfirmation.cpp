// BrokerConfirmation.cpp 
#include "BrokerConfirmation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

BrokerConfirmation::BrokerConfirmation(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //brokerConfirmationTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* brokerConfirmationTypeNode = xmlNode->FirstChildElement("brokerConfirmationType");

   if(brokerConfirmationTypeNode){brokerConfirmationTypeIsNull_ = false;}
   else{brokerConfirmationTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- brokerConfirmationTypeNode , address : " << brokerConfirmationTypeNode << std::endl;
   #endif
   if(brokerConfirmationTypeNode)
   {
      if(brokerConfirmationTypeNode->Attribute("href") || brokerConfirmationTypeNode->Attribute("id"))
      {
          if(brokerConfirmationTypeNode->Attribute("id"))
          {
             brokerConfirmationTypeIDRef_ = brokerConfirmationTypeNode->Attribute("id");
             brokerConfirmationType_ = boost::shared_ptr<BrokerConfirmationType>(new BrokerConfirmationType(brokerConfirmationTypeNode));
             brokerConfirmationType_->setID(brokerConfirmationTypeIDRef_);
             IDManager::instance().setID(brokerConfirmationTypeIDRef_,brokerConfirmationType_);
          }
          else if(brokerConfirmationTypeNode->Attribute("href")) { brokerConfirmationTypeIDRef_ = brokerConfirmationTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { brokerConfirmationType_ = boost::shared_ptr<BrokerConfirmationType>(new BrokerConfirmationType(brokerConfirmationTypeNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<BrokerConfirmationType> BrokerConfirmation::getBrokerConfirmationType()
{
   if(!this->brokerConfirmationTypeIsNull_){
        if(brokerConfirmationTypeIDRef_ != ""){
             return boost::shared_static_cast<BrokerConfirmationType>(IDManager::instance().getID(brokerConfirmationTypeIDRef_));
        }else{
             return this->brokerConfirmationType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BrokerConfirmationType>();
   }
}
}

