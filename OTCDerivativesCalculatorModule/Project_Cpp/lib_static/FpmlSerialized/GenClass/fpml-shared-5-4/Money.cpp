// Money.cpp 
#include "Money.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Money::Money(TiXmlNode* xmlNode)
: MoneyBase(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //amountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* amountNode = xmlNode->FirstChildElement("amount");

   if(amountNode){amountIsNull_ = false;}
   else{amountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- amountNode , address : " << amountNode << std::endl;
   #endif
   if(amountNode)
   {
      if(amountNode->Attribute("href") || amountNode->Attribute("id"))
      {
          if(amountNode->Attribute("id"))
          {
             amountIDRef_ = amountNode->Attribute("id");
             amount_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(amountNode));
             amount_->setID(amountIDRef_);
             IDManager::instance().setID(amountIDRef_,amount_);
          }
          else if(amountNode->Attribute("href")) { amountIDRef_ = amountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { amount_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(amountNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDecimal> Money::getAmount()
{
   if(!this->amountIsNull_){
        if(amountIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(amountIDRef_));
        }else{
             return this->amount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
}

