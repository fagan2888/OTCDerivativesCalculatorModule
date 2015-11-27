using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_multiAsset_digitalCallPut : ISerialized
    {
        public Excel_multiAsset_digitalCallPut() { }
        public Excel_multiAsset_digitalCallPut(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode payoffDateNode = xmlNode.SelectSingleNode("payoffDate");
            
            if (payoffDateNode != null)
            {
                if (payoffDateNode.Attributes["href"] != null || payoffDateNode.Attributes["id"] != null) 
                {
                    if (payoffDateNode.Attributes["id"] != null) 
                    {
                        payoffDateIDRef_ = payoffDateNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(payoffDateNode);
                        IDManager.SetID(payoffDateIDRef_, ob);
                    }
                    else if (payoffDateNode.Attributes["href"] != null)
                    {
                        payoffDateIDRef_ = payoffDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        payoffDate_ = new XsdTypeToken(payoffDateNode);
                    }
                }
                else
                {
                    payoffDate_ = new XsdTypeToken(payoffDateNode);
                }
            }
            
        
            XmlNode exerciseDateNode = xmlNode.SelectSingleNode("exerciseDate");
            
            if (exerciseDateNode != null)
            {
                if (exerciseDateNode.Attributes["href"] != null || exerciseDateNode.Attributes["id"] != null) 
                {
                    if (exerciseDateNode.Attributes["id"] != null) 
                    {
                        exerciseDateIDRef_ = exerciseDateNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(exerciseDateNode);
                        IDManager.SetID(exerciseDateIDRef_, ob);
                    }
                    else if (exerciseDateNode.Attributes["href"] != null)
                    {
                        exerciseDateIDRef_ = exerciseDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        exerciseDate_ = new XsdTypeToken(exerciseDateNode);
                    }
                }
                else
                {
                    exerciseDate_ = new XsdTypeToken(exerciseDateNode);
                }
            }
            
        
            XmlNode callPutNode = xmlNode.SelectSingleNode("callPut");
            
            if (callPutNode != null)
            {
                if (callPutNode.Attributes["href"] != null || callPutNode.Attributes["id"] != null) 
                {
                    if (callPutNode.Attributes["id"] != null) 
                    {
                        callPutIDRef_ = callPutNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(callPutNode);
                        IDManager.SetID(callPutIDRef_, ob);
                    }
                    else if (callPutNode.Attributes["href"] != null)
                    {
                        callPutIDRef_ = callPutNode.Attributes["href"].Value;
                    }
                    else
                    {
                        callPut_ = new XsdTypeToken(callPutNode);
                    }
                }
                else
                {
                    callPut_ = new XsdTypeToken(callPutNode);
                }
            }
            
        
            XmlNode baseUnderlyingValueNode = xmlNode.SelectSingleNode("baseUnderlyingValue");
            
            if (baseUnderlyingValueNode != null)
            {
                if (baseUnderlyingValueNode.Attributes["href"] != null || baseUnderlyingValueNode.Attributes["id"] != null) 
                {
                    if (baseUnderlyingValueNode.Attributes["id"] != null) 
                    {
                        baseUnderlyingValueIDRef_ = baseUnderlyingValueNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(baseUnderlyingValueNode);
                        IDManager.SetID(baseUnderlyingValueIDRef_, ob);
                    }
                    else if (baseUnderlyingValueNode.Attributes["href"] != null)
                    {
                        baseUnderlyingValueIDRef_ = baseUnderlyingValueNode.Attributes["href"].Value;
                    }
                    else
                    {
                        baseUnderlyingValue_ = new XsdTypeToken(baseUnderlyingValueNode);
                    }
                }
                else
                {
                    baseUnderlyingValue_ = new XsdTypeToken(baseUnderlyingValueNode);
                }
            }
            
        
            XmlNode baseCouponNode = xmlNode.SelectSingleNode("baseCoupon");
            
            if (baseCouponNode != null)
            {
                if (baseCouponNode.Attributes["href"] != null || baseCouponNode.Attributes["id"] != null) 
                {
                    if (baseCouponNode.Attributes["id"] != null) 
                    {
                        baseCouponIDRef_ = baseCouponNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(baseCouponNode);
                        IDManager.SetID(baseCouponIDRef_, ob);
                    }
                    else if (baseCouponNode.Attributes["href"] != null)
                    {
                        baseCouponIDRef_ = baseCouponNode.Attributes["href"].Value;
                    }
                    else
                    {
                        baseCoupon_ = new XsdTypeToken(baseCouponNode);
                    }
                }
                else
                {
                    baseCoupon_ = new XsdTypeToken(baseCouponNode);
                }
            }
            
        
            XmlNode strikeNode = xmlNode.SelectSingleNode("strike");
            
            if (strikeNode != null)
            {
                if (strikeNode.Attributes["href"] != null || strikeNode.Attributes["id"] != null) 
                {
                    if (strikeNode.Attributes["id"] != null) 
                    {
                        strikeIDRef_ = strikeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(strikeNode);
                        IDManager.SetID(strikeIDRef_, ob);
                    }
                    else if (strikeNode.Attributes["href"] != null)
                    {
                        strikeIDRef_ = strikeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        strike_ = new XsdTypeToken(strikeNode);
                    }
                }
                else
                {
                    strike_ = new XsdTypeToken(strikeNode);
                }
            }
            
        
            XmlNode strikeValueNode = xmlNode.SelectSingleNode("strikeValue");
            
            if (strikeValueNode != null)
            {
                if (strikeValueNode.Attributes["href"] != null || strikeValueNode.Attributes["id"] != null) 
                {
                    if (strikeValueNode.Attributes["id"] != null) 
                    {
                        strikeValueIDRef_ = strikeValueNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(strikeValueNode);
                        IDManager.SetID(strikeValueIDRef_, ob);
                    }
                    else if (strikeValueNode.Attributes["href"] != null)
                    {
                        strikeValueIDRef_ = strikeValueNode.Attributes["href"].Value;
                    }
                    else
                    {
                        strikeValue_ = new XsdTypeToken(strikeValueNode);
                    }
                }
                else
                {
                    strikeValue_ = new XsdTypeToken(strikeValueNode);
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
            
        
            XmlNode couponValueNode = xmlNode.SelectSingleNode("couponValue");
            
            if (couponValueNode != null)
            {
                if (couponValueNode.Attributes["href"] != null || couponValueNode.Attributes["id"] != null) 
                {
                    if (couponValueNode.Attributes["id"] != null) 
                    {
                        couponValueIDRef_ = couponValueNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(couponValueNode);
                        IDManager.SetID(couponValueIDRef_, ob);
                    }
                    else if (couponValueNode.Attributes["href"] != null)
                    {
                        couponValueIDRef_ = couponValueNode.Attributes["href"].Value;
                    }
                    else
                    {
                        couponValue_ = new XsdTypeToken(couponValueNode);
                    }
                }
                else
                {
                    couponValue_ = new XsdTypeToken(couponValueNode);
                }
            }
            
        
            XmlNode excel_underlyingCalcIDNode = xmlNode.SelectSingleNode("excel_underlyingCalcID");
            
            if (excel_underlyingCalcIDNode != null)
            {
                if (excel_underlyingCalcIDNode.Attributes["href"] != null || excel_underlyingCalcIDNode.Attributes["id"] != null) 
                {
                    if (excel_underlyingCalcIDNode.Attributes["id"] != null) 
                    {
                        excel_underlyingCalcIDIDRef_ = excel_underlyingCalcIDNode.Attributes["id"].Value;
                        Excel_underlyingCalcID ob = new Excel_underlyingCalcID(excel_underlyingCalcIDNode);
                        IDManager.SetID(excel_underlyingCalcIDIDRef_, ob);
                    }
                    else if (excel_underlyingCalcIDNode.Attributes["href"] != null)
                    {
                        excel_underlyingCalcIDIDRef_ = excel_underlyingCalcIDNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excel_underlyingCalcID_ = new Excel_underlyingCalcID(excel_underlyingCalcIDNode);
                    }
                }
                else
                {
                    excel_underlyingCalcID_ = new Excel_underlyingCalcID(excel_underlyingCalcIDNode);
                }
            }
            
        
        }
        
    
        #region PayoffDate_
        private XsdTypeToken payoffDate_;
        public XsdTypeToken PayoffDate_
        {
            get
            {
                if (this.payoffDate_ != null)
                {
                    return this.payoffDate_; 
                }
                else if (this.payoffDateIDRef_ != null)
                {
                    payoffDate_ = IDManager.getID(payoffDateIDRef_) as XsdTypeToken;
                    return this.payoffDate_; 
                }
                else
                {
                    throw new Exception( "payoffDate_Node no exist!");
                }
            }
            set
            {
                if (this.payoffDate_ != value)
                {
                    this.payoffDate_ = value;
                }
            }
        }
        #endregion
        
        public string payoffDateIDRef_ { get; set; }
        #region ExerciseDate_
        private XsdTypeToken exerciseDate_;
        public XsdTypeToken ExerciseDate_
        {
            get
            {
                if (this.exerciseDate_ != null)
                {
                    return this.exerciseDate_; 
                }
                else if (this.exerciseDateIDRef_ != null)
                {
                    exerciseDate_ = IDManager.getID(exerciseDateIDRef_) as XsdTypeToken;
                    return this.exerciseDate_; 
                }
                else
                {
                    throw new Exception( "exerciseDate_Node no exist!");
                }
            }
            set
            {
                if (this.exerciseDate_ != value)
                {
                    this.exerciseDate_ = value;
                }
            }
        }
        #endregion
        
        public string exerciseDateIDRef_ { get; set; }
        #region CallPut_
        private XsdTypeToken callPut_;
        public XsdTypeToken CallPut_
        {
            get
            {
                if (this.callPut_ != null)
                {
                    return this.callPut_; 
                }
                else if (this.callPutIDRef_ != null)
                {
                    callPut_ = IDManager.getID(callPutIDRef_) as XsdTypeToken;
                    return this.callPut_; 
                }
                else
                {
                    throw new Exception( "callPut_Node no exist!");
                }
            }
            set
            {
                if (this.callPut_ != value)
                {
                    this.callPut_ = value;
                }
            }
        }
        #endregion
        
        public string callPutIDRef_ { get; set; }
        #region BaseUnderlyingValue_
        private XsdTypeToken baseUnderlyingValue_;
        public XsdTypeToken BaseUnderlyingValue_
        {
            get
            {
                if (this.baseUnderlyingValue_ != null)
                {
                    return this.baseUnderlyingValue_; 
                }
                else if (this.baseUnderlyingValueIDRef_ != null)
                {
                    baseUnderlyingValue_ = IDManager.getID(baseUnderlyingValueIDRef_) as XsdTypeToken;
                    return this.baseUnderlyingValue_; 
                }
                else
                {
                    throw new Exception( "baseUnderlyingValue_Node no exist!");
                }
            }
            set
            {
                if (this.baseUnderlyingValue_ != value)
                {
                    this.baseUnderlyingValue_ = value;
                }
            }
        }
        #endregion
        
        public string baseUnderlyingValueIDRef_ { get; set; }
        #region BaseCoupon_
        private XsdTypeToken baseCoupon_;
        public XsdTypeToken BaseCoupon_
        {
            get
            {
                if (this.baseCoupon_ != null)
                {
                    return this.baseCoupon_; 
                }
                else if (this.baseCouponIDRef_ != null)
                {
                    baseCoupon_ = IDManager.getID(baseCouponIDRef_) as XsdTypeToken;
                    return this.baseCoupon_; 
                }
                else
                {
                    throw new Exception( "baseCoupon_Node no exist!");
                }
            }
            set
            {
                if (this.baseCoupon_ != value)
                {
                    this.baseCoupon_ = value;
                }
            }
        }
        #endregion
        
        public string baseCouponIDRef_ { get; set; }
        #region Strike_
        private XsdTypeToken strike_;
        public XsdTypeToken Strike_
        {
            get
            {
                if (this.strike_ != null)
                {
                    return this.strike_; 
                }
                else if (this.strikeIDRef_ != null)
                {
                    strike_ = IDManager.getID(strikeIDRef_) as XsdTypeToken;
                    return this.strike_; 
                }
                else
                {
                    throw new Exception( "strike_Node no exist!");
                }
            }
            set
            {
                if (this.strike_ != value)
                {
                    this.strike_ = value;
                }
            }
        }
        #endregion
        
        public string strikeIDRef_ { get; set; }
        #region StrikeValue_
        private XsdTypeToken strikeValue_;
        public XsdTypeToken StrikeValue_
        {
            get
            {
                if (this.strikeValue_ != null)
                {
                    return this.strikeValue_; 
                }
                else if (this.strikeValueIDRef_ != null)
                {
                    strikeValue_ = IDManager.getID(strikeValueIDRef_) as XsdTypeToken;
                    return this.strikeValue_; 
                }
                else
                {
                    throw new Exception( "strikeValue_Node no exist!");
                }
            }
            set
            {
                if (this.strikeValue_ != value)
                {
                    this.strikeValue_ = value;
                }
            }
        }
        #endregion
        
        public string strikeValueIDRef_ { get; set; }
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
        #region CouponValue_
        private XsdTypeToken couponValue_;
        public XsdTypeToken CouponValue_
        {
            get
            {
                if (this.couponValue_ != null)
                {
                    return this.couponValue_; 
                }
                else if (this.couponValueIDRef_ != null)
                {
                    couponValue_ = IDManager.getID(couponValueIDRef_) as XsdTypeToken;
                    return this.couponValue_; 
                }
                else
                {
                    throw new Exception( "couponValue_Node no exist!");
                }
            }
            set
            {
                if (this.couponValue_ != value)
                {
                    this.couponValue_ = value;
                }
            }
        }
        #endregion
        
        public string couponValueIDRef_ { get; set; }
        #region Excel_underlyingCalcID_
        private Excel_underlyingCalcID excel_underlyingCalcID_;
        public Excel_underlyingCalcID Excel_underlyingCalcID_
        {
            get
            {
                if (this.excel_underlyingCalcID_ != null)
                {
                    return this.excel_underlyingCalcID_; 
                }
                else if (this.excel_underlyingCalcIDIDRef_ != null)
                {
                    excel_underlyingCalcID_ = IDManager.getID(excel_underlyingCalcIDIDRef_) as Excel_underlyingCalcID;
                    return this.excel_underlyingCalcID_; 
                }
                else
                {
                    throw new Exception( "excel_underlyingCalcID_Node no exist!");
                }
            }
            set
            {
                if (this.excel_underlyingCalcID_ != value)
                {
                    this.excel_underlyingCalcID_ = value;
                }
            }
        }
        #endregion
        
        public string excel_underlyingCalcIDIDRef_ { get; set; }
        
    
        
    
    }
    
}

