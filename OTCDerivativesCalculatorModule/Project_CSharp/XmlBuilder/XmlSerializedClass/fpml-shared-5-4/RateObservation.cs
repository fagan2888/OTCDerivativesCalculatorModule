using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class RateObservation : ISerialized
    {
        public RateObservation(XmlNode xmlNode)
        {
            XmlNode resetDateNode = xmlNode.SelectSingleNode("resetDate");
            
            if (resetDateNode != null)
            {
                if (resetDateNode.Attributes["href"] != null || resetDateNode.Attributes["id"] != null) 
                {
                    if (resetDateNode.Attributes["id"] != null) 
                    {
                        resetDateIDRef_ = resetDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(resetDateNode);
                        IDManager.SetID(resetDateIDRef_, ob);
                    }
                    else if (resetDateNode.Attributes["href"] != null)
                    {
                        resetDateIDRef_ = resetDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        resetDate_ = new XsdTypeDate(resetDateNode);
                    }
                }
                else
                {
                    resetDate_ = new XsdTypeDate(resetDateNode);
                }
            }
            
        
            XmlNode adjustedFixingDateNode = xmlNode.SelectSingleNode("adjustedFixingDate");
            
            if (adjustedFixingDateNode != null)
            {
                if (adjustedFixingDateNode.Attributes["href"] != null || adjustedFixingDateNode.Attributes["id"] != null) 
                {
                    if (adjustedFixingDateNode.Attributes["id"] != null) 
                    {
                        adjustedFixingDateIDRef_ = adjustedFixingDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(adjustedFixingDateNode);
                        IDManager.SetID(adjustedFixingDateIDRef_, ob);
                    }
                    else if (adjustedFixingDateNode.Attributes["href"] != null)
                    {
                        adjustedFixingDateIDRef_ = adjustedFixingDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        adjustedFixingDate_ = new XsdTypeDate(adjustedFixingDateNode);
                    }
                }
                else
                {
                    adjustedFixingDate_ = new XsdTypeDate(adjustedFixingDateNode);
                }
            }
            
        
            XmlNode observedRateNode = xmlNode.SelectSingleNode("observedRate");
            
            if (observedRateNode != null)
            {
                if (observedRateNode.Attributes["href"] != null || observedRateNode.Attributes["id"] != null) 
                {
                    if (observedRateNode.Attributes["id"] != null) 
                    {
                        observedRateIDRef_ = observedRateNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(observedRateNode);
                        IDManager.SetID(observedRateIDRef_, ob);
                    }
                    else if (observedRateNode.Attributes["href"] != null)
                    {
                        observedRateIDRef_ = observedRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        observedRate_ = new XsdTypeDecimal(observedRateNode);
                    }
                }
                else
                {
                    observedRate_ = new XsdTypeDecimal(observedRateNode);
                }
            }
            
        
            XmlNode treatedRateNode = xmlNode.SelectSingleNode("treatedRate");
            
            if (treatedRateNode != null)
            {
                if (treatedRateNode.Attributes["href"] != null || treatedRateNode.Attributes["id"] != null) 
                {
                    if (treatedRateNode.Attributes["id"] != null) 
                    {
                        treatedRateIDRef_ = treatedRateNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(treatedRateNode);
                        IDManager.SetID(treatedRateIDRef_, ob);
                    }
                    else if (treatedRateNode.Attributes["href"] != null)
                    {
                        treatedRateIDRef_ = treatedRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        treatedRate_ = new XsdTypeDecimal(treatedRateNode);
                    }
                }
                else
                {
                    treatedRate_ = new XsdTypeDecimal(treatedRateNode);
                }
            }
            
        
            XmlNode observationWeightNode = xmlNode.SelectSingleNode("observationWeight");
            
            if (observationWeightNode != null)
            {
                if (observationWeightNode.Attributes["href"] != null || observationWeightNode.Attributes["id"] != null) 
                {
                    if (observationWeightNode.Attributes["id"] != null) 
                    {
                        observationWeightIDRef_ = observationWeightNode.Attributes["id"].Value;
                        XsdTypePositiveInteger ob = new XsdTypePositiveInteger(observationWeightNode);
                        IDManager.SetID(observationWeightIDRef_, ob);
                    }
                    else if (observationWeightNode.Attributes["href"] != null)
                    {
                        observationWeightIDRef_ = observationWeightNode.Attributes["href"].Value;
                    }
                    else
                    {
                        observationWeight_ = new XsdTypePositiveInteger(observationWeightNode);
                    }
                }
                else
                {
                    observationWeight_ = new XsdTypePositiveInteger(observationWeightNode);
                }
            }
            
        
            XmlNode rateReferenceNode = xmlNode.SelectSingleNode("rateReference");
            
            if (rateReferenceNode != null)
            {
                if (rateReferenceNode.Attributes["href"] != null || rateReferenceNode.Attributes["id"] != null) 
                {
                    if (rateReferenceNode.Attributes["id"] != null) 
                    {
                        rateReferenceIDRef_ = rateReferenceNode.Attributes["id"].Value;
                        RateReference ob = new RateReference(rateReferenceNode);
                        IDManager.SetID(rateReferenceIDRef_, ob);
                    }
                    else if (rateReferenceNode.Attributes["href"] != null)
                    {
                        rateReferenceIDRef_ = rateReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        rateReference_ = new RateReference(rateReferenceNode);
                    }
                }
                else
                {
                    rateReference_ = new RateReference(rateReferenceNode);
                }
            }
            
        
            XmlNode forecastRateNode = xmlNode.SelectSingleNode("forecastRate");
            
            if (forecastRateNode != null)
            {
                if (forecastRateNode.Attributes["href"] != null || forecastRateNode.Attributes["id"] != null) 
                {
                    if (forecastRateNode.Attributes["id"] != null) 
                    {
                        forecastRateIDRef_ = forecastRateNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(forecastRateNode);
                        IDManager.SetID(forecastRateIDRef_, ob);
                    }
                    else if (forecastRateNode.Attributes["href"] != null)
                    {
                        forecastRateIDRef_ = forecastRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        forecastRate_ = new XsdTypeDecimal(forecastRateNode);
                    }
                }
                else
                {
                    forecastRate_ = new XsdTypeDecimal(forecastRateNode);
                }
            }
            
        
            XmlNode treatedForecastRateNode = xmlNode.SelectSingleNode("treatedForecastRate");
            
            if (treatedForecastRateNode != null)
            {
                if (treatedForecastRateNode.Attributes["href"] != null || treatedForecastRateNode.Attributes["id"] != null) 
                {
                    if (treatedForecastRateNode.Attributes["id"] != null) 
                    {
                        treatedForecastRateIDRef_ = treatedForecastRateNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(treatedForecastRateNode);
                        IDManager.SetID(treatedForecastRateIDRef_, ob);
                    }
                    else if (treatedForecastRateNode.Attributes["href"] != null)
                    {
                        treatedForecastRateIDRef_ = treatedForecastRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        treatedForecastRate_ = new XsdTypeDecimal(treatedForecastRateNode);
                    }
                }
                else
                {
                    treatedForecastRate_ = new XsdTypeDecimal(treatedForecastRateNode);
                }
            }
            
        
        }
        
    
        #region ResetDate_
        private XsdTypeDate resetDate_;
        public XsdTypeDate ResetDate_
        {
            get
            {
                if (this.resetDate_ != null)
                {
                    return this.resetDate_; 
                }
                else if (this.resetDateIDRef_ != null)
                {
                    resetDate_ = IDManager.getID(resetDateIDRef_) as XsdTypeDate;
                    return this.resetDate_; 
                }
                else
                {
                      return this.resetDate_; 
                }
            }
            set
            {
                if (this.resetDate_ != value)
                {
                    this.resetDate_ = value;
                }
            }
        }
        #endregion
        
        public string resetDateIDRef_ { get; set; }
        #region AdjustedFixingDate_
        private XsdTypeDate adjustedFixingDate_;
        public XsdTypeDate AdjustedFixingDate_
        {
            get
            {
                if (this.adjustedFixingDate_ != null)
                {
                    return this.adjustedFixingDate_; 
                }
                else if (this.adjustedFixingDateIDRef_ != null)
                {
                    adjustedFixingDate_ = IDManager.getID(adjustedFixingDateIDRef_) as XsdTypeDate;
                    return this.adjustedFixingDate_; 
                }
                else
                {
                      return this.adjustedFixingDate_; 
                }
            }
            set
            {
                if (this.adjustedFixingDate_ != value)
                {
                    this.adjustedFixingDate_ = value;
                }
            }
        }
        #endregion
        
        public string adjustedFixingDateIDRef_ { get; set; }
        #region ObservedRate_
        private XsdTypeDecimal observedRate_;
        public XsdTypeDecimal ObservedRate_
        {
            get
            {
                if (this.observedRate_ != null)
                {
                    return this.observedRate_; 
                }
                else if (this.observedRateIDRef_ != null)
                {
                    observedRate_ = IDManager.getID(observedRateIDRef_) as XsdTypeDecimal;
                    return this.observedRate_; 
                }
                else
                {
                      return this.observedRate_; 
                }
            }
            set
            {
                if (this.observedRate_ != value)
                {
                    this.observedRate_ = value;
                }
            }
        }
        #endregion
        
        public string observedRateIDRef_ { get; set; }
        #region TreatedRate_
        private XsdTypeDecimal treatedRate_;
        public XsdTypeDecimal TreatedRate_
        {
            get
            {
                if (this.treatedRate_ != null)
                {
                    return this.treatedRate_; 
                }
                else if (this.treatedRateIDRef_ != null)
                {
                    treatedRate_ = IDManager.getID(treatedRateIDRef_) as XsdTypeDecimal;
                    return this.treatedRate_; 
                }
                else
                {
                      return this.treatedRate_; 
                }
            }
            set
            {
                if (this.treatedRate_ != value)
                {
                    this.treatedRate_ = value;
                }
            }
        }
        #endregion
        
        public string treatedRateIDRef_ { get; set; }
        #region ObservationWeight_
        private XsdTypePositiveInteger observationWeight_;
        public XsdTypePositiveInteger ObservationWeight_
        {
            get
            {
                if (this.observationWeight_ != null)
                {
                    return this.observationWeight_; 
                }
                else if (this.observationWeightIDRef_ != null)
                {
                    observationWeight_ = IDManager.getID(observationWeightIDRef_) as XsdTypePositiveInteger;
                    return this.observationWeight_; 
                }
                else
                {
                      return this.observationWeight_; 
                }
            }
            set
            {
                if (this.observationWeight_ != value)
                {
                    this.observationWeight_ = value;
                }
            }
        }
        #endregion
        
        public string observationWeightIDRef_ { get; set; }
        #region RateReference_
        private RateReference rateReference_;
        public RateReference RateReference_
        {
            get
            {
                if (this.rateReference_ != null)
                {
                    return this.rateReference_; 
                }
                else if (this.rateReferenceIDRef_ != null)
                {
                    rateReference_ = IDManager.getID(rateReferenceIDRef_) as RateReference;
                    return this.rateReference_; 
                }
                else
                {
                      return this.rateReference_; 
                }
            }
            set
            {
                if (this.rateReference_ != value)
                {
                    this.rateReference_ = value;
                }
            }
        }
        #endregion
        
        public string rateReferenceIDRef_ { get; set; }
        #region ForecastRate_
        private XsdTypeDecimal forecastRate_;
        public XsdTypeDecimal ForecastRate_
        {
            get
            {
                if (this.forecastRate_ != null)
                {
                    return this.forecastRate_; 
                }
                else if (this.forecastRateIDRef_ != null)
                {
                    forecastRate_ = IDManager.getID(forecastRateIDRef_) as XsdTypeDecimal;
                    return this.forecastRate_; 
                }
                else
                {
                      return this.forecastRate_; 
                }
            }
            set
            {
                if (this.forecastRate_ != value)
                {
                    this.forecastRate_ = value;
                }
            }
        }
        #endregion
        
        public string forecastRateIDRef_ { get; set; }
        #region TreatedForecastRate_
        private XsdTypeDecimal treatedForecastRate_;
        public XsdTypeDecimal TreatedForecastRate_
        {
            get
            {
                if (this.treatedForecastRate_ != null)
                {
                    return this.treatedForecastRate_; 
                }
                else if (this.treatedForecastRateIDRef_ != null)
                {
                    treatedForecastRate_ = IDManager.getID(treatedForecastRateIDRef_) as XsdTypeDecimal;
                    return this.treatedForecastRate_; 
                }
                else
                {
                      return this.treatedForecastRate_; 
                }
            }
            set
            {
                if (this.treatedForecastRate_ != value)
                {
                    this.treatedForecastRate_ = value;
                }
            }
        }
        #endregion
        
        public string treatedForecastRateIDRef_ { get; set; }
        
    
        
    
    }
    
}

