// GeneralTerminationEvent.cpp 
#include "GeneralTerminationEvent.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

GeneralTerminationEvent::GeneralTerminationEvent(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //detailTerminationTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* detailTerminationTypeNode = xmlNode->FirstChildElement("detailTerminationType");

   if(detailTerminationTypeNode){detailTerminationTypeIsNull_ = false;}
   else{detailTerminationTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- detailTerminationTypeNode , address : " << detailTerminationTypeNode << std::endl;
   #endif
   if(detailTerminationTypeNode)
   {
       detailTerminationType_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(detailTerminationTypeNode));
   }

   //eventDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* eventDateNode = xmlNode->FirstChildElement("eventDate");

   if(eventDateNode){eventDateIsNull_ = false;}
   else{eventDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- eventDateNode , address : " << eventDateNode << std::endl;
   #endif
   if(eventDateNode)
   {
       eventDate_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(eventDateNode));
   }

   //generalTerminationEventDetailNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* generalTerminationEventDetailNode = xmlNode->FirstChildElement("generalTerminationEventDetail");

   if(generalTerminationEventDetailNode){generalTerminationEventDetailIsNull_ = false;}
   else{generalTerminationEventDetailIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- generalTerminationEventDetailNode , address : " << generalTerminationEventDetailNode << std::endl;
   #endif
   if(generalTerminationEventDetailNode)
   {
       generalTerminationEventDetail_ = boost::shared_ptr<GeneralTerminationEventDetail>(new GeneralTerminationEventDetail(generalTerminationEventDetailNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> GeneralTerminationEvent::getDetailTerminationType()
{
   if(!this->detailTerminationTypeIsNull_){
        return this->detailTerminationType_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> GeneralTerminationEvent::getEventDate()
{
   if(!this->eventDateIsNull_){
        return this->eventDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<GeneralTerminationEventDetail> GeneralTerminationEvent::getGeneralTerminationEventDetail()
{
   if(!this->generalTerminationEventDetailIsNull_){
        return this->generalTerminationEventDetail_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<GeneralTerminationEventDetail>();
   }
}
}

