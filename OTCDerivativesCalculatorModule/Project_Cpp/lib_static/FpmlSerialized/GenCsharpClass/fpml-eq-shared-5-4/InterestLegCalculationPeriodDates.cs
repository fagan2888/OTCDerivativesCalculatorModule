using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class InterestLegCalculationPeriodDates
    {
        public InterestLegCalculationPeriodDates(XmlNode xmlNode)
        {
            XmlNodeList effectiveDateNodeList = xmlNode.SelectNodes("effectiveDate");
            if (effectiveDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in effectiveDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        effectiveDateIDRef = item.Attributes["id"].Name;
                        AdjustableOrRelativeDate ob = AdjustableOrRelativeDate();
                        IDManager.SetID(effectiveDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        effectiveDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        effectiveDate = new AdjustableOrRelativeDate(item);
                    }
                }
            }
            
        
            XmlNodeList terminationDateNodeList = xmlNode.SelectNodes("terminationDate");
            if (terminationDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in terminationDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        terminationDateIDRef = item.Attributes["id"].Name;
                        AdjustableOrRelativeDate ob = AdjustableOrRelativeDate();
                        IDManager.SetID(terminationDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        terminationDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        terminationDate = new AdjustableOrRelativeDate(item);
                    }
                }
            }
            
        
            XmlNodeList interestLegResetDatesNodeList = xmlNode.SelectNodes("interestLegResetDates");
            if (interestLegResetDatesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in interestLegResetDatesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        interestLegResetDatesIDRef = item.Attributes["id"].Name;
                        InterestLegResetDates ob = InterestLegResetDates();
                        IDManager.SetID(interestLegResetDatesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        interestLegResetDatesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        interestLegResetDates = new InterestLegResetDates(item);
                    }
                }
            }
            
        
            XmlNodeList interestLegPaymentDatesNodeList = xmlNode.SelectNodes("interestLegPaymentDates");
            if (interestLegPaymentDatesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in interestLegPaymentDatesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        interestLegPaymentDatesIDRef = item.Attributes["id"].Name;
                        AdjustableRelativeOrPeriodicDates2 ob = AdjustableRelativeOrPeriodicDates2();
                        IDManager.SetID(interestLegPaymentDatesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        interestLegPaymentDatesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        interestLegPaymentDates = new AdjustableRelativeOrPeriodicDates2(item);
                    }
                }
            }
            
        
        }
        
    
        #region EffectiveDate
        private AdjustableOrRelativeDate effectiveDate;
        public AdjustableOrRelativeDate EffectiveDate
        {
            get
            {
                if (this.effectiveDate != null)
                {
                    return this.effectiveDate; 
                }
                else if (this.effectiveDateIDRef != null)
                {
                    effectiveDate = IDManager.getID(effectiveDateIDRef) as AdjustableOrRelativeDate;
                    return this.effectiveDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.effectiveDate != value)
                {
                    this.effectiveDate = value;
                }
            }
        }
        #endregion
        
        public string AdjustableOrRelativeDateIDRef { get; set; }
        #region TerminationDate
        private AdjustableOrRelativeDate terminationDate;
        public AdjustableOrRelativeDate TerminationDate
        {
            get
            {
                if (this.terminationDate != null)
                {
                    return this.terminationDate; 
                }
                else if (this.terminationDateIDRef != null)
                {
                    terminationDate = IDManager.getID(terminationDateIDRef) as AdjustableOrRelativeDate;
                    return this.terminationDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.terminationDate != value)
                {
                    this.terminationDate = value;
                }
            }
        }
        #endregion
        
        public string AdjustableOrRelativeDateIDRef { get; set; }
        #region InterestLegResetDates
        private InterestLegResetDates interestLegResetDates;
        public InterestLegResetDates InterestLegResetDates
        {
            get
            {
                if (this.interestLegResetDates != null)
                {
                    return this.interestLegResetDates; 
                }
                else if (this.interestLegResetDatesIDRef != null)
                {
                    interestLegResetDates = IDManager.getID(interestLegResetDatesIDRef) as InterestLegResetDates;
                    return this.interestLegResetDates; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.interestLegResetDates != value)
                {
                    this.interestLegResetDates = value;
                }
            }
        }
        #endregion
        
        public string InterestLegResetDatesIDRef { get; set; }
        #region InterestLegPaymentDates
        private AdjustableRelativeOrPeriodicDates2 interestLegPaymentDates;
        public AdjustableRelativeOrPeriodicDates2 InterestLegPaymentDates
        {
            get
            {
                if (this.interestLegPaymentDates != null)
                {
                    return this.interestLegPaymentDates; 
                }
                else if (this.interestLegPaymentDatesIDRef != null)
                {
                    interestLegPaymentDates = IDManager.getID(interestLegPaymentDatesIDRef) as AdjustableRelativeOrPeriodicDates2;
                    return this.interestLegPaymentDates; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.interestLegPaymentDates != value)
                {
                    this.interestLegPaymentDates = value;
                }
            }
        }
        #endregion
        
        public string AdjustableRelativeOrPeriodicDates2IDRef { get; set; }
        
    
        
    
    }
    
}

