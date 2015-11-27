// DailyReturnReferenceCal.cpp 
#include "DailyReturnReferenceCal.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

DailyReturnReferenceCal::DailyReturnReferenceCal(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //krCodeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* krCodeNode = xmlNode->FirstChildElement("krCode");

   if(krCodeNode){krCodeIsNull_ = false;}
   else{krCodeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- krCodeNode , address : " << krCodeNode << std::endl;
   #endif
   if(krCodeNode)
   {
       krCode_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(krCodeNode));
   }

   //fixingDateInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fixingDateInfoNode = xmlNode->FirstChildElement("fixingDateInfo");

   if(fixingDateInfoNode){fixingDateInfoIsNull_ = false;}
   else{fixingDateInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fixingDateInfoNode , address : " << fixingDateInfoNode << std::endl;
   #endif
   if(fixingDateInfoNode)
   {
       fixingDateInfo_ = boost::shared_ptr<FixingDateInfo>(new FixingDateInfo(fixingDateInfoNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> DailyReturnReferenceCal::getKrCode()
{
   if(!this->krCodeIsNull_){
        return this->krCode_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<FixingDateInfo> DailyReturnReferenceCal::getFixingDateInfo()
{
   if(!this->fixingDateInfoIsNull_){
        return this->fixingDateInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FixingDateInfo>();
   }
}
}

