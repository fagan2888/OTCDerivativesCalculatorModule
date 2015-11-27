// ComplexNDReturnCal.cpp 
#include "ComplexNDReturnCal.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ComplexNDReturnCal::ComplexNDReturnCal(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //variableCalListNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* variableCalListNode = xmlNode->FirstChildElement("variableCalList");

   if(variableCalListNode){variableCalListIsNull_ = false;}
   else{variableCalListIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- variableCalListNode , address : " << variableCalListNode << std::endl;
   #endif
   if(variableCalListNode)
   {
       variableCalList_ = boost::shared_ptr<VariableCalList>(new VariableCalList(variableCalListNode));
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
boost::shared_ptr<VariableCalList> ComplexNDReturnCal::getVariableCalList()
{
   if(!this->variableCalListIsNull_){
        return this->variableCalList_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<VariableCalList>();
   }
}
boost::shared_ptr<OperatorND> ComplexNDReturnCal::getOperatorND()
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

