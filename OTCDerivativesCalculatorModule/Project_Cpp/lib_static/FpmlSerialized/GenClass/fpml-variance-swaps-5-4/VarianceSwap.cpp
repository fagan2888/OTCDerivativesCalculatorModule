// VarianceSwap.cpp 
#include "VarianceSwap.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

VarianceSwap::VarianceSwap(TiXmlNode* xmlNode)
: NettedSwapBase(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //varianceLegNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* varianceLegNode = xmlNode->FirstChildElement("varianceLeg");

   if(varianceLegNode){varianceLegIsNull_ = false;}
   else{varianceLegIsNull_ = true;}

   if(varianceLegNode)
   {
      for(varianceLegNode; varianceLegNode; varianceLegNode = varianceLegNode->NextSiblingElement("varianceLeg")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- varianceLegNode , address : " << varianceLegNode << std::endl;
          #endif
          if(varianceLegNode->Attribute("href") || varianceLegNode->Attribute("id"))
          {
              if(varianceLegNode->Attribute("id"))
              {
                  varianceLegIDRef_ = varianceLegNode->Attribute("id");
                  varianceLeg_.push_back(boost::shared_ptr<VarianceLeg>(new VarianceLeg(varianceLegNode)));
                  varianceLeg_.back()->setID(varianceLegIDRef_);
                  IDManager::instance().setID(varianceLegIDRef_, varianceLeg_.back());
              }
              else if(varianceLegNode->Attribute("href")) { varianceLegIDRef_ = varianceLegNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { varianceLeg_.push_back(boost::shared_ptr<VarianceLeg>(new VarianceLeg(varianceLegNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- varianceLegNode , address : " << varianceLegNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<VarianceLeg>> VarianceSwap::getVarianceLeg()
{
   if(!this->varianceLegIsNull_){
        if(varianceLegIDRef_ != ""){
             return this->varianceLeg_;
        }else{
             return this->varianceLeg_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<VarianceLeg>>();
   }
}
}

