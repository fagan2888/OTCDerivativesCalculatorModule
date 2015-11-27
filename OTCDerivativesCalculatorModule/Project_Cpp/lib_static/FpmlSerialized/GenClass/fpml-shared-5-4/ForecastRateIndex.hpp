// ForecastRateIndex.hpp 
#ifndef FpmlSerialized_ForecastRateIndex_hpp
#define FpmlSerialized_ForecastRateIndex_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/FloatingRateIndex.hpp>
#include <fpml-shared-5-4/Period.hpp>

namespace FpmlSerialized {

class ForecastRateIndex : public ISerialized { 
   public: 
       ForecastRateIndex(TiXmlNode* xmlNode);

       bool isFloatingRateIndex(){return this->floatingRateIndexIsNull_;}
       boost::shared_ptr<FloatingRateIndex> getFloatingRateIndex();
      std::string getFloatingRateIndexIDRef(){return floatingRateIndexIDRef_;}

       bool isIndexTenor(){return this->indexTenorIsNull_;}
       boost::shared_ptr<Period> getIndexTenor();
      std::string getIndexTenorIDRef(){return indexTenorIDRef_;}

   protected: 
       boost::shared_ptr<FloatingRateIndex> floatingRateIndex_;
       std::string floatingRateIndexIDRef_;
       bool floatingRateIndexIsNull_;
       boost::shared_ptr<Period> indexTenor_;
       std::string indexTenorIDRef_;
       bool indexTenorIsNull_;

};

} //namespaceFpmlSerialized end
#endif

