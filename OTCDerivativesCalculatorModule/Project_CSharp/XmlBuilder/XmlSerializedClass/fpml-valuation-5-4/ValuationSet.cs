using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ValuationSet : ISerialized
    {
        public ValuationSet(XmlNode xmlNode)
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
            
        
            XmlNodeList valuationScenarioNodeList = xmlNode.SelectNodes("valuationScenario");
            
            if (valuationScenarioNodeList != null)
            {
                this.valuationScenario_ = new List<ValuationScenario>();
                foreach (XmlNode item in valuationScenarioNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            valuationScenarioIDRef_ = item.Attributes["id"].Value;
                            valuationScenario_.Add(new ValuationScenario(item));
                            IDManager.SetID(valuationScenarioIDRef_, valuationScenario_[valuationScenario_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            valuationScenarioIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        valuationScenario_.Add(new ValuationScenario(item));
                        }
                    }
                    else
                    {
                        valuationScenario_.Add(new ValuationScenario(item));
                    }
                }
            }
            
        
            XmlNodeList valuationScenarioReferenceNodeList = xmlNode.SelectNodes("valuationScenarioReference");
            
            if (valuationScenarioReferenceNodeList != null)
            {
                this.valuationScenarioReference_ = new List<ValuationScenarioReference>();
                foreach (XmlNode item in valuationScenarioReferenceNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            valuationScenarioReferenceIDRef_ = item.Attributes["id"].Value;
                            valuationScenarioReference_.Add(new ValuationScenarioReference(item));
                            IDManager.SetID(valuationScenarioReferenceIDRef_, valuationScenarioReference_[valuationScenarioReference_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            valuationScenarioReferenceIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        valuationScenarioReference_.Add(new ValuationScenarioReference(item));
                        }
                    }
                    else
                    {
                        valuationScenarioReference_.Add(new ValuationScenarioReference(item));
                    }
                }
            }
            
        
            XmlNode basePartyNode = xmlNode.SelectSingleNode("baseParty");
            
            if (basePartyNode != null)
            {
                if (basePartyNode.Attributes["href"] != null || basePartyNode.Attributes["id"] != null) 
                {
                    if (basePartyNode.Attributes["id"] != null) 
                    {
                        basePartyIDRef_ = basePartyNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(basePartyNode);
                        IDManager.SetID(basePartyIDRef_, ob);
                    }
                    else if (basePartyNode.Attributes["href"] != null)
                    {
                        basePartyIDRef_ = basePartyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        baseParty_ = new PartyReference(basePartyNode);
                    }
                }
                else
                {
                    baseParty_ = new PartyReference(basePartyNode);
                }
            }
            
        
            XmlNodeList quotationCharacteristicsNodeList = xmlNode.SelectNodes("quotationCharacteristics");
            
            if (quotationCharacteristicsNodeList != null)
            {
                this.quotationCharacteristics_ = new List<QuotationCharacteristics>();
                foreach (XmlNode item in quotationCharacteristicsNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            quotationCharacteristicsIDRef_ = item.Attributes["id"].Value;
                            quotationCharacteristics_.Add(new QuotationCharacteristics(item));
                            IDManager.SetID(quotationCharacteristicsIDRef_, quotationCharacteristics_[quotationCharacteristics_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            quotationCharacteristicsIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        quotationCharacteristics_.Add(new QuotationCharacteristics(item));
                        }
                    }
                    else
                    {
                        quotationCharacteristics_.Add(new QuotationCharacteristics(item));
                    }
                }
            }
            
        
            XmlNodeList sensitivitySetDefinitionNodeList = xmlNode.SelectNodes("sensitivitySetDefinition");
            
            if (sensitivitySetDefinitionNodeList != null)
            {
                this.sensitivitySetDefinition_ = new List<SensitivitySetDefinition>();
                foreach (XmlNode item in sensitivitySetDefinitionNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            sensitivitySetDefinitionIDRef_ = item.Attributes["id"].Value;
                            sensitivitySetDefinition_.Add(new SensitivitySetDefinition(item));
                            IDManager.SetID(sensitivitySetDefinitionIDRef_, sensitivitySetDefinition_[sensitivitySetDefinition_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            sensitivitySetDefinitionIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        sensitivitySetDefinition_.Add(new SensitivitySetDefinition(item));
                        }
                    }
                    else
                    {
                        sensitivitySetDefinition_.Add(new SensitivitySetDefinition(item));
                    }
                }
            }
            
        
            XmlNode detailNode = xmlNode.SelectSingleNode("detail");
            
            if (detailNode != null)
            {
                if (detailNode.Attributes["href"] != null || detailNode.Attributes["id"] != null) 
                {
                    if (detailNode.Attributes["id"] != null) 
                    {
                        detailIDRef_ = detailNode.Attributes["id"].Value;
                        ValuationSetDetail ob = new ValuationSetDetail(detailNode);
                        IDManager.SetID(detailIDRef_, ob);
                    }
                    else if (detailNode.Attributes["href"] != null)
                    {
                        detailIDRef_ = detailNode.Attributes["href"].Value;
                    }
                    else
                    {
                        detail_ = new ValuationSetDetail(detailNode);
                    }
                }
                else
                {
                    detail_ = new ValuationSetDetail(detailNode);
                }
            }
            
        
            XmlNodeList assetValuationNodeList = xmlNode.SelectNodes("assetValuation");
            
            if (assetValuationNodeList != null)
            {
                this.assetValuation_ = new List<AssetValuation>();
                foreach (XmlNode item in assetValuationNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            assetValuationIDRef_ = item.Attributes["id"].Value;
                            assetValuation_.Add(new AssetValuation(item));
                            IDManager.SetID(assetValuationIDRef_, assetValuation_[assetValuation_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            assetValuationIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        assetValuation_.Add(new AssetValuation(item));
                        }
                    }
                    else
                    {
                        assetValuation_.Add(new AssetValuation(item));
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
        #region ValuationScenario_
        private List<ValuationScenario> valuationScenario_;
        public List<ValuationScenario> ValuationScenario_
        {
            get
            {
                if (this.valuationScenario_ != null)
                {
                    return this.valuationScenario_; 
                }
                else if (this.valuationScenarioIDRef_ != null)
                {
                    return this.valuationScenario_; 
                }
                else
                {
                      return this.valuationScenario_; 
                }
            }
            set
            {
                if (this.valuationScenario_ != value)
                {
                    this.valuationScenario_ = value;
                }
            }
        }
        #endregion
        
        public string valuationScenarioIDRef_ { get; set; }
        #region ValuationScenarioReference_
        private List<ValuationScenarioReference> valuationScenarioReference_;
        public List<ValuationScenarioReference> ValuationScenarioReference_
        {
            get
            {
                if (this.valuationScenarioReference_ != null)
                {
                    return this.valuationScenarioReference_; 
                }
                else if (this.valuationScenarioReferenceIDRef_ != null)
                {
                    return this.valuationScenarioReference_; 
                }
                else
                {
                      return this.valuationScenarioReference_; 
                }
            }
            set
            {
                if (this.valuationScenarioReference_ != value)
                {
                    this.valuationScenarioReference_ = value;
                }
            }
        }
        #endregion
        
        public string valuationScenarioReferenceIDRef_ { get; set; }
        #region BaseParty_
        private PartyReference baseParty_;
        public PartyReference BaseParty_
        {
            get
            {
                if (this.baseParty_ != null)
                {
                    return this.baseParty_; 
                }
                else if (this.basePartyIDRef_ != null)
                {
                    baseParty_ = IDManager.getID(basePartyIDRef_) as PartyReference;
                    return this.baseParty_; 
                }
                else
                {
                      return this.baseParty_; 
                }
            }
            set
            {
                if (this.baseParty_ != value)
                {
                    this.baseParty_ = value;
                }
            }
        }
        #endregion
        
        public string basePartyIDRef_ { get; set; }
        #region QuotationCharacteristics_
        private List<QuotationCharacteristics> quotationCharacteristics_;
        public List<QuotationCharacteristics> QuotationCharacteristics_
        {
            get
            {
                if (this.quotationCharacteristics_ != null)
                {
                    return this.quotationCharacteristics_; 
                }
                else if (this.quotationCharacteristicsIDRef_ != null)
                {
                    return this.quotationCharacteristics_; 
                }
                else
                {
                      return this.quotationCharacteristics_; 
                }
            }
            set
            {
                if (this.quotationCharacteristics_ != value)
                {
                    this.quotationCharacteristics_ = value;
                }
            }
        }
        #endregion
        
        public string quotationCharacteristicsIDRef_ { get; set; }
        #region SensitivitySetDefinition_
        private List<SensitivitySetDefinition> sensitivitySetDefinition_;
        public List<SensitivitySetDefinition> SensitivitySetDefinition_
        {
            get
            {
                if (this.sensitivitySetDefinition_ != null)
                {
                    return this.sensitivitySetDefinition_; 
                }
                else if (this.sensitivitySetDefinitionIDRef_ != null)
                {
                    return this.sensitivitySetDefinition_; 
                }
                else
                {
                      return this.sensitivitySetDefinition_; 
                }
            }
            set
            {
                if (this.sensitivitySetDefinition_ != value)
                {
                    this.sensitivitySetDefinition_ = value;
                }
            }
        }
        #endregion
        
        public string sensitivitySetDefinitionIDRef_ { get; set; }
        #region Detail_
        private ValuationSetDetail detail_;
        public ValuationSetDetail Detail_
        {
            get
            {
                if (this.detail_ != null)
                {
                    return this.detail_; 
                }
                else if (this.detailIDRef_ != null)
                {
                    detail_ = IDManager.getID(detailIDRef_) as ValuationSetDetail;
                    return this.detail_; 
                }
                else
                {
                      return this.detail_; 
                }
            }
            set
            {
                if (this.detail_ != value)
                {
                    this.detail_ = value;
                }
            }
        }
        #endregion
        
        public string detailIDRef_ { get; set; }
        #region AssetValuation_
        private List<AssetValuation> assetValuation_;
        public List<AssetValuation> AssetValuation_
        {
            get
            {
                if (this.assetValuation_ != null)
                {
                    return this.assetValuation_; 
                }
                else if (this.assetValuationIDRef_ != null)
                {
                    return this.assetValuation_; 
                }
                else
                {
                      return this.assetValuation_; 
                }
            }
            set
            {
                if (this.assetValuation_ != value)
                {
                    this.assetValuation_ = value;
                }
            }
        }
        #endregion
        
        public string assetValuationIDRef_ { get; set; }
        
    
        
    
    }
    
}

