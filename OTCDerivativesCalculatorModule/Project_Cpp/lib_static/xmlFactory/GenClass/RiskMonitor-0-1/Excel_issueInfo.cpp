// Excel_issueInfo.cpp 
#include "Excel_issueInfo.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_issueInfo::Excel_issueInfo(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //excel_typeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_typeNode = xmlNode->FirstChildElement("excel_type");

   if(excel_typeNode){excel_typeIsNull_ = false;}
   else{excel_typeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_typeNode , address : " << excel_typeNode << std::endl;
   #endif
   if(excel_typeNode)
   {
       excel_type_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(excel_typeNode));
   }

   //excel_noteInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_noteInfoNode = xmlNode->FirstChildElement("excel_noteInfo");

   if(excel_noteInfoNode){excel_noteInfoIsNull_ = false;}
   else{excel_noteInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_noteInfoNode , address : " << excel_noteInfoNode << std::endl;
   #endif
   if(excel_noteInfoNode)
   {
       excel_noteInfo_ = boost::shared_ptr<Excel_noteInfo>(new Excel_noteInfo(excel_noteInfoNode));
   }

   //excel_swapInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_swapInfoNode = xmlNode->FirstChildElement("excel_swapInfo");

   if(excel_swapInfoNode){excel_swapInfoIsNull_ = false;}
   else{excel_swapInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_swapInfoNode , address : " << excel_swapInfoNode << std::endl;
   #endif
   if(excel_swapInfoNode)
   {
       excel_swapInfo_ = boost::shared_ptr<Excel_swapInfo>(new Excel_swapInfo(excel_swapInfoNode));
   }

   //excel_swapLegInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_swapLegInfoNode = xmlNode->FirstChildElement("excel_swapLegInfo");

   if(excel_swapLegInfoNode){excel_swapLegInfoIsNull_ = false;}
   else{excel_swapLegInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_swapLegInfoNode , address : " << excel_swapLegInfoNode << std::endl;
   #endif
   if(excel_swapLegInfoNode)
   {
       excel_swapLegInfo_ = boost::shared_ptr<Excel_swapLegInfo>(new Excel_swapLegInfo(excel_swapLegInfoNode));
   }

   //excel_emptyInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_emptyInfoNode = xmlNode->FirstChildElement("excel_emptyInfo");

   if(excel_emptyInfoNode){excel_emptyInfoIsNull_ = false;}
   else{excel_emptyInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_emptyInfoNode , address : " << excel_emptyInfoNode << std::endl;
   #endif
   if(excel_emptyInfoNode)
   {
       excel_emptyInfo_ = boost::shared_ptr<Excel_emptyInfo>(new Excel_emptyInfo(excel_emptyInfoNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_issueInfo::getExcel_type()
{
   if(!this->excel_typeIsNull_){
        return this->excel_type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<Excel_noteInfo> Excel_issueInfo::getExcel_noteInfo()
{
   if(!this->excel_noteInfoIsNull_){
        return this->excel_noteInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_noteInfo>();
   }
}
boost::shared_ptr<Excel_swapInfo> Excel_issueInfo::getExcel_swapInfo()
{
   if(!this->excel_swapInfoIsNull_){
        return this->excel_swapInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_swapInfo>();
   }
}
boost::shared_ptr<Excel_swapLegInfo> Excel_issueInfo::getExcel_swapLegInfo()
{
   if(!this->excel_swapLegInfoIsNull_){
        return this->excel_swapLegInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_swapLegInfo>();
   }
}
boost::shared_ptr<Excel_emptyInfo> Excel_issueInfo::getExcel_emptyInfo()
{
   if(!this->excel_emptyInfoIsNull_){
        return this->excel_emptyInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_emptyInfo>();
   }
}
}

