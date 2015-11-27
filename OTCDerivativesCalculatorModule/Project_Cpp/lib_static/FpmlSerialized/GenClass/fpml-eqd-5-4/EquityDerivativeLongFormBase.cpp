// EquityDerivativeLongFormBase.cpp 
#include "EquityDerivativeLongFormBase.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

EquityDerivativeLongFormBase::EquityDerivativeLongFormBase(TiXmlNode* xmlNode)
: EquityDerivativeBase(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //dividendConditionsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dividendConditionsNode = xmlNode->FirstChildElement("dividendConditions");

   if(dividendConditionsNode){dividendConditionsIsNull_ = false;}
   else{dividendConditionsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dividendConditionsNode , address : " << dividendConditionsNode << std::endl;
   #endif
   if(dividendConditionsNode)
   {
      if(dividendConditionsNode->Attribute("href") || dividendConditionsNode->Attribute("id"))
      {
          if(dividendConditionsNode->Attribute("id"))
          {
             dividendConditionsIDRef_ = dividendConditionsNode->Attribute("id");
             dividendConditions_ = boost::shared_ptr<DividendConditions>(new DividendConditions(dividendConditionsNode));
             dividendConditions_->setID(dividendConditionsIDRef_);
             IDManager::instance().setID(dividendConditionsIDRef_,dividendConditions_);
          }
          else if(dividendConditionsNode->Attribute("href")) { dividendConditionsIDRef_ = dividendConditionsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { dividendConditions_ = boost::shared_ptr<DividendConditions>(new DividendConditions(dividendConditionsNode));}
   }

   //methodOfAdjustmentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* methodOfAdjustmentNode = xmlNode->FirstChildElement("methodOfAdjustment");

   if(methodOfAdjustmentNode){methodOfAdjustmentIsNull_ = false;}
   else{methodOfAdjustmentIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- methodOfAdjustmentNode , address : " << methodOfAdjustmentNode << std::endl;
   #endif
   if(methodOfAdjustmentNode)
   {
      if(methodOfAdjustmentNode->Attribute("href") || methodOfAdjustmentNode->Attribute("id"))
      {
          if(methodOfAdjustmentNode->Attribute("id"))
          {
             methodOfAdjustmentIDRef_ = methodOfAdjustmentNode->Attribute("id");
             methodOfAdjustment_ = boost::shared_ptr<MethodOfAdjustmentEnum>(new MethodOfAdjustmentEnum(methodOfAdjustmentNode));
             methodOfAdjustment_->setID(methodOfAdjustmentIDRef_);
             IDManager::instance().setID(methodOfAdjustmentIDRef_,methodOfAdjustment_);
          }
          else if(methodOfAdjustmentNode->Attribute("href")) { methodOfAdjustmentIDRef_ = methodOfAdjustmentNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { methodOfAdjustment_ = boost::shared_ptr<MethodOfAdjustmentEnum>(new MethodOfAdjustmentEnum(methodOfAdjustmentNode));}
   }

   //extraordinaryEventsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* extraordinaryEventsNode = xmlNode->FirstChildElement("extraordinaryEvents");

   if(extraordinaryEventsNode){extraordinaryEventsIsNull_ = false;}
   else{extraordinaryEventsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- extraordinaryEventsNode , address : " << extraordinaryEventsNode << std::endl;
   #endif
   if(extraordinaryEventsNode)
   {
      if(extraordinaryEventsNode->Attribute("href") || extraordinaryEventsNode->Attribute("id"))
      {
          if(extraordinaryEventsNode->Attribute("id"))
          {
             extraordinaryEventsIDRef_ = extraordinaryEventsNode->Attribute("id");
             extraordinaryEvents_ = boost::shared_ptr<ExtraordinaryEvents>(new ExtraordinaryEvents(extraordinaryEventsNode));
             extraordinaryEvents_->setID(extraordinaryEventsIDRef_);
             IDManager::instance().setID(extraordinaryEventsIDRef_,extraordinaryEvents_);
          }
          else if(extraordinaryEventsNode->Attribute("href")) { extraordinaryEventsIDRef_ = extraordinaryEventsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { extraordinaryEvents_ = boost::shared_ptr<ExtraordinaryEvents>(new ExtraordinaryEvents(extraordinaryEventsNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<DividendConditions> EquityDerivativeLongFormBase::getDividendConditions()
{
   if(!this->dividendConditionsIsNull_){
        if(dividendConditionsIDRef_ != ""){
             return boost::shared_static_cast<DividendConditions>(IDManager::instance().getID(dividendConditionsIDRef_));
        }else{
             return this->dividendConditions_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DividendConditions>();
   }
}
boost::shared_ptr<MethodOfAdjustmentEnum> EquityDerivativeLongFormBase::getMethodOfAdjustment()
{
   if(!this->methodOfAdjustmentIsNull_){
        if(methodOfAdjustmentIDRef_ != ""){
             return boost::shared_static_cast<MethodOfAdjustmentEnum>(IDManager::instance().getID(methodOfAdjustmentIDRef_));
        }else{
             return this->methodOfAdjustment_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<MethodOfAdjustmentEnum>();
   }
}
boost::shared_ptr<ExtraordinaryEvents> EquityDerivativeLongFormBase::getExtraordinaryEvents()
{
   if(!this->extraordinaryEventsIsNull_){
        if(extraordinaryEventsIDRef_ != ""){
             return boost::shared_static_cast<ExtraordinaryEvents>(IDManager::instance().getID(extraordinaryEventsIDRef_));
        }else{
             return this->extraordinaryEvents_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ExtraordinaryEvents>();
   }
}
}

