// DividendAdjustment.cpp 
#include "DividendAdjustment.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

DividendAdjustment::DividendAdjustment(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //dividendPeriodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dividendPeriodNode = xmlNode->FirstChildElement("dividendPeriod");

   if(dividendPeriodNode){dividendPeriodIsNull_ = false;}
   else{dividendPeriodIsNull_ = true;}

   if(dividendPeriodNode)
   {
      for(dividendPeriodNode; dividendPeriodNode; dividendPeriodNode = dividendPeriodNode->NextSiblingElement("dividendPeriod")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dividendPeriodNode , address : " << dividendPeriodNode << std::endl;
          #endif
          if(dividendPeriodNode->Attribute("href") || dividendPeriodNode->Attribute("id"))
          {
              if(dividendPeriodNode->Attribute("id"))
              {
                  dividendPeriodIDRef_ = dividendPeriodNode->Attribute("id");
                  dividendPeriod_.push_back(boost::shared_ptr<DividendPeriodDividend>(new DividendPeriodDividend(dividendPeriodNode)));
                  dividendPeriod_.back()->setID(dividendPeriodIDRef_);
                  IDManager::instance().setID(dividendPeriodIDRef_, dividendPeriod_.back());
              }
              else if(dividendPeriodNode->Attribute("href")) { dividendPeriodIDRef_ = dividendPeriodNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { dividendPeriod_.push_back(boost::shared_ptr<DividendPeriodDividend>(new DividendPeriodDividend(dividendPeriodNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dividendPeriodNode , address : " << dividendPeriodNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<DividendPeriodDividend>> DividendAdjustment::getDividendPeriod()
{
   if(!this->dividendPeriodIsNull_){
        if(dividendPeriodIDRef_ != ""){
             return this->dividendPeriod_;
        }else{
             return this->dividendPeriod_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<DividendPeriodDividend>>();
   }
}
}

