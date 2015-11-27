using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class FxBarrierFeature
    {
        public FxBarrierFeature(XmlNode xmlNode)
        {
            XmlNodeList barrierTypeNodeList = xmlNode.SelectNodes("barrierType");
            if (barrierTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in barrierTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        barrierTypeIDRef = item.Attributes["id"].Name;
                        FxBarrierTypeEnum ob = FxBarrierTypeEnum();
                        IDManager.SetID(barrierTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        barrierTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        barrierType = new FxBarrierTypeEnum(item);
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
        
    
        #region BarrierType
        private FxBarrierTypeEnum barrierType;
        public FxBarrierTypeEnum BarrierType
        {
            get
            {
                if (this.barrierType != null)
                {
                    return this.barrierType; 
                }
                else if (this.barrierTypeIDRef != null)
                {
                    barrierType = IDManager.getID(barrierTypeIDRef) as FxBarrierTypeEnum;
                    return this.barrierType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.barrierType != value)
                {
                    this.barrierType = value;
                }
            }
        }
        #endregion
        
        public string FxBarrierTypeEnumIDRef { get; set; }
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

