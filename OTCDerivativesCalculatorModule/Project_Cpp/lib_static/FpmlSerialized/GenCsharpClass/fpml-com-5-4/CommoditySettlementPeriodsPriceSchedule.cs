using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CommoditySettlementPeriodsPriceSchedule
    {
        public CommoditySettlementPeriodsPriceSchedule(XmlNode xmlNode)
        {
            XmlNodeList settlementPeriodsPriceStepNodeList = xmlNode.SelectNodes("settlementPeriodsPriceStep");
            
            foreach (XmlNode item in settlementPeriodsPriceStepNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        settlementPeriodsPriceStepIDRef = item.Attributes["id"].Name;
                        List<FixedPrice> ob = new List<FixedPrice>();
                        ob.Add(new FixedPrice(item));
                        IDManager.SetID(settlementPeriodsPriceStepIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        settlementPeriodsPriceStepIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    settlementPeriodsPriceStep.Add(new FixedPrice(item));
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
        
    
        #region SettlementPeriodsPriceStep
        private List<FixedPrice> settlementPeriodsPriceStep;
        public List<FixedPrice> SettlementPeriodsPriceStep
        {
            get
            {
                if (this.settlementPeriodsPriceStep != null)
                {
                    return this.settlementPeriodsPriceStep; 
                }
                else if (this.settlementPeriodsPriceStepIDRef != null)
                {
                    settlementPeriodsPriceStep = IDManager.getID(settlementPeriodsPriceStepIDRef) as List<FixedPrice>;
                    return this.settlementPeriodsPriceStep; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.settlementPeriodsPriceStep != value)
                {
                    this.settlementPeriodsPriceStep = value;
                }
            }
        }
        #endregion
        
        public string FixedPriceIDRef { get; set; }
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

