// Excel_creditEventInfo.cpp 
#include "Excel_creditEventInfo.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_creditEventInfo::Excel_creditEventInfo(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //excel_issueInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_issueInfoNode = xmlNode->FirstChildElement("excel_issueInfo");

   if(excel_issueInfoNode){excel_issueInfoIsNull_ = false;}
   else{excel_issueInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_issueInfoNode , address : " << excel_issueInfoNode << std::endl;
   #endif
   if(excel_issueInfoNode)
   {
       excel_issueInfo_ = boost::shared_ptr<Excel_issueInfo>(new Excel_issueInfo(excel_issueInfoNode));
   }

   //excel_referenceInformationListNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_referenceInformationListNode = xmlNode->FirstChildElement("excel_referenceInformationList");

   if(excel_referenceInformationListNode){excel_referenceInformationListIsNull_ = false;}
   else{excel_referenceInformationListIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_referenceInformationListNode , address : " << excel_referenceInformationListNode << std::endl;
   #endif
   if(excel_referenceInformationListNode)
   {
       excel_referenceInformationList_ = boost::shared_ptr<Excel_referenceInformationList>(new Excel_referenceInformationList(excel_referenceInformationListNode));
   }

   //excel_jointProbabilityTraitNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_jointProbabilityTraitNode = xmlNode->FirstChildElement("excel_jointProbabilityTrait");

   if(excel_jointProbabilityTraitNode){excel_jointProbabilityTraitIsNull_ = false;}
   else{excel_jointProbabilityTraitIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_jointProbabilityTraitNode , address : " << excel_jointProbabilityTraitNode << std::endl;
   #endif
   if(excel_jointProbabilityTraitNode)
   {
       excel_jointProbabilityTrait_ = boost::shared_ptr<Excel_jointProbabilityTrait>(new Excel_jointProbabilityTrait(excel_jointProbabilityTraitNode));
   }

   //excel_protectionTermsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_protectionTermsNode = xmlNode->FirstChildElement("excel_protectionTerms");

   if(excel_protectionTermsNode){excel_protectionTermsIsNull_ = false;}
   else{excel_protectionTermsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_protectionTermsNode , address : " << excel_protectionTermsNode << std::endl;
   #endif
   if(excel_protectionTermsNode)
   {
       excel_protectionTerms_ = boost::shared_ptr<Excel_protectionTerms>(new Excel_protectionTerms(excel_protectionTermsNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Excel_issueInfo> Excel_creditEventInfo::getExcel_issueInfo()
{
   if(!this->excel_issueInfoIsNull_){
        return this->excel_issueInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_issueInfo>();
   }
}
boost::shared_ptr<Excel_referenceInformationList> Excel_creditEventInfo::getExcel_referenceInformationList()
{
   if(!this->excel_referenceInformationListIsNull_){
        return this->excel_referenceInformationList_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_referenceInformationList>();
   }
}
boost::shared_ptr<Excel_jointProbabilityTrait> Excel_creditEventInfo::getExcel_jointProbabilityTrait()
{
   if(!this->excel_jointProbabilityTraitIsNull_){
        return this->excel_jointProbabilityTrait_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_jointProbabilityTrait>();
   }
}
boost::shared_ptr<Excel_protectionTerms> Excel_creditEventInfo::getExcel_protectionTerms()
{
   if(!this->excel_protectionTermsIsNull_){
        return this->excel_protectionTerms_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_protectionTerms>();
   }
}
}

