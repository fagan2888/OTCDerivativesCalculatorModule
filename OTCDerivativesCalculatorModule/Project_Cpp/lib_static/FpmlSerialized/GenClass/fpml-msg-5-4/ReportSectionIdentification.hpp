// ReportSectionIdentification.hpp 
#ifndef FpmlSerialized_ReportSectionIdentification_hpp
#define FpmlSerialized_ReportSectionIdentification_hpp

#include <ISerialized.hpp>
#include <fpml-msg-5-4/ReportId.hpp>
#include <built_in_type/XsdTypePositiveInteger.hpp>

namespace FpmlSerialized {

class ReportSectionIdentification : public ISerialized { 
   public: 
       ReportSectionIdentification(TiXmlNode* xmlNode);

       bool isReportId(){return this->reportIdIsNull_;}
       boost::shared_ptr<ReportId> getReportId();
      std::string getReportIdIDRef(){return reportIdIDRef_;}

       bool isSectionNumber(){return this->sectionNumberIsNull_;}
       boost::shared_ptr<XsdTypePositiveInteger> getSectionNumber();
      std::string getSectionNumberIDRef(){return sectionNumberIDRef_;}

   protected: 
       boost::shared_ptr<ReportId> reportId_;
       std::string reportIdIDRef_;
       bool reportIdIsNull_;
       boost::shared_ptr<XsdTypePositiveInteger> sectionNumber_;
       std::string sectionNumberIDRef_;
       bool sectionNumberIsNull_;

};

} //namespaceFpmlSerialized end
#endif

