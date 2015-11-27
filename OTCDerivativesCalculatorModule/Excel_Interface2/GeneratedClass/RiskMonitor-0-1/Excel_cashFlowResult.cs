using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_cashFlowResult : ISerialized
    {
        public Excel_cashFlowResult() { }
        public Excel_cashFlowResult(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode seqNode = xmlNode.SelectSingleNode("seq");
            
            if (seqNode != null)
            {
                if (seqNode.Attributes["href"] != null || seqNode.Attributes["id"] != null) 
                {
                    if (seqNode.Attributes["id"] != null) 
                    {
                        seqIDRef_ = seqNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(seqNode);
                        IDManager.SetID(seqIDRef_, ob);
                    }
                    else if (seqNode.Attributes["href"] != null)
                    {
                        seqIDRef_ = seqNode.Attributes["href"].Value;
                    }
                    else
                    {
                        seq_ = new XsdTypeToken(seqNode);
                    }
                }
                else
                {
                    seq_ = new XsdTypeToken(seqNode);
                }
            }
            
        
            XmlNode eventDateNode = xmlNode.SelectSingleNode("eventDate");
            
            if (eventDateNode != null)
            {
                if (eventDateNode.Attributes["href"] != null || eventDateNode.Attributes["id"] != null) 
                {
                    if (eventDateNode.Attributes["id"] != null) 
                    {
                        eventDateIDRef_ = eventDateNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(eventDateNode);
                        IDManager.SetID(eventDateIDRef_, ob);
                    }
                    else if (eventDateNode.Attributes["href"] != null)
                    {
                        eventDateIDRef_ = eventDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        eventDate_ = new XsdTypeToken(eventDateNode);
                    }
                }
                else
                {
                    eventDate_ = new XsdTypeToken(eventDateNode);
                }
            }
            
        
            XmlNode payoffDateNode = xmlNode.SelectSingleNode("payoffDate");
            
            if (payoffDateNode != null)
            {
                if (payoffDateNode.Attributes["href"] != null || payoffDateNode.Attributes["id"] != null) 
                {
                    if (payoffDateNode.Attributes["id"] != null) 
                    {
                        payoffDateIDRef_ = payoffDateNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(payoffDateNode);
                        IDManager.SetID(payoffDateIDRef_, ob);
                    }
                    else if (payoffDateNode.Attributes["href"] != null)
                    {
                        payoffDateIDRef_ = payoffDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        payoffDate_ = new XsdTypeToken(payoffDateNode);
                    }
                }
                else
                {
                    payoffDate_ = new XsdTypeToken(payoffDateNode);
                }
            }
            
        
            XmlNode typeNode = xmlNode.SelectSingleNode("type");
            
            if (typeNode != null)
            {
                if (typeNode.Attributes["href"] != null || typeNode.Attributes["id"] != null) 
                {
                    if (typeNode.Attributes["id"] != null) 
                    {
                        typeIDRef_ = typeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(typeNode);
                        IDManager.SetID(typeIDRef_, ob);
                    }
                    else if (typeNode.Attributes["href"] != null)
                    {
                        typeIDRef_ = typeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        type_ = new XsdTypeToken(typeNode);
                    }
                }
                else
                {
                    type_ = new XsdTypeToken(typeNode);
                }
            }
            
        
            XmlNode currencyNode = xmlNode.SelectSingleNode("currency");
            
            if (currencyNode != null)
            {
                if (currencyNode.Attributes["href"] != null || currencyNode.Attributes["id"] != null) 
                {
                    if (currencyNode.Attributes["id"] != null) 
                    {
                        currencyIDRef_ = currencyNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(currencyNode);
                        IDManager.SetID(currencyIDRef_, ob);
                    }
                    else if (currencyNode.Attributes["href"] != null)
                    {
                        currencyIDRef_ = currencyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        currency_ = new XsdTypeToken(currencyNode);
                    }
                }
                else
                {
                    currency_ = new XsdTypeToken(currencyNode);
                }
            }
            
        
            XmlNode cashFlowNode = xmlNode.SelectSingleNode("cashFlow");
            
            if (cashFlowNode != null)
            {
                if (cashFlowNode.Attributes["href"] != null || cashFlowNode.Attributes["id"] != null) 
                {
                    if (cashFlowNode.Attributes["id"] != null) 
                    {
                        cashFlowIDRef_ = cashFlowNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(cashFlowNode);
                        IDManager.SetID(cashFlowIDRef_, ob);
                    }
                    else if (cashFlowNode.Attributes["href"] != null)
                    {
                        cashFlowIDRef_ = cashFlowNode.Attributes["href"].Value;
                    }
                    else
                    {
                        cashFlow_ = new XsdTypeToken(cashFlowNode);
                    }
                }
                else
                {
                    cashFlow_ = new XsdTypeToken(cashFlowNode);
                }
            }
            
        
            XmlNode yieldNode = xmlNode.SelectSingleNode("yield");
            
            if (yieldNode != null)
            {
                if (yieldNode.Attributes["href"] != null || yieldNode.Attributes["id"] != null) 
                {
                    if (yieldNode.Attributes["id"] != null) 
                    {
                        yieldIDRef_ = yieldNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(yieldNode);
                        IDManager.SetID(yieldIDRef_, ob);
                    }
                    else if (yieldNode.Attributes["href"] != null)
                    {
                        yieldIDRef_ = yieldNode.Attributes["href"].Value;
                    }
                    else
                    {
                        yield_ = new XsdTypeToken(yieldNode);
                    }
                }
                else
                {
                    yield_ = new XsdTypeToken(yieldNode);
                }
            }
            
        
            XmlNode discountNode = xmlNode.SelectSingleNode("discount");
            
            if (discountNode != null)
            {
                if (discountNode.Attributes["href"] != null || discountNode.Attributes["id"] != null) 
                {
                    if (discountNode.Attributes["id"] != null) 
                    {
                        discountIDRef_ = discountNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(discountNode);
                        IDManager.SetID(discountIDRef_, ob);
                    }
                    else if (discountNode.Attributes["href"] != null)
                    {
                        discountIDRef_ = discountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        discount_ = new XsdTypeToken(discountNode);
                    }
                }
                else
                {
                    discount_ = new XsdTypeToken(discountNode);
                }
            }
            
        
            XmlNode exProbNode = xmlNode.SelectSingleNode("exProb");
            
            if (exProbNode != null)
            {
                if (exProbNode.Attributes["href"] != null || exProbNode.Attributes["id"] != null) 
                {
                    if (exProbNode.Attributes["id"] != null) 
                    {
                        exProbIDRef_ = exProbNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(exProbNode);
                        IDManager.SetID(exProbIDRef_, ob);
                    }
                    else if (exProbNode.Attributes["href"] != null)
                    {
                        exProbIDRef_ = exProbNode.Attributes["href"].Value;
                    }
                    else
                    {
                        exProb_ = new XsdTypeToken(exProbNode);
                    }
                }
                else
                {
                    exProb_ = new XsdTypeToken(exProbNode);
                }
            }
            
        
            XmlNode notionalPaymentNode = xmlNode.SelectSingleNode("notionalPayment");
            
            if (notionalPaymentNode != null)
            {
                if (notionalPaymentNode.Attributes["href"] != null || notionalPaymentNode.Attributes["id"] != null) 
                {
                    if (notionalPaymentNode.Attributes["id"] != null) 
                    {
                        notionalPaymentIDRef_ = notionalPaymentNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(notionalPaymentNode);
                        IDManager.SetID(notionalPaymentIDRef_, ob);
                    }
                    else if (notionalPaymentNode.Attributes["href"] != null)
                    {
                        notionalPaymentIDRef_ = notionalPaymentNode.Attributes["href"].Value;
                    }
                    else
                    {
                        notionalPayment_ = new XsdTypeToken(notionalPaymentNode);
                    }
                }
                else
                {
                    notionalPayment_ = new XsdTypeToken(notionalPaymentNode);
                }
            }
            
        
            XmlNode fxRate_forwardNode = xmlNode.SelectSingleNode("fxRate_forward");
            
            if (fxRate_forwardNode != null)
            {
                if (fxRate_forwardNode.Attributes["href"] != null || fxRate_forwardNode.Attributes["id"] != null) 
                {
                    if (fxRate_forwardNode.Attributes["id"] != null) 
                    {
                        fxRate_forwardIDRef_ = fxRate_forwardNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(fxRate_forwardNode);
                        IDManager.SetID(fxRate_forwardIDRef_, ob);
                    }
                    else if (fxRate_forwardNode.Attributes["href"] != null)
                    {
                        fxRate_forwardIDRef_ = fxRate_forwardNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fxRate_forward_ = new XsdTypeToken(fxRate_forwardNode);
                    }
                }
                else
                {
                    fxRate_forward_ = new XsdTypeToken(fxRate_forwardNode);
                }
            }
            
        
            XmlNode valueNode = xmlNode.SelectSingleNode("value");
            
            if (valueNode != null)
            {
                if (valueNode.Attributes["href"] != null || valueNode.Attributes["id"] != null) 
                {
                    if (valueNode.Attributes["id"] != null) 
                    {
                        valueIDRef_ = valueNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(valueNode);
                        IDManager.SetID(valueIDRef_, ob);
                    }
                    else if (valueNode.Attributes["href"] != null)
                    {
                        valueIDRef_ = valueNode.Attributes["href"].Value;
                    }
                    else
                    {
                        value_ = new XsdTypeToken(valueNode);
                    }
                }
                else
                {
                    value_ = new XsdTypeToken(valueNode);
                }
            }
            
        
        }
        
    
        #region Seq_
        private XsdTypeToken seq_;
        public XsdTypeToken Seq_
        {
            get
            {
                if (this.seq_ != null)
                {
                    return this.seq_; 
                }
                else if (this.seqIDRef_ != null)
                {
                    seq_ = IDManager.getID(seqIDRef_) as XsdTypeToken;
                    return this.seq_; 
                }
                else
                {
                    throw new Exception( "seq_Node no exist!");
                }
            }
            set
            {
                if (this.seq_ != value)
                {
                    this.seq_ = value;
                }
            }
        }
        #endregion
        
        public string seqIDRef_ { get; set; }
        #region EventDate_
        private XsdTypeToken eventDate_;
        public XsdTypeToken EventDate_
        {
            get
            {
                if (this.eventDate_ != null)
                {
                    return this.eventDate_; 
                }
                else if (this.eventDateIDRef_ != null)
                {
                    eventDate_ = IDManager.getID(eventDateIDRef_) as XsdTypeToken;
                    return this.eventDate_; 
                }
                else
                {
                    throw new Exception( "eventDate_Node no exist!");
                }
            }
            set
            {
                if (this.eventDate_ != value)
                {
                    this.eventDate_ = value;
                }
            }
        }
        #endregion
        
        public string eventDateIDRef_ { get; set; }
        #region PayoffDate_
        private XsdTypeToken payoffDate_;
        public XsdTypeToken PayoffDate_
        {
            get
            {
                if (this.payoffDate_ != null)
                {
                    return this.payoffDate_; 
                }
                else if (this.payoffDateIDRef_ != null)
                {
                    payoffDate_ = IDManager.getID(payoffDateIDRef_) as XsdTypeToken;
                    return this.payoffDate_; 
                }
                else
                {
                    throw new Exception( "payoffDate_Node no exist!");
                }
            }
            set
            {
                if (this.payoffDate_ != value)
                {
                    this.payoffDate_ = value;
                }
            }
        }
        #endregion
        
        public string payoffDateIDRef_ { get; set; }
        #region Type_
        private XsdTypeToken type_;
        public XsdTypeToken Type_
        {
            get
            {
                if (this.type_ != null)
                {
                    return this.type_; 
                }
                else if (this.typeIDRef_ != null)
                {
                    type_ = IDManager.getID(typeIDRef_) as XsdTypeToken;
                    return this.type_; 
                }
                else
                {
                    throw new Exception( "type_Node no exist!");
                }
            }
            set
            {
                if (this.type_ != value)
                {
                    this.type_ = value;
                }
            }
        }
        #endregion
        
        public string typeIDRef_ { get; set; }
        #region Currency_
        private XsdTypeToken currency_;
        public XsdTypeToken Currency_
        {
            get
            {
                if (this.currency_ != null)
                {
                    return this.currency_; 
                }
                else if (this.currencyIDRef_ != null)
                {
                    currency_ = IDManager.getID(currencyIDRef_) as XsdTypeToken;
                    return this.currency_; 
                }
                else
                {
                    throw new Exception( "currency_Node no exist!");
                }
            }
            set
            {
                if (this.currency_ != value)
                {
                    this.currency_ = value;
                }
            }
        }
        #endregion
        
        public string currencyIDRef_ { get; set; }
        #region CashFlow_
        private XsdTypeToken cashFlow_;
        public XsdTypeToken CashFlow_
        {
            get
            {
                if (this.cashFlow_ != null)
                {
                    return this.cashFlow_; 
                }
                else if (this.cashFlowIDRef_ != null)
                {
                    cashFlow_ = IDManager.getID(cashFlowIDRef_) as XsdTypeToken;
                    return this.cashFlow_; 
                }
                else
                {
                    throw new Exception( "cashFlow_Node no exist!");
                }
            }
            set
            {
                if (this.cashFlow_ != value)
                {
                    this.cashFlow_ = value;
                }
            }
        }
        #endregion
        
        public string cashFlowIDRef_ { get; set; }
        #region Yield_
        private XsdTypeToken yield_;
        public XsdTypeToken Yield_
        {
            get
            {
                if (this.yield_ != null)
                {
                    return this.yield_; 
                }
                else if (this.yieldIDRef_ != null)
                {
                    yield_ = IDManager.getID(yieldIDRef_) as XsdTypeToken;
                    return this.yield_; 
                }
                else
                {
                    throw new Exception( "yield_Node no exist!");
                }
            }
            set
            {
                if (this.yield_ != value)
                {
                    this.yield_ = value;
                }
            }
        }
        #endregion
        
        public string yieldIDRef_ { get; set; }
        #region Discount_
        private XsdTypeToken discount_;
        public XsdTypeToken Discount_
        {
            get
            {
                if (this.discount_ != null)
                {
                    return this.discount_; 
                }
                else if (this.discountIDRef_ != null)
                {
                    discount_ = IDManager.getID(discountIDRef_) as XsdTypeToken;
                    return this.discount_; 
                }
                else
                {
                    throw new Exception( "discount_Node no exist!");
                }
            }
            set
            {
                if (this.discount_ != value)
                {
                    this.discount_ = value;
                }
            }
        }
        #endregion
        
        public string discountIDRef_ { get; set; }
        #region ExProb_
        private XsdTypeToken exProb_;
        public XsdTypeToken ExProb_
        {
            get
            {
                if (this.exProb_ != null)
                {
                    return this.exProb_; 
                }
                else if (this.exProbIDRef_ != null)
                {
                    exProb_ = IDManager.getID(exProbIDRef_) as XsdTypeToken;
                    return this.exProb_; 
                }
                else
                {
                    throw new Exception( "exProb_Node no exist!");
                }
            }
            set
            {
                if (this.exProb_ != value)
                {
                    this.exProb_ = value;
                }
            }
        }
        #endregion
        
        public string exProbIDRef_ { get; set; }
        #region NotionalPayment_
        private XsdTypeToken notionalPayment_;
        public XsdTypeToken NotionalPayment_
        {
            get
            {
                if (this.notionalPayment_ != null)
                {
                    return this.notionalPayment_; 
                }
                else if (this.notionalPaymentIDRef_ != null)
                {
                    notionalPayment_ = IDManager.getID(notionalPaymentIDRef_) as XsdTypeToken;
                    return this.notionalPayment_; 
                }
                else
                {
                    throw new Exception( "notionalPayment_Node no exist!");
                }
            }
            set
            {
                if (this.notionalPayment_ != value)
                {
                    this.notionalPayment_ = value;
                }
            }
        }
        #endregion
        
        public string notionalPaymentIDRef_ { get; set; }
        #region FxRate_forward_
        private XsdTypeToken fxRate_forward_;
        public XsdTypeToken FxRate_forward_
        {
            get
            {
                if (this.fxRate_forward_ != null)
                {
                    return this.fxRate_forward_; 
                }
                else if (this.fxRate_forwardIDRef_ != null)
                {
                    fxRate_forward_ = IDManager.getID(fxRate_forwardIDRef_) as XsdTypeToken;
                    return this.fxRate_forward_; 
                }
                else
                {
                    throw new Exception( "fxRate_forward_Node no exist!");
                }
            }
            set
            {
                if (this.fxRate_forward_ != value)
                {
                    this.fxRate_forward_ = value;
                }
            }
        }
        #endregion
        
        public string fxRate_forwardIDRef_ { get; set; }
        #region Value_
        private XsdTypeToken value_;
        public XsdTypeToken Value_
        {
            get
            {
                if (this.value_ != null)
                {
                    return this.value_; 
                }
                else if (this.valueIDRef_ != null)
                {
                    value_ = IDManager.getID(valueIDRef_) as XsdTypeToken;
                    return this.value_; 
                }
                else
                {
                    throw new Exception( "value_Node no exist!");
                }
            }
            set
            {
                if (this.value_ != value)
                {
                    this.value_ = value;
                }
            }
        }
        #endregion
        
        public string valueIDRef_ { get; set; }
        
    
        
    
    }
    
}

