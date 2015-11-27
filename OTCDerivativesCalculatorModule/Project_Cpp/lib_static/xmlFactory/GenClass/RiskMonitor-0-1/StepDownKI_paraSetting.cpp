// StepDownKI_paraSetting.cpp 
#include "StepDownKI_paraSetting.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

StepDownKI_paraSetting::StepDownKI_paraSetting(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //geometricBM_paraSettingNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* geometricBM_paraSettingNode = xmlNode->FirstChildElement("geometricBM_paraSetting");

   if(geometricBM_paraSettingNode){geometricBM_paraSettingIsNull_ = false;}
   else{geometricBM_paraSettingIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- geometricBM_paraSettingNode , address : " << geometricBM_paraSettingNode << std::endl;
   #endif
   if(geometricBM_paraSettingNode)
   {
       geometricBM_paraSetting_ = boost::shared_ptr<GeometricBM_paraSetting>(new GeometricBM_paraSetting(geometricBM_paraSettingNode));
   }

   //hullWhite_paraSettingNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* hullWhite_paraSettingNode = xmlNode->FirstChildElement("hullWhite_paraSetting");

   if(hullWhite_paraSettingNode){hullWhite_paraSettingIsNull_ = false;}
   else{hullWhite_paraSettingIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- hullWhite_paraSettingNode , address : " << hullWhite_paraSettingNode << std::endl;
   #endif
   if(hullWhite_paraSettingNode)
   {
       hullWhite_paraSetting_ = boost::shared_ptr<HullWhite_paraSetting>(new HullWhite_paraSetting(hullWhite_paraSettingNode));
   }

   //discountCurve_paraSettingNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* discountCurve_paraSettingNode = xmlNode->FirstChildElement("discountCurve_paraSetting");

   if(discountCurve_paraSettingNode){discountCurve_paraSettingIsNull_ = false;}
   else{discountCurve_paraSettingIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- discountCurve_paraSettingNode , address : " << discountCurve_paraSettingNode << std::endl;
   #endif
   if(discountCurve_paraSettingNode)
   {
       discountCurve_paraSetting_ = boost::shared_ptr<DiscountCurve_paraSetting>(new DiscountCurve_paraSetting(discountCurve_paraSettingNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<GeometricBM_paraSetting> StepDownKI_paraSetting::getGeometricBM_paraSetting()
{
   if(!this->geometricBM_paraSettingIsNull_){
        return this->geometricBM_paraSetting_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<GeometricBM_paraSetting>();
   }
}
boost::shared_ptr<HullWhite_paraSetting> StepDownKI_paraSetting::getHullWhite_paraSetting()
{
   if(!this->hullWhite_paraSettingIsNull_){
        return this->hullWhite_paraSetting_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<HullWhite_paraSetting>();
   }
}
boost::shared_ptr<DiscountCurve_paraSetting> StepDownKI_paraSetting::getDiscountCurve_paraSetting()
{
   if(!this->discountCurve_paraSettingIsNull_){
        return this->discountCurve_paraSetting_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DiscountCurve_paraSetting>();
   }
}
}

