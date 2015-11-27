// Excel_multiAsset_compositeOption_subtype.cpp 
#include "Excel_multiAsset_compositeOption_subtype.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_multiAsset_compositeOption_subtype::Excel_multiAsset_compositeOption_subtype(TiXmlNode* xmlNode)
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

   //excel_multiAsset_vanillaCallPutNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_multiAsset_vanillaCallPutNode = xmlNode->FirstChildElement("excel_multiAsset_vanillaCallPut");

   if(excel_multiAsset_vanillaCallPutNode){excel_multiAsset_vanillaCallPutIsNull_ = false;}
   else{excel_multiAsset_vanillaCallPutIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_multiAsset_vanillaCallPutNode , address : " << excel_multiAsset_vanillaCallPutNode << std::endl;
   #endif
   if(excel_multiAsset_vanillaCallPutNode)
   {
       excel_multiAsset_vanillaCallPut_ = boost::shared_ptr<Excel_multiAsset_vanillaCallPut>(new Excel_multiAsset_vanillaCallPut(excel_multiAsset_vanillaCallPutNode));
   }

   //excel_multiAsset_upInOutCallNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_multiAsset_upInOutCallNode = xmlNode->FirstChildElement("excel_multiAsset_upInOutCall");

   if(excel_multiAsset_upInOutCallNode){excel_multiAsset_upInOutCallIsNull_ = false;}
   else{excel_multiAsset_upInOutCallIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_multiAsset_upInOutCallNode , address : " << excel_multiAsset_upInOutCallNode << std::endl;
   #endif
   if(excel_multiAsset_upInOutCallNode)
   {
       excel_multiAsset_upInOutCall_ = boost::shared_ptr<Excel_multiAsset_upInOutCall>(new Excel_multiAsset_upInOutCall(excel_multiAsset_upInOutCallNode));
   }

   //excel_multiAsset_downInOutPutNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_multiAsset_downInOutPutNode = xmlNode->FirstChildElement("excel_multiAsset_downInOutPut");

   if(excel_multiAsset_downInOutPutNode){excel_multiAsset_downInOutPutIsNull_ = false;}
   else{excel_multiAsset_downInOutPutIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_multiAsset_downInOutPutNode , address : " << excel_multiAsset_downInOutPutNode << std::endl;
   #endif
   if(excel_multiAsset_downInOutPutNode)
   {
       excel_multiAsset_downInOutPut_ = boost::shared_ptr<Excel_multiAsset_downInOutPut>(new Excel_multiAsset_downInOutPut(excel_multiAsset_downInOutPutNode));
   }

   //excel_multiAsset_digitalCallPutNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_multiAsset_digitalCallPutNode = xmlNode->FirstChildElement("excel_multiAsset_digitalCallPut");

   if(excel_multiAsset_digitalCallPutNode){excel_multiAsset_digitalCallPutIsNull_ = false;}
   else{excel_multiAsset_digitalCallPutIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_multiAsset_digitalCallPutNode , address : " << excel_multiAsset_digitalCallPutNode << std::endl;
   #endif
   if(excel_multiAsset_digitalCallPutNode)
   {
       excel_multiAsset_digitalCallPut_ = boost::shared_ptr<Excel_multiAsset_digitalCallPut>(new Excel_multiAsset_digitalCallPut(excel_multiAsset_digitalCallPutNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_multiAsset_compositeOption_subtype::getExcel_type()
{
   if(!this->excel_typeIsNull_){
        return this->excel_type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<Excel_multiAsset_vanillaCallPut> Excel_multiAsset_compositeOption_subtype::getExcel_multiAsset_vanillaCallPut()
{
   if(!this->excel_multiAsset_vanillaCallPutIsNull_){
        return this->excel_multiAsset_vanillaCallPut_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_multiAsset_vanillaCallPut>();
   }
}
boost::shared_ptr<Excel_multiAsset_upInOutCall> Excel_multiAsset_compositeOption_subtype::getExcel_multiAsset_upInOutCall()
{
   if(!this->excel_multiAsset_upInOutCallIsNull_){
        return this->excel_multiAsset_upInOutCall_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_multiAsset_upInOutCall>();
   }
}
boost::shared_ptr<Excel_multiAsset_downInOutPut> Excel_multiAsset_compositeOption_subtype::getExcel_multiAsset_downInOutPut()
{
   if(!this->excel_multiAsset_downInOutPutIsNull_){
        return this->excel_multiAsset_downInOutPut_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_multiAsset_downInOutPut>();
   }
}
boost::shared_ptr<Excel_multiAsset_digitalCallPut> Excel_multiAsset_compositeOption_subtype::getExcel_multiAsset_digitalCallPut()
{
   if(!this->excel_multiAsset_digitalCallPutIsNull_){
        return this->excel_multiAsset_digitalCallPut_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_multiAsset_digitalCallPut>();
   }
}
}

