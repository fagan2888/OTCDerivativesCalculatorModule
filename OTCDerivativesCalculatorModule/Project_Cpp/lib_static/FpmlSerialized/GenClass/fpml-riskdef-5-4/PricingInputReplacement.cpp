// PricingInputReplacement.cpp 
#include "PricingInputReplacement.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

PricingInputReplacement::PricingInputReplacement(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //originalInputReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* originalInputReferenceNode = xmlNode->FirstChildElement("originalInputReference");

   if(originalInputReferenceNode){originalInputReferenceIsNull_ = false;}
   else{originalInputReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- originalInputReferenceNode , address : " << originalInputReferenceNode << std::endl;
   #endif
   if(originalInputReferenceNode)
   {
      if(originalInputReferenceNode->Attribute("href") || originalInputReferenceNode->Attribute("id"))
      {
          if(originalInputReferenceNode->Attribute("id"))
          {
             originalInputReferenceIDRef_ = originalInputReferenceNode->Attribute("id");
             originalInputReference_ = boost::shared_ptr<PricingStructureReference>(new PricingStructureReference(originalInputReferenceNode));
             originalInputReference_->setID(originalInputReferenceIDRef_);
             IDManager::instance().setID(originalInputReferenceIDRef_,originalInputReference_);
          }
          else if(originalInputReferenceNode->Attribute("href")) { originalInputReferenceIDRef_ = originalInputReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { originalInputReference_ = boost::shared_ptr<PricingStructureReference>(new PricingStructureReference(originalInputReferenceNode));}
   }

   //replacementInputReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* replacementInputReferenceNode = xmlNode->FirstChildElement("replacementInputReference");

   if(replacementInputReferenceNode){replacementInputReferenceIsNull_ = false;}
   else{replacementInputReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- replacementInputReferenceNode , address : " << replacementInputReferenceNode << std::endl;
   #endif
   if(replacementInputReferenceNode)
   {
      if(replacementInputReferenceNode->Attribute("href") || replacementInputReferenceNode->Attribute("id"))
      {
          if(replacementInputReferenceNode->Attribute("id"))
          {
             replacementInputReferenceIDRef_ = replacementInputReferenceNode->Attribute("id");
             replacementInputReference_ = boost::shared_ptr<PricingStructureReference>(new PricingStructureReference(replacementInputReferenceNode));
             replacementInputReference_->setID(replacementInputReferenceIDRef_);
             IDManager::instance().setID(replacementInputReferenceIDRef_,replacementInputReference_);
          }
          else if(replacementInputReferenceNode->Attribute("href")) { replacementInputReferenceIDRef_ = replacementInputReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { replacementInputReference_ = boost::shared_ptr<PricingStructureReference>(new PricingStructureReference(replacementInputReferenceNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PricingStructureReference> PricingInputReplacement::getOriginalInputReference()
{
   if(!this->originalInputReferenceIsNull_){
        if(originalInputReferenceIDRef_ != ""){
             return boost::shared_static_cast<PricingStructureReference>(IDManager::instance().getID(originalInputReferenceIDRef_));
        }else{
             return this->originalInputReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PricingStructureReference>();
   }
}
boost::shared_ptr<PricingStructureReference> PricingInputReplacement::getReplacementInputReference()
{
   if(!this->replacementInputReferenceIsNull_){
        if(replacementInputReferenceIDRef_ != ""){
             return boost::shared_static_cast<PricingStructureReference>(IDManager::instance().getID(replacementInputReferenceIDRef_));
        }else{
             return this->replacementInputReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PricingStructureReference>();
   }
}
}

