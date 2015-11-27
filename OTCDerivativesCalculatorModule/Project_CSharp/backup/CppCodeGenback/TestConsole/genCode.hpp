// BondReference.hpp 
#ifndef CppCodeGen_BondReference_hpp
#define CppCodeGen_BondReference_hpp

class BondReference { 
   public: 
       BondReference(TiXmlNode* xmlNode)
       {
              TiXmlElement* conditionPrecedentBondNode = xmlNode->FirstChild("conditionPrecedentBond").ToText();
              conditionPrecedentBond = boost::shared_ptr<boolean>(
                           new boolean(conditionPrecedentBondNode));

              TiXmlElement* discrepancyClauseNode = xmlNode->FirstChild("discrepancyClause").ToText();
              discrepancyClause = boost::shared_ptr<boolean>(
                           new boolean(discrepancyClauseNode));

       }
   protected: 
       boolean conditionPrecedentBond;
       boolean discrepancyClause;
};
#endif

// BulletPayment.hpp 
#ifndef CppCodeGen_BulletPayment_hpp
#define CppCodeGen_BulletPayment_hpp

class BulletPayment : public Product { 
   public: 
       BulletPayment(TiXmlNode* xmlNode)
       {
              TiXmlElement* paymentNode = xmlNode->FirstChild("payment").ToText();
              payment = boost::shared_ptr<Payment>(
                           new Payment(paymentNode));

       }
   protected: 
       boost::shared_ptr<Payment> payment;
};
#endif

// Calculation.hpp 
#ifndef CppCodeGen_Calculation_hpp
#define CppCodeGen_Calculation_hpp

class Calculation { 
   public: 
       Calculation(TiXmlNode* xmlNode)
       {
              TiXmlElement* notionalScheduleNode = xmlNode->FirstChild("notionalSchedule").ToText();
              notionalSchedule = boost::shared_ptr<Notional>(
                           new Notional(notionalScheduleNode));

              TiXmlElement* fxLinkedNotionalScheduleNode = xmlNode->FirstChild("fxLinkedNotionalSchedule").ToText();
              fxLinkedNotionalSchedule = boost::shared_ptr<FxLinkedNotionalSchedule>(
                           new FxLinkedNotionalSchedule(fxLinkedNotionalScheduleNode));

              TiXmlElement* fixedRateScheduleNode = xmlNode->FirstChild("fixedRateSchedule").ToText();
              fixedRateSchedule = boost::shared_ptr<Schedule>(
                           new Schedule(fixedRateScheduleNode));

              TiXmlElement* futureValueNotionalNode = xmlNode->FirstChild("futureValueNotional").ToText();
              futureValueNotional = boost::shared_ptr<FutureValueAmount>(
                           new FutureValueAmount(futureValueNotionalNode));

              TiXmlElement* dayCountFractionNode = xmlNode->FirstChild("dayCountFraction").ToText();
              dayCountFraction = boost::shared_ptr<DayCountFraction>(
                           new DayCountFraction(dayCountFractionNode));

              TiXmlElement* discountingNode = xmlNode->FirstChild("discounting").ToText();
              discounting = boost::shared_ptr<Discounting>(
                           new Discounting(discountingNode));

              TiXmlElement* compoundingMethodNode = xmlNode->FirstChild("compoundingMethod").ToText();
              compoundingMethod = boost::shared_ptr<CompoundingMethodEnum>(
                           new CompoundingMethodEnum(compoundingMethodNode));

       }
   protected: 
       boost::shared_ptr<Notional> notionalSchedule;
       boost::shared_ptr<FxLinkedNotionalSchedule> fxLinkedNotionalSchedule;
       boost::shared_ptr<Schedule> fixedRateSchedule;
       boost::shared_ptr<FutureValueAmount> futureValueNotional;
       boost::shared_ptr<DayCountFraction> dayCountFraction;
       boost::shared_ptr<Discounting> discounting;
       boost::shared_ptr<CompoundingMethodEnum> compoundingMethod;
};
#endif

// CalculationPeriod.hpp 
#ifndef CppCodeGen_CalculationPeriod_hpp
#define CppCodeGen_CalculationPeriod_hpp

class CalculationPeriod { 
   public: 
       CalculationPeriod(TiXmlNode* xmlNode)
       {
              TiXmlElement* unadjustedStartDateNode = xmlNode->FirstChild("unadjustedStartDate").ToText();
              unadjustedStartDate = boost::shared_ptr<date>(
                           new date(unadjustedStartDateNode));

              TiXmlElement* unadjustedEndDateNode = xmlNode->FirstChild("unadjustedEndDate").ToText();
              unadjustedEndDate = boost::shared_ptr<date>(
                           new date(unadjustedEndDateNode));

              TiXmlElement* adjustedStartDateNode = xmlNode->FirstChild("adjustedStartDate").ToText();
              adjustedStartDate = boost::shared_ptr<date>(
                           new date(adjustedStartDateNode));

              TiXmlElement* adjustedEndDateNode = xmlNode->FirstChild("adjustedEndDate").ToText();
              adjustedEndDate = boost::shared_ptr<date>(
                           new date(adjustedEndDateNode));

              TiXmlElement* calculationPeriodNumberOfDaysNode = xmlNode->FirstChild("calculationPeriodNumberOfDays").ToText();
              calculationPeriodNumberOfDays = boost::shared_ptr<positiveInteger>(
                           new positiveInteger(calculationPeriodNumberOfDaysNode));

              TiXmlElement* notionalAmountNode = xmlNode->FirstChild("notionalAmount").ToText();
              notionalAmount = boost::shared_ptr<decimal>(
                           new decimal(notionalAmountNode));

              TiXmlElement* fxLinkedNotionalAmountNode = xmlNode->FirstChild("fxLinkedNotionalAmount").ToText();
              fxLinkedNotionalAmount = boost::shared_ptr<FxLinkedNotionalAmount>(
                           new FxLinkedNotionalAmount(fxLinkedNotionalAmountNode));

              TiXmlElement* floatingRateDefinitionNode = xmlNode->FirstChild("floatingRateDefinition").ToText();
              floatingRateDefinition = boost::shared_ptr<FloatingRateDefinition>(
                           new FloatingRateDefinition(floatingRateDefinitionNode));

              TiXmlElement* fixedRateNode = xmlNode->FirstChild("fixedRate").ToText();
              fixedRate = boost::shared_ptr<decimal>(
                           new decimal(fixedRateNode));

              TiXmlElement* dayCountYearFractionNode = xmlNode->FirstChild("dayCountYearFraction").ToText();
              dayCountYearFraction = boost::shared_ptr<decimal>(
                           new decimal(dayCountYearFractionNode));

              TiXmlElement* forecastAmountNode = xmlNode->FirstChild("forecastAmount").ToText();
              forecastAmount = boost::shared_ptr<Money>(
                           new Money(forecastAmountNode));

              TiXmlElement* forecastRateNode = xmlNode->FirstChild("forecastRate").ToText();
              forecastRate = boost::shared_ptr<decimal>(
                           new decimal(forecastRateNode));

       }
   protected: 
       boost::shared_ptr<date> unadjustedStartDate;
       boost::shared_ptr<date> unadjustedEndDate;
       boost::shared_ptr<date> adjustedStartDate;
       boost::shared_ptr<date> adjustedEndDate;
       boost::shared_ptr<positiveInteger> calculationPeriodNumberOfDays;
       decimal notionalAmount;
       boost::shared_ptr<FxLinkedNotionalAmount> fxLinkedNotionalAmount;
       boost::shared_ptr<FloatingRateDefinition> floatingRateDefinition;
       decimal fixedRate;
       decimal dayCountYearFraction;
       boost::shared_ptr<Money> forecastAmount;
       decimal forecastRate;
};
#endif

// CalculationPeriodAmount.hpp 
#ifndef CppCodeGen_CalculationPeriodAmount_hpp
#define CppCodeGen_CalculationPeriodAmount_hpp

class CalculationPeriodAmount { 
   public: 
       CalculationPeriodAmount(TiXmlNode* xmlNode)
       {
              TiXmlElement* calculationNode = xmlNode->FirstChild("calculation").ToText();
              calculation = boost::shared_ptr<Calculation>(
                           new Calculation(calculationNode));

              TiXmlElement* knownAmountScheduleNode = xmlNode->FirstChild("knownAmountSchedule").ToText();
              knownAmountSchedule = boost::shared_ptr<AmountSchedule>(
                           new AmountSchedule(knownAmountScheduleNode));

       }
   protected: 
       boost::shared_ptr<Calculation> calculation;
       boost::shared_ptr<AmountSchedule> knownAmountSchedule;
};
#endif

// CalculationPeriodDates.hpp 
#ifndef CppCodeGen_CalculationPeriodDates_hpp
#define CppCodeGen_CalculationPeriodDates_hpp

class CalculationPeriodDates { 
   public: 
       CalculationPeriodDates(TiXmlNode* xmlNode)
       {
              TiXmlElement* effectiveDateNode = xmlNode->FirstChild("effectiveDate").ToText();
              effectiveDate = boost::shared_ptr<AdjustableDate>(
                           new AdjustableDate(effectiveDateNode));

              TiXmlElement* relativeEffectiveDateNode = xmlNode->FirstChild("relativeEffectiveDate").ToText();
              relativeEffectiveDate = boost::shared_ptr<AdjustedRelativeDateOffset>(
                           new AdjustedRelativeDateOffset(relativeEffectiveDateNode));

              TiXmlElement* terminationDateNode = xmlNode->FirstChild("terminationDate").ToText();
              terminationDate = boost::shared_ptr<AdjustableDate>(
                           new AdjustableDate(terminationDateNode));

              TiXmlElement* relativeTerminationDateNode = xmlNode->FirstChild("relativeTerminationDate").ToText();
              relativeTerminationDate = boost::shared_ptr<RelativeDateOffset>(
                           new RelativeDateOffset(relativeTerminationDateNode));

              TiXmlElement* calculationPeriodDatesAdjustmentsNode = xmlNode->FirstChild("calculationPeriodDatesAdjustments").ToText();
              calculationPeriodDatesAdjustments = boost::shared_ptr<BusinessDayAdjustments>(
                           new BusinessDayAdjustments(calculationPeriodDatesAdjustmentsNode));

              TiXmlElement* firstPeriodStartDateNode = xmlNode->FirstChild("firstPeriodStartDate").ToText();
              firstPeriodStartDate = boost::shared_ptr<AdjustableDate>(
                           new AdjustableDate(firstPeriodStartDateNode));

              TiXmlElement* firstRegularPeriodStartDateNode = xmlNode->FirstChild("firstRegularPeriodStartDate").ToText();
              firstRegularPeriodStartDate = boost::shared_ptr<date>(
                           new date(firstRegularPeriodStartDateNode));

              TiXmlElement* firstCompoundingPeriodEndDateNode = xmlNode->FirstChild("firstCompoundingPeriodEndDate").ToText();
              firstCompoundingPeriodEndDate = boost::shared_ptr<date>(
                           new date(firstCompoundingPeriodEndDateNode));

              TiXmlElement* lastRegularPeriodEndDateNode = xmlNode->FirstChild("lastRegularPeriodEndDate").ToText();
              lastRegularPeriodEndDate = boost::shared_ptr<date>(
                           new date(lastRegularPeriodEndDateNode));

              TiXmlElement* stubPeriodTypeNode = xmlNode->FirstChild("stubPeriodType").ToText();
              stubPeriodType = boost::shared_ptr<StubPeriodTypeEnum>(
                           new StubPeriodTypeEnum(stubPeriodTypeNode));

              TiXmlElement* calculationPeriodFrequencyNode = xmlNode->FirstChild("calculationPeriodFrequency").ToText();
              calculationPeriodFrequency = boost::shared_ptr<CalculationPeriodFrequency>(
                           new CalculationPeriodFrequency(calculationPeriodFrequencyNode));

       }
   protected: 
       boost::shared_ptr<AdjustableDate> effectiveDate;
       boost::shared_ptr<AdjustedRelativeDateOffset> relativeEffectiveDate;
       boost::shared_ptr<AdjustableDate> terminationDate;
       boost::shared_ptr<RelativeDateOffset> relativeTerminationDate;
       boost::shared_ptr<BusinessDayAdjustments> calculationPeriodDatesAdjustments;
       boost::shared_ptr<AdjustableDate> firstPeriodStartDate;
       boost::shared_ptr<date> firstRegularPeriodStartDate;
       boost::shared_ptr<date> firstCompoundingPeriodEndDate;
       boost::shared_ptr<date> lastRegularPeriodEndDate;
       boost::shared_ptr<StubPeriodTypeEnum> stubPeriodType;
       boost::shared_ptr<CalculationPeriodFrequency> calculationPeriodFrequency;
};
#endif

