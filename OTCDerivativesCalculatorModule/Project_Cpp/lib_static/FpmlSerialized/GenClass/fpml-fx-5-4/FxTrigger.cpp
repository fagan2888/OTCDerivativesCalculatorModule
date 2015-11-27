// FxTrigger.cpp 
#include "FxTrigger.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FxTrigger::FxTrigger(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //triggerConditionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* triggerConditionNode = xmlNode->FirstChildElement("triggerCondition");

   if(triggerConditionNode){triggerConditionIsNull_ = false;}
   else{triggerConditionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- triggerConditionNode , address : " << triggerConditionNode << std::endl;
   #endif
   if(triggerConditionNode)
   {
      if(triggerConditionNode->Attribute("href") || triggerConditionNode->Attribute("id"))
      {
          if(triggerConditionNode->Attribute("id"))
          {
             triggerConditionIDRef_ = triggerConditionNode->Attribute("id");
             triggerCondition_ = boost::shared_ptr<TriggerConditionEnum>(new TriggerConditionEnum(triggerConditionNode));
             triggerCondition_->setID(triggerConditionIDRef_);
             IDManager::instance().setID(triggerConditionIDRef_,triggerCondition_);
          }
          else if(triggerConditionNode->Attribute("href")) { triggerConditionIDRef_ = triggerConditionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { triggerCondition_ = boost::shared_ptr<TriggerConditionEnum>(new TriggerConditionEnum(triggerConditionNode));}
   }

   //quotedCurrencyPairNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* quotedCurrencyPairNode = xmlNode->FirstChildElement("quotedCurrencyPair");

   if(quotedCurrencyPairNode){quotedCurrencyPairIsNull_ = false;}
   else{quotedCurrencyPairIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- quotedCurrencyPairNode , address : " << quotedCurrencyPairNode << std::endl;
   #endif
   if(quotedCurrencyPairNode)
   {
      if(quotedCurrencyPairNode->Attribute("href") || quotedCurrencyPairNode->Attribute("id"))
      {
          if(quotedCurrencyPairNode->Attribute("id"))
          {
             quotedCurrencyPairIDRef_ = quotedCurrencyPairNode->Attribute("id");
             quotedCurrencyPair_ = boost::shared_ptr<QuotedCurrencyPair>(new QuotedCurrencyPair(quotedCurrencyPairNode));
             quotedCurrencyPair_->setID(quotedCurrencyPairIDRef_);
             IDManager::instance().setID(quotedCurrencyPairIDRef_,quotedCurrencyPair_);
          }
          else if(quotedCurrencyPairNode->Attribute("href")) { quotedCurrencyPairIDRef_ = quotedCurrencyPairNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { quotedCurrencyPair_ = boost::shared_ptr<QuotedCurrencyPair>(new QuotedCurrencyPair(quotedCurrencyPairNode));}
   }

   //triggerRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* triggerRateNode = xmlNode->FirstChildElement("triggerRate");

   if(triggerRateNode){triggerRateIsNull_ = false;}
   else{triggerRateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- triggerRateNode , address : " << triggerRateNode << std::endl;
   #endif
   if(triggerRateNode)
   {
      if(triggerRateNode->Attribute("href") || triggerRateNode->Attribute("id"))
      {
          if(triggerRateNode->Attribute("id"))
          {
             triggerRateIDRef_ = triggerRateNode->Attribute("id");
             triggerRate_ = boost::shared_ptr<PositiveDecimal>(new PositiveDecimal(triggerRateNode));
             triggerRate_->setID(triggerRateIDRef_);
             IDManager::instance().setID(triggerRateIDRef_,triggerRate_);
          }
          else if(triggerRateNode->Attribute("href")) { triggerRateIDRef_ = triggerRateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { triggerRate_ = boost::shared_ptr<PositiveDecimal>(new PositiveDecimal(triggerRateNode));}
   }

   //spotRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* spotRateNode = xmlNode->FirstChildElement("spotRate");

   if(spotRateNode){spotRateIsNull_ = false;}
   else{spotRateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- spotRateNode , address : " << spotRateNode << std::endl;
   #endif
   if(spotRateNode)
   {
      if(spotRateNode->Attribute("href") || spotRateNode->Attribute("id"))
      {
          if(spotRateNode->Attribute("id"))
          {
             spotRateIDRef_ = spotRateNode->Attribute("id");
             spotRate_ = boost::shared_ptr<PositiveDecimal>(new PositiveDecimal(spotRateNode));
             spotRate_->setID(spotRateIDRef_);
             IDManager::instance().setID(spotRateIDRef_,spotRate_);
          }
          else if(spotRateNode->Attribute("href")) { spotRateIDRef_ = spotRateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { spotRate_ = boost::shared_ptr<PositiveDecimal>(new PositiveDecimal(spotRateNode));}
   }

   //informationSourceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* informationSourceNode = xmlNode->FirstChildElement("informationSource");

   if(informationSourceNode){informationSourceIsNull_ = false;}
   else{informationSourceIsNull_ = true;}

   if(informationSourceNode)
   {
      for(informationSourceNode; informationSourceNode; informationSourceNode = informationSourceNode->NextSiblingElement("informationSource")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- informationSourceNode , address : " << informationSourceNode << std::endl;
          #endif
          if(informationSourceNode->Attribute("href") || informationSourceNode->Attribute("id"))
          {
              if(informationSourceNode->Attribute("id"))
              {
                  informationSourceIDRef_ = informationSourceNode->Attribute("id");
                  informationSource_.push_back(boost::shared_ptr<InformationSource>(new InformationSource(informationSourceNode)));
                  informationSource_.back()->setID(informationSourceIDRef_);
                  IDManager::instance().setID(informationSourceIDRef_, informationSource_.back());
              }
              else if(informationSourceNode->Attribute("href")) { informationSourceIDRef_ = informationSourceNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { informationSource_.push_back(boost::shared_ptr<InformationSource>(new InformationSource(informationSourceNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- informationSourceNode , address : " << informationSourceNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<TriggerConditionEnum> FxTrigger::getTriggerCondition()
{
   if(!this->triggerConditionIsNull_){
        if(triggerConditionIDRef_ != ""){
             return boost::shared_static_cast<TriggerConditionEnum>(IDManager::instance().getID(triggerConditionIDRef_));
        }else{
             return this->triggerCondition_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<TriggerConditionEnum>();
   }
}
boost::shared_ptr<QuotedCurrencyPair> FxTrigger::getQuotedCurrencyPair()
{
   if(!this->quotedCurrencyPairIsNull_){
        if(quotedCurrencyPairIDRef_ != ""){
             return boost::shared_static_cast<QuotedCurrencyPair>(IDManager::instance().getID(quotedCurrencyPairIDRef_));
        }else{
             return this->quotedCurrencyPair_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<QuotedCurrencyPair>();
   }
}
boost::shared_ptr<PositiveDecimal> FxTrigger::getTriggerRate()
{
   if(!this->triggerRateIsNull_){
        if(triggerRateIDRef_ != ""){
             return boost::shared_static_cast<PositiveDecimal>(IDManager::instance().getID(triggerRateIDRef_));
        }else{
             return this->triggerRate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PositiveDecimal>();
   }
}
boost::shared_ptr<PositiveDecimal> FxTrigger::getSpotRate()
{
   if(!this->spotRateIsNull_){
        if(spotRateIDRef_ != ""){
             return boost::shared_static_cast<PositiveDecimal>(IDManager::instance().getID(spotRateIDRef_));
        }else{
             return this->spotRate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PositiveDecimal>();
   }
}
std::vector<boost::shared_ptr<InformationSource>> FxTrigger::getInformationSource()
{
   if(!this->informationSourceIsNull_){
        if(informationSourceIDRef_ != ""){
             return this->informationSource_;
        }else{
             return this->informationSource_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<InformationSource>>();
   }
}
}

