using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FxLinkedNotionalAmount : ISerialized
    {
        public FxLinkedNotionalAmount(XmlNode xmlNode)
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
            
        
            XmlNode adjustedFxSpotFixingDateNode = xmlNode.SelectSingleNode("adjustedFxSpotFixingDate");
            
            if (adjustedFxSpotFixingDateNode != null)
            {
                if (adjustedFxSpotFixingDateNode.Attributes["href"] != null || adjustedFxSpotFixingDateNode.Attributes["id"] != null) 
                {
                    if (adjustedFxSpotFixingDateNode.Attributes["id"] != null) 
                    {
                        adjustedFxSpotFixingDateIDRef_ = adjustedFxSpotFixingDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(adjustedFxSpotFixingDateNode);
                        IDManager.SetID(adjustedFxSpotFixingDateIDRef_, ob);
                    }
                    else if (adjustedFxSpotFixingDateNode.Attributes["href"] != null)
                    {
                        adjustedFxSpotFixingDateIDRef_ = adjustedFxSpotFixingDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        adjustedFxSpotFixingDate_ = new XsdTypeDate(adjustedFxSpotFixingDateNode);
                    }
                }
                else
                {
                    adjustedFxSpotFixingDate_ = new XsdTypeDate(adjustedFxSpotFixingDateNode);
                }
            }
            
        
            XmlNode observedFxSpotRateNode = xmlNode.SelectSingleNode("observedFxSpotRate");
            
            if (observedFxSpotRateNode != null)
            {
                if (observedFxSpotRateNode.Attributes["href"] != null || observedFxSpotRateNode.Attributes["id"] != null) 
                {
                    if (observedFxSpotRateNode.Attributes["id"] != null) 
                    {
                        observedFxSpotRateIDRef_ = observedFxSpotRateNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(observedFxSpotRateNode);
                        IDManager.SetID(observedFxSpotRateIDRef_, ob);
                    }
                    else if (observedFxSpotRateNode.Attributes["href"] != null)
                    {
                        observedFxSpotRateIDRef_ = observedFxSpotRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        observedFxSpotRate_ = new XsdTypeDecimal(observedFxSpotRateNode);
                    }
                }
                else
                {
                    observedFxSpotRate_ = new XsdTypeDecimal(observedFxSpotRateNode);
                }
            }
            
        
            XmlNode notionalAmountNode = xmlNode.SelectSingleNode("notionalAmount");
            
            if (notionalAmountNode != null)
            {
                if (notionalAmountNode.Attributes["href"] != null || notionalAmountNode.Attributes["id"] != null) 
                {
                    if (notionalAmountNode.Attributes["id"] != null) 
                    {
                        notionalAmountIDRef_ = notionalAmountNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(notionalAmountNode);
                        IDManager.SetID(notionalAmountIDRef_, ob);
                    }
                    else if (notionalAmountNode.Attributes["href"] != null)
                    {
                        notionalAmountIDRef_ = notionalAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        notionalAmount_ = new XsdTypeDecimal(notionalAmountNode);
                    }
                }
                else
                {
                    notionalAmount_ = new XsdTypeDecimal(notionalAmountNode);
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
        #region AdjustedFxSpotFixingDate_
        private XsdTypeDate adjustedFxSpotFixingDate_;
        public XsdTypeDate AdjustedFxSpotFixingDate_
        {
            get
            {
                if (this.adjustedFxSpotFixingDate_ != null)
                {
                    return this.adjustedFxSpotFixingDate_; 
                }
                else if (this.adjustedFxSpotFixingDateIDRef_ != null)
                {
                    adjustedFxSpotFixingDate_ = IDManager.getID(adjustedFxSpotFixingDateIDRef_) as XsdTypeDate;
                    return this.adjustedFxSpotFixingDate_; 
                }
                else
                {
                      return this.adjustedFxSpotFixingDate_; 
                }
            }
            set
            {
                if (this.adjustedFxSpotFixingDate_ != value)
                {
                    this.adjustedFxSpotFixingDate_ = value;
                }
            }
        }
        #endregion
        
        public string adjustedFxSpotFixingDateIDRef_ { get; set; }
        #region ObservedFxSpotRate_
        private XsdTypeDecimal observedFxSpotRate_;
        public XsdTypeDecimal ObservedFxSpotRate_
        {
            get
            {
                if (this.observedFxSpotRate_ != null)
                {
                    return this.observedFxSpotRate_; 
                }
                else if (this.observedFxSpotRateIDRef_ != null)
                {
                    observedFxSpotRate_ = IDManager.getID(observedFxSpotRateIDRef_) as XsdTypeDecimal;
                    return this.observedFxSpotRate_; 
                }
                else
                {
                      return this.observedFxSpotRate_; 
                }
            }
            set
            {
                if (this.observedFxSpotRate_ != value)
                {
                    this.observedFxSpotRate_ = value;
                }
            }
        }
        #endregion
        
        public string observedFxSpotRateIDRef_ { get; set; }
        #region NotionalAmount_
        private XsdTypeDecimal notionalAmount_;
        public XsdTypeDecimal NotionalAmount_
        {
            get
            {
                if (this.notionalAmount_ != null)
                {
                    return this.notionalAmount_; 
                }
                else if (this.notionalAmountIDRef_ != null)
                {
                    notionalAmount_ = IDManager.getID(notionalAmountIDRef_) as XsdTypeDecimal;
                    return this.notionalAmount_; 
                }
                else
                {
                      return this.notionalAmount_; 
                }
            }
            set
            {
                if (this.notionalAmount_ != value)
                {
                    this.notionalAmount_ = value;
                }
            }
        }
        #endregion
        
        public string notionalAmountIDRef_ { get; set; }
        
    
        
    
    }
    
}

