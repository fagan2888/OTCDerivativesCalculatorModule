using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Variable : ISerialized
    {
        public Variable(XmlNode xmlNode)
        {
            XmlNode symbolNameNode = xmlNode.SelectSingleNode("symbolName");
            
            if (symbolNameNode != null)
            {
                if (symbolNameNode.Attributes["href"] != null || symbolNameNode.Attributes["id"] != null) 
                {
                    if (symbolNameNode.Attributes["id"] != null) 
                    {
                        symbolNameIDRef_ = symbolNameNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(symbolNameNode);
                        IDManager.SetID(symbolNameIDRef_, ob);
                    }
                    else if (symbolNameNode.Attributes["href"] != null)
                    {
                        symbolNameIDRef_ = symbolNameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        symbolName_ = new XsdTypeToken(symbolNameNode);
                    }
                }
                else
                {
                    symbolName_ = new XsdTypeToken(symbolNameNode);
                }
            }
            
        
        }
        
    
        #region SymbolName_
        private XsdTypeToken symbolName_;
        public XsdTypeToken SymbolName_
        {
            get
            {
                if (this.symbolName_ != null)
                {
                    return this.symbolName_; 
                }
                else if (this.symbolNameIDRef_ != null)
                {
                    symbolName_ = IDManager.getID(symbolNameIDRef_) as XsdTypeToken;
                    return this.symbolName_; 
                }
                else
                {
                      return this.symbolName_; 
                }
            }
            set
            {
                if (this.symbolName_ != value)
                {
                    this.symbolName_ = value;
                }
            }
        }
        #endregion
        
        public string symbolNameIDRef_ { get; set; }
        
    
        
    
    }
    
}

