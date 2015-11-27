using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class DateRelativeToCalculationPeriodDates : ISerialized
    {
        public DateRelativeToCalculationPeriodDates(XmlNode xmlNode)
        {
            XmlNodeList calculationPeriodDatesReferenceNodeList = xmlNode.SelectNodes("calculationPeriodDatesReference");
            
            if (calculationPeriodDatesReferenceNodeList != null)
            {
                this.calculationPeriodDatesReference_ = new List<CalculationPeriodDatesReference>();
                foreach (XmlNode item in calculationPeriodDatesReferenceNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            calculationPeriodDatesReferenceIDRef_ = item.Attributes["id"].Value;
                            calculationPeriodDatesReference_.Add(new CalculationPeriodDatesReference(item));
                            IDManager.SetID(calculationPeriodDatesReferenceIDRef_, calculationPeriodDatesReference_[calculationPeriodDatesReference_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            calculationPeriodDatesReferenceIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        calculationPeriodDatesReference_.Add(new CalculationPeriodDatesReference(item));
                        }
                    }
                    else
                    {
                        calculationPeriodDatesReference_.Add(new CalculationPeriodDatesReference(item));
                    }
                }
            }
            
        
        }
        
    
        #region CalculationPeriodDatesReference_
        private List<CalculationPeriodDatesReference> calculationPeriodDatesReference_;
        public List<CalculationPeriodDatesReference> CalculationPeriodDatesReference_
        {
            get
            {
                if (this.calculationPeriodDatesReference_ != null)
                {
                    return this.calculationPeriodDatesReference_; 
                }
                else if (this.calculationPeriodDatesReferenceIDRef_ != null)
                {
                    return this.calculationPeriodDatesReference_; 
                }
                else
                {
                      return this.calculationPeriodDatesReference_; 
                }
            }
            set
            {
                if (this.calculationPeriodDatesReference_ != value)
                {
                    this.calculationPeriodDatesReference_ = value;
                }
            }
        }
        #endregion
        
        public string calculationPeriodDatesReferenceIDRef_ { get; set; }
        
    
        
    
    }
    
}

