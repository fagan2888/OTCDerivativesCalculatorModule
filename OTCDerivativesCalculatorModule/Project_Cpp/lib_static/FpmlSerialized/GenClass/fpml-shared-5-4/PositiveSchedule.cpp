// PositiveSchedule.cpp 
#include "PositiveSchedule.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

PositiveSchedule::PositiveSchedule(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //initialValueNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* initialValueNode = xmlNode->FirstChildElement("initialValue");

   if(initialValueNode){initialValueIsNull_ = false;}
   else{initialValueIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- initialValueNode , address : " << initialValueNode << std::endl;
   #endif
   if(initialValueNode)
   {
      if(initialValueNode->Attribute("href") || initialValueNode->Attribute("id"))
      {
          if(initialValueNode->Attribute("id"))
          {
             initialValueIDRef_ = initialValueNode->Attribute("id");
             initialValue_ = boost::shared_ptr<PositiveDecimal>(new PositiveDecimal(initialValueNode));
             initialValue_->setID(initialValueIDRef_);
             IDManager::instance().setID(initialValueIDRef_,initialValue_);
          }
          else if(initialValueNode->Attribute("href")) { initialValueIDRef_ = initialValueNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { initialValue_ = boost::shared_ptr<PositiveDecimal>(new PositiveDecimal(initialValueNode));}
   }

   //stepNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* stepNode = xmlNode->FirstChildElement("step");

   if(stepNode){stepIsNull_ = false;}
   else{stepIsNull_ = true;}

   if(stepNode)
   {
      for(stepNode; stepNode; stepNode = stepNode->NextSiblingElement("step")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- stepNode , address : " << stepNode << std::endl;
          #endif
          if(stepNode->Attribute("href") || stepNode->Attribute("id"))
          {
              if(stepNode->Attribute("id"))
              {
                  stepIDRef_ = stepNode->Attribute("id");
                  step_.push_back(boost::shared_ptr<PositiveStep>(new PositiveStep(stepNode)));
                  step_.back()->setID(stepIDRef_);
                  IDManager::instance().setID(stepIDRef_, step_.back());
              }
              else if(stepNode->Attribute("href")) { stepIDRef_ = stepNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { step_.push_back(boost::shared_ptr<PositiveStep>(new PositiveStep(stepNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- stepNode , address : " << stepNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PositiveDecimal> PositiveSchedule::getInitialValue()
{
   if(!this->initialValueIsNull_){
        if(initialValueIDRef_ != ""){
             return boost::shared_static_cast<PositiveDecimal>(IDManager::instance().getID(initialValueIDRef_));
        }else{
             return this->initialValue_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PositiveDecimal>();
   }
}
std::vector<boost::shared_ptr<PositiveStep>> PositiveSchedule::getStep()
{
   if(!this->stepIsNull_){
        if(stepIDRef_ != ""){
             return this->step_;
        }else{
             return this->step_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<PositiveStep>>();
   }
}
}

