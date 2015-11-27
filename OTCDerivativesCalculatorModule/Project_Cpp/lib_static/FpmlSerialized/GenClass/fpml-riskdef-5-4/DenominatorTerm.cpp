// DenominatorTerm.cpp 
#include "DenominatorTerm.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

DenominatorTerm::DenominatorTerm(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //weightedPartialNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* weightedPartialNode = xmlNode->FirstChildElement("weightedPartial");

   if(weightedPartialNode){weightedPartialIsNull_ = false;}
   else{weightedPartialIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- weightedPartialNode , address : " << weightedPartialNode << std::endl;
   #endif
   if(weightedPartialNode)
   {
      if(weightedPartialNode->Attribute("href") || weightedPartialNode->Attribute("id"))
      {
          if(weightedPartialNode->Attribute("id"))
          {
             weightedPartialIDRef_ = weightedPartialNode->Attribute("id");
             weightedPartial_ = boost::shared_ptr<WeightedPartialDerivative>(new WeightedPartialDerivative(weightedPartialNode));
             weightedPartial_->setID(weightedPartialIDRef_);
             IDManager::instance().setID(weightedPartialIDRef_,weightedPartial_);
          }
          else if(weightedPartialNode->Attribute("href")) { weightedPartialIDRef_ = weightedPartialNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { weightedPartial_ = boost::shared_ptr<WeightedPartialDerivative>(new WeightedPartialDerivative(weightedPartialNode));}
   }

   //powerNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* powerNode = xmlNode->FirstChildElement("power");

   if(powerNode){powerIsNull_ = false;}
   else{powerIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- powerNode , address : " << powerNode << std::endl;
   #endif
   if(powerNode)
   {
      if(powerNode->Attribute("href") || powerNode->Attribute("id"))
      {
          if(powerNode->Attribute("id"))
          {
             powerIDRef_ = powerNode->Attribute("id");
             power_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(powerNode));
             power_->setID(powerIDRef_);
             IDManager::instance().setID(powerIDRef_,power_);
          }
          else if(powerNode->Attribute("href")) { powerIDRef_ = powerNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { power_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(powerNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<WeightedPartialDerivative> DenominatorTerm::getWeightedPartial()
{
   if(!this->weightedPartialIsNull_){
        if(weightedPartialIDRef_ != ""){
             return boost::shared_static_cast<WeightedPartialDerivative>(IDManager::instance().getID(weightedPartialIDRef_));
        }else{
             return this->weightedPartial_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<WeightedPartialDerivative>();
   }
}
boost::shared_ptr<XsdTypePositiveInteger> DenominatorTerm::getPower()
{
   if(!this->powerIsNull_){
        if(powerIDRef_ != ""){
             return boost::shared_static_cast<XsdTypePositiveInteger>(IDManager::instance().getID(powerIDRef_));
        }else{
             return this->power_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypePositiveInteger>();
   }
}
}

