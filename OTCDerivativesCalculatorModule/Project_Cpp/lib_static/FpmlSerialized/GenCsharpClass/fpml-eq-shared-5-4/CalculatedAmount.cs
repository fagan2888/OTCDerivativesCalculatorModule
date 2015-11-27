using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CalculatedAmount
    {
        public CalculatedAmount(XmlNode xmlNode)
        {
            XmlNodeList calculationDatesNodeList = xmlNode.SelectNodes("calculationDates");
            if (calculationDatesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in calculationDatesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        calculationDatesIDRef = item.Attributes["id"].Name;
                        AdjustableRelativeOrPeriodicDates ob = AdjustableRelativeOrPeriodicDates();
                        IDManager.SetID(calculationDatesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        calculationDatesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        calculationDates = new AdjustableRelativeOrPeriodicDates(item);
                    }
                }
            }
            
        
            XmlNodeList observationStartDateNodeList = xmlNode.SelectNodes("observationStartDate");
            if (observationStartDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in observationStartDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        observationStartDateIDRef = item.Attributes["id"].Name;
                        AdjustableOrRelativeDate ob = AdjustableOrRelativeDate();
                        IDManager.SetID(observationStartDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        observationStartDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        observationStartDate = new AdjustableOrRelativeDate(item);
                    }
                }
            }
            
        
            XmlNodeList optionsExchangeDividendsNodeList = xmlNode.SelectNodes("optionsExchangeDividends");
            if (optionsExchangeDividendsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in optionsExchangeDividendsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        optionsExchangeDividendsIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(optionsExchangeDividendsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        optionsExchangeDividendsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        optionsExchangeDividends = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList additionalDividendsNodeList = xmlNode.SelectNodes("additionalDividends");
            if (additionalDividendsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in additionalDividendsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        additionalDividendsIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(additionalDividendsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        additionalDividendsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        additionalDividends = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList allDividendsNodeList = xmlNode.SelectNodes("allDividends");
            if (allDividendsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in allDividendsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        allDividendsIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(allDividendsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        allDividendsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        allDividends = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
        }
        
    
        #region CalculationDates
        private AdjustableRelativeOrPeriodicDates calculationDates;
        public AdjustableRelativeOrPeriodicDates CalculationDates
        {
            get
            {
                if (this.calculationDates != null)
                {
                    return this.calculationDates; 
                }
                else if (this.calculationDatesIDRef != null)
                {
                    calculationDates = IDManager.getID(calculationDatesIDRef) as AdjustableRelativeOrPeriodicDates;
                    return this.calculationDates; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.calculationDates != value)
                {
                    this.calculationDates = value;
                }
            }
        }
        #endregion
        
        public string AdjustableRelativeOrPeriodicDatesIDRef { get; set; }
        #region ObservationStartDate
        private AdjustableOrRelativeDate observationStartDate;
        public AdjustableOrRelativeDate ObservationStartDate
        {
            get
            {
                if (this.observationStartDate != null)
                {
                    return this.observationStartDate; 
                }
                else if (this.observationStartDateIDRef != null)
                {
                    observationStartDate = IDManager.getID(observationStartDateIDRef) as AdjustableOrRelativeDate;
                    return this.observationStartDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.observationStartDate != value)
                {
                    this.observationStartDate = value;
                }
            }
        }
        #endregion
        
        public string AdjustableOrRelativeDateIDRef { get; set; }
        #region OptionsExchangeDividends
        private XsdTypeBoolean optionsExchangeDividends;
        public XsdTypeBoolean OptionsExchangeDividends
        {
            get
            {
                if (this.optionsExchangeDividends != null)
                {
                    return this.optionsExchangeDividends; 
                }
                else if (this.optionsExchangeDividendsIDRef != null)
                {
                    optionsExchangeDividends = IDManager.getID(optionsExchangeDividendsIDRef) as XsdTypeBoolean;
                    return this.optionsExchangeDividends; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.optionsExchangeDividends != value)
                {
                    this.optionsExchangeDividends = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region AdditionalDividends
        private XsdTypeBoolean additionalDividends;
        public XsdTypeBoolean AdditionalDividends
        {
            get
            {
                if (this.additionalDividends != null)
                {
                    return this.additionalDividends; 
                }
                else if (this.additionalDividendsIDRef != null)
                {
                    additionalDividends = IDManager.getID(additionalDividendsIDRef) as XsdTypeBoolean;
                    return this.additionalDividends; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.additionalDividends != value)
                {
                    this.additionalDividends = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region AllDividends
        private XsdTypeBoolean allDividends;
        public XsdTypeBoolean AllDividends
        {
            get
            {
                if (this.allDividends != null)
                {
                    return this.allDividends; 
                }
                else if (this.allDividendsIDRef != null)
                {
                    allDividends = IDManager.getID(allDividendsIDRef) as XsdTypeBoolean;
                    return this.allDividends; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.allDividends != value)
                {
                    this.allDividends = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        
    
        
    
    }
    
}

