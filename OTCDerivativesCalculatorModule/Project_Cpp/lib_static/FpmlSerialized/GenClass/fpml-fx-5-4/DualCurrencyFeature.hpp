// DualCurrencyFeature.hpp 
#ifndef FpmlSerialized_DualCurrencyFeature_hpp
#define FpmlSerialized_DualCurrencyFeature_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/Currency.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <fpml-shared-5-4/BusinessCenterTime.hpp>
#include <fpml-fx-5-4/DualCurrencyStrikePrice.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>

namespace FpmlSerialized {

class DualCurrencyFeature : public ISerialized { 
   public: 
       DualCurrencyFeature(TiXmlNode* xmlNode);

       bool isCurrency(){return this->currencyIsNull_;}
       boost::shared_ptr<Currency> getCurrency();
      std::string getCurrencyIDRef(){return currencyIDRef_;}

       bool isFixingDate(){return this->fixingDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getFixingDate();
      std::string getFixingDateIDRef(){return fixingDateIDRef_;}

       bool isFixingTime(){return this->fixingTimeIsNull_;}
       boost::shared_ptr<BusinessCenterTime> getFixingTime();
      std::string getFixingTimeIDRef(){return fixingTimeIDRef_;}

       bool isStrike(){return this->strikeIsNull_;}
       boost::shared_ptr<DualCurrencyStrikePrice> getStrike();
      std::string getStrikeIDRef(){return strikeIDRef_;}

       bool isSpotRate(){return this->spotRateIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getSpotRate();
      std::string getSpotRateIDRef(){return spotRateIDRef_;}

       bool isInterestAtRisk(){return this->interestAtRiskIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getInterestAtRisk();
      std::string getInterestAtRiskIDRef(){return interestAtRiskIDRef_;}

   protected: 
       boost::shared_ptr<Currency> currency_;
       std::string currencyIDRef_;
       bool currencyIsNull_;
       boost::shared_ptr<XsdTypeDate> fixingDate_;
       std::string fixingDateIDRef_;
       bool fixingDateIsNull_;
       boost::shared_ptr<BusinessCenterTime> fixingTime_;
       std::string fixingTimeIDRef_;
       bool fixingTimeIsNull_;
       boost::shared_ptr<DualCurrencyStrikePrice> strike_;
       std::string strikeIDRef_;
       bool strikeIsNull_;
       boost::shared_ptr<XsdTypeDecimal> spotRate_;
       std::string spotRateIDRef_;
       bool spotRateIsNull_;
       boost::shared_ptr<XsdTypeBoolean> interestAtRisk_;
       std::string interestAtRiskIDRef_;
       bool interestAtRiskIsNull_;

};

} //namespaceFpmlSerialized end
#endif

