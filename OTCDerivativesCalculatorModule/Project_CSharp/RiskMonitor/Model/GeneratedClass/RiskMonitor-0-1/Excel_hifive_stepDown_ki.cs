using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_hifive_stepDown_ki : ISerialized
    {
        public Excel_hifive_stepDown_ki() { }
        public Excel_hifive_stepDown_ki(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode underlyingCalcTypeNode = xmlNode.SelectSingleNode("underlyingCalcType");
            
            if (underlyingCalcTypeNode != null)
            {
                if (underlyingCalcTypeNode.Attributes["href"] != null || underlyingCalcTypeNode.Attributes["id"] != null) 
                {
                    if (underlyingCalcTypeNode.Attributes["id"] != null) 
                    {
                        underlyingCalcTypeIDRef_ = underlyingCalcTypeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(underlyingCalcTypeNode);
                        IDManager.SetID(underlyingCalcTypeIDRef_, ob);
                    }
                    else if (underlyingCalcTypeNode.Attributes["href"] != null)
                    {
                        underlyingCalcTypeIDRef_ = underlyingCalcTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        underlyingCalcType_ = new XsdTypeToken(underlyingCalcTypeNode);
                    }
                }
                else
                {
                    underlyingCalcType_ = new XsdTypeToken(underlyingCalcTypeNode);
                }
            }
            
        
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
            
        
            XmlNodeList excel_stepDownKI_subScheduleNodeList = xmlNode.SelectNodes("excel_stepDownKI_subSchedule");
            
            if (excel_stepDownKI_subScheduleNodeList != null)
            {
                this.excel_stepDownKI_subSchedule_ = new List<Excel_stepDownKI_subSchedule>();
                foreach (XmlNode item in excel_stepDownKI_subScheduleNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            excel_stepDownKI_subScheduleIDRef_ = item.Attributes["id"].Value;
                            excel_stepDownKI_subSchedule_.Add(new Excel_stepDownKI_subSchedule(item));
                            IDManager.SetID(excel_stepDownKI_subScheduleIDRef_, excel_stepDownKI_subSchedule_[excel_stepDownKI_subSchedule_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            excel_stepDownKI_subScheduleIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        excel_stepDownKI_subSchedule_.Add(new Excel_stepDownKI_subSchedule(item));
                        }
                    }
                    else
                    {
                        excel_stepDownKI_subSchedule_.Add(new Excel_stepDownKI_subSchedule(item));
                    }
                }
            }
            
        
            XmlNode couponNode = xmlNode.SelectSingleNode("coupon");
            
            if (couponNode != null)
            {
                if (couponNode.Attributes["href"] != null || couponNode.Attributes["id"] != null) 
                {
                    if (couponNode.Attributes["id"] != null) 
                    {
                        couponIDRef_ = couponNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(couponNode);
                        IDManager.SetID(couponIDRef_, ob);
                    }
                    else if (couponNode.Attributes["href"] != null)
                    {
                        couponIDRef_ = couponNode.Attributes["href"].Value;
                    }
                    else
                    {
                        coupon_ = new XsdTypeToken(couponNode);
                    }
                }
                else
                {
                    coupon_ = new XsdTypeToken(couponNode);
                }
            }
            
        
            XmlNode kiNode = xmlNode.SelectSingleNode("ki");
            
            if (kiNode != null)
            {
                if (kiNode.Attributes["href"] != null || kiNode.Attributes["id"] != null) 
                {
                    if (kiNode.Attributes["id"] != null) 
                    {
                        kiIDRef_ = kiNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(kiNode);
                        IDManager.SetID(kiIDRef_, ob);
                    }
                    else if (kiNode.Attributes["href"] != null)
                    {
                        kiIDRef_ = kiNode.Attributes["href"].Value;
                    }
                    else
                    {
                        ki_ = new XsdTypeToken(kiNode);
                    }
                }
                else
                {
                    ki_ = new XsdTypeToken(kiNode);
                }
            }
            
        
            XmlNode kiObStartDateNode = xmlNode.SelectSingleNode("kiObStartDate");
            
            if (kiObStartDateNode != null)
            {
                if (kiObStartDateNode.Attributes["href"] != null || kiObStartDateNode.Attributes["id"] != null) 
                {
                    if (kiObStartDateNode.Attributes["id"] != null) 
                    {
                        kiObStartDateIDRef_ = kiObStartDateNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(kiObStartDateNode);
                        IDManager.SetID(kiObStartDateIDRef_, ob);
                    }
                    else if (kiObStartDateNode.Attributes["href"] != null)
                    {
                        kiObStartDateIDRef_ = kiObStartDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        kiObStartDate_ = new XsdTypeToken(kiObStartDateNode);
                    }
                }
                else
                {
                    kiObStartDate_ = new XsdTypeToken(kiObStartDateNode);
                }
            }
            
        
            XmlNode kiObEndDateNode = xmlNode.SelectSingleNode("kiObEndDate");
            
            if (kiObEndDateNode != null)
            {
                if (kiObEndDateNode.Attributes["href"] != null || kiObEndDateNode.Attributes["id"] != null) 
                {
                    if (kiObEndDateNode.Attributes["id"] != null) 
                    {
                        kiObEndDateIDRef_ = kiObEndDateNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(kiObEndDateNode);
                        IDManager.SetID(kiObEndDateIDRef_, ob);
                    }
                    else if (kiObEndDateNode.Attributes["href"] != null)
                    {
                        kiObEndDateIDRef_ = kiObEndDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        kiObEndDate_ = new XsdTypeToken(kiObEndDateNode);
                    }
                }
                else
                {
                    kiObEndDate_ = new XsdTypeToken(kiObEndDateNode);
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
        
    
        #region UnderlyingCalcType_
        private XsdTypeToken underlyingCalcType_;
        public XsdTypeToken UnderlyingCalcType_
        {
            get
            {
                if (this.underlyingCalcType_ != null)
                {
                    return this.underlyingCalcType_; 
                }
                else if (this.underlyingCalcTypeIDRef_ != null)
                {
                    underlyingCalcType_ = IDManager.getID(underlyingCalcTypeIDRef_) as XsdTypeToken;
                    return this.underlyingCalcType_; 
                }
                else
                {
                    throw new Exception( "underlyingCalcType_Node no exist!");
                }
            }
            set
            {
                if (this.underlyingCalcType_ != value)
                {
                    this.underlyingCalcType_ = value;
                }
            }
        }
        #endregion
        
        public string underlyingCalcTypeIDRef_ { get; set; }
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
        #region Excel_stepDownKI_subSchedule_
        private List<Excel_stepDownKI_subSchedule> excel_stepDownKI_subSchedule_;
        public List<Excel_stepDownKI_subSchedule> Excel_stepDownKI_subSchedule_
        {
            get
            {
                if (this.excel_stepDownKI_subSchedule_ != null)
                {
                    return this.excel_stepDownKI_subSchedule_; 
                }
                else if (this.excel_stepDownKI_subScheduleIDRef_ != null)
                {
                    return this.excel_stepDownKI_subSchedule_; 
                }
                else
                {
                    throw new Exception( "excel_stepDownKI_subSchedule_Node no exist!");
                }
            }
            set
            {
                if (this.excel_stepDownKI_subSchedule_ != value)
                {
                    this.excel_stepDownKI_subSchedule_ = value;
                }
            }
        }
        #endregion
        
        public string excel_stepDownKI_subScheduleIDRef_ { get; set; }
        #region Coupon_
        private XsdTypeToken coupon_;
        public XsdTypeToken Coupon_
        {
            get
            {
                if (this.coupon_ != null)
                {
                    return this.coupon_; 
                }
                else if (this.couponIDRef_ != null)
                {
                    coupon_ = IDManager.getID(couponIDRef_) as XsdTypeToken;
                    return this.coupon_; 
                }
                else
                {
                    throw new Exception( "coupon_Node no exist!");
                }
            }
            set
            {
                if (this.coupon_ != value)
                {
                    this.coupon_ = value;
                }
            }
        }
        #endregion
        
        public string couponIDRef_ { get; set; }
        #region Ki_
        private XsdTypeToken ki_;
        public XsdTypeToken Ki_
        {
            get
            {
                if (this.ki_ != null)
                {
                    return this.ki_; 
                }
                else if (this.kiIDRef_ != null)
                {
                    ki_ = IDManager.getID(kiIDRef_) as XsdTypeToken;
                    return this.ki_; 
                }
                else
                {
                    throw new Exception( "ki_Node no exist!");
                }
            }
            set
            {
                if (this.ki_ != value)
                {
                    this.ki_ = value;
                }
            }
        }
        #endregion
        
        public string kiIDRef_ { get; set; }
        #region KiObStartDate_
        private XsdTypeToken kiObStartDate_;
        public XsdTypeToken KiObStartDate_
        {
            get
            {
                if (this.kiObStartDate_ != null)
                {
                    return this.kiObStartDate_; 
                }
                else if (this.kiObStartDateIDRef_ != null)
                {
                    kiObStartDate_ = IDManager.getID(kiObStartDateIDRef_) as XsdTypeToken;
                    return this.kiObStartDate_; 
                }
                else
                {
                    throw new Exception( "kiObStartDate_Node no exist!");
                }
            }
            set
            {
                if (this.kiObStartDate_ != value)
                {
                    this.kiObStartDate_ = value;
                }
            }
        }
        #endregion
        
        public string kiObStartDateIDRef_ { get; set; }
        #region KiObEndDate_
        private XsdTypeToken kiObEndDate_;
        public XsdTypeToken KiObEndDate_
        {
            get
            {
                if (this.kiObEndDate_ != null)
                {
                    return this.kiObEndDate_; 
                }
                else if (this.kiObEndDateIDRef_ != null)
                {
                    kiObEndDate_ = IDManager.getID(kiObEndDateIDRef_) as XsdTypeToken;
                    return this.kiObEndDate_; 
                }
                else
                {
                    throw new Exception( "kiObEndDate_Node no exist!");
                }
            }
            set
            {
                if (this.kiObEndDate_ != value)
                {
                    this.kiObEndDate_ = value;
                }
            }
        }
        #endregion
        
        public string kiObEndDateIDRef_ { get; set; }
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

