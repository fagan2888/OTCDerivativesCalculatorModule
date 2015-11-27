// IndexCalculationTime.cpp 
#include "IndexCalculationTime.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

IndexCalculationTime::IndexCalculationTime(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //returnTimeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* returnTimeNode = xmlNode->FirstChildElement("returnTime");

   if(returnTimeNode){returnTimeIsNull_ = false;}
   else{returnTimeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- returnTimeNode , address : " << returnTimeNode << std::endl;
   #endif
   if(returnTimeNode)
   {
      if(returnTimeNode->Attribute("href") || returnTimeNode->Attribute("id"))
      {
          if(returnTimeNode->Attribute("id"))
          {
             returnTimeIDRef_ = returnTimeNode->Attribute("id");
             returnTime_ = boost::shared_ptr<ReturnTranTime>(new ReturnTranTime(returnTimeNode));
             returnTime_->setID(returnTimeIDRef_);
             IDManager::instance().setID(returnTimeIDRef_,returnTime_);
          }
          else if(returnTimeNode->Attribute("href")) { returnTimeIDRef_ = returnTimeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { returnTime_ = boost::shared_ptr<ReturnTranTime>(new ReturnTranTime(returnTimeNode));}
   }

   //minimumNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* minimumNode = xmlNode->FirstChildElement("minimum");

   if(minimumNode){minimumIsNull_ = false;}
   else{minimumIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- minimumNode , address : " << minimumNode << std::endl;
   #endif
   if(minimumNode)
   {
      if(minimumNode->Attribute("href") || minimumNode->Attribute("id"))
      {
          if(minimumNode->Attribute("id"))
          {
             minimumIDRef_ = minimumNode->Attribute("id");
             minimum_ = boost::shared_ptr<MinimumTran>(new MinimumTran(minimumNode));
             minimum_->setID(minimumIDRef_);
             IDManager::instance().setID(minimumIDRef_,minimum_);
          }
          else if(minimumNode->Attribute("href")) { minimumIDRef_ = minimumNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { minimum_ = boost::shared_ptr<MinimumTran>(new MinimumTran(minimumNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<ReturnTranTime> IndexCalculationTime::getReturnTime()
{
   if(!this->returnTimeIsNull_){
        if(returnTimeIDRef_ != ""){
             return boost::shared_static_cast<ReturnTranTime>(IDManager::instance().getID(returnTimeIDRef_));
        }else{
             return this->returnTime_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ReturnTranTime>();
   }
}
boost::shared_ptr<MinimumTran> IndexCalculationTime::getMinimum()
{
   if(!this->minimumIsNull_){
        if(minimumIDRef_ != ""){
             return boost::shared_static_cast<MinimumTran>(IDManager::instance().getID(minimumIDRef_));
        }else{
             return this->minimum_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<MinimumTran>();
   }
}
}

