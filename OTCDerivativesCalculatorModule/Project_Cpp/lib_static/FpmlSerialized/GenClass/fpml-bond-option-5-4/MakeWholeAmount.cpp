// MakeWholeAmount.cpp 
#include "MakeWholeAmount.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

MakeWholeAmount::MakeWholeAmount(TiXmlNode* xmlNode)
: SwapCurveValuation(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //interpolationMethodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* interpolationMethodNode = xmlNode->FirstChildElement("interpolationMethod");

   if(interpolationMethodNode){interpolationMethodIsNull_ = false;}
   else{interpolationMethodIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- interpolationMethodNode , address : " << interpolationMethodNode << std::endl;
   #endif
   if(interpolationMethodNode)
   {
      if(interpolationMethodNode->Attribute("href") || interpolationMethodNode->Attribute("id"))
      {
          if(interpolationMethodNode->Attribute("id"))
          {
             interpolationMethodIDRef_ = interpolationMethodNode->Attribute("id");
             interpolationMethod_ = boost::shared_ptr<InterpolationMethod>(new InterpolationMethod(interpolationMethodNode));
             interpolationMethod_->setID(interpolationMethodIDRef_);
             IDManager::instance().setID(interpolationMethodIDRef_,interpolationMethod_);
          }
          else if(interpolationMethodNode->Attribute("href")) { interpolationMethodIDRef_ = interpolationMethodNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { interpolationMethod_ = boost::shared_ptr<InterpolationMethod>(new InterpolationMethod(interpolationMethodNode));}
   }

   //earlyCallDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* earlyCallDateNode = xmlNode->FirstChildElement("earlyCallDate");

   if(earlyCallDateNode){earlyCallDateIsNull_ = false;}
   else{earlyCallDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- earlyCallDateNode , address : " << earlyCallDateNode << std::endl;
   #endif
   if(earlyCallDateNode)
   {
      if(earlyCallDateNode->Attribute("href") || earlyCallDateNode->Attribute("id"))
      {
          if(earlyCallDateNode->Attribute("id"))
          {
             earlyCallDateIDRef_ = earlyCallDateNode->Attribute("id");
             earlyCallDate_ = boost::shared_ptr<IdentifiedDate>(new IdentifiedDate(earlyCallDateNode));
             earlyCallDate_->setID(earlyCallDateIDRef_);
             IDManager::instance().setID(earlyCallDateIDRef_,earlyCallDate_);
          }
          else if(earlyCallDateNode->Attribute("href")) { earlyCallDateIDRef_ = earlyCallDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { earlyCallDate_ = boost::shared_ptr<IdentifiedDate>(new IdentifiedDate(earlyCallDateNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<InterpolationMethod> MakeWholeAmount::getInterpolationMethod()
{
   if(!this->interpolationMethodIsNull_){
        if(interpolationMethodIDRef_ != ""){
             return boost::shared_static_cast<InterpolationMethod>(IDManager::instance().getID(interpolationMethodIDRef_));
        }else{
             return this->interpolationMethod_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<InterpolationMethod>();
   }
}
boost::shared_ptr<IdentifiedDate> MakeWholeAmount::getEarlyCallDate()
{
   if(!this->earlyCallDateIsNull_){
        if(earlyCallDateIDRef_ != ""){
             return boost::shared_static_cast<IdentifiedDate>(IDManager::instance().getID(earlyCallDateIDRef_));
        }else{
             return this->earlyCallDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<IdentifiedDate>();
   }
}
}

