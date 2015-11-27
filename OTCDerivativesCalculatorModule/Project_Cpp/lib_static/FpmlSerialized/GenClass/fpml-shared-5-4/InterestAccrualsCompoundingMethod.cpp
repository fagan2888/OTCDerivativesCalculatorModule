// InterestAccrualsCompoundingMethod.cpp 
#include "InterestAccrualsCompoundingMethod.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

InterestAccrualsCompoundingMethod::InterestAccrualsCompoundingMethod(TiXmlNode* xmlNode)
: InterestAccrualsMethod(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //compoundingMethodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* compoundingMethodNode = xmlNode->FirstChildElement("compoundingMethod");

   if(compoundingMethodNode){compoundingMethodIsNull_ = false;}
   else{compoundingMethodIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- compoundingMethodNode , address : " << compoundingMethodNode << std::endl;
   #endif
   if(compoundingMethodNode)
   {
      if(compoundingMethodNode->Attribute("href") || compoundingMethodNode->Attribute("id"))
      {
          if(compoundingMethodNode->Attribute("id"))
          {
             compoundingMethodIDRef_ = compoundingMethodNode->Attribute("id");
             compoundingMethod_ = boost::shared_ptr<CompoundingMethodEnum>(new CompoundingMethodEnum(compoundingMethodNode));
             compoundingMethod_->setID(compoundingMethodIDRef_);
             IDManager::instance().setID(compoundingMethodIDRef_,compoundingMethod_);
          }
          else if(compoundingMethodNode->Attribute("href")) { compoundingMethodIDRef_ = compoundingMethodNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { compoundingMethod_ = boost::shared_ptr<CompoundingMethodEnum>(new CompoundingMethodEnum(compoundingMethodNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<CompoundingMethodEnum> InterestAccrualsCompoundingMethod::getCompoundingMethod()
{
   if(!this->compoundingMethodIsNull_){
        if(compoundingMethodIDRef_ != ""){
             return boost::shared_static_cast<CompoundingMethodEnum>(IDManager::instance().getID(compoundingMethodIDRef_));
        }else{
             return this->compoundingMethod_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CompoundingMethodEnum>();
   }
}
}

