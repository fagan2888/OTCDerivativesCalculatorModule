// ReferenceCalculation.cpp 
#include "ReferenceCalculation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ReferenceCalculation::ReferenceCalculation(TiXmlNode* xmlNode)
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

   //fixingInformationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fixingInformationNode = xmlNode->FirstChildElement("fixingInformation");

   if(fixingInformationNode){fixingInformationIsNull_ = false;}
   else{fixingInformationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fixingInformationNode , address : " << fixingInformationNode << std::endl;
   #endif
   if(fixingInformationNode)
   {
       fixingInformation_ = boost::shared_ptr<FixingInformation>(new FixingInformation(fixingInformationNode));
   }

   //choiceReferenceCalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* choiceReferenceCalNode = xmlNode->FirstChildElement("choiceReferenceCal");

   if(choiceReferenceCalNode){choiceReferenceCalIsNull_ = false;}
   else{choiceReferenceCalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- choiceReferenceCalNode , address : " << choiceReferenceCalNode << std::endl;
   #endif
   if(choiceReferenceCalNode)
   {
       choiceReferenceCal_ = boost::shared_ptr<ChoiceReferenceCal>(new ChoiceReferenceCal(choiceReferenceCalNode));
   }

   //identityReferenceCalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* identityReferenceCalNode = xmlNode->FirstChildElement("identityReferenceCal");

   if(identityReferenceCalNode){identityReferenceCalIsNull_ = false;}
   else{identityReferenceCalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- identityReferenceCalNode , address : " << identityReferenceCalNode << std::endl;
   #endif
   if(identityReferenceCalNode)
   {
       identityReferenceCal_ = boost::shared_ptr<IdentityReferenceCal>(new IdentityReferenceCal(identityReferenceCalNode));
   }

   //maximumReferenceCalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* maximumReferenceCalNode = xmlNode->FirstChildElement("maximumReferenceCal");

   if(maximumReferenceCalNode){maximumReferenceCalIsNull_ = false;}
   else{maximumReferenceCalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- maximumReferenceCalNode , address : " << maximumReferenceCalNode << std::endl;
   #endif
   if(maximumReferenceCalNode)
   {
       maximumReferenceCal_ = boost::shared_ptr<MaximumReferenceCal>(new MaximumReferenceCal(maximumReferenceCalNode));
   }

   //minimumReferenceCalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* minimumReferenceCalNode = xmlNode->FirstChildElement("minimumReferenceCal");

   if(minimumReferenceCalNode){minimumReferenceCalIsNull_ = false;}
   else{minimumReferenceCalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- minimumReferenceCalNode , address : " << minimumReferenceCalNode << std::endl;
   #endif
   if(minimumReferenceCalNode)
   {
       minimumReferenceCal_ = boost::shared_ptr<MinimumReferenceCal>(new MinimumReferenceCal(minimumReferenceCalNode));
   }

   //refVariableReferenceCalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* refVariableReferenceCalNode = xmlNode->FirstChildElement("refVariableReferenceCal");

   if(refVariableReferenceCalNode){refVariableReferenceCalIsNull_ = false;}
   else{refVariableReferenceCalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- refVariableReferenceCalNode , address : " << refVariableReferenceCalNode << std::endl;
   #endif
   if(refVariableReferenceCalNode)
   {
       refVariableReferenceCal_ = boost::shared_ptr<RefVariableReferenceCal>(new RefVariableReferenceCal(refVariableReferenceCalNode));
   }

   //dailyReturnReferenceCalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dailyReturnReferenceCalNode = xmlNode->FirstChildElement("dailyReturnReferenceCal");

   if(dailyReturnReferenceCalNode){dailyReturnReferenceCalIsNull_ = false;}
   else{dailyReturnReferenceCalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dailyReturnReferenceCalNode , address : " << dailyReturnReferenceCalNode << std::endl;
   #endif
   if(dailyReturnReferenceCalNode)
   {
       dailyReturnReferenceCal_ = boost::shared_ptr<DailyReturnReferenceCal>(new DailyReturnReferenceCal(dailyReturnReferenceCalNode));
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

   //refVariable_referenceValueNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* refVariable_referenceValueNode = xmlNode->FirstChildElement("refVariable_referenceValue");

   if(refVariable_referenceValueNode){refVariable_referenceValueIsNull_ = false;}
   else{refVariable_referenceValueIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- refVariable_referenceValueNode , address : " << refVariable_referenceValueNode << std::endl;
   #endif
   if(refVariable_referenceValueNode)
   {
       refVariable_referenceValue_ = boost::shared_ptr<RefVariable_referenceValue>(new RefVariable_referenceValue(refVariable_referenceValueNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> ReferenceCalculation::getType()
{
   if(!this->typeIsNull_){
        return this->type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<FixingInformation> ReferenceCalculation::getFixingInformation()
{
   if(!this->fixingInformationIsNull_){
        return this->fixingInformation_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FixingInformation>();
   }
}
boost::shared_ptr<ChoiceReferenceCal> ReferenceCalculation::getChoiceReferenceCal()
{
   if(!this->choiceReferenceCalIsNull_){
        return this->choiceReferenceCal_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ChoiceReferenceCal>();
   }
}
boost::shared_ptr<IdentityReferenceCal> ReferenceCalculation::getIdentityReferenceCal()
{
   if(!this->identityReferenceCalIsNull_){
        return this->identityReferenceCal_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<IdentityReferenceCal>();
   }
}
boost::shared_ptr<MaximumReferenceCal> ReferenceCalculation::getMaximumReferenceCal()
{
   if(!this->maximumReferenceCalIsNull_){
        return this->maximumReferenceCal_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<MaximumReferenceCal>();
   }
}
boost::shared_ptr<MinimumReferenceCal> ReferenceCalculation::getMinimumReferenceCal()
{
   if(!this->minimumReferenceCalIsNull_){
        return this->minimumReferenceCal_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<MinimumReferenceCal>();
   }
}
boost::shared_ptr<RefVariableReferenceCal> ReferenceCalculation::getRefVariableReferenceCal()
{
   if(!this->refVariableReferenceCalIsNull_){
        return this->refVariableReferenceCal_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<RefVariableReferenceCal>();
   }
}
boost::shared_ptr<DailyReturnReferenceCal> ReferenceCalculation::getDailyReturnReferenceCal()
{
   if(!this->dailyReturnReferenceCalIsNull_){
        return this->dailyReturnReferenceCal_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DailyReturnReferenceCal>();
   }
}
boost::shared_ptr<PostCalculation> ReferenceCalculation::getPostCalculation()
{
   if(!this->postCalculationIsNull_){
        return this->postCalculation_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PostCalculation>();
   }
}
boost::shared_ptr<RefVariable_referenceValue> ReferenceCalculation::getRefVariable_referenceValue()
{
   if(!this->refVariable_referenceValueIsNull_){
        return this->refVariable_referenceValue_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<RefVariable_referenceValue>();
   }
}
}

