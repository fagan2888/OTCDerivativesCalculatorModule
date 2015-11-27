using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class MessageHeader
    {
        public MessageHeader(XmlNode xmlNode)
        {
            XmlNodeList messageIdNodeList = xmlNode.SelectNodes("messageId");
            if (messageIdNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in messageIdNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        messageIdIDRef = item.Attributes["id"].Name;
                        MessageId ob = MessageId();
                        IDManager.SetID(messageIdIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        messageIdIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        messageId = new MessageId(item);
                    }
                }
            }
            
        
        }
        
    
        #region MessageId
        private MessageId messageId;
        public MessageId MessageId
        {
            get
            {
                if (this.messageId != null)
                {
                    return this.messageId; 
                }
                else if (this.messageIdIDRef != null)
                {
                    messageId = IDManager.getID(messageIdIDRef) as MessageId;
                    return this.messageId; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.messageId != value)
                {
                    this.messageId = value;
                }
            }
        }
        #endregion
        
        public string MessageIdIDRef { get; set; }
        
    
        
    
    }
    
}

