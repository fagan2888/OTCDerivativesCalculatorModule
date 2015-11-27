// Premium.hpp 
#ifndef FpmlSerialized_Premium_hpp
#define FpmlSerialized_Premium_hpp

#include <fpml-shared-5-4/SimplePayment.hpp>
#include <fpml-enum-5-4/PremiumTypeEnum.hpp>
#include <fpml-shared-5-4/Money.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>

namespace FpmlSerialized {

class Premium : public SimplePayment { 
   public: 
       Premium(TiXmlNode* xmlNode);

       bool isPremiumType(){return this->premiumTypeIsNull_;}
       boost::shared_ptr<PremiumTypeEnum> getPremiumType();
      std::string getPremiumTypeIDRef(){return premiumTypeIDRef_;}

       bool isPricePerOption(){return this->pricePerOptionIsNull_;}
       boost::shared_ptr<Money> getPricePerOption();
      std::string getPricePerOptionIDRef(){return pricePerOptionIDRef_;}

       bool isPercentageOfNotional(){return this->percentageOfNotionalIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getPercentageOfNotional();
      std::string getPercentageOfNotionalIDRef(){return percentageOfNotionalIDRef_;}

       bool isDiscountFactor(){return this->discountFactorIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getDiscountFactor();
      std::string getDiscountFactorIDRef(){return discountFactorIDRef_;}

       bool isPresentValueAmount(){return this->presentValueAmountIsNull_;}
       boost::shared_ptr<Money> getPresentValueAmount();
      std::string getPresentValueAmountIDRef(){return presentValueAmountIDRef_;}

   protected: 
       boost::shared_ptr<PremiumTypeEnum> premiumType_;
       std::string premiumTypeIDRef_;
       bool premiumTypeIsNull_;
       boost::shared_ptr<Money> pricePerOption_;
       std::string pricePerOptionIDRef_;
       bool pricePerOptionIsNull_;
       boost::shared_ptr<XsdTypeDecimal> percentageOfNotional_;
       std::string percentageOfNotionalIDRef_;
       bool percentageOfNotionalIsNull_;
       boost::shared_ptr<XsdTypeDecimal> discountFactor_;
       std::string discountFactorIDRef_;
       bool discountFactorIsNull_;
       boost::shared_ptr<Money> presentValueAmount_;
       std::string presentValueAmountIDRef_;
       bool presentValueAmountIsNull_;

};

} //namespaceFpmlSerialized end
#endif

