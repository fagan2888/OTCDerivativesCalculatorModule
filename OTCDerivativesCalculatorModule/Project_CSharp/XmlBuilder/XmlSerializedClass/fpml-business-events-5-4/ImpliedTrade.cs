using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ImpliedTrade : ISerialized
    {
        public ImpliedTrade(XmlNode xmlNode)
        {
            XmlNode originatingEventNode = xmlNode.SelectSingleNode("originatingEvent");
            
            if (originatingEventNode != null)
            {
                if (originatingEventNode.Attributes["href"] != null || originatingEventNode.Attributes["id"] != null) 
                {
                    if (originatingEventNode.Attributes["id"] != null) 
                    {
                        originatingEventIDRef_ = originatingEventNode.Attributes["id"].Value;
                        OriginatingEvent ob = new OriginatingEvent(originatingEventNode);
                        IDManager.SetID(originatingEventIDRef_, ob);
                    }
                    else if (originatingEventNode.Attributes["href"] != null)
                    {
                        originatingEventIDRef_ = originatingEventNode.Attributes["href"].Value;
                    }
                    else
                    {
                        originatingEvent_ = new OriginatingEvent(originatingEventNode);
                    }
                }
                else
                {
                    originatingEvent_ = new OriginatingEvent(originatingEventNode);
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
            
        
            XmlNode paymentNode = xmlNode.SelectSingleNode("payment");
            
            if (paymentNode != null)
            {
                if (paymentNode.Attributes["href"] != null || paymentNode.Attributes["id"] != null) 
                {
                    if (paymentNode.Attributes["id"] != null) 
                    {
                        paymentIDRef_ = paymentNode.Attributes["id"].Value;
                        NonNegativePayment ob = new NonNegativePayment(paymentNode);
                        IDManager.SetID(paymentIDRef_, ob);
                    }
                    else if (paymentNode.Attributes["href"] != null)
                    {
                        paymentIDRef_ = paymentNode.Attributes["href"].Value;
                    }
                    else
                    {
                        payment_ = new NonNegativePayment(paymentNode);
                    }
                }
                else
                {
                    payment_ = new NonNegativePayment(paymentNode);
                }
            }
            
        
        }
        
    
        #region OriginatingEvent_
        private OriginatingEvent originatingEvent_;
        public OriginatingEvent OriginatingEvent_
        {
            get
            {
                if (this.originatingEvent_ != null)
                {
                    return this.originatingEvent_; 
                }
                else if (this.originatingEventIDRef_ != null)
                {
                    originatingEvent_ = IDManager.getID(originatingEventIDRef_) as OriginatingEvent;
                    return this.originatingEvent_; 
                }
                else
                {
                      return this.originatingEvent_; 
                }
            }
            set
            {
                if (this.originatingEvent_ != value)
                {
                    this.originatingEvent_ = value;
                }
            }
        }
        #endregion
        
        public string originatingEventIDRef_ { get; set; }
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
        #region Payment_
        private NonNegativePayment payment_;
        public NonNegativePayment Payment_
        {
            get
            {
                if (this.payment_ != null)
                {
                    return this.payment_; 
                }
                else if (this.paymentIDRef_ != null)
                {
                    payment_ = IDManager.getID(paymentIDRef_) as NonNegativePayment;
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

