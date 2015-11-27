// SwapCurveValuation.cpp 
#include "SwapCurveValuation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

SwapCurveValuation::SwapCurveValuation(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //floatingRateIndexNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* floatingRateIndexNode = xmlNode->FirstChildElement("floatingRateIndex");

   if(floatingRateIndexNode){floatingRateIndexIsNull_ = false;}
   else{floatingRateIndexIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- floatingRateIndexNode , address : " << floatingRateIndexNode << std::endl;
   #endif
   if(floatingRateIndexNode)
   {
      if(floatingRateIndexNode->Attribute("href") || floatingRateIndexNode->Attribute("id"))
      {
          if(floatingRateIndexNode->Attribute("id"))
          {
             floatingRateIndexIDRef_ = floatingRateIndexNode->Attribute("id");
             floatingRateIndex_ = boost::shared_ptr<FloatingRateIndex>(new FloatingRateIndex(floatingRateIndexNode));
             floatingRateIndex_->setID(floatingRateIndexIDRef_);
             IDManager::instance().setID(floatingRateIndexIDRef_,floatingRateIndex_);
          }
          else if(floatingRateIndexNode->Attribute("href")) { floatingRateIndexIDRef_ = floatingRateIndexNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { floatingRateIndex_ = boost::shared_ptr<FloatingRateIndex>(new FloatingRateIndex(floatingRateIndexNode));}
   }

   //indexTenorNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* indexTenorNode = xmlNode->FirstChildElement("indexTenor");

   if(indexTenorNode){indexTenorIsNull_ = false;}
   else{indexTenorIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- indexTenorNode , address : " << indexTenorNode << std::endl;
   #endif
   if(indexTenorNode)
   {
      if(indexTenorNode->Attribute("href") || indexTenorNode->Attribute("id"))
      {
          if(indexTenorNode->Attribute("id"))
          {
             indexTenorIDRef_ = indexTenorNode->Attribute("id");
             indexTenor_ = boost::shared_ptr<Period>(new Period(indexTenorNode));
             indexTenor_->setID(indexTenorIDRef_);
             IDManager::instance().setID(indexTenorIDRef_,indexTenor_);
          }
          else if(indexTenorNode->Attribute("href")) { indexTenorIDRef_ = indexTenorNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { indexTenor_ = boost::shared_ptr<Period>(new Period(indexTenorNode));}
   }

   //spreadNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* spreadNode = xmlNode->FirstChildElement("spread");

   if(spreadNode){spreadIsNull_ = false;}
   else{spreadIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- spreadNode , address : " << spreadNode << std::endl;
   #endif
   if(spreadNode)
   {
      if(spreadNode->Attribute("href") || spreadNode->Attribute("id"))
      {
          if(spreadNode->Attribute("id"))
          {
             spreadIDRef_ = spreadNode->Attribute("id");
             spread_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(spreadNode));
             spread_->setID(spreadIDRef_);
             IDManager::instance().setID(spreadIDRef_,spread_);
          }
          else if(spreadNode->Attribute("href")) { spreadIDRef_ = spreadNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { spread_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(spreadNode));}
   }

   //sideNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* sideNode = xmlNode->FirstChildElement("side");

   if(sideNode){sideIsNull_ = false;}
   else{sideIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- sideNode , address : " << sideNode << std::endl;
   #endif
   if(sideNode)
   {
      if(sideNode->Attribute("href") || sideNode->Attribute("id"))
      {
          if(sideNode->Attribute("id"))
          {
             sideIDRef_ = sideNode->Attribute("id");
             side_ = boost::shared_ptr<QuotationSideEnum>(new QuotationSideEnum(sideNode));
             side_->setID(sideIDRef_);
             IDManager::instance().setID(sideIDRef_,side_);
          }
          else if(sideNode->Attribute("href")) { sideIDRef_ = sideNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { side_ = boost::shared_ptr<QuotationSideEnum>(new QuotationSideEnum(sideNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<FloatingRateIndex> SwapCurveValuation::getFloatingRateIndex()
{
   if(!this->floatingRateIndexIsNull_){
        if(floatingRateIndexIDRef_ != ""){
             return boost::shared_static_cast<FloatingRateIndex>(IDManager::instance().getID(floatingRateIndexIDRef_));
        }else{
             return this->floatingRateIndex_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FloatingRateIndex>();
   }
}
boost::shared_ptr<Period> SwapCurveValuation::getIndexTenor()
{
   if(!this->indexTenorIsNull_){
        if(indexTenorIDRef_ != ""){
             return boost::shared_static_cast<Period>(IDManager::instance().getID(indexTenorIDRef_));
        }else{
             return this->indexTenor_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Period>();
   }
}
boost::shared_ptr<XsdTypeDecimal> SwapCurveValuation::getSpread()
{
   if(!this->spreadIsNull_){
        if(spreadIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(spreadIDRef_));
        }else{
             return this->spread_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<QuotationSideEnum> SwapCurveValuation::getSide()
{
   if(!this->sideIsNull_){
        if(sideIDRef_ != ""){
             return boost::shared_static_cast<QuotationSideEnum>(IDManager::instance().getID(sideIDRef_));
        }else{
             return this->side_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<QuotationSideEnum>();
   }
}
}

