// Underlyer.hpp 
#ifndef FpmlSerialized_Underlyer_hpp
#define FpmlSerialized_Underlyer_hpp

#include <ISerialized.hpp>
#include <fpml-asset-5-4/SingleUnderlyer.hpp>
#include <fpml-asset-5-4/Basket.hpp>

namespace FpmlSerialized {

class Underlyer : public ISerialized { 
   public: 
       Underlyer(TiXmlNode* xmlNode);

       bool isSingleUnderlyer(){return this->singleUnderlyerIsNull_;}
       boost::shared_ptr<SingleUnderlyer> getSingleUnderlyer();
      std::string getSingleUnderlyerIDRef(){return singleUnderlyerIDRef_;}

       bool isBasket(){return this->basketIsNull_;}
       boost::shared_ptr<Basket> getBasket();
      std::string getBasketIDRef(){return basketIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!singleUnderlyerIsNull_){
                count += 1;
                str = "singleUnderlyer" ;
           }
           if(!basketIsNull_){
                count += 1;
                str = "basket" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<SingleUnderlyer> singleUnderlyer_;     //choice
       std::string singleUnderlyerIDRef_;
       bool singleUnderlyerIsNull_;
         boost::shared_ptr<Basket> basket_;     //choice
       std::string basketIDRef_;
       bool basketIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