// CalculationPeriodDatesReference.hpp 
#ifndef CppCodeGen_CalculationPeriodDatesReference_hpp
#define CppCodeGen_CalculationPeriodDatesReference_hpp

class CalculationPeriodDatesReference : public Reference { 
   public: 
       CalculationPeriodDatesReference(TiXmlNode* xmlNode)
       {
       }
   protected: 
};
#endif

// CancelableProvision.hpp 
#ifndef CppCodeGen_CancelableProvision_hpp
#define CppCodeGen_CancelableProvision_hpp

class CancelableProvision { 
   public: 
       CancelableProvision(TiXmlNode* xmlNode)
       {
              TiXmlElement* exerciseNoticeNode = xmlNode->FirstChild("exerciseNotice").ToText();
              exerciseNotice = boost::shared_ptr<ExerciseNotice>(
                           new ExerciseNotice(exerciseNoticeNode));

              TiXmlElement* followUpConfirmationNode = xmlNode->FirstChild("followUpConfirmation").ToText();
              followUpConfirmation = boost::shared_ptr<boolean>(
                           new boolean(followUpConfirmationNode));

              TiXmlElement* cancelableProvisionAdjustedDatesNode = xmlNode->FirstChild("cancelableProvisionAdjustedDates").ToText();
              cancelableProvisionAdjustedDates = boost::shared_ptr<CancelableProvisionAdjustedDates>(
                           new CancelableProvisionAdjustedDates(cancelableProvisionAdjustedDatesNode));

              TiXmlElement* finalCalculationPeriodDateAdjustmentNode = xmlNode->FirstChild("finalCalculationPeriodDateAdjustment").ToText();
              finalCalculationPeriodDateAdjustment = boost::shared_ptr<FinalCalculationPeriodDateAdjustment>(
                           new FinalCalculationPeriodDateAdjustment(finalCalculationPeriodDateAdjustmentNode));

              TiXmlElement* initialFeeNode = xmlNode->FirstChild("initialFee").ToText();
              initialFee = boost::shared_ptr<SimplePayment>(
                           new SimplePayment(initialFeeNode));

       }
   protected: 
       boost::shared_ptr<ExerciseNotice> exerciseNotice;
       boolean followUpConfirmation;
       boost::shared_ptr<CancelableProvisionAdjustedDates> cancelableProvisionAdjustedDates;
       boost::shared_ptr<FinalCalculationPeriodDateAdjustment> finalCalculationPeriodDateAdjustment;
       boost::shared_ptr<SimplePayment> initialFee;
};
#endif

// CancelableProvisionAdjustedDates.hpp 
#ifndef CppCodeGen_CancelableProvisionAdjustedDates_hpp
#define CppCodeGen_CancelableProvisionAdjustedDates_hpp

class CancelableProvisionAdjustedDates { 
   public: 
       CancelableProvisionAdjustedDates(TiXmlNode* xmlNode)
       {
              TiXmlElement* cancellationEventNode = xmlNode->FirstChild("cancellationEvent").ToText();
              cancellationEvent = boost::shared_ptr<CancellationEvent>(
                           new CancellationEvent(cancellationEventNode));

       }
   protected: 
       boost::shared_ptr<CancellationEvent> cancellationEvent;
};
#endif

// CancellationEvent.hpp 
#ifndef CppCodeGen_CancellationEvent_hpp
#define CppCodeGen_CancellationEvent_hpp

class CancellationEvent { 
   public: 
       CancellationEvent(TiXmlNode* xmlNode)
       {
              TiXmlElement* adjustedExerciseDateNode = xmlNode->FirstChild("adjustedExerciseDate").ToText();
              adjustedExerciseDate = boost::shared_ptr<date>(
                           new date(adjustedExerciseDateNode));

              TiXmlElement* adjustedEarlyTerminationDateNode = xmlNode->FirstChild("adjustedEarlyTerminationDate").ToText();
              adjustedEarlyTerminationDate = boost::shared_ptr<date>(
                           new date(adjustedEarlyTerminationDateNode));

       }
   protected: 
       boost::shared_ptr<date> adjustedExerciseDate;
       boost::shared_ptr<date> adjustedEarlyTerminationDate;
};
#endif

// CapFloor.hpp 
#ifndef CppCodeGen_CapFloor_hpp
#define CppCodeGen_CapFloor_hpp

class CapFloor : public Product { 
   public: 
       CapFloor(TiXmlNode* xmlNode)
       {
              TiXmlElement* capFloorStreamNode = xmlNode->FirstChild("capFloorStream").ToText();
              capFloorStream = boost::shared_ptr<InterestRateStream>(
                           new InterestRateStream(capFloorStreamNode));

              TiXmlElement* premiumNode = xmlNode->FirstChild("premium").ToText();
              premium = boost::shared_ptr<Payment>(
                           new Payment(premiumNode));

              TiXmlElement* additionalPaymentNode = xmlNode->FirstChild("additionalPayment").ToText();
              additionalPayment = boost::shared_ptr<Payment>(
                           new Payment(additionalPaymentNode));

              TiXmlElement* earlyTerminationProvisionNode = xmlNode->FirstChild("earlyTerminationProvision").ToText();
              earlyTerminationProvision = boost::shared_ptr<EarlyTerminationProvision>(
                           new EarlyTerminationProvision(earlyTerminationProvisionNode));

       }
   protected: 
       boost::shared_ptr<InterestRateStream> capFloorStream;
       boost::shared_ptr<Payment> premium;
       boost::shared_ptr<Payment> additionalPayment;
       boost::shared_ptr<EarlyTerminationProvision> earlyTerminationProvision;
};
#endif

// Cashflows.hpp 
#ifndef CppCodeGen_Cashflows_hpp
#define CppCodeGen_Cashflows_hpp

class Cashflows { 
   public: 
       Cashflows(TiXmlNode* xmlNode)
       {
              TiXmlElement* cashflowsMatchParametersNode = xmlNode->FirstChild("cashflowsMatchParameters").ToText();
              cashflowsMatchParameters = boost::shared_ptr<boolean>(
                           new boolean(cashflowsMatchParametersNode));

              TiXmlElement* principalExchangeNode = xmlNode->FirstChild("principalExchange").ToText();
              principalExchange = boost::shared_ptr<PrincipalExchange>(
                           new PrincipalExchange(principalExchangeNode));

              TiXmlElement* paymentCalculationPeriodNode = xmlNode->FirstChild("paymentCalculationPeriod").ToText();
              paymentCalculationPeriod = boost::shared_ptr<PaymentCalculationPeriod>(
                           new PaymentCalculationPeriod(paymentCalculationPeriodNode));

       }
   protected: 
       boolean cashflowsMatchParameters;
       boost::shared_ptr<PrincipalExchange> principalExchange;
       boost::shared_ptr<PaymentCalculationPeriod> paymentCalculationPeriod;
};
#endif

// CashPriceMethod.hpp 
#ifndef CppCodeGen_CashPriceMethod_hpp
#define CppCodeGen_CashPriceMethod_hpp

class CashPriceMethod { 
   public: 
       CashPriceMethod(TiXmlNode* xmlNode)
       {
              TiXmlElement* cashSettlementReferenceBanksNode = xmlNode->FirstChild("cashSettlementReferenceBanks").ToText();
              cashSettlementReferenceBanks = boost::shared_ptr<CashSettlementReferenceBanks>(
                           new CashSettlementReferenceBanks(cashSettlementReferenceBanksNode));

              TiXmlElement* cashSettlementCurrencyNode = xmlNode->FirstChild("cashSettlementCurrency").ToText();
              cashSettlementCurrency = boost::shared_ptr<Currency>(
                           new Currency(cashSettlementCurrencyNode));

              TiXmlElement* quotationRateTypeNode = xmlNode->FirstChild("quotationRateType").ToText();
              quotationRateType = boost::shared_ptr<QuotationRateTypeEnum>(
                           new QuotationRateTypeEnum(quotationRateTypeNode));

       }
   protected: 
       boost::shared_ptr<CashSettlementReferenceBanks> cashSettlementReferenceBanks;
       boost::shared_ptr<Currency> cashSettlementCurrency;
       boost::shared_ptr<QuotationRateTypeEnum> quotationRateType;
};
#endif

// CashSettlement.hpp 
#ifndef CppCodeGen_CashSettlement_hpp
#define CppCodeGen_CashSettlement_hpp

class CashSettlement { 
   public: 
       CashSettlement(TiXmlNode* xmlNode)
       {
              TiXmlElement* cashSettlementValuationTimeNode = xmlNode->FirstChild("cashSettlementValuationTime").ToText();
              cashSettlementValuationTime = boost::shared_ptr<BusinessCenterTime>(
                           new BusinessCenterTime(cashSettlementValuationTimeNode));

              TiXmlElement* cashSettlementValuationDateNode = xmlNode->FirstChild("cashSettlementValuationDate").ToText();
              cashSettlementValuationDate = boost::shared_ptr<RelativeDateOffset>(
                           new RelativeDateOffset(cashSettlementValuationDateNode));

              TiXmlElement* cashSettlementPaymentDateNode = xmlNode->FirstChild("cashSettlementPaymentDate").ToText();
              cashSettlementPaymentDate = boost::shared_ptr<CashSettlementPaymentDate>(
                           new CashSettlementPaymentDate(cashSettlementPaymentDateNode));

              TiXmlElement* cashPriceMethodNode = xmlNode->FirstChild("cashPriceMethod").ToText();
              cashPriceMethod = boost::shared_ptr<CashPriceMethod>(
                           new CashPriceMethod(cashPriceMethodNode));

              TiXmlElement* cashPriceAlternateMethodNode = xmlNode->FirstChild("cashPriceAlternateMethod").ToText();
              cashPriceAlternateMethod = boost::shared_ptr<CashPriceMethod>(
                           new CashPriceMethod(cashPriceAlternateMethodNode));

              TiXmlElement* parYieldCurveAdjustedMethodNode = xmlNode->FirstChild("parYieldCurveAdjustedMethod").ToText();
              parYieldCurveAdjustedMethod = boost::shared_ptr<YieldCurveMethod>(
                           new YieldCurveMethod(parYieldCurveAdjustedMethodNode));

              TiXmlElement* zeroCouponYieldAdjustedMethodNode = xmlNode->FirstChild("zeroCouponYieldAdjustedMethod").ToText();
              zeroCouponYieldAdjustedMethod = boost::shared_ptr<YieldCurveMethod>(
                           new YieldCurveMethod(zeroCouponYieldAdjustedMethodNode));

              TiXmlElement* parYieldCurveUnadjustedMethodNode = xmlNode->FirstChild("parYieldCurveUnadjustedMethod").ToText();
              parYieldCurveUnadjustedMethod = boost::shared_ptr<YieldCurveMethod>(
                           new YieldCurveMethod(parYieldCurveUnadjustedMethodNode));

              TiXmlElement* crossCurrencyMethodNode = xmlNode->FirstChild("crossCurrencyMethod").ToText();
              crossCurrencyMethod = boost::shared_ptr<CrossCurrencyMethod>(
                           new CrossCurrencyMethod(crossCurrencyMethodNode));

              TiXmlElement* collateralizedCashPriceMethodNode = xmlNode->FirstChild("collateralizedCashPriceMethod").ToText();
              collateralizedCashPriceMethod = boost::shared_ptr<YieldCurveMethod>(
                           new YieldCurveMethod(collateralizedCashPriceMethodNode));

       }
   protected: 
       boost::shared_ptr<BusinessCenterTime> cashSettlementValuationTime;
       boost::shared_ptr<RelativeDateOffset> cashSettlementValuationDate;
       boost::shared_ptr<CashSettlementPaymentDate> cashSettlementPaymentDate;
       boost::shared_ptr<CashPriceMethod> cashPriceMethod;
       boost::shared_ptr<CashPriceMethod> cashPriceAlternateMethod;
       boost::shared_ptr<YieldCurveMethod> parYieldCurveAdjustedMethod;
       boost::shared_ptr<YieldCurveMethod> zeroCouponYieldAdjustedMethod;
       boost::shared_ptr<YieldCurveMethod> parYieldCurveUnadjustedMethod;
       boost::shared_ptr<CrossCurrencyMethod> crossCurrencyMethod;
       boost::shared_ptr<YieldCurveMethod> collateralizedCashPriceMethod;
};
#endif

