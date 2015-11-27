// WeightedPartialDerivative.cpp 
#include "WeightedPartialDerivative.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

WeightedPartialDerivative::WeightedPartialDerivative(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //partialDerivativeReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* partialDerivativeReferenceNode = xmlNode->FirstChildElement("partialDerivativeReference");

   if(partialDerivativeReferenceNode){partialDerivativeReferenceIsNull_ = false;}
   else{partialDerivativeReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- partialDerivativeReferenceNode , address : " << partialDerivativeReferenceNode << std::endl;
   #endif
   if(partialDerivativeReferenceNode)
   {
      if(partialDerivativeReferenceNode->Attribute("href") || partialDerivativeReferenceNode->Attribute("id"))
      {
          if(partialDerivativeReferenceNode->Attribute("id"))
          {
             partialDerivativeReferenceIDRef_ = partialDerivativeReferenceNode->Attribute("id");
             partialDerivativeReference_ = boost::shared_ptr<PricingParameterDerivativeReference>(new PricingParameterDerivativeReference(partialDerivativeReferenceNode));
             partialDerivativeReference_->setID(partialDerivativeReferenceIDRef_);
             IDManager::instance().setID(partialDerivativeReferenceIDRef_,partialDerivativeReference_);
          }
          else if(partialDerivativeReferenceNode->Attribute("href")) { partialDerivativeReferenceIDRef_ = partialDerivativeReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { partialDerivativeReference_ = boost::shared_ptr<PricingParameterDerivativeReference>(new PricingParameterDerivativeReference(partialDerivativeReferenceNode));}
   }

   //weightNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* weightNode = xmlNode->FirstChildElement("weight");

   if(weightNode){weightIsNull_ = false;}
   else{weightIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- weightNode , address : " << weightNode << std::endl;
   #endif
   if(weightNode)
   {
      if(weightNode->Attribute("href") || weightNode->Attribute("id"))
      {
          if(weightNode->Attribute("id"))
          {
             weightIDRef_ = weightNode->Attribute("id");
             weight_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(weightNode));
             weight_->setID(weightIDRef_);
             IDManager::instance().setID(weightIDRef_,weight_);
          }
          else if(weightNode->Attribute("href")) { weightIDRef_ = weightNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { weight_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(weightNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PricingParameterDerivativeReference> WeightedPartialDerivative::getPartialDerivativeReference()
{
   if(!this->partialDerivativeReferenceIsNull_){
        if(partialDerivativeReferenceIDRef_ != ""){
             return boost::shared_static_cast<PricingParameterDerivativeReference>(IDManager::instance().getID(partialDerivativeReferenceIDRef_));
        }else{
             return this->partialDerivativeReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PricingParameterDerivativeReference>();
   }
}
boost::shared_ptr<XsdTypeDecimal> WeightedPartialDerivative::getWeight()
{
   if(!this->weightIsNull_){
        if(weightIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(weightIDRef_));
        }else{
             return this->weight_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
}

