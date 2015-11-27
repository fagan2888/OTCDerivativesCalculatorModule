// ScheduledDate.cpp 
#include "ScheduledDate.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ScheduledDate::ScheduledDate(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //unadjustedDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* unadjustedDateNode = xmlNode->FirstChildElement("unadjustedDate");

   if(unadjustedDateNode){unadjustedDateIsNull_ = false;}
   else{unadjustedDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- unadjustedDateNode , address : " << unadjustedDateNode << std::endl;
   #endif
   if(unadjustedDateNode)
   {
      if(unadjustedDateNode->Attribute("href") || unadjustedDateNode->Attribute("id"))
      {
          if(unadjustedDateNode->Attribute("id"))
          {
             unadjustedDateIDRef_ = unadjustedDateNode->Attribute("id");
             unadjustedDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(unadjustedDateNode));
             unadjustedDate_->setID(unadjustedDateIDRef_);
             IDManager::instance().setID(unadjustedDateIDRef_,unadjustedDate_);
          }
          else if(unadjustedDateNode->Attribute("href")) { unadjustedDateIDRef_ = unadjustedDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { unadjustedDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(unadjustedDateNode));}
   }

   //adjustedDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* adjustedDateNode = xmlNode->FirstChildElement("adjustedDate");

   if(adjustedDateNode){adjustedDateIsNull_ = false;}
   else{adjustedDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- adjustedDateNode , address : " << adjustedDateNode << std::endl;
   #endif
   if(adjustedDateNode)
   {
      if(adjustedDateNode->Attribute("href") || adjustedDateNode->Attribute("id"))
      {
          if(adjustedDateNode->Attribute("id"))
          {
             adjustedDateIDRef_ = adjustedDateNode->Attribute("id");
             adjustedDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(adjustedDateNode));
             adjustedDate_->setID(adjustedDateIDRef_);
             IDManager::instance().setID(adjustedDateIDRef_,adjustedDate_);
          }
          else if(adjustedDateNode->Attribute("href")) { adjustedDateIDRef_ = adjustedDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { adjustedDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(adjustedDateNode));}
   }

   //typeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* typeNode = xmlNode->FirstChildElement("type");

   if(typeNode){typeIsNull_ = false;}
   else{typeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- typeNode , address : " << typeNode << std::endl;
   #endif
   if(typeNode)
   {
      if(typeNode->Attribute("href") || typeNode->Attribute("id"))
      {
          if(typeNode->Attribute("id"))
          {
             typeIDRef_ = typeNode->Attribute("id");
             type_ = boost::shared_ptr<ScheduledDateType>(new ScheduledDateType(typeNode));
             type_->setID(typeIDRef_);
             IDManager::instance().setID(typeIDRef_,type_);
          }
          else if(typeNode->Attribute("href")) { typeIDRef_ = typeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { type_ = boost::shared_ptr<ScheduledDateType>(new ScheduledDateType(typeNode));}
   }

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

   //associatedValueNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* associatedValueNode = xmlNode->FirstChildElement("associatedValue");

   if(associatedValueNode){associatedValueIsNull_ = false;}
   else{associatedValueIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- associatedValueNode , address : " << associatedValueNode << std::endl;
   #endif
   if(associatedValueNode)
   {
      if(associatedValueNode->Attribute("href") || associatedValueNode->Attribute("id"))
      {
          if(associatedValueNode->Attribute("id"))
          {
             associatedValueIDRef_ = associatedValueNode->Attribute("id");
             associatedValue_ = boost::shared_ptr<AssetValuation>(new AssetValuation(associatedValueNode));
             associatedValue_->setID(associatedValueIDRef_);
             IDManager::instance().setID(associatedValueIDRef_,associatedValue_);
          }
          else if(associatedValueNode->Attribute("href")) { associatedValueIDRef_ = associatedValueNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { associatedValue_ = boost::shared_ptr<AssetValuation>(new AssetValuation(associatedValueNode));}
   }

   //associatedValueReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* associatedValueReferenceNode = xmlNode->FirstChildElement("associatedValueReference");

   if(associatedValueReferenceNode){associatedValueReferenceIsNull_ = false;}
   else{associatedValueReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- associatedValueReferenceNode , address : " << associatedValueReferenceNode << std::endl;
   #endif
   if(associatedValueReferenceNode)
   {
      if(associatedValueReferenceNode->Attribute("href") || associatedValueReferenceNode->Attribute("id"))
      {
          if(associatedValueReferenceNode->Attribute("id"))
          {
             associatedValueReferenceIDRef_ = associatedValueReferenceNode->Attribute("id");
             associatedValueReference_ = boost::shared_ptr<ValuationReference>(new ValuationReference(associatedValueReferenceNode));
             associatedValueReference_->setID(associatedValueReferenceIDRef_);
             IDManager::instance().setID(associatedValueReferenceIDRef_,associatedValueReference_);
          }
          else if(associatedValueReferenceNode->Attribute("href")) { associatedValueReferenceIDRef_ = associatedValueReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { associatedValueReference_ = boost::shared_ptr<ValuationReference>(new ValuationReference(associatedValueReferenceNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDate> ScheduledDate::getUnadjustedDate()
{
   if(!this->unadjustedDateIsNull_){
        if(unadjustedDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(unadjustedDateIDRef_));
        }else{
             return this->unadjustedDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<XsdTypeDate> ScheduledDate::getAdjustedDate()
{
   if(!this->adjustedDateIsNull_){
        if(adjustedDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(adjustedDateIDRef_));
        }else{
             return this->adjustedDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<ScheduledDateType> ScheduledDate::getType()
{
   if(!this->typeIsNull_){
        if(typeIDRef_ != ""){
             return boost::shared_static_cast<ScheduledDateType>(IDManager::instance().getID(typeIDRef_));
        }else{
             return this->type_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ScheduledDateType>();
   }
}
boost::shared_ptr<AnyAssetReference> ScheduledDate::getAssetReference()
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
boost::shared_ptr<AssetValuation> ScheduledDate::getAssociatedValue()
{
   if(!this->associatedValueIsNull_){
        if(associatedValueIDRef_ != ""){
             return boost::shared_static_cast<AssetValuation>(IDManager::instance().getID(associatedValueIDRef_));
        }else{
             return this->associatedValue_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AssetValuation>();
   }
}
boost::shared_ptr<ValuationReference> ScheduledDate::getAssociatedValueReference()
{
   if(!this->associatedValueReferenceIsNull_){
        if(associatedValueReferenceIDRef_ != ""){
             return boost::shared_static_cast<ValuationReference>(IDManager::instance().getID(associatedValueReferenceIDRef_));
        }else{
             return this->associatedValueReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ValuationReference>();
   }
}
}

