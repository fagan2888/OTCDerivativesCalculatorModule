// InstrumentList.cpp 
#include "InstrumentList.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

InstrumentList::InstrumentList(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //instHirachyInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* instHirachyInfoNode = xmlNode->FirstChildElement("instHirachyInfo");

   if(instHirachyInfoNode){instHirachyInfoIsNull_ = false;}
   else{instHirachyInfoIsNull_ = true;}

   if(instHirachyInfoNode)
   {
      for(instHirachyInfoNode; instHirachyInfoNode; instHirachyInfoNode = instHirachyInfoNode->NextSiblingElement("instHirachyInfo")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- instHirachyInfoNode , address : " << instHirachyInfoNode << std::endl;
          #endif
          instHirachyInfo_.push_back(boost::shared_ptr<InstHirachyInfo>(new InstHirachyInfo(instHirachyInfoNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- instHirachyInfoNode , address : " << instHirachyInfoNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<InstHirachyInfo>> InstrumentList::getInstHirachyInfo()
{
   if(!this->instHirachyInfoIsNull_){
        return this->instHirachyInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<InstHirachyInfo>>();
   }
}
}

