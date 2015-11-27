// CorrelationAmount.hpp 
#ifndef FpmlSerialized_CorrelationAmount_hpp
#define FpmlSerialized_CorrelationAmount_hpp

#include <fpml-eq-shared-5-4/CalculatedAmount.hpp>
#include <fpml-eq-shared-5-4/Correlation.hpp>

namespace FpmlSerialized {

class CorrelationAmount : public CalculatedAmount { 
   public: 
       CorrelationAmount(TiXmlNode* xmlNode);

       bool isCorrelation(){return this->correlationIsNull_;}
       boost::shared_ptr<Correlation> getCorrelation();
      std::string getCorrelationIDRef(){return correlationIDRef_;}

   protected: 
       boost::shared_ptr<Correlation> correlation_;
       std::string correlationIDRef_;
       bool correlationIsNull_;

};

} //namespaceFpmlSerialized end
#endif

