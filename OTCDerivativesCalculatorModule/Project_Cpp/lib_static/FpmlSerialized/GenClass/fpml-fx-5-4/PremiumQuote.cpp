// PremiumQuote.cpp 
#include "PremiumQuote.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

PremiumQuote::PremiumQuote(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //valueNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* valueNode = xmlNode->FirstChildElement("value");

   if(valueNode){valueIsNull_ = false;}
   else{valueIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- valueNode , address : " << valueNode << std::endl;
   #endif
   if(valueNode)
   {
      if(valueNode->Attribute("href") || valueNode->Attribute("id"))
      {
          if(valueNode->Attribute("id"))
          {
             valueIDRef_ = valueNode->Attribute("id");
             value_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(valueNode));
             value_->setID(valueIDRef_);
             IDManager::instance().setID(valueIDRef_,value_);
          }
          else if(valueNode->Attribute("href")) { valueIDRef_ = valueNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { value_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(valueNode));}
   }

   //quoteBasisNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* quoteBasisNode = xmlNode->FirstChildElement("quoteBasis");

   if(quoteBasisNode){quoteBasisIsNull_ = false;}
   else{quoteBasisIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- quoteBasisNode , address : " << quoteBasisNode << std::endl;
   #endif
   if(quoteBasisNode)
   {
      if(quoteBasisNode->Attribute("href") || quoteBasisNode->Attribute("id"))
      {
          if(quoteBasisNode->Attribute("id"))
          {
             quoteBasisIDRef_ = quoteBasisNode->Attribute("id");
             quoteBasis_ = boost::shared_ptr<PremiumQuoteBasisEnum>(new PremiumQuoteBasisEnum(quoteBasisNode));
             quoteBasis_->setID(quoteBasisIDRef_);
             IDManager::instance().setID(quoteBasisIDRef_,quoteBasis_);
          }
          else if(quoteBasisNode->Attribute("href")) { quoteBasisIDRef_ = quoteBasisNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { quoteBasis_ = boost::shared_ptr<PremiumQuoteBasisEnum>(new PremiumQuoteBasisEnum(quoteBasisNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDecimal> PremiumQuote::getValue()
{
   if(!this->valueIsNull_){
        if(valueIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(valueIDRef_));
        }else{
             return this->value_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<PremiumQuoteBasisEnum> PremiumQuote::getQuoteBasis()
{
   if(!this->quoteBasisIsNull_){
        if(quoteBasisIDRef_ != ""){
             return boost::shared_static_cast<PremiumQuoteBasisEnum>(IDManager::instance().getID(quoteBasisIDRef_));
        }else{
             return this->quoteBasis_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PremiumQuoteBasisEnum>();
   }
}
}

