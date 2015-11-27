// ReturnSwap.cpp 
#include "ReturnSwap.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ReturnSwap::ReturnSwap(TiXmlNode* xmlNode)
: ReturnSwapBase(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //additionalPaymentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* additionalPaymentNode = xmlNode->FirstChildElement("additionalPayment");

   if(additionalPaymentNode){additionalPaymentIsNull_ = false;}
   else{additionalPaymentIsNull_ = true;}

   if(additionalPaymentNode)
   {
      for(additionalPaymentNode; additionalPaymentNode; additionalPaymentNode = additionalPaymentNode->NextSiblingElement("additionalPayment")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- additionalPaymentNode , address : " << additionalPaymentNode << std::endl;
          #endif
          if(additionalPaymentNode->Attribute("href") || additionalPaymentNode->Attribute("id"))
          {
              if(additionalPaymentNode->Attribute("id"))
              {
                  additionalPaymentIDRef_ = additionalPaymentNode->Attribute("id");
                  additionalPayment_.push_back(boost::shared_ptr<ReturnSwapAdditionalPayment>(new ReturnSwapAdditionalPayment(additionalPaymentNode)));
                  additionalPayment_.back()->setID(additionalPaymentIDRef_);
                  IDManager::instance().setID(additionalPaymentIDRef_, additionalPayment_.back());
              }
              else if(additionalPaymentNode->Attribute("href")) { additionalPaymentIDRef_ = additionalPaymentNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { additionalPayment_.push_back(boost::shared_ptr<ReturnSwapAdditionalPayment>(new ReturnSwapAdditionalPayment(additionalPaymentNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- additionalPaymentNode , address : " << additionalPaymentNode << std::endl;
       #endif
   }

   //earlyTerminationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* earlyTerminationNode = xmlNode->FirstChildElement("earlyTermination");

   if(earlyTerminationNode){earlyTerminationIsNull_ = false;}
   else{earlyTerminationIsNull_ = true;}

   if(earlyTerminationNode)
   {
      for(earlyTerminationNode; earlyTerminationNode; earlyTerminationNode = earlyTerminationNode->NextSiblingElement("earlyTermination")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- earlyTerminationNode , address : " << earlyTerminationNode << std::endl;
          #endif
          if(earlyTerminationNode->Attribute("href") || earlyTerminationNode->Attribute("id"))
          {
              if(earlyTerminationNode->Attribute("id"))
              {
                  earlyTerminationIDRef_ = earlyTerminationNode->Attribute("id");
                  earlyTermination_.push_back(boost::shared_ptr<ReturnSwapEarlyTermination>(new ReturnSwapEarlyTermination(earlyTerminationNode)));
                  earlyTermination_.back()->setID(earlyTerminationIDRef_);
                  IDManager::instance().setID(earlyTerminationIDRef_, earlyTermination_.back());
              }
              else if(earlyTerminationNode->Attribute("href")) { earlyTerminationIDRef_ = earlyTerminationNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { earlyTermination_.push_back(boost::shared_ptr<ReturnSwapEarlyTermination>(new ReturnSwapEarlyTermination(earlyTerminationNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- earlyTerminationNode , address : " << earlyTerminationNode << std::endl;
       #endif
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
std::vector<boost::shared_ptr<ReturnSwapAdditionalPayment>> ReturnSwap::getAdditionalPayment()
{
   if(!this->additionalPaymentIsNull_){
        if(additionalPaymentIDRef_ != ""){
             return this->additionalPayment_;
        }else{
             return this->additionalPayment_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<ReturnSwapAdditionalPayment>>();
   }
}
std::vector<boost::shared_ptr<ReturnSwapEarlyTermination>> ReturnSwap::getEarlyTermination()
{
   if(!this->earlyTerminationIsNull_){
        if(earlyTerminationIDRef_ != ""){
             return this->earlyTermination_;
        }else{
             return this->earlyTermination_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<ReturnSwapEarlyTermination>>();
   }
}
boost::shared_ptr<ExtraordinaryEvents> ReturnSwap::getExtraordinaryEvents()
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

