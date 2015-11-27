// PubliclyAvailableInformation.cpp 
#include "PubliclyAvailableInformation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

PubliclyAvailableInformation::PubliclyAvailableInformation(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //standardPublicSourcesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* standardPublicSourcesNode = xmlNode->FirstChildElement("standardPublicSources");

   if(standardPublicSourcesNode){standardPublicSourcesIsNull_ = false;}
   else{standardPublicSourcesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- standardPublicSourcesNode , address : " << standardPublicSourcesNode << std::endl;
   #endif
   if(standardPublicSourcesNode)
   {
      if(standardPublicSourcesNode->Attribute("href") || standardPublicSourcesNode->Attribute("id"))
      {
          if(standardPublicSourcesNode->Attribute("id"))
          {
             standardPublicSourcesIDRef_ = standardPublicSourcesNode->Attribute("id");
             standardPublicSources_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(standardPublicSourcesNode));
             standardPublicSources_->setID(standardPublicSourcesIDRef_);
             IDManager::instance().setID(standardPublicSourcesIDRef_,standardPublicSources_);
          }
          else if(standardPublicSourcesNode->Attribute("href")) { standardPublicSourcesIDRef_ = standardPublicSourcesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { standardPublicSources_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(standardPublicSourcesNode));}
   }

   //publicSourceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* publicSourceNode = xmlNode->FirstChildElement("publicSource");

   if(publicSourceNode){publicSourceIsNull_ = false;}
   else{publicSourceIsNull_ = true;}

   if(publicSourceNode)
   {
      for(publicSourceNode; publicSourceNode; publicSourceNode = publicSourceNode->NextSiblingElement("publicSource")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- publicSourceNode , address : " << publicSourceNode << std::endl;
          #endif
          if(publicSourceNode->Attribute("href") || publicSourceNode->Attribute("id"))
          {
              if(publicSourceNode->Attribute("id"))
              {
                  publicSourceIDRef_ = publicSourceNode->Attribute("id");
                  publicSource_.push_back(boost::shared_ptr<XsdTypeString>(new XsdTypeString(publicSourceNode)));
                  publicSource_.back()->setID(publicSourceIDRef_);
                  IDManager::instance().setID(publicSourceIDRef_, publicSource_.back());
              }
              else if(publicSourceNode->Attribute("href")) { publicSourceIDRef_ = publicSourceNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { publicSource_.push_back(boost::shared_ptr<XsdTypeString>(new XsdTypeString(publicSourceNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- publicSourceNode , address : " << publicSourceNode << std::endl;
       #endif
   }

   //specifiedNumberNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* specifiedNumberNode = xmlNode->FirstChildElement("specifiedNumber");

   if(specifiedNumberNode){specifiedNumberIsNull_ = false;}
   else{specifiedNumberIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- specifiedNumberNode , address : " << specifiedNumberNode << std::endl;
   #endif
   if(specifiedNumberNode)
   {
      if(specifiedNumberNode->Attribute("href") || specifiedNumberNode->Attribute("id"))
      {
          if(specifiedNumberNode->Attribute("id"))
          {
             specifiedNumberIDRef_ = specifiedNumberNode->Attribute("id");
             specifiedNumber_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(specifiedNumberNode));
             specifiedNumber_->setID(specifiedNumberIDRef_);
             IDManager::instance().setID(specifiedNumberIDRef_,specifiedNumber_);
          }
          else if(specifiedNumberNode->Attribute("href")) { specifiedNumberIDRef_ = specifiedNumberNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { specifiedNumber_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(specifiedNumberNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeBoolean> PubliclyAvailableInformation::getStandardPublicSources()
{
   if(!this->standardPublicSourcesIsNull_){
        if(standardPublicSourcesIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(standardPublicSourcesIDRef_));
        }else{
             return this->standardPublicSources_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
std::vector<boost::shared_ptr<XsdTypeString>> PubliclyAvailableInformation::getPublicSource()
{
   if(!this->publicSourceIsNull_){
        if(publicSourceIDRef_ != ""){
             return this->publicSource_;
        }else{
             return this->publicSource_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<XsdTypeString>>();
   }
}
boost::shared_ptr<XsdTypePositiveInteger> PubliclyAvailableInformation::getSpecifiedNumber()
{
   if(!this->specifiedNumberIsNull_){
        if(specifiedNumberIDRef_ != ""){
             return boost::shared_static_cast<XsdTypePositiveInteger>(IDManager::instance().getID(specifiedNumberIDRef_));
        }else{
             return this->specifiedNumber_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypePositiveInteger>();
   }
}
}

