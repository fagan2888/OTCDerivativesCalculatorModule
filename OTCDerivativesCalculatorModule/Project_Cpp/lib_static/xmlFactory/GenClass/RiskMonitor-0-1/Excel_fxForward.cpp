// Excel_fxForward.cpp 
#include "Excel_fxForward.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_fxForward::Excel_fxForward(TiXmlNode* xmlNode)
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

   //fx_exchangeLegNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fx_exchangeLegNode = xmlNode->FirstChildElement("fx_exchangeLeg");

   if(fx_exchangeLegNode){fx_exchangeLegIsNull_ = false;}
   else{fx_exchangeLegIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fx_exchangeLegNode , address : " << fx_exchangeLegNode << std::endl;
   #endif
   if(fx_exchangeLegNode)
   {
       fx_exchangeLeg_ = boost::shared_ptr<Fx_exchangeLeg>(new Fx_exchangeLeg(fx_exchangeLegNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Excel_issueInfo> Excel_fxForward::getExcel_issueInfo()
{
   if(!this->excel_issueInfoIsNull_){
        return this->excel_issueInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_issueInfo>();
   }
}
boost::shared_ptr<Fx_exchangeLeg> Excel_fxForward::getFx_exchangeLeg()
{
   if(!this->fx_exchangeLegIsNull_){
        return this->fx_exchangeLeg_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Fx_exchangeLeg>();
   }
}
}

