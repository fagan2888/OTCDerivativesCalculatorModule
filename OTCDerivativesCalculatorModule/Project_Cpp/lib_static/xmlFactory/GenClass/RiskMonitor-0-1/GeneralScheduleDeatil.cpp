// GeneralScheduleDeatil.cpp 
#include "GeneralScheduleDeatil.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

GeneralScheduleDeatil::GeneralScheduleDeatil(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //eventDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* eventDateNode = xmlNode->FirstChildElement("eventDate");

   if(eventDateNode){eventDateIsNull_ = false;}
   else{eventDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- eventDateNode , address : " << eventDateNode << std::endl;
   #endif
   if(eventDateNode)
   {
       eventDate_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(eventDateNode));
   }

   //typeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* typeNode = xmlNode->FirstChildElement("type");

   if(typeNode){typeIsNull_ = false;}
   else{typeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- typeNode , address : " << typeNode << std::endl;
   #endif
   if(typeNode)
   {
       type_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(typeNode));
   }

   //general_scheduleDetail_fixedCouponNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* general_scheduleDetail_fixedCouponNode = xmlNode->FirstChildElement("general_scheduleDetail_fixedCoupon");

   if(general_scheduleDetail_fixedCouponNode){general_scheduleDetail_fixedCouponIsNull_ = false;}
   else{general_scheduleDetail_fixedCouponIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- general_scheduleDetail_fixedCouponNode , address : " << general_scheduleDetail_fixedCouponNode << std::endl;
   #endif
   if(general_scheduleDetail_fixedCouponNode)
   {
       general_scheduleDetail_fixedCoupon_ = boost::shared_ptr<General_scheduleDetail_fixedCoupon>(new General_scheduleDetail_fixedCoupon(general_scheduleDetail_fixedCouponNode));
   }

   //general_scheduleDetail_fixedAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* general_scheduleDetail_fixedAmountNode = xmlNode->FirstChildElement("general_scheduleDetail_fixedAmount");

   if(general_scheduleDetail_fixedAmountNode){general_scheduleDetail_fixedAmountIsNull_ = false;}
   else{general_scheduleDetail_fixedAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- general_scheduleDetail_fixedAmountNode , address : " << general_scheduleDetail_fixedAmountNode << std::endl;
   #endif
   if(general_scheduleDetail_fixedAmountNode)
   {
       general_scheduleDetail_fixedAmount_ = boost::shared_ptr<General_scheduleDetail_fixedAmount>(new General_scheduleDetail_fixedAmount(general_scheduleDetail_fixedAmountNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> GeneralScheduleDeatil::getEventDate()
{
   if(!this->eventDateIsNull_){
        return this->eventDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> GeneralScheduleDeatil::getType()
{
   if(!this->typeIsNull_){
        return this->type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<General_scheduleDetail_fixedCoupon> GeneralScheduleDeatil::getGeneral_scheduleDetail_fixedCoupon()
{
   if(!this->general_scheduleDetail_fixedCouponIsNull_){
        return this->general_scheduleDetail_fixedCoupon_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<General_scheduleDetail_fixedCoupon>();
   }
}
boost::shared_ptr<General_scheduleDetail_fixedAmount> GeneralScheduleDeatil::getGeneral_scheduleDetail_fixedAmount()
{
   if(!this->general_scheduleDetail_fixedAmountIsNull_){
        return this->general_scheduleDetail_fixedAmount_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<General_scheduleDetail_fixedAmount>();
   }
}
}

