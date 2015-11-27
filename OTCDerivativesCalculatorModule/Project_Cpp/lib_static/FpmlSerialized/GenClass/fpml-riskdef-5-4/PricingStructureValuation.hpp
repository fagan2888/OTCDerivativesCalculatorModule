// PricingStructureValuation.hpp 
#ifndef FpmlSerialized_PricingStructureValuation_hpp
#define FpmlSerialized_PricingStructureValuation_hpp

#include <fpml-riskdef-5-4/Valuation.hpp>
#include <fpml-shared-5-4/IdentifiedDate.hpp>
#include <built_in_type/XsdTypeDateTime.hpp>

namespace FpmlSerialized {

class PricingStructureValuation : public Valuation { 
   public: 
       PricingStructureValuation(TiXmlNode* xmlNode);

       bool isBaseDate(){return this->baseDateIsNull_;}
       boost::shared_ptr<IdentifiedDate> getBaseDate();
      std::string getBaseDateIDRef(){return baseDateIDRef_;}

       bool isSpotDate(){return this->spotDateIsNull_;}
       boost::shared_ptr<IdentifiedDate> getSpotDate();
      std::string getSpotDateIDRef(){return spotDateIDRef_;}

       bool isInputDataDate(){return this->inputDataDateIsNull_;}
       boost::shared_ptr<IdentifiedDate> getInputDataDate();
      std::string getInputDataDateIDRef(){return inputDataDateIDRef_;}

       bool isEndDate(){return this->endDateIsNull_;}
       boost::shared_ptr<IdentifiedDate> getEndDate();
      std::string getEndDateIDRef(){return endDateIDRef_;}

       bool isBuildDateTime(){return this->buildDateTimeIsNull_;}
       boost::shared_ptr<XsdTypeDateTime> getBuildDateTime();
      std::string getBuildDateTimeIDRef(){return buildDateTimeIDRef_;}

   protected: 
       boost::shared_ptr<IdentifiedDate> baseDate_;
       std::string baseDateIDRef_;
       bool baseDateIsNull_;
       boost::shared_ptr<IdentifiedDate> spotDate_;
       std::string spotDateIDRef_;
       bool spotDateIsNull_;
       boost::shared_ptr<IdentifiedDate> inputDataDate_;
       std::string inputDataDateIDRef_;
       bool inputDataDateIsNull_;
       boost::shared_ptr<IdentifiedDate> endDate_;
       std::string endDateIDRef_;
       bool endDateIsNull_;
       boost::shared_ptr<XsdTypeDateTime> buildDateTime_;
       std::string buildDateTimeIDRef_;
       bool buildDateTimeIsNull_;

};

} //namespaceFpmlSerialized end
#endif

