// DataValueInfo.cpp 
#include "DataValueInfo.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

DataValueInfo::DataValueInfo(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //dataValueNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dataValueNode = xmlNode->FirstChildElement("dataValue");

   if(dataValueNode){dataValueIsNull_ = false;}
   else{dataValueIsNull_ = true;}

   if(dataValueNode)
   {
      for(dataValueNode; dataValueNode; dataValueNode = dataValueNode->NextSiblingElement("dataValue")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dataValueNode , address : " << dataValueNode << std::endl;
          #endif
          dataValue_.push_back(boost::shared_ptr<DataValue>(new DataValue(dataValueNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dataValueNode , address : " << dataValueNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<DataValue>> DataValueInfo::getDataValue()
{
   if(!this->dataValueIsNull_){
        return this->dataValue_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<DataValue>>();
   }
}
}

