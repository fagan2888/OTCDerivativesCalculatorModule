// ReturnCalculation.cpp 
#include "ReturnCalculation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ReturnCalculation::ReturnCalculation(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
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

   //preCalculationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* preCalculationNode = xmlNode->FirstChildElement("preCalculation");

   if(preCalculationNode){preCalculationIsNull_ = false;}
   else{preCalculationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- preCalculationNode , address : " << preCalculationNode << std::endl;
   #endif
   if(preCalculationNode)
   {
       preCalculation_ = boost::shared_ptr<PreCalculation>(new PreCalculation(preCalculationNode));
   }

   //stopLossReturnCalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* stopLossReturnCalNode = xmlNode->FirstChildElement("stopLossReturnCal");

   if(stopLossReturnCalNode){stopLossReturnCalIsNull_ = false;}
   else{stopLossReturnCalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- stopLossReturnCalNode , address : " << stopLossReturnCalNode << std::endl;
   #endif
   if(stopLossReturnCalNode)
   {
       stopLossReturnCal_ = boost::shared_ptr<StopLossReturnCal>(new StopLossReturnCal(stopLossReturnCalNode));
   }

   //constReturnCalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* constReturnCalNode = xmlNode->FirstChildElement("constReturnCal");

   if(constReturnCalNode){constReturnCalIsNull_ = false;}
   else{constReturnCalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- constReturnCalNode , address : " << constReturnCalNode << std::endl;
   #endif
   if(constReturnCalNode)
   {
       constReturnCal_ = boost::shared_ptr<ConstReturnCal>(new ConstReturnCal(constReturnCalNode));
   }

   //vanillaReturnCalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* vanillaReturnCalNode = xmlNode->FirstChildElement("vanillaReturnCal");

   if(vanillaReturnCalNode){vanillaReturnCalIsNull_ = false;}
   else{vanillaReturnCalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- vanillaReturnCalNode , address : " << vanillaReturnCalNode << std::endl;
   #endif
   if(vanillaReturnCalNode)
   {
       vanillaReturnCal_ = boost::shared_ptr<VanillaReturnCal>(new VanillaReturnCal(vanillaReturnCalNode));
   }

   //complex1DReturnCalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* complex1DReturnCalNode = xmlNode->FirstChildElement("complex1DReturnCal");

   if(complex1DReturnCalNode){complex1DReturnCalIsNull_ = false;}
   else{complex1DReturnCalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- complex1DReturnCalNode , address : " << complex1DReturnCalNode << std::endl;
   #endif
   if(complex1DReturnCalNode)
   {
       complex1DReturnCal_ = boost::shared_ptr<Complex1DReturnCal>(new Complex1DReturnCal(complex1DReturnCalNode));
   }

   //complexNDReturnCalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* complexNDReturnCalNode = xmlNode->FirstChildElement("complexNDReturnCal");

   if(complexNDReturnCalNode){complexNDReturnCalIsNull_ = false;}
   else{complexNDReturnCalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- complexNDReturnCalNode , address : " << complexNDReturnCalNode << std::endl;
   #endif
   if(complexNDReturnCalNode)
   {
       complexNDReturnCal_ = boost::shared_ptr<ComplexNDReturnCal>(new ComplexNDReturnCal(complexNDReturnCalNode));
   }

   //zeroReturnCalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* zeroReturnCalNode = xmlNode->FirstChildElement("zeroReturnCal");

   if(zeroReturnCalNode){zeroReturnCalIsNull_ = false;}
   else{zeroReturnCalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- zeroReturnCalNode , address : " << zeroReturnCalNode << std::endl;
   #endif
   if(zeroReturnCalNode)
   {
       zeroReturnCal_ = boost::shared_ptr<ZeroReturnCal>(new ZeroReturnCal(zeroReturnCalNode));
   }

   //callPutCompositeReturnCalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* callPutCompositeReturnCalNode = xmlNode->FirstChildElement("callPutCompositeReturnCal");

   if(callPutCompositeReturnCalNode){callPutCompositeReturnCalIsNull_ = false;}
   else{callPutCompositeReturnCalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- callPutCompositeReturnCalNode , address : " << callPutCompositeReturnCalNode << std::endl;
   #endif
   if(callPutCompositeReturnCalNode)
   {
       callPutCompositeReturnCal_ = boost::shared_ptr<CallPutCompositeReturnCal>(new CallPutCompositeReturnCal(callPutCompositeReturnCalNode));
   }

   //postCalculationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* postCalculationNode = xmlNode->FirstChildElement("postCalculation");

   if(postCalculationNode){postCalculationIsNull_ = false;}
   else{postCalculationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- postCalculationNode , address : " << postCalculationNode << std::endl;
   #endif
   if(postCalculationNode)
   {
       postCalculation_ = boost::shared_ptr<PostCalculation>(new PostCalculation(postCalculationNode));
   }

   //refVariable_returnValueNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* refVariable_returnValueNode = xmlNode->FirstChildElement("refVariable_returnValue");

   if(refVariable_returnValueNode){refVariable_returnValueIsNull_ = false;}
   else{refVariable_returnValueIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- refVariable_returnValueNode , address : " << refVariable_returnValueNode << std::endl;
   #endif
   if(refVariable_returnValueNode)
   {
       refVariable_returnValue_ = boost::shared_ptr<RefVariable_returnValue>(new RefVariable_returnValue(refVariable_returnValueNode));
   }

   //resetVariableInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* resetVariableInfoNode = xmlNode->FirstChildElement("resetVariableInfo");

   if(resetVariableInfoNode){resetVariableInfoIsNull_ = false;}
   else{resetVariableInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- resetVariableInfoNode , address : " << resetVariableInfoNode << std::endl;
   #endif
   if(resetVariableInfoNode)
   {
       resetVariableInfo_ = boost::shared_ptr<ResetVariableInfo>(new ResetVariableInfo(resetVariableInfoNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> ReturnCalculation::getType()
{
   if(!this->typeIsNull_){
        return this->type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<PreCalculation> ReturnCalculation::getPreCalculation()
{
   if(!this->preCalculationIsNull_){
        return this->preCalculation_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PreCalculation>();
   }
}
boost::shared_ptr<StopLossReturnCal> ReturnCalculation::getStopLossReturnCal()
{
   if(!this->stopLossReturnCalIsNull_){
        return this->stopLossReturnCal_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<StopLossReturnCal>();
   }
}
boost::shared_ptr<ConstReturnCal> ReturnCalculation::getConstReturnCal()
{
   if(!this->constReturnCalIsNull_){
        return this->constReturnCal_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ConstReturnCal>();
   }
}
boost::shared_ptr<VanillaReturnCal> ReturnCalculation::getVanillaReturnCal()
{
   if(!this->vanillaReturnCalIsNull_){
        return this->vanillaReturnCal_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<VanillaReturnCal>();
   }
}
boost::shared_ptr<Complex1DReturnCal> ReturnCalculation::getComplex1DReturnCal()
{
   if(!this->complex1DReturnCalIsNull_){
        return this->complex1DReturnCal_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Complex1DReturnCal>();
   }
}
boost::shared_ptr<ComplexNDReturnCal> ReturnCalculation::getComplexNDReturnCal()
{
   if(!this->complexNDReturnCalIsNull_){
        return this->complexNDReturnCal_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ComplexNDReturnCal>();
   }
}
boost::shared_ptr<ZeroReturnCal> ReturnCalculation::getZeroReturnCal()
{
   if(!this->zeroReturnCalIsNull_){
        return this->zeroReturnCal_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ZeroReturnCal>();
   }
}
boost::shared_ptr<CallPutCompositeReturnCal> ReturnCalculation::getCallPutCompositeReturnCal()
{
   if(!this->callPutCompositeReturnCalIsNull_){
        return this->callPutCompositeReturnCal_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CallPutCompositeReturnCal>();
   }
}
boost::shared_ptr<PostCalculation> ReturnCalculation::getPostCalculation()
{
   if(!this->postCalculationIsNull_){
        return this->postCalculation_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PostCalculation>();
   }
}
boost::shared_ptr<RefVariable_returnValue> ReturnCalculation::getRefVariable_returnValue()
{
   if(!this->refVariable_returnValueIsNull_){
        return this->refVariable_returnValue_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<RefVariable_returnValue>();
   }
}
boost::shared_ptr<ResetVariableInfo> ReturnCalculation::getResetVariableInfo()
{
   if(!this->resetVariableInfoIsNull_){
        return this->resetVariableInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ResetVariableInfo>();
   }
}
}