// CashSettlementPaymentDate.hpp 
#ifndef CppCodeGen_CashSettlementPaymentDate_hpp
#define CppCodeGen_CashSettlementPaymentDate_hpp

class CashSettlementPaymentDate { 
   public: 
       CashSettlementPaymentDate(TiXmlNode* xmlNode)
       {
              TiXmlElement* adjustableDatesNode = xmlNode->FirstChild("adjustableDates").ToText();
              adjustableDates = boost::shared_ptr<AdjustableDates>(
                           new AdjustableDates(adjustableDatesNode));

              TiXmlElement* relativeDateNode = xmlNode->FirstChild("relativeDate").ToText();
              relativeDate = boost::shared_ptr<RelativeDateOffset>(
                           new RelativeDateOffset(relativeDateNode));

              TiXmlElement* businessDateRangeNode = xmlNode->FirstChild("businessDateRange").ToText();
              businessDateRange = boost::shared_ptr<BusinessDateRange>(
                           new BusinessDateRange(businessDateRangeNode));

       }
   protected: 
       boost::shared_ptr<AdjustableDates> adjustableDates;
       boost::shared_ptr<RelativeDateOffset> relativeDate;
       boost::shared_ptr<BusinessDateRange> businessDateRange;
};
#endif

// CrossCurrencyMethod.hpp 
#ifndef CppCodeGen_CrossCurrencyMethod_hpp
#define CppCodeGen_CrossCurrencyMethod_hpp

class CrossCurrencyMethod { 
   public: 
       CrossCurrencyMethod(TiXmlNode* xmlNode)
       {
              TiXmlElement* cashSettlementReferenceBanksNode = xmlNode->FirstChild("cashSettlementReferenceBanks").ToText();
              cashSettlementReferenceBanks = boost::shared_ptr<CashSettlementReferenceBanks>(
                           new CashSettlementReferenceBanks(cashSettlementReferenceBanksNode));

              TiXmlElement* cashSettlementCurrencyNode = xmlNode->FirstChild("cashSettlementCurrency").ToText();
              cashSettlementCurrency = boost::shared_ptr<Currency>(
                           new Currency(cashSettlementCurrencyNode));

              TiXmlElement* quotationRateTypeNode = xmlNode->FirstChild("quotationRateType").ToText();
              quotationRateType = boost::shared_ptr<QuotationRateTypeEnum>(
                           new QuotationRateTypeEnum(quotationRateTypeNode));

       }
   protected: 
       boost::shared_ptr<CashSettlementReferenceBanks> cashSettlementReferenceBanks;
       boost::shared_ptr<Currency> cashSettlementCurrency;
       boost::shared_ptr<QuotationRateTypeEnum> quotationRateType;
};
#endif

// DateRelativeToCalculationPeriodDates.hpp 
#ifndef CppCodeGen_DateRelativeToCalculationPeriodDates_hpp
#define CppCodeGen_DateRelativeToCalculationPeriodDates_hpp

class DateRelativeToCalculationPeriodDates { 
   public: 
       DateRelativeToCalculationPeriodDates(TiXmlNode* xmlNode)
       {
              TiXmlElement* calculationPeriodDatesReferenceNode = xmlNode->FirstChild("calculationPeriodDatesReference").ToText();
              calculationPeriodDatesReference = boost::shared_ptr<CalculationPeriodDatesReference>(
                           new CalculationPeriodDatesReference(calculationPeriodDatesReferenceNode));

       }
   protected: 
       boost::shared_ptr<CalculationPeriodDatesReference> calculationPeriodDatesReference;
};
#endif

// DateRelativeToPaymentDates.hpp 
#ifndef CppCodeGen_DateRelativeToPaymentDates_hpp
#define CppCodeGen_DateRelativeToPaymentDates_hpp

class DateRelativeToPaymentDates { 
   public: 
       DateRelativeToPaymentDates(TiXmlNode* xmlNode)
       {
              TiXmlElement* paymentDatesReferenceNode = xmlNode->FirstChild("paymentDatesReference").ToText();
              paymentDatesReference = boost::shared_ptr<PaymentDatesReference>(
                           new PaymentDatesReference(paymentDatesReferenceNode));

       }
   protected: 
       boost::shared_ptr<PaymentDatesReference> paymentDatesReference;
};
#endif

// Discounting.hpp 
#ifndef CppCodeGen_Discounting_hpp
#define CppCodeGen_Discounting_hpp

class Discounting { 
   public: 
       Discounting(TiXmlNode* xmlNode)
       {
              TiXmlElement* discountingTypeNode = xmlNode->FirstChild("discountingType").ToText();
              discountingType = boost::shared_ptr<DiscountingTypeEnum>(
                           new DiscountingTypeEnum(discountingTypeNode));

       }
   protected: 
       boost::shared_ptr<DiscountingTypeEnum> discountingType;
};
#endif

// EarlyTerminationEvent.hpp 
#ifndef CppCodeGen_EarlyTerminationEvent_hpp
#define CppCodeGen_EarlyTerminationEvent_hpp

class EarlyTerminationEvent { 
   public: 
       EarlyTerminationEvent(TiXmlNode* xmlNode)
       {
              TiXmlElement* adjustedExerciseDateNode = xmlNode->FirstChild("adjustedExerciseDate").ToText();
              adjustedExerciseDate = boost::shared_ptr<date>(
                           new date(adjustedExerciseDateNode));

              TiXmlElement* adjustedEarlyTerminationDateNode = xmlNode->FirstChild("adjustedEarlyTerminationDate").ToText();
              adjustedEarlyTerminationDate = boost::shared_ptr<date>(
                           new date(adjustedEarlyTerminationDateNode));

              TiXmlElement* adjustedCashSettlementValuationDateNode = xmlNode->FirstChild("adjustedCashSettlementValuationDate").ToText();
              adjustedCashSettlementValuationDate = boost::shared_ptr<date>(
                           new date(adjustedCashSettlementValuationDateNode));

              TiXmlElement* adjustedCashSettlementPaymentDateNode = xmlNode->FirstChild("adjustedCashSettlementPaymentDate").ToText();
              adjustedCashSettlementPaymentDate = boost::shared_ptr<date>(
                           new date(adjustedCashSettlementPaymentDateNode));

              TiXmlElement* adjustedExerciseFeePaymentDateNode = xmlNode->FirstChild("adjustedExerciseFeePaymentDate").ToText();
              adjustedExerciseFeePaymentDate = boost::shared_ptr<date>(
                           new date(adjustedExerciseFeePaymentDateNode));

       }
   protected: 
       boost::shared_ptr<date> adjustedExerciseDate;
       boost::shared_ptr<date> adjustedEarlyTerminationDate;
       boost::shared_ptr<date> adjustedCashSettlementValuationDate;
       boost::shared_ptr<date> adjustedCashSettlementPaymentDate;
       boost::shared_ptr<date> adjustedExerciseFeePaymentDate;
};
#endif

// EarlyTerminationProvision.hpp 
#ifndef CppCodeGen_EarlyTerminationProvision_hpp
#define CppCodeGen_EarlyTerminationProvision_hpp

class EarlyTerminationProvision { 
   public: 
       EarlyTerminationProvision(TiXmlNode* xmlNode)
       {
       }
   protected: 
};
#endif

// ExerciseEvent.hpp 
#ifndef CppCodeGen_ExerciseEvent_hpp
#define CppCodeGen_ExerciseEvent_hpp

class ExerciseEvent { 
   public: 
       ExerciseEvent(TiXmlNode* xmlNode)
       {
              TiXmlElement* adjustedExerciseDateNode = xmlNode->FirstChild("adjustedExerciseDate").ToText();
              adjustedExerciseDate = boost::shared_ptr<date>(
                           new date(adjustedExerciseDateNode));

              TiXmlElement* adjustedRelevantSwapEffectiveDateNode = xmlNode->FirstChild("adjustedRelevantSwapEffectiveDate").ToText();
              adjustedRelevantSwapEffectiveDate = boost::shared_ptr<date>(
                           new date(adjustedRelevantSwapEffectiveDateNode));

              TiXmlElement* adjustedCashSettlementValuationDateNode = xmlNode->FirstChild("adjustedCashSettlementValuationDate").ToText();
              adjustedCashSettlementValuationDate = boost::shared_ptr<date>(
                           new date(adjustedCashSettlementValuationDateNode));

              TiXmlElement* adjustedCashSettlementPaymentDateNode = xmlNode->FirstChild("adjustedCashSettlementPaymentDate").ToText();
              adjustedCashSettlementPaymentDate = boost::shared_ptr<date>(
                           new date(adjustedCashSettlementPaymentDateNode));

              TiXmlElement* adjustedExerciseFeePaymentDateNode = xmlNode->FirstChild("adjustedExerciseFeePaymentDate").ToText();
              adjustedExerciseFeePaymentDate = boost::shared_ptr<date>(
                           new date(adjustedExerciseFeePaymentDateNode));

       }
   protected: 
       boost::shared_ptr<date> adjustedExerciseDate;
       boost::shared_ptr<date> adjustedRelevantSwapEffectiveDate;
       boost::shared_ptr<date> adjustedCashSettlementValuationDate;
       boost::shared_ptr<date> adjustedCashSettlementPaymentDate;
       boost::shared_ptr<date> adjustedExerciseFeePaymentDate;
};
#endif

// ExercisePeriod.hpp 
#ifndef CppCodeGen_ExercisePeriod_hpp
#define CppCodeGen_ExercisePeriod_hpp

class ExercisePeriod { 
   public: 
       ExercisePeriod(TiXmlNode* xmlNode)
       {
              TiXmlElement* earliestExerciseDateTenorNode = xmlNode->FirstChild("earliestExerciseDateTenor").ToText();
              earliestExerciseDateTenor = boost::shared_ptr<Period>(
                           new Period(earliestExerciseDateTenorNode));

              TiXmlElement* exerciseFrequencyNode = xmlNode->FirstChild("exerciseFrequency").ToText();
              exerciseFrequency = boost::shared_ptr<Period>(
                           new Period(exerciseFrequencyNode));

       }
   protected: 
       boost::shared_ptr<Period> earliestExerciseDateTenor;
       boost::shared_ptr<Period> exerciseFrequency;
};
#endif

