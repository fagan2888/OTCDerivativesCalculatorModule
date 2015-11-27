// RefVariable_returnValue.cpp 
#include "RefVariable_returnValue.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

RefVariable_returnValue::RefVariable_returnValue(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //variableInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* variableInfoNode = xmlNode->FirstChildElement("variableInfo");

   if(variableInfoNode){variableInfoIsNull_ = false;}
   else{variableInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- variableInfoNode , address : " << variableInfoNode << std::endl;
   #endif
   if(variableInfoNode)
   {
       variableInfo_ = boost::shared_ptr<VariableInfo>(new VariableInfo(variableInfoNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<VariableInfo> RefVariable_returnValue::getVariableInfo()
{
   if(!this->variableInfoIsNull_){
        return this->variableInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<VariableInfo>();
   }
}
}

