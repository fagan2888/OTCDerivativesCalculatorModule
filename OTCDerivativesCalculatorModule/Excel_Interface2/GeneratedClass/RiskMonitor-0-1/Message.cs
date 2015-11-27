using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Message : ISerialized
    {
        public Message() { }
        public Message(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode messageHeaderNode = xmlNode.SelectSingleNode("messageHeader");
            
            if (messageHeaderNode != null)
            {
                if (messageHeaderNode.Attributes["href"] != null || messageHeaderNode.Attributes["id"] != null) 
                {
                    if (messageHeaderNode.Attributes["id"] != null) 
                    {
                        messageHeaderIDRef_ = messageHeaderNode.Attributes["id"].Value;
                        MessageHeader ob = new MessageHeader(messageHeaderNode);
                        IDManager.SetID(messageHeaderIDRef_, ob);
                    }
                    else if (messageHeaderNode.Attributes["href"] != null)
                    {
                        messageHeaderIDRef_ = messageHeaderNode.Attributes["href"].Value;
                    }
                    else
                    {
                        messageHeader_ = new MessageHeader(messageHeaderNode);
                    }
                }
                else
                {
                    messageHeader_ = new MessageHeader(messageHeaderNode);
                }
            }
            
        
            XmlNode messageBodyNode = xmlNode.SelectSingleNode("messageBody");
            
            if (messageBodyNode != null)
            {
                if (messageBodyNode.Attributes["href"] != null || messageBodyNode.Attributes["id"] != null) 
                {
                    if (messageBodyNode.Attributes["id"] != null) 
                    {
                        messageBodyIDRef_ = messageBodyNode.Attributes["id"].Value;
                        MessageBody ob = new MessageBody(messageBodyNode);
                        IDManager.SetID(messageBodyIDRef_, ob);
                    }
                    else if (messageBodyNode.Attributes["href"] != null)
                    {
                        messageBodyIDRef_ = messageBodyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        messageBody_ = new MessageBody(messageBodyNode);
                    }
                }
                else
                {
                    messageBody_ = new MessageBody(messageBodyNode);
                }
            }
            
        
        }
        
    
        #region MessageHeader_
        private MessageHeader messageHeader_;
        public MessageHeader MessageHeader_
        {
            get
            {
                if (this.messageHeader_ != null)
                {
                    return this.messageHeader_; 
                }
                else if (this.messageHeaderIDRef_ != null)
                {
                    messageHeader_ = IDManager.getID(messageHeaderIDRef_) as MessageHeader;
                    return this.messageHeader_; 
                }
                else
                {
                    throw new Exception( "messageHeader_Node no exist!");
                }
            }
            set
            {
                if (this.messageHeader_ != value)
                {
                    this.messageHeader_ = value;
                }
            }
        }
        #endregion
        
        public string messageHeaderIDRef_ { get; set; }
        #region MessageBody_
        private MessageBody messageBody_;
        public MessageBody MessageBody_
        {
            get
            {
                if (this.messageBody_ != null)
                {
                    return this.messageBody_; 
                }
                else if (this.messageBodyIDRef_ != null)
                {
                    messageBody_ = IDManager.getID(messageBodyIDRef_) as MessageBody;
                    return this.messageBody_; 
                }
                else
                {
                    throw new Exception( "messageBody_Node no exist!");
                }
            }
            set
            {
                if (this.messageBody_ != value)
                {
                    this.messageBody_ = value;
                }
            }
        }
        #endregion
        
        public string messageBodyIDRef_ { get; set; }
        
    
        
    
    }
    
}

