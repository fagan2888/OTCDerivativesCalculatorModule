// Trade.hpp 
#ifndef FpmlSerialized_Trade_hpp
#define FpmlSerialized_Trade_hpp

#include <ISerialized.hpp>
#include <fpml-doc-5-4/TradeHeader.hpp>
#include <fpml-shared-5-4/Product.hpp>
#include <example-extension-5-4/ForwardSale.hpp>
#include <fpml-bond-option-5-4/BondOption.hpp>
#include <fpml-cd-5-4/CreditDefaultSwap.hpp>
#include <fpml-cd-5-4/CreditDefaultSwapOption.hpp>
#include <fpml-com-5-4/CommodityForward.hpp>
#include <fpml-com-5-4/CommodityOption.hpp>
#include <fpml-com-5-4/CommoditySwap.hpp>
#include <fpml-com-5-4/CommoditySwaption.hpp>
#include <fpml-correlation-swaps-5-4/CorrelationSwap.hpp>
#include <fpml-dividend-swaps-5-4/DividendSwapOptionTransactionSupplement.hpp>
#include <fpml-dividend-swaps-5-4/DividendSwapTransactionSupplement.hpp>
#include <fpml-doc-5-4/InstrumentTradeDetails.hpp>
#include <fpml-doc-5-4/Strategy.hpp>
#include <fpml-eq-shared-5-4/ReturnSwap.hpp>
#include <fpml-eqd-5-4/BrokerEquityOption.hpp>
#include <fpml-eqd-5-4/EquityForward.hpp>
#include <fpml-eqd-5-4/EquityOption.hpp>
#include <fpml-eqd-5-4/EquityOptionTransactionSupplement.hpp>
#include <fpml-fx-5-4/FxSingleLeg.hpp>
#include <fpml-fx-5-4/FxSwap.hpp>
#include <fpml-fx-5-4/FxOption.hpp>
#include <fpml-fx-5-4/FxDigitalOption.hpp>
#include <fpml-fx-5-4/TermDeposit.hpp>
#include <fpml-generic-5-4/GenericProduct.hpp>
#include <fpml-ird-5-4/BulletPayment.hpp>
#include <fpml-ird-5-4/CapFloor.hpp>
#include <fpml-ird-5-4/Fra.hpp>
#include <fpml-ird-5-4/Swap.hpp>
#include <fpml-ird-5-4/Swaption.hpp>
#include <fpml-return-swaps-5-4/EquitySwapTransactionSupplement.hpp>
#include <fpml-standard-5-4/StandardProduct.hpp>
#include <fpml-variance-swaps-5-4/VarianceOptionTransactionSupplement.hpp>
#include <fpml-variance-swaps-5-4/VarianceSwap.hpp>
#include <fpml-variance-swaps-5-4/VarianceSwapTransactionSupplement.hpp>
#include <fpml-shared-5-4/Payment.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <fpml-shared-5-4/CalculationAgent.hpp>
#include <fpml-shared-5-4/BusinessCenter.hpp>
#include <fpml-doc-5-4/Collateral.hpp>
#include <fpml-shared-5-4/Documentation.hpp>
#include <fpml-shared-5-4/GoverningLaw.hpp>
#include <fpml-doc-5-4/Allocations.hpp>

namespace FpmlSerialized {

class Trade : public ISerialized { 
   public: 
       Trade(TiXmlNode* xmlNode);

       bool isTradeHeader(){return this->tradeHeaderIsNull_;}
       boost::shared_ptr<TradeHeader> getTradeHeader();
      std::string getTradeHeaderIDRef(){return tradeHeaderIDRef_;}

       bool isProduct(){return this->productIsNull_;}
       boost::shared_ptr<Product> getProduct();
      std::string getProductIDRef(){return productIDRef_;}

       bool isForward(){return this->forwardIsNull_;}
       boost::shared_ptr<ForwardSale> getForward();
      std::string getForwardIDRef(){return forwardIDRef_;}

       bool isBondOption(){return this->bondOptionIsNull_;}
       boost::shared_ptr<BondOption> getBondOption();
      std::string getBondOptionIDRef(){return bondOptionIDRef_;}

       bool isCreditDefaultSwap(){return this->creditDefaultSwapIsNull_;}
       boost::shared_ptr<CreditDefaultSwap> getCreditDefaultSwap();
      std::string getCreditDefaultSwapIDRef(){return creditDefaultSwapIDRef_;}

       bool isCreditDefaultSwapOption(){return this->creditDefaultSwapOptionIsNull_;}
       boost::shared_ptr<CreditDefaultSwapOption> getCreditDefaultSwapOption();
      std::string getCreditDefaultSwapOptionIDRef(){return creditDefaultSwapOptionIDRef_;}

