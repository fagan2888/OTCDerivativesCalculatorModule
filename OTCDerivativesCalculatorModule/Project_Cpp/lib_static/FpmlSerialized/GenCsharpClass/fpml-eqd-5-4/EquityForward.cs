using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class EquityForward
    {
        public EquityForward(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList forwardPriceNodeList = xmlNode.SelectNodes("forwardPrice");
            if (forwardPriceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in forwardPriceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        forwardPriceIDRef = item.Attributes["id"].Name;
                        NonNegativeMoney ob = NonNegativeMoney();
                        IDManager.SetID(forwardPriceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        forwardPriceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        forwardPrice = new NonNegativeMoney(item);
                    }
                }
            }
            
        
        }
        
    
        #region ForwardPrice
        private NonNegativeMoney forwardPrice;
        public NonNegativeMoney ForwardPrice
        {
            get
            {
                if (this.forwardPrice != null)
                {
                    return this.forwardPrice; 
                }
                else if (this.forwardPriceIDRef != null)
                {
                    forwardPrice = IDManager.getID(forwardPriceIDRef) as NonNegativeMoney;
                    return this.forwardPrice; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.forwardPrice != value)
                {
                    this.forwardPrice = value;
                }
            }
        }
        #endregion
        
        public string NonNegativeMoneyIDRef { get; set; }
        
    
        
    
    }
    
}

