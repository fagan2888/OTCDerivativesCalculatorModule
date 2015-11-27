// GasProduct.cpp 
#include "GasProduct.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

GasProduct::GasProduct(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
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
             type_ = boost::shared_ptr<GasProductTypeEnum>(new GasProductTypeEnum(typeNode));
             type_->setID(typeIDRef_);
             IDManager::instance().setID(typeIDRef_,type_);
          }
          else if(typeNode->Attribute("href")) { typeIDRef_ = typeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { type_ = boost::shared_ptr<GasProductTypeEnum>(new GasProductTypeEnum(typeNode));}
   }

   //calorificValueNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calorificValueNode = xmlNode->FirstChildElement("calorificValue");

   if(calorificValueNode){calorificValueIsNull_ = false;}
   else{calorificValueIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calorificValueNode , address : " << calorificValueNode << std::endl;
   #endif
   if(calorificValueNode)
   {
      if(calorificValueNode->Attribute("href") || calorificValueNode->Attribute("id"))
      {
          if(calorificValueNode->Attribute("id"))
          {
             calorificValueIDRef_ = calorificValueNode->Attribute("id");
             calorificValue_ = boost::shared_ptr<NonNegativeDecimal>(new NonNegativeDecimal(calorificValueNode));
             calorificValue_->setID(calorificValueIDRef_);
             IDManager::instance().setID(calorificValueIDRef_,calorificValue_);
          }
          else if(calorificValueNode->Attribute("href")) { calorificValueIDRef_ = calorificValueNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { calorificValue_ = boost::shared_ptr<NonNegativeDecimal>(new NonNegativeDecimal(calorificValueNode));}
   }

   //qualityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* qualityNode = xmlNode->FirstChildElement("quality");

   if(qualityNode){qualityIsNull_ = false;}
   else{qualityIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- qualityNode , address : " << qualityNode << std::endl;
   #endif
   if(qualityNode)
   {
      if(qualityNode->Attribute("href") || qualityNode->Attribute("id"))
      {
          if(qualityNode->Attribute("id"))
          {
             qualityIDRef_ = qualityNode->Attribute("id");
             quality_ = boost::shared_ptr<GasQuality>(new GasQuality(qualityNode));
             quality_->setID(qualityIDRef_);
             IDManager::instance().setID(qualityIDRef_,quality_);
          }
          else if(qualityNode->Attribute("href")) { qualityIDRef_ = qualityNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { quality_ = boost::shared_ptr<GasQuality>(new GasQuality(qualityNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<GasProductTypeEnum> GasProduct::getType()
{
   if(!this->typeIsNull_){
        if(typeIDRef_ != ""){
             return boost::shared_static_cast<GasProductTypeEnum>(IDManager::instance().getID(typeIDRef_));
        }else{
             return this->type_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<GasProductTypeEnum>();
   }
}
boost::shared_ptr<NonNegativeDecimal> GasProduct::getCalorificValue()
{
   if(!this->calorificValueIsNull_){
        if(calorificValueIDRef_ != ""){
             return boost::shared_static_cast<NonNegativeDecimal>(IDManager::instance().getID(calorificValueIDRef_));
        }else{
             return this->calorificValue_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NonNegativeDecimal>();
   }
}
boost::shared_ptr<GasQuality> GasProduct::getQuality()
{
   if(!this->qualityIsNull_){
        if(qualityIDRef_ != ""){
             return boost::shared_static_cast<GasQuality>(IDManager::instance().getID(qualityIDRef_));
        }else{
             return this->quality_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<GasQuality>();
   }
}
}

