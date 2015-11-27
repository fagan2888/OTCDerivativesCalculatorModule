using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CommodityMarketDisruption
    {
        public CommodityMarketDisruption(XmlNode xmlNode)
        {
            XmlNodeList marketDisruptionEventsNodeList = xmlNode.SelectNodes("marketDisruptionEvents");
            if (marketDisruptionEventsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in marketDisruptionEventsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        marketDisruptionEventsIDRef = item.Attributes["id"].Name;
                        MarketDisruptionEventsEnum ob = MarketDisruptionEventsEnum();
                        IDManager.SetID(marketDisruptionEventsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        marketDisruptionEventsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        marketDisruptionEvents = new MarketDisruptionEventsEnum(item);
                    }
                }
            }
            
        
            XmlNodeList additionalMarketDisruptionEventNodeList = xmlNode.SelectNodes("additionalMarketDisruptionEvent");
            
            foreach (XmlNode item in additionalMarketDisruptionEventNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        additionalMarketDisruptionEventIDRef = item.Attributes["id"].Name;
                        List<MarketDisruptionEvent> ob = new List<MarketDisruptionEvent>();
                        ob.Add(new MarketDisruptionEvent(item));
                        IDManager.SetID(additionalMarketDisruptionEventIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        additionalMarketDisruptionEventIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    additionalMarketDisruptionEvent.Add(new MarketDisruptionEvent(item));
                    }
                }
            }
            
        
            XmlNodeList marketDisruptionEventNodeList = xmlNode.SelectNodes("marketDisruptionEvent");
            
            foreach (XmlNode item in marketDisruptionEventNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        marketDisruptionEventIDRef = item.Attributes["id"].Name;
                        List<MarketDisruptionEvent> ob = new List<MarketDisruptionEvent>();
                        ob.Add(new MarketDisruptionEvent(item));
                        IDManager.SetID(marketDisruptionEventIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        marketDisruptionEventIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    marketDisruptionEvent.Add(new MarketDisruptionEvent(item));
                    }
                }
            }
            
        
            XmlNodeList disruptionFallbacksNodeList = xmlNode.SelectNodes("disruptionFallbacks");
            if (disruptionFallbacksNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in disruptionFallbacksNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        disruptionFallbacksIDRef = item.Attributes["id"].Name;
                        DisruptionFallbacksEnum ob = DisruptionFallbacksEnum();
                        IDManager.SetID(disruptionFallbacksIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        disruptionFallbacksIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        disruptionFallbacks = new DisruptionFallbacksEnum(item);
                    }
                }
            }
            
        
            XmlNodeList disruptionFallbackNodeList = xmlNode.SelectNodes("disruptionFallback");
            
            foreach (XmlNode item in disruptionFallbackNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        disruptionFallbackIDRef = item.Attributes["id"].Name;
                        List<SequencedDisruptionFallback> ob = new List<SequencedDisruptionFallback>();
                        ob.Add(new SequencedDisruptionFallback(item));
                        IDManager.SetID(disruptionFallbackIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        disruptionFallbackIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    disruptionFallback.Add(new SequencedDisruptionFallback(item));
                    }
                }
            }
            
        
            XmlNodeList fallbackReferencePriceNodeList = xmlNode.SelectNodes("fallbackReferencePrice");
            if (fallbackReferencePriceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fallbackReferencePriceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fallbackReferencePriceIDRef = item.Attributes["id"].Name;
                        Underlyer ob = Underlyer();
                        IDManager.SetID(fallbackReferencePriceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fallbackReferencePriceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fallbackReferencePrice = new Underlyer(item);
                    }
                }
            }
            
        
            XmlNodeList maximumNumberOfDaysOfDisruptionNodeList = xmlNode.SelectNodes("maximumNumberOfDaysOfDisruption");
            if (maximumNumberOfDaysOfDisruptionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in maximumNumberOfDaysOfDisruptionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        maximumNumberOfDaysOfDisruptionIDRef = item.Attributes["id"].Name;
                        XsdTypeNonNegativeInteger ob = XsdTypeNonNegativeInteger();
                        IDManager.SetID(maximumNumberOfDaysOfDisruptionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        maximumNumberOfDaysOfDisruptionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        maximumNumberOfDaysOfDisruption = new XsdTypeNonNegativeInteger(item);
                    }
                }
            }
            
        
            XmlNodeList priceMaterialityPercentageNodeList = xmlNode.SelectNodes("priceMaterialityPercentage");
            if (priceMaterialityPercentageNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in priceMaterialityPercentageNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        priceMaterialityPercentageIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(priceMaterialityPercentageIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        priceMaterialityPercentageIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        priceMaterialityPercentage = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList minimumFuturesContractsNodeList = xmlNode.SelectNodes("minimumFuturesContracts");
            if (minimumFuturesContractsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in minimumFuturesContractsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        minimumFuturesContractsIDRef = item.Attributes["id"].Name;
                        XsdTypePositiveInteger ob = XsdTypePositiveInteger();
                        IDManager.SetID(minimumFuturesContractsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        minimumFuturesContractsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        minimumFuturesContracts = new XsdTypePositiveInteger(item);
                    }
                }
            }
            
        
        }
        
    
        #region MarketDisruptionEvents
        private MarketDisruptionEventsEnum marketDisruptionEvents;
        public MarketDisruptionEventsEnum MarketDisruptionEvents
        {
            get
            {
                if (this.marketDisruptionEvents != null)
                {
                    return this.marketDisruptionEvents; 
                }
                else if (this.marketDisruptionEventsIDRef != null)
                {
                    marketDisruptionEvents = IDManager.getID(marketDisruptionEventsIDRef) as MarketDisruptionEventsEnum;
                    return this.marketDisruptionEvents; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.marketDisruptionEvents != value)
                {
                    this.marketDisruptionEvents = value;
                }
            }
        }
        #endregion
        
        public string MarketDisruptionEventsEnumIDRef { get; set; }
        #region AdditionalMarketDisruptionEvent
        private List<MarketDisruptionEvent> additionalMarketDisruptionEvent;
        public List<MarketDisruptionEvent> AdditionalMarketDisruptionEvent
        {
            get
            {
                if (this.additionalMarketDisruptionEvent != null)
                {
                    return this.additionalMarketDisruptionEvent; 
                }
                else if (this.additionalMarketDisruptionEventIDRef != null)
                {
                    additionalMarketDisruptionEvent = IDManager.getID(additionalMarketDisruptionEventIDRef) as List<MarketDisruptionEvent>;
                    return this.additionalMarketDisruptionEvent; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.additionalMarketDisruptionEvent != value)
                {
                    this.additionalMarketDisruptionEvent = value;
                }
            }
        }
        #endregion
        
        public string MarketDisruptionEventIDRef { get; set; }
        #region MarketDisruptionEvent
        private List<MarketDisruptionEvent> marketDisruptionEvent;
        public List<MarketDisruptionEvent> MarketDisruptionEvent
        {
            get
            {
                if (this.marketDisruptionEvent != null)
                {
                    return this.marketDisruptionEvent; 
                }
                else if (this.marketDisruptionEventIDRef != null)
                {
                    marketDisruptionEvent = IDManager.getID(marketDisruptionEventIDRef) as List<MarketDisruptionEvent>;
                    return this.marketDisruptionEvent; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.marketDisruptionEvent != value)
                {
                    this.marketDisruptionEvent = value;
                }
            }
        }
        #endregion
        
        public string MarketDisruptionEventIDRef { get; set; }
        #region DisruptionFallbacks
        private DisruptionFallbacksEnum disruptionFallbacks;
        public DisruptionFallbacksEnum DisruptionFallbacks
        {
            get
            {
                if (this.disruptionFallbacks != null)
                {
                    return this.disruptionFallbacks; 
                }
                else if (this.disruptionFallbacksIDRef != null)
                {
                    disruptionFallbacks = IDManager.getID(disruptionFallbacksIDRef) as DisruptionFallbacksEnum;
                    return this.disruptionFallbacks; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.disruptionFallbacks != value)
                {
                    this.disruptionFallbacks = value;
                }
            }
        }
        #endregion
        
        public string DisruptionFallbacksEnumIDRef { get; set; }
        #region DisruptionFallback
        private List<SequencedDisruptionFallback> disruptionFallback;
        public List<SequencedDisruptionFallback> DisruptionFallback
        {
            get
            {
                if (this.disruptionFallback != null)
                {
                    return this.disruptionFallback; 
                }
                else if (this.disruptionFallbackIDRef != null)
                {
                    disruptionFallback = IDManager.getID(disruptionFallbackIDRef) as List<SequencedDisruptionFallback>;
                    return this.disruptionFallback; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.disruptionFallback != value)
                {
                    this.disruptionFallback = value;
                }
            }
        }
        #endregion
        
        public string SequencedDisruptionFallbackIDRef { get; set; }
        #region FallbackReferencePrice
        private Underlyer fallbackReferencePrice;
        public Underlyer FallbackReferencePrice
        {
            get
            {
                if (this.fallbackReferencePrice != null)
                {
                    return this.fallbackReferencePrice; 
                }
                else if (this.fallbackReferencePriceIDRef != null)
                {
                    fallbackReferencePrice = IDManager.getID(fallbackReferencePriceIDRef) as Underlyer;
                    return this.fallbackReferencePrice; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fallbackReferencePrice != value)
                {
                    this.fallbackReferencePrice = value;
                }
            }
        }
        #endregion
        
        public string UnderlyerIDRef { get; set; }
        #region MaximumNumberOfDaysOfDisruption
        private XsdTypeNonNegativeInteger maximumNumberOfDaysOfDisruption;
        public XsdTypeNonNegativeInteger MaximumNumberOfDaysOfDisruption
        {
            get
            {
                if (this.maximumNumberOfDaysOfDisruption != null)
                {
                    return this.maximumNumberOfDaysOfDisruption; 
                }
                else if (this.maximumNumberOfDaysOfDisruptionIDRef != null)
                {
                    maximumNumberOfDaysOfDisruption = IDManager.getID(maximumNumberOfDaysOfDisruptionIDRef) as XsdTypeNonNegativeInteger;
                    return this.maximumNumberOfDaysOfDisruption; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.maximumNumberOfDaysOfDisruption != value)
                {
                    this.maximumNumberOfDaysOfDisruption = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeNonNegativeIntegerIDRef { get; set; }
        #region PriceMaterialityPercentage
        private XsdTypeDecimal priceMaterialityPercentage;
        public XsdTypeDecimal PriceMaterialityPercentage
        {
            get
            {
                if (this.priceMaterialityPercentage != null)
                {
                    return this.priceMaterialityPercentage; 
                }
                else if (this.priceMaterialityPercentageIDRef != null)
                {
                    priceMaterialityPercentage = IDManager.getID(priceMaterialityPercentageIDRef) as XsdTypeDecimal;
                    return this.priceMaterialityPercentage; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.priceMaterialityPercentage != value)
                {
                    this.priceMaterialityPercentage = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region MinimumFuturesContracts
        private XsdTypePositiveInteger minimumFuturesContracts;
        public XsdTypePositiveInteger MinimumFuturesContracts
        {
            get
            {
                if (this.minimumFuturesContracts != null)
                {
                    return this.minimumFuturesContracts; 
                }
                else if (this.minimumFuturesContractsIDRef != null)
                {
                    minimumFuturesContracts = IDManager.getID(minimumFuturesContractsIDRef) as XsdTypePositiveInteger;
                    return this.minimumFuturesContracts; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.minimumFuturesContracts != value)
                {
                    this.minimumFuturesContracts = value;
                }
            }
        }
        #endregion
        
        public string XsdTypePositiveIntegerIDRef { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        
    
        
    
    }
    
}

