using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class StrategyComponentIdentification : ISerialized
    {
        public StrategyComponentIdentification(XmlNode xmlNode)
        {
            XmlNode tradeIdentifierReferenceNode = xmlNode.SelectSingleNode("tradeIdentifierReference");
            
            if (tradeIdentifierReferenceNode != null)
            {
                if (tradeIdentifierReferenceNode.Attributes["href"] != null || tradeIdentifierReferenceNode.Attributes["id"] != null) 
                {
                    if (tradeIdentifierReferenceNode.Attributes["id"] != null) 
                    {
                        tradeIdentifierReferenceIDRef_ = tradeIdentifierReferenceNode.Attributes["id"].Value;
                        PartyTradeIdentifierReference ob = new PartyTradeIdentifierReference(tradeIdentifierReferenceNode);
                        IDManager.SetID(tradeIdentifierReferenceIDRef_, ob);
                    }
                    else if (tradeIdentifierReferenceNode.Attributes["href"] != null)
                    {
                        tradeIdentifierReferenceIDRef_ = tradeIdentifierReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        tradeIdentifierReference_ = new PartyTradeIdentifierReference(tradeIdentifierReferenceNode);
                    }
                }
                else
                {
                    tradeIdentifierReference_ = new PartyTradeIdentifierReference(tradeIdentifierReferenceNode);
                }
            }
            
        
            XmlNode componentReferenceNode = xmlNode.SelectSingleNode("componentReference");
            
            if (componentReferenceNode != null)
            {
                if (componentReferenceNode.Attributes["href"] != null || componentReferenceNode.Attributes["id"] != null) 
                {
                    if (componentReferenceNode.Attributes["id"] != null) 
                    {
                        componentReferenceIDRef_ = componentReferenceNode.Attributes["id"].Value;
                        ProductReference ob = new ProductReference(componentReferenceNode);
                        IDManager.SetID(componentReferenceIDRef_, ob);
                    }
                    else if (componentReferenceNode.Attributes["href"] != null)
                    {
                        componentReferenceIDRef_ = componentReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        componentReference_ = new ProductReference(componentReferenceNode);
                    }
                }
                else
                {
                    componentReference_ = new ProductReference(componentReferenceNode);
                }
            }
            
        
        }
        
    
        #region TradeIdentifierReference_
        private PartyTradeIdentifierReference tradeIdentifierReference_;
        public PartyTradeIdentifierReference TradeIdentifierReference_
        {
            get
            {
                if (this.tradeIdentifierReference_ != null)
                {
                    return this.tradeIdentifierReference_; 
                }
                else if (this.tradeIdentifierReferenceIDRef_ != null)
                {
                    tradeIdentifierReference_ = IDManager.getID(tradeIdentifierReferenceIDRef_) as PartyTradeIdentifierReference;
                    return this.tradeIdentifierReference_; 
                }
                else
                {
                      return this.tradeIdentifierReference_; 
                }
            }
            set
            {
                if (this.tradeIdentifierReference_ != value)
                {
                    this.tradeIdentifierReference_ = value;
                }
            }
        }
        #endregion
        
        public string tradeIdentifierReferenceIDRef_ { get; set; }
        #region ComponentReference_
        private ProductReference componentReference_;
        public ProductReference ComponentReference_
        {
            get
            {
                if (this.componentReference_ != null)
                {
                    return this.componentReference_; 
                }
                else if (this.componentReferenceIDRef_ != null)
                {
                    componentReference_ = IDManager.getID(componentReferenceIDRef_) as ProductReference;
                    return this.componentReference_; 
                }
                else
                {
                      return this.componentReference_; 
                }
            }
            set
            {
                if (this.componentReference_ != value)
                {
                    this.componentReference_ = value;
                }
            }
        }
        #endregion
        
        public string componentReferenceIDRef_ { get; set; }
        
    
        
    
    }
    
}

