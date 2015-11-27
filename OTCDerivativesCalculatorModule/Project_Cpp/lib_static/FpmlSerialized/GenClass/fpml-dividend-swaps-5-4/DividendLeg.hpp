// DividendLeg.hpp 
#ifndef FpmlSerialized_DividendLeg_hpp
#define FpmlSerialized_DividendLeg_hpp

#include <fpml-eq-shared-5-4/DirectionalLegUnderlyer.hpp>
#include <fpml-shared-5-4/NonNegativeDecimal.hpp>
#include <fpml-dividend-swaps-5-4/DividendPeriodPayment.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>

namespace FpmlSerialized {

class DividendLeg : public DirectionalLegUnderlyer { 
   public: 
       DividendLeg(TiXmlNode* xmlNode);

       bool isDeclaredCashDividendPercentage(){return this->declaredCashDividendPercentageIsNull_;}
       boost::shared_ptr<NonNegativeDecimal> getDeclaredCashDividendPercentage();
      std::string getDeclaredCashDividendPercentageIDRef(){return declaredCashDividendPercentageIDRef_;}

       bool isDeclaredCashEquivalentDividendPercentage(){return this->declaredCashEquivalentDividendPercentageIsNull_;}
       boost::shared_ptr<NonNegativeDecimal> getDeclaredCashEquivalentDividendPercentage();
      std::string getDeclaredCashEquivalentDividendPercentageIDRef(){return declaredCashEquivalentDividendPercentageIDRef_;}

       bool isDividendPeriod(){return this->dividendPeriodIsNull_;}
       std::vector<boost::shared_ptr<DividendPeriodPayment>> getDividendPeriod();
      std::string getDividendPeriodIDRef(){return dividendPeriodIDRef_;}

       bool isSpecialDividends(){return this->specialDividendsIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getSpecialDividends();
      std::string getSpecialDividendsIDRef(){return specialDividendsIDRef_;}

       bool isMaterialDividend(){return this->materialDividendIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getMaterialDividend();
      std::string getMaterialDividendIDRef(){return materialDividendIDRef_;}

   protected: 
       boost::shared_ptr<NonNegativeDecimal> declaredCashDividendPercentage_;
       std::string declaredCashDividendPercentageIDRef_;
       bool declaredCashDividendPercentageIsNull_;
       boost::shared_ptr<NonNegativeDecimal> declaredCashEquivalentDividendPercentage_;
       std::string declaredCashEquivalentDividendPercentageIDRef_;
       bool declaredCashEquivalentDividendPercentageIsNull_;
       std::vector<boost::shared_ptr<DividendPeriodPayment>> dividendPeriod_;
       std::string dividendPeriodIDRef_;
       bool dividendPeriodIsNull_;
       boost::shared_ptr<XsdTypeBoolean> specialDividends_;
       std::string specialDividendsIDRef_;
       bool specialDividendsIsNull_;
       boost::shared_ptr<XsdTypeBoolean> materialDividend_;
       std::string materialDividendIDRef_;
       bool materialDividendIsNull_;

};

} //namespaceFpmlSerialized end
#endif

