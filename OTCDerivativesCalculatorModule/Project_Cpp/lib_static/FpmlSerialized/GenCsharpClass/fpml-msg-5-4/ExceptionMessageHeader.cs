using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ExceptionMessageHeader
    {
        public ExceptionMessageHeader(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList inReplyToNodeList = xmlNode.SelectNodes("inReplyTo");
            if (inReplyToNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in inReplyToNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        inReplyToIDRef = item.Attributes["id"].Name;
                        MessageId ob = MessageId();
                        IDManager.SetID(inReplyToIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        inReplyToIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        inReplyTo = new MessageId(item);
                    }
                }
            }
            
        
            XmlNodeList sentByNodeList = xmlNode.SelectNodes("sentBy");
            if (sentByNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in sentByNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        sentByIDRef = item.Attributes["id"].Name;
                        MessageAddress ob = MessageAddress();
                        IDManager.SetID(sentByIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        sentByIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        sentBy = new MessageAddress(item);
                    }
                }
            }
            
        
            XmlNodeList sendToNodeList = xmlNode.SelectNodes("sendTo");
            
            foreach (XmlNode item in sendToNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        sendToIDRef = item.Attributes["id"].Name;
                        List<MessageAddress> ob = new List<MessageAddress>();
                        ob.Add(new MessageAddress(item));
                        IDManager.SetID(sendToIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        sendToIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    sendTo.Add(new MessageAddress(item));
                    }
                }
            }
            
        
            XmlNodeList copyToNodeList = xmlNode.SelectNodes("copyTo");
            
            foreach (XmlNode item in copyToNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        copyToIDRef = item.Attributes["id"].Name;
                        List<MessageAddress> ob = new List<MessageAddress>();
                        ob.Add(new MessageAddress(item));
                        IDManager.SetID(copyToIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        copyToIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    copyTo.Add(new MessageAddress(item));
                    }
                }
            }
            
        
            XmlNodeList creationTimestampNodeList = xmlNode.SelectNodes("creationTimestamp");
            if (creationTimestampNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in creationTimestampNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        creationTimestampIDRef = item.Attributes["id"].Name;
                        XsdTypeDateTime ob = XsdTypeDateTime();
                        IDManager.SetID(creationTimestampIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        creationTimestampIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        creationTimestamp = new XsdTypeDateTime(item);
                    }
                }
            }
            
        
            XmlNodeList expiryTimestampNodeList = xmlNode.SelectNodes("expiryTimestamp");
            if (expiryTimestampNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in expiryTimestampNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        expiryTimestampIDRef = item.Attributes["id"].Name;
                        XsdTypeDateTime ob = XsdTypeDateTime();
                        IDManager.SetID(expiryTimestampIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        expiryTimestampIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        expiryTimestamp = new XsdTypeDateTime(item);
                    }
                }
            }
            
        
            XmlNodeList implementationSpecificationNodeList = xmlNode.SelectNodes("implementationSpecification");
            if (implementationSpecificationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in implementationSpecificationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        implementationSpecificationIDRef = item.Attributes["id"].Name;
                        ImplementationSpecification ob = ImplementationSpecification();
                        IDManager.SetID(implementationSpecificationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        implementationSpecificationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        implementationSpecification = new ImplementationSpecification(item);
                    }
                }
            }
            
        
            XmlNodeList partyMessageInformationNodeList = xmlNode.SelectNodes("partyMessageInformation");
            
            foreach (XmlNode item in partyMessageInformationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        partyMessageInformationIDRef = item.Attributes["id"].Name;
                        List<PartyMessageInformation> ob = new List<PartyMessageInformation>();
                        ob.Add(new PartyMessageInformation(item));
                        IDManager.SetID(partyMessageInformationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        partyMessageInformationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    partyMessageInformation.Add(new PartyMessageInformation(item));
                    }
                }
            }
            
        
            XmlNodeList SignatureNodeList = xmlNode.SelectNodes("Signature");
            if (SignatureNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in SignatureNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        SignatureIDRef = item.Attributes["id"].Name;
                        SignatureType ob = SignatureType();
                        IDManager.SetID(SignatureIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        SignatureIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        Signature = new SignatureType(item);
                    }
                }
            }
            
        
        }
        
    
        #region InReplyTo
        private MessageId inReplyTo;
        public MessageId InReplyTo
        {
            get
            {
                if (this.inReplyTo != null)
                {
                    return this.inReplyTo; 
                }
                else if (this.inReplyToIDRef != null)
                {
                    inReplyTo = IDManager.getID(inReplyToIDRef) as MessageId;
                    return this.inReplyTo; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.inReplyTo != value)
                {
                    this.inReplyTo = value;
                }
            }
        }
        #endregion
        
        public string MessageIdIDRef { get; set; }
        #region SentBy
        private MessageAddress sentBy;
        public MessageAddress SentBy
        {
            get
            {
                if (this.sentBy != null)
                {
                    return this.sentBy; 
                }
                else if (this.sentByIDRef != null)
                {
                    sentBy = IDManager.getID(sentByIDRef) as MessageAddress;
                    return this.sentBy; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.sentBy != value)
                {
                    this.sentBy = value;
                }
            }
        }
        #endregion
        
        public string MessageAddressIDRef { get; set; }
        #region SendTo
        private List<MessageAddress> sendTo;
        public List<MessageAddress> SendTo
        {
            get
            {
                if (this.sendTo != null)
                {
                    return this.sendTo; 
                }
                else if (this.sendToIDRef != null)
                {
                    sendTo = IDManager.getID(sendToIDRef) as List<MessageAddress>;
                    return this.sendTo; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.sendTo != value)
                {
                    this.sendTo = value;
                }
            }
        }
        #endregion
        
        public string MessageAddressIDRef { get; set; }
        #region CopyTo
        private List<MessageAddress> copyTo;
        public List<MessageAddress> CopyTo
        {
            get
            {
                if (this.copyTo != null)
                {
                    return this.copyTo; 
                }
                else if (this.copyToIDRef != null)
                {
                    copyTo = IDManager.getID(copyToIDRef) as List<MessageAddress>;
                    return this.copyTo; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.copyTo != value)
                {
                    this.copyTo = value;
                }
            }
        }
        #endregion
        
        public string MessageAddressIDRef { get; set; }
        #region CreationTimestamp
        private XsdTypeDateTime creationTimestamp;
        public XsdTypeDateTime CreationTimestamp
        {
            get
            {
                if (this.creationTimestamp != null)
                {
                    return this.creationTimestamp; 
                }
                else if (this.creationTimestampIDRef != null)
                {
                    creationTimestamp = IDManager.getID(creationTimestampIDRef) as XsdTypeDateTime;
                    return this.creationTimestamp; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.creationTimestamp != value)
                {
                    this.creationTimestamp = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateTimeIDRef { get; set; }
        #region ExpiryTimestamp
        private XsdTypeDateTime expiryTimestamp;
        public XsdTypeDateTime ExpiryTimestamp
        {
            get
            {
                if (this.expiryTimestamp != null)
                {
                    return this.expiryTimestamp; 
                }
                else if (this.expiryTimestampIDRef != null)
                {
                    expiryTimestamp = IDManager.getID(expiryTimestampIDRef) as XsdTypeDateTime;
                    return this.expiryTimestamp; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.expiryTimestamp != value)
                {
                    this.expiryTimestamp = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateTimeIDRef { get; set; }
        #region ImplementationSpecification
        private ImplementationSpecification implementationSpecification;
        public ImplementationSpecification ImplementationSpecification
        {
            get
            {
                if (this.implementationSpecification != null)
                {
                    return this.implementationSpecification; 
                }
                else if (this.implementationSpecificationIDRef != null)
                {
                    implementationSpecification = IDManager.getID(implementationSpecificationIDRef) as ImplementationSpecification;
                    return this.implementationSpecification; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.implementationSpecification != value)
                {
                    this.implementationSpecification = value;
                }
            }
        }
        #endregion
        
        public string ImplementationSpecificationIDRef { get; set; }
        #region PartyMessageInformation
        private List<PartyMessageInformation> partyMessageInformation;
        public List<PartyMessageInformation> PartyMessageInformation
        {
            get
            {
                if (this.partyMessageInformation != null)
                {
                    return this.partyMessageInformation; 
                }
                else if (this.partyMessageInformationIDRef != null)
                {
                    partyMessageInformation = IDManager.getID(partyMessageInformationIDRef) as List<PartyMessageInformation>;
                    return this.partyMessageInformation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.partyMessageInformation != value)
                {
                    this.partyMessageInformation = value;
                }
            }
        }
        #endregion
        
        public string PartyMessageInformationIDRef { get; set; }
        #region Signature
        private SignatureType Signature;
        public SignatureType Signature
        {
            get
            {
                if (this.Signature != null)
                {
                    return this.Signature; 
                }
                else if (this.SignatureIDRef != null)
                {
                    Signature = IDManager.getID(SignatureIDRef) as SignatureType;
                    return this.Signature; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.Signature != value)
                {
                    this.Signature = value;
                }
            }
        }
        #endregion
        
        public string SignatureTypeIDRef { get; set; }
        
    
        
    
    }
    
}

