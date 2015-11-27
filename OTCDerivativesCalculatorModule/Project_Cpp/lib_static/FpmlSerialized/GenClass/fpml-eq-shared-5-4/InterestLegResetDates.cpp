// InterestLegResetDates.cpp 
#include "InterestLegResetDates.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

InterestLegResetDates::InterestLegResetDates(TiXmlNode* xmlNode)
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
             calculationPeriodDatesReference_ = boost::shared_ptr<InterestLegCalculationPeriodDatesReference>(new InterestLegCalculationPeriodDatesReference(calculationPeriodDatesReferenceNode));
             calculationPeriodDatesReference_->setID(calculationPeriodDatesReferenceIDRef_);
             IDManager::instance().setID(calculationPeriodDatesReferenceIDRef_,calculationPeriodDatesReference_);
          }
          else if(calculationPeriodDatesReferenceNode->Attribute("href")) { calculationPeriodDatesReferenceIDRef_ = calculationPeriodDatesReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { calculationPeriodDatesReference_ = boost::shared_ptr<InterestLegCalculationPeriodDatesReference>(new InterestLegCalculationPeriodDatesReference(calculationPeriodDatesReferenceNode));}
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
             fixingDates_ = boost::shared_ptr<AdjustableDatesOrRelativeDateOffset>(new AdjustableDatesOrRelativeDateOffset(fixingDatesNode));
             fixingDates_->setID(fixingDatesIDRef_);
             IDManager::instance().setID(fixingDatesIDRef_,fixingDates_);
          }
          else if(fixingDatesNode->Attribute("href")) { fixingDatesIDRef_ = fixingDatesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fixingDates_ = boost::shared_ptr<AdjustableDatesOrRelativeDateOffset>(new AdjustableDatesOrRelativeDateOffset(fixingDatesNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<InterestLegCalculationPeriodDatesReference> InterestLegResetDates::getCalculationPeriodDatesReference()
{
   if(!this->calculationPeriodDatesReferenceIsNull_){
        if(calculationPeriodDatesReferenceIDRef_ != ""){
             return boost::shared_static_cast<InterestLegCalculationPeriodDatesReference>(IDManager::instance().getID(calculationPeriodDatesReferenceIDRef_));
        }else{
             return this->calculationPeriodDatesReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<InterestLegCalculationPeriodDatesReference>();
   }
}
boost::shared_ptr<ResetRelativeToEnum> InterestLegResetDates::getResetRelativeTo()
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
boost::shared_ptr<ResetFrequency> InterestLegResetDates::getResetFrequency()
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
boost::shared_ptr<RelativeDateOffset> InterestLegResetDates::getInitialFixingDate()
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
boost::shared_ptr<AdjustableDatesOrRelativeDateOffset> InterestLegResetDates::getFixingDates()
{
   if(!this->fixingDatesIsNull_){
        if(fixingDatesIDRef_ != ""){
             return boost::shared_static_cast<AdjustableDatesOrRelativeDateOffset>(IDManager::instance().getID(fixingDatesIDRef_));
        }else{
             return this->fixingDates_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableDatesOrRelativeDateOffset>();
   }
}
}

