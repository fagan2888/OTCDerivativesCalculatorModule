// Excel_geometricBM.cpp 
#include "Excel_geometricBM.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_geometricBM::Excel_geometricBM(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //currentValueNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* currentValueNode = xmlNode->FirstChildElement("currentValue");

   if(currentValueNode){currentValueIsNull_ = false;}
   else{currentValueIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- currentValueNode , address : " << currentValueNode << std::endl;
   #endif
   if(currentValueNode)
   {
       currentValue_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(currentValueNode));
   }

   //driftNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* driftNode = xmlNode->FirstChildElement("drift");

   if(driftNode){driftIsNull_ = false;}
   else{driftIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- driftNode , address : " << driftNode << std::endl;
   #endif
   if(driftNode)
   {
       drift_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(driftNode));
   }

   //dividendNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dividendNode = xmlNode->FirstChildElement("dividend");

   if(dividendNode){dividendIsNull_ = false;}
   else{dividendIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dividendNode , address : " << dividendNode << std::endl;
   #endif
   if(dividendNode)
   {
       dividend_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(dividendNode));
   }

   //volatilityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* volatilityNode = xmlNode->FirstChildElement("volatility");

   if(volatilityNode){volatilityIsNull_ = false;}
   else{volatilityIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- volatilityNode , address : " << volatilityNode << std::endl;
   #endif
   if(volatilityNode)
   {
       volatility_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(volatilityNode));
   }

   //vba_descriptionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* vba_descriptionNode = xmlNode->FirstChildElement("vba_description");

   if(vba_descriptionNode){vba_descriptionIsNull_ = false;}
   else{vba_descriptionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- vba_descriptionNode , address : " << vba_descriptionNode << std::endl;
   #endif
   if(vba_descriptionNode)
   {
       vba_description_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(vba_descriptionNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_geometricBM::getCurrentValue()
{
   if(!this->currentValueIsNull_){
        return this->currentValue_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_geometricBM::getDrift()
{
   if(!this->driftIsNull_){
        return this->drift_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_geometricBM::getDividend()
{
   if(!this->dividendIsNull_){
        return this->dividend_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_geometricBM::getVolatility()
{
   if(!this->volatilityIsNull_){
        return this->volatility_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_geometricBM::getVba_description()
{
   if(!this->vba_descriptionIsNull_){
        return this->vba_description_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

