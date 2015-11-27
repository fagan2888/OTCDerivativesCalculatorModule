// ParaRoot.cpp 
#include "ParaRoot.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ParaRoot::ParaRoot(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //pricingNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* pricingNode = xmlNode->FirstChildElement("pricing");

   if(pricingNode){pricingIsNull_ = false;}
   else{pricingIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- pricingNode , address : " << pricingNode << std::endl;
   #endif
   if(pricingNode)
   {
       pricing_ = boost::shared_ptr<Pricing>(new Pricing(pricingNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Pricing> ParaRoot::getPricing()
{
   if(!this->pricingIsNull_){
        return this->pricing_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Pricing>();
   }
}
}

