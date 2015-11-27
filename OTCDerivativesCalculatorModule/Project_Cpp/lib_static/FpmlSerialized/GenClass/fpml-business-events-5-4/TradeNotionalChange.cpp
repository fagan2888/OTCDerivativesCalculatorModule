// TradeNotionalChange.cpp 
#include "TradeNotionalChange.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

TradeNotionalChange::TradeNotionalChange(TiXmlNode* xmlNode)
: TradeChangeBase(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //changeInNotionalAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* changeInNotionalAmountNode = xmlNode->FirstChildElement("changeInNotionalAmount");

   if(changeInNotionalAmountNode){changeInNotionalAmountIsNull_ = false;}
   else{changeInNotionalAmountIsNull_ = true;}

   if(changeInNotionalAmountNode)
   {
      for(changeInNotionalAmountNode; changeInNotionalAmountNode; changeInNotionalAmountNode = changeInNotionalAmountNode->NextSiblingElement("changeInNotionalAmount")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- changeInNotionalAmountNode , address : " << changeInNotionalAmountNode << std::endl;
          #endif
          if(changeInNotionalAmountNode->Attribute("href") || changeInNotionalAmountNode->Attribute("id"))
          {
              if(changeInNotionalAmountNode->Attribute("id"))
              {
                  changeInNotionalAmountIDRef_ = changeInNotionalAmountNode->Attribute("id");
                  changeInNotionalAmount_.push_back(boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(changeInNotionalAmountNode)));
                  changeInNotionalAmount_.back()->setID(changeInNotionalAmountIDRef_);
                  IDManager::instance().setID(changeInNotionalAmountIDRef_, changeInNotionalAmount_.back());
              }
              else if(changeInNotionalAmountNode->Attribute("href")) { changeInNotionalAmountIDRef_ = changeInNotionalAmountNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { changeInNotionalAmount_.push_back(boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(changeInNotionalAmountNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- changeInNotionalAmountNode , address : " << changeInNotionalAmountNode << std::endl;
       #endif
   }

   //outstandingNotionalAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* outstandingNotionalAmountNode = xmlNode->FirstChildElement("outstandingNotionalAmount");

   if(outstandingNotionalAmountNode){outstandingNotionalAmountIsNull_ = false;}
   else{outstandingNotionalAmountIsNull_ = true;}

   if(outstandingNotionalAmountNode)
   {
      for(outstandingNotionalAmountNode; outstandingNotionalAmountNode; outstandingNotionalAmountNode = outstandingNotionalAmountNode->NextSiblingElement("outstandingNotionalAmount")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- outstandingNotionalAmountNode , address : " << outstandingNotionalAmountNode << std::endl;
          #endif
          if(outstandingNotionalAmountNode->Attribute("href") || outstandingNotionalAmountNode->Attribute("id"))
          {
              if(outstandingNotionalAmountNode->Attribute("id"))
              {
                  outstandingNotionalAmountIDRef_ = outstandingNotionalAmountNode->Attribute("id");
                  outstandingNotionalAmount_.push_back(boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(outstandingNotionalAmountNode)));
                  outstandingNotionalAmount_.back()->setID(outstandingNotionalAmountIDRef_);
                  IDManager::instance().setID(outstandingNotionalAmountIDRef_, outstandingNotionalAmount_.back());
              }
              else if(outstandingNotionalAmountNode->Attribute("href")) { outstandingNotionalAmountIDRef_ = outstandingNotionalAmountNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { outstandingNotionalAmount_.push_back(boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(outstandingNotionalAmountNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- outstandingNotionalAmountNode , address : " << outstandingNotionalAmountNode << std::endl;
       #endif
   }

   //changeInNumberOfOptionsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* changeInNumberOfOptionsNode = xmlNode->FirstChildElement("changeInNumberOfOptions");

   if(changeInNumberOfOptionsNode){changeInNumberOfOptionsIsNull_ = false;}
   else{changeInNumberOfOptionsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- changeInNumberOfOptionsNode , address : " << changeInNumberOfOptionsNode << std::endl;
   #endif
   if(changeInNumberOfOptionsNode)
   {
      if(changeInNumberOfOptionsNode->Attribute("href") || changeInNumberOfOptionsNode->Attribute("id"))
      {
          if(changeInNumberOfOptionsNode->Attribute("id"))
          {
             changeInNumberOfOptionsIDRef_ = changeInNumberOfOptionsNode->Attribute("id");
             changeInNumberOfOptions_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(changeInNumberOfOptionsNode));
             changeInNumberOfOptions_->setID(changeInNumberOfOptionsIDRef_);
             IDManager::instance().setID(changeInNumberOfOptionsIDRef_,changeInNumberOfOptions_);
          }
          else if(changeInNumberOfOptionsNode->Attribute("href")) { changeInNumberOfOptionsIDRef_ = changeInNumberOfOptionsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { changeInNumberOfOptions_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(changeInNumberOfOptionsNode));}
   }

   //outstandingNumberOfOptionsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* outstandingNumberOfOptionsNode = xmlNode->FirstChildElement("outstandingNumberOfOptions");

   if(outstandingNumberOfOptionsNode){outstandingNumberOfOptionsIsNull_ = false;}
   else{outstandingNumberOfOptionsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- outstandingNumberOfOptionsNode , address : " << outstandingNumberOfOptionsNode << std::endl;
   #endif
   if(outstandingNumberOfOptionsNode)
   {
      if(outstandingNumberOfOptionsNode->Attribute("href") || outstandingNumberOfOptionsNode->Attribute("id"))
      {
          if(outstandingNumberOfOptionsNode->Attribute("id"))
          {
             outstandingNumberOfOptionsIDRef_ = outstandingNumberOfOptionsNode->Attribute("id");
             outstandingNumberOfOptions_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(outstandingNumberOfOptionsNode));
             outstandingNumberOfOptions_->setID(outstandingNumberOfOptionsIDRef_);
             IDManager::instance().setID(outstandingNumberOfOptionsIDRef_,outstandingNumberOfOptions_);
          }
          else if(outstandingNumberOfOptionsNode->Attribute("href")) { outstandingNumberOfOptionsIDRef_ = outstandingNumberOfOptionsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { outstandingNumberOfOptions_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(outstandingNumberOfOptionsNode));}
   }

   //changeInNumberOfUnitsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* changeInNumberOfUnitsNode = xmlNode->FirstChildElement("changeInNumberOfUnits");

   if(changeInNumberOfUnitsNode){changeInNumberOfUnitsIsNull_ = false;}
   else{changeInNumberOfUnitsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- changeInNumberOfUnitsNode , address : " << changeInNumberOfUnitsNode << std::endl;
   #endif
   if(changeInNumberOfUnitsNode)
   {
      if(changeInNumberOfUnitsNode->Attribute("href") || changeInNumberOfUnitsNode->Attribute("id"))
      {
          if(changeInNumberOfUnitsNode->Attribute("id"))
          {
             changeInNumberOfUnitsIDRef_ = changeInNumberOfUnitsNode->Attribute("id");
             changeInNumberOfUnits_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(changeInNumberOfUnitsNode));
             changeInNumberOfUnits_->setID(changeInNumberOfUnitsIDRef_);
             IDManager::instance().setID(changeInNumberOfUnitsIDRef_,changeInNumberOfUnits_);
          }
          else if(changeInNumberOfUnitsNode->Attribute("href")) { changeInNumberOfUnitsIDRef_ = changeInNumberOfUnitsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { changeInNumberOfUnits_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(changeInNumberOfUnitsNode));}
   }

   //outstandingNumberOfUnitsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* outstandingNumberOfUnitsNode = xmlNode->FirstChildElement("outstandingNumberOfUnits");

   if(outstandingNumberOfUnitsNode){outstandingNumberOfUnitsIsNull_ = false;}
   else{outstandingNumberOfUnitsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- outstandingNumberOfUnitsNode , address : " << outstandingNumberOfUnitsNode << std::endl;
   #endif
   if(outstandingNumberOfUnitsNode)
   {
      if(outstandingNumberOfUnitsNode->Attribute("href") || outstandingNumberOfUnitsNode->Attribute("id"))
      {
          if(outstandingNumberOfUnitsNode->Attribute("id"))
          {
             outstandingNumberOfUnitsIDRef_ = outstandingNumberOfUnitsNode->Attribute("id");
             outstandingNumberOfUnits_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(outstandingNumberOfUnitsNode));
             outstandingNumberOfUnits_->setID(outstandingNumberOfUnitsIDRef_);
             IDManager::instance().setID(outstandingNumberOfUnitsIDRef_,outstandingNumberOfUnits_);
          }
          else if(outstandingNumberOfUnitsNode->Attribute("href")) { outstandingNumberOfUnitsIDRef_ = outstandingNumberOfUnitsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { outstandingNumberOfUnits_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(outstandingNumberOfUnitsNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<NonNegativeMoney>> TradeNotionalChange::getChangeInNotionalAmount()
{
   if(!this->changeInNotionalAmountIsNull_){
        if(changeInNotionalAmountIDRef_ != ""){
             return this->changeInNotionalAmount_;
        }else{
             return this->changeInNotionalAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<NonNegativeMoney>>();
   }
}
std::vector<boost::shared_ptr<NonNegativeMoney>> TradeNotionalChange::getOutstandingNotionalAmount()
{
   if(!this->outstandingNotionalAmountIsNull_){
        if(outstandingNotionalAmountIDRef_ != ""){
             return this->outstandingNotionalAmount_;
        }else{
             return this->outstandingNotionalAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<NonNegativeMoney>>();
   }
}
boost::shared_ptr<XsdTypeDecimal> TradeNotionalChange::getChangeInNumberOfOptions()
{
   if(!this->changeInNumberOfOptionsIsNull_){
        if(changeInNumberOfOptionsIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(changeInNumberOfOptionsIDRef_));
        }else{
             return this->changeInNumberOfOptions_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<XsdTypeDecimal> TradeNotionalChange::getOutstandingNumberOfOptions()
{
   if(!this->outstandingNumberOfOptionsIsNull_){
        if(outstandingNumberOfOptionsIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(outstandingNumberOfOptionsIDRef_));
        }else{
             return this->outstandingNumberOfOptions_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<XsdTypeDecimal> TradeNotionalChange::getChangeInNumberOfUnits()
{
   if(!this->changeInNumberOfUnitsIsNull_){
        if(changeInNumberOfUnitsIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(changeInNumberOfUnitsIDRef_));
        }else{
             return this->changeInNumberOfUnits_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<XsdTypeDecimal> TradeNotionalChange::getOutstandingNumberOfUnits()
{
   if(!this->outstandingNumberOfUnitsIsNull_){
        if(outstandingNumberOfUnitsIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(outstandingNumberOfUnitsIDRef_));
        }else{
             return this->outstandingNumberOfUnits_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
}

