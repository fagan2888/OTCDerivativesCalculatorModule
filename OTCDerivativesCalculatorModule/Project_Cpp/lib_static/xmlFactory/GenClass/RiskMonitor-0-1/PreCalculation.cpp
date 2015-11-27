// PreCalculation.cpp 
#include "PreCalculation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

PreCalculation::PreCalculation(TiXmlNode* xmlNode)
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

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<VariableCalList> PreCalculation::getVariableCalList()
{
   if(!this->variableCalListIsNull_){
        return this->variableCalList_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<VariableCalList>();
   }
}
}

