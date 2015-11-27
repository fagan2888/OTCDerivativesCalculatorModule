using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class SimpleRangeRateTrigger : ISerialized
    {
        public SimpleRangeRateTrigger() { }
        public SimpleRangeRateTrigger(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode dayCounterNode = xmlNode.SelectSingleNode("dayCounter");
            
            if (dayCounterNode != null)
            {
                if (dayCounterNode.Attributes["href"] != null || dayCounterNode.Attributes["id"] != null) 
                {
                    if (dayCounterNode.Attributes["id"] != null) 
                    {
                        dayCounterIDRef_ = dayCounterNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(dayCounterNode);
                        IDManager.SetID(dayCounterIDRef_, ob);
                    }
                    else if (dayCounterNode.Attributes["href"] != null)
                    {
                        dayCounterIDRef_ = dayCounterNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dayCounter_ = new XsdTypeToken(dayCounterNode);
                    }
                }
                else
                {
                    dayCounter_ = new XsdTypeToken(dayCounterNode);
                }
            }
            
        
            XmlNode calculationStartDateNode = xmlNode.SelectSingleNode("calculationStartDate");
            
            if (calculationStartDateNode != null)
            {
                if (calculationStartDateNode.Attributes["href"] != null || calculationStartDateNode.Attributes["id"] != null) 
                {
                    if (calculationStartDateNode.Attributes["id"] != null) 
                    {
                        calculationStartDateIDRef_ = calculationStartDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(calculationStartDateNode);
                        IDManager.SetID(calculationStartDateIDRef_, ob);
                    }
                    else if (calculationStartDateNode.Attributes["href"] != null)
                    {
                        calculationStartDateIDRef_ = calculationStartDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculationStartDate_ = new XsdTypeDate(calculationStartDateNode);
                    }
                }
                else
                {
                    calculationStartDate_ = new XsdTypeDate(calculationStartDateNode);
                }
            }
            
        
            XmlNode calculationEndDateNode = xmlNode.SelectSingleNode("calculationEndDate");
            
            if (calculationEndDateNode != null)
            {
                if (calculationEndDateNode.Attributes["href"] != null || calculationEndDateNode.Attributes["id"] != null) 
                {
                    if (calculationEndDateNode.Attributes["id"] != null) 
                    {
                        calculationEndDateIDRef_ = calculationEndDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(calculationEndDateNode);
                        IDManager.SetID(calculationEndDateIDRef_, ob);
                    }
                    else if (calculationEndDateNode.Attributes["href"] != null)
                    {
                        calculationEndDateIDRef_ = calculationEndDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculationEndDate_ = new XsdTypeDate(calculationEndDateNode);
                    }
                }
                else
                {
                    calculationEndDate_ = new XsdTypeDate(calculationEndDateNode);
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
            
        
            XmlNode simpleRangeEventListNode = xmlNode.SelectSingleNode("simpleRangeEventList");
            
            if (simpleRangeEventListNode != null)
            {
                if (simpleRangeEventListNode.Attributes["href"] != null || simpleRangeEventListNode.Attributes["id"] != null) 
                {
                    if (simpleRangeEventListNode.Attributes["id"] != null) 
                    {
                        simpleRangeEventListIDRef_ = simpleRangeEventListNode.Attributes["id"].Value;
                        SimpleRangeEventList ob = new SimpleRangeEventList(simpleRangeEventListNode);
                        IDManager.SetID(simpleRangeEventListIDRef_, ob);
                    }
                    else if (simpleRangeEventListNode.Attributes["href"] != null)
                    {
                        simpleRangeEventListIDRef_ = simpleRangeEventListNode.Attributes["href"].Value;
                    }
                    else
                    {
                        simpleRangeEventList_ = new SimpleRangeEventList(simpleRangeEventListNode);
                    }
                }
                else
                {
                    simpleRangeEventList_ = new SimpleRangeEventList(simpleRangeEventListNode);
                }
            }
            
        
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
            
        
        }
        
    
        #region DayCounter_
        private XsdTypeToken dayCounter_;
        public XsdTypeToken DayCounter_
        {
            get
            {
                if (this.dayCounter_ != null)
                {
                    return this.dayCounter_; 
                }
                else if (this.dayCounterIDRef_ != null)
                {
                    dayCounter_ = IDManager.getID(dayCounterIDRef_) as XsdTypeToken;
                    return this.dayCounter_; 
                }
                else
                {
                    throw new Exception( "dayCounter_Node no exist!");
                }
            }
            set
            {
                if (this.dayCounter_ != value)
                {
                    this.dayCounter_ = value;
                }
            }
        }
        #endregion
        
        public string dayCounterIDRef_ { get; set; }
        #region CalculationStartDate_
        private XsdTypeDate calculationStartDate_;
        public XsdTypeDate CalculationStartDate_
        {
            get
            {
                if (this.calculationStartDate_ != null)
                {
                    return this.calculationStartDate_; 
                }
                else if (this.calculationStartDateIDRef_ != null)
                {
                    calculationStartDate_ = IDManager.getID(calculationStartDateIDRef_) as XsdTypeDate;
                    return this.calculationStartDate_; 
                }
                else
                {
                    throw new Exception( "calculationStartDate_Node no exist!");
                }
            }
            set
            {
                if (this.calculationStartDate_ != value)
                {
                    this.calculationStartDate_ = value;
                }
            }
        }
        #endregion
        
        public string calculationStartDateIDRef_ { get; set; }
        #region CalculationEndDate_
        private XsdTypeDate calculationEndDate_;
        public XsdTypeDate CalculationEndDate_
        {
            get
            {
                if (this.calculationEndDate_ != null)
                {
                    return this.calculationEndDate_; 
                }
                else if (this.calculationEndDateIDRef_ != null)
                {
                    calculationEndDate_ = IDManager.getID(calculationEndDateIDRef_) as XsdTypeDate;
                    return this.calculationEndDate_; 
                }
                else
                {
                    throw new Exception( "calculationEndDate_Node no exist!");
                }
            }
            set
            {
                if (this.calculationEndDate_ != value)
                {
                    this.calculationEndDate_ = value;
                }
            }
        }
        #endregion
        
        public string calculationEndDateIDRef_ { get; set; }
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
        #region SimpleRangeEventList_
        private SimpleRangeEventList simpleRangeEventList_;
        public SimpleRangeEventList SimpleRangeEventList_
        {
            get
            {
                if (this.simpleRangeEventList_ != null)
                {
                    return this.simpleRangeEventList_; 
                }
                else if (this.simpleRangeEventListIDRef_ != null)
                {
                    simpleRangeEventList_ = IDManager.getID(simpleRangeEventListIDRef_) as SimpleRangeEventList;
                    return this.simpleRangeEventList_; 
                }
                else
                {
                    throw new Exception( "simpleRangeEventList_Node no exist!");
                }
            }
            set
            {
                if (this.simpleRangeEventList_ != value)
                {
                    this.simpleRangeEventList_ = value;
                }
            }
        }
        #endregion
        
        public string simpleRangeEventListIDRef_ { get; set; }
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
        
    
        
    
    }
    
}

