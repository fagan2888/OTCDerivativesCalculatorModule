// ProtectionTerms.cpp 
#include "ProtectionTerms.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ProtectionTerms::ProtectionTerms(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //calculationAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calculationAmountNode = xmlNode->FirstChildElement("calculationAmount");

   if(calculationAmountNode){calculationAmountIsNull_ = false;}
   else{calculationAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationAmountNode , address : " << calculationAmountNode << std::endl;
   #endif
   if(calculationAmountNode)
   {
      if(calculationAmountNode->Attribute("href") || calculationAmountNode->Attribute("id"))
      {
          if(calculationAmountNode->Attribute("id"))
          {
             calculationAmountIDRef_ = calculationAmountNode->Attribute("id");
             calculationAmount_ = boost::shared_ptr<Money>(new Money(calculationAmountNode));
             calculationAmount_->setID(calculationAmountIDRef_);
             IDManager::instance().setID(calculationAmountIDRef_,calculationAmount_);
          }
          else if(calculationAmountNode->Attribute("href")) { calculationAmountIDRef_ = calculationAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { calculationAmount_ = boost::shared_ptr<Money>(new Money(calculationAmountNode));}
   }

   //creditEventsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* creditEventsNode = xmlNode->FirstChildElement("creditEvents");

   if(creditEventsNode){creditEventsIsNull_ = false;}
   else{creditEventsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- creditEventsNode , address : " << creditEventsNode << std::endl;
   #endif
   if(creditEventsNode)
   {
      if(creditEventsNode->Attribute("href") || creditEventsNode->Attribute("id"))
      {
          if(creditEventsNode->Attribute("id"))
          {
             creditEventsIDRef_ = creditEventsNode->Attribute("id");
             creditEvents_ = boost::shared_ptr<CreditEvents>(new CreditEvents(creditEventsNode));
             creditEvents_->setID(creditEventsIDRef_);
             IDManager::instance().setID(creditEventsIDRef_,creditEvents_);
          }
          else if(creditEventsNode->Attribute("href")) { creditEventsIDRef_ = creditEventsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { creditEvents_ = boost::shared_ptr<CreditEvents>(new CreditEvents(creditEventsNode));}
   }

   //obligationsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* obligationsNode = xmlNode->FirstChildElement("obligations");

   if(obligationsNode){obligationsIsNull_ = false;}
   else{obligationsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- obligationsNode , address : " << obligationsNode << std::endl;
   #endif
   if(obligationsNode)
   {
      if(obligationsNode->Attribute("href") || obligationsNode->Attribute("id"))
      {
          if(obligationsNode->Attribute("id"))
          {
             obligationsIDRef_ = obligationsNode->Attribute("id");
             obligations_ = boost::shared_ptr<Obligations>(new Obligations(obligationsNode));
             obligations_->setID(obligationsIDRef_);
             IDManager::instance().setID(obligationsIDRef_,obligations_);
          }
          else if(obligationsNode->Attribute("href")) { obligationsIDRef_ = obligationsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { obligations_ = boost::shared_ptr<Obligations>(new Obligations(obligationsNode));}
   }

   //floatingAmountEventsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* floatingAmountEventsNode = xmlNode->FirstChildElement("floatingAmountEvents");

   if(floatingAmountEventsNode){floatingAmountEventsIsNull_ = false;}
   else{floatingAmountEventsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- floatingAmountEventsNode , address : " << floatingAmountEventsNode << std::endl;
   #endif
   if(floatingAmountEventsNode)
   {
      if(floatingAmountEventsNode->Attribute("href") || floatingAmountEventsNode->Attribute("id"))
      {
          if(floatingAmountEventsNode->Attribute("id"))
          {
             floatingAmountEventsIDRef_ = floatingAmountEventsNode->Attribute("id");
             floatingAmountEvents_ = boost::shared_ptr<FloatingAmountEvents>(new FloatingAmountEvents(floatingAmountEventsNode));
             floatingAmountEvents_->setID(floatingAmountEventsIDRef_);
             IDManager::instance().setID(floatingAmountEventsIDRef_,floatingAmountEvents_);
          }
          else if(floatingAmountEventsNode->Attribute("href")) { floatingAmountEventsIDRef_ = floatingAmountEventsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { floatingAmountEvents_ = boost::shared_ptr<FloatingAmountEvents>(new FloatingAmountEvents(floatingAmountEventsNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Money> ProtectionTerms::getCalculationAmount()
{
   if(!this->calculationAmountIsNull_){
        if(calculationAmountIDRef_ != ""){
             return boost::shared_static_cast<Money>(IDManager::instance().getID(calculationAmountIDRef_));
        }else{
             return this->calculationAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Money>();
   }
}
boost::shared_ptr<CreditEvents> ProtectionTerms::getCreditEvents()
{
   if(!this->creditEventsIsNull_){
        if(creditEventsIDRef_ != ""){
             return boost::shared_static_cast<CreditEvents>(IDManager::instance().getID(creditEventsIDRef_));
        }else{
             return this->creditEvents_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CreditEvents>();
   }
}
boost::shared_ptr<Obligations> ProtectionTerms::getObligations()
{
   if(!this->obligationsIsNull_){
        if(obligationsIDRef_ != ""){
             return boost::shared_static_cast<Obligations>(IDManager::instance().getID(obligationsIDRef_));
        }else{
             return this->obligations_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Obligations>();
   }
}
boost::shared_ptr<FloatingAmountEvents> ProtectionTerms::getFloatingAmountEvents()
{
   if(!this->floatingAmountEventsIsNull_){
        if(floatingAmountEventsIDRef_ != ""){
             return boost::shared_static_cast<FloatingAmountEvents>(IDManager::instance().getID(floatingAmountEventsIDRef_));
        }else{
             return this->floatingAmountEvents_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FloatingAmountEvents>();
   }
}
}

