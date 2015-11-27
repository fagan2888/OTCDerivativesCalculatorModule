using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class SingleBarrier : ISerialized
    {
        public SingleBarrier() { }
        public SingleBarrier(XmlNode xmlNode)
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
            
        
            XmlNode rebateNode = xmlNode.SelectSingleNode("rebate");
            
            if (rebateNode != null)
            {
                if (rebateNode.Attributes["href"] != null || rebateNode.Attributes["id"] != null) 
                {
                    if (rebateNode.Attributes["id"] != null) 
                    {
                        rebateIDRef_ = rebateNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(rebateNode);
                        IDManager.SetID(rebateIDRef_, ob);
                    }
                    else if (rebateNode.Attributes["href"] != null)
                    {
                        rebateIDRef_ = rebateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        rebate_ = new XsdTypeDouble(rebateNode);
                    }
                }
                else
                {
                    rebate_ = new XsdTypeDouble(rebateNode);
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
        #region Rebate_
        private XsdTypeDouble rebate_;
        public XsdTypeDouble Rebate_
        {
            get
            {
                if (this.rebate_ != null)
                {
                    return this.rebate_; 
                }
                else if (this.rebateIDRef_ != null)
                {
                    rebate_ = IDManager.getID(rebateIDRef_) as XsdTypeDouble;
                    return this.rebate_; 
                }
                else
                {
                    throw new Exception( "rebate_Node no exist!");
                }
            }
            set
            {
                if (this.rebate_ != value)
                {
                    this.rebate_ = value;
                }
            }
        }
        #endregion
        
        public string rebateIDRef_ { get; set; }
        
    
        
    
    }
    
}

