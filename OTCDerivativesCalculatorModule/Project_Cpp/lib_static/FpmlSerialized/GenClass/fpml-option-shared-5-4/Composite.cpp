// Composite.cpp 
#include "Composite.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Composite::Composite(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //determinationMethodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* determinationMethodNode = xmlNode->FirstChildElement("determinationMethod");

   if(determinationMethodNode){determinationMethodIsNull_ = false;}
   else{determinationMethodIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- determinationMethodNode , address : " << determinationMethodNode << std::endl;
   #endif
   if(determinationMethodNode)
   {
      if(determinationMethodNode->Attribute("href") || determinationMethodNode->Attribute("id"))
      {
          if(determinationMethodNode->Attribute("id"))
          {
             determinationMethodIDRef_ = determinationMethodNode->Attribute("id");
             determinationMethod_ = boost::shared_ptr<DeterminationMethod>(new DeterminationMethod(determinationMethodNode));
             determinationMethod_->setID(determinationMethodIDRef_);
             IDManager::instance().setID(determinationMethodIDRef_,determinationMethod_);
          }
          else if(determinationMethodNode->Attribute("href")) { determinationMethodIDRef_ = determinationMethodNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { determinationMethod_ = boost::shared_ptr<DeterminationMethod>(new DeterminationMethod(determinationMethodNode));}
   }

   //relativeDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* relativeDateNode = xmlNode->FirstChildElement("relativeDate");

   if(relativeDateNode){relativeDateIsNull_ = false;}
   else{relativeDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- relativeDateNode , address : " << relativeDateNode << std::endl;
   #endif
   if(relativeDateNode)
   {
      if(relativeDateNode->Attribute("href") || relativeDateNode->Attribute("id"))
      {
          if(relativeDateNode->Attribute("id"))
          {
             relativeDateIDRef_ = relativeDateNode->Attribute("id");
             relativeDate_ = boost::shared_ptr<RelativeDateOffset>(new RelativeDateOffset(relativeDateNode));
             relativeDate_->setID(relativeDateIDRef_);
             IDManager::instance().setID(relativeDateIDRef_,relativeDate_);
          }
          else if(relativeDateNode->Attribute("href")) { relativeDateIDRef_ = relativeDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { relativeDate_ = boost::shared_ptr<RelativeDateOffset>(new RelativeDateOffset(relativeDateNode));}
   }

   //fxSpotRateSourceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fxSpotRateSourceNode = xmlNode->FirstChildElement("fxSpotRateSource");

   if(fxSpotRateSourceNode){fxSpotRateSourceIsNull_ = false;}
   else{fxSpotRateSourceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fxSpotRateSourceNode , address : " << fxSpotRateSourceNode << std::endl;
   #endif
   if(fxSpotRateSourceNode)
   {
      if(fxSpotRateSourceNode->Attribute("href") || fxSpotRateSourceNode->Attribute("id"))
      {
          if(fxSpotRateSourceNode->Attribute("id"))
          {
             fxSpotRateSourceIDRef_ = fxSpotRateSourceNode->Attribute("id");
             fxSpotRateSource_ = boost::shared_ptr<FxSpotRateSource>(new FxSpotRateSource(fxSpotRateSourceNode));
             fxSpotRateSource_->setID(fxSpotRateSourceIDRef_);
             IDManager::instance().setID(fxSpotRateSourceIDRef_,fxSpotRateSource_);
          }
          else if(fxSpotRateSourceNode->Attribute("href")) { fxSpotRateSourceIDRef_ = fxSpotRateSourceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fxSpotRateSource_ = boost::shared_ptr<FxSpotRateSource>(new FxSpotRateSource(fxSpotRateSourceNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<DeterminationMethod> Composite::getDeterminationMethod()
{
   if(!this->determinationMethodIsNull_){
        if(determinationMethodIDRef_ != ""){
             return boost::shared_static_cast<DeterminationMethod>(IDManager::instance().getID(determinationMethodIDRef_));
        }else{
             return this->determinationMethod_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DeterminationMethod>();
   }
}
boost::shared_ptr<RelativeDateOffset> Composite::getRelativeDate()
{
   if(!this->relativeDateIsNull_){
        if(relativeDateIDRef_ != ""){
             return boost::shared_static_cast<RelativeDateOffset>(IDManager::instance().getID(relativeDateIDRef_));
        }else{
             return this->relativeDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<RelativeDateOffset>();
   }
}
boost::shared_ptr<FxSpotRateSource> Composite::getFxSpotRateSource()
{
   if(!this->fxSpotRateSourceIsNull_){
        if(fxSpotRateSourceIDRef_ != ""){
             return boost::shared_static_cast<FxSpotRateSource>(IDManager::instance().getID(fxSpotRateSourceIDRef_));
        }else{
             return this->fxSpotRateSource_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FxSpotRateSource>();
   }
}
}

