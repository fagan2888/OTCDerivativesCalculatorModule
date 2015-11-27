// StandardInstrument.cpp 
#include "StandardInstrument.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

StandardInstrument::StandardInstrument(TiXmlNode* xmlNode)
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
       issueInformation_ = boost::shared_ptr<IssueInformation>(new IssueInformation(issueInformationNode));
   }

   //underlyingInformationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* underlyingInformationNode = xmlNode->FirstChildElement("underlyingInformation");

   if(underlyingInformationNode){underlyingInformationIsNull_ = false;}
   else{underlyingInformationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- underlyingInformationNode , address : " << underlyingInformationNode << std::endl;
   #endif
   if(underlyingInformationNode)
   {
       underlyingInformation_ = boost::shared_ptr<UnderlyingInformation>(new UnderlyingInformation(underlyingInformationNode));
   }

   //payoffInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* payoffInfoNode = xmlNode->FirstChildElement("payoffInfo");

   if(payoffInfoNode){payoffInfoIsNull_ = false;}
   else{payoffInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- payoffInfoNode , address : " << payoffInfoNode << std::endl;
   #endif
   if(payoffInfoNode)
   {
       payoffInfo_ = boost::shared_ptr<PayoffInfo>(new PayoffInfo(payoffInfoNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<IssueInformation> StandardInstrument::getIssueInformation()
{
   if(!this->issueInformationIsNull_){
        return this->issueInformation_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<IssueInformation>();
   }
}
boost::shared_ptr<UnderlyingInformation> StandardInstrument::getUnderlyingInformation()
{
   if(!this->underlyingInformationIsNull_){
        return this->underlyingInformation_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<UnderlyingInformation>();
   }
}
boost::shared_ptr<PayoffInfo> StandardInstrument::getPayoffInfo()
{
   if(!this->payoffInfoIsNull_){
        return this->payoffInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PayoffInfo>();
   }
}
}

