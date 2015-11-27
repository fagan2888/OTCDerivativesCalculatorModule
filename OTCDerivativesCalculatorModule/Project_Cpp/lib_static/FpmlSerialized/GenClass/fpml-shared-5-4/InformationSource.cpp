// InformationSource.cpp 
#include "InformationSource.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

InformationSource::InformationSource(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //rateSourceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* rateSourceNode = xmlNode->FirstChildElement("rateSource");

   if(rateSourceNode){rateSourceIsNull_ = false;}
   else{rateSourceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- rateSourceNode , address : " << rateSourceNode << std::endl;
   #endif
   if(rateSourceNode)
   {
      if(rateSourceNode->Attribute("href") || rateSourceNode->Attribute("id"))
      {
          if(rateSourceNode->Attribute("id"))
          {
             rateSourceIDRef_ = rateSourceNode->Attribute("id");
             rateSource_ = boost::shared_ptr<InformationProvider>(new InformationProvider(rateSourceNode));
             rateSource_->setID(rateSourceIDRef_);
             IDManager::instance().setID(rateSourceIDRef_,rateSource_);
          }
          else if(rateSourceNode->Attribute("href")) { rateSourceIDRef_ = rateSourceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { rateSource_ = boost::shared_ptr<InformationProvider>(new InformationProvider(rateSourceNode));}
   }

   //rateSourcePageNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* rateSourcePageNode = xmlNode->FirstChildElement("rateSourcePage");

   if(rateSourcePageNode){rateSourcePageIsNull_ = false;}
   else{rateSourcePageIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- rateSourcePageNode , address : " << rateSourcePageNode << std::endl;
   #endif
   if(rateSourcePageNode)
   {
      if(rateSourcePageNode->Attribute("href") || rateSourcePageNode->Attribute("id"))
      {
          if(rateSourcePageNode->Attribute("id"))
          {
             rateSourcePageIDRef_ = rateSourcePageNode->Attribute("id");
             rateSourcePage_ = boost::shared_ptr<RateSourcePage>(new RateSourcePage(rateSourcePageNode));
             rateSourcePage_->setID(rateSourcePageIDRef_);
             IDManager::instance().setID(rateSourcePageIDRef_,rateSourcePage_);
          }
          else if(rateSourcePageNode->Attribute("href")) { rateSourcePageIDRef_ = rateSourcePageNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { rateSourcePage_ = boost::shared_ptr<RateSourcePage>(new RateSourcePage(rateSourcePageNode));}
   }

   //rateSourcePageHeadingNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* rateSourcePageHeadingNode = xmlNode->FirstChildElement("rateSourcePageHeading");

   if(rateSourcePageHeadingNode){rateSourcePageHeadingIsNull_ = false;}
   else{rateSourcePageHeadingIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- rateSourcePageHeadingNode , address : " << rateSourcePageHeadingNode << std::endl;
   #endif
   if(rateSourcePageHeadingNode)
   {
      if(rateSourcePageHeadingNode->Attribute("href") || rateSourcePageHeadingNode->Attribute("id"))
      {
          if(rateSourcePageHeadingNode->Attribute("id"))
          {
             rateSourcePageHeadingIDRef_ = rateSourcePageHeadingNode->Attribute("id");
             rateSourcePageHeading_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(rateSourcePageHeadingNode));
             rateSourcePageHeading_->setID(rateSourcePageHeadingIDRef_);
             IDManager::instance().setID(rateSourcePageHeadingIDRef_,rateSourcePageHeading_);
          }
          else if(rateSourcePageHeadingNode->Attribute("href")) { rateSourcePageHeadingIDRef_ = rateSourcePageHeadingNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { rateSourcePageHeading_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(rateSourcePageHeadingNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<InformationProvider> InformationSource::getRateSource()
{
   if(!this->rateSourceIsNull_){
        if(rateSourceIDRef_ != ""){
             return boost::shared_static_cast<InformationProvider>(IDManager::instance().getID(rateSourceIDRef_));
        }else{
             return this->rateSource_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<InformationProvider>();
   }
}
boost::shared_ptr<RateSourcePage> InformationSource::getRateSourcePage()
{
   if(!this->rateSourcePageIsNull_){
        if(rateSourcePageIDRef_ != ""){
             return boost::shared_static_cast<RateSourcePage>(IDManager::instance().getID(rateSourcePageIDRef_));
        }else{
             return this->rateSourcePage_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<RateSourcePage>();
   }
}
boost::shared_ptr<XsdTypeString> InformationSource::getRateSourcePageHeading()
{
   if(!this->rateSourcePageHeadingIsNull_){
        if(rateSourcePageHeadingIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeString>(IDManager::instance().getID(rateSourcePageHeadingIDRef_));
        }else{
             return this->rateSourcePageHeading_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeString>();
   }
}
}

