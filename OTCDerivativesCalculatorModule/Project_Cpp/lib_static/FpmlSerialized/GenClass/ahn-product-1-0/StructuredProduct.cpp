// StructuredProduct.cpp 
#include "StructuredProduct.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

StructuredProduct::StructuredProduct(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //issueInformationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* issueInformationNode = xmlNode->FirstChildElement("issueInformation");

   if(issueInformationNode){issueInformationIsNull_ = false;}
   else{issueInformationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- issueInformationNode , address : " << issueInformationNode << std::endl;
   #endif
   if(issueInformationNode)
   {
      if(issueInformationNode->Attribute("href") || issueInformationNode->Attribute("id"))
      {
          if(issueInformationNode->Attribute("id"))
          {
             issueInformationIDRef_ = issueInformationNode->Attribute("id");
             issueInformation_ = boost::shared_ptr<IssueInformation>(new IssueInformation(issueInformationNode));
             issueInformation_->setID(issueInformationIDRef_);
             IDManager::instance().setID(issueInformationIDRef_,issueInformation_);
          }
          else if(issueInformationNode->Attribute("href")) { issueInformationIDRef_ = issueInformationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { issueInformation_ = boost::shared_ptr<IssueInformation>(new IssueInformation(issueInformationNode));}
   }

   //structuredProductPayoffNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* structuredProductPayoffNode = xmlNode->FirstChildElement("structuredProductPayoff");

   if(structuredProductPayoffNode){structuredProductPayoffIsNull_ = false;}
   else{structuredProductPayoffIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- structuredProductPayoffNode , address : " << structuredProductPayoffNode << std::endl;
   #endif
   if(structuredProductPayoffNode)
   {
      if(structuredProductPayoffNode->Attribute("href") || structuredProductPayoffNode->Attribute("id"))
      {
          if(structuredProductPayoffNode->Attribute("id"))
          {
             structuredProductPayoffIDRef_ = structuredProductPayoffNode->Attribute("id");
             structuredProductPayoff_ = boost::shared_ptr<StructuredProductPayoff>(new StructuredProductPayoff(structuredProductPayoffNode));
             structuredProductPayoff_->setID(structuredProductPayoffIDRef_);
             IDManager::instance().setID(structuredProductPayoffIDRef_,structuredProductPayoff_);
          }
          else if(structuredProductPayoffNode->Attribute("href")) { structuredProductPayoffIDRef_ = structuredProductPayoffNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { structuredProductPayoff_ = boost::shared_ptr<StructuredProductPayoff>(new StructuredProductPayoff(structuredProductPayoffNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<IssueInformation> StructuredProduct::getIssueInformation()
{
   if(!this->issueInformationIsNull_){
        if(issueInformationIDRef_ != ""){
             return boost::shared_static_cast<IssueInformation>(IDManager::instance().getID(issueInformationIDRef_));
        }else{
             return this->issueInformation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<IssueInformation>();
   }
}
boost::shared_ptr<StructuredProductPayoff> StructuredProduct::getStructuredProductPayoff()
{
   if(!this->structuredProductPayoffIsNull_){
        if(structuredProductPayoffIDRef_ != ""){
             return boost::shared_static_cast<StructuredProductPayoff>(IDManager::instance().getID(structuredProductPayoffIDRef_));
        }else{
             return this->structuredProductPayoff_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<StructuredProductPayoff>();
   }
}
}

