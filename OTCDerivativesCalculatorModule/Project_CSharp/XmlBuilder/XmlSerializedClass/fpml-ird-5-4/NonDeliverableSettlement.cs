using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class NonDeliverableSettlement : ISerialized
    {
        public NonDeliverableSettlement(XmlNode xmlNode)
        {
            XmlNode referenceCurrencyNode = xmlNode.SelectSingleNode("referenceCurrency");
            
            if (referenceCurrencyNode != null)
            {
                if (referenceCurrencyNode.Attributes["href"] != null || referenceCurrencyNode.Attributes["id"] != null) 
                {
                    if (referenceCurrencyNode.Attributes["id"] != null) 
                    {
                        referenceCurrencyIDRef_ = referenceCurrencyNode.Attributes["id"].Value;
                        Currency ob = new Currency(referenceCurrencyNode);
                        IDManager.SetID(referenceCurrencyIDRef_, ob);
                    }
                    else if (referenceCurrencyNode.Attributes["href"] != null)
                    {
                        referenceCurrencyIDRef_ = referenceCurrencyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        referenceCurrency_ = new Currency(referenceCurrencyNode);
                    }
                }
                else
                {
                    referenceCurrency_ = new Currency(referenceCurrencyNode);
                }
            }
            
        
            XmlNode fxFixingDateNode = xmlNode.SelectSingleNode("fxFixingDate");
            
            if (fxFixingDateNode != null)
            {
                if (fxFixingDateNode.Attributes["href"] != null || fxFixingDateNode.Attributes["id"] != null) 
                {
                    if (fxFixingDateNode.Attributes["id"] != null) 
                    {
                        fxFixingDateIDRef_ = fxFixingDateNode.Attributes["id"].Value;
                        FxFixingDate ob = new FxFixingDate(fxFixingDateNode);
                        IDManager.SetID(fxFixingDateIDRef_, ob);
                    }
                    else if (fxFixingDateNode.Attributes["href"] != null)
                    {
                        fxFixingDateIDRef_ = fxFixingDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fxFixingDate_ = new FxFixingDate(fxFixingDateNode);
                    }
                }
                else
                {
                    fxFixingDate_ = new FxFixingDate(fxFixingDateNode);
                }
            }
            
        
            XmlNode fxFixingScheduleNode = xmlNode.SelectSingleNode("fxFixingSchedule");
            
            if (fxFixingScheduleNode != null)
            {
                if (fxFixingScheduleNode.Attributes["href"] != null || fxFixingScheduleNode.Attributes["id"] != null) 
                {
                    if (fxFixingScheduleNode.Attributes["id"] != null) 
                    {
                        fxFixingScheduleIDRef_ = fxFixingScheduleNode.Attributes["id"].Value;
                        AdjustableDates ob = new AdjustableDates(fxFixingScheduleNode);
                        IDManager.SetID(fxFixingScheduleIDRef_, ob);
                    }
                    else if (fxFixingScheduleNode.Attributes["href"] != null)
                    {
                        fxFixingScheduleIDRef_ = fxFixingScheduleNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fxFixingSchedule_ = new AdjustableDates(fxFixingScheduleNode);
                    }
                }
                else
                {
                    fxFixingSchedule_ = new AdjustableDates(fxFixingScheduleNode);
                }
            }
            
        
            XmlNode settlementRateOptionNode = xmlNode.SelectSingleNode("settlementRateOption");
            
            if (settlementRateOptionNode != null)
            {
                if (settlementRateOptionNode.Attributes["href"] != null || settlementRateOptionNode.Attributes["id"] != null) 
                {
                    if (settlementRateOptionNode.Attributes["id"] != null) 
                    {
                        settlementRateOptionIDRef_ = settlementRateOptionNode.Attributes["id"].Value;
                        SettlementRateOption ob = new SettlementRateOption(settlementRateOptionNode);
                        IDManager.SetID(settlementRateOptionIDRef_, ob);
                    }
                    else if (settlementRateOptionNode.Attributes["href"] != null)
                    {
                        settlementRateOptionIDRef_ = settlementRateOptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        settlementRateOption_ = new SettlementRateOption(settlementRateOptionNode);
                    }
                }
                else
                {
                    settlementRateOption_ = new SettlementRateOption(settlementRateOptionNode);
                }
            }
            
        
            XmlNode priceSourceDisruptionNode = xmlNode.SelectSingleNode("priceSourceDisruption");
            
            if (priceSourceDisruptionNode != null)
            {
                if (priceSourceDisruptionNode.Attributes["href"] != null || priceSourceDisruptionNode.Attributes["id"] != null) 
                {
                    if (priceSourceDisruptionNode.Attributes["id"] != null) 
                    {
                        priceSourceDisruptionIDRef_ = priceSourceDisruptionNode.Attributes["id"].Value;
                        PriceSourceDisruption ob = new PriceSourceDisruption(priceSourceDisruptionNode);
                        IDManager.SetID(priceSourceDisruptionIDRef_, ob);
                    }
                    else if (priceSourceDisruptionNode.Attributes["href"] != null)
                    {
                        priceSourceDisruptionIDRef_ = priceSourceDisruptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        priceSourceDisruption_ = new PriceSourceDisruption(priceSourceDisruptionNode);
                    }
                }
                else
                {
                    priceSourceDisruption_ = new PriceSourceDisruption(priceSourceDisruptionNode);
                }
            }
            
        
        }
        
    
        #region ReferenceCurrency_
        private Currency referenceCurrency_;
        public Currency ReferenceCurrency_
        {
            get
            {
                if (this.referenceCurrency_ != null)
                {
                    return this.referenceCurrency_; 
                }
                else if (this.referenceCurrencyIDRef_ != null)
                {
                    referenceCurrency_ = IDManager.getID(referenceCurrencyIDRef_) as Currency;
                    return this.referenceCurrency_; 
                }
                else
                {
                      return this.referenceCurrency_; 
                }
            }
            set
            {
                if (this.referenceCurrency_ != value)
                {
                    this.referenceCurrency_ = value;
                }
            }
        }
        #endregion
        
        public string referenceCurrencyIDRef_ { get; set; }
        #region FxFixingDate_
        private FxFixingDate fxFixingDate_;
        public FxFixingDate FxFixingDate_
        {
            get
            {
                if (this.fxFixingDate_ != null)
                {
                    return this.fxFixingDate_; 
                }
                else if (this.fxFixingDateIDRef_ != null)
                {
                    fxFixingDate_ = IDManager.getID(fxFixingDateIDRef_) as FxFixingDate;
                    return this.fxFixingDate_; 
                }
                else
                {
                      return this.fxFixingDate_; 
                }
            }
            set
            {
                if (this.fxFixingDate_ != value)
                {
                    this.fxFixingDate_ = value;
                }
            }
        }
        #endregion
        
        public string fxFixingDateIDRef_ { get; set; }
        #region FxFixingSchedule_
        private AdjustableDates fxFixingSchedule_;
        public AdjustableDates FxFixingSchedule_
        {
            get
            {
                if (this.fxFixingSchedule_ != null)
                {
                    return this.fxFixingSchedule_; 
                }
                else if (this.fxFixingScheduleIDRef_ != null)
                {
                    fxFixingSchedule_ = IDManager.getID(fxFixingScheduleIDRef_) as AdjustableDates;
                    return this.fxFixingSchedule_; 
                }
                else
                {
                      return this.fxFixingSchedule_; 
                }
            }
            set
            {
                if (this.fxFixingSchedule_ != value)
                {
                    this.fxFixingSchedule_ = value;
                }
            }
        }
        #endregion
        
        public string fxFixingScheduleIDRef_ { get; set; }
        #region SettlementRateOption_
        private SettlementRateOption settlementRateOption_;
        public SettlementRateOption SettlementRateOption_
        {
            get
            {
                if (this.settlementRateOption_ != null)
                {
                    return this.settlementRateOption_; 
                }
                else if (this.settlementRateOptionIDRef_ != null)
                {
                    settlementRateOption_ = IDManager.getID(settlementRateOptionIDRef_) as SettlementRateOption;
                    return this.settlementRateOption_; 
                }
                else
                {
                      return this.settlementRateOption_; 
                }
            }
            set
            {
                if (this.settlementRateOption_ != value)
                {
                    this.settlementRateOption_ = value;
                }
            }
        }
        #endregion
        
        public string settlementRateOptionIDRef_ { get; set; }
        #region PriceSourceDisruption_
        private PriceSourceDisruption priceSourceDisruption_;
        public PriceSourceDisruption PriceSourceDisruption_
        {
            get
            {
                if (this.priceSourceDisruption_ != null)
                {
                    return this.priceSourceDisruption_; 
                }
                else if (this.priceSourceDisruptionIDRef_ != null)
                {
                    priceSourceDisruption_ = IDManager.getID(priceSourceDisruptionIDRef_) as PriceSourceDisruption;
                    return this.priceSourceDisruption_; 
                }
                else
                {
                      return this.priceSourceDisruption_; 
                }
            }
            set
            {
                if (this.priceSourceDisruption_ != value)
                {
                    this.priceSourceDisruption_ = value;
                }
            }
        }
        #endregion
        
        public string priceSourceDisruptionIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

