using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class TradeWrapper
    {
        public TradeWrapper(XmlNode xmlNode)
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
            
        
            XmlNodeList tradeReferenceInformationNodeList = xmlNode.SelectNodes("tradeReferenceInformation");
            if (tradeReferenceInformationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in tradeReferenceInformationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        tradeReferenceInformationIDRef = item.Attributes["id"].Name;
                        TradeReferenceInformation ob = TradeReferenceInformation();
                        IDManager.SetID(tradeReferenceInformationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        tradeReferenceInformationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        tradeReferenceInformation = new TradeReferenceInformation(item);
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
        #region TradeReferenceInformation
        private TradeReferenceInformation tradeReferenceInformation;
        public TradeReferenceInformation TradeReferenceInformation
        {
            get
            {
                if (this.tradeReferenceInformation != null)
                {
                    return this.tradeReferenceInformation; 
                }
                else if (this.tradeReferenceInformationIDRef != null)
                {
                    tradeReferenceInformation = IDManager.getID(tradeReferenceInformationIDRef) as TradeReferenceInformation;
                    return this.tradeReferenceInformation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.tradeReferenceInformation != value)
                {
                    this.tradeReferenceInformation = value;
                }
            }
        }
        #endregion
        
        public string TradeReferenceInformationIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

