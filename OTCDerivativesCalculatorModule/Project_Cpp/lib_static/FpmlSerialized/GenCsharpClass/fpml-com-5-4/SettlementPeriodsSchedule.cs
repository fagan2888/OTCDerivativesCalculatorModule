using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class SettlementPeriodsSchedule
    {
        public SettlementPeriodsSchedule(XmlNode xmlNode)
        {
            XmlNodeList settlementPeriodsStepNodeList = xmlNode.SelectNodes("settlementPeriodsStep");
            
            foreach (XmlNode item in settlementPeriodsStepNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        settlementPeriodsStepIDRef = item.Attributes["id"].Name;
                        List<SettlementPeriodsStep> ob = new List<SettlementPeriodsStep>();
                        ob.Add(new SettlementPeriodsStep(item));
                        IDManager.SetID(settlementPeriodsStepIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        settlementPeriodsStepIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    settlementPeriodsStep.Add(new SettlementPeriodsStep(item));
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
        
    
        #region SettlementPeriodsStep
        private List<SettlementPeriodsStep> settlementPeriodsStep;
        public List<SettlementPeriodsStep> SettlementPeriodsStep
        {
            get
            {
                if (this.settlementPeriodsStep != null)
                {
                    return this.settlementPeriodsStep; 
                }
                else if (this.settlementPeriodsStepIDRef != null)
                {
                    settlementPeriodsStep = IDManager.getID(settlementPeriodsStepIDRef) as List<SettlementPeriodsStep>;
                    return this.settlementPeriodsStep; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.settlementPeriodsStep != value)
                {
                    this.settlementPeriodsStep = value;
                }
            }
        }
        #endregion
        
        public string SettlementPeriodsStepIDRef { get; set; }
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

