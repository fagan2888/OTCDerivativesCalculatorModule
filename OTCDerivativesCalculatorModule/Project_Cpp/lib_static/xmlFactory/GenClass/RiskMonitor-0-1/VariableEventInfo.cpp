// VariableEventInfo.cpp 
#include "VariableEventInfo.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

VariableEventInfo::VariableEventInfo(TiXmlNode* xmlNode)
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

   //nullVariableEventInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* nullVariableEventInfoNode = xmlNode->FirstChildElement("nullVariableEventInfo");

   if(nullVariableEventInfoNode){nullVariableEventInfoIsNull_ = false;}
   else{nullVariableEventInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- nullVariableEventInfoNode , address : " << nullVariableEventInfoNode << std::endl;
   #endif
   if(nullVariableEventInfoNode)
   {
       nullVariableEventInfo_ = boost::shared_ptr<NullVariableEventInfo>(new NullVariableEventInfo(nullVariableEventInfoNode));
   }

   //overWriteVariableEventInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* overWriteVariableEventInfoNode = xmlNode->FirstChildElement("overWriteVariableEventInfo");

   if(overWriteVariableEventInfoNode){overWriteVariableEventInfoIsNull_ = false;}
   else{overWriteVariableEventInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- overWriteVariableEventInfoNode , address : " << overWriteVariableEventInfoNode << std::endl;
   #endif
   if(overWriteVariableEventInfoNode)
   {
       overWriteVariableEventInfo_ = boost::shared_ptr<OverWriteVariableEventInfo>(new OverWriteVariableEventInfo(overWriteVariableEventInfoNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> VariableEventInfo::getType()
{
   if(!this->typeIsNull_){
        return this->type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<NullVariableEventInfo> VariableEventInfo::getNullVariableEventInfo()
{
   if(!this->nullVariableEventInfoIsNull_){
        return this->nullVariableEventInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NullVariableEventInfo>();
   }
}
boost::shared_ptr<OverWriteVariableEventInfo> VariableEventInfo::getOverWriteVariableEventInfo()
{
   if(!this->overWriteVariableEventInfoIsNull_){
        return this->overWriteVariableEventInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<OverWriteVariableEventInfo>();
   }
}
}