// ExtendibleProvision.hpp 
#ifndef CppCodeGen_ExtendibleProvision_hpp
#define CppCodeGen_ExtendibleProvision_hpp

class ExtendibleProvision { 
   public: 
       ExtendibleProvision(TiXmlNode* xmlNode)
       {
              TiXmlElement* exerciseNoticeNode = xmlNode->FirstChild("exerciseNotice").ToText();
              exerciseNotice = boost::shared_ptr<ExerciseNotice>(
                           new ExerciseNotice(exerciseNoticeNode));

              TiXmlElement* followUpConfirmationNode = xmlNode->FirstChild("followUpConfirmation").ToText();
              followUpConfirmation = boost::shared_ptr<boolean>(
                           new boolean(followUpConfirmationNode));

              TiXmlElement* extendibleProvisionAdjustedDatesNode = xmlNode->FirstChild("extendibleProvisionAdjustedDates").ToText();
              extendibleProvisionAdjustedDates = boost::shared_ptr<ExtendibleProvisionAdjustedDates>(
                           new ExtendibleProvisionAdjustedDates(extendibleProvisionAdjustedDatesNode));

       }
   protected: 
       boost::shared_ptr<ExerciseNotice> exerciseNotice;
       boolean followUpConfirmation;
       boost::shared_ptr<ExtendibleProvisionAdjustedDates> extendibleProvisionAdjustedDates;
};
#endif

// ExtendibleProvisionAdjustedDates.hpp 
#ifndef CppCodeGen_ExtendibleProvisionAdjustedDates_hpp
#define CppCodeGen_ExtendibleProvisionAdjustedDates_hpp

class ExtendibleProvisionAdjustedDates { 
   public: 
       ExtendibleProvisionAdjustedDates(TiXmlNode* xmlNode)
       {
              TiXmlElement* extensionEventNode = xmlNode->FirstChild("extensionEvent").ToText();
              extensionEvent = boost::shared_ptr<ExtensionEvent>(
                           new ExtensionEvent(extensionEventNode));

       }
   protected: 
       boost::shared_ptr<ExtensionEvent> extensionEvent;
};
#endif

// ExtensionEvent.hpp 
#ifndef CppCodeGen_ExtensionEvent_hpp
#define CppCodeGen_ExtensionEvent_hpp

class ExtensionEvent { 
   public: 
       ExtensionEvent(TiXmlNode* xmlNode)
       {
              TiXmlElement* adjustedExerciseDateNode = xmlNode->FirstChild("adjustedExerciseDate").ToText();
              adjustedExerciseDate = boost::shared_ptr<date>(
                           new date(adjustedExerciseDateNode));

              TiXmlElement* adjustedExtendedTerminationDateNode = xmlNode->FirstChild("adjustedExtendedTerminationDate").ToText();
              adjustedExtendedTerminationDate = boost::shared_ptr<date>(
                           new date(adjustedExtendedTerminationDateNode));

       }
   protected: 
       boost::shared_ptr<date> adjustedExerciseDate;
       boost::shared_ptr<date> adjustedExtendedTerminationDate;
};
#endif

// FallbackReferencePrice.hpp 
#ifndef CppCodeGen_FallbackReferencePrice_hpp
#define CppCodeGen_FallbackReferencePrice_hpp

class FallbackReferencePrice { 
   public: 
       FallbackReferencePrice(TiXmlNode* xmlNode)
       {
              TiXmlElement* valuationPostponementNode = xmlNode->FirstChild("valuationPostponement").ToText();
              valuationPostponement = boost::shared_ptr<ValuationPostponement>(
                           new ValuationPostponement(valuationPostponementNode));

              TiXmlElement* fallbackSettlementRateOptionNode = xmlNode->FirstChild("fallbackSettlementRateOption").ToText();
              fallbackSettlementRateOption = boost::shared_ptr<SettlementRateOption>(
                           new SettlementRateOption(fallbackSettlementRateOptionNode));

              TiXmlElement* fallbackSurveyValuationPostponenmentNode = xmlNode->FirstChild("fallbackSurveyValuationPostponenment").ToText();
              fallbackSurveyValuationPostponenment = boost::shared_ptr<Empty>(
                           new Empty(fallbackSurveyValuationPostponenmentNode));

              TiXmlElement* calculationAgentDeterminationNode = xmlNode->FirstChild("calculationAgentDetermination").ToText();
              calculationAgentDetermination = boost::shared_ptr<CalculationAgent>(
                           new CalculationAgent(calculationAgentDeterminationNode));

       }
   protected: 
       boost::shared_ptr<ValuationPostponement> valuationPostponement;
       boost::shared_ptr<SettlementRateOption> fallbackSettlementRateOption;
       boost::shared_ptr<Empty> fallbackSurveyValuationPostponenment;
       boost::shared_ptr<CalculationAgent> calculationAgentDetermination;
};
#endif

// FinalCalculationPeriodDateAdjustment.hpp 
#ifndef CppCodeGen_FinalCalculationPeriodDateAdjustment_hpp
#define CppCodeGen_FinalCalculationPeriodDateAdjustment_hpp

class FinalCalculationPeriodDateAdjustment { 
   public: 
       FinalCalculationPeriodDateAdjustment(TiXmlNode* xmlNode)
       {
              TiXmlElement* relevantUnderlyingDateReferenceNode = xmlNode->FirstChild("relevantUnderlyingDateReference").ToText();
              relevantUnderlyingDateReference = boost::shared_ptr<RelevantUnderlyingDateReference>(
                           new RelevantUnderlyingDateReference(relevantUnderlyingDateReferenceNode));

              TiXmlElement* swapStreamReferenceNode = xmlNode->FirstChild("swapStreamReference").ToText();
              swapStreamReference = boost::shared_ptr<InterestRateStreamReference>(
                           new InterestRateStreamReference(swapStreamReferenceNode));

              TiXmlElement* businessDayConventionNode = xmlNode->FirstChild("businessDayConvention").ToText();
              businessDayConvention = boost::shared_ptr<BusinessDayConventionEnum>(
                           new BusinessDayConventionEnum(businessDayConventionNode));

       }
   protected: 
       boost::shared_ptr<RelevantUnderlyingDateReference> relevantUnderlyingDateReference;
       boost::shared_ptr<InterestRateStreamReference> swapStreamReference;
       boost::shared_ptr<BusinessDayConventionEnum> businessDayConvention;
};
#endif

// FloatingRateDefinition.hpp 
#ifndef CppCodeGen_FloatingRateDefinition_hpp
#define CppCodeGen_FloatingRateDefinition_hpp

class FloatingRateDefinition { 
   public: 
       FloatingRateDefinition(TiXmlNode* xmlNode)
       {
              TiXmlElement* calculatedRateNode = xmlNode->FirstChild("calculatedRate").ToText();
              calculatedRate = boost::shared_ptr<decimal>(
                           new decimal(calculatedRateNode));

              TiXmlElement* rateObservationNode = xmlNode->FirstChild("rateObservation").ToText();
              rateObservation = boost::shared_ptr<RateObservation>(
                           new RateObservation(rateObservationNode));

              TiXmlElement* floatingRateMultiplierNode = xmlNode->FirstChild("floatingRateMultiplier").ToText();
              floatingRateMultiplier = boost::shared_ptr<decimal>(
                           new decimal(floatingRateMultiplierNode));

              TiXmlElement* spreadNode = xmlNode->FirstChild("spread").ToText();
              spread = boost::shared_ptr<decimal>(
                           new decimal(spreadNode));

              TiXmlElement* capRateNode = xmlNode->FirstChild("capRate").ToText();
              capRate = boost::shared_ptr<Strike>(
                           new Strike(capRateNode));

              TiXmlElement* floorRateNode = xmlNode->FirstChild("floorRate").ToText();
              floorRate = boost::shared_ptr<Strike>(
                           new Strike(floorRateNode));

       }
   protected: 
       decimal calculatedRate;
       boost::shared_ptr<RateObservation> rateObservation;
       decimal floatingRateMultiplier;
       decimal spread;
       boost::shared_ptr<Strike> capRate;
       boost::shared_ptr<Strike> floorRate;
};
#endif

// Fra.hpp 
#ifndef CppCodeGen_Fra_hpp
#define CppCodeGen_Fra_hpp

class Fra : public Product { 
   public: 
       Fra(TiXmlNode* xmlNode)
       {
              TiXmlElement* adjustedEffectiveDateNode = xmlNode->FirstChild("adjustedEffectiveDate").ToText();
              adjustedEffectiveDate = boost::shared_ptr<RequiredIdentifierDate>(
                           new RequiredIdentifierDate(adjustedEffectiveDateNode));

              TiXmlElement* adjustedTerminationDateNode = xmlNode->FirstChild("adjustedTerminationDate").ToText();
              adjustedTerminationDate = boost::shared_ptr<date>(
                           new date(adjustedTerminationDateNode));

              TiXmlElement* paymentDateNode = xmlNode->FirstChild("paymentDate").ToText();
              paymentDate = boost::shared_ptr<AdjustableDate>(
                           new AdjustableDate(paymentDateNode));

              TiXmlElement* fixingDateOffsetNode = xmlNode->FirstChild("fixingDateOffset").ToText();
              fixingDateOffset = boost::shared_ptr<RelativeDateOffset>(
                           new RelativeDateOffset(fixingDateOffsetNode));

              TiXmlElement* dayCountFractionNode = xmlNode->FirstChild("dayCountFraction").ToText();
              dayCountFraction = boost::shared_ptr<DayCountFraction>(
                           new DayCountFraction(dayCountFractionNode));

              TiXmlElement* calculationPeriodNumberOfDaysNode = xmlNode->FirstChild("calculationPeriodNumberOfDays").ToText();
              calculationPeriodNumberOfDays = boost::shared_ptr<positiveInteger>(
                           new positiveInteger(calculationPeriodNumberOfDaysNode));

              TiXmlElement* notionalNode = xmlNode->FirstChild("notional").ToText();
              notional = boost::shared_ptr<Money>(
                           new Money(notionalNode));

              TiXmlElement* fixedRateNode = xmlNode->FirstChild("fixedRate").ToText();
              fixedRate = boost::shared_ptr<decimal>(
                           new decimal(fixedRateNode));

              TiXmlElement* floatingRateIndexNode = xmlNode->FirstChild("floatingRateIndex").ToText();
              floatingRateIndex = boost::shared_ptr<FloatingRateIndex>(
                           new FloatingRateIndex(floatingRateIndexNode));

              TiXmlElement* indexTenorNode = xmlNode->FirstChild("indexTenor").ToText();
              indexTenor = boost::shared_ptr<Period>(
                           new Period(indexTenorNode));

              TiXmlElement* fraDiscountingNode = xmlNode->FirstChild("fraDiscounting").ToText();
              fraDiscounting = boost::shared_ptr<FraDiscountingEnum>(
                           new FraDiscountingEnum(fraDiscountingNode));

       }
   protected: 
       boost::shared_ptr<RequiredIdentifierDate> adjustedEffectiveDate;
       boost::shared_ptr<date> adjustedTerminationDate;
       boost::shared_ptr<AdjustableDate> paymentDate;
       boost::shared_ptr<RelativeDateOffset> fixingDateOffset;
       boost::shared_ptr<DayCountFraction> dayCountFraction;
       boost::shared_ptr<positiveInteger> calculationPeriodNumberOfDays;
       boost::shared_ptr<Money> notional;
       decimal fixedRate;
       boost::shared_ptr<FloatingRateIndex> floatingRateIndex;
       boost::shared_ptr<Period> indexTenor;
       boost::shared_ptr<FraDiscountingEnum> fraDiscounting;
};
#endif

