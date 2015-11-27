// ReturnSwapNotional.cpp 
#include "ReturnSwapNotional.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ReturnSwapNotional::ReturnSwapNotional(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //relativeNotionalAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* relativeNotionalAmountNode = xmlNode->FirstChildElement("relativeNotionalAmount");

   if(relativeNotionalAmountNode){relativeNotionalAmountIsNull_ = false;}
   else{relativeNotionalAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- relativeNotionalAmountNode , address : " << relativeNotionalAmountNode << std::endl;
   #endif
   if(relativeNotionalAmountNode)
   {
      if(relativeNotionalAmountNode->Attribute("href") || relativeNotionalAmountNode->Attribute("id"))
      {
          if(relativeNotionalAmountNode->Attribute("id"))
          {
             relativeNotionalAmountIDRef_ = relativeNotionalAmountNode->Attribute("id");
             relativeNotionalAmount_ = boost::shared_ptr<ReturnSwapNotionalAmountReference>(new ReturnSwapNotionalAmountReference(relativeNotionalAmountNode));
             relativeNotionalAmount_->setID(relativeNotionalAmountIDRef_);
             IDManager::instance().setID(relativeNotionalAmountIDRef_,relativeNotionalAmount_);
          }
          else if(relativeNotionalAmountNode->Attribute("href")) { relativeNotionalAmountIDRef_ = relativeNotionalAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { relativeNotionalAmount_ = boost::shared_ptr<ReturnSwapNotionalAmountReference>(new ReturnSwapNotionalAmountReference(relativeNotionalAmountNode));}
   }

   //relativeDeterminationMethodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* relativeDeterminationMethodNode = xmlNode->FirstChildElement("relativeDeterminationMethod");

   if(relativeDeterminationMethodNode){relativeDeterminationMethodIsNull_ = false;}
   else{relativeDeterminationMethodIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- relativeDeterminationMethodNode , address : " << relativeDeterminationMethodNode << std::endl;
   #endif
   if(relativeDeterminationMethodNode)
   {
      if(relativeDeterminationMethodNode->Attribute("href") || relativeDeterminationMethodNode->Attribute("id"))
      {
          if(relativeDeterminationMethodNode->Attribute("id"))
          {
             relativeDeterminationMethodIDRef_ = relativeDeterminationMethodNode->Attribute("id");
             relativeDeterminationMethod_ = boost::shared_ptr<DeterminationMethodReference>(new DeterminationMethodReference(relativeDeterminationMethodNode));
             relativeDeterminationMethod_->setID(relativeDeterminationMethodIDRef_);
             IDManager::instance().setID(relativeDeterminationMethodIDRef_,relativeDeterminationMethod_);
          }
          else if(relativeDeterminationMethodNode->Attribute("href")) { relativeDeterminationMethodIDRef_ = relativeDeterminationMethodNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { relativeDeterminationMethod_ = boost::shared_ptr<DeterminationMethodReference>(new DeterminationMethodReference(relativeDeterminationMethodNode));}
   }

   //determinationMethodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* determinationMethodNode = xmlNode->FirstChildElement("determinationMethod");

   if(determinationMethodNode){determinationMethodIsNull_ = false;}
   else{determinationMethodIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- determinationMethodNode , address : " << determinationMethodNode << std::endl;
   #endif
   if(determinationMethodNode)
   {
      if(determinationMethodNode->Attribute("href") || determinationMethodNode->Attribute("id"))
      {
          if(determinationMethodNode->Attribute("id"))
          {
             determinationMethodIDRef_ = determinationMethodNode->Attribute("id");
             determinationMethod_ = boost::shared_ptr<DeterminationMethod>(new DeterminationMethod(determinationMethodNode));
             determinationMethod_->setID(determinationMethodIDRef_);
             IDManager::instance().setID(determinationMethodIDRef_,determinationMethod_);
          }
          else if(determinationMethodNode->Attribute("href")) { determinationMethodIDRef_ = determinationMethodNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { determinationMethod_ = boost::shared_ptr<DeterminationMethod>(new DeterminationMethod(determinationMethodNode));}
   }

   //notionalAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* notionalAmountNode = xmlNode->FirstChildElement("notionalAmount");

   if(notionalAmountNode){notionalAmountIsNull_ = false;}
   else{notionalAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- notionalAmountNode , address : " << notionalAmountNode << std::endl;
   #endif
   if(notionalAmountNode)
   {
      if(notionalAmountNode->Attribute("href") || notionalAmountNode->Attribute("id"))
      {
          if(notionalAmountNode->Attribute("id"))
          {
             notionalAmountIDRef_ = notionalAmountNode->Attribute("id");
             notionalAmount_ = boost::shared_ptr<NotionalAmount>(new NotionalAmount(notionalAmountNode));
             notionalAmount_->setID(notionalAmountIDRef_);
             IDManager::instance().setID(notionalAmountIDRef_,notionalAmount_);
          }
          else if(notionalAmountNode->Attribute("href")) { notionalAmountIDRef_ = notionalAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { notionalAmount_ = boost::shared_ptr<NotionalAmount>(new NotionalAmount(notionalAmountNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<ReturnSwapNotionalAmountReference> ReturnSwapNotional::getRelativeNotionalAmount()
{
   if(!this->relativeNotionalAmountIsNull_){
        if(relativeNotionalAmountIDRef_ != ""){
             return boost::shared_static_cast<ReturnSwapNotionalAmountReference>(IDManager::instance().getID(relativeNotionalAmountIDRef_));
        }else{
             return this->relativeNotionalAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ReturnSwapNotionalAmountReference>();
   }
}
boost::shared_ptr<DeterminationMethodReference> ReturnSwapNotional::getRelativeDeterminationMethod()
{
   if(!this->relativeDeterminationMethodIsNull_){
        if(relativeDeterminationMethodIDRef_ != ""){
             return boost::shared_static_cast<DeterminationMethodReference>(IDManager::instance().getID(relativeDeterminationMethodIDRef_));
        }else{
             return this->relativeDeterminationMethod_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DeterminationMethodReference>();
   }
}
boost::shared_ptr<DeterminationMethod> ReturnSwapNotional::getDeterminationMethod()
{
   if(!this->determinationMethodIsNull_){
        if(determinationMethodIDRef_ != ""){
             return boost::shared_static_cast<DeterminationMethod>(IDManager::instance().getID(determinationMethodIDRef_));
        }else{
             return this->determinationMethod_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DeterminationMethod>();
   }
}
boost::shared_ptr<NotionalAmount> ReturnSwapNotional::getNotionalAmount()
{
   if(!this->notionalAmountIsNull_){
        if(notionalAmountIDRef_ != ""){
             return boost::shared_static_cast<NotionalAmount>(IDManager::instance().getID(notionalAmountIDRef_));
        }else{
             return this->notionalAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NotionalAmount>();
   }
}
}

