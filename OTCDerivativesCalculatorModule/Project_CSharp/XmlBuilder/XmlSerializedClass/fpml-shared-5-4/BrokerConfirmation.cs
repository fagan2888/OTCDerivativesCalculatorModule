using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class BrokerConfirmation : ISerialized
    {
        public BrokerConfirmation(XmlNode xmlNode)
        {
            XmlNode brokerConfirmationTypeNode = xmlNode.SelectSingleNode("brokerConfirmationType");
            
            if (brokerConfirmationTypeNode != null)
            {
                if (brokerConfirmationTypeNode.Attributes["href"] != null || brokerConfirmationTypeNode.Attributes["id"] != null) 
                {
                    if (brokerConfirmationTypeNode.Attributes["id"] != null) 
                    {
                        brokerConfirmationTypeIDRef_ = brokerConfirmationTypeNode.Attributes["id"].Value;
                        BrokerConfirmationType ob = new BrokerConfirmationType(brokerConfirmationTypeNode);
                        IDManager.SetID(brokerConfirmationTypeIDRef_, ob);
                    }
                    else if (brokerConfirmationTypeNode.Attributes["href"] != null)
                    {
                        brokerConfirmationTypeIDRef_ = brokerConfirmationTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        brokerConfirmationType_ = new BrokerConfirmationType(brokerConfirmationTypeNode);
                    }
                }
                else
                {
                    brokerConfirmationType_ = new BrokerConfirmationType(brokerConfirmationTypeNode);
                }
            }
            
        
        }
        
    
        #region BrokerConfirmationType_
        private BrokerConfirmationType brokerConfirmationType_;
        public BrokerConfirmationType BrokerConfirmationType_
        {
            get
            {
                if (this.brokerConfirmationType_ != null)
                {
                    return this.brokerConfirmationType_; 
                }
                else if (this.brokerConfirmationTypeIDRef_ != null)
                {
                    brokerConfirmationType_ = IDManager.getID(brokerConfirmationTypeIDRef_) as BrokerConfirmationType;
                    return this.brokerConfirmationType_; 
                }
                else
                {
                      return this.brokerConfirmationType_; 
                }
            }
            set
            {
                if (this.brokerConfirmationType_ != value)
                {
                    this.brokerConfirmationType_ = value;
                }
            }
        }
        #endregion
        
        public string brokerConfirmationTypeIDRef_ { get; set; }
        
    
        
    
    }
    
}

