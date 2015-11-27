using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PaymentCalculationPeriod : PaymentBase
    {
        public PaymentCalculationPeriod(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode unadjustedPaymentDateNode = xmlNode.SelectSingleNode("unadjustedPaymentDate");
            
            if (unadjustedPaymentDateNode != null)
            {
                if (unadjustedPaymentDateNode.Attributes["href"] != null || unadjustedPaymentDateNode.Attributes["id"] != null) 
                {
                    if (unadjustedPaymentDateNode.Attributes["id"] != null) 
                    {
                        unadjustedPaymentDateIDRef_ = unadjustedPaymentDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(unadjustedPaymentDateNode);
                        IDManager.SetID(unadjustedPaymentDateIDRef_, ob);
                    }
                    else if (unadjustedPaymentDateNode.Attributes["href"] != null)
                    {
                        unadjustedPaymentDateIDRef_ = unadjustedPaymentDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        unadjustedPaymentDate_ = new XsdTypeDate(unadjustedPaymentDateNode);
                    }
                }
                else
                {
                    unadjustedPaymentDate_ = new XsdTypeDate(unadjustedPaymentDateNode);
                }
            }
            
        
            XmlNode adjustedPaymentDateNode = xmlNode.SelectSingleNode("adjustedPaymentDate");
            
            if (adjustedPaymentDateNode != null)
            {
                if (adjustedPaymentDateNode.Attributes["href"] != null || adjustedPaymentDateNode.Attributes["id"] != null) 
                {
                    if (adjustedPaymentDateNode.Attributes["id"] != null) 
                    {
                        adjustedPaymentDateIDRef_ = adjustedPaymentDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(adjustedPaymentDateNode);
                        IDManager.SetID(adjustedPaymentDateIDRef_, ob);
                    }
                    else if (adjustedPaymentDateNode.Attributes["href"] != null)
                    {
                        adjustedPaymentDateIDRef_ = adjustedPaymentDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        adjustedPaymentDate_ = new XsdTypeDate(adjustedPaymentDateNode);
                    }
                }
                else
                {
                    adjustedPaymentDate_ = new XsdTypeDate(adjustedPaymentDateNode);
                }
            }
            
        
            XmlNodeList calculationPeriodNodeList = xmlNode.SelectNodes("calculationPeriod");
            
            if (calculationPeriodNodeList != null)
            {
                this.calculationPeriod_ = new List<CalculationPeriod>();
                foreach (XmlNode item in calculationPeriodNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            calculationPeriodIDRef_ = item.Attributes["id"].Value;
                            calculationPeriod_.Add(new CalculationPeriod(item));
                            IDManager.SetID(calculationPeriodIDRef_, calculationPeriod_[calculationPeriod_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            calculationPeriodIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        calculationPeriod_.Add(new CalculationPeriod(item));
                        }
                    }
                    else
                    {
                        calculationPeriod_.Add(new CalculationPeriod(item));
                    }
                }
            }
            
        
            XmlNode fixedPaymentAmountNode = xmlNode.SelectSingleNode("fixedPaymentAmount");
            
            if (fixedPaymentAmountNode != null)
            {
                if (fixedPaymentAmountNode.Attributes["href"] != null || fixedPaymentAmountNode.Attributes["id"] != null) 
                {
                    if (fixedPaymentAmountNode.Attributes["id"] != null) 
                    {
                        fixedPaymentAmountIDRef_ = fixedPaymentAmountNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(fixedPaymentAmountNode);
                        IDManager.SetID(fixedPaymentAmountIDRef_, ob);
                    }
                    else if (fixedPaymentAmountNode.Attributes["href"] != null)
                    {
                        fixedPaymentAmountIDRef_ = fixedPaymentAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fixedPaymentAmount_ = new XsdTypeDecimal(fixedPaymentAmountNode);
                    }
                }
                else
                {
                    fixedPaymentAmount_ = new XsdTypeDecimal(fixedPaymentAmountNode);
                }
            }
            
        
            XmlNode discountFactorNode = xmlNode.SelectSingleNode("discountFactor");
            
            if (discountFactorNode != null)
            {
                if (discountFactorNode.Attributes["href"] != null || discountFactorNode.Attributes["id"] != null) 
                {
                    if (discountFactorNode.Attributes["id"] != null) 
                    {
                        discountFactorIDRef_ = discountFactorNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(discountFactorNode);
                        IDManager.SetID(discountFactorIDRef_, ob);
                    }
                    else if (discountFactorNode.Attributes["href"] != null)
                    {
                        discountFactorIDRef_ = discountFactorNode.Attributes["href"].Value;
                    }
                    else
                    {
                        discountFactor_ = new XsdTypeDecimal(discountFactorNode);
                    }
                }
                else
                {
                    discountFactor_ = new XsdTypeDecimal(discountFactorNode);
                }
            }
            
        
            XmlNode forecastPaymentAmountNode = xmlNode.SelectSingleNode("forecastPaymentAmount");
            
            if (forecastPaymentAmountNode != null)
            {
                if (forecastPaymentAmountNode.Attributes["href"] != null || forecastPaymentAmountNode.Attributes["id"] != null) 
                {
                    if (forecastPaymentAmountNode.Attributes["id"] != null) 
                    {
                        forecastPaymentAmountIDRef_ = forecastPaymentAmountNode.Attributes["id"].Value;
                        Money ob = new Money(forecastPaymentAmountNode);
                        IDManager.SetID(forecastPaymentAmountIDRef_, ob);
                    }
                    else if (forecastPaymentAmountNode.Attributes["href"] != null)
                    {
                        forecastPaymentAmountIDRef_ = forecastPaymentAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        forecastPaymentAmount_ = new Money(forecastPaymentAmountNode);
                    }
                }
                else
                {
                    forecastPaymentAmount_ = new Money(forecastPaymentAmountNode);
                }
            }
            
        
            XmlNode presentValueAmountNode = xmlNode.SelectSingleNode("presentValueAmount");
            
            if (presentValueAmountNode != null)
            {
                if (presentValueAmountNode.Attributes["href"] != null || presentValueAmountNode.Attributes["id"] != null) 
                {
                    if (presentValueAmountNode.Attributes["id"] != null) 
                    {
                        presentValueAmountIDRef_ = presentValueAmountNode.Attributes["id"].Value;
                        Money ob = new Money(presentValueAmountNode);
                        IDManager.SetID(presentValueAmountIDRef_, ob);
                    }
                    else if (presentValueAmountNode.Attributes["href"] != null)
                    {
                        presentValueAmountIDRef_ = presentValueAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        presentValueAmount_ = new Money(presentValueAmountNode);
                    }
                }
                else
                {
                    presentValueAmount_ = new Money(presentValueAmountNode);
                }
            }
            
        
        }
        
    
        #region UnadjustedPaymentDate_
        private XsdTypeDate unadjustedPaymentDate_;
        public XsdTypeDate UnadjustedPaymentDate_
        {
            get
            {
                if (this.unadjustedPaymentDate_ != null)
                {
                    return this.unadjustedPaymentDate_; 
                }
                else if (this.unadjustedPaymentDateIDRef_ != null)
                {
                    unadjustedPaymentDate_ = IDManager.getID(unadjustedPaymentDateIDRef_) as XsdTypeDate;
                    return this.unadjustedPaymentDate_; 
                }
                else
                {
                      return this.unadjustedPaymentDate_; 
                }
            }
            set
            {
                if (this.unadjustedPaymentDate_ != value)
                {
                    this.unadjustedPaymentDate_ = value;
                }
            }
        }
        #endregion
        
        public string unadjustedPaymentDateIDRef_ { get; set; }
        #region AdjustedPaymentDate_
        private XsdTypeDate adjustedPaymentDate_;
        public XsdTypeDate AdjustedPaymentDate_
        {
            get
            {
                if (this.adjustedPaymentDate_ != null)
                {
                    return this.adjustedPaymentDate_; 
                }
                else if (this.adjustedPaymentDateIDRef_ != null)
                {
                    adjustedPaymentDate_ = IDManager.getID(adjustedPaymentDateIDRef_) as XsdTypeDate;
                    return this.adjustedPaymentDate_; 
                }
                else
                {
                      return this.adjustedPaymentDate_; 
                }
            }
            set
            {
                if (this.adjustedPaymentDate_ != value)
                {
                    this.adjustedPaymentDate_ = value;
                }
            }
        }
        #endregion
        
        public string adjustedPaymentDateIDRef_ { get; set; }
        #region CalculationPeriod_
        private List<CalculationPeriod> calculationPeriod_;
        public List<CalculationPeriod> CalculationPeriod_
        {
            get
            {
                if (this.calculationPeriod_ != null)
                {
                    return this.calculationPeriod_; 
                }
                else if (this.calculationPeriodIDRef_ != null)
                {
                    return this.calculationPeriod_; 
                }
                else
                {
                      return this.calculationPeriod_; 
                }
            }
            set
            {
                if (this.calculationPeriod_ != value)
                {
                    this.calculationPeriod_ = value;
                }
            }
        }
        #endregion
        
        public string calculationPeriodIDRef_ { get; set; }
        #region FixedPaymentAmount_
        private XsdTypeDecimal fixedPaymentAmount_;
        public XsdTypeDecimal FixedPaymentAmount_
        {
            get
            {
                if (this.fixedPaymentAmount_ != null)
                {
                    return this.fixedPaymentAmount_; 
                }
                else if (this.fixedPaymentAmountIDRef_ != null)
                {
                    fixedPaymentAmount_ = IDManager.getID(fixedPaymentAmountIDRef_) as XsdTypeDecimal;
                    return this.fixedPaymentAmount_; 
                }
                else
                {
                      return this.fixedPaymentAmount_; 
                }
            }
            set
            {
                if (this.fixedPaymentAmount_ != value)
                {
                    this.fixedPaymentAmount_ = value;
                }
            }
        }
        #endregion
        
        public string fixedPaymentAmountIDRef_ { get; set; }
        #region DiscountFactor_
        private XsdTypeDecimal discountFactor_;
        public XsdTypeDecimal DiscountFactor_
        {
            get
            {
                if (this.discountFactor_ != null)
                {
                    return this.discountFactor_; 
                }
                else if (this.discountFactorIDRef_ != null)
                {
                    discountFactor_ = IDManager.getID(discountFactorIDRef_) as XsdTypeDecimal;
                    return this.discountFactor_; 
                }
                else
                {
                      return this.discountFactor_; 
                }
            }
            set
            {
                if (this.discountFactor_ != value)
                {
                    this.discountFactor_ = value;
                }
            }
        }
        #endregion
        
        public string discountFactorIDRef_ { get; set; }
        #region ForecastPaymentAmount_
        private Money forecastPaymentAmount_;
        public Money ForecastPaymentAmount_
        {
            get
            {
                if (this.forecastPaymentAmount_ != null)
                {
                    return this.forecastPaymentAmount_; 
                }
                else if (this.forecastPaymentAmountIDRef_ != null)
                {
                    forecastPaymentAmount_ = IDManager.getID(forecastPaymentAmountIDRef_) as Money;
                    return this.forecastPaymentAmount_; 
                }
                else
                {
                      return this.forecastPaymentAmount_; 
                }
            }
            set
            {
                if (this.forecastPaymentAmount_ != value)
                {
                    this.forecastPaymentAmount_ = value;
                }
            }
        }
        #endregion
        
        public string forecastPaymentAmountIDRef_ { get; set; }
        #region PresentValueAmount_
        private Money presentValueAmount_;
        public Money PresentValueAmount_
        {
            get
            {
                if (this.presentValueAmount_ != null)
                {
                    return this.presentValueAmount_; 
                }
                else if (this.presentValueAmountIDRef_ != null)
                {
                    presentValueAmount_ = IDManager.getID(presentValueAmountIDRef_) as Money;
                    return this.presentValueAmount_; 
                }
                else
                {
                      return this.presentValueAmount_; 
                }
            }
            set
            {
                if (this.presentValueAmount_ != value)
                {
                    this.presentValueAmount_ = value;
                }
            }
        }
        #endregion
        
        public string presentValueAmountIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

