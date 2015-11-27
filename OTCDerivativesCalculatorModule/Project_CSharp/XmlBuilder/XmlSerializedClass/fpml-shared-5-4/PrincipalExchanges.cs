using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PrincipalExchanges : ISerialized
    {
        public PrincipalExchanges(XmlNode xmlNode)
        {
            XmlNode initialExchangeNode = xmlNode.SelectSingleNode("initialExchange");
            
            if (initialExchangeNode != null)
            {
                if (initialExchangeNode.Attributes["href"] != null || initialExchangeNode.Attributes["id"] != null) 
                {
                    if (initialExchangeNode.Attributes["id"] != null) 
                    {
                        initialExchangeIDRef_ = initialExchangeNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(initialExchangeNode);
                        IDManager.SetID(initialExchangeIDRef_, ob);
                    }
                    else if (initialExchangeNode.Attributes["href"] != null)
                    {
                        initialExchangeIDRef_ = initialExchangeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        initialExchange_ = new XsdTypeBoolean(initialExchangeNode);
                    }
                }
                else
                {
                    initialExchange_ = new XsdTypeBoolean(initialExchangeNode);
                }
            }
            
        
            XmlNode finalExchangeNode = xmlNode.SelectSingleNode("finalExchange");
            
            if (finalExchangeNode != null)
            {
                if (finalExchangeNode.Attributes["href"] != null || finalExchangeNode.Attributes["id"] != null) 
                {
                    if (finalExchangeNode.Attributes["id"] != null) 
                    {
                        finalExchangeIDRef_ = finalExchangeNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(finalExchangeNode);
                        IDManager.SetID(finalExchangeIDRef_, ob);
                    }
                    else if (finalExchangeNode.Attributes["href"] != null)
                    {
                        finalExchangeIDRef_ = finalExchangeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        finalExchange_ = new XsdTypeBoolean(finalExchangeNode);
                    }
                }
                else
                {
                    finalExchange_ = new XsdTypeBoolean(finalExchangeNode);
                }
            }
            
        
            XmlNode intermediateExchangeNode = xmlNode.SelectSingleNode("intermediateExchange");
            
            if (intermediateExchangeNode != null)
            {
                if (intermediateExchangeNode.Attributes["href"] != null || intermediateExchangeNode.Attributes["id"] != null) 
                {
                    if (intermediateExchangeNode.Attributes["id"] != null) 
                    {
                        intermediateExchangeIDRef_ = intermediateExchangeNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(intermediateExchangeNode);
                        IDManager.SetID(intermediateExchangeIDRef_, ob);
                    }
                    else if (intermediateExchangeNode.Attributes["href"] != null)
                    {
                        intermediateExchangeIDRef_ = intermediateExchangeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        intermediateExchange_ = new XsdTypeBoolean(intermediateExchangeNode);
                    }
                }
                else
                {
                    intermediateExchange_ = new XsdTypeBoolean(intermediateExchangeNode);
                }
            }
            
        
        }
        
    
        #region InitialExchange_
        private XsdTypeBoolean initialExchange_;
        public XsdTypeBoolean InitialExchange_
        {
            get
            {
                if (this.initialExchange_ != null)
                {
                    return this.initialExchange_; 
                }
                else if (this.initialExchangeIDRef_ != null)
                {
                    initialExchange_ = IDManager.getID(initialExchangeIDRef_) as XsdTypeBoolean;
                    return this.initialExchange_; 
                }
                else
                {
                      return this.initialExchange_; 
                }
            }
            set
            {
                if (this.initialExchange_ != value)
                {
                    this.initialExchange_ = value;
                }
            }
        }
        #endregion
        
        public string initialExchangeIDRef_ { get; set; }
        #region FinalExchange_
        private XsdTypeBoolean finalExchange_;
        public XsdTypeBoolean FinalExchange_
        {
            get
            {
                if (this.finalExchange_ != null)
                {
                    return this.finalExchange_; 
                }
                else if (this.finalExchangeIDRef_ != null)
                {
                    finalExchange_ = IDManager.getID(finalExchangeIDRef_) as XsdTypeBoolean;
                    return this.finalExchange_; 
                }
                else
                {
                      return this.finalExchange_; 
                }
            }
            set
            {
                if (this.finalExchange_ != value)
                {
                    this.finalExchange_ = value;
                }
            }
        }
        #endregion
        
        public string finalExchangeIDRef_ { get; set; }
        #region IntermediateExchange_
        private XsdTypeBoolean intermediateExchange_;
        public XsdTypeBoolean IntermediateExchange_
        {
            get
            {
                if (this.intermediateExchange_ != null)
                {
                    return this.intermediateExchange_; 
                }
                else if (this.intermediateExchangeIDRef_ != null)
                {
                    intermediateExchange_ = IDManager.getID(intermediateExchangeIDRef_) as XsdTypeBoolean;
                    return this.intermediateExchange_; 
                }
                else
                {
                      return this.intermediateExchange_; 
                }
            }
            set
            {
                if (this.intermediateExchange_ != value)
                {
                    this.intermediateExchange_ = value;
                }
            }
        }
        #endregion
        
        public string intermediateExchangeIDRef_ { get; set; }
        
    
        
    
    }
    
}

