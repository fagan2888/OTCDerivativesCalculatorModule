// EnvironmentalProductComplaincePeriod.hpp 
#ifndef FpmlSerialized_EnvironmentalProductComplaincePeriod_hpp
#define FpmlSerialized_EnvironmentalProductComplaincePeriod_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeGYear.hpp>

namespace FpmlSerialized {

class EnvironmentalProductComplaincePeriod : public ISerialized { 
   public: 
       EnvironmentalProductComplaincePeriod(TiXmlNode* xmlNode);

       bool isStartYear(){return this->startYearIsNull_;}
       boost::shared_ptr<XsdTypeGYear> getStartYear();
      std::string getStartYearIDRef(){return startYearIDRef_;}

       bool isEndYear(){return this->endYearIsNull_;}
       boost::shared_ptr<XsdTypeGYear> getEndYear();
      std::string getEndYearIDRef(){return endYearIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeGYear> startYear_;
       std::string startYearIDRef_;
       bool startYearIsNull_;
       boost::shared_ptr<XsdTypeGYear> endYear_;
       std::string endYearIDRef_;
       bool endYearIsNull_;

};

} //namespaceFpmlSerialized end
#endif

