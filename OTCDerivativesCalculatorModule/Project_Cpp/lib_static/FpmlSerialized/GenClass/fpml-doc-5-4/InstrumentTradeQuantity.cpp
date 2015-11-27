// InstrumentTradeQuantity.cpp 
#include "InstrumentTradeQuantity.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

InstrumentTradeQuantity::InstrumentTradeQuantity(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //numberNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* numberNode = xmlNode->FirstChildElement("number");

   if(numberNode){numberIsNull_ = false;}
   else{numberIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- numberNode , address : " << numberNode << std::endl;
   #endif
   if(numberNode)
   {
      if(numberNode->Attribute("href") || numberNode->Attribute("id"))
      {
          if(numberNode->Attribute("id"))
          {
             numberIDRef_ = numberNode->Attribute("id");
             number_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(numberNode));
             number_->setID(numberIDRef_);
             IDManager::instance().setID(numberIDRef_,number_);
          }
          else if(numberNode->Attribute("href")) { numberIDRef_ = numberNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { number_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(numberNode));}
   }

   //nominalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* nominalNode = xmlNode->FirstChildElement("nominal");

   if(nominalNode){nominalIsNull_ = false;}
   else{nominalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- nominalNode , address : " << nominalNode << std::endl;
   #endif
   if(nominalNode)
   {
      if(nominalNode->Attribute("href") || nominalNode->Attribute("id"))
      {
          if(nominalNode->Attribute("id"))
          {
             nominalIDRef_ = nominalNode->Attribute("id");
             nominal_ = boost::shared_ptr<Money>(new Money(nominalNode));
             nominal_->setID(nominalIDRef_);
             IDManager::instance().setID(nominalIDRef_,nominal_);
          }
          else if(nominalNode->Attribute("href")) { nominalIDRef_ = nominalNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { nominal_ = boost::shared_ptr<Money>(new Money(nominalNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDecimal> InstrumentTradeQuantity::getNumber()
{
   if(!this->numberIsNull_){
        if(numberIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(numberIDRef_));
        }else{
             return this->number_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<Money> InstrumentTradeQuantity::getNominal()
{
   if(!this->nominalIsNull_){
        if(nominalIDRef_ != ""){
             return boost::shared_static_cast<Money>(IDManager::instance().getID(nominalIDRef_));
        }else{
             return this->nominal_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Money>();
   }
}
}

