// InflationRateCalculation.cpp 
#include "InflationRateCalculation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

InflationRateCalculation::InflationRateCalculation(TiXmlNode* xmlNode)
: FloatingRateCalculation(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //inflationLagNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* inflationLagNode = xmlNode->FirstChildElement("inflationLag");

   if(inflationLagNode){inflationLagIsNull_ = false;}
   else{inflationLagIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- inflationLagNode , address : " << inflationLagNode << std::endl;
   #endif
   if(inflationLagNode)
   {
      if(inflationLagNode->Attribute("href") || inflationLagNode->Attribute("id"))
      {
          if(inflationLagNode->Attribute("id"))
          {
             inflationLagIDRef_ = inflationLagNode->Attribute("id");
             inflationLag_ = boost::shared_ptr<Offset>(new Offset(inflationLagNode));
             inflationLag_->setID(inflationLagIDRef_);
             IDManager::instance().setID(inflationLagIDRef_,inflationLag_);
          }
          else if(inflationLagNode->Attribute("href")) { inflationLagIDRef_ = inflationLagNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { inflationLag_ = boost::shared_ptr<Offset>(new Offset(inflationLagNode));}
   }

   //indexSourceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* indexSourceNode = xmlNode->FirstChildElement("indexSource");

   if(indexSourceNode){indexSourceIsNull_ = false;}
   else{indexSourceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- indexSourceNode , address : " << indexSourceNode << std::endl;
   #endif
   if(indexSourceNode)
   {
      if(indexSourceNode->Attribute("href") || indexSourceNode->Attribute("id"))
      {
          if(indexSourceNode->Attribute("id"))
          {
             indexSourceIDRef_ = indexSourceNode->Attribute("id");
             indexSource_ = boost::shared_ptr<RateSourcePage>(new RateSourcePage(indexSourceNode));
             indexSource_->setID(indexSourceIDRef_);
             IDManager::instance().setID(indexSourceIDRef_,indexSource_);
          }
          else if(indexSourceNode->Attribute("href")) { indexSourceIDRef_ = indexSourceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { indexSource_ = boost::shared_ptr<RateSourcePage>(new RateSourcePage(indexSourceNode));}
   }

   //mainPublicationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* mainPublicationNode = xmlNode->FirstChildElement("mainPublication");

   if(mainPublicationNode){mainPublicationIsNull_ = false;}
   else{mainPublicationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- mainPublicationNode , address : " << mainPublicationNode << std::endl;
   #endif
   if(mainPublicationNode)
   {
      if(mainPublicationNode->Attribute("href") || mainPublicationNode->Attribute("id"))
      {
          if(mainPublicationNode->Attribute("id"))
          {
             mainPublicationIDRef_ = mainPublicationNode->Attribute("id");
             mainPublication_ = boost::shared_ptr<MainPublication>(new MainPublication(mainPublicationNode));
             mainPublication_->setID(mainPublicationIDRef_);
             IDManager::instance().setID(mainPublicationIDRef_,mainPublication_);
          }
          else if(mainPublicationNode->Attribute("href")) { mainPublicationIDRef_ = mainPublicationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { mainPublication_ = boost::shared_ptr<MainPublication>(new MainPublication(mainPublicationNode));}
   }

   //interpolationMethodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* interpolationMethodNode = xmlNode->FirstChildElement("interpolationMethod");

   if(interpolationMethodNode){interpolationMethodIsNull_ = false;}
   else{interpolationMethodIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- interpolationMethodNode , address : " << interpolationMethodNode << std::endl;
   #endif
   if(interpolationMethodNode)
   {
      if(interpolationMethodNode->Attribute("href") || interpolationMethodNode->Attribute("id"))
      {
          if(interpolationMethodNode->Attribute("id"))
          {
             interpolationMethodIDRef_ = interpolationMethodNode->Attribute("id");
             interpolationMethod_ = boost::shared_ptr<InterpolationMethod>(new InterpolationMethod(interpolationMethodNode));
             interpolationMethod_->setID(interpolationMethodIDRef_);
             IDManager::instance().setID(interpolationMethodIDRef_,interpolationMethod_);
          }
          else if(interpolationMethodNode->Attribute("href")) { interpolationMethodIDRef_ = interpolationMethodNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { interpolationMethod_ = boost::shared_ptr<InterpolationMethod>(new InterpolationMethod(interpolationMethodNode));}
   }

   //initialIndexLevelNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* initialIndexLevelNode = xmlNode->FirstChildElement("initialIndexLevel");

   if(initialIndexLevelNode){initialIndexLevelIsNull_ = false;}
   else{initialIndexLevelIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- initialIndexLevelNode , address : " << initialIndexLevelNode << std::endl;
   #endif
   if(initialIndexLevelNode)
   {
      if(initialIndexLevelNode->Attribute("href") || initialIndexLevelNode->Attribute("id"))
      {
          if(initialIndexLevelNode->Attribute("id"))
          {
             initialIndexLevelIDRef_ = initialIndexLevelNode->Attribute("id");
             initialIndexLevel_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(initialIndexLevelNode));
             initialIndexLevel_->setID(initialIndexLevelIDRef_);
             IDManager::instance().setID(initialIndexLevelIDRef_,initialIndexLevel_);
          }
          else if(initialIndexLevelNode->Attribute("href")) { initialIndexLevelIDRef_ = initialIndexLevelNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { initialIndexLevel_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(initialIndexLevelNode));}
   }

   //fallbackBondApplicableNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fallbackBondApplicableNode = xmlNode->FirstChildElement("fallbackBondApplicable");

   if(fallbackBondApplicableNode){fallbackBondApplicableIsNull_ = false;}
   else{fallbackBondApplicableIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fallbackBondApplicableNode , address : " << fallbackBondApplicableNode << std::endl;
   #endif
   if(fallbackBondApplicableNode)
   {
      if(fallbackBondApplicableNode->Attribute("href") || fallbackBondApplicableNode->Attribute("id"))
      {
          if(fallbackBondApplicableNode->Attribute("id"))
          {
             fallbackBondApplicableIDRef_ = fallbackBondApplicableNode->Attribute("id");
             fallbackBondApplicable_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(fallbackBondApplicableNode));
             fallbackBondApplicable_->setID(fallbackBondApplicableIDRef_);
             IDManager::instance().setID(fallbackBondApplicableIDRef_,fallbackBondApplicable_);
          }
          else if(fallbackBondApplicableNode->Attribute("href")) { fallbackBondApplicableIDRef_ = fallbackBondApplicableNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fallbackBondApplicable_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(fallbackBondApplicableNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Offset> InflationRateCalculation::getInflationLag()
{
   if(!this->inflationLagIsNull_){
        if(inflationLagIDRef_ != ""){
             return boost::shared_static_cast<Offset>(IDManager::instance().getID(inflationLagIDRef_));
        }else{
             return this->inflationLag_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Offset>();
   }
}
boost::shared_ptr<RateSourcePage> InflationRateCalculation::getIndexSource()
{
   if(!this->indexSourceIsNull_){
        if(indexSourceIDRef_ != ""){
             return boost::shared_static_cast<RateSourcePage>(IDManager::instance().getID(indexSourceIDRef_));
        }else{
             return this->indexSource_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<RateSourcePage>();
   }
}
boost::shared_ptr<MainPublication> InflationRateCalculation::getMainPublication()
{
   if(!this->mainPublicationIsNull_){
        if(mainPublicationIDRef_ != ""){
             return boost::shared_static_cast<MainPublication>(IDManager::instance().getID(mainPublicationIDRef_));
        }else{
             return this->mainPublication_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<MainPublication>();
   }
}
boost::shared_ptr<InterpolationMethod> InflationRateCalculation::getInterpolationMethod()
{
   if(!this->interpolationMethodIsNull_){
        if(interpolationMethodIDRef_ != ""){
             return boost::shared_static_cast<InterpolationMethod>(IDManager::instance().getID(interpolationMethodIDRef_));
        }else{
             return this->interpolationMethod_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<InterpolationMethod>();
   }
}
boost::shared_ptr<XsdTypeDecimal> InflationRateCalculation::getInitialIndexLevel()
{
   if(!this->initialIndexLevelIsNull_){
        if(initialIndexLevelIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(initialIndexLevelIDRef_));
        }else{
             return this->initialIndexLevel_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<XsdTypeBoolean> InflationRateCalculation::getFallbackBondApplicable()
{
   if(!this->fallbackBondApplicableIsNull_){
        if(fallbackBondApplicableIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(fallbackBondApplicableIDRef_));
        }else{
             return this->fallbackBondApplicable_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
}

