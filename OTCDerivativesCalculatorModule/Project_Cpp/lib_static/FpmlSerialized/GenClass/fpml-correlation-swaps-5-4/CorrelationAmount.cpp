// CorrelationAmount.cpp 
#include "CorrelationAmount.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CorrelationAmount::CorrelationAmount(TiXmlNode* xmlNode)
: CalculatedAmount(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //correlationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* correlationNode = xmlNode->FirstChildElement("correlation");

   if(correlationNode){correlationIsNull_ = false;}
   else{correlationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- correlationNode , address : " << correlationNode << std::endl;
   #endif
   if(correlationNode)
   {
      if(correlationNode->Attribute("href") || correlationNode->Attribute("id"))
      {
          if(correlationNode->Attribute("id"))
          {
             correlationIDRef_ = correlationNode->Attribute("id");
             correlation_ = boost::shared_ptr<Correlation>(new Correlation(correlationNode));
             correlation_->setID(correlationIDRef_);
             IDManager::instance().setID(correlationIDRef_,correlation_);
          }
          else if(correlationNode->Attribute("href")) { correlationIDRef_ = correlationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { correlation_ = boost::shared_ptr<Correlation>(new Correlation(correlationNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Correlation> CorrelationAmount::getCorrelation()
{
   if(!this->correlationIsNull_){
        if(correlationIDRef_ != ""){
             return boost::shared_static_cast<Correlation>(IDManager::instance().getID(correlationIDRef_));
        }else{
             return this->correlation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Correlation>();
   }
}
}

