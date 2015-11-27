// Position.cpp 
#include "Position.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Position::Position(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //positionIdNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* positionIdNode = xmlNode->FirstChildElement("positionId");

   if(positionIdNode){positionIdIsNull_ = false;}
   else{positionIdIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- positionIdNode , address : " << positionIdNode << std::endl;
   #endif
   if(positionIdNode)
   {
      if(positionIdNode->Attribute("href") || positionIdNode->Attribute("id"))
      {
          if(positionIdNode->Attribute("id"))
          {
             positionIdIDRef_ = positionIdNode->Attribute("id");
             positionId_ = boost::shared_ptr<PositionId>(new PositionId(positionIdNode));
             positionId_->setID(positionIdIDRef_);
             IDManager::instance().setID(positionIdIDRef_,positionId_);
          }
          else if(positionIdNode->Attribute("href")) { positionIdIDRef_ = positionIdNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { positionId_ = boost::shared_ptr<PositionId>(new PositionId(positionIdNode));}
   }

   //versionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* versionNode = xmlNode->FirstChildElement("version");

   if(versionNode){versionIsNull_ = false;}
   else{versionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- versionNode , address : " << versionNode << std::endl;
   #endif
   if(versionNode)
   {
      if(versionNode->Attribute("href") || versionNode->Attribute("id"))
      {
          if(versionNode->Attribute("id"))
          {
             versionIDRef_ = versionNode->Attribute("id");
             version_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(versionNode));
             version_->setID(versionIDRef_);
             IDManager::instance().setID(versionIDRef_,version_);
          }
          else if(versionNode->Attribute("href")) { versionIDRef_ = versionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { version_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(versionNode));}
   }

   //statusNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* statusNode = xmlNode->FirstChildElement("status");

   if(statusNode){statusIsNull_ = false;}
   else{statusIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- statusNode , address : " << statusNode << std::endl;
   #endif
   if(statusNode)
   {
      if(statusNode->Attribute("href") || statusNode->Attribute("id"))
      {
          if(statusNode->Attribute("id"))
          {
             statusIDRef_ = statusNode->Attribute("id");
             status_ = boost::shared_ptr<PositionStatusEnum>(new PositionStatusEnum(statusNode));
             status_->setID(statusIDRef_);
             IDManager::instance().setID(statusIDRef_,status_);
          }
          else if(statusNode->Attribute("href")) { statusIDRef_ = statusNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { status_ = boost::shared_ptr<PositionStatusEnum>(new PositionStatusEnum(statusNode));}
   }

   //creationDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* creationDateNode = xmlNode->FirstChildElement("creationDate");

   if(creationDateNode){creationDateIsNull_ = false;}
   else{creationDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- creationDateNode , address : " << creationDateNode << std::endl;
   #endif
   if(creationDateNode)
   {
      if(creationDateNode->Attribute("href") || creationDateNode->Attribute("id"))
      {
          if(creationDateNode->Attribute("id"))
          {
             creationDateIDRef_ = creationDateNode->Attribute("id");
             creationDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(creationDateNode));
             creationDate_->setID(creationDateIDRef_);
             IDManager::instance().setID(creationDateIDRef_,creationDate_);
          }
          else if(creationDateNode->Attribute("href")) { creationDateIDRef_ = creationDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { creationDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(creationDateNode));}
   }

   //originatingEventNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* originatingEventNode = xmlNode->FirstChildElement("originatingEvent");

   if(originatingEventNode){originatingEventIsNull_ = false;}
   else{originatingEventIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- originatingEventNode , address : " << originatingEventNode << std::endl;
   #endif
   if(originatingEventNode)
   {
      if(originatingEventNode->Attribute("href") || originatingEventNode->Attribute("id"))
      {
          if(originatingEventNode->Attribute("id"))
          {
             originatingEventIDRef_ = originatingEventNode->Attribute("id");
             originatingEvent_ = boost::shared_ptr<PositionOriginEnum>(new PositionOriginEnum(originatingEventNode));
             originatingEvent_->setID(originatingEventIDRef_);
             IDManager::instance().setID(originatingEventIDRef_,originatingEvent_);
          }
          else if(originatingEventNode->Attribute("href")) { originatingEventIDRef_ = originatingEventNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { originatingEvent_ = boost::shared_ptr<PositionOriginEnum>(new PositionOriginEnum(originatingEventNode));}
   }

   //historyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* historyNode = xmlNode->FirstChildElement("history");

   if(historyNode){historyIsNull_ = false;}
   else{historyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- historyNode , address : " << historyNode << std::endl;
   #endif
   if(historyNode)
   {
      if(historyNode->Attribute("href") || historyNode->Attribute("id"))
      {
          if(historyNode->Attribute("id"))
          {
             historyIDRef_ = historyNode->Attribute("id");
             history_ = boost::shared_ptr<PositionHistory>(new PositionHistory(historyNode));
             history_->setID(historyIDRef_);
             IDManager::instance().setID(historyIDRef_,history_);
          }
          else if(historyNode->Attribute("href")) { historyIDRef_ = historyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { history_ = boost::shared_ptr<PositionHistory>(new PositionHistory(historyNode));}
   }

   //reportingRolesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* reportingRolesNode = xmlNode->FirstChildElement("reportingRoles");

   if(reportingRolesNode){reportingRolesIsNull_ = false;}
   else{reportingRolesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- reportingRolesNode , address : " << reportingRolesNode << std::endl;
   #endif
   if(reportingRolesNode)
   {
      if(reportingRolesNode->Attribute("href") || reportingRolesNode->Attribute("id"))
      {
          if(reportingRolesNode->Attribute("id"))
          {
             reportingRolesIDRef_ = reportingRolesNode->Attribute("id");
             reportingRoles_ = boost::shared_ptr<ReportingRoles>(new ReportingRoles(reportingRolesNode));
             reportingRoles_->setID(reportingRolesIDRef_);
             IDManager::instance().setID(reportingRolesIDRef_,reportingRoles_);
          }
          else if(reportingRolesNode->Attribute("href")) { reportingRolesIDRef_ = reportingRolesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { reportingRoles_ = boost::shared_ptr<ReportingRoles>(new ReportingRoles(reportingRolesNode));}
   }

   //constituentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* constituentNode = xmlNode->FirstChildElement("constituent");

   if(constituentNode){constituentIsNull_ = false;}
   else{constituentIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- constituentNode , address : " << constituentNode << std::endl;
   #endif
   if(constituentNode)
   {
      if(constituentNode->Attribute("href") || constituentNode->Attribute("id"))
      {
          if(constituentNode->Attribute("id"))
          {
             constituentIDRef_ = constituentNode->Attribute("id");
             constituent_ = boost::shared_ptr<PositionConstituent>(new PositionConstituent(constituentNode));
             constituent_->setID(constituentIDRef_);
             IDManager::instance().setID(constituentIDRef_,constituent_);
          }
          else if(constituentNode->Attribute("href")) { constituentIDRef_ = constituentNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { constituent_ = boost::shared_ptr<PositionConstituent>(new PositionConstituent(constituentNode));}
   }

   //scheduledDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* scheduledDateNode = xmlNode->FirstChildElement("scheduledDate");

   if(scheduledDateNode){scheduledDateIsNull_ = false;}
   else{scheduledDateIsNull_ = true;}

   if(scheduledDateNode)
   {
      for(scheduledDateNode; scheduledDateNode; scheduledDateNode = scheduledDateNode->NextSiblingElement("scheduledDate")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- scheduledDateNode , address : " << scheduledDateNode << std::endl;
          #endif
          if(scheduledDateNode->Attribute("href") || scheduledDateNode->Attribute("id"))
          {
              if(scheduledDateNode->Attribute("id"))
              {
                  scheduledDateIDRef_ = scheduledDateNode->Attribute("id");
                  scheduledDate_.push_back(boost::shared_ptr<ScheduledDate>(new ScheduledDate(scheduledDateNode)));
                  scheduledDate_.back()->setID(scheduledDateIDRef_);
                  IDManager::instance().setID(scheduledDateIDRef_, scheduledDate_.back());
              }
              else if(scheduledDateNode->Attribute("href")) { scheduledDateIDRef_ = scheduledDateNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { scheduledDate_.push_back(boost::shared_ptr<ScheduledDate>(new ScheduledDate(scheduledDateNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- scheduledDateNode , address : " << scheduledDateNode << std::endl;
       #endif
   }

   //valuationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* valuationNode = xmlNode->FirstChildElement("valuation");

   if(valuationNode){valuationIsNull_ = false;}
   else{valuationIsNull_ = true;}

   if(valuationNode)
   {
      for(valuationNode; valuationNode; valuationNode = valuationNode->NextSiblingElement("valuation")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- valuationNode , address : " << valuationNode << std::endl;
          #endif
          if(valuationNode->Attribute("href") || valuationNode->Attribute("id"))
          {
              if(valuationNode->Attribute("id"))
              {
                  valuationIDRef_ = valuationNode->Attribute("id");
                  valuation_.push_back(boost::shared_ptr<AssetValuation>(new AssetValuation(valuationNode)));
                  valuation_.back()->setID(valuationIDRef_);
                  IDManager::instance().setID(valuationIDRef_, valuation_.back());
              }
              else if(valuationNode->Attribute("href")) { valuationIDRef_ = valuationNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { valuation_.push_back(boost::shared_ptr<AssetValuation>(new AssetValuation(valuationNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- valuationNode , address : " << valuationNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PositionId> Position::getPositionId()
{
   if(!this->positionIdIsNull_){
        if(positionIdIDRef_ != ""){
             return boost::shared_static_cast<PositionId>(IDManager::instance().getID(positionIdIDRef_));
        }else{
             return this->positionId_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PositionId>();
   }
}
boost::shared_ptr<XsdTypePositiveInteger> Position::getVersion()
{
   if(!this->versionIsNull_){
        if(versionIDRef_ != ""){
             return boost::shared_static_cast<XsdTypePositiveInteger>(IDManager::instance().getID(versionIDRef_));
        }else{
             return this->version_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypePositiveInteger>();
   }
}
boost::shared_ptr<PositionStatusEnum> Position::getStatus()
{
   if(!this->statusIsNull_){
        if(statusIDRef_ != ""){
             return boost::shared_static_cast<PositionStatusEnum>(IDManager::instance().getID(statusIDRef_));
        }else{
             return this->status_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PositionStatusEnum>();
   }
}
boost::shared_ptr<XsdTypeDate> Position::getCreationDate()
{
   if(!this->creationDateIsNull_){
        if(creationDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(creationDateIDRef_));
        }else{
             return this->creationDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<PositionOriginEnum> Position::getOriginatingEvent()
{
   if(!this->originatingEventIsNull_){
        if(originatingEventIDRef_ != ""){
             return boost::shared_static_cast<PositionOriginEnum>(IDManager::instance().getID(originatingEventIDRef_));
        }else{
             return this->originatingEvent_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PositionOriginEnum>();
   }
}
boost::shared_ptr<PositionHistory> Position::getHistory()
{
   if(!this->historyIsNull_){
        if(historyIDRef_ != ""){
             return boost::shared_static_cast<PositionHistory>(IDManager::instance().getID(historyIDRef_));
        }else{
             return this->history_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PositionHistory>();
   }
}
boost::shared_ptr<ReportingRoles> Position::getReportingRoles()
{
   if(!this->reportingRolesIsNull_){
        if(reportingRolesIDRef_ != ""){
             return boost::shared_static_cast<ReportingRoles>(IDManager::instance().getID(reportingRolesIDRef_));
        }else{
             return this->reportingRoles_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ReportingRoles>();
   }
}
boost::shared_ptr<PositionConstituent> Position::getConstituent()
{
   if(!this->constituentIsNull_){
        if(constituentIDRef_ != ""){
             return boost::shared_static_cast<PositionConstituent>(IDManager::instance().getID(constituentIDRef_));
        }else{
             return this->constituent_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PositionConstituent>();
   }
}
std::vector<boost::shared_ptr<ScheduledDate>> Position::getScheduledDate()
{
   if(!this->scheduledDateIsNull_){
        if(scheduledDateIDRef_ != ""){
             return this->scheduledDate_;
        }else{
             return this->scheduledDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<ScheduledDate>>();
   }
}
std::vector<boost::shared_ptr<AssetValuation>> Position::getValuation()
{
   if(!this->valuationIsNull_){
        if(valuationIDRef_ != ""){
             return this->valuation_;
        }else{
             return this->valuation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<AssetValuation>>();
   }
}
}

