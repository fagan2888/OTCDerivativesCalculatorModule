// NettedSwapBase.hpp 
#ifndef FpmlSerialized_NettedSwapBase_hpp
#define FpmlSerialized_NettedSwapBase_hpp

#include <fpml-shared-5-4/Product.hpp>
#include <fpml-option-shared-5-4/ClassifiedPayment.hpp>
#include <fpml-eq-shared-5-4/ExtraordinaryEvents.hpp>

namespace FpmlSerialized {

class NettedSwapBase : public Product { 
   public: 
       NettedSwapBase(TiXmlNode* xmlNode);

       bool isAdditionalPayment(){return this->additionalPaymentIsNull_;}
       std::vector<boost::shared_ptr<ClassifiedPayment>> getAdditionalPayment();
      std::string getAdditionalPaymentIDRef(){return additionalPaymentIDRef_;}

       bool isExtraordinaryEvents(){return this->extraordinaryEventsIsNull_;}
       boost::shared_ptr<ExtraordinaryEvents> getExtraordinaryEvents();
      std::string getExtraordinaryEventsIDRef(){return extraordinaryEventsIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<ClassifiedPayment>> additionalPayment_;
       std::string additionalPaymentIDRef_;
       bool additionalPaymentIsNull_;
       boost::shared_ptr<ExtraordinaryEvents> extraordinaryEvents_;
       std::string extraordinaryEventsIDRef_;
       bool extraordinaryEventsIsNull_;

};

} //namespaceFpmlSerialized end
#endif

