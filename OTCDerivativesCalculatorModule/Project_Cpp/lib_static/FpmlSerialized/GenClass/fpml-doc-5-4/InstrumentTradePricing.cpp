// InstrumentTradePricing.cpp 
#include "InstrumentTradePricing.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

InstrumentTradePricing::InstrumentTradePricing(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //quoteNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* quoteNode = xmlNode->FirstChildElement("quote");

   if(quoteNode){quoteIsNull_ = false;}
   else{quoteIsNull_ = true;}

   if(quoteNode)
   {
      for(quoteNode; quoteNode; quoteNode = quoteNode->NextSiblingElement("quote")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- quoteNode , address : " << quoteNode << std::endl;
          #endif
          if(quoteNode->Attribute("href") || quoteNode->Attribute("id"))
          {
              if(quoteNode->Attribute("id"))
              {
                  quoteIDRef_ = quoteNode->Attribute("id");
                  quote_.push_back(boost::shared_ptr<BasicQuotation>(new BasicQuotation(quoteNode)));
                  quote_.back()->setID(quoteIDRef_);
                  IDManager::instance().setID(quoteIDRef_, quote_.back());
              }
              else if(quoteNode->Attribute("href")) { quoteIDRef_ = quoteNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { quote_.push_back(boost::shared_ptr<BasicQuotation>(new BasicQuotation(quoteNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- quoteNode , address : " << quoteNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<BasicQuotation>> InstrumentTradePricing::getQuote()
{
   if(!this->quoteIsNull_){
        if(quoteIDRef_ != ""){
             return this->quote_;
        }else{
             return this->quote_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<BasicQuotation>>();
   }
}
}

