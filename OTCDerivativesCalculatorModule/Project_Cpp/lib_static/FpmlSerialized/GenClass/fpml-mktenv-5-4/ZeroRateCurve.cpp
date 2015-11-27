// ZeroRateCurve.cpp 
#include "ZeroRateCurve.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ZeroRateCurve::ZeroRateCurve(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //compoundingFrequencyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* compoundingFrequencyNode = xmlNode->FirstChildElement("compoundingFrequency");

   if(compoundingFrequencyNode){compoundingFrequencyIsNull_ = false;}
   else{compoundingFrequencyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- compoundingFrequencyNode , address : " << compoundingFrequencyNode << std::endl;
   #endif
   if(compoundingFrequencyNode)
   {
      if(compoundingFrequencyNode->Attribute("href") || compoundingFrequencyNode->Attribute("id"))
      {
          if(compoundingFrequencyNode->Attribute("id"))
          {
             compoundingFrequencyIDRef_ = compoundingFrequencyNode->Attribute("id");
             compoundingFrequency_ = boost::shared_ptr<CompoundingFrequency>(new CompoundingFrequency(compoundingFrequencyNode));
             compoundingFrequency_->setID(compoundingFrequencyIDRef_);
             IDManager::instance().setID(compoundingFrequencyIDRef_,compoundingFrequency_);
          }
          else if(compoundingFrequencyNode->Attribute("href")) { compoundingFrequencyIDRef_ = compoundingFrequencyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { compoundingFrequency_ = boost::shared_ptr<CompoundingFrequency>(new CompoundingFrequency(compoundingFrequencyNode));}
   }

   //rateCurveNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* rateCurveNode = xmlNode->FirstChildElement("rateCurve");

   if(rateCurveNode){rateCurveIsNull_ = false;}
   else{rateCurveIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- rateCurveNode , address : " << rateCurveNode << std::endl;
   #endif
   if(rateCurveNode)
   {
      if(rateCurveNode->Attribute("href") || rateCurveNode->Attribute("id"))
      {
          if(rateCurveNode->Attribute("id"))
          {
             rateCurveIDRef_ = rateCurveNode->Attribute("id");
             rateCurve_ = boost::shared_ptr<TermCurve>(new TermCurve(rateCurveNode));
             rateCurve_->setID(rateCurveIDRef_);
             IDManager::instance().setID(rateCurveIDRef_,rateCurve_);
          }
          else if(rateCurveNode->Attribute("href")) { rateCurveIDRef_ = rateCurveNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { rateCurve_ = boost::shared_ptr<TermCurve>(new TermCurve(rateCurveNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<CompoundingFrequency> ZeroRateCurve::getCompoundingFrequency()
{
   if(!this->compoundingFrequencyIsNull_){
        if(compoundingFrequencyIDRef_ != ""){
             return boost::shared_static_cast<CompoundingFrequency>(IDManager::instance().getID(compoundingFrequencyIDRef_));
        }else{
             return this->compoundingFrequency_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CompoundingFrequency>();
   }
}
boost::shared_ptr<TermCurve> ZeroRateCurve::getRateCurve()
{
   if(!this->rateCurveIsNull_){
        if(rateCurveIDRef_ != ""){
             return boost::shared_static_cast<TermCurve>(IDManager::instance().getID(rateCurveIDRef_));
        }else{
             return this->rateCurve_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<TermCurve>();
   }
}
}

