// PayoffDateInfo.cpp 
#include "PayoffDateInfo.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

PayoffDateInfo::PayoffDateInfo(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //fixingDateInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fixingDateInfoNode = xmlNode->FirstChildElement("fixingDateInfo");

   if(fixingDateInfoNode){fixingDateInfoIsNull_ = false;}
   else{fixingDateInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fixingDateInfoNode , address : " << fixingDateInfoNode << std::endl;
   #endif
   if(fixingDateInfoNode)
   {
       fixingDateInfo_ = boost::shared_ptr<FixingDateInfo>(new FixingDateInfo(fixingDateInfoNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<FixingDateInfo> PayoffDateInfo::getFixingDateInfo()
{
   if(!this->fixingDateInfoIsNull_){
        return this->fixingDateInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FixingDateInfo>();
   }
}
}

