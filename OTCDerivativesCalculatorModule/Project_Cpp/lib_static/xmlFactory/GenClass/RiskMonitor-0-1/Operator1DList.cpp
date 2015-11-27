// Operator1DList.cpp 
#include "Operator1DList.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Operator1DList::Operator1DList(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //operator1DNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* operator1DNode = xmlNode->FirstChildElement("operator1D");

   if(operator1DNode){operator1DIsNull_ = false;}
   else{operator1DIsNull_ = true;}

   if(operator1DNode)
   {
      for(operator1DNode; operator1DNode; operator1DNode = operator1DNode->NextSiblingElement("operator1D")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- operator1DNode , address : " << operator1DNode << std::endl;
          #endif
          operator1D_.push_back(boost::shared_ptr<Operator1D>(new Operator1D(operator1DNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- operator1DNode , address : " << operator1DNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<Operator1D>> Operator1DList::getOperator1D()
{
   if(!this->operator1DIsNull_){
        return this->operator1D_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Operator1D>>();
   }
}
}

