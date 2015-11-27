// CapFloorOption.cpp 
#include "CapFloorOption.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CapFloorOption::CapFloorOption(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //capOptionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* capOptionNode = xmlNode->FirstChildElement("capOption");

   if(capOptionNode){capOptionIsNull_ = false;}
   else{capOptionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- capOptionNode , address : " << capOptionNode << std::endl;
   #endif
   if(capOptionNode)
   {
       capOption_ = boost::shared_ptr<CapOption>(new CapOption(capOptionNode));
   }

   //floorOptionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* floorOptionNode = xmlNode->FirstChildElement("floorOption");

   if(floorOptionNode){floorOptionIsNull_ = false;}
   else{floorOptionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- floorOptionNode , address : " << floorOptionNode << std::endl;
   #endif
   if(floorOptionNode)
   {
       floorOption_ = boost::shared_ptr<FloorOption>(new FloorOption(floorOptionNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<CapOption> CapFloorOption::getCapOption()
{
   if(!this->capOptionIsNull_){
        return this->capOption_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CapOption>();
   }
}
boost::shared_ptr<FloorOption> CapFloorOption::getFloorOption()
{
   if(!this->floorOptionIsNull_){
        return this->floorOption_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FloorOption>();
   }
}
}

