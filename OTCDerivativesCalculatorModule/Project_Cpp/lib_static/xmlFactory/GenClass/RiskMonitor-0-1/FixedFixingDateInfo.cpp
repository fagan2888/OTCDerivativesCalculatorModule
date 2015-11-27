// FixedFixingDateInfo.cpp 
#include "FixedFixingDateInfo.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FixedFixingDateInfo::FixedFixingDateInfo(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //dateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dateNode = xmlNode->FirstChildElement("date");

   if(dateNode){dateIsNull_ = false;}
   else{dateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dateNode , address : " << dateNode << std::endl;
   #endif
   if(dateNode)
   {
       date_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(dateNode));
   }

   //autoCallFlagNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* autoCallFlagNode = xmlNode->FirstChildElement("autoCallFlag");

   if(autoCallFlagNode){autoCallFlagIsNull_ = false;}
   else{autoCallFlagIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- autoCallFlagNode , address : " << autoCallFlagNode << std::endl;
   #endif
   if(autoCallFlagNode)
   {
       autoCallFlag_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(autoCallFlagNode));
   }

   //autoCallFixingDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* autoCallFixingDateNode = xmlNode->FirstChildElement("autoCallFixingDate");

   if(autoCallFixingDateNode){autoCallFixingDateIsNull_ = false;}
   else{autoCallFixingDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- autoCallFixingDateNode , address : " << autoCallFixingDateNode << std::endl;
   #endif
   if(autoCallFixingDateNode)
   {
       autoCallFixingDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(autoCallFixingDateNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> FixedFixingDateInfo::getDate()
{
   if(!this->dateIsNull_){
        return this->date_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeBoolean> FixedFixingDateInfo::getAutoCallFlag()
{
   if(!this->autoCallFlagIsNull_){
        return this->autoCallFlag_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeDate> FixedFixingDateInfo::getAutoCallFixingDate()
{
   if(!this->autoCallFixingDateIsNull_){
        return this->autoCallFixingDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
}

