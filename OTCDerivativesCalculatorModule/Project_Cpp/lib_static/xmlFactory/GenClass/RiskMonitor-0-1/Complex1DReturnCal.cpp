// Complex1DReturnCal.cpp 
#include "Complex1DReturnCal.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Complex1DReturnCal::Complex1DReturnCal(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //variableCalculationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* variableCalculationNode = xmlNode->FirstChildElement("variableCalculation");

   if(variableCalculationNode){variableCalculationIsNull_ = false;}
   else{variableCalculationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- variableCalculationNode , address : " << variableCalculationNode << std::endl;
   #endif
   if(variableCalculationNode)
   {
       variableCalculation_ = boost::shared_ptr<VariableCalculation>(new VariableCalculation(variableCalculationNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<VariableCalculation> Complex1DReturnCal::getVariableCalculation()
{
   if(!this->variableCalculationIsNull_){
        return this->variableCalculation_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<VariableCalculation>();
   }
}
}

