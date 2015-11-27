using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class DateRelativeToCalculationPeriodDates
    {
        public DateRelativeToCalculationPeriodDates(XmlNode xmlNode)
        {
            XmlNodeList calculationPeriodDatesReferenceNodeList = xmlNode.SelectNodes("calculationPeriodDatesReference");
            
            foreach (XmlNode item in calculationPeriodDatesReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        calculationPeriodDatesReferenceIDRef = item.Attributes["id"].Name;
                        List<CalculationPeriodDatesReference> ob = new List<CalculationPeriodDatesReference>();
                        ob.Add(new CalculationPeriodDatesReference(item));
                        IDManager.SetID(calculationPeriodDatesReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        calculationPeriodDatesReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    calculationPeriodDatesReference.Add(new CalculationPeriodDatesReference(item));
                    }
                }
            }
            
        
        }
        
    
        #region CalculationPeriodDatesReference
        private List<CalculationPeriodDatesReference> calculationPeriodDatesReference;
        public List<CalculationPeriodDatesReference> CalculationPeriodDatesReference
        {
            get
            {
                if (this.calculationPeriodDatesReference != null)
                {
                    return this.calculationPeriodDatesReference; 
                }
                else if (this.calculationPeriodDatesReferenceIDRef != null)
                {
                    calculationPeriodDatesReference = IDManager.getID(calculationPeriodDatesReferenceIDRef) as List<CalculationPeriodDatesReference>;
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
        
    
        
    
    }
    
}