       bool isCommodityForward(){return this->commodityForwardIsNull_;}
       boost::shared_ptr<CommodityForward> getCommodityForward();
      std::string getCommodityForwardIDRef(){return commodityForwardIDRef_;}

       bool isCommodityOption(){return this->commodityOptionIsNull_;}
       boost::shared_ptr<CommodityOption> getCommodityOption();
      std::string getCommodityOptionIDRef(){return commodityOptionIDRef_;}

       bool isCommoditySwap(){return this->commoditySwapIsNull_;}
       boost::shared_ptr<CommoditySwap> getCommoditySwap();
      std::string getCommoditySwapIDRef(){return commoditySwapIDRef_;}

       bool isCommoditySwaption(){return this->commoditySwaptionIsNull_;}
       boost::shared_ptr<CommoditySwaption> getCommoditySwaption();
      std::string getCommoditySwaptionIDRef(){return commoditySwaptionIDRef_;}

       bool isCorrelationSwap(){return this->correlationSwapIsNull_;}
       boost::shared_ptr<CorrelationSwap> getCorrelationSwap();
      std::string getCorrelationSwapIDRef(){return correlationSwapIDRef_;}

       bool isDividendSwapOptionTransactionSupplement(){return this->dividendSwapOptionTransactionSupplementIsNull_;}
       boost::shared_ptr<DividendSwapOptionTransactionSupplement> getDividendSwapOptionTransactionSupplement();
      std::string getDividendSwapOptionTransactionSupplementIDRef(){return dividendSwapOptionTransactionSupplementIDRef_;}

       bool isDividendSwapTransactionSupplement(){return this->dividendSwapTransactionSupplementIsNull_;}
       boost::shared_ptr<DividendSwapTransactionSupplement> getDividendSwapTransactionSupplement();
      std::string getDividendSwapTransactionSupplementIDRef(){return dividendSwapTransactionSupplementIDRef_;}

       bool isInstrumentTradeDetails(){return this->instrumentTradeDetailsIsNull_;}
       boost::shared_ptr<InstrumentTradeDetails> getInstrumentTradeDetails();
      std::string getInstrumentTradeDetailsIDRef(){return instrumentTradeDetailsIDRef_;}

       bool isStrategy(){return this->strategyIsNull_;}
       boost::shared_ptr<Strategy> getStrategy();
      std::string getStrategyIDRef(){return strategyIDRef_;}

       bool isReturnSwap(){return this->returnSwapIsNull_;}
       boost::shared_ptr<ReturnSwap> getReturnSwap();
      std::string getReturnSwapIDRef(){return returnSwapIDRef_;}

       bool isBrokerEquityOption(){return this->brokerEquityOptionIsNull_;}
       boost::shared_ptr<BrokerEquityOption> getBrokerEquityOption();
      std::string getBrokerEquityOptionIDRef(){return brokerEquityOptionIDRef_;}

       bool isEquityForward(){return this->equityForwardIsNull_;}
       boost::shared_ptr<EquityForward> getEquityForward();
      std::string getEquityForwardIDRef(){return equityForwardIDRef_;}

       bool isEquityOption(){return this->equityOptionIsNull_;}
       boost::shared_ptr<EquityOption> getEquityOption();
      std::string getEquityOptionIDRef(){return equityOptionIDRef_;}

       bool isEquityOptionTransactionSupplement(){return this->equityOptionTransactionSupplementIsNull_;}
       boost::shared_ptr<EquityOptionTransactionSupplement> getEquityOptionTransactionSupplement();
      std::string getEquityOptionTransactionSupplementIDRef(){return equityOptionTransactionSupplementIDRef_;}

       bool isFxSingleLeg(){return this->fxSingleLegIsNull_;}
       boost::shared_ptr<FxSingleLeg> getFxSingleLeg();
      std::string getFxSingleLegIDRef(){return fxSingleLegIDRef_;}

       bool isFxSwap(){return this->fxSwapIsNull_;}
       boost::shared_ptr<FxSwap> getFxSwap();
      std::string getFxSwapIDRef(){return fxSwapIDRef_;}

       bool isFxOption(){return this->fxOptionIsNull_;}
       boost::shared_ptr<FxOption> getFxOption();
      std::string getFxOptionIDRef(){return fxOptionIDRef_;}

       bool isFxDigitalOption(){return this->fxDigitalOptionIsNull_;}
       boost::shared_ptr<FxDigitalOption> getFxDigitalOption();
      std::string getFxDigitalOptionIDRef(){return fxDigitalOptionIDRef_;}

