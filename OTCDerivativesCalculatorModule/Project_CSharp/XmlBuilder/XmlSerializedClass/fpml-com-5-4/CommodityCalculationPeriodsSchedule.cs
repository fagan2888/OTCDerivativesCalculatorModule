using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CommodityCalculationPeriodsSchedule : Frequency
    {
        public CommodityCalculationPeriodsSchedule(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode balanceOfFirstPeriodNode = xmlNode.SelectSingleNode("balanceOfFirstPeriod");
            
            if (balanceOfFirstPeriodNode != null)
            {
                if (balanceOfFirstPeriodNode.Attributes["href"] != null || balanceOfFirstPeriodNode.Attributes["id"] != null) 
                {
                    if (balanceOfFirstPeriodNode.Attributes["id"] != null) 
                    {
                        balanceOfFirstPeriodIDRef_ = balanceOfFirstPeriodNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(balanceOfFirstPeriodNode);
                        IDManager.SetID(balanceOfFirstPeriodIDRef_, ob);
                    }
                    else if (balanceOfFirstPeriodNode.Attributes["href"] != null)
                    {
                        balanceOfFirstPeriodIDRef_ = balanceOfFirstPeriodNode.Attributes["href"].Value;
                    }
                    else
                    {
                        balanceOfFirstPeriod_ = new XsdTypeBoolean(balanceOfFirstPeriodNode);
                    }
                }
                else
                {
                    balanceOfFirstPeriod_ = new XsdTypeBoolean(balanceOfFirstPeriodNode);
                }
            }
            
        
        }
        
    
        #region BalanceOfFirstPeriod_
        private XsdTypeBoolean balanceOfFirstPeriod_;
        public XsdTypeBoolean BalanceOfFirstPeriod_
        {
            get
            {
                if (this.balanceOfFirstPeriod_ != null)
                {
                    return this.balanceOfFirstPeriod_; 
                }
                else if (this.balanceOfFirstPeriodIDRef_ != null)
                {
                    balanceOfFirstPeriod_ = IDManager.getID(balanceOfFirstPeriodIDRef_) as XsdTypeBoolean;
                    return this.balanceOfFirstPeriod_; 
                }
                else
                {
                      return this.balanceOfFirstPeriod_; 
                }
            }
            set
            {
                if (this.balanceOfFirstPeriod_ != value)
                {
                    this.balanceOfFirstPeriod_ = value;
                }
            }
        }
        #endregion
        
        public string balanceOfFirstPeriodIDRef_ { get; set; }
        
    
        
    
    }
    
}

