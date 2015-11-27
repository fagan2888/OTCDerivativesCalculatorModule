// EquityForward.hpp 
#ifndef FpmlSerialized_EquityForward_hpp
#define FpmlSerialized_EquityForward_hpp

#include <fpml-eqd-5-4/EquityDerivativeLongFormBase.hpp>
#include <fpml-shared-5-4/NonNegativeMoney.hpp>

namespace FpmlSerialized {

class EquityForward : public EquityDerivativeLongFormBase { 
   public: 
       EquityForward(TiXmlNode* xmlNode);

       bool isForwardPrice(){return this->forwardPriceIsNull_;}
       boost::shared_ptr<NonNegativeMoney> getForwardPrice();
      std::string getForwardPriceIDRef(){return forwardPriceIDRef_;}

   protected: 
       boost::shared_ptr<NonNegativeMoney> forwardPrice_;
       std::string forwardPriceIDRef_;
       bool forwardPriceIsNull_;

};

} //namespaceFpmlSerialized end
#endif