// FxFixingDate.hpp 
#ifndef CppCodeGen_FxFixingDate_hpp
#define CppCodeGen_FxFixingDate_hpp

class FxFixingDate : public Offset { 
   public: 
       FxFixingDate(TiXmlNode* xmlNode)
       {
              TiXmlElement* businessDayConventionNode = xmlNode->FirstChild("businessDayConvention").ToText();
              businessDayConvention = boost::shared_ptr<BusinessDayConventionEnum>(
                           new BusinessDayConventionEnum(businessDayConventionNode));

              TiXmlElement* dateRelativeToPaymentDatesNode = xmlNode->FirstChild("dateRelativeToPaymentDates").ToText();
              dateRelativeToPaymentDates = boost::shared_ptr<DateRelativeToPaymentDates>(
                           new DateRelativeToPaymentDates(dateRelativeToPaymentDatesNode));

              TiXmlElement* dateRelativeToCalculationPeriodDatesNode = xmlNode->FirstChild("dateRelativeToCalculationPeriodDates").ToText();
              dateRelativeToCalculationPeriodDates = boost::shared_ptr<DateRelativeToCalculationPeriodDates>(
                           new DateRelativeToCalculationPeriodDates(dateRelativeToCalculationPeriodDatesNode));

       }
   protected: 
       boost::shared_ptr<BusinessDayConventionEnum> businessDayConvention;
       boost::shared_ptr<DateRelativeToPaymentDates> dateRelativeToPaymentDates;
       boost::shared_ptr<DateRelativeToCalculationPeriodDates> dateRelativeToCalculationPeriodDates;
};
#endif

// FxLinkedNotionalAmount.hpp 
#ifndef CppCodeGen_FxLinkedNotionalAmount_hpp
#define CppCodeGen_FxLinkedNotionalAmount_hpp

class FxLinkedNotionalAmount { 
   public: 
       FxLinkedNotionalAmount(TiXmlNode* xmlNode)
       {
              TiXmlElement* resetDateNode = xmlNode->FirstChild("resetDate").ToText();
              resetDate = boost::shared_ptr<date>(
                           new date(resetDateNode));

              TiXmlElement* adjustedFxSpotFixingDateNode = xmlNode->FirstChild("adjustedFxSpotFixingDate").ToText();
              adjustedFxSpotFixingDate = boost::shared_ptr<date>(
                           new date(adjustedFxSpotFixingDateNode));

              TiXmlElement* observedFxSpotRateNode = xmlNode->FirstChild("observedFxSpotRate").ToText();
              observedFxSpotRate = boost::shared_ptr<decimal>(
                           new decimal(observedFxSpotRateNode));

              TiXmlElement* notionalAmountNode = xmlNode->FirstChild("notionalAmount").ToText();
              notionalAmount = boost::shared_ptr<decimal>(
                           new decimal(notionalAmountNode));

       }
   protected: 
       boost::shared_ptr<date> resetDate;
       boost::shared_ptr<date> adjustedFxSpotFixingDate;
       decimal observedFxSpotRate;
       decimal notionalAmount;
};
#endif

// FxLinkedNotionalSchedule.hpp 
#ifndef CppCodeGen_FxLinkedNotionalSchedule_hpp
#define CppCodeGen_FxLinkedNotionalSchedule_hpp

class FxLinkedNotionalSchedule { 
   public: 
       FxLinkedNotionalSchedule(TiXmlNode* xmlNode)
       {
              TiXmlElement* constantNotionalScheduleReferenceNode = xmlNode->FirstChild("constantNotionalScheduleReference").ToText();
              constantNotionalScheduleReference = boost::shared_ptr<NotionalReference>(
                           new NotionalReference(constantNotionalScheduleReferenceNode));

              TiXmlElement* initialValueNode = xmlNode->FirstChild("initialValue").ToText();
              initialValue = boost::shared_ptr<decimal>(
                           new decimal(initialValueNode));

              TiXmlElement* varyingNotionalCurrencyNode = xmlNode->FirstChild("varyingNotionalCurrency").ToText();
              varyingNotionalCurrency = boost::shared_ptr<Currency>(
                           new Currency(varyingNotionalCurrencyNode));

              TiXmlElement* varyingNotionalFixingDatesNode = xmlNode->FirstChild("varyingNotionalFixingDates").ToText();
              varyingNotionalFixingDates = boost::shared_ptr<RelativeDateOffset>(
                           new RelativeDateOffset(varyingNotionalFixingDatesNode));

              TiXmlElement* fxSpotRateSourceNode = xmlNode->FirstChild("fxSpotRateSource").ToText();
              fxSpotRateSource = boost::shared_ptr<FxSpotRateSource>(
                           new FxSpotRateSource(fxSpotRateSourceNode));

              TiXmlElement* varyingNotionalInterimExchangePaymentDatesNode = xmlNode->FirstChild("varyingNotionalInterimExchangePaymentDates").ToText();
              varyingNotionalInterimExchangePaymentDates = boost::shared_ptr<RelativeDateOffset>(
                           new RelativeDateOffset(varyingNotionalInterimExchangePaymentDatesNode));

       }
   protected: 
       boost::shared_ptr<NotionalReference> constantNotionalScheduleReference;
       decimal initialValue;
       boost::shared_ptr<Currency> varyingNotionalCurrency;
       boost::shared_ptr<RelativeDateOffset> varyingNotionalFixingDates;
       boost::shared_ptr<FxSpotRateSource> fxSpotRateSource;
       boost::shared_ptr<RelativeDateOffset> varyingNotionalInterimExchangePaymentDates;
};
#endif

// InflationRateCalculation.hpp 
#ifndef CppCodeGen_InflationRateCalculation_hpp
#define CppCodeGen_InflationRateCalculation_hpp

class InflationRateCalculation : public FloatingRateCalculation { 
   public: 
       InflationRateCalculation(TiXmlNode* xmlNode)
       {
              TiXmlElement* inflationLagNode = xmlNode->FirstChild("inflationLag").ToText();
              inflationLag = boost::shared_ptr<Offset>(
                           new Offset(inflationLagNode));

              TiXmlElement* indexSourceNode = xmlNode->FirstChild("indexSource").ToText();
              indexSource = boost::shared_ptr<RateSourcePage>(
                           new RateSourcePage(indexSourceNode));

              TiXmlElement* mainPublicationNode = xmlNode->FirstChild("mainPublication").ToText();
              mainPublication = boost::shared_ptr<MainPublication>(
                           new MainPublication(mainPublicationNode));

              TiXmlElement* interpolationMethodNode = xmlNode->FirstChild("interpolationMethod").ToText();
              interpolationMethod = boost::shared_ptr<InterpolationMethod>(
                           new InterpolationMethod(interpolationMethodNode));

              TiXmlElement* initialIndexLevelNode = xmlNode->FirstChild("initialIndexLevel").ToText();
              initialIndexLevel = boost::shared_ptr<decimal>(
                           new decimal(initialIndexLevelNode));

              TiXmlElement* fallbackBondApplicableNode = xmlNode->FirstChild("fallbackBondApplicable").ToText();
              fallbackBondApplicable = boost::shared_ptr<boolean>(
                           new boolean(fallbackBondApplicableNode));

       }
   protected: 
       boost::shared_ptr<Offset> inflationLag;
       boost::shared_ptr<RateSourcePage> indexSource;
       boost::shared_ptr<MainPublication> mainPublication;
       boost::shared_ptr<InterpolationMethod> interpolationMethod;
       decimal initialIndexLevel;
       boolean fallbackBondApplicable;
};
#endif

// InterestRateStream.hpp 
#ifndef CppCodeGen_InterestRateStream_hpp
#define CppCodeGen_InterestRateStream_hpp

class InterestRateStream : public Leg { 
   public: 
       InterestRateStream(TiXmlNode* xmlNode)
       {
              TiXmlElement* calculationPeriodDatesNode = xmlNode->FirstChild("calculationPeriodDates").ToText();
              calculationPeriodDates = boost::shared_ptr<CalculationPeriodDates>(
                           new CalculationPeriodDates(calculationPeriodDatesNode));

              TiXmlElement* paymentDatesNode = xmlNode->FirstChild("paymentDates").ToText();
              paymentDates = boost::shared_ptr<PaymentDates>(
                           new PaymentDates(paymentDatesNode));

              TiXmlElement* resetDatesNode = xmlNode->FirstChild("resetDates").ToText();
              resetDates = boost::shared_ptr<ResetDates>(
                           new ResetDates(resetDatesNode));

              TiXmlElement* calculationPeriodAmountNode = xmlNode->FirstChild("calculationPeriodAmount").ToText();
              calculationPeriodAmount = boost::shared_ptr<CalculationPeriodAmount>(
                           new CalculationPeriodAmount(calculationPeriodAmountNode));

              TiXmlElement* stubCalculationPeriodAmountNode = xmlNode->FirstChild("stubCalculationPeriodAmount").ToText();
              stubCalculationPeriodAmount = boost::shared_ptr<StubCalculationPeriodAmount>(
                           new StubCalculationPeriodAmount(stubCalculationPeriodAmountNode));

              TiXmlElement* principalExchangesNode = xmlNode->FirstChild("principalExchanges").ToText();
              principalExchanges = boost::shared_ptr<PrincipalExchanges>(
                           new PrincipalExchanges(principalExchangesNode));

              TiXmlElement* cashflowsNode = xmlNode->FirstChild("cashflows").ToText();
              cashflows = boost::shared_ptr<Cashflows>(
                           new Cashflows(cashflowsNode));

              TiXmlElement* settlementProvisionNode = xmlNode->FirstChild("settlementProvision").ToText();
              settlementProvision = boost::shared_ptr<SettlementProvision>(
                           new SettlementProvision(settlementProvisionNode));

              TiXmlElement* formulaNode = xmlNode->FirstChild("formula").ToText();
              formula = boost::shared_ptr<Formula>(
                           new Formula(formulaNode));

       }
   protected: 
       boost::shared_ptr<CalculationPeriodDates> calculationPeriodDates;
       boost::shared_ptr<PaymentDates> paymentDates;
       boost::shared_ptr<ResetDates> resetDates;
       boost::shared_ptr<CalculationPeriodAmount> calculationPeriodAmount;
       boost::shared_ptr<StubCalculationPeriodAmount> stubCalculationPeriodAmount;
       boost::shared_ptr<PrincipalExchanges> principalExchanges;
       boost::shared_ptr<Cashflows> cashflows;
       boost::shared_ptr<SettlementProvision> settlementProvision;
       boost::shared_ptr<Formula> formula;
};
#endif

// InterestRateStreamReference.hpp 
#ifndef CppCodeGen_InterestRateStreamReference_hpp
#define CppCodeGen_InterestRateStreamReference_hpp

class InterestRateStreamReference : public Reference { 
   public: 
       InterestRateStreamReference(TiXmlNode* xmlNode)
       {
       }
   protected: 
};
#endif

// MandatoryEarlyTermination.hpp 
#ifndef CppCodeGen_MandatoryEarlyTermination_hpp
#define CppCodeGen_MandatoryEarlyTermination_hpp

