using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class SimpleIRSwap : UnderlyingAsset
    {
        public SimpleIRSwap(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode termNode = xmlNode.SelectSingleNode("term");
            
            if (termNode != null)
            {
                if (termNode.Attributes["href"] != null || termNode.Attributes["id"] != null) 
                {
                    if (termNode.Attributes["id"] != null) 
                    {
                        termIDRef_ = termNode.Attributes["id"].Value;
                        Period ob = new Period(termNode);
                        IDManager.SetID(termIDRef_, ob);
                    }
                    else if (termNode.Attributes["href"] != null)
                    {
                        termIDRef_ = termNode.Attributes["href"].Value;
                    }
                    else
                    {
                        term_ = new Period(termNode);
                    }
                }
                else
                {
                    term_ = new Period(termNode);
                }
            }
            
        
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
            
        
            XmlNode dayCountFractionNode = xmlNode.SelectSingleNode("dayCountFraction");
            
            if (dayCountFractionNode != null)
            {
                if (dayCountFractionNode.Attributes["href"] != null || dayCountFractionNode.Attributes["id"] != null) 
                {
                    if (dayCountFractionNode.Attributes["id"] != null) 
                    {
                        dayCountFractionIDRef_ = dayCountFractionNode.Attributes["id"].Value;
                        DayCountFraction ob = new DayCountFraction(dayCountFractionNode);
                        IDManager.SetID(dayCountFractionIDRef_, ob);
                    }
                    else if (dayCountFractionNode.Attributes["href"] != null)
                    {
                        dayCountFractionIDRef_ = dayCountFractionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dayCountFraction_ = new DayCountFraction(dayCountFractionNode);
                    }
                }
                else
                {
                    dayCountFraction_ = new DayCountFraction(dayCountFractionNode);
                }
            }
            
        
        }
        
    
        #region Term_
        private Period term_;
        public Period Term_
        {
            get
            {
                if (this.term_ != null)
                {
                    return this.term_; 
                }
                else if (this.termIDRef_ != null)
                {
                    term_ = IDManager.getID(termIDRef_) as Period;
                    return this.term_; 
                }
                else
                {
                      return this.term_; 
                }
            }
            set
            {
                if (this.term_ != value)
                {
                    this.term_ = value;
                }
            }
        }
        #endregion
        
        public string termIDRef_ { get; set; }
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
        #region DayCountFraction_
        private DayCountFraction dayCountFraction_;
        public DayCountFraction DayCountFraction_
        {
            get
            {
                if (this.dayCountFraction_ != null)
                {
                    return this.dayCountFraction_; 
                }
                else if (this.dayCountFractionIDRef_ != null)
                {
                    dayCountFraction_ = IDManager.getID(dayCountFractionIDRef_) as DayCountFraction;
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
        
    
        
    
    }
    
}

