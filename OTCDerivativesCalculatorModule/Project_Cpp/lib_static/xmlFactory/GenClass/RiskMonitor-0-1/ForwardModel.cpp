// ForwardModel.cpp 
#include "ForwardModel.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ForwardModel::ForwardModel(TiXmlNode* xmlNode)
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
boost::shared_ptr<XsdTypeDouble> ForwardModel::getCurrentValue()
{
   if(!this->currentValueIsNull_){
        return this->currentValue_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDouble>();
   }
}
boost::shared_ptr<Tenor> ForwardModel::getTenor()
{
   if(!this->tenorIsNull_){
        return this->tenor_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Tenor>();
   }
}
boost::shared_ptr<FittingYieldCurve> ForwardModel::getFittingYieldCurve()
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

