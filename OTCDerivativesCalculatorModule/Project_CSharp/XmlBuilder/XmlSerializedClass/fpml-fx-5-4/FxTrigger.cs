using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FxTrigger : ISerialized
    {
        public FxTrigger(XmlNode xmlNode)
        {
            XmlNode triggerConditionNode = xmlNode.SelectSingleNode("triggerCondition");
            
            if (triggerConditionNode != null)
            {
                if (triggerConditionNode.Attributes["href"] != null || triggerConditionNode.Attributes["id"] != null) 
                {
                    if (triggerConditionNode.Attributes["id"] != null) 
                    {
                        triggerConditionIDRef_ = triggerConditionNode.Attributes["id"].Value;
                        TriggerConditionEnum ob = new TriggerConditionEnum(triggerConditionNode);
                        IDManager.SetID(triggerConditionIDRef_, ob);
                    }
                    else if (triggerConditionNode.Attributes["href"] != null)
                    {
                        triggerConditionIDRef_ = triggerConditionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        triggerCondition_ = new TriggerConditionEnum(triggerConditionNode);
                    }
                }
                else
                {
                    triggerCondition_ = new TriggerConditionEnum(triggerConditionNode);
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
            
        
        }
        
    
        #region TriggerCondition_
        private TriggerConditionEnum triggerCondition_;
        public TriggerConditionEnum TriggerCondition_
        {
            get
            {
                if (this.triggerCondition_ != null)
                {
                    return this.triggerCondition_; 
                }
                else if (this.triggerConditionIDRef_ != null)
                {
                    triggerCondition_ = IDManager.getID(triggerConditionIDRef_) as TriggerConditionEnum;
                    return this.triggerCondition_; 
                }
                else
                {
                      return this.triggerCondition_; 
                }
            }
            set
            {
                if (this.triggerCondition_ != value)
                {
                    this.triggerCondition_ = value;
                }
            }
        }
        #endregion
        
        public string triggerConditionIDRef_ { get; set; }
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
        
    
        
    
    }
    
}

