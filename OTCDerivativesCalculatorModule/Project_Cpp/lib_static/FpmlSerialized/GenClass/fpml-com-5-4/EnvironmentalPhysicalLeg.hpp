// EnvironmentalPhysicalLeg.hpp 
#ifndef FpmlSerialized_EnvironmentalPhysicalLeg_hpp
#define FpmlSerialized_EnvironmentalPhysicalLeg_hpp

#include <fpml-com-5-4/PhysicalSwapLeg.hpp>
#include <fpml-com-5-4/UnitQuantity.hpp>
#include <fpml-com-5-4/EnvironmentalProduct.hpp>
#include <fpml-enum-5-4/EnvironmentalAbandonmentOfSchemeEnum.hpp>
#include <fpml-shared-5-4/AdjustableOrRelativeDate.hpp>
#include <fpml-shared-5-4/DateOffset.hpp>
#include <fpml-shared-5-4/BusinessCentersReference.hpp>
#include <fpml-shared-5-4/BusinessCenters.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-com-5-4/EEPParameters.hpp>

namespace FpmlSerialized {

class EnvironmentalPhysicalLeg : public PhysicalSwapLeg { 
   public: 
       EnvironmentalPhysicalLeg(TiXmlNode* xmlNode);

       bool isNumberOfAllowances(){return this->numberOfAllowancesIsNull_;}
       boost::shared_ptr<UnitQuantity> getNumberOfAllowances();
      std::string getNumberOfAllowancesIDRef(){return numberOfAllowancesIDRef_;}

       bool isEnvironmental(){return this->environmentalIsNull_;}
       boost::shared_ptr<EnvironmentalProduct> getEnvironmental();
      std::string getEnvironmentalIDRef(){return environmentalIDRef_;}

       bool isAbandonmentOfScheme(){return this->abandonmentOfSchemeIsNull_;}
       boost::shared_ptr<EnvironmentalAbandonmentOfSchemeEnum> getAbandonmentOfScheme();
      std::string getAbandonmentOfSchemeIDRef(){return abandonmentOfSchemeIDRef_;}

       bool isDeliveryDate(){return this->deliveryDateIsNull_;}
       boost::shared_ptr<AdjustableOrRelativeDate> getDeliveryDate();
      std::string getDeliveryDateIDRef(){return deliveryDateIDRef_;}

       bool isPaymentDate(){return this->paymentDateIsNull_;}
       boost::shared_ptr<DateOffset> getPaymentDate();
      std::string getPaymentDateIDRef(){return paymentDateIDRef_;}

       bool isBusinessCentersReference(){return this->businessCentersReferenceIsNull_;}
       boost::shared_ptr<BusinessCentersReference> getBusinessCentersReference();
      std::string getBusinessCentersReferenceIDRef(){return businessCentersReferenceIDRef_;}

       bool isBusinessCenters(){return this->businessCentersIsNull_;}
       boost::shared_ptr<BusinessCenters> getBusinessCenters();
      std::string getBusinessCentersIDRef(){return businessCentersIDRef_;}

       bool isFailureToDeliverApplicable(){return this->failureToDeliverApplicableIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getFailureToDeliverApplicable();
      std::string getFailureToDeliverApplicableIDRef(){return failureToDeliverApplicableIDRef_;}

       bool isEEPParameters(){return this->eEPParametersIsNull_;}
       boost::shared_ptr<EEPParameters> getEEPParameters();
      std::string getEEPParametersIDRef(){return eEPParametersIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!businessCentersReferenceIsNull_){
                count += 1;
                str = "businessCentersReference" ;
           }
           if(!businessCentersIsNull_){
                count += 1;
                str = "businessCenters" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<UnitQuantity> numberOfAllowances_;
       std::string numberOfAllowancesIDRef_;
       bool numberOfAllowancesIsNull_;
       boost::shared_ptr<EnvironmentalProduct> environmental_;
       std::string environmentalIDRef_;
       bool environmentalIsNull_;
       boost::shared_ptr<EnvironmentalAbandonmentOfSchemeEnum> abandonmentOfScheme_;
       std::string abandonmentOfSchemeIDRef_;
       bool abandonmentOfSchemeIsNull_;
       boost::shared_ptr<AdjustableOrRelativeDate> deliveryDate_;
       std::string deliveryDateIDRef_;
       bool deliveryDateIsNull_;
       boost::shared_ptr<DateOffset> paymentDate_;
       std::string paymentDateIDRef_;
       bool paymentDateIsNull_;
         boost::shared_ptr<BusinessCentersReference> businessCentersReference_;     //choice
       std::string businessCentersReferenceIDRef_;
       bool businessCentersReferenceIsNull_;
         boost::shared_ptr<BusinessCenters> businessCenters_;     //choice
       std::string businessCentersIDRef_;
       bool businessCentersIsNull_;
       boost::shared_ptr<XsdTypeBoolean> failureToDeliverApplicable_;
       std::string failureToDeliverApplicableIDRef_;
       bool failureToDeliverApplicableIsNull_;
       boost::shared_ptr<EEPParameters> eEPParameters_;
       std::string eEPParametersIDRef_;
       bool eEPParametersIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

