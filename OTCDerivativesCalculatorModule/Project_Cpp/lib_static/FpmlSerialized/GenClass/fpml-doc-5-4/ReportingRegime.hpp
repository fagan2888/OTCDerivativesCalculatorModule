// ReportingRegime.hpp 
#ifndef FpmlSerialized_ReportingRegime_hpp
#define FpmlSerialized_ReportingRegime_hpp

#include <ISerialized.hpp>
#include <fpml-doc-5-4/ReportingRegimeName.hpp>
#include <fpml-doc-5-4/SupervisorRegistration.hpp>
#include <fpml-doc-5-4/ReportingRole.hpp>
#include <fpml-doc-5-4/ReportingPurpose.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>

namespace FpmlSerialized {

class ReportingRegime : public ISerialized { 
   public: 
       ReportingRegime(TiXmlNode* xmlNode);

       bool isName(){return this->nameIsNull_;}
       boost::shared_ptr<ReportingRegimeName> getName();
      std::string getNameIDRef(){return nameIDRef_;}

       bool isSupervisorRegistration(){return this->supervisorRegistrationIsNull_;}
       std::vector<boost::shared_ptr<SupervisorRegistration>> getSupervisorRegistration();
      std::string getSupervisorRegistrationIDRef(){return supervisorRegistrationIDRef_;}

       bool isReportingRole(){return this->reportingRoleIsNull_;}
       boost::shared_ptr<ReportingRole> getReportingRole();
      std::string getReportingRoleIDRef(){return reportingRoleIDRef_;}

       bool isReportingPurpose(){return this->reportingPurposeIsNull_;}
       std::vector<boost::shared_ptr<ReportingPurpose>> getReportingPurpose();
      std::string getReportingPurposeIDRef(){return reportingPurposeIDRef_;}

       bool isMandatorilyClearable(){return this->mandatorilyClearableIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getMandatorilyClearable();
      std::string getMandatorilyClearableIDRef(){return mandatorilyClearableIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!nameIsNull_){
                count += 1;
                str = "name" ;
           }
           if(!supervisorRegistrationIsNull_){
                count += 1;
                str = "supervisorRegistration" ;
           }
           if(!supervisorRegistrationIsNull_){
                count += 1;
                str = "supervisorRegistration" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<ReportingRegimeName> name_;     //choice
       std::string nameIDRef_;
       bool nameIsNull_;
         std::vector<boost::shared_ptr<SupervisorRegistration>> supervisorRegistration_;     //choice
       std::string supervisorRegistrationIDRef_;
       bool supervisorRegistrationIsNull_;
       boost::shared_ptr<ReportingRole> reportingRole_;
       std::string reportingRoleIDRef_;
       bool reportingRoleIsNull_;
       std::vector<boost::shared_ptr<ReportingPurpose>> reportingPurpose_;
       std::string reportingPurposeIDRef_;
       bool reportingPurposeIsNull_;
       boost::shared_ptr<XsdTypeBoolean> mandatorilyClearable_;
       std::string mandatorilyClearableIDRef_;
       bool mandatorilyClearableIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

