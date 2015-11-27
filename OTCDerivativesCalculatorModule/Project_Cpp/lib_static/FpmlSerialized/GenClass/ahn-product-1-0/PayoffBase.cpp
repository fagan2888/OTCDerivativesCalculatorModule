// PayoffBase.cpp 
#include "PayoffBase.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

PayoffBase::PayoffBase(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //payoffDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* payoffDateNode = xmlNode->FirstChildElement("payoffDate");

   if(payoffDateNode){payoffDateIsNull_ = false;}
   else{payoffDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- payoffDateNode , address : " << payoffDateNode << std::endl;
   #endif
   if(payoffDateNode)
   {
      if(payoffDateNode->Attribute("href") || payoffDateNode->Attribute("id"))
      {
          if(payoffDateNode->Attribute("id"))
          {
             payoffDateIDRef_ = payoffDateNode->Attribute("id");
             payoffDate_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(payoffDateNode));
             payoffDate_->setID(payoffDateIDRef_);
             IDManager::instance().setID(payoffDateIDRef_,payoffDate_);
          }
          else if(payoffDateNode->Attribute("href")) { payoffDateIDRef_ = payoffDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { payoffDate_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(payoffDateNode));}
   }

   //constPayoffNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* constPayoffNode = xmlNode->FirstChildElement("constPayoff");

   if(constPayoffNode){constPayoffIsNull_ = false;}
   else{constPayoffIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- constPayoffNode , address : " << constPayoffNode << std::endl;
   #endif
   if(constPayoffNode)
   {
      if(constPayoffNode->Attribute("href") || constPayoffNode->Attribute("id"))
      {
          if(constPayoffNode->Attribute("id"))
          {
             constPayoffIDRef_ = constPayoffNode->Attribute("id");
             constPayoff_ = boost::shared_ptr<ConstPayoff>(new ConstPayoff(constPayoffNode));
             constPayoff_->setID(constPayoffIDRef_);
             IDManager::instance().setID(constPayoffIDRef_,constPayoff_);
          }
          else if(constPayoffNode->Attribute("href")) { constPayoffIDRef_ = constPayoffNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { constPayoff_ = boost::shared_ptr<ConstPayoff>(new ConstPayoff(constPayoffNode));}
   }

   //nullPayoffNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* nullPayoffNode = xmlNode->FirstChildElement("nullPayoff");

   if(nullPayoffNode){nullPayoffIsNull_ = false;}
   else{nullPayoffIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- nullPayoffNode , address : " << nullPayoffNode << std::endl;
   #endif
   if(nullPayoffNode)
   {
      if(nullPayoffNode->Attribute("href") || nullPayoffNode->Attribute("id"))
      {
          if(nullPayoffNode->Attribute("id"))
          {
             nullPayoffIDRef_ = nullPayoffNode->Attribute("id");
             nullPayoff_ = boost::shared_ptr<NullPayoff>(new NullPayoff(nullPayoffNode));
             nullPayoff_->setID(nullPayoffIDRef_);
             IDManager::instance().setID(nullPayoffIDRef_,nullPayoff_);
          }
          else if(nullPayoffNode->Attribute("href")) { nullPayoffIDRef_ = nullPayoffNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { nullPayoff_ = boost::shared_ptr<NullPayoff>(new NullPayoff(nullPayoffNode));}
   }

   //averPayoffNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* averPayoffNode = xmlNode->FirstChildElement("averPayoff");

   if(averPayoffNode){averPayoffIsNull_ = false;}
   else{averPayoffIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- averPayoffNode , address : " << averPayoffNode << std::endl;
   #endif
   if(averPayoffNode)
   {
      if(averPayoffNode->Attribute("href") || averPayoffNode->Attribute("id"))
      {
          if(averPayoffNode->Attribute("id"))
          {
             averPayoffIDRef_ = averPayoffNode->Attribute("id");
             averPayoff_ = boost::shared_ptr<AverPayoff>(new AverPayoff(averPayoffNode));
             averPayoff_->setID(averPayoffIDRef_);
             IDManager::instance().setID(averPayoffIDRef_,averPayoff_);
          }
          else if(averPayoffNode->Attribute("href")) { averPayoffIDRef_ = averPayoffNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { averPayoff_ = boost::shared_ptr<AverPayoff>(new AverPayoff(averPayoffNode));}
   }

   //exprPayoffNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* exprPayoffNode = xmlNode->FirstChildElement("exprPayoff");

   if(exprPayoffNode){exprPayoffIsNull_ = false;}
   else{exprPayoffIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- exprPayoffNode , address : " << exprPayoffNode << std::endl;
   #endif
   if(exprPayoffNode)
   {
      if(exprPayoffNode->Attribute("href") || exprPayoffNode->Attribute("id"))
      {
          if(exprPayoffNode->Attribute("id"))
          {
             exprPayoffIDRef_ = exprPayoffNode->Attribute("id");
             exprPayoff_ = boost::shared_ptr<ExprPayoff>(new ExprPayoff(exprPayoffNode));
             exprPayoff_->setID(exprPayoffIDRef_);
             IDManager::instance().setID(exprPayoffIDRef_,exprPayoff_);
          }
          else if(exprPayoffNode->Attribute("href")) { exprPayoffIDRef_ = exprPayoffNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { exprPayoff_ = boost::shared_ptr<ExprPayoff>(new ExprPayoff(exprPayoffNode));}
   }

   //preFixPayoffNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* preFixPayoffNode = xmlNode->FirstChildElement("preFixPayoff");

   if(preFixPayoffNode){preFixPayoffIsNull_ = false;}
   else{preFixPayoffIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- preFixPayoffNode , address : " << preFixPayoffNode << std::endl;
   #endif
   if(preFixPayoffNode)
   {
      if(preFixPayoffNode->Attribute("href") || preFixPayoffNode->Attribute("id"))
      {
          if(preFixPayoffNode->Attribute("id"))
          {
             preFixPayoffIDRef_ = preFixPayoffNode->Attribute("id");
             preFixPayoff_ = boost::shared_ptr<PreFixPayoff>(new PreFixPayoff(preFixPayoffNode));
             preFixPayoff_->setID(preFixPayoffIDRef_);
             IDManager::instance().setID(preFixPayoffIDRef_,preFixPayoff_);
          }
          else if(preFixPayoffNode->Attribute("href")) { preFixPayoffIDRef_ = preFixPayoffNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { preFixPayoff_ = boost::shared_ptr<PreFixPayoff>(new PreFixPayoff(preFixPayoffNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> PayoffBase::getPayoffDate()
{
   if(!this->payoffDateIsNull_){
        if(payoffDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeToken>(IDManager::instance().getID(payoffDateIDRef_));
        }else{
             return this->payoffDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<ConstPayoff> PayoffBase::getConstPayoff()
{
   if(!this->constPayoffIsNull_){
        if(constPayoffIDRef_ != ""){
             return boost::shared_static_cast<ConstPayoff>(IDManager::instance().getID(constPayoffIDRef_));
        }else{
             return this->constPayoff_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ConstPayoff>();
   }
}
boost::shared_ptr<NullPayoff> PayoffBase::getNullPayoff()
{
   if(!this->nullPayoffIsNull_){
        if(nullPayoffIDRef_ != ""){
             return boost::shared_static_cast<NullPayoff>(IDManager::instance().getID(nullPayoffIDRef_));
        }else{
             return this->nullPayoff_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NullPayoff>();
   }
}
boost::shared_ptr<AverPayoff> PayoffBase::getAverPayoff()
{
   if(!this->averPayoffIsNull_){
        if(averPayoffIDRef_ != ""){
             return boost::shared_static_cast<AverPayoff>(IDManager::instance().getID(averPayoffIDRef_));
        }else{
             return this->averPayoff_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AverPayoff>();
   }
}
boost::shared_ptr<ExprPayoff> PayoffBase::getExprPayoff()
{
   if(!this->exprPayoffIsNull_){
        if(exprPayoffIDRef_ != ""){
             return boost::shared_static_cast<ExprPayoff>(IDManager::instance().getID(exprPayoffIDRef_));
        }else{
             return this->exprPayoff_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ExprPayoff>();
   }
}
boost::shared_ptr<PreFixPayoff> PayoffBase::getPreFixPayoff()
{
   if(!this->preFixPayoffIsNull_){
        if(preFixPayoffIDRef_ != ""){
             return boost::shared_static_cast<PreFixPayoff>(IDManager::instance().getID(preFixPayoffIDRef_));
        }else{
             return this->preFixPayoff_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PreFixPayoff>();
   }
}
}

