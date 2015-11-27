using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace RiskMonitor
{
    public partial class IRCalculation : ISerialized
    {
        public IRCalculation() { }
        public IRCalculation(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode paymentDatesNode = xmlNode.SelectSingleNode("paymentDates");
            
            if (paymentDatesNode != null)
            {
                if (paymentDatesNode.Attributes["href"] != null || paymentDatesNode.Attributes["id"] != null) 
                {
                    if (paymentDatesNode.Attributes["id"] != null) 
                    {
                        paymentDatesIDRef_ = paymentDatesNode.Attributes["id"].Value;
                        SchduleGen ob = new SchduleGen(paymentDatesNode);
                        IDManager.SetID(paymentDatesIDRef_, ob);
                    }
                    else if (paymentDatesNode.Attributes["href"] != null)
                    {
                        paymentDatesIDRef_ = paymentDatesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        paymentDates_ = new SchduleGen(paymentDatesNode);
                    }
                }
                else
                {
                    paymentDates_ = new SchduleGen(paymentDatesNode);
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
                        FixedRate ob = new FixedRate(fixedRateNode);
                        IDManager.SetID(fixedRateIDRef_, ob);
                    }
                    else if (fixedRateNode.Attributes["href"] != null)
                    {
                        fixedRateIDRef_ = fixedRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fixedRate_ = new FixedRate(fixedRateNode);
                    }
                }
                else
                {
                    fixedRate_ = new FixedRate(fixedRateNode);
                }
            }
            
        
            XmlNode dayCountFractionNode = xmlNode.SelectSingleNode("dayCountFraction");
            
            if (dayCountFractionNode != null)
            {
                if (dayCountFractionNode.Attributes["href"] != null || dayCountFractionNode.Attributes["id"] != null) 
                {
                    if (dayCountFractionNode.Attributes["id"] != null) 
                    {
                        dayCountFractionIDRef_ = dayCountFractionNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(dayCountFractionNode);
                        IDManager.SetID(dayCountFractionIDRef_, ob);
                    }
                    else if (dayCountFractionNode.Attributes["href"] != null)
                    {
                        dayCountFractionIDRef_ = dayCountFractionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dayCountFraction_ = new XsdTypeToken(dayCountFractionNode);
                    }
                }
                else
                {
                    dayCountFraction_ = new XsdTypeToken(dayCountFractionNode);
                }
            }
            
        
            XmlNode inArrearNode = xmlNode.SelectSingleNode("inArrear");
            
            if (inArrearNode != null)
            {
                if (inArrearNode.Attributes["href"] != null || inArrearNode.Attributes["id"] != null) 
                {
                    if (inArrearNode.Attributes["id"] != null) 
                    {
                        inArrearIDRef_ = inArrearNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(inArrearNode);
                        IDManager.SetID(inArrearIDRef_, ob);
                    }
                    else if (inArrearNode.Attributes["href"] != null)
                    {
                        inArrearIDRef_ = inArrearNode.Attributes["href"].Value;
                    }
                    else
                    {
                        inArrear_ = new XsdTypeBoolean(inArrearNode);
                    }
                }
                else
                {
                    inArrear_ = new XsdTypeBoolean(inArrearNode);
                }
            }
            
        
        }
        
    
        #region PaymentDates_
        private SchduleGen paymentDates_;
        public SchduleGen PaymentDates_
        {
            get
            {
                if (this.paymentDates_ != null)
                {
                    return this.paymentDates_; 
                }
                else if (this.paymentDatesIDRef_ != null)
                {
                    paymentDates_ = IDManager.getID(paymentDatesIDRef_) as SchduleGen;
                    return this.paymentDates_; 
                }
                else
                {
                      return this.paymentDates_; 
                }
            }
            set
            {
                if (this.paymentDates_ != value)
                {
                    this.paymentDates_ = value;
                }
            }
        }
        #endregion
        
        public string paymentDatesIDRef_ { get; set; }
        #region FixedRate_
        private FixedRate fixedRate_;
        public FixedRate FixedRate_
        {
            get
            {
                if (this.fixedRate_ != null)
                {
                    return this.fixedRate_; 
                }
                else if (this.fixedRateIDRef_ != null)
                {
                    fixedRate_ = IDManager.getID(fixedRateIDRef_) as FixedRate;
                    return this.fixedRate_; 
                }
                else
                {
                      return this.fixedRate_; 
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
        #region DayCountFraction_
        private XsdTypeToken dayCountFraction_;
        public XsdTypeToken DayCountFraction_
        {
            get
            {
                if (this.dayCountFraction_ != null)
                {
                    return this.dayCountFraction_; 
                }
                else if (this.dayCountFractionIDRef_ != null)
                {
                    dayCountFraction_ = IDManager.getID(dayCountFractionIDRef_) as XsdTypeToken;
                    return this.dayCountFraction_; 
                }
                else
                {
                      return this.dayCountFraction_; 
                }
            }
            set
            {
                if (this.dayCountFraction_ != value)
                {
                    this.dayCountFraction_ = value;
                }
            }
        }
        #endregion
        
        public string dayCountFractionIDRef_ { get; set; }
        #region InArrear_
        private XsdTypeBoolean inArrear_;
        public XsdTypeBoolean InArrear_
        {
            get
            {
                if (this.inArrear_ != null)
                {
                    return this.inArrear_; 
                }
                else if (this.inArrearIDRef_ != null)
                {
                    inArrear_ = IDManager.getID(inArrearIDRef_) as XsdTypeBoolean;
                    return this.inArrear_; 
                }
                else
                {
                      return this.inArrear_; 
                }
            }
            set
            {
                if (this.inArrear_ != value)
                {
                    this.inArrear_ = value;
                }
            }
        }
        #endregion
        
        public string inArrearIDRef_ { get; set; }
        public string choiceStr_couponType;
        
    
        
    
    }
    
}

