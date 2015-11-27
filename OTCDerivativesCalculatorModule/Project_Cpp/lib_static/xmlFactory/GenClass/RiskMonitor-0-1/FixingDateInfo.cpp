// FixingDateInfo.cpp 
#include "FixingDateInfo.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FixingDateInfo::FixingDateInfo(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //typeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* typeNode = xmlNode->FirstChildElement("type");

   if(typeNode){typeIsNull_ = false;}
   else{typeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- typeNode , address : " << typeNode << std::endl;
   #endif
   if(typeNode)
   {
       type_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(typeNode));
   }

   //fixedFixingDateInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fixedFixingDateInfoNode = xmlNode->FirstChildElement("fixedFixingDateInfo");

   if(fixedFixingDateInfoNode){fixedFixingDateInfoIsNull_ = false;}
   else{fixedFixingDateInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fixedFixingDateInfoNode , address : " << fixedFixingDateInfoNode << std::endl;
   #endif
   if(fixedFixingDateInfoNode)
   {
       fixedFixingDateInfo_ = boost::shared_ptr<FixedFixingDateInfo>(new FixedFixingDateInfo(fixedFixingDateInfoNode));
   }

   //refVariableFixingDateInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* refVariableFixingDateInfoNode = xmlNode->FirstChildElement("refVariableFixingDateInfo");

   if(refVariableFixingDateInfoNode){refVariableFixingDateInfoIsNull_ = false;}
   else{refVariableFixingDateInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- refVariableFixingDateInfoNode , address : " << refVariableFixingDateInfoNode << std::endl;
   #endif
   if(refVariableFixingDateInfoNode)
   {
       refVariableFixingDateInfo_ = boost::shared_ptr<RefVariableFixingDateInfo>(new RefVariableFixingDateInfo(refVariableFixingDateInfoNode));
   }

   //nullFixingDateInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* nullFixingDateInfoNode = xmlNode->FirstChildElement("nullFixingDateInfo");

   if(nullFixingDateInfoNode){nullFixingDateInfoIsNull_ = false;}
   else{nullFixingDateInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- nullFixingDateInfoNode , address : " << nullFixingDateInfoNode << std::endl;
   #endif
   if(nullFixingDateInfoNode)
   {
       nullFixingDateInfo_ = boost::shared_ptr<NullFixingDateInfo>(new NullFixingDateInfo(nullFixingDateInfoNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> FixingDateInfo::getType()
{
   if(!this->typeIsNull_){
        return this->type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<FixedFixingDateInfo> FixingDateInfo::getFixedFixingDateInfo()
{
   if(!this->fixedFixingDateInfoIsNull_){
        return this->fixedFixingDateInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FixedFixingDateInfo>();
   }
}
boost::shared_ptr<RefVariableFixingDateInfo> FixingDateInfo::getRefVariableFixingDateInfo()
{
   if(!this->refVariableFixingDateInfoIsNull_){
        return this->refVariableFixingDateInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<RefVariableFixingDateInfo>();
   }
}
boost::shared_ptr<NullFixingDateInfo> FixingDateInfo::getNullFixingDateInfo()
{
   if(!this->nullFixingDateInfoIsNull_){
        return this->nullFixingDateInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NullFixingDateInfo>();
   }
}
}

