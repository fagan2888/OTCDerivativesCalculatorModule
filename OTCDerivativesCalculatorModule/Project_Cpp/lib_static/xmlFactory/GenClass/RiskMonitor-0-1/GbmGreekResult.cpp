// GbmGreekResult.cpp 
#include "GbmGreekResult.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

GbmGreekResult::GbmGreekResult(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //underlyingNameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* underlyingNameNode = xmlNode->FirstChildElement("underlyingName");

   if(underlyingNameNode){underlyingNameIsNull_ = false;}
   else{underlyingNameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- underlyingNameNode , address : " << underlyingNameNode << std::endl;
   #endif
   if(underlyingNameNode)
   {
       underlyingName_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(underlyingNameNode));
   }

   //deltaNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* deltaNode = xmlNode->FirstChildElement("delta");

   if(deltaNode){deltaIsNull_ = false;}
   else{deltaIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- deltaNode , address : " << deltaNode << std::endl;
   #endif
   if(deltaNode)
   {
       delta_ = boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(deltaNode));
   }

   //gammaNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* gammaNode = xmlNode->FirstChildElement("gamma");

   if(gammaNode){gammaIsNull_ = false;}
   else{gammaIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- gammaNode , address : " << gammaNode << std::endl;
   #endif
   if(gammaNode)
   {
       gamma_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(gammaNode));
   }

   //vegaNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* vegaNode = xmlNode->FirstChildElement("vega");

   if(vegaNode){vegaIsNull_ = false;}
   else{vegaIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- vegaNode , address : " << vegaNode << std::endl;
   #endif
   if(vegaNode)
   {
       vega_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(vegaNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> GbmGreekResult::getUnderlyingName()
{
   if(!this->underlyingNameIsNull_){
        return this->underlyingName_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeDouble> GbmGreekResult::getDelta()
{
   if(!this->deltaIsNull_){
        return this->delta_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDouble>();
   }
}
boost::shared_ptr<XsdTypeToken> GbmGreekResult::getGamma()
{
   if(!this->gammaIsNull_){
        return this->gamma_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> GbmGreekResult::getVega()
{
   if(!this->vegaIsNull_){
        return this->vega_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

