using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class FutureValueAmount
    {
        public FutureValueAmount(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList calculationPeriodNumberOfDaysNodeList = xmlNode.SelectNodes("calculationPeriodNumberOfDays");
            if (calculationPeriodNumberOfDaysNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in calculationPeriodNumberOfDaysNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        calculationPeriodNumberOfDaysIDRef = item.Attributes["id"].Name;
                        XsdTypePositiveInteger ob = XsdTypePositiveInteger();
                        IDManager.SetID(calculationPeriodNumberOfDaysIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        calculationPeriodNumberOfDaysIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        calculationPeriodNumberOfDays = new XsdTypePositiveInteger(item);
                    }
                }
            }
            
        
            XmlNodeList valueDateNodeList = xmlNode.SelectNodes("valueDate");
            if (valueDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in valueDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        valueDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(valueDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        valueDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        valueDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
        }
        
    
        #region CalculationPeriodNumberOfDays
        private XsdTypePositiveInteger calculationPeriodNumberOfDays;
        public XsdTypePositiveInteger CalculationPeriodNumberOfDays
        {
            get
            {
                if (this.calculationPeriodNumberOfDays != null)
                {
                    return this.calculationPeriodNumberOfDays; 
                }
                else if (this.calculationPeriodNumberOfDaysIDRef != null)
                {
                    calculationPeriodNumberOfDays = IDManager.getID(calculationPeriodNumberOfDaysIDRef) as XsdTypePositiveInteger;
                    return this.calculationPeriodNumberOfDays; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.calculationPeriodNumberOfDays != value)
                {
                    this.calculationPeriodNumberOfDays = value;
                }
            }
        }
        #endregion
        
        public string XsdTypePositiveIntegerIDRef { get; set; }
        #region ValueDate
        private XsdTypeDate valueDate;
        public XsdTypeDate ValueDate
        {
            get
            {
                if (this.valueDate != null)
                {
                    return this.valueDate; 
                }
                else if (this.valueDateIDRef != null)
                {
                    valueDate = IDManager.getID(valueDateIDRef) as XsdTypeDate;
                    return this.valueDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.valueDate != value)
                {
                    this.valueDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        
    
        
    
    }
    
}

