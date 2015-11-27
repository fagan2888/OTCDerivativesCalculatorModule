using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class NotionalValue
    {
        public NotionalValue(XmlNode xmlNode)
        {
            XmlNodeList notionalAmountNodeList = xmlNode.SelectNodes("notionalAmount");
            if (notionalAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in notionalAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        notionalAmountIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(notionalAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        notionalAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        notionalAmount = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
        }
        
    
        #region NotionalAmount
        private XsdTypeDecimal notionalAmount;
        public XsdTypeDecimal NotionalAmount
        {
            get
            {
                if (this.notionalAmount != null)
                {
                    return this.notionalAmount; 
                }
                else if (this.notionalAmountIDRef != null)
                {
                    notionalAmount = IDManager.getID(notionalAmountIDRef) as XsdTypeDecimal;
                    return this.notionalAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.notionalAmount != value)
                {
                    this.notionalAmount = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        
    
        
    
    }
    
}

