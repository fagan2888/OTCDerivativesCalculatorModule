using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CommodityPhysicalQuantitySchedule
    {
        public CommodityPhysicalQuantitySchedule(XmlNode xmlNode)
        {
            XmlNodeList quantityStepNodeList = xmlNode.SelectNodes("quantityStep");
            
            foreach (XmlNode item in quantityStepNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        quantityStepIDRef = item.Attributes["id"].Name;
                        List<CommodityNotionalQuantity> ob = new List<CommodityNotionalQuantity>();
                        ob.Add(new CommodityNotionalQuantity(item));
                        IDManager.SetID(quantityStepIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        quantityStepIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    quantityStep.Add(new CommodityNotionalQuantity(item));
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
        
    
        #region QuantityStep
        private List<CommodityNotionalQuantity> quantityStep;
        public List<CommodityNotionalQuantity> QuantityStep
        {
            get
            {
                if (this.quantityStep != null)
                {
                    return this.quantityStep; 
                }
                else if (this.quantityStepIDRef != null)
                {
                    quantityStep = IDManager.getID(quantityStepIDRef) as List<CommodityNotionalQuantity>;
                    return this.quantityStep; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.quantityStep != value)
                {
                    this.quantityStep = value;
                }
            }
        }
        #endregion
        
        public string CommodityNotionalQuantityIDRef { get; set; }
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

