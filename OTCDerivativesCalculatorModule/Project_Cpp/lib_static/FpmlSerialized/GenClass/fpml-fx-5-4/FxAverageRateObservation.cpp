// FxAverageRateObservation.cpp 
#include "FxAverageRateObservation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FxAverageRateObservation::FxAverageRateObservation(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //dateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dateNode = xmlNode->FirstChildElement("date");

   if(dateNode){dateIsNull_ = false;}
   else{dateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dateNode , address : " << dateNode << std::endl;
   #endif
   if(dateNode)
   {
      if(dateNode->Attribute("href") || dateNode->Attribute("id"))
      {
          if(dateNode->Attribute("id"))
          {
             dateIDRef_ = dateNode->Attribute("id");
             date_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(dateNode));
             date_->setID(dateIDRef_);
             IDManager::instance().setID(dateIDRef_,date_);
          }
          else if(dateNode->Attribute("href")) { dateIDRef_ = dateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { date_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(dateNode));}
   }

   //averageRateWeightingFactorNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* averageRateWeightingFactorNode = xmlNode->FirstChildElement("averageRateWeightingFactor");

   if(averageRateWeightingFactorNode){averageRateWeightingFactorIsNull_ = false;}
   else{averageRateWeightingFactorIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- averageRateWeightingFactorNode , address : " << averageRateWeightingFactorNode << std::endl;
   #endif
   if(averageRateWeightingFactorNode)
   {
      if(averageRateWeightingFactorNode->Attribute("href") || averageRateWeightingFactorNode->Attribute("id"))
      {
          if(averageRateWeightingFactorNode->Attribute("id"))
          {
             averageRateWeightingFactorIDRef_ = averageRateWeightingFactorNode->Attribute("id");
             averageRateWeightingFactor_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(averageRateWeightingFactorNode));
             averageRateWeightingFactor_->setID(averageRateWeightingFactorIDRef_);
             IDManager::instance().setID(averageRateWeightingFactorIDRef_,averageRateWeightingFactor_);
          }
          else if(averageRateWeightingFactorNode->Attribute("href")) { averageRateWeightingFactorIDRef_ = averageRateWeightingFactorNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { averageRateWeightingFactor_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(averageRateWeightingFactorNode));}
   }

   //rateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* rateNode = xmlNode->FirstChildElement("rate");

   if(rateNode){rateIsNull_ = false;}
   else{rateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- rateNode , address : " << rateNode << std::endl;
   #endif
   if(rateNode)
   {
      if(rateNode->Attribute("href") || rateNode->Attribute("id"))
      {
          if(rateNode->Attribute("id"))
          {
             rateIDRef_ = rateNode->Attribute("id");
             rate_ = boost::shared_ptr<NonNegativeDecimal>(new NonNegativeDecimal(rateNode));
             rate_->setID(rateIDRef_);
             IDManager::instance().setID(rateIDRef_,rate_);
          }
          else if(rateNode->Attribute("href")) { rateIDRef_ = rateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { rate_ = boost::shared_ptr<NonNegativeDecimal>(new NonNegativeDecimal(rateNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDate> FxAverageRateObservation::getDate()
{
   if(!this->dateIsNull_){
        if(dateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(dateIDRef_));
        }else{
             return this->date_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<XsdTypeDecimal> FxAverageRateObservation::getAverageRateWeightingFactor()
{
   if(!this->averageRateWeightingFactorIsNull_){
        if(averageRateWeightingFactorIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(averageRateWeightingFactorIDRef_));
        }else{
             return this->averageRateWeightingFactor_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<NonNegativeDecimal> FxAverageRateObservation::getRate()
{
   if(!this->rateIsNull_){
        if(rateIDRef_ != ""){
             return boost::shared_static_cast<NonNegativeDecimal>(IDManager::instance().getID(rateIDRef_));
        }else{
             return this->rate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NonNegativeDecimal>();
   }
}
}

