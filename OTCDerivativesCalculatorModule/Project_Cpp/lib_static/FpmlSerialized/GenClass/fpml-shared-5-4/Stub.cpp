// Stub.cpp 
#include "Stub.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Stub::Stub(TiXmlNode* xmlNode)
: StubValue(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //stubStartDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* stubStartDateNode = xmlNode->FirstChildElement("stubStartDate");

   if(stubStartDateNode){stubStartDateIsNull_ = false;}
   else{stubStartDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- stubStartDateNode , address : " << stubStartDateNode << std::endl;
   #endif
   if(stubStartDateNode)
   {
      if(stubStartDateNode->Attribute("href") || stubStartDateNode->Attribute("id"))
      {
          if(stubStartDateNode->Attribute("id"))
          {
             stubStartDateIDRef_ = stubStartDateNode->Attribute("id");
             stubStartDate_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(stubStartDateNode));
             stubStartDate_->setID(stubStartDateIDRef_);
             IDManager::instance().setID(stubStartDateIDRef_,stubStartDate_);
          }
          else if(stubStartDateNode->Attribute("href")) { stubStartDateIDRef_ = stubStartDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { stubStartDate_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(stubStartDateNode));}
   }

   //stubEndDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* stubEndDateNode = xmlNode->FirstChildElement("stubEndDate");

   if(stubEndDateNode){stubEndDateIsNull_ = false;}
   else{stubEndDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- stubEndDateNode , address : " << stubEndDateNode << std::endl;
   #endif
   if(stubEndDateNode)
   {
      if(stubEndDateNode->Attribute("href") || stubEndDateNode->Attribute("id"))
      {
          if(stubEndDateNode->Attribute("id"))
          {
             stubEndDateIDRef_ = stubEndDateNode->Attribute("id");
             stubEndDate_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(stubEndDateNode));
             stubEndDate_->setID(stubEndDateIDRef_);
             IDManager::instance().setID(stubEndDateIDRef_,stubEndDate_);
          }
          else if(stubEndDateNode->Attribute("href")) { stubEndDateIDRef_ = stubEndDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { stubEndDate_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(stubEndDateNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<AdjustableOrRelativeDate> Stub::getStubStartDate()
{
   if(!this->stubStartDateIsNull_){
        if(stubStartDateIDRef_ != ""){
             return boost::shared_static_cast<AdjustableOrRelativeDate>(IDManager::instance().getID(stubStartDateIDRef_));
        }else{
             return this->stubStartDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableOrRelativeDate>();
   }
}
boost::shared_ptr<AdjustableOrRelativeDate> Stub::getStubEndDate()
{
   if(!this->stubEndDateIsNull_){
        if(stubEndDateIDRef_ != ""){
             return boost::shared_static_cast<AdjustableOrRelativeDate>(IDManager::instance().getID(stubEndDateIDRef_));
        }else{
             return this->stubEndDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableOrRelativeDate>();
   }
}
}

