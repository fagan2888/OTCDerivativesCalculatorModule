// ClearingConfirmed.cpp 
#include "ClearingConfirmed.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ClearingConfirmed::ClearingConfirmed(TiXmlNode* xmlNode)
: NotificationMessage(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //compressionActivityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* compressionActivityNode = xmlNode->FirstChildElement("compressionActivity");

   if(compressionActivityNode){compressionActivityIsNull_ = false;}
   else{compressionActivityIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- compressionActivityNode , address : " << compressionActivityNode << std::endl;
   #endif
   if(compressionActivityNode)
   {
      if(compressionActivityNode->Attribute("href") || compressionActivityNode->Attribute("id"))
      {
          if(compressionActivityNode->Attribute("id"))
          {
             compressionActivityIDRef_ = compressionActivityNode->Attribute("id");
             compressionActivity_ = boost::shared_ptr<CompressionActivity>(new CompressionActivity(compressionActivityNode));
             compressionActivity_->setID(compressionActivityIDRef_);
             IDManager::instance().setID(compressionActivityIDRef_,compressionActivity_);
          }
          else if(compressionActivityNode->Attribute("href")) { compressionActivityIDRef_ = compressionActivityNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { compressionActivity_ = boost::shared_ptr<CompressionActivity>(new CompressionActivity(compressionActivityNode));}
   }

   //portfolioReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* portfolioReferenceNode = xmlNode->FirstChildElement("portfolioReference");

   if(portfolioReferenceNode){portfolioReferenceIsNull_ = false;}
   else{portfolioReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- portfolioReferenceNode , address : " << portfolioReferenceNode << std::endl;
   #endif
   if(portfolioReferenceNode)
   {
      if(portfolioReferenceNode->Attribute("href") || portfolioReferenceNode->Attribute("id"))
      {
          if(portfolioReferenceNode->Attribute("id"))
          {
             portfolioReferenceIDRef_ = portfolioReferenceNode->Attribute("id");
             portfolioReference_ = boost::shared_ptr<PortfolioReference>(new PortfolioReference(portfolioReferenceNode));
             portfolioReference_->setID(portfolioReferenceIDRef_);
             IDManager::instance().setID(portfolioReferenceIDRef_,portfolioReference_);
          }
          else if(portfolioReferenceNode->Attribute("href")) { portfolioReferenceIDRef_ = portfolioReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { portfolioReference_ = boost::shared_ptr<PortfolioReference>(new PortfolioReference(portfolioReferenceNode));}
   }

   //originatingEventNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* originatingEventNode = xmlNode->FirstChildElement("originatingEvent");

   if(originatingEventNode){originatingEventIsNull_ = false;}
   else{originatingEventIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- originatingEventNode , address : " << originatingEventNode << std::endl;
   #endif
   if(originatingEventNode)
   {
      if(originatingEventNode->Attribute("href") || originatingEventNode->Attribute("id"))
      {
          if(originatingEventNode->Attribute("id"))
          {
             originatingEventIDRef_ = originatingEventNode->Attribute("id");
             originatingEvent_ = boost::shared_ptr<OriginatingEvent>(new OriginatingEvent(originatingEventNode));
             originatingEvent_->setID(originatingEventIDRef_);
             IDManager::instance().setID(originatingEventIDRef_,originatingEvent_);
          }
          else if(originatingEventNode->Attribute("href")) { originatingEventIDRef_ = originatingEventNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { originatingEvent_ = boost::shared_ptr<OriginatingEvent>(new OriginatingEvent(originatingEventNode));}
   }

   //tradeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* tradeNode = xmlNode->FirstChildElement("trade");

   if(tradeNode){tradeIsNull_ = false;}
   else{tradeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- tradeNode , address : " << tradeNode << std::endl;
   #endif
   if(tradeNode)
   {
      if(tradeNode->Attribute("href") || tradeNode->Attribute("id"))
      {
          if(tradeNode->Attribute("id"))
          {
             tradeIDRef_ = tradeNode->Attribute("id");
             trade_ = boost::shared_ptr<Trade>(new Trade(tradeNode));
             trade_->setID(tradeIDRef_);
             IDManager::instance().setID(tradeIDRef_,trade_);
          }
          else if(tradeNode->Attribute("href")) { tradeIDRef_ = tradeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { trade_ = boost::shared_ptr<Trade>(new Trade(tradeNode));}
   }

   //amendmentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* amendmentNode = xmlNode->FirstChildElement("amendment");

   if(amendmentNode){amendmentIsNull_ = false;}
   else{amendmentIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- amendmentNode , address : " << amendmentNode << std::endl;
   #endif
   if(amendmentNode)
   {
      if(amendmentNode->Attribute("href") || amendmentNode->Attribute("id"))
      {
          if(amendmentNode->Attribute("id"))
          {
             amendmentIDRef_ = amendmentNode->Attribute("id");
             amendment_ = boost::shared_ptr<TradeAmendmentContent>(new TradeAmendmentContent(amendmentNode));
             amendment_->setID(amendmentIDRef_);
             IDManager::instance().setID(amendmentIDRef_,amendment_);
          }
          else if(amendmentNode->Attribute("href")) { amendmentIDRef_ = amendmentNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { amendment_ = boost::shared_ptr<TradeAmendmentContent>(new TradeAmendmentContent(amendmentNode));}
   }

   //increaseNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* increaseNode = xmlNode->FirstChildElement("increase");

   if(increaseNode){increaseIsNull_ = false;}
   else{increaseIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- increaseNode , address : " << increaseNode << std::endl;
   #endif
   if(increaseNode)
   {
      if(increaseNode->Attribute("href") || increaseNode->Attribute("id"))
      {
          if(increaseNode->Attribute("id"))
          {
             increaseIDRef_ = increaseNode->Attribute("id");
             increase_ = boost::shared_ptr<TradeNotionalChange>(new TradeNotionalChange(increaseNode));
             increase_->setID(increaseIDRef_);
             IDManager::instance().setID(increaseIDRef_,increase_);
          }
          else if(increaseNode->Attribute("href")) { increaseIDRef_ = increaseNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { increase_ = boost::shared_ptr<TradeNotionalChange>(new TradeNotionalChange(increaseNode));}
   }

   //terminatingEventNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* terminatingEventNode = xmlNode->FirstChildElement("terminatingEvent");

   if(terminatingEventNode){terminatingEventIsNull_ = false;}
   else{terminatingEventIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- terminatingEventNode , address : " << terminatingEventNode << std::endl;
   #endif
   if(terminatingEventNode)
   {
      if(terminatingEventNode->Attribute("href") || terminatingEventNode->Attribute("id"))
      {
          if(terminatingEventNode->Attribute("id"))
          {
             terminatingEventIDRef_ = terminatingEventNode->Attribute("id");
             terminatingEvent_ = boost::shared_ptr<TerminatingEvent>(new TerminatingEvent(terminatingEventNode));
             terminatingEvent_->setID(terminatingEventIDRef_);
             IDManager::instance().setID(terminatingEventIDRef_,terminatingEvent_);
          }
          else if(terminatingEventNode->Attribute("href")) { terminatingEventIDRef_ = terminatingEventNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { terminatingEvent_ = boost::shared_ptr<TerminatingEvent>(new TerminatingEvent(terminatingEventNode));}
   }

   //terminationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* terminationNode = xmlNode->FirstChildElement("termination");

   if(terminationNode){terminationIsNull_ = false;}
   else{terminationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- terminationNode , address : " << terminationNode << std::endl;
   #endif
   if(terminationNode)
   {
      if(terminationNode->Attribute("href") || terminationNode->Attribute("id"))
      {
          if(terminationNode->Attribute("id"))
          {
             terminationIDRef_ = terminationNode->Attribute("id");
             termination_ = boost::shared_ptr<TradeNotionalChange>(new TradeNotionalChange(terminationNode));
             termination_->setID(terminationIDRef_);
             IDManager::instance().setID(terminationIDRef_,termination_);
          }
          else if(terminationNode->Attribute("href")) { terminationIDRef_ = terminationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { termination_ = boost::shared_ptr<TradeNotionalChange>(new TradeNotionalChange(terminationNode));}
   }

   //novationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* novationNode = xmlNode->FirstChildElement("novation");

   if(novationNode){novationIsNull_ = false;}
   else{novationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- novationNode , address : " << novationNode << std::endl;
   #endif
   if(novationNode)
   {
      if(novationNode->Attribute("href") || novationNode->Attribute("id"))
      {
          if(novationNode->Attribute("id"))
          {
             novationIDRef_ = novationNode->Attribute("id");
             novation_ = boost::shared_ptr<TradeNovationContent>(new TradeNovationContent(novationNode));
             novation_->setID(novationIDRef_);
             IDManager::instance().setID(novationIDRef_,novation_);
          }
          else if(novationNode->Attribute("href")) { novationIDRef_ = novationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { novation_ = boost::shared_ptr<TradeNovationContent>(new TradeNovationContent(novationNode));}
   }

   //optionExerciseNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* optionExerciseNode = xmlNode->FirstChildElement("optionExercise");

   if(optionExerciseNode){optionExerciseIsNull_ = false;}
   else{optionExerciseIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- optionExerciseNode , address : " << optionExerciseNode << std::endl;
   #endif
   if(optionExerciseNode)
   {
      if(optionExerciseNode->Attribute("href") || optionExerciseNode->Attribute("id"))
      {
          if(optionExerciseNode->Attribute("id"))
          {
             optionExerciseIDRef_ = optionExerciseNode->Attribute("id");
             optionExercise_ = boost::shared_ptr<OptionExercise>(new OptionExercise(optionExerciseNode));
             optionExercise_->setID(optionExerciseIDRef_);
             IDManager::instance().setID(optionExerciseIDRef_,optionExercise_);
          }
          else if(optionExerciseNode->Attribute("href")) { optionExerciseIDRef_ = optionExerciseNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { optionExercise_ = boost::shared_ptr<OptionExercise>(new OptionExercise(optionExerciseNode));}
   }

   //optionExpiryNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* optionExpiryNode = xmlNode->FirstChildElement("optionExpiry");

   if(optionExpiryNode){optionExpiryIsNull_ = false;}
   else{optionExpiryIsNull_ = true;}

   if(optionExpiryNode)
   {
      for(optionExpiryNode; optionExpiryNode; optionExpiryNode = optionExpiryNode->NextSiblingElement("optionExpiry")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- optionExpiryNode , address : " << optionExpiryNode << std::endl;
          #endif
          if(optionExpiryNode->Attribute("href") || optionExpiryNode->Attribute("id"))
          {
              if(optionExpiryNode->Attribute("id"))
              {
                  optionExpiryIDRef_ = optionExpiryNode->Attribute("id");
                  optionExpiry_.push_back(boost::shared_ptr<OptionExpiry>(new OptionExpiry(optionExpiryNode)));
                  optionExpiry_.back()->setID(optionExpiryIDRef_);
                  IDManager::instance().setID(optionExpiryIDRef_, optionExpiry_.back());
              }
              else if(optionExpiryNode->Attribute("href")) { optionExpiryIDRef_ = optionExpiryNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { optionExpiry_.push_back(boost::shared_ptr<OptionExpiry>(new OptionExpiry(optionExpiryNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- optionExpiryNode , address : " << optionExpiryNode << std::endl;
       #endif
   }

   //deClearNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* deClearNode = xmlNode->FirstChildElement("deClear");

   if(deClearNode){deClearIsNull_ = false;}
   else{deClearIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- deClearNode , address : " << deClearNode << std::endl;
   #endif
   if(deClearNode)
   {
      if(deClearNode->Attribute("href") || deClearNode->Attribute("id"))
      {
          if(deClearNode->Attribute("id"))
          {
             deClearIDRef_ = deClearNode->Attribute("id");
             deClear_ = boost::shared_ptr<DeClear>(new DeClear(deClearNode));
             deClear_->setID(deClearIDRef_);
             IDManager::instance().setID(deClearIDRef_,deClear_);
          }
          else if(deClearNode->Attribute("href")) { deClearIDRef_ = deClearNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { deClear_ = boost::shared_ptr<DeClear>(new DeClear(deClearNode));}
   }

   //withdrawalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* withdrawalNode = xmlNode->FirstChildElement("withdrawal");

   if(withdrawalNode){withdrawalIsNull_ = false;}
   else{withdrawalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- withdrawalNode , address : " << withdrawalNode << std::endl;
   #endif
   if(withdrawalNode)
   {
      if(withdrawalNode->Attribute("href") || withdrawalNode->Attribute("id"))
      {
          if(withdrawalNode->Attribute("id"))
          {
             withdrawalIDRef_ = withdrawalNode->Attribute("id");
             withdrawal_ = boost::shared_ptr<Withdrawal>(new Withdrawal(withdrawalNode));
             withdrawal_->setID(withdrawalIDRef_);
             IDManager::instance().setID(withdrawalIDRef_,withdrawal_);
          }
          else if(withdrawalNode->Attribute("href")) { withdrawalIDRef_ = withdrawalNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { withdrawal_ = boost::shared_ptr<Withdrawal>(new Withdrawal(withdrawalNode));}
   }

   //additionalEventNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* additionalEventNode = xmlNode->FirstChildElement("additionalEvent");

   if(additionalEventNode){additionalEventIsNull_ = false;}
   else{additionalEventIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- additionalEventNode , address : " << additionalEventNode << std::endl;
   #endif
   if(additionalEventNode)
   {
      if(additionalEventNode->Attribute("href") || additionalEventNode->Attribute("id"))
      {
          if(additionalEventNode->Attribute("id"))
          {
             additionalEventIDRef_ = additionalEventNode->Attribute("id");
             additionalEvent_ = boost::shared_ptr<AdditionalEvent>(new AdditionalEvent(additionalEventNode));
             additionalEvent_->setID(additionalEventIDRef_);
             IDManager::instance().setID(additionalEventIDRef_,additionalEvent_);
          }
          else if(additionalEventNode->Attribute("href")) { additionalEventIDRef_ = additionalEventNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { additionalEvent_ = boost::shared_ptr<AdditionalEvent>(new AdditionalEvent(additionalEventNode));}
   }

   //clearingNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* clearingNode = xmlNode->FirstChildElement("clearing");

   if(clearingNode){clearingIsNull_ = false;}
   else{clearingIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- clearingNode , address : " << clearingNode << std::endl;
   #endif
   if(clearingNode)
   {
      if(clearingNode->Attribute("href") || clearingNode->Attribute("id"))
      {
          if(clearingNode->Attribute("id"))
          {
             clearingIDRef_ = clearingNode->Attribute("id");
             clearing_ = boost::shared_ptr<Clearing>(new Clearing(clearingNode));
             clearing_->setID(clearingIDRef_);
             IDManager::instance().setID(clearingIDRef_,clearing_);
          }
          else if(clearingNode->Attribute("href")) { clearingIDRef_ = clearingNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { clearing_ = boost::shared_ptr<Clearing>(new Clearing(clearingNode));}
   }

   //quoteNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* quoteNode = xmlNode->FirstChildElement("quote");

   if(quoteNode){quoteIsNull_ = false;}
   else{quoteIsNull_ = true;}

   if(quoteNode)
   {
      for(quoteNode; quoteNode; quoteNode = quoteNode->NextSiblingElement("quote")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- quoteNode , address : " << quoteNode << std::endl;
          #endif
          if(quoteNode->Attribute("href") || quoteNode->Attribute("id"))
          {
              if(quoteNode->Attribute("id"))
              {
                  quoteIDRef_ = quoteNode->Attribute("id");
                  quote_.push_back(boost::shared_ptr<BasicQuotation>(new BasicQuotation(quoteNode)));
                  quote_.back()->setID(quoteIDRef_);
                  IDManager::instance().setID(quoteIDRef_, quote_.back());
              }
              else if(quoteNode->Attribute("href")) { quoteIDRef_ = quoteNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { quote_.push_back(boost::shared_ptr<BasicQuotation>(new BasicQuotation(quoteNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- quoteNode , address : " << quoteNode << std::endl;
       #endif
   }

   //partyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* partyNode = xmlNode->FirstChildElement("party");

   if(partyNode){partyIsNull_ = false;}
   else{partyIsNull_ = true;}

   if(partyNode)
   {
      for(partyNode; partyNode; partyNode = partyNode->NextSiblingElement("party")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- partyNode , address : " << partyNode << std::endl;
          #endif
          if(partyNode->Attribute("href") || partyNode->Attribute("id"))
          {
              if(partyNode->Attribute("id"))
              {
                  partyIDRef_ = partyNode->Attribute("id");
                  party_.push_back(boost::shared_ptr<Party>(new Party(partyNode)));
                  party_.back()->setID(partyIDRef_);
                  IDManager::instance().setID(partyIDRef_, party_.back());
              }
              else if(partyNode->Attribute("href")) { partyIDRef_ = partyNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { party_.push_back(boost::shared_ptr<Party>(new Party(partyNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- partyNode , address : " << partyNode << std::endl;
       #endif
   }

   //accountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* accountNode = xmlNode->FirstChildElement("account");

   if(accountNode){accountIsNull_ = false;}
   else{accountIsNull_ = true;}

   if(accountNode)
   {
      for(accountNode; accountNode; accountNode = accountNode->NextSiblingElement("account")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- accountNode , address : " << accountNode << std::endl;
          #endif
          if(accountNode->Attribute("href") || accountNode->Attribute("id"))
          {
              if(accountNode->Attribute("id"))
              {
                  accountIDRef_ = accountNode->Attribute("id");
                  account_.push_back(boost::shared_ptr<Account>(new Account(accountNode)));
                  account_.back()->setID(accountIDRef_);
                  IDManager::instance().setID(accountIDRef_, account_.back());
              }
              else if(accountNode->Attribute("href")) { accountIDRef_ = accountNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { account_.push_back(boost::shared_ptr<Account>(new Account(accountNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- accountNode , address : " << accountNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<CompressionActivity> ClearingConfirmed::getCompressionActivity()
{
   if(!this->compressionActivityIsNull_){
        if(compressionActivityIDRef_ != ""){
             return boost::shared_static_cast<CompressionActivity>(IDManager::instance().getID(compressionActivityIDRef_));
        }else{
             return this->compressionActivity_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CompressionActivity>();
   }
}
boost::shared_ptr<PortfolioReference> ClearingConfirmed::getPortfolioReference()
{
   if(!this->portfolioReferenceIsNull_){
        if(portfolioReferenceIDRef_ != ""){
             return boost::shared_static_cast<PortfolioReference>(IDManager::instance().getID(portfolioReferenceIDRef_));
        }else{
             return this->portfolioReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PortfolioReference>();
   }
}
boost::shared_ptr<OriginatingEvent> ClearingConfirmed::getOriginatingEvent()
{
   if(!this->originatingEventIsNull_){
        if(originatingEventIDRef_ != ""){
             return boost::shared_static_cast<OriginatingEvent>(IDManager::instance().getID(originatingEventIDRef_));
        }else{
             return this->originatingEvent_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<OriginatingEvent>();
   }
}
boost::shared_ptr<Trade> ClearingConfirmed::getTrade()
{
   if(!this->tradeIsNull_){
        if(tradeIDRef_ != ""){
             return boost::shared_static_cast<Trade>(IDManager::instance().getID(tradeIDRef_));
        }else{
             return this->trade_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Trade>();
   }
}
boost::shared_ptr<TradeAmendmentContent> ClearingConfirmed::getAmendment()
{
   if(!this->amendmentIsNull_){
        if(amendmentIDRef_ != ""){
             return boost::shared_static_cast<TradeAmendmentContent>(IDManager::instance().getID(amendmentIDRef_));
        }else{
             return this->amendment_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<TradeAmendmentContent>();
   }
}
boost::shared_ptr<TradeNotionalChange> ClearingConfirmed::getIncrease()
{
   if(!this->increaseIsNull_){
        if(increaseIDRef_ != ""){
             return boost::shared_static_cast<TradeNotionalChange>(IDManager::instance().getID(increaseIDRef_));
        }else{
             return this->increase_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<TradeNotionalChange>();
   }
}
boost::shared_ptr<TerminatingEvent> ClearingConfirmed::getTerminatingEvent()
{
   if(!this->terminatingEventIsNull_){
        if(terminatingEventIDRef_ != ""){
             return boost::shared_static_cast<TerminatingEvent>(IDManager::instance().getID(terminatingEventIDRef_));
        }else{
             return this->terminatingEvent_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<TerminatingEvent>();
   }
}
boost::shared_ptr<TradeNotionalChange> ClearingConfirmed::getTermination()
{
   if(!this->terminationIsNull_){
        if(terminationIDRef_ != ""){
             return boost::shared_static_cast<TradeNotionalChange>(IDManager::instance().getID(terminationIDRef_));
        }else{
             return this->termination_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<TradeNotionalChange>();
   }
}
boost::shared_ptr<TradeNovationContent> ClearingConfirmed::getNovation()
{
   if(!this->novationIsNull_){
        if(novationIDRef_ != ""){
             return boost::shared_static_cast<TradeNovationContent>(IDManager::instance().getID(novationIDRef_));
        }else{
             return this->novation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<TradeNovationContent>();
   }
}
boost::shared_ptr<OptionExercise> ClearingConfirmed::getOptionExercise()
{
   if(!this->optionExerciseIsNull_){
        if(optionExerciseIDRef_ != ""){
             return boost::shared_static_cast<OptionExercise>(IDManager::instance().getID(optionExerciseIDRef_));
        }else{
             return this->optionExercise_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<OptionExercise>();
   }
}
std::vector<boost::shared_ptr<OptionExpiry>> ClearingConfirmed::getOptionExpiry()
{
   if(!this->optionExpiryIsNull_){
        if(optionExpiryIDRef_ != ""){
             return this->optionExpiry_;
        }else{
             return this->optionExpiry_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<OptionExpiry>>();
   }
}
boost::shared_ptr<DeClear> ClearingConfirmed::getDeClear()
{
   if(!this->deClearIsNull_){
        if(deClearIDRef_ != ""){
             return boost::shared_static_cast<DeClear>(IDManager::instance().getID(deClearIDRef_));
        }else{
             return this->deClear_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DeClear>();
   }
}
boost::shared_ptr<Withdrawal> ClearingConfirmed::getWithdrawal()
{
   if(!this->withdrawalIsNull_){
        if(withdrawalIDRef_ != ""){
             return boost::shared_static_cast<Withdrawal>(IDManager::instance().getID(withdrawalIDRef_));
        }else{
             return this->withdrawal_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Withdrawal>();
   }
}
boost::shared_ptr<AdditionalEvent> ClearingConfirmed::getAdditionalEvent()
{
   if(!this->additionalEventIsNull_){
        if(additionalEventIDRef_ != ""){
             return boost::shared_static_cast<AdditionalEvent>(IDManager::instance().getID(additionalEventIDRef_));
        }else{
             return this->additionalEvent_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdditionalEvent>();
   }
}
boost::shared_ptr<Clearing> ClearingConfirmed::getClearing()
{
   if(!this->clearingIsNull_){
        if(clearingIDRef_ != ""){
             return boost::shared_static_cast<Clearing>(IDManager::instance().getID(clearingIDRef_));
        }else{
             return this->clearing_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Clearing>();
   }
}
std::vector<boost::shared_ptr<BasicQuotation>> ClearingConfirmed::getQuote()
{
   if(!this->quoteIsNull_){
        if(quoteIDRef_ != ""){
             return this->quote_;
        }else{
             return this->quote_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<BasicQuotation>>();
   }
}
std::vector<boost::shared_ptr<Party>> ClearingConfirmed::getParty()
{
   if(!this->partyIsNull_){
        if(partyIDRef_ != ""){
             return this->party_;
        }else{
             return this->party_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Party>>();
   }
}
std::vector<boost::shared_ptr<Account>> ClearingConfirmed::getAccount()
{
   if(!this->accountIsNull_){
        if(accountIDRef_ != ""){
             return this->account_;
        }else{
             return this->account_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Account>>();
   }
}
}

