// FixedPaymentLeg.hpp 
#ifndef FpmlSerialized_FixedPaymentLeg_hpp
#define FpmlSerialized_FixedPaymentLeg_hpp

#include <fpml-eq-shared-5-4/DirectionalLeg.hpp>
#include <fpml-dividend-swaps-5-4/FixedPaymentAmount.hpp>

namespace FpmlSerialized {

class FixedPaymentLeg : public DirectionalLeg { 
   public: 
       FixedPaymentLeg(TiXmlNode* xmlNode);

       bool isFixedPayment(){return this->fixedPaymentIsNull_;}
       std::vector<boost::shared_ptr<FixedPaymentAmount>> getFixedPayment();
      std::string getFixedPaymentIDRef(){return fixedPaymentIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<FixedPaymentAmount>> fixedPayment_;
       std::string fixedPaymentIDRef_;
       bool fixedPaymentIsNull_;

};

} //namespaceFpmlSerialized end
#endif

