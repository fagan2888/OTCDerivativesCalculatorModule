// CoalProduct.cpp 
#include "CoalProduct.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CoalProduct::CoalProduct(TiXmlNode* xmlNode)
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
             type_ = boost::shared_ptr<CoalProductType>(new CoalProductType(typeNode));
             type_->setID(typeIDRef_);
             IDManager::instance().setID(typeIDRef_,type_);
          }
          else if(typeNode->Attribute("href")) { typeIDRef_ = typeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { type_ = boost::shared_ptr<CoalProductType>(new CoalProductType(typeNode));}
   }

   //coalProductSpecificationsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* coalProductSpecificationsNode = xmlNode->FirstChildElement("coalProductSpecifications");

   if(coalProductSpecificationsNode){coalProductSpecificationsIsNull_ = false;}
   else{coalProductSpecificationsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- coalProductSpecificationsNode , address : " << coalProductSpecificationsNode << std::endl;
   #endif
   if(coalProductSpecificationsNode)
   {
      if(coalProductSpecificationsNode->Attribute("href") || coalProductSpecificationsNode->Attribute("id"))
      {
          if(coalProductSpecificationsNode->Attribute("id"))
          {
             coalProductSpecificationsIDRef_ = coalProductSpecificationsNode->Attribute("id");
             coalProductSpecifications_ = boost::shared_ptr<CoalProductSpecifications>(new CoalProductSpecifications(coalProductSpecificationsNode));
             coalProductSpecifications_->setID(coalProductSpecificationsIDRef_);
             IDManager::instance().setID(coalProductSpecificationsIDRef_,coalProductSpecifications_);
          }
          else if(coalProductSpecificationsNode->Attribute("href")) { coalProductSpecificationsIDRef_ = coalProductSpecificationsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { coalProductSpecifications_ = boost::shared_ptr<CoalProductSpecifications>(new CoalProductSpecifications(coalProductSpecificationsNode));}
   }

   //sourceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* sourceNode = xmlNode->FirstChildElement("source");

   if(sourceNode){sourceIsNull_ = false;}
   else{sourceIsNull_ = true;}

   if(sourceNode)
   {
      for(sourceNode; sourceNode; sourceNode = sourceNode->NextSiblingElement("source")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- sourceNode , address : " << sourceNode << std::endl;
          #endif
          if(sourceNode->Attribute("href") || sourceNode->Attribute("id"))
          {
              if(sourceNode->Attribute("id"))
              {
                  sourceIDRef_ = sourceNode->Attribute("id");
                  source_.push_back(boost::shared_ptr<CoalProductSource>(new CoalProductSource(sourceNode)));
                  source_.back()->setID(sourceIDRef_);
                  IDManager::instance().setID(sourceIDRef_, source_.back());
              }
              else if(sourceNode->Attribute("href")) { sourceIDRef_ = sourceNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { source_.push_back(boost::shared_ptr<CoalProductSource>(new CoalProductSource(sourceNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- sourceNode , address : " << sourceNode << std::endl;
       #endif
   }

   //sCoTASpecificationsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* sCoTASpecificationsNode = xmlNode->FirstChildElement("sCoTASpecifications");

   if(sCoTASpecificationsNode){sCoTASpecificationsIsNull_ = false;}
   else{sCoTASpecificationsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- sCoTASpecificationsNode , address : " << sCoTASpecificationsNode << std::endl;
   #endif
   if(sCoTASpecificationsNode)
   {
      if(sCoTASpecificationsNode->Attribute("href") || sCoTASpecificationsNode->Attribute("id"))
      {
          if(sCoTASpecificationsNode->Attribute("id"))
          {
             sCoTASpecificationsIDRef_ = sCoTASpecificationsNode->Attribute("id");
             sCoTASpecifications_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(sCoTASpecificationsNode));
             sCoTASpecifications_->setID(sCoTASpecificationsIDRef_);
             IDManager::instance().setID(sCoTASpecificationsIDRef_,sCoTASpecifications_);
          }
          else if(sCoTASpecificationsNode->Attribute("href")) { sCoTASpecificationsIDRef_ = sCoTASpecificationsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { sCoTASpecifications_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(sCoTASpecificationsNode));}
   }

   //btuQualityAdjustmentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* btuQualityAdjustmentNode = xmlNode->FirstChildElement("btuQualityAdjustment");

   if(btuQualityAdjustmentNode){btuQualityAdjustmentIsNull_ = false;}
   else{btuQualityAdjustmentIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- btuQualityAdjustmentNode , address : " << btuQualityAdjustmentNode << std::endl;
   #endif
   if(btuQualityAdjustmentNode)
   {
      if(btuQualityAdjustmentNode->Attribute("href") || btuQualityAdjustmentNode->Attribute("id"))
      {
          if(btuQualityAdjustmentNode->Attribute("id"))
          {
             btuQualityAdjustmentIDRef_ = btuQualityAdjustmentNode->Attribute("id");
             btuQualityAdjustment_ = boost::shared_ptr<CoalQualityAdjustments>(new CoalQualityAdjustments(btuQualityAdjustmentNode));
             btuQualityAdjustment_->setID(btuQualityAdjustmentIDRef_);
             IDManager::instance().setID(btuQualityAdjustmentIDRef_,btuQualityAdjustment_);
          }
          else if(btuQualityAdjustmentNode->Attribute("href")) { btuQualityAdjustmentIDRef_ = btuQualityAdjustmentNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { btuQualityAdjustment_ = boost::shared_ptr<CoalQualityAdjustments>(new CoalQualityAdjustments(btuQualityAdjustmentNode));}
   }

   //so2QualityAdjustmentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* so2QualityAdjustmentNode = xmlNode->FirstChildElement("so2QualityAdjustment");

   if(so2QualityAdjustmentNode){so2QualityAdjustmentIsNull_ = false;}
   else{so2QualityAdjustmentIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- so2QualityAdjustmentNode , address : " << so2QualityAdjustmentNode << std::endl;
   #endif
   if(so2QualityAdjustmentNode)
   {
      if(so2QualityAdjustmentNode->Attribute("href") || so2QualityAdjustmentNode->Attribute("id"))
      {
          if(so2QualityAdjustmentNode->Attribute("id"))
          {
             so2QualityAdjustmentIDRef_ = so2QualityAdjustmentNode->Attribute("id");
             so2QualityAdjustment_ = boost::shared_ptr<CoalQualityAdjustments>(new CoalQualityAdjustments(so2QualityAdjustmentNode));
             so2QualityAdjustment_->setID(so2QualityAdjustmentIDRef_);
             IDManager::instance().setID(so2QualityAdjustmentIDRef_,so2QualityAdjustment_);
          }
          else if(so2QualityAdjustmentNode->Attribute("href")) { so2QualityAdjustmentIDRef_ = so2QualityAdjustmentNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { so2QualityAdjustment_ = boost::shared_ptr<CoalQualityAdjustments>(new CoalQualityAdjustments(so2QualityAdjustmentNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<CoalProductType> CoalProduct::getType()
{
   if(!this->typeIsNull_){
        if(typeIDRef_ != ""){
             return boost::shared_static_cast<CoalProductType>(IDManager::instance().getID(typeIDRef_));
        }else{
             return this->type_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CoalProductType>();
   }
}
boost::shared_ptr<CoalProductSpecifications> CoalProduct::getCoalProductSpecifications()
{
   if(!this->coalProductSpecificationsIsNull_){
        if(coalProductSpecificationsIDRef_ != ""){
             return boost::shared_static_cast<CoalProductSpecifications>(IDManager::instance().getID(coalProductSpecificationsIDRef_));
        }else{
             return this->coalProductSpecifications_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CoalProductSpecifications>();
   }
}
std::vector<boost::shared_ptr<CoalProductSource>> CoalProduct::getSource()
{
   if(!this->sourceIsNull_){
        if(sourceIDRef_ != ""){
             return this->source_;
        }else{
             return this->source_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<CoalProductSource>>();
   }
}
boost::shared_ptr<XsdTypeBoolean> CoalProduct::getSCoTASpecifications()
{
   if(!this->sCoTASpecificationsIsNull_){
        if(sCoTASpecificationsIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(sCoTASpecificationsIDRef_));
        }else{
             return this->sCoTASpecifications_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<CoalQualityAdjustments> CoalProduct::getBtuQualityAdjustment()
{
   if(!this->btuQualityAdjustmentIsNull_){
        if(btuQualityAdjustmentIDRef_ != ""){
             return boost::shared_static_cast<CoalQualityAdjustments>(IDManager::instance().getID(btuQualityAdjustmentIDRef_));
        }else{
             return this->btuQualityAdjustment_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CoalQualityAdjustments>();
   }
}
boost::shared_ptr<CoalQualityAdjustments> CoalProduct::getSo2QualityAdjustment()
{
   if(!this->so2QualityAdjustmentIsNull_){
        if(so2QualityAdjustmentIDRef_ != ""){
             return boost::shared_static_cast<CoalQualityAdjustments>(IDManager::instance().getID(so2QualityAdjustmentIDRef_));
        }else{
             return this->so2QualityAdjustment_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CoalQualityAdjustments>();
   }
}
}

