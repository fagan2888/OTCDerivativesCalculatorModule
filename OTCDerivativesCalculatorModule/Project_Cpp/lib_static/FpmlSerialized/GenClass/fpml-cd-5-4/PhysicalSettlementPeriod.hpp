// PhysicalSettlementPeriod.hpp 
#ifndef FpmlSerialized_PhysicalSettlementPeriod_hpp
#define FpmlSerialized_PhysicalSettlementPeriod_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <built_in_type/XsdTypeNonNegativeInteger.hpp>

namespace FpmlSerialized {

class PhysicalSettlementPeriod : public ISerialized { 
   public: 
       PhysicalSettlementPeriod(TiXmlNode* xmlNode);

       bool isBusinessDaysNotSpecified(){return this->businessDaysNotSpecifiedIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getBusinessDaysNotSpecified();
      std::string getBusinessDaysNotSpecifiedIDRef(){return businessDaysNotSpecifiedIDRef_;}

       bool isBusinessDays(){return this->businessDaysIsNull_;}
       boost::shared_ptr<XsdTypeNonNegativeInteger> getBusinessDays();
      std::string getBusinessDaysIDRef(){return businessDaysIDRef_;}

       bool isMaximumBusinessDays(){return this->maximumBusinessDaysIsNull_;}
       boost::shared_ptr<XsdTypeNonNegativeInteger> getMaximumBusinessDays();
      std::string getMaximumBusinessDaysIDRef(){return maximumBusinessDaysIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!businessDaysNotSpecifiedIsNull_){
                count += 1;
                str = "businessDaysNotSpecified" ;
           }
           if(!businessDaysIsNull_){
                count += 1;
                str = "businessDays" ;
           }
           if(!maximumBusinessDaysIsNull_){
                count += 1;
                str = "maximumBusinessDays" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<XsdTypeBoolean> businessDaysNotSpecified_;     //choice
       std::string businessDaysNotSpecifiedIDRef_;
       bool businessDaysNotSpecifiedIsNull_;
         boost::shared_ptr<XsdTypeNonNegativeInteger> businessDays_;     //choice
       std::string businessDaysIDRef_;
       bool businessDaysIsNull_;
         boost::shared_ptr<XsdTypeNonNegativeInteger> maximumBusinessDays_;     //choice
       std::string maximumBusinessDaysIDRef_;
       bool maximumBusinessDaysIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

