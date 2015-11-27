// DualCurrencyStrikePrice.cpp 
#include "DualCurrencyStrikePrice.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

DualCurrencyStrikePrice::DualCurrencyStrikePrice(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //rateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* rateNode = xmlNode->FirstChildElement("rate");

   if(rateNode){rateIsNull_ = false;}
   else{rateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- rateNode , address : " << rateNode << std::endl;
   #endif
   if(rateNode)
   {
      if(rateNode->Attribute("href") || rateNode->Attribute("id"))
      {
          if(rateNode->Attribute("id"))
          {
             rateIDRef_ = rateNode->Attribute("id");
             rate_ = boost::shared_ptr<PositiveDecimal>(new PositiveDecimal(rateNode));
             rate_->setID(rateIDRef_);
             IDManager::instance().setID(rateIDRef_,rate_);
          }
          else if(rateNode->Attribute("href")) { rateIDRef_ = rateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { rate_ = boost::shared_ptr<PositiveDecimal>(new PositiveDecimal(rateNode));}
   }

   //strikeQuoteBasisNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* strikeQuoteBasisNode = xmlNode->FirstChildElement("strikeQuoteBasis");

   if(strikeQuoteBasisNode){strikeQuoteBasisIsNull_ = false;}
   else{strikeQuoteBasisIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- strikeQuoteBasisNode , address : " << strikeQuoteBasisNode << std::endl;
   #endif
   if(strikeQuoteBasisNode)
   {
      if(strikeQuoteBasisNode->Attribute("href") || strikeQuoteBasisNode->Attribute("id"))
      {
          if(strikeQuoteBasisNode->Attribute("id"))
          {
             strikeQuoteBasisIDRef_ = strikeQuoteBasisNode->Attribute("id");
             strikeQuoteBasis_ = boost::shared_ptr<DualCurrencyStrikeQuoteBasisEnum>(new DualCurrencyStrikeQuoteBasisEnum(strikeQuoteBasisNode));
             strikeQuoteBasis_->setID(strikeQuoteBasisIDRef_);
             IDManager::instance().setID(strikeQuoteBasisIDRef_,strikeQuoteBasis_);
          }
          else if(strikeQuoteBasisNode->Attribute("href")) { strikeQuoteBasisIDRef_ = strikeQuoteBasisNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { strikeQuoteBasis_ = boost::shared_ptr<DualCurrencyStrikeQuoteBasisEnum>(new DualCurrencyStrikeQuoteBasisEnum(strikeQuoteBasisNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PositiveDecimal> DualCurrencyStrikePrice::getRate()
{
   if(!this->rateIsNull_){
        if(rateIDRef_ != ""){
             return boost::shared_static_cast<PositiveDecimal>(IDManager::instance().getID(rateIDRef_));
        }else{
             return this->rate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PositiveDecimal>();
   }
}
boost::shared_ptr<DualCurrencyStrikeQuoteBasisEnum> DualCurrencyStrikePrice::getStrikeQuoteBasis()
{
   if(!this->strikeQuoteBasisIsNull_){
        if(strikeQuoteBasisIDRef_ != ""){
             return boost::shared_static_cast<DualCurrencyStrikeQuoteBasisEnum>(IDManager::instance().getID(strikeQuoteBasisIDRef_));
        }else{
             return this->strikeQuoteBasis_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DualCurrencyStrikeQuoteBasisEnum>();
   }
}
}

