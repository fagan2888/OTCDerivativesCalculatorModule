// ReferenceCurveList.cpp 
#include "ReferenceCurveList.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ReferenceCurveList::ReferenceCurveList(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //referenceCurveNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* referenceCurveNode = xmlNode->FirstChildElement("referenceCurve");

   if(referenceCurveNode){referenceCurveIsNull_ = false;}
   else{referenceCurveIsNull_ = true;}

   if(referenceCurveNode)
   {
      for(referenceCurveNode; referenceCurveNode; referenceCurveNode = referenceCurveNode->NextSiblingElement("referenceCurve")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- referenceCurveNode , address : " << referenceCurveNode << std::endl;
          #endif
          referenceCurve_.push_back(boost::shared_ptr<ReferenceCurve>(new ReferenceCurve(referenceCurveNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- referenceCurveNode , address : " << referenceCurveNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<ReferenceCurve>> ReferenceCurveList::getReferenceCurve()
{
   if(!this->referenceCurveIsNull_){
        return this->referenceCurve_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<ReferenceCurve>>();
   }
}
}

