using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PeriodicPayment : PaymentBase
    {
        public PeriodicPayment(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode paymentFrequencyNode = xmlNode.SelectSingleNode("paymentFrequency");
            
            if (paymentFrequencyNode != null)
            {
                if (paymentFrequencyNode.Attributes["href"] != null || paymentFrequencyNode.Attributes["id"] != null) 
                {
                    if (paymentFrequencyNode.Attributes["id"] != null) 
                    {
                        paymentFrequencyIDRef_ = paymentFrequencyNode.Attributes["id"].Value;
                        Period ob = new Period(paymentFrequencyNode);
                        IDManager.SetID(paymentFrequencyIDRef_, ob);
                    }
                    else if (paymentFrequencyNode.Attributes["href"] != null)
                    {
                        paymentFrequencyIDRef_ = paymentFrequencyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        paymentFrequency_ = new Period(paymentFrequencyNode);
                    }
                }
                else
                {
                    paymentFrequency_ = new Period(paymentFrequencyNode);
                }
            }
            
        
            XmlNode firstPeriodStartDateNode = xmlNode.SelectSingleNode("firstPeriodStartDate");
            
            if (firstPeriodStartDateNode != null)
            {
                if (firstPeriodStartDateNode.Attributes["href"] != null || firstPeriodStartDateNode.Attributes["id"] != null) 
                {
                    if (firstPeriodStartDateNode.Attributes["id"] != null) 
                    {
                        firstPeriodStartDateIDRef_ = firstPeriodStartDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(firstPeriodStartDateNode);
                        IDManager.SetID(firstPeriodStartDateIDRef_, ob);
                    }
                    else if (firstPeriodStartDateNode.Attributes["href"] != null)
                    {
                        firstPeriodStartDateIDRef_ = firstPeriodStartDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        firstPeriodStartDate_ = new XsdTypeDate(firstPeriodStartDateNode);
                    }
                }
                else
                {
                    firstPeriodStartDate_ = new XsdTypeDate(firstPeriodStartDateNode);
                }
            }
            
        
            XmlNode firstPaymentDateNode = xmlNode.SelectSingleNode("firstPaymentDate");
            
            if (firstPaymentDateNode != null)
            {
                if (firstPaymentDateNode.Attributes["href"] != null || firstPaymentDateNode.Attributes["id"] != null) 
                {
                    if (firstPaymentDateNode.Attributes["id"] != null) 
                    {
                        firstPaymentDateIDRef_ = firstPaymentDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(firstPaymentDateNode);
                        IDManager.SetID(firstPaymentDateIDRef_, ob);
                    }
                    else if (firstPaymentDateNode.Attributes["href"] != null)
                    {
                        firstPaymentDateIDRef_ = firstPaymentDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        firstPaymentDate_ = new XsdTypeDate(firstPaymentDateNode);
                    }
                }
                else
                {
                    firstPaymentDate_ = new XsdTypeDate(firstPaymentDateNode);
                }
            }
            
        
            XmlNode lastRegularPaymentDateNode = xmlNode.SelectSingleNode("lastRegularPaymentDate");
            
            if (lastRegularPaymentDateNode != null)
            {
                if (lastRegularPaymentDateNode.Attributes["href"] != null || lastRegularPaymentDateNode.Attributes["id"] != null) 
                {
                    if (lastRegularPaymentDateNode.Attributes["id"] != null) 
                    {
                        lastRegularPaymentDateIDRef_ = lastRegularPaymentDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(lastRegularPaymentDateNode);
                        IDManager.SetID(lastRegularPaymentDateIDRef_, ob);
                    }
                    else if (lastRegularPaymentDateNode.Attributes["href"] != null)
                    {
                        lastRegularPaymentDateIDRef_ = lastRegularPaymentDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        lastRegularPaymentDate_ = new XsdTypeDate(lastRegularPaymentDateNode);
                    }
                }
                else
                {
                    lastRegularPaymentDate_ = new XsdTypeDate(lastRegularPaymentDateNode);
                }
            }
            
        
            XmlNode rollConventionNode = xmlNode.SelectSingleNode("rollConvention");
            
            if (rollConventionNode != null)
            {
                if (rollConventionNode.Attributes["href"] != null || rollConventionNode.Attributes["id"] != null) 
                {
                    if (rollConventionNode.Attributes["id"] != null) 
                    {
                        rollConventionIDRef_ = rollConventionNode.Attributes["id"].Value;
                        RollConventionEnum ob = new RollConventionEnum(rollConventionNode);
                        IDManager.SetID(rollConventionIDRef_, ob);
                    }
                    else if (rollConventionNode.Attributes["href"] != null)
                    {
                        rollConventionIDRef_ = rollConventionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        rollConvention_ = new RollConventionEnum(rollConventionNode);
                    }
                }
                else
                {
                    rollConvention_ = new RollConventionEnum(rollConventionNode);
                }
            }
            
        
            XmlNode fixedAmountNode = xmlNode.SelectSingleNode("fixedAmount");
            
            if (fixedAmountNode != null)
            {
                if (fixedAmountNode.Attributes["href"] != null || fixedAmountNode.Attributes["id"] != null) 
                {
                    if (fixedAmountNode.Attributes["id"] != null) 
                    {
                        fixedAmountIDRef_ = fixedAmountNode.Attributes["id"].Value;
                        Money ob = new Money(fixedAmountNode);
                        IDManager.SetID(fixedAmountIDRef_, ob);
                    }
                    else if (fixedAmountNode.Attributes["href"] != null)
                    {
                        fixedAmountIDRef_ = fixedAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fixedAmount_ = new Money(fixedAmountNode);
                    }
                }
                else
                {
                    fixedAmount_ = new Money(fixedAmountNode);
                }
            }
            
        
            XmlNode fixedAmountCalculationNode = xmlNode.SelectSingleNode("fixedAmountCalculation");
            
            if (fixedAmountCalculationNode != null)
            {
                if (fixedAmountCalculationNode.Attributes["href"] != null || fixedAmountCalculationNode.Attributes["id"] != null) 
                {
                    if (fixedAmountCalculationNode.Attributes["id"] != null) 
                    {
                        fixedAmountCalculationIDRef_ = fixedAmountCalculationNode.Attributes["id"].Value;
                        FixedAmountCalculation ob = new FixedAmountCalculation(fixedAmountCalculationNode);
                        IDManager.SetID(fixedAmountCalculationIDRef_, ob);
                    }
                    else if (fixedAmountCalculationNode.Attributes["href"] != null)
                    {
                        fixedAmountCalculationIDRef_ = fixedAmountCalculationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fixedAmountCalculation_ = new FixedAmountCalculation(fixedAmountCalculationNode);
                    }
                }
                else
                {
                    fixedAmountCalculation_ = new FixedAmountCalculation(fixedAmountCalculationNode);
                }
            }
            
        
            XmlNodeList adjustedPaymentDatesNodeList = xmlNode.SelectNodes("adjustedPaymentDates");
            
            if (adjustedPaymentDatesNodeList != null)
            {
                this.adjustedPaymentDates_ = new List<AdjustedPaymentDates>();
                foreach (XmlNode item in adjustedPaymentDatesNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            adjustedPaymentDatesIDRef_ = item.Attributes["id"].Value;
                            adjustedPaymentDates_.Add(new AdjustedPaymentDates(item));
                            IDManager.SetID(adjustedPaymentDatesIDRef_, adjustedPaymentDates_[adjustedPaymentDates_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            adjustedPaymentDatesIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        adjustedPaymentDates_.Add(new AdjustedPaymentDates(item));
                        }
                    }
                    else
                    {
                        adjustedPaymentDates_.Add(new AdjustedPaymentDates(item));
                    }
                }
            }
            
        
        }
        
    
        #region PaymentFrequency_
        private Period paymentFrequency_;
        public Period PaymentFrequency_
        {
            get
            {
                if (this.paymentFrequency_ != null)
                {
                    return this.paymentFrequency_; 
                }
                else if (this.paymentFrequencyIDRef_ != null)
                {
                    paymentFrequency_ = IDManager.getID(paymentFrequencyIDRef_) as Period;
                    return this.paymentFrequency_; 
                }
                else
                {
                      return this.paymentFrequency_; 
                }
            }
            set
            {
                if (this.paymentFrequency_ != value)
                {
                    this.paymentFrequency_ = value;
                }
            }
        }
        #endregion
        
        public string paymentFrequencyIDRef_ { get; set; }
        #region FirstPeriodStartDate_
        private XsdTypeDate firstPeriodStartDate_;
        public XsdTypeDate FirstPeriodStartDate_
        {
            get
            {
                if (this.firstPeriodStartDate_ != null)
                {
                    return this.firstPeriodStartDate_; 
                }
                else if (this.firstPeriodStartDateIDRef_ != null)
                {
                    firstPeriodStartDate_ = IDManager.getID(firstPeriodStartDateIDRef_) as XsdTypeDate;
                    return this.firstPeriodStartDate_; 
                }
                else
                {
                      return this.firstPeriodStartDate_; 
                }
            }
            set
            {
                if (this.firstPeriodStartDate_ != value)
                {
                    this.firstPeriodStartDate_ = value;
                }
            }
        }
        #endregion
        
        public string firstPeriodStartDateIDRef_ { get; set; }
        #region FirstPaymentDate_
        private XsdTypeDate firstPaymentDate_;
        public XsdTypeDate FirstPaymentDate_
        {
            get
            {
                if (this.firstPaymentDate_ != null)
                {
                    return this.firstPaymentDate_; 
                }
                else if (this.firstPaymentDateIDRef_ != null)
                {
                    firstPaymentDate_ = IDManager.getID(firstPaymentDateIDRef_) as XsdTypeDate;
                    return this.firstPaymentDate_; 
                }
                else
                {
                      return this.firstPaymentDate_; 
                }
            }
            set
            {
                if (this.firstPaymentDate_ != value)
                {
                    this.firstPaymentDate_ = value;
                }
            }
        }
        #endregion
        
        public string firstPaymentDateIDRef_ { get; set; }
        #region LastRegularPaymentDate_
        private XsdTypeDate lastRegularPaymentDate_;
        public XsdTypeDate LastRegularPaymentDate_
        {
            get
            {
                if (this.lastRegularPaymentDate_ != null)
                {
                    return this.lastRegularPaymentDate_; 
                }
                else if (this.lastRegularPaymentDateIDRef_ != null)
                {
                    lastRegularPaymentDate_ = IDManager.getID(lastRegularPaymentDateIDRef_) as XsdTypeDate;
                    return this.lastRegularPaymentDate_; 
                }
                else
                {
                      return this.lastRegularPaymentDate_; 
                }
            }
            set
            {
                if (this.lastRegularPaymentDate_ != value)
                {
                    this.lastRegularPaymentDate_ = value;
                }
            }
        }
        #endregion
        
        public string lastRegularPaymentDateIDRef_ { get; set; }
        #region RollConvention_
        private RollConventionEnum rollConvention_;
        public RollConventionEnum RollConvention_
        {
            get
            {
                if (this.rollConvention_ != null)
                {
                    return this.rollConvention_; 
                }
                else if (this.rollConventionIDRef_ != null)
                {
                    rollConvention_ = IDManager.getID(rollConventionIDRef_) as RollConventionEnum;
                    return this.rollConvention_; 
                }
                else
                {
                      return this.rollConvention_; 
                }
            }
            set
            {
                if (this.rollConvention_ != value)
                {
                    this.rollConvention_ = value;
                }
            }
        }
        #endregion
        
        public string rollConventionIDRef_ { get; set; }
        #region FixedAmount_
        private Money fixedAmount_;
        public Money FixedAmount_
        {
            get
            {
                if (this.fixedAmount_ != null)
                {
                    return this.fixedAmount_; 
                }
                else if (this.fixedAmountIDRef_ != null)
                {
                    fixedAmount_ = IDManager.getID(fixedAmountIDRef_) as Money;
                    return this.fixedAmount_; 
                }
                else
                {
                      return this.fixedAmount_; 
                }
            }
            set
            {
                if (this.fixedAmount_ != value)
                {
                    this.fixedAmount_ = value;
                }
            }
        }
        #endregion
        
        public string fixedAmountIDRef_ { get; set; }
        #region FixedAmountCalculation_
        private FixedAmountCalculation fixedAmountCalculation_;
        public FixedAmountCalculation FixedAmountCalculation_
        {
            get
            {
                if (this.fixedAmountCalculation_ != null)
                {
                    return this.fixedAmountCalculation_; 
                }
                else if (this.fixedAmountCalculationIDRef_ != null)
                {
                    fixedAmountCalculation_ = IDManager.getID(fixedAmountCalculationIDRef_) as FixedAmountCalculation;
                    return this.fixedAmountCalculation_; 
                }
                else
                {
                      return this.fixedAmountCalculation_; 
                }
            }
            set
            {
                if (this.fixedAmountCalculation_ != value)
                {
                    this.fixedAmountCalculation_ = value;
                }
            }
        }
        #endregion
        
        public string fixedAmountCalculationIDRef_ { get; set; }
        #region AdjustedPaymentDates_
        private List<AdjustedPaymentDates> adjustedPaymentDates_;
        public List<AdjustedPaymentDates> AdjustedPaymentDates_
        {
            get
            {
                if (this.adjustedPaymentDates_ != null)
                {
                    return this.adjustedPaymentDates_; 
                }
                else if (this.adjustedPaymentDatesIDRef_ != null)
                {
                    return this.adjustedPaymentDates_; 
                }
                else
                {
                      return this.adjustedPaymentDates_; 
                }
            }
            set
            {
                if (this.adjustedPaymentDates_ != value)
                {
                    this.adjustedPaymentDates_ = value;
                }
            }
        }
        #endregion
        
        public string adjustedPaymentDatesIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

