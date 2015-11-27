using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CoalStandardQualitySchedule
    {
        public CoalStandardQualitySchedule(XmlNode xmlNode)
        {
            XmlNodeList StandardQualityStepNodeList = xmlNode.SelectNodes("StandardQualityStep");
            
            foreach (XmlNode item in StandardQualityStepNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        StandardQualityStepIDRef = item.Attributes["id"].Name;
                        List<CoalStandardQuality> ob = new List<CoalStandardQuality>();
                        ob.Add(new CoalStandardQuality(item));
                        IDManager.SetID(StandardQualityStepIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        StandardQualityStepIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    StandardQualityStep.Add(new CoalStandardQuality(item));
                    }
                }
            }
            
        
            XmlNodeList deliveryPeriodsReferenceNodeList = xmlNode.SelectNodes("deliveryPeriodsReference");
            if (deliveryPeriodsReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in deliveryPeriodsReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        deliveryPeriodsReferenceIDRef = item.Attributes["id"].Name;
                        CalculationPeriodsReference ob = CalculationPeriodsReference();
                        IDManager.SetID(deliveryPeriodsReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        deliveryPeriodsReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        deliveryPeriodsReference = new CalculationPeriodsReference(item);
                    }
                }
            }
            
        
            XmlNodeList deliveryPeriodsScheduleReferenceNodeList = xmlNode.SelectNodes("deliveryPeriodsScheduleReference");
            if (deliveryPeriodsScheduleReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in deliveryPeriodsScheduleReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        deliveryPeriodsScheduleReferenceIDRef = item.Attributes["id"].Name;
                        CalculationPeriodsScheduleReference ob = CalculationPeriodsScheduleReference();
                        IDManager.SetID(deliveryPeriodsScheduleReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        deliveryPeriodsScheduleReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        deliveryPeriodsScheduleReference = new CalculationPeriodsScheduleReference(item);
                    }
                }
            }
            
        
        }
        
    
        #region StandardQualityStep
        private List<CoalStandardQuality> StandardQualityStep;
        public List<CoalStandardQuality> StandardQualityStep
        {
            get
            {
                if (this.StandardQualityStep != null)
                {
                    return this.StandardQualityStep; 
                }
                else if (this.StandardQualityStepIDRef != null)
                {
                    StandardQualityStep = IDManager.getID(StandardQualityStepIDRef) as List<CoalStandardQuality>;
                    return this.StandardQualityStep; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.StandardQualityStep != value)
                {
                    this.StandardQualityStep = value;
                }
            }
        }
        #endregion
        
        public string CoalStandardQualityIDRef { get; set; }
        #region DeliveryPeriodsReference
        private CalculationPeriodsReference deliveryPeriodsReference;
        public CalculationPeriodsReference DeliveryPeriodsReference
        {
            get
            {
                if (this.deliveryPeriodsReference != null)
                {
                    return this.deliveryPeriodsReference; 
                }
                else if (this.deliveryPeriodsReferenceIDRef != null)
                {
                    deliveryPeriodsReference = IDManager.getID(deliveryPeriodsReferenceIDRef) as CalculationPeriodsReference;
                    return this.deliveryPeriodsReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.deliveryPeriodsReference != value)
                {
                    this.deliveryPeriodsReference = value;
                }
            }
        }
        #endregion
        
        public string CalculationPeriodsReferenceIDRef { get; set; }
        #region DeliveryPeriodsScheduleReference
        private CalculationPeriodsScheduleReference deliveryPeriodsScheduleReference;
        public CalculationPeriodsScheduleReference DeliveryPeriodsScheduleReference
        {
            get
            {
                if (this.deliveryPeriodsScheduleReference != null)
                {
                    return this.deliveryPeriodsScheduleReference; 
                }
                else if (this.deliveryPeriodsScheduleReferenceIDRef != null)
                {
                    deliveryPeriodsScheduleReference = IDManager.getID(deliveryPeriodsScheduleReferenceIDRef) as CalculationPeriodsScheduleReference;
                    return this.deliveryPeriodsScheduleReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.deliveryPeriodsScheduleReference != value)
                {
                    this.deliveryPeriodsScheduleReference = value;
                }
            }
        }
        #endregion
        
        public string CalculationPeriodsScheduleReferenceIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

