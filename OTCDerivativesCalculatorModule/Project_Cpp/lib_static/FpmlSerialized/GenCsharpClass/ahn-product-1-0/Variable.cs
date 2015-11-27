using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Variable
    {
        public Variable(XmlNode xmlNode)
        {
            XmlNodeList symbolNameNodeList = xmlNode.SelectNodes("symbolName");
            if (symbolNameNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in symbolNameNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        symbolNameIDRef = item.Attributes["id"].Name;
                        XsdTypeToken ob = XsdTypeToken();
                        IDManager.SetID(symbolNameIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        symbolNameIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        symbolName = new XsdTypeToken(item);
                    }
                }
            }
            
        
        }
        
    
        #region SymbolName
        private XsdTypeToken symbolName;
        public XsdTypeToken SymbolName
        {
            get
            {
                if (this.symbolName != null)
                {
                    return this.symbolName; 
                }
                else if (this.symbolNameIDRef != null)
                {
                    symbolName = IDManager.getID(symbolNameIDRef) as XsdTypeToken;
                    return this.symbolName; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.symbolName != value)
                {
                    this.symbolName = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeTokenIDRef { get; set; }
        
    
        
    
    }
    
}

