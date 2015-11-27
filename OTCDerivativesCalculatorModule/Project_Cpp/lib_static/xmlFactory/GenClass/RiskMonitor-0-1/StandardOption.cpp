// StandardOption.cpp 
#include "StandardOption.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

StandardOption::StandardOption(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //unitNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* unitNode = xmlNode->FirstChildElement("unit");

   if(unitNode){unitIsNull_ = false;}
   else{unitIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- unitNode , address : " << unitNode << std::endl;
   #endif
   if(unitNode)
   {
       unit_ = boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(unitNode));
   }

   //baseCouponNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* baseCouponNode = xmlNode->FirstChildElement("baseCoupon");

   if(baseCouponNode){baseCouponIsNull_ = false;}
   else{baseCouponIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- baseCouponNode , address : " << baseCouponNode << std::endl;
   #endif
   if(baseCouponNode)
   {
       baseCoupon_ = boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(baseCouponNode));
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

   //singleBarrierNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* singleBarrierNode = xmlNode->FirstChildElement("singleBarrier");

   if(singleBarrierNode){singleBarrierIsNull_ = false;}
   else{singleBarrierIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- singleBarrierNode , address : " << singleBarrierNode << std::endl;
   #endif
   if(singleBarrierNode)
   {
       singleBarrier_ = boost::shared_ptr<SingleBarrier>(new SingleBarrier(singleBarrierNode));
   }

   //vanillaCallOptionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* vanillaCallOptionNode = xmlNode->FirstChildElement("vanillaCallOption");

   if(vanillaCallOptionNode){vanillaCallOptionIsNull_ = false;}
   else{vanillaCallOptionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- vanillaCallOptionNode , address : " << vanillaCallOptionNode << std::endl;
   #endif
   if(vanillaCallOptionNode)
   {
       vanillaCallOption_ = boost::shared_ptr<VanillaCallOption>(new VanillaCallOption(vanillaCallOptionNode));
   }

   //vanillaPutOptionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* vanillaPutOptionNode = xmlNode->FirstChildElement("vanillaPutOption");

   if(vanillaPutOptionNode){vanillaPutOptionIsNull_ = false;}
   else{vanillaPutOptionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- vanillaPutOptionNode , address : " << vanillaPutOptionNode << std::endl;
   #endif
   if(vanillaPutOptionNode)
   {
       vanillaPutOption_ = boost::shared_ptr<VanillaPutOption>(new VanillaPutOption(vanillaPutOptionNode));
   }

   //barrierWithConstRebateCallOptionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* barrierWithConstRebateCallOptionNode = xmlNode->FirstChildElement("barrierWithConstRebateCallOption");

   if(barrierWithConstRebateCallOptionNode){barrierWithConstRebateCallOptionIsNull_ = false;}
   else{barrierWithConstRebateCallOptionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- barrierWithConstRebateCallOptionNode , address : " << barrierWithConstRebateCallOptionNode << std::endl;
   #endif
   if(barrierWithConstRebateCallOptionNode)
   {
       barrierWithConstRebateCallOption_ = boost::shared_ptr<BarrierWithConstRebateCallOption>(new BarrierWithConstRebateCallOption(barrierWithConstRebateCallOptionNode));
   }

   //barrierWithConstRebatePutOptionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* barrierWithConstRebatePutOptionNode = xmlNode->FirstChildElement("barrierWithConstRebatePutOption");

   if(barrierWithConstRebatePutOptionNode){barrierWithConstRebatePutOptionIsNull_ = false;}
   else{barrierWithConstRebatePutOptionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- barrierWithConstRebatePutOptionNode , address : " << barrierWithConstRebatePutOptionNode << std::endl;
   #endif
   if(barrierWithConstRebatePutOptionNode)
   {
       barrierWithConstRebatePutOption_ = boost::shared_ptr<BarrierWithConstRebatePutOption>(new BarrierWithConstRebatePutOption(barrierWithConstRebatePutOptionNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDouble> StandardOption::getUnit()
{
   if(!this->unitIsNull_){
        return this->unit_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDouble>();
   }
}
boost::shared_ptr<XsdTypeDouble> StandardOption::getBaseCoupon()
{
   if(!this->baseCouponIsNull_){
        return this->baseCoupon_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDouble>();
   }
}
boost::shared_ptr<XsdTypeToken> StandardOption::getType()
{
   if(!this->typeIsNull_){
        return this->type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<SingleBarrier> StandardOption::getSingleBarrier()
{
   if(!this->singleBarrierIsNull_){
        return this->singleBarrier_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<SingleBarrier>();
   }
}
boost::shared_ptr<VanillaCallOption> StandardOption::getVanillaCallOption()
{
   if(!this->vanillaCallOptionIsNull_){
        return this->vanillaCallOption_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<VanillaCallOption>();
   }
}
boost::shared_ptr<VanillaPutOption> StandardOption::getVanillaPutOption()
{
   if(!this->vanillaPutOptionIsNull_){
        return this->vanillaPutOption_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<VanillaPutOption>();
   }
}
boost::shared_ptr<BarrierWithConstRebateCallOption> StandardOption::getBarrierWithConstRebateCallOption()
{
   if(!this->barrierWithConstRebateCallOptionIsNull_){
        return this->barrierWithConstRebateCallOption_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BarrierWithConstRebateCallOption>();
   }
}
boost::shared_ptr<BarrierWithConstRebatePutOption> StandardOption::getBarrierWithConstRebatePutOption()
{
   if(!this->barrierWithConstRebatePutOptionIsNull_){
        return this->barrierWithConstRebatePutOption_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BarrierWithConstRebatePutOption>();
   }
}
}

