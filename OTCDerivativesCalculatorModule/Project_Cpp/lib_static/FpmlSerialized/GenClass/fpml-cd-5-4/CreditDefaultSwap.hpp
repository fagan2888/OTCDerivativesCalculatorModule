// CreditDefaultSwap.hpp 
#ifndef FpmlSerialized_CreditDefaultSwap_hpp
#define FpmlSerialized_CreditDefaultSwap_hpp

#include <fpml-shared-5-4/Product.hpp>
#include <fpml-cd-5-4/GeneralTerms.hpp>
#include <fpml-cd-5-4/FeeLeg.hpp>
#include <fpml-cd-5-4/ProtectionTerms.hpp>
#include <fpml-cd-5-4/CashSettlementTerms.hpp>
#include <fpml-cd-5-4/PhysicalSettlementTerms.hpp>

namespace FpmlSerialized {

class CreditDefaultSwap : public Product { 
   public: 
       CreditDefaultSwap(TiXmlNode* xmlNode);

       bool isGeneralTerms(){return this->generalTermsIsNull_;}
       boost::shared_ptr<GeneralTerms> getGeneralTerms();
      std::string getGeneralTermsIDRef(){return generalTermsIDRef_;}

       bool isFeeLeg(){return this->feeLegIsNull_;}
       boost::shared_ptr<FeeLeg> getFeeLeg();
      std::string getFeeLegIDRef(){return feeLegIDRef_;}

       bool isProtectionTerms(){return this->protectionTermsIsNull_;}
       std::vector<boost::shared_ptr<ProtectionTerms>> getProtectionTerms();
      std::string getProtectionTermsIDRef(){return protectionTermsIDRef_;}

       bool isCashSettlementTerms(){return this->cashSettlementTermsIsNull_;}
       boost::shared_ptr<CashSettlementTerms> getCashSettlementTerms();
      std::string getCashSettlementTermsIDRef(){return cashSettlementTermsIDRef_;}

       bool isPhysicalSettlementTerms(){return this->physicalSettlementTermsIsNull_;}
       boost::shared_ptr<PhysicalSettlementTerms> getPhysicalSettlementTerms();
      std::string getPhysicalSettlementTermsIDRef(){return physicalSettlementTermsIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!cashSettlementTermsIsNull_){
                count += 1;
                str = "cashSettlementTerms" ;
           }
           if(!physicalSettlementTermsIsNull_){
                count += 1;
                str = "physicalSettlementTerms" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<GeneralTerms> generalTerms_;
       std::string generalTermsIDRef_;
       bool generalTermsIsNull_;
       boost::shared_ptr<FeeLeg> feeLeg_;
       std::string feeLegIDRef_;
       bool feeLegIsNull_;
       std::vector<boost::shared_ptr<ProtectionTerms>> protectionTerms_;
       std::string protectionTermsIDRef_;
       bool protectionTermsIsNull_;
         boost::shared_ptr<CashSettlementTerms> cashSettlementTerms_;     //choice
       std::string cashSettlementTermsIDRef_;
       bool cashSettlementTermsIsNull_;
         boost::shared_ptr<PhysicalSettlementTerms> physicalSettlementTerms_;     //choice
       std::string physicalSettlementTermsIDRef_;
       bool physicalSettlementTermsIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

