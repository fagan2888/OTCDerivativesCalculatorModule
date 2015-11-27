// Excel_constReturnCal.cpp 
#include "Excel_constReturnCal.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_constReturnCal::Excel_constReturnCal(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //constReturnNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* constReturnNode = xmlNode->FirstChildElement("constReturn");

   if(constReturnNode){constReturnIsNull_ = false;}
   else{constReturnIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- constReturnNode , address : " << constReturnNode << std::endl;
   #endif
   if(constReturnNode)
   {
       constReturn_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(constReturnNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_constReturnCal::getConstReturn()
{
   if(!this->constReturnIsNull_){
        return this->constReturn_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

