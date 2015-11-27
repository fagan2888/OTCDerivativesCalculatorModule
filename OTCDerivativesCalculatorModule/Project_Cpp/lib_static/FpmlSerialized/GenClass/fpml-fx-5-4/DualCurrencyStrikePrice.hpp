// DualCurrencyStrikePrice.hpp 
#ifndef FpmlSerialized_DualCurrencyStrikePrice_hpp
#define FpmlSerialized_DualCurrencyStrikePrice_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/PositiveDecimal.hpp>
#include <fpml-enum-5-4/DualCurrencyStrikeQuoteBasisEnum.hpp>

namespace FpmlSerialized {

class DualCurrencyStrikePrice : public ISerialized { 
   public: 
       DualCurrencyStrikePrice(TiXmlNode* xmlNode);

       bool isRate(){return this->rateIsNull_;}
       boost::shared_ptr<PositiveDecimal> getRate();
      std::string getRateIDRef(){return rateIDRef_;}

       bool isStrikeQuoteBasis(){return this->strikeQuoteBasisIsNull_;}
       boost::shared_ptr<DualCurrencyStrikeQuoteBasisEnum> getStrikeQuoteBasis();
      std::string getStrikeQuoteBasisIDRef(){return strikeQuoteBasisIDRef_;}

   protected: 
       boost::shared_ptr<PositiveDecimal> rate_;
       std::string rateIDRef_;
       bool rateIsNull_;
       boost::shared_ptr<DualCurrencyStrikeQuoteBasisEnum> strikeQuoteBasis_;
       std::string strikeQuoteBasisIDRef_;
       bool strikeQuoteBasisIsNull_;

};

} //namespaceFpmlSerialized end
#endif

