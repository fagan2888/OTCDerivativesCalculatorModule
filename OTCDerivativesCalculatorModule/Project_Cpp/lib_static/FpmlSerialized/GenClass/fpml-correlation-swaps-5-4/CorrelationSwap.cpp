// CorrelationSwap.cpp 
#include "CorrelationSwap.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CorrelationSwap::CorrelationSwap(TiXmlNode* xmlNode)
: NettedSwapBase(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //correlationLegNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* correlationLegNode = xmlNode->FirstChildElement("correlationLeg");

   if(correlationLegNode){correlationLegIsNull_ = false;}
   else{correlationLegIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- correlationLegNode , address : " << correlationLegNode << std::endl;
   #endif
   if(correlationLegNode)
   {
      if(correlationLegNode->Attribute("href") || correlationLegNode->Attribute("id"))
      {
          if(correlationLegNode->Attribute("id"))
          {
             correlationLegIDRef_ = correlationLegNode->Attribute("id");
             correlationLeg_ = boost::shared_ptr<CorrelationLeg>(new CorrelationLeg(correlationLegNode));
             correlationLeg_->setID(correlationLegIDRef_);
             IDManager::instance().setID(correlationLegIDRef_,correlationLeg_);
          }
          else if(correlationLegNode->Attribute("href")) { correlationLegIDRef_ = correlationLegNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { correlationLeg_ = boost::shared_ptr<CorrelationLeg>(new CorrelationLeg(correlationLegNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<CorrelationLeg> CorrelationSwap::getCorrelationLeg()
{
   if(!this->correlationLegIsNull_){
        if(correlationLegIDRef_ != ""){
             return boost::shared_static_cast<CorrelationLeg>(IDManager::instance().getID(correlationLegIDRef_));
        }else{
             return this->correlationLeg_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CorrelationLeg>();
   }
}
}

