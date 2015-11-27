// CommodityMultipleExercise.cpp 
#include "CommodityMultipleExercise.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CommodityMultipleExercise::CommodityMultipleExercise(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //integralMultipleQuantityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* integralMultipleQuantityNode = xmlNode->FirstChildElement("integralMultipleQuantity");

   if(integralMultipleQuantityNode){integralMultipleQuantityIsNull_ = false;}
   else{integralMultipleQuantityIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- integralMultipleQuantityNode , address : " << integralMultipleQuantityNode << std::endl;
   #endif
   if(integralMultipleQuantityNode)
   {
      if(integralMultipleQuantityNode->Attribute("href") || integralMultipleQuantityNode->Attribute("id"))
      {
          if(integralMultipleQuantityNode->Attribute("id"))
          {
             integralMultipleQuantityIDRef_ = integralMultipleQuantityNode->Attribute("id");
             integralMultipleQuantity_ = boost::shared_ptr<CommodityNotionalQuantity>(new CommodityNotionalQuantity(integralMultipleQuantityNode));
             integralMultipleQuantity_->setID(integralMultipleQuantityIDRef_);
             IDManager::instance().setID(integralMultipleQuantityIDRef_,integralMultipleQuantity_);
          }
          else if(integralMultipleQuantityNode->Attribute("href")) { integralMultipleQuantityIDRef_ = integralMultipleQuantityNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { integralMultipleQuantity_ = boost::shared_ptr<CommodityNotionalQuantity>(new CommodityNotionalQuantity(integralMultipleQuantityNode));}
   }

   //minimumNotionalQuantityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* minimumNotionalQuantityNode = xmlNode->FirstChildElement("minimumNotionalQuantity");

   if(minimumNotionalQuantityNode){minimumNotionalQuantityIsNull_ = false;}
   else{minimumNotionalQuantityIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- minimumNotionalQuantityNode , address : " << minimumNotionalQuantityNode << std::endl;
   #endif
   if(minimumNotionalQuantityNode)
   {
      if(minimumNotionalQuantityNode->Attribute("href") || minimumNotionalQuantityNode->Attribute("id"))
      {
          if(minimumNotionalQuantityNode->Attribute("id"))
          {
             minimumNotionalQuantityIDRef_ = minimumNotionalQuantityNode->Attribute("id");
             minimumNotionalQuantity_ = boost::shared_ptr<CommodityNotionalQuantity>(new CommodityNotionalQuantity(minimumNotionalQuantityNode));
             minimumNotionalQuantity_->setID(minimumNotionalQuantityIDRef_);
             IDManager::instance().setID(minimumNotionalQuantityIDRef_,minimumNotionalQuantity_);
          }
          else if(minimumNotionalQuantityNode->Attribute("href")) { minimumNotionalQuantityIDRef_ = minimumNotionalQuantityNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { minimumNotionalQuantity_ = boost::shared_ptr<CommodityNotionalQuantity>(new CommodityNotionalQuantity(minimumNotionalQuantityNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<CommodityNotionalQuantity> CommodityMultipleExercise::getIntegralMultipleQuantity()
{
   if(!this->integralMultipleQuantityIsNull_){
        if(integralMultipleQuantityIDRef_ != ""){
             return boost::shared_static_cast<CommodityNotionalQuantity>(IDManager::instance().getID(integralMultipleQuantityIDRef_));
        }else{
             return this->integralMultipleQuantity_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityNotionalQuantity>();
   }
}
boost::shared_ptr<CommodityNotionalQuantity> CommodityMultipleExercise::getMinimumNotionalQuantity()
{
   if(!this->minimumNotionalQuantityIsNull_){
        if(minimumNotionalQuantityIDRef_ != ""){
             return boost::shared_static_cast<CommodityNotionalQuantity>(IDManager::instance().getID(minimumNotionalQuantityIDRef_));
        }else{
             return this->minimumNotionalQuantity_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityNotionalQuantity>();
   }
}
}

