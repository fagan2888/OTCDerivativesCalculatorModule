// YieldCurveMethod.hpp 
#ifndef FpmlSerialized_YieldCurveMethod_hpp
#define FpmlSerialized_YieldCurveMethod_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/SettlementRateSource.hpp>
#include <fpml-enum-5-4/QuotationRateTypeEnum.hpp>

namespace FpmlSerialized {

class YieldCurveMethod : public ISerialized { 
   public: 
       YieldCurveMethod(TiXmlNode* xmlNode);

       bool isSettlementRateSource(){return this->settlementRateSourceIsNull_;}
       boost::shared_ptr<SettlementRateSource> getSettlementRateSource();
      std::string getSettlementRateSourceIDRef(){return settlementRateSourceIDRef_;}

       bool isQuotationRateType(){return this->quotationRateTypeIsNull_;}
       boost::shared_ptr<QuotationRateTypeEnum> getQuotationRateType();
      std::string getQuotationRateTypeIDRef(){return quotationRateTypeIDRef_;}

   protected: 
       boost::shared_ptr<SettlementRateSource> settlementRateSource_;
       std::string settlementRateSourceIDRef_;
       bool settlementRateSourceIsNull_;
       boost::shared_ptr<QuotationRateTypeEnum> quotationRateType_;
       std::string quotationRateTypeIDRef_;
       bool quotationRateTypeIsNull_;

};

} //namespaceFpmlSerialized end
#endif

