// ResetDates.cpp 
#include "ResetDates.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ResetDates::ResetDates(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //calculationPeriodDatesReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calculationPeriodDatesReferenceNode = xmlNode->FirstChildElement("calculationPeriodDatesReference");

   if(calculationPeriodDatesReferenceNode){calculationPeriodDatesReferenceIsNull_ = false;}
   else{calculationPeriodDatesReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationPeriodDatesReferenceNode , address : " << calculationPeriodDatesReferenceNode << std::endl;
   #endif
   if(calculationPeriodDatesReferenceNode)
   {
      if(calculationPeriodDatesReferenceNode->Attribute("href") || calculationPeriodDatesReferenceNode->Attribute("id"))
      {
          if(calculationPeriodDatesReferenceNode->Attribute("id"))
          {
             calculationPeriodDatesReferenceIDRef_ = calculationPeriodDatesReferenceNode->Attribute("id");
             calculationPeriodDatesReference_ = boost::shared_ptr<CalculationPeriodDatesReference>(new CalculationPeriodDatesReference(calculationPeriodDatesReferenceNode));
             calculationPeriodDatesReference_->setID(calculationPeriodDatesReferenceIDRef_);
             IDManager::instance().setID(calculationPeriodDatesReferenceIDRef_,calculationPeriodDatesReference_);
          }
          else if(calculationPeriodDatesReferenceNode->Attribute("href")) { calculationPeriodDatesReferenceIDRef_ = calculationPeriodDatesReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { calculationPeriodDatesReference_ = boost::shared_ptr<CalculationPeriodDatesReference>(new CalculationPeriodDatesReference(calculationPeriodDatesReferenceNode));}
   }

   //resetRelativeToNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* resetRelativeToNode = xmlNode->FirstChildElement("resetRelativeTo");

   if(resetRelativeToNode){resetRelativeToIsNull_ = false;}
   else{resetRelativeToIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- resetRelativeToNode , address : " << resetRelativeToNode << std::endl;
   #endif
   if(resetRelativeToNode)
   {
      if(resetRelativeToNode->Attribute("href") || resetRelativeToNode->Attribute("id"))
      {
          if(resetRelativeToNode->Attribute("id"))
          {
             resetRelativeToIDRef_ = resetRelativeToNode->Attribute("id");
             resetRelativeTo_ = boost::shared_ptr<ResetRelativeToEnum>(new ResetRelativeToEnum(resetRelativeToNode));
             resetRelativeTo_->setID(resetRelativeToIDRef_);
             IDManager::instance().setID(resetRelativeToIDRef_,resetRelativeTo_);
          }
          else if(resetRelativeToNode->Attribute("href")) { resetRelativeToIDRef_ = resetRelativeToNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { resetRelativeTo_ = boost::shared_ptr<ResetRelativeToEnum>(new ResetRelativeToEnum(resetRelativeToNode));}
   }

   //initialFixingDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* initialFixingDateNode = xmlNode->FirstChildElement("initialFixingDate");

   if(initialFixingDateNode){initialFixingDateIsNull_ = false;}
   else{initialFixingDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- initialFixingDateNode , address : " << initialFixingDateNode << std::endl;
   #endif
   if(initialFixingDateNode)
   {
      if(initialFixingDateNode->Attribute("href") || initialFixingDateNode->Attribute("id"))
      {
          if(initialFixingDateNode->Attribute("id"))
          {
             initialFixingDateIDRef_ = initialFixingDateNode->Attribute("id");
             initialFixingDate_ = boost::shared_ptr<RelativeDateOffset>(new RelativeDateOffset(initialFixingDateNode));
             initialFixingDate_->setID(initialFixingDateIDRef_);
             IDManager::instance().setID(initialFixingDateIDRef_,initialFixingDate_);
          }
          else if(initialFixingDateNode->Attribute("href")) { initialFixingDateIDRef_ = initialFixingDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { initialFixingDate_ = boost::shared_ptr<RelativeDateOffset>(new RelativeDateOffset(initialFixingDateNode));}
   }

   //fixingDatesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fixingDatesNode = xmlNode->FirstChildElement("fixingDates");

   if(fixingDatesNode){fixingDatesIsNull_ = false;}
   else{fixingDatesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fixingDatesNode , address : " << fixingDatesNode << std::endl;
   #endif
   if(fixingDatesNode)
   {
      if(fixingDatesNode->Attribute("href") || fixingDatesNode->Attribute("id"))
      {
          if(fixingDatesNode->Attribute("id"))
          {
             fixingDatesIDRef_ = fixingDatesNode->Attribute("id");
             fixingDates_ = boost::shared_ptr<RelativeDateOffset>(new RelativeDateOffset(fixingDatesNode));
             fixingDates_->setID(fixingDatesIDRef_);
             IDManager::instance().setID(fixingDatesIDRef_,fixingDates_);
          }
          else if(fixingDatesNode->Attribute("href")) { fixingDatesIDRef_ = fixingDatesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fixingDates_ = boost::shared_ptr<RelativeDateOffset>(new RelativeDateOffset(fixingDatesNode));}
   }

   //rateCutOffDaysOffsetNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* rateCutOffDaysOffsetNode = xmlNode->FirstChildElement("rateCutOffDaysOffset");

   if(rateCutOffDaysOffsetNode){rateCutOffDaysOffsetIsNull_ = false;}
   else{rateCutOffDaysOffsetIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- rateCutOffDaysOffsetNode , address : " << rateCutOffDaysOffsetNode << std::endl;
   #endif
   if(rateCutOffDaysOffsetNode)
   {
      if(rateCutOffDaysOffsetNode->Attribute("href") || rateCutOffDaysOffsetNode->Attribute("id"))
      {
          if(rateCutOffDaysOffsetNode->Attribute("id"))
          {
             rateCutOffDaysOffsetIDRef_ = rateCutOffDaysOffsetNode->Attribute("id");
             rateCutOffDaysOffset_ = boost::shared_ptr<Offset>(new Offset(rateCutOffDaysOffsetNode));
             rateCutOffDaysOffset_->setID(rateCutOffDaysOffsetIDRef_);
             IDManager::instance().setID(rateCutOffDaysOffsetIDRef_,rateCutOffDaysOffset_);
          }
          else if(rateCutOffDaysOffsetNode->Attribute("href")) { rateCutOffDaysOffsetIDRef_ = rateCutOffDaysOffsetNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { rateCutOffDaysOffset_ = boost::shared_ptr<Offset>(new Offset(rateCutOffDaysOffsetNode));}
   }

   //resetFrequencyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* resetFrequencyNode = xmlNode->FirstChildElement("resetFrequency");

   if(resetFrequencyNode){resetFrequencyIsNull_ = false;}
   else{resetFrequencyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- resetFrequencyNode , address : " << resetFrequencyNode << std::endl;
   #endif
   if(resetFrequencyNode)
   {
      if(resetFrequencyNode->Attribute("href") || resetFrequencyNode->Attribute("id"))
      {
          if(resetFrequencyNode->Attribute("id"))
          {
             resetFrequencyIDRef_ = resetFrequencyNode->Attribute("id");
             resetFrequency_ = boost::shared_ptr<ResetFrequency>(new ResetFrequency(resetFrequencyNode));
             resetFrequency_->setID(resetFrequencyIDRef_);
             IDManager::instance().setID(resetFrequencyIDRef_,resetFrequency_);
          }
          else if(resetFrequencyNode->Attribute("href")) { resetFrequencyIDRef_ = resetFrequencyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { resetFrequency_ = boost::shared_ptr<ResetFrequency>(new ResetFrequency(resetFrequencyNode));}
   }

   //resetDatesAdjustmentsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* resetDatesAdjustmentsNode = xmlNode->FirstChildElement("resetDatesAdjustments");

   if(resetDatesAdjustmentsNode){resetDatesAdjustmentsIsNull_ = false;}
   else{resetDatesAdjustmentsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- resetDatesAdjustmentsNode , address : " << resetDatesAdjustmentsNode << std::endl;
   #endif
   if(resetDatesAdjustmentsNode)
   {
      if(resetDatesAdjustmentsNode->Attribute("href") || resetDatesAdjustmentsNode->Attribute("id"))
      {
          if(resetDatesAdjustmentsNode->Attribute("id"))
          {
             resetDatesAdjustmentsIDRef_ = resetDatesAdjustmentsNode->Attribute("id");
             resetDatesAdjustments_ = boost::shared_ptr<BusinessDayAdjustments>(new BusinessDayAdjustments(resetDatesAdjustmentsNode));
             resetDatesAdjustments_->setID(resetDatesAdjustmentsIDRef_);
             IDManager::instance().setID(resetDatesAdjustmentsIDRef_,resetDatesAdjustments_);
          }
          else if(resetDatesAdjustmentsNode->Attribute("href")) { resetDatesAdjustmentsIDRef_ = resetDatesAdjustmentsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { resetDatesAdjustments_ = boost::shared_ptr<BusinessDayAdjustments>(new BusinessDayAdjustments(resetDatesAdjustmentsNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<CalculationPeriodDatesReference> ResetDates::getCalculationPeriodDatesReference()
{
   if(!this->calculationPeriodDatesReferenceIsNull_){
        if(calculationPeriodDatesReferenceIDRef_ != ""){
             return boost::shared_static_cast<CalculationPeriodDatesReference>(IDManager::instance().getID(calculationPeriodDatesReferenceIDRef_));
        }else{
             return this->calculationPeriodDatesReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CalculationPeriodDatesReference>();
   }
}
boost::shared_ptr<ResetRelativeToEnum> ResetDates::getResetRelativeTo()
{
   if(!this->resetRelativeToIsNull_){
        if(resetRelativeToIDRef_ != ""){
             return boost::shared_static_cast<ResetRelativeToEnum>(IDManager::instance().getID(resetRelativeToIDRef_));
        }else{
             return this->resetRelativeTo_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ResetRelativeToEnum>();
   }
}
boost::shared_ptr<RelativeDateOffset> ResetDates::getInitialFixingDate()
{
   if(!this->initialFixingDateIsNull_){
        if(initialFixingDateIDRef_ != ""){
             return boost::shared_static_cast<RelativeDateOffset>(IDManager::instance().getID(initialFixingDateIDRef_));
        }else{
             return this->initialFixingDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<RelativeDateOffset>();
   }
}
boost::shared_ptr<RelativeDateOffset> ResetDates::getFixingDates()
{
   if(!this->fixingDatesIsNull_){
        if(fixingDatesIDRef_ != ""){
             return boost::shared_static_cast<RelativeDateOffset>(IDManager::instance().getID(fixingDatesIDRef_));
        }else{
             return this->fixingDates_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<RelativeDateOffset>();
   }
}
boost::shared_ptr<Offset> ResetDates::getRateCutOffDaysOffset()
{
   if(!this->rateCutOffDaysOffsetIsNull_){
        if(rateCutOffDaysOffsetIDRef_ != ""){
             return boost::shared_static_cast<Offset>(IDManager::instance().getID(rateCutOffDaysOffsetIDRef_));
        }else{
             return this->rateCutOffDaysOffset_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Offset>();
   }
}
boost::shared_ptr<ResetFrequency> ResetDates::getResetFrequency()
{
   if(!this->resetFrequencyIsNull_){
        if(resetFrequencyIDRef_ != ""){
             return boost::shared_static_cast<ResetFrequency>(IDManager::instance().getID(resetFrequencyIDRef_));
        }else{
             return this->resetFrequency_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ResetFrequency>();
   }
}
boost::shared_ptr<BusinessDayAdjustments> ResetDates::getResetDatesAdjustments()
{
   if(!this->resetDatesAdjustmentsIsNull_){
        if(resetDatesAdjustmentsIDRef_ != ""){
             return boost::shared_static_cast<BusinessDayAdjustments>(IDManager::instance().getID(resetDatesAdjustmentsIDRef_));
        }else{
             return this->resetDatesAdjustments_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BusinessDayAdjustments>();
   }
}
}

