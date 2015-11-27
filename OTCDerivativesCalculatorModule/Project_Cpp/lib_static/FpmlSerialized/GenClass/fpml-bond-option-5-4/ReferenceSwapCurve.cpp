// ReferenceSwapCurve.cpp 
#include "ReferenceSwapCurve.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ReferenceSwapCurve::ReferenceSwapCurve(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //swapUnwindValueNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* swapUnwindValueNode = xmlNode->FirstChildElement("swapUnwindValue");

   if(swapUnwindValueNode){swapUnwindValueIsNull_ = false;}
   else{swapUnwindValueIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- swapUnwindValueNode , address : " << swapUnwindValueNode << std::endl;
   #endif
   if(swapUnwindValueNode)
   {
      if(swapUnwindValueNode->Attribute("href") || swapUnwindValueNode->Attribute("id"))
      {
          if(swapUnwindValueNode->Attribute("id"))
          {
             swapUnwindValueIDRef_ = swapUnwindValueNode->Attribute("id");
             swapUnwindValue_ = boost::shared_ptr<SwapCurveValuation>(new SwapCurveValuation(swapUnwindValueNode));
             swapUnwindValue_->setID(swapUnwindValueIDRef_);
             IDManager::instance().setID(swapUnwindValueIDRef_,swapUnwindValue_);
          }
          else if(swapUnwindValueNode->Attribute("href")) { swapUnwindValueIDRef_ = swapUnwindValueNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { swapUnwindValue_ = boost::shared_ptr<SwapCurveValuation>(new SwapCurveValuation(swapUnwindValueNode));}
   }

   //makeWholeAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* makeWholeAmountNode = xmlNode->FirstChildElement("makeWholeAmount");

   if(makeWholeAmountNode){makeWholeAmountIsNull_ = false;}
   else{makeWholeAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- makeWholeAmountNode , address : " << makeWholeAmountNode << std::endl;
   #endif
   if(makeWholeAmountNode)
   {
      if(makeWholeAmountNode->Attribute("href") || makeWholeAmountNode->Attribute("id"))
      {
          if(makeWholeAmountNode->Attribute("id"))
          {
             makeWholeAmountIDRef_ = makeWholeAmountNode->Attribute("id");
             makeWholeAmount_ = boost::shared_ptr<MakeWholeAmount>(new MakeWholeAmount(makeWholeAmountNode));
             makeWholeAmount_->setID(makeWholeAmountIDRef_);
             IDManager::instance().setID(makeWholeAmountIDRef_,makeWholeAmount_);
          }
          else if(makeWholeAmountNode->Attribute("href")) { makeWholeAmountIDRef_ = makeWholeAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { makeWholeAmount_ = boost::shared_ptr<MakeWholeAmount>(new MakeWholeAmount(makeWholeAmountNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<SwapCurveValuation> ReferenceSwapCurve::getSwapUnwindValue()
{
   if(!this->swapUnwindValueIsNull_){
        if(swapUnwindValueIDRef_ != ""){
             return boost::shared_static_cast<SwapCurveValuation>(IDManager::instance().getID(swapUnwindValueIDRef_));
        }else{
             return this->swapUnwindValue_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<SwapCurveValuation>();
   }
}
boost::shared_ptr<MakeWholeAmount> ReferenceSwapCurve::getMakeWholeAmount()
{
   if(!this->makeWholeAmountIsNull_){
        if(makeWholeAmountIDRef_ != ""){
             return boost::shared_static_cast<MakeWholeAmount>(IDManager::instance().getID(makeWholeAmountIDRef_));
        }else{
             return this->makeWholeAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<MakeWholeAmount>();
   }
}
}

