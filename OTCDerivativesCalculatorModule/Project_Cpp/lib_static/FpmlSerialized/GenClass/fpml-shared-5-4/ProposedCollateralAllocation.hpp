// ProposedCollateralAllocation.hpp 
#ifndef FpmlSerialized_ProposedCollateralAllocation_hpp
#define FpmlSerialized_ProposedCollateralAllocation_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <fpml-shared-5-4/AccountReference.hpp>
#include <fpml-shared-5-4/CollateralValueAllocation.hpp>

namespace FpmlSerialized {

class ProposedCollateralAllocation : public ISerialized { 
   public: 
       ProposedCollateralAllocation(TiXmlNode* xmlNode);

       bool isAllocationPartyReference(){return this->allocationPartyReferenceIsNull_;}
       boost::shared_ptr<PartyReference> getAllocationPartyReference();
      std::string getAllocationPartyReferenceIDRef(){return allocationPartyReferenceIDRef_;}

       bool isAllocationAccountReference(){return this->allocationAccountReferenceIsNull_;}
       boost::shared_ptr<AccountReference> getAllocationAccountReference();
      std::string getAllocationAccountReferenceIDRef(){return allocationAccountReferenceIDRef_;}

       bool isCollateralValueAllocation(){return this->collateralValueAllocationIsNull_;}
       boost::shared_ptr<CollateralValueAllocation> getCollateralValueAllocation();
      std::string getCollateralValueAllocationIDRef(){return collateralValueAllocationIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!collateralValueAllocationIsNull_){
                count += 1;
                str = "collateralValueAllocation" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<PartyReference> allocationPartyReference_;
       std::string allocationPartyReferenceIDRef_;
       bool allocationPartyReferenceIsNull_;
       boost::shared_ptr<AccountReference> allocationAccountReference_;
       std::string allocationAccountReferenceIDRef_;
       bool allocationAccountReferenceIsNull_;
         boost::shared_ptr<CollateralValueAllocation> collateralValueAllocation_;     //choice
       std::string collateralValueAllocationIDRef_;
       bool collateralValueAllocationIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

