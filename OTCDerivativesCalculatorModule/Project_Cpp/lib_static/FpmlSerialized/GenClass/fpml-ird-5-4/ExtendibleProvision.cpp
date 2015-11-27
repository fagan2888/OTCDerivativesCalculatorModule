// ExtendibleProvision.cpp 
#include "ExtendibleProvision.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ExtendibleProvision::ExtendibleProvision(TiXmlNode* xmlNode)
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

   //extendibleProvisionAdjustedDatesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* extendibleProvisionAdjustedDatesNode = xmlNode->FirstChildElement("extendibleProvisionAdjustedDates");

   if(extendibleProvisionAdjustedDatesNode){extendibleProvisionAdjustedDatesIsNull_ = false;}
   else{extendibleProvisionAdjustedDatesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- extendibleProvisionAdjustedDatesNode , address : " << extendibleProvisionAdjustedDatesNode << std::endl;
   #endif
   if(extendibleProvisionAdjustedDatesNode)
   {
      if(extendibleProvisionAdjustedDatesNode->Attribute("href") || extendibleProvisionAdjustedDatesNode->Attribute("id"))
      {
          if(extendibleProvisionAdjustedDatesNode->Attribute("id"))
          {
             extendibleProvisionAdjustedDatesIDRef_ = extendibleProvisionAdjustedDatesNode->Attribute("id");
             extendibleProvisionAdjustedDates_ = boost::shared_ptr<ExtendibleProvisionAdjustedDates>(new ExtendibleProvisionAdjustedDates(extendibleProvisionAdjustedDatesNode));
             extendibleProvisionAdjustedDates_->setID(extendibleProvisionAdjustedDatesIDRef_);
             IDManager::instance().setID(extendibleProvisionAdjustedDatesIDRef_,extendibleProvisionAdjustedDates_);
          }
          else if(extendibleProvisionAdjustedDatesNode->Attribute("href")) { extendibleProvisionAdjustedDatesIDRef_ = extendibleProvisionAdjustedDatesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { extendibleProvisionAdjustedDates_ = boost::shared_ptr<ExtendibleProvisionAdjustedDates>(new ExtendibleProvisionAdjustedDates(extendibleProvisionAdjustedDatesNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PartyReference> ExtendibleProvision::getBuyerPartyReference()
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
boost::shared_ptr<AccountReference> ExtendibleProvision::getBuyerAccountReference()
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
boost::shared_ptr<PartyReference> ExtendibleProvision::getSellerPartyReference()
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
boost::shared_ptr<AccountReference> ExtendibleProvision::getSellerAccountReference()
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
boost::shared_ptr<Exercise> ExtendibleProvision::getExercise()
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
boost::shared_ptr<AmericanExercise> ExtendibleProvision::getAmericanExercise()
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
boost::shared_ptr<BermudaExercise> ExtendibleProvision::getBermudaExercise()
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
boost::shared_ptr<EuropeanExercise> ExtendibleProvision::getEuropeanExercise()
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
boost::shared_ptr<ExerciseNotice> ExtendibleProvision::getExerciseNotice()
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
boost::shared_ptr<XsdTypeBoolean> ExtendibleProvision::getFollowUpConfirmation()
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
boost::shared_ptr<ExtendibleProvisionAdjustedDates> ExtendibleProvision::getExtendibleProvisionAdjustedDates()
{
   if(!this->extendibleProvisionAdjustedDatesIsNull_){
        if(extendibleProvisionAdjustedDatesIDRef_ != ""){
             return boost::shared_static_cast<ExtendibleProvisionAdjustedDates>(IDManager::instance().getID(extendibleProvisionAdjustedDatesIDRef_));
        }else{
             return this->extendibleProvisionAdjustedDates_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ExtendibleProvisionAdjustedDates>();
   }
}
}

