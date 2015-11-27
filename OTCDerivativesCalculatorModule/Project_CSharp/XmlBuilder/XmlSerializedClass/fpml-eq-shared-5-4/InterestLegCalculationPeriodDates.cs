using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class InterestLegCalculationPeriodDates : ISerialized
    {
        public InterestLegCalculationPeriodDates(XmlNode xmlNode)
        {
            XmlNode effectiveDateNode = xmlNode.SelectSingleNode("effectiveDate");
            
            if (effectiveDateNode != null)
            {
                if (effectiveDateNode.Attributes["href"] != null || effectiveDateNode.Attributes["id"] != null) 
                {
                    if (effectiveDateNode.Attributes["id"] != null) 
                    {
                        effectiveDateIDRef_ = effectiveDateNode.Attributes["id"].Value;
                        AdjustableOrRelativeDate ob = new AdjustableOrRelativeDate(effectiveDateNode);
                        IDManager.SetID(effectiveDateIDRef_, ob);
                    }
                    else if (effectiveDateNode.Attributes["href"] != null)
                    {
                        effectiveDateIDRef_ = effectiveDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        effectiveDate_ = new AdjustableOrRelativeDate(effectiveDateNode);
                    }
                }
                else
                {
                    effectiveDate_ = new AdjustableOrRelativeDate(effectiveDateNode);
                }
            }
            
        
            XmlNode terminationDateNode = xmlNode.SelectSingleNode("terminationDate");
            
            if (terminationDateNode != null)
            {
                if (terminationDateNode.Attributes["href"] != null || terminationDateNode.Attributes["id"] != null) 
                {
                    if (terminationDateNode.Attributes["id"] != null) 
                    {
                        terminationDateIDRef_ = terminationDateNode.Attributes["id"].Value;
                        AdjustableOrRelativeDate ob = new AdjustableOrRelativeDate(terminationDateNode);
                        IDManager.SetID(terminationDateIDRef_, ob);
                    }
                    else if (terminationDateNode.Attributes["href"] != null)
                    {
                        terminationDateIDRef_ = terminationDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        terminationDate_ = new AdjustableOrRelativeDate(terminationDateNode);
                    }
                }
                else
                {
                    terminationDate_ = new AdjustableOrRelativeDate(terminationDateNode);
                }
            }
            
        
            XmlNode interestLegResetDatesNode = xmlNode.SelectSingleNode("interestLegResetDates");
            
            if (interestLegResetDatesNode != null)
            {
                if (interestLegResetDatesNode.Attributes["href"] != null || interestLegResetDatesNode.Attributes["id"] != null) 
                {
                    if (interestLegResetDatesNode.Attributes["id"] != null) 
                    {
                        interestLegResetDatesIDRef_ = interestLegResetDatesNode.Attributes["id"].Value;
                        InterestLegResetDates ob = new InterestLegResetDates(interestLegResetDatesNode);
                        IDManager.SetID(interestLegResetDatesIDRef_, ob);
                    }
                    else if (interestLegResetDatesNode.Attributes["href"] != null)
                    {
                        interestLegResetDatesIDRef_ = interestLegResetDatesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        interestLegResetDates_ = new InterestLegResetDates(interestLegResetDatesNode);
                    }
                }
                else
                {
                    interestLegResetDates_ = new InterestLegResetDates(interestLegResetDatesNode);
                }
            }
            
        
            XmlNode interestLegPaymentDatesNode = xmlNode.SelectSingleNode("interestLegPaymentDates");
            
            if (interestLegPaymentDatesNode != null)
            {
                if (interestLegPaymentDatesNode.Attributes["href"] != null || interestLegPaymentDatesNode.Attributes["id"] != null) 
                {
                    if (interestLegPaymentDatesNode.Attributes["id"] != null) 
                    {
                        interestLegPaymentDatesIDRef_ = interestLegPaymentDatesNode.Attributes["id"].Value;
                        AdjustableRelativeOrPeriodicDates2 ob = new AdjustableRelativeOrPeriodicDates2(interestLegPaymentDatesNode);
                        IDManager.SetID(interestLegPaymentDatesIDRef_, ob);
                    }
                    else if (interestLegPaymentDatesNode.Attributes["href"] != null)
                    {
                        interestLegPaymentDatesIDRef_ = interestLegPaymentDatesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        interestLegPaymentDates_ = new AdjustableRelativeOrPeriodicDates2(interestLegPaymentDatesNode);
                    }
                }
                else
                {
                    interestLegPaymentDates_ = new AdjustableRelativeOrPeriodicDates2(interestLegPaymentDatesNode);
                }
            }
            
        
        }
        
    
        #region EffectiveDate_
        private AdjustableOrRelativeDate effectiveDate_;
        public AdjustableOrRelativeDate EffectiveDate_
        {
            get
            {
                if (this.effectiveDate_ != null)
                {
                    return this.effectiveDate_; 
                }
                else if (this.effectiveDateIDRef_ != null)
                {
                    effectiveDate_ = IDManager.getID(effectiveDateIDRef_) as AdjustableOrRelativeDate;
                    return this.effectiveDate_; 
                }
                else
                {
                      return this.effectiveDate_; 
                }
            }
            set
            {
                if (this.effectiveDate_ != value)
                {
                    this.effectiveDate_ = value;
                }
            }
        }
        #endregion
        
        public string effectiveDateIDRef_ { get; set; }
        #region TerminationDate_
        private AdjustableOrRelativeDate terminationDate_;
        public AdjustableOrRelativeDate TerminationDate_
        {
            get
            {
                if (this.terminationDate_ != null)
                {
                    return this.terminationDate_; 
                }
                else if (this.terminationDateIDRef_ != null)
                {
                    terminationDate_ = IDManager.getID(terminationDateIDRef_) as AdjustableOrRelativeDate;
                    return this.terminationDate_; 
                }
                else
                {
                      return this.terminationDate_; 
                }
            }
            set
            {
                if (this.terminationDate_ != value)
                {
                    this.terminationDate_ = value;
                }
            }
        }
        #endregion
        
        public string terminationDateIDRef_ { get; set; }
        #region InterestLegResetDates_
        private InterestLegResetDates interestLegResetDates_;
        public InterestLegResetDates InterestLegResetDates_
        {
            get
            {
                if (this.interestLegResetDates_ != null)
                {
                    return this.interestLegResetDates_; 
                }
                else if (this.interestLegResetDatesIDRef_ != null)
                {
                    interestLegResetDates_ = IDManager.getID(interestLegResetDatesIDRef_) as InterestLegResetDates;
                    return this.interestLegResetDates_; 
                }
                else
                {
                      return this.interestLegResetDates_; 
                }
            }
            set
            {
                if (this.interestLegResetDates_ != value)
                {
                    this.interestLegResetDates_ = value;
                }
            }
        }
        #endregion
        
        public string interestLegResetDatesIDRef_ { get; set; }
        #region InterestLegPaymentDates_
        private AdjustableRelativeOrPeriodicDates2 interestLegPaymentDates_;
        public AdjustableRelativeOrPeriodicDates2 InterestLegPaymentDates_
        {
            get
            {
                if (this.interestLegPaymentDates_ != null)
                {
                    return this.interestLegPaymentDates_; 
                }
                else if (this.interestLegPaymentDatesIDRef_ != null)
                {
                    interestLegPaymentDates_ = IDManager.getID(interestLegPaymentDatesIDRef_) as AdjustableRelativeOrPeriodicDates2;
                    return this.interestLegPaymentDates_; 
                }
                else
                {
                      return this.interestLegPaymentDates_; 
                }
            }
            set
            {
                if (this.interestLegPaymentDates_ != value)
                {
                    this.interestLegPaymentDates_ = value;
                }
            }
        }
        #endregion
        
        public string interestLegPaymentDatesIDRef_ { get; set; }
        
    
        
    
    }
    
}

