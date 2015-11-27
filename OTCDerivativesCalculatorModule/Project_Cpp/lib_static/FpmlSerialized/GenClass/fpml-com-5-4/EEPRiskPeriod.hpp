// EEPRiskPeriod.hpp 
#ifndef FpmlSerialized_EEPRiskPeriod_hpp
#define FpmlSerialized_EEPRiskPeriod_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDate.hpp>

namespace FpmlSerialized {

class EEPRiskPeriod : public ISerialized { 
   public: 
       EEPRiskPeriod(TiXmlNode* xmlNode);

       bool isStartDate(){return this->startDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getStartDate();
      std::string getStartDateIDRef(){return startDateIDRef_;}

       bool isEndDate(){return this->endDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getEndDate();
      std::string getEndDateIDRef(){return endDateIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeDate> startDate_;
       std::string startDateIDRef_;
       bool startDateIsNull_;
       boost::shared_ptr<XsdTypeDate> endDate_;
       std::string endDateIDRef_;
       bool endDateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

