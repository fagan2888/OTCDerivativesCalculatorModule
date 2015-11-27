// DividendAdjustment.hpp 
#ifndef FpmlSerialized_DividendAdjustment_hpp
#define FpmlSerialized_DividendAdjustment_hpp

#include <ISerialized.hpp>
#include <fpml-eq-shared-5-4/DividendPeriodDividend.hpp>

namespace FpmlSerialized {

class DividendAdjustment : public ISerialized { 
   public: 
       DividendAdjustment(TiXmlNode* xmlNode);

       bool isDividendPeriod(){return this->dividendPeriodIsNull_;}
       std::vector<boost::shared_ptr<DividendPeriodDividend>> getDividendPeriod();
      std::string getDividendPeriodIDRef(){return dividendPeriodIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<DividendPeriodDividend>> dividendPeriod_;
       std::string dividendPeriodIDRef_;
       bool dividendPeriodIsNull_;

};

} //namespaceFpmlSerialized end
#endif

