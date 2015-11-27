// PricingMethod.cpp 
#include "PricingMethod.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

PricingMethod::PricingMethod(TiXmlNode* xmlNode)
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
             assetReference_ = boost::shared_ptr<AnyAssetReference>(new AnyAssetReference(assetReferenceNode));
             assetReference_->setID(assetReferenceIDRef_);
             IDManager::instance().setID(assetReferenceIDRef_,assetReference_);
          }
          else if(assetReferenceNode->Attribute("href")) { assetReferenceIDRef_ = assetReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { assetReference_ = boost::shared_ptr<AnyAssetReference>(new AnyAssetReference(assetReferenceNode));}
   }

   //pricingInputReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* pricingInputReferenceNode = xmlNode->FirstChildElement("pricingInputReference");

   if(pricingInputReferenceNode){pricingInputReferenceIsNull_ = false;}
   else{pricingInputReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- pricingInputReferenceNode , address : " << pricingInputReferenceNode << std::endl;
   #endif
   if(pricingInputReferenceNode)
   {
      if(pricingInputReferenceNode->Attribute("href") || pricingInputReferenceNode->Attribute("id"))
      {
          if(pricingInputReferenceNode->Attribute("id"))
          {
             pricingInputReferenceIDRef_ = pricingInputReferenceNode->Attribute("id");
             pricingInputReference_ = boost::shared_ptr<PricingStructureReference>(new PricingStructureReference(pricingInputReferenceNode));
             pricingInputReference_->setID(pricingInputReferenceIDRef_);
             IDManager::instance().setID(pricingInputReferenceIDRef_,pricingInputReference_);
          }
          else if(pricingInputReferenceNode->Attribute("href")) { pricingInputReferenceIDRef_ = pricingInputReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { pricingInputReference_ = boost::shared_ptr<PricingStructureReference>(new PricingStructureReference(pricingInputReferenceNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<AnyAssetReference> PricingMethod::getAssetReference()
{
   if(!this->assetReferenceIsNull_){
        if(assetReferenceIDRef_ != ""){
             return boost::shared_static_cast<AnyAssetReference>(IDManager::instance().getID(assetReferenceIDRef_));
        }else{
             return this->assetReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AnyAssetReference>();
   }
}
boost::shared_ptr<PricingStructureReference> PricingMethod::getPricingInputReference()
{
   if(!this->pricingInputReferenceIsNull_){
        if(pricingInputReferenceIDRef_ != ""){
             return boost::shared_static_cast<PricingStructureReference>(IDManager::instance().getID(pricingInputReferenceIDRef_));
        }else{
             return this->pricingInputReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PricingStructureReference>();
   }
}
}

