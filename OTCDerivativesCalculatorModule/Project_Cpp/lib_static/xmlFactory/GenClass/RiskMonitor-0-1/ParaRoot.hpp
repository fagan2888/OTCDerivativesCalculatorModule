// ParaRoot.hpp 
#ifndef FpmlSerialized_ParaRoot_hpp
#define FpmlSerialized_ParaRoot_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/Pricing.hpp>

namespace FpmlSerialized {

class ParaRoot : public ISerialized { 
   public: 
       ParaRoot(TiXmlNode* xmlNode);

       bool isPricing(){return this->pricingIsNull_;}
       boost::shared_ptr<Pricing> getPricing();


   protected: 
       boost::shared_ptr<Pricing> pricing_;
       
       bool pricingIsNull_;

};

} //namespaceFpmlSerialized end
#endif

