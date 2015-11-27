using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class FxTouch
    {
        public FxTouch(XmlNode xmlNode)
        {
            XmlNodeList touchConditionNodeList = xmlNode.SelectNodes("touchCondition");
            if (touchConditionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in touchConditionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        touchConditionIDRef = item.Attributes["id"].Name;
                        TouchConditionEnum ob = TouchConditionEnum();
                        IDManager.SetID(touchConditionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        touchConditionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        touchCondition = new TouchConditionEnum(item);
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
            
        
            XmlNodeList observationStartDateNodeList = xmlNode.SelectNodes("observationStartDate");
            if (observationStartDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in observationStartDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        observationStartDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(observationStartDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        observationStartDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        observationStartDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList observationEndDateNodeList = xmlNode.SelectNodes("observationEndDate");
            if (observationEndDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in observationEndDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        observationEndDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(observationEndDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        observationEndDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        observationEndDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
        }
        
    
        #region TouchCondition
        private TouchConditionEnum touchCondition;
        public TouchConditionEnum TouchCondition
        {
            get
            {
                if (this.touchCondition != null)
                {
                    return this.touchCondition; 
                }
                else if (this.touchConditionIDRef != null)
                {
                    touchCondition = IDManager.getID(touchConditionIDRef) as TouchConditionEnum;
                    return this.touchCondition; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.touchCondition != value)
                {
                    this.touchCondition = value;
                }
            }
        }
        #endregion
        
        public string TouchConditionEnumIDRef { get; set; }
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
        #region ObservationStartDate
        private XsdTypeDate observationStartDate;
        public XsdTypeDate ObservationStartDate
        {
            get
            {
                if (this.observationStartDate != null)
                {
                    return this.observationStartDate; 
                }
                else if (this.observationStartDateIDRef != null)
                {
                    observationStartDate = IDManager.getID(observationStartDateIDRef) as XsdTypeDate;
                    return this.observationStartDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.observationStartDate != value)
                {
                    this.observationStartDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region ObservationEndDate
        private XsdTypeDate observationEndDate;
        public XsdTypeDate ObservationEndDate
        {
            get
            {
                if (this.observationEndDate != null)
                {
                    return this.observationEndDate; 
                }
                else if (this.observationEndDateIDRef != null)
                {
                    observationEndDate = IDManager.getID(observationEndDateIDRef) as XsdTypeDate;
                    return this.observationEndDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.observationEndDate != value)
                {
                    this.observationEndDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        
    
        
    
    }
    
}

