// Strike.cpp 
#include "Strike.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Strike::Strike(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //strikeRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* strikeRateNode = xmlNode->FirstChildElement("strikeRate");

   if(strikeRateNode){strikeRateIsNull_ = false;}
   else{strikeRateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- strikeRateNode , address : " << strikeRateNode << std::endl;
   #endif
   if(strikeRateNode)
   {
      if(strikeRateNode->Attribute("href") || strikeRateNode->Attribute("id"))
      {
          if(strikeRateNode->Attribute("id"))
          {
             strikeRateIDRef_ = strikeRateNode->Attribute("id");
             strikeRate_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(strikeRateNode));
             strikeRate_->setID(strikeRateIDRef_);
             IDManager::instance().setID(strikeRateIDRef_,strikeRate_);
          }
          else if(strikeRateNode->Attribute("href")) { strikeRateIDRef_ = strikeRateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { strikeRate_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(strikeRateNode));}
   }

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
boost::shared_ptr<XsdTypeDecimal> Strike::getStrikeRate()
{
   if(!this->strikeRateIsNull_){
        if(strikeRateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(strikeRateIDRef_));
        }else{
             return this->strikeRate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<IdentifiedPayerReceiver> Strike::getBuyer()
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
boost::shared_ptr<IdentifiedPayerReceiver> Strike::getSeller()
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

