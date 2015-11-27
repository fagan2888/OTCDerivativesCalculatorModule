// ReturnSwapBase.hpp 
#ifndef FpmlSerialized_ReturnSwapBase_hpp
#define FpmlSerialized_ReturnSwapBase_hpp

#include <fpml-shared-5-4/Product.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <fpml-shared-5-4/AccountReference.hpp>
#include <fpml-eq-shared-5-4/DirectionalLeg.hpp>
#include <fpml-eq-shared-5-4/InterestLeg.hpp>
#include <fpml-eq-shared-5-4/ReturnLeg.hpp>
#include <fpml-eq-shared-5-4/PrincipalExchangeFeatures.hpp>

namespace FpmlSerialized {

class ReturnSwapBase : public Product { 
   public: 
       ReturnSwapBase(TiXmlNode* xmlNode);

       bool isBuyerPartyReference(){return this->buyerPartyReferenceIsNull_;}
       boost::shared_ptr<PartyReference> getBuyerPartyReference();
      std::string getBuyerPartyReferenceIDRef(){return buyerPartyReferenceIDRef_;}

       bool isBuyerAccountReference(){return this->buyerAccountReferenceIsNull_;}
       boost::shared_ptr<AccountReference> getBuyerAccountReference();
      std::string getBuyerAccountReferenceIDRef(){return buyerAccountReferenceIDRef_;}

       bool isSellerPartyReference(){return this->sellerPartyReferenceIsNull_;}
       boost::shared_ptr<PartyReference> getSellerPartyReference();
      std::string getSellerPartyReferenceIDRef(){return sellerPartyReferenceIDRef_;}

       bool isSellerAccountReference(){return this->sellerAccountReferenceIsNull_;}
       boost::shared_ptr<AccountReference> getSellerAccountReference();
      std::string getSellerAccountReferenceIDRef(){return sellerAccountReferenceIDRef_;}

       bool isReturnSwapLeg(){return this->returnSwapLegIsNull_;}
       boost::shared_ptr<DirectionalLeg> getReturnSwapLeg();
      std::string getReturnSwapLegIDRef(){return returnSwapLegIDRef_;}

       bool isInterestLeg(){return this->interestLegIsNull_;}
       boost::shared_ptr<InterestLeg> getInterestLeg();
      std::string getInterestLegIDRef(){return interestLegIDRef_;}

       bool isReturnLeg(){return this->returnLegIsNull_;}
       boost::shared_ptr<ReturnLeg> getReturnLeg();
      std::string getReturnLegIDRef(){return returnLegIDRef_;}

       bool isPrincipalExchangeFeatures(){return this->principalExchangeFeaturesIsNull_;}
       boost::shared_ptr<PrincipalExchangeFeatures> getPrincipalExchangeFeatures();
      std::string getPrincipalExchangeFeaturesIDRef(){return principalExchangeFeaturesIDRef_;}

   protected: 
       boost::shared_ptr<PartyReference> buyerPartyReference_;
       std::string buyerPartyReferenceIDRef_;
       bool buyerPartyReferenceIsNull_;
       boost::shared_ptr<AccountReference> buyerAccountReference_;
       std::string buyerAccountReferenceIDRef_;
       bool buyerAccountReferenceIsNull_;
       boost::shared_ptr<PartyReference> sellerPartyReference_;
       std::string sellerPartyReferenceIDRef_;
       bool sellerPartyReferenceIsNull_;
       boost::shared_ptr<AccountReference> sellerAccountReference_;
       std::string sellerAccountReferenceIDRef_;
       bool sellerAccountReferenceIsNull_;
       boost::shared_ptr<DirectionalLeg> returnSwapLeg_;
       std::string returnSwapLegIDRef_;
       bool returnSwapLegIsNull_;
       boost::shared_ptr<InterestLeg> interestLeg_;     //substitude 
       std::string interestLegIDRef_;
       bool interestLegIsNull_;
       boost::shared_ptr<ReturnLeg> returnLeg_;     //substitude 
       std::string returnLegIDRef_;
       bool returnLegIsNull_;
       boost::shared_ptr<PrincipalExchangeFeatures> principalExchangeFeatures_;
       std::string principalExchangeFeaturesIDRef_;
       bool principalExchangeFeaturesIsNull_;

};

} //namespaceFpmlSerialized end
#endif

