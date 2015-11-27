using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class EquityDerivativeBase : Product
    {
        public EquityDerivativeBase(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode buyerPartyReferenceNode = xmlNode.SelectSingleNode("buyerPartyReference");
            
            if (buyerPartyReferenceNode != null)
            {
                if (buyerPartyReferenceNode.Attributes["href"] != null || buyerPartyReferenceNode.Attributes["id"] != null) 
                {
                    if (buyerPartyReferenceNode.Attributes["id"] != null) 
                    {
                        buyerPartyReferenceIDRef_ = buyerPartyReferenceNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(buyerPartyReferenceNode);
                        IDManager.SetID(buyerPartyReferenceIDRef_, ob);
                    }
                    else if (buyerPartyReferenceNode.Attributes["href"] != null)
                    {
                        buyerPartyReferenceIDRef_ = buyerPartyReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        buyerPartyReference_ = new PartyReference(buyerPartyReferenceNode);
                    }
                }
                else
                {
                    buyerPartyReference_ = new PartyReference(buyerPartyReferenceNode);
                }
            }
            
        
            XmlNode buyerAccountReferenceNode = xmlNode.SelectSingleNode("buyerAccountReference");
            
            if (buyerAccountReferenceNode != null)
            {
                if (buyerAccountReferenceNode.Attributes["href"] != null || buyerAccountReferenceNode.Attributes["id"] != null) 
                {
                    if (buyerAccountReferenceNode.Attributes["id"] != null) 
                    {
                        buyerAccountReferenceIDRef_ = buyerAccountReferenceNode.Attributes["id"].Value;
                        AccountReference ob = new AccountReference(buyerAccountReferenceNode);
                        IDManager.SetID(buyerAccountReferenceIDRef_, ob);
                    }
                    else if (buyerAccountReferenceNode.Attributes["href"] != null)
                    {
                        buyerAccountReferenceIDRef_ = buyerAccountReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        buyerAccountReference_ = new AccountReference(buyerAccountReferenceNode);
                    }
                }
                else
                {
                    buyerAccountReference_ = new AccountReference(buyerAccountReferenceNode);
                }
            }
            
        
            XmlNode sellerPartyReferenceNode = xmlNode.SelectSingleNode("sellerPartyReference");
            
            if (sellerPartyReferenceNode != null)
            {
                if (sellerPartyReferenceNode.Attributes["href"] != null || sellerPartyReferenceNode.Attributes["id"] != null) 
                {
                    if (sellerPartyReferenceNode.Attributes["id"] != null) 
                    {
                        sellerPartyReferenceIDRef_ = sellerPartyReferenceNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(sellerPartyReferenceNode);
                        IDManager.SetID(sellerPartyReferenceIDRef_, ob);
                    }
                    else if (sellerPartyReferenceNode.Attributes["href"] != null)
                    {
                        sellerPartyReferenceIDRef_ = sellerPartyReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        sellerPartyReference_ = new PartyReference(sellerPartyReferenceNode);
                    }
                }
                else
                {
                    sellerPartyReference_ = new PartyReference(sellerPartyReferenceNode);
                }
            }
            
        
            XmlNode sellerAccountReferenceNode = xmlNode.SelectSingleNode("sellerAccountReference");
            
            if (sellerAccountReferenceNode != null)
            {
                if (sellerAccountReferenceNode.Attributes["href"] != null || sellerAccountReferenceNode.Attributes["id"] != null) 
                {
                    if (sellerAccountReferenceNode.Attributes["id"] != null) 
                    {
                        sellerAccountReferenceIDRef_ = sellerAccountReferenceNode.Attributes["id"].Value;
                        AccountReference ob = new AccountReference(sellerAccountReferenceNode);
                        IDManager.SetID(sellerAccountReferenceIDRef_, ob);
                    }
                    else if (sellerAccountReferenceNode.Attributes["href"] != null)
                    {
                        sellerAccountReferenceIDRef_ = sellerAccountReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        sellerAccountReference_ = new AccountReference(sellerAccountReferenceNode);
                    }
                }
                else
                {
                    sellerAccountReference_ = new AccountReference(sellerAccountReferenceNode);
                }
            }
            
        
            XmlNode optionTypeNode = xmlNode.SelectSingleNode("optionType");
            
            if (optionTypeNode != null)
            {
                if (optionTypeNode.Attributes["href"] != null || optionTypeNode.Attributes["id"] != null) 
                {
                    if (optionTypeNode.Attributes["id"] != null) 
                    {
                        optionTypeIDRef_ = optionTypeNode.Attributes["id"].Value;
                        EquityOptionTypeEnum ob = new EquityOptionTypeEnum(optionTypeNode);
                        IDManager.SetID(optionTypeIDRef_, ob);
                    }
                    else if (optionTypeNode.Attributes["href"] != null)
                    {
                        optionTypeIDRef_ = optionTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        optionType_ = new EquityOptionTypeEnum(optionTypeNode);
                    }
                }
                else
                {
                    optionType_ = new EquityOptionTypeEnum(optionTypeNode);
                }
            }
            
        
            XmlNode equityEffectiveDateNode = xmlNode.SelectSingleNode("equityEffectiveDate");
            
            if (equityEffectiveDateNode != null)
            {
                if (equityEffectiveDateNode.Attributes["href"] != null || equityEffectiveDateNode.Attributes["id"] != null) 
                {
                    if (equityEffectiveDateNode.Attributes["id"] != null) 
                    {
                        equityEffectiveDateIDRef_ = equityEffectiveDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(equityEffectiveDateNode);
                        IDManager.SetID(equityEffectiveDateIDRef_, ob);
                    }
                    else if (equityEffectiveDateNode.Attributes["href"] != null)
                    {
                        equityEffectiveDateIDRef_ = equityEffectiveDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        equityEffectiveDate_ = new XsdTypeDate(equityEffectiveDateNode);
                    }
                }
                else
                {
                    equityEffectiveDate_ = new XsdTypeDate(equityEffectiveDateNode);
                }
            }
            
        
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
            
        
            XmlNode notionalNode = xmlNode.SelectSingleNode("notional");
            
            if (notionalNode != null)
            {
                if (notionalNode.Attributes["href"] != null || notionalNode.Attributes["id"] != null) 
                {
                    if (notionalNode.Attributes["id"] != null) 
                    {
                        notionalIDRef_ = notionalNode.Attributes["id"].Value;
                        NonNegativeMoney ob = new NonNegativeMoney(notionalNode);
                        IDManager.SetID(notionalIDRef_, ob);
                    }
                    else if (notionalNode.Attributes["href"] != null)
                    {
                        notionalIDRef_ = notionalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        notional_ = new NonNegativeMoney(notionalNode);
                    }
                }
                else
                {
                    notional_ = new NonNegativeMoney(notionalNode);
                }
            }
            
        
            XmlNode equityExerciseNode = xmlNode.SelectSingleNode("equityExercise");
            
            if (equityExerciseNode != null)
            {
                if (equityExerciseNode.Attributes["href"] != null || equityExerciseNode.Attributes["id"] != null) 
                {
                    if (equityExerciseNode.Attributes["id"] != null) 
                    {
                        equityExerciseIDRef_ = equityExerciseNode.Attributes["id"].Value;
                        EquityExerciseValuationSettlement ob = new EquityExerciseValuationSettlement(equityExerciseNode);
                        IDManager.SetID(equityExerciseIDRef_, ob);
                    }
                    else if (equityExerciseNode.Attributes["href"] != null)
                    {
                        equityExerciseIDRef_ = equityExerciseNode.Attributes["href"].Value;
                    }
                    else
                    {
                        equityExercise_ = new EquityExerciseValuationSettlement(equityExerciseNode);
                    }
                }
                else
                {
                    equityExercise_ = new EquityExerciseValuationSettlement(equityExerciseNode);
                }
            }
            
        
            XmlNode featureNode = xmlNode.SelectSingleNode("feature");
            
            if (featureNode != null)
            {
                if (featureNode.Attributes["href"] != null || featureNode.Attributes["id"] != null) 
                {
                    if (featureNode.Attributes["id"] != null) 
                    {
                        featureIDRef_ = featureNode.Attributes["id"].Value;
                        OptionFeatures ob = new OptionFeatures(featureNode);
                        IDManager.SetID(featureIDRef_, ob);
                    }
                    else if (featureNode.Attributes["href"] != null)
                    {
                        featureIDRef_ = featureNode.Attributes["href"].Value;
                    }
                    else
                    {
                        feature_ = new OptionFeatures(featureNode);
                    }
                }
                else
                {
                    feature_ = new OptionFeatures(featureNode);
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
            
        
            XmlNode strategyFeatureNode = xmlNode.SelectSingleNode("strategyFeature");
            
            if (strategyFeatureNode != null)
            {
                if (strategyFeatureNode.Attributes["href"] != null || strategyFeatureNode.Attributes["id"] != null) 
                {
                    if (strategyFeatureNode.Attributes["id"] != null) 
                    {
                        strategyFeatureIDRef_ = strategyFeatureNode.Attributes["id"].Value;
                        StrategyFeature ob = new StrategyFeature(strategyFeatureNode);
                        IDManager.SetID(strategyFeatureIDRef_, ob);
                    }
                    else if (strategyFeatureNode.Attributes["href"] != null)
                    {
                        strategyFeatureIDRef_ = strategyFeatureNode.Attributes["href"].Value;
                    }
                    else
                    {
                        strategyFeature_ = new StrategyFeature(strategyFeatureNode);
                    }
                }
                else
                {
                    strategyFeature_ = new StrategyFeature(strategyFeatureNode);
                }
            }
            
        
        }
        
    
        #region BuyerPartyReference_
        private PartyReference buyerPartyReference_;
        public PartyReference BuyerPartyReference_
        {
            get
            {
                if (this.buyerPartyReference_ != null)
                {
                    return this.buyerPartyReference_; 
                }
                else if (this.buyerPartyReferenceIDRef_ != null)
                {
                    buyerPartyReference_ = IDManager.getID(buyerPartyReferenceIDRef_) as PartyReference;
                    return this.buyerPartyReference_; 
                }
                else
                {
                      return this.buyerPartyReference_; 
                }
            }
            set
            {
                if (this.buyerPartyReference_ != value)
                {
                    this.buyerPartyReference_ = value;
                }
            }
        }
        #endregion
        
        public string buyerPartyReferenceIDRef_ { get; set; }
        #region BuyerAccountReference_
        private AccountReference buyerAccountReference_;
        public AccountReference BuyerAccountReference_
        {
            get
            {
                if (this.buyerAccountReference_ != null)
                {
                    return this.buyerAccountReference_; 
                }
                else if (this.buyerAccountReferenceIDRef_ != null)
                {
                    buyerAccountReference_ = IDManager.getID(buyerAccountReferenceIDRef_) as AccountReference;
                    return this.buyerAccountReference_; 
                }
                else
                {
                      return this.buyerAccountReference_; 
                }
            }
            set
            {
                if (this.buyerAccountReference_ != value)
                {
                    this.buyerAccountReference_ = value;
                }
            }
        }
        #endregion
        
        public string buyerAccountReferenceIDRef_ { get; set; }
        #region SellerPartyReference_
        private PartyReference sellerPartyReference_;
        public PartyReference SellerPartyReference_
        {
            get
            {
                if (this.sellerPartyReference_ != null)
                {
                    return this.sellerPartyReference_; 
                }
                else if (this.sellerPartyReferenceIDRef_ != null)
                {
                    sellerPartyReference_ = IDManager.getID(sellerPartyReferenceIDRef_) as PartyReference;
                    return this.sellerPartyReference_; 
                }
                else
                {
                      return this.sellerPartyReference_; 
                }
            }
            set
            {
                if (this.sellerPartyReference_ != value)
                {
                    this.sellerPartyReference_ = value;
                }
            }
        }
        #endregion
        
        public string sellerPartyReferenceIDRef_ { get; set; }
        #region SellerAccountReference_
        private AccountReference sellerAccountReference_;
        public AccountReference SellerAccountReference_
        {
            get
            {
                if (this.sellerAccountReference_ != null)
                {
                    return this.sellerAccountReference_; 
                }
                else if (this.sellerAccountReferenceIDRef_ != null)
                {
                    sellerAccountReference_ = IDManager.getID(sellerAccountReferenceIDRef_) as AccountReference;
                    return this.sellerAccountReference_; 
                }
                else
                {
                      return this.sellerAccountReference_; 
                }
            }
            set
            {
                if (this.sellerAccountReference_ != value)
                {
                    this.sellerAccountReference_ = value;
                }
            }
        }
        #endregion
        
        public string sellerAccountReferenceIDRef_ { get; set; }
        #region OptionType_
        private EquityOptionTypeEnum optionType_;
        public EquityOptionTypeEnum OptionType_
        {
            get
            {
                if (this.optionType_ != null)
                {
                    return this.optionType_; 
                }
                else if (this.optionTypeIDRef_ != null)
                {
                    optionType_ = IDManager.getID(optionTypeIDRef_) as EquityOptionTypeEnum;
                    return this.optionType_; 
                }
                else
                {
                      return this.optionType_; 
                }
            }
            set
            {
                if (this.optionType_ != value)
                {
                    this.optionType_ = value;
                }
            }
        }
        #endregion
        
        public string optionTypeIDRef_ { get; set; }
        #region EquityEffectiveDate_
        private XsdTypeDate equityEffectiveDate_;
        public XsdTypeDate EquityEffectiveDate_
        {
            get
            {
                if (this.equityEffectiveDate_ != null)
                {
                    return this.equityEffectiveDate_; 
                }
                else if (this.equityEffectiveDateIDRef_ != null)
                {
                    equityEffectiveDate_ = IDManager.getID(equityEffectiveDateIDRef_) as XsdTypeDate;
                    return this.equityEffectiveDate_; 
                }
                else
                {
                      return this.equityEffectiveDate_; 
                }
            }
            set
            {
                if (this.equityEffectiveDate_ != value)
                {
                    this.equityEffectiveDate_ = value;
                }
            }
        }
        #endregion
        
        public string equityEffectiveDateIDRef_ { get; set; }
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
        #region Notional_
        private NonNegativeMoney notional_;
        public NonNegativeMoney Notional_
        {
            get
            {
                if (this.notional_ != null)
                {
                    return this.notional_; 
                }
                else if (this.notionalIDRef_ != null)
                {
                    notional_ = IDManager.getID(notionalIDRef_) as NonNegativeMoney;
                    return this.notional_; 
                }
                else
                {
                      return this.notional_; 
                }
            }
            set
            {
                if (this.notional_ != value)
                {
                    this.notional_ = value;
                }
            }
        }
        #endregion
        
        public string notionalIDRef_ { get; set; }
        #region EquityExercise_
        private EquityExerciseValuationSettlement equityExercise_;
        public EquityExerciseValuationSettlement EquityExercise_
        {
            get
            {
                if (this.equityExercise_ != null)
                {
                    return this.equityExercise_; 
                }
                else if (this.equityExerciseIDRef_ != null)
                {
                    equityExercise_ = IDManager.getID(equityExerciseIDRef_) as EquityExerciseValuationSettlement;
                    return this.equityExercise_; 
                }
                else
                {
                      return this.equityExercise_; 
                }
            }
            set
            {
                if (this.equityExercise_ != value)
                {
                    this.equityExercise_ = value;
                }
            }
        }
        #endregion
        
        public string equityExerciseIDRef_ { get; set; }
        #region Feature_
        private OptionFeatures feature_;
        public OptionFeatures Feature_
        {
            get
            {
                if (this.feature_ != null)
                {
                    return this.feature_; 
                }
                else if (this.featureIDRef_ != null)
                {
                    feature_ = IDManager.getID(featureIDRef_) as OptionFeatures;
                    return this.feature_; 
                }
                else
                {
                      return this.feature_; 
                }
            }
            set
            {
                if (this.feature_ != value)
                {
                    this.feature_ = value;
                }
            }
        }
        #endregion
        
        public string featureIDRef_ { get; set; }
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
        #region StrategyFeature_
        private StrategyFeature strategyFeature_;
        public StrategyFeature StrategyFeature_
        {
            get
            {
                if (this.strategyFeature_ != null)
                {
                    return this.strategyFeature_; 
                }
                else if (this.strategyFeatureIDRef_ != null)
                {
                    strategyFeature_ = IDManager.getID(strategyFeatureIDRef_) as StrategyFeature;
                    return this.strategyFeature_; 
                }
                else
                {
                      return this.strategyFeature_; 
                }
            }
            set
            {
                if (this.strategyFeature_ != value)
                {
                    this.strategyFeature_ = value;
                }
            }
        }
        #endregion
        
        public string strategyFeatureIDRef_ { get; set; }
        
    
        
    
    }
    
}

