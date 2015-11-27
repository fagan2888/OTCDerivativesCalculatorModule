// GasProduct.hpp 
#ifndef FpmlSerialized_GasProduct_hpp
#define FpmlSerialized_GasProduct_hpp

#include <ISerialized.hpp>
#include <fpml-enum-5-4/GasProductTypeEnum.hpp>
#include <fpml-shared-5-4/NonNegativeDecimal.hpp>
#include <fpml-com-5-4/GasQuality.hpp>

namespace FpmlSerialized {

class GasProduct : public ISerialized { 
   public: 
       GasProduct(TiXmlNode* xmlNode);

       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<GasProductTypeEnum> getType();
      std::string getTypeIDRef(){return typeIDRef_;}

       bool isCalorificValue(){return this->calorificValueIsNull_;}
       boost::shared_ptr<NonNegativeDecimal> getCalorificValue();
      std::string getCalorificValueIDRef(){return calorificValueIDRef_;}

       bool isQuality(){return this->qualityIsNull_;}
       boost::shared_ptr<GasQuality> getQuality();
      std::string getQualityIDRef(){return qualityIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!calorificValueIsNull_){
                count += 1;
                str = "calorificValue" ;
           }
           if(!qualityIsNull_){
                count += 1;
                str = "quality" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<GasProductTypeEnum> type_;
       std::string typeIDRef_;
       bool typeIsNull_;
         boost::shared_ptr<NonNegativeDecimal> calorificValue_;     //choice
       std::string calorificValueIDRef_;
       bool calorificValueIsNull_;
         boost::shared_ptr<GasQuality> quality_;     //choice
       std::string qualityIDRef_;
       bool qualityIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

