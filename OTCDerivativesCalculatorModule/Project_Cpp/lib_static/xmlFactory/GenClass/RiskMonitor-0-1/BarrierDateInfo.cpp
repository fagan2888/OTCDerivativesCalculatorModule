// BarrierDateInfo.cpp 
#include "BarrierDateInfo.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

BarrierDateInfo::BarrierDateInfo(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //dateInformationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dateInformationNode = xmlNode->FirstChildElement("dateInformation");

   if(dateInformationNode){dateInformationIsNull_ = false;}
   else{dateInformationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dateInformationNode , address : " << dateInformationNode << std::endl;
   #endif
   if(dateInformationNode)
   {
       dateInformation_ = boost::shared_ptr<DateInformation>(new DateInformation(dateInformationNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<DateInformation> BarrierDateInfo::getDateInformation()
{
   if(!this->dateInformationIsNull_){
        return this->dateInformation_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DateInformation>();
   }
}
}

