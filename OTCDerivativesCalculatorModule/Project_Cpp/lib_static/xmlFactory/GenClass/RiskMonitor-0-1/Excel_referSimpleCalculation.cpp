// Excel_referSimpleCalculation.cpp 
#include "Excel_referSimpleCalculation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_referSimpleCalculation::Excel_referSimpleCalculation(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //calculationIDNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calculationIDNode = xmlNode->FirstChildElement("calculationID");

   if(calculationIDNode){calculationIDIsNull_ = false;}
   else{calculationIDIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationIDNode , address : " << calculationIDNode << std::endl;
   #endif
   if(calculationIDNode)
   {
       calculationID_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(calculationIDNode));
   }

   //referenceTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* referenceTypeNode = xmlNode->FirstChildElement("referenceType");

   if(referenceTypeNode){referenceTypeIsNull_ = false;}
   else{referenceTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- referenceTypeNode , address : " << referenceTypeNode << std::endl;
   #endif
   if(referenceTypeNode)
   {
       referenceType_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(referenceTypeNode));
   }

   //referenceSetNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* referenceSetNode = xmlNode->FirstChildElement("referenceSet");

   if(referenceSetNode){referenceSetIsNull_ = false;}
   else{referenceSetIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- referenceSetNode , address : " << referenceSetNode << std::endl;
   #endif
   if(referenceSetNode)
   {
       referenceSet_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(referenceSetNode));
   }

   //nthNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* nthNode = xmlNode->FirstChildElement("nth");

   if(nthNode){nthIsNull_ = false;}
   else{nthIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- nthNode , address : " << nthNode << std::endl;
   #endif
   if(nthNode)
   {
       nth_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(nthNode));
   }

   //averageDaysNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* averageDaysNode = xmlNode->FirstChildElement("averageDays");

   if(averageDaysNode){averageDaysIsNull_ = false;}
   else{averageDaysIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- averageDaysNode , address : " << averageDaysNode << std::endl;
   #endif
   if(averageDaysNode)
   {
       averageDays_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(averageDaysNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_referSimpleCalculation::getCalculationID()
{
   if(!this->calculationIDIsNull_){
        return this->calculationID_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_referSimpleCalculation::getReferenceType()
{
   if(!this->referenceTypeIsNull_){
        return this->referenceType_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_referSimpleCalculation::getReferenceSet()
{
   if(!this->referenceSetIsNull_){
        return this->referenceSet_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_referSimpleCalculation::getNth()
{
   if(!this->nthIsNull_){
        return this->nth_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_referSimpleCalculation::getAverageDays()
{
   if(!this->averageDaysIsNull_){
        return this->averageDays_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

