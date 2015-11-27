using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class TradeChangeContent : ISerialized
    {
        public TradeChangeContent(XmlNode xmlNode)
        {
            XmlNode oldTradeIdentifierNode = xmlNode.SelectSingleNode("oldTradeIdentifier");
            
            if (oldTradeIdentifierNode != null)
            {
                if (oldTradeIdentifierNode.Attributes["href"] != null || oldTradeIdentifierNode.Attributes["id"] != null) 
                {
                    if (oldTradeIdentifierNode.Attributes["id"] != null) 
                    {
                        oldTradeIdentifierIDRef_ = oldTradeIdentifierNode.Attributes["id"].Value;
                        PartyTradeIdentifier ob = new PartyTradeIdentifier(oldTradeIdentifierNode);
                        IDManager.SetID(oldTradeIdentifierIDRef_, ob);
                    }
                    else if (oldTradeIdentifierNode.Attributes["href"] != null)
                    {
                        oldTradeIdentifierIDRef_ = oldTradeIdentifierNode.Attributes["href"].Value;
                    }
                    else
                    {
                        oldTradeIdentifier_ = new PartyTradeIdentifier(oldTradeIdentifierNode);
                    }
                }
                else
                {
                    oldTradeIdentifier_ = new PartyTradeIdentifier(oldTradeIdentifierNode);
                }
            }
            
        
            XmlNode oldTradeNode = xmlNode.SelectSingleNode("oldTrade");
            
            if (oldTradeNode != null)
            {
                if (oldTradeNode.Attributes["href"] != null || oldTradeNode.Attributes["id"] != null) 
                {
                    if (oldTradeNode.Attributes["id"] != null) 
                    {
                        oldTradeIDRef_ = oldTradeNode.Attributes["id"].Value;
                        Trade ob = new Trade(oldTradeNode);
                        IDManager.SetID(oldTradeIDRef_, ob);
                    }
                    else if (oldTradeNode.Attributes["href"] != null)
                    {
                        oldTradeIDRef_ = oldTradeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        oldTrade_ = new Trade(oldTradeNode);
                    }
                }
                else
                {
                    oldTrade_ = new Trade(oldTradeNode);
                }
            }
            
        
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
            
        
            XmlNode changeEventNode = xmlNode.SelectSingleNode("changeEvent");
            
            if (changeEventNode != null)
            {
                if (changeEventNode.Attributes["href"] != null || changeEventNode.Attributes["id"] != null) 
                {
                    if (changeEventNode.Attributes["id"] != null) 
                    {
                        changeEventIDRef_ = changeEventNode.Attributes["id"].Value;
                        ChangeEvent ob = new ChangeEvent(changeEventNode);
                        IDManager.SetID(changeEventIDRef_, ob);
                    }
                    else if (changeEventNode.Attributes["href"] != null)
                    {
                        changeEventIDRef_ = changeEventNode.Attributes["href"].Value;
                    }
                    else
                    {
                        changeEvent_ = new ChangeEvent(changeEventNode);
                    }
                }
                else
                {
                    changeEvent_ = new ChangeEvent(changeEventNode);
                }
            }
            
        
            XmlNode indexChangeNode = xmlNode.SelectSingleNode("indexChange");
            
            if (indexChangeNode != null)
            {
                if (indexChangeNode.Attributes["href"] != null || indexChangeNode.Attributes["id"] != null) 
                {
                    if (indexChangeNode.Attributes["id"] != null) 
                    {
                        indexChangeIDRef_ = indexChangeNode.Attributes["id"].Value;
                        IndexChange ob = new IndexChange(indexChangeNode);
                        IDManager.SetID(indexChangeIDRef_, ob);
                    }
                    else if (indexChangeNode.Attributes["href"] != null)
                    {
                        indexChangeIDRef_ = indexChangeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        indexChange_ = new IndexChange(indexChangeNode);
                    }
                }
                else
                {
                    indexChange_ = new IndexChange(indexChangeNode);
                }
            }
            
        
            XmlNode paymentNode = xmlNode.SelectSingleNode("payment");
            
            if (paymentNode != null)
            {
                if (paymentNode.Attributes["href"] != null || paymentNode.Attributes["id"] != null) 
                {
                    if (paymentNode.Attributes["id"] != null) 
                    {
                        paymentIDRef_ = paymentNode.Attributes["id"].Value;
                        Payment ob = new Payment(paymentNode);
                        IDManager.SetID(paymentIDRef_, ob);
                    }
                    else if (paymentNode.Attributes["href"] != null)
                    {
                        paymentIDRef_ = paymentNode.Attributes["href"].Value;
                    }
                    else
                    {
                        payment_ = new Payment(paymentNode);
                    }
                }
                else
                {
                    payment_ = new Payment(paymentNode);
                }
            }
            
        
        }
        
    
        #region OldTradeIdentifier_
        private PartyTradeIdentifier oldTradeIdentifier_;
        public PartyTradeIdentifier OldTradeIdentifier_
        {
            get
            {
                if (this.oldTradeIdentifier_ != null)
                {
                    return this.oldTradeIdentifier_; 
                }
                else if (this.oldTradeIdentifierIDRef_ != null)
                {
                    oldTradeIdentifier_ = IDManager.getID(oldTradeIdentifierIDRef_) as PartyTradeIdentifier;
                    return this.oldTradeIdentifier_; 
                }
                else
                {
                      return this.oldTradeIdentifier_; 
                }
            }
            set
            {
                if (this.oldTradeIdentifier_ != value)
                {
                    this.oldTradeIdentifier_ = value;
                }
            }
        }
        #endregion
        
        public string oldTradeIdentifierIDRef_ { get; set; }
        #region OldTrade_
        private Trade oldTrade_;
        public Trade OldTrade_
        {
            get
            {
                if (this.oldTrade_ != null)
                {
                    return this.oldTrade_; 
                }
                else if (this.oldTradeIDRef_ != null)
                {
                    oldTrade_ = IDManager.getID(oldTradeIDRef_) as Trade;
                    return this.oldTrade_; 
                }
                else
                {
                      return this.oldTrade_; 
                }
            }
            set
            {
                if (this.oldTrade_ != value)
                {
                    this.oldTrade_ = value;
                }
            }
        }
        #endregion
        
        public string oldTradeIDRef_ { get; set; }
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
        #region ChangeEvent_
        private ChangeEvent changeEvent_;
        public ChangeEvent ChangeEvent_
        {
            get
            {
                if (this.changeEvent_ != null)
                {
                    return this.changeEvent_; 
                }
                else if (this.changeEventIDRef_ != null)
                {
                    changeEvent_ = IDManager.getID(changeEventIDRef_) as ChangeEvent;
                    return this.changeEvent_; 
                }
                else
                {
                      return this.changeEvent_; 
                }
            }
            set
            {
                if (this.changeEvent_ != value)
                {
                    this.changeEvent_ = value;
                }
            }
        }
        #endregion
        
        public string changeEventIDRef_ { get; set; }
        #region IndexChange_
        private IndexChange indexChange_;
        public IndexChange IndexChange_
        {
            get
            {
                if (this.indexChange_ != null)
                {
                    return this.indexChange_; 
                }
                else if (this.indexChangeIDRef_ != null)
                {
                    indexChange_ = IDManager.getID(indexChangeIDRef_) as IndexChange;
                    return this.indexChange_; 
                }
                else
                {
                      return this.indexChange_; 
                }
            }
            set
            {
                if (this.indexChange_ != value)
                {
                    this.indexChange_ = value;
                }
            }
        }
        #endregion
        
        public string indexChangeIDRef_ { get; set; }     // substitude
        #region Payment_
        private Payment payment_;
        public Payment Payment_
        {
            get
            {
                if (this.payment_ != null)
                {
                    return this.payment_; 
                }
                else if (this.paymentIDRef_ != null)
                {
                    payment_ = IDManager.getID(paymentIDRef_) as Payment;
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
        public string choiceStr_0;
        
    
        
    
    }
    
}

