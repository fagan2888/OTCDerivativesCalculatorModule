using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class BarrierWithConstRebatePutOption : ISerialized
    {
        public BarrierWithConstRebatePutOption() { }
        public BarrierWithConstRebatePutOption(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode payoffDateInfoNode = xmlNode.SelectSingleNode("payoffDateInfo");
            
            if (payoffDateInfoNode != null)
            {
                if (payoffDateInfoNode.Attributes["href"] != null || payoffDateInfoNode.Attributes["id"] != null) 
                {
                    if (payoffDateInfoNode.Attributes["id"] != null) 
                    {
                        payoffDateInfoIDRef_ = payoffDateInfoNode.Attributes["id"].Value;
                        PayoffDateInfo ob = new PayoffDateInfo(payoffDateInfoNode);
                        IDManager.SetID(payoffDateInfoIDRef_, ob);
                    }
                    else if (payoffDateInfoNode.Attributes["href"] != null)
                    {
                        payoffDateInfoIDRef_ = payoffDateInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        payoffDateInfo_ = new PayoffDateInfo(payoffDateInfoNode);
                    }
                }
                else
                {
                    payoffDateInfo_ = new PayoffDateInfo(payoffDateInfoNode);
                }
            }
            
        
            XmlNode participateRateNode = xmlNode.SelectSingleNode("participateRate");
            
            if (participateRateNode != null)
            {
                if (participateRateNode.Attributes["href"] != null || participateRateNode.Attributes["id"] != null) 
                {
                    if (participateRateNode.Attributes["id"] != null) 
                    {
                        participateRateIDRef_ = participateRateNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(participateRateNode);
                        IDManager.SetID(participateRateIDRef_, ob);
                    }
                    else if (participateRateNode.Attributes["href"] != null)
                    {
                        participateRateIDRef_ = participateRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        participateRate_ = new XsdTypeDouble(participateRateNode);
                    }
                }
                else
                {
                    participateRate_ = new XsdTypeDouble(participateRateNode);
                }
            }
            
        
            XmlNode referenceCalculationInfoNode = xmlNode.SelectSingleNode("referenceCalculationInfo");
            
            if (referenceCalculationInfoNode != null)
            {
                if (referenceCalculationInfoNode.Attributes["href"] != null || referenceCalculationInfoNode.Attributes["id"] != null) 
                {
                    if (referenceCalculationInfoNode.Attributes["id"] != null) 
                    {
                        referenceCalculationInfoIDRef_ = referenceCalculationInfoNode.Attributes["id"].Value;
                        ReferenceCalculationInfo ob = new ReferenceCalculationInfo(referenceCalculationInfoNode);
                        IDManager.SetID(referenceCalculationInfoIDRef_, ob);
                    }
                    else if (referenceCalculationInfoNode.Attributes["href"] != null)
                    {
                        referenceCalculationInfoIDRef_ = referenceCalculationInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        referenceCalculationInfo_ = new ReferenceCalculationInfo(referenceCalculationInfoNode);
                    }
                }
                else
                {
                    referenceCalculationInfo_ = new ReferenceCalculationInfo(referenceCalculationInfoNode);
                }
            }
            
        
            XmlNode barrierInfoNode = xmlNode.SelectSingleNode("barrierInfo");
            
            if (barrierInfoNode != null)
            {
                if (barrierInfoNode.Attributes["href"] != null || barrierInfoNode.Attributes["id"] != null) 
                {
                    if (barrierInfoNode.Attributes["id"] != null) 
                    {
                        barrierInfoIDRef_ = barrierInfoNode.Attributes["id"].Value;
                        BarrierInfo ob = new BarrierInfo(barrierInfoNode);
                        IDManager.SetID(barrierInfoIDRef_, ob);
                    }
                    else if (barrierInfoNode.Attributes["href"] != null)
                    {
                        barrierInfoIDRef_ = barrierInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        barrierInfo_ = new BarrierInfo(barrierInfoNode);
                    }
                }
                else
                {
                    barrierInfo_ = new BarrierInfo(barrierInfoNode);
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
                        XsdTypeDouble ob = new XsdTypeDouble(strikeNode);
                        IDManager.SetID(strikeIDRef_, ob);
                    }
                    else if (strikeNode.Attributes["href"] != null)
                    {
                        strikeIDRef_ = strikeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        strike_ = new XsdTypeDouble(strikeNode);
                    }
                }
                else
                {
                    strike_ = new XsdTypeDouble(strikeNode);
                }
            }
            
        
            XmlNode lowerBoundNode = xmlNode.SelectSingleNode("lowerBound");
            
            if (lowerBoundNode != null)
            {
                if (lowerBoundNode.Attributes["href"] != null || lowerBoundNode.Attributes["id"] != null) 
                {
                    if (lowerBoundNode.Attributes["id"] != null) 
                    {
                        lowerBoundIDRef_ = lowerBoundNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(lowerBoundNode);
                        IDManager.SetID(lowerBoundIDRef_, ob);
                    }
                    else if (lowerBoundNode.Attributes["href"] != null)
                    {
                        lowerBoundIDRef_ = lowerBoundNode.Attributes["href"].Value;
                    }
                    else
                    {
                        lowerBound_ = new XsdTypeDouble(lowerBoundNode);
                    }
                }
                else
                {
                    lowerBound_ = new XsdTypeDouble(lowerBoundNode);
                }
            }
            
        
            XmlNode rebateRateNode = xmlNode.SelectSingleNode("rebateRate");
            
            if (rebateRateNode != null)
            {
                if (rebateRateNode.Attributes["href"] != null || rebateRateNode.Attributes["id"] != null) 
                {
                    if (rebateRateNode.Attributes["id"] != null) 
                    {
                        rebateRateIDRef_ = rebateRateNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(rebateRateNode);
                        IDManager.SetID(rebateRateIDRef_, ob);
                    }
                    else if (rebateRateNode.Attributes["href"] != null)
                    {
                        rebateRateIDRef_ = rebateRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        rebateRate_ = new XsdTypeDouble(rebateRateNode);
                    }
                }
                else
                {
                    rebateRate_ = new XsdTypeDouble(rebateRateNode);
                }
            }
            
        
        }
        
    
        #region PayoffDateInfo_
        private PayoffDateInfo payoffDateInfo_;
        public PayoffDateInfo PayoffDateInfo_
        {
            get
            {
                if (this.payoffDateInfo_ != null)
                {
                    return this.payoffDateInfo_; 
                }
                else if (this.payoffDateInfoIDRef_ != null)
                {
                    payoffDateInfo_ = IDManager.getID(payoffDateInfoIDRef_) as PayoffDateInfo;
                    return this.payoffDateInfo_; 
                }
                else
                {
                    throw new Exception( "payoffDateInfo_Node no exist!");
                }
            }
            set
            {
                if (this.payoffDateInfo_ != value)
                {
                    this.payoffDateInfo_ = value;
                }
            }
        }
        #endregion
        
        public string payoffDateInfoIDRef_ { get; set; }
        #region ParticipateRate_
        private XsdTypeDouble participateRate_;
        public XsdTypeDouble ParticipateRate_
        {
            get
            {
                if (this.participateRate_ != null)
                {
                    return this.participateRate_; 
                }
                else if (this.participateRateIDRef_ != null)
                {
                    participateRate_ = IDManager.getID(participateRateIDRef_) as XsdTypeDouble;
                    return this.participateRate_; 
                }
                else
                {
                    throw new Exception( "participateRate_Node no exist!");
                }
            }
            set
            {
                if (this.participateRate_ != value)
                {
                    this.participateRate_ = value;
                }
            }
        }
        #endregion
        
        public string participateRateIDRef_ { get; set; }
        #region ReferenceCalculationInfo_
        private ReferenceCalculationInfo referenceCalculationInfo_;
        public ReferenceCalculationInfo ReferenceCalculationInfo_
        {
            get
            {
                if (this.referenceCalculationInfo_ != null)
                {
                    return this.referenceCalculationInfo_; 
                }
                else if (this.referenceCalculationInfoIDRef_ != null)
                {
                    referenceCalculationInfo_ = IDManager.getID(referenceCalculationInfoIDRef_) as ReferenceCalculationInfo;
                    return this.referenceCalculationInfo_; 
                }
                else
                {
                    throw new Exception( "referenceCalculationInfo_Node no exist!");
                }
            }
            set
            {
                if (this.referenceCalculationInfo_ != value)
                {
                    this.referenceCalculationInfo_ = value;
                }
            }
        }
        #endregion
        
        public string referenceCalculationInfoIDRef_ { get; set; }
        #region BarrierInfo_
        private BarrierInfo barrierInfo_;
        public BarrierInfo BarrierInfo_
        {
            get
            {
                if (this.barrierInfo_ != null)
                {
                    return this.barrierInfo_; 
                }
                else if (this.barrierInfoIDRef_ != null)
                {
                    barrierInfo_ = IDManager.getID(barrierInfoIDRef_) as BarrierInfo;
                    return this.barrierInfo_; 
                }
                else
                {
                    throw new Exception( "barrierInfo_Node no exist!");
                }
            }
            set
            {
                if (this.barrierInfo_ != value)
                {
                    this.barrierInfo_ = value;
                }
            }
        }
        #endregion
        
        public string barrierInfoIDRef_ { get; set; }
        #region Strike_
        private XsdTypeDouble strike_;
        public XsdTypeDouble Strike_
        {
            get
            {
                if (this.strike_ != null)
                {
                    return this.strike_; 
                }
                else if (this.strikeIDRef_ != null)
                {
                    strike_ = IDManager.getID(strikeIDRef_) as XsdTypeDouble;
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
        #region LowerBound_
        private XsdTypeDouble lowerBound_;
        public XsdTypeDouble LowerBound_
        {
            get
            {
                if (this.lowerBound_ != null)
                {
                    return this.lowerBound_; 
                }
                else if (this.lowerBoundIDRef_ != null)
                {
                    lowerBound_ = IDManager.getID(lowerBoundIDRef_) as XsdTypeDouble;
                    return this.lowerBound_; 
                }
                else
                {
                    throw new Exception( "lowerBound_Node no exist!");
                }
            }
            set
            {
                if (this.lowerBound_ != value)
                {
                    this.lowerBound_ = value;
                }
            }
        }
        #endregion
        
        public string lowerBoundIDRef_ { get; set; }
        #region RebateRate_
        private XsdTypeDouble rebateRate_;
        public XsdTypeDouble RebateRate_
        {
            get
            {
                if (this.rebateRate_ != null)
                {
                    return this.rebateRate_; 
                }
                else if (this.rebateRateIDRef_ != null)
                {
                    rebateRate_ = IDManager.getID(rebateRateIDRef_) as XsdTypeDouble;
                    return this.rebateRate_; 
                }
                else
                {
                    throw new Exception( "rebateRate_Node no exist!");
                }
            }
            set
            {
                if (this.rebateRate_ != value)
                {
                    this.rebateRate_ = value;
                }
            }
        }
        #endregion
        
        public string rebateRateIDRef_ { get; set; }
        
    
        
    
    }
    
}

