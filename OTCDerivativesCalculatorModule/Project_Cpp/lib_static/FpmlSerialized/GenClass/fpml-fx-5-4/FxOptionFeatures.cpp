// FxOptionFeatures.cpp 
#include "FxOptionFeatures.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FxOptionFeatures::FxOptionFeatures(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //asianNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* asianNode = xmlNode->FirstChildElement("asian");

   if(asianNode){asianIsNull_ = false;}
   else{asianIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- asianNode , address : " << asianNode << std::endl;
   #endif
   if(asianNode)
   {
      if(asianNode->Attribute("href") || asianNode->Attribute("id"))
      {
          if(asianNode->Attribute("id"))
          {
             asianIDRef_ = asianNode->Attribute("id");
             asian_ = boost::shared_ptr<FxAsianFeature>(new FxAsianFeature(asianNode));
             asian_->setID(asianIDRef_);
             IDManager::instance().setID(asianIDRef_,asian_);
          }
          else if(asianNode->Attribute("href")) { asianIDRef_ = asianNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { asian_ = boost::shared_ptr<FxAsianFeature>(new FxAsianFeature(asianNode));}
   }

   //barrierNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* barrierNode = xmlNode->FirstChildElement("barrier");

   if(barrierNode){barrierIsNull_ = false;}
   else{barrierIsNull_ = true;}

   if(barrierNode)
   {
      for(barrierNode; barrierNode; barrierNode = barrierNode->NextSiblingElement("barrier")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- barrierNode , address : " << barrierNode << std::endl;
          #endif
          if(barrierNode->Attribute("href") || barrierNode->Attribute("id"))
          {
              if(barrierNode->Attribute("id"))
              {
                  barrierIDRef_ = barrierNode->Attribute("id");
                  barrier_.push_back(boost::shared_ptr<FxBarrierFeature>(new FxBarrierFeature(barrierNode)));
                  barrier_.back()->setID(barrierIDRef_);
                  IDManager::instance().setID(barrierIDRef_, barrier_.back());
              }
              else if(barrierNode->Attribute("href")) { barrierIDRef_ = barrierNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { barrier_.push_back(boost::shared_ptr<FxBarrierFeature>(new FxBarrierFeature(barrierNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- barrierNode , address : " << barrierNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<FxAsianFeature> FxOptionFeatures::getAsian()
{
   if(!this->asianIsNull_){
        if(asianIDRef_ != ""){
             return boost::shared_static_cast<FxAsianFeature>(IDManager::instance().getID(asianIDRef_));
        }else{
             return this->asian_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FxAsianFeature>();
   }
}
std::vector<boost::shared_ptr<FxBarrierFeature>> FxOptionFeatures::getBarrier()
{
   if(!this->barrierIsNull_){
        if(barrierIDRef_ != ""){
             return this->barrier_;
        }else{
             return this->barrier_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<FxBarrierFeature>>();
   }
}
}

