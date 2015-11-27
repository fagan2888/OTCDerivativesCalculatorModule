using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class OptionExercise : AbstractEvent
    {
        public OptionExercise(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode optionSellerNode = xmlNode.SelectSingleNode("optionSeller");
            
            if (optionSellerNode != null)
            {
                if (optionSellerNode.Attributes["href"] != null || optionSellerNode.Attributes["id"] != null) 
                {
                    if (optionSellerNode.Attributes["id"] != null) 
                    {
                        optionSellerIDRef_ = optionSellerNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(optionSellerNode);
                        IDManager.SetID(optionSellerIDRef_, ob);
                    }
                    else if (optionSellerNode.Attributes["href"] != null)
                    {
                        optionSellerIDRef_ = optionSellerNode.Attributes["href"].Value;
                    }
                    else
                    {
                        optionSeller_ = new PartyReference(optionSellerNode);
                    }
                }
                else
                {
                    optionSeller_ = new PartyReference(optionSellerNode);
                }
            }
            
        
            XmlNode optionBuyerNode = xmlNode.SelectSingleNode("optionBuyer");
            
            if (optionBuyerNode != null)
            {
                if (optionBuyerNode.Attributes["href"] != null || optionBuyerNode.Attributes["id"] != null) 
                {
                    if (optionBuyerNode.Attributes["id"] != null) 
                    {
                        optionBuyerIDRef_ = optionBuyerNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(optionBuyerNode);
                        IDManager.SetID(optionBuyerIDRef_, ob);
                    }
                    else if (optionBuyerNode.Attributes["href"] != null)
                    {
                        optionBuyerIDRef_ = optionBuyerNode.Attributes["href"].Value;
                    }
                    else
                    {
                        optionBuyer_ = new PartyReference(optionBuyerNode);
                    }
                }
                else
                {
                    optionBuyer_ = new PartyReference(optionBuyerNode);
                }
            }
            
        
            XmlNode originalTradeNode = xmlNode.SelectSingleNode("originalTrade");
            
            if (originalTradeNode != null)
            {
                if (originalTradeNode.Attributes["href"] != null || originalTradeNode.Attributes["id"] != null) 
                {
                    if (originalTradeNode.Attributes["id"] != null) 
                    {
                        originalTradeIDRef_ = originalTradeNode.Attributes["id"].Value;
                        Trade ob = new Trade(originalTradeNode);
                        IDManager.SetID(originalTradeIDRef_, ob);
                    }
                    else if (originalTradeNode.Attributes["href"] != null)
                    {
                        originalTradeIDRef_ = originalTradeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        originalTrade_ = new Trade(originalTradeNode);
                    }
                }
                else
                {
                    originalTrade_ = new Trade(originalTradeNode);
                }
            }
            
        
            XmlNodeList tradeIdentifierNodeList = xmlNode.SelectNodes("tradeIdentifier");
            
            if (tradeIdentifierNodeList != null)
            {
                this.tradeIdentifier_ = new List<PartyTradeIdentifier>();
                foreach (XmlNode item in tradeIdentifierNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            tradeIdentifierIDRef_ = item.Attributes["id"].Value;
                            tradeIdentifier_.Add(new PartyTradeIdentifier(item));
                            IDManager.SetID(tradeIdentifierIDRef_, tradeIdentifier_[tradeIdentifier_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            tradeIdentifierIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        tradeIdentifier_.Add(new PartyTradeIdentifier(item));
                        }
                    }
                    else
                    {
                        tradeIdentifier_.Add(new PartyTradeIdentifier(item));
                    }
                }
            }
            
        
            XmlNode exerciseDateNode = xmlNode.SelectSingleNode("exerciseDate");
            
            if (exerciseDateNode != null)
            {
                if (exerciseDateNode.Attributes["href"] != null || exerciseDateNode.Attributes["id"] != null) 
                {
                    if (exerciseDateNode.Attributes["id"] != null) 
                    {
                        exerciseDateIDRef_ = exerciseDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(exerciseDateNode);
                        IDManager.SetID(exerciseDateIDRef_, ob);
                    }
                    else if (exerciseDateNode.Attributes["href"] != null)
                    {
                        exerciseDateIDRef_ = exerciseDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        exerciseDate_ = new XsdTypeDate(exerciseDateNode);
                    }
                }
                else
                {
                    exerciseDate_ = new XsdTypeDate(exerciseDateNode);
                }
            }
            
        
            XmlNode exerciseTimeNode = xmlNode.SelectSingleNode("exerciseTime");
            
            if (exerciseTimeNode != null)
            {
                if (exerciseTimeNode.Attributes["href"] != null || exerciseTimeNode.Attributes["id"] != null) 
                {
                    if (exerciseTimeNode.Attributes["id"] != null) 
                    {
                        exerciseTimeIDRef_ = exerciseTimeNode.Attributes["id"].Value;
                        XsdTypeTime ob = new XsdTypeTime(exerciseTimeNode);
                        IDManager.SetID(exerciseTimeIDRef_, ob);
                    }
                    else if (exerciseTimeNode.Attributes["href"] != null)
                    {
                        exerciseTimeIDRef_ = exerciseTimeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        exerciseTime_ = new XsdTypeTime(exerciseTimeNode);
                    }
                }
                else
                {
                    exerciseTime_ = new XsdTypeTime(exerciseTimeNode);
                }
            }
            
        
            XmlNode expiryNode = xmlNode.SelectSingleNode("expiry");
            
            if (expiryNode != null)
            {
                if (expiryNode.Attributes["href"] != null || expiryNode.Attributes["id"] != null) 
                {
                    if (expiryNode.Attributes["id"] != null) 
                    {
                        expiryIDRef_ = expiryNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(expiryNode);
                        IDManager.SetID(expiryIDRef_, ob);
                    }
                    else if (expiryNode.Attributes["href"] != null)
                    {
                        expiryIDRef_ = expiryNode.Attributes["href"].Value;
                    }
                    else
                    {
                        expiry_ = new XsdTypeBoolean(expiryNode);
                    }
                }
                else
                {
                    expiry_ = new XsdTypeBoolean(expiryNode);
                }
            }
            
        
            XmlNode fullExerciseNode = xmlNode.SelectSingleNode("fullExercise");
            
            if (fullExerciseNode != null)
            {
                if (fullExerciseNode.Attributes["href"] != null || fullExerciseNode.Attributes["id"] != null) 
                {
                    if (fullExerciseNode.Attributes["id"] != null) 
                    {
                        fullExerciseIDRef_ = fullExerciseNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(fullExerciseNode);
                        IDManager.SetID(fullExerciseIDRef_, ob);
                    }
                    else if (fullExerciseNode.Attributes["href"] != null)
                    {
                        fullExerciseIDRef_ = fullExerciseNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fullExercise_ = new XsdTypeBoolean(fullExerciseNode);
                    }
                }
                else
                {
                    fullExercise_ = new XsdTypeBoolean(fullExerciseNode);
                }
            }
            
        
            XmlNode exerciseInNotionalAmountNode = xmlNode.SelectSingleNode("exerciseInNotionalAmount");
            
            if (exerciseInNotionalAmountNode != null)
            {
                if (exerciseInNotionalAmountNode.Attributes["href"] != null || exerciseInNotionalAmountNode.Attributes["id"] != null) 
                {
                    if (exerciseInNotionalAmountNode.Attributes["id"] != null) 
                    {
                        exerciseInNotionalAmountIDRef_ = exerciseInNotionalAmountNode.Attributes["id"].Value;
                        Money ob = new Money(exerciseInNotionalAmountNode);
                        IDManager.SetID(exerciseInNotionalAmountIDRef_, ob);
                    }
                    else if (exerciseInNotionalAmountNode.Attributes["href"] != null)
                    {
                        exerciseInNotionalAmountIDRef_ = exerciseInNotionalAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        exerciseInNotionalAmount_ = new Money(exerciseInNotionalAmountNode);
                    }
                }
                else
                {
                    exerciseInNotionalAmount_ = new Money(exerciseInNotionalAmountNode);
                }
            }
            
        
            XmlNode outstandingNotionalAmountNode = xmlNode.SelectSingleNode("outstandingNotionalAmount");
            
            if (outstandingNotionalAmountNode != null)
            {
                if (outstandingNotionalAmountNode.Attributes["href"] != null || outstandingNotionalAmountNode.Attributes["id"] != null) 
                {
                    if (outstandingNotionalAmountNode.Attributes["id"] != null) 
                    {
                        outstandingNotionalAmountIDRef_ = outstandingNotionalAmountNode.Attributes["id"].Value;
                        Money ob = new Money(outstandingNotionalAmountNode);
                        IDManager.SetID(outstandingNotionalAmountIDRef_, ob);
                    }
                    else if (outstandingNotionalAmountNode.Attributes["href"] != null)
                    {
                        outstandingNotionalAmountIDRef_ = outstandingNotionalAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        outstandingNotionalAmount_ = new Money(outstandingNotionalAmountNode);
                    }
                }
                else
                {
                    outstandingNotionalAmount_ = new Money(outstandingNotionalAmountNode);
                }
            }
            
        
            XmlNode exerciseInNumberOfOptionsNode = xmlNode.SelectSingleNode("exerciseInNumberOfOptions");
            
            if (exerciseInNumberOfOptionsNode != null)
            {
                if (exerciseInNumberOfOptionsNode.Attributes["href"] != null || exerciseInNumberOfOptionsNode.Attributes["id"] != null) 
                {
                    if (exerciseInNumberOfOptionsNode.Attributes["id"] != null) 
                    {
                        exerciseInNumberOfOptionsIDRef_ = exerciseInNumberOfOptionsNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(exerciseInNumberOfOptionsNode);
                        IDManager.SetID(exerciseInNumberOfOptionsIDRef_, ob);
                    }
                    else if (exerciseInNumberOfOptionsNode.Attributes["href"] != null)
                    {
                        exerciseInNumberOfOptionsIDRef_ = exerciseInNumberOfOptionsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        exerciseInNumberOfOptions_ = new XsdTypeDecimal(exerciseInNumberOfOptionsNode);
                    }
                }
                else
                {
                    exerciseInNumberOfOptions_ = new XsdTypeDecimal(exerciseInNumberOfOptionsNode);
                }
            }
            
        
            XmlNode outstandingNumberOfOptionsNode = xmlNode.SelectSingleNode("outstandingNumberOfOptions");
            
            if (outstandingNumberOfOptionsNode != null)
            {
                if (outstandingNumberOfOptionsNode.Attributes["href"] != null || outstandingNumberOfOptionsNode.Attributes["id"] != null) 
                {
                    if (outstandingNumberOfOptionsNode.Attributes["id"] != null) 
                    {
                        outstandingNumberOfOptionsIDRef_ = outstandingNumberOfOptionsNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(outstandingNumberOfOptionsNode);
                        IDManager.SetID(outstandingNumberOfOptionsIDRef_, ob);
                    }
                    else if (outstandingNumberOfOptionsNode.Attributes["href"] != null)
                    {
                        outstandingNumberOfOptionsIDRef_ = outstandingNumberOfOptionsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        outstandingNumberOfOptions_ = new XsdTypeDecimal(outstandingNumberOfOptionsNode);
                    }
                }
                else
                {
                    outstandingNumberOfOptions_ = new XsdTypeDecimal(outstandingNumberOfOptionsNode);
                }
            }
            
        
            XmlNode exerciseInNumberOfUnitsNode = xmlNode.SelectSingleNode("exerciseInNumberOfUnits");
            
            if (exerciseInNumberOfUnitsNode != null)
            {
                if (exerciseInNumberOfUnitsNode.Attributes["href"] != null || exerciseInNumberOfUnitsNode.Attributes["id"] != null) 
                {
                    if (exerciseInNumberOfUnitsNode.Attributes["id"] != null) 
                    {
                        exerciseInNumberOfUnitsIDRef_ = exerciseInNumberOfUnitsNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(exerciseInNumberOfUnitsNode);
                        IDManager.SetID(exerciseInNumberOfUnitsIDRef_, ob);
                    }
                    else if (exerciseInNumberOfUnitsNode.Attributes["href"] != null)
                    {
                        exerciseInNumberOfUnitsIDRef_ = exerciseInNumberOfUnitsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        exerciseInNumberOfUnits_ = new XsdTypeDecimal(exerciseInNumberOfUnitsNode);
                    }
                }
                else
                {
                    exerciseInNumberOfUnits_ = new XsdTypeDecimal(exerciseInNumberOfUnitsNode);
                }
            }
            
        
            XmlNode outstandingNumberOfUnitsNode = xmlNode.SelectSingleNode("outstandingNumberOfUnits");
            
            if (outstandingNumberOfUnitsNode != null)
            {
                if (outstandingNumberOfUnitsNode.Attributes["href"] != null || outstandingNumberOfUnitsNode.Attributes["id"] != null) 
                {
                    if (outstandingNumberOfUnitsNode.Attributes["id"] != null) 
                    {
                        outstandingNumberOfUnitsIDRef_ = outstandingNumberOfUnitsNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(outstandingNumberOfUnitsNode);
                        IDManager.SetID(outstandingNumberOfUnitsIDRef_, ob);
                    }
                    else if (outstandingNumberOfUnitsNode.Attributes["href"] != null)
                    {
                        outstandingNumberOfUnitsIDRef_ = outstandingNumberOfUnitsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        outstandingNumberOfUnits_ = new XsdTypeDecimal(outstandingNumberOfUnitsNode);
                    }
                }
                else
                {
                    outstandingNumberOfUnits_ = new XsdTypeDecimal(outstandingNumberOfUnitsNode);
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
            
        
            XmlNode cashSettlementNode = xmlNode.SelectSingleNode("cashSettlement");
            
            if (cashSettlementNode != null)
            {
                if (cashSettlementNode.Attributes["href"] != null || cashSettlementNode.Attributes["id"] != null) 
                {
                    if (cashSettlementNode.Attributes["id"] != null) 
                    {
                        cashSettlementIDRef_ = cashSettlementNode.Attributes["id"].Value;
                        SimplePayment ob = new SimplePayment(cashSettlementNode);
                        IDManager.SetID(cashSettlementIDRef_, ob);
                    }
                    else if (cashSettlementNode.Attributes["href"] != null)
                    {
                        cashSettlementIDRef_ = cashSettlementNode.Attributes["href"].Value;
                    }
                    else
                    {
                        cashSettlement_ = new SimplePayment(cashSettlementNode);
                    }
                }
                else
                {
                    cashSettlement_ = new SimplePayment(cashSettlementNode);
                }
            }
            
        
            XmlNode physicalSettlementNode = xmlNode.SelectSingleNode("physicalSettlement");
            
            if (physicalSettlementNode != null)
            {
                if (physicalSettlementNode.Attributes["href"] != null || physicalSettlementNode.Attributes["id"] != null) 
                {
                    if (physicalSettlementNode.Attributes["id"] != null) 
                    {
                        physicalSettlementIDRef_ = physicalSettlementNode.Attributes["id"].Value;
                        PhysicalSettlement ob = new PhysicalSettlement(physicalSettlementNode);
                        IDManager.SetID(physicalSettlementIDRef_, ob);
                    }
                    else if (physicalSettlementNode.Attributes["href"] != null)
                    {
                        physicalSettlementIDRef_ = physicalSettlementNode.Attributes["href"].Value;
                    }
                    else
                    {
                        physicalSettlement_ = new PhysicalSettlement(physicalSettlementNode);
                    }
                }
                else
                {
                    physicalSettlement_ = new PhysicalSettlement(physicalSettlementNode);
                }
            }
            
        
            XmlNode paymentNode = xmlNode.SelectSingleNode("payment");
            
            if (paymentNode != null)
            {
                if (paymentNode.Attributes["href"] != null || paymentNode.Attributes["id"] != null) 
                {
                    if (paymentNode.Attributes["id"] != null) 
                    {
                        paymentIDRef_ = paymentNode.Attributes["id"].Value;
                        NonNegativePayment ob = new NonNegativePayment(paymentNode);
                        IDManager.SetID(paymentIDRef_, ob);
                    }
                    else if (paymentNode.Attributes["href"] != null)
                    {
                        paymentIDRef_ = paymentNode.Attributes["href"].Value;
                    }
                    else
                    {
                        payment_ = new NonNegativePayment(paymentNode);
                    }
                }
                else
                {
                    payment_ = new NonNegativePayment(paymentNode);
                }
            }
            
        
        }
        
    
        #region OptionSeller_
        private PartyReference optionSeller_;
        public PartyReference OptionSeller_
        {
            get
            {
                if (this.optionSeller_ != null)
                {
                    return this.optionSeller_; 
                }
                else if (this.optionSellerIDRef_ != null)
                {
                    optionSeller_ = IDManager.getID(optionSellerIDRef_) as PartyReference;
                    return this.optionSeller_; 
                }
                else
                {
                      return this.optionSeller_; 
                }
            }
            set
            {
                if (this.optionSeller_ != value)
                {
                    this.optionSeller_ = value;
                }
            }
        }
        #endregion
        
        public string optionSellerIDRef_ { get; set; }
        #region OptionBuyer_
        private PartyReference optionBuyer_;
        public PartyReference OptionBuyer_
        {
            get
            {
                if (this.optionBuyer_ != null)
                {
                    return this.optionBuyer_; 
                }
                else if (this.optionBuyerIDRef_ != null)
                {
                    optionBuyer_ = IDManager.getID(optionBuyerIDRef_) as PartyReference;
                    return this.optionBuyer_; 
                }
                else
                {
                      return this.optionBuyer_; 
                }
            }
            set
            {
                if (this.optionBuyer_ != value)
                {
                    this.optionBuyer_ = value;
                }
            }
        }
        #endregion
        
        public string optionBuyerIDRef_ { get; set; }
        #region OriginalTrade_
        private Trade originalTrade_;
        public Trade OriginalTrade_
        {
            get
            {
                if (this.originalTrade_ != null)
                {
                    return this.originalTrade_; 
                }
                else if (this.originalTradeIDRef_ != null)
                {
                    originalTrade_ = IDManager.getID(originalTradeIDRef_) as Trade;
                    return this.originalTrade_; 
                }
                else
                {
                      return this.originalTrade_; 
                }
            }
            set
            {
                if (this.originalTrade_ != value)
                {
                    this.originalTrade_ = value;
                }
            }
        }
        #endregion
        
        public string originalTradeIDRef_ { get; set; }
        #region TradeIdentifier_
        private List<PartyTradeIdentifier> tradeIdentifier_;
        public List<PartyTradeIdentifier> TradeIdentifier_
        {
            get
            {
                if (this.tradeIdentifier_ != null)
                {
                    return this.tradeIdentifier_; 
                }
                else if (this.tradeIdentifierIDRef_ != null)
                {
                    return this.tradeIdentifier_; 
                }
                else
                {
                      return this.tradeIdentifier_; 
                }
            }
            set
            {
                if (this.tradeIdentifier_ != value)
                {
                    this.tradeIdentifier_ = value;
                }
            }
        }
        #endregion
        
        public string tradeIdentifierIDRef_ { get; set; }
        #region ExerciseDate_
        private XsdTypeDate exerciseDate_;
        public XsdTypeDate ExerciseDate_
        {
            get
            {
                if (this.exerciseDate_ != null)
                {
                    return this.exerciseDate_; 
                }
                else if (this.exerciseDateIDRef_ != null)
                {
                    exerciseDate_ = IDManager.getID(exerciseDateIDRef_) as XsdTypeDate;
                    return this.exerciseDate_; 
                }
                else
                {
                      return this.exerciseDate_; 
                }
            }
            set
            {
                if (this.exerciseDate_ != value)
                {
                    this.exerciseDate_ = value;
                }
            }
        }
        #endregion
        
        public string exerciseDateIDRef_ { get; set; }
        #region ExerciseTime_
        private XsdTypeTime exerciseTime_;
        public XsdTypeTime ExerciseTime_
        {
            get
            {
                if (this.exerciseTime_ != null)
                {
                    return this.exerciseTime_; 
                }
                else if (this.exerciseTimeIDRef_ != null)
                {
                    exerciseTime_ = IDManager.getID(exerciseTimeIDRef_) as XsdTypeTime;
                    return this.exerciseTime_; 
                }
                else
                {
                      return this.exerciseTime_; 
                }
            }
            set
            {
                if (this.exerciseTime_ != value)
                {
                    this.exerciseTime_ = value;
                }
            }
        }
        #endregion
        
        public string exerciseTimeIDRef_ { get; set; }
        #region Expiry_
        private XsdTypeBoolean expiry_;
        public XsdTypeBoolean Expiry_
        {
            get
            {
                if (this.expiry_ != null)
                {
                    return this.expiry_; 
                }
                else if (this.expiryIDRef_ != null)
                {
                    expiry_ = IDManager.getID(expiryIDRef_) as XsdTypeBoolean;
                    return this.expiry_; 
                }
                else
                {
                      return this.expiry_; 
                }
            }
            set
            {
                if (this.expiry_ != value)
                {
                    this.expiry_ = value;
                }
            }
        }
        #endregion
        
        public string expiryIDRef_ { get; set; }
        #region FullExercise_
        private XsdTypeBoolean fullExercise_;
        public XsdTypeBoolean FullExercise_
        {
            get
            {
                if (this.fullExercise_ != null)
                {
                    return this.fullExercise_; 
                }
                else if (this.fullExerciseIDRef_ != null)
                {
                    fullExercise_ = IDManager.getID(fullExerciseIDRef_) as XsdTypeBoolean;
                    return this.fullExercise_; 
                }
                else
                {
                      return this.fullExercise_; 
                }
            }
            set
            {
                if (this.fullExercise_ != value)
                {
                    this.fullExercise_ = value;
                }
            }
        }
        #endregion
        
        public string fullExerciseIDRef_ { get; set; }
        #region ExerciseInNotionalAmount_
        private Money exerciseInNotionalAmount_;
        public Money ExerciseInNotionalAmount_
        {
            get
            {
                if (this.exerciseInNotionalAmount_ != null)
                {
                    return this.exerciseInNotionalAmount_; 
                }
                else if (this.exerciseInNotionalAmountIDRef_ != null)
                {
                    exerciseInNotionalAmount_ = IDManager.getID(exerciseInNotionalAmountIDRef_) as Money;
                    return this.exerciseInNotionalAmount_; 
                }
                else
                {
                      return this.exerciseInNotionalAmount_; 
                }
            }
            set
            {
                if (this.exerciseInNotionalAmount_ != value)
                {
                    this.exerciseInNotionalAmount_ = value;
                }
            }
        }
        #endregion
        
        public string exerciseInNotionalAmountIDRef_ { get; set; }
        #region OutstandingNotionalAmount_
        private Money outstandingNotionalAmount_;
        public Money OutstandingNotionalAmount_
        {
            get
            {
                if (this.outstandingNotionalAmount_ != null)
                {
                    return this.outstandingNotionalAmount_; 
                }
                else if (this.outstandingNotionalAmountIDRef_ != null)
                {
                    outstandingNotionalAmount_ = IDManager.getID(outstandingNotionalAmountIDRef_) as Money;
                    return this.outstandingNotionalAmount_; 
                }
                else
                {
                      return this.outstandingNotionalAmount_; 
                }
            }
            set
            {
                if (this.outstandingNotionalAmount_ != value)
                {
                    this.outstandingNotionalAmount_ = value;
                }
            }
        }
        #endregion
        
        public string outstandingNotionalAmountIDRef_ { get; set; }
        #region ExerciseInNumberOfOptions_
        private XsdTypeDecimal exerciseInNumberOfOptions_;
        public XsdTypeDecimal ExerciseInNumberOfOptions_
        {
            get
            {
                if (this.exerciseInNumberOfOptions_ != null)
                {
                    return this.exerciseInNumberOfOptions_; 
                }
                else if (this.exerciseInNumberOfOptionsIDRef_ != null)
                {
                    exerciseInNumberOfOptions_ = IDManager.getID(exerciseInNumberOfOptionsIDRef_) as XsdTypeDecimal;
                    return this.exerciseInNumberOfOptions_; 
                }
                else
                {
                      return this.exerciseInNumberOfOptions_; 
                }
            }
            set
            {
                if (this.exerciseInNumberOfOptions_ != value)
                {
                    this.exerciseInNumberOfOptions_ = value;
                }
            }
        }
        #endregion
        
        public string exerciseInNumberOfOptionsIDRef_ { get; set; }
        #region OutstandingNumberOfOptions_
        private XsdTypeDecimal outstandingNumberOfOptions_;
        public XsdTypeDecimal OutstandingNumberOfOptions_
        {
            get
            {
                if (this.outstandingNumberOfOptions_ != null)
                {
                    return this.outstandingNumberOfOptions_; 
                }
                else if (this.outstandingNumberOfOptionsIDRef_ != null)
                {
                    outstandingNumberOfOptions_ = IDManager.getID(outstandingNumberOfOptionsIDRef_) as XsdTypeDecimal;
                    return this.outstandingNumberOfOptions_; 
                }
                else
                {
                      return this.outstandingNumberOfOptions_; 
                }
            }
            set
            {
                if (this.outstandingNumberOfOptions_ != value)
                {
                    this.outstandingNumberOfOptions_ = value;
                }
            }
        }
        #endregion
        
        public string outstandingNumberOfOptionsIDRef_ { get; set; }
        #region ExerciseInNumberOfUnits_
        private XsdTypeDecimal exerciseInNumberOfUnits_;
        public XsdTypeDecimal ExerciseInNumberOfUnits_
        {
            get
            {
                if (this.exerciseInNumberOfUnits_ != null)
                {
                    return this.exerciseInNumberOfUnits_; 
                }
                else if (this.exerciseInNumberOfUnitsIDRef_ != null)
                {
                    exerciseInNumberOfUnits_ = IDManager.getID(exerciseInNumberOfUnitsIDRef_) as XsdTypeDecimal;
                    return this.exerciseInNumberOfUnits_; 
                }
                else
                {
                      return this.exerciseInNumberOfUnits_; 
                }
            }
            set
            {
                if (this.exerciseInNumberOfUnits_ != value)
                {
                    this.exerciseInNumberOfUnits_ = value;
                }
            }
        }
        #endregion
        
        public string exerciseInNumberOfUnitsIDRef_ { get; set; }
        #region OutstandingNumberOfUnits_
        private XsdTypeDecimal outstandingNumberOfUnits_;
        public XsdTypeDecimal OutstandingNumberOfUnits_
        {
            get
            {
                if (this.outstandingNumberOfUnits_ != null)
                {
                    return this.outstandingNumberOfUnits_; 
                }
                else if (this.outstandingNumberOfUnitsIDRef_ != null)
                {
                    outstandingNumberOfUnits_ = IDManager.getID(outstandingNumberOfUnitsIDRef_) as XsdTypeDecimal;
                    return this.outstandingNumberOfUnits_; 
                }
                else
                {
                      return this.outstandingNumberOfUnits_; 
                }
            }
            set
            {
                if (this.outstandingNumberOfUnits_ != value)
                {
                    this.outstandingNumberOfUnits_ = value;
                }
            }
        }
        #endregion
        
        public string outstandingNumberOfUnitsIDRef_ { get; set; }
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
        #region CashSettlement_
        private SimplePayment cashSettlement_;
        public SimplePayment CashSettlement_
        {
            get
            {
                if (this.cashSettlement_ != null)
                {
                    return this.cashSettlement_; 
                }
                else if (this.cashSettlementIDRef_ != null)
                {
                    cashSettlement_ = IDManager.getID(cashSettlementIDRef_) as SimplePayment;
                    return this.cashSettlement_; 
                }
                else
                {
                      return this.cashSettlement_; 
                }
            }
            set
            {
                if (this.cashSettlement_ != value)
                {
                    this.cashSettlement_ = value;
                }
            }
        }
        #endregion
        
        public string cashSettlementIDRef_ { get; set; }
        #region PhysicalSettlement_
        private PhysicalSettlement physicalSettlement_;
        public PhysicalSettlement PhysicalSettlement_
        {
            get
            {
                if (this.physicalSettlement_ != null)
                {
                    return this.physicalSettlement_; 
                }
                else if (this.physicalSettlementIDRef_ != null)
                {
                    physicalSettlement_ = IDManager.getID(physicalSettlementIDRef_) as PhysicalSettlement;
                    return this.physicalSettlement_; 
                }
                else
                {
                      return this.physicalSettlement_; 
                }
            }
            set
            {
                if (this.physicalSettlement_ != value)
                {
                    this.physicalSettlement_ = value;
                }
            }
        }
        #endregion
        
        public string physicalSettlementIDRef_ { get; set; }
        #region Payment_
        private NonNegativePayment payment_;
        public NonNegativePayment Payment_
        {
            get
            {
                if (this.payment_ != null)
                {
                    return this.payment_; 
                }
                else if (this.paymentIDRef_ != null)
                {
                    payment_ = IDManager.getID(paymentIDRef_) as NonNegativePayment;
                    return this.payment_; 
                }
                else
                {
                      return this.payment_; 
                }
            }
            set
            {
                if (this.payment_ != value)
                {
                    this.payment_ = value;
                }
            }
        }
        #endregion
        
        public string paymentIDRef_ { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        public string choiceStr_2;
        
    
        
    
    }
    
}

