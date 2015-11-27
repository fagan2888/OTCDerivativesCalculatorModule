// ReturnCalculationInfo.cpp 
#include "ReturnCalculationInfo.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ReturnCalculationInfo::ReturnCalculationInfo(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //returnCalculationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* returnCalculationNode = xmlNode->FirstChildElement("returnCalculation");

   if(returnCalculationNode){returnCalculationIsNull_ = false;}
   else{returnCalculationIsNull_ = true;}

   if(returnCalculationNode)
   {
      for(returnCalculationNode; returnCalculationNode; returnCalculationNode = returnCalculationNode->NextSiblingElement("returnCalculation")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- returnCalculationNode , address : " << returnCalculationNode << std::endl;
          #endif
          returnCalculation_.push_back(boost::shared_ptr<ReturnCalculation>(new ReturnCalculation(returnCalculationNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- returnCalculationNode , address : " << returnCalculationNode << std::endl;
       #endif
   }

   //operatorNDNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* operatorNDNode = xmlNode->FirstChildElement("operatorND");

   if(operatorNDNode){operatorNDIsNull_ = false;}
   else{operatorNDIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- operatorNDNode , address : " << operatorNDNode << std::endl;
   #endif
   if(operatorNDNode)
   {
       operatorND_ = boost::shared_ptr<OperatorND>(new OperatorND(operatorNDNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<ReturnCalculation>> ReturnCalculationInfo::getReturnCalculation()
{
   if(!this->returnCalculationIsNull_){
        return this->returnCalculation_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<ReturnCalculation>>();
   }
}
boost::shared_ptr<OperatorND> ReturnCalculationInfo::getOperatorND()
{
   if(!this->operatorNDIsNull_){
        return this->operatorND_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<OperatorND>();
   }
}
}

