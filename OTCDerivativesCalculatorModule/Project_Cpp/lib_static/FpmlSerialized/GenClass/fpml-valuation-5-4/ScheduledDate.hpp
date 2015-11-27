// ScheduledDate.hpp 
#ifndef FpmlSerialized_ScheduledDate_hpp
#define FpmlSerialized_ScheduledDate_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <fpml-valuation-5-4/ScheduledDateType.hpp>
#include <fpml-asset-5-4/AnyAssetReference.hpp>
#include <fpml-valuation-5-4/AssetValuation.hpp>
#include <fpml-riskdef-5-4/ValuationReference.hpp>

namespace FpmlSerialized {

class ScheduledDate : public ISerialized { 
   public: 
       ScheduledDate(TiXmlNode* xmlNode);

       bool isUnadjustedDate(){return this->unadjustedDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getUnadjustedDate();
      std::string getUnadjustedDateIDRef(){return unadjustedDateIDRef_;}

       bool isAdjustedDate(){return this->adjustedDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getAdjustedDate();
      std::string getAdjustedDateIDRef(){return adjustedDateIDRef_;}

       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<ScheduledDateType> getType();
      std::string getTypeIDRef(){return typeIDRef_;}

       bool isAssetReference(){return this->assetReferenceIsNull_;}
       boost::shared_ptr<AnyAssetReference> getAssetReference();
      std::string getAssetReferenceIDRef(){return assetReferenceIDRef_;}

       bool isAssociatedValue(){return this->associatedValueIsNull_;}
       boost::shared_ptr<AssetValuation> getAssociatedValue();
      std::string getAssociatedValueIDRef(){return associatedValueIDRef_;}

       bool isAssociatedValueReference(){return this->associatedValueReferenceIsNull_;}
       boost::shared_ptr<ValuationReference> getAssociatedValueReference();
      std::string getAssociatedValueReferenceIDRef(){return associatedValueReferenceIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!unadjustedDateIsNull_){
                count += 1;
                str = "unadjustedDate" ;
           }
           if(!adjustedDateIsNull_){
                count += 1;
                str = "adjustedDate" ;
           }
           if(!adjustedDateIsNull_){
                count += 1;
                str = "adjustedDate" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
       std::string getChoiceStr_1(){
           std::string str;
           int count = 0;
           if(!associatedValueIsNull_){
                count += 1;
                str = "associatedValue" ;
           }
           if(!associatedValueReferenceIsNull_){
                count += 1;
                str = "associatedValueReference" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_1_ = str ;
           return choiceStr_1_;
       }
   protected: 
         boost::shared_ptr<XsdTypeDate> unadjustedDate_;     //choice
       std::string unadjustedDateIDRef_;
       bool unadjustedDateIsNull_;
         boost::shared_ptr<XsdTypeDate> adjustedDate_;     //choice
       std::string adjustedDateIDRef_;
       bool adjustedDateIsNull_;
       boost::shared_ptr<ScheduledDateType> type_;
       std::string typeIDRef_;
       bool typeIsNull_;
       boost::shared_ptr<AnyAssetReference> assetReference_;
       std::string assetReferenceIDRef_;
       bool assetReferenceIsNull_;
         boost::shared_ptr<AssetValuation> associatedValue_;     //choice
       std::string associatedValueIDRef_;
       bool associatedValueIsNull_;
         boost::shared_ptr<ValuationReference> associatedValueReference_;     //choice
       std::string associatedValueReferenceIDRef_;
       bool associatedValueReferenceIsNull_;

       //choiceStr 
       std::string choiceStr_0_;
       std::string choiceStr_1_;

};

} //namespaceFpmlSerialized end
#endif

