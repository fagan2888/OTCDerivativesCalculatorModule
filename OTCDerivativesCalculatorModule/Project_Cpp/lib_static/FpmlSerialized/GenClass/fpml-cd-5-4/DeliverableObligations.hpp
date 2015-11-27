// DeliverableObligations.hpp 
#ifndef FpmlSerialized_DeliverableObligations_hpp
#define FpmlSerialized_DeliverableObligations_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-enum-5-4/ObligationCategoryEnum.hpp>
#include <fpml-cd-5-4/SpecifiedCurrency.hpp>
#include <fpml-cd-5-4/NotDomesticCurrency.hpp>
#include <fpml-cd-5-4/PCDeliverableObligationCharac.hpp>
#include <fpml-cd-5-4/LoanParticipation.hpp>
#include <fpml-shared-5-4/Period.hpp>
#include <built_in_type/XsdTypeString.hpp>

namespace FpmlSerialized {

class DeliverableObligations : public ISerialized { 
   public: 
       DeliverableObligations(TiXmlNode* xmlNode);

       bool isAccruedInterest(){return this->accruedInterestIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getAccruedInterest();
      std::string getAccruedInterestIDRef(){return accruedInterestIDRef_;}

       bool isCategory(){return this->categoryIsNull_;}
       boost::shared_ptr<ObligationCategoryEnum> getCategory();
      std::string getCategoryIDRef(){return categoryIDRef_;}

       bool isNotSubordinated(){return this->notSubordinatedIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getNotSubordinated();
      std::string getNotSubordinatedIDRef(){return notSubordinatedIDRef_;}

       bool isSpecifiedCurrency(){return this->specifiedCurrencyIsNull_;}
       boost::shared_ptr<SpecifiedCurrency> getSpecifiedCurrency();
      std::string getSpecifiedCurrencyIDRef(){return specifiedCurrencyIDRef_;}

       bool isNotSovereignLender(){return this->notSovereignLenderIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getNotSovereignLender();
      std::string getNotSovereignLenderIDRef(){return notSovereignLenderIDRef_;}

       bool isNotDomesticCurrency(){return this->notDomesticCurrencyIsNull_;}
       boost::shared_ptr<NotDomesticCurrency> getNotDomesticCurrency();
      std::string getNotDomesticCurrencyIDRef(){return notDomesticCurrencyIDRef_;}

       bool isNotDomesticLaw(){return this->notDomesticLawIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getNotDomesticLaw();
      std::string getNotDomesticLawIDRef(){return notDomesticLawIDRef_;}

       bool isListed(){return this->listedIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getListed();
      std::string getListedIDRef(){return listedIDRef_;}

       bool isNotContingent(){return this->notContingentIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getNotContingent();
      std::string getNotContingentIDRef(){return notContingentIDRef_;}

       bool isNotDomesticIssuance(){return this->notDomesticIssuanceIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getNotDomesticIssuance();
      std::string getNotDomesticIssuanceIDRef(){return notDomesticIssuanceIDRef_;}

       bool isAssignableLoan(){return this->assignableLoanIsNull_;}
       boost::shared_ptr<PCDeliverableObligationCharac> getAssignableLoan();
      std::string getAssignableLoanIDRef(){return assignableLoanIDRef_;}

       bool isConsentRequiredLoan(){return this->consentRequiredLoanIsNull_;}
       boost::shared_ptr<PCDeliverableObligationCharac> getConsentRequiredLoan();
      std::string getConsentRequiredLoanIDRef(){return consentRequiredLoanIDRef_;}

       bool isDirectLoanParticipation(){return this->directLoanParticipationIsNull_;}
       boost::shared_ptr<LoanParticipation> getDirectLoanParticipation();
      std::string getDirectLoanParticipationIDRef(){return directLoanParticipationIDRef_;}

       bool isTransferable(){return this->transferableIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getTransferable();
      std::string getTransferableIDRef(){return transferableIDRef_;}

       bool isMaximumMaturity(){return this->maximumMaturityIsNull_;}
       boost::shared_ptr<Period> getMaximumMaturity();
      std::string getMaximumMaturityIDRef(){return maximumMaturityIDRef_;}

       bool isAcceleratedOrMatured(){return this->acceleratedOrMaturedIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getAcceleratedOrMatured();
      std::string getAcceleratedOrMaturedIDRef(){return acceleratedOrMaturedIDRef_;}

       bool isNotBearer(){return this->notBearerIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getNotBearer();
      std::string getNotBearerIDRef(){return notBearerIDRef_;}

       bool isFullFaithAndCreditObLiability(){return this->fullFaithAndCreditObLiabilityIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getFullFaithAndCreditObLiability();
      std::string getFullFaithAndCreditObLiabilityIDRef(){return fullFaithAndCreditObLiabilityIDRef_;}

       bool isGeneralFundObligationLiability(){return this->generalFundObligationLiabilityIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getGeneralFundObligationLiability();
      std::string getGeneralFundObligationLiabilityIDRef(){return generalFundObligationLiabilityIDRef_;}

       bool isRevenueObligationLiability(){return this->revenueObligationLiabilityIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getRevenueObligationLiability();
      std::string getRevenueObligationLiabilityIDRef(){return revenueObligationLiabilityIDRef_;}

       bool isIndirectLoanParticipation(){return this->indirectLoanParticipationIsNull_;}
       boost::shared_ptr<LoanParticipation> getIndirectLoanParticipation();
      std::string getIndirectLoanParticipationIDRef(){return indirectLoanParticipationIDRef_;}

       bool isExcluded(){return this->excludedIsNull_;}
       boost::shared_ptr<XsdTypeString> getExcluded();
      std::string getExcludedIDRef(){return excludedIDRef_;}

       bool isOthReferenceEntityObligations(){return this->othReferenceEntityObligationsIsNull_;}
       boost::shared_ptr<XsdTypeString> getOthReferenceEntityObligations();
      std::string getOthReferenceEntityObligationsIDRef(){return othReferenceEntityObligationsIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!fullFaithAndCreditObLiabilityIsNull_){
                count += 1;
                str = "fullFaithAndCreditObLiability" ;
           }
           if(!generalFundObligationLiabilityIsNull_){
                count += 1;
                str = "generalFundObligationLiability" ;
           }
           if(!revenueObligationLiabilityIsNull_){
                count += 1;
                str = "revenueObligationLiability" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<XsdTypeBoolean> accruedInterest_;
       std::string accruedInterestIDRef_;
       bool accruedInterestIsNull_;
       boost::shared_ptr<ObligationCategoryEnum> category_;
       std::string categoryIDRef_;
       bool categoryIsNull_;
       boost::shared_ptr<XsdTypeBoolean> notSubordinated_;
       std::string notSubordinatedIDRef_;
       bool notSubordinatedIsNull_;
       boost::shared_ptr<SpecifiedCurrency> specifiedCurrency_;
       std::string specifiedCurrencyIDRef_;
       bool specifiedCurrencyIsNull_;
       boost::shared_ptr<XsdTypeBoolean> notSovereignLender_;
       std::string notSovereignLenderIDRef_;
       bool notSovereignLenderIsNull_;
       boost::shared_ptr<NotDomesticCurrency> notDomesticCurrency_;
       std::string notDomesticCurrencyIDRef_;
       bool notDomesticCurrencyIsNull_;
       boost::shared_ptr<XsdTypeBoolean> notDomesticLaw_;
       std::string notDomesticLawIDRef_;
       bool notDomesticLawIsNull_;
       boost::shared_ptr<XsdTypeBoolean> listed_;
       std::string listedIDRef_;
       bool listedIsNull_;
       boost::shared_ptr<XsdTypeBoolean> notContingent_;
       std::string notContingentIDRef_;
       bool notContingentIsNull_;
       boost::shared_ptr<XsdTypeBoolean> notDomesticIssuance_;
       std::string notDomesticIssuanceIDRef_;
       bool notDomesticIssuanceIsNull_;
       boost::shared_ptr<PCDeliverableObligationCharac> assignableLoan_;
       std::string assignableLoanIDRef_;
       bool assignableLoanIsNull_;
       boost::shared_ptr<PCDeliverableObligationCharac> consentRequiredLoan_;
       std::string consentRequiredLoanIDRef_;
       bool consentRequiredLoanIsNull_;
       boost::shared_ptr<LoanParticipation> directLoanParticipation_;
       std::string directLoanParticipationIDRef_;
       bool directLoanParticipationIsNull_;
       boost::shared_ptr<XsdTypeBoolean> transferable_;
       std::string transferableIDRef_;
       bool transferableIsNull_;
       boost::shared_ptr<Period> maximumMaturity_;
       std::string maximumMaturityIDRef_;
       bool maximumMaturityIsNull_;
       boost::shared_ptr<XsdTypeBoolean> acceleratedOrMatured_;
       std::string acceleratedOrMaturedIDRef_;
       bool acceleratedOrMaturedIsNull_;
       boost::shared_ptr<XsdTypeBoolean> notBearer_;
       std::string notBearerIDRef_;
       bool notBearerIsNull_;
         boost::shared_ptr<XsdTypeBoolean> fullFaithAndCreditObLiability_;     //choice
       std::string fullFaithAndCreditObLiabilityIDRef_;
       bool fullFaithAndCreditObLiabilityIsNull_;
         boost::shared_ptr<XsdTypeBoolean> generalFundObligationLiability_;     //choice
       std::string generalFundObligationLiabilityIDRef_;
       bool generalFundObligationLiabilityIsNull_;
         boost::shared_ptr<XsdTypeBoolean> revenueObligationLiability_;     //choice
       std::string revenueObligationLiabilityIDRef_;
       bool revenueObligationLiabilityIsNull_;
       boost::shared_ptr<LoanParticipation> indirectLoanParticipation_;
       std::string indirectLoanParticipationIDRef_;
       bool indirectLoanParticipationIsNull_;
       boost::shared_ptr<XsdTypeString> excluded_;
       std::string excludedIDRef_;
       bool excludedIsNull_;
       boost::shared_ptr<XsdTypeString> othReferenceEntityObligations_;
       std::string othReferenceEntityObligationsIDRef_;
       bool othReferenceEntityObligationsIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

