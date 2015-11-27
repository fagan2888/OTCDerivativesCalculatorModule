// ForwardRateCurve.cpp 
#include "ForwardRateCurve.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ForwardRateCurve::ForwardRateCurve(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //assetReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* assetReferenceNode = xmlNode->FirstChildElement("assetReference");

   if(assetReferenceNode){assetReferenceIsNull_ = false;}
   else{assetReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- assetReferenceNode , address : " << assetReferenceNode << std::endl;
   #endif
   if(assetReferenceNode)
   {
      if(assetReferenceNode->Attribute("href") || assetReferenceNode->Attribute("id"))
      {
          if(assetReferenceNode->Attribute("id"))
          {
             assetReferenceIDRef_ = assetReferenceNode->Attribute("id");
             assetReference_ = boost::shared_ptr<AssetReference>(new AssetReference(assetReferenceNode));
             assetReference_->setID(assetReferenceIDRef_);
             IDManager::instance().setID(assetReferenceIDRef_,assetReference_);
          }
          else if(assetReferenceNode->Attribute("href")) { assetReferenceIDRef_ = assetReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { assetReference_ = boost::shared_ptr<AssetReference>(new AssetReference(assetReferenceNode));}
   }

   //rateCurveNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* rateCurveNode = xmlNode->FirstChildElement("rateCurve");

   if(rateCurveNode){rateCurveIsNull_ = false;}
   else{rateCurveIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- rateCurveNode , address : " << rateCurveNode << std::endl;
   #endif
   if(rateCurveNode)
   {
      if(rateCurveNode->Attribute("href") || rateCurveNode->Attribute("id"))
      {
          if(rateCurveNode->Attribute("id"))
          {
             rateCurveIDRef_ = rateCurveNode->Attribute("id");
             rateCurve_ = boost::shared_ptr<TermCurve>(new TermCurve(rateCurveNode));
             rateCurve_->setID(rateCurveIDRef_);
             IDManager::instance().setID(rateCurveIDRef_,rateCurve_);
          }
          else if(rateCurveNode->Attribute("href")) { rateCurveIDRef_ = rateCurveNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { rateCurve_ = boost::shared_ptr<TermCurve>(new TermCurve(rateCurveNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<AssetReference> ForwardRateCurve::getAssetReference()
{
   if(!this->assetReferenceIsNull_){
        if(assetReferenceIDRef_ != ""){
             return boost::shared_static_cast<AssetReference>(IDManager::instance().getID(assetReferenceIDRef_));
        }else{
             return this->assetReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AssetReference>();
   }
}
boost::shared_ptr<TermCurve> ForwardRateCurve::getRateCurve()
{
   if(!this->rateCurveIsNull_){
        if(rateCurveIDRef_ != ""){
             return boost::shared_static_cast<TermCurve>(IDManager::instance().getID(rateCurveIDRef_));
        }else{
             return this->rateCurve_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<TermCurve>();
   }
}
}

