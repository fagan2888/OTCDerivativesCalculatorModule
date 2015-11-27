// RefVariableFixingDateInfo.cpp 
#include "RefVariableFixingDateInfo.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

RefVariableFixingDateInfo::RefVariableFixingDateInfo(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //refDateNameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* refDateNameNode = xmlNode->FirstChildElement("refDateName");

   if(refDateNameNode){refDateNameIsNull_ = false;}
   else{refDateNameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- refDateNameNode , address : " << refDateNameNode << std::endl;
   #endif
   if(refDateNameNode)
   {
       refDateName_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(refDateNameNode));
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
boost::shared_ptr<XsdTypeToken> RefVariableFixingDateInfo::getRefDateName()
{
   if(!this->refDateNameIsNull_){
        return this->refDateName_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeBoolean> RefVariableFixingDateInfo::getAutoCallFlag()
{
   if(!this->autoCallFlagIsNull_){
        return this->autoCallFlag_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeDate> RefVariableFixingDateInfo::getAutoCallFixingDate()
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

