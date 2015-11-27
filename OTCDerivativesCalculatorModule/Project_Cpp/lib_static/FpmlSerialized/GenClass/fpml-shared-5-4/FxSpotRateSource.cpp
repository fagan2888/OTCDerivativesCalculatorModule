// FxSpotRateSource.cpp 
#include "FxSpotRateSource.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FxSpotRateSource::FxSpotRateSource(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //primaryRateSourceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* primaryRateSourceNode = xmlNode->FirstChildElement("primaryRateSource");

   if(primaryRateSourceNode){primaryRateSourceIsNull_ = false;}
   else{primaryRateSourceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- primaryRateSourceNode , address : " << primaryRateSourceNode << std::endl;
   #endif
   if(primaryRateSourceNode)
   {
      if(primaryRateSourceNode->Attribute("href") || primaryRateSourceNode->Attribute("id"))
      {
          if(primaryRateSourceNode->Attribute("id"))
          {
             primaryRateSourceIDRef_ = primaryRateSourceNode->Attribute("id");
             primaryRateSource_ = boost::shared_ptr<InformationSource>(new InformationSource(primaryRateSourceNode));
             primaryRateSource_->setID(primaryRateSourceIDRef_);
             IDManager::instance().setID(primaryRateSourceIDRef_,primaryRateSource_);
          }
          else if(primaryRateSourceNode->Attribute("href")) { primaryRateSourceIDRef_ = primaryRateSourceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { primaryRateSource_ = boost::shared_ptr<InformationSource>(new InformationSource(primaryRateSourceNode));}
   }

   //secondaryRateSourceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* secondaryRateSourceNode = xmlNode->FirstChildElement("secondaryRateSource");

   if(secondaryRateSourceNode){secondaryRateSourceIsNull_ = false;}
   else{secondaryRateSourceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- secondaryRateSourceNode , address : " << secondaryRateSourceNode << std::endl;
   #endif
   if(secondaryRateSourceNode)
   {
      if(secondaryRateSourceNode->Attribute("href") || secondaryRateSourceNode->Attribute("id"))
      {
          if(secondaryRateSourceNode->Attribute("id"))
          {
             secondaryRateSourceIDRef_ = secondaryRateSourceNode->Attribute("id");
             secondaryRateSource_ = boost::shared_ptr<InformationSource>(new InformationSource(secondaryRateSourceNode));
             secondaryRateSource_->setID(secondaryRateSourceIDRef_);
             IDManager::instance().setID(secondaryRateSourceIDRef_,secondaryRateSource_);
          }
          else if(secondaryRateSourceNode->Attribute("href")) { secondaryRateSourceIDRef_ = secondaryRateSourceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { secondaryRateSource_ = boost::shared_ptr<InformationSource>(new InformationSource(secondaryRateSourceNode));}
   }

   //fixingTimeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fixingTimeNode = xmlNode->FirstChildElement("fixingTime");

   if(fixingTimeNode){fixingTimeIsNull_ = false;}
   else{fixingTimeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fixingTimeNode , address : " << fixingTimeNode << std::endl;
   #endif
   if(fixingTimeNode)
   {
      if(fixingTimeNode->Attribute("href") || fixingTimeNode->Attribute("id"))
      {
          if(fixingTimeNode->Attribute("id"))
          {
             fixingTimeIDRef_ = fixingTimeNode->Attribute("id");
             fixingTime_ = boost::shared_ptr<BusinessCenterTime>(new BusinessCenterTime(fixingTimeNode));
             fixingTime_->setID(fixingTimeIDRef_);
             IDManager::instance().setID(fixingTimeIDRef_,fixingTime_);
          }
          else if(fixingTimeNode->Attribute("href")) { fixingTimeIDRef_ = fixingTimeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fixingTime_ = boost::shared_ptr<BusinessCenterTime>(new BusinessCenterTime(fixingTimeNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<InformationSource> FxSpotRateSource::getPrimaryRateSource()
{
   if(!this->primaryRateSourceIsNull_){
        if(primaryRateSourceIDRef_ != ""){
             return boost::shared_static_cast<InformationSource>(IDManager::instance().getID(primaryRateSourceIDRef_));
        }else{
             return this->primaryRateSource_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<InformationSource>();
   }
}
boost::shared_ptr<InformationSource> FxSpotRateSource::getSecondaryRateSource()
{
   if(!this->secondaryRateSourceIsNull_){
        if(secondaryRateSourceIDRef_ != ""){
             return boost::shared_static_cast<InformationSource>(IDManager::instance().getID(secondaryRateSourceIDRef_));
        }else{
             return this->secondaryRateSource_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<InformationSource>();
   }
}
boost::shared_ptr<BusinessCenterTime> FxSpotRateSource::getFixingTime()
{
   if(!this->fixingTimeIsNull_){
        if(fixingTimeIDRef_ != ""){
             return boost::shared_static_cast<BusinessCenterTime>(IDManager::instance().getID(fixingTimeIDRef_));
        }else{
             return this->fixingTime_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BusinessCenterTime>();
   }
}
}

