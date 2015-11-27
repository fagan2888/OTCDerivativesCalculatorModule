// Quanto.cpp 
#include "Quanto.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Quanto::Quanto(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //fxRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fxRateNode = xmlNode->FirstChildElement("fxRate");

   if(fxRateNode){fxRateIsNull_ = false;}
   else{fxRateIsNull_ = true;}

   if(fxRateNode)
   {
      for(fxRateNode; fxRateNode; fxRateNode = fxRateNode->NextSiblingElement("fxRate")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fxRateNode , address : " << fxRateNode << std::endl;
          #endif
          if(fxRateNode->Attribute("href") || fxRateNode->Attribute("id"))
          {
              if(fxRateNode->Attribute("id"))
              {
                  fxRateIDRef_ = fxRateNode->Attribute("id");
                  fxRate_.push_back(boost::shared_ptr<FxRate>(new FxRate(fxRateNode)));
                  fxRate_.back()->setID(fxRateIDRef_);
                  IDManager::instance().setID(fxRateIDRef_, fxRate_.back());
              }
              else if(fxRateNode->Attribute("href")) { fxRateIDRef_ = fxRateNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { fxRate_.push_back(boost::shared_ptr<FxRate>(new FxRate(fxRateNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fxRateNode , address : " << fxRateNode << std::endl;
       #endif
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
std::vector<boost::shared_ptr<FxRate>> Quanto::getFxRate()
{
   if(!this->fxRateIsNull_){
        if(fxRateIDRef_ != ""){
             return this->fxRate_;
        }else{
             return this->fxRate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<FxRate>>();
   }
}
boost::shared_ptr<FxSpotRateSource> Quanto::getFxSpotRateSource()
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

