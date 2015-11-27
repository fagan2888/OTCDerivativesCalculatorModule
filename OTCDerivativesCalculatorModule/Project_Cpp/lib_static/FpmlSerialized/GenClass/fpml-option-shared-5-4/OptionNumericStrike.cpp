// OptionNumericStrike.cpp 
#include "OptionNumericStrike.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

OptionNumericStrike::OptionNumericStrike(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //strikePriceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* strikePriceNode = xmlNode->FirstChildElement("strikePrice");

   if(strikePriceNode){strikePriceIsNull_ = false;}
   else{strikePriceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- strikePriceNode , address : " << strikePriceNode << std::endl;
   #endif
   if(strikePriceNode)
   {
      if(strikePriceNode->Attribute("href") || strikePriceNode->Attribute("id"))
      {
          if(strikePriceNode->Attribute("id"))
          {
             strikePriceIDRef_ = strikePriceNode->Attribute("id");
             strikePrice_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(strikePriceNode));
             strikePrice_->setID(strikePriceIDRef_);
             IDManager::instance().setID(strikePriceIDRef_,strikePrice_);
          }
          else if(strikePriceNode->Attribute("href")) { strikePriceIDRef_ = strikePriceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { strikePrice_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(strikePriceNode));}
   }

   //strikePercentageNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* strikePercentageNode = xmlNode->FirstChildElement("strikePercentage");

   if(strikePercentageNode){strikePercentageIsNull_ = false;}
   else{strikePercentageIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- strikePercentageNode , address : " << strikePercentageNode << std::endl;
   #endif
   if(strikePercentageNode)
   {
      if(strikePercentageNode->Attribute("href") || strikePercentageNode->Attribute("id"))
      {
          if(strikePercentageNode->Attribute("id"))
          {
             strikePercentageIDRef_ = strikePercentageNode->Attribute("id");
             strikePercentage_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(strikePercentageNode));
             strikePercentage_->setID(strikePercentageIDRef_);
             IDManager::instance().setID(strikePercentageIDRef_,strikePercentage_);
          }
          else if(strikePercentageNode->Attribute("href")) { strikePercentageIDRef_ = strikePercentageNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { strikePercentage_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(strikePercentageNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDecimal> OptionNumericStrike::getStrikePrice()
{
   if(!this->strikePriceIsNull_){
        if(strikePriceIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(strikePriceIDRef_));
        }else{
             return this->strikePrice_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<XsdTypeDecimal> OptionNumericStrike::getStrikePercentage()
{
   if(!this->strikePercentageIsNull_){
        if(strikePercentageIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(strikePercentageIDRef_));
        }else{
             return this->strikePercentage_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
}

