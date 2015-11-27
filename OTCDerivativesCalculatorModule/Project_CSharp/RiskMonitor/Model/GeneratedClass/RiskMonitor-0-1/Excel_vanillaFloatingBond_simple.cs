using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_vanillaFloatingBond_simple : ISerialized
    {
        public Excel_vanillaFloatingBond_simple() { }
        public Excel_vanillaFloatingBond_simple(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode maturityNode = xmlNode.SelectSingleNode("maturity");
            
            if (maturityNode != null)
            {
                if (maturityNode.Attributes["href"] != null || maturityNode.Attributes["id"] != null) 
                {
                    if (maturityNode.Attributes["id"] != null) 
                    {
                        maturityIDRef_ = maturityNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(maturityNode);
                        IDManager.SetID(maturityIDRef_, ob);
                    }
                    else if (maturityNode.Attributes["href"] != null)
                    {
                        maturityIDRef_ = maturityNode.Attributes["href"].Value;
                    }
                    else
                    {
                        maturity_ = new XsdTypeToken(maturityNode);
                    }
                }
                else
                {
                    maturity_ = new XsdTypeToken(maturityNode);
                }
            }
            
        
            XmlNode maturityPeriodNode = xmlNode.SelectSingleNode("maturityPeriod");
            
            if (maturityPeriodNode != null)
            {
                if (maturityPeriodNode.Attributes["href"] != null || maturityPeriodNode.Attributes["id"] != null) 
                {
                    if (maturityPeriodNode.Attributes["id"] != null) 
                    {
                        maturityPeriodIDRef_ = maturityPeriodNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(maturityPeriodNode);
                        IDManager.SetID(maturityPeriodIDRef_, ob);
                    }
                    else if (maturityPeriodNode.Attributes["href"] != null)
                    {
                        maturityPeriodIDRef_ = maturityPeriodNode.Attributes["href"].Value;
                    }
                    else
                    {
                        maturityPeriod_ = new XsdTypeToken(maturityPeriodNode);
                    }
                }
                else
                {
                    maturityPeriod_ = new XsdTypeToken(maturityPeriodNode);
                }
            }
            
        
            XmlNode couponTenorNode = xmlNode.SelectSingleNode("couponTenor");
            
            if (couponTenorNode != null)
            {
                if (couponTenorNode.Attributes["href"] != null || couponTenorNode.Attributes["id"] != null) 
                {
                    if (couponTenorNode.Attributes["id"] != null) 
                    {
                        couponTenorIDRef_ = couponTenorNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(couponTenorNode);
                        IDManager.SetID(couponTenorIDRef_, ob);
                    }
                    else if (couponTenorNode.Attributes["href"] != null)
                    {
                        couponTenorIDRef_ = couponTenorNode.Attributes["href"].Value;
                    }
                    else
                    {
                        couponTenor_ = new XsdTypeToken(couponTenorNode);
                    }
                }
                else
                {
                    couponTenor_ = new XsdTypeToken(couponTenorNode);
                }
            }
            
        
            XmlNode couponTenorPeriodNode = xmlNode.SelectSingleNode("couponTenorPeriod");
            
            if (couponTenorPeriodNode != null)
            {
                if (couponTenorPeriodNode.Attributes["href"] != null || couponTenorPeriodNode.Attributes["id"] != null) 
                {
                    if (couponTenorPeriodNode.Attributes["id"] != null) 
                    {
                        couponTenorPeriodIDRef_ = couponTenorPeriodNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(couponTenorPeriodNode);
                        IDManager.SetID(couponTenorPeriodIDRef_, ob);
                    }
                    else if (couponTenorPeriodNode.Attributes["href"] != null)
                    {
                        couponTenorPeriodIDRef_ = couponTenorPeriodNode.Attributes["href"].Value;
                    }
                    else
                    {
                        couponTenorPeriod_ = new XsdTypeToken(couponTenorPeriodNode);
                    }
                }
                else
                {
                    couponTenorPeriod_ = new XsdTypeToken(couponTenorPeriodNode);
                }
            }
            
        
            XmlNodeList excel_vanillaFloatingBond_subScheduleNodeList = xmlNode.SelectNodes("excel_vanillaFloatingBond_subSchedule");
            
            if (excel_vanillaFloatingBond_subScheduleNodeList != null)
            {
                this.excel_vanillaFloatingBond_subSchedule_ = new List<Excel_vanillaFloatingBond_subSchedule>();
                foreach (XmlNode item in excel_vanillaFloatingBond_subScheduleNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            excel_vanillaFloatingBond_subScheduleIDRef_ = item.Attributes["id"].Value;
                            excel_vanillaFloatingBond_subSchedule_.Add(new Excel_vanillaFloatingBond_subSchedule(item));
                            IDManager.SetID(excel_vanillaFloatingBond_subScheduleIDRef_, excel_vanillaFloatingBond_subSchedule_[excel_vanillaFloatingBond_subSchedule_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            excel_vanillaFloatingBond_subScheduleIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        excel_vanillaFloatingBond_subSchedule_.Add(new Excel_vanillaFloatingBond_subSchedule(item));
                        }
                    }
                    else
                    {
                        excel_vanillaFloatingBond_subSchedule_.Add(new Excel_vanillaFloatingBond_subSchedule(item));
                    }
                }
            }
            
        
            XmlNode gearingNode = xmlNode.SelectSingleNode("gearing");
            
            if (gearingNode != null)
            {
                if (gearingNode.Attributes["href"] != null || gearingNode.Attributes["id"] != null) 
                {
                    if (gearingNode.Attributes["id"] != null) 
                    {
                        gearingIDRef_ = gearingNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(gearingNode);
                        IDManager.SetID(gearingIDRef_, ob);
                    }
                    else if (gearingNode.Attributes["href"] != null)
                    {
                        gearingIDRef_ = gearingNode.Attributes["href"].Value;
                    }
                    else
                    {
                        gearing_ = new XsdTypeToken(gearingNode);
                    }
                }
                else
                {
                    gearing_ = new XsdTypeToken(gearingNode);
                }
            }
            
        
            XmlNode spreadNode = xmlNode.SelectSingleNode("spread");
            
            if (spreadNode != null)
            {
                if (spreadNode.Attributes["href"] != null || spreadNode.Attributes["id"] != null) 
                {
                    if (spreadNode.Attributes["id"] != null) 
                    {
                        spreadIDRef_ = spreadNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(spreadNode);
                        IDManager.SetID(spreadIDRef_, ob);
                    }
                    else if (spreadNode.Attributes["href"] != null)
                    {
                        spreadIDRef_ = spreadNode.Attributes["href"].Value;
                    }
                    else
                    {
                        spread_ = new XsdTypeToken(spreadNode);
                    }
                }
                else
                {
                    spread_ = new XsdTypeToken(spreadNode);
                }
            }
            
        
            XmlNode settlementDaysNode = xmlNode.SelectSingleNode("settlementDays");
            
            if (settlementDaysNode != null)
            {
                if (settlementDaysNode.Attributes["href"] != null || settlementDaysNode.Attributes["id"] != null) 
                {
                    if (settlementDaysNode.Attributes["id"] != null) 
                    {
                        settlementDaysIDRef_ = settlementDaysNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(settlementDaysNode);
                        IDManager.SetID(settlementDaysIDRef_, ob);
                    }
                    else if (settlementDaysNode.Attributes["href"] != null)
                    {
                        settlementDaysIDRef_ = settlementDaysNode.Attributes["href"].Value;
                    }
                    else
                    {
                        settlementDays_ = new XsdTypeToken(settlementDaysNode);
                    }
                }
                else
                {
                    settlementDays_ = new XsdTypeToken(settlementDaysNode);
                }
            }
            
        
        }
        
    
        #region Maturity_
        private XsdTypeToken maturity_;
        public XsdTypeToken Maturity_
        {
            get
            {
                if (this.maturity_ != null)
                {
                    return this.maturity_; 
                }
                else if (this.maturityIDRef_ != null)
                {
                    maturity_ = IDManager.getID(maturityIDRef_) as XsdTypeToken;
                    return this.maturity_; 
                }
                else
                {
                    throw new Exception( "maturity_Node no exist!");
                }
            }
            set
            {
                if (this.maturity_ != value)
                {
                    this.maturity_ = value;
                }
            }
        }
        #endregion
        
        public string maturityIDRef_ { get; set; }
        #region MaturityPeriod_
        private XsdTypeToken maturityPeriod_;
        public XsdTypeToken MaturityPeriod_
        {
            get
            {
                if (this.maturityPeriod_ != null)
                {
                    return this.maturityPeriod_; 
                }
                else if (this.maturityPeriodIDRef_ != null)
                {
                    maturityPeriod_ = IDManager.getID(maturityPeriodIDRef_) as XsdTypeToken;
                    return this.maturityPeriod_; 
                }
                else
                {
                    throw new Exception( "maturityPeriod_Node no exist!");
                }
            }
            set
            {
                if (this.maturityPeriod_ != value)
                {
                    this.maturityPeriod_ = value;
                }
            }
        }
        #endregion
        
        public string maturityPeriodIDRef_ { get; set; }
        #region CouponTenor_
        private XsdTypeToken couponTenor_;
        public XsdTypeToken CouponTenor_
        {
            get
            {
                if (this.couponTenor_ != null)
                {
                    return this.couponTenor_; 
                }
                else if (this.couponTenorIDRef_ != null)
                {
                    couponTenor_ = IDManager.getID(couponTenorIDRef_) as XsdTypeToken;
                    return this.couponTenor_; 
                }
                else
                {
                    throw new Exception( "couponTenor_Node no exist!");
                }
            }
            set
            {
                if (this.couponTenor_ != value)
                {
                    this.couponTenor_ = value;
                }
            }
        }
        #endregion
        
        public string couponTenorIDRef_ { get; set; }
        #region CouponTenorPeriod_
        private XsdTypeToken couponTenorPeriod_;
        public XsdTypeToken CouponTenorPeriod_
        {
            get
            {
                if (this.couponTenorPeriod_ != null)
                {
                    return this.couponTenorPeriod_; 
                }
                else if (this.couponTenorPeriodIDRef_ != null)
                {
                    couponTenorPeriod_ = IDManager.getID(couponTenorPeriodIDRef_) as XsdTypeToken;
                    return this.couponTenorPeriod_; 
                }
                else
                {
                    throw new Exception( "couponTenorPeriod_Node no exist!");
                }
            }
            set
            {
                if (this.couponTenorPeriod_ != value)
                {
                    this.couponTenorPeriod_ = value;
                }
            }
        }
        #endregion
        
        public string couponTenorPeriodIDRef_ { get; set; }
        #region Excel_vanillaFloatingBond_subSchedule_
        private List<Excel_vanillaFloatingBond_subSchedule> excel_vanillaFloatingBond_subSchedule_;
        public List<Excel_vanillaFloatingBond_subSchedule> Excel_vanillaFloatingBond_subSchedule_
        {
            get
            {
                if (this.excel_vanillaFloatingBond_subSchedule_ != null)
                {
                    return this.excel_vanillaFloatingBond_subSchedule_; 
                }
                else if (this.excel_vanillaFloatingBond_subScheduleIDRef_ != null)
                {
                    return this.excel_vanillaFloatingBond_subSchedule_; 
                }
                else
                {
                    throw new Exception( "excel_vanillaFloatingBond_subSchedule_Node no exist!");
                }
            }
            set
            {
                if (this.excel_vanillaFloatingBond_subSchedule_ != value)
                {
                    this.excel_vanillaFloatingBond_subSchedule_ = value;
                }
            }
        }
        #endregion
        
        public string excel_vanillaFloatingBond_subScheduleIDRef_ { get; set; }
        #region Gearing_
        private XsdTypeToken gearing_;
        public XsdTypeToken Gearing_
        {
            get
            {
                if (this.gearing_ != null)
                {
                    return this.gearing_; 
                }
                else if (this.gearingIDRef_ != null)
                {
                    gearing_ = IDManager.getID(gearingIDRef_) as XsdTypeToken;
                    return this.gearing_; 
                }
                else
                {
                    throw new Exception( "gearing_Node no exist!");
                }
            }
            set
            {
                if (this.gearing_ != value)
                {
                    this.gearing_ = value;
                }
            }
        }
        #endregion
        
        public string gearingIDRef_ { get; set; }
        #region Spread_
        private XsdTypeToken spread_;
        public XsdTypeToken Spread_
        {
            get
            {
                if (this.spread_ != null)
                {
                    return this.spread_; 
                }
                else if (this.spreadIDRef_ != null)
                {
                    spread_ = IDManager.getID(spreadIDRef_) as XsdTypeToken;
                    return this.spread_; 
                }
                else
                {
                    throw new Exception( "spread_Node no exist!");
                }
            }
            set
            {
                if (this.spread_ != value)
                {
                    this.spread_ = value;
                }
            }
        }
        #endregion
        
        public string spreadIDRef_ { get; set; }
        #region SettlementDays_
        private XsdTypeToken settlementDays_;
        public XsdTypeToken SettlementDays_
        {
            get
            {
                if (this.settlementDays_ != null)
                {
                    return this.settlementDays_; 
                }
                else if (this.settlementDaysIDRef_ != null)
                {
                    settlementDays_ = IDManager.getID(settlementDaysIDRef_) as XsdTypeToken;
                    return this.settlementDays_; 
                }
                else
                {
                    throw new Exception( "settlementDays_Node no exist!");
                }
            }
            set
            {
                if (this.settlementDays_ != value)
                {
                    this.settlementDays_ = value;
                }
            }
        }
        #endregion
        
        public string settlementDaysIDRef_ { get; set; }
        
    
        
    
    }
    
}