       bool isTermDeposit(){return this->termDepositIsNull_;}
       boost::shared_ptr<TermDeposit> getTermDeposit();
      std::string getTermDepositIDRef(){return termDepositIDRef_;}

       bool isGenericProduct(){return this->genericProductIsNull_;}
       boost::shared_ptr<GenericProduct> getGenericProduct();
      std::string getGenericProductIDRef(){return genericProductIDRef_;}

       bool isNonSchemaProduct(){return this->nonSchemaProductIsNull_;}
       boost::shared_ptr<GenericProduct> getNonSchemaProduct();
      std::string getNonSchemaProductIDRef(){return nonSchemaProductIDRef_;}

       bool isBulletPayment(){return this->bulletPaymentIsNull_;}
       boost::shared_ptr<BulletPayment> getBulletPayment();
      std::string getBulletPaymentIDRef(){return bulletPaymentIDRef_;}

       bool isCapFloor(){return this->capFloorIsNull_;}
       boost::shared_ptr<CapFloor> getCapFloor();
      std::string getCapFloorIDRef(){return capFloorIDRef_;}

       bool isFra(){return this->fraIsNull_;}
       boost::shared_ptr<Fra> getFra();
      std::string getFraIDRef(){return fraIDRef_;}

       bool isSwap(){return this->swapIsNull_;}
       boost::shared_ptr<Swap> getSwap();
      std::string getSwapIDRef(){return swapIDRef_;}

       bool isSwaption(){return this->swaptionIsNull_;}
       boost::shared_ptr<Swaption> getSwaption();
      std::string getSwaptionIDRef(){return swaptionIDRef_;}

       bool isEquitySwapTransactionSupplement(){return this->equitySwapTransactionSupplementIsNull_;}
       boost::shared_ptr<EquitySwapTransactionSupplement> getEquitySwapTransactionSupplement();
      std::string getEquitySwapTransactionSupplementIDRef(){return equitySwapTransactionSupplementIDRef_;}

       bool isStandardProduct(){return this->standardProductIsNull_;}
       boost::shared_ptr<StandardProduct> getStandardProduct();
      std::string getStandardProductIDRef(){return standardProductIDRef_;}

       bool isVarianceOptionTransactionSupplement(){return this->varianceOptionTransactionSupplementIsNull_;}
       boost::shared_ptr<VarianceOptionTransactionSupplement> getVarianceOptionTransactionSupplement();
      std::string getVarianceOptionTransactionSupplementIDRef(){return varianceOptionTransactionSupplementIDRef_;}

       bool isVarianceSwap(){return this->varianceSwapIsNull_;}
       boost::shared_ptr<VarianceSwap> getVarianceSwap();
      std::string getVarianceSwapIDRef(){return varianceSwapIDRef_;}

       bool isVarianceSwapTransactionSupplement(){return this->varianceSwapTransactionSupplementIsNull_;}
       boost::shared_ptr<VarianceSwapTransactionSupplement> getVarianceSwapTransactionSupplement();
      std::string getVarianceSwapTransactionSupplementIDRef(){return varianceSwapTransactionSupplementIDRef_;}

       bool isOtherPartyPayment(){return this->otherPartyPaymentIsNull_;}
       std::vector<boost::shared_ptr<Payment>> getOtherPartyPayment();
      std::string getOtherPartyPaymentIDRef(){return otherPartyPaymentIDRef_;}

       bool isBrokerPartyReference(){return this->brokerPartyReferenceIsNull_;}
       std::vector<boost::shared_ptr<PartyReference>> getBrokerPartyReference();
      std::string getBrokerPartyReferenceIDRef(){return brokerPartyReferenceIDRef_;}

       bool isCalculationAgent(){return this->calculationAgentIsNull_;}
       boost::shared_ptr<CalculationAgent> getCalculationAgent();
      std::string getCalculationAgentIDRef(){return calculationAgentIDRef_;}

       bool isCalculationAgentBusinessCenter(){return this->calculationAgentBusinessCenterIsNull_;}
       boost::shared_ptr<BusinessCenter> getCalculationAgentBusinessCenter();
      std::string getCalculationAgentBusinessCenterIDRef(){return calculationAgentBusinessCenterIDRef_;}

       bool isDeterminingParty(){return this->determiningPartyIsNull_;}
       std::vector<boost::shared_ptr<PartyReference>> getDeterminingParty();
      std::string getDeterminingPartyIDRef(){return determiningPartyIDRef_;}

