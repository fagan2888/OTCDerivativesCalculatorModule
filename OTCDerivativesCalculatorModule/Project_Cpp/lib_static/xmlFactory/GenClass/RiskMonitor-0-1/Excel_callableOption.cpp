// Excel_callableOption.cpp 
#include "Excel_callableOption.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_callableOption::Excel_callableOption(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //optionTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* optionTypeNode = xmlNode->FirstChildElement("optionType");

   if(optionTypeNode){optionTypeIsNull_ = false;}
   else{optionTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- optionTypeNode , address : " << optionTypeNode << std::endl;
   #endif
   if(optionTypeNode)
   {
       optionType_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(optionTypeNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_callableOption::getOptionType()
{
   if(!this->optionTypeIsNull_){
        return this->optionType_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

