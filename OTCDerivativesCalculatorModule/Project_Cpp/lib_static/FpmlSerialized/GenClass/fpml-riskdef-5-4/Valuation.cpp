// Valuation.cpp 
#include "Valuation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Valuation::Valuation(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //objectReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* objectReferenceNode = xmlNode->FirstChildElement("objectReference");

   if(objectReferenceNode){objectReferenceIsNull_ = false;}
   else{objectReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- objectReferenceNode , address : " << objectReferenceNode << std::endl;
   #endif
   if(objectReferenceNode)
   {
      if(objectReferenceNode->Attribute("href") || objectReferenceNode->Attribute("id"))
      {
          if(objectReferenceNode->Attribute("id"))
          {
             objectReferenceIDRef_ = objectReferenceNode->Attribute("id");
             objectReference_ = boost::shared_ptr<AnyAssetReference>(new AnyAssetReference(objectReferenceNode));
             objectReference_->setID(objectReferenceIDRef_);
             IDManager::instance().setID(objectReferenceIDRef_,objectReference_);
          }
          else if(objectReferenceNode->Attribute("href")) { objectReferenceIDRef_ = objectReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { objectReference_ = boost::shared_ptr<AnyAssetReference>(new AnyAssetReference(objectReferenceNode));}
   }

   //valuationScenarioReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* valuationScenarioReferenceNode = xmlNode->FirstChildElement("valuationScenarioReference");

   if(valuationScenarioReferenceNode){valuationScenarioReferenceIsNull_ = false;}
   else{valuationScenarioReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- valuationScenarioReferenceNode , address : " << valuationScenarioReferenceNode << std::endl;
   #endif
   if(valuationScenarioReferenceNode)
   {
      if(valuationScenarioReferenceNode->Attribute("href") || valuationScenarioReferenceNode->Attribute("id"))
      {
          if(valuationScenarioReferenceNode->Attribute("id"))
          {
             valuationScenarioReferenceIDRef_ = valuationScenarioReferenceNode->Attribute("id");
             valuationScenarioReference_ = boost::shared_ptr<ValuationScenarioReference>(new ValuationScenarioReference(valuationScenarioReferenceNode));
             valuationScenarioReference_->setID(valuationScenarioReferenceIDRef_);
             IDManager::instance().setID(valuationScenarioReferenceIDRef_,valuationScenarioReference_);
          }
          else if(valuationScenarioReferenceNode->Attribute("href")) { valuationScenarioReferenceIDRef_ = valuationScenarioReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { valuationScenarioReference_ = boost::shared_ptr<ValuationScenarioReference>(new ValuationScenarioReference(valuationScenarioReferenceNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<AnyAssetReference> Valuation::getObjectReference()
{
   if(!this->objectReferenceIsNull_){
        if(objectReferenceIDRef_ != ""){
             return boost::shared_static_cast<AnyAssetReference>(IDManager::instance().getID(objectReferenceIDRef_));
        }else{
             return this->objectReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AnyAssetReference>();
   }
}
boost::shared_ptr<ValuationScenarioReference> Valuation::getValuationScenarioReference()
{
   if(!this->valuationScenarioReferenceIsNull_){
        if(valuationScenarioReferenceIDRef_ != ""){
             return boost::shared_static_cast<ValuationScenarioReference>(IDManager::instance().getID(valuationScenarioReferenceIDRef_));
        }else{
             return this->valuationScenarioReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ValuationScenarioReference>();
   }
}
}

