using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CommoditySettlementPeriodsNotionalQuantitySchedule
    {
        public CommoditySettlementPeriodsNotionalQuantitySchedule(XmlNode xmlNode)
        {
            XmlNodeList settlementPeriodsNotionalQuantityStepNodeList = xmlNode.SelectNodes("settlementPeriodsNotionalQuantityStep");
            
            foreach (XmlNode item in settlementPeriodsNotionalQuantityStepNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        settlementPeriodsNotionalQuantityStepIDRef = item.Attributes["id"].Name;
                        List<CommodityNotionalQuantity> ob = new List<CommodityNotionalQuantity>();
                        ob.Add(new CommodityNotionalQuantity(item));
                        IDManager.SetID(settlementPeriodsNotionalQuantityStepIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        settlementPeriodsNotionalQuantityStepIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    settlementPeriodsNotionalQuantityStep.Add(new CommodityNotionalQuantity(item));
                    }
                }
            }
            
        
            XmlNodeList settlementPeriodsReferenceNodeList = xmlNode.SelectNodes("settlementPeriodsReference");
            
            foreach (XmlNode item in settlementPeriodsReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        settlementPeriodsReferenceIDRef = item.Attributes["id"].Name;
                        List<SettlementPeriodsReference> ob = new List<SettlementPeriodsReference>();
                        ob.Add(new SettlementPeriodsReference(item));
                        IDManager.SetID(settlementPeriodsReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        settlementPeriodsReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    settlementPeriodsReference.Add(new SettlementPeriodsReference(item));
                    }
                }
            }
            
        
        }
        
    
        #region SettlementPeriodsNotionalQuantityStep
        private List<CommodityNotionalQuantity> settlementPeriodsNotionalQuantityStep;
        public List<CommodityNotionalQuantity> SettlementPeriodsNotionalQuantityStep
        {
            get
            {
                if (this.settlementPeriodsNotionalQuantityStep != null)
                {
                    return this.settlementPeriodsNotionalQuantityStep; 
                }
                else if (this.settlementPeriodsNotionalQuantityStepIDRef != null)
                {
                    settlementPeriodsNotionalQuantityStep = IDManager.getID(settlementPeriodsNotionalQuantityStepIDRef) as List<CommodityNotionalQuantity>;
                    return this.settlementPeriodsNotionalQuantityStep; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.settlementPeriodsNotionalQuantityStep != value)
                {
                    this.settlementPeriodsNotionalQuantityStep = value;
                }
            }
        }
        #endregion
        
        public string CommodityNotionalQuantityIDRef { get; set; }
        #region SettlementPeriodsReference
        private List<SettlementPeriodsReference> settlementPeriodsReference;
        public List<SettlementPeriodsReference> SettlementPeriodsReference
        {
            get
            {
                if (this.settlementPeriodsReference != null)
                {
                    return this.settlementPeriodsReference; 
                }
                else if (this.settlementPeriodsReferenceIDRef != null)
                {
                    settlementPeriodsReference = IDManager.getID(settlementPeriodsReferenceIDRef) as List<SettlementPeriodsReference>;
                    return this.settlementPeriodsReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.settlementPeriodsReference != value)
                {
                    this.settlementPeriodsReference = value;
                }
            }
        }
        #endregion
        
        public string SettlementPeriodsReferenceIDRef { get; set; }
        
    
        
    
    }
    
}

