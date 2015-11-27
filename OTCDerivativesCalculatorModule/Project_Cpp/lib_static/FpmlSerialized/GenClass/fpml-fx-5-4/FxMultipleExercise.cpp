// FxMultipleExercise.cpp 
#include "FxMultipleExercise.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FxMultipleExercise::FxMultipleExercise(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //minimumNotionalAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* minimumNotionalAmountNode = xmlNode->FirstChildElement("minimumNotionalAmount");

   if(minimumNotionalAmountNode){minimumNotionalAmountIsNull_ = false;}
   else{minimumNotionalAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- minimumNotionalAmountNode , address : " << minimumNotionalAmountNode << std::endl;
   #endif
   if(minimumNotionalAmountNode)
   {
      if(minimumNotionalAmountNode->Attribute("href") || minimumNotionalAmountNode->Attribute("id"))
      {
          if(minimumNotionalAmountNode->Attribute("id"))
          {
             minimumNotionalAmountIDRef_ = minimumNotionalAmountNode->Attribute("id");
             minimumNotionalAmount_ = boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(minimumNotionalAmountNode));
             minimumNotionalAmount_->setID(minimumNotionalAmountIDRef_);
             IDManager::instance().setID(minimumNotionalAmountIDRef_,minimumNotionalAmount_);
          }
          else if(minimumNotionalAmountNode->Attribute("href")) { minimumNotionalAmountIDRef_ = minimumNotionalAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { minimumNotionalAmount_ = boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(minimumNotionalAmountNode));}
   }

   //maximumNotionalAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* maximumNotionalAmountNode = xmlNode->FirstChildElement("maximumNotionalAmount");

   if(maximumNotionalAmountNode){maximumNotionalAmountIsNull_ = false;}
   else{maximumNotionalAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- maximumNotionalAmountNode , address : " << maximumNotionalAmountNode << std::endl;
   #endif
   if(maximumNotionalAmountNode)
   {
      if(maximumNotionalAmountNode->Attribute("href") || maximumNotionalAmountNode->Attribute("id"))
      {
          if(maximumNotionalAmountNode->Attribute("id"))
          {
             maximumNotionalAmountIDRef_ = maximumNotionalAmountNode->Attribute("id");
             maximumNotionalAmount_ = boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(maximumNotionalAmountNode));
             maximumNotionalAmount_->setID(maximumNotionalAmountIDRef_);
             IDManager::instance().setID(maximumNotionalAmountIDRef_,maximumNotionalAmount_);
          }
          else if(maximumNotionalAmountNode->Attribute("href")) { maximumNotionalAmountIDRef_ = maximumNotionalAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { maximumNotionalAmount_ = boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(maximumNotionalAmountNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<NonNegativeMoney> FxMultipleExercise::getMinimumNotionalAmount()
{
   if(!this->minimumNotionalAmountIsNull_){
        if(minimumNotionalAmountIDRef_ != ""){
             return boost::shared_static_cast<NonNegativeMoney>(IDManager::instance().getID(minimumNotionalAmountIDRef_));
        }else{
             return this->minimumNotionalAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NonNegativeMoney>();
   }
}
boost::shared_ptr<NonNegativeMoney> FxMultipleExercise::getMaximumNotionalAmount()
{
   if(!this->maximumNotionalAmountIsNull_){
        if(maximumNotionalAmountIDRef_ != ""){
             return boost::shared_static_cast<NonNegativeMoney>(IDManager::instance().getID(maximumNotionalAmountIDRef_));
        }else{
             return this->maximumNotionalAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NonNegativeMoney>();
   }
}
}

