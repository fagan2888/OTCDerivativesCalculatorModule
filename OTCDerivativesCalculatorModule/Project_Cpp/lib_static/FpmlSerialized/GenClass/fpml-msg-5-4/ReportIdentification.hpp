// ReportIdentification.hpp 
#ifndef FpmlSerialized_ReportIdentification_hpp
#define FpmlSerialized_ReportIdentification_hpp

#include <fpml-msg-5-4/ReportSectionIdentification.hpp>
#include <built_in_type/XsdTypePositiveInteger.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>

namespace FpmlSerialized {

class ReportIdentification : public ReportSectionIdentification { 
   public: 
       ReportIdentification(TiXmlNode* xmlNode);

       bool isNumberOfSections(){return this->numberOfSectionsIsNull_;}
       boost::shared_ptr<XsdTypePositiveInteger> getNumberOfSections();
      std::string getNumberOfSectionsIDRef(){return numberOfSectionsIDRef_;}

       bool isSubmissionsComplete(){return this->submissionsCompleteIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getSubmissionsComplete();
      std::string getSubmissionsCompleteIDRef(){return submissionsCompleteIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypePositiveInteger> numberOfSections_;
       std::string numberOfSectionsIDRef_;
       bool numberOfSectionsIsNull_;
       boost::shared_ptr<XsdTypeBoolean> submissionsComplete_;
       std::string submissionsCompleteIDRef_;
       bool submissionsCompleteIsNull_;

};

} //namespaceFpmlSerialized end
#endif

