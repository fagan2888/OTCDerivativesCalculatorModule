// SimpleRangeReturnList.cpp 
#include "SimpleRangeReturnList.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

SimpleRangeReturnList::SimpleRangeReturnList(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //simpleRangeReturnNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* simpleRangeReturnNode = xmlNode->FirstChildElement("simpleRangeReturn");

   if(simpleRangeReturnNode){simpleRangeReturnIsNull_ = false;}
   else{simpleRangeReturnIsNull_ = true;}

   if(simpleRangeReturnNode)
   {
      for(simpleRangeReturnNode; simpleRangeReturnNode; simpleRangeReturnNode = simpleRangeReturnNode->NextSiblingElement("simpleRangeReturn")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- simpleRangeReturnNode , address : " << simpleRangeReturnNode << std::endl;
          #endif
          simpleRangeReturn_.push_back(boost::shared_ptr<SimpleRangeReturn>(new SimpleRangeReturn(simpleRangeReturnNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- simpleRangeReturnNode , address : " << simpleRangeReturnNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<SimpleRangeReturn>> SimpleRangeReturnList::getSimpleRangeReturn()
{
   if(!this->simpleRangeReturnIsNull_){
        return this->simpleRangeReturn_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<SimpleRangeReturn>>();
   }
}
}

