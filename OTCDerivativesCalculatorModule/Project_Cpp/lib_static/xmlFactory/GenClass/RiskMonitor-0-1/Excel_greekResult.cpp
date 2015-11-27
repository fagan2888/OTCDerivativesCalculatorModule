// Excel_greekResult.cpp 
#include "Excel_greekResult.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_greekResult::Excel_greekResult(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //excel_greekUnderlyingNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_greekUnderlyingNode = xmlNode->FirstChildElement("excel_greekUnderlying");

   if(excel_greekUnderlyingNode){excel_greekUnderlyingIsNull_ = false;}
   else{excel_greekUnderlyingIsNull_ = true;}

   if(excel_greekUnderlyingNode)
   {
      for(excel_greekUnderlyingNode; excel_greekUnderlyingNode; excel_greekUnderlyingNode = excel_greekUnderlyingNode->NextSiblingElement("excel_greekUnderlying")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_greekUnderlyingNode , address : " << excel_greekUnderlyingNode << std::endl;
          #endif
          excel_greekUnderlying_.push_back(boost::shared_ptr<Excel_greekUnderlying>(new Excel_greekUnderlying(excel_greekUnderlyingNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_greekUnderlyingNode , address : " << excel_greekUnderlyingNode << std::endl;
       #endif
   }

   //thetaNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* thetaNode = xmlNode->FirstChildElement("theta");

   if(thetaNode){thetaIsNull_ = false;}
   else{thetaIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- thetaNode , address : " << thetaNode << std::endl;
   #endif
   if(thetaNode)
   {
       theta_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(thetaNode));
   }

   //rhoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* rhoNode = xmlNode->FirstChildElement("rho");

   if(rhoNode){rhoIsNull_ = false;}
   else{rhoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- rhoNode , address : " << rhoNode << std::endl;
   #endif
   if(rhoNode)
   {
       rho_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(rhoNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<Excel_greekUnderlying>> Excel_greekResult::getExcel_greekUnderlying()
{
   if(!this->excel_greekUnderlyingIsNull_){
        return this->excel_greekUnderlying_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Excel_greekUnderlying>>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_greekResult::getTheta()
{
   if(!this->thetaIsNull_){
        return this->theta_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_greekResult::getRho()
{
   if(!this->rhoIsNull_){
        return this->rho_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

