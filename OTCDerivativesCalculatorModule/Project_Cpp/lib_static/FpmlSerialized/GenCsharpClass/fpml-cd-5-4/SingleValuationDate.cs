using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class SingleValuationDate
    {
        public SingleValuationDate(XmlNode xmlNode)
        {
            XmlNodeList businessDaysNodeList = xmlNode.SelectNodes("businessDays");
            if (businessDaysNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in businessDaysNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        businessDaysIDRef = item.Attributes["id"].Name;
                        XsdTypeNonNegativeInteger ob = XsdTypeNonNegativeInteger();
                        IDManager.SetID(businessDaysIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        businessDaysIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        businessDays = new XsdTypeNonNegativeInteger(item);
                    }
                }
            }
            
        
        }
        
    
        #region BusinessDays
        private XsdTypeNonNegativeInteger businessDays;
        public XsdTypeNonNegativeInteger BusinessDays
        {
            get
            {
                if (this.businessDays != null)
                {
                    return this.businessDays; 
                }
                else if (this.businessDaysIDRef != null)
                {
                    businessDays = IDManager.getID(businessDaysIDRef) as XsdTypeNonNegativeInteger;
                    return this.businessDays; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.businessDays != value)
                {
                    this.businessDays = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeNonNegativeIntegerIDRef { get; set; }
        
    
        
    
    }
    
}

