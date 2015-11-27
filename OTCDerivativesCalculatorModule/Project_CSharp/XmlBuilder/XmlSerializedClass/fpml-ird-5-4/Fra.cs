using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Fra : Product
    {
        public Fra(XmlNode xmlNode)
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
            
        
            XmlNode adjustedEffectiveDateNode = xmlNode.SelectSingleNode("adjustedEffectiveDate");
            
            if (adjustedEffectiveDateNode != null)
            {
                if (adjustedEffectiveDateNode.Attributes["href"] != null || adjustedEffectiveDateNode.Attributes["id"] != null) 
                {
                    if (adjustedEffectiveDateNode.Attributes["id"] != null) 
                    {
                        adjustedEffectiveDateIDRef_ = adjustedEffectiveDateNode.Attributes["id"].Value;
                        RequiredIdentifierDate ob = new RequiredIdentifierDate(adjustedEffectiveDateNode);
                        IDManager.SetID(adjustedEffectiveDateIDRef_, ob);
                    }
                    else if (adjustedEffectiveDateNode.Attributes["href"] != null)
                    {
                        adjustedEffectiveDateIDRef_ = adjustedEffectiveDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        adjustedEffectiveDate_ = new RequiredIdentifierDate(adjustedEffectiveDateNode);
                    }
                }
                else
                {
                    adjustedEffectiveDate_ = new RequiredIdentifierDate(adjustedEffectiveDateNode);
                }
            }
            
        
            XmlNode adjustedTerminationDateNode = xmlNode.SelectSingleNode("adjustedTerminationDate");
            
            if (adjustedTerminationDateNode != null)
            {
                if (adjustedTerminationDateNode.Attributes["href"] != null || adjustedTerminationDateNode.Attributes["id"] != null) 
                {
                    if (adjustedTerminationDateNode.Attributes["id"] != null) 
                    {
                        adjustedTerminationDateIDRef_ = adjustedTerminationDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(adjustedTerminationDateNode);
                        IDManager.SetID(adjustedTerminationDateIDRef_, ob);
                    }
                    else if (adjustedTerminationDateNode.Attributes["href"] != null)
                    {
                        adjustedTerminationDateIDRef_ = adjustedTerminationDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        adjustedTerminationDate_ = new XsdTypeDate(adjustedTerminationDateNode);
                    }
                }
                else
                {
                    adjustedTerminationDate_ = new XsdTypeDate(adjustedTerminationDateNode);
                }
            }
            
        
            XmlNode paymentDateNode = xmlNode.SelectSingleNode("paymentDate");
            
            if (paymentDateNode != null)
            {
                if (paymentDateNode.Attributes["href"] != null || paymentDateNode.Attributes["id"] != null) 
                {
                    if (paymentDateNode.Attributes["id"] != null) 
                    {
                        paymentDateIDRef_ = paymentDateNode.Attributes["id"].Value;
                        AdjustableDate ob = new AdjustableDate(paymentDateNode);
                        IDManager.SetID(paymentDateIDRef_, ob);
                    }
                    else if (paymentDateNode.Attributes["href"] != null)
                    {
                        paymentDateIDRef_ = paymentDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        paymentDate_ = new AdjustableDate(paymentDateNode);
                    }
                }
                else
                {
                    paymentDate_ = new AdjustableDate(paymentDateNode);
                }
            }
            
        
            XmlNode fixingDateOffsetNode = xmlNode.SelectSingleNode("fixingDateOffset");
            
            if (fixingDateOffsetNode != null)
            {
                if (fixingDateOffsetNode.Attributes["href"] != null || fixingDateOffsetNode.Attributes["id"] != null) 
                {
                    if (fixingDateOffsetNode.Attributes["id"] != null) 
                    {
                        fixingDateOffsetIDRef_ = fixingDateOffsetNode.Attributes["id"].Value;
                        RelativeDateOffset ob = new RelativeDateOffset(fixingDateOffsetNode);
                        IDManager.SetID(fixingDateOffsetIDRef_, ob);
                    }
                    else if (fixingDateOffsetNode.Attributes["href"] != null)
                    {
                        fixingDateOffsetIDRef_ = fixingDateOffsetNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fixingDateOffset_ = new RelativeDateOffset(fixingDateOffsetNode);
                    }
                }
                else
                {
                    fixingDateOffset_ = new RelativeDateOffset(fixingDateOffsetNode);
                }
            }
            
        
            XmlNode dayCountFractionNode = xmlNode.SelectSingleNode("dayCountFraction");
            
            if (dayCountFractionNode != null)
            {
                if (dayCountFractionNode.Attributes["href"] != null || dayCountFractionNode.Attributes["id"] != null) 
                {
                    if (dayCountFractionNode.Attributes["id"] != null) 
                    {
                        dayCountFractionIDRef_ = dayCountFractionNode.Attributes["id"].Value;
                        DayCountFraction ob = new DayCountFraction(dayCountFractionNode);
                        IDManager.SetID(dayCountFractionIDRef_, ob);
                    }
                    else if (dayCountFractionNode.Attributes["href"] != null)
                    {
                        dayCountFractionIDRef_ = dayCountFractionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dayCountFraction_ = new DayCountFraction(dayCountFractionNode);
                    }
                }
                else
                {
                    dayCountFraction_ = new DayCountFraction(dayCountFractionNode);
                }
            }
            
        
            XmlNode calculationPeriodNumberOfDaysNode = xmlNode.SelectSingleNode("calculationPeriodNumberOfDays");
            
            if (calculationPeriodNumberOfDaysNode != null)
            {
                if (calculationPeriodNumberOfDaysNode.Attributes["href"] != null || calculationPeriodNumberOfDaysNode.Attributes["id"] != null) 
                {
                    if (calculationPeriodNumberOfDaysNode.Attributes["id"] != null) 
                    {
                        calculationPeriodNumberOfDaysIDRef_ = calculationPeriodNumberOfDaysNode.Attributes["id"].Value;
                        XsdTypePositiveInteger ob = new XsdTypePositiveInteger(calculationPeriodNumberOfDaysNode);
                        IDManager.SetID(calculationPeriodNumberOfDaysIDRef_, ob);
                    }
                    else if (calculationPeriodNumberOfDaysNode.Attributes["href"] != null)
                    {
                        calculationPeriodNumberOfDaysIDRef_ = calculationPeriodNumberOfDaysNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculationPeriodNumberOfDays_ = new XsdTypePositiveInteger(calculationPeriodNumberOfDaysNode);
                    }
                }
                else
                {
                    calculationPeriodNumberOfDays_ = new XsdTypePositiveInteger(calculationPeriodNumberOfDaysNode);
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
                        Money ob = new Money(notionalNode);
                        IDManager.SetID(notionalIDRef_, ob);
                    }
                    else if (notionalNode.Attributes["href"] != null)
                    {
                        notionalIDRef_ = notionalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        notional_ = new Money(notionalNode);
                    }
                }
                else
                {
                    notional_ = new Money(notionalNode);
                }
            }
            
        
            XmlNode fixedRateNode = xmlNode.SelectSingleNode("fixedRate");
            
            if (fixedRateNode != null)
            {
                if (fixedRateNode.Attributes["href"] != null || fixedRateNode.Attributes["id"] != null) 
                {
                    if (fixedRateNode.Attributes["id"] != null) 
                    {
                        fixedRateIDRef_ = fixedRateNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(fixedRateNode);
                        IDManager.SetID(fixedRateIDRef_, ob);
                    }
                    else if (fixedRateNode.Attributes["href"] != null)
                    {
                        fixedRateIDRef_ = fixedRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fixedRate_ = new XsdTypeDecimal(fixedRateNode);
                    }
                }
                else
                {
                    fixedRate_ = new XsdTypeDecimal(fixedRateNode);
                }
            }
            
        
            XmlNode floatingRateIndexNode = xmlNode.SelectSingleNode("floatingRateIndex");
            
            if (floatingRateIndexNode != null)
            {
                if (floatingRateIndexNode.Attributes["href"] != null || floatingRateIndexNode.Attributes["id"] != null) 
                {
                    if (floatingRateIndexNode.Attributes["id"] != null) 
                    {
                        floatingRateIndexIDRef_ = floatingRateIndexNode.Attributes["id"].Value;
                        FloatingRateIndex ob = new FloatingRateIndex(floatingRateIndexNode);
                        IDManager.SetID(floatingRateIndexIDRef_, ob);
                    }
                    else if (floatingRateIndexNode.Attributes["href"] != null)
                    {
                        floatingRateIndexIDRef_ = floatingRateIndexNode.Attributes["href"].Value;
                    }
                    else
                    {
                        floatingRateIndex_ = new FloatingRateIndex(floatingRateIndexNode);
                    }
                }
                else
                {
                    floatingRateIndex_ = new FloatingRateIndex(floatingRateIndexNode);
                }
            }
            
        
            XmlNodeList indexTenorNodeList = xmlNode.SelectNodes("indexTenor");
            
            if (indexTenorNodeList != null)
            {
                this.indexTenor_ = new List<Period>();
                foreach (XmlNode item in indexTenorNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            indexTenorIDRef_ = item.Attributes["id"].Value;
                            indexTenor_.Add(new Period(item));
                            IDManager.SetID(indexTenorIDRef_, indexTenor_[indexTenor_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            indexTenorIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        indexTenor_.Add(new Period(item));
                        }
                    }
                    else
                    {
                        indexTenor_.Add(new Period(item));
                    }
                }
            }
            
        
            XmlNode fraDiscountingNode = xmlNode.SelectSingleNode("fraDiscounting");
            
            if (fraDiscountingNode != null)
            {
                if (fraDiscountingNode.Attributes["href"] != null || fraDiscountingNode.Attributes["id"] != null) 
                {
                    if (fraDiscountingNode.Attributes["id"] != null) 
                    {
                        fraDiscountingIDRef_ = fraDiscountingNode.Attributes["id"].Value;
                        FraDiscountingEnum ob = new FraDiscountingEnum(fraDiscountingNode);
                        IDManager.SetID(fraDiscountingIDRef_, ob);
                    }
                    else if (fraDiscountingNode.Attributes["href"] != null)
                    {
                        fraDiscountingIDRef_ = fraDiscountingNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fraDiscounting_ = new FraDiscountingEnum(fraDiscountingNode);
                    }
                }
                else
                {
                    fraDiscounting_ = new FraDiscountingEnum(fraDiscountingNode);
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
        #region AdjustedEffectiveDate_
        private RequiredIdentifierDate adjustedEffectiveDate_;
        public RequiredIdentifierDate AdjustedEffectiveDate_
        {
            get
            {
                if (this.adjustedEffectiveDate_ != null)
                {
                    return this.adjustedEffectiveDate_; 
                }
                else if (this.adjustedEffectiveDateIDRef_ != null)
                {
                    adjustedEffectiveDate_ = IDManager.getID(adjustedEffectiveDateIDRef_) as RequiredIdentifierDate;
                    return this.adjustedEffectiveDate_; 
                }
                else
                {
                      return this.adjustedEffectiveDate_; 
                }
            }
            set
            {
                if (this.adjustedEffectiveDate_ != value)
                {
                    this.adjustedEffectiveDate_ = value;
                }
            }
        }
        #endregion
        
        public string adjustedEffectiveDateIDRef_ { get; set; }
        #region AdjustedTerminationDate_
        private XsdTypeDate adjustedTerminationDate_;
        public XsdTypeDate AdjustedTerminationDate_
        {
            get
            {
                if (this.adjustedTerminationDate_ != null)
                {
                    return this.adjustedTerminationDate_; 
                }
                else if (this.adjustedTerminationDateIDRef_ != null)
                {
                    adjustedTerminationDate_ = IDManager.getID(adjustedTerminationDateIDRef_) as XsdTypeDate;
                    return this.adjustedTerminationDate_; 
                }
                else
                {
                      return this.adjustedTerminationDate_; 
                }
            }
            set
            {
                if (this.adjustedTerminationDate_ != value)
                {
                    this.adjustedTerminationDate_ = value;
                }
            }
        }
        #endregion
        
        public string adjustedTerminationDateIDRef_ { get; set; }
        #region PaymentDate_
        private AdjustableDate paymentDate_;
        public AdjustableDate PaymentDate_
        {
            get
            {
                if (this.paymentDate_ != null)
                {
                    return this.paymentDate_; 
                }
                else if (this.paymentDateIDRef_ != null)
                {
                    paymentDate_ = IDManager.getID(paymentDateIDRef_) as AdjustableDate;
                    return this.paymentDate_; 
                }
                else
                {
                      return this.paymentDate_; 
                }
            }
            set
            {
                if (this.paymentDate_ != value)
                {
                    this.paymentDate_ = value;
                }
            }
        }
        #endregion
        
        public string paymentDateIDRef_ { get; set; }
        #region FixingDateOffset_
        private RelativeDateOffset fixingDateOffset_;
        public RelativeDateOffset FixingDateOffset_
        {
            get
            {
                if (this.fixingDateOffset_ != null)
                {
                    return this.fixingDateOffset_; 
                }
                else if (this.fixingDateOffsetIDRef_ != null)
                {
                    fixingDateOffset_ = IDManager.getID(fixingDateOffsetIDRef_) as RelativeDateOffset;
                    return this.fixingDateOffset_; 
                }
                else
                {
                      return this.fixingDateOffset_; 
                }
            }
            set
            {
                if (this.fixingDateOffset_ != value)
                {
                    this.fixingDateOffset_ = value;
                }
            }
        }
        #endregion
        
        public string fixingDateOffsetIDRef_ { get; set; }
        #region DayCountFraction_
        private DayCountFraction dayCountFraction_;
        public DayCountFraction DayCountFraction_
        {
            get
            {
                if (this.dayCountFraction_ != null)
                {
                    return this.dayCountFraction_; 
                }
                else if (this.dayCountFractionIDRef_ != null)
                {
                    dayCountFraction_ = IDManager.getID(dayCountFractionIDRef_) as DayCountFraction;
                    return this.dayCountFraction_; 
                }
                else
                {
                      return this.dayCountFraction_; 
                }
            }
            set
            {
                if (this.dayCountFraction_ != value)
                {
                    this.dayCountFraction_ = value;
                }
            }
        }
        #endregion
        
        public string dayCountFractionIDRef_ { get; set; }
        #region CalculationPeriodNumberOfDays_
        private XsdTypePositiveInteger calculationPeriodNumberOfDays_;
        public XsdTypePositiveInteger CalculationPeriodNumberOfDays_
        {
            get
            {
                if (this.calculationPeriodNumberOfDays_ != null)
                {
                    return this.calculationPeriodNumberOfDays_; 
                }
                else if (this.calculationPeriodNumberOfDaysIDRef_ != null)
                {
                    calculationPeriodNumberOfDays_ = IDManager.getID(calculationPeriodNumberOfDaysIDRef_) as XsdTypePositiveInteger;
                    return this.calculationPeriodNumberOfDays_; 
                }
                else
                {
                      return this.calculationPeriodNumberOfDays_; 
                }
            }
            set
            {
                if (this.calculationPeriodNumberOfDays_ != value)
                {
                    this.calculationPeriodNumberOfDays_ = value;
                }
            }
        }
        #endregion
        
        public string calculationPeriodNumberOfDaysIDRef_ { get; set; }
        #region Notional_
        private Money notional_;
        public Money Notional_
        {
            get
            {
                if (this.notional_ != null)
                {
                    return this.notional_; 
                }
                else if (this.notionalIDRef_ != null)
                {
                    notional_ = IDManager.getID(notionalIDRef_) as Money;
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
        #region FixedRate_
        private XsdTypeDecimal fixedRate_;
        public XsdTypeDecimal FixedRate_
        {
            get
            {
                if (this.fixedRate_ != null)
                {
                    return this.fixedRate_; 
                }
                else if (this.fixedRateIDRef_ != null)
                {
                    fixedRate_ = IDManager.getID(fixedRateIDRef_) as XsdTypeDecimal;
                    return this.fixedRate_; 
                }
                else
                {
                      return this.fixedRate_; 
                }
            }
            set
            {
                if (this.fixedRate_ != value)
                {
                    this.fixedRate_ = value;
                }
            }
        }
        #endregion
        
        public string fixedRateIDRef_ { get; set; }
        #region FloatingRateIndex_
        private FloatingRateIndex floatingRateIndex_;
        public FloatingRateIndex FloatingRateIndex_
        {
            get
            {
                if (this.floatingRateIndex_ != null)
                {
                    return this.floatingRateIndex_; 
                }
                else if (this.floatingRateIndexIDRef_ != null)
                {
                    floatingRateIndex_ = IDManager.getID(floatingRateIndexIDRef_) as FloatingRateIndex;
                    return this.floatingRateIndex_; 
                }
                else
                {
                      return this.floatingRateIndex_; 
                }
            }
            set
            {
                if (this.floatingRateIndex_ != value)
                {
                    this.floatingRateIndex_ = value;
                }
            }
        }
        #endregion
        
        public string floatingRateIndexIDRef_ { get; set; }
        #region IndexTenor_
        private List<Period> indexTenor_;
        public List<Period> IndexTenor_
        {
            get
            {
                if (this.indexTenor_ != null)
                {
                    return this.indexTenor_; 
                }
                else if (this.indexTenorIDRef_ != null)
                {
                    return this.indexTenor_; 
                }
                else
                {
                      return this.indexTenor_; 
                }
            }
            set
            {
                if (this.indexTenor_ != value)
                {
                    this.indexTenor_ = value;
                }
            }
        }
        #endregion
        
        public string indexTenorIDRef_ { get; set; }
        #region FraDiscounting_
        private FraDiscountingEnum fraDiscounting_;
        public FraDiscountingEnum FraDiscounting_
        {
            get
            {
                if (this.fraDiscounting_ != null)
                {
                    return this.fraDiscounting_; 
                }
                else if (this.fraDiscountingIDRef_ != null)
                {
                    fraDiscounting_ = IDManager.getID(fraDiscountingIDRef_) as FraDiscountingEnum;
                    return this.fraDiscounting_; 
                }
                else
                {
                      return this.fraDiscounting_; 
                }
            }
            set
            {
                if (this.fraDiscounting_ != value)
                {
                    this.fraDiscounting_ = value;
                }
            }
        }
        #endregion
        
        public string fraDiscountingIDRef_ { get; set; }
        
    
        
    
    }
    
}

