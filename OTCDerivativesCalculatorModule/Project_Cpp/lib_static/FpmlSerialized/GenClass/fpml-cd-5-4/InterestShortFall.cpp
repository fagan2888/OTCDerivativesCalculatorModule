// InterestShortFall.cpp 
#include "InterestShortFall.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

InterestShortFall::InterestShortFall(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //interestShortfallCapNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* interestShortfallCapNode = xmlNode->FirstChildElement("interestShortfallCap");

   if(interestShortfallCapNode){interestShortfallCapIsNull_ = false;}
   else{interestShortfallCapIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- interestShortfallCapNode , address : " << interestShortfallCapNode << std::endl;
   #endif
   if(interestShortfallCapNode)
   {
      if(interestShortfallCapNode->Attribute("href") || interestShortfallCapNode->Attribute("id"))
      {
          if(interestShortfallCapNode->Attribute("id"))
          {
             interestShortfallCapIDRef_ = interestShortfallCapNode->Attribute("id");
             interestShortfallCap_ = boost::shared_ptr<InterestShortfallCapEnum>(new InterestShortfallCapEnum(interestShortfallCapNode));
             interestShortfallCap_->setID(interestShortfallCapIDRef_);
             IDManager::instance().setID(interestShortfallCapIDRef_,interestShortfallCap_);
          }
          else if(interestShortfallCapNode->Attribute("href")) { interestShortfallCapIDRef_ = interestShortfallCapNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { interestShortfallCap_ = boost::shared_ptr<InterestShortfallCapEnum>(new InterestShortfallCapEnum(interestShortfallCapNode));}
   }

   //compoundingNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* compoundingNode = xmlNode->FirstChildElement("compounding");

   if(compoundingNode){compoundingIsNull_ = false;}
   else{compoundingIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- compoundingNode , address : " << compoundingNode << std::endl;
   #endif
   if(compoundingNode)
   {
      if(compoundingNode->Attribute("href") || compoundingNode->Attribute("id"))
      {
          if(compoundingNode->Attribute("id"))
          {
             compoundingIDRef_ = compoundingNode->Attribute("id");
             compounding_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(compoundingNode));
             compounding_->setID(compoundingIDRef_);
             IDManager::instance().setID(compoundingIDRef_,compounding_);
          }
          else if(compoundingNode->Attribute("href")) { compoundingIDRef_ = compoundingNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { compounding_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(compoundingNode));}
   }

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
             rateSource_ = boost::shared_ptr<FloatingRateIndex>(new FloatingRateIndex(rateSourceNode));
             rateSource_->setID(rateSourceIDRef_);
             IDManager::instance().setID(rateSourceIDRef_,rateSource_);
          }
          else if(rateSourceNode->Attribute("href")) { rateSourceIDRef_ = rateSourceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { rateSource_ = boost::shared_ptr<FloatingRateIndex>(new FloatingRateIndex(rateSourceNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<InterestShortfallCapEnum> InterestShortFall::getInterestShortfallCap()
{
   if(!this->interestShortfallCapIsNull_){
        if(interestShortfallCapIDRef_ != ""){
             return boost::shared_static_cast<InterestShortfallCapEnum>(IDManager::instance().getID(interestShortfallCapIDRef_));
        }else{
             return this->interestShortfallCap_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<InterestShortfallCapEnum>();
   }
}
boost::shared_ptr<XsdTypeBoolean> InterestShortFall::getCompounding()
{
   if(!this->compoundingIsNull_){
        if(compoundingIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(compoundingIDRef_));
        }else{
             return this->compounding_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<FloatingRateIndex> InterestShortFall::getRateSource()
{
   if(!this->rateSourceIsNull_){
        if(rateSourceIDRef_ != ""){
             return boost::shared_static_cast<FloatingRateIndex>(IDManager::instance().getID(rateSourceIDRef_));
        }else{
             return this->rateSource_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FloatingRateIndex>();
   }
}
}

