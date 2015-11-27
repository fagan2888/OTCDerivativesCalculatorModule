// FxOptionFeatures.hpp 
#ifndef FpmlSerialized_FxOptionFeatures_hpp
#define FpmlSerialized_FxOptionFeatures_hpp

#include <ISerialized.hpp>
#include <fpml-fx-5-4/FxAsianFeature.hpp>
#include <fpml-fx-5-4/FxBarrierFeature.hpp>

namespace FpmlSerialized {

class FxOptionFeatures : public ISerialized { 
   public: 
       FxOptionFeatures(TiXmlNode* xmlNode);

       bool isAsian(){return this->asianIsNull_;}
       boost::shared_ptr<FxAsianFeature> getAsian();
      std::string getAsianIDRef(){return asianIDRef_;}

       bool isBarrier(){return this->barrierIsNull_;}
       std::vector<boost::shared_ptr<FxBarrierFeature>> getBarrier();
      std::string getBarrierIDRef(){return barrierIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!asianIsNull_){
                count += 1;
                str = "asian" ;
           }
           if(!barrierIsNull_){
                count += 1;
                str = "barrier" ;
           }
           if(!barrierIsNull_){
                count += 1;
                str = "barrier" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<FxAsianFeature> asian_;     //choice
       std::string asianIDRef_;
       bool asianIsNull_;
         std::vector<boost::shared_ptr<FxBarrierFeature>> barrier_;     //choice
       std::string barrierIDRef_;
       bool barrierIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

