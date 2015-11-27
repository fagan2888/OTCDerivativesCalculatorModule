using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class MandatoryEarlyTerminationAdjustedDates : ISerialized
    {
        public MandatoryEarlyTerminationAdjustedDates(XmlNode xmlNode)
        {
            XmlNode adjustedEarlyTerminationDateNode = xmlNode.SelectSingleNode("adjustedEarlyTerminationDate");
            
            if (adjustedEarlyTerminationDateNode != null)
            {
                if (adjustedEarlyTerminationDateNode.Attributes["href"] != null || adjustedEarlyTerminationDateNode.Attributes["id"] != null) 
                {
                    if (adjustedEarlyTerminationDateNode.Attributes["id"] != null) 
                    {
                        adjustedEarlyTerminationDateIDRef_ = adjustedEarlyTerminationDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(adjustedEarlyTerminationDateNode);
                        IDManager.SetID(adjustedEarlyTerminationDateIDRef_, ob);
                    }
                    else if (adjustedEarlyTerminationDateNode.Attributes["href"] != null)
                    {
                        adjustedEarlyTerminationDateIDRef_ = adjustedEarlyTerminationDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        adjustedEarlyTerminationDate_ = new XsdTypeDate(adjustedEarlyTerminationDateNode);
                    }
                }
                else
                {
                    adjustedEarlyTerminationDate_ = new XsdTypeDate(adjustedEarlyTerminationDateNode);
                }
            }
            
        
            XmlNode adjustedCashSettlementValuationDateNode = xmlNode.SelectSingleNode("adjustedCashSettlementValuationDate");
            
            if (adjustedCashSettlementValuationDateNode != null)
            {
                if (adjustedCashSettlementValuationDateNode.Attributes["href"] != null || adjustedCashSettlementValuationDateNode.Attributes["id"] != null) 
                {
                    if (adjustedCashSettlementValuationDateNode.Attributes["id"] != null) 
                    {
                        adjustedCashSettlementValuationDateIDRef_ = adjustedCashSettlementValuationDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(adjustedCashSettlementValuationDateNode);
                        IDManager.SetID(adjustedCashSettlementValuationDateIDRef_, ob);
                    }
                    else if (adjustedCashSettlementValuationDateNode.Attributes["href"] != null)
                    {
                        adjustedCashSettlementValuationDateIDRef_ = adjustedCashSettlementValuationDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        adjustedCashSettlementValuationDate_ = new XsdTypeDate(adjustedCashSettlementValuationDateNode);
                    }
                }
                else
                {
                    adjustedCashSettlementValuationDate_ = new XsdTypeDate(adjustedCashSettlementValuationDateNode);
                }
            }
            
        
            XmlNode adjustedCashSettlementPaymentDateNode = xmlNode.SelectSingleNode("adjustedCashSettlementPaymentDate");
            
            if (adjustedCashSettlementPaymentDateNode != null)
            {
                if (adjustedCashSettlementPaymentDateNode.Attributes["href"] != null || adjustedCashSettlementPaymentDateNode.Attributes["id"] != null) 
                {
                    if (adjustedCashSettlementPaymentDateNode.Attributes["id"] != null) 
                    {
                        adjustedCashSettlementPaymentDateIDRef_ = adjustedCashSettlementPaymentDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(adjustedCashSettlementPaymentDateNode);
                        IDManager.SetID(adjustedCashSettlementPaymentDateIDRef_, ob);
                    }
                    else if (adjustedCashSettlementPaymentDateNode.Attributes["href"] != null)
                    {
                        adjustedCashSettlementPaymentDateIDRef_ = adjustedCashSettlementPaymentDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        adjustedCashSettlementPaymentDate_ = new XsdTypeDate(adjustedCashSettlementPaymentDateNode);
                    }
                }
                else
                {
                    adjustedCashSettlementPaymentDate_ = new XsdTypeDate(adjustedCashSettlementPaymentDateNode);
                }
            }
            
        
        }
        
    
        #region AdjustedEarlyTerminationDate_
        private XsdTypeDate adjustedEarlyTerminationDate_;
        public XsdTypeDate AdjustedEarlyTerminationDate_
        {
            get
            {
                if (this.adjustedEarlyTerminationDate_ != null)
                {
                    return this.adjustedEarlyTerminationDate_; 
                }
                else if (this.adjustedEarlyTerminationDateIDRef_ != null)
                {
                    adjustedEarlyTerminationDate_ = IDManager.getID(adjustedEarlyTerminationDateIDRef_) as XsdTypeDate;
                    return this.adjustedEarlyTerminationDate_; 
                }
                else
                {
                      return this.adjustedEarlyTerminationDate_; 
                }
            }
            set
            {
                if (this.adjustedEarlyTerminationDate_ != value)
                {
                    this.adjustedEarlyTerminationDate_ = value;
                }
            }
        }
        #endregion
        
        public string adjustedEarlyTerminationDateIDRef_ { get; set; }
        #region AdjustedCashSettlementValuationDate_
        private XsdTypeDate adjustedCashSettlementValuationDate_;
        public XsdTypeDate AdjustedCashSettlementValuationDate_
        {
            get
            {
                if (this.adjustedCashSettlementValuationDate_ != null)
                {
                    return this.adjustedCashSettlementValuationDate_; 
                }
                else if (this.adjustedCashSettlementValuationDateIDRef_ != null)
                {
                    adjustedCashSettlementValuationDate_ = IDManager.getID(adjustedCashSettlementValuationDateIDRef_) as XsdTypeDate;
                    return this.adjustedCashSettlementValuationDate_; 
                }
                else
                {
                      return this.adjustedCashSettlementValuationDate_; 
                }
            }
            set
            {
                if (this.adjustedCashSettlementValuationDate_ != value)
                {
                    this.adjustedCashSettlementValuationDate_ = value;
                }
            }
        }
        #endregion
        
        public string adjustedCashSettlementValuationDateIDRef_ { get; set; }
        #region AdjustedCashSettlementPaymentDate_
        private XsdTypeDate adjustedCashSettlementPaymentDate_;
        public XsdTypeDate AdjustedCashSettlementPaymentDate_
        {
            get
            {
                if (this.adjustedCashSettlementPaymentDate_ != null)
                {
                    return this.adjustedCashSettlementPaymentDate_; 
                }
                else if (this.adjustedCashSettlementPaymentDateIDRef_ != null)
                {
                    adjustedCashSettlementPaymentDate_ = IDManager.getID(adjustedCashSettlementPaymentDateIDRef_) as XsdTypeDate;
                    return this.adjustedCashSettlementPaymentDate_; 
                }
                else
                {
                      return this.adjustedCashSettlementPaymentDate_; 
                }
            }
            set
            {
                if (this.adjustedCashSettlementPaymentDate_ != value)
                {
                    this.adjustedCashSettlementPaymentDate_ = value;
                }
            }
        }
        #endregion
        
        public string adjustedCashSettlementPaymentDateIDRef_ { get; set; }
        
    
        
    
    }
    
}

