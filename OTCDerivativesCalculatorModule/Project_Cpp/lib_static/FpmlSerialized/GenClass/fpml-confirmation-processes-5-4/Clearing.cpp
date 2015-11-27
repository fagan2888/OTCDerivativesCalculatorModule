// Clearing.cpp 
#include "Clearing.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Clearing::Clearing(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //submittedNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* submittedNode = xmlNode->FirstChildElement("submitted");

   if(submittedNode){submittedIsNull_ = false;}
   else{submittedIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- submittedNode , address : " << submittedNode << std::endl;
   #endif
   if(submittedNode)
   {
      if(submittedNode->Attribute("href") || submittedNode->Attribute("id"))
      {
          if(submittedNode->Attribute("id"))
          {
             submittedIDRef_ = submittedNode->Attribute("id");
             submitted_ = boost::shared_ptr<TradeWrapper>(new TradeWrapper(submittedNode));
             submitted_->setID(submittedIDRef_);
             IDManager::instance().setID(submittedIDRef_,submitted_);
          }
          else if(submittedNode->Attribute("href")) { submittedIDRef_ = submittedNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { submitted_ = boost::shared_ptr<TradeWrapper>(new TradeWrapper(submittedNode));}
   }

   //clearedNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* clearedNode = xmlNode->FirstChildElement("cleared");

   if(clearedNode){clearedIsNull_ = false;}
   else{clearedIsNull_ = true;}

   if(clearedNode)
   {
      for(clearedNode; clearedNode; clearedNode = clearedNode->NextSiblingElement("cleared")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- clearedNode , address : " << clearedNode << std::endl;
          #endif
          if(clearedNode->Attribute("href") || clearedNode->Attribute("id"))
          {
              if(clearedNode->Attribute("id"))
              {
                  clearedIDRef_ = clearedNode->Attribute("id");
                  cleared_.push_back(boost::shared_ptr<TradeWrapper>(new TradeWrapper(clearedNode)));
                  cleared_.back()->setID(clearedIDRef_);
                  IDManager::instance().setID(clearedIDRef_, cleared_.back());
              }
              else if(clearedNode->Attribute("href")) { clearedIDRef_ = clearedNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { cleared_.push_back(boost::shared_ptr<TradeWrapper>(new TradeWrapper(clearedNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- clearedNode , address : " << clearedNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<TradeWrapper> Clearing::getSubmitted()
{
   if(!this->submittedIsNull_){
        if(submittedIDRef_ != ""){
             return boost::shared_static_cast<TradeWrapper>(IDManager::instance().getID(submittedIDRef_));
        }else{
             return this->submitted_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<TradeWrapper>();
   }
}
std::vector<boost::shared_ptr<TradeWrapper>> Clearing::getCleared()
{
   if(!this->clearedIsNull_){
        if(clearedIDRef_ != ""){
             return this->cleared_;
        }else{
             return this->cleared_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<TradeWrapper>>();
   }
}
}

