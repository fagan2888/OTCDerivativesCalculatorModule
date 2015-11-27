// YieldCurveMethod.cpp 
#include "YieldCurveMethod.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

YieldCurveMethod::YieldCurveMethod(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //settlementRateSourceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* settlementRateSourceNode = xmlNode->FirstChildElement("settlementRateSource");

   if(settlementRateSourceNode){settlementRateSourceIsNull_ = false;}
   else{settlementRateSourceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settlementRateSourceNode , address : " << settlementRateSourceNode << std::endl;
   #endif
   if(settlementRateSourceNode)
   {
      if(settlementRateSourceNode->Attribute("href") || settlementRateSourceNode->Attribute("id"))
      {
          if(settlementRateSourceNode->Attribute("id"))
          {
             settlementRateSourceIDRef_ = settlementRateSourceNode->Attribute("id");
             settlementRateSource_ = boost::shared_ptr<SettlementRateSource>(new SettlementRateSource(settlementRateSourceNode));
             settlementRateSource_->setID(settlementRateSourceIDRef_);
             IDManager::instance().setID(settlementRateSourceIDRef_,settlementRateSource_);
          }
          else if(settlementRateSourceNode->Attribute("href")) { settlementRateSourceIDRef_ = settlementRateSourceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { settlementRateSource_ = boost::shared_ptr<SettlementRateSource>(new SettlementRateSource(settlementRateSourceNode));}
   }

   //quotationRateTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* quotationRateTypeNode = xmlNode->FirstChildElement("quotationRateType");

   if(quotationRateTypeNode){quotationRateTypeIsNull_ = false;}
   else{quotationRateTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- quotationRateTypeNode , address : " << quotationRateTypeNode << std::endl;
   #endif
   if(quotationRateTypeNode)
   {
      if(quotationRateTypeNode->Attribute("href") || quotationRateTypeNode->Attribute("id"))
      {
          if(quotationRateTypeNode->Attribute("id"))
          {
             quotationRateTypeIDRef_ = quotationRateTypeNode->Attribute("id");
             quotationRateType_ = boost::shared_ptr<QuotationRateTypeEnum>(new QuotationRateTypeEnum(quotationRateTypeNode));
             quotationRateType_->setID(quotationRateTypeIDRef_);
             IDManager::instance().setID(quotationRateTypeIDRef_,quotationRateType_);
          }
          else if(quotationRateTypeNode->Attribute("href")) { quotationRateTypeIDRef_ = quotationRateTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { quotationRateType_ = boost::shared_ptr<QuotationRateTypeEnum>(new QuotationRateTypeEnum(quotationRateTypeNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<SettlementRateSource> YieldCurveMethod::getSettlementRateSource()
{
   if(!this->settlementRateSourceIsNull_){
        if(settlementRateSourceIDRef_ != ""){
             return boost::shared_static_cast<SettlementRateSource>(IDManager::instance().getID(settlementRateSourceIDRef_));
        }else{
             return this->settlementRateSource_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<SettlementRateSource>();
   }
}
boost::shared_ptr<QuotationRateTypeEnum> YieldCurveMethod::getQuotationRateType()
{
   if(!this->quotationRateTypeIsNull_){
        if(quotationRateTypeIDRef_ != ""){
             return boost::shared_static_cast<QuotationRateTypeEnum>(IDManager::instance().getID(quotationRateTypeIDRef_));
        }else{
             return this->quotationRateType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<QuotationRateTypeEnum>();
   }
}
}

