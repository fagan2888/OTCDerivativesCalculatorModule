using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CommodityExercise : ISerialized
    {
        public CommodityExercise(XmlNode xmlNode)
        {
            XmlNode americanExerciseNode = xmlNode.SelectSingleNode("americanExercise");
            
            if (americanExerciseNode != null)
            {
                if (americanExerciseNode.Attributes["href"] != null || americanExerciseNode.Attributes["id"] != null) 
                {
                    if (americanExerciseNode.Attributes["id"] != null) 
                    {
                        americanExerciseIDRef_ = americanExerciseNode.Attributes["id"].Value;
                        CommodityAmericanExercise ob = new CommodityAmericanExercise(americanExerciseNode);
                        IDManager.SetID(americanExerciseIDRef_, ob);
                    }
                    else if (americanExerciseNode.Attributes["href"] != null)
                    {
                        americanExerciseIDRef_ = americanExerciseNode.Attributes["href"].Value;
                    }
                    else
                    {
                        americanExercise_ = new CommodityAmericanExercise(americanExerciseNode);
                    }
                }
                else
                {
                    americanExercise_ = new CommodityAmericanExercise(americanExerciseNode);
                }
            }
            
        
            XmlNode europeanExerciseNode = xmlNode.SelectSingleNode("europeanExercise");
            
            if (europeanExerciseNode != null)
            {
                if (europeanExerciseNode.Attributes["href"] != null || europeanExerciseNode.Attributes["id"] != null) 
                {
                    if (europeanExerciseNode.Attributes["id"] != null) 
                    {
                        europeanExerciseIDRef_ = europeanExerciseNode.Attributes["id"].Value;
                        CommodityEuropeanExercise ob = new CommodityEuropeanExercise(europeanExerciseNode);
                        IDManager.SetID(europeanExerciseIDRef_, ob);
                    }
                    else if (europeanExerciseNode.Attributes["href"] != null)
                    {
                        europeanExerciseIDRef_ = europeanExerciseNode.Attributes["href"].Value;
                    }
                    else
                    {
                        europeanExercise_ = new CommodityEuropeanExercise(europeanExerciseNode);
                    }
                }
                else
                {
                    europeanExercise_ = new CommodityEuropeanExercise(europeanExerciseNode);
                }
            }
            
        
            XmlNode automaticExerciseNode = xmlNode.SelectSingleNode("automaticExercise");
            
            if (automaticExerciseNode != null)
            {
                if (automaticExerciseNode.Attributes["href"] != null || automaticExerciseNode.Attributes["id"] != null) 
                {
                    if (automaticExerciseNode.Attributes["id"] != null) 
                    {
                        automaticExerciseIDRef_ = automaticExerciseNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(automaticExerciseNode);
                        IDManager.SetID(automaticExerciseIDRef_, ob);
                    }
                    else if (automaticExerciseNode.Attributes["href"] != null)
                    {
                        automaticExerciseIDRef_ = automaticExerciseNode.Attributes["href"].Value;
                    }
                    else
                    {
                        automaticExercise_ = new XsdTypeBoolean(automaticExerciseNode);
                    }
                }
                else
                {
                    automaticExercise_ = new XsdTypeBoolean(automaticExerciseNode);
                }
            }
            
        
            XmlNode writtenConfirmationNode = xmlNode.SelectSingleNode("writtenConfirmation");
            
            if (writtenConfirmationNode != null)
            {
                if (writtenConfirmationNode.Attributes["href"] != null || writtenConfirmationNode.Attributes["id"] != null) 
                {
                    if (writtenConfirmationNode.Attributes["id"] != null) 
                    {
                        writtenConfirmationIDRef_ = writtenConfirmationNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(writtenConfirmationNode);
                        IDManager.SetID(writtenConfirmationIDRef_, ob);
                    }
                    else if (writtenConfirmationNode.Attributes["href"] != null)
                    {
                        writtenConfirmationIDRef_ = writtenConfirmationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        writtenConfirmation_ = new XsdTypeBoolean(writtenConfirmationNode);
                    }
                }
                else
                {
                    writtenConfirmation_ = new XsdTypeBoolean(writtenConfirmationNode);
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
                        IdentifiedCurrency ob = new IdentifiedCurrency(settlementCurrencyNode);
                        IDManager.SetID(settlementCurrencyIDRef_, ob);
                    }
                    else if (settlementCurrencyNode.Attributes["href"] != null)
                    {
                        settlementCurrencyIDRef_ = settlementCurrencyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        settlementCurrency_ = new IdentifiedCurrency(settlementCurrencyNode);
                    }
                }
                else
                {
                    settlementCurrency_ = new IdentifiedCurrency(settlementCurrencyNode);
                }
            }
            
        
            XmlNode fxNode = xmlNode.SelectSingleNode("fx");
            
            if (fxNode != null)
            {
                if (fxNode.Attributes["href"] != null || fxNode.Attributes["id"] != null) 
                {
                    if (fxNode.Attributes["id"] != null) 
                    {
                        fxIDRef_ = fxNode.Attributes["id"].Value;
                        CommodityFx ob = new CommodityFx(fxNode);
                        IDManager.SetID(fxIDRef_, ob);
                    }
                    else if (fxNode.Attributes["href"] != null)
                    {
                        fxIDRef_ = fxNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fx_ = new CommodityFx(fxNode);
                    }
                }
                else
                {
                    fx_ = new CommodityFx(fxNode);
                }
            }
            
        
            XmlNode conversionFactorNode = xmlNode.SelectSingleNode("conversionFactor");
            
            if (conversionFactorNode != null)
            {
                if (conversionFactorNode.Attributes["href"] != null || conversionFactorNode.Attributes["id"] != null) 
                {
                    if (conversionFactorNode.Attributes["id"] != null) 
                    {
                        conversionFactorIDRef_ = conversionFactorNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(conversionFactorNode);
                        IDManager.SetID(conversionFactorIDRef_, ob);
                    }
                    else if (conversionFactorNode.Attributes["href"] != null)
                    {
                        conversionFactorIDRef_ = conversionFactorNode.Attributes["href"].Value;
                    }
                    else
                    {
                        conversionFactor_ = new XsdTypeDecimal(conversionFactorNode);
                    }
                }
                else
                {
                    conversionFactor_ = new XsdTypeDecimal(conversionFactorNode);
                }
            }
            
        
            XmlNode relativePaymentDatesNode = xmlNode.SelectSingleNode("relativePaymentDates");
            
            if (relativePaymentDatesNode != null)
            {
                if (relativePaymentDatesNode.Attributes["href"] != null || relativePaymentDatesNode.Attributes["id"] != null) 
                {
                    if (relativePaymentDatesNode.Attributes["id"] != null) 
                    {
                        relativePaymentDatesIDRef_ = relativePaymentDatesNode.Attributes["id"].Value;
                        CommodityRelativePaymentDates ob = new CommodityRelativePaymentDates(relativePaymentDatesNode);
                        IDManager.SetID(relativePaymentDatesIDRef_, ob);
                    }
                    else if (relativePaymentDatesNode.Attributes["href"] != null)
                    {
                        relativePaymentDatesIDRef_ = relativePaymentDatesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        relativePaymentDates_ = new CommodityRelativePaymentDates(relativePaymentDatesNode);
                    }
                }
                else
                {
                    relativePaymentDates_ = new CommodityRelativePaymentDates(relativePaymentDatesNode);
                }
            }
            
        
            XmlNode paymentDatesNode = xmlNode.SelectSingleNode("paymentDates");
            
            if (paymentDatesNode != null)
            {
                if (paymentDatesNode.Attributes["href"] != null || paymentDatesNode.Attributes["id"] != null) 
                {
                    if (paymentDatesNode.Attributes["id"] != null) 
                    {
                        paymentDatesIDRef_ = paymentDatesNode.Attributes["id"].Value;
                        AdjustableDatesOrRelativeDateOffset ob = new AdjustableDatesOrRelativeDateOffset(paymentDatesNode);
                        IDManager.SetID(paymentDatesIDRef_, ob);
                    }
                    else if (paymentDatesNode.Attributes["href"] != null)
                    {
                        paymentDatesIDRef_ = paymentDatesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        paymentDates_ = new AdjustableDatesOrRelativeDateOffset(paymentDatesNode);
                    }
                }
                else
                {
                    paymentDates_ = new AdjustableDatesOrRelativeDateOffset(paymentDatesNode);
                }
            }
            
        
            XmlNode masterAgreementPaymentDatesNode = xmlNode.SelectSingleNode("masterAgreementPaymentDates");
            
            if (masterAgreementPaymentDatesNode != null)
            {
                if (masterAgreementPaymentDatesNode.Attributes["href"] != null || masterAgreementPaymentDatesNode.Attributes["id"] != null) 
                {
                    if (masterAgreementPaymentDatesNode.Attributes["id"] != null) 
                    {
                        masterAgreementPaymentDatesIDRef_ = masterAgreementPaymentDatesNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(masterAgreementPaymentDatesNode);
                        IDManager.SetID(masterAgreementPaymentDatesIDRef_, ob);
                    }
                    else if (masterAgreementPaymentDatesNode.Attributes["href"] != null)
                    {
                        masterAgreementPaymentDatesIDRef_ = masterAgreementPaymentDatesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        masterAgreementPaymentDates_ = new XsdTypeBoolean(masterAgreementPaymentDatesNode);
                    }
                }
                else
                {
                    masterAgreementPaymentDates_ = new XsdTypeBoolean(masterAgreementPaymentDatesNode);
                }
            }
            
        
        }
        
    
        #region AmericanExercise_
        private CommodityAmericanExercise americanExercise_;
        public CommodityAmericanExercise AmericanExercise_
        {
            get
            {
                if (this.americanExercise_ != null)
                {
                    return this.americanExercise_; 
                }
                else if (this.americanExerciseIDRef_ != null)
                {
                    americanExercise_ = IDManager.getID(americanExerciseIDRef_) as CommodityAmericanExercise;
                    return this.americanExercise_; 
                }
                else
                {
                      return this.americanExercise_; 
                }
            }
            set
            {
                if (this.americanExercise_ != value)
                {
                    this.americanExercise_ = value;
                }
            }
        }
        #endregion
        
        public string americanExerciseIDRef_ { get; set; }
        #region EuropeanExercise_
        private CommodityEuropeanExercise europeanExercise_;
        public CommodityEuropeanExercise EuropeanExercise_
        {
            get
            {
                if (this.europeanExercise_ != null)
                {
                    return this.europeanExercise_; 
                }
                else if (this.europeanExerciseIDRef_ != null)
                {
                    europeanExercise_ = IDManager.getID(europeanExerciseIDRef_) as CommodityEuropeanExercise;
                    return this.europeanExercise_; 
                }
                else
                {
                      return this.europeanExercise_; 
                }
            }
            set
            {
                if (this.europeanExercise_ != value)
                {
                    this.europeanExercise_ = value;
                }
            }
        }
        #endregion
        
        public string europeanExerciseIDRef_ { get; set; }
        #region AutomaticExercise_
        private XsdTypeBoolean automaticExercise_;
        public XsdTypeBoolean AutomaticExercise_
        {
            get
            {
                if (this.automaticExercise_ != null)
                {
                    return this.automaticExercise_; 
                }
                else if (this.automaticExerciseIDRef_ != null)
                {
                    automaticExercise_ = IDManager.getID(automaticExerciseIDRef_) as XsdTypeBoolean;
                    return this.automaticExercise_; 
                }
                else
                {
                      return this.automaticExercise_; 
                }
            }
            set
            {
                if (this.automaticExercise_ != value)
                {
                    this.automaticExercise_ = value;
                }
            }
        }
        #endregion
        
        public string automaticExerciseIDRef_ { get; set; }
        #region WrittenConfirmation_
        private XsdTypeBoolean writtenConfirmation_;
        public XsdTypeBoolean WrittenConfirmation_
        {
            get
            {
                if (this.writtenConfirmation_ != null)
                {
                    return this.writtenConfirmation_; 
                }
                else if (this.writtenConfirmationIDRef_ != null)
                {
                    writtenConfirmation_ = IDManager.getID(writtenConfirmationIDRef_) as XsdTypeBoolean;
                    return this.writtenConfirmation_; 
                }
                else
                {
                      return this.writtenConfirmation_; 
                }
            }
            set
            {
                if (this.writtenConfirmation_ != value)
                {
                    this.writtenConfirmation_ = value;
                }
            }
        }
        #endregion
        
        public string writtenConfirmationIDRef_ { get; set; }
        #region SettlementCurrency_
        private IdentifiedCurrency settlementCurrency_;
        public IdentifiedCurrency SettlementCurrency_
        {
            get
            {
                if (this.settlementCurrency_ != null)
                {
                    return this.settlementCurrency_; 
                }
                else if (this.settlementCurrencyIDRef_ != null)
                {
                    settlementCurrency_ = IDManager.getID(settlementCurrencyIDRef_) as IdentifiedCurrency;
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
        #region Fx_
        private CommodityFx fx_;
        public CommodityFx Fx_
        {
            get
            {
                if (this.fx_ != null)
                {
                    return this.fx_; 
                }
                else if (this.fxIDRef_ != null)
                {
                    fx_ = IDManager.getID(fxIDRef_) as CommodityFx;
                    return this.fx_; 
                }
                else
                {
                      return this.fx_; 
                }
            }
            set
            {
                if (this.fx_ != value)
                {
                    this.fx_ = value;
                }
            }
        }
        #endregion
        
        public string fxIDRef_ { get; set; }
        #region ConversionFactor_
        private XsdTypeDecimal conversionFactor_;
        public XsdTypeDecimal ConversionFactor_
        {
            get
            {
                if (this.conversionFactor_ != null)
                {
                    return this.conversionFactor_; 
                }
                else if (this.conversionFactorIDRef_ != null)
                {
                    conversionFactor_ = IDManager.getID(conversionFactorIDRef_) as XsdTypeDecimal;
                    return this.conversionFactor_; 
                }
                else
                {
                      return this.conversionFactor_; 
                }
            }
            set
            {
                if (this.conversionFactor_ != value)
                {
                    this.conversionFactor_ = value;
                }
            }
        }
        #endregion
        
        public string conversionFactorIDRef_ { get; set; }
        #region RelativePaymentDates_
        private CommodityRelativePaymentDates relativePaymentDates_;
        public CommodityRelativePaymentDates RelativePaymentDates_
        {
            get
            {
                if (this.relativePaymentDates_ != null)
                {
                    return this.relativePaymentDates_; 
                }
                else if (this.relativePaymentDatesIDRef_ != null)
                {
                    relativePaymentDates_ = IDManager.getID(relativePaymentDatesIDRef_) as CommodityRelativePaymentDates;
                    return this.relativePaymentDates_; 
                }
                else
                {
                      return this.relativePaymentDates_; 
                }
            }
            set
            {
                if (this.relativePaymentDates_ != value)
                {
                    this.relativePaymentDates_ = value;
                }
            }
        }
        #endregion
        
        public string relativePaymentDatesIDRef_ { get; set; }
        #region PaymentDates_
        private AdjustableDatesOrRelativeDateOffset paymentDates_;
        public AdjustableDatesOrRelativeDateOffset PaymentDates_
        {
            get
            {
                if (this.paymentDates_ != null)
                {
                    return this.paymentDates_; 
                }
                else if (this.paymentDatesIDRef_ != null)
                {
                    paymentDates_ = IDManager.getID(paymentDatesIDRef_) as AdjustableDatesOrRelativeDateOffset;
                    return this.paymentDates_; 
                }
                else
                {
                      return this.paymentDates_; 
                }
            }
            set
            {
                if (this.paymentDates_ != value)
                {
                    this.paymentDates_ = value;
                }
            }
        }
        #endregion
        
        public string paymentDatesIDRef_ { get; set; }
        #region MasterAgreementPaymentDates_
        private XsdTypeBoolean masterAgreementPaymentDates_;
        public XsdTypeBoolean MasterAgreementPaymentDates_
        {
            get
            {
                if (this.masterAgreementPaymentDates_ != null)
                {
                    return this.masterAgreementPaymentDates_; 
                }
                else if (this.masterAgreementPaymentDatesIDRef_ != null)
                {
                    masterAgreementPaymentDates_ = IDManager.getID(masterAgreementPaymentDatesIDRef_) as XsdTypeBoolean;
                    return this.masterAgreementPaymentDates_; 
                }
                else
                {
                      return this.masterAgreementPaymentDates_; 
                }
            }
            set
            {
                if (this.masterAgreementPaymentDates_ != value)
                {
                    this.masterAgreementPaymentDates_ = value;
                }
            }
        }
        #endregion
        
        public string masterAgreementPaymentDatesIDRef_ { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        public string choiceStr_2;
        
    
        
    
    }
    
}

