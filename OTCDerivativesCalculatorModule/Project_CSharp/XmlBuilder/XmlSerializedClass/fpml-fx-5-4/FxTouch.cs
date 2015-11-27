using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FxTouch : ISerialized
    {
        public FxTouch(XmlNode xmlNode)
        {
            XmlNode touchConditionNode = xmlNode.SelectSingleNode("touchCondition");
            
            if (touchConditionNode != null)
            {
                if (touchConditionNode.Attributes["href"] != null || touchConditionNode.Attributes["id"] != null) 
                {
                    if (touchConditionNode.Attributes["id"] != null) 
                    {
                        touchConditionIDRef_ = touchConditionNode.Attributes["id"].Value;
                        TouchConditionEnum ob = new TouchConditionEnum(touchConditionNode);
                        IDManager.SetID(touchConditionIDRef_, ob);
                    }
                    else if (touchConditionNode.Attributes["href"] != null)
                    {
                        touchConditionIDRef_ = touchConditionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        touchCondition_ = new TouchConditionEnum(touchConditionNode);
                    }
                }
                else
                {
                    touchCondition_ = new TouchConditionEnum(touchConditionNode);
                }
            }
            
        
            XmlNode quotedCurrencyPairNode = xmlNode.SelectSingleNode("quotedCurrencyPair");
            
            if (quotedCurrencyPairNode != null)
            {
                if (quotedCurrencyPairNode.Attributes["href"] != null || quotedCurrencyPairNode.Attributes["id"] != null) 
                {
                    if (quotedCurrencyPairNode.Attributes["id"] != null) 
                    {
                        quotedCurrencyPairIDRef_ = quotedCurrencyPairNode.Attributes["id"].Value;
                        QuotedCurrencyPair ob = new QuotedCurrencyPair(quotedCurrencyPairNode);
                        IDManager.SetID(quotedCurrencyPairIDRef_, ob);
                    }
                    else if (quotedCurrencyPairNode.Attributes["href"] != null)
                    {
                        quotedCurrencyPairIDRef_ = quotedCurrencyPairNode.Attributes["href"].Value;
                    }
                    else
                    {
                        quotedCurrencyPair_ = new QuotedCurrencyPair(quotedCurrencyPairNode);
                    }
                }
                else
                {
                    quotedCurrencyPair_ = new QuotedCurrencyPair(quotedCurrencyPairNode);
                }
            }
            
        
            XmlNode triggerRateNode = xmlNode.SelectSingleNode("triggerRate");
            
            if (triggerRateNode != null)
            {
                if (triggerRateNode.Attributes["href"] != null || triggerRateNode.Attributes["id"] != null) 
                {
                    if (triggerRateNode.Attributes["id"] != null) 
                    {
                        triggerRateIDRef_ = triggerRateNode.Attributes["id"].Value;
                        PositiveDecimal ob = new PositiveDecimal(triggerRateNode);
                        IDManager.SetID(triggerRateIDRef_, ob);
                    }
                    else if (triggerRateNode.Attributes["href"] != null)
                    {
                        triggerRateIDRef_ = triggerRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        triggerRate_ = new PositiveDecimal(triggerRateNode);
                    }
                }
                else
                {
                    triggerRate_ = new PositiveDecimal(triggerRateNode);
                }
            }
            
        
            XmlNode spotRateNode = xmlNode.SelectSingleNode("spotRate");
            
            if (spotRateNode != null)
            {
                if (spotRateNode.Attributes["href"] != null || spotRateNode.Attributes["id"] != null) 
                {
                    if (spotRateNode.Attributes["id"] != null) 
                    {
                        spotRateIDRef_ = spotRateNode.Attributes["id"].Value;
                        PositiveDecimal ob = new PositiveDecimal(spotRateNode);
                        IDManager.SetID(spotRateIDRef_, ob);
                    }
                    else if (spotRateNode.Attributes["href"] != null)
                    {
                        spotRateIDRef_ = spotRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        spotRate_ = new PositiveDecimal(spotRateNode);
                    }
                }
                else
                {
                    spotRate_ = new PositiveDecimal(spotRateNode);
                }
            }
            
        
            XmlNodeList informationSourceNodeList = xmlNode.SelectNodes("informationSource");
            
            if (informationSourceNodeList != null)
            {
                this.informationSource_ = new List<InformationSource>();
                foreach (XmlNode item in informationSourceNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            informationSourceIDRef_ = item.Attributes["id"].Value;
                            informationSource_.Add(new InformationSource(item));
                            IDManager.SetID(informationSourceIDRef_, informationSource_[informationSource_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            informationSourceIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        informationSource_.Add(new InformationSource(item));
                        }
                    }
                    else
                    {
                        informationSource_.Add(new InformationSource(item));
                    }
                }
            }
            
        
            XmlNode observationStartDateNode = xmlNode.SelectSingleNode("observationStartDate");
            
            if (observationStartDateNode != null)
            {
                if (observationStartDateNode.Attributes["href"] != null || observationStartDateNode.Attributes["id"] != null) 
                {
                    if (observationStartDateNode.Attributes["id"] != null) 
                    {
                        observationStartDateIDRef_ = observationStartDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(observationStartDateNode);
                        IDManager.SetID(observationStartDateIDRef_, ob);
                    }
                    else if (observationStartDateNode.Attributes["href"] != null)
                    {
                        observationStartDateIDRef_ = observationStartDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        observationStartDate_ = new XsdTypeDate(observationStartDateNode);
                    }
                }
                else
                {
                    observationStartDate_ = new XsdTypeDate(observationStartDateNode);
                }
            }
            
        
            XmlNode observationEndDateNode = xmlNode.SelectSingleNode("observationEndDate");
            
            if (observationEndDateNode != null)
            {
                if (observationEndDateNode.Attributes["href"] != null || observationEndDateNode.Attributes["id"] != null) 
                {
                    if (observationEndDateNode.Attributes["id"] != null) 
                    {
                        observationEndDateIDRef_ = observationEndDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(observationEndDateNode);
                        IDManager.SetID(observationEndDateIDRef_, ob);
                    }
                    else if (observationEndDateNode.Attributes["href"] != null)
                    {
                        observationEndDateIDRef_ = observationEndDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        observationEndDate_ = new XsdTypeDate(observationEndDateNode);
                    }
                }
                else
                {
                    observationEndDate_ = new XsdTypeDate(observationEndDateNode);
                }
            }
            
        
        }
        
    
        #region TouchCondition_
        private TouchConditionEnum touchCondition_;
        public TouchConditionEnum TouchCondition_
        {
            get
            {
                if (this.touchCondition_ != null)
                {
                    return this.touchCondition_; 
                }
                else if (this.touchConditionIDRef_ != null)
                {
                    touchCondition_ = IDManager.getID(touchConditionIDRef_) as TouchConditionEnum;
                    return this.touchCondition_; 
                }
                else
                {
                      return this.touchCondition_; 
                }
            }
            set
            {
                if (this.touchCondition_ != value)
                {
                    this.touchCondition_ = value;
                }
            }
        }
        #endregion
        
        public string touchConditionIDRef_ { get; set; }
        #region QuotedCurrencyPair_
        private QuotedCurrencyPair quotedCurrencyPair_;
        public QuotedCurrencyPair QuotedCurrencyPair_
        {
            get
            {
                if (this.quotedCurrencyPair_ != null)
                {
                    return this.quotedCurrencyPair_; 
                }
                else if (this.quotedCurrencyPairIDRef_ != null)
                {
                    quotedCurrencyPair_ = IDManager.getID(quotedCurrencyPairIDRef_) as QuotedCurrencyPair;
                    return this.quotedCurrencyPair_; 
                }
                else
                {
                      return this.quotedCurrencyPair_; 
                }
            }
            set
            {
                if (this.quotedCurrencyPair_ != value)
                {
                    this.quotedCurrencyPair_ = value;
                }
            }
        }
        #endregion
        
        public string quotedCurrencyPairIDRef_ { get; set; }
        #region TriggerRate_
        private PositiveDecimal triggerRate_;
        public PositiveDecimal TriggerRate_
        {
            get
            {
                if (this.triggerRate_ != null)
                {
                    return this.triggerRate_; 
                }
                else if (this.triggerRateIDRef_ != null)
                {
                    triggerRate_ = IDManager.getID(triggerRateIDRef_) as PositiveDecimal;
                    return this.triggerRate_; 
                }
                else
                {
                      return this.triggerRate_; 
                }
            }
            set
            {
                if (this.triggerRate_ != value)
                {
                    this.triggerRate_ = value;
                }
            }
        }
        #endregion
        
        public string triggerRateIDRef_ { get; set; }
        #region SpotRate_
        private PositiveDecimal spotRate_;
        public PositiveDecimal SpotRate_
        {
            get
            {
                if (this.spotRate_ != null)
                {
                    return this.spotRate_; 
                }
                else if (this.spotRateIDRef_ != null)
                {
                    spotRate_ = IDManager.getID(spotRateIDRef_) as PositiveDecimal;
                    return this.spotRate_; 
                }
                else
                {
                      return this.spotRate_; 
                }
            }
            set
            {
                if (this.spotRate_ != value)
                {
                    this.spotRate_ = value;
                }
            }
        }
        #endregion
        
        public string spotRateIDRef_ { get; set; }
        #region InformationSource_
        private List<InformationSource> informationSource_;
        public List<InformationSource> InformationSource_
        {
            get
            {
                if (this.informationSource_ != null)
                {
                    return this.informationSource_; 
                }
                else if (this.informationSourceIDRef_ != null)
                {
                    return this.informationSource_; 
                }
                else
                {
                      return this.informationSource_; 
                }
            }
            set
            {
                if (this.informationSource_ != value)
                {
                    this.informationSource_ = value;
                }
            }
        }
        #endregion
        
        public string informationSourceIDRef_ { get; set; }
        #region ObservationStartDate_
        private XsdTypeDate observationStartDate_;
        public XsdTypeDate ObservationStartDate_
        {
            get
            {
                if (this.observationStartDate_ != null)
                {
                    return this.observationStartDate_; 
                }
                else if (this.observationStartDateIDRef_ != null)
                {
                    observationStartDate_ = IDManager.getID(observationStartDateIDRef_) as XsdTypeDate;
                    return this.observationStartDate_; 
                }
                else
                {
                      return this.observationStartDate_; 
                }
            }
            set
            {
                if (this.observationStartDate_ != value)
                {
                    this.observationStartDate_ = value;
                }
            }
        }
        #endregion
        
        public string observationStartDateIDRef_ { get; set; }
        #region ObservationEndDate_
        private XsdTypeDate observationEndDate_;
        public XsdTypeDate ObservationEndDate_
        {
            get
            {
                if (this.observationEndDate_ != null)
                {
                    return this.observationEndDate_; 
                }
                else if (this.observationEndDateIDRef_ != null)
                {
                    observationEndDate_ = IDManager.getID(observationEndDateIDRef_) as XsdTypeDate;
                    return this.observationEndDate_; 
                }
                else
                {
                      return this.observationEndDate_; 
                }
            }
            set
            {
                if (this.observationEndDate_ != value)
                {
                    this.observationEndDate_ = value;
                }
            }
        }
        #endregion
        
        public string observationEndDateIDRef_ { get; set; }
        
    
        
    
    }
    
}