class MandatoryEarlyTermination { 
   public: 
       MandatoryEarlyTermination(TiXmlNode* xmlNode)
       {
              TiXmlElement* mandatoryEarlyTerminationDateNode = xmlNode->FirstChild("mandatoryEarlyTerminationDate").ToText();
              mandatoryEarlyTerminationDate = boost::shared_ptr<AdjustableDate>(
                           new AdjustableDate(mandatoryEarlyTerminationDateNode));

              TiXmlElement* calculationAgentNode = xmlNode->FirstChild("calculationAgent").ToText();
              calculationAgent = boost::shared_ptr<CalculationAgent>(
                           new CalculationAgent(calculationAgentNode));

              TiXmlElement* cashSettlementNode = xmlNode->FirstChild("cashSettlement").ToText();
              cashSettlement = boost::shared_ptr<CashSettlement>(
                           new CashSettlement(cashSettlementNode));

              TiXmlElement* mandatoryEarlyTerminationAdjustedDatesNode = xmlNode->FirstChild("mandatoryEarlyTerminationAdjustedDates").ToText();
              mandatoryEarlyTerminationAdjustedDates = boost::shared_ptr<MandatoryEarlyTerminationAdjustedDates>(
                           new MandatoryEarlyTerminationAdjustedDates(mandatoryEarlyTerminationAdjustedDatesNode));

       }
   protected: 
       boost::shared_ptr<AdjustableDate> mandatoryEarlyTerminationDate;
       boost::shared_ptr<CalculationAgent> calculationAgent;
       boost::shared_ptr<CashSettlement> cashSettlement;
       boost::shared_ptr<MandatoryEarlyTerminationAdjustedDates> mandatoryEarlyTerminationAdjustedDates;
};
#endif

// MandatoryEarlyTerminationAdjustedDates.hpp 
#ifndef CppCodeGen_MandatoryEarlyTerminationAdjustedDates_hpp
#define CppCodeGen_MandatoryEarlyTerminationAdjustedDates_hpp

class MandatoryEarlyTerminationAdjustedDates { 
   public: 
       MandatoryEarlyTerminationAdjustedDates(TiXmlNode* xmlNode)
       {
              TiXmlElement* adjustedEarlyTerminationDateNode = xmlNode->FirstChild("adjustedEarlyTerminationDate").ToText();
              adjustedEarlyTerminationDate = boost::shared_ptr<date>(
                           new date(adjustedEarlyTerminationDateNode));

              TiXmlElement* adjustedCashSettlementValuationDateNode = xmlNode->FirstChild("adjustedCashSettlementValuationDate").ToText();
              adjustedCashSettlementValuationDate = boost::shared_ptr<date>(
                           new date(adjustedCashSettlementValuationDateNode));

              TiXmlElement* adjustedCashSettlementPaymentDateNode = xmlNode->FirstChild("adjustedCashSettlementPaymentDate").ToText();
              adjustedCashSettlementPaymentDate = boost::shared_ptr<date>(
                           new date(adjustedCashSettlementPaymentDateNode));

       }
   protected: 
       boost::shared_ptr<date> adjustedEarlyTerminationDate;
       boost::shared_ptr<date> adjustedCashSettlementValuationDate;
       boost::shared_ptr<date> adjustedCashSettlementPaymentDate;
};
#endif

// NonDeliverableSettlement.hpp 
#ifndef CppCodeGen_NonDeliverableSettlement_hpp
#define CppCodeGen_NonDeliverableSettlement_hpp

class NonDeliverableSettlement { 
   public: 
       NonDeliverableSettlement(TiXmlNode* xmlNode)
       {
              TiXmlElement* referenceCurrencyNode = xmlNode->FirstChild("referenceCurrency").ToText();
              referenceCurrency = boost::shared_ptr<Currency>(
                           new Currency(referenceCurrencyNode));

              TiXmlElement* fxFixingDateNode = xmlNode->FirstChild("fxFixingDate").ToText();
              fxFixingDate = boost::shared_ptr<FxFixingDate>(
                           new FxFixingDate(fxFixingDateNode));

              TiXmlElement* fxFixingScheduleNode = xmlNode->FirstChild("fxFixingSchedule").ToText();
              fxFixingSchedule = boost::shared_ptr<AdjustableDates>(
                           new AdjustableDates(fxFixingScheduleNode));

              TiXmlElement* settlementRateOptionNode = xmlNode->FirstChild("settlementRateOption").ToText();
              settlementRateOption = boost::shared_ptr<SettlementRateOption>(
                           new SettlementRateOption(settlementRateOptionNode));

              TiXmlElement* priceSourceDisruptionNode = xmlNode->FirstChild("priceSourceDisruption").ToText();
              priceSourceDisruption = boost::shared_ptr<PriceSourceDisruption>(
                           new PriceSourceDisruption(priceSourceDisruptionNode));

       }
   protected: 
       boost::shared_ptr<Currency> referenceCurrency;
       boost::shared_ptr<FxFixingDate> fxFixingDate;
       boost::shared_ptr<AdjustableDates> fxFixingSchedule;
       boost::shared_ptr<SettlementRateOption> settlementRateOption;
       boost::shared_ptr<PriceSourceDisruption> priceSourceDisruption;
};
#endif

// Notional.hpp 
#ifndef CppCodeGen_Notional_hpp
#define CppCodeGen_Notional_hpp

class Notional { 
   public: 
       Notional(TiXmlNode* xmlNode)
       {
              TiXmlElement* notionalStepScheduleNode = xmlNode->FirstChild("notionalStepSchedule").ToText();
              notionalStepSchedule = boost::shared_ptr<NonNegativeAmountSchedule>(
                           new NonNegativeAmountSchedule(notionalStepScheduleNode));

              TiXmlElement* notionalStepParametersNode = xmlNode->FirstChild("notionalStepParameters").ToText();
              notionalStepParameters = boost::shared_ptr<NotionalStepRule>(
                           new NotionalStepRule(notionalStepParametersNode));

       }
   protected: 
       boost::shared_ptr<NonNegativeAmountSchedule> notionalStepSchedule;
       boost::shared_ptr<NotionalStepRule> notionalStepParameters;
};
#endif

// NotionalStepRule.hpp 
#ifndef CppCodeGen_NotionalStepRule_hpp
#define CppCodeGen_NotionalStepRule_hpp

class NotionalStepRule { 
   public: 
       NotionalStepRule(TiXmlNode* xmlNode)
       {
              TiXmlElement* calculationPeriodDatesReferenceNode = xmlNode->FirstChild("calculationPeriodDatesReference").ToText();
              calculationPeriodDatesReference = boost::shared_ptr<CalculationPeriodDatesReference>(
                           new CalculationPeriodDatesReference(calculationPeriodDatesReferenceNode));

              TiXmlElement* stepFrequencyNode = xmlNode->FirstChild("stepFrequency").ToText();
              stepFrequency = boost::shared_ptr<Period>(
                           new Period(stepFrequencyNode));

              TiXmlElement* firstNotionalStepDateNode = xmlNode->FirstChild("firstNotionalStepDate").ToText();
              firstNotionalStepDate = boost::shared_ptr<date>(
                           new date(firstNotionalStepDateNode));

              TiXmlElement* lastNotionalStepDateNode = xmlNode->FirstChild("lastNotionalStepDate").ToText();
              lastNotionalStepDate = boost::shared_ptr<date>(
                           new date(lastNotionalStepDateNode));

              TiXmlElement* notionalStepAmountNode = xmlNode->FirstChild("notionalStepAmount").ToText();
              notionalStepAmount = boost::shared_ptr<decimal>(
                           new decimal(notionalStepAmountNode));

              TiXmlElement* notionalStepRateNode = xmlNode->FirstChild("notionalStepRate").ToText();
              notionalStepRate = boost::shared_ptr<decimal>(
                           new decimal(notionalStepRateNode));

              TiXmlElement* stepRelativeToNode = xmlNode->FirstChild("stepRelativeTo").ToText();
              stepRelativeTo = boost::shared_ptr<StepRelativeToEnum>(
                           new StepRelativeToEnum(stepRelativeToNode));

       }
   protected: 
       boost::shared_ptr<CalculationPeriodDatesReference> calculationPeriodDatesReference;
       boost::shared_ptr<Period> stepFrequency;
       boost::shared_ptr<date> firstNotionalStepDate;
       boost::shared_ptr<date> lastNotionalStepDate;
       decimal notionalStepAmount;
       decimal notionalStepRate;
       boost::shared_ptr<StepRelativeToEnum> stepRelativeTo;
};
#endif

// OptionalEarlyTermination.hpp 
#ifndef CppCodeGen_OptionalEarlyTermination_hpp
#define CppCodeGen_OptionalEarlyTermination_hpp

class OptionalEarlyTermination { 
   public: 
       OptionalEarlyTermination(TiXmlNode* xmlNode)
       {
              TiXmlElement* singlePartyOptionNode = xmlNode->FirstChild("singlePartyOption").ToText();
              singlePartyOption = boost::shared_ptr<SinglePartyOption>(
                           new SinglePartyOption(singlePartyOptionNode));

              TiXmlElement* exerciseNoticeNode = xmlNode->FirstChild("exerciseNotice").ToText();
              exerciseNotice = boost::shared_ptr<ExerciseNotice>(
                           new ExerciseNotice(exerciseNoticeNode));

              TiXmlElement* followUpConfirmationNode = xmlNode->FirstChild("followUpConfirmation").ToText();
              followUpConfirmation = boost::shared_ptr<boolean>(
                           new boolean(followUpConfirmationNode));

              TiXmlElement* calculationAgentNode = xmlNode->FirstChild("calculationAgent").ToText();
              calculationAgent = boost::shared_ptr<CalculationAgent>(
                           new CalculationAgent(calculationAgentNode));

              TiXmlElement* cashSettlementNode = xmlNode->FirstChild("cashSettlement").ToText();
              cashSettlement = boost::shared_ptr<CashSettlement>(
                           new CashSettlement(cashSettlementNode));

              TiXmlElement* optionalEarlyTerminationAdjustedDatesNode = xmlNode->FirstChild("optionalEarlyTerminationAdjustedDates").ToText();
              optionalEarlyTerminationAdjustedDates = boost::shared_ptr<OptionalEarlyTerminationAdjustedDates>(
                           new OptionalEarlyTerminationAdjustedDates(optionalEarlyTerminationAdjustedDatesNode));

       }
   protected: 
       boost::shared_ptr<SinglePartyOption> singlePartyOption;
       boost::shared_ptr<ExerciseNotice> exerciseNotice;
       boolean followUpConfirmation;
       boost::shared_ptr<CalculationAgent> calculationAgent;
       boost::shared_ptr<CashSettlement> cashSettlement;
       boost::shared_ptr<OptionalEarlyTerminationAdjustedDates> optionalEarlyTerminationAdjustedDates;
};
#endif

// OptionalEarlyTerminationAdjustedDates.hpp 
#ifndef CppCodeGen_OptionalEarlyTerminationAdjustedDates_hpp
#define CppCodeGen_OptionalEarlyTerminationAdjustedDates_hpp

class OptionalEarlyTerminationAdjustedDates { 
   public: 
       OptionalEarlyTerminationAdjustedDates(TiXmlNode* xmlNode)
       {
              TiXmlElement* earlyTerminationEventNode = xmlNode->FirstChild("earlyTerminationEvent").ToText();
              earlyTerminationEvent = boost::shared_ptr<EarlyTerminationEvent>(
                           new EarlyTerminationEvent(earlyTerminationEventNode));

       }
   protected: 
       boost::shared_ptr<EarlyTerminationEvent> earlyTerminationEvent;
};
#endif

// PaymentCalculationPeriod.hpp 
#ifndef CppCodeGen_PaymentCalculationPeriod_hpp
#define CppCodeGen_PaymentCalculationPeriod_hpp

