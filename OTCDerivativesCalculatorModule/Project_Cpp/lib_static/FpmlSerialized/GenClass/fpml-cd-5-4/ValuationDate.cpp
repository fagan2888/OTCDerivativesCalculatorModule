// ValuationDate.cpp 
#include "ValuationDate.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ValuationDate::ValuationDate(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //singleValuationDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* singleValuationDateNode = xmlNode->FirstChildElement("singleValuationDate");

   if(singleValuationDateNode){singleValuationDateIsNull_ = false;}
   else{singleValuationDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- singleValuationDateNode , address : " << singleValuationDateNode << std::endl;
   #endif
   if(singleValuationDateNode)
   {
      if(singleValuationDateNode->Attribute("href") || singleValuationDateNode->Attribute("id"))
      {
          if(singleValuationDateNode->Attribute("id"))
          {
             singleValuationDateIDRef_ = singleValuationDateNode->Attribute("id");
             singleValuationDate_ = boost::shared_ptr<SingleValuationDate>(new SingleValuationDate(singleValuationDateNode));
             singleValuationDate_->setID(singleValuationDateIDRef_);
             IDManager::instance().setID(singleValuationDateIDRef_,singleValuationDate_);
          }
          else if(singleValuationDateNode->Attribute("href")) { singleValuationDateIDRef_ = singleValuationDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { singleValuationDate_ = boost::shared_ptr<SingleValuationDate>(new SingleValuationDate(singleValuationDateNode));}
   }

   //multipleValuationDatesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* multipleValuationDatesNode = xmlNode->FirstChildElement("multipleValuationDates");

   if(multipleValuationDatesNode){multipleValuationDatesIsNull_ = false;}
   else{multipleValuationDatesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- multipleValuationDatesNode , address : " << multipleValuationDatesNode << std::endl;
   #endif
   if(multipleValuationDatesNode)
   {
      if(multipleValuationDatesNode->Attribute("href") || multipleValuationDatesNode->Attribute("id"))
      {
          if(multipleValuationDatesNode->Attribute("id"))
          {
             multipleValuationDatesIDRef_ = multipleValuationDatesNode->Attribute("id");
             multipleValuationDates_ = boost::shared_ptr<MultipleValuationDates>(new MultipleValuationDates(multipleValuationDatesNode));
             multipleValuationDates_->setID(multipleValuationDatesIDRef_);
             IDManager::instance().setID(multipleValuationDatesIDRef_,multipleValuationDates_);
          }
          else if(multipleValuationDatesNode->Attribute("href")) { multipleValuationDatesIDRef_ = multipleValuationDatesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { multipleValuationDates_ = boost::shared_ptr<MultipleValuationDates>(new MultipleValuationDates(multipleValuationDatesNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<SingleValuationDate> ValuationDate::getSingleValuationDate()
{
   if(!this->singleValuationDateIsNull_){
        if(singleValuationDateIDRef_ != ""){
             return boost::shared_static_cast<SingleValuationDate>(IDManager::instance().getID(singleValuationDateIDRef_));
        }else{
             return this->singleValuationDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<SingleValuationDate>();
   }
}
boost::shared_ptr<MultipleValuationDates> ValuationDate::getMultipleValuationDates()
{
   if(!this->multipleValuationDatesIsNull_){
        if(multipleValuationDatesIDRef_ != ""){
             return boost::shared_static_cast<MultipleValuationDates>(IDManager::instance().getID(multipleValuationDatesIDRef_));
        }else{
             return this->multipleValuationDates_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<MultipleValuationDates>();
   }
}
}

