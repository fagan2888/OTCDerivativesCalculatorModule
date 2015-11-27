using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Market : ISerialized
    {
        public Market(XmlNode xmlNode)
        {
            XmlNode nameNode = xmlNode.SelectSingleNode("name");
            
            if (nameNode != null)
            {
                if (nameNode.Attributes["href"] != null || nameNode.Attributes["id"] != null) 
                {
                    if (nameNode.Attributes["id"] != null) 
                    {
                        nameIDRef_ = nameNode.Attributes["id"].Value;
                        XsdTypeString ob = new XsdTypeString(nameNode);
                        IDManager.SetID(nameIDRef_, ob);
                    }
                    else if (nameNode.Attributes["href"] != null)
                    {
                        nameIDRef_ = nameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        name_ = new XsdTypeString(nameNode);
                    }
                }
                else
                {
                    name_ = new XsdTypeString(nameNode);
                }
            }
            
        
            XmlNode benchmarkQuotesNode = xmlNode.SelectSingleNode("benchmarkQuotes");
            
            if (benchmarkQuotesNode != null)
            {
                if (benchmarkQuotesNode.Attributes["href"] != null || benchmarkQuotesNode.Attributes["id"] != null) 
                {
                    if (benchmarkQuotesNode.Attributes["id"] != null) 
                    {
                        benchmarkQuotesIDRef_ = benchmarkQuotesNode.Attributes["id"].Value;
                        QuotedAssetSet ob = new QuotedAssetSet(benchmarkQuotesNode);
                        IDManager.SetID(benchmarkQuotesIDRef_, ob);
                    }
                    else if (benchmarkQuotesNode.Attributes["href"] != null)
                    {
                        benchmarkQuotesIDRef_ = benchmarkQuotesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        benchmarkQuotes_ = new QuotedAssetSet(benchmarkQuotesNode);
                    }
                }
                else
                {
                    benchmarkQuotes_ = new QuotedAssetSet(benchmarkQuotesNode);
                }
            }
            
        
            XmlNode pricingStructureNode = xmlNode.SelectSingleNode("pricingStructure");
            
            if (pricingStructureNode != null)
            {
                if (pricingStructureNode.Attributes["href"] != null || pricingStructureNode.Attributes["id"] != null) 
                {
                    if (pricingStructureNode.Attributes["id"] != null) 
                    {
                        pricingStructureIDRef_ = pricingStructureNode.Attributes["id"].Value;
                        PricingStructure ob = new PricingStructure(pricingStructureNode);
                        IDManager.SetID(pricingStructureIDRef_, ob);
                    }
                    else if (pricingStructureNode.Attributes["href"] != null)
                    {
                        pricingStructureIDRef_ = pricingStructureNode.Attributes["href"].Value;
                    }
                    else
                    {
                        pricingStructure_ = new PricingStructure(pricingStructureNode);
                    }
                }
                else
                {
                    pricingStructure_ = new PricingStructure(pricingStructureNode);
                }
            }
            
        
            XmlNode creditCurveNode = xmlNode.SelectSingleNode("creditCurve");
            
            if (creditCurveNode != null)
            {
                if (creditCurveNode.Attributes["href"] != null || creditCurveNode.Attributes["id"] != null) 
                {
                    if (creditCurveNode.Attributes["id"] != null) 
                    {
                        creditCurveIDRef_ = creditCurveNode.Attributes["id"].Value;
                        CreditCurve ob = new CreditCurve(creditCurveNode);
                        IDManager.SetID(creditCurveIDRef_, ob);
                    }
                    else if (creditCurveNode.Attributes["href"] != null)
                    {
                        creditCurveIDRef_ = creditCurveNode.Attributes["href"].Value;
                    }
                    else
                    {
                        creditCurve_ = new CreditCurve(creditCurveNode);
                    }
                }
                else
                {
                    creditCurve_ = new CreditCurve(creditCurveNode);
                }
            }
            
        
            XmlNode fxCurveNode = xmlNode.SelectSingleNode("fxCurve");
            
            if (fxCurveNode != null)
            {
                if (fxCurveNode.Attributes["href"] != null || fxCurveNode.Attributes["id"] != null) 
                {
                    if (fxCurveNode.Attributes["id"] != null) 
                    {
                        fxCurveIDRef_ = fxCurveNode.Attributes["id"].Value;
                        FxCurve ob = new FxCurve(fxCurveNode);
                        IDManager.SetID(fxCurveIDRef_, ob);
                    }
                    else if (fxCurveNode.Attributes["href"] != null)
                    {
                        fxCurveIDRef_ = fxCurveNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fxCurve_ = new FxCurve(fxCurveNode);
                    }
                }
                else
                {
                    fxCurve_ = new FxCurve(fxCurveNode);
                }
            }
            
        
            XmlNode volatilityRepresentationNode = xmlNode.SelectSingleNode("volatilityRepresentation");
            
            if (volatilityRepresentationNode != null)
            {
                if (volatilityRepresentationNode.Attributes["href"] != null || volatilityRepresentationNode.Attributes["id"] != null) 
                {
                    if (volatilityRepresentationNode.Attributes["id"] != null) 
                    {
                        volatilityRepresentationIDRef_ = volatilityRepresentationNode.Attributes["id"].Value;
                        VolatilityRepresentation ob = new VolatilityRepresentation(volatilityRepresentationNode);
                        IDManager.SetID(volatilityRepresentationIDRef_, ob);
                    }
                    else if (volatilityRepresentationNode.Attributes["href"] != null)
                    {
                        volatilityRepresentationIDRef_ = volatilityRepresentationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        volatilityRepresentation_ = new VolatilityRepresentation(volatilityRepresentationNode);
                    }
                }
                else
                {
                    volatilityRepresentation_ = new VolatilityRepresentation(volatilityRepresentationNode);
                }
            }
            
        
            XmlNode yieldCurveNode = xmlNode.SelectSingleNode("yieldCurve");
            
            if (yieldCurveNode != null)
            {
                if (yieldCurveNode.Attributes["href"] != null || yieldCurveNode.Attributes["id"] != null) 
                {
                    if (yieldCurveNode.Attributes["id"] != null) 
                    {
                        yieldCurveIDRef_ = yieldCurveNode.Attributes["id"].Value;
                        YieldCurve ob = new YieldCurve(yieldCurveNode);
                        IDManager.SetID(yieldCurveIDRef_, ob);
                    }
                    else if (yieldCurveNode.Attributes["href"] != null)
                    {
                        yieldCurveIDRef_ = yieldCurveNode.Attributes["href"].Value;
                    }
                    else
                    {
                        yieldCurve_ = new YieldCurve(yieldCurveNode);
                    }
                }
                else
                {
                    yieldCurve_ = new YieldCurve(yieldCurveNode);
                }
            }
            
        
            XmlNode pricingStructureValuationNode = xmlNode.SelectSingleNode("pricingStructureValuation");
            
            if (pricingStructureValuationNode != null)
            {
                if (pricingStructureValuationNode.Attributes["href"] != null || pricingStructureValuationNode.Attributes["id"] != null) 
                {
                    if (pricingStructureValuationNode.Attributes["id"] != null) 
                    {
                        pricingStructureValuationIDRef_ = pricingStructureValuationNode.Attributes["id"].Value;
                        PricingStructureValuation ob = new PricingStructureValuation(pricingStructureValuationNode);
                        IDManager.SetID(pricingStructureValuationIDRef_, ob);
                    }
                    else if (pricingStructureValuationNode.Attributes["href"] != null)
                    {
                        pricingStructureValuationIDRef_ = pricingStructureValuationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        pricingStructureValuation_ = new PricingStructureValuation(pricingStructureValuationNode);
                    }
                }
                else
                {
                    pricingStructureValuation_ = new PricingStructureValuation(pricingStructureValuationNode);
                }
            }
            
        
            XmlNode creditCurveValuationNode = xmlNode.SelectSingleNode("creditCurveValuation");
            
            if (creditCurveValuationNode != null)
            {
                if (creditCurveValuationNode.Attributes["href"] != null || creditCurveValuationNode.Attributes["id"] != null) 
                {
                    if (creditCurveValuationNode.Attributes["id"] != null) 
                    {
                        creditCurveValuationIDRef_ = creditCurveValuationNode.Attributes["id"].Value;
                        CreditCurveValuation ob = new CreditCurveValuation(creditCurveValuationNode);
                        IDManager.SetID(creditCurveValuationIDRef_, ob);
                    }
                    else if (creditCurveValuationNode.Attributes["href"] != null)
                    {
                        creditCurveValuationIDRef_ = creditCurveValuationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        creditCurveValuation_ = new CreditCurveValuation(creditCurveValuationNode);
                    }
                }
                else
                {
                    creditCurveValuation_ = new CreditCurveValuation(creditCurveValuationNode);
                }
            }
            
        
            XmlNode fxCurveValuationNode = xmlNode.SelectSingleNode("fxCurveValuation");
            
            if (fxCurveValuationNode != null)
            {
                if (fxCurveValuationNode.Attributes["href"] != null || fxCurveValuationNode.Attributes["id"] != null) 
                {
                    if (fxCurveValuationNode.Attributes["id"] != null) 
                    {
                        fxCurveValuationIDRef_ = fxCurveValuationNode.Attributes["id"].Value;
                        FxCurveValuation ob = new FxCurveValuation(fxCurveValuationNode);
                        IDManager.SetID(fxCurveValuationIDRef_, ob);
                    }
                    else if (fxCurveValuationNode.Attributes["href"] != null)
                    {
                        fxCurveValuationIDRef_ = fxCurveValuationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fxCurveValuation_ = new FxCurveValuation(fxCurveValuationNode);
                    }
                }
                else
                {
                    fxCurveValuation_ = new FxCurveValuation(fxCurveValuationNode);
                }
            }
            
        
            XmlNode volatilityMatrixValuationNode = xmlNode.SelectSingleNode("volatilityMatrixValuation");
            
            if (volatilityMatrixValuationNode != null)
            {
                if (volatilityMatrixValuationNode.Attributes["href"] != null || volatilityMatrixValuationNode.Attributes["id"] != null) 
                {
                    if (volatilityMatrixValuationNode.Attributes["id"] != null) 
                    {
                        volatilityMatrixValuationIDRef_ = volatilityMatrixValuationNode.Attributes["id"].Value;
                        VolatilityMatrix ob = new VolatilityMatrix(volatilityMatrixValuationNode);
                        IDManager.SetID(volatilityMatrixValuationIDRef_, ob);
                    }
                    else if (volatilityMatrixValuationNode.Attributes["href"] != null)
                    {
                        volatilityMatrixValuationIDRef_ = volatilityMatrixValuationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        volatilityMatrixValuation_ = new VolatilityMatrix(volatilityMatrixValuationNode);
                    }
                }
                else
                {
                    volatilityMatrixValuation_ = new VolatilityMatrix(volatilityMatrixValuationNode);
                }
            }
            
        
            XmlNode yieldCurveValuationNode = xmlNode.SelectSingleNode("yieldCurveValuation");
            
            if (yieldCurveValuationNode != null)
            {
                if (yieldCurveValuationNode.Attributes["href"] != null || yieldCurveValuationNode.Attributes["id"] != null) 
                {
                    if (yieldCurveValuationNode.Attributes["id"] != null) 
                    {
                        yieldCurveValuationIDRef_ = yieldCurveValuationNode.Attributes["id"].Value;
                        YieldCurveValuation ob = new YieldCurveValuation(yieldCurveValuationNode);
                        IDManager.SetID(yieldCurveValuationIDRef_, ob);
                    }
                    else if (yieldCurveValuationNode.Attributes["href"] != null)
                    {
                        yieldCurveValuationIDRef_ = yieldCurveValuationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        yieldCurveValuation_ = new YieldCurveValuation(yieldCurveValuationNode);
                    }
                }
                else
                {
                    yieldCurveValuation_ = new YieldCurveValuation(yieldCurveValuationNode);
                }
            }
            
        
            XmlNodeList benchmarkPricingMethodNodeList = xmlNode.SelectNodes("benchmarkPricingMethod");
            
            if (benchmarkPricingMethodNodeList != null)
            {
                this.benchmarkPricingMethod_ = new List<PricingMethod>();
                foreach (XmlNode item in benchmarkPricingMethodNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            benchmarkPricingMethodIDRef_ = item.Attributes["id"].Value;
                            benchmarkPricingMethod_.Add(new PricingMethod(item));
                            IDManager.SetID(benchmarkPricingMethodIDRef_, benchmarkPricingMethod_[benchmarkPricingMethod_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            benchmarkPricingMethodIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        benchmarkPricingMethod_.Add(new PricingMethod(item));
                        }
                    }
                    else
                    {
                        benchmarkPricingMethod_.Add(new PricingMethod(item));
                    }
                }
            }
            
        
        }
        
    
        #region Name_
        private XsdTypeString name_;
        public XsdTypeString Name_
        {
            get
            {
                if (this.name_ != null)
                {
                    return this.name_; 
                }
                else if (this.nameIDRef_ != null)
                {
                    name_ = IDManager.getID(nameIDRef_) as XsdTypeString;
                    return this.name_; 
                }
                else
                {
                      return this.name_; 
                }
            }
            set
            {
                if (this.name_ != value)
                {
                    this.name_ = value;
                }
            }
        }
        #endregion
        
        public string nameIDRef_ { get; set; }
        #region BenchmarkQuotes_
        private QuotedAssetSet benchmarkQuotes_;
        public QuotedAssetSet BenchmarkQuotes_
        {
            get
            {
                if (this.benchmarkQuotes_ != null)
                {
                    return this.benchmarkQuotes_; 
                }
                else if (this.benchmarkQuotesIDRef_ != null)
                {
                    benchmarkQuotes_ = IDManager.getID(benchmarkQuotesIDRef_) as QuotedAssetSet;
                    return this.benchmarkQuotes_; 
                }
                else
                {
                      return this.benchmarkQuotes_; 
                }
            }
            set
            {
                if (this.benchmarkQuotes_ != value)
                {
                    this.benchmarkQuotes_ = value;
                }
            }
        }
        #endregion
        
        public string benchmarkQuotesIDRef_ { get; set; }
        #region PricingStructure_
        private PricingStructure pricingStructure_;
        public PricingStructure PricingStructure_
        {
            get
            {
                if (this.pricingStructure_ != null)
                {
                    return this.pricingStructure_; 
                }
                else if (this.pricingStructureIDRef_ != null)
                {
                    pricingStructure_ = IDManager.getID(pricingStructureIDRef_) as PricingStructure;
                    return this.pricingStructure_; 
                }
                else
                {
                      return this.pricingStructure_; 
                }
            }
            set
            {
                if (this.pricingStructure_ != value)
                {
                    this.pricingStructure_ = value;
                }
            }
        }
        #endregion
        
        public string pricingStructureIDRef_ { get; set; }
        #region CreditCurve_
        private CreditCurve creditCurve_;
        public CreditCurve CreditCurve_
        {
            get
            {
                if (this.creditCurve_ != null)
                {
                    return this.creditCurve_; 
                }
                else if (this.creditCurveIDRef_ != null)
                {
                    creditCurve_ = IDManager.getID(creditCurveIDRef_) as CreditCurve;
                    return this.creditCurve_; 
                }
                else
                {
                      return this.creditCurve_; 
                }
            }
            set
            {
                if (this.creditCurve_ != value)
                {
                    this.creditCurve_ = value;
                }
            }
        }
        #endregion
        
        public string creditCurveIDRef_ { get; set; }     // substitude
        #region FxCurve_
        private FxCurve fxCurve_;
        public FxCurve FxCurve_
        {
            get
            {
                if (this.fxCurve_ != null)
                {
                    return this.fxCurve_; 
                }
                else if (this.fxCurveIDRef_ != null)
                {
                    fxCurve_ = IDManager.getID(fxCurveIDRef_) as FxCurve;
                    return this.fxCurve_; 
                }
                else
                {
                      return this.fxCurve_; 
                }
            }
            set
            {
                if (this.fxCurve_ != value)
                {
                    this.fxCurve_ = value;
                }
            }
        }
        #endregion
        
        public string fxCurveIDRef_ { get; set; }     // substitude
        #region VolatilityRepresentation_
        private VolatilityRepresentation volatilityRepresentation_;
        public VolatilityRepresentation VolatilityRepresentation_
        {
            get
            {
                if (this.volatilityRepresentation_ != null)
                {
                    return this.volatilityRepresentation_; 
                }
                else if (this.volatilityRepresentationIDRef_ != null)
                {
                    volatilityRepresentation_ = IDManager.getID(volatilityRepresentationIDRef_) as VolatilityRepresentation;
                    return this.volatilityRepresentation_; 
                }
                else
                {
                      return this.volatilityRepresentation_; 
                }
            }
            set
            {
                if (this.volatilityRepresentation_ != value)
                {
                    this.volatilityRepresentation_ = value;
                }
            }
        }
        #endregion
        
        public string volatilityRepresentationIDRef_ { get; set; }     // substitude
        #region YieldCurve_
        private YieldCurve yieldCurve_;
        public YieldCurve YieldCurve_
        {
            get
            {
                if (this.yieldCurve_ != null)
                {
                    return this.yieldCurve_; 
                }
                else if (this.yieldCurveIDRef_ != null)
                {
                    yieldCurve_ = IDManager.getID(yieldCurveIDRef_) as YieldCurve;
                    return this.yieldCurve_; 
                }
                else
                {
                      return this.yieldCurve_; 
                }
            }
            set
            {
                if (this.yieldCurve_ != value)
                {
                    this.yieldCurve_ = value;
                }
            }
        }
        #endregion
        
        public string yieldCurveIDRef_ { get; set; }     // substitude
        #region PricingStructureValuation_
        private PricingStructureValuation pricingStructureValuation_;
        public PricingStructureValuation PricingStructureValuation_
        {
            get
            {
                if (this.pricingStructureValuation_ != null)
                {
                    return this.pricingStructureValuation_; 
                }
                else if (this.pricingStructureValuationIDRef_ != null)
                {
                    pricingStructureValuation_ = IDManager.getID(pricingStructureValuationIDRef_) as PricingStructureValuation;
                    return this.pricingStructureValuation_; 
                }
                else
                {
                      return this.pricingStructureValuation_; 
                }
            }
            set
            {
                if (this.pricingStructureValuation_ != value)
                {
                    this.pricingStructureValuation_ = value;
                }
            }
        }
        #endregion
        
        public string pricingStructureValuationIDRef_ { get; set; }
        #region CreditCurveValuation_
        private CreditCurveValuation creditCurveValuation_;
        public CreditCurveValuation CreditCurveValuation_
        {
            get
            {
                if (this.creditCurveValuation_ != null)
                {
                    return this.creditCurveValuation_; 
                }
                else if (this.creditCurveValuationIDRef_ != null)
                {
                    creditCurveValuation_ = IDManager.getID(creditCurveValuationIDRef_) as CreditCurveValuation;
                    return this.creditCurveValuation_; 
                }
                else
                {
                      return this.creditCurveValuation_; 
                }
            }
            set
            {
                if (this.creditCurveValuation_ != value)
                {
                    this.creditCurveValuation_ = value;
                }
            }
        }
        #endregion
        
        public string creditCurveValuationIDRef_ { get; set; }     // substitude
        #region FxCurveValuation_
        private FxCurveValuation fxCurveValuation_;
        public FxCurveValuation FxCurveValuation_
        {
            get
            {
                if (this.fxCurveValuation_ != null)
                {
                    return this.fxCurveValuation_; 
                }
                else if (this.fxCurveValuationIDRef_ != null)
                {
                    fxCurveValuation_ = IDManager.getID(fxCurveValuationIDRef_) as FxCurveValuation;
                    return this.fxCurveValuation_; 
                }
                else
                {
                      return this.fxCurveValuation_; 
                }
            }
            set
            {
                if (this.fxCurveValuation_ != value)
                {
                    this.fxCurveValuation_ = value;
                }
            }
        }
        #endregion
        
        public string fxCurveValuationIDRef_ { get; set; }     // substitude
        #region VolatilityMatrixValuation_
        private VolatilityMatrix volatilityMatrixValuation_;
        public VolatilityMatrix VolatilityMatrixValuation_
        {
            get
            {
                if (this.volatilityMatrixValuation_ != null)
                {
                    return this.volatilityMatrixValuation_; 
                }
                else if (this.volatilityMatrixValuationIDRef_ != null)
                {
                    volatilityMatrixValuation_ = IDManager.getID(volatilityMatrixValuationIDRef_) as VolatilityMatrix;
                    return this.volatilityMatrixValuation_; 
                }
                else
                {
                      return this.volatilityMatrixValuation_; 
                }
            }
            set
            {
                if (this.volatilityMatrixValuation_ != value)
                {
                    this.volatilityMatrixValuation_ = value;
                }
            }
        }
        #endregion
        
        public string volatilityMatrixValuationIDRef_ { get; set; }     // substitude
        #region YieldCurveValuation_
        private YieldCurveValuation yieldCurveValuation_;
        public YieldCurveValuation YieldCurveValuation_
        {
            get
            {
                if (this.yieldCurveValuation_ != null)
                {
                    return this.yieldCurveValuation_; 
                }
                else if (this.yieldCurveValuationIDRef_ != null)
                {
                    yieldCurveValuation_ = IDManager.getID(yieldCurveValuationIDRef_) as YieldCurveValuation;
                    return this.yieldCurveValuation_; 
                }
                else
                {
                      return this.yieldCurveValuation_; 
                }
            }
            set
            {
                if (this.yieldCurveValuation_ != value)
                {
                    this.yieldCurveValuation_ = value;
                }
            }
        }
        #endregion
        
        public string yieldCurveValuationIDRef_ { get; set; }     // substitude
        #region BenchmarkPricingMethod_
        private List<PricingMethod> benchmarkPricingMethod_;
        public List<PricingMethod> BenchmarkPricingMethod_
        {
            get
            {
                if (this.benchmarkPricingMethod_ != null)
                {
                    return this.benchmarkPricingMethod_; 
                }
                else if (this.benchmarkPricingMethodIDRef_ != null)
                {
                    return this.benchmarkPricingMethod_; 
                }
                else
                {
                      return this.benchmarkPricingMethod_; 
                }
            }
            set
            {
                if (this.benchmarkPricingMethod_ != value)
                {
                    this.benchmarkPricingMethod_ = value;
                }
            }
        }
        #endregion
        
        public string benchmarkPricingMethodIDRef_ { get; set; }
        
    
        
    
    }
    
}

