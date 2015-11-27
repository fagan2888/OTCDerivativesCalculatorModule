// LogPrint.cpp 
#include "LogPrint.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

LogPrint::LogPrint(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //generatedPathLogNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* generatedPathLogNode = xmlNode->FirstChildElement("generatedPathLog");

   if(generatedPathLogNode){generatedPathLogIsNull_ = false;}
   else{generatedPathLogIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- generatedPathLogNode , address : " << generatedPathLogNode << std::endl;
   #endif
   if(generatedPathLogNode)
   {
      if(generatedPathLogNode->Attribute("href") || generatedPathLogNode->Attribute("id"))
      {
          if(generatedPathLogNode->Attribute("id"))
          {
             generatedPathLogIDRef_ = generatedPathLogNode->Attribute("id");
             generatedPathLog_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(generatedPathLogNode));
             generatedPathLog_->setID(generatedPathLogIDRef_);
             IDManager::instance().setID(generatedPathLogIDRef_,generatedPathLog_);
          }
          else if(generatedPathLogNode->Attribute("href")) { generatedPathLogIDRef_ = generatedPathLogNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { generatedPathLog_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(generatedPathLogNode));}
   }

   //payoffCalcLogNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* payoffCalcLogNode = xmlNode->FirstChildElement("payoffCalcLog");

   if(payoffCalcLogNode){payoffCalcLogIsNull_ = false;}
   else{payoffCalcLogIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- payoffCalcLogNode , address : " << payoffCalcLogNode << std::endl;
   #endif
   if(payoffCalcLogNode)
   {
      if(payoffCalcLogNode->Attribute("href") || payoffCalcLogNode->Attribute("id"))
      {
          if(payoffCalcLogNode->Attribute("id"))
          {
             payoffCalcLogIDRef_ = payoffCalcLogNode->Attribute("id");
             payoffCalcLog_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(payoffCalcLogNode));
             payoffCalcLog_->setID(payoffCalcLogIDRef_);
             IDManager::instance().setID(payoffCalcLogIDRef_,payoffCalcLog_);
          }
          else if(payoffCalcLogNode->Attribute("href")) { payoffCalcLogIDRef_ = payoffCalcLogNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { payoffCalcLog_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(payoffCalcLogNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> LogPrint::getGeneratedPathLog()
{
   if(!this->generatedPathLogIsNull_){
        if(generatedPathLogIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeToken>(IDManager::instance().getID(generatedPathLogIDRef_));
        }else{
             return this->generatedPathLog_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> LogPrint::getPayoffCalcLog()
{
   if(!this->payoffCalcLogIsNull_){
        if(payoffCalcLogIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeToken>(IDManager::instance().getID(payoffCalcLogIDRef_));
        }else{
             return this->payoffCalcLog_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

