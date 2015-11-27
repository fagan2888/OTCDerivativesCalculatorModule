using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class DividendPeriodDividend
    {
        public DividendPeriodDividend(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList dividendNodeList = xmlNode.SelectNodes("dividend");
            if (dividendNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dividendNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dividendIDRef = item.Attributes["id"].Name;
                        NonNegativeMoney ob = NonNegativeMoney();
                        IDManager.SetID(dividendIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dividendIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        dividend = new NonNegativeMoney(item);
                    }
                }
            }
            
        
            XmlNodeList multiplierNodeList = xmlNode.SelectNodes("multiplier");
            if (multiplierNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in multiplierNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        multiplierIDRef = item.Attributes["id"].Name;
                        PositiveDecimal ob = PositiveDecimal();
                        IDManager.SetID(multiplierIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        multiplierIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        multiplier = new PositiveDecimal(item);
                    }
                }
            }
            
        
        }
        
    
        #region Dividend
        private NonNegativeMoney dividend;
        public NonNegativeMoney Dividend
        {
            get
            {
                if (this.dividend != null)
                {
                    return this.dividend; 
                }
                else if (this.dividendIDRef != null)
                {
                    dividend = IDManager.getID(dividendIDRef) as NonNegativeMoney;
                    return this.dividend; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dividend != value)
                {
                    this.dividend = value;
                }
            }
        }
        #endregion
        
        public string NonNegativeMoneyIDRef { get; set; }
        #region Multiplier
        private PositiveDecimal multiplier;
        public PositiveDecimal Multiplier
        {
            get
            {
                if (this.multiplier != null)
                {
                    return this.multiplier; 
                }
                else if (this.multiplierIDRef != null)
                {
                    multiplier = IDManager.getID(multiplierIDRef) as PositiveDecimal;
                    return this.multiplier; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.multiplier != value)
                {
                    this.multiplier = value;
                }
            }
        }
        #endregion
        
        public string PositiveDecimalIDRef { get; set; }
        
    
        
    
    }
    
}

