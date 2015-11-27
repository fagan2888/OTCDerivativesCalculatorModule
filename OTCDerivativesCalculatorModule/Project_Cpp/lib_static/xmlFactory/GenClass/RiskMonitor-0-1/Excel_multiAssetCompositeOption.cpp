// Excel_multiAssetCompositeOption.cpp 
#include "Excel_multiAssetCompositeOption.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_multiAssetCompositeOption::Excel_multiAssetCompositeOption(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //excel_issueInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_issueInfoNode = xmlNode->FirstChildElement("excel_issueInfo");

   if(excel_issueInfoNode){excel_issueInfoIsNull_ = false;}
   else{excel_issueInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_issueInfoNode , address : " << excel_issueInfoNode << std::endl;
   #endif
   if(excel_issueInfoNode)
   {
       excel_issueInfo_ = boost::shared_ptr<Excel_issueInfo>(new Excel_issueInfo(excel_issueInfoNode));
   }

   //excel_underlyingCalcInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_underlyingCalcInfoNode = xmlNode->FirstChildElement("excel_underlyingCalcInfo");

   if(excel_underlyingCalcInfoNode){excel_underlyingCalcInfoIsNull_ = false;}
   else{excel_underlyingCalcInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_underlyingCalcInfoNode , address : " << excel_underlyingCalcInfoNode << std::endl;
   #endif
   if(excel_underlyingCalcInfoNode)
   {
       excel_underlyingCalcInfo_ = boost::shared_ptr<Excel_underlyingCalcInfo>(new Excel_underlyingCalcInfo(excel_underlyingCalcInfoNode));
   }

   //exerciseDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* exerciseDateNode = xmlNode->FirstChildElement("exerciseDate");

   if(exerciseDateNode){exerciseDateIsNull_ = false;}
   else{exerciseDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- exerciseDateNode , address : " << exerciseDateNode << std::endl;
   #endif
   if(exerciseDateNode)
   {
       exerciseDate_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(exerciseDateNode));
   }

   //payoffDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* payoffDateNode = xmlNode->FirstChildElement("payoffDate");

   if(payoffDateNode){payoffDateIsNull_ = false;}
   else{payoffDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- payoffDateNode , address : " << payoffDateNode << std::endl;
   #endif
   if(payoffDateNode)
   {
       payoffDate_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(payoffDateNode));
   }

   //notionalMaturityPaymentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* notionalMaturityPaymentNode = xmlNode->FirstChildElement("notionalMaturityPayment");

   if(notionalMaturityPaymentNode){notionalMaturityPaymentIsNull_ = false;}
   else{notionalMaturityPaymentIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- notionalMaturityPaymentNode , address : " << notionalMaturityPaymentNode << std::endl;
   #endif
   if(notionalMaturityPaymentNode)
   {
       notionalMaturityPayment_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(notionalMaturityPaymentNode));
   }

   //excel_multiAsset_compositeOption_subtypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_multiAsset_compositeOption_subtypeNode = xmlNode->FirstChildElement("excel_multiAsset_compositeOption_subtype");

   if(excel_multiAsset_compositeOption_subtypeNode){excel_multiAsset_compositeOption_subtypeIsNull_ = false;}
   else{excel_multiAsset_compositeOption_subtypeIsNull_ = true;}

   if(excel_multiAsset_compositeOption_subtypeNode)
   {
      for(excel_multiAsset_compositeOption_subtypeNode; excel_multiAsset_compositeOption_subtypeNode; excel_multiAsset_compositeOption_subtypeNode = excel_multiAsset_compositeOption_subtypeNode->NextSiblingElement("excel_multiAsset_compositeOption_subtype")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_multiAsset_compositeOption_subtypeNode , address : " << excel_multiAsset_compositeOption_subtypeNode << std::endl;
          #endif
          excel_multiAsset_compositeOption_subtype_.push_back(boost::shared_ptr<Excel_multiAsset_compositeOption_subtype>(new Excel_multiAsset_compositeOption_subtype(excel_multiAsset_compositeOption_subtypeNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_multiAsset_compositeOption_subtypeNode , address : " << excel_multiAsset_compositeOption_subtypeNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Excel_issueInfo> Excel_multiAssetCompositeOption::getExcel_issueInfo()
{
   if(!this->excel_issueInfoIsNull_){
        return this->excel_issueInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_issueInfo>();
   }
}
boost::shared_ptr<Excel_underlyingCalcInfo> Excel_multiAssetCompositeOption::getExcel_underlyingCalcInfo()
{
   if(!this->excel_underlyingCalcInfoIsNull_){
        return this->excel_underlyingCalcInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_underlyingCalcInfo>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_multiAssetCompositeOption::getExerciseDate()
{
   if(!this->exerciseDateIsNull_){
        return this->exerciseDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_multiAssetCompositeOption::getPayoffDate()
{
   if(!this->payoffDateIsNull_){
        return this->payoffDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_multiAssetCompositeOption::getNotionalMaturityPayment()
{
   if(!this->notionalMaturityPaymentIsNull_){
        return this->notionalMaturityPayment_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
std::vector<boost::shared_ptr<Excel_multiAsset_compositeOption_subtype>> Excel_multiAssetCompositeOption::getExcel_multiAsset_compositeOption_subtype()
{
   if(!this->excel_multiAsset_compositeOption_subtypeIsNull_){
        return this->excel_multiAsset_compositeOption_subtype_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Excel_multiAsset_compositeOption_subtype>>();
   }
}
}

