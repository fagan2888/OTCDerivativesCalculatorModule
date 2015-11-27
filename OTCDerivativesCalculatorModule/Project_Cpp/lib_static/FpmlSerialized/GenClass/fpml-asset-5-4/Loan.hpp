// Loan.hpp 
#ifndef FpmlSerialized_Loan_hpp
#define FpmlSerialized_Loan_hpp

#include <fpml-asset-5-4/UnderlyingAsset.hpp>
#include <fpml-shared-5-4/LegalEntity.hpp>
#include <fpml-shared-5-4/LegalEntityReference.hpp>
#include <fpml-asset-5-4/Lien.hpp>
#include <fpml-asset-5-4/FacilityType.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <fpml-asset-5-4/UnderlyingAssetTranche.hpp>

namespace FpmlSerialized {

class Loan : public UnderlyingAsset { 
   public: 
       Loan(TiXmlNode* xmlNode);

       bool isBorrower(){return this->borrowerIsNull_;}
       boost::shared_ptr<LegalEntity> getBorrower();
      std::string getBorrowerIDRef(){return borrowerIDRef_;}

       bool isBorrowerReference(){return this->borrowerReferenceIsNull_;}
       boost::shared_ptr<LegalEntityReference> getBorrowerReference();
      std::string getBorrowerReferenceIDRef(){return borrowerReferenceIDRef_;}

       bool isLien(){return this->lienIsNull_;}
       boost::shared_ptr<Lien> getLien();
      std::string getLienIDRef(){return lienIDRef_;}

       bool isFacilityType(){return this->facilityTypeIsNull_;}
       boost::shared_ptr<FacilityType> getFacilityType();
      std::string getFacilityTypeIDRef(){return facilityTypeIDRef_;}

       bool isMaturity(){return this->maturityIsNull_;}
       boost::shared_ptr<XsdTypeDate> getMaturity();
      std::string getMaturityIDRef(){return maturityIDRef_;}

       bool isCreditAgreementDate(){return this->creditAgreementDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getCreditAgreementDate();
      std::string getCreditAgreementDateIDRef(){return creditAgreementDateIDRef_;}

       bool isTranche(){return this->trancheIsNull_;}
       boost::shared_ptr<UnderlyingAssetTranche> getTranche();
      std::string getTrancheIDRef(){return trancheIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!borrowerIsNull_){
                count += 1;
                str = "borrower" ;
           }
           if(!borrowerReferenceIsNull_){
                count += 1;
                str = "borrowerReference" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<LegalEntity> borrower_;     //choice
       std::string borrowerIDRef_;
       bool borrowerIsNull_;
         boost::shared_ptr<LegalEntityReference> borrowerReference_;     //choice
       std::string borrowerReferenceIDRef_;
       bool borrowerReferenceIsNull_;
       boost::shared_ptr<Lien> lien_;
       std::string lienIDRef_;
       bool lienIsNull_;
       boost::shared_ptr<FacilityType> facilityType_;
       std::string facilityTypeIDRef_;
       bool facilityTypeIsNull_;
       boost::shared_ptr<XsdTypeDate> maturity_;
       std::string maturityIDRef_;
       bool maturityIsNull_;
       boost::shared_ptr<XsdTypeDate> creditAgreementDate_;
       std::string creditAgreementDateIDRef_;
       bool creditAgreementDateIsNull_;
       boost::shared_ptr<UnderlyingAssetTranche> tranche_;
       std::string trancheIDRef_;
       bool trancheIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

