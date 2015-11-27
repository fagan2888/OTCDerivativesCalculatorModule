// Group.cpp 
#include "Group.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Group::Group(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //headerNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* headerNode = xmlNode->FirstChildElement("header");

   if(headerNode){headerIsNull_ = false;}
   else{headerIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- headerNode , address : " << headerNode << std::endl;
   #endif
   if(headerNode)
   {
       header_ = boost::shared_ptr<Header>(new Header(headerNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Header> Group::getHeader()
{
   if(!this->headerIsNull_){
        return this->header_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Header>();
   }
}
}

