// VarianceAmount.cpp 
#include "VarianceAmount.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

VarianceAmount::VarianceAmount(TiXmlNode* xmlNode)
: CalculatedAmount(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //varianceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* varianceNode = xmlNode->FirstChildElement("variance");

   if(varianceNode){varianceIsNull_ = false;}
   else{varianceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- varianceNode , address : " << varianceNode << std::endl;
   #endif
   if(varianceNode)
   {
      if(varianceNode->Attribute("href") || varianceNode->Attribute("id"))
      {
          if(varianceNode->Attribute("id"))
          {
             varianceIDRef_ = varianceNode->Attribute("id");
             variance_ = boost::shared_ptr<Variance>(new Variance(varianceNode));
             variance_->setID(varianceIDRef_);
             IDManager::instance().setID(varianceIDRef_,variance_);
          }
          else if(varianceNode->Attribute("href")) { varianceIDRef_ = varianceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { variance_ = boost::shared_ptr<Variance>(new Variance(varianceNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Variance> VarianceAmount::getVariance()
{
   if(!this->varianceIsNull_){
        if(varianceIDRef_ != ""){
             return boost::shared_static_cast<Variance>(IDManager::instance().getID(varianceIDRef_));
        }else{
             return this->variance_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Variance>();
   }
}
}

