// PortfolioReference.cpp 
#include "PortfolioReference.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

PortfolioReference::PortfolioReference(TiXmlNode* xmlNode)
: PortfolioReferenceBase(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //sequenceNumberNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* sequenceNumberNode = xmlNode->FirstChildElement("sequenceNumber");

   if(sequenceNumberNode){sequenceNumberIsNull_ = false;}
   else{sequenceNumberIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- sequenceNumberNode , address : " << sequenceNumberNode << std::endl;
   #endif
   if(sequenceNumberNode)
   {
      if(sequenceNumberNode->Attribute("href") || sequenceNumberNode->Attribute("id"))
      {
          if(sequenceNumberNode->Attribute("id"))
          {
             sequenceNumberIDRef_ = sequenceNumberNode->Attribute("id");
             sequenceNumber_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(sequenceNumberNode));
             sequenceNumber_->setID(sequenceNumberIDRef_);
             IDManager::instance().setID(sequenceNumberIDRef_,sequenceNumber_);
          }
          else if(sequenceNumberNode->Attribute("href")) { sequenceNumberIDRef_ = sequenceNumberNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { sequenceNumber_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(sequenceNumberNode));}
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
boost::shared_ptr<XsdTypePositiveInteger> PortfolioReference::getSequenceNumber()
{
   if(!this->sequenceNumberIsNull_){
        if(sequenceNumberIDRef_ != ""){
             return boost::shared_static_cast<XsdTypePositiveInteger>(IDManager::instance().getID(sequenceNumberIDRef_));
        }else{
             return this->sequenceNumber_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypePositiveInteger>();
   }
}
boost::shared_ptr<XsdTypeBoolean> PortfolioReference::getSubmissionsComplete()
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

