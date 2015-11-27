using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ValuationSet
    {
        public ValuationSet(XmlNode xmlNode)
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
            
        
            XmlNodeList valuationScenarioNodeList = xmlNode.SelectNodes("valuationScenario");
            
            foreach (XmlNode item in valuationScenarioNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        valuationScenarioIDRef = item.Attributes["id"].Name;
                        List<ValuationScenario> ob = new List<ValuationScenario>();
                        ob.Add(new ValuationScenario(item));
                        IDManager.SetID(valuationScenarioIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        valuationScenarioIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    valuationScenario.Add(new ValuationScenario(item));
                    }
                }
            }
            
        
            XmlNodeList valuationScenarioReferenceNodeList = xmlNode.SelectNodes("valuationScenarioReference");
            
            foreach (XmlNode item in valuationScenarioReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        valuationScenarioReferenceIDRef = item.Attributes["id"].Name;
                        List<ValuationScenarioReference> ob = new List<ValuationScenarioReference>();
                        ob.Add(new ValuationScenarioReference(item));
                        IDManager.SetID(valuationScenarioReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        valuationScenarioReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    valuationScenarioReference.Add(new ValuationScenarioReference(item));
                    }
                }
            }
            
        
            XmlNodeList basePartyNodeList = xmlNode.SelectNodes("baseParty");
            if (basePartyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in basePartyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        basePartyIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(basePartyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        basePartyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        baseParty = new PartyReference(item);
                    }
                }
            }
            
        
            XmlNodeList quotationCharacteristicsNodeList = xmlNode.SelectNodes("quotationCharacteristics");
            
            foreach (XmlNode item in quotationCharacteristicsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        quotationCharacteristicsIDRef = item.Attributes["id"].Name;
                        List<QuotationCharacteristics> ob = new List<QuotationCharacteristics>();
                        ob.Add(new QuotationCharacteristics(item));
                        IDManager.SetID(quotationCharacteristicsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        quotationCharacteristicsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    quotationCharacteristics.Add(new QuotationCharacteristics(item));
                    }
                }
            }
            
        
            XmlNodeList sensitivitySetDefinitionNodeList = xmlNode.SelectNodes("sensitivitySetDefinition");
            
            foreach (XmlNode item in sensitivitySetDefinitionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        sensitivitySetDefinitionIDRef = item.Attributes["id"].Name;
                        List<SensitivitySetDefinition> ob = new List<SensitivitySetDefinition>();
                        ob.Add(new SensitivitySetDefinition(item));
                        IDManager.SetID(sensitivitySetDefinitionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        sensitivitySetDefinitionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    sensitivitySetDefinition.Add(new SensitivitySetDefinition(item));
                    }
                }
            }
            
        
            XmlNodeList detailNodeList = xmlNode.SelectNodes("detail");
            if (detailNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in detailNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        detailIDRef = item.Attributes["id"].Name;
                        ValuationSetDetail ob = ValuationSetDetail();
                        IDManager.SetID(detailIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        detailIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        detail = new ValuationSetDetail(item);
                    }
                }
            }
            
        
            XmlNodeList assetValuationNodeList = xmlNode.SelectNodes("assetValuation");
            
            foreach (XmlNode item in assetValuationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        assetValuationIDRef = item.Attributes["id"].Name;
                        List<AssetValuation> ob = new List<AssetValuation>();
                        ob.Add(new AssetValuation(item));
                        IDManager.SetID(assetValuationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        assetValuationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    assetValuation.Add(new AssetValuation(item));
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
        #region ValuationScenario
        private List<ValuationScenario> valuationScenario;
        public List<ValuationScenario> ValuationScenario
        {
            get
            {
                if (this.valuationScenario != null)
                {
                    return this.valuationScenario; 
                }
                else if (this.valuationScenarioIDRef != null)
                {
                    valuationScenario = IDManager.getID(valuationScenarioIDRef) as List<ValuationScenario>;
                    return this.valuationScenario; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.valuationScenario != value)
                {
                    this.valuationScenario = value;
                }
            }
        }
        #endregion
        
        public string ValuationScenarioIDRef { get; set; }
        #region ValuationScenarioReference
        private List<ValuationScenarioReference> valuationScenarioReference;
        public List<ValuationScenarioReference> ValuationScenarioReference
        {
            get
            {
                if (this.valuationScenarioReference != null)
                {
                    return this.valuationScenarioReference; 
                }
                else if (this.valuationScenarioReferenceIDRef != null)
                {
                    valuationScenarioReference = IDManager.getID(valuationScenarioReferenceIDRef) as List<ValuationScenarioReference>;
                    return this.valuationScenarioReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.valuationScenarioReference != value)
                {
                    this.valuationScenarioReference = value;
                }
            }
        }
        #endregion
        
        public string ValuationScenarioReferenceIDRef { get; set; }
        #region BaseParty
        private PartyReference baseParty;
        public PartyReference BaseParty
        {
            get
            {
                if (this.baseParty != null)
                {
                    return this.baseParty; 
                }
                else if (this.basePartyIDRef != null)
                {
                    baseParty = IDManager.getID(basePartyIDRef) as PartyReference;
                    return this.baseParty; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.baseParty != value)
                {
                    this.baseParty = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        #region QuotationCharacteristics
        private List<QuotationCharacteristics> quotationCharacteristics;
        public List<QuotationCharacteristics> QuotationCharacteristics
        {
            get
            {
                if (this.quotationCharacteristics != null)
                {
                    return this.quotationCharacteristics; 
                }
                else if (this.quotationCharacteristicsIDRef != null)
                {
                    quotationCharacteristics = IDManager.getID(quotationCharacteristicsIDRef) as List<QuotationCharacteristics>;
                    return this.quotationCharacteristics; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.quotationCharacteristics != value)
                {
                    this.quotationCharacteristics = value;
                }
            }
        }
        #endregion
        
        public string QuotationCharacteristicsIDRef { get; set; }
        #region SensitivitySetDefinition
        private List<SensitivitySetDefinition> sensitivitySetDefinition;
        public List<SensitivitySetDefinition> SensitivitySetDefinition
        {
            get
            {
                if (this.sensitivitySetDefinition != null)
                {
                    return this.sensitivitySetDefinition; 
                }
                else if (this.sensitivitySetDefinitionIDRef != null)
                {
                    sensitivitySetDefinition = IDManager.getID(sensitivitySetDefinitionIDRef) as List<SensitivitySetDefinition>;
                    return this.sensitivitySetDefinition; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.sensitivitySetDefinition != value)
                {
                    this.sensitivitySetDefinition = value;
                }
            }
        }
        #endregion
        
        public string SensitivitySetDefinitionIDRef { get; set; }
        #region Detail
        private ValuationSetDetail detail;
        public ValuationSetDetail Detail
        {
            get
            {
                if (this.detail != null)
                {
                    return this.detail; 
                }
                else if (this.detailIDRef != null)
                {
                    detail = IDManager.getID(detailIDRef) as ValuationSetDetail;
                    return this.detail; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.detail != value)
                {
                    this.detail = value;
                }
            }
        }
        #endregion
        
        public string ValuationSetDetailIDRef { get; set; }
        #region AssetValuation
        private List<AssetValuation> assetValuation;
        public List<AssetValuation> AssetValuation
        {
            get
            {
                if (this.assetValuation != null)
                {
                    return this.assetValuation; 
                }
                else if (this.assetValuationIDRef != null)
                {
                    assetValuation = IDManager.getID(assetValuationIDRef) as List<AssetValuation>;
                    return this.assetValuation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.assetValuation != value)
                {
                    this.assetValuation = value;
                }
            }
        }
        #endregion
        
        public string AssetValuationIDRef { get; set; }
        
    
        
    
    }
    
}

