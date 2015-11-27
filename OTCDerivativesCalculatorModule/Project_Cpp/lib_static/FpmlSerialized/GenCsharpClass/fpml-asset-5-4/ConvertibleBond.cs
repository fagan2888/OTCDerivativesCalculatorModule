using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ConvertibleBond
    {
        public ConvertibleBond(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList underlyingEquityNodeList = xmlNode.SelectNodes("underlyingEquity");
            if (underlyingEquityNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in underlyingEquityNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        underlyingEquityIDRef = item.Attributes["id"].Name;
                        EquityAsset ob = EquityAsset();
                        IDManager.SetID(underlyingEquityIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        underlyingEquityIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        underlyingEquity = new EquityAsset(item);
                    }
                }
            }
            
        
            XmlNodeList redemptionDateNodeList = xmlNode.SelectNodes("redemptionDate");
            if (redemptionDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in redemptionDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        redemptionDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(redemptionDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        redemptionDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        redemptionDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
        }
        
    
        #region UnderlyingEquity
        private EquityAsset underlyingEquity;
        public EquityAsset UnderlyingEquity
        {
            get
            {
                if (this.underlyingEquity != null)
                {
                    return this.underlyingEquity; 
                }
                else if (this.underlyingEquityIDRef != null)
                {
                    underlyingEquity = IDManager.getID(underlyingEquityIDRef) as EquityAsset;
                    return this.underlyingEquity; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.underlyingEquity != value)
                {
                    this.underlyingEquity = value;
                }
            }
        }
        #endregion
        
        public string EquityAssetIDRef { get; set; }
        #region RedemptionDate
        private XsdTypeDate redemptionDate;
        public XsdTypeDate RedemptionDate
        {
            get
            {
                if (this.redemptionDate != null)
                {
                    return this.redemptionDate; 
                }
                else if (this.redemptionDateIDRef != null)
                {
                    redemptionDate = IDManager.getID(redemptionDateIDRef) as XsdTypeDate;
                    return this.redemptionDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.redemptionDate != value)
                {
                    this.redemptionDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        
    
        
    
    }
    
}

