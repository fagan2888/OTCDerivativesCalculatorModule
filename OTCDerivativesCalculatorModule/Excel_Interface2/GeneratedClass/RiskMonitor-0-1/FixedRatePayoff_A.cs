using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FixedRatePayoff_A : ISerialized
    {
        public FixedRatePayoff_A() { }
        public FixedRatePayoff_A(XmlNode xmlNode)
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
        
    
        
    
    }
    
}

