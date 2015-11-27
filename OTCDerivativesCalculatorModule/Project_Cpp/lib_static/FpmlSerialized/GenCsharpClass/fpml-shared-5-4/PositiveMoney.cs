using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class PositiveMoney
    {
        public PositiveMoney(XmlNode xmlNode)
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
                        PositiveDecimal ob = PositiveDecimal();
                        IDManager.SetID(amountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        amountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        amount = new PositiveDecimal(item);
                    }
                }
            }
            
        
        }
        
    
        #region Amount
        private PositiveDecimal amount;
        public PositiveDecimal Amount
        {
            get
            {
                if (this.amount != null)
                {
                    return this.amount; 
                }
                else if (this.amountIDRef != null)
                {
                    amount = IDManager.getID(amountIDRef) as PositiveDecimal;
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
        
        public string PositiveDecimalIDRef { get; set; }
        
    
        
    
    }
    
}

