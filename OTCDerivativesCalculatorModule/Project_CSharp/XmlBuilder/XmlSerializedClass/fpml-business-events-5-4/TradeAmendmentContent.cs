using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class TradeAmendmentContent : AbstractEvent
    {
        public TradeAmendmentContent(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode tradeNode = xmlNode.SelectSingleNode("trade");
            
            if (tradeNode != null)
            {
                if (tradeNode.Attributes["href"] != null || tradeNode.Attributes["id"] != null) 
                {
                    if (tradeNode.Attributes["id"] != null) 
                    {
                        tradeIDRef_ = tradeNode.Attributes["id"].Value;
                        Trade ob = new Trade(tradeNode);
                        IDManager.SetID(tradeIDRef_, ob);
                    }
                    else if (tradeNode.Attributes["href"] != null)
                    {
                        tradeIDRef_ = tradeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        trade_ = new Trade(tradeNode);
                    }
                }
                else
                {
                    trade_ = new Trade(tradeNode);
                }
            }
            
        
            XmlNode agreementDateNode = xmlNode.SelectSingleNode("agreementDate");
            
            if (agreementDateNode != null)
            {
                if (agreementDateNode.Attributes["href"] != null || agreementDateNode.Attributes["id"] != null) 
                {
                    if (agreementDateNode.Attributes["id"] != null) 
                    {
                        agreementDateIDRef_ = agreementDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(agreementDateNode);
                        IDManager.SetID(agreementDateIDRef_, ob);
                    }
                    else if (agreementDateNode.Attributes["href"] != null)
                    {
                        agreementDateIDRef_ = agreementDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        agreementDate_ = new XsdTypeDate(agreementDateNode);
                    }
                }
                else
                {
                    agreementDate_ = new XsdTypeDate(agreementDateNode);
                }
            }
            
        
            XmlNode executionDateTimeNode = xmlNode.SelectSingleNode("executionDateTime");
            
            if (executionDateTimeNode != null)
            {
                if (executionDateTimeNode.Attributes["href"] != null || executionDateTimeNode.Attributes["id"] != null) 
                {
                    if (executionDateTimeNode.Attributes["id"] != null) 
                    {
                        executionDateTimeIDRef_ = executionDateTimeNode.Attributes["id"].Value;
                        ExecutionDateTime ob = new ExecutionDateTime(executionDateTimeNode);
                        IDManager.SetID(executionDateTimeIDRef_, ob);
                    }
                    else if (executionDateTimeNode.Attributes["href"] != null)
                    {
                        executionDateTimeIDRef_ = executionDateTimeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        executionDateTime_ = new ExecutionDateTime(executionDateTimeNode);
                    }
                }
                else
                {
                    executionDateTime_ = new ExecutionDateTime(executionDateTimeNode);
                }
            }
            
        
            XmlNode effectiveDateNode = xmlNode.SelectSingleNode("effectiveDate");
            
            if (effectiveDateNode != null)
            {
                if (effectiveDateNode.Attributes["href"] != null || effectiveDateNode.Attributes["id"] != null) 
                {
                    if (effectiveDateNode.Attributes["id"] != null) 
                    {
                        effectiveDateIDRef_ = effectiveDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(effectiveDateNode);
                        IDManager.SetID(effectiveDateIDRef_, ob);
                    }
                    else if (effectiveDateNode.Attributes["href"] != null)
                    {
                        effectiveDateIDRef_ = effectiveDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        effectiveDate_ = new XsdTypeDate(effectiveDateNode);
                    }
                }
                else
                {
                    effectiveDate_ = new XsdTypeDate(effectiveDateNode);
                }
            }
            
        
            XmlNodeList paymentNodeList = xmlNode.SelectNodes("payment");
            
            if (paymentNodeList != null)
            {
                this.payment_ = new List<Payment>();
                foreach (XmlNode item in paymentNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            paymentIDRef_ = item.Attributes["id"].Value;
                            payment_.Add(new Payment(item));
                            IDManager.SetID(paymentIDRef_, payment_[payment_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            paymentIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        payment_.Add(new Payment(item));
                        }
                    }
                    else
                    {
                        payment_.Add(new Payment(item));
                    }
                }
            }
            
        
        }
        
    
        #region Trade_
        private Trade trade_;
        public Trade Trade_
        {
            get
            {
                if (this.trade_ != null)
                {
                    return this.trade_; 
                }
                else if (this.tradeIDRef_ != null)
                {
                    trade_ = IDManager.getID(tradeIDRef_) as Trade;
                    return this.trade_; 
                }
                else
                {
                      return this.trade_; 
                }
            }
            set
            {
                if (this.trade_ != value)
                {
                    this.trade_ = value;
                }
            }
        }
        #endregion
        
        public string tradeIDRef_ { get; set; }
        #region AgreementDate_
        private XsdTypeDate agreementDate_;
        public XsdTypeDate AgreementDate_
        {
            get
            {
                if (this.agreementDate_ != null)
                {
                    return this.agreementDate_; 
                }
                else if (this.agreementDateIDRef_ != null)
                {
                    agreementDate_ = IDManager.getID(agreementDateIDRef_) as XsdTypeDate;
                    return this.agreementDate_; 
                }
                else
                {
                      return this.agreementDate_; 
                }
            }
            set
            {
                if (this.agreementDate_ != value)
                {
                    this.agreementDate_ = value;
                }
            }
        }
        #endregion
        
        public string agreementDateIDRef_ { get; set; }
        #region ExecutionDateTime_
        private ExecutionDateTime executionDateTime_;
        public ExecutionDateTime ExecutionDateTime_
        {
            get
            {
                if (this.executionDateTime_ != null)
                {
                    return this.executionDateTime_; 
                }
                else if (this.executionDateTimeIDRef_ != null)
                {
                    executionDateTime_ = IDManager.getID(executionDateTimeIDRef_) as ExecutionDateTime;
                    return this.executionDateTime_; 
                }
                else
                {
                      return this.executionDateTime_; 
                }
            }
            set
            {
                if (this.executionDateTime_ != value)
                {
                    this.executionDateTime_ = value;
                }
            }
        }
        #endregion
        
        public string executionDateTimeIDRef_ { get; set; }
        #region EffectiveDate_
        private XsdTypeDate effectiveDate_;
        public XsdTypeDate EffectiveDate_
        {
            get
            {
                if (this.effectiveDate_ != null)
                {
                    return this.effectiveDate_; 
                }
                else if (this.effectiveDateIDRef_ != null)
                {
                    effectiveDate_ = IDManager.getID(effectiveDateIDRef_) as XsdTypeDate;
                    return this.effectiveDate_; 
                }
                else
                {
                      return this.effectiveDate_; 
                }
            }
            set
            {
                if (this.effectiveDate_ != value)
                {
                    this.effectiveDate_ = value;
                }
            }
        }
        #endregion
        
        public string effectiveDateIDRef_ { get; set; }
        #region Payment_
        private List<Payment> payment_;
        public List<Payment> Payment_
        {
            get
            {
                if (this.payment_ != null)
                {
                    return this.payment_; 
                }
                else if (this.paymentIDRef_ != null)
                {
                    return this.payment_; 
                }
                else
                {
                      return this.payment_; 
                }
            }
            set
            {
                if (this.payment_ != value)
                {
                    this.payment_ = value;
                }
            }
        }
        #endregion
        
        public string paymentIDRef_ { get; set; }
        
    
        
    
    }
    
}

