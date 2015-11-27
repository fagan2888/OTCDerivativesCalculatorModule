using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class RateObservation
    {
        public RateObservation(XmlNode xmlNode)
        {
            XmlNodeList resetDateNodeList = xmlNode.SelectNodes("resetDate");
            if (resetDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in resetDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        resetDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(resetDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        resetDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        resetDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList adjustedFixingDateNodeList = xmlNode.SelectNodes("adjustedFixingDate");
            if (adjustedFixingDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in adjustedFixingDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        adjustedFixingDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(adjustedFixingDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        adjustedFixingDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        adjustedFixingDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList observedRateNodeList = xmlNode.SelectNodes("observedRate");
            if (observedRateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in observedRateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        observedRateIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(observedRateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        observedRateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        observedRate = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList treatedRateNodeList = xmlNode.SelectNodes("treatedRate");
            if (treatedRateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in treatedRateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        treatedRateIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(treatedRateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        treatedRateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        treatedRate = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList observationWeightNodeList = xmlNode.SelectNodes("observationWeight");
            if (observationWeightNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in observationWeightNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        observationWeightIDRef = item.Attributes["id"].Name;
                        XsdTypePositiveInteger ob = XsdTypePositiveInteger();
                        IDManager.SetID(observationWeightIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        observationWeightIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        observationWeight = new XsdTypePositiveInteger(item);
                    }
                }
            }
            
        
            XmlNodeList rateReferenceNodeList = xmlNode.SelectNodes("rateReference");
            if (rateReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in rateReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        rateReferenceIDRef = item.Attributes["id"].Name;
                        RateReference ob = RateReference();
                        IDManager.SetID(rateReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        rateReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        rateReference = new RateReference(item);
                    }
                }
            }
            
        
            XmlNodeList forecastRateNodeList = xmlNode.SelectNodes("forecastRate");
            if (forecastRateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in forecastRateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        forecastRateIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(forecastRateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        forecastRateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        forecastRate = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList treatedForecastRateNodeList = xmlNode.SelectNodes("treatedForecastRate");
            if (treatedForecastRateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in treatedForecastRateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        treatedForecastRateIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(treatedForecastRateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        treatedForecastRateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        treatedForecastRate = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
        }
        
    
        #region ResetDate
        private XsdTypeDate resetDate;
        public XsdTypeDate ResetDate
        {
            get
            {
                if (this.resetDate != null)
                {
                    return this.resetDate; 
                }
                else if (this.resetDateIDRef != null)
                {
                    resetDate = IDManager.getID(resetDateIDRef) as XsdTypeDate;
                    return this.resetDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.resetDate != value)
                {
                    this.resetDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region AdjustedFixingDate
        private XsdTypeDate adjustedFixingDate;
        public XsdTypeDate AdjustedFixingDate
        {
            get
            {
                if (this.adjustedFixingDate != null)
                {
                    return this.adjustedFixingDate; 
                }
                else if (this.adjustedFixingDateIDRef != null)
                {
                    adjustedFixingDate = IDManager.getID(adjustedFixingDateIDRef) as XsdTypeDate;
                    return this.adjustedFixingDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.adjustedFixingDate != value)
                {
                    this.adjustedFixingDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region ObservedRate
        private XsdTypeDecimal observedRate;
        public XsdTypeDecimal ObservedRate
        {
            get
            {
                if (this.observedRate != null)
                {
                    return this.observedRate; 
                }
                else if (this.observedRateIDRef != null)
                {
                    observedRate = IDManager.getID(observedRateIDRef) as XsdTypeDecimal;
                    return this.observedRate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.observedRate != value)
                {
                    this.observedRate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region TreatedRate
        private XsdTypeDecimal treatedRate;
        public XsdTypeDecimal TreatedRate
        {
            get
            {
                if (this.treatedRate != null)
                {
                    return this.treatedRate; 
                }
                else if (this.treatedRateIDRef != null)
                {
                    treatedRate = IDManager.getID(treatedRateIDRef) as XsdTypeDecimal;
                    return this.treatedRate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.treatedRate != value)
                {
                    this.treatedRate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region ObservationWeight
        private XsdTypePositiveInteger observationWeight;
        public XsdTypePositiveInteger ObservationWeight
        {
            get
            {
                if (this.observationWeight != null)
                {
                    return this.observationWeight; 
                }
                else if (this.observationWeightIDRef != null)
                {
                    observationWeight = IDManager.getID(observationWeightIDRef) as XsdTypePositiveInteger;
                    return this.observationWeight; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.observationWeight != value)
                {
                    this.observationWeight = value;
                }
            }
        }
        #endregion
        
        public string XsdTypePositiveIntegerIDRef { get; set; }
        #region RateReference
        private RateReference rateReference;
        public RateReference RateReference
        {
            get
            {
                if (this.rateReference != null)
                {
                    return this.rateReference; 
                }
                else if (this.rateReferenceIDRef != null)
                {
                    rateReference = IDManager.getID(rateReferenceIDRef) as RateReference;
                    return this.rateReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.rateReference != value)
                {
                    this.rateReference = value;
                }
            }
        }
        #endregion
        
        public string RateReferenceIDRef { get; set; }
        #region ForecastRate
        private XsdTypeDecimal forecastRate;
        public XsdTypeDecimal ForecastRate
        {
            get
            {
                if (this.forecastRate != null)
                {
                    return this.forecastRate; 
                }
                else if (this.forecastRateIDRef != null)
                {
                    forecastRate = IDManager.getID(forecastRateIDRef) as XsdTypeDecimal;
                    return this.forecastRate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.forecastRate != value)
                {
                    this.forecastRate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region TreatedForecastRate
        private XsdTypeDecimal treatedForecastRate;
        public XsdTypeDecimal TreatedForecastRate
        {
            get
            {
                if (this.treatedForecastRate != null)
                {
                    return this.treatedForecastRate; 
                }
                else if (this.treatedForecastRateIDRef != null)
                {
                    treatedForecastRate = IDManager.getID(treatedForecastRateIDRef) as XsdTypeDecimal;
                    return this.treatedForecastRate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.treatedForecastRate != value)
                {
                    this.treatedForecastRate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        
    
        
    
    }
    
}

