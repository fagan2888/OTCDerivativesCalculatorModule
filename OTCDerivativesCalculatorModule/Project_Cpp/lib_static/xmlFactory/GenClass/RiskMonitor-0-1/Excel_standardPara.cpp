// Excel_standardPara.cpp 
#include "Excel_standardPara.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_standardPara::Excel_standardPara(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //referenceDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* referenceDateNode = xmlNode->FirstChildElement("referenceDate");

   if(referenceDateNode){referenceDateIsNull_ = false;}
   else{referenceDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- referenceDateNode , address : " << referenceDateNode << std::endl;
   #endif
   if(referenceDateNode)
   {
       referenceDate_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(referenceDateNode));
   }

   //simulationNumNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* simulationNumNode = xmlNode->FirstChildElement("simulationNum");

   if(simulationNumNode){simulationNumIsNull_ = false;}
   else{simulationNumIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- simulationNumNode , address : " << simulationNumNode << std::endl;
   #endif
   if(simulationNumNode)
   {
       simulationNum_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(simulationNumNode));
   }

   //excel_underlyingCalcInfo_paraNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_underlyingCalcInfo_paraNode = xmlNode->FirstChildElement("excel_underlyingCalcInfo_para");

   if(excel_underlyingCalcInfo_paraNode){excel_underlyingCalcInfo_paraIsNull_ = false;}
   else{excel_underlyingCalcInfo_paraIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_underlyingCalcInfo_paraNode , address : " << excel_underlyingCalcInfo_paraNode << std::endl;
   #endif
   if(excel_underlyingCalcInfo_paraNode)
   {
       excel_underlyingCalcInfo_para_ = boost::shared_ptr<Excel_underlyingCalcInfo_para>(new Excel_underlyingCalcInfo_para(excel_underlyingCalcInfo_paraNode));
   }

   //excel_discountCurve_paraNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_discountCurve_paraNode = xmlNode->FirstChildElement("excel_discountCurve_para");

   if(excel_discountCurve_paraNode){excel_discountCurve_paraIsNull_ = false;}
   else{excel_discountCurve_paraIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_discountCurve_paraNode , address : " << excel_discountCurve_paraNode << std::endl;
   #endif
   if(excel_discountCurve_paraNode)
   {
       excel_discountCurve_para_ = boost::shared_ptr<Excel_discountCurve_para>(new Excel_discountCurve_para(excel_discountCurve_paraNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_standardPara::getReferenceDate()
{
   if(!this->referenceDateIsNull_){
        return this->referenceDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_standardPara::getSimulationNum()
{
   if(!this->simulationNumIsNull_){
        return this->simulationNum_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<Excel_underlyingCalcInfo_para> Excel_standardPara::getExcel_underlyingCalcInfo_para()
{
   if(!this->excel_underlyingCalcInfo_paraIsNull_){
        return this->excel_underlyingCalcInfo_para_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_underlyingCalcInfo_para>();
   }
}
boost::shared_ptr<Excel_discountCurve_para> Excel_standardPara::getExcel_discountCurve_para()
{
   if(!this->excel_discountCurve_paraIsNull_){
        return this->excel_discountCurve_para_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_discountCurve_para>();
   }
}
}

