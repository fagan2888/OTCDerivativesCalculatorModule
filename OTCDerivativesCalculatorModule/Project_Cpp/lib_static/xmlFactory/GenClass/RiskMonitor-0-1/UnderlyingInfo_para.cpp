// UnderlyingInfo_para.cpp 
#include "UnderlyingInfo_para.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

UnderlyingInfo_para::UnderlyingInfo_para(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //underlying_paraNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* underlying_paraNode = xmlNode->FirstChildElement("underlying_para");

   if(underlying_paraNode){underlying_paraIsNull_ = false;}
   else{underlying_paraIsNull_ = true;}

   if(underlying_paraNode)
   {
      for(underlying_paraNode; underlying_paraNode; underlying_paraNode = underlying_paraNode->NextSiblingElement("underlying_para")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- underlying_paraNode , address : " << underlying_paraNode << std::endl;
          #endif
          underlying_para_.push_back(boost::shared_ptr<Underlying_para>(new Underlying_para(underlying_paraNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- underlying_paraNode , address : " << underlying_paraNode << std::endl;
       #endif
   }

   //correlationInfo_paraNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* correlationInfo_paraNode = xmlNode->FirstChildElement("correlationInfo_para");

   if(correlationInfo_paraNode){correlationInfo_paraIsNull_ = false;}
   else{correlationInfo_paraIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- correlationInfo_paraNode , address : " << correlationInfo_paraNode << std::endl;
   #endif
   if(correlationInfo_paraNode)
   {
       correlationInfo_para_ = boost::shared_ptr<CorrelationInfo_para>(new CorrelationInfo_para(correlationInfo_paraNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<Underlying_para>> UnderlyingInfo_para::getUnderlying_para()
{
   if(!this->underlying_paraIsNull_){
        return this->underlying_para_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Underlying_para>>();
   }
}
boost::shared_ptr<CorrelationInfo_para> UnderlyingInfo_para::getCorrelationInfo_para()
{
   if(!this->correlationInfo_paraIsNull_){
        return this->correlationInfo_para_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CorrelationInfo_para>();
   }
}
}

