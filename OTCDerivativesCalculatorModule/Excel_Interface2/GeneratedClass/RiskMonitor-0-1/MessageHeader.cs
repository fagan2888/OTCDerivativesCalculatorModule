using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class MessageHeader : ISerialized
    {
        public MessageHeader() { }
        public MessageHeader(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode messageIdNode = xmlNode.SelectSingleNode("messageId");
            
            if (messageIdNode != null)
            {
                if (messageIdNode.Attributes["href"] != null || messageIdNode.Attributes["id"] != null) 
                {
                    if (messageIdNode.Attributes["id"] != null) 
                    {
                        messageIdIDRef_ = messageIdNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(messageIdNode);
                        IDManager.SetID(messageIdIDRef_, ob);
                    }
                    else if (messageIdNode.Attributes["href"] != null)
                    {
                        messageIdIDRef_ = messageIdNode.Attributes["href"].Value;
                    }
                    else
                    {
                        messageId_ = new XsdTypeToken(messageIdNode);
                    }
                }
                else
                {
                    messageId_ = new XsdTypeToken(messageIdNode);
                }
            }
            
        
            XmlNode messageTypeNode = xmlNode.SelectSingleNode("messageType");
            
            if (messageTypeNode != null)
            {
                if (messageTypeNode.Attributes["href"] != null || messageTypeNode.Attributes["id"] != null) 
                {
                    if (messageTypeNode.Attributes["id"] != null) 
                    {
                        messageTypeIDRef_ = messageTypeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(messageTypeNode);
                        IDManager.SetID(messageTypeIDRef_, ob);
                    }
                    else if (messageTypeNode.Attributes["href"] != null)
                    {
                        messageTypeIDRef_ = messageTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        messageType_ = new XsdTypeToken(messageTypeNode);
                    }
                }
                else
                {
                    messageType_ = new XsdTypeToken(messageTypeNode);
                }
            }
            
        
            XmlNode sentByNode = xmlNode.SelectSingleNode("sentBy");
            
            if (sentByNode != null)
            {
                if (sentByNode.Attributes["href"] != null || sentByNode.Attributes["id"] != null) 
                {
                    if (sentByNode.Attributes["id"] != null) 
                    {
                        sentByIDRef_ = sentByNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(sentByNode);
                        IDManager.SetID(sentByIDRef_, ob);
                    }
                    else if (sentByNode.Attributes["href"] != null)
                    {
                        sentByIDRef_ = sentByNode.Attributes["href"].Value;
                    }
                    else
                    {
                        sentBy_ = new XsdTypeToken(sentByNode);
                    }
                }
                else
                {
                    sentBy_ = new XsdTypeToken(sentByNode);
                }
            }
            
        
            XmlNode sendToNode = xmlNode.SelectSingleNode("sendTo");
            
            if (sendToNode != null)
            {
                if (sendToNode.Attributes["href"] != null || sendToNode.Attributes["id"] != null) 
                {
                    if (sendToNode.Attributes["id"] != null) 
                    {
                        sendToIDRef_ = sendToNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(sendToNode);
                        IDManager.SetID(sendToIDRef_, ob);
                    }
                    else if (sendToNode.Attributes["href"] != null)
                    {
                        sendToIDRef_ = sendToNode.Attributes["href"].Value;
                    }
                    else
                    {
                        sendTo_ = new XsdTypeToken(sendToNode);
                    }
                }
                else
                {
                    sendTo_ = new XsdTypeToken(sendToNode);
                }
            }
            
        
            XmlNode creationTimestampNode = xmlNode.SelectSingleNode("creationTimestamp");
            
            if (creationTimestampNode != null)
            {
                if (creationTimestampNode.Attributes["href"] != null || creationTimestampNode.Attributes["id"] != null) 
                {
                    if (creationTimestampNode.Attributes["id"] != null) 
                    {
                        creationTimestampIDRef_ = creationTimestampNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(creationTimestampNode);
                        IDManager.SetID(creationTimestampIDRef_, ob);
                    }
                    else if (creationTimestampNode.Attributes["href"] != null)
                    {
                        creationTimestampIDRef_ = creationTimestampNode.Attributes["href"].Value;
                    }
                    else
                    {
                        creationTimestamp_ = new XsdTypeToken(creationTimestampNode);
                    }
                }
                else
                {
                    creationTimestamp_ = new XsdTypeToken(creationTimestampNode);
                }
            }
            
        
            XmlNode isCorrectionNode = xmlNode.SelectSingleNode("isCorrection");
            
            if (isCorrectionNode != null)
            {
                if (isCorrectionNode.Attributes["href"] != null || isCorrectionNode.Attributes["id"] != null) 
                {
                    if (isCorrectionNode.Attributes["id"] != null) 
                    {
                        isCorrectionIDRef_ = isCorrectionNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(isCorrectionNode);
                        IDManager.SetID(isCorrectionIDRef_, ob);
                    }
                    else if (isCorrectionNode.Attributes["href"] != null)
                    {
                        isCorrectionIDRef_ = isCorrectionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        isCorrection_ = new XsdTypeToken(isCorrectionNode);
                    }
                }
                else
                {
                    isCorrection_ = new XsdTypeToken(isCorrectionNode);
                }
            }
            
        
            XmlNode correlationIdNode = xmlNode.SelectSingleNode("correlationId");
            
            if (correlationIdNode != null)
            {
                if (correlationIdNode.Attributes["href"] != null || correlationIdNode.Attributes["id"] != null) 
                {
                    if (correlationIdNode.Attributes["id"] != null) 
                    {
                        correlationIdIDRef_ = correlationIdNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(correlationIdNode);
                        IDManager.SetID(correlationIdIDRef_, ob);
                    }
                    else if (correlationIdNode.Attributes["href"] != null)
                    {
                        correlationIdIDRef_ = correlationIdNode.Attributes["href"].Value;
                    }
                    else
                    {
                        correlationId_ = new XsdTypeToken(correlationIdNode);
                    }
                }
                else
                {
                    correlationId_ = new XsdTypeToken(correlationIdNode);
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
                        XsdTypeToken ob = new XsdTypeToken(sequenceNumberNode);
                        IDManager.SetID(sequenceNumberIDRef_, ob);
                    }
                    else if (sequenceNumberNode.Attributes["href"] != null)
                    {
                        sequenceNumberIDRef_ = sequenceNumberNode.Attributes["href"].Value;
                    }
                    else
                    {
                        sequenceNumber_ = new XsdTypeToken(sequenceNumberNode);
                    }
                }
                else
                {
                    sequenceNumber_ = new XsdTypeToken(sequenceNumberNode);
                }
            }
            
        
        }
        
    
        #region MessageId_
        private XsdTypeToken messageId_;
        public XsdTypeToken MessageId_
        {
            get
            {
                if (this.messageId_ != null)
                {
                    return this.messageId_; 
                }
                else if (this.messageIdIDRef_ != null)
                {
                    messageId_ = IDManager.getID(messageIdIDRef_) as XsdTypeToken;
                    return this.messageId_; 
                }
                else
                {
                    throw new Exception( "messageId_Node no exist!");
                }
            }
            set
            {
                if (this.messageId_ != value)
                {
                    this.messageId_ = value;
                }
            }
        }
        #endregion
        
        public string messageIdIDRef_ { get; set; }
        #region MessageType_
        private XsdTypeToken messageType_;
        public XsdTypeToken MessageType_
        {
            get
            {
                if (this.messageType_ != null)
                {
                    return this.messageType_; 
                }
                else if (this.messageTypeIDRef_ != null)
                {
                    messageType_ = IDManager.getID(messageTypeIDRef_) as XsdTypeToken;
                    return this.messageType_; 
                }
                else
                {
                    throw new Exception( "messageType_Node no exist!");
                }
            }
            set
            {
                if (this.messageType_ != value)
                {
                    this.messageType_ = value;
                }
            }
        }
        #endregion
        
        public string messageTypeIDRef_ { get; set; }
        #region SentBy_
        private XsdTypeToken sentBy_;
        public XsdTypeToken SentBy_
        {
            get
            {
                if (this.sentBy_ != null)
                {
                    return this.sentBy_; 
                }
                else if (this.sentByIDRef_ != null)
                {
                    sentBy_ = IDManager.getID(sentByIDRef_) as XsdTypeToken;
                    return this.sentBy_; 
                }
                else
                {
                    throw new Exception( "sentBy_Node no exist!");
                }
            }
            set
            {
                if (this.sentBy_ != value)
                {
                    this.sentBy_ = value;
                }
            }
        }
        #endregion
        
        public string sentByIDRef_ { get; set; }
        #region SendTo_
        private XsdTypeToken sendTo_;
        public XsdTypeToken SendTo_
        {
            get
            {
                if (this.sendTo_ != null)
                {
                    return this.sendTo_; 
                }
                else if (this.sendToIDRef_ != null)
                {
                    sendTo_ = IDManager.getID(sendToIDRef_) as XsdTypeToken;
                    return this.sendTo_; 
                }
                else
                {
                    throw new Exception( "sendTo_Node no exist!");
                }
            }
            set
            {
                if (this.sendTo_ != value)
                {
                    this.sendTo_ = value;
                }
            }
        }
        #endregion
        
        public string sendToIDRef_ { get; set; }
        #region CreationTimestamp_
        private XsdTypeToken creationTimestamp_;
        public XsdTypeToken CreationTimestamp_
        {
            get
            {
                if (this.creationTimestamp_ != null)
                {
                    return this.creationTimestamp_; 
                }
                else if (this.creationTimestampIDRef_ != null)
                {
                    creationTimestamp_ = IDManager.getID(creationTimestampIDRef_) as XsdTypeToken;
                    return this.creationTimestamp_; 
                }
                else
                {
                    throw new Exception( "creationTimestamp_Node no exist!");
                }
            }
            set
            {
                if (this.creationTimestamp_ != value)
                {
                    this.creationTimestamp_ = value;
                }
            }
        }
        #endregion
        
        public string creationTimestampIDRef_ { get; set; }
        #region IsCorrection_
        private XsdTypeToken isCorrection_;
        public XsdTypeToken IsCorrection_
        {
            get
            {
                if (this.isCorrection_ != null)
                {
                    return this.isCorrection_; 
                }
                else if (this.isCorrectionIDRef_ != null)
                {
                    isCorrection_ = IDManager.getID(isCorrectionIDRef_) as XsdTypeToken;
                    return this.isCorrection_; 
                }
                else
                {
                    throw new Exception( "isCorrection_Node no exist!");
                }
            }
            set
            {
                if (this.isCorrection_ != value)
                {
                    this.isCorrection_ = value;
                }
            }
        }
        #endregion
        
        public string isCorrectionIDRef_ { get; set; }
        #region CorrelationId_
        private XsdTypeToken correlationId_;
        public XsdTypeToken CorrelationId_
        {
            get
            {
                if (this.correlationId_ != null)
                {
                    return this.correlationId_; 
                }
                else if (this.correlationIdIDRef_ != null)
                {
                    correlationId_ = IDManager.getID(correlationIdIDRef_) as XsdTypeToken;
                    return this.correlationId_; 
                }
                else
                {
                    throw new Exception( "correlationId_Node no exist!");
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
        private XsdTypeToken sequenceNumber_;
        public XsdTypeToken SequenceNumber_
        {
            get
            {
                if (this.sequenceNumber_ != null)
                {
                    return this.sequenceNumber_; 
                }
                else if (this.sequenceNumberIDRef_ != null)
                {
                    sequenceNumber_ = IDManager.getID(sequenceNumberIDRef_) as XsdTypeToken;
                    return this.sequenceNumber_; 
                }
                else
                {
                    throw new Exception( "sequenceNumber_Node no exist!");
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
        
    
        
    
    }
    
}

