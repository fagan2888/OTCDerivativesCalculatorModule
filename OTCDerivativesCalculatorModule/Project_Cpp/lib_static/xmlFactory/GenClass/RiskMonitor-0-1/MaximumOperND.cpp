// MaximumOperND.cpp 
#include "MaximumOperND.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

MaximumOperND::MaximumOperND(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //weightNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* weightNode = xmlNode->FirstChildElement("weight");

   if(weightNode){weightIsNull_ = false;}
   else{weightIsNull_ = true;}

   if(weightNode)
   {
      for(weightNode; weightNode; weightNode = weightNode->NextSiblingElement("weight")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- weightNode , address : " << weightNode << std::endl;
          #endif
          weight_.push_back(boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(weightNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- weightNode , address : " << weightNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<XsdTypeToken>> MaximumOperND::getWeight()
{
   if(!this->weightIsNull_){
        return this->weight_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<XsdTypeToken>>();
   }
}
}

