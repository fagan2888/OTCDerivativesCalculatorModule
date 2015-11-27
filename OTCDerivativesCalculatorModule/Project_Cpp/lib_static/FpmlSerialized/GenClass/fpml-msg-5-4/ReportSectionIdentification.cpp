// ReportSectionIdentification.cpp 
#include "ReportSectionIdentification.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ReportSectionIdentification::ReportSectionIdentification(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //reportIdNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* reportIdNode = xmlNode->FirstChildElement("reportId");

   if(reportIdNode){reportIdIsNull_ = false;}
   else{reportIdIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- reportIdNode , address : " << reportIdNode << std::endl;
   #endif
   if(reportIdNode)
   {
      if(reportIdNode->Attribute("href") || reportIdNode->Attribute("id"))
      {
          if(reportIdNode->Attribute("id"))
          {
             reportIdIDRef_ = reportIdNode->Attribute("id");
             reportId_ = boost::shared_ptr<ReportId>(new ReportId(reportIdNode));
             reportId_->setID(reportIdIDRef_);
             IDManager::instance().setID(reportIdIDRef_,reportId_);
          }
          else if(reportIdNode->Attribute("href")) { reportIdIDRef_ = reportIdNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { reportId_ = boost::shared_ptr<ReportId>(new ReportId(reportIdNode));}
   }

   //sectionNumberNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* sectionNumberNode = xmlNode->FirstChildElement("sectionNumber");

   if(sectionNumberNode){sectionNumberIsNull_ = false;}
   else{sectionNumberIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- sectionNumberNode , address : " << sectionNumberNode << std::endl;
   #endif
   if(sectionNumberNode)
   {
      if(sectionNumberNode->Attribute("href") || sectionNumberNode->Attribute("id"))
      {
          if(sectionNumberNode->Attribute("id"))
          {
             sectionNumberIDRef_ = sectionNumberNode->Attribute("id");
             sectionNumber_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(sectionNumberNode));
             sectionNumber_->setID(sectionNumberIDRef_);
             IDManager::instance().setID(sectionNumberIDRef_,sectionNumber_);
          }
          else if(sectionNumberNode->Attribute("href")) { sectionNumberIDRef_ = sectionNumberNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { sectionNumber_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(sectionNumberNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<ReportId> ReportSectionIdentification::getReportId()
{
   if(!this->reportIdIsNull_){
        if(reportIdIDRef_ != ""){
             return boost::shared_static_cast<ReportId>(IDManager::instance().getID(reportIdIDRef_));
        }else{
             return this->reportId_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ReportId>();
   }
}
boost::shared_ptr<XsdTypePositiveInteger> ReportSectionIdentification::getSectionNumber()
{
   if(!this->sectionNumberIsNull_){
        if(sectionNumberIDRef_ != ""){
             return boost::shared_static_cast<XsdTypePositiveInteger>(IDManager::instance().getID(sectionNumberIDRef_));
        }else{
             return this->sectionNumber_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypePositiveInteger>();
   }
}
}

