// FixedPaymentLeg.cpp 
#include "FixedPaymentLeg.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FixedPaymentLeg::FixedPaymentLeg(TiXmlNode* xmlNode)
: DirectionalLeg(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //fixedPaymentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fixedPaymentNode = xmlNode->FirstChildElement("fixedPayment");

   if(fixedPaymentNode){fixedPaymentIsNull_ = false;}
   else{fixedPaymentIsNull_ = true;}

   if(fixedPaymentNode)
   {
      for(fixedPaymentNode; fixedPaymentNode; fixedPaymentNode = fixedPaymentNode->NextSiblingElement("fixedPayment")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fixedPaymentNode , address : " << fixedPaymentNode << std::endl;
          #endif
          if(fixedPaymentNode->Attribute("href") || fixedPaymentNode->Attribute("id"))
          {
              if(fixedPaymentNode->Attribute("id"))
              {
                  fixedPaymentIDRef_ = fixedPaymentNode->Attribute("id");
                  fixedPayment_.push_back(boost::shared_ptr<FixedPaymentAmount>(new FixedPaymentAmount(fixedPaymentNode)));
                  fixedPayment_.back()->setID(fixedPaymentIDRef_);
                  IDManager::instance().setID(fixedPaymentIDRef_, fixedPayment_.back());
              }
              else if(fixedPaymentNode->Attribute("href")) { fixedPaymentIDRef_ = fixedPaymentNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { fixedPayment_.push_back(boost::shared_ptr<FixedPaymentAmount>(new FixedPaymentAmount(fixedPaymentNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fixedPaymentNode , address : " << fixedPaymentNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<FixedPaymentAmount>> FixedPaymentLeg::getFixedPayment()
{
   if(!this->fixedPaymentIsNull_){
        if(fixedPaymentIDRef_ != ""){
             return this->fixedPayment_;
        }else{
             return this->fixedPayment_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<FixedPaymentAmount>>();
   }
}
}

