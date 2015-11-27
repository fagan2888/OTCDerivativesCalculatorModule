// SwapCurveValuation.hpp 
#ifndef FpmlSerialized_SwapCurveValuation_hpp
#define FpmlSerialized_SwapCurveValuation_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/FloatingRateIndex.hpp>
#include <fpml-shared-5-4/Period.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-enum-5-4/QuotationSideEnum.hpp>

namespace FpmlSerialized {

class SwapCurveValuation : public ISerialized { 
   public: 
       SwapCurveValuation(TiXmlNode* xmlNode);

       bool isFloatingRateIndex(){return this->floatingRateIndexIsNull_;}
       boost::shared_ptr<FloatingRateIndex> getFloatingRateIndex();
      std::string getFloatingRateIndexIDRef(){return floatingRateIndexIDRef_;}

       bool isIndexTenor(){return this->indexTenorIsNull_;}
       boost::shared_ptr<Period> getIndexTenor();
      std::string getIndexTenorIDRef(){return indexTenorIDRef_;}

       bool isSpread(){return this->spreadIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getSpread();
      std::string getSpreadIDRef(){return spreadIDRef_;}

       bool isSide(){return this->sideIsNull_;}
       boost::shared_ptr<QuotationSideEnum> getSide();
      std::string getSideIDRef(){return sideIDRef_;}

   protected: 
       boost::shared_ptr<FloatingRateIndex> floatingRateIndex_;
       std::string floatingRateIndexIDRef_;
       bool floatingRateIndexIsNull_;
       boost::shared_ptr<Period> indexTenor_;
       std::string indexTenorIDRef_;
       bool indexTenorIsNull_;
       boost::shared_ptr<XsdTypeDecimal> spread_;
       std::string spreadIDRef_;
       bool spreadIsNull_;
       boost::shared_ptr<QuotationSideEnum> side_;
       std::string sideIDRef_;
       bool sideIsNull_;

};

} //namespaceFpmlSerialized end
#endif

