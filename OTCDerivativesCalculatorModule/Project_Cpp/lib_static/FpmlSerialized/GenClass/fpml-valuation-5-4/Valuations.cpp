// Valuations.cpp 
#include "Valuations.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Valuations::Valuations(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //valuationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* valuationNode = xmlNode->FirstChildElement("valuation");

   if(valuationNode){valuationIsNull_ = false;}
   else{valuationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- valuationNode , address : " << valuationNode << std::endl;
   #endif
   if(valuationNode)
   {
      if(valuationNode->Attribute("href") || valuationNode->Attribute("id"))
      {
          if(valuationNode->Attribute("id"))
          {
             valuationIDRef_ = valuationNode->Attribute("id");
             valuation_ = boost::shared_ptr<AssetValuation>(new AssetValuation(valuationNode));
             valuation_->setID(valuationIDRef_);
             IDManager::instance().setID(valuationIDRef_,valuation_);
          }
          else if(valuationNode->Attribute("href")) { valuationIDRef_ = valuationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { valuation_ = boost::shared_ptr<AssetValuation>(new AssetValuation(valuationNode));}
   }

   //valuationReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* valuationReferenceNode = xmlNode->FirstChildElement("valuationReference");

   if(valuationReferenceNode){valuationReferenceIsNull_ = false;}
   else{valuationReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- valuationReferenceNode , address : " << valuationReferenceNode << std::endl;
   #endif
   if(valuationReferenceNode)
   {
      if(valuationReferenceNode->Attribute("href") || valuationReferenceNode->Attribute("id"))
      {
          if(valuationReferenceNode->Attribute("id"))
          {
             valuationReferenceIDRef_ = valuationReferenceNode->Attribute("id");
             valuationReference_ = boost::shared_ptr<ValuationReference>(new ValuationReference(valuationReferenceNode));
             valuationReference_->setID(valuationReferenceIDRef_);
             IDManager::instance().setID(valuationReferenceIDRef_,valuationReference_);
          }
          else if(valuationReferenceNode->Attribute("href")) { valuationReferenceIDRef_ = valuationReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { valuationReference_ = boost::shared_ptr<ValuationReference>(new ValuationReference(valuationReferenceNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<AssetValuation> Valuations::getValuation()
{
   if(!this->valuationIsNull_){
        if(valuationIDRef_ != ""){
             return boost::shared_static_cast<AssetValuation>(IDManager::instance().getID(valuationIDRef_));
        }else{
             return this->valuation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AssetValuation>();
   }
}
boost::shared_ptr<ValuationReference> Valuations::getValuationReference()
{
   if(!this->valuationReferenceIsNull_){
        if(valuationReferenceIDRef_ != ""){
             return boost::shared_static_cast<ValuationReference>(IDManager::instance().getID(valuationReferenceIDRef_));
        }else{
             return this->valuationReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ValuationReference>();
   }
}
}

