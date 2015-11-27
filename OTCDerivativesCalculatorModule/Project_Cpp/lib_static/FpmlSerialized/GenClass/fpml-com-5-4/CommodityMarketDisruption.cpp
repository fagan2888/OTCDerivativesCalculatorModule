// CommodityMarketDisruption.cpp 
#include "CommodityMarketDisruption.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CommodityMarketDisruption::CommodityMarketDisruption(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //marketDisruptionEventsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* marketDisruptionEventsNode = xmlNode->FirstChildElement("marketDisruptionEvents");

   if(marketDisruptionEventsNode){marketDisruptionEventsIsNull_ = false;}
   else{marketDisruptionEventsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- marketDisruptionEventsNode , address : " << marketDisruptionEventsNode << std::endl;
   #endif
   if(marketDisruptionEventsNode)
   {
      if(marketDisruptionEventsNode->Attribute("href") || marketDisruptionEventsNode->Attribute("id"))
      {
          if(marketDisruptionEventsNode->Attribute("id"))
          {
             marketDisruptionEventsIDRef_ = marketDisruptionEventsNode->Attribute("id");
             marketDisruptionEvents_ = boost::shared_ptr<MarketDisruptionEventsEnum>(new MarketDisruptionEventsEnum(marketDisruptionEventsNode));
             marketDisruptionEvents_->setID(marketDisruptionEventsIDRef_);
             IDManager::instance().setID(marketDisruptionEventsIDRef_,marketDisruptionEvents_);
          }
          else if(marketDisruptionEventsNode->Attribute("href")) { marketDisruptionEventsIDRef_ = marketDisruptionEventsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { marketDisruptionEvents_ = boost::shared_ptr<MarketDisruptionEventsEnum>(new MarketDisruptionEventsEnum(marketDisruptionEventsNode));}
   }

   //additionalMarketDisruptionEventNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* additionalMarketDisruptionEventNode = xmlNode->FirstChildElement("additionalMarketDisruptionEvent");

   if(additionalMarketDisruptionEventNode){additionalMarketDisruptionEventIsNull_ = false;}
   else{additionalMarketDisruptionEventIsNull_ = true;}

   if(additionalMarketDisruptionEventNode)
   {
      for(additionalMarketDisruptionEventNode; additionalMarketDisruptionEventNode; additionalMarketDisruptionEventNode = additionalMarketDisruptionEventNode->NextSiblingElement("additionalMarketDisruptionEvent")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- additionalMarketDisruptionEventNode , address : " << additionalMarketDisruptionEventNode << std::endl;
          #endif
          if(additionalMarketDisruptionEventNode->Attribute("href") || additionalMarketDisruptionEventNode->Attribute("id"))
          {
              if(additionalMarketDisruptionEventNode->Attribute("id"))
              {
                  additionalMarketDisruptionEventIDRef_ = additionalMarketDisruptionEventNode->Attribute("id");
                  additionalMarketDisruptionEvent_.push_back(boost::shared_ptr<MarketDisruptionEvent>(new MarketDisruptionEvent(additionalMarketDisruptionEventNode)));
                  additionalMarketDisruptionEvent_.back()->setID(additionalMarketDisruptionEventIDRef_);
                  IDManager::instance().setID(additionalMarketDisruptionEventIDRef_, additionalMarketDisruptionEvent_.back());
              }
              else if(additionalMarketDisruptionEventNode->Attribute("href")) { additionalMarketDisruptionEventIDRef_ = additionalMarketDisruptionEventNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { additionalMarketDisruptionEvent_.push_back(boost::shared_ptr<MarketDisruptionEvent>(new MarketDisruptionEvent(additionalMarketDisruptionEventNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- additionalMarketDisruptionEventNode , address : " << additionalMarketDisruptionEventNode << std::endl;
       #endif
   }

   //marketDisruptionEventNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* marketDisruptionEventNode = xmlNode->FirstChildElement("marketDisruptionEvent");

   if(marketDisruptionEventNode){marketDisruptionEventIsNull_ = false;}
   else{marketDisruptionEventIsNull_ = true;}

   if(marketDisruptionEventNode)
   {
      for(marketDisruptionEventNode; marketDisruptionEventNode; marketDisruptionEventNode = marketDisruptionEventNode->NextSiblingElement("marketDisruptionEvent")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- marketDisruptionEventNode , address : " << marketDisruptionEventNode << std::endl;
          #endif
          if(marketDisruptionEventNode->Attribute("href") || marketDisruptionEventNode->Attribute("id"))
          {
              if(marketDisruptionEventNode->Attribute("id"))
              {
                  marketDisruptionEventIDRef_ = marketDisruptionEventNode->Attribute("id");
                  marketDisruptionEvent_.push_back(boost::shared_ptr<MarketDisruptionEvent>(new MarketDisruptionEvent(marketDisruptionEventNode)));
                  marketDisruptionEvent_.back()->setID(marketDisruptionEventIDRef_);
                  IDManager::instance().setID(marketDisruptionEventIDRef_, marketDisruptionEvent_.back());
              }
              else if(marketDisruptionEventNode->Attribute("href")) { marketDisruptionEventIDRef_ = marketDisruptionEventNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { marketDisruptionEvent_.push_back(boost::shared_ptr<MarketDisruptionEvent>(new MarketDisruptionEvent(marketDisruptionEventNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- marketDisruptionEventNode , address : " << marketDisruptionEventNode << std::endl;
       #endif
   }

   //disruptionFallbacksNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* disruptionFallbacksNode = xmlNode->FirstChildElement("disruptionFallbacks");

   if(disruptionFallbacksNode){disruptionFallbacksIsNull_ = false;}
   else{disruptionFallbacksIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- disruptionFallbacksNode , address : " << disruptionFallbacksNode << std::endl;
   #endif
   if(disruptionFallbacksNode)
   {
      if(disruptionFallbacksNode->Attribute("href") || disruptionFallbacksNode->Attribute("id"))
      {
          if(disruptionFallbacksNode->Attribute("id"))
          {
             disruptionFallbacksIDRef_ = disruptionFallbacksNode->Attribute("id");
             disruptionFallbacks_ = boost::shared_ptr<DisruptionFallbacksEnum>(new DisruptionFallbacksEnum(disruptionFallbacksNode));
             disruptionFallbacks_->setID(disruptionFallbacksIDRef_);
             IDManager::instance().setID(disruptionFallbacksIDRef_,disruptionFallbacks_);
          }
          else if(disruptionFallbacksNode->Attribute("href")) { disruptionFallbacksIDRef_ = disruptionFallbacksNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { disruptionFallbacks_ = boost::shared_ptr<DisruptionFallbacksEnum>(new DisruptionFallbacksEnum(disruptionFallbacksNode));}
   }

   //disruptionFallbackNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* disruptionFallbackNode = xmlNode->FirstChildElement("disruptionFallback");

   if(disruptionFallbackNode){disruptionFallbackIsNull_ = false;}
   else{disruptionFallbackIsNull_ = true;}

   if(disruptionFallbackNode)
   {
      for(disruptionFallbackNode; disruptionFallbackNode; disruptionFallbackNode = disruptionFallbackNode->NextSiblingElement("disruptionFallback")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- disruptionFallbackNode , address : " << disruptionFallbackNode << std::endl;
          #endif
          if(disruptionFallbackNode->Attribute("href") || disruptionFallbackNode->Attribute("id"))
          {
              if(disruptionFallbackNode->Attribute("id"))
              {
                  disruptionFallbackIDRef_ = disruptionFallbackNode->Attribute("id");
                  disruptionFallback_.push_back(boost::shared_ptr<SequencedDisruptionFallback>(new SequencedDisruptionFallback(disruptionFallbackNode)));
                  disruptionFallback_.back()->setID(disruptionFallbackIDRef_);
                  IDManager::instance().setID(disruptionFallbackIDRef_, disruptionFallback_.back());
              }
              else if(disruptionFallbackNode->Attribute("href")) { disruptionFallbackIDRef_ = disruptionFallbackNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { disruptionFallback_.push_back(boost::shared_ptr<SequencedDisruptionFallback>(new SequencedDisruptionFallback(disruptionFallbackNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- disruptionFallbackNode , address : " << disruptionFallbackNode << std::endl;
       #endif
   }

   //fallbackReferencePriceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fallbackReferencePriceNode = xmlNode->FirstChildElement("fallbackReferencePrice");

   if(fallbackReferencePriceNode){fallbackReferencePriceIsNull_ = false;}
   else{fallbackReferencePriceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fallbackReferencePriceNode , address : " << fallbackReferencePriceNode << std::endl;
   #endif
   if(fallbackReferencePriceNode)
   {
      if(fallbackReferencePriceNode->Attribute("href") || fallbackReferencePriceNode->Attribute("id"))
      {
          if(fallbackReferencePriceNode->Attribute("id"))
          {
             fallbackReferencePriceIDRef_ = fallbackReferencePriceNode->Attribute("id");
             fallbackReferencePrice_ = boost::shared_ptr<Underlyer>(new Underlyer(fallbackReferencePriceNode));
             fallbackReferencePrice_->setID(fallbackReferencePriceIDRef_);
             IDManager::instance().setID(fallbackReferencePriceIDRef_,fallbackReferencePrice_);
          }
          else if(fallbackReferencePriceNode->Attribute("href")) { fallbackReferencePriceIDRef_ = fallbackReferencePriceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fallbackReferencePrice_ = boost::shared_ptr<Underlyer>(new Underlyer(fallbackReferencePriceNode));}
   }

   //maximumNumberOfDaysOfDisruptionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* maximumNumberOfDaysOfDisruptionNode = xmlNode->FirstChildElement("maximumNumberOfDaysOfDisruption");

   if(maximumNumberOfDaysOfDisruptionNode){maximumNumberOfDaysOfDisruptionIsNull_ = false;}
   else{maximumNumberOfDaysOfDisruptionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- maximumNumberOfDaysOfDisruptionNode , address : " << maximumNumberOfDaysOfDisruptionNode << std::endl;
   #endif
   if(maximumNumberOfDaysOfDisruptionNode)
   {
      if(maximumNumberOfDaysOfDisruptionNode->Attribute("href") || maximumNumberOfDaysOfDisruptionNode->Attribute("id"))
      {
          if(maximumNumberOfDaysOfDisruptionNode->Attribute("id"))
          {
             maximumNumberOfDaysOfDisruptionIDRef_ = maximumNumberOfDaysOfDisruptionNode->Attribute("id");
             maximumNumberOfDaysOfDisruption_ = boost::shared_ptr<XsdTypeNonNegativeInteger>(new XsdTypeNonNegativeInteger(maximumNumberOfDaysOfDisruptionNode));
             maximumNumberOfDaysOfDisruption_->setID(maximumNumberOfDaysOfDisruptionIDRef_);
             IDManager::instance().setID(maximumNumberOfDaysOfDisruptionIDRef_,maximumNumberOfDaysOfDisruption_);
          }
          else if(maximumNumberOfDaysOfDisruptionNode->Attribute("href")) { maximumNumberOfDaysOfDisruptionIDRef_ = maximumNumberOfDaysOfDisruptionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { maximumNumberOfDaysOfDisruption_ = boost::shared_ptr<XsdTypeNonNegativeInteger>(new XsdTypeNonNegativeInteger(maximumNumberOfDaysOfDisruptionNode));}
   }

   //priceMaterialityPercentageNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* priceMaterialityPercentageNode = xmlNode->FirstChildElement("priceMaterialityPercentage");

   if(priceMaterialityPercentageNode){priceMaterialityPercentageIsNull_ = false;}
   else{priceMaterialityPercentageIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- priceMaterialityPercentageNode , address : " << priceMaterialityPercentageNode << std::endl;
   #endif
   if(priceMaterialityPercentageNode)
   {
      if(priceMaterialityPercentageNode->Attribute("href") || priceMaterialityPercentageNode->Attribute("id"))
      {
          if(priceMaterialityPercentageNode->Attribute("id"))
          {
             priceMaterialityPercentageIDRef_ = priceMaterialityPercentageNode->Attribute("id");
             priceMaterialityPercentage_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(priceMaterialityPercentageNode));
             priceMaterialityPercentage_->setID(priceMaterialityPercentageIDRef_);
             IDManager::instance().setID(priceMaterialityPercentageIDRef_,priceMaterialityPercentage_);
          }
          else if(priceMaterialityPercentageNode->Attribute("href")) { priceMaterialityPercentageIDRef_ = priceMaterialityPercentageNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { priceMaterialityPercentage_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(priceMaterialityPercentageNode));}
   }

   //minimumFuturesContractsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* minimumFuturesContractsNode = xmlNode->FirstChildElement("minimumFuturesContracts");

   if(minimumFuturesContractsNode){minimumFuturesContractsIsNull_ = false;}
   else{minimumFuturesContractsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- minimumFuturesContractsNode , address : " << minimumFuturesContractsNode << std::endl;
   #endif
   if(minimumFuturesContractsNode)
   {
      if(minimumFuturesContractsNode->Attribute("href") || minimumFuturesContractsNode->Attribute("id"))
      {
          if(minimumFuturesContractsNode->Attribute("id"))
          {
             minimumFuturesContractsIDRef_ = minimumFuturesContractsNode->Attribute("id");
             minimumFuturesContracts_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(minimumFuturesContractsNode));
             minimumFuturesContracts_->setID(minimumFuturesContractsIDRef_);
             IDManager::instance().setID(minimumFuturesContractsIDRef_,minimumFuturesContracts_);
          }
          else if(minimumFuturesContractsNode->Attribute("href")) { minimumFuturesContractsIDRef_ = minimumFuturesContractsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { minimumFuturesContracts_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(minimumFuturesContractsNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<MarketDisruptionEventsEnum> CommodityMarketDisruption::getMarketDisruptionEvents()
{
   if(!this->marketDisruptionEventsIsNull_){
        if(marketDisruptionEventsIDRef_ != ""){
             return boost::shared_static_cast<MarketDisruptionEventsEnum>(IDManager::instance().getID(marketDisruptionEventsIDRef_));
        }else{
             return this->marketDisruptionEvents_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<MarketDisruptionEventsEnum>();
   }
}
std::vector<boost::shared_ptr<MarketDisruptionEvent>> CommodityMarketDisruption::getAdditionalMarketDisruptionEvent()
{
   if(!this->additionalMarketDisruptionEventIsNull_){
        if(additionalMarketDisruptionEventIDRef_ != ""){
             return this->additionalMarketDisruptionEvent_;
        }else{
             return this->additionalMarketDisruptionEvent_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<MarketDisruptionEvent>>();
   }
}
std::vector<boost::shared_ptr<MarketDisruptionEvent>> CommodityMarketDisruption::getMarketDisruptionEvent()
{
   if(!this->marketDisruptionEventIsNull_){
        if(marketDisruptionEventIDRef_ != ""){
             return this->marketDisruptionEvent_;
        }else{
             return this->marketDisruptionEvent_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<MarketDisruptionEvent>>();
   }
}
boost::shared_ptr<DisruptionFallbacksEnum> CommodityMarketDisruption::getDisruptionFallbacks()
{
   if(!this->disruptionFallbacksIsNull_){
        if(disruptionFallbacksIDRef_ != ""){
             return boost::shared_static_cast<DisruptionFallbacksEnum>(IDManager::instance().getID(disruptionFallbacksIDRef_));
        }else{
             return this->disruptionFallbacks_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DisruptionFallbacksEnum>();
   }
}
std::vector<boost::shared_ptr<SequencedDisruptionFallback>> CommodityMarketDisruption::getDisruptionFallback()
{
   if(!this->disruptionFallbackIsNull_){
        if(disruptionFallbackIDRef_ != ""){
             return this->disruptionFallback_;
        }else{
             return this->disruptionFallback_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<SequencedDisruptionFallback>>();
   }
}
boost::shared_ptr<Underlyer> CommodityMarketDisruption::getFallbackReferencePrice()
{
   if(!this->fallbackReferencePriceIsNull_){
        if(fallbackReferencePriceIDRef_ != ""){
             return boost::shared_static_cast<Underlyer>(IDManager::instance().getID(fallbackReferencePriceIDRef_));
        }else{
             return this->fallbackReferencePrice_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Underlyer>();
   }
}
boost::shared_ptr<XsdTypeNonNegativeInteger> CommodityMarketDisruption::getMaximumNumberOfDaysOfDisruption()
{
   if(!this->maximumNumberOfDaysOfDisruptionIsNull_){
        if(maximumNumberOfDaysOfDisruptionIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeNonNegativeInteger>(IDManager::instance().getID(maximumNumberOfDaysOfDisruptionIDRef_));
        }else{
             return this->maximumNumberOfDaysOfDisruption_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeNonNegativeInteger>();
   }
}
boost::shared_ptr<XsdTypeDecimal> CommodityMarketDisruption::getPriceMaterialityPercentage()
{
   if(!this->priceMaterialityPercentageIsNull_){
        if(priceMaterialityPercentageIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(priceMaterialityPercentageIDRef_));
        }else{
             return this->priceMaterialityPercentage_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<XsdTypePositiveInteger> CommodityMarketDisruption::getMinimumFuturesContracts()
{
   if(!this->minimumFuturesContractsIsNull_){
        if(minimumFuturesContractsIDRef_ != ""){
             return boost::shared_static_cast<XsdTypePositiveInteger>(IDManager::instance().getID(minimumFuturesContractsIDRef_));
        }else{
             return this->minimumFuturesContracts_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypePositiveInteger>();
   }
}
}

