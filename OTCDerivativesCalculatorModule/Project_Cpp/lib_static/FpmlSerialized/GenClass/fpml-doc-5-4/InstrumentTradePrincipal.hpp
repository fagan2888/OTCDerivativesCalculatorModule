// InstrumentTradePrincipal.hpp 
#ifndef FpmlSerialized_InstrumentTradePrincipal_hpp
#define FpmlSerialized_InstrumentTradePrincipal_hpp

#include <ISerialized.hpp>
#include <fpml-doc-5-4/NetAndGross.hpp>

namespace FpmlSerialized {

class InstrumentTradePrincipal : public ISerialized { 
   public: 
       InstrumentTradePrincipal(TiXmlNode* xmlNode);

       bool isPrincipalAmount(){return this->principalAmountIsNull_;}
       boost::shared_ptr<NetAndGross> getPrincipalAmount();
      std::string getPrincipalAmountIDRef(){return principalAmountIDRef_;}

   protected: 
       boost::shared_ptr<NetAndGross> principalAmount_;
       std::string principalAmountIDRef_;
       bool principalAmountIsNull_;

};

} //namespaceFpmlSerialized end
#endif

