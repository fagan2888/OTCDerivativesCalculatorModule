// BoundedVariance.cpp 
#include "BoundedVariance.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

BoundedVariance::BoundedVariance(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //realisedVarianceMethodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* realisedVarianceMethodNode = xmlNode->FirstChildElement("realisedVarianceMethod");

   if(realisedVarianceMethodNode){realisedVarianceMethodIsNull_ = false;}
   else{realisedVarianceMethodIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- realisedVarianceMethodNode , address : " << realisedVarianceMethodNode << std::endl;
   #endif
   if(realisedVarianceMethodNode)
   {
      if(realisedVarianceMethodNode->Attribute("href") || realisedVarianceMethodNode->Attribute("id"))
      {
          if(realisedVarianceMethodNode->Attribute("id"))
          {
             realisedVarianceMethodIDRef_ = realisedVarianceMethodNode->Attribute("id");
             realisedVarianceMethod_ = boost::shared_ptr<RealisedVarianceMethodEnum>(new RealisedVarianceMethodEnum(realisedVarianceMethodNode));
             realisedVarianceMethod_->setID(realisedVarianceMethodIDRef_);
             IDManager::instance().setID(realisedVarianceMethodIDRef_,realisedVarianceMethod_);
          }
          else if(realisedVarianceMethodNode->Attribute("href")) { realisedVarianceMethodIDRef_ = realisedVarianceMethodNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { realisedVarianceMethod_ = boost::shared_ptr<RealisedVarianceMethodEnum>(new RealisedVarianceMethodEnum(realisedVarianceMethodNode));}
   }

   //daysInRangeAdjustmentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* daysInRangeAdjustmentNode = xmlNode->FirstChildElement("daysInRangeAdjustment");

   if(daysInRangeAdjustmentNode){daysInRangeAdjustmentIsNull_ = false;}
   else{daysInRangeAdjustmentIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- daysInRangeAdjustmentNode , address : " << daysInRangeAdjustmentNode << std::endl;
   #endif
   if(daysInRangeAdjustmentNode)
   {
      if(daysInRangeAdjustmentNode->Attribute("href") || daysInRangeAdjustmentNode->Attribute("id"))
      {
          if(daysInRangeAdjustmentNode->Attribute("id"))
          {
             daysInRangeAdjustmentIDRef_ = daysInRangeAdjustmentNode->Attribute("id");
             daysInRangeAdjustment_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(daysInRangeAdjustmentNode));
             daysInRangeAdjustment_->setID(daysInRangeAdjustmentIDRef_);
             IDManager::instance().setID(daysInRangeAdjustmentIDRef_,daysInRangeAdjustment_);
          }
          else if(daysInRangeAdjustmentNode->Attribute("href")) { daysInRangeAdjustmentIDRef_ = daysInRangeAdjustmentNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { daysInRangeAdjustment_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(daysInRangeAdjustmentNode));}
   }

   //upperBarrierNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* upperBarrierNode = xmlNode->FirstChildElement("upperBarrier");

   if(upperBarrierNode){upperBarrierIsNull_ = false;}
   else{upperBarrierIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- upperBarrierNode , address : " << upperBarrierNode << std::endl;
   #endif
   if(upperBarrierNode)
   {
      if(upperBarrierNode->Attribute("href") || upperBarrierNode->Attribute("id"))
      {
          if(upperBarrierNode->Attribute("id"))
          {
             upperBarrierIDRef_ = upperBarrierNode->Attribute("id");
             upperBarrier_ = boost::shared_ptr<NonNegativeDecimal>(new NonNegativeDecimal(upperBarrierNode));
             upperBarrier_->setID(upperBarrierIDRef_);
             IDManager::instance().setID(upperBarrierIDRef_,upperBarrier_);
          }
          else if(upperBarrierNode->Attribute("href")) { upperBarrierIDRef_ = upperBarrierNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { upperBarrier_ = boost::shared_ptr<NonNegativeDecimal>(new NonNegativeDecimal(upperBarrierNode));}
   }

   //lowerBarrierNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* lowerBarrierNode = xmlNode->FirstChildElement("lowerBarrier");

   if(lowerBarrierNode){lowerBarrierIsNull_ = false;}
   else{lowerBarrierIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- lowerBarrierNode , address : " << lowerBarrierNode << std::endl;
   #endif
   if(lowerBarrierNode)
   {
      if(lowerBarrierNode->Attribute("href") || lowerBarrierNode->Attribute("id"))
      {
          if(lowerBarrierNode->Attribute("id"))
          {
             lowerBarrierIDRef_ = lowerBarrierNode->Attribute("id");
             lowerBarrier_ = boost::shared_ptr<NonNegativeDecimal>(new NonNegativeDecimal(lowerBarrierNode));
             lowerBarrier_->setID(lowerBarrierIDRef_);
             IDManager::instance().setID(lowerBarrierIDRef_,lowerBarrier_);
          }
          else if(lowerBarrierNode->Attribute("href")) { lowerBarrierIDRef_ = lowerBarrierNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { lowerBarrier_ = boost::shared_ptr<NonNegativeDecimal>(new NonNegativeDecimal(lowerBarrierNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<RealisedVarianceMethodEnum> BoundedVariance::getRealisedVarianceMethod()
{
   if(!this->realisedVarianceMethodIsNull_){
        if(realisedVarianceMethodIDRef_ != ""){
             return boost::shared_static_cast<RealisedVarianceMethodEnum>(IDManager::instance().getID(realisedVarianceMethodIDRef_));
        }else{
             return this->realisedVarianceMethod_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<RealisedVarianceMethodEnum>();
   }
}
boost::shared_ptr<XsdTypeBoolean> BoundedVariance::getDaysInRangeAdjustment()
{
   if(!this->daysInRangeAdjustmentIsNull_){
        if(daysInRangeAdjustmentIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(daysInRangeAdjustmentIDRef_));
        }else{
             return this->daysInRangeAdjustment_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<NonNegativeDecimal> BoundedVariance::getUpperBarrier()
{
   if(!this->upperBarrierIsNull_){
        if(upperBarrierIDRef_ != ""){
             return boost::shared_static_cast<NonNegativeDecimal>(IDManager::instance().getID(upperBarrierIDRef_));
        }else{
             return this->upperBarrier_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NonNegativeDecimal>();
   }
}
boost::shared_ptr<NonNegativeDecimal> BoundedVariance::getLowerBarrier()
{
   if(!this->lowerBarrierIsNull_){
        if(lowerBarrierIDRef_ != ""){
             return boost::shared_static_cast<NonNegativeDecimal>(IDManager::instance().getID(lowerBarrierIDRef_));
        }else{
             return this->lowerBarrier_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NonNegativeDecimal>();
   }
}
}

