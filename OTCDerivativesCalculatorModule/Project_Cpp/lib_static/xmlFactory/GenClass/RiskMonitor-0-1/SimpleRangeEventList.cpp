// SimpleRangeEventList.cpp 
#include "SimpleRangeEventList.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

SimpleRangeEventList::SimpleRangeEventList(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //simpleRangeEventCalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* simpleRangeEventCalNode = xmlNode->FirstChildElement("simpleRangeEventCal");

   if(simpleRangeEventCalNode){simpleRangeEventCalIsNull_ = false;}
   else{simpleRangeEventCalIsNull_ = true;}

   if(simpleRangeEventCalNode)
   {
      for(simpleRangeEventCalNode; simpleRangeEventCalNode; simpleRangeEventCalNode = simpleRangeEventCalNode->NextSiblingElement("simpleRangeEventCal")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- simpleRangeEventCalNode , address : " << simpleRangeEventCalNode << std::endl;
          #endif
          simpleRangeEventCal_.push_back(boost::shared_ptr<SimpleRangeEventCal>(new SimpleRangeEventCal(simpleRangeEventCalNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- simpleRangeEventCalNode , address : " << simpleRangeEventCalNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<SimpleRangeEventCal>> SimpleRangeEventList::getSimpleRangeEventCal()
{
   if(!this->simpleRangeEventCalIsNull_){
        return this->simpleRangeEventCal_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<SimpleRangeEventCal>>();
   }
}
}

