using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CoalStandardQualitySchedule : ISerialized
    {
        public CoalStandardQualitySchedule(XmlNode xmlNode)
        {
            XmlNodeList StandardQualityStepNodeList = xmlNode.SelectNodes("StandardQualityStep");
            
            if (StandardQualityStepNodeList != null)
            {
                this.StandardQualityStep_ = new List<CoalStandardQuality>();
                foreach (XmlNode item in StandardQualityStepNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            StandardQualityStepIDRef_ = item.Attributes["id"].Value;
                            StandardQualityStep_.Add(new CoalStandardQuality(item));
                            IDManager.SetID(StandardQualityStepIDRef_, StandardQualityStep_[StandardQualityStep_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            StandardQualityStepIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        StandardQualityStep_.Add(new CoalStandardQuality(item));
                        }
                    }
                    else
                    {
                        StandardQualityStep_.Add(new CoalStandardQuality(item));
                    }
                }
            }
            
        
            XmlNode deliveryPeriodsReferenceNode = xmlNode.SelectSingleNode("deliveryPeriodsReference");
            
            if (deliveryPeriodsReferenceNode != null)
            {
                if (deliveryPeriodsReferenceNode.Attributes["href"] != null || deliveryPeriodsReferenceNode.Attributes["id"] != null) 
                {
                    if (deliveryPeriodsReferenceNode.Attributes["id"] != null) 
                    {
                        deliveryPeriodsReferenceIDRef_ = deliveryPeriodsReferenceNode.Attributes["id"].Value;
                        CalculationPeriodsReference ob = new CalculationPeriodsReference(deliveryPeriodsReferenceNode);
                        IDManager.SetID(deliveryPeriodsReferenceIDRef_, ob);
                    }
                    else if (deliveryPeriodsReferenceNode.Attributes["href"] != null)
                    {
                        deliveryPeriodsReferenceIDRef_ = deliveryPeriodsReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        deliveryPeriodsReference_ = new CalculationPeriodsReference(deliveryPeriodsReferenceNode);
                    }
                }
                else
                {
                    deliveryPeriodsReference_ = new CalculationPeriodsReference(deliveryPeriodsReferenceNode);
                }
            }
            
        
            XmlNode deliveryPeriodsScheduleReferenceNode = xmlNode.SelectSingleNode("deliveryPeriodsScheduleReference");
            
            if (deliveryPeriodsScheduleReferenceNode != null)
            {
                if (deliveryPeriodsScheduleReferenceNode.Attributes["href"] != null || deliveryPeriodsScheduleReferenceNode.Attributes["id"] != null) 
                {
                    if (deliveryPeriodsScheduleReferenceNode.Attributes["id"] != null) 
                    {
                        deliveryPeriodsScheduleReferenceIDRef_ = deliveryPeriodsScheduleReferenceNode.Attributes["id"].Value;
                        CalculationPeriodsScheduleReference ob = new CalculationPeriodsScheduleReference(deliveryPeriodsScheduleReferenceNode);
                        IDManager.SetID(deliveryPeriodsScheduleReferenceIDRef_, ob);
                    }
                    else if (deliveryPeriodsScheduleReferenceNode.Attributes["href"] != null)
                    {
                        deliveryPeriodsScheduleReferenceIDRef_ = deliveryPeriodsScheduleReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        deliveryPeriodsScheduleReference_ = new CalculationPeriodsScheduleReference(deliveryPeriodsScheduleReferenceNode);
                    }
                }
                else
                {
                    deliveryPeriodsScheduleReference_ = new CalculationPeriodsScheduleReference(deliveryPeriodsScheduleReferenceNode);
                }
            }
            
        
        }
        
    
        #region StandardQualityStep_
        private List<CoalStandardQuality> StandardQualityStep_;
        public List<CoalStandardQuality> StandardQualityStep_
        {
            get
            {
                if (this.StandardQualityStep_ != null)
                {
                    return this.StandardQualityStep_; 
                }
                else if (this.StandardQualityStepIDRef_ != null)
                {
                    return this.StandardQualityStep_; 
                }
                else
                {
                      return this.StandardQualityStep_; 
                }
            }
            set
            {
                if (this.StandardQualityStep_ != value)
                {
                    this.StandardQualityStep_ = value;
                }
            }
        }
        #endregion
        
        public string StandardQualityStepIDRef_ { get; set; }
        #region DeliveryPeriodsReference_
        private CalculationPeriodsReference deliveryPeriodsReference_;
        public CalculationPeriodsReference DeliveryPeriodsReference_
        {
            get
            {
                if (this.deliveryPeriodsReference_ != null)
                {
                    return this.deliveryPeriodsReference_; 
                }
                else if (this.deliveryPeriodsReferenceIDRef_ != null)
                {
                    deliveryPeriodsReference_ = IDManager.getID(deliveryPeriodsReferenceIDRef_) as CalculationPeriodsReference;
                    return this.deliveryPeriodsReference_; 
                }
                else
                {
                      return this.deliveryPeriodsReference_; 
                }
            }
            set
            {
                if (this.deliveryPeriodsReference_ != value)
                {
                    this.deliveryPeriodsReference_ = value;
                }
            }
        }
        #endregion
        
        public string deliveryPeriodsReferenceIDRef_ { get; set; }
        #region DeliveryPeriodsScheduleReference_
        private CalculationPeriodsScheduleReference deliveryPeriodsScheduleReference_;
        public CalculationPeriodsScheduleReference DeliveryPeriodsScheduleReference_
        {
            get
            {
                if (this.deliveryPeriodsScheduleReference_ != null)
                {
                    return this.deliveryPeriodsScheduleReference_; 
                }
                else if (this.deliveryPeriodsScheduleReferenceIDRef_ != null)
                {
                    deliveryPeriodsScheduleReference_ = IDManager.getID(deliveryPeriodsScheduleReferenceIDRef_) as CalculationPeriodsScheduleReference;
                    return this.deliveryPeriodsScheduleReference_; 
                }
                else
                {
                      return this.deliveryPeriodsScheduleReference_; 
                }
            }
            set
            {
                if (this.deliveryPeriodsScheduleReference_ != value)
                {
                    this.deliveryPeriodsScheduleReference_ = value;
                }
            }
        }
        #endregion
        
        public string deliveryPeriodsScheduleReferenceIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

