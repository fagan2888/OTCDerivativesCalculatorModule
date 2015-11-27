// FxLinkedNotionalSchedule.cpp 
#include "FxLinkedNotionalSchedule.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FxLinkedNotionalSchedule::FxLinkedNotionalSchedule(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //constantNotionalScheduleReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* constantNotionalScheduleReferenceNode = xmlNode->FirstChildElement("constantNotionalScheduleReference");

   if(constantNotionalScheduleReferenceNode){constantNotionalScheduleReferenceIsNull_ = false;}
   else{constantNotionalScheduleReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- constantNotionalScheduleReferenceNode , address : " << constantNotionalScheduleReferenceNode << std::endl;
   #endif
   if(constantNotionalScheduleReferenceNode)
   {
      if(constantNotionalScheduleReferenceNode->Attribute("href") || constantNotionalScheduleReferenceNode->Attribute("id"))
      {
          if(constantNotionalScheduleReferenceNode->Attribute("id"))
          {
             constantNotionalScheduleReferenceIDRef_ = constantNotionalScheduleReferenceNode->Attribute("id");
             constantNotionalScheduleReference_ = boost::shared_ptr<NotionalReference>(new NotionalReference(constantNotionalScheduleReferenceNode));
             constantNotionalScheduleReference_->setID(constantNotionalScheduleReferenceIDRef_);
             IDManager::instance().setID(constantNotionalScheduleReferenceIDRef_,constantNotionalScheduleReference_);
          }
          else if(constantNotionalScheduleReferenceNode->Attribute("href")) { constantNotionalScheduleReferenceIDRef_ = constantNotionalScheduleReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { constantNotionalScheduleReference_ = boost::shared_ptr<NotionalReference>(new NotionalReference(constantNotionalScheduleReferenceNode));}
   }

   //initialValueNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* initialValueNode = xmlNode->FirstChildElement("initialValue");

   if(initialValueNode){initialValueIsNull_ = false;}
   else{initialValueIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- initialValueNode , address : " << initialValueNode << std::endl;
   #endif
   if(initialValueNode)
   {
      if(initialValueNode->Attribute("href") || initialValueNode->Attribute("id"))
      {
          if(initialValueNode->Attribute("id"))
          {
             initialValueIDRef_ = initialValueNode->Attribute("id");
             initialValue_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(initialValueNode));
             initialValue_->setID(initialValueIDRef_);
             IDManager::instance().setID(initialValueIDRef_,initialValue_);
          }
          else if(initialValueNode->Attribute("href")) { initialValueIDRef_ = initialValueNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { initialValue_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(initialValueNode));}
   }

   //varyingNotionalCurrencyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* varyingNotionalCurrencyNode = xmlNode->FirstChildElement("varyingNotionalCurrency");

   if(varyingNotionalCurrencyNode){varyingNotionalCurrencyIsNull_ = false;}
   else{varyingNotionalCurrencyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- varyingNotionalCurrencyNode , address : " << varyingNotionalCurrencyNode << std::endl;
   #endif
   if(varyingNotionalCurrencyNode)
   {
      if(varyingNotionalCurrencyNode->Attribute("href") || varyingNotionalCurrencyNode->Attribute("id"))
      {
          if(varyingNotionalCurrencyNode->Attribute("id"))
          {
             varyingNotionalCurrencyIDRef_ = varyingNotionalCurrencyNode->Attribute("id");
             varyingNotionalCurrency_ = boost::shared_ptr<Currency>(new Currency(varyingNotionalCurrencyNode));
             varyingNotionalCurrency_->setID(varyingNotionalCurrencyIDRef_);
             IDManager::instance().setID(varyingNotionalCurrencyIDRef_,varyingNotionalCurrency_);
          }
          else if(varyingNotionalCurrencyNode->Attribute("href")) { varyingNotionalCurrencyIDRef_ = varyingNotionalCurrencyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { varyingNotionalCurrency_ = boost::shared_ptr<Currency>(new Currency(varyingNotionalCurrencyNode));}
   }

   //varyingNotionalFixingDatesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* varyingNotionalFixingDatesNode = xmlNode->FirstChildElement("varyingNotionalFixingDates");

   if(varyingNotionalFixingDatesNode){varyingNotionalFixingDatesIsNull_ = false;}
   else{varyingNotionalFixingDatesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- varyingNotionalFixingDatesNode , address : " << varyingNotionalFixingDatesNode << std::endl;
   #endif
   if(varyingNotionalFixingDatesNode)
   {
      if(varyingNotionalFixingDatesNode->Attribute("href") || varyingNotionalFixingDatesNode->Attribute("id"))
      {
          if(varyingNotionalFixingDatesNode->Attribute("id"))
          {
             varyingNotionalFixingDatesIDRef_ = varyingNotionalFixingDatesNode->Attribute("id");
             varyingNotionalFixingDates_ = boost::shared_ptr<RelativeDateOffset>(new RelativeDateOffset(varyingNotionalFixingDatesNode));
             varyingNotionalFixingDates_->setID(varyingNotionalFixingDatesIDRef_);
             IDManager::instance().setID(varyingNotionalFixingDatesIDRef_,varyingNotionalFixingDates_);
          }
          else if(varyingNotionalFixingDatesNode->Attribute("href")) { varyingNotionalFixingDatesIDRef_ = varyingNotionalFixingDatesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { varyingNotionalFixingDates_ = boost::shared_ptr<RelativeDateOffset>(new RelativeDateOffset(varyingNotionalFixingDatesNode));}
   }

   //fxSpotRateSourceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fxSpotRateSourceNode = xmlNode->FirstChildElement("fxSpotRateSource");

   if(fxSpotRateSourceNode){fxSpotRateSourceIsNull_ = false;}
   else{fxSpotRateSourceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fxSpotRateSourceNode , address : " << fxSpotRateSourceNode << std::endl;
   #endif
   if(fxSpotRateSourceNode)
   {
      if(fxSpotRateSourceNode->Attribute("href") || fxSpotRateSourceNode->Attribute("id"))
      {
          if(fxSpotRateSourceNode->Attribute("id"))
          {
             fxSpotRateSourceIDRef_ = fxSpotRateSourceNode->Attribute("id");
             fxSpotRateSource_ = boost::shared_ptr<FxSpotRateSource>(new FxSpotRateSource(fxSpotRateSourceNode));
             fxSpotRateSource_->setID(fxSpotRateSourceIDRef_);
             IDManager::instance().setID(fxSpotRateSourceIDRef_,fxSpotRateSource_);
          }
          else if(fxSpotRateSourceNode->Attribute("href")) { fxSpotRateSourceIDRef_ = fxSpotRateSourceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fxSpotRateSource_ = boost::shared_ptr<FxSpotRateSource>(new FxSpotRateSource(fxSpotRateSourceNode));}
   }

   //varyingNotionalInterimExchangePaymentDatesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* varyingNotionalInterimExchangePaymentDatesNode = xmlNode->FirstChildElement("varyingNotionalInterimExchangePaymentDates");

   if(varyingNotionalInterimExchangePaymentDatesNode){varyingNotionalInterimExchangePaymentDatesIsNull_ = false;}
   else{varyingNotionalInterimExchangePaymentDatesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- varyingNotionalInterimExchangePaymentDatesNode , address : " << varyingNotionalInterimExchangePaymentDatesNode << std::endl;
   #endif
   if(varyingNotionalInterimExchangePaymentDatesNode)
   {
      if(varyingNotionalInterimExchangePaymentDatesNode->Attribute("href") || varyingNotionalInterimExchangePaymentDatesNode->Attribute("id"))
      {
          if(varyingNotionalInterimExchangePaymentDatesNode->Attribute("id"))
          {
             varyingNotionalInterimExchangePaymentDatesIDRef_ = varyingNotionalInterimExchangePaymentDatesNode->Attribute("id");
             varyingNotionalInterimExchangePaymentDates_ = boost::shared_ptr<RelativeDateOffset>(new RelativeDateOffset(varyingNotionalInterimExchangePaymentDatesNode));
             varyingNotionalInterimExchangePaymentDates_->setID(varyingNotionalInterimExchangePaymentDatesIDRef_);
             IDManager::instance().setID(varyingNotionalInterimExchangePaymentDatesIDRef_,varyingNotionalInterimExchangePaymentDates_);
          }
          else if(varyingNotionalInterimExchangePaymentDatesNode->Attribute("href")) { varyingNotionalInterimExchangePaymentDatesIDRef_ = varyingNotionalInterimExchangePaymentDatesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { varyingNotionalInterimExchangePaymentDates_ = boost::shared_ptr<RelativeDateOffset>(new RelativeDateOffset(varyingNotionalInterimExchangePaymentDatesNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<NotionalReference> FxLinkedNotionalSchedule::getConstantNotionalScheduleReference()
{
   if(!this->constantNotionalScheduleReferenceIsNull_){
        if(constantNotionalScheduleReferenceIDRef_ != ""){
             return boost::shared_static_cast<NotionalReference>(IDManager::instance().getID(constantNotionalScheduleReferenceIDRef_));
        }else{
             return this->constantNotionalScheduleReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NotionalReference>();
   }
}
boost::shared_ptr<XsdTypeDecimal> FxLinkedNotionalSchedule::getInitialValue()
{
   if(!this->initialValueIsNull_){
        if(initialValueIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(initialValueIDRef_));
        }else{
             return this->initialValue_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<Currency> FxLinkedNotionalSchedule::getVaryingNotionalCurrency()
{
   if(!this->varyingNotionalCurrencyIsNull_){
        if(varyingNotionalCurrencyIDRef_ != ""){
             return boost::shared_static_cast<Currency>(IDManager::instance().getID(varyingNotionalCurrencyIDRef_));
        }else{
             return this->varyingNotionalCurrency_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Currency>();
   }
}
boost::shared_ptr<RelativeDateOffset> FxLinkedNotionalSchedule::getVaryingNotionalFixingDates()
{
   if(!this->varyingNotionalFixingDatesIsNull_){
        if(varyingNotionalFixingDatesIDRef_ != ""){
             return boost::shared_static_cast<RelativeDateOffset>(IDManager::instance().getID(varyingNotionalFixingDatesIDRef_));
        }else{
             return this->varyingNotionalFixingDates_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<RelativeDateOffset>();
   }
}
boost::shared_ptr<FxSpotRateSource> FxLinkedNotionalSchedule::getFxSpotRateSource()
{
   if(!this->fxSpotRateSourceIsNull_){
        if(fxSpotRateSourceIDRef_ != ""){
             return boost::shared_static_cast<FxSpotRateSource>(IDManager::instance().getID(fxSpotRateSourceIDRef_));
        }else{
             return this->fxSpotRateSource_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FxSpotRateSource>();
   }
}
boost::shared_ptr<RelativeDateOffset> FxLinkedNotionalSchedule::getVaryingNotionalInterimExchangePaymentDates()
{
   if(!this->varyingNotionalInterimExchangePaymentDatesIsNull_){
        if(varyingNotionalInterimExchangePaymentDatesIDRef_ != ""){
             return boost::shared_static_cast<RelativeDateOffset>(IDManager::instance().getID(varyingNotionalInterimExchangePaymentDatesIDRef_));
        }else{
             return this->varyingNotionalInterimExchangePaymentDates_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<RelativeDateOffset>();
   }
}
}

