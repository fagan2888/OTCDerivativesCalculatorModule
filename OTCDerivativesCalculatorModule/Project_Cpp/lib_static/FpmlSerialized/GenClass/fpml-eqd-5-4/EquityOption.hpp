// EquityOption.hpp 
#ifndef FpmlSerialized_EquityOption_hpp
#define FpmlSerialized_EquityOption_hpp

#include <fpml-eqd-5-4/EquityDerivativeLongFormBase.hpp>
#include <fpml-eq-shared-5-4/EquityStrike.hpp>
#include <fpml-shared-5-4/NonNegativeDecimal.hpp>
#include <fpml-shared-5-4/PositiveDecimal.hpp>
#include <fpml-eq-shared-5-4/EquityPremium.hpp>

namespace FpmlSerialized {

class EquityOption : public EquityDerivativeLongFormBase { 
   public: 
       EquityOption(TiXmlNode* xmlNode);

       bool isStrike(){return this->strikeIsNull_;}
       boost::shared_ptr<EquityStrike> getStrike();
      std::string getStrikeIDRef(){return strikeIDRef_;}

       bool isSpotPrice(){return this->spotPriceIsNull_;}
       boost::shared_ptr<NonNegativeDecimal> getSpotPrice();
      std::string getSpotPriceIDRef(){return spotPriceIDRef_;}

       bool isNumberOfOptions(){return this->numberOfOptionsIsNull_;}
       boost::shared_ptr<NonNegativeDecimal> getNumberOfOptions();
      std::string getNumberOfOptionsIDRef(){return numberOfOptionsIDRef_;}

       bool isOptionEntitlement(){return this->optionEntitlementIsNull_;}
       boost::shared_ptr<PositiveDecimal> getOptionEntitlement();
      std::string getOptionEntitlementIDRef(){return optionEntitlementIDRef_;}

       bool isEquityPremium(){return this->equityPremiumIsNull_;}
       boost::shared_ptr<EquityPremium> getEquityPremium();
      std::string getEquityPremiumIDRef(){return equityPremiumIDRef_;}

   protected: 
       boost::shared_ptr<EquityStrike> strike_;
       std::string strikeIDRef_;
       bool strikeIsNull_;
       boost::shared_ptr<NonNegativeDecimal> spotPrice_;
       std::string spotPriceIDRef_;
       bool spotPriceIsNull_;
       boost::shared_ptr<NonNegativeDecimal> numberOfOptions_;
       std::string numberOfOptionsIDRef_;
       bool numberOfOptionsIsNull_;
       boost::shared_ptr<PositiveDecimal> optionEntitlement_;
       std::string optionEntitlementIDRef_;
       bool optionEntitlementIsNull_;
       boost::shared_ptr<EquityPremium> equityPremium_;
       std::string equityPremiumIDRef_;
       bool equityPremiumIsNull_;

};

} //namespaceFpmlSerialized end
#endif

