// LegIdentifier.cpp 
#include "LegIdentifier.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

LegIdentifier::LegIdentifier(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //legIdNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* legIdNode = xmlNode->FirstChildElement("legId");

   if(legIdNode){legIdIsNull_ = false;}
   else{legIdIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- legIdNode , address : " << legIdNode << std::endl;
   #endif
   if(legIdNode)
   {
      if(legIdNode->Attribute("href") || legIdNode->Attribute("id"))
      {
          if(legIdNode->Attribute("id"))
          {
             legIdIDRef_ = legIdNode->Attribute("id");
             legId_ = boost::shared_ptr<LegId>(new LegId(legIdNode));
             legId_->setID(legIdIDRef_);
             IDManager::instance().setID(legIdIDRef_,legId_);
          }
          else if(legIdNode->Attribute("href")) { legIdIDRef_ = legIdNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { legId_ = boost::shared_ptr<LegId>(new LegId(legIdNode));}
   }

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

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<LegId> LegIdentifier::getLegId()
{
   if(!this->legIdIsNull_){
        if(legIdIDRef_ != ""){
             return boost::shared_static_cast<LegId>(IDManager::instance().getID(legIdIDRef_));
        }else{
             return this->legId_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<LegId>();
   }
}
boost::shared_ptr<XsdTypeNonNegativeInteger> LegIdentifier::getVersion()
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
boost::shared_ptr<IdentifiedDate> LegIdentifier::getEffectiveDate()
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
}

