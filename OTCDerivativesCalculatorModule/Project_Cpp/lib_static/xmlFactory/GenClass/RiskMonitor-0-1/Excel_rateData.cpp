// Excel_rateData.cpp 
#include "Excel_rateData.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_rateData::Excel_rateData(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //tenorNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* tenorNode = xmlNode->FirstChildElement("tenor");

   if(tenorNode){tenorIsNull_ = false;}
   else{tenorIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- tenorNode , address : " << tenorNode << std::endl;
   #endif
   if(tenorNode)
   {
       tenor_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(tenorNode));
   }

   //rateTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* rateTypeNode = xmlNode->FirstChildElement("rateType");

   if(rateTypeNode){rateTypeIsNull_ = false;}
   else{rateTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- rateTypeNode , address : " << rateTypeNode << std::endl;
   #endif
   if(rateTypeNode)
   {
       rateType_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(rateTypeNode));
   }

   //valueNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* valueNode = xmlNode->FirstChildElement("value");

   if(valueNode){valueIsNull_ = false;}
   else{valueIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- valueNode , address : " << valueNode << std::endl;
   #endif
   if(valueNode)
   {
       value_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(valueNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_rateData::getTenor()
{
   if(!this->tenorIsNull_){
        return this->tenor_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_rateData::getRateType()
{
   if(!this->rateTypeIsNull_){
        return this->rateType_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_rateData::getValue()
{
   if(!this->valueIsNull_){
        return this->value_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

