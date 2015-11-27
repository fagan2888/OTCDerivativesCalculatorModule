using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_multiAsset_upInOutCall : ISerialized
    {
        public Excel_multiAsset_upInOutCall() { }
        public Excel_multiAsset_upInOutCall(XmlNode xmlNode)
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
            
        
            XmlNode inOutNode = xmlNode.SelectSingleNode("inOut");
            
            if (inOutNode != null)
            {
                if (inOutNode.Attributes["href"] != null || inOutNode.Attributes["id"] != null) 
                {
                    if (inOutNode.Attributes["id"] != null) 
                    {
                        inOutIDRef_ = inOutNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(inOutNode);
                        IDManager.SetID(inOutIDRef_, ob);
                    }
                    else if (inOutNode.Attributes["href"] != null)
                    {
                        inOutIDRef_ = inOutNode.Attributes["href"].Value;
                    }
                    else
                    {
                        inOut_ = new XsdTypeToken(inOutNode);
                    }
                }
                else
                {
                    inOut_ = new XsdTypeToken(inOutNode);
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
            
        
            XmlNode barrierNode = xmlNode.SelectSingleNode("barrier");
            
            if (barrierNode != null)
            {
                if (barrierNode.Attributes["href"] != null || barrierNode.Attributes["id"] != null) 
                {
                    if (barrierNode.Attributes["id"] != null) 
                    {
                        barrierIDRef_ = barrierNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(barrierNode);
                        IDManager.SetID(barrierIDRef_, ob);
                    }
                    else if (barrierNode.Attributes["href"] != null)
                    {
                        barrierIDRef_ = barrierNode.Attributes["href"].Value;
                    }
                    else
                    {
                        barrier_ = new XsdTypeToken(barrierNode);
                    }
                }
                else
                {
                    barrier_ = new XsdTypeToken(barrierNode);
                }
            }
            
        
            XmlNode barrierValueNode = xmlNode.SelectSingleNode("barrierValue");
            
            if (barrierValueNode != null)
            {
                if (barrierValueNode.Attributes["href"] != null || barrierValueNode.Attributes["id"] != null) 
                {
                    if (barrierValueNode.Attributes["id"] != null) 
                    {
                        barrierValueIDRef_ = barrierValueNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(barrierValueNode);
                        IDManager.SetID(barrierValueIDRef_, ob);
                    }
                    else if (barrierValueNode.Attributes["href"] != null)
                    {
                        barrierValueIDRef_ = barrierValueNode.Attributes["href"].Value;
                    }
                    else
                    {
                        barrierValue_ = new XsdTypeToken(barrierValueNode);
                    }
                }
                else
                {
                    barrierValue_ = new XsdTypeToken(barrierValueNode);
                }
            }
            
        
            XmlNode rebateCouponNode = xmlNode.SelectSingleNode("rebateCoupon");
            
            if (rebateCouponNode != null)
            {
                if (rebateCouponNode.Attributes["href"] != null || rebateCouponNode.Attributes["id"] != null) 
                {
                    if (rebateCouponNode.Attributes["id"] != null) 
                    {
                        rebateCouponIDRef_ = rebateCouponNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(rebateCouponNode);
                        IDManager.SetID(rebateCouponIDRef_, ob);
                    }
                    else if (rebateCouponNode.Attributes["href"] != null)
                    {
                        rebateCouponIDRef_ = rebateCouponNode.Attributes["href"].Value;
                    }
                    else
                    {
                        rebateCoupon_ = new XsdTypeToken(rebateCouponNode);
                    }
                }
                else
                {
                    rebateCoupon_ = new XsdTypeToken(rebateCouponNode);
                }
            }
            
        
            XmlNode rebateCouponValueNode = xmlNode.SelectSingleNode("rebateCouponValue");
            
            if (rebateCouponValueNode != null)
            {
                if (rebateCouponValueNode.Attributes["href"] != null || rebateCouponValueNode.Attributes["id"] != null) 
                {
                    if (rebateCouponValueNode.Attributes["id"] != null) 
                    {
                        rebateCouponValueIDRef_ = rebateCouponValueNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(rebateCouponValueNode);
                        IDManager.SetID(rebateCouponValueIDRef_, ob);
                    }
                    else if (rebateCouponValueNode.Attributes["href"] != null)
                    {
                        rebateCouponValueIDRef_ = rebateCouponValueNode.Attributes["href"].Value;
                    }
                    else
                    {
                        rebateCouponValue_ = new XsdTypeToken(rebateCouponValueNode);
                    }
                }
                else
                {
                    rebateCouponValue_ = new XsdTypeToken(rebateCouponValueNode);
                }
            }
            
        
            XmlNodeList excel_underlyingCalcIDNodeList = xmlNode.SelectNodes("excel_underlyingCalcID");
            
            if (excel_underlyingCalcIDNodeList != null)
            {
                this.excel_underlyingCalcID_ = new List<Excel_underlyingCalcID>();
                foreach (XmlNode item in excel_underlyingCalcIDNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            excel_underlyingCalcIDIDRef_ = item.Attributes["id"].Value;
                            excel_underlyingCalcID_.Add(new Excel_underlyingCalcID(item));
                            IDManager.SetID(excel_underlyingCalcIDIDRef_, excel_underlyingCalcID_[excel_underlyingCalcID_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            excel_underlyingCalcIDIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        excel_underlyingCalcID_.Add(new Excel_underlyingCalcID(item));
                        }
                    }
                    else
                    {
                        excel_underlyingCalcID_.Add(new Excel_underlyingCalcID(item));
                    }
                }
            }
            
        
            XmlNode observationStartDateNode = xmlNode.SelectSingleNode("observationStartDate");
            
            if (observationStartDateNode != null)
            {
                if (observationStartDateNode.Attributes["href"] != null || observationStartDateNode.Attributes["id"] != null) 
                {
                    if (observationStartDateNode.Attributes["id"] != null) 
                    {
                        observationStartDateIDRef_ = observationStartDateNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(observationStartDateNode);
                        IDManager.SetID(observationStartDateIDRef_, ob);
                    }
                    else if (observationStartDateNode.Attributes["href"] != null)
                    {
                        observationStartDateIDRef_ = observationStartDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        observationStartDate_ = new XsdTypeToken(observationStartDateNode);
                    }
                }
                else
                {
                    observationStartDate_ = new XsdTypeToken(observationStartDateNode);
                }
            }
            
        
            XmlNode observationEndDateNode = xmlNode.SelectSingleNode("observationEndDate");
            
            if (observationEndDateNode != null)
            {
                if (observationEndDateNode.Attributes["href"] != null || observationEndDateNode.Attributes["id"] != null) 
                {
                    if (observationEndDateNode.Attributes["id"] != null) 
                    {
                        observationEndDateIDRef_ = observationEndDateNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(observationEndDateNode);
                        IDManager.SetID(observationEndDateIDRef_, ob);
                    }
                    else if (observationEndDateNode.Attributes["href"] != null)
                    {
                        observationEndDateIDRef_ = observationEndDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        observationEndDate_ = new XsdTypeToken(observationEndDateNode);
                    }
                }
                else
                {
                    observationEndDate_ = new XsdTypeToken(observationEndDateNode);
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
        #region InOut_
        private XsdTypeToken inOut_;
        public XsdTypeToken InOut_
        {
            get
            {
                if (this.inOut_ != null)
                {
                    return this.inOut_; 
                }
                else if (this.inOutIDRef_ != null)
                {
                    inOut_ = IDManager.getID(inOutIDRef_) as XsdTypeToken;
                    return this.inOut_; 
                }
                else
                {
                    throw new Exception( "inOut_Node no exist!");
                }
            }
            set
            {
                if (this.inOut_ != value)
                {
                    this.inOut_ = value;
                }
            }
        }
        #endregion
        
        public string inOutIDRef_ { get; set; }
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
        #region Barrier_
        private XsdTypeToken barrier_;
        public XsdTypeToken Barrier_
        {
            get
            {
                if (this.barrier_ != null)
                {
                    return this.barrier_; 
                }
                else if (this.barrierIDRef_ != null)
                {
                    barrier_ = IDManager.getID(barrierIDRef_) as XsdTypeToken;
                    return this.barrier_; 
                }
                else
                {
                    throw new Exception( "barrier_Node no exist!");
                }
            }
            set
            {
                if (this.barrier_ != value)
                {
                    this.barrier_ = value;
                }
            }
        }
        #endregion
        
        public string barrierIDRef_ { get; set; }
        #region BarrierValue_
        private XsdTypeToken barrierValue_;
        public XsdTypeToken BarrierValue_
        {
            get
            {
                if (this.barrierValue_ != null)
                {
                    return this.barrierValue_; 
                }
                else if (this.barrierValueIDRef_ != null)
                {
                    barrierValue_ = IDManager.getID(barrierValueIDRef_) as XsdTypeToken;
                    return this.barrierValue_; 
                }
                else
                {
                    throw new Exception( "barrierValue_Node no exist!");
                }
            }
            set
            {
                if (this.barrierValue_ != value)
                {
                    this.barrierValue_ = value;
                }
            }
        }
        #endregion
        
        public string barrierValueIDRef_ { get; set; }
        #region RebateCoupon_
        private XsdTypeToken rebateCoupon_;
        public XsdTypeToken RebateCoupon_
        {
            get
            {
                if (this.rebateCoupon_ != null)
                {
                    return this.rebateCoupon_; 
                }
                else if (this.rebateCouponIDRef_ != null)
                {
                    rebateCoupon_ = IDManager.getID(rebateCouponIDRef_) as XsdTypeToken;
                    return this.rebateCoupon_; 
                }
                else
                {
                    throw new Exception( "rebateCoupon_Node no exist!");
                }
            }
            set
            {
                if (this.rebateCoupon_ != value)
                {
                    this.rebateCoupon_ = value;
                }
            }
        }
        #endregion
        
        public string rebateCouponIDRef_ { get; set; }
        #region RebateCouponValue_
        private XsdTypeToken rebateCouponValue_;
        public XsdTypeToken RebateCouponValue_
        {
            get
            {
                if (this.rebateCouponValue_ != null)
                {
                    return this.rebateCouponValue_; 
                }
                else if (this.rebateCouponValueIDRef_ != null)
                {
                    rebateCouponValue_ = IDManager.getID(rebateCouponValueIDRef_) as XsdTypeToken;
                    return this.rebateCouponValue_; 
                }
                else
                {
                    throw new Exception( "rebateCouponValue_Node no exist!");
                }
            }
            set
            {
                if (this.rebateCouponValue_ != value)
                {
                    this.rebateCouponValue_ = value;
                }
            }
        }
        #endregion
        
        public string rebateCouponValueIDRef_ { get; set; }
        #region Excel_underlyingCalcID_
        private List<Excel_underlyingCalcID> excel_underlyingCalcID_;
        public List<Excel_underlyingCalcID> Excel_underlyingCalcID_
        {
            get
            {
                if (this.excel_underlyingCalcID_ != null)
                {
                    return this.excel_underlyingCalcID_; 
                }
                else if (this.excel_underlyingCalcIDIDRef_ != null)
                {
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
        #region ObservationStartDate_
        private XsdTypeToken observationStartDate_;
        public XsdTypeToken ObservationStartDate_
        {
            get
            {
                if (this.observationStartDate_ != null)
                {
                    return this.observationStartDate_; 
                }
                else if (this.observationStartDateIDRef_ != null)
                {
                    observationStartDate_ = IDManager.getID(observationStartDateIDRef_) as XsdTypeToken;
                    return this.observationStartDate_; 
                }
                else
                {
                    throw new Exception( "observationStartDate_Node no exist!");
                }
            }
            set
            {
                if (this.observationStartDate_ != value)
                {
                    this.observationStartDate_ = value;
                }
            }
        }
        #endregion
        
        public string observationStartDateIDRef_ { get; set; }
        #region ObservationEndDate_
        private XsdTypeToken observationEndDate_;
        public XsdTypeToken ObservationEndDate_
        {
            get
            {
                if (this.observationEndDate_ != null)
                {
                    return this.observationEndDate_; 
                }
                else if (this.observationEndDateIDRef_ != null)
                {
                    observationEndDate_ = IDManager.getID(observationEndDateIDRef_) as XsdTypeToken;
                    return this.observationEndDate_; 
                }
                else
                {
                    throw new Exception( "observationEndDate_Node no exist!");
                }
            }
            set
            {
                if (this.observationEndDate_ != value)
                {
                    this.observationEndDate_ = value;
                }
            }
        }
        #endregion
        
        public string observationEndDateIDRef_ { get; set; }
        
    
        
    
    }
    
}

