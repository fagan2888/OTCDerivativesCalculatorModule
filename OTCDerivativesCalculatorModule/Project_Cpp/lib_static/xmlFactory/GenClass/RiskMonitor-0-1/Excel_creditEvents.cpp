// Excel_creditEvents.cpp 
#include "Excel_creditEvents.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_creditEvents::Excel_creditEvents(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //failureToPayNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* failureToPayNode = xmlNode->FirstChildElement("failureToPay");

   if(failureToPayNode){failureToPayIsNull_ = false;}
   else{failureToPayIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- failureToPayNode , address : " << failureToPayNode << std::endl;
   #endif
   if(failureToPayNode)
   {
       failureToPay_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(failureToPayNode));
   }

   //obligationAccelerationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* obligationAccelerationNode = xmlNode->FirstChildElement("obligationAcceleration");

   if(obligationAccelerationNode){obligationAccelerationIsNull_ = false;}
   else{obligationAccelerationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- obligationAccelerationNode , address : " << obligationAccelerationNode << std::endl;
   #endif
   if(obligationAccelerationNode)
   {
       obligationAcceleration_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(obligationAccelerationNode));
   }

   //repudiationMoratoriumNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* repudiationMoratoriumNode = xmlNode->FirstChildElement("repudiationMoratorium");

   if(repudiationMoratoriumNode){repudiationMoratoriumIsNull_ = false;}
   else{repudiationMoratoriumIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- repudiationMoratoriumNode , address : " << repudiationMoratoriumNode << std::endl;
   #endif
   if(repudiationMoratoriumNode)
   {
       repudiationMoratorium_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(repudiationMoratoriumNode));
   }

   //restructuringNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* restructuringNode = xmlNode->FirstChildElement("restructuring");

   if(restructuringNode){restructuringIsNull_ = false;}
   else{restructuringIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- restructuringNode , address : " << restructuringNode << std::endl;
   #endif
   if(restructuringNode)
   {
       restructuring_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(restructuringNode));
   }

   //defaultRequirementNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* defaultRequirementNode = xmlNode->FirstChildElement("defaultRequirement");

   if(defaultRequirementNode){defaultRequirementIsNull_ = false;}
   else{defaultRequirementIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- defaultRequirementNode , address : " << defaultRequirementNode << std::endl;
   #endif
   if(defaultRequirementNode)
   {
       defaultRequirement_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(defaultRequirementNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_creditEvents::getFailureToPay()
{
   if(!this->failureToPayIsNull_){
        return this->failureToPay_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_creditEvents::getObligationAcceleration()
{
   if(!this->obligationAccelerationIsNull_){
        return this->obligationAcceleration_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_creditEvents::getRepudiationMoratorium()
{
   if(!this->repudiationMoratoriumIsNull_){
        return this->repudiationMoratorium_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_creditEvents::getRestructuring()
{
   if(!this->restructuringIsNull_){
        return this->restructuring_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_creditEvents::getDefaultRequirement()
{
   if(!this->defaultRequirementIsNull_){
        return this->defaultRequirement_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

