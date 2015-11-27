// IndexCalculation.cpp 
#include "IndexCalculation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

IndexCalculation::IndexCalculation(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //timeTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* timeTypeNode = xmlNode->FirstChildElement("timeType");

   if(timeTypeNode){timeTypeIsNull_ = false;}
   else{timeTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- timeTypeNode , address : " << timeTypeNode << std::endl;
   #endif
   if(timeTypeNode)
   {
      if(timeTypeNode->Attribute("href") || timeTypeNode->Attribute("id"))
      {
          if(timeTypeNode->Attribute("id"))
          {
             timeTypeIDRef_ = timeTypeNode->Attribute("id");
             timeType_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(timeTypeNode));
             timeType_->setID(timeTypeIDRef_);
             IDManager::instance().setID(timeTypeIDRef_,timeType_);
          }
          else if(timeTypeNode->Attribute("href")) { timeTypeIDRef_ = timeTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { timeType_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(timeTypeNode));}
   }

   //returnNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* returnNode = xmlNode->FirstChildElement("return");

   if(returnNode){returnIsNull_ = false;}
   else{returnIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- returnNode , address : " << returnNode << std::endl;
   #endif
   if(returnNode)
   {
      if(returnNode->Attribute("href") || returnNode->Attribute("id"))
      {
          if(returnNode->Attribute("id"))
          {
             returnIDRef_ = returnNode->Attribute("id");
             return_ = boost::shared_ptr<ReturnTran>(new ReturnTran(returnNode));
             return_->setID(returnIDRef_);
             IDManager::instance().setID(returnIDRef_,return_);
          }
          else if(returnNode->Attribute("href")) { returnIDRef_ = returnNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { return_ = boost::shared_ptr<ReturnTran>(new ReturnTran(returnNode));}
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

   //basketAverNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* basketAverNode = xmlNode->FirstChildElement("basketAver");

   if(basketAverNode){basketAverIsNull_ = false;}
   else{basketAverIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- basketAverNode , address : " << basketAverNode << std::endl;
   #endif
   if(basketAverNode)
   {
      if(basketAverNode->Attribute("href") || basketAverNode->Attribute("id"))
      {
          if(basketAverNode->Attribute("id"))
          {
             basketAverIDRef_ = basketAverNode->Attribute("id");
             basketAver_ = boost::shared_ptr<BasketAver>(new BasketAver(basketAverNode));
             basketAver_->setID(basketAverIDRef_);
             IDManager::instance().setID(basketAverIDRef_,basketAver_);
          }
          else if(basketAverNode->Attribute("href")) { basketAverIDRef_ = basketAverNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { basketAver_ = boost::shared_ptr<BasketAver>(new BasketAver(basketAverNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeBoolean> IndexCalculation::getTimeType()
{
   if(!this->timeTypeIsNull_){
        if(timeTypeIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(timeTypeIDRef_));
        }else{
             return this->timeType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<ReturnTran> IndexCalculation::getReturn()
{
   if(!this->returnIsNull_){
        if(returnIDRef_ != ""){
             return boost::shared_static_cast<ReturnTran>(IDManager::instance().getID(returnIDRef_));
        }else{
             return this->return_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ReturnTran>();
   }
}
boost::shared_ptr<MinimumTran> IndexCalculation::getMinimum()
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
boost::shared_ptr<BasketAver> IndexCalculation::getBasketAver()
{
   if(!this->basketAverIsNull_){
        if(basketAverIDRef_ != ""){
             return boost::shared_static_cast<BasketAver>(IDManager::instance().getID(basketAverIDRef_));
        }else{
             return this->basketAver_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BasketAver>();
   }
}
}

