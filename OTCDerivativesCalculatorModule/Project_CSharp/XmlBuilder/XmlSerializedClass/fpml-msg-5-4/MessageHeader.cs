using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class MessageHeader : ISerialized
    {
        public MessageHeader(XmlNode xmlNode)
        {
            XmlNode messageIdNode = xmlNode.SelectSingleNode("messageId");
            
            if (messageIdNode != null)
            {
                if (messageIdNode.Attributes["href"] != null || messageIdNode.Attributes["id"] != null) 
                {
                    if (messageIdNode.Attributes["id"] != null) 
                    {
                        messageIdIDRef_ = messageIdNode.Attributes["id"].Value;
                        MessageId ob = new MessageId(messageIdNode);
                        IDManager.SetID(messageIdIDRef_, ob);
                    }
                    else if (messageIdNode.Attributes["href"] != null)
                    {
                        messageIdIDRef_ = messageIdNode.Attributes["href"].Value;
                    }
                    else
                    {
                        messageId_ = new MessageId(messageIdNode);
                    }
                }
                else
                {
                    messageId_ = new MessageId(messageIdNode);
                }
            }
            
        
        }
        
    
        #region MessageId_
        private MessageId messageId_;
        public MessageId MessageId_
        {
            get
            {
                if (this.messageId_ != null)
                {
                    return this.messageId_; 
                }
                else if (this.messageIdIDRef_ != null)
                {
                    messageId_ = IDManager.getID(messageIdIDRef_) as MessageId;
                    return this.messageId_; 
                }
                else
                {
                      return this.messageId_; 
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
        
    
        
    
    }
    
}

