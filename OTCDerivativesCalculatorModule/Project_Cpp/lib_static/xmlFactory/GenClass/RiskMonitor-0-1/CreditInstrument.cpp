// CreditInstrument.cpp 
#include "CreditInstrument.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CreditInstrument::CreditInstrument(TiXmlNode* xmlNode)
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

   //creditPayoffInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* creditPayoffInfoNode = xmlNode->FirstChildElement("creditPayoffInfo");

   if(creditPayoffInfoNode){creditPayoffInfoIsNull_ = false;}
   else{creditPayoffInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- creditPayoffInfoNode , address : " << creditPayoffInfoNode << std::endl;
   #endif
   if(creditPayoffInfoNode)
   {
       creditPayoffInfo_ = boost::shared_ptr<CreditPayoffInfo>(new CreditPayoffInfo(creditPayoffInfoNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<IssueInformation> CreditInstrument::getIssueInformation()
{
   if(!this->issueInformationIsNull_){
        return this->issueInformation_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<IssueInformation>();
   }
}
boost::shared_ptr<UnderlyingInformation> CreditInstrument::getUnderlyingInformation()
{
   if(!this->underlyingInformationIsNull_){
        return this->underlyingInformation_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<UnderlyingInformation>();
   }
}
boost::shared_ptr<CreditPayoffInfo> CreditInstrument::getCreditPayoffInfo()
{
   if(!this->creditPayoffInfoIsNull_){
        return this->creditPayoffInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CreditPayoffInfo>();
   }
}
}

