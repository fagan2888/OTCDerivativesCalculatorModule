// VariableCalculation.cpp 
#include "VariableCalculation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

VariableCalculation::VariableCalculation(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //referenceCalculationInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* referenceCalculationInfoNode = xmlNode->FirstChildElement("referenceCalculationInfo");

   if(referenceCalculationInfoNode){referenceCalculationInfoIsNull_ = false;}
   else{referenceCalculationInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- referenceCalculationInfoNode , address : " << referenceCalculationInfoNode << std::endl;
   #endif
   if(referenceCalculationInfoNode)
   {
       referenceCalculationInfo_ = boost::shared_ptr<ReferenceCalculationInfo>(new ReferenceCalculationInfo(referenceCalculationInfoNode));
   }

   //operator1DListNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* operator1DListNode = xmlNode->FirstChildElement("operator1DList");

   if(operator1DListNode){operator1DListIsNull_ = false;}
   else{operator1DListIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- operator1DListNode , address : " << operator1DListNode << std::endl;
   #endif
   if(operator1DListNode)
   {
       operator1DList_ = boost::shared_ptr<Operator1DList>(new Operator1DList(operator1DListNode));
   }

   //conditionOperatorNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* conditionOperatorNode = xmlNode->FirstChildElement("conditionOperator");

   if(conditionOperatorNode){conditionOperatorIsNull_ = false;}
   else{conditionOperatorIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- conditionOperatorNode , address : " << conditionOperatorNode << std::endl;
   #endif
   if(conditionOperatorNode)
   {
       conditionOperator_ = boost::shared_ptr<ConditionOperator>(new ConditionOperator(conditionOperatorNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<ReferenceCalculationInfo> VariableCalculation::getReferenceCalculationInfo()
{
   if(!this->referenceCalculationInfoIsNull_){
        return this->referenceCalculationInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ReferenceCalculationInfo>();
   }
}
boost::shared_ptr<Operator1DList> VariableCalculation::getOperator1DList()
{
   if(!this->operator1DListIsNull_){
        return this->operator1DList_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Operator1DList>();
   }
}
boost::shared_ptr<ConditionOperator> VariableCalculation::getConditionOperator()
{
   if(!this->conditionOperatorIsNull_){
        return this->conditionOperator_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ConditionOperator>();
   }
}
}