       bool isHedgingParty(){return this->hedgingPartyIsNull_;}
       std::vector<boost::shared_ptr<PartyReference>> getHedgingParty();
      std::string getHedgingPartyIDRef(){return hedgingPartyIDRef_;}

       bool isCollateral(){return this->collateralIsNull_;}
       boost::shared_ptr<Collateral> getCollateral();
      std::string getCollateralIDRef(){return collateralIDRef_;}

       bool isDocumentation(){return this->documentationIsNull_;}
       boost::shared_ptr<Documentation> getDocumentation();
      std::string getDocumentationIDRef(){return documentationIDRef_;}

       bool isGoverningLaw(){return this->governingLawIsNull_;}
       boost::shared_ptr<GoverningLaw> getGoverningLaw();
      std::string getGoverningLawIDRef(){return governingLawIDRef_;}

       bool isAllocations(){return this->allocationsIsNull_;}
       boost::shared_ptr<Allocations> getAllocations();
      std::string getAllocationsIDRef(){return allocationsIDRef_;}

   protected: 
       boost::shared_ptr<TradeHeader> tradeHeader_;
       std::string tradeHeaderIDRef_;
       bool tradeHeaderIsNull_;
       boost::shared_ptr<Product> product_;
       std::string productIDRef_;
       bool productIsNull_;
       boost::shared_ptr<ForwardSale> forward_;     //substitude 
       std::string forwardIDRef_;
       bool forwardIsNull_;
       boost::shared_ptr<BondOption> bondOption_;     //substitude 
       std::string bondOptionIDRef_;
       bool bondOptionIsNull_;
       boost::shared_ptr<CreditDefaultSwap> creditDefaultSwap_;     //substitude 
       std::string creditDefaultSwapIDRef_;
       bool creditDefaultSwapIsNull_;
       boost::shared_ptr<CreditDefaultSwapOption> creditDefaultSwapOption_;     //substitude 
       std::string creditDefaultSwapOptionIDRef_;
       bool creditDefaultSwapOptionIsNull_;
       boost::shared_ptr<CommodityForward> commodityForward_;     //substitude 
       std::string commodityForwardIDRef_;
       bool commodityForwardIsNull_;
       boost::shared_ptr<CommodityOption> commodityOption_;     //substitude 
       std::string commodityOptionIDRef_;
       bool commodityOptionIsNull_;
       boost::shared_ptr<CommoditySwap> commoditySwap_;     //substitude 
       std::string commoditySwapIDRef_;
       bool commoditySwapIsNull_;
       boost::shared_ptr<CommoditySwaption> commoditySwaption_;     //substitude 
       std::string commoditySwaptionIDRef_;
       bool commoditySwaptionIsNull_;
       boost::shared_ptr<CorrelationSwap> correlationSwap_;     //substitude 
       std::string correlationSwapIDRef_;
       bool correlationSwapIsNull_;
       boost::shared_ptr<DividendSwapOptionTransactionSupplement> dividendSwapOptionTransactionSupplement_;     //substitude 
       std::string dividendSwapOptionTransactionSupplementIDRef_;
       bool dividendSwapOptionTransactionSupplementIsNull_;
       boost::shared_ptr<DividendSwapTransactionSupplement> dividendSwapTransactionSupplement_;     //substitude 
       std::string dividendSwapTransactionSupplementIDRef_;
       bool dividendSwapTransactionSupplementIsNull_;
       boost::shared_ptr<InstrumentTradeDetails> instrumentTradeDetails_;     //substitude 
       std::string instrumentTradeDetailsIDRef_;
       bool instrumentTradeDetailsIsNull_;
       boost::shared_ptr<Strategy> strategy_;     //substitude 
       std::string strategyIDRef_;
       bool strategyIsNull_;
       boost::shared_ptr<ReturnSwap> returnSwap_;     //substitude 
       std::string returnSwapIDRef_;
       bool returnSwapIsNull_;
       boost::shared_ptr<BrokerEquityOption> brokerEquityOption_;     //substitude 
       std::string brokerEquityOptionIDRef_;
       bool brokerEquityOptionIsNull_;
       boost::shared_ptr<EquityForward> equityForward_;     //substitude 
       std::string equityForwardIDRef_;
       bool equityForwardIsNull_;
       boost::shared_ptr<EquityOption> equityOption_;     //substitude 
       std::string equityOptionIDRef_;
       bool equityOptionIsNull_;
       boost::shared_ptr<EquityOptionTransactionSupplement> equityOptionTransactionSupplement_;     //substitude 
       std::string equityOptionTransactionSupplementIDRef_;
       bool equityOptionTransactionSupplementIsNull_;
       boost::shared_ptr<FxSingleLeg> fxSingleLeg_;     //substitude 
       std::string fxSingleLegIDRef_;
       bool fxSingleLegIsNull_;
       boost::shared_ptr<FxSwap> fxSwap_;     //substitude 
       std::string fxSwapIDRef_;
       bool fxSwapIsNull_;
       boost::shared_ptr<FxOption> fxOption_;     //substitude 
       std::string fxOptionIDRef_;
       bool fxOptionIsNull_;
       boost::shared_ptr<FxDigitalOption> fxDigitalOption_;     //substitude 
       std::string fxDigitalOptionIDRef_;
       bool fxDigitalOptionIsNull_;
       boost::shared_ptr<TermDeposit> termDeposit_;     //substitude 
       std::string termDepositIDRef_;
       bool termDepositIsNull_;
       boost::shared_ptr<GenericProduct> genericProduct_;     //substitude 
       std::string genericProductIDRef_;
       bool genericProductIsNull_;
       boost::shared_ptr<GenericProduct> nonSchemaProduct_;     //substitude 
       std::string nonSchemaProductIDRef_;
       bool nonSchemaProductIsNull_;
       boost::shared_ptr<BulletPayment> bulletPayment_;     //substitude 
       std::string bulletPaymentIDRef_;
       bool bulletPaymentIsNull_;
       boost::shared_ptr<CapFloor> capFloor_;     //substitude 
       std::string capFloorIDRef_;
       bool capFloorIsNull_;
       boost::shared_ptr<Fra> fra_;     //substitude 
       std::string fraIDRef_;
       bool fraIsNull_;
       boost::shared_ptr<Swap> swap_;     //substitude 
       std::string swapIDRef_;
       bool swapIsNull_;
       boost::shared_ptr<Swaption> swaption_;     //substitude 
       std::string swaptionIDRef_;
       bool swaptionIsNull_;
       boost::shared_ptr<EquitySwapTransactionSupplement> equitySwapTransactionSupplement_;     //substitude 
       std::string equitySwapTransactionSupplementIDRef_;
       bool equitySwapTransactionSupplementIsNull_;
       boost::shared_ptr<StandardProduct> standardProduct_;     //substitude 
       std::string standardProductIDRef_;
       bool standardProductIsNull_;
       boost::shared_ptr<VarianceOptionTransactionSupplement> varianceOptionTransactionSupplement_;     //substitude 
       std::string varianceOptionTransactionSupplementIDRef_;
       bool varianceOptionTransactionSupplementIsNull_;
       boost::shared_ptr<VarianceSwap> varianceSwap_;     //substitude 
       std::string varianceSwapIDRef_;
       bool varianceSwapIsNull_;
       boost::shared_ptr<VarianceSwapTransactionSupplement> varianceSwapTransactionSupplement_;     //substitude 
       std::string varianceSwapTransactionSupplementIDRef_;
       bool varianceSwapTransactionSupplementIsNull_;
       std::vector<boost::shared_ptr<Payment>> otherPartyPayment_;
       std::string otherPartyPaymentIDRef_;
       bool otherPartyPaymentIsNull_;
       std::vector<boost::shared_ptr<PartyReference>> brokerPartyReference_;
       std::string brokerPartyReferenceIDRef_;
       bool brokerPartyReferenceIsNull_;
       boost::shared_ptr<CalculationAgent> calculationAgent_;
       std::string calculationAgentIDRef_;
       bool calculationAgentIsNull_;
       boost::shared_ptr<BusinessCenter> calculationAgentBusinessCenter_;
       std::string calculationAgentBusinessCenterIDRef_;
       bool calculationAgentBusinessCenterIsNull_;
       std::vector<boost::shared_ptr<PartyReference>> determiningParty_;
       std::string determiningPartyIDRef_;
       bool determiningPartyIsNull_;
       std::vector<boost::shared_ptr<PartyReference>> hedgingParty_;
       std::string hedgingPartyIDRef_;
       bool hedgingPartyIsNull_;
       boost::shared_ptr<Collateral> collateral_;
       std::string collateralIDRef_;
       bool collateralIsNull_;
       boost::shared_ptr<Documentation> documentation_;
       std::string documentationIDRef_;
       bool documentationIsNull_;
       boost::shared_ptr<GoverningLaw> governingLaw_;
       std::string governingLawIDRef_;
       bool governingLawIsNull_;
       boost::shared_ptr<Allocations> allocations_;
       std::string allocationsIDRef_;
       bool allocationsIsNull_;

};

} //namespaceFpmlSerialized end
#endif

