// PreDefinedVariableList.cpp 
#include "PreDefinedVariableList.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

PreDefinedVariableList::PreDefinedVariableList(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //preDefinedVariableInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* preDefinedVariableInfoNode = xmlNode->FirstChildElement("preDefinedVariableInfo");

   if(preDefinedVariableInfoNode){preDefinedVariableInfoIsNull_ = false;}
   else{preDefinedVariableInfoIsNull_ = true;}

   if(preDefinedVariableInfoNode)
   {
      for(preDefinedVariableInfoNode; preDefinedVariableInfoNode; preDefinedVariableInfoNode = preDefinedVariableInfoNode->NextSiblingElement("preDefinedVariableInfo")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- preDefinedVariableInfoNode , address : " << preDefinedVariableInfoNode << std::endl;
          #endif
          preDefinedVariableInfo_.push_back(boost::shared_ptr<PreDefinedVariableInfo>(new PreDefinedVariableInfo(preDefinedVariableInfoNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- preDefinedVariableInfoNode , address : " << preDefinedVariableInfoNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<PreDefinedVariableInfo>> PreDefinedVariableList::getPreDefinedVariableInfo()
{
   if(!this->preDefinedVariableInfoIsNull_){
        return this->preDefinedVariableInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<PreDefinedVariableInfo>>();
   }
}
}

