// Root.cpp 
#include "Root.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Root::Root(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //instrumentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* instrumentNode = xmlNode->FirstChildElement("instrument");

   if(instrumentNode){instrumentIsNull_ = false;}
   else{instrumentIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- instrumentNode , address : " << instrumentNode << std::endl;
   #endif
   if(instrumentNode)
   {
       instrument_ = boost::shared_ptr<Instrument>(new Instrument(instrumentNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Instrument> Root::getInstrument()
{
   if(!this->instrumentIsNull_){
        return this->instrument_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Instrument>();
   }
}
}

