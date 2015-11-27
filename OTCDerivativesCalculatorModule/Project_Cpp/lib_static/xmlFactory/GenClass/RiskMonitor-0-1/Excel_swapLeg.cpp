// Excel_swapLeg.cpp 
#include "Excel_swapLeg.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_swapLeg::Excel_swapLeg(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //excel_typeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_typeNode = xmlNode->FirstChildElement("excel_type");

   if(excel_typeNode){excel_typeIsNull_ = false;}
   else{excel_typeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_typeNode , address : " << excel_typeNode << std::endl;
   #endif
   if(excel_typeNode)
   {
       excel_type_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(excel_typeNode));
   }

   //excel_fixedRateSwapLegNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_fixedRateSwapLegNode = xmlNode->FirstChildElement("excel_fixedRateSwapLeg");

   if(excel_fixedRateSwapLegNode){excel_fixedRateSwapLegIsNull_ = false;}
   else{excel_fixedRateSwapLegIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_fixedRateSwapLegNode , address : " << excel_fixedRateSwapLegNode << std::endl;
   #endif
   if(excel_fixedRateSwapLegNode)
   {
       excel_fixedRateSwapLeg_ = boost::shared_ptr<Excel_fixedRateSwapLeg>(new Excel_fixedRateSwapLeg(excel_fixedRateSwapLegNode));
   }

   //excel_vanillaFloatingRateSwapLegNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_vanillaFloatingRateSwapLegNode = xmlNode->FirstChildElement("excel_vanillaFloatingRateSwapLeg");

   if(excel_vanillaFloatingRateSwapLegNode){excel_vanillaFloatingRateSwapLegIsNull_ = false;}
   else{excel_vanillaFloatingRateSwapLegIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_vanillaFloatingRateSwapLegNode , address : " << excel_vanillaFloatingRateSwapLegNode << std::endl;
   #endif
   if(excel_vanillaFloatingRateSwapLegNode)
   {
       excel_vanillaFloatingRateSwapLeg_ = boost::shared_ptr<Excel_vanillaFloatingRateSwapLeg>(new Excel_vanillaFloatingRateSwapLeg(excel_vanillaFloatingRateSwapLegNode));
   }

   //excel_structuredSwapLegNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_structuredSwapLegNode = xmlNode->FirstChildElement("excel_structuredSwapLeg");

   if(excel_structuredSwapLegNode){excel_structuredSwapLegIsNull_ = false;}
   else{excel_structuredSwapLegIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_structuredSwapLegNode , address : " << excel_structuredSwapLegNode << std::endl;
   #endif
   if(excel_structuredSwapLegNode)
   {
       excel_structuredSwapLeg_ = boost::shared_ptr<Excel_structuredSwapLeg>(new Excel_structuredSwapLeg(excel_structuredSwapLegNode));
   }

   //excel_creditEventSwapLegNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_creditEventSwapLegNode = xmlNode->FirstChildElement("excel_creditEventSwapLeg");

   if(excel_creditEventSwapLegNode){excel_creditEventSwapLegIsNull_ = false;}
   else{excel_creditEventSwapLegIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_creditEventSwapLegNode , address : " << excel_creditEventSwapLegNode << std::endl;
   #endif
   if(excel_creditEventSwapLegNode)
   {
       excel_creditEventSwapLeg_ = boost::shared_ptr<Excel_creditEventSwapLeg>(new Excel_creditEventSwapLeg(excel_creditEventSwapLegNode));
   }

   //excel_hifiveSwapLegNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_hifiveSwapLegNode = xmlNode->FirstChildElement("excel_hifiveSwapLeg");

   if(excel_hifiveSwapLegNode){excel_hifiveSwapLegIsNull_ = false;}
   else{excel_hifiveSwapLegIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_hifiveSwapLegNode , address : " << excel_hifiveSwapLegNode << std::endl;
   #endif
   if(excel_hifiveSwapLegNode)
   {
       excel_hifiveSwapLeg_ = boost::shared_ptr<Excel_hifiveSwapLeg>(new Excel_hifiveSwapLeg(excel_hifiveSwapLegNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_swapLeg::getExcel_type()
{
   if(!this->excel_typeIsNull_){
        return this->excel_type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<Excel_fixedRateSwapLeg> Excel_swapLeg::getExcel_fixedRateSwapLeg()
{
   if(!this->excel_fixedRateSwapLegIsNull_){
        return this->excel_fixedRateSwapLeg_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_fixedRateSwapLeg>();
   }
}
boost::shared_ptr<Excel_vanillaFloatingRateSwapLeg> Excel_swapLeg::getExcel_vanillaFloatingRateSwapLeg()
{
   if(!this->excel_vanillaFloatingRateSwapLegIsNull_){
        return this->excel_vanillaFloatingRateSwapLeg_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_vanillaFloatingRateSwapLeg>();
   }
}
boost::shared_ptr<Excel_structuredSwapLeg> Excel_swapLeg::getExcel_structuredSwapLeg()
{
   if(!this->excel_structuredSwapLegIsNull_){
        return this->excel_structuredSwapLeg_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_structuredSwapLeg>();
   }
}
boost::shared_ptr<Excel_creditEventSwapLeg> Excel_swapLeg::getExcel_creditEventSwapLeg()
{
   if(!this->excel_creditEventSwapLegIsNull_){
        return this->excel_creditEventSwapLeg_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_creditEventSwapLeg>();
   }
}
boost::shared_ptr<Excel_hifiveSwapLeg> Excel_swapLeg::getExcel_hifiveSwapLeg()
{
   if(!this->excel_hifiveSwapLegIsNull_){
        return this->excel_hifiveSwapLeg_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_hifiveSwapLeg>();
   }
}
}

