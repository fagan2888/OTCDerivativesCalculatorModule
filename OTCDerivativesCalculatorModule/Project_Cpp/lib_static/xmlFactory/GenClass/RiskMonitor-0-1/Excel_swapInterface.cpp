// Excel_swapInterface.cpp 
#include "Excel_swapInterface.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_swapInterface::Excel_swapInterface(TiXmlNode* xmlNode)
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

   //excel_irsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_irsNode = xmlNode->FirstChildElement("excel_irs");

   if(excel_irsNode){excel_irsIsNull_ = false;}
   else{excel_irsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_irsNode , address : " << excel_irsNode << std::endl;
   #endif
   if(excel_irsNode)
   {
       excel_irs_ = boost::shared_ptr<Excel_irs>(new Excel_irs(excel_irsNode));
   }

   //excel_crsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_crsNode = xmlNode->FirstChildElement("excel_crs");

   if(excel_crsNode){excel_crsIsNull_ = false;}
   else{excel_crsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_crsNode , address : " << excel_crsNode << std::endl;
   #endif
   if(excel_crsNode)
   {
       excel_crs_ = boost::shared_ptr<Excel_crs>(new Excel_crs(excel_crsNode));
   }

   //excel_cdsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_cdsNode = xmlNode->FirstChildElement("excel_cds");

   if(excel_cdsNode){excel_cdsIsNull_ = false;}
   else{excel_cdsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_cdsNode , address : " << excel_cdsNode << std::endl;
   #endif
   if(excel_cdsNode)
   {
       excel_cds_ = boost::shared_ptr<Excel_cds>(new Excel_cds(excel_cdsNode));
   }

   //excel_structuredSwapNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_structuredSwapNode = xmlNode->FirstChildElement("excel_structuredSwap");

   if(excel_structuredSwapNode){excel_structuredSwapIsNull_ = false;}
   else{excel_structuredSwapIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_structuredSwapNode , address : " << excel_structuredSwapNode << std::endl;
   #endif
   if(excel_structuredSwapNode)
   {
       excel_structuredSwap_ = boost::shared_ptr<Excel_structuredSwap>(new Excel_structuredSwap(excel_structuredSwapNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_swapInterface::getExcel_type()
{
   if(!this->excel_typeIsNull_){
        return this->excel_type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<Excel_irs> Excel_swapInterface::getExcel_irs()
{
   if(!this->excel_irsIsNull_){
        return this->excel_irs_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_irs>();
   }
}
boost::shared_ptr<Excel_crs> Excel_swapInterface::getExcel_crs()
{
   if(!this->excel_crsIsNull_){
        return this->excel_crs_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_crs>();
   }
}
boost::shared_ptr<Excel_cds> Excel_swapInterface::getExcel_cds()
{
   if(!this->excel_cdsIsNull_){
        return this->excel_cds_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_cds>();
   }
}
boost::shared_ptr<Excel_structuredSwap> Excel_swapInterface::getExcel_structuredSwap()
{
   if(!this->excel_structuredSwapIsNull_){
        return this->excel_structuredSwap_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_structuredSwap>();
   }
}
}

