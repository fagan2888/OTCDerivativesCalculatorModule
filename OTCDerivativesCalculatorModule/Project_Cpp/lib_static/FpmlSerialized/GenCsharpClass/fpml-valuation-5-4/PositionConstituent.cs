using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class PositionConstituent
    {
        public PositionConstituent(XmlNode xmlNode)
        {
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
            
        
            XmlNodeList positionVersionReferenceNodeList = xmlNode.SelectNodes("positionVersionReference");
            if (positionVersionReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in positionVersionReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        positionVersionReferenceIDRef = item.Attributes["id"].Name;
                        XsdTypePositiveInteger ob = XsdTypePositiveInteger();
                        IDManager.SetID(positionVersionReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        positionVersionReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        positionVersionReference = new XsdTypePositiveInteger(item);
                    }
                }
            }
            
        
            XmlNodeList tradeReferenceNodeList = xmlNode.SelectNodes("tradeReference");
            if (tradeReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in tradeReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        tradeReferenceIDRef = item.Attributes["id"].Name;
                        PartyTradeIdentifiers ob = PartyTradeIdentifiers();
                        IDManager.SetID(tradeReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        tradeReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        tradeReference = new PartyTradeIdentifiers(item);
                    }
                }
            }
            
        
        }
        
    
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
        #region PositionVersionReference
        private XsdTypePositiveInteger positionVersionReference;
        public XsdTypePositiveInteger PositionVersionReference
        {
            get
            {
                if (this.positionVersionReference != null)
                {
                    return this.positionVersionReference; 
                }
                else if (this.positionVersionReferenceIDRef != null)
                {
                    positionVersionReference = IDManager.getID(positionVersionReferenceIDRef) as XsdTypePositiveInteger;
                    return this.positionVersionReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.positionVersionReference != value)
                {
                    this.positionVersionReference = value;
                }
            }
        }
        #endregion
        
        public string XsdTypePositiveIntegerIDRef { get; set; }
        #region TradeReference
        private PartyTradeIdentifiers tradeReference;
        public PartyTradeIdentifiers TradeReference
        {
            get
            {
                if (this.tradeReference != null)
                {
                    return this.tradeReference; 
                }
                else if (this.tradeReferenceIDRef != null)
                {
                    tradeReference = IDManager.getID(tradeReferenceIDRef) as PartyTradeIdentifiers;
                    return this.tradeReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.tradeReference != value)
                {
                    this.tradeReference = value;
                }
            }
        }
        #endregion
        
        public string PartyTradeIdentifiersIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

