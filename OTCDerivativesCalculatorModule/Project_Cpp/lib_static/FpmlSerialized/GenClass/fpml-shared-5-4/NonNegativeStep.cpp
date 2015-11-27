// NonNegativeStep.cpp 
#include "NonNegativeStep.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

NonNegativeStep::NonNegativeStep(TiXmlNode* xmlNode)
: StepBase(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //stepValueNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* stepValueNode = xmlNode->FirstChildElement("stepValue");

   if(stepValueNode){stepValueIsNull_ = false;}
   else{stepValueIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- stepValueNode , address : " << stepValueNode << std::endl;
   #endif
   if(stepValueNode)
   {
      if(stepValueNode->Attribute("href") || stepValueNode->Attribute("id"))
      {
          if(stepValueNode->Attribute("id"))
          {
             stepValueIDRef_ = stepValueNode->Attribute("id");
             stepValue_ = boost::shared_ptr<NonNegativeDecimal>(new NonNegativeDecimal(stepValueNode));
             stepValue_->setID(stepValueIDRef_);
             IDManager::instance().setID(stepValueIDRef_,stepValue_);
          }
          else if(stepValueNode->Attribute("href")) { stepValueIDRef_ = stepValueNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { stepValue_ = boost::shared_ptr<NonNegativeDecimal>(new NonNegativeDecimal(stepValueNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<NonNegativeDecimal> NonNegativeStep::getStepValue()
{
   if(!this->stepValueIsNull_){
        if(stepValueIDRef_ != ""){
             return boost::shared_static_cast<NonNegativeDecimal>(IDManager::instance().getID(stepValueIDRef_));
        }else{
             return this->stepValue_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NonNegativeDecimal>();
   }
}
}

