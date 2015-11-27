// Excel_greekUnderlying.cpp 
#include "Excel_greekUnderlying.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_greekUnderlying::Excel_greekUnderlying(TiXmlNode* xmlNode)
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

   //underlyingValueNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* underlyingValueNode = xmlNode->FirstChildElement("underlyingValue");

   if(underlyingValueNode){underlyingValueIsNull_ = false;}
   else{underlyingValueIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- underlyingValueNode , address : " << underlyingValueNode << std::endl;
   #endif
   if(underlyingValueNode)
   {
       underlyingValue_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(underlyingValueNode));
   }

   //basePriceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* basePriceNode = xmlNode->FirstChildElement("basePrice");

   if(basePriceNode){basePriceIsNull_ = false;}
   else{basePriceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- basePriceNode , address : " << basePriceNode << std::endl;
   #endif
   if(basePriceNode)
   {
       basePrice_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(basePriceNode));
   }

   //volatilityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* volatilityNode = xmlNode->FirstChildElement("volatility");

   if(volatilityNode){volatilityIsNull_ = false;}
   else{volatilityIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- volatilityNode , address : " << volatilityNode << std::endl;
   #endif
   if(volatilityNode)
   {
       volatility_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(volatilityNode));
   }

   //pertubation_hNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* pertubation_hNode = xmlNode->FirstChildElement("pertubation_h");

   if(pertubation_hNode){pertubation_hIsNull_ = false;}
   else{pertubation_hIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- pertubation_hNode , address : " << pertubation_hNode << std::endl;
   #endif
   if(pertubation_hNode)
   {
       pertubation_h_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(pertubation_hNode));
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
       delta_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(deltaNode));
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
boost::shared_ptr<XsdTypeToken> Excel_greekUnderlying::getUnderlyingName()
{
   if(!this->underlyingNameIsNull_){
        return this->underlyingName_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_greekUnderlying::getUnderlyingValue()
{
   if(!this->underlyingValueIsNull_){
        return this->underlyingValue_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_greekUnderlying::getBasePrice()
{
   if(!this->basePriceIsNull_){
        return this->basePrice_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_greekUnderlying::getVolatility()
{
   if(!this->volatilityIsNull_){
        return this->volatility_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_greekUnderlying::getPertubation_h()
{
   if(!this->pertubation_hIsNull_){
        return this->pertubation_h_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_greekUnderlying::getDelta()
{
   if(!this->deltaIsNull_){
        return this->delta_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_greekUnderlying::getGamma()
{
   if(!this->gammaIsNull_){
        return this->gamma_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_greekUnderlying::getVega()
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

