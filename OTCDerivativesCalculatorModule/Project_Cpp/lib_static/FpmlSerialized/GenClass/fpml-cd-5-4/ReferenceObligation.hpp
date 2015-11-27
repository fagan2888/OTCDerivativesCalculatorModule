// ReferenceObligation.hpp 
#ifndef FpmlSerialized_ReferenceObligation_hpp
#define FpmlSerialized_ReferenceObligation_hpp

#include <ISerialized.hpp>
#include <fpml-asset-5-4/Bond.hpp>
#include <fpml-asset-5-4/ConvertibleBond.hpp>
#include <fpml-asset-5-4/Mortgage.hpp>
#include <fpml-asset-5-4/Loan.hpp>
#include <fpml-shared-5-4/LegalEntity.hpp>
#include <fpml-shared-5-4/LegalEntityReference.hpp>

namespace FpmlSerialized {

class ReferenceObligation : public ISerialized { 
   public: 
       ReferenceObligation(TiXmlNode* xmlNode);

       bool isBond(){return this->bondIsNull_;}
       boost::shared_ptr<Bond> getBond();
      std::string getBondIDRef(){return bondIDRef_;}

       bool isConvertibleBond(){return this->convertibleBondIsNull_;}
       boost::shared_ptr<ConvertibleBond> getConvertibleBond();
      std::string getConvertibleBondIDRef(){return convertibleBondIDRef_;}

       bool isMortgage(){return this->mortgageIsNull_;}
       boost::shared_ptr<Mortgage> getMortgage();
      std::string getMortgageIDRef(){return mortgageIDRef_;}

       bool isLoan(){return this->loanIsNull_;}
       boost::shared_ptr<Loan> getLoan();
      std::string getLoanIDRef(){return loanIDRef_;}

       bool isPrimaryObligor(){return this->primaryObligorIsNull_;}
       boost::shared_ptr<LegalEntity> getPrimaryObligor();
      std::string getPrimaryObligorIDRef(){return primaryObligorIDRef_;}

       bool isPrimaryObligorReference(){return this->primaryObligorReferenceIsNull_;}
       boost::shared_ptr<LegalEntityReference> getPrimaryObligorReference();
      std::string getPrimaryObligorReferenceIDRef(){return primaryObligorReferenceIDRef_;}

       bool isGuarantor(){return this->guarantorIsNull_;}
       boost::shared_ptr<LegalEntity> getGuarantor();
      std::string getGuarantorIDRef(){return guarantorIDRef_;}

       bool isGuarantorReference(){return this->guarantorReferenceIsNull_;}
       boost::shared_ptr<LegalEntityReference> getGuarantorReference();
      std::string getGuarantorReferenceIDRef(){return guarantorReferenceIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!bondIsNull_){
                count += 1;
                str = "bond" ;
           }
           if(!convertibleBondIsNull_){
                count += 1;
                str = "convertibleBond" ;
           }
           if(!mortgageIsNull_){
                count += 1;
                str = "mortgage" ;
           }
           if(!loanIsNull_){
                count += 1;
                str = "loan" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
       std::string getChoiceStr_1(){
           std::string str;
           int count = 0;
           if(!primaryObligorIsNull_){
                count += 1;
                str = "primaryObligor" ;
           }
           if(!primaryObligorReferenceIsNull_){
                count += 1;
                str = "primaryObligorReference" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_1_ = str ;
           return choiceStr_1_;
       }
       std::string getChoiceStr_2(){
           std::string str;
           int count = 0;
           if(!guarantorIsNull_){
                count += 1;
                str = "guarantor" ;
           }
           if(!guarantorReferenceIsNull_){
                count += 1;
                str = "guarantorReference" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_2_ = str ;
           return choiceStr_2_;
       }
   protected: 
         boost::shared_ptr<Bond> bond_;     //choice
       std::string bondIDRef_;
       bool bondIsNull_;
         boost::shared_ptr<ConvertibleBond> convertibleBond_;     //choice
       std::string convertibleBondIDRef_;
       bool convertibleBondIsNull_;
         boost::shared_ptr<Mortgage> mortgage_;     //choice
       std::string mortgageIDRef_;
       bool mortgageIsNull_;
         boost::shared_ptr<Loan> loan_;     //choice
       std::string loanIDRef_;
       bool loanIsNull_;
         boost::shared_ptr<LegalEntity> primaryObligor_;     //choice
       std::string primaryObligorIDRef_;
       bool primaryObligorIsNull_;
         boost::shared_ptr<LegalEntityReference> primaryObligorReference_;     //choice
       std::string primaryObligorReferenceIDRef_;
       bool primaryObligorReferenceIsNull_;
         boost::shared_ptr<LegalEntity> guarantor_;     //choice
       std::string guarantorIDRef_;
       bool guarantorIsNull_;
         boost::shared_ptr<LegalEntityReference> guarantorReference_;     //choice
       std::string guarantorReferenceIDRef_;
       bool guarantorReferenceIsNull_;

       //choiceStr 
       std::string choiceStr_0_;
       std::string choiceStr_1_;
       std::string choiceStr_2_;

};

} //namespaceFpmlSerialized end
#endif

