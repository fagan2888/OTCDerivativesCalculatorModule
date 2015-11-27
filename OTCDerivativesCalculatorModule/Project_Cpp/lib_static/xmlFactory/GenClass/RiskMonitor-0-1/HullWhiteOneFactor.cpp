// HullWhiteOneFactor.cpp 
#include "HullWhiteOneFactor.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

HullWhiteOneFactor::HullWhiteOneFactor(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //currentValueNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* currentValueNode = xmlNode->FirstChildElement("currentValue");

   if(currentValueNode){currentValueIsNull_ = false;}
   else{currentValueIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- currentValueNode , address : " << currentValueNode << std::endl;
   #endif
   if(currentValueNode)
   {
       currentValue_ = boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(currentValueNode));
   }

   //alphaNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* alphaNode = xmlNode->FirstChildElement("alpha");

   if(alphaNode){alphaIsNull_ = false;}
   else{alphaIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- alphaNode , address : " << alphaNode << std::endl;
   #endif
   if(alphaNode)
   {
       alpha_ = boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(alphaNode));
   }

   //sigmaNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* sigmaNode = xmlNode->FirstChildElement("sigma");

   if(sigmaNode){sigmaIsNull_ = false;}
   else{sigmaIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- sigmaNode , address : " << sigmaNode << std::endl;
   #endif
   if(sigmaNode)
   {
       sigma_ = boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(sigmaNode));
   }

   //tenorNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* tenorNode = xmlNode->FirstChildElement("tenor");

   if(tenorNode){tenorIsNull_ = false;}
   else{tenorIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- tenorNode , address : " << tenorNode << std::endl;
   #endif
   if(tenorNode)
   {
       tenor_ = boost::shared_ptr<Tenor>(new Tenor(tenorNode));
   }

   //fittingYieldCurveNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fittingYieldCurveNode = xmlNode->FirstChildElement("fittingYieldCurve");

   if(fittingYieldCurveNode){fittingYieldCurveIsNull_ = false;}
   else{fittingYieldCurveIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fittingYieldCurveNode , address : " << fittingYieldCurveNode << std::endl;
   #endif
   if(fittingYieldCurveNode)
   {
       fittingYieldCurve_ = boost::shared_ptr<FittingYieldCurve>(new FittingYieldCurve(fittingYieldCurveNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDouble> HullWhiteOneFactor::getCurrentValue()
{
   if(!this->currentValueIsNull_){
        return this->currentValue_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDouble>();
   }
}
boost::shared_ptr<XsdTypeDouble> HullWhiteOneFactor::getAlpha()
{
   if(!this->alphaIsNull_){
        return this->alpha_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDouble>();
   }
}
boost::shared_ptr<XsdTypeDouble> HullWhiteOneFactor::getSigma()
{
   if(!this->sigmaIsNull_){
        return this->sigma_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDouble>();
   }
}
boost::shared_ptr<Tenor> HullWhiteOneFactor::getTenor()
{
   if(!this->tenorIsNull_){
        return this->tenor_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Tenor>();
   }
}
boost::shared_ptr<FittingYieldCurve> HullWhiteOneFactor::getFittingYieldCurve()
{
   if(!this->fittingYieldCurveIsNull_){
        return this->fittingYieldCurve_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FittingYieldCurve>();
   }
}
}

