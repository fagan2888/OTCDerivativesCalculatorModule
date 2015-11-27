using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class OptionNumericStrike
    {
        public OptionNumericStrike(XmlNode xmlNode)
        {
            XmlNodeList strikePriceNodeList = xmlNode.SelectNodes("strikePrice");
            if (strikePriceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in strikePriceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        strikePriceIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(strikePriceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        strikePriceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        strikePrice = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList strikePercentageNodeList = xmlNode.SelectNodes("strikePercentage");
            if (strikePercentageNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in strikePercentageNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        strikePercentageIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(strikePercentageIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        strikePercentageIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        strikePercentage = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
        }
        
    
        #region StrikePrice
        private XsdTypeDecimal strikePrice;
        public XsdTypeDecimal StrikePrice
        {
            get
            {
                if (this.strikePrice != null)
                {
                    return this.strikePrice; 
                }
                else if (this.strikePriceIDRef != null)
                {
                    strikePrice = IDManager.getID(strikePriceIDRef) as XsdTypeDecimal;
                    return this.strikePrice; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.strikePrice != value)
                {
                    this.strikePrice = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region StrikePercentage
        private XsdTypeDecimal strikePercentage;
        public XsdTypeDecimal StrikePercentage
        {
            get
            {
                if (this.strikePercentage != null)
                {
                    return this.strikePercentage; 
                }
                else if (this.strikePercentageIDRef != null)
                {
                    strikePercentage = IDManager.getID(strikePercentageIDRef) as XsdTypeDecimal;
                    return this.strikePercentage; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.strikePercentage != value)
                {
                    this.strikePercentage = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

