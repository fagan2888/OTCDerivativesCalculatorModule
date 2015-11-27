// DividendPeriodDividend.cpp 
#include "DividendPeriodDividend.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

DividendPeriodDividend::DividendPeriodDividend(TiXmlNode* xmlNode)
: DividendPeriod(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //dividendNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dividendNode = xmlNode->FirstChildElement("dividend");

   if(dividendNode){dividendIsNull_ = false;}
   else{dividendIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dividendNode , address : " << dividendNode << std::endl;
   #endif
   if(dividendNode)
   {
      if(dividendNode->Attribute("href") || dividendNode->Attribute("id"))
      {
          if(dividendNode->Attribute("id"))
          {
             dividendIDRef_ = dividendNode->Attribute("id");
             dividend_ = boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(dividendNode));
             dividend_->setID(dividendIDRef_);
             IDManager::instance().setID(dividendIDRef_,dividend_);
          }
          else if(dividendNode->Attribute("href")) { dividendIDRef_ = dividendNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { dividend_ = boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(dividendNode));}
   }

   //multiplierNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* multiplierNode = xmlNode->FirstChildElement("multiplier");

   if(multiplierNode){multiplierIsNull_ = false;}
   else{multiplierIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- multiplierNode , address : " << multiplierNode << std::endl;
   #endif
   if(multiplierNode)
   {
      if(multiplierNode->Attribute("href") || multiplierNode->Attribute("id"))
      {
          if(multiplierNode->Attribute("id"))
          {
             multiplierIDRef_ = multiplierNode->Attribute("id");
             multiplier_ = boost::shared_ptr<PositiveDecimal>(new PositiveDecimal(multiplierNode));
             multiplier_->setID(multiplierIDRef_);
             IDManager::instance().setID(multiplierIDRef_,multiplier_);
          }
          else if(multiplierNode->Attribute("href")) { multiplierIDRef_ = multiplierNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { multiplier_ = boost::shared_ptr<PositiveDecimal>(new PositiveDecimal(multiplierNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<NonNegativeMoney> DividendPeriodDividend::getDividend()
{
   if(!this->dividendIsNull_){
        if(dividendIDRef_ != ""){
             return boost::shared_static_cast<NonNegativeMoney>(IDManager::instance().getID(dividendIDRef_));
        }else{
             return this->dividend_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NonNegativeMoney>();
   }
}
boost::shared_ptr<PositiveDecimal> DividendPeriodDividend::getMultiplier()
{
   if(!this->multiplierIsNull_){
        if(multiplierIDRef_ != ""){
             return boost::shared_static_cast<PositiveDecimal>(IDManager::instance().getID(multiplierIDRef_));
        }else{
             return this->multiplier_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PositiveDecimal>();
   }
}
}