class PaymentCalculationPeriod : public PaymentBase { 
   public: 
       PaymentCalculationPeriod(TiXmlNode* xmlNode)
       {
              TiXmlElement* unadjustedPaymentDateNode = xmlNode->FirstChild("unadjustedPaymentDate").ToText();
              unadjustedPaymentDate = boost::shared_ptr<date>(
                           new date(unadjustedPaymentDateNode));

              TiXmlElement* adjustedPaymentDateNode = xmlNode->FirstChild("adjustedPaymentDate").ToText();
              adjustedPaymentDate = boost::shared_ptr<date>(
                           new date(adjustedPaymentDateNode));

              TiXmlElement* calculationPeriodNode = xmlNode->FirstChild("calculationPeriod").ToText();
              calculationPeriod = boost::shared_ptr<CalculationPeriod>(
                           new CalculationPeriod(calculationPeriodNode));

              TiXmlElement* fixedPaymentAmountNode = xmlNode->FirstChild("fixedPaymentAmount").ToText();
              fixedPaymentAmount = boost::shared_ptr<decimal>(
                           new decimal(fixedPaymentAmountNode));

              TiXmlElement* discountFactorNode = xmlNode->FirstChild("discountFactor").ToText();
              discountFactor = boost::shared_ptr<decimal>(
                           new decimal(discountFactorNode));

              TiXmlElement* forecastPaymentAmountNode = xmlNode->FirstChild("forecastPaymentAmount").ToText();
              forecastPaymentAmount = boost::shared_ptr<Money>(
                           new Money(forecastPaymentAmountNode));

              TiXmlElement* presentValueAmountNode = xmlNode->FirstChild("presentValueAmount").ToText();
              presentValueAmount = boost::shared_ptr<Money>(
                           new Money(presentValueAmountNode));

       }
   protected: 
       boost::shared_ptr<date> unadjustedPaymentDate;
       boost::shared_ptr<date> adjustedPaymentDate;
       boost::shared_ptr<CalculationPeriod> calculationPeriod;
       decimal fixedPaymentAmount;
       decimal discountFactor;
       boost::shared_ptr<Money> forecastPaymentAmount;
       boost::shared_ptr<Money> presentValueAmount;
};
#endif

// PaymentDates.hpp 
#ifndef CppCodeGen_PaymentDates_hpp
#define CppCodeGen_PaymentDates_hpp

class PaymentDates { 
   public: 
       PaymentDates(TiXmlNode* xmlNode)
       {
              TiXmlElement* calculationPeriodDatesReferenceNode = xmlNode->FirstChild("calculationPeriodDatesReference").ToText();
              calculationPeriodDatesReference = boost::shared_ptr<CalculationPeriodDatesReference>(
                           new CalculationPeriodDatesReference(calculationPeriodDatesReferenceNode));

              TiXmlElement* resetDatesReferenceNode = xmlNode->FirstChild("resetDatesReference").ToText();
              resetDatesReference = boost::shared_ptr<ResetDatesReference>(
                           new ResetDatesReference(resetDatesReferenceNode));

              TiXmlElement* valuationDatesReferenceNode = xmlNode->FirstChild("valuationDatesReference").ToText();
              valuationDatesReference = boost::shared_ptr<ValuationDatesReference>(
                           new ValuationDatesReference(valuationDatesReferenceNode));

              TiXmlElement* paymentFrequencyNode = xmlNode->FirstChild("paymentFrequency").ToText();
              paymentFrequency = boost::shared_ptr<Frequency>(
                           new Frequency(paymentFrequencyNode));

              TiXmlElement* firstPaymentDateNode = xmlNode->FirstChild("firstPaymentDate").ToText();
              firstPaymentDate = boost::shared_ptr<date>(
                           new date(firstPaymentDateNode));

              TiXmlElement* lastRegularPaymentDateNode = xmlNode->FirstChild("lastRegularPaymentDate").ToText();
              lastRegularPaymentDate = boost::shared_ptr<date>(
                           new date(lastRegularPaymentDateNode));

              TiXmlElement* payRelativeToNode = xmlNode->FirstChild("payRelativeTo").ToText();
              payRelativeTo = boost::shared_ptr<PayRelativeToEnum>(
                           new PayRelativeToEnum(payRelativeToNode));

              TiXmlElement* paymentDaysOffsetNode = xmlNode->FirstChild("paymentDaysOffset").ToText();
              paymentDaysOffset = boost::shared_ptr<Offset>(
                           new Offset(paymentDaysOffsetNode));

              TiXmlElement* paymentDatesAdjustmentsNode = xmlNode->FirstChild("paymentDatesAdjustments").ToText();
              paymentDatesAdjustments = boost::shared_ptr<BusinessDayAdjustments>(
                           new BusinessDayAdjustments(paymentDatesAdjustmentsNode));

       }
   protected: 
       boost::shared_ptr<CalculationPeriodDatesReference> calculationPeriodDatesReference;
       boost::shared_ptr<ResetDatesReference> resetDatesReference;
       boost::shared_ptr<ValuationDatesReference> valuationDatesReference;
       boost::shared_ptr<Frequency> paymentFrequency;
       boost::shared_ptr<date> firstPaymentDate;
       boost::shared_ptr<date> lastRegularPaymentDate;
       boost::shared_ptr<PayRelativeToEnum> payRelativeTo;
       boost::shared_ptr<Offset> paymentDaysOffset;
       boost::shared_ptr<BusinessDayAdjustments> paymentDatesAdjustments;
};
#endif

// PaymentDatesReference.hpp 
#ifndef CppCodeGen_PaymentDatesReference_hpp
#define CppCodeGen_PaymentDatesReference_hpp

class PaymentDatesReference : public Reference { 
   public: 
       PaymentDatesReference(TiXmlNode* xmlNode)
       {
       }
   protected: 
};
#endif

// PriceSourceDisruption.hpp 
#ifndef CppCodeGen_PriceSourceDisruption_hpp
#define CppCodeGen_PriceSourceDisruption_hpp

class PriceSourceDisruption { 
   public: 
       PriceSourceDisruption(TiXmlNode* xmlNode)
       {
              TiXmlElement* fallbackReferencePriceNode = xmlNode->FirstChild("fallbackReferencePrice").ToText();
              fallbackReferencePrice = boost::shared_ptr<FallbackReferencePrice>(
                           new FallbackReferencePrice(fallbackReferencePriceNode));

       }
   protected: 
       boost::shared_ptr<FallbackReferencePrice> fallbackReferencePrice;
};
#endif

// PrincipalExchange.hpp 
#ifndef CppCodeGen_PrincipalExchange_hpp
#define CppCodeGen_PrincipalExchange_hpp

class PrincipalExchange { 
   public: 
       PrincipalExchange(TiXmlNode* xmlNode)
       {
              TiXmlElement* unadjustedPrincipalExchangeDateNode = xmlNode->FirstChild("unadjustedPrincipalExchangeDate").ToText();
              unadjustedPrincipalExchangeDate = boost::shared_ptr<date>(
                           new date(unadjustedPrincipalExchangeDateNode));

              TiXmlElement* adjustedPrincipalExchangeDateNode = xmlNode->FirstChild("adjustedPrincipalExchangeDate").ToText();
              adjustedPrincipalExchangeDate = boost::shared_ptr<date>(
                           new date(adjustedPrincipalExchangeDateNode));

              TiXmlElement* principalExchangeAmountNode = xmlNode->FirstChild("principalExchangeAmount").ToText();
              principalExchangeAmount = boost::shared_ptr<decimal>(
                           new decimal(principalExchangeAmountNode));

              TiXmlElement* discountFactorNode = xmlNode->FirstChild("discountFactor").ToText();
              discountFactor = boost::shared_ptr<decimal>(
                           new decimal(discountFactorNode));

              TiXmlElement* presentValuePrincipalExchangeAmountNode = xmlNode->FirstChild("presentValuePrincipalExchangeAmount").ToText();
              presentValuePrincipalExchangeAmount = boost::shared_ptr<Money>(
                           new Money(presentValuePrincipalExchangeAmountNode));

       }
   protected: 
       boost::shared_ptr<date> unadjustedPrincipalExchangeDate;
       boost::shared_ptr<date> adjustedPrincipalExchangeDate;
       decimal principalExchangeAmount;
       decimal discountFactor;
       boost::shared_ptr<Money> presentValuePrincipalExchangeAmount;
};
#endif

// RelevantUnderlyingDateReference.hpp 
#ifndef CppCodeGen_RelevantUnderlyingDateReference_hpp
#define CppCodeGen_RelevantUnderlyingDateReference_hpp

class RelevantUnderlyingDateReference : public Reference { 
   public: 
       RelevantUnderlyingDateReference(TiXmlNode* xmlNode)
       {
       }
   protected: 
};
#endif

// ResetDates.hpp 
#ifndef CppCodeGen_ResetDates_hpp
#define CppCodeGen_ResetDates_hpp

class ResetDates { 
   public: 
       ResetDates(TiXmlNode* xmlNode)
       {
              TiXmlElement* calculationPeriodDatesReferenceNode = xmlNode->FirstChild("calculationPeriodDatesReference").ToText();
              calculationPeriodDatesReference = boost::shared_ptr<CalculationPeriodDatesReference>(
                           new CalculationPeriodDatesReference(calculationPeriodDatesReferenceNode));

              TiXmlElement* resetRelativeToNode = xmlNode->FirstChild("resetRelativeTo").ToText();
              resetRelativeTo = boost::shared_ptr<ResetRelativeToEnum>(
                           new ResetRelativeToEnum(resetRelativeToNode));

              TiXmlElement* initialFixingDateNode = xmlNode->FirstChild("initialFixingDate").ToText();
              initialFixingDate = boost::shared_ptr<RelativeDateOffset>(
                           new RelativeDateOffset(initialFixingDateNode));

              TiXmlElement* fixingDatesNode = xmlNode->FirstChild("fixingDates").ToText();
              fixingDates = boost::shared_ptr<RelativeDateOffset>(
                           new RelativeDateOffset(fixingDatesNode));

              TiXmlElement* rateCutOffDaysOffsetNode = xmlNode->FirstChild("rateCutOffDaysOffset").ToText();
              rateCutOffDaysOffset = boost::shared_ptr<Offset>(
                           new Offset(rateCutOffDaysOffsetNode));

              TiXmlElement* resetFrequencyNode = xmlNode->FirstChild("resetFrequency").ToText();
              resetFrequency = boost::shared_ptr<ResetFrequency>(
                           new ResetFrequency(resetFrequencyNode));

              TiXmlElement* resetDatesAdjustmentsNode = xmlNode->FirstChild("resetDatesAdjustments").ToText();
              resetDatesAdjustments = boost::shared_ptr<BusinessDayAdjustments>(
                           new BusinessDayAdjustments(resetDatesAdjustmentsNode));

       }
   protected: 
       boost::shared_ptr<CalculationPeriodDatesReference> calculationPeriodDatesReference;
       boost::shared_ptr<ResetRelativeToEnum> resetRelativeTo;
       boost::shared_ptr<RelativeDateOffset> initialFixingDate;
       boost::shared_ptr<RelativeDateOffset> fixingDates;
       boost::shared_ptr<Offset> rateCutOffDaysOffset;
       boost::shared_ptr<ResetFrequency> resetFrequency;
       boost::shared_ptr<BusinessDayAdjustments> resetDatesAdjustments;
};
#endif

// ResetDatesReference.hpp 
#ifndef CppCodeGen_ResetDatesReference_hpp
#define CppCodeGen_ResetDatesReference_hpp

class ResetDatesReference : public Reference { 
   public: 
       ResetDatesReference(TiXmlNode* xmlNode)
       {
       }
   protected: 
};
#endif

