// CapFloor.hpp 
#ifndef FpmlSerialized_CapFloor_hpp
#define FpmlSerialized_CapFloor_hpp

#include <fpml-shared-5-4/Product.hpp>
#include <fpml-ird-5-4/InterestRateStream.hpp>
#include <fpml-shared-5-4/Payment.hpp>
#include <fpml-ird-5-4/EarlyTerminationProvision.hpp>

namespace FpmlSerialized {

class CapFloor : public Product { 
   public: 
       CapFloor(TiXmlNode* xmlNode);

       bool isCapFloorStream(){return this->capFloorStreamIsNull_;}
       boost::shared_ptr<InterestRateStream> getCapFloorStream();
      std::string getCapFloorStreamIDRef(){return capFloorStreamIDRef_;}

       bool isPremium(){return this->premiumIsNull_;}
       std::vector<boost::shared_ptr<Payment>> getPremium();
      std::string getPremiumIDRef(){return premiumIDRef_;}

       bool isAdditionalPayment(){return this->additionalPaymentIsNull_;}
       std::vector<boost::shared_ptr<Payment>> getAdditionalPayment();
      std::string getAdditionalPaymentIDRef(){return additionalPaymentIDRef_;}

       bool isEarlyTerminationProvision(){return this->earlyTerminationProvisionIsNull_;}
       boost::shared_ptr<EarlyTerminationProvision> getEarlyTerminationProvision();
      std::string getEarlyTerminationProvisionIDRef(){return earlyTerminationProvisionIDRef_;}

   protected: 
       boost::shared_ptr<InterestRateStream> capFloorStream_;
       std::string capFloorStreamIDRef_;
       bool capFloorStreamIsNull_;
       std::vector<boost::shared_ptr<Payment>> premium_;
       std::string premiumIDRef_;
       bool premiumIsNull_;
       std::vector<boost::shared_ptr<Payment>> additionalPayment_;
       std::string additionalPaymentIDRef_;
       bool additionalPaymentIsNull_;
       boost::shared_ptr<EarlyTerminationProvision> earlyTerminationProvision_;
       std::string earlyTerminationProvisionIDRef_;
       bool earlyTerminationProvisionIsNull_;

};

} //namespaceFpmlSerialized end
#endif

