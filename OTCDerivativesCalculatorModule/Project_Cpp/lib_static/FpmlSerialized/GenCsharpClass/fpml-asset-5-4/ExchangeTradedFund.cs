using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ExchangeTradedFund
    {
        public ExchangeTradedFund(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList fundManagerNodeList = xmlNode.SelectNodes("fundManager");
            if (fundManagerNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fundManagerNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fundManagerIDRef = item.Attributes["id"].Name;
                        XsdTypeString ob = XsdTypeString();
                        IDManager.SetID(fundManagerIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fundManagerIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fundManager = new XsdTypeString(item);
                    }
                }
            }
            
        
        }
        
    
        #region FundManager
        private XsdTypeString fundManager;
        public XsdTypeString FundManager
        {
            get
            {
                if (this.fundManager != null)
                {
                    return this.fundManager; 
                }
                else if (this.fundManagerIDRef != null)
                {
                    fundManager = IDManager.getID(fundManagerIDRef) as XsdTypeString;
                    return this.fundManager; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fundManager != value)
                {
                    this.fundManager = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeStringIDRef { get; set; }
        
    
        
    
    }
    
}

