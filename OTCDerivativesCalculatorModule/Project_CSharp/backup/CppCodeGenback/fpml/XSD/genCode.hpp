// BondReference.hpp 
#ifndef CppCodeGen_BondReference_hpp
#define CppCodeGen_BondReference_hpp

class BondReference { 
   public: 
       BondReference(TiXmlNode* xmlNode)
       {
              TiXmlElement* conditionPrecedentBondNode = xmlNode->FirstChile("conditionPrecedentBond").ToText();
              conditionPrecedentBond = boost::shared_ptr<boolean>(
                           new boolean(conditionPrecedentBondNode));

              TiXmlElement* discrepancyClauseNode = xmlNode->FirstChile("discrepancyClause").ToText();
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
              TiXmlElement* paymentNode = xmlNode->FirstChile("payment").ToText();
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
              TiXmlElement* notionalScheduleNode = xmlNode->FirstChile("notionalSchedule").ToText();
              notionalSchedule = boost::shared_ptr<Notional>(
                           new Notional(notionalScheduleNode));

              TiXmlElement* fxLinkedNotionalScheduleNode = xmlNode->FirstChile("fxLinkedNotionalSchedule").ToText();
              fxLinkedNotionalSchedule = boost::shared_ptr<FxLinkedNotionalSchedule>(
                           new FxLinkedNotionalSchedule(fxLinkedNotionalScheduleNode));

              TiXmlElement* fixedRateScheduleNode = xmlNode->FirstChile("fixedRateSchedule").ToText();
              fixedRateSchedule = boost::shared_ptr<Schedule>(
                           new Schedule(fixedRateScheduleNode));

              TiXmlElement* futureValueNotionalNode = xmlNode->FirstChile("futureValueNotional").ToText();
              futureValueNotional = boost::shared_ptr<FutureValueAmount>(
                           new FutureValueAmount(futureValueNotionalNode));

              TiXmlElement* dayCountFractionNode = xmlNode->FirstChile("dayCountFraction").ToText();
              dayCountFraction = boost::shared_ptr<DayCountFraction>(
                           new DayCountFraction(dayCountFractionNode));

              TiXmlElement* discountingNode = xmlNode->FirstChile("discounting").ToText();
              discounting = boost::shared_ptr<Discounting>(
                           new Discounting(discountingNode));

              TiXmlElement* compoundingMethodNode = xmlNode->FirstChile("compoundingMethod").ToText();
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
              TiXmlElement* unadjustedStartDateNode = xmlNode->FirstChile("unadjustedStartDate").ToText();
              unadjustedStartDate = boost::shared_ptr<date>(
                           new date(unadjustedStartDateNode));

              TiXmlElement* unadjustedEndDateNode = xmlNode->FirstChile("unadjustedEndDate").ToText();
              unadjustedEndDate = boost::shared_ptr<date>(
                           new date(unadjustedEndDateNode));

              TiXmlElement* adjustedStartDateNode = xmlNode->FirstChile("adjustedStartDate").ToText();
              adjustedStartDate = boost::shared_ptr<date>(
                           new date(adjustedStartDateNode));

              TiXmlElement* adjustedEndDateNode = xmlNode->FirstChile("adjustedEndDate").ToText();
              adjustedEndDate = boost::shared_ptr<date>(
                           new date(adjustedEndDateNode));

              TiXmlElement* calculationPeriodNumberOfDaysNode = xmlNode->FirstChile("calculationPeriodNumberOfDays").ToText();
              calculationPeriodNumberOfDays = boost::shared_ptr<positiveInteger>(
                           new positiveInteger(calculationPeriodNumberOfDaysNode));

              TiXmlElement* notionalAmountNode = xmlNode->FirstChile("notionalAmount").ToText();
              notionalAmount = boost::shared_ptr<decimal>(
                           new decimal(notionalAmountNode));

              TiXmlElement* fxLinkedNotionalAmountNode = xmlNode->FirstChile("fxLinkedNotionalAmount").ToText();
              fxLinkedNotionalAmount = boost::shared_ptr<FxLinkedNotionalAmount>(
                           new FxLinkedNotionalAmount(fxLinkedNotionalAmountNode));

              TiXmlElement* floatingRateDefinitionNode = xmlNode->FirstChile("floatingRateDefinition").ToText();
              floatingRateDefinition = boost::shared_ptr<FloatingRateDefinition>(
                           new FloatingRateDefinition(floatingRateDefinitionNode));

              TiXmlElement* fixedRateNode = xmlNode->FirstChile("fixedRate").ToText();
              fixedRate = boost::shared_ptr<decimal>(
                           new decimal(fixedRateNode));

              TiXmlElement* dayCountYearFractionNode = xmlNode->FirstChile("dayCountYearFraction").ToText();
              dayCountYearFraction = boost::shared_ptr<decimal>(
                           new decimal(dayCountYearFractionNode));

              TiXmlElement* forecastAmountNode = xmlNode->FirstChile("forecastAmount").ToText();
              forecastAmount = boost::shared_ptr<Money>(
                           new Money(forecastAmountNode));

              TiXmlElement* forecastRateNode = xmlNode->FirstChile("forecastRate").ToText();
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
              TiXmlElement* calculationNode = xmlNode->FirstChile("calculation").ToText();
              calculation = boost::shared_ptr<Calculation>(
                           new Calculation(calculationNode));

              TiXmlElement* knownAmountScheduleNode = xmlNode->FirstChile("knownAmountSchedule").ToText();
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
              TiXmlElement* effectiveDateNode = xmlNode->FirstChile("effectiveDate").ToText();
              effectiveDate = boost::shared_ptr<AdjustableDate>(
                           new AdjustableDate(effectiveDateNode));

              TiXmlElement* relativeEffectiveDateNode = xmlNode->FirstChile("relativeEffectiveDate").ToText();
              relativeEffectiveDate = boost::shared_ptr<AdjustedRelativeDateOffset>(
                           new AdjustedRelativeDateOffset(relativeEffectiveDateNode));

              TiXmlElement* terminationDateNode = xmlNode->FirstChile("terminationDate").ToText();
              terminationDate = boost::shared_ptr<AdjustableDate>(
                           new AdjustableDate(terminationDateNode));

              TiXmlElement* relativeTerminationDateNode = xmlNode->FirstChile("relativeTerminationDate").ToText();
              relativeTerminationDate = boost::shared_ptr<RelativeDateOffset>(
                           new RelativeDateOffset(relativeTerminationDateNode));

              TiXmlElement* calculationPeriodDatesAdjustmentsNode = xmlNode->FirstChile("calculationPeriodDatesAdjustments").ToText();
              calculationPeriodDatesAdjustments = boost::shared_ptr<BusinessDayAdjustments>(
                           new BusinessDayAdjustments(calculationPeriodDatesAdjustmentsNode));

              TiXmlElement* firstPeriodStartDateNode = xmlNode->FirstChile("firstPeriodStartDate").ToText();
              firstPeriodStartDate = boost::shared_ptr<AdjustableDate>(
                           new AdjustableDate(firstPeriodStartDateNode));

              TiXmlElement* firstRegularPeriodStartDateNode = xmlNode->FirstChile("firstRegularPeriodStartDate").ToText();
              firstRegularPeriodStartDate = boost::shared_ptr<date>(
                           new date(firstRegularPeriodStartDateNode));

              TiXmlElement* firstCompoundingPeriodEndDateNode = xmlNode->FirstChile("firstCompoundingPeriodEndDate").ToText();
              firstCompoundingPeriodEndDate = boost::shared_ptr<date>(
                           new date(firstCompoundingPeriodEndDateNode));

              TiXmlElement* lastRegularPeriodEndDateNode = xmlNode->FirstChile("lastRegularPeriodEndDate").ToText();
              lastRegularPeriodEndDate = boost::shared_ptr<date>(
                           new date(lastRegularPeriodEndDateNode));

              TiXmlElement* stubPeriodTypeNode = xmlNode->FirstChile("stubPeriodType").ToText();
              stubPeriodType = boost::shared_ptr<StubPeriodTypeEnum>(
                           new StubPeriodTypeEnum(stubPeriodTypeNode));

              TiXmlElement* calculationPeriodFrequencyNode = xmlNode->FirstChile("calculationPeriodFrequency").ToText();
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
              TiXmlElement* exerciseNoticeNode = xmlNode->FirstChile("exerciseNotice").ToText();
              exerciseNotice = boost::shared_ptr<ExerciseNotice>(
                           new ExerciseNotice(exerciseNoticeNode));

              TiXmlElement* followUpConfirmationNode = xmlNode->FirstChile("followUpConfirmation").ToText();
              followUpConfirmation = boost::shared_ptr<boolean>(
                           new boolean(followUpConfirmationNode));

              TiXmlElement* cancelableProvisionAdjustedDatesNode = xmlNode->FirstChile("cancelableProvisionAdjustedDates").ToText();
              cancelableProvisionAdjustedDates = boost::shared_ptr<CancelableProvisionAdjustedDates>(
                           new CancelableProvisionAdjustedDates(cancelableProvisionAdjustedDatesNode));

              TiXmlElement* finalCalculationPeriodDateAdjustmentNode = xmlNode->FirstChile("finalCalculationPeriodDateAdjustment").ToText();
              finalCalculationPeriodDateAdjustment = boost::shared_ptr<FinalCalculationPeriodDateAdjustment>(
                           new FinalCalculationPeriodDateAdjustment(finalCalculationPeriodDateAdjustmentNode));

              TiXmlElement* initialFeeNode = xmlNode->FirstChile("initialFee").ToText();
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
              TiXmlElement* cancellationEventNode = xmlNode->FirstChile("cancellationEvent").ToText();
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
              TiXmlElement* adjustedExerciseDateNode = xmlNode->FirstChile("adjustedExerciseDate").ToText();
              adjustedExerciseDate = boost::shared_ptr<date>(
                           new date(adjustedExerciseDateNode));

              TiXmlElement* adjustedEarlyTerminationDateNode = xmlNode->FirstChile("adjustedEarlyTerminationDate").ToText();
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
              TiXmlElement* capFloorStreamNode = xmlNode->FirstChile("capFloorStream").ToText();
              capFloorStream = boost::shared_ptr<InterestRateStream>(
                           new InterestRateStream(capFloorStreamNode));

              TiXmlElement* premiumNode = xmlNode->FirstChile("premium").ToText();
              premium = boost::shared_ptr<Payment>(
                           new Payment(premiumNode));

              TiXmlElement* additionalPaymentNode = xmlNode->FirstChile("additionalPayment").ToText();
              additionalPayment = boost::shared_ptr<Payment>(
                           new Payment(additionalPaymentNode));

              TiXmlElement* earlyTerminationProvisionNode = xmlNode->FirstChile("earlyTerminationProvision").ToText();
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
              TiXmlElement* cashflowsMatchParametersNode = xmlNode->FirstChile("cashflowsMatchParameters").ToText();
              cashflowsMatchParameters = boost::shared_ptr<boolean>(
                           new boolean(cashflowsMatchParametersNode));

              TiXmlElement* principalExchangeNode = xmlNode->FirstChile("principalExchange").ToText();
              principalExchange = boost::shared_ptr<PrincipalExchange>(
                           new PrincipalExchange(principalExchangeNode));

              TiXmlElement* paymentCalculationPeriodNode = xmlNode->FirstChile("paymentCalculationPeriod").ToText();
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
              TiXmlElement* cashSettlementReferenceBanksNode = xmlNode->FirstChile("cashSettlementReferenceBanks").ToText();
              cashSettlementReferenceBanks = boost::shared_ptr<CashSettlementReferenceBanks>(
                           new CashSettlementReferenceBanks(cashSettlementReferenceBanksNode));

              TiXmlElement* cashSettlementCurrencyNode = xmlNode->FirstChile("cashSettlementCurrency").ToText();
              cashSettlementCurrency = boost::shared_ptr<Currency>(
                           new Currency(cashSettlementCurrencyNode));

              TiXmlElement* quotationRateTypeNode = xmlNode->FirstChile("quotationRateType").ToText();
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
              TiXmlElement* cashSettlementValuationTimeNode = xmlNode->FirstChile("cashSettlementValuationTime").ToText();
              cashSettlementValuationTime = boost::shared_ptr<BusinessCenterTime>(
                           new BusinessCenterTime(cashSettlementValuationTimeNode));

              TiXmlElement* cashSettlementValuationDateNode = xmlNode->FirstChile("cashSettlementValuationDate").ToText();
              cashSettlementValuationDate = boost::shared_ptr<RelativeDateOffset>(
                           new RelativeDateOffset(cashSettlementValuationDateNode));

              TiXmlElement* cashSettlementPaymentDateNode = xmlNode->FirstChile("cashSettlementPaymentDate").ToText();
              cashSettlementPaymentDate = boost::shared_ptr<CashSettlementPaymentDate>(
                           new CashSettlementPaymentDate(cashSettlementPaymentDateNode));

              TiXmlElement* cashPriceMethodNode = xmlNode->FirstChile("cashPriceMethod").ToText();
              cashPriceMethod = boost::shared_ptr<CashPriceMethod>(
                           new CashPriceMethod(cashPriceMethodNode));

              TiXmlElement* cashPriceAlternateMethodNode = xmlNode->FirstChile("cashPriceAlternateMethod").ToText();
              cashPriceAlternateMethod = boost::shared_ptr<CashPriceMethod>(
                           new CashPriceMethod(cashPriceAlternateMethodNode));

              TiXmlElement* parYieldCurveAdjustedMethodNode = xmlNode->FirstChile("parYieldCurveAdjustedMethod").ToText();
              parYieldCurveAdjustedMethod = boost::shared_ptr<YieldCurveMethod>(
                           new YieldCurveMethod(parYieldCurveAdjustedMethodNode));

              TiXmlElement* zeroCouponYieldAdjustedMethodNode = xmlNode->FirstChile("zeroCouponYieldAdjustedMethod").ToText();
              zeroCouponYieldAdjustedMethod = boost::shared_ptr<YieldCurveMethod>(
                           new YieldCurveMethod(zeroCouponYieldAdjustedMethodNode));

              TiXmlElement* parYieldCurveUnadjustedMethodNode = xmlNode->FirstChile("parYieldCurveUnadjustedMethod").ToText();
              parYieldCurveUnadjustedMethod = boost::shared_ptr<YieldCurveMethod>(
                           new YieldCurveMethod(parYieldCurveUnadjustedMethodNode));

              TiXmlElement* crossCurrencyMethodNode = xmlNode->FirstChile("crossCurrencyMethod").ToText();
              crossCurrencyMethod = boost::shared_ptr<CrossCurrencyMethod>(
                           new CrossCurrencyMethod(crossCurrencyMethodNode));

              TiXmlElement* collateralizedCashPriceMethodNode = xmlNode->FirstChile("collateralizedCashPriceMethod").ToText();
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
              TiXmlElement* adjustableDatesNode = xmlNode->FirstChile("adjustableDates").ToText();
              adjustableDates = boost::shared_ptr<AdjustableDates>(
                           new AdjustableDates(adjustableDatesNode));

              TiXmlElement* relativeDateNode = xmlNode->FirstChile("relativeDate").ToText();
              relativeDate = boost::shared_ptr<RelativeDateOffset>(
                           new RelativeDateOffset(relativeDateNode));

              TiXmlElement* businessDateRangeNode = xmlNode->FirstChile("businessDateRange").ToText();
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
              TiXmlElement* cashSettlementReferenceBanksNode = xmlNode->FirstChile("cashSettlementReferenceBanks").ToText();
              cashSettlementReferenceBanks = boost::shared_ptr<CashSettlementReferenceBanks>(
                           new CashSettlementReferenceBanks(cashSettlementReferenceBanksNode));

              TiXmlElement* cashSettlementCurrencyNode = xmlNode->FirstChile("cashSettlementCurrency").ToText();
              cashSettlementCurrency = boost::shared_ptr<Currency>(
                           new Currency(cashSettlementCurrencyNode));

              TiXmlElement* quotationRateTypeNode = xmlNode->FirstChile("quotationRateType").ToText();
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
              TiXmlElement* calculationPeriodDatesReferenceNode = xmlNode->FirstChile("calculationPeriodDatesReference").ToText();
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
              TiXmlElement* paymentDatesReferenceNode = xmlNode->FirstChile("paymentDatesReference").ToText();
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
              TiXmlElement* discountingTypeNode = xmlNode->FirstChile("discountingType").ToText();
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
              TiXmlElement* adjustedExerciseDateNode = xmlNode->FirstChile("adjustedExerciseDate").ToText();
              adjustedExerciseDate = boost::shared_ptr<date>(
                           new date(adjustedExerciseDateNode));

              TiXmlElement* adjustedEarlyTerminationDateNode = xmlNode->FirstChile("adjustedEarlyTerminationDate").ToText();
              adjustedEarlyTerminationDate = boost::shared_ptr<date>(
                           new date(adjustedEarlyTerminationDateNode));

              TiXmlElement* adjustedCashSettlementValuationDateNode = xmlNode->FirstChile("adjustedCashSettlementValuationDate").ToText();
              adjustedCashSettlementValuationDate = boost::shared_ptr<date>(
                           new date(adjustedCashSettlementValuationDateNode));

              TiXmlElement* adjustedCashSettlementPaymentDateNode = xmlNode->FirstChile("adjustedCashSettlementPaymentDate").ToText();
              adjustedCashSettlementPaymentDate = boost::shared_ptr<date>(
                           new date(adjustedCashSettlementPaymentDateNode));

              TiXmlElement* adjustedExerciseFeePaymentDateNode = xmlNode->FirstChile("adjustedExerciseFeePaymentDate").ToText();
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
              TiXmlElement* adjustedExerciseDateNode = xmlNode->FirstChile("adjustedExerciseDate").ToText();
              adjustedExerciseDate = boost::shared_ptr<date>(
                           new date(adjustedExerciseDateNode));

              TiXmlElement* adjustedRelevantSwapEffectiveDateNode = xmlNode->FirstChile("adjustedRelevantSwapEffectiveDate").ToText();
              adjustedRelevantSwapEffectiveDate = boost::shared_ptr<date>(
                           new date(adjustedRelevantSwapEffectiveDateNode));

              TiXmlElement* adjustedCashSettlementValuationDateNode = xmlNode->FirstChile("adjustedCashSettlementValuationDate").ToText();
              adjustedCashSettlementValuationDate = boost::shared_ptr<date>(
                           new date(adjustedCashSettlementValuationDateNode));

              TiXmlElement* adjustedCashSettlementPaymentDateNode = xmlNode->FirstChile("adjustedCashSettlementPaymentDate").ToText();
              adjustedCashSettlementPaymentDate = boost::shared_ptr<date>(
                           new date(adjustedCashSettlementPaymentDateNode));

              TiXmlElement* adjustedExerciseFeePaymentDateNode = xmlNode->FirstChile("adjustedExerciseFeePaymentDate").ToText();
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
              TiXmlElement* earliestExerciseDateTenorNode = xmlNode->FirstChile("earliestExerciseDateTenor").ToText();
              earliestExerciseDateTenor = boost::shared_ptr<Period>(
                           new Period(earliestExerciseDateTenorNode));

              TiXmlElement* exerciseFrequencyNode = xmlNode->FirstChile("exerciseFrequency").ToText();
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
              TiXmlElement* exerciseNoticeNode = xmlNode->FirstChile("exerciseNotice").ToText();
              exerciseNotice = boost::shared_ptr<ExerciseNotice>(
                           new ExerciseNotice(exerciseNoticeNode));

              TiXmlElement* followUpConfirmationNode = xmlNode->FirstChile("followUpConfirmation").ToText();
              followUpConfirmation = boost::shared_ptr<boolean>(
                           new boolean(followUpConfirmationNode));

              TiXmlElement* extendibleProvisionAdjustedDatesNode = xmlNode->FirstChile("extendibleProvisionAdjustedDates").ToText();
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
              TiXmlElement* extensionEventNode = xmlNode->FirstChile("extensionEvent").ToText();
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
              TiXmlElement* adjustedExerciseDateNode = xmlNode->FirstChile("adjustedExerciseDate").ToText();
              adjustedExerciseDate = boost::shared_ptr<date>(
                           new date(adjustedExerciseDateNode));

              TiXmlElement* adjustedExtendedTerminationDateNode = xmlNode->FirstChile("adjustedExtendedTerminationDate").ToText();
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
              TiXmlElement* valuationPostponementNode = xmlNode->FirstChile("valuationPostponement").ToText();
              valuationPostponement = boost::shared_ptr<ValuationPostponement>(
                           new ValuationPostponement(valuationPostponementNode));

              TiXmlElement* fallbackSettlementRateOptionNode = xmlNode->FirstChile("fallbackSettlementRateOption").ToText();
              fallbackSettlementRateOption = boost::shared_ptr<SettlementRateOption>(
                           new SettlementRateOption(fallbackSettlementRateOptionNode));

              TiXmlElement* fallbackSurveyValuationPostponenmentNode = xmlNode->FirstChile("fallbackSurveyValuationPostponenment").ToText();
              fallbackSurveyValuationPostponenment = boost::shared_ptr<Empty>(
                           new Empty(fallbackSurveyValuationPostponenmentNode));

              TiXmlElement* calculationAgentDeterminationNode = xmlNode->FirstChile("calculationAgentDetermination").ToText();
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
              TiXmlElement* relevantUnderlyingDateReferenceNode = xmlNode->FirstChile("relevantUnderlyingDateReference").ToText();
              relevantUnderlyingDateReference = boost::shared_ptr<RelevantUnderlyingDateReference>(
                           new RelevantUnderlyingDateReference(relevantUnderlyingDateReferenceNode));

              TiXmlElement* swapStreamReferenceNode = xmlNode->FirstChile("swapStreamReference").ToText();
              swapStreamReference = boost::shared_ptr<InterestRateStreamReference>(
                           new InterestRateStreamReference(swapStreamReferenceNode));

              TiXmlElement* businessDayConventionNode = xmlNode->FirstChile("businessDayConvention").ToText();
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
              TiXmlElement* calculatedRateNode = xmlNode->FirstChile("calculatedRate").ToText();
              calculatedRate = boost::shared_ptr<decimal>(
                           new decimal(calculatedRateNode));

              TiXmlElement* rateObservationNode = xmlNode->FirstChile("rateObservation").ToText();
              rateObservation = boost::shared_ptr<RateObservation>(
                           new RateObservation(rateObservationNode));

              TiXmlElement* floatingRateMultiplierNode = xmlNode->FirstChile("floatingRateMultiplier").ToText();
              floatingRateMultiplier = boost::shared_ptr<decimal>(
                           new decimal(floatingRateMultiplierNode));

              TiXmlElement* spreadNode = xmlNode->FirstChile("spread").ToText();
              spread = boost::shared_ptr<decimal>(
                           new decimal(spreadNode));

              TiXmlElement* capRateNode = xmlNode->FirstChile("capRate").ToText();
              capRate = boost::shared_ptr<Strike>(
                           new Strike(capRateNode));

              TiXmlElement* floorRateNode = xmlNode->FirstChile("floorRate").ToText();
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
              TiXmlElement* adjustedEffectiveDateNode = xmlNode->FirstChile("adjustedEffectiveDate").ToText();
              adjustedEffectiveDate = boost::shared_ptr<RequiredIdentifierDate>(
                           new RequiredIdentifierDate(adjustedEffectiveDateNode));

              TiXmlElement* adjustedTerminationDateNode = xmlNode->FirstChile("adjustedTerminationDate").ToText();
              adjustedTerminationDate = boost::shared_ptr<date>(
                           new date(adjustedTerminationDateNode));

              TiXmlElement* paymentDateNode = xmlNode->FirstChile("paymentDate").ToText();
              paymentDate = boost::shared_ptr<AdjustableDate>(
                           new AdjustableDate(paymentDateNode));

              TiXmlElement* fixingDateOffsetNode = xmlNode->FirstChile("fixingDateOffset").ToText();
              fixingDateOffset = boost::shared_ptr<RelativeDateOffset>(
                           new RelativeDateOffset(fixingDateOffsetNode));

              TiXmlElement* dayCountFractionNode = xmlNode->FirstChile("dayCountFraction").ToText();
              dayCountFraction = boost::shared_ptr<DayCountFraction>(
                           new DayCountFraction(dayCountFractionNode));

              TiXmlElement* calculationPeriodNumberOfDaysNode = xmlNode->FirstChile("calculationPeriodNumberOfDays").ToText();
              calculationPeriodNumberOfDays = boost::shared_ptr<positiveInteger>(
                           new positiveInteger(calculationPeriodNumberOfDaysNode));

              TiXmlElement* notionalNode = xmlNode->FirstChile("notional").ToText();
              notional = boost::shared_ptr<Money>(
                           new Money(notionalNode));

              TiXmlElement* fixedRateNode = xmlNode->FirstChile("fixedRate").ToText();
              fixedRate = boost::shared_ptr<decimal>(
                           new decimal(fixedRateNode));

              TiXmlElement* floatingRateIndexNode = xmlNode->FirstChile("floatingRateIndex").ToText();
              floatingRateIndex = boost::shared_ptr<FloatingRateIndex>(
                           new FloatingRateIndex(floatingRateIndexNode));

              TiXmlElement* indexTenorNode = xmlNode->FirstChile("indexTenor").ToText();
              indexTenor = boost::shared_ptr<Period>(
                           new Period(indexTenorNode));

              TiXmlElement* fraDiscountingNode = xmlNode->FirstChile("fraDiscounting").ToText();
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
              TiXmlElement* businessDayConventionNode = xmlNode->FirstChile("businessDayConvention").ToText();
              businessDayConvention = boost::shared_ptr<BusinessDayConventionEnum>(
                           new BusinessDayConventionEnum(businessDayConventionNode));

              TiXmlElement* dateRelativeToPaymentDatesNode = xmlNode->FirstChile("dateRelativeToPaymentDates").ToText();
              dateRelativeToPaymentDates = boost::shared_ptr<DateRelativeToPaymentDates>(
                           new DateRelativeToPaymentDates(dateRelativeToPaymentDatesNode));

              TiXmlElement* dateRelativeToCalculationPeriodDatesNode = xmlNode->FirstChile("dateRelativeToCalculationPeriodDates").ToText();
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
              TiXmlElement* resetDateNode = xmlNode->FirstChile("resetDate").ToText();
              resetDate = boost::shared_ptr<date>(
                           new date(resetDateNode));

              TiXmlElement* adjustedFxSpotFixingDateNode = xmlNode->FirstChile("adjustedFxSpotFixingDate").ToText();
              adjustedFxSpotFixingDate = boost::shared_ptr<date>(
                           new date(adjustedFxSpotFixingDateNode));

              TiXmlElement* observedFxSpotRateNode = xmlNode->FirstChile("observedFxSpotRate").ToText();
              observedFxSpotRate = boost::shared_ptr<decimal>(
                           new decimal(observedFxSpotRateNode));

              TiXmlElement* notionalAmountNode = xmlNode->FirstChile("notionalAmount").ToText();
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
              TiXmlElement* constantNotionalScheduleReferenceNode = xmlNode->FirstChile("constantNotionalScheduleReference").ToText();
              constantNotionalScheduleReference = boost::shared_ptr<NotionalReference>(
                           new NotionalReference(constantNotionalScheduleReferenceNode));

              TiXmlElement* initialValueNode = xmlNode->FirstChile("initialValue").ToText();
              initialValue = boost::shared_ptr<decimal>(
                           new decimal(initialValueNode));

              TiXmlElement* varyingNotionalCurrencyNode = xmlNode->FirstChile("varyingNotionalCurrency").ToText();
              varyingNotionalCurrency = boost::shared_ptr<Currency>(
                           new Currency(varyingNotionalCurrencyNode));

              TiXmlElement* varyingNotionalFixingDatesNode = xmlNode->FirstChile("varyingNotionalFixingDates").ToText();
              varyingNotionalFixingDates = boost::shared_ptr<RelativeDateOffset>(
                           new RelativeDateOffset(varyingNotionalFixingDatesNode));

              TiXmlElement* fxSpotRateSourceNode = xmlNode->FirstChile("fxSpotRateSource").ToText();
              fxSpotRateSource = boost::shared_ptr<FxSpotRateSource>(
                           new FxSpotRateSource(fxSpotRateSourceNode));

              TiXmlElement* varyingNotionalInterimExchangePaymentDatesNode = xmlNode->FirstChile("varyingNotionalInterimExchangePaymentDates").ToText();
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
              TiXmlElement* inflationLagNode = xmlNode->FirstChile("inflationLag").ToText();
              inflationLag = boost::shared_ptr<Offset>(
                           new Offset(inflationLagNode));

              TiXmlElement* indexSourceNode = xmlNode->FirstChile("indexSource").ToText();
              indexSource = boost::shared_ptr<RateSourcePage>(
                           new RateSourcePage(indexSourceNode));

              TiXmlElement* mainPublicationNode = xmlNode->FirstChile("mainPublication").ToText();
              mainPublication = boost::shared_ptr<MainPublication>(
                           new MainPublication(mainPublicationNode));

              TiXmlElement* interpolationMethodNode = xmlNode->FirstChile("interpolationMethod").ToText();
              interpolationMethod = boost::shared_ptr<InterpolationMethod>(
                           new InterpolationMethod(interpolationMethodNode));

              TiXmlElement* initialIndexLevelNode = xmlNode->FirstChile("initialIndexLevel").ToText();
              initialIndexLevel = boost::shared_ptr<decimal>(
                           new decimal(initialIndexLevelNode));

              TiXmlElement* fallbackBondApplicableNode = xmlNode->FirstChile("fallbackBondApplicable").ToText();
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
              TiXmlElement* calculationPeriodDatesNode = xmlNode->FirstChile("calculationPeriodDates").ToText();
              calculationPeriodDates = boost::shared_ptr<CalculationPeriodDates>(
                           new CalculationPeriodDates(calculationPeriodDatesNode));

              TiXmlElement* paymentDatesNode = xmlNode->FirstChile("paymentDates").ToText();
              paymentDates = boost::shared_ptr<PaymentDates>(
                           new PaymentDates(paymentDatesNode));

              TiXmlElement* resetDatesNode = xmlNode->FirstChile("resetDates").ToText();
              resetDates = boost::shared_ptr<ResetDates>(
                           new ResetDates(resetDatesNode));

              TiXmlElement* calculationPeriodAmountNode = xmlNode->FirstChile("calculationPeriodAmount").ToText();
              calculationPeriodAmount = boost::shared_ptr<CalculationPeriodAmount>(
                           new CalculationPeriodAmount(calculationPeriodAmountNode));

              TiXmlElement* stubCalculationPeriodAmountNode = xmlNode->FirstChile("stubCalculationPeriodAmount").ToText();
              stubCalculationPeriodAmount = boost::shared_ptr<StubCalculationPeriodAmount>(
                           new StubCalculationPeriodAmount(stubCalculationPeriodAmountNode));

              TiXmlElement* principalExchangesNode = xmlNode->FirstChile("principalExchanges").ToText();
              principalExchanges = boost::shared_ptr<PrincipalExchanges>(
                           new PrincipalExchanges(principalExchangesNode));

              TiXmlElement* cashflowsNode = xmlNode->FirstChile("cashflows").ToText();
              cashflows = boost::shared_ptr<Cashflows>(
                           new Cashflows(cashflowsNode));

              TiXmlElement* settlementProvisionNode = xmlNode->FirstChile("settlementProvision").ToText();
              settlementProvision = boost::shared_ptr<SettlementProvision>(
                           new SettlementProvision(settlementProvisionNode));

              TiXmlElement* formulaNode = xmlNode->FirstChile("formula").ToText();
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
              TiXmlElement* mandatoryEarlyTerminationDateNode = xmlNode->FirstChile("mandatoryEarlyTerminationDate").ToText();
              mandatoryEarlyTerminationDate = boost::shared_ptr<AdjustableDate>(
                           new AdjustableDate(mandatoryEarlyTerminationDateNode));

              TiXmlElement* calculationAgentNode = xmlNode->FirstChile("calculationAgent").ToText();
              calculationAgent = boost::shared_ptr<CalculationAgent>(
                           new CalculationAgent(calculationAgentNode));

              TiXmlElement* cashSettlementNode = xmlNode->FirstChile("cashSettlement").ToText();
              cashSettlement = boost::shared_ptr<CashSettlement>(
                           new CashSettlement(cashSettlementNode));

              TiXmlElement* mandatoryEarlyTerminationAdjustedDatesNode = xmlNode->FirstChile("mandatoryEarlyTerminationAdjustedDates").ToText();
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
              TiXmlElement* adjustedEarlyTerminationDateNode = xmlNode->FirstChile("adjustedEarlyTerminationDate").ToText();
              adjustedEarlyTerminationDate = boost::shared_ptr<date>(
                           new date(adjustedEarlyTerminationDateNode));

              TiXmlElement* adjustedCashSettlementValuationDateNode = xmlNode->FirstChile("adjustedCashSettlementValuationDate").ToText();
              adjustedCashSettlementValuationDate = boost::shared_ptr<date>(
                           new date(adjustedCashSettlementValuationDateNode));

              TiXmlElement* adjustedCashSettlementPaymentDateNode = xmlNode->FirstChile("adjustedCashSettlementPaymentDate").ToText();
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
              TiXmlElement* referenceCurrencyNode = xmlNode->FirstChile("referenceCurrency").ToText();
              referenceCurrency = boost::shared_ptr<Currency>(
                           new Currency(referenceCurrencyNode));

              TiXmlElement* fxFixingDateNode = xmlNode->FirstChile("fxFixingDate").ToText();
              fxFixingDate = boost::shared_ptr<FxFixingDate>(
                           new FxFixingDate(fxFixingDateNode));

              TiXmlElement* fxFixingScheduleNode = xmlNode->FirstChile("fxFixingSchedule").ToText();
              fxFixingSchedule = boost::shared_ptr<AdjustableDates>(
                           new AdjustableDates(fxFixingScheduleNode));

              TiXmlElement* settlementRateOptionNode = xmlNode->FirstChile("settlementRateOption").ToText();
              settlementRateOption = boost::shared_ptr<SettlementRateOption>(
                           new SettlementRateOption(settlementRateOptionNode));

              TiXmlElement* priceSourceDisruptionNode = xmlNode->FirstChile("priceSourceDisruption").ToText();
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
              TiXmlElement* notionalStepScheduleNode = xmlNode->FirstChile("notionalStepSchedule").ToText();
              notionalStepSchedule = boost::shared_ptr<NonNegativeAmountSchedule>(
                           new NonNegativeAmountSchedule(notionalStepScheduleNode));

              TiXmlElement* notionalStepParametersNode = xmlNode->FirstChile("notionalStepParameters").ToText();
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
              TiXmlElement* calculationPeriodDatesReferenceNode = xmlNode->FirstChile("calculationPeriodDatesReference").ToText();
              calculationPeriodDatesReference = boost::shared_ptr<CalculationPeriodDatesReference>(
                           new CalculationPeriodDatesReference(calculationPeriodDatesReferenceNode));

              TiXmlElement* stepFrequencyNode = xmlNode->FirstChile("stepFrequency").ToText();
              stepFrequency = boost::shared_ptr<Period>(
                           new Period(stepFrequencyNode));

              TiXmlElement* firstNotionalStepDateNode = xmlNode->FirstChile("firstNotionalStepDate").ToText();
              firstNotionalStepDate = boost::shared_ptr<date>(
                           new date(firstNotionalStepDateNode));

              TiXmlElement* lastNotionalStepDateNode = xmlNode->FirstChile("lastNotionalStepDate").ToText();
              lastNotionalStepDate = boost::shared_ptr<date>(
                           new date(lastNotionalStepDateNode));

              TiXmlElement* notionalStepAmountNode = xmlNode->FirstChile("notionalStepAmount").ToText();
              notionalStepAmount = boost::shared_ptr<decimal>(
                           new decimal(notionalStepAmountNode));

              TiXmlElement* notionalStepRateNode = xmlNode->FirstChile("notionalStepRate").ToText();
              notionalStepRate = boost::shared_ptr<decimal>(
                           new decimal(notionalStepRateNode));

              TiXmlElement* stepRelativeToNode = xmlNode->FirstChile("stepRelativeTo").ToText();
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
              TiXmlElement* singlePartyOptionNode = xmlNode->FirstChile("singlePartyOption").ToText();
              singlePartyOption = boost::shared_ptr<SinglePartyOption>(
                           new SinglePartyOption(singlePartyOptionNode));

              TiXmlElement* exerciseNoticeNode = xmlNode->FirstChile("exerciseNotice").ToText();
              exerciseNotice = boost::shared_ptr<ExerciseNotice>(
                           new ExerciseNotice(exerciseNoticeNode));

              TiXmlElement* followUpConfirmationNode = xmlNode->FirstChile("followUpConfirmation").ToText();
              followUpConfirmation = boost::shared_ptr<boolean>(
                           new boolean(followUpConfirmationNode));

              TiXmlElement* calculationAgentNode = xmlNode->FirstChile("calculationAgent").ToText();
              calculationAgent = boost::shared_ptr<CalculationAgent>(
                           new CalculationAgent(calculationAgentNode));

              TiXmlElement* cashSettlementNode = xmlNode->FirstChile("cashSettlement").ToText();
              cashSettlement = boost::shared_ptr<CashSettlement>(
                           new CashSettlement(cashSettlementNode));

              TiXmlElement* optionalEarlyTerminationAdjustedDatesNode = xmlNode->FirstChile("optionalEarlyTerminationAdjustedDates").ToText();
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
              TiXmlElement* earlyTerminationEventNode = xmlNode->FirstChile("earlyTerminationEvent").ToText();
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
              TiXmlElement* unadjustedPaymentDateNode = xmlNode->FirstChile("unadjustedPaymentDate").ToText();
              unadjustedPaymentDate = boost::shared_ptr<date>(
                           new date(unadjustedPaymentDateNode));

              TiXmlElement* adjustedPaymentDateNode = xmlNode->FirstChile("adjustedPaymentDate").ToText();
              adjustedPaymentDate = boost::shared_ptr<date>(
                           new date(adjustedPaymentDateNode));

              TiXmlElement* calculationPeriodNode = xmlNode->FirstChile("calculationPeriod").ToText();
              calculationPeriod = boost::shared_ptr<CalculationPeriod>(
                           new CalculationPeriod(calculationPeriodNode));

              TiXmlElement* fixedPaymentAmountNode = xmlNode->FirstChile("fixedPaymentAmount").ToText();
              fixedPaymentAmount = boost::shared_ptr<decimal>(
                           new decimal(fixedPaymentAmountNode));

              TiXmlElement* discountFactorNode = xmlNode->FirstChile("discountFactor").ToText();
              discountFactor = boost::shared_ptr<decimal>(
                           new decimal(discountFactorNode));

              TiXmlElement* forecastPaymentAmountNode = xmlNode->FirstChile("forecastPaymentAmount").ToText();
              forecastPaymentAmount = boost::shared_ptr<Money>(
                           new Money(forecastPaymentAmountNode));

              TiXmlElement* presentValueAmountNode = xmlNode->FirstChile("presentValueAmount").ToText();
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
              TiXmlElement* calculationPeriodDatesReferenceNode = xmlNode->FirstChile("calculationPeriodDatesReference").ToText();
              calculationPeriodDatesReference = boost::shared_ptr<CalculationPeriodDatesReference>(
                           new CalculationPeriodDatesReference(calculationPeriodDatesReferenceNode));

              TiXmlElement* resetDatesReferenceNode = xmlNode->FirstChile("resetDatesReference").ToText();
              resetDatesReference = boost::shared_ptr<ResetDatesReference>(
                           new ResetDatesReference(resetDatesReferenceNode));

              TiXmlElement* valuationDatesReferenceNode = xmlNode->FirstChile("valuationDatesReference").ToText();
              valuationDatesReference = boost::shared_ptr<ValuationDatesReference>(
                           new ValuationDatesReference(valuationDatesReferenceNode));

              TiXmlElement* paymentFrequencyNode = xmlNode->FirstChile("paymentFrequency").ToText();
              paymentFrequency = boost::shared_ptr<Frequency>(
                           new Frequency(paymentFrequencyNode));

              TiXmlElement* firstPaymentDateNode = xmlNode->FirstChile("firstPaymentDate").ToText();
              firstPaymentDate = boost::shared_ptr<date>(
                           new date(firstPaymentDateNode));

              TiXmlElement* lastRegularPaymentDateNode = xmlNode->FirstChile("lastRegularPaymentDate").ToText();
              lastRegularPaymentDate = boost::shared_ptr<date>(
                           new date(lastRegularPaymentDateNode));

              TiXmlElement* payRelativeToNode = xmlNode->FirstChile("payRelativeTo").ToText();
              payRelativeTo = boost::shared_ptr<PayRelativeToEnum>(
                           new PayRelativeToEnum(payRelativeToNode));

              TiXmlElement* paymentDaysOffsetNode = xmlNode->FirstChile("paymentDaysOffset").ToText();
              paymentDaysOffset = boost::shared_ptr<Offset>(
                           new Offset(paymentDaysOffsetNode));

              TiXmlElement* paymentDatesAdjustmentsNode = xmlNode->FirstChile("paymentDatesAdjustments").ToText();
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
              TiXmlElement* fallbackReferencePriceNode = xmlNode->FirstChile("fallbackReferencePrice").ToText();
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
              TiXmlElement* unadjustedPrincipalExchangeDateNode = xmlNode->FirstChile("unadjustedPrincipalExchangeDate").ToText();
              unadjustedPrincipalExchangeDate = boost::shared_ptr<date>(
                           new date(unadjustedPrincipalExchangeDateNode));

              TiXmlElement* adjustedPrincipalExchangeDateNode = xmlNode->FirstChile("adjustedPrincipalExchangeDate").ToText();
              adjustedPrincipalExchangeDate = boost::shared_ptr<date>(
                           new date(adjustedPrincipalExchangeDateNode));

              TiXmlElement* principalExchangeAmountNode = xmlNode->FirstChile("principalExchangeAmount").ToText();
              principalExchangeAmount = boost::shared_ptr<decimal>(
                           new decimal(principalExchangeAmountNode));

              TiXmlElement* discountFactorNode = xmlNode->FirstChile("discountFactor").ToText();
              discountFactor = boost::shared_ptr<decimal>(
                           new decimal(discountFactorNode));

              TiXmlElement* presentValuePrincipalExchangeAmountNode = xmlNode->FirstChile("presentValuePrincipalExchangeAmount").ToText();
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
              TiXmlElement* calculationPeriodDatesReferenceNode = xmlNode->FirstChile("calculationPeriodDatesReference").ToText();
              calculationPeriodDatesReference = boost::shared_ptr<CalculationPeriodDatesReference>(
                           new CalculationPeriodDatesReference(calculationPeriodDatesReferenceNode));

              TiXmlElement* resetRelativeToNode = xmlNode->FirstChile("resetRelativeTo").ToText();
              resetRelativeTo = boost::shared_ptr<ResetRelativeToEnum>(
                           new ResetRelativeToEnum(resetRelativeToNode));

              TiXmlElement* initialFixingDateNode = xmlNode->FirstChile("initialFixingDate").ToText();
              initialFixingDate = boost::shared_ptr<RelativeDateOffset>(
                           new RelativeDateOffset(initialFixingDateNode));

              TiXmlElement* fixingDatesNode = xmlNode->FirstChile("fixingDates").ToText();
              fixingDates = boost::shared_ptr<RelativeDateOffset>(
                           new RelativeDateOffset(fixingDatesNode));

              TiXmlElement* rateCutOffDaysOffsetNode = xmlNode->FirstChile("rateCutOffDaysOffset").ToText();
              rateCutOffDaysOffset = boost::shared_ptr<Offset>(
                           new Offset(rateCutOffDaysOffsetNode));

              TiXmlElement* resetFrequencyNode = xmlNode->FirstChile("resetFrequency").ToText();
              resetFrequency = boost::shared_ptr<ResetFrequency>(
                           new ResetFrequency(resetFrequencyNode));

              TiXmlElement* resetDatesAdjustmentsNode = xmlNode->FirstChile("resetDatesAdjustments").ToText();
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
              TiXmlElement* settlementCurrencyNode = xmlNode->FirstChile("settlementCurrency").ToText();
              settlementCurrency = boost::shared_ptr<Currency>(
                           new Currency(settlementCurrencyNode));

              TiXmlElement* nonDeliverableSettlementNode = xmlNode->FirstChile("nonDeliverableSettlement").ToText();
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
              TiXmlElement* calculationPeriodDatesReferenceNode = xmlNode->FirstChile("calculationPeriodDatesReference").ToText();
              calculationPeriodDatesReference = boost::shared_ptr<CalculationPeriodDatesReference>(
                           new CalculationPeriodDatesReference(calculationPeriodDatesReferenceNode));

              TiXmlElement* initialStubNode = xmlNode->FirstChile("initialStub").ToText();
              initialStub = boost::shared_ptr<StubValue>(
                           new StubValue(initialStubNode));

              TiXmlElement* finalStubNode = xmlNode->FirstChile("finalStub").ToText();
              finalStub = boost::shared_ptr<StubValue>(
                           new StubValue(finalStubNode));

              TiXmlElement* finalStubNode = xmlNode->FirstChile("finalStub").ToText();
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
              TiXmlElement* swapStreamNode = xmlNode->FirstChile("swapStream").ToText();
              swapStream = boost::shared_ptr<InterestRateStream>(
                           new InterestRateStream(swapStreamNode));

              TiXmlElement* earlyTerminationProvisionNode = xmlNode->FirstChile("earlyTerminationProvision").ToText();
              earlyTerminationProvision = boost::shared_ptr<EarlyTerminationProvision>(
                           new EarlyTerminationProvision(earlyTerminationProvisionNode));

              TiXmlElement* cancelableProvisionNode = xmlNode->FirstChile("cancelableProvision").ToText();
              cancelableProvision = boost::shared_ptr<CancelableProvision>(
                           new CancelableProvision(cancelableProvisionNode));

              TiXmlElement* extendibleProvisionNode = xmlNode->FirstChile("extendibleProvision").ToText();
              extendibleProvision = boost::shared_ptr<ExtendibleProvision>(
                           new ExtendibleProvision(extendibleProvisionNode));

              TiXmlElement* additionalPaymentNode = xmlNode->FirstChile("additionalPayment").ToText();
              additionalPayment = boost::shared_ptr<Payment>(
                           new Payment(additionalPaymentNode));

              TiXmlElement* additionalTermsNode = xmlNode->FirstChile("additionalTerms").ToText();
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
              TiXmlElement* bondReferenceNode = xmlNode->FirstChile("bondReference").ToText();
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
              TiXmlElement* premiumNode = xmlNode->FirstChile("premium").ToText();
              premium = boost::shared_ptr<Payment>(
                           new Payment(premiumNode));

              TiXmlElement* exerciseProcedureNode = xmlNode->FirstChile("exerciseProcedure").ToText();
              exerciseProcedure = boost::shared_ptr<ExerciseProcedure>(
                           new ExerciseProcedure(exerciseProcedureNode));

              TiXmlElement* calculationAgentNode = xmlNode->FirstChile("calculationAgent").ToText();
              calculationAgent = boost::shared_ptr<CalculationAgent>(
                           new CalculationAgent(calculationAgentNode));

              TiXmlElement* cashSettlementNode = xmlNode->FirstChile("cashSettlement").ToText();
              cashSettlement = boost::shared_ptr<CashSettlement>(
                           new CashSettlement(cashSettlementNode));

              TiXmlElement* physicalSettlementNode = xmlNode->FirstChile("physicalSettlement").ToText();
              physicalSettlement = boost::shared_ptr<SwaptionPhysicalSettlement>(
                           new SwaptionPhysicalSettlement(physicalSettlementNode));

              TiXmlElement* swaptionStraddleNode = xmlNode->FirstChile("swaptionStraddle").ToText();
              swaptionStraddle = boost::shared_ptr<boolean>(
                           new boolean(swaptionStraddleNode));

              TiXmlElement* swaptionAdjustedDatesNode = xmlNode->FirstChile("swaptionAdjustedDates").ToText();
              swaptionAdjustedDates = boost::shared_ptr<SwaptionAdjustedDates>(
                           new SwaptionAdjustedDates(swaptionAdjustedDatesNode));

              TiXmlElement* swapNode = xmlNode->FirstChile("swap").ToText();
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
              TiXmlElement* exerciseEventNode = xmlNode->FirstChile("exerciseEvent").ToText();
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
              TiXmlElement* clearedPhysicalSettlementNode = xmlNode->FirstChile("clearedPhysicalSettlement").ToText();
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
              TiXmlElement* maximumDaysOfPostponementNode = xmlNode->FirstChile("maximumDaysOfPostponement").ToText();
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
              TiXmlElement* settlementRateSourceNode = xmlNode->FirstChile("settlementRateSource").ToText();
              settlementRateSource = boost::shared_ptr<SettlementRateSource>(
                           new SettlementRateSource(settlementRateSourceNode));

              TiXmlElement* quotationRateTypeNode = xmlNode->FirstChile("quotationRateType").ToText();
              quotationRateType = boost::shared_ptr<QuotationRateTypeEnum>(
                           new QuotationRateTypeEnum(quotationRateTypeNode));

       }
   protected: 
       boost::shared_ptr<SettlementRateSource> settlementRateSource;
       boost::shared_ptr<QuotationRateTypeEnum> quotationRateType;
};
#endif

