using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class NonDeliverableSettlement
    {
        public NonDeliverableSettlement(XmlNode xmlNode)
        {
            XmlNodeList referenceCurrencyNodeList = xmlNode.SelectNodes("referenceCurrency");
            if (referenceCurrencyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in referenceCurrencyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        referenceCurrencyIDRef = item.Attributes["id"].Name;
                        Currency ob = Currency();
                        IDManager.SetID(referenceCurrencyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        referenceCurrencyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        referenceCurrency = new Currency(item);
                    }
                }
            }
            
        
            XmlNodeList fxFixingDateNodeList = xmlNode.SelectNodes("fxFixingDate");
            if (fxFixingDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fxFixingDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fxFixingDateIDRef = item.Attributes["id"].Name;
                        FxFixingDate ob = FxFixingDate();
                        IDManager.SetID(fxFixingDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fxFixingDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fxFixingDate = new FxFixingDate(item);
                    }
                }
            }
            
        
            XmlNodeList fxFixingScheduleNodeList = xmlNode.SelectNodes("fxFixingSchedule");
            if (fxFixingScheduleNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fxFixingScheduleNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fxFixingScheduleIDRef = item.Attributes["id"].Name;
                        AdjustableDates ob = AdjustableDates();
                        IDManager.SetID(fxFixingScheduleIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fxFixingScheduleIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fxFixingSchedule = new AdjustableDates(item);
                    }
                }
            }
            
        
            XmlNodeList settlementRateOptionNodeList = xmlNode.SelectNodes("settlementRateOption");
            if (settlementRateOptionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in settlementRateOptionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        settlementRateOptionIDRef = item.Attributes["id"].Name;
                        SettlementRateOption ob = SettlementRateOption();
                        IDManager.SetID(settlementRateOptionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        settlementRateOptionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        settlementRateOption = new SettlementRateOption(item);
                    }
                }
            }
            
        
            XmlNodeList priceSourceDisruptionNodeList = xmlNode.SelectNodes("priceSourceDisruption");
            if (priceSourceDisruptionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in priceSourceDisruptionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        priceSourceDisruptionIDRef = item.Attributes["id"].Name;
                        PriceSourceDisruption ob = PriceSourceDisruption();
                        IDManager.SetID(priceSourceDisruptionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        priceSourceDisruptionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        priceSourceDisruption = new PriceSourceDisruption(item);
                    }
                }
            }
            
        
        }
        
    
        #region ReferenceCurrency
        private Currency referenceCurrency;
        public Currency ReferenceCurrency
        {
            get
            {
                if (this.referenceCurrency != null)
                {
                    return this.referenceCurrency; 
                }
                else if (this.referenceCurrencyIDRef != null)
                {
                    referenceCurrency = IDManager.getID(referenceCurrencyIDRef) as Currency;
                    return this.referenceCurrency; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.referenceCurrency != value)
                {
                    this.referenceCurrency = value;
                }
            }
        }
        #endregion
        
        public string CurrencyIDRef { get; set; }
        #region FxFixingDate
        private FxFixingDate fxFixingDate;
        public FxFixingDate FxFixingDate
        {
            get
            {
                if (this.fxFixingDate != null)
                {
                    return this.fxFixingDate; 
                }
                else if (this.fxFixingDateIDRef != null)
                {
                    fxFixingDate = IDManager.getID(fxFixingDateIDRef) as FxFixingDate;
                    return this.fxFixingDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fxFixingDate != value)
                {
                    this.fxFixingDate = value;
                }
            }
        }
        #endregion
        
        public string FxFixingDateIDRef { get; set; }
        #region FxFixingSchedule
        private AdjustableDates fxFixingSchedule;
        public AdjustableDates FxFixingSchedule
        {
            get
            {
                if (this.fxFixingSchedule != null)
                {
                    return this.fxFixingSchedule; 
                }
                else if (this.fxFixingScheduleIDRef != null)
                {
                    fxFixingSchedule = IDManager.getID(fxFixingScheduleIDRef) as AdjustableDates;
                    return this.fxFixingSchedule; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fxFixingSchedule != value)
                {
                    this.fxFixingSchedule = value;
                }
            }
        }
        #endregion
        
        public string AdjustableDatesIDRef { get; set; }
        #region SettlementRateOption
        private SettlementRateOption settlementRateOption;
        public SettlementRateOption SettlementRateOption
        {
            get
            {
                if (this.settlementRateOption != null)
                {
                    return this.settlementRateOption; 
                }
                else if (this.settlementRateOptionIDRef != null)
                {
                    settlementRateOption = IDManager.getID(settlementRateOptionIDRef) as SettlementRateOption;
                    return this.settlementRateOption; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.settlementRateOption != value)
                {
                    this.settlementRateOption = value;
                }
            }
        }
        #endregion
        
        public string SettlementRateOptionIDRef { get; set; }
        #region PriceSourceDisruption
        private PriceSourceDisruption priceSourceDisruption;
        public PriceSourceDisruption PriceSourceDisruption
        {
            get
            {
                if (this.priceSourceDisruption != null)
                {
                    return this.priceSourceDisruption; 
                }
                else if (this.priceSourceDisruptionIDRef != null)
                {
                    priceSourceDisruption = IDManager.getID(priceSourceDisruptionIDRef) as PriceSourceDisruption;
                    return this.priceSourceDisruption; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.priceSourceDisruption != value)
                {
                    this.priceSourceDisruption = value;
                }
            }
        }
        #endregion
        
        public string PriceSourceDisruptionIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

