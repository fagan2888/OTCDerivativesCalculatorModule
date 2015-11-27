// CreditDefaultSwapInstrument.cpp 
#include "CreditDefaultSwapInstrument.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CreditDefaultSwapInstrument::CreditDefaultSwapInstrument(TiXmlNode* xmlNode)
: Instrument(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //creditDefaultSwapNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* creditDefaultSwapNode = xmlNode->FirstChildElement("creditDefaultSwap");

   if(creditDefaultSwapNode){creditDefaultSwapIsNull_ = false;}
   else{creditDefaultSwapIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- creditDefaultSwapNode , address : " << creditDefaultSwapNode << std::endl;
   #endif
   if(creditDefaultSwapNode)
   {
       creditDefaultSwap_ = boost::shared_ptr<CreditDefaultSwap>(new CreditDefaultSwap(creditDefaultSwapNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<CreditDefaultSwap> CreditDefaultSwapInstrument::getCreditDefaultSwap()
{
   if(!this->creditDefaultSwapIsNull_){
        return this->creditDefaultSwap_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CreditDefaultSwap>();
   }
}
}

