// ReportIdentification.cpp 
#include "ReportIdentification.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ReportIdentification::ReportIdentification(TiXmlNode* xmlNode)
: ReportSectionIdentification(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //numberOfSectionsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* numberOfSectionsNode = xmlNode->FirstChildElement("numberOfSections");

   if(numberOfSectionsNode){numberOfSectionsIsNull_ = false;}
   else{numberOfSectionsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- numberOfSectionsNode , address : " << numberOfSectionsNode << std::endl;
   #endif
   if(numberOfSectionsNode)
   {
      if(numberOfSectionsNode->Attribute("href") || numberOfSectionsNode->Attribute("id"))
      {
          if(numberOfSectionsNode->Attribute("id"))
          {
             numberOfSectionsIDRef_ = numberOfSectionsNode->Attribute("id");
             numberOfSections_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(numberOfSectionsNode));
             numberOfSections_->setID(numberOfSectionsIDRef_);
             IDManager::instance().setID(numberOfSectionsIDRef_,numberOfSections_);
          }
          else if(numberOfSectionsNode->Attribute("href")) { numberOfSectionsIDRef_ = numberOfSectionsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { numberOfSections_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(numberOfSectionsNode));}
   }

   //submissionsCompleteNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* submissionsCompleteNode = xmlNode->FirstChildElement("submissionsComplete");

   if(submissionsCompleteNode){submissionsCompleteIsNull_ = false;}
   else{submissionsCompleteIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- submissionsCompleteNode , address : " << submissionsCompleteNode << std::endl;
   #endif
   if(submissionsCompleteNode)
   {
      if(submissionsCompleteNode->Attribute("href") || submissionsCompleteNode->Attribute("id"))
      {
          if(submissionsCompleteNode->Attribute("id"))
          {
             submissionsCompleteIDRef_ = submissionsCompleteNode->Attribute("id");
             submissionsComplete_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(submissionsCompleteNode));
             submissionsComplete_->setID(submissionsCompleteIDRef_);
             IDManager::instance().setID(submissionsCompleteIDRef_,submissionsComplete_);
          }
          else if(submissionsCompleteNode->Attribute("href")) { submissionsCompleteIDRef_ = submissionsCompleteNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { submissionsComplete_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(submissionsCompleteNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypePositiveInteger> ReportIdentification::getNumberOfSections()
{
   if(!this->numberOfSectionsIsNull_){
        if(numberOfSectionsIDRef_ != ""){
             return boost::shared_static_cast<XsdTypePositiveInteger>(IDManager::instance().getID(numberOfSectionsIDRef_));
        }else{
             return this->numberOfSections_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypePositiveInteger>();
   }
}
boost::shared_ptr<XsdTypeBoolean> ReportIdentification::getSubmissionsComplete()
{
   if(!this->submissionsCompleteIsNull_){
        if(submissionsCompleteIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(submissionsCompleteIDRef_));
        }else{
             return this->submissionsComplete_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
}

