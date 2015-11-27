// EquityForward.cpp 
#include "EquityForward.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

EquityForward::EquityForward(TiXmlNode* xmlNode)
: EquityDerivativeLongFormBase(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //forwardPriceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* forwardPriceNode = xmlNode->FirstChildElement("forwardPrice");

   if(forwardPriceNode){forwardPriceIsNull_ = false;}
   else{forwardPriceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- forwardPriceNode , address : " << forwardPriceNode << std::endl;
   #endif
   if(forwardPriceNode)
   {
      if(forwardPriceNode->Attribute("href") || forwardPriceNode->Attribute("id"))
      {
          if(forwardPriceNode->Attribute("id"))
          {
             forwardPriceIDRef_ = forwardPriceNode->Attribute("id");
             forwardPrice_ = boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(forwardPriceNode));
             forwardPrice_->setID(forwardPriceIDRef_);
             IDManager::instance().setID(forwardPriceIDRef_,forwardPrice_);
          }
          else if(forwardPriceNode->Attribute("href")) { forwardPriceIDRef_ = forwardPriceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { forwardPrice_ = boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(forwardPriceNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<NonNegativeMoney> EquityForward::getForwardPrice()
{
   if(!this->forwardPriceIsNull_){
        if(forwardPriceIDRef_ != ""){
             return boost::shared_static_cast<NonNegativeMoney>(IDManager::instance().getID(forwardPriceIDRef_));
        }else{
             return this->forwardPrice_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NonNegativeMoney>();
   }
}
}

