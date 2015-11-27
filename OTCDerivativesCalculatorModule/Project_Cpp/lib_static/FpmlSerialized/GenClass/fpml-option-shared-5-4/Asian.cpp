// Asian.cpp 
#include "Asian.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Asian::Asian(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //averagingInOutNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* averagingInOutNode = xmlNode->FirstChildElement("averagingInOut");

   if(averagingInOutNode){averagingInOutIsNull_ = false;}
   else{averagingInOutIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- averagingInOutNode , address : " << averagingInOutNode << std::endl;
   #endif
   if(averagingInOutNode)
   {
      if(averagingInOutNode->Attribute("href") || averagingInOutNode->Attribute("id"))
      {
          if(averagingInOutNode->Attribute("id"))
          {
             averagingInOutIDRef_ = averagingInOutNode->Attribute("id");
             averagingInOut_ = boost::shared_ptr<AveragingInOutEnum>(new AveragingInOutEnum(averagingInOutNode));
             averagingInOut_->setID(averagingInOutIDRef_);
             IDManager::instance().setID(averagingInOutIDRef_,averagingInOut_);
          }
          else if(averagingInOutNode->Attribute("href")) { averagingInOutIDRef_ = averagingInOutNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { averagingInOut_ = boost::shared_ptr<AveragingInOutEnum>(new AveragingInOutEnum(averagingInOutNode));}
   }

   //strikeFactorNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* strikeFactorNode = xmlNode->FirstChildElement("strikeFactor");

   if(strikeFactorNode){strikeFactorIsNull_ = false;}
   else{strikeFactorIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- strikeFactorNode , address : " << strikeFactorNode << std::endl;
   #endif
   if(strikeFactorNode)
   {
      if(strikeFactorNode->Attribute("href") || strikeFactorNode->Attribute("id"))
      {
          if(strikeFactorNode->Attribute("id"))
          {
             strikeFactorIDRef_ = strikeFactorNode->Attribute("id");
             strikeFactor_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(strikeFactorNode));
             strikeFactor_->setID(strikeFactorIDRef_);
             IDManager::instance().setID(strikeFactorIDRef_,strikeFactor_);
          }
          else if(strikeFactorNode->Attribute("href")) { strikeFactorIDRef_ = strikeFactorNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { strikeFactor_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(strikeFactorNode));}
   }

   //averagingPeriodInNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* averagingPeriodInNode = xmlNode->FirstChildElement("averagingPeriodIn");

   if(averagingPeriodInNode){averagingPeriodInIsNull_ = false;}
   else{averagingPeriodInIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- averagingPeriodInNode , address : " << averagingPeriodInNode << std::endl;
   #endif
   if(averagingPeriodInNode)
   {
      if(averagingPeriodInNode->Attribute("href") || averagingPeriodInNode->Attribute("id"))
      {
          if(averagingPeriodInNode->Attribute("id"))
          {
             averagingPeriodInIDRef_ = averagingPeriodInNode->Attribute("id");
             averagingPeriodIn_ = boost::shared_ptr<AveragingPeriod>(new AveragingPeriod(averagingPeriodInNode));
             averagingPeriodIn_->setID(averagingPeriodInIDRef_);
             IDManager::instance().setID(averagingPeriodInIDRef_,averagingPeriodIn_);
          }
          else if(averagingPeriodInNode->Attribute("href")) { averagingPeriodInIDRef_ = averagingPeriodInNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { averagingPeriodIn_ = boost::shared_ptr<AveragingPeriod>(new AveragingPeriod(averagingPeriodInNode));}
   }

   //averagingPeriodOutNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* averagingPeriodOutNode = xmlNode->FirstChildElement("averagingPeriodOut");

   if(averagingPeriodOutNode){averagingPeriodOutIsNull_ = false;}
   else{averagingPeriodOutIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- averagingPeriodOutNode , address : " << averagingPeriodOutNode << std::endl;
   #endif
   if(averagingPeriodOutNode)
   {
      if(averagingPeriodOutNode->Attribute("href") || averagingPeriodOutNode->Attribute("id"))
      {
          if(averagingPeriodOutNode->Attribute("id"))
          {
             averagingPeriodOutIDRef_ = averagingPeriodOutNode->Attribute("id");
             averagingPeriodOut_ = boost::shared_ptr<AveragingPeriod>(new AveragingPeriod(averagingPeriodOutNode));
             averagingPeriodOut_->setID(averagingPeriodOutIDRef_);
             IDManager::instance().setID(averagingPeriodOutIDRef_,averagingPeriodOut_);
          }
          else if(averagingPeriodOutNode->Attribute("href")) { averagingPeriodOutIDRef_ = averagingPeriodOutNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { averagingPeriodOut_ = boost::shared_ptr<AveragingPeriod>(new AveragingPeriod(averagingPeriodOutNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<AveragingInOutEnum> Asian::getAveragingInOut()
{
   if(!this->averagingInOutIsNull_){
        if(averagingInOutIDRef_ != ""){
             return boost::shared_static_cast<AveragingInOutEnum>(IDManager::instance().getID(averagingInOutIDRef_));
        }else{
             return this->averagingInOut_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AveragingInOutEnum>();
   }
}
boost::shared_ptr<XsdTypeDecimal> Asian::getStrikeFactor()
{
   if(!this->strikeFactorIsNull_){
        if(strikeFactorIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(strikeFactorIDRef_));
        }else{
             return this->strikeFactor_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<AveragingPeriod> Asian::getAveragingPeriodIn()
{
   if(!this->averagingPeriodInIsNull_){
        if(averagingPeriodInIDRef_ != ""){
             return boost::shared_static_cast<AveragingPeriod>(IDManager::instance().getID(averagingPeriodInIDRef_));
        }else{
             return this->averagingPeriodIn_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AveragingPeriod>();
   }
}
boost::shared_ptr<AveragingPeriod> Asian::getAveragingPeriodOut()
{
   if(!this->averagingPeriodOutIsNull_){
        if(averagingPeriodOutIDRef_ != ""){
             return boost::shared_static_cast<AveragingPeriod>(IDManager::instance().getID(averagingPeriodOutIDRef_));
        }else{
             return this->averagingPeriodOut_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AveragingPeriod>();
   }
}
}

