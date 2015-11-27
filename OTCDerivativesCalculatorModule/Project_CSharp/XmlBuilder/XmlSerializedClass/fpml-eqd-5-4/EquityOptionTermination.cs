using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class EquityOptionTermination : ISerialized
    {
        public EquityOptionTermination(XmlNode xmlNode)
        {
            XmlNode settlementAmountPaymentDateNode = xmlNode.SelectSingleNode("settlementAmountPaymentDate");
            
            if (settlementAmountPaymentDateNode != null)
            {
                if (settlementAmountPaymentDateNode.Attributes["href"] != null || settlementAmountPaymentDateNode.Attributes["id"] != null) 
                {
                    if (settlementAmountPaymentDateNode.Attributes["id"] != null) 
                    {
                        settlementAmountPaymentDateIDRef_ = settlementAmountPaymentDateNode.Attributes["id"].Value;
                        AdjustableDate ob = new AdjustableDate(settlementAmountPaymentDateNode);
                        IDManager.SetID(settlementAmountPaymentDateIDRef_, ob);
                    }
                    else if (settlementAmountPaymentDateNode.Attributes["href"] != null)
                    {
                        settlementAmountPaymentDateIDRef_ = settlementAmountPaymentDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        settlementAmountPaymentDate_ = new AdjustableDate(settlementAmountPaymentDateNode);
                    }
                }
                else
                {
                    settlementAmountPaymentDate_ = new AdjustableDate(settlementAmountPaymentDateNode);
                }
            }
            
        
            XmlNode settlementAmountNode = xmlNode.SelectSingleNode("settlementAmount");
            
            if (settlementAmountNode != null)
            {
                if (settlementAmountNode.Attributes["href"] != null || settlementAmountNode.Attributes["id"] != null) 
                {
                    if (settlementAmountNode.Attributes["id"] != null) 
                    {
                        settlementAmountIDRef_ = settlementAmountNode.Attributes["id"].Value;
                        NonNegativeMoney ob = new NonNegativeMoney(settlementAmountNode);
                        IDManager.SetID(settlementAmountIDRef_, ob);
                    }
                    else if (settlementAmountNode.Attributes["href"] != null)
                    {
                        settlementAmountIDRef_ = settlementAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        settlementAmount_ = new NonNegativeMoney(settlementAmountNode);
                    }
                }
                else
                {
                    settlementAmount_ = new NonNegativeMoney(settlementAmountNode);
                }
            }
            
        
        }
        
    
        #region SettlementAmountPaymentDate_
        private AdjustableDate settlementAmountPaymentDate_;
        public AdjustableDate SettlementAmountPaymentDate_
        {
            get
            {
                if (this.settlementAmountPaymentDate_ != null)
                {
                    return this.settlementAmountPaymentDate_; 
                }
                else if (this.settlementAmountPaymentDateIDRef_ != null)
                {
                    settlementAmountPaymentDate_ = IDManager.getID(settlementAmountPaymentDateIDRef_) as AdjustableDate;
                    return this.settlementAmountPaymentDate_; 
                }
                else
                {
                      return this.settlementAmountPaymentDate_; 
                }
            }
            set
            {
                if (this.settlementAmountPaymentDate_ != value)
                {
                    this.settlementAmountPaymentDate_ = value;
                }
            }
        }
        #endregion
        
        public string settlementAmountPaymentDateIDRef_ { get; set; }
        #region SettlementAmount_
        private NonNegativeMoney settlementAmount_;
        public NonNegativeMoney SettlementAmount_
        {
            get
            {
                if (this.settlementAmount_ != null)
                {
                    return this.settlementAmount_; 
                }
                else if (this.settlementAmountIDRef_ != null)
                {
                    settlementAmount_ = IDManager.getID(settlementAmountIDRef_) as NonNegativeMoney;
                    return this.settlementAmount_; 
                }
                else
                {
                      return this.settlementAmount_; 
                }
            }
            set
            {
                if (this.settlementAmount_ != value)
                {
                    this.settlementAmount_ = value;
                }
            }
        }
        #endregion
        
        public string settlementAmountIDRef_ { get; set; }
        
    
        
    
    }
    
}

