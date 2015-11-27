// CompoundingRate.cpp 
#include "CompoundingRate.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CompoundingRate::CompoundingRate(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //interestLegRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* interestLegRateNode = xmlNode->FirstChildElement("interestLegRate");

   if(interestLegRateNode){interestLegRateIsNull_ = false;}
   else{interestLegRateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- interestLegRateNode , address : " << interestLegRateNode << std::endl;
   #endif
   if(interestLegRateNode)
   {
      if(interestLegRateNode->Attribute("href") || interestLegRateNode->Attribute("id"))
      {
          if(interestLegRateNode->Attribute("id"))
          {
             interestLegRateIDRef_ = interestLegRateNode->Attribute("id");
             interestLegRate_ = boost::shared_ptr<FloatingRateCalculationReference>(new FloatingRateCalculationReference(interestLegRateNode));
             interestLegRate_->setID(interestLegRateIDRef_);
             IDManager::instance().setID(interestLegRateIDRef_,interestLegRate_);
          }
          else if(interestLegRateNode->Attribute("href")) { interestLegRateIDRef_ = interestLegRateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { interestLegRate_ = boost::shared_ptr<FloatingRateCalculationReference>(new FloatingRateCalculationReference(interestLegRateNode));}
   }

   //specificRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* specificRateNode = xmlNode->FirstChildElement("specificRate");

   if(specificRateNode){specificRateIsNull_ = false;}
   else{specificRateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- specificRateNode , address : " << specificRateNode << std::endl;
   #endif
   if(specificRateNode)
   {
      if(specificRateNode->Attribute("href") || specificRateNode->Attribute("id"))
      {
          if(specificRateNode->Attribute("id"))
          {
             specificRateIDRef_ = specificRateNode->Attribute("id");
             specificRate_ = boost::shared_ptr<InterestAccrualsMethod>(new InterestAccrualsMethod(specificRateNode));
             specificRate_->setID(specificRateIDRef_);
             IDManager::instance().setID(specificRateIDRef_,specificRate_);
          }
          else if(specificRateNode->Attribute("href")) { specificRateIDRef_ = specificRateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { specificRate_ = boost::shared_ptr<InterestAccrualsMethod>(new InterestAccrualsMethod(specificRateNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<FloatingRateCalculationReference> CompoundingRate::getInterestLegRate()
{
   if(!this->interestLegRateIsNull_){
        if(interestLegRateIDRef_ != ""){
             return boost::shared_static_cast<FloatingRateCalculationReference>(IDManager::instance().getID(interestLegRateIDRef_));
        }else{
             return this->interestLegRate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FloatingRateCalculationReference>();
   }
}
boost::shared_ptr<InterestAccrualsMethod> CompoundingRate::getSpecificRate()
{
   if(!this->specificRateIsNull_){
        if(specificRateIDRef_ != ""){
             return boost::shared_static_cast<InterestAccrualsMethod>(IDManager::instance().getID(specificRateIDRef_));
        }else{
             return this->specificRate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<InterestAccrualsMethod>();
   }
}
}

