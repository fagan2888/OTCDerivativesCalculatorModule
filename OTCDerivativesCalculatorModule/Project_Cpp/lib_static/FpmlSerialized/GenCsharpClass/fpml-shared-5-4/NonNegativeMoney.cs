using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class NonNegativeMoney
    {
        public NonNegativeMoney(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList amountNodeList = xmlNode.SelectNodes("amount");
            if (amountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in amountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        amountIDRef = item.Attributes["id"].Name;
                        NonNegativeDecimal ob = NonNegativeDecimal();
                        IDManager.SetID(amountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        amountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        amount = new NonNegativeDecimal(item);
                    }
                }
            }
            
        
        }
        
    
        #region Amount
        private NonNegativeDecimal amount;
        public NonNegativeDecimal Amount
        {
            get
            {
                if (this.amount != null)
                {
                    return this.amount; 
                }
                else if (this.amountIDRef != null)
                {
                    amount = IDManager.getID(amountIDRef) as NonNegativeDecimal;
                    return this.amount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.amount != value)
                {
                    this.amount = value;
                }
            }
        }
        #endregion
        
        public string NonNegativeDecimalIDRef { get; set; }
        
    
        
    
    }
    
}

