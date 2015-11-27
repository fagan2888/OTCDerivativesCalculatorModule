// MultipleExercise.cpp 
#include "MultipleExercise.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

MultipleExercise::MultipleExercise(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //notionalReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* notionalReferenceNode = xmlNode->FirstChildElement("notionalReference");

   if(notionalReferenceNode){notionalReferenceIsNull_ = false;}
   else{notionalReferenceIsNull_ = true;}

   if(notionalReferenceNode)
   {
      for(notionalReferenceNode; notionalReferenceNode; notionalReferenceNode = notionalReferenceNode->NextSiblingElement("notionalReference")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- notionalReferenceNode , address : " << notionalReferenceNode << std::endl;
          #endif
          if(notionalReferenceNode->Attribute("href") || notionalReferenceNode->Attribute("id"))
          {
              if(notionalReferenceNode->Attribute("id"))
              {
                  notionalReferenceIDRef_ = notionalReferenceNode->Attribute("id");
                  notionalReference_.push_back(boost::shared_ptr<NotionalReference>(new NotionalReference(notionalReferenceNode)));
                  notionalReference_.back()->setID(notionalReferenceIDRef_);
                  IDManager::instance().setID(notionalReferenceIDRef_, notionalReference_.back());
              }
              else if(notionalReferenceNode->Attribute("href")) { notionalReferenceIDRef_ = notionalReferenceNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { notionalReference_.push_back(boost::shared_ptr<NotionalReference>(new NotionalReference(notionalReferenceNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- notionalReferenceNode , address : " << notionalReferenceNode << std::endl;
       #endif
   }

   //integralMultipleAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* integralMultipleAmountNode = xmlNode->FirstChildElement("integralMultipleAmount");

   if(integralMultipleAmountNode){integralMultipleAmountIsNull_ = false;}
   else{integralMultipleAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- integralMultipleAmountNode , address : " << integralMultipleAmountNode << std::endl;
   #endif
   if(integralMultipleAmountNode)
   {
      if(integralMultipleAmountNode->Attribute("href") || integralMultipleAmountNode->Attribute("id"))
      {
          if(integralMultipleAmountNode->Attribute("id"))
          {
             integralMultipleAmountIDRef_ = integralMultipleAmountNode->Attribute("id");
             integralMultipleAmount_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(integralMultipleAmountNode));
             integralMultipleAmount_->setID(integralMultipleAmountIDRef_);
             IDManager::instance().setID(integralMultipleAmountIDRef_,integralMultipleAmount_);
          }
          else if(integralMultipleAmountNode->Attribute("href")) { integralMultipleAmountIDRef_ = integralMultipleAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { integralMultipleAmount_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(integralMultipleAmountNode));}
   }

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
             minimumNotionalAmount_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(minimumNotionalAmountNode));
             minimumNotionalAmount_->setID(minimumNotionalAmountIDRef_);
             IDManager::instance().setID(minimumNotionalAmountIDRef_,minimumNotionalAmount_);
          }
          else if(minimumNotionalAmountNode->Attribute("href")) { minimumNotionalAmountIDRef_ = minimumNotionalAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { minimumNotionalAmount_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(minimumNotionalAmountNode));}
   }

   //minimumNumberOfOptionsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* minimumNumberOfOptionsNode = xmlNode->FirstChildElement("minimumNumberOfOptions");

   if(minimumNumberOfOptionsNode){minimumNumberOfOptionsIsNull_ = false;}
   else{minimumNumberOfOptionsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- minimumNumberOfOptionsNode , address : " << minimumNumberOfOptionsNode << std::endl;
   #endif
   if(minimumNumberOfOptionsNode)
   {
      if(minimumNumberOfOptionsNode->Attribute("href") || minimumNumberOfOptionsNode->Attribute("id"))
      {
          if(minimumNumberOfOptionsNode->Attribute("id"))
          {
             minimumNumberOfOptionsIDRef_ = minimumNumberOfOptionsNode->Attribute("id");
             minimumNumberOfOptions_ = boost::shared_ptr<XsdTypeNonNegativeInteger>(new XsdTypeNonNegativeInteger(minimumNumberOfOptionsNode));
             minimumNumberOfOptions_->setID(minimumNumberOfOptionsIDRef_);
             IDManager::instance().setID(minimumNumberOfOptionsIDRef_,minimumNumberOfOptions_);
          }
          else if(minimumNumberOfOptionsNode->Attribute("href")) { minimumNumberOfOptionsIDRef_ = minimumNumberOfOptionsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { minimumNumberOfOptions_ = boost::shared_ptr<XsdTypeNonNegativeInteger>(new XsdTypeNonNegativeInteger(minimumNumberOfOptionsNode));}
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
             maximumNotionalAmount_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(maximumNotionalAmountNode));
             maximumNotionalAmount_->setID(maximumNotionalAmountIDRef_);
             IDManager::instance().setID(maximumNotionalAmountIDRef_,maximumNotionalAmount_);
          }
          else if(maximumNotionalAmountNode->Attribute("href")) { maximumNotionalAmountIDRef_ = maximumNotionalAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { maximumNotionalAmount_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(maximumNotionalAmountNode));}
   }

   //maximumNumberOfOptionsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* maximumNumberOfOptionsNode = xmlNode->FirstChildElement("maximumNumberOfOptions");

   if(maximumNumberOfOptionsNode){maximumNumberOfOptionsIsNull_ = false;}
   else{maximumNumberOfOptionsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- maximumNumberOfOptionsNode , address : " << maximumNumberOfOptionsNode << std::endl;
   #endif
   if(maximumNumberOfOptionsNode)
   {
      if(maximumNumberOfOptionsNode->Attribute("href") || maximumNumberOfOptionsNode->Attribute("id"))
      {
          if(maximumNumberOfOptionsNode->Attribute("id"))
          {
             maximumNumberOfOptionsIDRef_ = maximumNumberOfOptionsNode->Attribute("id");
             maximumNumberOfOptions_ = boost::shared_ptr<NonNegativeDecimal>(new NonNegativeDecimal(maximumNumberOfOptionsNode));
             maximumNumberOfOptions_->setID(maximumNumberOfOptionsIDRef_);
             IDManager::instance().setID(maximumNumberOfOptionsIDRef_,maximumNumberOfOptions_);
          }
          else if(maximumNumberOfOptionsNode->Attribute("href")) { maximumNumberOfOptionsIDRef_ = maximumNumberOfOptionsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { maximumNumberOfOptions_ = boost::shared_ptr<NonNegativeDecimal>(new NonNegativeDecimal(maximumNumberOfOptionsNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<NotionalReference>> MultipleExercise::getNotionalReference()
{
   if(!this->notionalReferenceIsNull_){
        if(notionalReferenceIDRef_ != ""){
             return this->notionalReference_;
        }else{
             return this->notionalReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<NotionalReference>>();
   }
}
boost::shared_ptr<XsdTypeDecimal> MultipleExercise::getIntegralMultipleAmount()
{
   if(!this->integralMultipleAmountIsNull_){
        if(integralMultipleAmountIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(integralMultipleAmountIDRef_));
        }else{
             return this->integralMultipleAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<XsdTypeDecimal> MultipleExercise::getMinimumNotionalAmount()
{
   if(!this->minimumNotionalAmountIsNull_){
        if(minimumNotionalAmountIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(minimumNotionalAmountIDRef_));
        }else{
             return this->minimumNotionalAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<XsdTypeNonNegativeInteger> MultipleExercise::getMinimumNumberOfOptions()
{
   if(!this->minimumNumberOfOptionsIsNull_){
        if(minimumNumberOfOptionsIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeNonNegativeInteger>(IDManager::instance().getID(minimumNumberOfOptionsIDRef_));
        }else{
             return this->minimumNumberOfOptions_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeNonNegativeInteger>();
   }
}
boost::shared_ptr<XsdTypeDecimal> MultipleExercise::getMaximumNotionalAmount()
{
   if(!this->maximumNotionalAmountIsNull_){
        if(maximumNotionalAmountIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(maximumNotionalAmountIDRef_));
        }else{
             return this->maximumNotionalAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<NonNegativeDecimal> MultipleExercise::getMaximumNumberOfOptions()
{
   if(!this->maximumNumberOfOptionsIsNull_){
        if(maximumNumberOfOptionsIDRef_ != ""){
             return boost::shared_static_cast<NonNegativeDecimal>(IDManager::instance().getID(maximumNumberOfOptionsIDRef_));
        }else{
             return this->maximumNumberOfOptions_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NonNegativeDecimal>();
   }
}
}

