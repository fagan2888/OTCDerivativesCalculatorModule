// TradeProcessingTimestamps.cpp 
#include "TradeProcessingTimestamps.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

TradeProcessingTimestamps::TradeProcessingTimestamps(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //orderEnteredNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* orderEnteredNode = xmlNode->FirstChildElement("orderEntered");

   if(orderEnteredNode){orderEnteredIsNull_ = false;}
   else{orderEnteredIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- orderEnteredNode , address : " << orderEnteredNode << std::endl;
   #endif
   if(orderEnteredNode)
   {
      if(orderEnteredNode->Attribute("href") || orderEnteredNode->Attribute("id"))
      {
          if(orderEnteredNode->Attribute("id"))
          {
             orderEnteredIDRef_ = orderEnteredNode->Attribute("id");
             orderEntered_ = boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(orderEnteredNode));
             orderEntered_->setID(orderEnteredIDRef_);
             IDManager::instance().setID(orderEnteredIDRef_,orderEntered_);
          }
          else if(orderEnteredNode->Attribute("href")) { orderEnteredIDRef_ = orderEnteredNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { orderEntered_ = boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(orderEnteredNode));}
   }

   //orderSubmittedNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* orderSubmittedNode = xmlNode->FirstChildElement("orderSubmitted");

   if(orderSubmittedNode){orderSubmittedIsNull_ = false;}
   else{orderSubmittedIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- orderSubmittedNode , address : " << orderSubmittedNode << std::endl;
   #endif
   if(orderSubmittedNode)
   {
      if(orderSubmittedNode->Attribute("href") || orderSubmittedNode->Attribute("id"))
      {
          if(orderSubmittedNode->Attribute("id"))
          {
             orderSubmittedIDRef_ = orderSubmittedNode->Attribute("id");
             orderSubmitted_ = boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(orderSubmittedNode));
             orderSubmitted_->setID(orderSubmittedIDRef_);
             IDManager::instance().setID(orderSubmittedIDRef_,orderSubmitted_);
          }
          else if(orderSubmittedNode->Attribute("href")) { orderSubmittedIDRef_ = orderSubmittedNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { orderSubmitted_ = boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(orderSubmittedNode));}
   }

   //publiclyReportedNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* publiclyReportedNode = xmlNode->FirstChildElement("publiclyReported");

   if(publiclyReportedNode){publiclyReportedIsNull_ = false;}
   else{publiclyReportedIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- publiclyReportedNode , address : " << publiclyReportedNode << std::endl;
   #endif
   if(publiclyReportedNode)
   {
      if(publiclyReportedNode->Attribute("href") || publiclyReportedNode->Attribute("id"))
      {
          if(publiclyReportedNode->Attribute("id"))
          {
             publiclyReportedIDRef_ = publiclyReportedNode->Attribute("id");
             publiclyReported_ = boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(publiclyReportedNode));
             publiclyReported_->setID(publiclyReportedIDRef_);
             IDManager::instance().setID(publiclyReportedIDRef_,publiclyReported_);
          }
          else if(publiclyReportedNode->Attribute("href")) { publiclyReportedIDRef_ = publiclyReportedNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { publiclyReported_ = boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(publiclyReportedNode));}
   }

   //publicReportUpdatedNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* publicReportUpdatedNode = xmlNode->FirstChildElement("publicReportUpdated");

   if(publicReportUpdatedNode){publicReportUpdatedIsNull_ = false;}
   else{publicReportUpdatedIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- publicReportUpdatedNode , address : " << publicReportUpdatedNode << std::endl;
   #endif
   if(publicReportUpdatedNode)
   {
      if(publicReportUpdatedNode->Attribute("href") || publicReportUpdatedNode->Attribute("id"))
      {
          if(publicReportUpdatedNode->Attribute("id"))
          {
             publicReportUpdatedIDRef_ = publicReportUpdatedNode->Attribute("id");
             publicReportUpdated_ = boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(publicReportUpdatedNode));
             publicReportUpdated_->setID(publicReportUpdatedIDRef_);
             IDManager::instance().setID(publicReportUpdatedIDRef_,publicReportUpdated_);
          }
          else if(publicReportUpdatedNode->Attribute("href")) { publicReportUpdatedIDRef_ = publicReportUpdatedNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { publicReportUpdated_ = boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(publicReportUpdatedNode));}
   }

   //nonpubliclyReportedNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* nonpubliclyReportedNode = xmlNode->FirstChildElement("nonpubliclyReported");

   if(nonpubliclyReportedNode){nonpubliclyReportedIsNull_ = false;}
   else{nonpubliclyReportedIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- nonpubliclyReportedNode , address : " << nonpubliclyReportedNode << std::endl;
   #endif
   if(nonpubliclyReportedNode)
   {
      if(nonpubliclyReportedNode->Attribute("href") || nonpubliclyReportedNode->Attribute("id"))
      {
          if(nonpubliclyReportedNode->Attribute("id"))
          {
             nonpubliclyReportedIDRef_ = nonpubliclyReportedNode->Attribute("id");
             nonpubliclyReported_ = boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(nonpubliclyReportedNode));
             nonpubliclyReported_->setID(nonpubliclyReportedIDRef_);
             IDManager::instance().setID(nonpubliclyReportedIDRef_,nonpubliclyReported_);
          }
          else if(nonpubliclyReportedNode->Attribute("href")) { nonpubliclyReportedIDRef_ = nonpubliclyReportedNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { nonpubliclyReported_ = boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(nonpubliclyReportedNode));}
   }

   //nonpublicReportUpdatedNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* nonpublicReportUpdatedNode = xmlNode->FirstChildElement("nonpublicReportUpdated");

   if(nonpublicReportUpdatedNode){nonpublicReportUpdatedIsNull_ = false;}
   else{nonpublicReportUpdatedIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- nonpublicReportUpdatedNode , address : " << nonpublicReportUpdatedNode << std::endl;
   #endif
   if(nonpublicReportUpdatedNode)
   {
      if(nonpublicReportUpdatedNode->Attribute("href") || nonpublicReportUpdatedNode->Attribute("id"))
      {
          if(nonpublicReportUpdatedNode->Attribute("id"))
          {
             nonpublicReportUpdatedIDRef_ = nonpublicReportUpdatedNode->Attribute("id");
             nonpublicReportUpdated_ = boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(nonpublicReportUpdatedNode));
             nonpublicReportUpdated_->setID(nonpublicReportUpdatedIDRef_);
             IDManager::instance().setID(nonpublicReportUpdatedIDRef_,nonpublicReportUpdated_);
          }
          else if(nonpublicReportUpdatedNode->Attribute("href")) { nonpublicReportUpdatedIDRef_ = nonpublicReportUpdatedNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { nonpublicReportUpdated_ = boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(nonpublicReportUpdatedNode));}
   }

   //submittedForConfirmationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* submittedForConfirmationNode = xmlNode->FirstChildElement("submittedForConfirmation");

   if(submittedForConfirmationNode){submittedForConfirmationIsNull_ = false;}
   else{submittedForConfirmationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- submittedForConfirmationNode , address : " << submittedForConfirmationNode << std::endl;
   #endif
   if(submittedForConfirmationNode)
   {
      if(submittedForConfirmationNode->Attribute("href") || submittedForConfirmationNode->Attribute("id"))
      {
          if(submittedForConfirmationNode->Attribute("id"))
          {
             submittedForConfirmationIDRef_ = submittedForConfirmationNode->Attribute("id");
             submittedForConfirmation_ = boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(submittedForConfirmationNode));
             submittedForConfirmation_->setID(submittedForConfirmationIDRef_);
             IDManager::instance().setID(submittedForConfirmationIDRef_,submittedForConfirmation_);
          }
          else if(submittedForConfirmationNode->Attribute("href")) { submittedForConfirmationIDRef_ = submittedForConfirmationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { submittedForConfirmation_ = boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(submittedForConfirmationNode));}
   }

   //updatedForConfirmationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* updatedForConfirmationNode = xmlNode->FirstChildElement("updatedForConfirmation");

   if(updatedForConfirmationNode){updatedForConfirmationIsNull_ = false;}
   else{updatedForConfirmationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- updatedForConfirmationNode , address : " << updatedForConfirmationNode << std::endl;
   #endif
   if(updatedForConfirmationNode)
   {
      if(updatedForConfirmationNode->Attribute("href") || updatedForConfirmationNode->Attribute("id"))
      {
          if(updatedForConfirmationNode->Attribute("id"))
          {
             updatedForConfirmationIDRef_ = updatedForConfirmationNode->Attribute("id");
             updatedForConfirmation_ = boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(updatedForConfirmationNode));
             updatedForConfirmation_->setID(updatedForConfirmationIDRef_);
             IDManager::instance().setID(updatedForConfirmationIDRef_,updatedForConfirmation_);
          }
          else if(updatedForConfirmationNode->Attribute("href")) { updatedForConfirmationIDRef_ = updatedForConfirmationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { updatedForConfirmation_ = boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(updatedForConfirmationNode));}
   }

   //confirmedNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* confirmedNode = xmlNode->FirstChildElement("confirmed");

   if(confirmedNode){confirmedIsNull_ = false;}
   else{confirmedIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- confirmedNode , address : " << confirmedNode << std::endl;
   #endif
   if(confirmedNode)
   {
      if(confirmedNode->Attribute("href") || confirmedNode->Attribute("id"))
      {
          if(confirmedNode->Attribute("id"))
          {
             confirmedIDRef_ = confirmedNode->Attribute("id");
             confirmed_ = boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(confirmedNode));
             confirmed_->setID(confirmedIDRef_);
             IDManager::instance().setID(confirmedIDRef_,confirmed_);
          }
          else if(confirmedNode->Attribute("href")) { confirmedIDRef_ = confirmedNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { confirmed_ = boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(confirmedNode));}
   }

   //submittedForClearingNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* submittedForClearingNode = xmlNode->FirstChildElement("submittedForClearing");

   if(submittedForClearingNode){submittedForClearingIsNull_ = false;}
   else{submittedForClearingIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- submittedForClearingNode , address : " << submittedForClearingNode << std::endl;
   #endif
   if(submittedForClearingNode)
   {
      if(submittedForClearingNode->Attribute("href") || submittedForClearingNode->Attribute("id"))
      {
          if(submittedForClearingNode->Attribute("id"))
          {
             submittedForClearingIDRef_ = submittedForClearingNode->Attribute("id");
             submittedForClearing_ = boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(submittedForClearingNode));
             submittedForClearing_->setID(submittedForClearingIDRef_);
             IDManager::instance().setID(submittedForClearingIDRef_,submittedForClearing_);
          }
          else if(submittedForClearingNode->Attribute("href")) { submittedForClearingIDRef_ = submittedForClearingNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { submittedForClearing_ = boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(submittedForClearingNode));}
   }

   //updatedForClearingNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* updatedForClearingNode = xmlNode->FirstChildElement("updatedForClearing");

   if(updatedForClearingNode){updatedForClearingIsNull_ = false;}
   else{updatedForClearingIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- updatedForClearingNode , address : " << updatedForClearingNode << std::endl;
   #endif
   if(updatedForClearingNode)
   {
      if(updatedForClearingNode->Attribute("href") || updatedForClearingNode->Attribute("id"))
      {
          if(updatedForClearingNode->Attribute("id"))
          {
             updatedForClearingIDRef_ = updatedForClearingNode->Attribute("id");
             updatedForClearing_ = boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(updatedForClearingNode));
             updatedForClearing_->setID(updatedForClearingIDRef_);
             IDManager::instance().setID(updatedForClearingIDRef_,updatedForClearing_);
          }
          else if(updatedForClearingNode->Attribute("href")) { updatedForClearingIDRef_ = updatedForClearingNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { updatedForClearing_ = boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(updatedForClearingNode));}
   }

   //clearedNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* clearedNode = xmlNode->FirstChildElement("cleared");

   if(clearedNode){clearedIsNull_ = false;}
   else{clearedIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- clearedNode , address : " << clearedNode << std::endl;
   #endif
   if(clearedNode)
   {
      if(clearedNode->Attribute("href") || clearedNode->Attribute("id"))
      {
          if(clearedNode->Attribute("id"))
          {
             clearedIDRef_ = clearedNode->Attribute("id");
             cleared_ = boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(clearedNode));
             cleared_->setID(clearedIDRef_);
             IDManager::instance().setID(clearedIDRef_,cleared_);
          }
          else if(clearedNode->Attribute("href")) { clearedIDRef_ = clearedNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { cleared_ = boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(clearedNode));}
   }

   //allocationsSubmittedNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* allocationsSubmittedNode = xmlNode->FirstChildElement("allocationsSubmitted");

   if(allocationsSubmittedNode){allocationsSubmittedIsNull_ = false;}
   else{allocationsSubmittedIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- allocationsSubmittedNode , address : " << allocationsSubmittedNode << std::endl;
   #endif
   if(allocationsSubmittedNode)
   {
      if(allocationsSubmittedNode->Attribute("href") || allocationsSubmittedNode->Attribute("id"))
      {
          if(allocationsSubmittedNode->Attribute("id"))
          {
             allocationsSubmittedIDRef_ = allocationsSubmittedNode->Attribute("id");
             allocationsSubmitted_ = boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(allocationsSubmittedNode));
             allocationsSubmitted_->setID(allocationsSubmittedIDRef_);
             IDManager::instance().setID(allocationsSubmittedIDRef_,allocationsSubmitted_);
          }
          else if(allocationsSubmittedNode->Attribute("href")) { allocationsSubmittedIDRef_ = allocationsSubmittedNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { allocationsSubmitted_ = boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(allocationsSubmittedNode));}
   }

   //allocationsUpdatedNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* allocationsUpdatedNode = xmlNode->FirstChildElement("allocationsUpdated");

   if(allocationsUpdatedNode){allocationsUpdatedIsNull_ = false;}
   else{allocationsUpdatedIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- allocationsUpdatedNode , address : " << allocationsUpdatedNode << std::endl;
   #endif
   if(allocationsUpdatedNode)
   {
      if(allocationsUpdatedNode->Attribute("href") || allocationsUpdatedNode->Attribute("id"))
      {
          if(allocationsUpdatedNode->Attribute("id"))
          {
             allocationsUpdatedIDRef_ = allocationsUpdatedNode->Attribute("id");
             allocationsUpdated_ = boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(allocationsUpdatedNode));
             allocationsUpdated_->setID(allocationsUpdatedIDRef_);
             IDManager::instance().setID(allocationsUpdatedIDRef_,allocationsUpdated_);
          }
          else if(allocationsUpdatedNode->Attribute("href")) { allocationsUpdatedIDRef_ = allocationsUpdatedNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { allocationsUpdated_ = boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(allocationsUpdatedNode));}
   }

   //allocationsCompletedNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* allocationsCompletedNode = xmlNode->FirstChildElement("allocationsCompleted");

   if(allocationsCompletedNode){allocationsCompletedIsNull_ = false;}
   else{allocationsCompletedIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- allocationsCompletedNode , address : " << allocationsCompletedNode << std::endl;
   #endif
   if(allocationsCompletedNode)
   {
      if(allocationsCompletedNode->Attribute("href") || allocationsCompletedNode->Attribute("id"))
      {
          if(allocationsCompletedNode->Attribute("id"))
          {
             allocationsCompletedIDRef_ = allocationsCompletedNode->Attribute("id");
             allocationsCompleted_ = boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(allocationsCompletedNode));
             allocationsCompleted_->setID(allocationsCompletedIDRef_);
             IDManager::instance().setID(allocationsCompletedIDRef_,allocationsCompleted_);
          }
          else if(allocationsCompletedNode->Attribute("href")) { allocationsCompletedIDRef_ = allocationsCompletedNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { allocationsCompleted_ = boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(allocationsCompletedNode));}
   }

   //timestampNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* timestampNode = xmlNode->FirstChildElement("timestamp");

   if(timestampNode){timestampIsNull_ = false;}
   else{timestampIsNull_ = true;}

   if(timestampNode)
   {
      for(timestampNode; timestampNode; timestampNode = timestampNode->NextSiblingElement("timestamp")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- timestampNode , address : " << timestampNode << std::endl;
          #endif
          if(timestampNode->Attribute("href") || timestampNode->Attribute("id"))
          {
              if(timestampNode->Attribute("id"))
              {
                  timestampIDRef_ = timestampNode->Attribute("id");
                  timestamp_.push_back(boost::shared_ptr<TradeTimestamp>(new TradeTimestamp(timestampNode)));
                  timestamp_.back()->setID(timestampIDRef_);
                  IDManager::instance().setID(timestampIDRef_, timestamp_.back());
              }
              else if(timestampNode->Attribute("href")) { timestampIDRef_ = timestampNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { timestamp_.push_back(boost::shared_ptr<TradeTimestamp>(new TradeTimestamp(timestampNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- timestampNode , address : " << timestampNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDateTime> TradeProcessingTimestamps::getOrderEntered()
{
   if(!this->orderEnteredIsNull_){
        if(orderEnteredIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDateTime>(IDManager::instance().getID(orderEnteredIDRef_));
        }else{
             return this->orderEntered_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDateTime>();
   }
}
boost::shared_ptr<XsdTypeDateTime> TradeProcessingTimestamps::getOrderSubmitted()
{
   if(!this->orderSubmittedIsNull_){
        if(orderSubmittedIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDateTime>(IDManager::instance().getID(orderSubmittedIDRef_));
        }else{
             return this->orderSubmitted_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDateTime>();
   }
}
boost::shared_ptr<XsdTypeDateTime> TradeProcessingTimestamps::getPubliclyReported()
{
   if(!this->publiclyReportedIsNull_){
        if(publiclyReportedIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDateTime>(IDManager::instance().getID(publiclyReportedIDRef_));
        }else{
             return this->publiclyReported_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDateTime>();
   }
}
boost::shared_ptr<XsdTypeDateTime> TradeProcessingTimestamps::getPublicReportUpdated()
{
   if(!this->publicReportUpdatedIsNull_){
        if(publicReportUpdatedIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDateTime>(IDManager::instance().getID(publicReportUpdatedIDRef_));
        }else{
             return this->publicReportUpdated_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDateTime>();
   }
}
boost::shared_ptr<XsdTypeDateTime> TradeProcessingTimestamps::getNonpubliclyReported()
{
   if(!this->nonpubliclyReportedIsNull_){
        if(nonpubliclyReportedIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDateTime>(IDManager::instance().getID(nonpubliclyReportedIDRef_));
        }else{
             return this->nonpubliclyReported_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDateTime>();
   }
}
boost::shared_ptr<XsdTypeDateTime> TradeProcessingTimestamps::getNonpublicReportUpdated()
{
   if(!this->nonpublicReportUpdatedIsNull_){
        if(nonpublicReportUpdatedIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDateTime>(IDManager::instance().getID(nonpublicReportUpdatedIDRef_));
        }else{
             return this->nonpublicReportUpdated_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDateTime>();
   }
}
boost::shared_ptr<XsdTypeDateTime> TradeProcessingTimestamps::getSubmittedForConfirmation()
{
   if(!this->submittedForConfirmationIsNull_){
        if(submittedForConfirmationIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDateTime>(IDManager::instance().getID(submittedForConfirmationIDRef_));
        }else{
             return this->submittedForConfirmation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDateTime>();
   }
}
boost::shared_ptr<XsdTypeDateTime> TradeProcessingTimestamps::getUpdatedForConfirmation()
{
   if(!this->updatedForConfirmationIsNull_){
        if(updatedForConfirmationIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDateTime>(IDManager::instance().getID(updatedForConfirmationIDRef_));
        }else{
             return this->updatedForConfirmation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDateTime>();
   }
}
boost::shared_ptr<XsdTypeDateTime> TradeProcessingTimestamps::getConfirmed()
{
   if(!this->confirmedIsNull_){
        if(confirmedIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDateTime>(IDManager::instance().getID(confirmedIDRef_));
        }else{
             return this->confirmed_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDateTime>();
   }
}
boost::shared_ptr<XsdTypeDateTime> TradeProcessingTimestamps::getSubmittedForClearing()
{
   if(!this->submittedForClearingIsNull_){
        if(submittedForClearingIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDateTime>(IDManager::instance().getID(submittedForClearingIDRef_));
        }else{
             return this->submittedForClearing_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDateTime>();
   }
}
boost::shared_ptr<XsdTypeDateTime> TradeProcessingTimestamps::getUpdatedForClearing()
{
   if(!this->updatedForClearingIsNull_){
        if(updatedForClearingIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDateTime>(IDManager::instance().getID(updatedForClearingIDRef_));
        }else{
             return this->updatedForClearing_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDateTime>();
   }
}
boost::shared_ptr<XsdTypeDateTime> TradeProcessingTimestamps::getCleared()
{
   if(!this->clearedIsNull_){
        if(clearedIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDateTime>(IDManager::instance().getID(clearedIDRef_));
        }else{
             return this->cleared_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDateTime>();
   }
}
boost::shared_ptr<XsdTypeDateTime> TradeProcessingTimestamps::getAllocationsSubmitted()
{
   if(!this->allocationsSubmittedIsNull_){
        if(allocationsSubmittedIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDateTime>(IDManager::instance().getID(allocationsSubmittedIDRef_));
        }else{
             return this->allocationsSubmitted_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDateTime>();
   }
}
boost::shared_ptr<XsdTypeDateTime> TradeProcessingTimestamps::getAllocationsUpdated()
{
   if(!this->allocationsUpdatedIsNull_){
        if(allocationsUpdatedIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDateTime>(IDManager::instance().getID(allocationsUpdatedIDRef_));
        }else{
             return this->allocationsUpdated_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDateTime>();
   }
}
boost::shared_ptr<XsdTypeDateTime> TradeProcessingTimestamps::getAllocationsCompleted()
{
   if(!this->allocationsCompletedIsNull_){
        if(allocationsCompletedIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDateTime>(IDManager::instance().getID(allocationsCompletedIDRef_));
        }else{
             return this->allocationsCompleted_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDateTime>();
   }
}
std::vector<boost::shared_ptr<TradeTimestamp>> TradeProcessingTimestamps::getTimestamp()
{
   if(!this->timestampIsNull_){
        if(timestampIDRef_ != ""){
             return this->timestamp_;
        }else{
             return this->timestamp_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<TradeTimestamp>>();
   }
}
}

