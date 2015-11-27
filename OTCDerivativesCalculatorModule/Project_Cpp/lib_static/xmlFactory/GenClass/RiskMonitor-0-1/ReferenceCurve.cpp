// ReferenceCurve.cpp 
#include "ReferenceCurve.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ReferenceCurve::ReferenceCurve(TiXmlNode* xmlNode)
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

   //cdsSpreadTermstructureNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* cdsSpreadTermstructureNode = xmlNode->FirstChildElement("cdsSpreadTermstructure");

   if(cdsSpreadTermstructureNode){cdsSpreadTermstructureIsNull_ = false;}
   else{cdsSpreadTermstructureIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- cdsSpreadTermstructureNode , address : " << cdsSpreadTermstructureNode << std::endl;
   #endif
   if(cdsSpreadTermstructureNode)
   {
       cdsSpreadTermstructure_ = boost::shared_ptr<CdsSpreadTermstructure>(new CdsSpreadTermstructure(cdsSpreadTermstructureNode));
   }

   //yieldTermstructureNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* yieldTermstructureNode = xmlNode->FirstChildElement("yieldTermstructure");

   if(yieldTermstructureNode){yieldTermstructureIsNull_ = false;}
   else{yieldTermstructureIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- yieldTermstructureNode , address : " << yieldTermstructureNode << std::endl;
   #endif
   if(yieldTermstructureNode)
   {
       yieldTermstructure_ = boost::shared_ptr<YieldTermstructure>(new YieldTermstructure(yieldTermstructureNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> ReferenceCurve::getType()
{
   if(!this->typeIsNull_){
        return this->type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<CdsSpreadTermstructure> ReferenceCurve::getCdsSpreadTermstructure()
{
   if(!this->cdsSpreadTermstructureIsNull_){
        return this->cdsSpreadTermstructure_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CdsSpreadTermstructure>();
   }
}
boost::shared_ptr<YieldTermstructure> ReferenceCurve::getYieldTermstructure()
{
   if(!this->yieldTermstructureIsNull_){
        return this->yieldTermstructure_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<YieldTermstructure>();
   }
}
}

