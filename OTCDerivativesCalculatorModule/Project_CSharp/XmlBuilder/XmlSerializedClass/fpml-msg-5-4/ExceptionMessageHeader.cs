using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ExceptionMessageHeader : MessageHeader
    {
        public ExceptionMessageHeader(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode inReplyToNode = xmlNode.SelectSingleNode("inReplyTo");
            
            if (inReplyToNode != null)
            {
                if (inReplyToNode.Attributes["href"] != null || inReplyToNode.Attributes["id"] != null) 
                {
                    if (inReplyToNode.Attributes["id"] != null) 
                    {
                        inReplyToIDRef_ = inReplyToNode.Attributes["id"].Value;
                        MessageId ob = new MessageId(inReplyToNode);
                        IDManager.SetID(inReplyToIDRef_, ob);
                    }
                    else if (inReplyToNode.Attributes["href"] != null)
                    {
                        inReplyToIDRef_ = inReplyToNode.Attributes["href"].Value;
                    }
                    else
                    {
                        inReplyTo_ = new MessageId(inReplyToNode);
                    }
                }
                else
                {
                    inReplyTo_ = new MessageId(inReplyToNode);
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
                        MessageAddress ob = new MessageAddress(sentByNode);
                        IDManager.SetID(sentByIDRef_, ob);
                    }
                    else if (sentByNode.Attributes["href"] != null)
                    {
                        sentByIDRef_ = sentByNode.Attributes["href"].Value;
                    }
                    else
                    {
                        sentBy_ = new MessageAddress(sentByNode);
                    }
                }
                else
                {
                    sentBy_ = new MessageAddress(sentByNode);
                }
            }
            
        
            XmlNodeList sendToNodeList = xmlNode.SelectNodes("sendTo");
            
            if (sendToNodeList != null)
            {
                this.sendTo_ = new List<MessageAddress>();
                foreach (XmlNode item in sendToNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            sendToIDRef_ = item.Attributes["id"].Value;
                            sendTo_.Add(new MessageAddress(item));
                            IDManager.SetID(sendToIDRef_, sendTo_[sendTo_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            sendToIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        sendTo_.Add(new MessageAddress(item));
                        }
                    }
                    else
                    {
                        sendTo_.Add(new MessageAddress(item));
                    }
                }
            }
            
        
            XmlNodeList copyToNodeList = xmlNode.SelectNodes("copyTo");
            
            if (copyToNodeList != null)
            {
                this.copyTo_ = new List<MessageAddress>();
                foreach (XmlNode item in copyToNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            copyToIDRef_ = item.Attributes["id"].Value;
                            copyTo_.Add(new MessageAddress(item));
                            IDManager.SetID(copyToIDRef_, copyTo_[copyTo_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            copyToIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        copyTo_.Add(new MessageAddress(item));
                        }
                    }
                    else
                    {
                        copyTo_.Add(new MessageAddress(item));
                    }
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
                        XsdTypeDateTime ob = new XsdTypeDateTime(creationTimestampNode);
                        IDManager.SetID(creationTimestampIDRef_, ob);
                    }
                    else if (creationTimestampNode.Attributes["href"] != null)
                    {
                        creationTimestampIDRef_ = creationTimestampNode.Attributes["href"].Value;
                    }
                    else
                    {
                        creationTimestamp_ = new XsdTypeDateTime(creationTimestampNode);
                    }
                }
                else
                {
                    creationTimestamp_ = new XsdTypeDateTime(creationTimestampNode);
                }
            }
            
        
            XmlNode expiryTimestampNode = xmlNode.SelectSingleNode("expiryTimestamp");
            
            if (expiryTimestampNode != null)
            {
                if (expiryTimestampNode.Attributes["href"] != null || expiryTimestampNode.Attributes["id"] != null) 
                {
                    if (expiryTimestampNode.Attributes["id"] != null) 
                    {
                        expiryTimestampIDRef_ = expiryTimestampNode.Attributes["id"].Value;
                        XsdTypeDateTime ob = new XsdTypeDateTime(expiryTimestampNode);
                        IDManager.SetID(expiryTimestampIDRef_, ob);
                    }
                    else if (expiryTimestampNode.Attributes["href"] != null)
                    {
                        expiryTimestampIDRef_ = expiryTimestampNode.Attributes["href"].Value;
                    }
                    else
                    {
                        expiryTimestamp_ = new XsdTypeDateTime(expiryTimestampNode);
                    }
                }
                else
                {
                    expiryTimestamp_ = new XsdTypeDateTime(expiryTimestampNode);
                }
            }
            
        
            XmlNode implementationSpecificationNode = xmlNode.SelectSingleNode("implementationSpecification");
            
            if (implementationSpecificationNode != null)
            {
                if (implementationSpecificationNode.Attributes["href"] != null || implementationSpecificationNode.Attributes["id"] != null) 
                {
                    if (implementationSpecificationNode.Attributes["id"] != null) 
                    {
                        implementationSpecificationIDRef_ = implementationSpecificationNode.Attributes["id"].Value;
                        ImplementationSpecification ob = new ImplementationSpecification(implementationSpecificationNode);
                        IDManager.SetID(implementationSpecificationIDRef_, ob);
                    }
                    else if (implementationSpecificationNode.Attributes["href"] != null)
                    {
                        implementationSpecificationIDRef_ = implementationSpecificationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        implementationSpecification_ = new ImplementationSpecification(implementationSpecificationNode);
                    }
                }
                else
                {
                    implementationSpecification_ = new ImplementationSpecification(implementationSpecificationNode);
                }
            }
            
        
            XmlNodeList partyMessageInformationNodeList = xmlNode.SelectNodes("partyMessageInformation");
            
            if (partyMessageInformationNodeList != null)
            {
                this.partyMessageInformation_ = new List<PartyMessageInformation>();
                foreach (XmlNode item in partyMessageInformationNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            partyMessageInformationIDRef_ = item.Attributes["id"].Value;
                            partyMessageInformation_.Add(new PartyMessageInformation(item));
                            IDManager.SetID(partyMessageInformationIDRef_, partyMessageInformation_[partyMessageInformation_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            partyMessageInformationIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        partyMessageInformation_.Add(new PartyMessageInformation(item));
                        }
                    }
                    else
                    {
                        partyMessageInformation_.Add(new PartyMessageInformation(item));
                    }
                }
            }
            
        
            XmlNode SignatureNode = xmlNode.SelectSingleNode("Signature");
            
            if (SignatureNode != null)
            {
                if (SignatureNode.Attributes["href"] != null || SignatureNode.Attributes["id"] != null) 
                {
                    if (SignatureNode.Attributes["id"] != null) 
                    {
                        SignatureIDRef_ = SignatureNode.Attributes["id"].Value;
                        SignatureType ob = new SignatureType(SignatureNode);
                        IDManager.SetID(SignatureIDRef_, ob);
                    }
                    else if (SignatureNode.Attributes["href"] != null)
                    {
                        SignatureIDRef_ = SignatureNode.Attributes["href"].Value;
                    }
                    else
                    {
                        Signature_ = new SignatureType(SignatureNode);
                    }
                }
                else
                {
                    Signature_ = new SignatureType(SignatureNode);
                }
            }
            
        
        }
        
    
        #region InReplyTo_
        private MessageId inReplyTo_;
        public MessageId InReplyTo_
        {
            get
            {
                if (this.inReplyTo_ != null)
                {
                    return this.inReplyTo_; 
                }
                else if (this.inReplyToIDRef_ != null)
                {
                    inReplyTo_ = IDManager.getID(inReplyToIDRef_) as MessageId;
                    return this.inReplyTo_; 
                }
                else
                {
                      return this.inReplyTo_; 
                }
            }
            set
            {
                if (this.inReplyTo_ != value)
                {
                    this.inReplyTo_ = value;
                }
            }
        }
        #endregion
        
        public string inReplyToIDRef_ { get; set; }
        #region SentBy_
        private MessageAddress sentBy_;
        public MessageAddress SentBy_
        {
            get
            {
                if (this.sentBy_ != null)
                {
                    return this.sentBy_; 
                }
                else if (this.sentByIDRef_ != null)
                {
                    sentBy_ = IDManager.getID(sentByIDRef_) as MessageAddress;
                    return this.sentBy_; 
                }
                else
                {
                      return this.sentBy_; 
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
        private List<MessageAddress> sendTo_;
        public List<MessageAddress> SendTo_
        {
            get
            {
                if (this.sendTo_ != null)
                {
                    return this.sendTo_; 
                }
                else if (this.sendToIDRef_ != null)
                {
                    return this.sendTo_; 
                }
                else
                {
                      return this.sendTo_; 
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
        #region CopyTo_
        private List<MessageAddress> copyTo_;
        public List<MessageAddress> CopyTo_
        {
            get
            {
                if (this.copyTo_ != null)
                {
                    return this.copyTo_; 
                }
                else if (this.copyToIDRef_ != null)
                {
                    return this.copyTo_; 
                }
                else
                {
                      return this.copyTo_; 
                }
            }
            set
            {
                if (this.copyTo_ != value)
                {
                    this.copyTo_ = value;
                }
            }
        }
        #endregion
        
        public string copyToIDRef_ { get; set; }
        #region CreationTimestamp_
        private XsdTypeDateTime creationTimestamp_;
        public XsdTypeDateTime CreationTimestamp_
        {
            get
            {
                if (this.creationTimestamp_ != null)
                {
                    return this.creationTimestamp_; 
                }
                else if (this.creationTimestampIDRef_ != null)
                {
                    creationTimestamp_ = IDManager.getID(creationTimestampIDRef_) as XsdTypeDateTime;
                    return this.creationTimestamp_; 
                }
                else
                {
                      return this.creationTimestamp_; 
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
        #region ExpiryTimestamp_
        private XsdTypeDateTime expiryTimestamp_;
        public XsdTypeDateTime ExpiryTimestamp_
        {
            get
            {
                if (this.expiryTimestamp_ != null)
                {
                    return this.expiryTimestamp_; 
                }
                else if (this.expiryTimestampIDRef_ != null)
                {
                    expiryTimestamp_ = IDManager.getID(expiryTimestampIDRef_) as XsdTypeDateTime;
                    return this.expiryTimestamp_; 
                }
                else
                {
                      return this.expiryTimestamp_; 
                }
            }
            set
            {
                if (this.expiryTimestamp_ != value)
                {
                    this.expiryTimestamp_ = value;
                }
            }
        }
        #endregion
        
        public string expiryTimestampIDRef_ { get; set; }
        #region ImplementationSpecification_
        private ImplementationSpecification implementationSpecification_;
        public ImplementationSpecification ImplementationSpecification_
        {
            get
            {
                if (this.implementationSpecification_ != null)
                {
                    return this.implementationSpecification_; 
                }
                else if (this.implementationSpecificationIDRef_ != null)
                {
                    implementationSpecification_ = IDManager.getID(implementationSpecificationIDRef_) as ImplementationSpecification;
                    return this.implementationSpecification_; 
                }
                else
                {
                      return this.implementationSpecification_; 
                }
            }
            set
            {
                if (this.implementationSpecification_ != value)
                {
                    this.implementationSpecification_ = value;
                }
            }
        }
        #endregion
        
        public string implementationSpecificationIDRef_ { get; set; }
        #region PartyMessageInformation_
        private List<PartyMessageInformation> partyMessageInformation_;
        public List<PartyMessageInformation> PartyMessageInformation_
        {
            get
            {
                if (this.partyMessageInformation_ != null)
                {
                    return this.partyMessageInformation_; 
                }
                else if (this.partyMessageInformationIDRef_ != null)
                {
                    return this.partyMessageInformation_; 
                }
                else
                {
                      return this.partyMessageInformation_; 
                }
            }
            set
            {
                if (this.partyMessageInformation_ != value)
                {
                    this.partyMessageInformation_ = value;
                }
            }
        }
        #endregion
        
        public string partyMessageInformationIDRef_ { get; set; }
        #region Signature_
        private SignatureType Signature_;
        public SignatureType Signature_
        {
            get
            {
                if (this.Signature_ != null)
                {
                    return this.Signature_; 
                }
                else if (this.SignatureIDRef_ != null)
                {
                    Signature_ = IDManager.getID(SignatureIDRef_) as SignatureType;
                    return this.Signature_; 
                }
                else
                {
                      return this.Signature_; 
                }
            }
            set
            {
                if (this.Signature_ != value)
                {
                    this.Signature_ = value;
                }
            }
        }
        #endregion
        
        public string SignatureIDRef_ { get; set; }
        
    
        
    
    }
    
}

