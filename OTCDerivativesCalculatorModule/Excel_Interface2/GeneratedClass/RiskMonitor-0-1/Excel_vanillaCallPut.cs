using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_vanillaCallPut : ISerialized
    {
        public Excel_vanillaCallPut() { }
        public Excel_vanillaCallPut(XmlNode xmlNode)
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
            
        
            XmlNode underlyingCodeNode = xmlNode.SelectSingleNode("underlyingCode");
            
            if (underlyingCodeNode != null)
            {
                if (underlyingCodeNode.Attributes["href"] != null || underlyingCodeNode.Attributes["id"] != null) 
                {
                    if (underlyingCodeNode.Attributes["id"] != null) 
                    {
                        underlyingCodeIDRef_ = underlyingCodeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(underlyingCodeNode);
                        IDManager.SetID(underlyingCodeIDRef_, ob);
                    }
                    else if (underlyingCodeNode.Attributes["href"] != null)
                    {
                        underlyingCodeIDRef_ = underlyingCodeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        underlyingCode_ = new XsdTypeToken(underlyingCodeNode);
                    }
                }
                else
                {
                    underlyingCode_ = new XsdTypeToken(underlyingCodeNode);
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
            
        
            XmlNode partiRateNode = xmlNode.SelectSingleNode("partiRate");
            
            if (partiRateNode != null)
            {
                if (partiRateNode.Attributes["href"] != null || partiRateNode.Attributes["id"] != null) 
                {
                    if (partiRateNode.Attributes["id"] != null) 
                    {
                        partiRateIDRef_ = partiRateNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(partiRateNode);
                        IDManager.SetID(partiRateIDRef_, ob);
                    }
                    else if (partiRateNode.Attributes["href"] != null)
                    {
                        partiRateIDRef_ = partiRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        partiRate_ = new XsdTypeToken(partiRateNode);
                    }
                }
                else
                {
                    partiRate_ = new XsdTypeToken(partiRateNode);
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
        #region UnderlyingCode_
        private XsdTypeToken underlyingCode_;
        public XsdTypeToken UnderlyingCode_
        {
            get
            {
                if (this.underlyingCode_ != null)
                {
                    return this.underlyingCode_; 
                }
                else if (this.underlyingCodeIDRef_ != null)
                {
                    underlyingCode_ = IDManager.getID(underlyingCodeIDRef_) as XsdTypeToken;
                    return this.underlyingCode_; 
                }
                else
                {
                    throw new Exception( "underlyingCode_Node no exist!");
                }
            }
            set
            {
                if (this.underlyingCode_ != value)
                {
                    this.underlyingCode_ = value;
                }
            }
        }
        #endregion
        
        public string underlyingCodeIDRef_ { get; set; }
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
        #region PartiRate_
        private XsdTypeToken partiRate_;
        public XsdTypeToken PartiRate_
        {
            get
            {
                if (this.partiRate_ != null)
                {
                    return this.partiRate_; 
                }
                else if (this.partiRateIDRef_ != null)
                {
                    partiRate_ = IDManager.getID(partiRateIDRef_) as XsdTypeToken;
                    return this.partiRate_; 
                }
                else
                {
                    throw new Exception( "partiRate_Node no exist!");
                }
            }
            set
            {
                if (this.partiRate_ != value)
                {
                    this.partiRate_ = value;
                }
            }
        }
        #endregion
        
        public string partiRateIDRef_ { get; set; }
        
    
        
    
    }
    
}

