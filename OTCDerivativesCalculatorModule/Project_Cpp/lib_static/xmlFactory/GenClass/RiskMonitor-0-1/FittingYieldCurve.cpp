// FittingYieldCurve.cpp 
#include "FittingYieldCurve.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FittingYieldCurve::FittingYieldCurve(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //yieldTermstructureNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* yieldTermstructureNode = xmlNode->FirstChildElement("yieldTermstructure");

   if(yieldTermstructureNode){yieldTermstructureIsNull_ = false;}
   else{yieldTermstructureIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- yieldTermstructureNode , address : " << yieldTermstructureNode << std::endl;
   #endif
   if(yieldTermstructureNode)
   {
       yieldTermstructure_ = boost::shared_ptr<YieldTermstructure>(new YieldTermstructure(yieldTermstructureNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<YieldTermstructure> FittingYieldCurve::getYieldTermstructure()
{
   if(!this->yieldTermstructureIsNull_){
        return this->yieldTermstructure_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<YieldTermstructure>();
   }
}
}

