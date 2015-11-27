// Excel_interface.cpp 
#include "Excel_interface.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_interface::Excel_interface(TiXmlNode* xmlNode)
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

   //excel_hifiveNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_hifiveNode = xmlNode->FirstChildElement("excel_hifive");

   if(excel_hifiveNode){excel_hifiveIsNull_ = false;}
   else{excel_hifiveIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_hifiveNode , address : " << excel_hifiveNode << std::endl;
   #endif
   if(excel_hifiveNode)
   {
       excel_hifive_ = boost::shared_ptr<Excel_hifive>(new Excel_hifive(excel_hifiveNode));
   }

   //excel_stepDownKICustomNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_stepDownKICustomNode = xmlNode->FirstChildElement("excel_stepDownKICustom");

   if(excel_stepDownKICustomNode){excel_stepDownKICustomIsNull_ = false;}
   else{excel_stepDownKICustomIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_stepDownKICustomNode , address : " << excel_stepDownKICustomNode << std::endl;
   #endif
   if(excel_stepDownKICustomNode)
   {
       excel_stepDownKICustom_ = boost::shared_ptr<Excel_stepDownKICustom>(new Excel_stepDownKICustom(excel_stepDownKICustomNode));
   }

   //excel_compositeOptionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_compositeOptionNode = xmlNode->FirstChildElement("excel_compositeOption");

   if(excel_compositeOptionNode){excel_compositeOptionIsNull_ = false;}
   else{excel_compositeOptionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_compositeOptionNode , address : " << excel_compositeOptionNode << std::endl;
   #endif
   if(excel_compositeOptionNode)
   {
       excel_compositeOption_ = boost::shared_ptr<Excel_compositeOption>(new Excel_compositeOption(excel_compositeOptionNode));
   }

   //excel_generalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_generalNode = xmlNode->FirstChildElement("excel_general");

   if(excel_generalNode){excel_generalIsNull_ = false;}
   else{excel_generalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_generalNode , address : " << excel_generalNode << std::endl;
   #endif
   if(excel_generalNode)
   {
       excel_general_ = boost::shared_ptr<Excel_general>(new Excel_general(excel_generalNode));
   }

   //excel_fixedBondNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_fixedBondNode = xmlNode->FirstChildElement("excel_fixedBond");

   if(excel_fixedBondNode){excel_fixedBondIsNull_ = false;}
   else{excel_fixedBondIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_fixedBondNode , address : " << excel_fixedBondNode << std::endl;
   #endif
   if(excel_fixedBondNode)
   {
       excel_fixedBond_ = boost::shared_ptr<Excel_fixedBond>(new Excel_fixedBond(excel_fixedBondNode));
   }

   //excel_vanillaFloatingBondNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_vanillaFloatingBondNode = xmlNode->FirstChildElement("excel_vanillaFloatingBond");

   if(excel_vanillaFloatingBondNode){excel_vanillaFloatingBondIsNull_ = false;}
   else{excel_vanillaFloatingBondIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_vanillaFloatingBondNode , address : " << excel_vanillaFloatingBondNode << std::endl;
   #endif
   if(excel_vanillaFloatingBondNode)
   {
       excel_vanillaFloatingBond_ = boost::shared_ptr<Excel_vanillaFloatingBond>(new Excel_vanillaFloatingBond(excel_vanillaFloatingBondNode));
   }

   //excel_structuredBondNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_structuredBondNode = xmlNode->FirstChildElement("excel_structuredBond");

   if(excel_structuredBondNode){excel_structuredBondIsNull_ = false;}
   else{excel_structuredBondIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_structuredBondNode , address : " << excel_structuredBondNode << std::endl;
   #endif
   if(excel_structuredBondNode)
   {
       excel_structuredBond_ = boost::shared_ptr<Excel_structuredBond>(new Excel_structuredBond(excel_structuredBondNode));
   }

   //excel_fxForwardNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_fxForwardNode = xmlNode->FirstChildElement("excel_fxForward");

   if(excel_fxForwardNode){excel_fxForwardIsNull_ = false;}
   else{excel_fxForwardIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_fxForwardNode , address : " << excel_fxForwardNode << std::endl;
   #endif
   if(excel_fxForwardNode)
   {
       excel_fxForward_ = boost::shared_ptr<Excel_fxForward>(new Excel_fxForward(excel_fxForwardNode));
   }

   //excel_fxSwapNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_fxSwapNode = xmlNode->FirstChildElement("excel_fxSwap");

   if(excel_fxSwapNode){excel_fxSwapIsNull_ = false;}
   else{excel_fxSwapIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_fxSwapNode , address : " << excel_fxSwapNode << std::endl;
   #endif
   if(excel_fxSwapNode)
   {
       excel_fxSwap_ = boost::shared_ptr<Excel_fxSwap>(new Excel_fxSwap(excel_fxSwapNode));
   }

   //excel_multiAssetCompositeOptionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_multiAssetCompositeOptionNode = xmlNode->FirstChildElement("excel_multiAssetCompositeOption");

   if(excel_multiAssetCompositeOptionNode){excel_multiAssetCompositeOptionIsNull_ = false;}
   else{excel_multiAssetCompositeOptionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_multiAssetCompositeOptionNode , address : " << excel_multiAssetCompositeOptionNode << std::endl;
   #endif
   if(excel_multiAssetCompositeOptionNode)
   {
       excel_multiAssetCompositeOption_ = boost::shared_ptr<Excel_multiAssetCompositeOption>(new Excel_multiAssetCompositeOption(excel_multiAssetCompositeOptionNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_interface::getExcel_type()
{
   if(!this->excel_typeIsNull_){
        return this->excel_type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<Excel_hifive> Excel_interface::getExcel_hifive()
{
   if(!this->excel_hifiveIsNull_){
        return this->excel_hifive_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_hifive>();
   }
}
boost::shared_ptr<Excel_stepDownKICustom> Excel_interface::getExcel_stepDownKICustom()
{
   if(!this->excel_stepDownKICustomIsNull_){
        return this->excel_stepDownKICustom_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_stepDownKICustom>();
   }
}
boost::shared_ptr<Excel_compositeOption> Excel_interface::getExcel_compositeOption()
{
   if(!this->excel_compositeOptionIsNull_){
        return this->excel_compositeOption_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_compositeOption>();
   }
}
boost::shared_ptr<Excel_general> Excel_interface::getExcel_general()
{
   if(!this->excel_generalIsNull_){
        return this->excel_general_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_general>();
   }
}
boost::shared_ptr<Excel_fixedBond> Excel_interface::getExcel_fixedBond()
{
   if(!this->excel_fixedBondIsNull_){
        return this->excel_fixedBond_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_fixedBond>();
   }
}
boost::shared_ptr<Excel_vanillaFloatingBond> Excel_interface::getExcel_vanillaFloatingBond()
{
   if(!this->excel_vanillaFloatingBondIsNull_){
        return this->excel_vanillaFloatingBond_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_vanillaFloatingBond>();
   }
}
boost::shared_ptr<Excel_structuredBond> Excel_interface::getExcel_structuredBond()
{
   if(!this->excel_structuredBondIsNull_){
        return this->excel_structuredBond_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_structuredBond>();
   }
}
boost::shared_ptr<Excel_fxForward> Excel_interface::getExcel_fxForward()
{
   if(!this->excel_fxForwardIsNull_){
        return this->excel_fxForward_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_fxForward>();
   }
}
boost::shared_ptr<Excel_fxSwap> Excel_interface::getExcel_fxSwap()
{
   if(!this->excel_fxSwapIsNull_){
        return this->excel_fxSwap_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_fxSwap>();
   }
}
boost::shared_ptr<Excel_multiAssetCompositeOption> Excel_interface::getExcel_multiAssetCompositeOption()
{
   if(!this->excel_multiAssetCompositeOptionIsNull_){
        return this->excel_multiAssetCompositeOption_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_multiAssetCompositeOption>();
   }
}
}

