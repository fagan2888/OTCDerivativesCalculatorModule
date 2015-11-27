using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class DividendAdjustment
    {
        public DividendAdjustment(XmlNode xmlNode)
        {
            XmlNodeList dividendPeriodNodeList = xmlNode.SelectNodes("dividendPeriod");
            
            foreach (XmlNode item in dividendPeriodNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dividendPeriodIDRef = item.Attributes["id"].Name;
                        List<DividendPeriodDividend> ob = new List<DividendPeriodDividend>();
                        ob.Add(new DividendPeriodDividend(item));
                        IDManager.SetID(dividendPeriodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dividendPeriodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    dividendPeriod.Add(new DividendPeriodDividend(item));
                    }
                }
            }
            
        
        }
        
    
        #region DividendPeriod
        private List<DividendPeriodDividend> dividendPeriod;
        public List<DividendPeriodDividend> DividendPeriod
        {
            get
            {
                if (this.dividendPeriod != null)
                {
                    return this.dividendPeriod; 
                }
                else if (this.dividendPeriodIDRef != null)
                {
                    dividendPeriod = IDManager.getID(dividendPeriodIDRef) as List<DividendPeriodDividend>;
                    return this.dividendPeriod; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dividendPeriod != value)
                {
                    this.dividendPeriod = value;
                }
            }
        }
        #endregion
        
        public string DividendPeriodDividendIDRef { get; set; }
        
    
        
    
    }
    
}

