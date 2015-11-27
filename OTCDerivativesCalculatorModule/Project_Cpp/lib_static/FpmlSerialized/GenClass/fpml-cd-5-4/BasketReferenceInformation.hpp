// BasketReferenceInformation.hpp 
#ifndef FpmlSerialized_BasketReferenceInformation_hpp
#define FpmlSerialized_BasketReferenceInformation_hpp

#include <ISerialized.hpp>
#include <fpml-asset-5-4/BasketName.hpp>
#include <fpml-asset-5-4/BasketId.hpp>
#include <fpml-cd-5-4/ReferencePool.hpp>
#include <built_in_type/XsdTypePositiveInteger.hpp>
#include <fpml-cd-5-4/Tranche.hpp>

namespace FpmlSerialized {

class BasketReferenceInformation : public ISerialized { 
   public: 
       BasketReferenceInformation(TiXmlNode* xmlNode);

       bool isBasketName(){return this->basketNameIsNull_;}
       boost::shared_ptr<BasketName> getBasketName();
      std::string getBasketNameIDRef(){return basketNameIDRef_;}

       bool isBasketId(){return this->basketIdIsNull_;}
       std::vector<boost::shared_ptr<BasketId>> getBasketId();
      std::string getBasketIdIDRef(){return basketIdIDRef_;}

       bool isReferencePool(){return this->referencePoolIsNull_;}
       boost::shared_ptr<ReferencePool> getReferencePool();
      std::string getReferencePoolIDRef(){return referencePoolIDRef_;}

       bool isNthToDefault(){return this->nthToDefaultIsNull_;}
       boost::shared_ptr<XsdTypePositiveInteger> getNthToDefault();
      std::string getNthToDefaultIDRef(){return nthToDefaultIDRef_;}

       bool isMthToDefault(){return this->mthToDefaultIsNull_;}
       boost::shared_ptr<XsdTypePositiveInteger> getMthToDefault();
      std::string getMthToDefaultIDRef(){return mthToDefaultIDRef_;}

       bool isTranche(){return this->trancheIsNull_;}
       boost::shared_ptr<Tranche> getTranche();
      std::string getTrancheIDRef(){return trancheIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!basketNameIsNull_){
                count += 1;
                str = "basketName" ;
           }
           if(!basketIdIsNull_){
                count += 1;
                str = "basketId" ;
           }
           if(!basketIdIsNull_){
                count += 1;
                str = "basketId" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
       std::string getChoiceStr_1(){
           std::string str;
           int count = 0;
           if(!nthToDefaultIsNull_){
                count += 1;
                str = "nthToDefault" ;
           }
           if(!mthToDefaultIsNull_){
                count += 1;
                str = "mthToDefault" ;
           }
           if(!trancheIsNull_){
                count += 1;
                str = "tranche" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_1_ = str ;
           return choiceStr_1_;
       }
   protected: 
         boost::shared_ptr<BasketName> basketName_;     //choice
       std::string basketNameIDRef_;
       bool basketNameIsNull_;
         std::vector<boost::shared_ptr<BasketId>> basketId_;     //choice
       std::string basketIdIDRef_;
       bool basketIdIsNull_;
       boost::shared_ptr<ReferencePool> referencePool_;
       std::string referencePoolIDRef_;
       bool referencePoolIsNull_;
         boost::shared_ptr<XsdTypePositiveInteger> nthToDefault_;     //choice
       std::string nthToDefaultIDRef_;
       bool nthToDefaultIsNull_;
         boost::shared_ptr<XsdTypePositiveInteger> mthToDefault_;     //choice
       std::string mthToDefaultIDRef_;
       bool mthToDefaultIsNull_;
         boost::shared_ptr<Tranche> tranche_;     //choice
       std::string trancheIDRef_;
       bool trancheIsNull_;

       //choiceStr 
       std::string choiceStr_0_;
       std::string choiceStr_1_;

};

} //namespaceFpmlSerialized end
#endif

