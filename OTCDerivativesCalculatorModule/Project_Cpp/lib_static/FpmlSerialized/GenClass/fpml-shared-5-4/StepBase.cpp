// StepBase.cpp 
#include "StepBase.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

StepBase::StepBase(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //stepDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* stepDateNode = xmlNode->FirstChildElement("stepDate");

   if(stepDateNode){stepDateIsNull_ = false;}
   else{stepDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- stepDateNode , address : " << stepDateNode << std::endl;
   #endif
   if(stepDateNode)
   {
      if(stepDateNode->Attribute("href") || stepDateNode->Attribute("id"))
      {
          if(stepDateNode->Attribute("id"))
          {
             stepDateIDRef_ = stepDateNode->Attribute("id");
             stepDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(stepDateNode));
             stepDate_->setID(stepDateIDRef_);
             IDManager::instance().setID(stepDateIDRef_,stepDate_);
          }
          else if(stepDateNode->Attribute("href")) { stepDateIDRef_ = stepDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { stepDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(stepDateNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDate> StepBase::getStepDate()
{
   if(!this->stepDateIsNull_){
        if(stepDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(stepDateIDRef_));
        }else{
             return this->stepDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
}

