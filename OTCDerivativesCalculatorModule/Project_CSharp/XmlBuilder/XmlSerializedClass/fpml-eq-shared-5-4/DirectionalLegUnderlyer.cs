using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class DirectionalLegUnderlyer : DirectionalLeg
    {
        public DirectionalLegUnderlyer(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode underlyerNode = xmlNode.SelectSingleNode("underlyer");
            
            if (underlyerNode != null)
            {
                if (underlyerNode.Attributes["href"] != null || underlyerNode.Attributes["id"] != null) 
                {
                    if (underlyerNode.Attributes["id"] != null) 
                    {
                        underlyerIDRef_ = underlyerNode.Attributes["id"].Value;
                        Underlyer ob = new Underlyer(underlyerNode);
                        IDManager.SetID(underlyerIDRef_, ob);
                    }
                    else if (underlyerNode.Attributes["href"] != null)
                    {
                        underlyerIDRef_ = underlyerNode.Attributes["href"].Value;
                    }
                    else
                    {
                        underlyer_ = new Underlyer(underlyerNode);
                    }
                }
                else
                {
                    underlyer_ = new Underlyer(underlyerNode);
                }
            }
            
        
            XmlNode settlementTypeNode = xmlNode.SelectSingleNode("settlementType");
            
            if (settlementTypeNode != null)
            {
                if (settlementTypeNode.Attributes["href"] != null || settlementTypeNode.Attributes["id"] != null) 
                {
                    if (settlementTypeNode.Attributes["id"] != null) 
                    {
                        settlementTypeIDRef_ = settlementTypeNode.Attributes["id"].Value;
                        SettlementTypeEnum ob = new SettlementTypeEnum(settlementTypeNode);
                        IDManager.SetID(settlementTypeIDRef_, ob);
                    }
                    else if (settlementTypeNode.Attributes["href"] != null)
                    {
                        settlementTypeIDRef_ = settlementTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        settlementType_ = new SettlementTypeEnum(settlementTypeNode);
                    }
                }
                else
                {
                    settlementType_ = new SettlementTypeEnum(settlementTypeNode);
                }
            }
            
        
            XmlNode settlementDateNode = xmlNode.SelectSingleNode("settlementDate");
            
            if (settlementDateNode != null)
            {
                if (settlementDateNode.Attributes["href"] != null || settlementDateNode.Attributes["id"] != null) 
                {
                    if (settlementDateNode.Attributes["id"] != null) 
                    {
                        settlementDateIDRef_ = settlementDateNode.Attributes["id"].Value;
                        AdjustableOrRelativeDate ob = new AdjustableOrRelativeDate(settlementDateNode);
                        IDManager.SetID(settlementDateIDRef_, ob);
                    }
                    else if (settlementDateNode.Attributes["href"] != null)
                    {
                        settlementDateIDRef_ = settlementDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        settlementDate_ = new AdjustableOrRelativeDate(settlementDateNode);
                    }
                }
                else
                {
                    settlementDate_ = new AdjustableOrRelativeDate(settlementDateNode);
                }
            }
            
        
            XmlNode settlementAmountNode = xmlNode.SelectSingleNode("settlementAmount");
            
            if (settlementAmountNode != null)
            {
                if (settlementAmountNode.Attributes["href"] != null || settlementAmountNode.Attributes["id"] != null) 
                {
                    if (settlementAmountNode.Attributes["id"] != null) 
                    {
                        settlementAmountIDRef_ = settlementAmountNode.Attributes["id"].Value;
                        Money ob = new Money(settlementAmountNode);
                        IDManager.SetID(settlementAmountIDRef_, ob);
                    }
                    else if (settlementAmountNode.Attributes["href"] != null)
                    {
                        settlementAmountIDRef_ = settlementAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        settlementAmount_ = new Money(settlementAmountNode);
                    }
                }
                else
                {
                    settlementAmount_ = new Money(settlementAmountNode);
                }
            }
            
        
            XmlNode settlementCurrencyNode = xmlNode.SelectSingleNode("settlementCurrency");
            
            if (settlementCurrencyNode != null)
            {
                if (settlementCurrencyNode.Attributes["href"] != null || settlementCurrencyNode.Attributes["id"] != null) 
                {
                    if (settlementCurrencyNode.Attributes["id"] != null) 
                    {
                        settlementCurrencyIDRef_ = settlementCurrencyNode.Attributes["id"].Value;
                        Currency ob = new Currency(settlementCurrencyNode);
                        IDManager.SetID(settlementCurrencyIDRef_, ob);
                    }
                    else if (settlementCurrencyNode.Attributes["href"] != null)
                    {
                        settlementCurrencyIDRef_ = settlementCurrencyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        settlementCurrency_ = new Currency(settlementCurrencyNode);
                    }
                }
                else
                {
                    settlementCurrency_ = new Currency(settlementCurrencyNode);
                }
            }
            
        
            XmlNode fxFeatureNode = xmlNode.SelectSingleNode("fxFeature");
            
            if (fxFeatureNode != null)
            {
                if (fxFeatureNode.Attributes["href"] != null || fxFeatureNode.Attributes["id"] != null) 
                {
                    if (fxFeatureNode.Attributes["id"] != null) 
                    {
                        fxFeatureIDRef_ = fxFeatureNode.Attributes["id"].Value;
                        FxFeature ob = new FxFeature(fxFeatureNode);
                        IDManager.SetID(fxFeatureIDRef_, ob);
                    }
                    else if (fxFeatureNode.Attributes["href"] != null)
                    {
                        fxFeatureIDRef_ = fxFeatureNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fxFeature_ = new FxFeature(fxFeatureNode);
                    }
                }
                else
                {
                    fxFeature_ = new FxFeature(fxFeatureNode);
                }
            }
            
        
        }
        
    
        #region Underlyer_
        private Underlyer underlyer_;
        public Underlyer Underlyer_
        {
            get
            {
                if (this.underlyer_ != null)
                {
                    return this.underlyer_; 
                }
                else if (this.underlyerIDRef_ != null)
                {
                    underlyer_ = IDManager.getID(underlyerIDRef_) as Underlyer;
                    return this.underlyer_; 
                }
                else
                {
                      return this.underlyer_; 
                }
            }
            set
            {
                if (this.underlyer_ != value)
                {
                    this.underlyer_ = value;
                }
            }
        }
        #endregion
        
        public string underlyerIDRef_ { get; set; }
        #region SettlementType_
        private SettlementTypeEnum settlementType_;
        public SettlementTypeEnum SettlementType_
        {
            get
            {
                if (this.settlementType_ != null)
                {
                    return this.settlementType_; 
                }
                else if (this.settlementTypeIDRef_ != null)
                {
                    settlementType_ = IDManager.getID(settlementTypeIDRef_) as SettlementTypeEnum;
                    return this.settlementType_; 
                }
                else
                {
                      return this.settlementType_; 
                }
            }
            set
            {
                if (this.settlementType_ != value)
                {
                    this.settlementType_ = value;
                }
            }
        }
        #endregion
        
        public string settlementTypeIDRef_ { get; set; }
        #region SettlementDate_
        private AdjustableOrRelativeDate settlementDate_;
        public AdjustableOrRelativeDate SettlementDate_
        {
            get
            {
                if (this.settlementDate_ != null)
                {
                    return this.settlementDate_; 
                }
                else if (this.settlementDateIDRef_ != null)
                {
                    settlementDate_ = IDManager.getID(settlementDateIDRef_) as AdjustableOrRelativeDate;
                    return this.settlementDate_; 
                }
                else
                {
                      return this.settlementDate_; 
                }
            }
            set
            {
                if (this.settlementDate_ != value)
                {
                    this.settlementDate_ = value;
                }
            }
        }
        #endregion
        
        public string settlementDateIDRef_ { get; set; }
        #region SettlementAmount_
        private Money settlementAmount_;
        public Money SettlementAmount_
        {
            get
            {
                if (this.settlementAmount_ != null)
                {
                    return this.settlementAmount_; 
                }
                else if (this.settlementAmountIDRef_ != null)
                {
                    settlementAmount_ = IDManager.getID(settlementAmountIDRef_) as Money;
                    return this.settlementAmount_; 
                }
                else
                {
                      return this.settlementAmount_; 
                }
            }
            set
            {
                if (this.settlementAmount_ != value)
                {
                    this.settlementAmount_ = value;
                }
            }
        }
        #endregion
        
        public string settlementAmountIDRef_ { get; set; }
        #region SettlementCurrency_
        private Currency settlementCurrency_;
        public Currency SettlementCurrency_
        {
            get
            {
                if (this.settlementCurrency_ != null)
                {
                    return this.settlementCurrency_; 
                }
                else if (this.settlementCurrencyIDRef_ != null)
                {
                    settlementCurrency_ = IDManager.getID(settlementCurrencyIDRef_) as Currency;
                    return this.settlementCurrency_; 
                }
                else
                {
                      return this.settlementCurrency_; 
                }
            }
            set
            {
                if (this.settlementCurrency_ != value)
                {
                    this.settlementCurrency_ = value;
                }
            }
        }
        #endregion
        
        public string settlementCurrencyIDRef_ { get; set; }
        #region FxFeature_
        private FxFeature fxFeature_;
        public FxFeature FxFeature_
        {
            get
            {
                if (this.fxFeature_ != null)
                {
                    return this.fxFeature_; 
                }
                else if (this.fxFeatureIDRef_ != null)
                {
                    fxFeature_ = IDManager.getID(fxFeatureIDRef_) as FxFeature;
                    return this.fxFeature_; 
                }
                else
                {
                      return this.fxFeature_; 
                }
            }
            set
            {
                if (this.fxFeature_ != value)
                {
                    this.fxFeature_ = value;
                }
            }
        }
        #endregion
        
        public string fxFeatureIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

