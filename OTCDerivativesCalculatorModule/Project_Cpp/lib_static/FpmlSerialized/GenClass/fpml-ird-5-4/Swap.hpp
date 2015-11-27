// Swap.hpp 
#ifndef FpmlSerialized_Swap_hpp
#define FpmlSerialized_Swap_hpp

#include <fpml-shared-5-4/Product.hpp>
#include <fpml-ird-5-4/InterestRateStream.hpp>
#include <fpml-ird-5-4/EarlyTerminationProvision.hpp>
#include <fpml-ird-5-4/CancelableProvision.hpp>
#include <fpml-ird-5-4/ExtendibleProvision.hpp>
#include <fpml-shared-5-4/Payment.hpp>
#include <fpml-ird-5-4/SwapAdditionalTerms.hpp>

namespace FpmlSerialized {

class Swap : public Product { 
   public: 
       Swap(TiXmlNode* xmlNode);

       bool isSwapStream(){return this->swapStreamIsNull_;}
       std::vector<boost::shared_ptr<InterestRateStream>> getSwapStream();
      std::string getSwapStreamIDRef(){return swapStreamIDRef_;}

       bool isEarlyTerminationProvision(){return this->earlyTerminationProvisionIsNull_;}
       boost::shared_ptr<EarlyTerminationProvision> getEarlyTerminationProvision();
      std::string getEarlyTerminationProvisionIDRef(){return earlyTerminationProvisionIDRef_;}

       bool isCancelableProvision(){return this->cancelableProvisionIsNull_;}
       boost::shared_ptr<CancelableProvision> getCancelableProvision();
      std::string getCancelableProvisionIDRef(){return cancelableProvisionIDRef_;}

       bool isExtendibleProvision(){return this->extendibleProvisionIsNull_;}
       boost::shared_ptr<ExtendibleProvision> getExtendibleProvision();
      std::string getExtendibleProvisionIDRef(){return extendibleProvisionIDRef_;}

       bool isAdditionalPayment(){return this->additionalPaymentIsNull_;}
       std::vector<boost::shared_ptr<Payment>> getAdditionalPayment();
      std::string getAdditionalPaymentIDRef(){return additionalPaymentIDRef_;}

       bool isAdditionalTerms(){return this->additionalTermsIsNull_;}
       boost::shared_ptr<SwapAdditionalTerms> getAdditionalTerms();
      std::string getAdditionalTermsIDRef(){return additionalTermsIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<InterestRateStream>> swapStream_;
       std::string swapStreamIDRef_;
       bool swapStreamIsNull_;
       boost::shared_ptr<EarlyTerminationProvision> earlyTerminationProvision_;
       std::string earlyTerminationProvisionIDRef_;
       bool earlyTerminationProvisionIsNull_;
       boost::shared_ptr<CancelableProvision> cancelableProvision_;
       std::string cancelableProvisionIDRef_;
       bool cancelableProvisionIsNull_;
       boost::shared_ptr<ExtendibleProvision> extendibleProvision_;
       std::string extendibleProvisionIDRef_;
       bool extendibleProvisionIsNull_;
       std::vector<boost::shared_ptr<Payment>> additionalPayment_;
       std::string additionalPaymentIDRef_;
       bool additionalPaymentIsNull_;
       boost::shared_ptr<SwapAdditionalTerms> additionalTerms_;
       std::string additionalTermsIDRef_;
       bool additionalTermsIsNull_;

};

} //namespaceFpmlSerialized end
#endif

