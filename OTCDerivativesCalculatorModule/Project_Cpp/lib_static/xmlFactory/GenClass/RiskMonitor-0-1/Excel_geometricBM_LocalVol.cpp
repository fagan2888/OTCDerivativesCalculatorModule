// Excel_geometricBM_LocalVol.cpp 
#include "Excel_geometricBM_LocalVol.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_geometricBM_LocalVol::Excel_geometricBM_LocalVol(TiXmlNode* xmlNode)
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

   //linkedSurfaceCodeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* linkedSurfaceCodeNode = xmlNode->FirstChildElement("linkedSurfaceCode");

   if(linkedSurfaceCodeNode){linkedSurfaceCodeIsNull_ = false;}
   else{linkedSurfaceCodeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- linkedSurfaceCodeNode , address : " << linkedSurfaceCodeNode << std::endl;
   #endif
   if(linkedSurfaceCodeNode)
   {
       linkedSurfaceCode_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(linkedSurfaceCodeNode));
   }

   //excel_volSurfaceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_volSurfaceNode = xmlNode->FirstChildElement("excel_volSurface");

   if(excel_volSurfaceNode){excel_volSurfaceIsNull_ = false;}
   else{excel_volSurfaceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_volSurfaceNode , address : " << excel_volSurfaceNode << std::endl;
   #endif
   if(excel_volSurfaceNode)
   {
       excel_volSurface_ = boost::shared_ptr<Excel_volSurface>(new Excel_volSurface(excel_volSurfaceNode));
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
boost::shared_ptr<XsdTypeToken> Excel_geometricBM_LocalVol::getCurrentValue()
{
   if(!this->currentValueIsNull_){
        return this->currentValue_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_geometricBM_LocalVol::getDrift()
{
   if(!this->driftIsNull_){
        return this->drift_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_geometricBM_LocalVol::getDividend()
{
   if(!this->dividendIsNull_){
        return this->dividend_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_geometricBM_LocalVol::getLinkedSurfaceCode()
{
   if(!this->linkedSurfaceCodeIsNull_){
        return this->linkedSurfaceCode_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<Excel_volSurface> Excel_geometricBM_LocalVol::getExcel_volSurface()
{
   if(!this->excel_volSurfaceIsNull_){
        return this->excel_volSurface_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_volSurface>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_geometricBM_LocalVol::getVba_description()
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

