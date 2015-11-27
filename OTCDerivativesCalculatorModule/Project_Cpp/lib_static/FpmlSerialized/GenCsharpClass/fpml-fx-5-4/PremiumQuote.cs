using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class PremiumQuote
    {
        public PremiumQuote(XmlNode xmlNode)
        {
            XmlNodeList valueNodeList = xmlNode.SelectNodes("value");
            if (valueNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in valueNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        valueIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(valueIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        valueIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        value = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList quoteBasisNodeList = xmlNode.SelectNodes("quoteBasis");
            if (quoteBasisNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in quoteBasisNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        quoteBasisIDRef = item.Attributes["id"].Name;
                        PremiumQuoteBasisEnum ob = PremiumQuoteBasisEnum();
                        IDManager.SetID(quoteBasisIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        quoteBasisIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        quoteBasis = new PremiumQuoteBasisEnum(item);
                    }
                }
            }
            
        
        }
        
    
        #region Value
        private XsdTypeDecimal value;
        public XsdTypeDecimal Value
        {
            get
            {
                if (this.value != null)
                {
                    return this.value; 
                }
                else if (this.valueIDRef != null)
                {
                    value = IDManager.getID(valueIDRef) as XsdTypeDecimal;
                    return this.value; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.value != value)
                {
                    this.value = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region QuoteBasis
        private PremiumQuoteBasisEnum quoteBasis;
        public PremiumQuoteBasisEnum QuoteBasis
        {
            get
            {
                if (this.quoteBasis != null)
                {
                    return this.quoteBasis; 
                }
                else if (this.quoteBasisIDRef != null)
                {
                    quoteBasis = IDManager.getID(quoteBasisIDRef) as PremiumQuoteBasisEnum;
                    return this.quoteBasis; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.quoteBasis != value)
                {
                    this.quoteBasis = value;
                }
            }
        }
        #endregion
        
        public string PremiumQuoteBasisEnumIDRef { get; set; }
        
    
        
    
    }
    
}

