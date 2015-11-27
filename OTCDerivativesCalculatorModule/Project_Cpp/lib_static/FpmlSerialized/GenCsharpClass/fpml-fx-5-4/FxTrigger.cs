using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class FxTrigger
    {
        public FxTrigger(XmlNode xmlNode)
        {
            XmlNodeList triggerConditionNodeList = xmlNode.SelectNodes("triggerCondition");
            if (triggerConditionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in triggerConditionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        triggerConditionIDRef = item.Attributes["id"].Name;
                        TriggerConditionEnum ob = TriggerConditionEnum();
                        IDManager.SetID(triggerConditionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        triggerConditionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        triggerCondition = new TriggerConditionEnum(item);
                    }
                }
            }
            
        
            XmlNodeList quotedCurrencyPairNodeList = xmlNode.SelectNodes("quotedCurrencyPair");
            if (quotedCurrencyPairNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in quotedCurrencyPairNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        quotedCurrencyPairIDRef = item.Attributes["id"].Name;
                        QuotedCurrencyPair ob = QuotedCurrencyPair();
                        IDManager.SetID(quotedCurrencyPairIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        quotedCurrencyPairIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        quotedCurrencyPair = new QuotedCurrencyPair(item);
                    }
                }
            }
            
        
            XmlNodeList triggerRateNodeList = xmlNode.SelectNodes("triggerRate");
            if (triggerRateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in triggerRateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        triggerRateIDRef = item.Attributes["id"].Name;
                        PositiveDecimal ob = PositiveDecimal();
                        IDManager.SetID(triggerRateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        triggerRateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        triggerRate = new PositiveDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList spotRateNodeList = xmlNode.SelectNodes("spotRate");
            if (spotRateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in spotRateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        spotRateIDRef = item.Attributes["id"].Name;
                        PositiveDecimal ob = PositiveDecimal();
                        IDManager.SetID(spotRateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        spotRateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        spotRate = new PositiveDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList informationSourceNodeList = xmlNode.SelectNodes("informationSource");
            
            foreach (XmlNode item in informationSourceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        informationSourceIDRef = item.Attributes["id"].Name;
                        List<InformationSource> ob = new List<InformationSource>();
                        ob.Add(new InformationSource(item));
                        IDManager.SetID(informationSourceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        informationSourceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    informationSource.Add(new InformationSource(item));
                    }
                }
            }
            
        
        }
        
    
        #region TriggerCondition
        private TriggerConditionEnum triggerCondition;
        public TriggerConditionEnum TriggerCondition
        {
            get
            {
                if (this.triggerCondition != null)
                {
                    return this.triggerCondition; 
                }
                else if (this.triggerConditionIDRef != null)
                {
                    triggerCondition = IDManager.getID(triggerConditionIDRef) as TriggerConditionEnum;
                    return this.triggerCondition; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.triggerCondition != value)
                {
                    this.triggerCondition = value;
                }
            }
        }
        #endregion
        
        public string TriggerConditionEnumIDRef { get; set; }
        #region QuotedCurrencyPair
        private QuotedCurrencyPair quotedCurrencyPair;
        public QuotedCurrencyPair QuotedCurrencyPair
        {
            get
            {
                if (this.quotedCurrencyPair != null)
                {
                    return this.quotedCurrencyPair; 
                }
                else if (this.quotedCurrencyPairIDRef != null)
                {
                    quotedCurrencyPair = IDManager.getID(quotedCurrencyPairIDRef) as QuotedCurrencyPair;
                    return this.quotedCurrencyPair; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.quotedCurrencyPair != value)
                {
                    this.quotedCurrencyPair = value;
                }
            }
        }
        #endregion
        
        public string QuotedCurrencyPairIDRef { get; set; }
        #region TriggerRate
        private PositiveDecimal triggerRate;
        public PositiveDecimal TriggerRate
        {
            get
            {
                if (this.triggerRate != null)
                {
                    return this.triggerRate; 
                }
                else if (this.triggerRateIDRef != null)
                {
                    triggerRate = IDManager.getID(triggerRateIDRef) as PositiveDecimal;
                    return this.triggerRate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.triggerRate != value)
                {
                    this.triggerRate = value;
                }
            }
        }
        #endregion
        
        public string PositiveDecimalIDRef { get; set; }
        #region SpotRate
        private PositiveDecimal spotRate;
        public PositiveDecimal SpotRate
        {
            get
            {
                if (this.spotRate != null)
                {
                    return this.spotRate; 
                }
                else if (this.spotRateIDRef != null)
                {
                    spotRate = IDManager.getID(spotRateIDRef) as PositiveDecimal;
                    return this.spotRate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.spotRate != value)
                {
                    this.spotRate = value;
                }
            }
        }
        #endregion
        
        public string PositiveDecimalIDRef { get; set; }
        #region InformationSource
        private List<InformationSource> informationSource;
        public List<InformationSource> InformationSource
        {
            get
            {
                if (this.informationSource != null)
                {
                    return this.informationSource; 
                }
                else if (this.informationSourceIDRef != null)
                {
                    informationSource = IDManager.getID(informationSourceIDRef) as List<InformationSource>;
                    return this.informationSource; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.informationSource != value)
                {
                    this.informationSource = value;
                }
            }
        }
        #endregion
        
        public string InformationSourceIDRef { get; set; }
        
    
        
    
    }
    
}

