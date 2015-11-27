// AdditionalDisruptionEvents.hpp 
#ifndef FpmlSerialized_AdditionalDisruptionEvents_hpp
#define FpmlSerialized_AdditionalDisruptionEvents_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-shared-5-4/RestrictedPercentage.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>

namespace FpmlSerialized {

class AdditionalDisruptionEvents : public ISerialized { 
   public: 
       AdditionalDisruptionEvents(TiXmlNode* xmlNode);

       bool isChangeInLaw(){return this->changeInLawIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getChangeInLaw();
      std::string getChangeInLawIDRef(){return changeInLawIDRef_;}

       bool isFailureToDeliver(){return this->failureToDeliverIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getFailureToDeliver();
      std::string getFailureToDeliverIDRef(){return failureToDeliverIDRef_;}

       bool isInsolvencyFiling(){return this->insolvencyFilingIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getInsolvencyFiling();
      std::string getInsolvencyFilingIDRef(){return insolvencyFilingIDRef_;}

       bool isHedgingDisruption(){return this->hedgingDisruptionIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getHedgingDisruption();
      std::string getHedgingDisruptionIDRef(){return hedgingDisruptionIDRef_;}

       bool isLossOfStockBorrow(){return this->lossOfStockBorrowIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getLossOfStockBorrow();
      std::string getLossOfStockBorrowIDRef(){return lossOfStockBorrowIDRef_;}

       bool isMaximumStockLoanRate(){return this->maximumStockLoanRateIsNull_;}
       boost::shared_ptr<RestrictedPercentage> getMaximumStockLoanRate();
      std::string getMaximumStockLoanRateIDRef(){return maximumStockLoanRateIDRef_;}

       bool isIncreasedCostOfStockBorrow(){return this->increasedCostOfStockBorrowIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getIncreasedCostOfStockBorrow();
      std::string getIncreasedCostOfStockBorrowIDRef(){return increasedCostOfStockBorrowIDRef_;}

       bool isInitialStockLoanRate(){return this->initialStockLoanRateIsNull_;}
       boost::shared_ptr<RestrictedPercentage> getInitialStockLoanRate();
      std::string getInitialStockLoanRateIDRef(){return initialStockLoanRateIDRef_;}

       bool isIncreasedCostOfHedging(){return this->increasedCostOfHedgingIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getIncreasedCostOfHedging();
      std::string getIncreasedCostOfHedgingIDRef(){return increasedCostOfHedgingIDRef_;}

       bool isDeterminingPartyReference(){return this->determiningPartyReferenceIsNull_;}
       boost::shared_ptr<PartyReference> getDeterminingPartyReference();
      std::string getDeterminingPartyReferenceIDRef(){return determiningPartyReferenceIDRef_;}

       bool isForeignOwnershipEvent(){return this->foreignOwnershipEventIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getForeignOwnershipEvent();
      std::string getForeignOwnershipEventIDRef(){return foreignOwnershipEventIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeBoolean> changeInLaw_;
       std::string changeInLawIDRef_;
       bool changeInLawIsNull_;
       boost::shared_ptr<XsdTypeBoolean> failureToDeliver_;
       std::string failureToDeliverIDRef_;
       bool failureToDeliverIsNull_;
       boost::shared_ptr<XsdTypeBoolean> insolvencyFiling_;
       std::string insolvencyFilingIDRef_;
       bool insolvencyFilingIsNull_;
       boost::shared_ptr<XsdTypeBoolean> hedgingDisruption_;
       std::string hedgingDisruptionIDRef_;
       bool hedgingDisruptionIsNull_;
       boost::shared_ptr<XsdTypeBoolean> lossOfStockBorrow_;
       std::string lossOfStockBorrowIDRef_;
       bool lossOfStockBorrowIsNull_;
       boost::shared_ptr<RestrictedPercentage> maximumStockLoanRate_;
       std::string maximumStockLoanRateIDRef_;
       bool maximumStockLoanRateIsNull_;
       boost::shared_ptr<XsdTypeBoolean> increasedCostOfStockBorrow_;
       std::string increasedCostOfStockBorrowIDRef_;
       bool increasedCostOfStockBorrowIsNull_;
       boost::shared_ptr<RestrictedPercentage> initialStockLoanRate_;
       std::string initialStockLoanRateIDRef_;
       bool initialStockLoanRateIsNull_;
       boost::shared_ptr<XsdTypeBoolean> increasedCostOfHedging_;
       std::string increasedCostOfHedgingIDRef_;
       bool increasedCostOfHedgingIsNull_;
       boost::shared_ptr<PartyReference> determiningPartyReference_;
       std::string determiningPartyReferenceIDRef_;
       bool determiningPartyReferenceIsNull_;
       boost::shared_ptr<XsdTypeBoolean> foreignOwnershipEvent_;
       std::string foreignOwnershipEventIDRef_;
       bool foreignOwnershipEventIsNull_;

};

} //namespaceFpmlSerialized end
#endif

