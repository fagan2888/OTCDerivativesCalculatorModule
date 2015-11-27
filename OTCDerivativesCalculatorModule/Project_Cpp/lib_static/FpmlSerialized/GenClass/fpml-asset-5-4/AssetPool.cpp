// AssetPool.cpp 
#include "AssetPool.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

AssetPool::AssetPool(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //versionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* versionNode = xmlNode->FirstChildElement("version");

   if(versionNode){versionIsNull_ = false;}
   else{versionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- versionNode , address : " << versionNode << std::endl;
   #endif
   if(versionNode)
   {
      if(versionNode->Attribute("href") || versionNode->Attribute("id"))
      {
          if(versionNode->Attribute("id"))
          {
             versionIDRef_ = versionNode->Attribute("id");
             version_ = boost::shared_ptr<XsdTypeNonNegativeInteger>(new XsdTypeNonNegativeInteger(versionNode));
             version_->setID(versionIDRef_);
             IDManager::instance().setID(versionIDRef_,version_);
          }
          else if(versionNode->Attribute("href")) { versionIDRef_ = versionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { version_ = boost::shared_ptr<XsdTypeNonNegativeInteger>(new XsdTypeNonNegativeInteger(versionNode));}
   }

   //effectiveDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* effectiveDateNode = xmlNode->FirstChildElement("effectiveDate");

   if(effectiveDateNode){effectiveDateIsNull_ = false;}
   else{effectiveDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- effectiveDateNode , address : " << effectiveDateNode << std::endl;
   #endif
   if(effectiveDateNode)
   {
      if(effectiveDateNode->Attribute("href") || effectiveDateNode->Attribute("id"))
      {
          if(effectiveDateNode->Attribute("id"))
          {
             effectiveDateIDRef_ = effectiveDateNode->Attribute("id");
             effectiveDate_ = boost::shared_ptr<IdentifiedDate>(new IdentifiedDate(effectiveDateNode));
             effectiveDate_->setID(effectiveDateIDRef_);
             IDManager::instance().setID(effectiveDateIDRef_,effectiveDate_);
          }
          else if(effectiveDateNode->Attribute("href")) { effectiveDateIDRef_ = effectiveDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { effectiveDate_ = boost::shared_ptr<IdentifiedDate>(new IdentifiedDate(effectiveDateNode));}
   }

   //initialFactorNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* initialFactorNode = xmlNode->FirstChildElement("initialFactor");

   if(initialFactorNode){initialFactorIsNull_ = false;}
   else{initialFactorIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- initialFactorNode , address : " << initialFactorNode << std::endl;
   #endif
   if(initialFactorNode)
   {
      if(initialFactorNode->Attribute("href") || initialFactorNode->Attribute("id"))
      {
          if(initialFactorNode->Attribute("id"))
          {
             initialFactorIDRef_ = initialFactorNode->Attribute("id");
             initialFactor_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(initialFactorNode));
             initialFactor_->setID(initialFactorIDRef_);
             IDManager::instance().setID(initialFactorIDRef_,initialFactor_);
          }
          else if(initialFactorNode->Attribute("href")) { initialFactorIDRef_ = initialFactorNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { initialFactor_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(initialFactorNode));}
   }

   //currentFactorNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* currentFactorNode = xmlNode->FirstChildElement("currentFactor");

   if(currentFactorNode){currentFactorIsNull_ = false;}
   else{currentFactorIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- currentFactorNode , address : " << currentFactorNode << std::endl;
   #endif
   if(currentFactorNode)
   {
      if(currentFactorNode->Attribute("href") || currentFactorNode->Attribute("id"))
      {
          if(currentFactorNode->Attribute("id"))
          {
             currentFactorIDRef_ = currentFactorNode->Attribute("id");
             currentFactor_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(currentFactorNode));
             currentFactor_->setID(currentFactorIDRef_);
             IDManager::instance().setID(currentFactorIDRef_,currentFactor_);
          }
          else if(currentFactorNode->Attribute("href")) { currentFactorIDRef_ = currentFactorNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { currentFactor_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(currentFactorNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeNonNegativeInteger> AssetPool::getVersion()
{
   if(!this->versionIsNull_){
        if(versionIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeNonNegativeInteger>(IDManager::instance().getID(versionIDRef_));
        }else{
             return this->version_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeNonNegativeInteger>();
   }
}
boost::shared_ptr<IdentifiedDate> AssetPool::getEffectiveDate()
{
   if(!this->effectiveDateIsNull_){
        if(effectiveDateIDRef_ != ""){
             return boost::shared_static_cast<IdentifiedDate>(IDManager::instance().getID(effectiveDateIDRef_));
        }else{
             return this->effectiveDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<IdentifiedDate>();
   }
}
boost::shared_ptr<XsdTypeDecimal> AssetPool::getInitialFactor()
{
   if(!this->initialFactorIsNull_){
        if(initialFactorIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(initialFactorIDRef_));
        }else{
             return this->initialFactor_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<XsdTypeDecimal> AssetPool::getCurrentFactor()
{
   if(!this->currentFactorIsNull_){
        if(currentFactorIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(currentFactorIDRef_));
        }else{
             return this->currentFactor_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
}

