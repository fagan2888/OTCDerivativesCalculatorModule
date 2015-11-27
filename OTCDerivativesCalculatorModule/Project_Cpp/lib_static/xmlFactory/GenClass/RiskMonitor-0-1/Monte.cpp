// Monte.cpp 
#include "Monte.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Monte::Monte(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //simulationNumNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* simulationNumNode = xmlNode->FirstChildElement("simulationNum");

   if(simulationNumNode){simulationNumIsNull_ = false;}
   else{simulationNumIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- simulationNumNode , address : " << simulationNumNode << std::endl;
   #endif
   if(simulationNumNode)
   {
       simulationNum_ = boost::shared_ptr<XsdTypeInteger>(new XsdTypeInteger(simulationNumNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeInteger> Monte::getSimulationNum()
{
   if(!this->simulationNumIsNull_){
        return this->simulationNum_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeInteger>();
   }
}
}

