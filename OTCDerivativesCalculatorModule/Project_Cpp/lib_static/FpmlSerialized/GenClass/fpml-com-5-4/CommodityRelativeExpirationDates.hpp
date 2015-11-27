// CommodityRelativeExpirationDates.hpp 
#ifndef FpmlSerialized_CommodityRelativeExpirationDates_hpp
#define FpmlSerialized_CommodityRelativeExpirationDates_hpp

#include <ISerialized.hpp>
#include <fpml-com-5-4/CommodityExpireRelativeToEvent.hpp>
#include <fpml-shared-5-4/DateOffset.hpp>
#include <fpml-shared-5-4/BusinessCentersReference.hpp>
#include <fpml-shared-5-4/BusinessCenters.hpp>

namespace FpmlSerialized {

class CommodityRelativeExpirationDates : public ISerialized { 
   public: 
       CommodityRelativeExpirationDates(TiXmlNode* xmlNode);

       bool isExpireRelativeToEvent(){return this->expireRelativeToEventIsNull_;}
       boost::shared_ptr<CommodityExpireRelativeToEvent> getExpireRelativeToEvent();
      std::string getExpireRelativeToEventIDRef(){return expireRelativeToEventIDRef_;}

       bool isExpirationDateOffset(){return this->expirationDateOffsetIsNull_;}
       boost::shared_ptr<DateOffset> getExpirationDateOffset();
      std::string getExpirationDateOffsetIDRef(){return expirationDateOffsetIDRef_;}

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
       boost::shared_ptr<CommodityExpireRelativeToEvent> expireRelativeToEvent_;
       std::string expireRelativeToEventIDRef_;
       bool expireRelativeToEventIsNull_;
       boost::shared_ptr<DateOffset> expirationDateOffset_;
       std::string expirationDateOffsetIDRef_;
       bool expirationDateOffsetIsNull_;
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

