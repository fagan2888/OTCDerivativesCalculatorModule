using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CommodityMarketDisruption : ISerialized
    {
        public CommodityMarketDisruption(XmlNode xmlNode)
        {
            XmlNode marketDisruptionEventsNode = xmlNode.SelectSingleNode("marketDisruptionEvents");
            
            if (marketDisruptionEventsNode != null)
            {
                if (marketDisruptionEventsNode.Attributes["href"] != null || marketDisruptionEventsNode.Attributes["id"] != null) 
                {
                    if (marketDisruptionEventsNode.Attributes["id"] != null) 
                    {
                        marketDisruptionEventsIDRef_ = marketDisruptionEventsNode.Attributes["id"].Value;
                        MarketDisruptionEventsEnum ob = new MarketDisruptionEventsEnum(marketDisruptionEventsNode);
                        IDManager.SetID(marketDisruptionEventsIDRef_, ob);
                    }
                    else if (marketDisruptionEventsNode.Attributes["href"] != null)
                    {
                        marketDisruptionEventsIDRef_ = marketDisruptionEventsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        marketDisruptionEvents_ = new MarketDisruptionEventsEnum(marketDisruptionEventsNode);
                    }
                }
                else
                {
                    marketDisruptionEvents_ = new MarketDisruptionEventsEnum(marketDisruptionEventsNode);
                }
            }
            
        
            XmlNodeList additionalMarketDisruptionEventNodeList = xmlNode.SelectNodes("additionalMarketDisruptionEvent");
            
            if (additionalMarketDisruptionEventNodeList != null)
            {
                this.additionalMarketDisruptionEvent_ = new List<MarketDisruptionEvent>();
                foreach (XmlNode item in additionalMarketDisruptionEventNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            additionalMarketDisruptionEventIDRef_ = item.Attributes["id"].Value;
                            additionalMarketDisruptionEvent_.Add(new MarketDisruptionEvent(item));
                            IDManager.SetID(additionalMarketDisruptionEventIDRef_, additionalMarketDisruptionEvent_[additionalMarketDisruptionEvent_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            additionalMarketDisruptionEventIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        additionalMarketDisruptionEvent_.Add(new MarketDisruptionEvent(item));
                        }
                    }
                    else
                    {
                        additionalMarketDisruptionEvent_.Add(new MarketDisruptionEvent(item));
                    }
                }
            }
            
        
            XmlNodeList marketDisruptionEventNodeList = xmlNode.SelectNodes("marketDisruptionEvent");
            
            if (marketDisruptionEventNodeList != null)
            {
                this.marketDisruptionEvent_ = new List<MarketDisruptionEvent>();
                foreach (XmlNode item in marketDisruptionEventNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            marketDisruptionEventIDRef_ = item.Attributes["id"].Value;
                            marketDisruptionEvent_.Add(new MarketDisruptionEvent(item));
                            IDManager.SetID(marketDisruptionEventIDRef_, marketDisruptionEvent_[marketDisruptionEvent_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            marketDisruptionEventIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        marketDisruptionEvent_.Add(new MarketDisruptionEvent(item));
                        }
                    }
                    else
                    {
                        marketDisruptionEvent_.Add(new MarketDisruptionEvent(item));
                    }
                }
            }
            
        
            XmlNode disruptionFallbacksNode = xmlNode.SelectSingleNode("disruptionFallbacks");
            
            if (disruptionFallbacksNode != null)
            {
                if (disruptionFallbacksNode.Attributes["href"] != null || disruptionFallbacksNode.Attributes["id"] != null) 
                {
                    if (disruptionFallbacksNode.Attributes["id"] != null) 
                    {
                        disruptionFallbacksIDRef_ = disruptionFallbacksNode.Attributes["id"].Value;
                        DisruptionFallbacksEnum ob = new DisruptionFallbacksEnum(disruptionFallbacksNode);
                        IDManager.SetID(disruptionFallbacksIDRef_, ob);
                    }
                    else if (disruptionFallbacksNode.Attributes["href"] != null)
                    {
                        disruptionFallbacksIDRef_ = disruptionFallbacksNode.Attributes["href"].Value;
                    }
                    else
                    {
                        disruptionFallbacks_ = new DisruptionFallbacksEnum(disruptionFallbacksNode);
                    }
                }
                else
                {
                    disruptionFallbacks_ = new DisruptionFallbacksEnum(disruptionFallbacksNode);
                }
            }
            
        
            XmlNodeList disruptionFallbackNodeList = xmlNode.SelectNodes("disruptionFallback");
            
            if (disruptionFallbackNodeList != null)
            {
                this.disruptionFallback_ = new List<SequencedDisruptionFallback>();
                foreach (XmlNode item in disruptionFallbackNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            disruptionFallbackIDRef_ = item.Attributes["id"].Value;
                            disruptionFallback_.Add(new SequencedDisruptionFallback(item));
                            IDManager.SetID(disruptionFallbackIDRef_, disruptionFallback_[disruptionFallback_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            disruptionFallbackIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        disruptionFallback_.Add(new SequencedDisruptionFallback(item));
                        }
                    }
                    else
                    {
                        disruptionFallback_.Add(new SequencedDisruptionFallback(item));
                    }
                }
            }
            
        
            XmlNode fallbackReferencePriceNode = xmlNode.SelectSingleNode("fallbackReferencePrice");
            
            if (fallbackReferencePriceNode != null)
            {
                if (fallbackReferencePriceNode.Attributes["href"] != null || fallbackReferencePriceNode.Attributes["id"] != null) 
                {
                    if (fallbackReferencePriceNode.Attributes["id"] != null) 
                    {
                        fallbackReferencePriceIDRef_ = fallbackReferencePriceNode.Attributes["id"].Value;
                        Underlyer ob = new Underlyer(fallbackReferencePriceNode);
                        IDManager.SetID(fallbackReferencePriceIDRef_, ob);
                    }
                    else if (fallbackReferencePriceNode.Attributes["href"] != null)
                    {
                        fallbackReferencePriceIDRef_ = fallbackReferencePriceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fallbackReferencePrice_ = new Underlyer(fallbackReferencePriceNode);
                    }
                }
                else
                {
                    fallbackReferencePrice_ = new Underlyer(fallbackReferencePriceNode);
                }
            }
            
        
            XmlNode maximumNumberOfDaysOfDisruptionNode = xmlNode.SelectSingleNode("maximumNumberOfDaysOfDisruption");
            
            if (maximumNumberOfDaysOfDisruptionNode != null)
            {
                if (maximumNumberOfDaysOfDisruptionNode.Attributes["href"] != null || maximumNumberOfDaysOfDisruptionNode.Attributes["id"] != null) 
                {
                    if (maximumNumberOfDaysOfDisruptionNode.Attributes["id"] != null) 
                    {
                        maximumNumberOfDaysOfDisruptionIDRef_ = maximumNumberOfDaysOfDisruptionNode.Attributes["id"].Value;
                        XsdTypeNonNegativeInteger ob = new XsdTypeNonNegativeInteger(maximumNumberOfDaysOfDisruptionNode);
                        IDManager.SetID(maximumNumberOfDaysOfDisruptionIDRef_, ob);
                    }
                    else if (maximumNumberOfDaysOfDisruptionNode.Attributes["href"] != null)
                    {
                        maximumNumberOfDaysOfDisruptionIDRef_ = maximumNumberOfDaysOfDisruptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        maximumNumberOfDaysOfDisruption_ = new XsdTypeNonNegativeInteger(maximumNumberOfDaysOfDisruptionNode);
                    }
                }
                else
                {
                    maximumNumberOfDaysOfDisruption_ = new XsdTypeNonNegativeInteger(maximumNumberOfDaysOfDisruptionNode);
                }
            }
            
        
            XmlNode priceMaterialityPercentageNode = xmlNode.SelectSingleNode("priceMaterialityPercentage");
            
            if (priceMaterialityPercentageNode != null)
            {
                if (priceMaterialityPercentageNode.Attributes["href"] != null || priceMaterialityPercentageNode.Attributes["id"] != null) 
                {
                    if (priceMaterialityPercentageNode.Attributes["id"] != null) 
                    {
                        priceMaterialityPercentageIDRef_ = priceMaterialityPercentageNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(priceMaterialityPercentageNode);
                        IDManager.SetID(priceMaterialityPercentageIDRef_, ob);
                    }
                    else if (priceMaterialityPercentageNode.Attributes["href"] != null)
                    {
                        priceMaterialityPercentageIDRef_ = priceMaterialityPercentageNode.Attributes["href"].Value;
                    }
                    else
                    {
                        priceMaterialityPercentage_ = new XsdTypeDecimal(priceMaterialityPercentageNode);
                    }
                }
                else
                {
                    priceMaterialityPercentage_ = new XsdTypeDecimal(priceMaterialityPercentageNode);
                }
            }
            
        
            XmlNode minimumFuturesContractsNode = xmlNode.SelectSingleNode("minimumFuturesContracts");
            
            if (minimumFuturesContractsNode != null)
            {
                if (minimumFuturesContractsNode.Attributes["href"] != null || minimumFuturesContractsNode.Attributes["id"] != null) 
                {
                    if (minimumFuturesContractsNode.Attributes["id"] != null) 
                    {
                        minimumFuturesContractsIDRef_ = minimumFuturesContractsNode.Attributes["id"].Value;
                        XsdTypePositiveInteger ob = new XsdTypePositiveInteger(minimumFuturesContractsNode);
                        IDManager.SetID(minimumFuturesContractsIDRef_, ob);
                    }
                    else if (minimumFuturesContractsNode.Attributes["href"] != null)
                    {
                        minimumFuturesContractsIDRef_ = minimumFuturesContractsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        minimumFuturesContracts_ = new XsdTypePositiveInteger(minimumFuturesContractsNode);
                    }
                }
                else
                {
                    minimumFuturesContracts_ = new XsdTypePositiveInteger(minimumFuturesContractsNode);
                }
            }
            
        
        }
        
    
        #region MarketDisruptionEvents_
        private MarketDisruptionEventsEnum marketDisruptionEvents_;
        public MarketDisruptionEventsEnum MarketDisruptionEvents_
        {
            get
            {
                if (this.marketDisruptionEvents_ != null)
                {
                    return this.marketDisruptionEvents_; 
                }
                else if (this.marketDisruptionEventsIDRef_ != null)
                {
                    marketDisruptionEvents_ = IDManager.getID(marketDisruptionEventsIDRef_) as MarketDisruptionEventsEnum;
                    return this.marketDisruptionEvents_; 
                }
                else
                {
                      return this.marketDisruptionEvents_; 
                }
            }
            set
            {
                if (this.marketDisruptionEvents_ != value)
                {
                    this.marketDisruptionEvents_ = value;
                }
            }
        }
        #endregion
        
        public string marketDisruptionEventsIDRef_ { get; set; }
        #region AdditionalMarketDisruptionEvent_
        private List<MarketDisruptionEvent> additionalMarketDisruptionEvent_;
        public List<MarketDisruptionEvent> AdditionalMarketDisruptionEvent_
        {
            get
            {
                if (this.additionalMarketDisruptionEvent_ != null)
                {
                    return this.additionalMarketDisruptionEvent_; 
                }
                else if (this.additionalMarketDisruptionEventIDRef_ != null)
                {
                    return this.additionalMarketDisruptionEvent_; 
                }
                else
                {
                      return this.additionalMarketDisruptionEvent_; 
                }
            }
            set
            {
                if (this.additionalMarketDisruptionEvent_ != value)
                {
                    this.additionalMarketDisruptionEvent_ = value;
                }
            }
        }
        #endregion
        
        public string additionalMarketDisruptionEventIDRef_ { get; set; }
        #region MarketDisruptionEvent_
        private List<MarketDisruptionEvent> marketDisruptionEvent_;
        public List<MarketDisruptionEvent> MarketDisruptionEvent_
        {
            get
            {
                if (this.marketDisruptionEvent_ != null)
                {
                    return this.marketDisruptionEvent_; 
                }
                else if (this.marketDisruptionEventIDRef_ != null)
                {
                    return this.marketDisruptionEvent_; 
                }
                else
                {
                      return this.marketDisruptionEvent_; 
                }
            }
            set
            {
                if (this.marketDisruptionEvent_ != value)
                {
                    this.marketDisruptionEvent_ = value;
                }
            }
        }
        #endregion
        
        public string marketDisruptionEventIDRef_ { get; set; }
        #region DisruptionFallbacks_
        private DisruptionFallbacksEnum disruptionFallbacks_;
        public DisruptionFallbacksEnum DisruptionFallbacks_
        {
            get
            {
                if (this.disruptionFallbacks_ != null)
                {
                    return this.disruptionFallbacks_; 
                }
                else if (this.disruptionFallbacksIDRef_ != null)
                {
                    disruptionFallbacks_ = IDManager.getID(disruptionFallbacksIDRef_) as DisruptionFallbacksEnum;
                    return this.disruptionFallbacks_; 
                }
                else
                {
                      return this.disruptionFallbacks_; 
                }
            }
            set
            {
                if (this.disruptionFallbacks_ != value)
                {
                    this.disruptionFallbacks_ = value;
                }
            }
        }
        #endregion
        
        public string disruptionFallbacksIDRef_ { get; set; }
        #region DisruptionFallback_
        private List<SequencedDisruptionFallback> disruptionFallback_;
        public List<SequencedDisruptionFallback> DisruptionFallback_
        {
            get
            {
                if (this.disruptionFallback_ != null)
                {
                    return this.disruptionFallback_; 
                }
                else if (this.disruptionFallbackIDRef_ != null)
                {
                    return this.disruptionFallback_; 
                }
                else
                {
                      return this.disruptionFallback_; 
                }
            }
            set
            {
                if (this.disruptionFallback_ != value)
                {
                    this.disruptionFallback_ = value;
                }
            }
        }
        #endregion
        
        public string disruptionFallbackIDRef_ { get; set; }
        #region FallbackReferencePrice_
        private Underlyer fallbackReferencePrice_;
        public Underlyer FallbackReferencePrice_
        {
            get
            {
                if (this.fallbackReferencePrice_ != null)
                {
                    return this.fallbackReferencePrice_; 
                }
                else if (this.fallbackReferencePriceIDRef_ != null)
                {
                    fallbackReferencePrice_ = IDManager.getID(fallbackReferencePriceIDRef_) as Underlyer;
                    return this.fallbackReferencePrice_; 
                }
                else
                {
                      return this.fallbackReferencePrice_; 
                }
            }
            set
            {
                if (this.fallbackReferencePrice_ != value)
                {
                    this.fallbackReferencePrice_ = value;
                }
            }
        }
        #endregion
        
        public string fallbackReferencePriceIDRef_ { get; set; }
        #region MaximumNumberOfDaysOfDisruption_
        private XsdTypeNonNegativeInteger maximumNumberOfDaysOfDisruption_;
        public XsdTypeNonNegativeInteger MaximumNumberOfDaysOfDisruption_
        {
            get
            {
                if (this.maximumNumberOfDaysOfDisruption_ != null)
                {
                    return this.maximumNumberOfDaysOfDisruption_; 
                }
                else if (this.maximumNumberOfDaysOfDisruptionIDRef_ != null)
                {
                    maximumNumberOfDaysOfDisruption_ = IDManager.getID(maximumNumberOfDaysOfDisruptionIDRef_) as XsdTypeNonNegativeInteger;
                    return this.maximumNumberOfDaysOfDisruption_; 
                }
                else
                {
                      return this.maximumNumberOfDaysOfDisruption_; 
                }
            }
            set
            {
                if (this.maximumNumberOfDaysOfDisruption_ != value)
                {
                    this.maximumNumberOfDaysOfDisruption_ = value;
                }
            }
        }
        #endregion
        
        public string maximumNumberOfDaysOfDisruptionIDRef_ { get; set; }
        #region PriceMaterialityPercentage_
        private XsdTypeDecimal priceMaterialityPercentage_;
        public XsdTypeDecimal PriceMaterialityPercentage_
        {
            get
            {
                if (this.priceMaterialityPercentage_ != null)
                {
                    return this.priceMaterialityPercentage_; 
                }
                else if (this.priceMaterialityPercentageIDRef_ != null)
                {
                    priceMaterialityPercentage_ = IDManager.getID(priceMaterialityPercentageIDRef_) as XsdTypeDecimal;
                    return this.priceMaterialityPercentage_; 
                }
                else
                {
                      return this.priceMaterialityPercentage_; 
                }
            }
            set
            {
                if (this.priceMaterialityPercentage_ != value)
                {
                    this.priceMaterialityPercentage_ = value;
                }
            }
        }
        #endregion
        
        public string priceMaterialityPercentageIDRef_ { get; set; }
        #region MinimumFuturesContracts_
        private XsdTypePositiveInteger minimumFuturesContracts_;
        public XsdTypePositiveInteger MinimumFuturesContracts_
        {
            get
            {
                if (this.minimumFuturesContracts_ != null)
                {
                    return this.minimumFuturesContracts_; 
                }
                else if (this.minimumFuturesContractsIDRef_ != null)
                {
                    minimumFuturesContracts_ = IDManager.getID(minimumFuturesContractsIDRef_) as XsdTypePositiveInteger;
                    return this.minimumFuturesContracts_; 
                }
                else
                {
                      return this.minimumFuturesContracts_; 
                }
            }
            set
            {
                if (this.minimumFuturesContracts_ != value)
                {
                    this.minimumFuturesContracts_ = value;
                }
            }
        }
        #endregion
        
        public string minimumFuturesContractsIDRef_ { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        
    
        
    
    }
    
}

