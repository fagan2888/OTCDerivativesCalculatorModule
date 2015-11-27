using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ImpliedTrade
    {
        public ImpliedTrade(XmlNode xmlNode)
        {
            XmlNodeList originatingEventNodeList = xmlNode.SelectNodes("originatingEvent");
            if (originatingEventNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in originatingEventNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        originatingEventIDRef = item.Attributes["id"].Name;
                        OriginatingEvent ob = OriginatingEvent();
                        IDManager.SetID(originatingEventIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        originatingEventIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        originatingEvent = new OriginatingEvent(item);
                    }
                }
            }
            
        
            XmlNodeList tradeNodeList = xmlNode.SelectNodes("trade");
            if (tradeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in tradeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        tradeIDRef = item.Attributes["id"].Name;
                        Trade ob = Trade();
                        IDManager.SetID(tradeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        tradeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        trade = new Trade(item);
                    }
                }
            }
            
        
            XmlNodeList paymentNodeList = xmlNode.SelectNodes("payment");
            if (paymentNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in paymentNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        paymentIDRef = item.Attributes["id"].Name;
                        NonNegativePayment ob = NonNegativePayment();
                        IDManager.SetID(paymentIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        paymentIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        payment = new NonNegativePayment(item);
                    }
                }
            }
            
        
        }
        
    
        #region OriginatingEvent
        private OriginatingEvent originatingEvent;
        public OriginatingEvent OriginatingEvent
        {
            get
            {
                if (this.originatingEvent != null)
                {
                    return this.originatingEvent; 
                }
                else if (this.originatingEventIDRef != null)
                {
                    originatingEvent = IDManager.getID(originatingEventIDRef) as OriginatingEvent;
                    return this.originatingEvent; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.originatingEvent != value)
                {
                    this.originatingEvent = value;
                }
            }
        }
        #endregion
        
        public string OriginatingEventIDRef { get; set; }
        #region Trade
        private Trade trade;
        public Trade Trade
        {
            get
            {
                if (this.trade != null)
                {
                    return this.trade; 
                }
                else if (this.tradeIDRef != null)
                {
                    trade = IDManager.getID(tradeIDRef) as Trade;
                    return this.trade; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.trade != value)
                {
                    this.trade = value;
                }
            }
        }
        #endregion
        
        public string TradeIDRef { get; set; }
        #region Payment
        private NonNegativePayment payment;
        public NonNegativePayment Payment
        {
            get
            {
                if (this.payment != null)
                {
                    return this.payment; 
                }
                else if (this.paymentIDRef != null)
                {
                    payment = IDManager.getID(paymentIDRef) as NonNegativePayment;
                    return this.payment; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.payment != value)
                {
                    this.payment = value;
                }
            }
        }
        #endregion
        
        public string NonNegativePaymentIDRef { get; set; }
        
    
        
    
    }
    
}

