// FxConversion.hpp 
#ifndef FpmlSerialized_FxConversion_hpp
#define FpmlSerialized_FxConversion_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/AmountReference.hpp>
#include <fpml-shared-5-4/FxRate.hpp>

namespace FpmlSerialized {

class FxConversion : public ISerialized { 
   public: 
       FxConversion(TiXmlNode* xmlNode);

       bool isAmountRelativeTo(){return this->amountRelativeToIsNull_;}
       boost::shared_ptr<AmountReference> getAmountRelativeTo();
      std::string getAmountRelativeToIDRef(){return amountRelativeToIDRef_;}

       bool isFxRate(){return this->fxRateIsNull_;}
       std::vector<boost::shared_ptr<FxRate>> getFxRate();
      std::string getFxRateIDRef(){return fxRateIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!amountRelativeToIsNull_){
                count += 1;
                str = "amountRelativeTo" ;
           }
           if(!fxRateIsNull_){
                count += 1;
                str = "fxRate" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<AmountReference> amountRelativeTo_;     //choice
       std::string amountRelativeToIDRef_;
       bool amountRelativeToIsNull_;
         std::vector<boost::shared_ptr<FxRate>> fxRate_;     //choice
       std::string fxRateIDRef_;
       bool fxRateIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

