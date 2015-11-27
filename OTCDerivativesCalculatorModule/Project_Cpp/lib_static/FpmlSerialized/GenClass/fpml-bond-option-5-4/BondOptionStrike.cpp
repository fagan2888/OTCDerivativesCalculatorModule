// BondOptionStrike.cpp 
#include "BondOptionStrike.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

BondOptionStrike::BondOptionStrike(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //referenceSwapCurveNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* referenceSwapCurveNode = xmlNode->FirstChildElement("referenceSwapCurve");

   if(referenceSwapCurveNode){referenceSwapCurveIsNull_ = false;}
   else{referenceSwapCurveIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- referenceSwapCurveNode , address : " << referenceSwapCurveNode << std::endl;
   #endif
   if(referenceSwapCurveNode)
   {
      if(referenceSwapCurveNode->Attribute("href") || referenceSwapCurveNode->Attribute("id"))
      {
          if(referenceSwapCurveNode->Attribute("id"))
          {
             referenceSwapCurveIDRef_ = referenceSwapCurveNode->Attribute("id");
             referenceSwapCurve_ = boost::shared_ptr<ReferenceSwapCurve>(new ReferenceSwapCurve(referenceSwapCurveNode));
             referenceSwapCurve_->setID(referenceSwapCurveIDRef_);
             IDManager::instance().setID(referenceSwapCurveIDRef_,referenceSwapCurve_);
          }
          else if(referenceSwapCurveNode->Attribute("href")) { referenceSwapCurveIDRef_ = referenceSwapCurveNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { referenceSwapCurve_ = boost::shared_ptr<ReferenceSwapCurve>(new ReferenceSwapCurve(referenceSwapCurveNode));}
   }

   //priceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* priceNode = xmlNode->FirstChildElement("price");

   if(priceNode){priceIsNull_ = false;}
   else{priceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- priceNode , address : " << priceNode << std::endl;
   #endif
   if(priceNode)
   {
      if(priceNode->Attribute("href") || priceNode->Attribute("id"))
      {
          if(priceNode->Attribute("id"))
          {
             priceIDRef_ = priceNode->Attribute("id");
             price_ = boost::shared_ptr<OptionStrike>(new OptionStrike(priceNode));
             price_->setID(priceIDRef_);
             IDManager::instance().setID(priceIDRef_,price_);
          }
          else if(priceNode->Attribute("href")) { priceIDRef_ = priceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { price_ = boost::shared_ptr<OptionStrike>(new OptionStrike(priceNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<ReferenceSwapCurve> BondOptionStrike::getReferenceSwapCurve()
{
   if(!this->referenceSwapCurveIsNull_){
        if(referenceSwapCurveIDRef_ != ""){
             return boost::shared_static_cast<ReferenceSwapCurve>(IDManager::instance().getID(referenceSwapCurveIDRef_));
        }else{
             return this->referenceSwapCurve_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ReferenceSwapCurve>();
   }
}
boost::shared_ptr<OptionStrike> BondOptionStrike::getPrice()
{
   if(!this->priceIsNull_){
        if(priceIDRef_ != ""){
             return boost::shared_static_cast<OptionStrike>(IDManager::instance().getID(priceIDRef_));
        }else{
             return this->price_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<OptionStrike>();
   }
}
}

