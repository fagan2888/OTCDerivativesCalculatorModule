// ConditionOperator.cpp 
#include "ConditionOperator.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ConditionOperator::ConditionOperator(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //rangeCondition1DNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* rangeCondition1DNode = xmlNode->FirstChildElement("rangeCondition1D");

   if(rangeCondition1DNode){rangeCondition1DIsNull_ = false;}
   else{rangeCondition1DIsNull_ = true;}

   if(rangeCondition1DNode)
   {
      for(rangeCondition1DNode; rangeCondition1DNode; rangeCondition1DNode = rangeCondition1DNode->NextSiblingElement("rangeCondition1D")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- rangeCondition1DNode , address : " << rangeCondition1DNode << std::endl;
          #endif
          rangeCondition1D_.push_back(boost::shared_ptr<RangeCondition1D>(new RangeCondition1D(rangeCondition1DNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- rangeCondition1DNode , address : " << rangeCondition1DNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<RangeCondition1D>> ConditionOperator::getRangeCondition1D()
{
   if(!this->rangeCondition1DIsNull_){
        return this->rangeCondition1D_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<RangeCondition1D>>();
   }
}
}