// SettlementProvision.hpp 
#ifndef CppCodeGen_SettlementProvision_hpp
#define CppCodeGen_SettlementProvision_hpp

class SettlementProvision { 
   public: 
       SettlementProvision(TiXmlNode* xmlNode)
       {
              TiXmlElement* settlementCurrencyNode = xmlNode->FirstChild("settlementCurrency").ToText();
              settlementCurrency = boost::shared_ptr<Currency>(
                           new Currency(settlementCurrencyNode));

              TiXmlElement* nonDeliverableSettlementNode = xmlNode->FirstChild("nonDeliverableSettlement").ToText();
              nonDeliverableSettlement = boost::shared_ptr<NonDeliverableSettlement>(
                           new NonDeliverableSettlement(nonDeliverableSettlementNode));

       }
   protected: 
       boost::shared_ptr<Currency> settlementCurrency;
       boost::shared_ptr<NonDeliverableSettlement> nonDeliverableSettlement;
};
#endif

// SettlementRateOption.hpp 
#ifndef CppCodeGen_SettlementRateOption_hpp
#define CppCodeGen_SettlementRateOption_hpp

class SettlementRateOption { 
   public: 
       SettlementRateOption(TiXmlNode* xmlNode)
       {
       }
   protected: 
};
#endif

// SinglePartyOption.hpp 
#ifndef CppCodeGen_SinglePartyOption_hpp
#define CppCodeGen_SinglePartyOption_hpp

class SinglePartyOption { 
   public: 
       SinglePartyOption(TiXmlNode* xmlNode)
       {
       }
   protected: 
};
#endif

// StubCalculationPeriodAmount.hpp 
#ifndef CppCodeGen_StubCalculationPeriodAmount_hpp
#define CppCodeGen_StubCalculationPeriodAmount_hpp

class StubCalculationPeriodAmount { 
   public: 
       StubCalculationPeriodAmount(TiXmlNode* xmlNode)
       {
              TiXmlElement* calculationPeriodDatesReferenceNode = xmlNode->FirstChild("calculationPeriodDatesReference").ToText();
              calculationPeriodDatesReference = boost::shared_ptr<CalculationPeriodDatesReference>(
                           new CalculationPeriodDatesReference(calculationPeriodDatesReferenceNode));

              TiXmlElement* initialStubNode = xmlNode->FirstChild("initialStub").ToText();
              initialStub = boost::shared_ptr<StubValue>(
                           new StubValue(initialStubNode));

              TiXmlElement* finalStubNode = xmlNode->FirstChild("finalStub").ToText();
              finalStub = boost::shared_ptr<StubValue>(
                           new StubValue(finalStubNode));

              TiXmlElement* finalStubNode = xmlNode->FirstChild("finalStub").ToText();
              finalStub = boost::shared_ptr<StubValue>(
                           new StubValue(finalStubNode));

       }
   protected: 
       boost::shared_ptr<CalculationPeriodDatesReference> calculationPeriodDatesReference;
       boost::shared_ptr<StubValue> initialStub;
       boost::shared_ptr<StubValue> finalStub;
       boost::shared_ptr<StubValue> finalStub;
};
#endif

// Swap.hpp 
#ifndef CppCodeGen_Swap_hpp
#define CppCodeGen_Swap_hpp

class Swap : public Product { 
   public: 
       Swap(TiXmlNode* xmlNode)
       {
              TiXmlElement* swapStreamNode = xmlNode->FirstChild("swapStream").ToText();
              swapStream = boost::shared_ptr<InterestRateStream>(
                           new InterestRateStream(swapStreamNode));

              TiXmlElement* earlyTerminationProvisionNode = xmlNode->FirstChild("earlyTerminationProvision").ToText();
              earlyTerminationProvision = boost::shared_ptr<EarlyTerminationProvision>(
                           new EarlyTerminationProvision(earlyTerminationProvisionNode));

              TiXmlElement* cancelableProvisionNode = xmlNode->FirstChild("cancelableProvision").ToText();
              cancelableProvision = boost::shared_ptr<CancelableProvision>(
                           new CancelableProvision(cancelableProvisionNode));

              TiXmlElement* extendibleProvisionNode = xmlNode->FirstChild("extendibleProvision").ToText();
              extendibleProvision = boost::shared_ptr<ExtendibleProvision>(
                           new ExtendibleProvision(extendibleProvisionNode));

              TiXmlElement* additionalPaymentNode = xmlNode->FirstChild("additionalPayment").ToText();
              additionalPayment = boost::shared_ptr<Payment>(
                           new Payment(additionalPaymentNode));

              TiXmlElement* additionalTermsNode = xmlNode->FirstChild("additionalTerms").ToText();
              additionalTerms = boost::shared_ptr<SwapAdditionalTerms>(
                           new SwapAdditionalTerms(additionalTermsNode));

       }
   protected: 
       boost::shared_ptr<InterestRateStream> swapStream;
       boost::shared_ptr<EarlyTerminationProvision> earlyTerminationProvision;
       boost::shared_ptr<CancelableProvision> cancelableProvision;
       boost::shared_ptr<ExtendibleProvision> extendibleProvision;
       boost::shared_ptr<Payment> additionalPayment;
       boost::shared_ptr<SwapAdditionalTerms> additionalTerms;
};
#endif

// SwapAdditionalTerms.hpp 
#ifndef CppCodeGen_SwapAdditionalTerms_hpp
#define CppCodeGen_SwapAdditionalTerms_hpp

class SwapAdditionalTerms { 
   public: 
       SwapAdditionalTerms(TiXmlNode* xmlNode)
       {
              TiXmlElement* bondReferenceNode = xmlNode->FirstChild("bondReference").ToText();
              bondReference = boost::shared_ptr<BondReference>(
                           new BondReference(bondReferenceNode));

       }
   protected: 
       boost::shared_ptr<BondReference> bondReference;
};
#endif

// Swaption.hpp 
#ifndef CppCodeGen_Swaption_hpp
#define CppCodeGen_Swaption_hpp

class Swaption : public Product { 
   public: 
       Swaption(TiXmlNode* xmlNode)
       {
              TiXmlElement* premiumNode = xmlNode->FirstChild("premium").ToText();
              premium = boost::shared_ptr<Payment>(
                           new Payment(premiumNode));

              TiXmlElement* exerciseProcedureNode = xmlNode->FirstChild("exerciseProcedure").ToText();
              exerciseProcedure = boost::shared_ptr<ExerciseProcedure>(
                           new ExerciseProcedure(exerciseProcedureNode));

              TiXmlElement* calculationAgentNode = xmlNode->FirstChild("calculationAgent").ToText();
              calculationAgent = boost::shared_ptr<CalculationAgent>(
                           new CalculationAgent(calculationAgentNode));

              TiXmlElement* cashSettlementNode = xmlNode->FirstChild("cashSettlement").ToText();
              cashSettlement = boost::shared_ptr<CashSettlement>(
                           new CashSettlement(cashSettlementNode));

              TiXmlElement* physicalSettlementNode = xmlNode->FirstChild("physicalSettlement").ToText();
              physicalSettlement = boost::shared_ptr<SwaptionPhysicalSettlement>(
                           new SwaptionPhysicalSettlement(physicalSettlementNode));

              TiXmlElement* swaptionStraddleNode = xmlNode->FirstChild("swaptionStraddle").ToText();
              swaptionStraddle = boost::shared_ptr<boolean>(
                           new boolean(swaptionStraddleNode));

              TiXmlElement* swaptionAdjustedDatesNode = xmlNode->FirstChild("swaptionAdjustedDates").ToText();
              swaptionAdjustedDates = boost::shared_ptr<SwaptionAdjustedDates>(
                           new SwaptionAdjustedDates(swaptionAdjustedDatesNode));

              TiXmlElement* swapNode = xmlNode->FirstChild("swap").ToText();
              swap = boost::shared_ptr<Swap>(
                           new Swap(swapNode));

       }
   protected: 
       boost::shared_ptr<Payment> premium;
       boost::shared_ptr<ExerciseProcedure> exerciseProcedure;
       boost::shared_ptr<CalculationAgent> calculationAgent;
       boost::shared_ptr<CashSettlement> cashSettlement;
       boost::shared_ptr<SwaptionPhysicalSettlement> physicalSettlement;
       boolean swaptionStraddle;
       boost::shared_ptr<SwaptionAdjustedDates> swaptionAdjustedDates;
       boost::shared_ptr<Swap> swap;
};
#endif

// SwaptionAdjustedDates.hpp 
#ifndef CppCodeGen_SwaptionAdjustedDates_hpp
#define CppCodeGen_SwaptionAdjustedDates_hpp

class SwaptionAdjustedDates { 
   public: 
       SwaptionAdjustedDates(TiXmlNode* xmlNode)
       {
              TiXmlElement* exerciseEventNode = xmlNode->FirstChild("exerciseEvent").ToText();
              exerciseEvent = boost::shared_ptr<ExerciseEvent>(
                           new ExerciseEvent(exerciseEventNode));

       }
   protected: 
       boost::shared_ptr<ExerciseEvent> exerciseEvent;
};
#endif

// SwaptionPhysicalSettlement.hpp 
#ifndef CppCodeGen_SwaptionPhysicalSettlement_hpp
#define CppCodeGen_SwaptionPhysicalSettlement_hpp

class SwaptionPhysicalSettlement { 
   public: 
       SwaptionPhysicalSettlement(TiXmlNode* xmlNode)
       {
              TiXmlElement* clearedPhysicalSettlementNode = xmlNode->FirstChild("clearedPhysicalSettlement").ToText();
              clearedPhysicalSettlement = boost::shared_ptr<boolean>(
                           new boolean(clearedPhysicalSettlementNode));

       }
   protected: 
       boolean clearedPhysicalSettlement;
};
#endif

// ValuationDatesReference.hpp 
#ifndef CppCodeGen_ValuationDatesReference_hpp
#define CppCodeGen_ValuationDatesReference_hpp

class ValuationDatesReference : public Reference { 
   public: 
       ValuationDatesReference(TiXmlNode* xmlNode)
       {
       }
   protected: 
};
#endif

// ValuationPostponement.hpp 
#ifndef CppCodeGen_ValuationPostponement_hpp
#define CppCodeGen_ValuationPostponement_hpp

class ValuationPostponement { 
   public: 
       ValuationPostponement(TiXmlNode* xmlNode)
       {
              TiXmlElement* maximumDaysOfPostponementNode = xmlNode->FirstChild("maximumDaysOfPostponement").ToText();
              maximumDaysOfPostponement = boost::shared_ptr<positiveInteger>(
                           new positiveInteger(maximumDaysOfPostponementNode));

       }
   protected: 
       boost::shared_ptr<positiveInteger> maximumDaysOfPostponement;
};
#endif

// YieldCurveMethod.hpp 
#ifndef CppCodeGen_YieldCurveMethod_hpp
#define CppCodeGen_YieldCurveMethod_hpp

class YieldCurveMethod { 
   public: 
       YieldCurveMethod(TiXmlNode* xmlNode)
       {
              TiXmlElement* settlementRateSourceNode = xmlNode->FirstChild("settlementRateSource").ToText();
              settlementRateSource = boost::shared_ptr<SettlementRateSource>(
                           new SettlementRateSource(settlementRateSourceNode));

              TiXmlElement* quotationRateTypeNode = xmlNode->FirstChild("quotationRateType").ToText();
              quotationRateType = boost::shared_ptr<QuotationRateTypeEnum>(
                           new QuotationRateTypeEnum(quotationRateTypeNode));

       }
   protected: 
       boost::shared_ptr<SettlementRateSource> settlementRateSource;
       boost::shared_ptr<QuotationRateTypeEnum> quotationRateType;
};
#endif

