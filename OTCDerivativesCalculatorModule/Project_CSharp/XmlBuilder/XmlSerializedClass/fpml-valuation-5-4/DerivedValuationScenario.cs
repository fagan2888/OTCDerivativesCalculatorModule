using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class DerivedValuationScenario : ISerialized
    {
        public DerivedValuationScenario(XmlNode xmlNode)
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
            
        
            XmlNode baseValuationScenarioNode = xmlNode.SelectSingleNode("baseValuationScenario");
            
            if (baseValuationScenarioNode != null)
            {
                if (baseValuationScenarioNode.Attributes["href"] != null || baseValuationScenarioNode.Attributes["id"] != null) 
                {
                    if (baseValuationScenarioNode.Attributes["id"] != null) 
                    {
                        baseValuationScenarioIDRef_ = baseValuationScenarioNode.Attributes["id"].Value;
                        ValuationScenarioReference ob = new ValuationScenarioReference(baseValuationScenarioNode);
                        IDManager.SetID(baseValuationScenarioIDRef_, ob);
                    }
                    else if (baseValuationScenarioNode.Attributes["href"] != null)
                    {
                        baseValuationScenarioIDRef_ = baseValuationScenarioNode.Attributes["href"].Value;
                    }
                    else
                    {
                        baseValuationScenario_ = new ValuationScenarioReference(baseValuationScenarioNode);
                    }
                }
                else
                {
                    baseValuationScenario_ = new ValuationScenarioReference(baseValuationScenarioNode);
                }
            }
            
        
            XmlNode valuationDateNode = xmlNode.SelectSingleNode("valuationDate");
            
            if (valuationDateNode != null)
            {
                if (valuationDateNode.Attributes["href"] != null || valuationDateNode.Attributes["id"] != null) 
                {
                    if (valuationDateNode.Attributes["id"] != null) 
                    {
                        valuationDateIDRef_ = valuationDateNode.Attributes["id"].Value;
                        IdentifiedDate ob = new IdentifiedDate(valuationDateNode);
                        IDManager.SetID(valuationDateIDRef_, ob);
                    }
                    else if (valuationDateNode.Attributes["href"] != null)
                    {
                        valuationDateIDRef_ = valuationDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        valuationDate_ = new IdentifiedDate(valuationDateNode);
                    }
                }
                else
                {
                    valuationDate_ = new IdentifiedDate(valuationDateNode);
                }
            }
            
        
            XmlNode marketReferenceNode = xmlNode.SelectSingleNode("marketReference");
            
            if (marketReferenceNode != null)
            {
                if (marketReferenceNode.Attributes["href"] != null || marketReferenceNode.Attributes["id"] != null) 
                {
                    if (marketReferenceNode.Attributes["id"] != null) 
                    {
                        marketReferenceIDRef_ = marketReferenceNode.Attributes["id"].Value;
                        MarketReference ob = new MarketReference(marketReferenceNode);
                        IDManager.SetID(marketReferenceIDRef_, ob);
                    }
                    else if (marketReferenceNode.Attributes["href"] != null)
                    {
                        marketReferenceIDRef_ = marketReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        marketReference_ = new MarketReference(marketReferenceNode);
                    }
                }
                else
                {
                    marketReference_ = new MarketReference(marketReferenceNode);
                }
            }
            
        
            XmlNodeList shiftNodeList = xmlNode.SelectNodes("shift");
            
            if (shiftNodeList != null)
            {
                this.shift_ = new List<PricingParameterShift>();
                foreach (XmlNode item in shiftNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            shiftIDRef_ = item.Attributes["id"].Value;
                            shift_.Add(new PricingParameterShift(item));
                            IDManager.SetID(shiftIDRef_, shift_[shift_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            shiftIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        shift_.Add(new PricingParameterShift(item));
                        }
                    }
                    else
                    {
                        shift_.Add(new PricingParameterShift(item));
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
        #region BaseValuationScenario_
        private ValuationScenarioReference baseValuationScenario_;
        public ValuationScenarioReference BaseValuationScenario_
        {
            get
            {
                if (this.baseValuationScenario_ != null)
                {
                    return this.baseValuationScenario_; 
                }
                else if (this.baseValuationScenarioIDRef_ != null)
                {
                    baseValuationScenario_ = IDManager.getID(baseValuationScenarioIDRef_) as ValuationScenarioReference;
                    return this.baseValuationScenario_; 
                }
                else
                {
                      return this.baseValuationScenario_; 
                }
            }
            set
            {
                if (this.baseValuationScenario_ != value)
                {
                    this.baseValuationScenario_ = value;
                }
            }
        }
        #endregion
        
        public string baseValuationScenarioIDRef_ { get; set; }
        #region ValuationDate_
        private IdentifiedDate valuationDate_;
        public IdentifiedDate ValuationDate_
        {
            get
            {
                if (this.valuationDate_ != null)
                {
                    return this.valuationDate_; 
                }
                else if (this.valuationDateIDRef_ != null)
                {
                    valuationDate_ = IDManager.getID(valuationDateIDRef_) as IdentifiedDate;
                    return this.valuationDate_; 
                }
                else
                {
                      return this.valuationDate_; 
                }
            }
            set
            {
                if (this.valuationDate_ != value)
                {
                    this.valuationDate_ = value;
                }
            }
        }
        #endregion
        
        public string valuationDateIDRef_ { get; set; }
        #region MarketReference_
        private MarketReference marketReference_;
        public MarketReference MarketReference_
        {
            get
            {
                if (this.marketReference_ != null)
                {
                    return this.marketReference_; 
                }
                else if (this.marketReferenceIDRef_ != null)
                {
                    marketReference_ = IDManager.getID(marketReferenceIDRef_) as MarketReference;
                    return this.marketReference_; 
                }
                else
                {
                      return this.marketReference_; 
                }
            }
            set
            {
                if (this.marketReference_ != value)
                {
                    this.marketReference_ = value;
                }
            }
        }
        #endregion
        
        public string marketReferenceIDRef_ { get; set; }
        #region Shift_
        private List<PricingParameterShift> shift_;
        public List<PricingParameterShift> Shift_
        {
            get
            {
                if (this.shift_ != null)
                {
                    return this.shift_; 
                }
                else if (this.shiftIDRef_ != null)
                {
                    return this.shift_; 
                }
                else
                {
                      return this.shift_; 
                }
            }
            set
            {
                if (this.shift_ != value)
                {
                    this.shift_ = value;
                }
            }
        }
        #endregion
        
        public string shiftIDRef_ { get; set; }
        
    
        
    
    }
    
}

