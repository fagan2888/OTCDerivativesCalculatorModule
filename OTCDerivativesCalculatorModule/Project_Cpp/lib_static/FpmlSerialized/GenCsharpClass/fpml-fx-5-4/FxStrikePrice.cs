using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class FxStrikePrice
    {
        public FxStrikePrice(XmlNode xmlNode)
        {
            XmlNodeList rateNodeList = xmlNode.SelectNodes("rate");
            if (rateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in rateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        rateIDRef = item.Attributes["id"].Name;
                        PositiveDecimal ob = PositiveDecimal();
                        IDManager.SetID(rateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        rateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        rate = new PositiveDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList strikeQuoteBasisNodeList = xmlNode.SelectNodes("strikeQuoteBasis");
            if (strikeQuoteBasisNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in strikeQuoteBasisNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        strikeQuoteBasisIDRef = item.Attributes["id"].Name;
                        StrikeQuoteBasisEnum ob = StrikeQuoteBasisEnum();
                        IDManager.SetID(strikeQuoteBasisIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        strikeQuoteBasisIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        strikeQuoteBasis = new StrikeQuoteBasisEnum(item);
                    }
                }
            }
            
        
        }
        
    
        #region Rate
        private PositiveDecimal rate;
        public PositiveDecimal Rate
        {
            get
            {
                if (this.rate != null)
                {
                    return this.rate; 
                }
                else if (this.rateIDRef != null)
                {
                    rate = IDManager.getID(rateIDRef) as PositiveDecimal;
                    return this.rate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.rate != value)
                {
                    this.rate = value;
                }
            }
        }
        #endregion
        
        public string PositiveDecimalIDRef { get; set; }
        #region StrikeQuoteBasis
        private StrikeQuoteBasisEnum strikeQuoteBasis;
        public StrikeQuoteBasisEnum StrikeQuoteBasis
        {
            get
            {
                if (this.strikeQuoteBasis != null)
                {
                    return this.strikeQuoteBasis; 
                }
                else if (this.strikeQuoteBasisIDRef != null)
                {
                    strikeQuoteBasis = IDManager.getID(strikeQuoteBasisIDRef) as StrikeQuoteBasisEnum;
                    return this.strikeQuoteBasis; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.strikeQuoteBasis != value)
                {
                    this.strikeQuoteBasis = value;
                }
            }
        }
        #endregion
        
        public string StrikeQuoteBasisEnumIDRef { get; set; }
        
    
        
    
    }
    
}

