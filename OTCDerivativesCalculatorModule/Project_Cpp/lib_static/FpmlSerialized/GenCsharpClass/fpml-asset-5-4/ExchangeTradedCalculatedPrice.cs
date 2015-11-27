using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ExchangeTradedCalculatedPrice
    {
        public ExchangeTradedCalculatedPrice(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList constituentExchangeIdNodeList = xmlNode.SelectNodes("constituentExchangeId");
            
            foreach (XmlNode item in constituentExchangeIdNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        constituentExchangeIdIDRef = item.Attributes["id"].Name;
                        List<ExchangeId> ob = new List<ExchangeId>();
                        ob.Add(new ExchangeId(item));
                        IDManager.SetID(constituentExchangeIdIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        constituentExchangeIdIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    constituentExchangeId.Add(new ExchangeId(item));
                    }
                }
            }
            
        
        }
        
    
        #region ConstituentExchangeId
        private List<ExchangeId> constituentExchangeId;
        public List<ExchangeId> ConstituentExchangeId
        {
            get
            {
                if (this.constituentExchangeId != null)
                {
                    return this.constituentExchangeId; 
                }
                else if (this.constituentExchangeIdIDRef != null)
                {
                    constituentExchangeId = IDManager.getID(constituentExchangeIdIDRef) as List<ExchangeId>;
                    return this.constituentExchangeId; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.constituentExchangeId != value)
                {
                    this.constituentExchangeId = value;
                }
            }
        }
        #endregion
        
        public string ExchangeIdIDRef { get; set; }
        
    
        
    
    }
    
}

