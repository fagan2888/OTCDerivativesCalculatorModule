using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class TradeChangeContent
    {
        public TradeChangeContent(XmlNode xmlNode)
        {
            XmlNodeList oldTradeIdentifierNodeList = xmlNode.SelectNodes("oldTradeIdentifier");
            if (oldTradeIdentifierNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in oldTradeIdentifierNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        oldTradeIdentifierIDRef = item.Attributes["id"].Name;
                        PartyTradeIdentifier ob = PartyTradeIdentifier();
                        IDManager.SetID(oldTradeIdentifierIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        oldTradeIdentifierIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        oldTradeIdentifier = new PartyTradeIdentifier(item);
                    }
                }
            }
            
        
            XmlNodeList oldTradeNodeList = xmlNode.SelectNodes("oldTrade");
            if (oldTradeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in oldTradeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        oldTradeIDRef = item.Attributes["id"].Name;
                        Trade ob = Trade();
                        IDManager.SetID(oldTradeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        oldTradeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        oldTrade = new Trade(item);
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
            
        
            XmlNodeList effectiveDateNodeList = xmlNode.SelectNodes("effectiveDate");
            if (effectiveDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in effectiveDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        effectiveDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(effectiveDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        effectiveDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        effectiveDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList changeEventNodeList = xmlNode.SelectNodes("changeEvent");
            if (changeEventNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in changeEventNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        changeEventIDRef = item.Attributes["id"].Name;
                        ChangeEvent ob = ChangeEvent();
                        IDManager.SetID(changeEventIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        changeEventIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        changeEvent = new ChangeEvent(item);
                    }
                }
            }
            
        
            XmlNodeList indexChangeNodeList = xmlNode.SelectNodes("indexChange");
            if (indexChangeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in indexChangeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        indexChangeIDRef = item.Attributes["id"].Name;
                        IndexChange ob = IndexChange();
                        IDManager.SetID(indexChangeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        indexChangeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        indexChange = new IndexChange(item);
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
                        Payment ob = Payment();
                        IDManager.SetID(paymentIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        paymentIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        payment = new Payment(item);
                    }
                }
            }
            
        
        }
        
    
        #region OldTradeIdentifier
        private PartyTradeIdentifier oldTradeIdentifier;
        public PartyTradeIdentifier OldTradeIdentifier
        {
            get
            {
                if (this.oldTradeIdentifier != null)
                {
                    return this.oldTradeIdentifier; 
                }
                else if (this.oldTradeIdentifierIDRef != null)
                {
                    oldTradeIdentifier = IDManager.getID(oldTradeIdentifierIDRef) as PartyTradeIdentifier;
                    return this.oldTradeIdentifier; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.oldTradeIdentifier != value)
                {
                    this.oldTradeIdentifier = value;
                }
            }
        }
        #endregion
        
        public string PartyTradeIdentifierIDRef { get; set; }
        #region OldTrade
        private Trade oldTrade;
        public Trade OldTrade
        {
            get
            {
                if (this.oldTrade != null)
                {
                    return this.oldTrade; 
                }
                else if (this.oldTradeIDRef != null)
                {
                    oldTrade = IDManager.getID(oldTradeIDRef) as Trade;
                    return this.oldTrade; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.oldTrade != value)
                {
                    this.oldTrade = value;
                }
            }
        }
        #endregion
        
        public string TradeIDRef { get; set; }
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
        #region EffectiveDate
        private XsdTypeDate effectiveDate;
        public XsdTypeDate EffectiveDate
        {
            get
            {
                if (this.effectiveDate != null)
                {
                    return this.effectiveDate; 
                }
                else if (this.effectiveDateIDRef != null)
                {
                    effectiveDate = IDManager.getID(effectiveDateIDRef) as XsdTypeDate;
                    return this.effectiveDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.effectiveDate != value)
                {
                    this.effectiveDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region ChangeEvent
        private ChangeEvent changeEvent;
        public ChangeEvent ChangeEvent
        {
            get
            {
                if (this.changeEvent != null)
                {
                    return this.changeEvent; 
                }
                else if (this.changeEventIDRef != null)
                {
                    changeEvent = IDManager.getID(changeEventIDRef) as ChangeEvent;
                    return this.changeEvent; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.changeEvent != value)
                {
                    this.changeEvent = value;
                }
            }
        }
        #endregion
        
        public string ChangeEventIDRef { get; set; }
        #region IndexChange
        private IndexChange indexChange;
        public IndexChange IndexChange
        {
            get
            {
                if (this.indexChange != null)
                {
                    return this.indexChange; 
                }
                else if (this.indexChangeIDRef != null)
                {
                    indexChange = IDManager.getID(indexChangeIDRef) as IndexChange;
                    return this.indexChange; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.indexChange != value)
                {
                    this.indexChange = value;
                }
            }
        }
        #endregion
        
        public string IndexChangeIDRef { get; set; }     // substitude
        #region Payment
        private Payment payment;
        public Payment Payment
        {
            get
            {
                if (this.payment != null)
                {
                    return this.payment; 
                }
                else if (this.paymentIDRef != null)
                {
                    payment = IDManager.getID(paymentIDRef) as Payment;
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
        
        public string PaymentIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

