// CalculationAmount.cpp 
#include "CalculationAmount.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CalculationAmount::CalculationAmount(TiXmlNode* xmlNode)
: Money(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //stepNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* stepNode = xmlNode->FirstChildElement("step");

   if(stepNode){stepIsNull_ = false;}
   else{stepIsNull_ = true;}

   if(stepNode)
   {
      for(stepNode; stepNode; stepNode = stepNode->NextSiblingElement("step")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- stepNode , address : " << stepNode << std::endl;
          #endif
          if(stepNode->Attribute("href") || stepNode->Attribute("id"))
          {
              if(stepNode->Attribute("id"))
              {
                  stepIDRef_ = stepNode->Attribute("id");
                  step_.push_back(boost::shared_ptr<Step>(new Step(stepNode)));
                  step_.back()->setID(stepIDRef_);
                  IDManager::instance().setID(stepIDRef_, step_.back());
              }
              else if(stepNode->Attribute("href")) { stepIDRef_ = stepNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { step_.push_back(boost::shared_ptr<Step>(new Step(stepNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- stepNode , address : " << stepNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<Step>> CalculationAmount::getStep()
{
   if(!this->stepIsNull_){
        if(stepIDRef_ != ""){
             return this->step_;
        }else{
             return this->step_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Step>>();
   }
}
}

