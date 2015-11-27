using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_fixedBond_constantRate : ISerialized
    {
        public Excel_fixedBond_constantRate() { }
        public Excel_fixedBond_constantRate(XmlNode xmlNode)
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
            
        
            XmlNodeList excel_fixedBond_subScheduleNodeList = xmlNode.SelectNodes("excel_fixedBond_subSchedule");
            
            if (excel_fixedBond_subScheduleNodeList != null)
            {
                this.excel_fixedBond_subSchedule_ = new List<Excel_fixedBond_subSchedule>();
                foreach (XmlNode item in excel_fixedBond_subScheduleNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            excel_fixedBond_subScheduleIDRef_ = item.Attributes["id"].Value;
                            excel_fixedBond_subSchedule_.Add(new Excel_fixedBond_subSchedule(item));
                            IDManager.SetID(excel_fixedBond_subScheduleIDRef_, excel_fixedBond_subSchedule_[excel_fixedBond_subSchedule_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            excel_fixedBond_subScheduleIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        excel_fixedBond_subSchedule_.Add(new Excel_fixedBond_subSchedule(item));
                        }
                    }
                    else
                    {
                        excel_fixedBond_subSchedule_.Add(new Excel_fixedBond_subSchedule(item));
                    }
                }
            }
            
        
            XmlNode fixedRateNode = xmlNode.SelectSingleNode("fixedRate");
            
            if (fixedRateNode != null)
            {
                if (fixedRateNode.Attributes["href"] != null || fixedRateNode.Attributes["id"] != null) 
                {
                    if (fixedRateNode.Attributes["id"] != null) 
                    {
                        fixedRateIDRef_ = fixedRateNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(fixedRateNode);
                        IDManager.SetID(fixedRateIDRef_, ob);
                    }
                    else if (fixedRateNode.Attributes["href"] != null)
                    {
                        fixedRateIDRef_ = fixedRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fixedRate_ = new XsdTypeToken(fixedRateNode);
                    }
                }
                else
                {
                    fixedRate_ = new XsdTypeToken(fixedRateNode);
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
        #region Excel_fixedBond_subSchedule_
        private List<Excel_fixedBond_subSchedule> excel_fixedBond_subSchedule_;
        public List<Excel_fixedBond_subSchedule> Excel_fixedBond_subSchedule_
        {
            get
            {
                if (this.excel_fixedBond_subSchedule_ != null)
                {
                    return this.excel_fixedBond_subSchedule_; 
                }
                else if (this.excel_fixedBond_subScheduleIDRef_ != null)
                {
                    return this.excel_fixedBond_subSchedule_; 
                }
                else
                {
                    throw new Exception( "excel_fixedBond_subSchedule_Node no exist!");
                }
            }
            set
            {
                if (this.excel_fixedBond_subSchedule_ != value)
                {
                    this.excel_fixedBond_subSchedule_ = value;
                }
            }
        }
        #endregion
        
        public string excel_fixedBond_subScheduleIDRef_ { get; set; }
        #region FixedRate_
        private XsdTypeToken fixedRate_;
        public XsdTypeToken FixedRate_
        {
            get
            {
                if (this.fixedRate_ != null)
                {
                    return this.fixedRate_; 
                }
                else if (this.fixedRateIDRef_ != null)
                {
                    fixedRate_ = IDManager.getID(fixedRateIDRef_) as XsdTypeToken;
                    return this.fixedRate_; 
                }
                else
                {
                    throw new Exception( "fixedRate_Node no exist!");
                }
            }
            set
            {
                if (this.fixedRate_ != value)
                {
                    this.fixedRate_ = value;
                }
            }
        }
        #endregion
        
        public string fixedRateIDRef_ { get; set; }
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

