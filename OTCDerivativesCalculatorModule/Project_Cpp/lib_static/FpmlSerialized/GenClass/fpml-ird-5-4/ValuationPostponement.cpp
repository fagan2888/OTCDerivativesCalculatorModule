// ValuationPostponement.cpp 
#include "ValuationPostponement.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ValuationPostponement::ValuationPostponement(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //maximumDaysOfPostponementNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* maximumDaysOfPostponementNode = xmlNode->FirstChildElement("maximumDaysOfPostponement");

   if(maximumDaysOfPostponementNode){maximumDaysOfPostponementIsNull_ = false;}
   else{maximumDaysOfPostponementIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- maximumDaysOfPostponementNode , address : " << maximumDaysOfPostponementNode << std::endl;
   #endif
   if(maximumDaysOfPostponementNode)
   {
      if(maximumDaysOfPostponementNode->Attribute("href") || maximumDaysOfPostponementNode->Attribute("id"))
      {
          if(maximumDaysOfPostponementNode->Attribute("id"))
          {
             maximumDaysOfPostponementIDRef_ = maximumDaysOfPostponementNode->Attribute("id");
             maximumDaysOfPostponement_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(maximumDaysOfPostponementNode));
             maximumDaysOfPostponement_->setID(maximumDaysOfPostponementIDRef_);
             IDManager::instance().setID(maximumDaysOfPostponementIDRef_,maximumDaysOfPostponement_);
          }
          else if(maximumDaysOfPostponementNode->Attribute("href")) { maximumDaysOfPostponementIDRef_ = maximumDaysOfPostponementNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { maximumDaysOfPostponement_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(maximumDaysOfPostponementNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypePositiveInteger> ValuationPostponement::getMaximumDaysOfPostponement()
{
   if(!this->maximumDaysOfPostponementIsNull_){
        if(maximumDaysOfPostponementIDRef_ != ""){
             return boost::shared_static_cast<XsdTypePositiveInteger>(IDManager::instance().getID(maximumDaysOfPostponementIDRef_));
        }else{
             return this->maximumDaysOfPostponement_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypePositiveInteger>();
   }
}
}

