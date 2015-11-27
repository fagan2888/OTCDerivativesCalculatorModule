using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class NotionalStepRule
    {
        public NotionalStepRule(XmlNode xmlNode)
        {
            XmlNodeList calculationPeriodDatesReferenceNodeList = xmlNode.SelectNodes("calculationPeriodDatesReference");
            if (calculationPeriodDatesReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in calculationPeriodDatesReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        calculationPeriodDatesReferenceIDRef = item.Attributes["id"].Name;
                        CalculationPeriodDatesReference ob = CalculationPeriodDatesReference();
                        IDManager.SetID(calculationPeriodDatesReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        calculationPeriodDatesReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        calculationPeriodDatesReference = new CalculationPeriodDatesReference(item);
                    }
                }
            }
            
        
            XmlNodeList stepFrequencyNodeList = xmlNode.SelectNodes("stepFrequency");
            if (stepFrequencyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in stepFrequencyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        stepFrequencyIDRef = item.Attributes["id"].Name;
                        Period ob = Period();
                        IDManager.SetID(stepFrequencyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        stepFrequencyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        stepFrequency = new Period(item);
                    }
                }
            }
            
        
            XmlNodeList firstNotionalStepDateNodeList = xmlNode.SelectNodes("firstNotionalStepDate");
            if (firstNotionalStepDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in firstNotionalStepDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        firstNotionalStepDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(firstNotionalStepDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        firstNotionalStepDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        firstNotionalStepDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList lastNotionalStepDateNodeList = xmlNode.SelectNodes("lastNotionalStepDate");
            if (lastNotionalStepDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in lastNotionalStepDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        lastNotionalStepDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(lastNotionalStepDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        lastNotionalStepDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        lastNotionalStepDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList notionalStepAmountNodeList = xmlNode.SelectNodes("notionalStepAmount");
            if (notionalStepAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in notionalStepAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        notionalStepAmountIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(notionalStepAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        notionalStepAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        notionalStepAmount = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList notionalStepRateNodeList = xmlNode.SelectNodes("notionalStepRate");
            if (notionalStepRateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in notionalStepRateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        notionalStepRateIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(notionalStepRateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        notionalStepRateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        notionalStepRate = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList stepRelativeToNodeList = xmlNode.SelectNodes("stepRelativeTo");
            if (stepRelativeToNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in stepRelativeToNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        stepRelativeToIDRef = item.Attributes["id"].Name;
                        StepRelativeToEnum ob = StepRelativeToEnum();
                        IDManager.SetID(stepRelativeToIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        stepRelativeToIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        stepRelativeTo = new StepRelativeToEnum(item);
                    }
                }
            }
            
        
        }
        
    
        #region CalculationPeriodDatesReference
        private CalculationPeriodDatesReference calculationPeriodDatesReference;
        public CalculationPeriodDatesReference CalculationPeriodDatesReference
        {
            get
            {
                if (this.calculationPeriodDatesReference != null)
                {
                    return this.calculationPeriodDatesReference; 
                }
                else if (this.calculationPeriodDatesReferenceIDRef != null)
                {
                    calculationPeriodDatesReference = IDManager.getID(calculationPeriodDatesReferenceIDRef) as CalculationPeriodDatesReference;
                    return this.calculationPeriodDatesReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.calculationPeriodDatesReference != value)
                {
                    this.calculationPeriodDatesReference = value;
                }
            }
        }
        #endregion
        
        public string CalculationPeriodDatesReferenceIDRef { get; set; }
        #region StepFrequency
        private Period stepFrequency;
        public Period StepFrequency
        {
            get
            {
                if (this.stepFrequency != null)
                {
                    return this.stepFrequency; 
                }
                else if (this.stepFrequencyIDRef != null)
                {
                    stepFrequency = IDManager.getID(stepFrequencyIDRef) as Period;
                    return this.stepFrequency; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.stepFrequency != value)
                {
                    this.stepFrequency = value;
                }
            }
        }
        #endregion
        
        public string PeriodIDRef { get; set; }
        #region FirstNotionalStepDate
        private XsdTypeDate firstNotionalStepDate;
        public XsdTypeDate FirstNotionalStepDate
        {
            get
            {
                if (this.firstNotionalStepDate != null)
                {
                    return this.firstNotionalStepDate; 
                }
                else if (this.firstNotionalStepDateIDRef != null)
                {
                    firstNotionalStepDate = IDManager.getID(firstNotionalStepDateIDRef) as XsdTypeDate;
                    return this.firstNotionalStepDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.firstNotionalStepDate != value)
                {
                    this.firstNotionalStepDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region LastNotionalStepDate
        private XsdTypeDate lastNotionalStepDate;
        public XsdTypeDate LastNotionalStepDate
        {
            get
            {
                if (this.lastNotionalStepDate != null)
                {
                    return this.lastNotionalStepDate; 
                }
                else if (this.lastNotionalStepDateIDRef != null)
                {
                    lastNotionalStepDate = IDManager.getID(lastNotionalStepDateIDRef) as XsdTypeDate;
                    return this.lastNotionalStepDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.lastNotionalStepDate != value)
                {
                    this.lastNotionalStepDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region NotionalStepAmount
        private XsdTypeDecimal notionalStepAmount;
        public XsdTypeDecimal NotionalStepAmount
        {
            get
            {
                if (this.notionalStepAmount != null)
                {
                    return this.notionalStepAmount; 
                }
                else if (this.notionalStepAmountIDRef != null)
                {
                    notionalStepAmount = IDManager.getID(notionalStepAmountIDRef) as XsdTypeDecimal;
                    return this.notionalStepAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.notionalStepAmount != value)
                {
                    this.notionalStepAmount = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region NotionalStepRate
        private XsdTypeDecimal notionalStepRate;
        public XsdTypeDecimal NotionalStepRate
        {
            get
            {
                if (this.notionalStepRate != null)
                {
                    return this.notionalStepRate; 
                }
                else if (this.notionalStepRateIDRef != null)
                {
                    notionalStepRate = IDManager.getID(notionalStepRateIDRef) as XsdTypeDecimal;
                    return this.notionalStepRate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.notionalStepRate != value)
                {
                    this.notionalStepRate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region StepRelativeTo
        private StepRelativeToEnum stepRelativeTo;
        public StepRelativeToEnum StepRelativeTo
        {
            get
            {
                if (this.stepRelativeTo != null)
                {
                    return this.stepRelativeTo; 
                }
                else if (this.stepRelativeToIDRef != null)
                {
                    stepRelativeTo = IDManager.getID(stepRelativeToIDRef) as StepRelativeToEnum;
                    return this.stepRelativeTo; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.stepRelativeTo != value)
                {
                    this.stepRelativeTo = value;
                }
            }
        }
        #endregion
        
        public string StepRelativeToEnumIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

