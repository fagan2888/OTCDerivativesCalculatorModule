// FormulaTerm.cpp 
#include "FormulaTerm.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FormulaTerm::FormulaTerm(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //coefficientNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* coefficientNode = xmlNode->FirstChildElement("coefficient");

   if(coefficientNode){coefficientIsNull_ = false;}
   else{coefficientIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- coefficientNode , address : " << coefficientNode << std::endl;
   #endif
   if(coefficientNode)
   {
      if(coefficientNode->Attribute("href") || coefficientNode->Attribute("id"))
      {
          if(coefficientNode->Attribute("id"))
          {
             coefficientIDRef_ = coefficientNode->Attribute("id");
             coefficient_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(coefficientNode));
             coefficient_->setID(coefficientIDRef_);
             IDManager::instance().setID(coefficientIDRef_,coefficient_);
          }
          else if(coefficientNode->Attribute("href")) { coefficientIDRef_ = coefficientNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { coefficient_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(coefficientNode));}
   }

   //partialDerivativeReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* partialDerivativeReferenceNode = xmlNode->FirstChildElement("partialDerivativeReference");

   if(partialDerivativeReferenceNode){partialDerivativeReferenceIsNull_ = false;}
   else{partialDerivativeReferenceIsNull_ = true;}

   if(partialDerivativeReferenceNode)
   {
      for(partialDerivativeReferenceNode; partialDerivativeReferenceNode; partialDerivativeReferenceNode = partialDerivativeReferenceNode->NextSiblingElement("partialDerivativeReference")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- partialDerivativeReferenceNode , address : " << partialDerivativeReferenceNode << std::endl;
          #endif
          if(partialDerivativeReferenceNode->Attribute("href") || partialDerivativeReferenceNode->Attribute("id"))
          {
              if(partialDerivativeReferenceNode->Attribute("id"))
              {
                  partialDerivativeReferenceIDRef_ = partialDerivativeReferenceNode->Attribute("id");
                  partialDerivativeReference_.push_back(boost::shared_ptr<PricingParameterDerivativeReference>(new PricingParameterDerivativeReference(partialDerivativeReferenceNode)));
                  partialDerivativeReference_.back()->setID(partialDerivativeReferenceIDRef_);
                  IDManager::instance().setID(partialDerivativeReferenceIDRef_, partialDerivativeReference_.back());
              }
              else if(partialDerivativeReferenceNode->Attribute("href")) { partialDerivativeReferenceIDRef_ = partialDerivativeReferenceNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { partialDerivativeReference_.push_back(boost::shared_ptr<PricingParameterDerivativeReference>(new PricingParameterDerivativeReference(partialDerivativeReferenceNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- partialDerivativeReferenceNode , address : " << partialDerivativeReferenceNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDecimal> FormulaTerm::getCoefficient()
{
   if(!this->coefficientIsNull_){
        if(coefficientIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(coefficientIDRef_));
        }else{
             return this->coefficient_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
std::vector<boost::shared_ptr<PricingParameterDerivativeReference>> FormulaTerm::getPartialDerivativeReference()
{
   if(!this->partialDerivativeReferenceIsNull_){
        if(partialDerivativeReferenceIDRef_ != ""){
             return this->partialDerivativeReference_;
        }else{
             return this->partialDerivativeReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<PricingParameterDerivativeReference>>();
   }
}
}

