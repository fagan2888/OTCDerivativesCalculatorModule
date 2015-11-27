// DividendPeriodDividend.hpp 
#ifndef FpmlSerialized_DividendPeriodDividend_hpp
#define FpmlSerialized_DividendPeriodDividend_hpp

#include <fpml-eq-shared-5-4/DividendPeriod.hpp>
#include <fpml-shared-5-4/NonNegativeMoney.hpp>
#include <fpml-shared-5-4/PositiveDecimal.hpp>

namespace FpmlSerialized {

class DividendPeriodDividend : public DividendPeriod { 
   public: 
       DividendPeriodDividend(TiXmlNode* xmlNode);

       bool isDividend(){return this->dividendIsNull_;}
       boost::shared_ptr<NonNegativeMoney> getDividend();
      std::string getDividendIDRef(){return dividendIDRef_;}

       bool isMultiplier(){return this->multiplierIsNull_;}
       boost::shared_ptr<PositiveDecimal> getMultiplier();
      std::string getMultiplierIDRef(){return multiplierIDRef_;}

   protected: 
       boost::shared_ptr<NonNegativeMoney> dividend_;
       std::string dividendIDRef_;
       bool dividendIsNull_;
       boost::shared_ptr<PositiveDecimal> multiplier_;
       std::string multiplierIDRef_;
       bool multiplierIsNull_;

};

} //namespaceFpmlSerialized end
#endif

