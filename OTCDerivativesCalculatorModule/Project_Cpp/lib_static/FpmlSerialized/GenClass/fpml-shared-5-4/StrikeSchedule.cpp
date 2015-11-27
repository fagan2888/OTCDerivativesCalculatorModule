// StrikeSchedule.cpp 
#include "StrikeSchedule.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

StrikeSchedule::StrikeSchedule(TiXmlNode* xmlNode)
: Schedule(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //buyerNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* buyerNode = xmlNode->FirstChildElement("buyer");

   if(buyerNode){buyerIsNull_ = false;}
   else{buyerIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- buyerNode , address : " << buyerNode << std::endl;
   #endif
   if(buyerNode)
   {
      if(buyerNode->Attribute("href") || buyerNode->Attribute("id"))
      {
          if(buyerNode->Attribute("id"))
          {
             buyerIDRef_ = buyerNode->Attribute("id");
             buyer_ = boost::shared_ptr<IdentifiedPayerReceiver>(new IdentifiedPayerReceiver(buyerNode));
             buyer_->setID(buyerIDRef_);
             IDManager::instance().setID(buyerIDRef_,buyer_);
          }
          else if(buyerNode->Attribute("href")) { buyerIDRef_ = buyerNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { buyer_ = boost::shared_ptr<IdentifiedPayerReceiver>(new IdentifiedPayerReceiver(buyerNode));}
   }

   //sellerNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* sellerNode = xmlNode->FirstChildElement("seller");

   if(sellerNode){sellerIsNull_ = false;}
   else{sellerIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- sellerNode , address : " << sellerNode << std::endl;
   #endif
   if(sellerNode)
   {
      if(sellerNode->Attribute("href") || sellerNode->Attribute("id"))
      {
          if(sellerNode->Attribute("id"))
          {
             sellerIDRef_ = sellerNode->Attribute("id");
             seller_ = boost::shared_ptr<IdentifiedPayerReceiver>(new IdentifiedPayerReceiver(sellerNode));
             seller_->setID(sellerIDRef_);
             IDManager::instance().setID(sellerIDRef_,seller_);
          }
          else if(sellerNode->Attribute("href")) { sellerIDRef_ = sellerNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { seller_ = boost::shared_ptr<IdentifiedPayerReceiver>(new IdentifiedPayerReceiver(sellerNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<IdentifiedPayerReceiver> StrikeSchedule::getBuyer()
{
   if(!this->buyerIsNull_){
        if(buyerIDRef_ != ""){
             return boost::shared_static_cast<IdentifiedPayerReceiver>(IDManager::instance().getID(buyerIDRef_));
        }else{
             return this->buyer_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<IdentifiedPayerReceiver>();
   }
}
boost::shared_ptr<IdentifiedPayerReceiver> StrikeSchedule::getSeller()
{
   if(!this->sellerIsNull_){
        if(sellerIDRef_ != ""){
             return boost::shared_static_cast<IdentifiedPayerReceiver>(IDManager::instance().getID(sellerIDRef_));
        }else{
             return this->seller_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<IdentifiedPayerReceiver>();
   }
}
}

