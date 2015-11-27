// Underlyer.cpp 
#include "Underlyer.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Underlyer::Underlyer(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //singleUnderlyerNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* singleUnderlyerNode = xmlNode->FirstChildElement("singleUnderlyer");

   if(singleUnderlyerNode){singleUnderlyerIsNull_ = false;}
   else{singleUnderlyerIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- singleUnderlyerNode , address : " << singleUnderlyerNode << std::endl;
   #endif
   if(singleUnderlyerNode)
   {
      if(singleUnderlyerNode->Attribute("href") || singleUnderlyerNode->Attribute("id"))
      {
          if(singleUnderlyerNode->Attribute("id"))
          {
             singleUnderlyerIDRef_ = singleUnderlyerNode->Attribute("id");
             singleUnderlyer_ = boost::shared_ptr<SingleUnderlyer>(new SingleUnderlyer(singleUnderlyerNode));
             singleUnderlyer_->setID(singleUnderlyerIDRef_);
             IDManager::instance().setID(singleUnderlyerIDRef_,singleUnderlyer_);
          }
          else if(singleUnderlyerNode->Attribute("href")) { singleUnderlyerIDRef_ = singleUnderlyerNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { singleUnderlyer_ = boost::shared_ptr<SingleUnderlyer>(new SingleUnderlyer(singleUnderlyerNode));}
   }

   //basketNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* basketNode = xmlNode->FirstChildElement("basket");

   if(basketNode){basketIsNull_ = false;}
   else{basketIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- basketNode , address : " << basketNode << std::endl;
   #endif
   if(basketNode)
   {
      if(basketNode->Attribute("href") || basketNode->Attribute("id"))
      {
          if(basketNode->Attribute("id"))
          {
             basketIDRef_ = basketNode->Attribute("id");
             basket_ = boost::shared_ptr<Basket>(new Basket(basketNode));
             basket_->setID(basketIDRef_);
             IDManager::instance().setID(basketIDRef_,basket_);
          }
          else if(basketNode->Attribute("href")) { basketIDRef_ = basketNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { basket_ = boost::shared_ptr<Basket>(new Basket(basketNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<SingleUnderlyer> Underlyer::getSingleUnderlyer()
{
   if(!this->singleUnderlyerIsNull_){
        if(singleUnderlyerIDRef_ != ""){
             return boost::shared_static_cast<SingleUnderlyer>(IDManager::instance().getID(singleUnderlyerIDRef_));
        }else{
             return this->singleUnderlyer_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<SingleUnderlyer>();
   }
}
boost::shared_ptr<Basket> Underlyer::getBasket()
{
   if(!this->basketIsNull_){
        if(basketIDRef_ != ""){
             return boost::shared_static_cast<Basket>(IDManager::instance().getID(basketIDRef_));
        }else{
             return this->basket_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Basket>();
   }
}
}

