// VolatilityRepresentation.cpp 
#include "VolatilityRepresentation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

VolatilityRepresentation::VolatilityRepresentation(TiXmlNode* xmlNode)
: PricingStructure(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //assetNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* assetNode = xmlNode->FirstChildElement("asset");

   if(assetNode){assetIsNull_ = false;}
   else{assetIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- assetNode , address : " << assetNode << std::endl;
   #endif
   if(assetNode)
   {
      if(assetNode->Attribute("href") || assetNode->Attribute("id"))
      {
          if(assetNode->Attribute("id"))
          {
             assetIDRef_ = assetNode->Attribute("id");
             asset_ = boost::shared_ptr<AnyAssetReference>(new AnyAssetReference(assetNode));
             asset_->setID(assetIDRef_);
             IDManager::instance().setID(assetIDRef_,asset_);
          }
          else if(assetNode->Attribute("href")) { assetIDRef_ = assetNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { asset_ = boost::shared_ptr<AnyAssetReference>(new AnyAssetReference(assetNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<AnyAssetReference> VolatilityRepresentation::getAsset()
{
   if(!this->assetIsNull_){
        if(assetIDRef_ != ""){
             return boost::shared_static_cast<AnyAssetReference>(IDManager::instance().getID(assetIDRef_));
        }else{
             return this->asset_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AnyAssetReference>();
   }
}
}

