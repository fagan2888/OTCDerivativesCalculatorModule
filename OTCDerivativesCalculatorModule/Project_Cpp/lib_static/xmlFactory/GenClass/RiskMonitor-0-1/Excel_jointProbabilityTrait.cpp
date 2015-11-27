// Excel_jointProbabilityTrait.cpp 
#include "Excel_jointProbabilityTrait.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_jointProbabilityTrait::Excel_jointProbabilityTrait(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //nthNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* nthNode = xmlNode->FirstChildElement("nth");

   if(nthNode){nthIsNull_ = false;}
   else{nthIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- nthNode , address : " << nthNode << std::endl;
   #endif
   if(nthNode)
   {
       nth_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(nthNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_jointProbabilityTrait::getNth()
{
   if(!this->nthIsNull_){
        return this->nth_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

