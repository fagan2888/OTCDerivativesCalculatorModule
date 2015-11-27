// Position.hpp 
#ifndef FpmlSerialized_Position_hpp
#define FpmlSerialized_Position_hpp

#include <ISerialized.hpp>
#include <fpml-riskdef-5-4/PositionId.hpp>
#include <built_in_type/XsdTypePositiveInteger.hpp>
#include <fpml-enum-5-4/PositionStatusEnum.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <fpml-enum-5-4/PositionOriginEnum.hpp>
#include <fpml-valuation-5-4/PositionHistory.hpp>
#include <fpml-valuation-5-4/ReportingRoles.hpp>
#include <fpml-valuation-5-4/PositionConstituent.hpp>
#include <fpml-valuation-5-4/ScheduledDate.hpp>
#include <fpml-valuation-5-4/AssetValuation.hpp>

namespace FpmlSerialized {

class Position : public ISerialized { 
   public: 
       Position(TiXmlNode* xmlNode);

       bool isPositionId(){return this->positionIdIsNull_;}
       boost::shared_ptr<PositionId> getPositionId();
      std::string getPositionIdIDRef(){return positionIdIDRef_;}

       bool isVersion(){return this->versionIsNull_;}
       boost::shared_ptr<XsdTypePositiveInteger> getVersion();
      std::string getVersionIDRef(){return versionIDRef_;}

       bool isStatus(){return this->statusIsNull_;}
       boost::shared_ptr<PositionStatusEnum> getStatus();
      std::string getStatusIDRef(){return statusIDRef_;}

       bool isCreationDate(){return this->creationDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getCreationDate();
      std::string getCreationDateIDRef(){return creationDateIDRef_;}

       bool isOriginatingEvent(){return this->originatingEventIsNull_;}
       boost::shared_ptr<PositionOriginEnum> getOriginatingEvent();
      std::string getOriginatingEventIDRef(){return originatingEventIDRef_;}

       bool isHistory(){return this->historyIsNull_;}
       boost::shared_ptr<PositionHistory> getHistory();
      std::string getHistoryIDRef(){return historyIDRef_;}

       bool isReportingRoles(){return this->reportingRolesIsNull_;}
       boost::shared_ptr<ReportingRoles> getReportingRoles();
      std::string getReportingRolesIDRef(){return reportingRolesIDRef_;}

       bool isConstituent(){return this->constituentIsNull_;}
       boost::shared_ptr<PositionConstituent> getConstituent();
      std::string getConstituentIDRef(){return constituentIDRef_;}

       bool isScheduledDate(){return this->scheduledDateIsNull_;}
       std::vector<boost::shared_ptr<ScheduledDate>> getScheduledDate();
      std::string getScheduledDateIDRef(){return scheduledDateIDRef_;}

       bool isValuation(){return this->valuationIsNull_;}
       std::vector<boost::shared_ptr<AssetValuation>> getValuation();
      std::string getValuationIDRef(){return valuationIDRef_;}

   protected: 
       boost::shared_ptr<PositionId> positionId_;
       std::string positionIdIDRef_;
       bool positionIdIsNull_;
       boost::shared_ptr<XsdTypePositiveInteger> version_;
       std::string versionIDRef_;
       bool versionIsNull_;
       boost::shared_ptr<PositionStatusEnum> status_;
       std::string statusIDRef_;
       bool statusIsNull_;
       boost::shared_ptr<XsdTypeDate> creationDate_;
       std::string creationDateIDRef_;
       bool creationDateIsNull_;
       boost::shared_ptr<PositionOriginEnum> originatingEvent_;
       std::string originatingEventIDRef_;
       bool originatingEventIsNull_;
       boost::shared_ptr<PositionHistory> history_;
       std::string historyIDRef_;
       bool historyIsNull_;
       boost::shared_ptr<ReportingRoles> reportingRoles_;
       std::string reportingRolesIDRef_;
       bool reportingRolesIsNull_;
       boost::shared_ptr<PositionConstituent> constituent_;
       std::string constituentIDRef_;
       bool constituentIsNull_;
       std::vector<boost::shared_ptr<ScheduledDate>> scheduledDate_;
       std::string scheduledDateIDRef_;
       bool scheduledDateIsNull_;
       std::vector<boost::shared_ptr<AssetValuation>> valuation_;
       std::string valuationIDRef_;
       bool valuationIsNull_;

};

} //namespaceFpmlSerialized end
#endif

