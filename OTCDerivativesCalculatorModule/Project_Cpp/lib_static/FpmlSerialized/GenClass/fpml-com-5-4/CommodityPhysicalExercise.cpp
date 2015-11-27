// CommodityPhysicalExercise.cpp 
#include "CommodityPhysicalExercise.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CommodityPhysicalExercise::CommodityPhysicalExercise(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //americanExerciseNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* americanExerciseNode = xmlNode->FirstChildElement("americanExercise");

   if(americanExerciseNode){americanExerciseIsNull_ = false;}
   else{americanExerciseIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- americanExerciseNode , address : " << americanExerciseNode << std::endl;
   #endif
   if(americanExerciseNode)
   {
      if(americanExerciseNode->Attribute("href") || americanExerciseNode->Attribute("id"))
      {
          if(americanExerciseNode->Attribute("id"))
          {
             americanExerciseIDRef_ = americanExerciseNode->Attribute("id");
             americanExercise_ = boost::shared_ptr<CommodityPhysicalAmericanExercise>(new CommodityPhysicalAmericanExercise(americanExerciseNode));
             americanExercise_->setID(americanExerciseIDRef_);
             IDManager::instance().setID(americanExerciseIDRef_,americanExercise_);
          }
          else if(americanExerciseNode->Attribute("href")) { americanExerciseIDRef_ = americanExerciseNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { americanExercise_ = boost::shared_ptr<CommodityPhysicalAmericanExercise>(new CommodityPhysicalAmericanExercise(americanExerciseNode));}
   }

   //europeanExerciseNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* europeanExerciseNode = xmlNode->FirstChildElement("europeanExercise");

   if(europeanExerciseNode){europeanExerciseIsNull_ = false;}
   else{europeanExerciseIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- europeanExerciseNode , address : " << europeanExerciseNode << std::endl;
   #endif
   if(europeanExerciseNode)
   {
      if(europeanExerciseNode->Attribute("href") || europeanExerciseNode->Attribute("id"))
      {
          if(europeanExerciseNode->Attribute("id"))
          {
             europeanExerciseIDRef_ = europeanExerciseNode->Attribute("id");
             europeanExercise_ = boost::shared_ptr<CommodityPhysicalEuropeanExercise>(new CommodityPhysicalEuropeanExercise(europeanExerciseNode));
             europeanExercise_->setID(europeanExerciseIDRef_);
             IDManager::instance().setID(europeanExerciseIDRef_,europeanExercise_);
          }
          else if(europeanExerciseNode->Attribute("href")) { europeanExerciseIDRef_ = europeanExerciseNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { europeanExercise_ = boost::shared_ptr<CommodityPhysicalEuropeanExercise>(new CommodityPhysicalEuropeanExercise(europeanExerciseNode));}
   }

   //automaticExerciseNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* automaticExerciseNode = xmlNode->FirstChildElement("automaticExercise");

   if(automaticExerciseNode){automaticExerciseIsNull_ = false;}
   else{automaticExerciseIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- automaticExerciseNode , address : " << automaticExerciseNode << std::endl;
   #endif
   if(automaticExerciseNode)
   {
      if(automaticExerciseNode->Attribute("href") || automaticExerciseNode->Attribute("id"))
      {
          if(automaticExerciseNode->Attribute("id"))
          {
             automaticExerciseIDRef_ = automaticExerciseNode->Attribute("id");
             automaticExercise_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(automaticExerciseNode));
             automaticExercise_->setID(automaticExerciseIDRef_);
             IDManager::instance().setID(automaticExerciseIDRef_,automaticExercise_);
          }
          else if(automaticExerciseNode->Attribute("href")) { automaticExerciseIDRef_ = automaticExerciseNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { automaticExercise_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(automaticExerciseNode));}
   }

   //writtenConfirmationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* writtenConfirmationNode = xmlNode->FirstChildElement("writtenConfirmation");

   if(writtenConfirmationNode){writtenConfirmationIsNull_ = false;}
   else{writtenConfirmationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- writtenConfirmationNode , address : " << writtenConfirmationNode << std::endl;
   #endif
   if(writtenConfirmationNode)
   {
      if(writtenConfirmationNode->Attribute("href") || writtenConfirmationNode->Attribute("id"))
      {
          if(writtenConfirmationNode->Attribute("id"))
          {
             writtenConfirmationIDRef_ = writtenConfirmationNode->Attribute("id");
             writtenConfirmation_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(writtenConfirmationNode));
             writtenConfirmation_->setID(writtenConfirmationIDRef_);
             IDManager::instance().setID(writtenConfirmationIDRef_,writtenConfirmation_);
          }
          else if(writtenConfirmationNode->Attribute("href")) { writtenConfirmationIDRef_ = writtenConfirmationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { writtenConfirmation_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(writtenConfirmationNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<CommodityPhysicalAmericanExercise> CommodityPhysicalExercise::getAmericanExercise()
{
   if(!this->americanExerciseIsNull_){
        if(americanExerciseIDRef_ != ""){
             return boost::shared_static_cast<CommodityPhysicalAmericanExercise>(IDManager::instance().getID(americanExerciseIDRef_));
        }else{
             return this->americanExercise_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityPhysicalAmericanExercise>();
   }
}
boost::shared_ptr<CommodityPhysicalEuropeanExercise> CommodityPhysicalExercise::getEuropeanExercise()
{
   if(!this->europeanExerciseIsNull_){
        if(europeanExerciseIDRef_ != ""){
             return boost::shared_static_cast<CommodityPhysicalEuropeanExercise>(IDManager::instance().getID(europeanExerciseIDRef_));
        }else{
             return this->europeanExercise_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityPhysicalEuropeanExercise>();
   }
}
boost::shared_ptr<XsdTypeBoolean> CommodityPhysicalExercise::getAutomaticExercise()
{
   if(!this->automaticExerciseIsNull_){
        if(automaticExerciseIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(automaticExerciseIDRef_));
        }else{
             return this->automaticExercise_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> CommodityPhysicalExercise::getWrittenConfirmation()
{
   if(!this->writtenConfirmationIsNull_){
        if(writtenConfirmationIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(writtenConfirmationIDRef_));
        }else{
             return this->writtenConfirmation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
}

