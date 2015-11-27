// CommodityExercisePeriods.cpp 
#include "CommodityExercisePeriods.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CommodityExercisePeriods::CommodityExercisePeriods(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //commencementDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* commencementDateNode = xmlNode->FirstChildElement("commencementDate");

   if(commencementDateNode){commencementDateIsNull_ = false;}
   else{commencementDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- commencementDateNode , address : " << commencementDateNode << std::endl;
   #endif
   if(commencementDateNode)
   {
      if(commencementDateNode->Attribute("href") || commencementDateNode->Attribute("id"))
      {
          if(commencementDateNode->Attribute("id"))
          {
             commencementDateIDRef_ = commencementDateNode->Attribute("id");
             commencementDate_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(commencementDateNode));
             commencementDate_->setID(commencementDateIDRef_);
             IDManager::instance().setID(commencementDateIDRef_,commencementDate_);
          }
          else if(commencementDateNode->Attribute("href")) { commencementDateIDRef_ = commencementDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { commencementDate_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(commencementDateNode));}
   }

   //expirationDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* expirationDateNode = xmlNode->FirstChildElement("expirationDate");

   if(expirationDateNode){expirationDateIsNull_ = false;}
   else{expirationDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- expirationDateNode , address : " << expirationDateNode << std::endl;
   #endif
   if(expirationDateNode)
   {
      if(expirationDateNode->Attribute("href") || expirationDateNode->Attribute("id"))
      {
          if(expirationDateNode->Attribute("id"))
          {
             expirationDateIDRef_ = expirationDateNode->Attribute("id");
             expirationDate_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(expirationDateNode));
             expirationDate_->setID(expirationDateIDRef_);
             IDManager::instance().setID(expirationDateIDRef_,expirationDate_);
          }
          else if(expirationDateNode->Attribute("href")) { expirationDateIDRef_ = expirationDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { expirationDate_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(expirationDateNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<AdjustableOrRelativeDate> CommodityExercisePeriods::getCommencementDate()
{
   if(!this->commencementDateIsNull_){
        if(commencementDateIDRef_ != ""){
             return boost::shared_static_cast<AdjustableOrRelativeDate>(IDManager::instance().getID(commencementDateIDRef_));
        }else{
             return this->commencementDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableOrRelativeDate>();
   }
}
boost::shared_ptr<AdjustableOrRelativeDate> CommodityExercisePeriods::getExpirationDate()
{
   if(!this->expirationDateIsNull_){
        if(expirationDateIDRef_ != ""){
             return boost::shared_static_cast<AdjustableOrRelativeDate>(IDManager::instance().getID(expirationDateIDRef_));
        }else{
             return this->expirationDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableOrRelativeDate>();
   }
}
}

