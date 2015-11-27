// CreditDefaultSwapOption.cpp 
#include "CreditDefaultSwapOption.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CreditDefaultSwapOption::CreditDefaultSwapOption(TiXmlNode* xmlNode)
: OptionBaseExtended(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //strikeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* strikeNode = xmlNode->FirstChildElement("strike");

   if(strikeNode){strikeIsNull_ = false;}
   else{strikeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- strikeNode , address : " << strikeNode << std::endl;
   #endif
   if(strikeNode)
   {
      if(strikeNode->Attribute("href") || strikeNode->Attribute("id"))
      {
          if(strikeNode->Attribute("id"))
          {
             strikeIDRef_ = strikeNode->Attribute("id");
             strike_ = boost::shared_ptr<CreditOptionStrike>(new CreditOptionStrike(strikeNode));
             strike_->setID(strikeIDRef_);
             IDManager::instance().setID(strikeIDRef_,strike_);
          }
          else if(strikeNode->Attribute("href")) { strikeIDRef_ = strikeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { strike_ = boost::shared_ptr<CreditOptionStrike>(new CreditOptionStrike(strikeNode));}
   }

   //creditDefaultSwapNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* creditDefaultSwapNode = xmlNode->FirstChildElement("creditDefaultSwap");

   if(creditDefaultSwapNode){creditDefaultSwapIsNull_ = false;}
   else{creditDefaultSwapIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- creditDefaultSwapNode , address : " << creditDefaultSwapNode << std::endl;
   #endif
   if(creditDefaultSwapNode)
   {
      if(creditDefaultSwapNode->Attribute("href") || creditDefaultSwapNode->Attribute("id"))
      {
          if(creditDefaultSwapNode->Attribute("id"))
          {
             creditDefaultSwapIDRef_ = creditDefaultSwapNode->Attribute("id");
             creditDefaultSwap_ = boost::shared_ptr<CreditDefaultSwap>(new CreditDefaultSwap(creditDefaultSwapNode));
             creditDefaultSwap_->setID(creditDefaultSwapIDRef_);
             IDManager::instance().setID(creditDefaultSwapIDRef_,creditDefaultSwap_);
          }
          else if(creditDefaultSwapNode->Attribute("href")) { creditDefaultSwapIDRef_ = creditDefaultSwapNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { creditDefaultSwap_ = boost::shared_ptr<CreditDefaultSwap>(new CreditDefaultSwap(creditDefaultSwapNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<CreditOptionStrike> CreditDefaultSwapOption::getStrike()
{
   if(!this->strikeIsNull_){
        if(strikeIDRef_ != ""){
             return boost::shared_static_cast<CreditOptionStrike>(IDManager::instance().getID(strikeIDRef_));
        }else{
             return this->strike_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CreditOptionStrike>();
   }
}
boost::shared_ptr<CreditDefaultSwap> CreditDefaultSwapOption::getCreditDefaultSwap()
{
   if(!this->creditDefaultSwapIsNull_){
        if(creditDefaultSwapIDRef_ != ""){
             return boost::shared_static_cast<CreditDefaultSwap>(IDManager::instance().getID(creditDefaultSwapIDRef_));
        }else{
             return this->creditDefaultSwap_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CreditDefaultSwap>();
   }
}
}

