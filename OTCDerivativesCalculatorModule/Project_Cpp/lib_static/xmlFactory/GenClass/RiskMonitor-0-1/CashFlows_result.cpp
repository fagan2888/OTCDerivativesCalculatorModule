// CashFlows_result.cpp 
#include "CashFlows_result.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CashFlows_result::CashFlows_result(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //cashFlow_resultNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* cashFlow_resultNode = xmlNode->FirstChildElement("cashFlow_result");

   if(cashFlow_resultNode){cashFlow_resultIsNull_ = false;}
   else{cashFlow_resultIsNull_ = true;}

   if(cashFlow_resultNode)
   {
      for(cashFlow_resultNode; cashFlow_resultNode; cashFlow_resultNode = cashFlow_resultNode->NextSiblingElement("cashFlow_result")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- cashFlow_resultNode , address : " << cashFlow_resultNode << std::endl;
          #endif
          cashFlow_result_.push_back(boost::shared_ptr<CashFlow_result>(new CashFlow_result(cashFlow_resultNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- cashFlow_resultNode , address : " << cashFlow_resultNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<CashFlow_result>> CashFlows_result::getCashFlow_result()
{
   if(!this->cashFlow_resultIsNull_){
        return this->cashFlow_result_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<CashFlow_result>>();
   }
}
}

