using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_fixedBond_subSchedule : ISerialized
    {
        public Excel_fixedBond_subSchedule() { }
        public Excel_fixedBond_subSchedule(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode eventDateNode = xmlNode.SelectSingleNode("eventDate");
            
            if (eventDateNode != null)
            {
                if (eventDateNode.Attributes["href"] != null || eventDateNode.Attributes["id"] != null) 
                {
                    if (eventDateNode.Attributes["id"] != null) 
                    {
                        eventDateIDRef_ = eventDateNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(eventDateNode);
                        IDManager.SetID(eventDateIDRef_, ob);
                    }
                    else if (eventDateNode.Attributes["href"] != null)
                    {
                        eventDateIDRef_ = eventDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        eventDate_ = new XsdTypeToken(eventDateNode);
                    }
                }
                else
                {
                    eventDate_ = new XsdTypeToken(eventDateNode);
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
                        XsdTypeToken ob = new XsdTypeToken(calculationStartDateNode);
                        IDManager.SetID(calculationStartDateIDRef_, ob);
                    }
                    else if (calculationStartDateNode.Attributes["href"] != null)
                    {
                        calculationStartDateIDRef_ = calculationStartDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculationStartDate_ = new XsdTypeToken(calculationStartDateNode);
                    }
                }
                else
                {
                    calculationStartDate_ = new XsdTypeToken(calculationStartDateNode);
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
                        XsdTypeToken ob = new XsdTypeToken(calculationEndDateNode);
                        IDManager.SetID(calculationEndDateIDRef_, ob);
                    }
                    else if (calculationEndDateNode.Attributes["href"] != null)
                    {
                        calculationEndDateIDRef_ = calculationEndDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculationEndDate_ = new XsdTypeToken(calculationEndDateNode);
                    }
                }
                else
                {
                    calculationEndDate_ = new XsdTypeToken(calculationEndDateNode);
                }
            }
            
        
            XmlNode paymentDateNode = xmlNode.SelectSingleNode("paymentDate");
            
            if (paymentDateNode != null)
            {
                if (paymentDateNode.Attributes["href"] != null || paymentDateNode.Attributes["id"] != null) 
                {
                    if (paymentDateNode.Attributes["id"] != null) 
                    {
                        paymentDateIDRef_ = paymentDateNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(paymentDateNode);
                        IDManager.SetID(paymentDateIDRef_, ob);
                    }
                    else if (paymentDateNode.Attributes["href"] != null)
                    {
                        paymentDateIDRef_ = paymentDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        paymentDate_ = new XsdTypeToken(paymentDateNode);
                    }
                }
                else
                {
                    paymentDate_ = new XsdTypeToken(paymentDateNode);
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
            
        
        }
        
    
        #region EventDate_
        private XsdTypeToken eventDate_;
        public XsdTypeToken EventDate_
        {
            get
            {
                if (this.eventDate_ != null)
                {
                    return this.eventDate_; 
                }
                else if (this.eventDateIDRef_ != null)
                {
                    eventDate_ = IDManager.getID(eventDateIDRef_) as XsdTypeToken;
                    return this.eventDate_; 
                }
                else
                {
                    throw new Exception( "eventDate_Node no exist!");
                }
            }
            set
            {
                if (this.eventDate_ != value)
                {
                    this.eventDate_ = value;
                }
            }
        }
        #endregion
        
        public string eventDateIDRef_ { get; set; }
        #region CalculationStartDate_
        private XsdTypeToken calculationStartDate_;
        public XsdTypeToken CalculationStartDate_
        {
            get
            {
                if (this.calculationStartDate_ != null)
                {
                    return this.calculationStartDate_; 
                }
                else if (this.calculationStartDateIDRef_ != null)
                {
                    calculationStartDate_ = IDManager.getID(calculationStartDateIDRef_) as XsdTypeToken;
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
        private XsdTypeToken calculationEndDate_;
        public XsdTypeToken CalculationEndDate_
        {
            get
            {
                if (this.calculationEndDate_ != null)
                {
                    return this.calculationEndDate_; 
                }
                else if (this.calculationEndDateIDRef_ != null)
                {
                    calculationEndDate_ = IDManager.getID(calculationEndDateIDRef_) as XsdTypeToken;
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
        #region PaymentDate_
        private XsdTypeToken paymentDate_;
        public XsdTypeToken PaymentDate_
        {
            get
            {
                if (this.paymentDate_ != null)
                {
                    return this.paymentDate_; 
                }
                else if (this.paymentDateIDRef_ != null)
                {
                    paymentDate_ = IDManager.getID(paymentDateIDRef_) as XsdTypeToken;
                    return this.paymentDate_; 
                }
                else
                {
                    throw new Exception( "paymentDate_Node no exist!");
                }
            }
            set
            {
                if (this.paymentDate_ != value)
                {
                    this.paymentDate_ = value;
                }
            }
        }
        #endregion
        
        public string paymentDateIDRef_ { get; set; }
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
        
    
        
    
    }
    
}

