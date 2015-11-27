using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ElectricityDeliveryPeriods
    {
        public ElectricityDeliveryPeriods(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList settlementPeriodsNodeList = xmlNode.SelectNodes("settlementPeriods");
            
            foreach (XmlNode item in settlementPeriodsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        settlementPeriodsIDRef = item.Attributes["id"].Name;
                        List<SettlementPeriods> ob = new List<SettlementPeriods>();
                        ob.Add(new SettlementPeriods(item));
                        IDManager.SetID(settlementPeriodsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        settlementPeriodsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    settlementPeriods.Add(new SettlementPeriods(item));
                    }
                }
            }
            
        
        }
        
    
        #region SettlementPeriods
        private List<SettlementPeriods> settlementPeriods;
        public List<SettlementPeriods> SettlementPeriods
        {
            get
            {
                if (this.settlementPeriods != null)
                {
                    return this.settlementPeriods; 
                }
                else if (this.settlementPeriodsIDRef != null)
                {
                    settlementPeriods = IDManager.getID(settlementPeriodsIDRef) as List<SettlementPeriods>;
                    return this.settlementPeriods; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.settlementPeriods != value)
                {
                    this.settlementPeriods = value;
                }
            }
        }
        #endregion
        
        public string SettlementPeriodsIDRef { get; set; }
        
    
        
    
    }
    
}

