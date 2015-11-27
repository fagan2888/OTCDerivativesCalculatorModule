using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Market
    {
        public Market(XmlNode xmlNode)
        {
            XmlNodeList nameNodeList = xmlNode.SelectNodes("name");
            if (nameNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in nameNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        nameIDRef = item.Attributes["id"].Name;
                        XsdTypeString ob = XsdTypeString();
                        IDManager.SetID(nameIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        nameIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        name = new XsdTypeString(item);
                    }
                }
            }
            
        
            XmlNodeList benchmarkQuotesNodeList = xmlNode.SelectNodes("benchmarkQuotes");
            if (benchmarkQuotesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in benchmarkQuotesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        benchmarkQuotesIDRef = item.Attributes["id"].Name;
                        QuotedAssetSet ob = QuotedAssetSet();
                        IDManager.SetID(benchmarkQuotesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        benchmarkQuotesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        benchmarkQuotes = new QuotedAssetSet(item);
                    }
                }
            }
            
        
            XmlNodeList pricingStructureNodeList = xmlNode.SelectNodes("pricingStructure");
            if (pricingStructureNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in pricingStructureNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        pricingStructureIDRef = item.Attributes["id"].Name;
                        PricingStructure ob = PricingStructure();
                        IDManager.SetID(pricingStructureIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        pricingStructureIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        pricingStructure = new PricingStructure(item);
                    }
                }
            }
            
        
            XmlNodeList creditCurveNodeList = xmlNode.SelectNodes("creditCurve");
            if (creditCurveNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in creditCurveNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        creditCurveIDRef = item.Attributes["id"].Name;
                        CreditCurve ob = CreditCurve();
                        IDManager.SetID(creditCurveIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        creditCurveIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        creditCurve = new CreditCurve(item);
                    }
                }
            }
            
        
            XmlNodeList fxCurveNodeList = xmlNode.SelectNodes("fxCurve");
            if (fxCurveNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fxCurveNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fxCurveIDRef = item.Attributes["id"].Name;
                        FxCurve ob = FxCurve();
                        IDManager.SetID(fxCurveIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fxCurveIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fxCurve = new FxCurve(item);
                    }
                }
            }
            
        
            XmlNodeList volatilityRepresentationNodeList = xmlNode.SelectNodes("volatilityRepresentation");
            if (volatilityRepresentationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in volatilityRepresentationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        volatilityRepresentationIDRef = item.Attributes["id"].Name;
                        VolatilityRepresentation ob = VolatilityRepresentation();
                        IDManager.SetID(volatilityRepresentationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        volatilityRepresentationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        volatilityRepresentation = new VolatilityRepresentation(item);
                    }
                }
            }
            
        
            XmlNodeList yieldCurveNodeList = xmlNode.SelectNodes("yieldCurve");
            if (yieldCurveNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in yieldCurveNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        yieldCurveIDRef = item.Attributes["id"].Name;
                        YieldCurve ob = YieldCurve();
                        IDManager.SetID(yieldCurveIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        yieldCurveIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        yieldCurve = new YieldCurve(item);
                    }
                }
            }
            
        
            XmlNodeList pricingStructureValuationNodeList = xmlNode.SelectNodes("pricingStructureValuation");
            if (pricingStructureValuationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in pricingStructureValuationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        pricingStructureValuationIDRef = item.Attributes["id"].Name;
                        PricingStructureValuation ob = PricingStructureValuation();
                        IDManager.SetID(pricingStructureValuationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        pricingStructureValuationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        pricingStructureValuation = new PricingStructureValuation(item);
                    }
                }
            }
            
        
            XmlNodeList creditCurveValuationNodeList = xmlNode.SelectNodes("creditCurveValuation");
            if (creditCurveValuationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in creditCurveValuationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        creditCurveValuationIDRef = item.Attributes["id"].Name;
                        CreditCurveValuation ob = CreditCurveValuation();
                        IDManager.SetID(creditCurveValuationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        creditCurveValuationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        creditCurveValuation = new CreditCurveValuation(item);
                    }
                }
            }
            
        
            XmlNodeList fxCurveValuationNodeList = xmlNode.SelectNodes("fxCurveValuation");
            if (fxCurveValuationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fxCurveValuationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fxCurveValuationIDRef = item.Attributes["id"].Name;
                        FxCurveValuation ob = FxCurveValuation();
                        IDManager.SetID(fxCurveValuationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fxCurveValuationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fxCurveValuation = new FxCurveValuation(item);
                    }
                }
            }
            
        
            XmlNodeList volatilityMatrixValuationNodeList = xmlNode.SelectNodes("volatilityMatrixValuation");
            if (volatilityMatrixValuationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in volatilityMatrixValuationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        volatilityMatrixValuationIDRef = item.Attributes["id"].Name;
                        VolatilityMatrix ob = VolatilityMatrix();
                        IDManager.SetID(volatilityMatrixValuationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        volatilityMatrixValuationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        volatilityMatrixValuation = new VolatilityMatrix(item);
                    }
                }
            }
            
        
            XmlNodeList yieldCurveValuationNodeList = xmlNode.SelectNodes("yieldCurveValuation");
            if (yieldCurveValuationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in yieldCurveValuationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        yieldCurveValuationIDRef = item.Attributes["id"].Name;
                        YieldCurveValuation ob = YieldCurveValuation();
                        IDManager.SetID(yieldCurveValuationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        yieldCurveValuationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        yieldCurveValuation = new YieldCurveValuation(item);
                    }
                }
            }
            
        
            XmlNodeList benchmarkPricingMethodNodeList = xmlNode.SelectNodes("benchmarkPricingMethod");
            
            foreach (XmlNode item in benchmarkPricingMethodNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        benchmarkPricingMethodIDRef = item.Attributes["id"].Name;
                        List<PricingMethod> ob = new List<PricingMethod>();
                        ob.Add(new PricingMethod(item));
                        IDManager.SetID(benchmarkPricingMethodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        benchmarkPricingMethodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    benchmarkPricingMethod.Add(new PricingMethod(item));
                    }
                }
            }
            
        
        }
        
    
        #region Name
        private XsdTypeString name;
        public XsdTypeString Name
        {
            get
            {
                if (this.name != null)
                {
                    return this.name; 
                }
                else if (this.nameIDRef != null)
                {
                    name = IDManager.getID(nameIDRef) as XsdTypeString;
                    return this.name; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.name != value)
                {
                    this.name = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeStringIDRef { get; set; }
        #region BenchmarkQuotes
        private QuotedAssetSet benchmarkQuotes;
        public QuotedAssetSet BenchmarkQuotes
        {
            get
            {
                if (this.benchmarkQuotes != null)
                {
                    return this.benchmarkQuotes; 
                }
                else if (this.benchmarkQuotesIDRef != null)
                {
                    benchmarkQuotes = IDManager.getID(benchmarkQuotesIDRef) as QuotedAssetSet;
                    return this.benchmarkQuotes; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.benchmarkQuotes != value)
                {
                    this.benchmarkQuotes = value;
                }
            }
        }
        #endregion
        
        public string QuotedAssetSetIDRef { get; set; }
        #region PricingStructure
        private PricingStructure pricingStructure;
        public PricingStructure PricingStructure
        {
            get
            {
                if (this.pricingStructure != null)
                {
                    return this.pricingStructure; 
                }
                else if (this.pricingStructureIDRef != null)
                {
                    pricingStructure = IDManager.getID(pricingStructureIDRef) as PricingStructure;
                    return this.pricingStructure; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.pricingStructure != value)
                {
                    this.pricingStructure = value;
                }
            }
        }
        #endregion
        
        public string PricingStructureIDRef { get; set; }
        #region CreditCurve
        private CreditCurve creditCurve;
        public CreditCurve CreditCurve
        {
            get
            {
                if (this.creditCurve != null)
                {
                    return this.creditCurve; 
                }
                else if (this.creditCurveIDRef != null)
                {
                    creditCurve = IDManager.getID(creditCurveIDRef) as CreditCurve;
                    return this.creditCurve; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.creditCurve != value)
                {
                    this.creditCurve = value;
                }
            }
        }
        #endregion
        
        public string CreditCurveIDRef { get; set; }     // substitude
        #region FxCurve
        private FxCurve fxCurve;
        public FxCurve FxCurve
        {
            get
            {
                if (this.fxCurve != null)
                {
                    return this.fxCurve; 
                }
                else if (this.fxCurveIDRef != null)
                {
                    fxCurve = IDManager.getID(fxCurveIDRef) as FxCurve;
                    return this.fxCurve; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fxCurve != value)
                {
                    this.fxCurve = value;
                }
            }
        }
        #endregion
        
        public string FxCurveIDRef { get; set; }     // substitude
        #region VolatilityRepresentation
        private VolatilityRepresentation volatilityRepresentation;
        public VolatilityRepresentation VolatilityRepresentation
        {
            get
            {
                if (this.volatilityRepresentation != null)
                {
                    return this.volatilityRepresentation; 
                }
                else if (this.volatilityRepresentationIDRef != null)
                {
                    volatilityRepresentation = IDManager.getID(volatilityRepresentationIDRef) as VolatilityRepresentation;
                    return this.volatilityRepresentation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.volatilityRepresentation != value)
                {
                    this.volatilityRepresentation = value;
                }
            }
        }
        #endregion
        
        public string VolatilityRepresentationIDRef { get; set; }     // substitude
        #region YieldCurve
        private YieldCurve yieldCurve;
        public YieldCurve YieldCurve
        {
            get
            {
                if (this.yieldCurve != null)
                {
                    return this.yieldCurve; 
                }
                else if (this.yieldCurveIDRef != null)
                {
                    yieldCurve = IDManager.getID(yieldCurveIDRef) as YieldCurve;
                    return this.yieldCurve; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.yieldCurve != value)
                {
                    this.yieldCurve = value;
                }
            }
        }
        #endregion
        
        public string YieldCurveIDRef { get; set; }     // substitude
        #region PricingStructureValuation
        private PricingStructureValuation pricingStructureValuation;
        public PricingStructureValuation PricingStructureValuation
        {
            get
            {
                if (this.pricingStructureValuation != null)
                {
                    return this.pricingStructureValuation; 
                }
                else if (this.pricingStructureValuationIDRef != null)
                {
                    pricingStructureValuation = IDManager.getID(pricingStructureValuationIDRef) as PricingStructureValuation;
                    return this.pricingStructureValuation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.pricingStructureValuation != value)
                {
                    this.pricingStructureValuation = value;
                }
            }
        }
        #endregion
        
        public string PricingStructureValuationIDRef { get; set; }
        #region CreditCurveValuation
        private CreditCurveValuation creditCurveValuation;
        public CreditCurveValuation CreditCurveValuation
        {
            get
            {
                if (this.creditCurveValuation != null)
                {
                    return this.creditCurveValuation; 
                }
                else if (this.creditCurveValuationIDRef != null)
                {
                    creditCurveValuation = IDManager.getID(creditCurveValuationIDRef) as CreditCurveValuation;
                    return this.creditCurveValuation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.creditCurveValuation != value)
                {
                    this.creditCurveValuation = value;
                }
            }
        }
        #endregion
        
        public string CreditCurveValuationIDRef { get; set; }     // substitude
        #region FxCurveValuation
        private FxCurveValuation fxCurveValuation;
        public FxCurveValuation FxCurveValuation
        {
            get
            {
                if (this.fxCurveValuation != null)
                {
                    return this.fxCurveValuation; 
                }
                else if (this.fxCurveValuationIDRef != null)
                {
                    fxCurveValuation = IDManager.getID(fxCurveValuationIDRef) as FxCurveValuation;
                    return this.fxCurveValuation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fxCurveValuation != value)
                {
                    this.fxCurveValuation = value;
                }
            }
        }
        #endregion
        
        public string FxCurveValuationIDRef { get; set; }     // substitude
        #region VolatilityMatrixValuation
        private VolatilityMatrix volatilityMatrixValuation;
        public VolatilityMatrix VolatilityMatrixValuation
        {
            get
            {
                if (this.volatilityMatrixValuation != null)
                {
                    return this.volatilityMatrixValuation; 
                }
                else if (this.volatilityMatrixValuationIDRef != null)
                {
                    volatilityMatrixValuation = IDManager.getID(volatilityMatrixValuationIDRef) as VolatilityMatrix;
                    return this.volatilityMatrixValuation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.volatilityMatrixValuation != value)
                {
                    this.volatilityMatrixValuation = value;
                }
            }
        }
        #endregion
        
        public string VolatilityMatrixIDRef { get; set; }     // substitude
        #region YieldCurveValuation
        private YieldCurveValuation yieldCurveValuation;
        public YieldCurveValuation YieldCurveValuation
        {
            get
            {
                if (this.yieldCurveValuation != null)
                {
                    return this.yieldCurveValuation; 
                }
                else if (this.yieldCurveValuationIDRef != null)
                {
                    yieldCurveValuation = IDManager.getID(yieldCurveValuationIDRef) as YieldCurveValuation;
                    return this.yieldCurveValuation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.yieldCurveValuation != value)
                {
                    this.yieldCurveValuation = value;
                }
            }
        }
        #endregion
        
        public string YieldCurveValuationIDRef { get; set; }     // substitude
        #region BenchmarkPricingMethod
        private List<PricingMethod> benchmarkPricingMethod;
        public List<PricingMethod> BenchmarkPricingMethod
        {
            get
            {
                if (this.benchmarkPricingMethod != null)
                {
                    return this.benchmarkPricingMethod; 
                }
                else if (this.benchmarkPricingMethodIDRef != null)
                {
                    benchmarkPricingMethod = IDManager.getID(benchmarkPricingMethodIDRef) as List<PricingMethod>;
                    return this.benchmarkPricingMethod; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.benchmarkPricingMethod != value)
                {
                    this.benchmarkPricingMethod = value;
                }
            }
        }
        #endregion
        
        public string PricingMethodIDRef { get; set; }
        
    
        
    
    }
    
}

