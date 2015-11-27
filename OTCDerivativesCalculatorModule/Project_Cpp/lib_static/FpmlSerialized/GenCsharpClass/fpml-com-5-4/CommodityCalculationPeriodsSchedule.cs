using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CommodityCalculationPeriodsSchedule
    {
        public CommodityCalculationPeriodsSchedule(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList balanceOfFirstPeriodNodeList = xmlNode.SelectNodes("balanceOfFirstPeriod");
            if (balanceOfFirstPeriodNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in balanceOfFirstPeriodNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        balanceOfFirstPeriodIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(balanceOfFirstPeriodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        balanceOfFirstPeriodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        balanceOfFirstPeriod = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
        }
        
    
        #region BalanceOfFirstPeriod
        private XsdTypeBoolean balanceOfFirstPeriod;
        public XsdTypeBoolean BalanceOfFirstPeriod
        {
            get
            {
                if (this.balanceOfFirstPeriod != null)
                {
                    return this.balanceOfFirstPeriod; 
                }
                else if (this.balanceOfFirstPeriodIDRef != null)
                {
                    balanceOfFirstPeriod = IDManager.getID(balanceOfFirstPeriodIDRef) as XsdTypeBoolean;
                    return this.balanceOfFirstPeriod; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.balanceOfFirstPeriod != value)
                {
                    this.balanceOfFirstPeriod = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        
    
        
    
    }
    
}

