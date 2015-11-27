using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class StrategyComponentIdentification
    {
        public StrategyComponentIdentification(XmlNode xmlNode)
        {
            XmlNodeList tradeIdentifierReferenceNodeList = xmlNode.SelectNodes("tradeIdentifierReference");
            if (tradeIdentifierReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in tradeIdentifierReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        tradeIdentifierReferenceIDRef = item.Attributes["id"].Name;
                        PartyTradeIdentifierReference ob = PartyTradeIdentifierReference();
                        IDManager.SetID(tradeIdentifierReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        tradeIdentifierReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        tradeIdentifierReference = new PartyTradeIdentifierReference(item);
                    }
                }
            }
            
        
            XmlNodeList componentReferenceNodeList = xmlNode.SelectNodes("componentReference");
            if (componentReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in componentReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        componentReferenceIDRef = item.Attributes["id"].Name;
                        ProductReference ob = ProductReference();
                        IDManager.SetID(componentReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        componentReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        componentReference = new ProductReference(item);
                    }
                }
            }
            
        
        }
        
    
        #region TradeIdentifierReference
        private PartyTradeIdentifierReference tradeIdentifierReference;
        public PartyTradeIdentifierReference TradeIdentifierReference
        {
            get
            {
                if (this.tradeIdentifierReference != null)
                {
                    return this.tradeIdentifierReference; 
                }
                else if (this.tradeIdentifierReferenceIDRef != null)
                {
                    tradeIdentifierReference = IDManager.getID(tradeIdentifierReferenceIDRef) as PartyTradeIdentifierReference;
                    return this.tradeIdentifierReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.tradeIdentifierReference != value)
                {
                    this.tradeIdentifierReference = value;
                }
            }
        }
        #endregion
        
        public string PartyTradeIdentifierReferenceIDRef { get; set; }
        #region ComponentReference
        private ProductReference componentReference;
        public ProductReference ComponentReference
        {
            get
            {
                if (this.componentReference != null)
                {
                    return this.componentReference; 
                }
                else if (this.componentReferenceIDRef != null)
                {
                    componentReference = IDManager.getID(componentReferenceIDRef) as ProductReference;
                    return this.componentReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.componentReference != value)
                {
                    this.componentReference = value;
                }
            }
        }
        #endregion
        
        public string ProductReferenceIDRef { get; set; }
        
    
        
    
    }
    
}

