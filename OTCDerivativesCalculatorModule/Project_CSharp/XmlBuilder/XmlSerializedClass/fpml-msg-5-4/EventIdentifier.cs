using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class EventIdentifier : ISerialized
    {
        public EventIdentifier(XmlNode xmlNode)
        {
            XmlNode correlationIdNode = xmlNode.SelectSingleNode("correlationId");
            
            if (correlationIdNode != null)
            {
                if (correlationIdNode.Attributes["href"] != null || correlationIdNode.Attributes["id"] != null) 
                {
                    if (correlationIdNode.Attributes["id"] != null) 
                    {
                        correlationIdIDRef_ = correlationIdNode.Attributes["id"].Value;
                        CorrelationId ob = new CorrelationId(correlationIdNode);
                        IDManager.SetID(correlationIdIDRef_, ob);
                    }
                    else if (correlationIdNode.Attributes["href"] != null)
                    {
                        correlationIdIDRef_ = correlationIdNode.Attributes["href"].Value;
                    }
                    else
                    {
                        correlationId_ = new CorrelationId(correlationIdNode);
                    }
                }
                else
                {
                    correlationId_ = new CorrelationId(correlationIdNode);
                }
            }
            
        
            XmlNode sequenceNumberNode = xmlNode.SelectSingleNode("sequenceNumber");
            
            if (sequenceNumberNode != null)
            {
                if (sequenceNumberNode.Attributes["href"] != null || sequenceNumberNode.Attributes["id"] != null) 
                {
                    if (sequenceNumberNode.Attributes["id"] != null) 
                    {
                        sequenceNumberIDRef_ = sequenceNumberNode.Attributes["id"].Value;
                        XsdTypePositiveInteger ob = new XsdTypePositiveInteger(sequenceNumberNode);
                        IDManager.SetID(sequenceNumberIDRef_, ob);
                    }
                    else if (sequenceNumberNode.Attributes["href"] != null)
                    {
                        sequenceNumberIDRef_ = sequenceNumberNode.Attributes["href"].Value;
                    }
                    else
                    {
                        sequenceNumber_ = new XsdTypePositiveInteger(sequenceNumberNode);
                    }
                }
                else
                {
                    sequenceNumber_ = new XsdTypePositiveInteger(sequenceNumberNode);
                }
            }
            
        
            XmlNode tradeIdentifierNode = xmlNode.SelectSingleNode("tradeIdentifier");
            
            if (tradeIdentifierNode != null)
            {
                if (tradeIdentifierNode.Attributes["href"] != null || tradeIdentifierNode.Attributes["id"] != null) 
                {
                    if (tradeIdentifierNode.Attributes["id"] != null) 
                    {
                        tradeIdentifierIDRef_ = tradeIdentifierNode.Attributes["id"].Value;
                        TradeIdentifier ob = new TradeIdentifier(tradeIdentifierNode);
                        IDManager.SetID(tradeIdentifierIDRef_, ob);
                    }
                    else if (tradeIdentifierNode.Attributes["href"] != null)
                    {
                        tradeIdentifierIDRef_ = tradeIdentifierNode.Attributes["href"].Value;
                    }
                    else
                    {
                        tradeIdentifier_ = new TradeIdentifier(tradeIdentifierNode);
                    }
                }
                else
                {
                    tradeIdentifier_ = new TradeIdentifier(tradeIdentifierNode);
                }
            }
            
        
        }
        
    
        #region CorrelationId_
        private CorrelationId correlationId_;
        public CorrelationId CorrelationId_
        {
            get
            {
                if (this.correlationId_ != null)
                {
                    return this.correlationId_; 
                }
                else if (this.correlationIdIDRef_ != null)
                {
                    correlationId_ = IDManager.getID(correlationIdIDRef_) as CorrelationId;
                    return this.correlationId_; 
                }
                else
                {
                      return this.correlationId_; 
                }
            }
            set
            {
                if (this.correlationId_ != value)
                {
                    this.correlationId_ = value;
                }
            }
        }
        #endregion
        
        public string correlationIdIDRef_ { get; set; }
        #region SequenceNumber_
        private XsdTypePositiveInteger sequenceNumber_;
        public XsdTypePositiveInteger SequenceNumber_
        {
            get
            {
                if (this.sequenceNumber_ != null)
                {
                    return this.sequenceNumber_; 
                }
                else if (this.sequenceNumberIDRef_ != null)
                {
                    sequenceNumber_ = IDManager.getID(sequenceNumberIDRef_) as XsdTypePositiveInteger;
                    return this.sequenceNumber_; 
                }
                else
                {
                      return this.sequenceNumber_; 
                }
            }
            set
            {
                if (this.sequenceNumber_ != value)
                {
                    this.sequenceNumber_ = value;
                }
            }
        }
        #endregion
        
        public string sequenceNumberIDRef_ { get; set; }
        #region TradeIdentifier_
        private TradeIdentifier tradeIdentifier_;
        public TradeIdentifier TradeIdentifier_
        {
            get
            {
                if (this.tradeIdentifier_ != null)
                {
                    return this.tradeIdentifier_; 
                }
                else if (this.tradeIdentifierIDRef_ != null)
                {
                    tradeIdentifier_ = IDManager.getID(tradeIdentifierIDRef_) as TradeIdentifier;
                    return this.tradeIdentifier_; 
                }
                else
                {
                      return this.tradeIdentifier_; 
                }
            }
            set
            {
                if (this.tradeIdentifier_ != value)
                {
                    this.tradeIdentifier_ = value;
                }
            }
        }
        #endregion
        
        public string tradeIdentifierIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

