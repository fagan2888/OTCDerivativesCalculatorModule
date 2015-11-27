// Obligations.hpp 
#ifndef FpmlSerialized_Obligations_hpp
#define FpmlSerialized_Obligations_hpp

#include <ISerialized.hpp>
#include <fpml-enum-5-4/ObligationCategoryEnum.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-cd-5-4/SpecifiedCurrency.hpp>
#include <fpml-cd-5-4/NotDomesticCurrency.hpp>
#include <built_in_type/XsdTypeString.hpp>
#include <fpml-asset-5-4/Lien.hpp>

namespace FpmlSerialized {

class Obligations : public ISerialized { 
   public: 
       Obligations(TiXmlNode* xmlNode);

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

       bool isNotDomesticIssuance(){return this->notDomesticIssuanceIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getNotDomesticIssuance();
      std::string getNotDomesticIssuanceIDRef(){return notDomesticIssuanceIDRef_;}

       bool isFullFaithAndCreditObLiability(){return this->fullFaithAndCreditObLiabilityIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getFullFaithAndCreditObLiability();
      std::string getFullFaithAndCreditObLiabilityIDRef(){return fullFaithAndCreditObLiabilityIDRef_;}

       bool isGeneralFundObligationLiability(){return this->generalFundObligationLiabilityIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getGeneralFundObligationLiability();
      std::string getGeneralFundObligationLiabilityIDRef(){return generalFundObligationLiabilityIDRef_;}

       bool isRevenueObligationLiability(){return this->revenueObligationLiabilityIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getRevenueObligationLiability();
      std::string getRevenueObligationLiabilityIDRef(){return revenueObligationLiabilityIDRef_;}

       bool isNotContingent(){return this->notContingentIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getNotContingent();
      std::string getNotContingentIDRef(){return notContingentIDRef_;}

       bool isExcluded(){return this->excludedIsNull_;}
       boost::shared_ptr<XsdTypeString> getExcluded();
      std::string getExcludedIDRef(){return excludedIDRef_;}

       bool isOthReferenceEntityObligations(){return this->othReferenceEntityObligationsIsNull_;}
       boost::shared_ptr<XsdTypeString> getOthReferenceEntityObligations();
      std::string getOthReferenceEntityObligationsIDRef(){return othReferenceEntityObligationsIDRef_;}

       bool isDesignatedPriority(){return this->designatedPriorityIsNull_;}
       boost::shared_ptr<Lien> getDesignatedPriority();
      std::string getDesignatedPriorityIDRef(){return designatedPriorityIDRef_;}

       bool isCashSettlementOnly(){return this->cashSettlementOnlyIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getCashSettlementOnly();
      std::string getCashSettlementOnlyIDRef(){return cashSettlementOnlyIDRef_;}

       bool isDeliveryOfCommitments(){return this->deliveryOfCommitmentsIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getDeliveryOfCommitments();
      std::string getDeliveryOfCommitmentsIDRef(){return deliveryOfCommitmentsIDRef_;}

       bool isContinuity(){return this->continuityIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getContinuity();
      std::string getContinuityIDRef(){return continuityIDRef_;}

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
       boost::shared_ptr<XsdTypeBoolean> notDomesticIssuance_;
       std::string notDomesticIssuanceIDRef_;
       bool notDomesticIssuanceIsNull_;
         boost::shared_ptr<XsdTypeBoolean> fullFaithAndCreditObLiability_;     //choice
       std::string fullFaithAndCreditObLiabilityIDRef_;
       bool fullFaithAndCreditObLiabilityIsNull_;
         boost::shared_ptr<XsdTypeBoolean> generalFundObligationLiability_;     //choice
       std::string generalFundObligationLiabilityIDRef_;
       bool generalFundObligationLiabilityIsNull_;
         boost::shared_ptr<XsdTypeBoolean> revenueObligationLiability_;     //choice
       std::string revenueObligationLiabilityIDRef_;
       bool revenueObligationLiabilityIsNull_;
       boost::shared_ptr<XsdTypeBoolean> notContingent_;
       std::string notContingentIDRef_;
       bool notContingentIsNull_;
       boost::shared_ptr<XsdTypeString> excluded_;
       std::string excludedIDRef_;
       bool excludedIsNull_;
       boost::shared_ptr<XsdTypeString> othReferenceEntityObligations_;
       std::string othReferenceEntityObligationsIDRef_;
       bool othReferenceEntityObligationsIsNull_;
       boost::shared_ptr<Lien> designatedPriority_;
       std::string designatedPriorityIDRef_;
       bool designatedPriorityIsNull_;
       boost::shared_ptr<XsdTypeBoolean> cashSettlementOnly_;
       std::string cashSettlementOnlyIDRef_;
       bool cashSettlementOnlyIsNull_;
       boost::shared_ptr<XsdTypeBoolean> deliveryOfCommitments_;
       std::string deliveryOfCommitmentsIDRef_;
       bool deliveryOfCommitmentsIsNull_;
       boost::shared_ptr<XsdTypeBoolean> continuity_;
       std::string continuityIDRef_;
       bool continuityIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

