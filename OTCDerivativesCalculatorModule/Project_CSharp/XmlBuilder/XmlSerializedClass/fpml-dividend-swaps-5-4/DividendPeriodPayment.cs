using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class DividendPeriodPayment : DividendPeriod
    {
        public DividendPeriodPayment(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode fixedStrikeNode = xmlNode.SelectSingleNode("fixedStrike");
            
            if (fixedStrikeNode != null)
            {
                if (fixedStrikeNode.Attributes["href"] != null || fixedStrikeNode.Attributes["id"] != null) 
                {
                    if (fixedStrikeNode.Attributes["id"] != null) 
                    {
                        fixedStrikeIDRef_ = fixedStrikeNode.Attributes["id"].Value;
                        PositiveDecimal ob = new PositiveDecimal(fixedStrikeNode);
                        IDManager.SetID(fixedStrikeIDRef_, ob);
                    }
                    else if (fixedStrikeNode.Attributes["href"] != null)
                    {
                        fixedStrikeIDRef_ = fixedStrikeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fixedStrike_ = new PositiveDecimal(fixedStrikeNode);
                    }
                }
                else
                {
                    fixedStrike_ = new PositiveDecimal(fixedStrikeNode);
                }
            }
            
        
            XmlNode paymentDateNode = xmlNode.SelectSingleNode("paymentDate");
            
            if (paymentDateNode != null)
            {
                if (paymentDateNode.Attributes["href"] != null || paymentDateNode.Attributes["id"] != null) 
                {
                    if (paymentDateNode.Attributes["id"] != null) 
                    {
                        paymentDateIDRef_ = paymentDateNode.Attributes["id"].Value;
                        AdjustableOrRelativeDate ob = new AdjustableOrRelativeDate(paymentDateNode);
                        IDManager.SetID(paymentDateIDRef_, ob);
                    }
                    else if (paymentDateNode.Attributes["href"] != null)
                    {
                        paymentDateIDRef_ = paymentDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        paymentDate_ = new AdjustableOrRelativeDate(paymentDateNode);
                    }
                }
                else
                {
                    paymentDate_ = new AdjustableOrRelativeDate(paymentDateNode);
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
                        AdjustableOrRelativeDate ob = new AdjustableOrRelativeDate(valuationDateNode);
                        IDManager.SetID(valuationDateIDRef_, ob);
                    }
                    else if (valuationDateNode.Attributes["href"] != null)
                    {
                        valuationDateIDRef_ = valuationDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        valuationDate_ = new AdjustableOrRelativeDate(valuationDateNode);
                    }
                }
                else
                {
                    valuationDate_ = new AdjustableOrRelativeDate(valuationDateNode);
                }
            }
            
        
        }
        
    
        #region FixedStrike_
        private PositiveDecimal fixedStrike_;
        public PositiveDecimal FixedStrike_
        {
            get
            {
                if (this.fixedStrike_ != null)
                {
                    return this.fixedStrike_; 
                }
                else if (this.fixedStrikeIDRef_ != null)
                {
                    fixedStrike_ = IDManager.getID(fixedStrikeIDRef_) as PositiveDecimal;
                    return this.fixedStrike_; 
                }
                else
                {
                      return this.fixedStrike_; 
                }
            }
            set
            {
                if (this.fixedStrike_ != value)
                {
                    this.fixedStrike_ = value;
                }
            }
        }
        #endregion
        
        public string fixedStrikeIDRef_ { get; set; }
        #region PaymentDate_
        private AdjustableOrRelativeDate paymentDate_;
        public AdjustableOrRelativeDate PaymentDate_
        {
            get
            {
                if (this.paymentDate_ != null)
                {
                    return this.paymentDate_; 
                }
                else if (this.paymentDateIDRef_ != null)
                {
                    paymentDate_ = IDManager.getID(paymentDateIDRef_) as AdjustableOrRelativeDate;
                    return this.paymentDate_; 
                }
                else
                {
                      return this.paymentDate_; 
                }
            }
            set
            {
                if (this.paymentDate_ != value)
                {
                    this.paymentDate_ = value;
                }
            }
        }
        #endregion
        
        public string paymentDateIDRef_ { get; set; }
        #region ValuationDate_
        private AdjustableOrRelativeDate valuationDate_;
        public AdjustableOrRelativeDate ValuationDate_
        {
            get
            {
                if (this.valuationDate_ != null)
                {
                    return this.valuationDate_; 
                }
                else if (this.valuationDateIDRef_ != null)
                {
                    valuationDate_ = IDManager.getID(valuationDateIDRef_) as AdjustableOrRelativeDate;
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
        
    
        
    
    }
    
}

