// ResetVariableInfo.cpp 
#include "ResetVariableInfo.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ResetVariableInfo::ResetVariableInfo(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //refInstanceNameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* refInstanceNameNode = xmlNode->FirstChildElement("refInstanceName");

   if(refInstanceNameNode){refInstanceNameIsNull_ = false;}
   else{refInstanceNameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- refInstanceNameNode , address : " << refInstanceNameNode << std::endl;
   #endif
   if(refInstanceNameNode)
   {
       refInstanceName_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(refInstanceNameNode));
   }

   //fixingInformationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fixingInformationNode = xmlNode->FirstChildElement("fixingInformation");

   if(fixingInformationNode){fixingInformationIsNull_ = false;}
   else{fixingInformationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fixingInformationNode , address : " << fixingInformationNode << std::endl;
   #endif
   if(fixingInformationNode)
   {
       fixingInformation_ = boost::shared_ptr<FixingInformation>(new FixingInformation(fixingInformationNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> ResetVariableInfo::getRefInstanceName()
{
   if(!this->refInstanceNameIsNull_){
        return this->refInstanceName_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<FixingInformation> ResetVariableInfo::getFixingInformation()
{
   if(!this->fixingInformationIsNull_){
        return this->fixingInformation_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FixingInformation>();
   }
}
}

