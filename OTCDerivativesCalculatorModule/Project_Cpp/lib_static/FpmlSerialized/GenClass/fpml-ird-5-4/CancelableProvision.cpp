// CancelableProvision.cpp 
#include "CancelableProvision.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CancelableProvision::CancelableProvision(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //buyerPartyReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* buyerPartyReferenceNode = xmlNode->FirstChildElement("buyerPartyReference");

   if(buyerPartyReferenceNode){buyerPartyReferenceIsNull_ = false;}
   else{buyerPartyReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- buyerPartyReferenceNode , address : " << buyerPartyReferenceNode << std::endl;
   #endif
   if(buyerPartyReferenceNode)
   {
      if(buyerPartyReferenceNode->Attribute("href") || buyerPartyReferenceNode->Attribute("id"))
      {
          if(buyerPartyReferenceNode->Attribute("id"))
          {
             buyerPartyReferenceIDRef_ = buyerPartyReferenceNode->Attribute("id");
             buyerPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(buyerPartyReferenceNode));
             buyerPartyReference_->setID(buyerPartyReferenceIDRef_);
             IDManager::instance().setID(buyerPartyReferenceIDRef_,buyerPartyReference_);
          }
          else if(buyerPartyReferenceNode->Attribute("href")) { buyerPartyReferenceIDRef_ = buyerPartyReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { buyerPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(buyerPartyReferenceNode));}
   }

   //buyerAccountReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* buyerAccountReferenceNode = xmlNode->FirstChildElement("buyerAccountReference");

   if(buyerAccountReferenceNode){buyerAccountReferenceIsNull_ = false;}
   else{buyerAccountReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- buyerAccountReferenceNode , address : " << buyerAccountReferenceNode << std::endl;
   #endif
   if(buyerAccountReferenceNode)
   {
      if(buyerAccountReferenceNode->Attribute("href") || buyerAccountReferenceNode->Attribute("id"))
      {
          if(buyerAccountReferenceNode->Attribute("id"))
          {
             buyerAccountReferenceIDRef_ = buyerAccountReferenceNode->Attribute("id");
             buyerAccountReference_ = boost::shared_ptr<AccountReference>(new AccountReference(buyerAccountReferenceNode));
             buyerAccountReference_->setID(buyerAccountReferenceIDRef_);
             IDManager::instance().setID(buyerAccountReferenceIDRef_,buyerAccountReference_);
          }
          else if(buyerAccountReferenceNode->Attribute("href")) { buyerAccountReferenceIDRef_ = buyerAccountReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { buyerAccountReference_ = boost::shared_ptr<AccountReference>(new AccountReference(buyerAccountReferenceNode));}
   }

   //sellerPartyReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* sellerPartyReferenceNode = xmlNode->FirstChildElement("sellerPartyReference");

   if(sellerPartyReferenceNode){sellerPartyReferenceIsNull_ = false;}
   else{sellerPartyReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- sellerPartyReferenceNode , address : " << sellerPartyReferenceNode << std::endl;
   #endif
   if(sellerPartyReferenceNode)
   {
      if(sellerPartyReferenceNode->Attribute("href") || sellerPartyReferenceNode->Attribute("id"))
      {
          if(sellerPartyReferenceNode->Attribute("id"))
          {
             sellerPartyReferenceIDRef_ = sellerPartyReferenceNode->Attribute("id");
             sellerPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(sellerPartyReferenceNode));
             sellerPartyReference_->setID(sellerPartyReferenceIDRef_);
             IDManager::instance().setID(sellerPartyReferenceIDRef_,sellerPartyReference_);
          }
          else if(sellerPartyReferenceNode->Attribute("href")) { sellerPartyReferenceIDRef_ = sellerPartyReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { sellerPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(sellerPartyReferenceNode));}
   }

   //sellerAccountReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* sellerAccountReferenceNode = xmlNode->FirstChildElement("sellerAccountReference");

   if(sellerAccountReferenceNode){sellerAccountReferenceIsNull_ = false;}
   else{sellerAccountReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- sellerAccountReferenceNode , address : " << sellerAccountReferenceNode << std::endl;
   #endif
   if(sellerAccountReferenceNode)
   {
      if(sellerAccountReferenceNode->Attribute("href") || sellerAccountReferenceNode->Attribute("id"))
      {
          if(sellerAccountReferenceNode->Attribute("id"))
          {
             sellerAccountReferenceIDRef_ = sellerAccountReferenceNode->Attribute("id");
             sellerAccountReference_ = boost::shared_ptr<AccountReference>(new AccountReference(sellerAccountReferenceNode));
             sellerAccountReference_->setID(sellerAccountReferenceIDRef_);
             IDManager::instance().setID(sellerAccountReferenceIDRef_,sellerAccountReference_);
          }
          else if(sellerAccountReferenceNode->Attribute("href")) { sellerAccountReferenceIDRef_ = sellerAccountReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { sellerAccountReference_ = boost::shared_ptr<AccountReference>(new AccountReference(sellerAccountReferenceNode));}
   }

   //exerciseNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* exerciseNode = xmlNode->FirstChildElement("exercise");

   if(exerciseNode){exerciseIsNull_ = false;}
   else{exerciseIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- exerciseNode , address : " << exerciseNode << std::endl;
   #endif
   if(exerciseNode)
   {
      if(exerciseNode->Attribute("href") || exerciseNode->Attribute("id"))
      {
          if(exerciseNode->Attribute("id"))
          {
             exerciseIDRef_ = exerciseNode->Attribute("id");
             exercise_ = boost::shared_ptr<Exercise>(new Exercise(exerciseNode));
             exercise_->setID(exerciseIDRef_);
             IDManager::instance().setID(exerciseIDRef_,exercise_);
          }
          else if(exerciseNode->Attribute("href")) { exerciseIDRef_ = exerciseNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { exercise_ = boost::shared_ptr<Exercise>(new Exercise(exerciseNode));}
   }

   //americanExerciseNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* americanExerciseNode = xmlNode->FirstChildElement("americanExercise");

   if(americanExerciseNode){americanExerciseIsNull_ = false;}
   else{americanExerciseIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- americanExerciseNode , address : " << americanExerciseNode << std::endl;
   #endif
   if(americanExerciseNode)
   {
      if(americanExerciseNode->Attribute("href") || americanExerciseNode->Attribute("id"))
      {
          if(americanExerciseNode->Attribute("id"))
          {
             americanExerciseIDRef_ = americanExerciseNode->Attribute("id");
             americanExercise_ = boost::shared_ptr<AmericanExercise>(new AmericanExercise(americanExerciseNode));
             americanExercise_->setID(americanExerciseIDRef_);
             IDManager::instance().setID(americanExerciseIDRef_,americanExercise_);
          }
          else if(americanExerciseNode->Attribute("href")) { americanExerciseIDRef_ = americanExerciseNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { americanExercise_ = boost::shared_ptr<AmericanExercise>(new AmericanExercise(americanExerciseNode));}
   }

   //bermudaExerciseNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* bermudaExerciseNode = xmlNode->FirstChildElement("bermudaExercise");

   if(bermudaExerciseNode){bermudaExerciseIsNull_ = false;}
   else{bermudaExerciseIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- bermudaExerciseNode , address : " << bermudaExerciseNode << std::endl;
   #endif
   if(bermudaExerciseNode)
   {
      if(bermudaExerciseNode->Attribute("href") || bermudaExerciseNode->Attribute("id"))
      {
          if(bermudaExerciseNode->Attribute("id"))
          {
             bermudaExerciseIDRef_ = bermudaExerciseNode->Attribute("id");
             bermudaExercise_ = boost::shared_ptr<BermudaExercise>(new BermudaExercise(bermudaExerciseNode));
             bermudaExercise_->setID(bermudaExerciseIDRef_);
             IDManager::instance().setID(bermudaExerciseIDRef_,bermudaExercise_);
          }
          else if(bermudaExerciseNode->Attribute("href")) { bermudaExerciseIDRef_ = bermudaExerciseNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { bermudaExercise_ = boost::shared_ptr<BermudaExercise>(new BermudaExercise(bermudaExerciseNode));}
   }

   //europeanExerciseNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* europeanExerciseNode = xmlNode->FirstChildElement("europeanExercise");

   if(europeanExerciseNode){europeanExerciseIsNull_ = false;}
   else{europeanExerciseIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- europeanExerciseNode , address : " << europeanExerciseNode << std::endl;
   #endif
   if(europeanExerciseNode)
   {
      if(europeanExerciseNode->Attribute("href") || europeanExerciseNode->Attribute("id"))
      {
          if(europeanExerciseNode->Attribute("id"))
          {
             europeanExerciseIDRef_ = europeanExerciseNode->Attribute("id");
             europeanExercise_ = boost::shared_ptr<EuropeanExercise>(new EuropeanExercise(europeanExerciseNode));
             europeanExercise_->setID(europeanExerciseIDRef_);
             IDManager::instance().setID(europeanExerciseIDRef_,europeanExercise_);
          }
          else if(europeanExerciseNode->Attribute("href")) { europeanExerciseIDRef_ = europeanExerciseNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { europeanExercise_ = boost::shared_ptr<EuropeanExercise>(new EuropeanExercise(europeanExerciseNode));}
   }

   //exerciseNoticeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* exerciseNoticeNode = xmlNode->FirstChildElement("exerciseNotice");

   if(exerciseNoticeNode){exerciseNoticeIsNull_ = false;}
   else{exerciseNoticeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- exerciseNoticeNode , address : " << exerciseNoticeNode << std::endl;
   #endif
   if(exerciseNoticeNode)
   {
      if(exerciseNoticeNode->Attribute("href") || exerciseNoticeNode->Attribute("id"))
      {
          if(exerciseNoticeNode->Attribute("id"))
          {
             exerciseNoticeIDRef_ = exerciseNoticeNode->Attribute("id");
             exerciseNotice_ = boost::shared_ptr<ExerciseNotice>(new ExerciseNotice(exerciseNoticeNode));
             exerciseNotice_->setID(exerciseNoticeIDRef_);
             IDManager::instance().setID(exerciseNoticeIDRef_,exerciseNotice_);
          }
          else if(exerciseNoticeNode->Attribute("href")) { exerciseNoticeIDRef_ = exerciseNoticeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { exerciseNotice_ = boost::shared_ptr<ExerciseNotice>(new ExerciseNotice(exerciseNoticeNode));}
   }

   //followUpConfirmationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* followUpConfirmationNode = xmlNode->FirstChildElement("followUpConfirmation");

   if(followUpConfirmationNode){followUpConfirmationIsNull_ = false;}
   else{followUpConfirmationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- followUpConfirmationNode , address : " << followUpConfirmationNode << std::endl;
   #endif
   if(followUpConfirmationNode)
   {
      if(followUpConfirmationNode->Attribute("href") || followUpConfirmationNode->Attribute("id"))
      {
          if(followUpConfirmationNode->Attribute("id"))
          {
             followUpConfirmationIDRef_ = followUpConfirmationNode->Attribute("id");
             followUpConfirmation_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(followUpConfirmationNode));
             followUpConfirmation_->setID(followUpConfirmationIDRef_);
             IDManager::instance().setID(followUpConfirmationIDRef_,followUpConfirmation_);
          }
          else if(followUpConfirmationNode->Attribute("href")) { followUpConfirmationIDRef_ = followUpConfirmationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { followUpConfirmation_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(followUpConfirmationNode));}
   }

   //cancelableProvisionAdjustedDatesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* cancelableProvisionAdjustedDatesNode = xmlNode->FirstChildElement("cancelableProvisionAdjustedDates");

   if(cancelableProvisionAdjustedDatesNode){cancelableProvisionAdjustedDatesIsNull_ = false;}
   else{cancelableProvisionAdjustedDatesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- cancelableProvisionAdjustedDatesNode , address : " << cancelableProvisionAdjustedDatesNode << std::endl;
   #endif
   if(cancelableProvisionAdjustedDatesNode)
   {
      if(cancelableProvisionAdjustedDatesNode->Attribute("href") || cancelableProvisionAdjustedDatesNode->Attribute("id"))
      {
          if(cancelableProvisionAdjustedDatesNode->Attribute("id"))
          {
             cancelableProvisionAdjustedDatesIDRef_ = cancelableProvisionAdjustedDatesNode->Attribute("id");
             cancelableProvisionAdjustedDates_ = boost::shared_ptr<CancelableProvisionAdjustedDates>(new CancelableProvisionAdjustedDates(cancelableProvisionAdjustedDatesNode));
             cancelableProvisionAdjustedDates_->setID(cancelableProvisionAdjustedDatesIDRef_);
             IDManager::instance().setID(cancelableProvisionAdjustedDatesIDRef_,cancelableProvisionAdjustedDates_);
          }
          else if(cancelableProvisionAdjustedDatesNode->Attribute("href")) { cancelableProvisionAdjustedDatesIDRef_ = cancelableProvisionAdjustedDatesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { cancelableProvisionAdjustedDates_ = boost::shared_ptr<CancelableProvisionAdjustedDates>(new CancelableProvisionAdjustedDates(cancelableProvisionAdjustedDatesNode));}
   }

   //finalCalculationPeriodDateAdjustmentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* finalCalculationPeriodDateAdjustmentNode = xmlNode->FirstChildElement("finalCalculationPeriodDateAdjustment");

   if(finalCalculationPeriodDateAdjustmentNode){finalCalculationPeriodDateAdjustmentIsNull_ = false;}
   else{finalCalculationPeriodDateAdjustmentIsNull_ = true;}

   if(finalCalculationPeriodDateAdjustmentNode)
   {
      for(finalCalculationPeriodDateAdjustmentNode; finalCalculationPeriodDateAdjustmentNode; finalCalculationPeriodDateAdjustmentNode = finalCalculationPeriodDateAdjustmentNode->NextSiblingElement("finalCalculationPeriodDateAdjustment")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- finalCalculationPeriodDateAdjustmentNode , address : " << finalCalculationPeriodDateAdjustmentNode << std::endl;
          #endif
          if(finalCalculationPeriodDateAdjustmentNode->Attribute("href") || finalCalculationPeriodDateAdjustmentNode->Attribute("id"))
          {
              if(finalCalculationPeriodDateAdjustmentNode->Attribute("id"))
              {
                  finalCalculationPeriodDateAdjustmentIDRef_ = finalCalculationPeriodDateAdjustmentNode->Attribute("id");
                  finalCalculationPeriodDateAdjustment_.push_back(boost::shared_ptr<FinalCalculationPeriodDateAdjustment>(new FinalCalculationPeriodDateAdjustment(finalCalculationPeriodDateAdjustmentNode)));
                  finalCalculationPeriodDateAdjustment_.back()->setID(finalCalculationPeriodDateAdjustmentIDRef_);
                  IDManager::instance().setID(finalCalculationPeriodDateAdjustmentIDRef_, finalCalculationPeriodDateAdjustment_.back());
              }
              else if(finalCalculationPeriodDateAdjustmentNode->Attribute("href")) { finalCalculationPeriodDateAdjustmentIDRef_ = finalCalculationPeriodDateAdjustmentNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { finalCalculationPeriodDateAdjustment_.push_back(boost::shared_ptr<FinalCalculationPeriodDateAdjustment>(new FinalCalculationPeriodDateAdjustment(finalCalculationPeriodDateAdjustmentNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- finalCalculationPeriodDateAdjustmentNode , address : " << finalCalculationPeriodDateAdjustmentNode << std::endl;
       #endif
   }

   //initialFeeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* initialFeeNode = xmlNode->FirstChildElement("initialFee");

   if(initialFeeNode){initialFeeIsNull_ = false;}
   else{initialFeeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- initialFeeNode , address : " << initialFeeNode << std::endl;
   #endif
   if(initialFeeNode)
   {
      if(initialFeeNode->Attribute("href") || initialFeeNode->Attribute("id"))
      {
          if(initialFeeNode->Attribute("id"))
          {
             initialFeeIDRef_ = initialFeeNode->Attribute("id");
             initialFee_ = boost::shared_ptr<SimplePayment>(new SimplePayment(initialFeeNode));
             initialFee_->setID(initialFeeIDRef_);
             IDManager::instance().setID(initialFeeIDRef_,initialFee_);
          }
          else if(initialFeeNode->Attribute("href")) { initialFeeIDRef_ = initialFeeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { initialFee_ = boost::shared_ptr<SimplePayment>(new SimplePayment(initialFeeNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PartyReference> CancelableProvision::getBuyerPartyReference()
{
   if(!this->buyerPartyReferenceIsNull_){
        if(buyerPartyReferenceIDRef_ != ""){
             return boost::shared_static_cast<PartyReference>(IDManager::instance().getID(buyerPartyReferenceIDRef_));
        }else{
             return this->buyerPartyReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyReference>();
   }
}
boost::shared_ptr<AccountReference> CancelableProvision::getBuyerAccountReference()
{
   if(!this->buyerAccountReferenceIsNull_){
        if(buyerAccountReferenceIDRef_ != ""){
             return boost::shared_static_cast<AccountReference>(IDManager::instance().getID(buyerAccountReferenceIDRef_));
        }else{
             return this->buyerAccountReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AccountReference>();
   }
}
boost::shared_ptr<PartyReference> CancelableProvision::getSellerPartyReference()
{
   if(!this->sellerPartyReferenceIsNull_){
        if(sellerPartyReferenceIDRef_ != ""){
             return boost::shared_static_cast<PartyReference>(IDManager::instance().getID(sellerPartyReferenceIDRef_));
        }else{
             return this->sellerPartyReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyReference>();
   }
}
boost::shared_ptr<AccountReference> CancelableProvision::getSellerAccountReference()
{
   if(!this->sellerAccountReferenceIsNull_){
        if(sellerAccountReferenceIDRef_ != ""){
             return boost::shared_static_cast<AccountReference>(IDManager::instance().getID(sellerAccountReferenceIDRef_));
        }else{
             return this->sellerAccountReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AccountReference>();
   }
}
boost::shared_ptr<Exercise> CancelableProvision::getExercise()
{
   if(!this->exerciseIsNull_){
        if(exerciseIDRef_ != ""){
             return boost::shared_static_cast<Exercise>(IDManager::instance().getID(exerciseIDRef_));
        }else{
             return this->exercise_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Exercise>();
   }
}
boost::shared_ptr<AmericanExercise> CancelableProvision::getAmericanExercise()
{
   if(!this->americanExerciseIsNull_){
        if(americanExerciseIDRef_ != ""){
             return boost::shared_static_cast<AmericanExercise>(IDManager::instance().getID(americanExerciseIDRef_));
        }else{
             return this->americanExercise_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AmericanExercise>();
   }
}
boost::shared_ptr<BermudaExercise> CancelableProvision::getBermudaExercise()
{
   if(!this->bermudaExerciseIsNull_){
        if(bermudaExerciseIDRef_ != ""){
             return boost::shared_static_cast<BermudaExercise>(IDManager::instance().getID(bermudaExerciseIDRef_));
        }else{
             return this->bermudaExercise_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BermudaExercise>();
   }
}
boost::shared_ptr<EuropeanExercise> CancelableProvision::getEuropeanExercise()
{
   if(!this->europeanExerciseIsNull_){
        if(europeanExerciseIDRef_ != ""){
             return boost::shared_static_cast<EuropeanExercise>(IDManager::instance().getID(europeanExerciseIDRef_));
        }else{
             return this->europeanExercise_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EuropeanExercise>();
   }
}
boost::shared_ptr<ExerciseNotice> CancelableProvision::getExerciseNotice()
{
   if(!this->exerciseNoticeIsNull_){
        if(exerciseNoticeIDRef_ != ""){
             return boost::shared_static_cast<ExerciseNotice>(IDManager::instance().getID(exerciseNoticeIDRef_));
        }else{
             return this->exerciseNotice_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ExerciseNotice>();
   }
}
boost::shared_ptr<XsdTypeBoolean> CancelableProvision::getFollowUpConfirmation()
{
   if(!this->followUpConfirmationIsNull_){
        if(followUpConfirmationIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(followUpConfirmationIDRef_));
        }else{
             return this->followUpConfirmation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<CancelableProvisionAdjustedDates> CancelableProvision::getCancelableProvisionAdjustedDates()
{
   if(!this->cancelableProvisionAdjustedDatesIsNull_){
        if(cancelableProvisionAdjustedDatesIDRef_ != ""){
             return boost::shared_static_cast<CancelableProvisionAdjustedDates>(IDManager::instance().getID(cancelableProvisionAdjustedDatesIDRef_));
        }else{
             return this->cancelableProvisionAdjustedDates_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CancelableProvisionAdjustedDates>();
   }
}
std::vector<boost::shared_ptr<FinalCalculationPeriodDateAdjustment>> CancelableProvision::getFinalCalculationPeriodDateAdjustment()
{
   if(!this->finalCalculationPeriodDateAdjustmentIsNull_){
        if(finalCalculationPeriodDateAdjustmentIDRef_ != ""){
             return this->finalCalculationPeriodDateAdjustment_;
        }else{
             return this->finalCalculationPeriodDateAdjustment_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<FinalCalculationPeriodDateAdjustment>>();
   }
}
boost::shared_ptr<SimplePayment> CancelableProvision::getInitialFee()
{
   if(!this->initialFeeIsNull_){
        if(initialFeeIDRef_ != ""){
             return boost::shared_static_cast<SimplePayment>(IDManager::instance().getID(initialFeeIDRef_));
        }else{
             return this->initialFee_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<SimplePayment>();
   }
}
}

