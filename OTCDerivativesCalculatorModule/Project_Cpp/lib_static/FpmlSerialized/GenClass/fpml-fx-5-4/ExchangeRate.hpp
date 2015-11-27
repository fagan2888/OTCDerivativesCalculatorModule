// ExchangeRate.hpp 
#ifndef FpmlSerialized_ExchangeRate_hpp
#define FpmlSerialized_ExchangeRate_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/QuotedCurrencyPair.hpp>
#include <fpml-shared-5-4/PositiveDecimal.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-fx-5-4/PointValue.hpp>
#include <fpml-fx-5-4/CrossRate.hpp>

namespace FpmlSerialized {

class ExchangeRate : public ISerialized { 
   public: 
       ExchangeRate(TiXmlNode* xmlNode);

       bool isQuotedCurrencyPair(){return this->quotedCurrencyPairIsNull_;}
       boost::shared_ptr<QuotedCurrencyPair> getQuotedCurrencyPair();
      std::string getQuotedCurrencyPairIDRef(){return quotedCurrencyPairIDRef_;}

       bool isRate(){return this->rateIsNull_;}
       boost::shared_ptr<PositiveDecimal> getRate();
      std::string getRateIDRef(){return rateIDRef_;}

       bool isSpotRate(){return this->spotRateIsNull_;}
       boost::shared_ptr<PositiveDecimal> getSpotRate();
      std::string getSpotRateIDRef(){return spotRateIDRef_;}

       bool isForwardPoints(){return this->forwardPointsIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getForwardPoints();
      std::string getForwardPointsIDRef(){return forwardPointsIDRef_;}

       bool isPointValue(){return this->pointValueIsNull_;}
       boost::shared_ptr<PointValue> getPointValue();
      std::string getPointValueIDRef(){return pointValueIDRef_;}

       bool isCrossRate(){return this->crossRateIsNull_;}
       std::vector<boost::shared_ptr<CrossRate>> getCrossRate();
      std::string getCrossRateIDRef(){return crossRateIDRef_;}

   protected: 
       boost::shared_ptr<QuotedCurrencyPair> quotedCurrencyPair_;
       std::string quotedCurrencyPairIDRef_;
       bool quotedCurrencyPairIsNull_;
       boost::shared_ptr<PositiveDecimal> rate_;
       std::string rateIDRef_;
       bool rateIsNull_;
       boost::shared_ptr<PositiveDecimal> spotRate_;
       std::string spotRateIDRef_;
       bool spotRateIsNull_;
       boost::shared_ptr<XsdTypeDecimal> forwardPoints_;
       std::string forwardPointsIDRef_;
       bool forwardPointsIsNull_;
       boost::shared_ptr<PointValue> pointValue_;
       std::string pointValueIDRef_;
       bool pointValueIsNull_;
       std::vector<boost::shared_ptr<CrossRate>> crossRate_;
       std::string crossRateIDRef_;
       bool crossRateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

