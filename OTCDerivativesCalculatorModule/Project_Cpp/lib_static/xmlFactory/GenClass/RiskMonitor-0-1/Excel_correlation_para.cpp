// Excel_correlation_para.cpp 
#include "Excel_correlation_para.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_correlation_para::Excel_correlation_para(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //firstNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* firstNode = xmlNode->FirstChildElement("first");

   if(firstNode){firstIsNull_ = false;}
   else{firstIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- firstNode , address : " << firstNode << std::endl;
   #endif
   if(firstNode)
   {
       first_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(firstNode));
   }

   //secondNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* secondNode = xmlNode->FirstChildElement("second");

   if(secondNode){secondIsNull_ = false;}
   else{secondIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- secondNode , address : " << secondNode << std::endl;
   #endif
   if(secondNode)
   {
       second_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(secondNode));
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
       value_ = boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(valueNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_correlation_para::getFirst()
{
   if(!this->firstIsNull_){
        return this->first_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_correlation_para::getSecond()
{
   if(!this->secondIsNull_){
        return this->second_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeDouble> Excel_correlation_para::getValue()
{
   if(!this->valueIsNull_){
        return this->value_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDouble>();
   }
}
}

