// EarlyTerminationProvision.cpp 
#include "EarlyTerminationProvision.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

EarlyTerminationProvision::EarlyTerminationProvision(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //mandatoryEarlyTerminationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* mandatoryEarlyTerminationNode = xmlNode->FirstChildElement("mandatoryEarlyTermination");

   if(mandatoryEarlyTerminationNode){mandatoryEarlyTerminationIsNull_ = false;}
   else{mandatoryEarlyTerminationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- mandatoryEarlyTerminationNode , address : " << mandatoryEarlyTerminationNode << std::endl;
   #endif
   if(mandatoryEarlyTerminationNode)
   {
      if(mandatoryEarlyTerminationNode->Attribute("href") || mandatoryEarlyTerminationNode->Attribute("id"))
      {
          if(mandatoryEarlyTerminationNode->Attribute("id"))
          {
             mandatoryEarlyTerminationIDRef_ = mandatoryEarlyTerminationNode->Attribute("id");
             mandatoryEarlyTermination_ = boost::shared_ptr<MandatoryEarlyTermination>(new MandatoryEarlyTermination(mandatoryEarlyTerminationNode));
             mandatoryEarlyTermination_->setID(mandatoryEarlyTerminationIDRef_);
             IDManager::instance().setID(mandatoryEarlyTerminationIDRef_,mandatoryEarlyTermination_);
          }
          else if(mandatoryEarlyTerminationNode->Attribute("href")) { mandatoryEarlyTerminationIDRef_ = mandatoryEarlyTerminationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { mandatoryEarlyTermination_ = boost::shared_ptr<MandatoryEarlyTermination>(new MandatoryEarlyTermination(mandatoryEarlyTerminationNode));}
   }

   //mandatoryEarlyTerminationDateTenorNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* mandatoryEarlyTerminationDateTenorNode = xmlNode->FirstChildElement("mandatoryEarlyTerminationDateTenor");

   if(mandatoryEarlyTerminationDateTenorNode){mandatoryEarlyTerminationDateTenorIsNull_ = false;}
   else{mandatoryEarlyTerminationDateTenorIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- mandatoryEarlyTerminationDateTenorNode , address : " << mandatoryEarlyTerminationDateTenorNode << std::endl;
   #endif
   if(mandatoryEarlyTerminationDateTenorNode)
   {
      if(mandatoryEarlyTerminationDateTenorNode->Attribute("href") || mandatoryEarlyTerminationDateTenorNode->Attribute("id"))
      {
          if(mandatoryEarlyTerminationDateTenorNode->Attribute("id"))
          {
             mandatoryEarlyTerminationDateTenorIDRef_ = mandatoryEarlyTerminationDateTenorNode->Attribute("id");
             mandatoryEarlyTerminationDateTenor_ = boost::shared_ptr<Period>(new Period(mandatoryEarlyTerminationDateTenorNode));
             mandatoryEarlyTerminationDateTenor_->setID(mandatoryEarlyTerminationDateTenorIDRef_);
             IDManager::instance().setID(mandatoryEarlyTerminationDateTenorIDRef_,mandatoryEarlyTerminationDateTenor_);
          }
          else if(mandatoryEarlyTerminationDateTenorNode->Attribute("href")) { mandatoryEarlyTerminationDateTenorIDRef_ = mandatoryEarlyTerminationDateTenorNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { mandatoryEarlyTerminationDateTenor_ = boost::shared_ptr<Period>(new Period(mandatoryEarlyTerminationDateTenorNode));}
   }

   //optionalEarlyTerminationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* optionalEarlyTerminationNode = xmlNode->FirstChildElement("optionalEarlyTermination");

   if(optionalEarlyTerminationNode){optionalEarlyTerminationIsNull_ = false;}
   else{optionalEarlyTerminationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- optionalEarlyTerminationNode , address : " << optionalEarlyTerminationNode << std::endl;
   #endif
   if(optionalEarlyTerminationNode)
   {
      if(optionalEarlyTerminationNode->Attribute("href") || optionalEarlyTerminationNode->Attribute("id"))
      {
          if(optionalEarlyTerminationNode->Attribute("id"))
          {
             optionalEarlyTerminationIDRef_ = optionalEarlyTerminationNode->Attribute("id");
             optionalEarlyTermination_ = boost::shared_ptr<OptionalEarlyTermination>(new OptionalEarlyTermination(optionalEarlyTerminationNode));
             optionalEarlyTermination_->setID(optionalEarlyTerminationIDRef_);
             IDManager::instance().setID(optionalEarlyTerminationIDRef_,optionalEarlyTermination_);
          }
          else if(optionalEarlyTerminationNode->Attribute("href")) { optionalEarlyTerminationIDRef_ = optionalEarlyTerminationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { optionalEarlyTermination_ = boost::shared_ptr<OptionalEarlyTermination>(new OptionalEarlyTermination(optionalEarlyTerminationNode));}
   }

   //optionalEarlyTerminationParametersNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* optionalEarlyTerminationParametersNode = xmlNode->FirstChildElement("optionalEarlyTerminationParameters");

   if(optionalEarlyTerminationParametersNode){optionalEarlyTerminationParametersIsNull_ = false;}
   else{optionalEarlyTerminationParametersIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- optionalEarlyTerminationParametersNode , address : " << optionalEarlyTerminationParametersNode << std::endl;
   #endif
   if(optionalEarlyTerminationParametersNode)
   {
      if(optionalEarlyTerminationParametersNode->Attribute("href") || optionalEarlyTerminationParametersNode->Attribute("id"))
      {
          if(optionalEarlyTerminationParametersNode->Attribute("id"))
          {
             optionalEarlyTerminationParametersIDRef_ = optionalEarlyTerminationParametersNode->Attribute("id");
             optionalEarlyTerminationParameters_ = boost::shared_ptr<ExercisePeriod>(new ExercisePeriod(optionalEarlyTerminationParametersNode));
             optionalEarlyTerminationParameters_->setID(optionalEarlyTerminationParametersIDRef_);
             IDManager::instance().setID(optionalEarlyTerminationParametersIDRef_,optionalEarlyTerminationParameters_);
          }
          else if(optionalEarlyTerminationParametersNode->Attribute("href")) { optionalEarlyTerminationParametersIDRef_ = optionalEarlyTerminationParametersNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { optionalEarlyTerminationParameters_ = boost::shared_ptr<ExercisePeriod>(new ExercisePeriod(optionalEarlyTerminationParametersNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<MandatoryEarlyTermination> EarlyTerminationProvision::getMandatoryEarlyTermination()
{
   if(!this->mandatoryEarlyTerminationIsNull_){
        if(mandatoryEarlyTerminationIDRef_ != ""){
             return boost::shared_static_cast<MandatoryEarlyTermination>(IDManager::instance().getID(mandatoryEarlyTerminationIDRef_));
        }else{
             return this->mandatoryEarlyTermination_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<MandatoryEarlyTermination>();
   }
}
boost::shared_ptr<Period> EarlyTerminationProvision::getMandatoryEarlyTerminationDateTenor()
{
   if(!this->mandatoryEarlyTerminationDateTenorIsNull_){
        if(mandatoryEarlyTerminationDateTenorIDRef_ != ""){
             return boost::shared_static_cast<Period>(IDManager::instance().getID(mandatoryEarlyTerminationDateTenorIDRef_));
        }else{
             return this->mandatoryEarlyTerminationDateTenor_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Period>();
   }
}
boost::shared_ptr<OptionalEarlyTermination> EarlyTerminationProvision::getOptionalEarlyTermination()
{
   if(!this->optionalEarlyTerminationIsNull_){
        if(optionalEarlyTerminationIDRef_ != ""){
             return boost::shared_static_cast<OptionalEarlyTermination>(IDManager::instance().getID(optionalEarlyTerminationIDRef_));
        }else{
             return this->optionalEarlyTermination_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<OptionalEarlyTermination>();
   }
}
boost::shared_ptr<ExercisePeriod> EarlyTerminationProvision::getOptionalEarlyTerminationParameters()
{
   if(!this->optionalEarlyTerminationParametersIsNull_){
        if(optionalEarlyTerminationParametersIDRef_ != ""){
             return boost::shared_static_cast<ExercisePeriod>(IDManager::instance().getID(optionalEarlyTerminationParametersIDRef_));
        }else{
             return this->optionalEarlyTerminationParameters_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ExercisePeriod>();
   }
}
}

