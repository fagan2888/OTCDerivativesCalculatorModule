using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PendingPayment : PaymentBase
    {
        public PendingPayment(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode paymentDateNode = xmlNode.SelectSingleNode("paymentDate");
            
            if (paymentDateNode != null)
            {
                if (paymentDateNode.Attributes["href"] != null || paymentDateNode.Attributes["id"] != null) 
                {
                    if (paymentDateNode.Attributes["id"] != null) 
                    {
                        paymentDateIDRef_ = paymentDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(paymentDateNode);
                        IDManager.SetID(paymentDateIDRef_, ob);
                    }
                    else if (paymentDateNode.Attributes["href"] != null)
                    {
                        paymentDateIDRef_ = paymentDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        paymentDate_ = new XsdTypeDate(paymentDateNode);
                    }
                }
                else
                {
                    paymentDate_ = new XsdTypeDate(paymentDateNode);
                }
            }
            
        
            XmlNode amountNode = xmlNode.SelectSingleNode("amount");
            
            if (amountNode != null)
            {
                if (amountNode.Attributes["href"] != null || amountNode.Attributes["id"] != null) 
                {
                    if (amountNode.Attributes["id"] != null) 
                    {
                        amountIDRef_ = amountNode.Attributes["id"].Value;
                        Money ob = new Money(amountNode);
                        IDManager.SetID(amountIDRef_, ob);
                    }
                    else if (amountNode.Attributes["href"] != null)
                    {
                        amountIDRef_ = amountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        amount_ = new Money(amountNode);
                    }
                }
                else
                {
                    amount_ = new Money(amountNode);
                }
            }
            
        
            XmlNode accruedInterestNode = xmlNode.SelectSingleNode("accruedInterest");
            
            if (accruedInterestNode != null)
            {
                if (accruedInterestNode.Attributes["href"] != null || accruedInterestNode.Attributes["id"] != null) 
                {
                    if (accruedInterestNode.Attributes["id"] != null) 
                    {
                        accruedInterestIDRef_ = accruedInterestNode.Attributes["id"].Value;
                        Money ob = new Money(accruedInterestNode);
                        IDManager.SetID(accruedInterestIDRef_, ob);
                    }
                    else if (accruedInterestNode.Attributes["href"] != null)
                    {
                        accruedInterestIDRef_ = accruedInterestNode.Attributes["href"].Value;
                    }
                    else
                    {
                        accruedInterest_ = new Money(accruedInterestNode);
                    }
                }
                else
                {
                    accruedInterest_ = new Money(accruedInterestNode);
                }
            }
            
        
        }
        
    
        #region PaymentDate_
        private XsdTypeDate paymentDate_;
        public XsdTypeDate PaymentDate_
        {
            get
            {
                if (this.paymentDate_ != null)
                {
                    return this.paymentDate_; 
                }
                else if (this.paymentDateIDRef_ != null)
                {
                    paymentDate_ = IDManager.getID(paymentDateIDRef_) as XsdTypeDate;
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
        #region Amount_
        private Money amount_;
        public Money Amount_
        {
            get
            {
                if (this.amount_ != null)
                {
                    return this.amount_; 
                }
                else if (this.amountIDRef_ != null)
                {
                    amount_ = IDManager.getID(amountIDRef_) as Money;
                    return this.amount_; 
                }
                else
                {
                      return this.amount_; 
                }
            }
            set
            {
                if (this.amount_ != value)
                {
                    this.amount_ = value;
                }
            }
        }
        #endregion
        
        public string amountIDRef_ { get; set; }
        #region AccruedInterest_
        private Money accruedInterest_;
        public Money AccruedInterest_
        {
            get
            {
                if (this.accruedInterest_ != null)
                {
                    return this.accruedInterest_; 
                }
                else if (this.accruedInterestIDRef_ != null)
                {
                    accruedInterest_ = IDManager.getID(accruedInterestIDRef_) as Money;
                    return this.accruedInterest_; 
                }
                else
                {
                      return this.accruedInterest_; 
                }
            }
            set
            {
                if (this.accruedInterest_ != value)
                {
                    this.accruedInterest_ = value;
                }
            }
        }
        #endregion
        
        public string accruedInterestIDRef_ { get; set; }
        
    
        
    
    }
    
}

