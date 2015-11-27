// Excel_underlyingModel_para.cpp 
#include "Excel_underlyingModel_para.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_underlyingModel_para::Excel_underlyingModel_para(TiXmlNode* xmlNode)
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

   //excel_geometricBMNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_geometricBMNode = xmlNode->FirstChildElement("excel_geometricBM");

   if(excel_geometricBMNode){excel_geometricBMIsNull_ = false;}
   else{excel_geometricBMIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_geometricBMNode , address : " << excel_geometricBMNode << std::endl;
   #endif
   if(excel_geometricBMNode)
   {
       excel_geometricBM_ = boost::shared_ptr<Excel_geometricBM>(new Excel_geometricBM(excel_geometricBMNode));
   }

   //excel_hullWhiteOneFactorNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_hullWhiteOneFactorNode = xmlNode->FirstChildElement("excel_hullWhiteOneFactor");

   if(excel_hullWhiteOneFactorNode){excel_hullWhiteOneFactorIsNull_ = false;}
   else{excel_hullWhiteOneFactorIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_hullWhiteOneFactorNode , address : " << excel_hullWhiteOneFactorNode << std::endl;
   #endif
   if(excel_hullWhiteOneFactorNode)
   {
       excel_hullWhiteOneFactor_ = boost::shared_ptr<Excel_hullWhiteOneFactor>(new Excel_hullWhiteOneFactor(excel_hullWhiteOneFactorNode));
   }

   //excel_hullWhiteTwoFactorNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_hullWhiteTwoFactorNode = xmlNode->FirstChildElement("excel_hullWhiteTwoFactor");

   if(excel_hullWhiteTwoFactorNode){excel_hullWhiteTwoFactorIsNull_ = false;}
   else{excel_hullWhiteTwoFactorIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_hullWhiteTwoFactorNode , address : " << excel_hullWhiteTwoFactorNode << std::endl;
   #endif
   if(excel_hullWhiteTwoFactorNode)
   {
       excel_hullWhiteTwoFactor_ = boost::shared_ptr<Excel_hullWhiteTwoFactor>(new Excel_hullWhiteTwoFactor(excel_hullWhiteTwoFactorNode));
   }

   //excel_forwardModelNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_forwardModelNode = xmlNode->FirstChildElement("excel_forwardModel");

   if(excel_forwardModelNode){excel_forwardModelIsNull_ = false;}
   else{excel_forwardModelIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_forwardModelNode , address : " << excel_forwardModelNode << std::endl;
   #endif
   if(excel_forwardModelNode)
   {
       excel_forwardModel_ = boost::shared_ptr<Excel_forwardModel>(new Excel_forwardModel(excel_forwardModelNode));
   }

   //excel_hestonModelNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_hestonModelNode = xmlNode->FirstChildElement("excel_hestonModel");

   if(excel_hestonModelNode){excel_hestonModelIsNull_ = false;}
   else{excel_hestonModelIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_hestonModelNode , address : " << excel_hestonModelNode << std::endl;
   #endif
   if(excel_hestonModelNode)
   {
       excel_hestonModel_ = boost::shared_ptr<Excel_hestonModel>(new Excel_hestonModel(excel_hestonModelNode));
   }

   //excel_geometricBM_LocalVolNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_geometricBM_LocalVolNode = xmlNode->FirstChildElement("excel_geometricBM_LocalVol");

   if(excel_geometricBM_LocalVolNode){excel_geometricBM_LocalVolIsNull_ = false;}
   else{excel_geometricBM_LocalVolIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_geometricBM_LocalVolNode , address : " << excel_geometricBM_LocalVolNode << std::endl;
   #endif
   if(excel_geometricBM_LocalVolNode)
   {
       excel_geometricBM_LocalVol_ = boost::shared_ptr<Excel_geometricBM_LocalVol>(new Excel_geometricBM_LocalVol(excel_geometricBM_LocalVolNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_underlyingModel_para::getExcel_type()
{
   if(!this->excel_typeIsNull_){
        return this->excel_type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<Excel_geometricBM> Excel_underlyingModel_para::getExcel_geometricBM()
{
   if(!this->excel_geometricBMIsNull_){
        return this->excel_geometricBM_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_geometricBM>();
   }
}
boost::shared_ptr<Excel_hullWhiteOneFactor> Excel_underlyingModel_para::getExcel_hullWhiteOneFactor()
{
   if(!this->excel_hullWhiteOneFactorIsNull_){
        return this->excel_hullWhiteOneFactor_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_hullWhiteOneFactor>();
   }
}
boost::shared_ptr<Excel_hullWhiteTwoFactor> Excel_underlyingModel_para::getExcel_hullWhiteTwoFactor()
{
   if(!this->excel_hullWhiteTwoFactorIsNull_){
        return this->excel_hullWhiteTwoFactor_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_hullWhiteTwoFactor>();
   }
}
boost::shared_ptr<Excel_forwardModel> Excel_underlyingModel_para::getExcel_forwardModel()
{
   if(!this->excel_forwardModelIsNull_){
        return this->excel_forwardModel_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_forwardModel>();
   }
}
boost::shared_ptr<Excel_hestonModel> Excel_underlyingModel_para::getExcel_hestonModel()
{
   if(!this->excel_hestonModelIsNull_){
        return this->excel_hestonModel_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_hestonModel>();
   }
}
boost::shared_ptr<Excel_geometricBM_LocalVol> Excel_underlyingModel_para::getExcel_geometricBM_LocalVol()
{
   if(!this->excel_geometricBM_LocalVolIsNull_){
        return this->excel_geometricBM_LocalVol_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_geometricBM_LocalVol>();
   }
}
}

