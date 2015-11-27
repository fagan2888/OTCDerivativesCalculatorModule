// YieldCurveValuation.cpp 
#include "YieldCurveValuation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

YieldCurveValuation::YieldCurveValuation(TiXmlNode* xmlNode)
: PricingStructureValuation(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //inputsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* inputsNode = xmlNode->FirstChildElement("inputs");

   if(inputsNode){inputsIsNull_ = false;}
   else{inputsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- inputsNode , address : " << inputsNode << std::endl;
   #endif
   if(inputsNode)
   {
      if(inputsNode->Attribute("href") || inputsNode->Attribute("id"))
      {
          if(inputsNode->Attribute("id"))
          {
             inputsIDRef_ = inputsNode->Attribute("id");
             inputs_ = boost::shared_ptr<QuotedAssetSet>(new QuotedAssetSet(inputsNode));
             inputs_->setID(inputsIDRef_);
             IDManager::instance().setID(inputsIDRef_,inputs_);
          }
          else if(inputsNode->Attribute("href")) { inputsIDRef_ = inputsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { inputs_ = boost::shared_ptr<QuotedAssetSet>(new QuotedAssetSet(inputsNode));}
   }

   //zeroCurveNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* zeroCurveNode = xmlNode->FirstChildElement("zeroCurve");

   if(zeroCurveNode){zeroCurveIsNull_ = false;}
   else{zeroCurveIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- zeroCurveNode , address : " << zeroCurveNode << std::endl;
   #endif
   if(zeroCurveNode)
   {
      if(zeroCurveNode->Attribute("href") || zeroCurveNode->Attribute("id"))
      {
          if(zeroCurveNode->Attribute("id"))
          {
             zeroCurveIDRef_ = zeroCurveNode->Attribute("id");
             zeroCurve_ = boost::shared_ptr<ZeroRateCurve>(new ZeroRateCurve(zeroCurveNode));
             zeroCurve_->setID(zeroCurveIDRef_);
             IDManager::instance().setID(zeroCurveIDRef_,zeroCurve_);
          }
          else if(zeroCurveNode->Attribute("href")) { zeroCurveIDRef_ = zeroCurveNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { zeroCurve_ = boost::shared_ptr<ZeroRateCurve>(new ZeroRateCurve(zeroCurveNode));}
   }

   //forwardCurveNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* forwardCurveNode = xmlNode->FirstChildElement("forwardCurve");

   if(forwardCurveNode){forwardCurveIsNull_ = false;}
   else{forwardCurveIsNull_ = true;}

   if(forwardCurveNode)
   {
      for(forwardCurveNode; forwardCurveNode; forwardCurveNode = forwardCurveNode->NextSiblingElement("forwardCurve")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- forwardCurveNode , address : " << forwardCurveNode << std::endl;
          #endif
          if(forwardCurveNode->Attribute("href") || forwardCurveNode->Attribute("id"))
          {
              if(forwardCurveNode->Attribute("id"))
              {
                  forwardCurveIDRef_ = forwardCurveNode->Attribute("id");
                  forwardCurve_.push_back(boost::shared_ptr<ForwardRateCurve>(new ForwardRateCurve(forwardCurveNode)));
                  forwardCurve_.back()->setID(forwardCurveIDRef_);
                  IDManager::instance().setID(forwardCurveIDRef_, forwardCurve_.back());
              }
              else if(forwardCurveNode->Attribute("href")) { forwardCurveIDRef_ = forwardCurveNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { forwardCurve_.push_back(boost::shared_ptr<ForwardRateCurve>(new ForwardRateCurve(forwardCurveNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- forwardCurveNode , address : " << forwardCurveNode << std::endl;
       #endif
   }

   //discountFactorCurveNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* discountFactorCurveNode = xmlNode->FirstChildElement("discountFactorCurve");

   if(discountFactorCurveNode){discountFactorCurveIsNull_ = false;}
   else{discountFactorCurveIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- discountFactorCurveNode , address : " << discountFactorCurveNode << std::endl;
   #endif
   if(discountFactorCurveNode)
   {
      if(discountFactorCurveNode->Attribute("href") || discountFactorCurveNode->Attribute("id"))
      {
          if(discountFactorCurveNode->Attribute("id"))
          {
             discountFactorCurveIDRef_ = discountFactorCurveNode->Attribute("id");
             discountFactorCurve_ = boost::shared_ptr<TermCurve>(new TermCurve(discountFactorCurveNode));
             discountFactorCurve_->setID(discountFactorCurveIDRef_);
             IDManager::instance().setID(discountFactorCurveIDRef_,discountFactorCurve_);
          }
          else if(discountFactorCurveNode->Attribute("href")) { discountFactorCurveIDRef_ = discountFactorCurveNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { discountFactorCurve_ = boost::shared_ptr<TermCurve>(new TermCurve(discountFactorCurveNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<QuotedAssetSet> YieldCurveValuation::getInputs()
{
   if(!this->inputsIsNull_){
        if(inputsIDRef_ != ""){
             return boost::shared_static_cast<QuotedAssetSet>(IDManager::instance().getID(inputsIDRef_));
        }else{
             return this->inputs_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<QuotedAssetSet>();
   }
}
boost::shared_ptr<ZeroRateCurve> YieldCurveValuation::getZeroCurve()
{
   if(!this->zeroCurveIsNull_){
        if(zeroCurveIDRef_ != ""){
             return boost::shared_static_cast<ZeroRateCurve>(IDManager::instance().getID(zeroCurveIDRef_));
        }else{
             return this->zeroCurve_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ZeroRateCurve>();
   }
}
std::vector<boost::shared_ptr<ForwardRateCurve>> YieldCurveValuation::getForwardCurve()
{
   if(!this->forwardCurveIsNull_){
        if(forwardCurveIDRef_ != ""){
             return this->forwardCurve_;
        }else{
             return this->forwardCurve_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<ForwardRateCurve>>();
   }
}
boost::shared_ptr<TermCurve> YieldCurveValuation::getDiscountFactorCurve()
{
   if(!this->discountFactorCurveIsNull_){
        if(discountFactorCurveIDRef_ != ""){
             return boost::shared_static_cast<TermCurve>(IDManager::instance().getID(discountFactorCurveIDRef_));
        }else{
             return this->discountFactorCurve_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<TermCurve>();
   }
}
}

