using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class BrokerEquityOption : EquityDerivativeShortFormBase
    {
        public BrokerEquityOption(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode deltaCrossedNode = xmlNode.SelectSingleNode("deltaCrossed");
            
            if (deltaCrossedNode != null)
            {
                if (deltaCrossedNode.Attributes["href"] != null || deltaCrossedNode.Attributes["id"] != null) 
                {
                    if (deltaCrossedNode.Attributes["id"] != null) 
                    {
                        deltaCrossedIDRef_ = deltaCrossedNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(deltaCrossedNode);
                        IDManager.SetID(deltaCrossedIDRef_, ob);
                    }
                    else if (deltaCrossedNode.Attributes["href"] != null)
                    {
                        deltaCrossedIDRef_ = deltaCrossedNode.Attributes["href"].Value;
                    }
                    else
                    {
                        deltaCrossed_ = new XsdTypeBoolean(deltaCrossedNode);
                    }
                }
                else
                {
                    deltaCrossed_ = new XsdTypeBoolean(deltaCrossedNode);
                }
            }
            
        
            XmlNode brokerageFeeNode = xmlNode.SelectSingleNode("brokerageFee");
            
            if (brokerageFeeNode != null)
            {
                if (brokerageFeeNode.Attributes["href"] != null || brokerageFeeNode.Attributes["id"] != null) 
                {
                    if (brokerageFeeNode.Attributes["id"] != null) 
                    {
                        brokerageFeeIDRef_ = brokerageFeeNode.Attributes["id"].Value;
                        Money ob = new Money(brokerageFeeNode);
                        IDManager.SetID(brokerageFeeIDRef_, ob);
                    }
                    else if (brokerageFeeNode.Attributes["href"] != null)
                    {
                        brokerageFeeIDRef_ = brokerageFeeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        brokerageFee_ = new Money(brokerageFeeNode);
                    }
                }
                else
                {
                    brokerageFee_ = new Money(brokerageFeeNode);
                }
            }
            
        
            XmlNode brokerNotesNode = xmlNode.SelectSingleNode("brokerNotes");
            
            if (brokerNotesNode != null)
            {
                if (brokerNotesNode.Attributes["href"] != null || brokerNotesNode.Attributes["id"] != null) 
                {
                    if (brokerNotesNode.Attributes["id"] != null) 
                    {
                        brokerNotesIDRef_ = brokerNotesNode.Attributes["id"].Value;
                        XsdTypeString ob = new XsdTypeString(brokerNotesNode);
                        IDManager.SetID(brokerNotesIDRef_, ob);
                    }
                    else if (brokerNotesNode.Attributes["href"] != null)
                    {
                        brokerNotesIDRef_ = brokerNotesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        brokerNotes_ = new XsdTypeString(brokerNotesNode);
                    }
                }
                else
                {
                    brokerNotes_ = new XsdTypeString(brokerNotesNode);
                }
            }
            
        
        }
        
    
        #region DeltaCrossed_
        private XsdTypeBoolean deltaCrossed_;
        public XsdTypeBoolean DeltaCrossed_
        {
            get
            {
                if (this.deltaCrossed_ != null)
                {
                    return this.deltaCrossed_; 
                }
                else if (this.deltaCrossedIDRef_ != null)
                {
                    deltaCrossed_ = IDManager.getID(deltaCrossedIDRef_) as XsdTypeBoolean;
                    return this.deltaCrossed_; 
                }
                else
                {
                      return this.deltaCrossed_; 
                }
            }
            set
            {
                if (this.deltaCrossed_ != value)
                {
                    this.deltaCrossed_ = value;
                }
            }
        }
        #endregion
        
        public string deltaCrossedIDRef_ { get; set; }
        #region BrokerageFee_
        private Money brokerageFee_;
        public Money BrokerageFee_
        {
            get
            {
                if (this.brokerageFee_ != null)
                {
                    return this.brokerageFee_; 
                }
                else if (this.brokerageFeeIDRef_ != null)
                {
                    brokerageFee_ = IDManager.getID(brokerageFeeIDRef_) as Money;
                    return this.brokerageFee_; 
                }
                else
                {
                      return this.brokerageFee_; 
                }
            }
            set
            {
                if (this.brokerageFee_ != value)
                {
                    this.brokerageFee_ = value;
                }
            }
        }
        #endregion
        
        public string brokerageFeeIDRef_ { get; set; }
        #region BrokerNotes_
        private XsdTypeString brokerNotes_;
        public XsdTypeString BrokerNotes_
        {
            get
            {
                if (this.brokerNotes_ != null)
                {
                    return this.brokerNotes_; 
                }
                else if (this.brokerNotesIDRef_ != null)
                {
                    brokerNotes_ = IDManager.getID(brokerNotesIDRef_) as XsdTypeString;
                    return this.brokerNotes_; 
                }
                else
                {
                      return this.brokerNotes_; 
                }
            }
            set
            {
                if (this.brokerNotes_ != value)
                {
                    this.brokerNotes_ = value;
                }
            }
        }
        #endregion
        
        public string brokerNotesIDRef_ { get; set; }
        
    
        
    
    }
    
}

