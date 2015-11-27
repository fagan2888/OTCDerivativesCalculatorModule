// SequencedDisruptionFallback.cpp 
#include "SequencedDisruptionFallback.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

SequencedDisruptionFallback::SequencedDisruptionFallback(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //fallbackNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fallbackNode = xmlNode->FirstChildElement("fallback");

   if(fallbackNode){fallbackIsNull_ = false;}
   else{fallbackIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fallbackNode , address : " << fallbackNode << std::endl;
   #endif
   if(fallbackNode)
   {
      if(fallbackNode->Attribute("href") || fallbackNode->Attribute("id"))
      {
          if(fallbackNode->Attribute("id"))
          {
             fallbackIDRef_ = fallbackNode->Attribute("id");
             fallback_ = boost::shared_ptr<DisruptionFallback>(new DisruptionFallback(fallbackNode));
             fallback_->setID(fallbackIDRef_);
             IDManager::instance().setID(fallbackIDRef_,fallback_);
          }
          else if(fallbackNode->Attribute("href")) { fallbackIDRef_ = fallbackNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fallback_ = boost::shared_ptr<DisruptionFallback>(new DisruptionFallback(fallbackNode));}
   }

   //sequenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* sequenceNode = xmlNode->FirstChildElement("sequence");

   if(sequenceNode){sequenceIsNull_ = false;}
   else{sequenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- sequenceNode , address : " << sequenceNode << std::endl;
   #endif
   if(sequenceNode)
   {
      if(sequenceNode->Attribute("href") || sequenceNode->Attribute("id"))
      {
          if(sequenceNode->Attribute("id"))
          {
             sequenceIDRef_ = sequenceNode->Attribute("id");
             sequence_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(sequenceNode));
             sequence_->setID(sequenceIDRef_);
             IDManager::instance().setID(sequenceIDRef_,sequence_);
          }
          else if(sequenceNode->Attribute("href")) { sequenceIDRef_ = sequenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { sequence_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(sequenceNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<DisruptionFallback> SequencedDisruptionFallback::getFallback()
{
   if(!this->fallbackIsNull_){
        if(fallbackIDRef_ != ""){
             return boost::shared_static_cast<DisruptionFallback>(IDManager::instance().getID(fallbackIDRef_));
        }else{
             return this->fallback_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DisruptionFallback>();
   }
}
boost::shared_ptr<XsdTypePositiveInteger> SequencedDisruptionFallback::getSequence()
{
   if(!this->sequenceIsNull_){
        if(sequenceIDRef_ != ""){
             return boost::shared_static_cast<XsdTypePositiveInteger>(IDManager::instance().getID(sequenceIDRef_));
        }else{
             return this->sequence_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypePositiveInteger>();
   }
}
}

