// BusinessDayAdjustments.hpp 
#ifndef FpmlSerialized_BusinessDayAdjustments_hpp
#define FpmlSerialized_BusinessDayAdjustments_hpp

#include <ISerialized.hpp>
#include <fpml-enum-5-4/BusinessDayConventionEnum.hpp>
#include <fpml-shared-5-4/BusinessCentersReference.hpp>
#include <fpml-shared-5-4/BusinessCenters.hpp>

namespace FpmlSerialized {

class BusinessDayAdjustments : public ISerialized { 
   public: 
       BusinessDayAdjustments(TiXmlNode* xmlNode);

       bool isBusinessDayConvention(){return this->businessDayConventionIsNull_;}
       boost::shared_ptr<BusinessDayConventionEnum> getBusinessDayConvention();
      std::string getBusinessDayConventionIDRef(){return businessDayConventionIDRef_;}

       bool isBusinessCentersReference(){return this->businessCentersReferenceIsNull_;}
       boost::shared_ptr<BusinessCentersReference> getBusinessCentersReference();
      std::string getBusinessCentersReferenceIDRef(){return businessCentersReferenceIDRef_;}

       bool isBusinessCenters(){return this->businessCentersIsNull_;}
       boost::shared_ptr<BusinessCenters> getBusinessCenters();
      std::string getBusinessCentersIDRef(){return businessCentersIDRef_;}

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
       boost::shared_ptr<BusinessDayConventionEnum> businessDayConvention_;
       std::string businessDayConventionIDRef_;
       bool businessDayConventionIsNull_;
         boost::shared_ptr<BusinessCentersReference> businessCentersReference_;     //choice
       std::string businessCentersReferenceIDRef_;
       bool businessCentersReferenceIsNull_;
         boost::shared_ptr<BusinessCenters> businessCenters_;     //choice
       std::string businessCentersIDRef_;
       bool businessCentersIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

