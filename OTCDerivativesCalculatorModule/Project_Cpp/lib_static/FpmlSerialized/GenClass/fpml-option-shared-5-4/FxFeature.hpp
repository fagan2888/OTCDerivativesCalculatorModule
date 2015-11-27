// FxFeature.hpp 
#ifndef FpmlSerialized_FxFeature_hpp
#define FpmlSerialized_FxFeature_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/IdentifiedCurrency.hpp>
#include <fpml-option-shared-5-4/Composite.hpp>
#include <fpml-option-shared-5-4/Quanto.hpp>

namespace FpmlSerialized {

class FxFeature : public ISerialized { 
   public: 
       FxFeature(TiXmlNode* xmlNode);

       bool isReferenceCurrency(){return this->referenceCurrencyIsNull_;}
       boost::shared_ptr<IdentifiedCurrency> getReferenceCurrency();
      std::string getReferenceCurrencyIDRef(){return referenceCurrencyIDRef_;}

       bool isComposite(){return this->compositeIsNull_;}
       boost::shared_ptr<Composite> getComposite();
      std::string getCompositeIDRef(){return compositeIDRef_;}

       bool isQuanto(){return this->quantoIsNull_;}
       boost::shared_ptr<Quanto> getQuanto();
      std::string getQuantoIDRef(){return quantoIDRef_;}

       bool isCrossCurrency(){return this->crossCurrencyIsNull_;}
       boost::shared_ptr<Composite> getCrossCurrency();
      std::string getCrossCurrencyIDRef(){return crossCurrencyIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!compositeIsNull_){
                count += 1;
                str = "composite" ;
           }
           if(!quantoIsNull_){
                count += 1;
                str = "quanto" ;
           }
           if(!crossCurrencyIsNull_){
                count += 1;
                str = "crossCurrency" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<IdentifiedCurrency> referenceCurrency_;
       std::string referenceCurrencyIDRef_;
       bool referenceCurrencyIsNull_;
         boost::shared_ptr<Composite> composite_;     //choice
       std::string compositeIDRef_;
       bool compositeIsNull_;
         boost::shared_ptr<Quanto> quanto_;     //choice
       std::string quantoIDRef_;
       bool quantoIsNull_;
         boost::shared_ptr<Composite> crossCurrency_;     //choice
       std::string crossCurrencyIDRef_;
       bool crossCurrencyIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

