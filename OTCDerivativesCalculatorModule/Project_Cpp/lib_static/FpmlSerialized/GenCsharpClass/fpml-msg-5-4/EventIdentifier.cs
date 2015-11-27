using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class EventIdentifier
    {
        public EventIdentifier(XmlNode xmlNode)
        {
            XmlNodeList correlationIdNodeList = xmlNode.SelectNodes("correlationId");
            if (correlationIdNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in correlationIdNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        correlationIdIDRef = item.Attributes["id"].Name;
                        CorrelationId ob = CorrelationId();
                        IDManager.SetID(correlationIdIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        correlationIdIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        correlationId = new CorrelationId(item);
                    }
                }
            }
            
        
            XmlNodeList sequenceNumberNodeList = xmlNode.SelectNodes("sequenceNumber");
            if (sequenceNumberNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in sequenceNumberNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        sequenceNumberIDRef = item.Attributes["id"].Name;
                        XsdTypePositiveInteger ob = XsdTypePositiveInteger();
                        IDManager.SetID(sequenceNumberIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        sequenceNumberIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        sequenceNumber = new XsdTypePositiveInteger(item);
                    }
                }
            }
            
        
            XmlNodeList tradeIdentifierNodeList = xmlNode.SelectNodes("tradeIdentifier");
            if (tradeIdentifierNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in tradeIdentifierNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        tradeIdentifierIDRef = item.Attributes["id"].Name;
                        TradeIdentifier ob = TradeIdentifier();
                        IDManager.SetID(tradeIdentifierIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        tradeIdentifierIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        tradeIdentifier = new TradeIdentifier(item);
                    }
                }
            }
            
        
        }
        
    
        #region CorrelationId
        private CorrelationId correlationId;
        public CorrelationId CorrelationId
        {
            get
            {
                if (this.correlationId != null)
                {
                    return this.correlationId; 
                }
                else if (this.correlationIdIDRef != null)
                {
                    correlationId = IDManager.getID(correlationIdIDRef) as CorrelationId;
                    return this.correlationId; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.correlationId != value)
                {
                    this.correlationId = value;
                }
            }
        }
        #endregion
        
        public string CorrelationIdIDRef { get; set; }
        #region SequenceNumber
        private XsdTypePositiveInteger sequenceNumber;
        public XsdTypePositiveInteger SequenceNumber
        {
            get
            {
                if (this.sequenceNumber != null)
                {
                    return this.sequenceNumber; 
                }
                else if (this.sequenceNumberIDRef != null)
                {
                    sequenceNumber = IDManager.getID(sequenceNumberIDRef) as XsdTypePositiveInteger;
                    return this.sequenceNumber; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.sequenceNumber != value)
                {
                    this.sequenceNumber = value;
                }
            }
        }
        #endregion
        
        public string XsdTypePositiveIntegerIDRef { get; set; }
        #region TradeIdentifier
        private TradeIdentifier tradeIdentifier;
        public TradeIdentifier TradeIdentifier
        {
            get
            {
                if (this.tradeIdentifier != null)
                {
                    return this.tradeIdentifier; 
                }
                else if (this.tradeIdentifierIDRef != null)
                {
                    tradeIdentifier = IDManager.getID(tradeIdentifierIDRef) as TradeIdentifier;
                    return this.tradeIdentifier; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.tradeIdentifier != value)
                {
                    this.tradeIdentifier = value;
                }
            }
        }
        #endregion
        
        public string TradeIdentifierIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

