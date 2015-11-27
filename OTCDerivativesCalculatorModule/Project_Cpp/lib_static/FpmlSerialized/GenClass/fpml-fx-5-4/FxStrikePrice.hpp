// FxStrikePrice.hpp 
#ifndef FpmlSerialized_FxStrikePrice_hpp
#define FpmlSerialized_FxStrikePrice_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/PositiveDecimal.hpp>
#include <fpml-enum-5-4/StrikeQuoteBasisEnum.hpp>

namespace FpmlSerialized {

class FxStrikePrice : public ISerialized { 
   public: 
       FxStrikePrice(TiXmlNode* xmlNode);

       bool isRate(){return this->rateIsNull_;}
       boost::shared_ptr<PositiveDecimal> getRate();
      std::string getRateIDRef(){return rateIDRef_;}

       bool isStrikeQuoteBasis(){return this->strikeQuoteBasisIsNull_;}
       boost::shared_ptr<StrikeQuoteBasisEnum> getStrikeQuoteBasis();
      std::string getStrikeQuoteBasisIDRef(){return strikeQuoteBasisIDRef_;}

   protected: 
       boost::shared_ptr<PositiveDecimal> rate_;
       std::string rateIDRef_;
       bool rateIsNull_;
       boost::shared_ptr<StrikeQuoteBasisEnum> strikeQuoteBasis_;
       std::string strikeQuoteBasisIDRef_;
       bool strikeQuoteBasisIsNull_;

};

} //namespaceFpmlSerialized end
#endif

