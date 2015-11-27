// CalculationFromObservation.cpp 
#include "CalculationFromObservation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CalculationFromObservation::CalculationFromObservation(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //initialLevelNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* initialLevelNode = xmlNode->FirstChildElement("initialLevel");

   if(initialLevelNode){initialLevelIsNull_ = false;}
   else{initialLevelIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- initialLevelNode , address : " << initialLevelNode << std::endl;
   #endif
   if(initialLevelNode)
   {
      if(initialLevelNode->Attribute("href") || initialLevelNode->Attribute("id"))
      {
          if(initialLevelNode->Attribute("id"))
          {
             initialLevelIDRef_ = initialLevelNode->Attribute("id");
             initialLevel_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(initialLevelNode));
             initialLevel_->setID(initialLevelIDRef_);
             IDManager::instance().setID(initialLevelIDRef_,initialLevel_);
          }
          else if(initialLevelNode->Attribute("href")) { initialLevelIDRef_ = initialLevelNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { initialLevel_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(initialLevelNode));}
   }

   //closingLevelNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* closingLevelNode = xmlNode->FirstChildElement("closingLevel");

   if(closingLevelNode){closingLevelIsNull_ = false;}
   else{closingLevelIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- closingLevelNode , address : " << closingLevelNode << std::endl;
   #endif
   if(closingLevelNode)
   {
      if(closingLevelNode->Attribute("href") || closingLevelNode->Attribute("id"))
      {
          if(closingLevelNode->Attribute("id"))
          {
             closingLevelIDRef_ = closingLevelNode->Attribute("id");
             closingLevel_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(closingLevelNode));
             closingLevel_->setID(closingLevelIDRef_);
             IDManager::instance().setID(closingLevelIDRef_,closingLevel_);
          }
          else if(closingLevelNode->Attribute("href")) { closingLevelIDRef_ = closingLevelNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { closingLevel_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(closingLevelNode));}
   }

   //expiringLevelNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* expiringLevelNode = xmlNode->FirstChildElement("expiringLevel");

   if(expiringLevelNode){expiringLevelIsNull_ = false;}
   else{expiringLevelIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- expiringLevelNode , address : " << expiringLevelNode << std::endl;
   #endif
   if(expiringLevelNode)
   {
      if(expiringLevelNode->Attribute("href") || expiringLevelNode->Attribute("id"))
      {
          if(expiringLevelNode->Attribute("id"))
          {
             expiringLevelIDRef_ = expiringLevelNode->Attribute("id");
             expiringLevel_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(expiringLevelNode));
             expiringLevel_->setID(expiringLevelIDRef_);
             IDManager::instance().setID(expiringLevelIDRef_,expiringLevel_);
          }
          else if(expiringLevelNode->Attribute("href")) { expiringLevelIDRef_ = expiringLevelNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { expiringLevel_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(expiringLevelNode));}
   }

   //expectedNNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* expectedNNode = xmlNode->FirstChildElement("expectedN");

   if(expectedNNode){expectedNIsNull_ = false;}
   else{expectedNIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- expectedNNode , address : " << expectedNNode << std::endl;
   #endif
   if(expectedNNode)
   {
      if(expectedNNode->Attribute("href") || expectedNNode->Attribute("id"))
      {
          if(expectedNNode->Attribute("id"))
          {
             expectedNIDRef_ = expectedNNode->Attribute("id");
             expectedN_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(expectedNNode));
             expectedN_->setID(expectedNIDRef_);
             IDManager::instance().setID(expectedNIDRef_,expectedN_);
          }
          else if(expectedNNode->Attribute("href")) { expectedNIDRef_ = expectedNNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { expectedN_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(expectedNNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDecimal> CalculationFromObservation::getInitialLevel()
{
   if(!this->initialLevelIsNull_){
        if(initialLevelIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(initialLevelIDRef_));
        }else{
             return this->initialLevel_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<XsdTypeBoolean> CalculationFromObservation::getClosingLevel()
{
   if(!this->closingLevelIsNull_){
        if(closingLevelIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(closingLevelIDRef_));
        }else{
             return this->closingLevel_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> CalculationFromObservation::getExpiringLevel()
{
   if(!this->expiringLevelIsNull_){
        if(expiringLevelIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(expiringLevelIDRef_));
        }else{
             return this->expiringLevel_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypePositiveInteger> CalculationFromObservation::getExpectedN()
{
   if(!this->expectedNIsNull_){
        if(expectedNIDRef_ != ""){
             return boost::shared_static_cast<XsdTypePositiveInteger>(IDManager::instance().getID(expectedNIDRef_));
        }else{
             return this->expectedN_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypePositiveInteger>();
   }
}
}

