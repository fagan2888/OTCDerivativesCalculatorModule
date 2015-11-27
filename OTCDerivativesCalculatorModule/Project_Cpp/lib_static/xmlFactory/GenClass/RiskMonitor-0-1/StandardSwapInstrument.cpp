// StandardSwapInstrument.cpp 
#include "StandardSwapInstrument.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

StandardSwapInstrument::StandardSwapInstrument(TiXmlNode* xmlNode)
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

   //swapPayoffInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* swapPayoffInfoNode = xmlNode->FirstChildElement("swapPayoffInfo");

   if(swapPayoffInfoNode){swapPayoffInfoIsNull_ = false;}
   else{swapPayoffInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- swapPayoffInfoNode , address : " << swapPayoffInfoNode << std::endl;
   #endif
   if(swapPayoffInfoNode)
   {
       swapPayoffInfo_ = boost::shared_ptr<SwapPayoffInfo>(new SwapPayoffInfo(swapPayoffInfoNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<IssueInformation> StandardSwapInstrument::getIssueInformation()
{
   if(!this->issueInformationIsNull_){
        return this->issueInformation_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<IssueInformation>();
   }
}
boost::shared_ptr<UnderlyingInformation> StandardSwapInstrument::getUnderlyingInformation()
{
   if(!this->underlyingInformationIsNull_){
        return this->underlyingInformation_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<UnderlyingInformation>();
   }
}
boost::shared_ptr<SwapPayoffInfo> StandardSwapInstrument::getSwapPayoffInfo()
{
   if(!this->swapPayoffInfoIsNull_){
        return this->swapPayoffInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<SwapPayoffInfo>();
   }
}
}

