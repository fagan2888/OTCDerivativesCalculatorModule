// Excel_fxSwap.cpp 
#include "Excel_fxSwap.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_fxSwap::Excel_fxSwap(TiXmlNode* xmlNode)
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

   if(fx_exchangeLegNode)
   {
      for(fx_exchangeLegNode; fx_exchangeLegNode; fx_exchangeLegNode = fx_exchangeLegNode->NextSiblingElement("fx_exchangeLeg")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fx_exchangeLegNode , address : " << fx_exchangeLegNode << std::endl;
          #endif
          fx_exchangeLeg_.push_back(boost::shared_ptr<Fx_exchangeLeg>(new Fx_exchangeLeg(fx_exchangeLegNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fx_exchangeLegNode , address : " << fx_exchangeLegNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Excel_issueInfo> Excel_fxSwap::getExcel_issueInfo()
{
   if(!this->excel_issueInfoIsNull_){
        return this->excel_issueInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_issueInfo>();
   }
}
std::vector<boost::shared_ptr<Fx_exchangeLeg>> Excel_fxSwap::getFx_exchangeLeg()
{
   if(!this->fx_exchangeLegIsNull_){
        return this->fx_exchangeLeg_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Fx_exchangeLeg>>();
   }
}
}

