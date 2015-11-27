// CorrelationInfo_para.cpp 
#include "CorrelationInfo_para.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CorrelationInfo_para::CorrelationInfo_para(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //dimensionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dimensionNode = xmlNode->FirstChildElement("dimension");

   if(dimensionNode){dimensionIsNull_ = false;}
   else{dimensionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dimensionNode , address : " << dimensionNode << std::endl;
   #endif
   if(dimensionNode)
   {
       dimension_ = boost::shared_ptr<XsdTypeInteger>(new XsdTypeInteger(dimensionNode));
   }

   //correlation_paraNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* correlation_paraNode = xmlNode->FirstChildElement("correlation_para");

   if(correlation_paraNode){correlation_paraIsNull_ = false;}
   else{correlation_paraIsNull_ = true;}

   if(correlation_paraNode)
   {
      for(correlation_paraNode; correlation_paraNode; correlation_paraNode = correlation_paraNode->NextSiblingElement("correlation_para")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- correlation_paraNode , address : " << correlation_paraNode << std::endl;
          #endif
          correlation_para_.push_back(boost::shared_ptr<Correlation_para>(new Correlation_para(correlation_paraNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- correlation_paraNode , address : " << correlation_paraNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeInteger> CorrelationInfo_para::getDimension()
{
   if(!this->dimensionIsNull_){
        return this->dimension_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeInteger>();
   }
}
std::vector<boost::shared_ptr<Correlation_para>> CorrelationInfo_para::getCorrelation_para()
{
   if(!this->correlation_paraIsNull_){
        return this->correlation_para_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Correlation_para>>();
   }
}
}

