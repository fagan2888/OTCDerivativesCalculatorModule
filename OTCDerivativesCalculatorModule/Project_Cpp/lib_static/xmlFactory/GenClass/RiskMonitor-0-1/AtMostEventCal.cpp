// AtMostEventCal.cpp 
#include "AtMostEventCal.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

AtMostEventCal::AtMostEventCal(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //numNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* numNode = xmlNode->FirstChildElement("num");

   if(numNode){numIsNull_ = false;}
   else{numIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- numNode , address : " << numNode << std::endl;
   #endif
   if(numNode)
   {
       num_ = boost::shared_ptr<XsdTypeInteger>(new XsdTypeInteger(numNode));
   }

   //eventCalculationListNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* eventCalculationListNode = xmlNode->FirstChildElement("eventCalculationList");

   if(eventCalculationListNode){eventCalculationListIsNull_ = false;}
   else{eventCalculationListIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- eventCalculationListNode , address : " << eventCalculationListNode << std::endl;
   #endif
   if(eventCalculationListNode)
   {
       eventCalculationList_ = boost::shared_ptr<EventCalculationList>(new EventCalculationList(eventCalculationListNode));
   }

   //complementNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* complementNode = xmlNode->FirstChildElement("complement");

   if(complementNode){complementIsNull_ = false;}
   else{complementIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- complementNode , address : " << complementNode << std::endl;
   #endif
   if(complementNode)
   {
       complement_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(complementNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeInteger> AtMostEventCal::getNum()
{
   if(!this->numIsNull_){
        return this->num_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeInteger>();
   }
}
boost::shared_ptr<EventCalculationList> AtMostEventCal::getEventCalculationList()
{
   if(!this->eventCalculationListIsNull_){
        return this->eventCalculationList_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EventCalculationList>();
   }
}
boost::shared_ptr<XsdTypeBoolean> AtMostEventCal::getComplement()
{
   if(!this->complementIsNull_){
        return this->complement_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
}

