// PriceSourceDisruption.cpp 
#include "PriceSourceDisruption.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

PriceSourceDisruption::PriceSourceDisruption(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //fallbackReferencePriceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fallbackReferencePriceNode = xmlNode->FirstChildElement("fallbackReferencePrice");

   if(fallbackReferencePriceNode){fallbackReferencePriceIsNull_ = false;}
   else{fallbackReferencePriceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fallbackReferencePriceNode , address : " << fallbackReferencePriceNode << std::endl;
   #endif
   if(fallbackReferencePriceNode)
   {
      if(fallbackReferencePriceNode->Attribute("href") || fallbackReferencePriceNode->Attribute("id"))
      {
          if(fallbackReferencePriceNode->Attribute("id"))
          {
             fallbackReferencePriceIDRef_ = fallbackReferencePriceNode->Attribute("id");
             fallbackReferencePrice_ = boost::shared_ptr<FallbackReferencePrice>(new FallbackReferencePrice(fallbackReferencePriceNode));
             fallbackReferencePrice_->setID(fallbackReferencePriceIDRef_);
             IDManager::instance().setID(fallbackReferencePriceIDRef_,fallbackReferencePrice_);
          }
          else if(fallbackReferencePriceNode->Attribute("href")) { fallbackReferencePriceIDRef_ = fallbackReferencePriceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fallbackReferencePrice_ = boost::shared_ptr<FallbackReferencePrice>(new FallbackReferencePrice(fallbackReferencePriceNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<FallbackReferencePrice> PriceSourceDisruption::getFallbackReferencePrice()
{
   if(!this->fallbackReferencePriceIsNull_){
        if(fallbackReferencePriceIDRef_ != ""){
             return boost::shared_static_cast<FallbackReferencePrice>(IDManager::instance().getID(fallbackReferencePriceIDRef_));
        }else{
             return this->fallbackReferencePrice_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FallbackReferencePrice>();
   }
}
}

