// BasketReferenceInformation.cpp 
#include "BasketReferenceInformation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

BasketReferenceInformation::BasketReferenceInformation(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //basketNameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* basketNameNode = xmlNode->FirstChildElement("basketName");

   if(basketNameNode){basketNameIsNull_ = false;}
   else{basketNameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- basketNameNode , address : " << basketNameNode << std::endl;
   #endif
   if(basketNameNode)
   {
      if(basketNameNode->Attribute("href") || basketNameNode->Attribute("id"))
      {
          if(basketNameNode->Attribute("id"))
          {
             basketNameIDRef_ = basketNameNode->Attribute("id");
             basketName_ = boost::shared_ptr<BasketName>(new BasketName(basketNameNode));
             basketName_->setID(basketNameIDRef_);
             IDManager::instance().setID(basketNameIDRef_,basketName_);
          }
          else if(basketNameNode->Attribute("href")) { basketNameIDRef_ = basketNameNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { basketName_ = boost::shared_ptr<BasketName>(new BasketName(basketNameNode));}
   }

   //basketIdNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* basketIdNode = xmlNode->FirstChildElement("basketId");

   if(basketIdNode){basketIdIsNull_ = false;}
   else{basketIdIsNull_ = true;}

   if(basketIdNode)
   {
      for(basketIdNode; basketIdNode; basketIdNode = basketIdNode->NextSiblingElement("basketId")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- basketIdNode , address : " << basketIdNode << std::endl;
          #endif
          if(basketIdNode->Attribute("href") || basketIdNode->Attribute("id"))
          {
              if(basketIdNode->Attribute("id"))
              {
                  basketIdIDRef_ = basketIdNode->Attribute("id");
                  basketId_.push_back(boost::shared_ptr<BasketId>(new BasketId(basketIdNode)));
                  basketId_.back()->setID(basketIdIDRef_);
                  IDManager::instance().setID(basketIdIDRef_, basketId_.back());
              }
              else if(basketIdNode->Attribute("href")) { basketIdIDRef_ = basketIdNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { basketId_.push_back(boost::shared_ptr<BasketId>(new BasketId(basketIdNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- basketIdNode , address : " << basketIdNode << std::endl;
       #endif
   }

   //referencePoolNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* referencePoolNode = xmlNode->FirstChildElement("referencePool");

   if(referencePoolNode){referencePoolIsNull_ = false;}
   else{referencePoolIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- referencePoolNode , address : " << referencePoolNode << std::endl;
   #endif
   if(referencePoolNode)
   {
      if(referencePoolNode->Attribute("href") || referencePoolNode->Attribute("id"))
      {
          if(referencePoolNode->Attribute("id"))
          {
             referencePoolIDRef_ = referencePoolNode->Attribute("id");
             referencePool_ = boost::shared_ptr<ReferencePool>(new ReferencePool(referencePoolNode));
             referencePool_->setID(referencePoolIDRef_);
             IDManager::instance().setID(referencePoolIDRef_,referencePool_);
          }
          else if(referencePoolNode->Attribute("href")) { referencePoolIDRef_ = referencePoolNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { referencePool_ = boost::shared_ptr<ReferencePool>(new ReferencePool(referencePoolNode));}
   }

   //nthToDefaultNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* nthToDefaultNode = xmlNode->FirstChildElement("nthToDefault");

   if(nthToDefaultNode){nthToDefaultIsNull_ = false;}
   else{nthToDefaultIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- nthToDefaultNode , address : " << nthToDefaultNode << std::endl;
   #endif
   if(nthToDefaultNode)
   {
      if(nthToDefaultNode->Attribute("href") || nthToDefaultNode->Attribute("id"))
      {
          if(nthToDefaultNode->Attribute("id"))
          {
             nthToDefaultIDRef_ = nthToDefaultNode->Attribute("id");
             nthToDefault_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(nthToDefaultNode));
             nthToDefault_->setID(nthToDefaultIDRef_);
             IDManager::instance().setID(nthToDefaultIDRef_,nthToDefault_);
          }
          else if(nthToDefaultNode->Attribute("href")) { nthToDefaultIDRef_ = nthToDefaultNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { nthToDefault_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(nthToDefaultNode));}
   }

   //mthToDefaultNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* mthToDefaultNode = xmlNode->FirstChildElement("mthToDefault");

   if(mthToDefaultNode){mthToDefaultIsNull_ = false;}
   else{mthToDefaultIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- mthToDefaultNode , address : " << mthToDefaultNode << std::endl;
   #endif
   if(mthToDefaultNode)
   {
      if(mthToDefaultNode->Attribute("href") || mthToDefaultNode->Attribute("id"))
      {
          if(mthToDefaultNode->Attribute("id"))
          {
             mthToDefaultIDRef_ = mthToDefaultNode->Attribute("id");
             mthToDefault_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(mthToDefaultNode));
             mthToDefault_->setID(mthToDefaultIDRef_);
             IDManager::instance().setID(mthToDefaultIDRef_,mthToDefault_);
          }
          else if(mthToDefaultNode->Attribute("href")) { mthToDefaultIDRef_ = mthToDefaultNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { mthToDefault_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(mthToDefaultNode));}
   }

   //trancheNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* trancheNode = xmlNode->FirstChildElement("tranche");

   if(trancheNode){trancheIsNull_ = false;}
   else{trancheIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- trancheNode , address : " << trancheNode << std::endl;
   #endif
   if(trancheNode)
   {
      if(trancheNode->Attribute("href") || trancheNode->Attribute("id"))
      {
          if(trancheNode->Attribute("id"))
          {
             trancheIDRef_ = trancheNode->Attribute("id");
             tranche_ = boost::shared_ptr<Tranche>(new Tranche(trancheNode));
             tranche_->setID(trancheIDRef_);
             IDManager::instance().setID(trancheIDRef_,tranche_);
          }
          else if(trancheNode->Attribute("href")) { trancheIDRef_ = trancheNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { tranche_ = boost::shared_ptr<Tranche>(new Tranche(trancheNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<BasketName> BasketReferenceInformation::getBasketName()
{
   if(!this->basketNameIsNull_){
        if(basketNameIDRef_ != ""){
             return boost::shared_static_cast<BasketName>(IDManager::instance().getID(basketNameIDRef_));
        }else{
             return this->basketName_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BasketName>();
   }
}
std::vector<boost::shared_ptr<BasketId>> BasketReferenceInformation::getBasketId()
{
   if(!this->basketIdIsNull_){
        if(basketIdIDRef_ != ""){
             return this->basketId_;
        }else{
             return this->basketId_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<BasketId>>();
   }
}
boost::shared_ptr<ReferencePool> BasketReferenceInformation::getReferencePool()
{
   if(!this->referencePoolIsNull_){
        if(referencePoolIDRef_ != ""){
             return boost::shared_static_cast<ReferencePool>(IDManager::instance().getID(referencePoolIDRef_));
        }else{
             return this->referencePool_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ReferencePool>();
   }
}
boost::shared_ptr<XsdTypePositiveInteger> BasketReferenceInformation::getNthToDefault()
{
   if(!this->nthToDefaultIsNull_){
        if(nthToDefaultIDRef_ != ""){
             return boost::shared_static_cast<XsdTypePositiveInteger>(IDManager::instance().getID(nthToDefaultIDRef_));
        }else{
             return this->nthToDefault_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypePositiveInteger>();
   }
}
boost::shared_ptr<XsdTypePositiveInteger> BasketReferenceInformation::getMthToDefault()
{
   if(!this->mthToDefaultIsNull_){
        if(mthToDefaultIDRef_ != ""){
             return boost::shared_static_cast<XsdTypePositiveInteger>(IDManager::instance().getID(mthToDefaultIDRef_));
        }else{
             return this->mthToDefault_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypePositiveInteger>();
   }
}
boost::shared_ptr<Tranche> BasketReferenceInformation::getTranche()
{
   if(!this->trancheIsNull_){
        if(trancheIDRef_ != ""){
             return boost::shared_static_cast<Tranche>(IDManager::instance().getID(trancheIDRef_));
        }else{
             return this->tranche_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Tranche>();
   }
}
}

