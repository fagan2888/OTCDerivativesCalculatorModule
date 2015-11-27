// FxSwap.cpp 
#include "FxSwap.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FxSwap::FxSwap(TiXmlNode* xmlNode)
: Product(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //nearLegNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* nearLegNode = xmlNode->FirstChildElement("nearLeg");

   if(nearLegNode){nearLegIsNull_ = false;}
   else{nearLegIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- nearLegNode , address : " << nearLegNode << std::endl;
   #endif
   if(nearLegNode)
   {
      if(nearLegNode->Attribute("href") || nearLegNode->Attribute("id"))
      {
          if(nearLegNode->Attribute("id"))
          {
             nearLegIDRef_ = nearLegNode->Attribute("id");
             nearLeg_ = boost::shared_ptr<FxSwapLeg>(new FxSwapLeg(nearLegNode));
             nearLeg_->setID(nearLegIDRef_);
             IDManager::instance().setID(nearLegIDRef_,nearLeg_);
          }
          else if(nearLegNode->Attribute("href")) { nearLegIDRef_ = nearLegNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { nearLeg_ = boost::shared_ptr<FxSwapLeg>(new FxSwapLeg(nearLegNode));}
   }

   //farLegNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* farLegNode = xmlNode->FirstChildElement("farLeg");

   if(farLegNode){farLegIsNull_ = false;}
   else{farLegIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- farLegNode , address : " << farLegNode << std::endl;
   #endif
   if(farLegNode)
   {
      if(farLegNode->Attribute("href") || farLegNode->Attribute("id"))
      {
          if(farLegNode->Attribute("id"))
          {
             farLegIDRef_ = farLegNode->Attribute("id");
             farLeg_ = boost::shared_ptr<FxSwapLeg>(new FxSwapLeg(farLegNode));
             farLeg_->setID(farLegIDRef_);
             IDManager::instance().setID(farLegIDRef_,farLeg_);
          }
          else if(farLegNode->Attribute("href")) { farLegIDRef_ = farLegNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { farLeg_ = boost::shared_ptr<FxSwapLeg>(new FxSwapLeg(farLegNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<FxSwapLeg> FxSwap::getNearLeg()
{
   if(!this->nearLegIsNull_){
        if(nearLegIDRef_ != ""){
             return boost::shared_static_cast<FxSwapLeg>(IDManager::instance().getID(nearLegIDRef_));
        }else{
             return this->nearLeg_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FxSwapLeg>();
   }
}
boost::shared_ptr<FxSwapLeg> FxSwap::getFarLeg()
{
   if(!this->farLegIsNull_){
        if(farLegIDRef_ != ""){
             return boost::shared_static_cast<FxSwapLeg>(IDManager::instance().getID(farLegIDRef_));
        }else{
             return this->farLeg_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FxSwapLeg>();
   }
}
}

