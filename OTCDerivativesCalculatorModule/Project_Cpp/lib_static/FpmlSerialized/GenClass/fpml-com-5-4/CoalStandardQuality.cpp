// CoalStandardQuality.cpp 
#include "CoalStandardQuality.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CoalStandardQuality::CoalStandardQuality(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //moistureNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* moistureNode = xmlNode->FirstChildElement("moisture");

   if(moistureNode){moistureIsNull_ = false;}
   else{moistureIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- moistureNode , address : " << moistureNode << std::endl;
   #endif
   if(moistureNode)
   {
      if(moistureNode->Attribute("href") || moistureNode->Attribute("id"))
      {
          if(moistureNode->Attribute("id"))
          {
             moistureIDRef_ = moistureNode->Attribute("id");
             moisture_ = boost::shared_ptr<CoalAttributePercentage>(new CoalAttributePercentage(moistureNode));
             moisture_->setID(moistureIDRef_);
             IDManager::instance().setID(moistureIDRef_,moisture_);
          }
          else if(moistureNode->Attribute("href")) { moistureIDRef_ = moistureNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { moisture_ = boost::shared_ptr<CoalAttributePercentage>(new CoalAttributePercentage(moistureNode));}
   }

   //ashNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* ashNode = xmlNode->FirstChildElement("ash");

   if(ashNode){ashIsNull_ = false;}
   else{ashIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- ashNode , address : " << ashNode << std::endl;
   #endif
   if(ashNode)
   {
      if(ashNode->Attribute("href") || ashNode->Attribute("id"))
      {
          if(ashNode->Attribute("id"))
          {
             ashIDRef_ = ashNode->Attribute("id");
             ash_ = boost::shared_ptr<CoalAttributePercentage>(new CoalAttributePercentage(ashNode));
             ash_->setID(ashIDRef_);
             IDManager::instance().setID(ashIDRef_,ash_);
          }
          else if(ashNode->Attribute("href")) { ashIDRef_ = ashNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { ash_ = boost::shared_ptr<CoalAttributePercentage>(new CoalAttributePercentage(ashNode));}
   }

   //sulfurNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* sulfurNode = xmlNode->FirstChildElement("sulfur");

   if(sulfurNode){sulfurIsNull_ = false;}
   else{sulfurIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- sulfurNode , address : " << sulfurNode << std::endl;
   #endif
   if(sulfurNode)
   {
      if(sulfurNode->Attribute("href") || sulfurNode->Attribute("id"))
      {
          if(sulfurNode->Attribute("id"))
          {
             sulfurIDRef_ = sulfurNode->Attribute("id");
             sulfur_ = boost::shared_ptr<CoalAttributePercentage>(new CoalAttributePercentage(sulfurNode));
             sulfur_->setID(sulfurIDRef_);
             IDManager::instance().setID(sulfurIDRef_,sulfur_);
          }
          else if(sulfurNode->Attribute("href")) { sulfurIDRef_ = sulfurNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { sulfur_ = boost::shared_ptr<CoalAttributePercentage>(new CoalAttributePercentage(sulfurNode));}
   }

   //SO2Node ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* SO2Node = xmlNode->FirstChildElement("SO2");

   if(SO2Node){SO2IsNull_ = false;}
   else{SO2IsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- SO2Node , address : " << SO2Node << std::endl;
   #endif
   if(SO2Node)
   {
      if(SO2Node->Attribute("href") || SO2Node->Attribute("id"))
      {
          if(SO2Node->Attribute("id"))
          {
             SO2IDRef_ = SO2Node->Attribute("id");
             SO2_ = boost::shared_ptr<CoalAttributePercentage>(new CoalAttributePercentage(SO2Node));
             SO2_->setID(SO2IDRef_);
             IDManager::instance().setID(SO2IDRef_,SO2_);
          }
          else if(SO2Node->Attribute("href")) { SO2IDRef_ = SO2Node->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { SO2_ = boost::shared_ptr<CoalAttributePercentage>(new CoalAttributePercentage(SO2Node));}
   }

   //volatileNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* volatileNode = xmlNode->FirstChildElement("volatile");

   if(volatileNode){volatileIsNull_ = false;}
   else{volatileIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- volatileNode , address : " << volatileNode << std::endl;
   #endif
   if(volatileNode)
   {
      if(volatileNode->Attribute("href") || volatileNode->Attribute("id"))
      {
          if(volatileNode->Attribute("id"))
          {
             volatileIDRef_ = volatileNode->Attribute("id");
             volatile_ = boost::shared_ptr<CoalAttributePercentage>(new CoalAttributePercentage(volatileNode));
             volatile_->setID(volatileIDRef_);
             IDManager::instance().setID(volatileIDRef_,volatile_);
          }
          else if(volatileNode->Attribute("href")) { volatileIDRef_ = volatileNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { volatile_ = boost::shared_ptr<CoalAttributePercentage>(new CoalAttributePercentage(volatileNode));}
   }

   //BTUperLBNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* BTUperLBNode = xmlNode->FirstChildElement("BTUperLB");

   if(BTUperLBNode){BTUperLBIsNull_ = false;}
   else{BTUperLBIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- BTUperLBNode , address : " << BTUperLBNode << std::endl;
   #endif
   if(BTUperLBNode)
   {
      if(BTUperLBNode->Attribute("href") || BTUperLBNode->Attribute("id"))
      {
          if(BTUperLBNode->Attribute("id"))
          {
             BTUperLBIDRef_ = BTUperLBNode->Attribute("id");
             BTUperLB_ = boost::shared_ptr<CoalAttributeDecimal>(new CoalAttributeDecimal(BTUperLBNode));
             BTUperLB_->setID(BTUperLBIDRef_);
             IDManager::instance().setID(BTUperLBIDRef_,BTUperLB_);
          }
          else if(BTUperLBNode->Attribute("href")) { BTUperLBIDRef_ = BTUperLBNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { BTUperLB_ = boost::shared_ptr<CoalAttributeDecimal>(new CoalAttributeDecimal(BTUperLBNode));}
   }

   //topSizeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* topSizeNode = xmlNode->FirstChildElement("topSize");

   if(topSizeNode){topSizeIsNull_ = false;}
   else{topSizeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- topSizeNode , address : " << topSizeNode << std::endl;
   #endif
   if(topSizeNode)
   {
      if(topSizeNode->Attribute("href") || topSizeNode->Attribute("id"))
      {
          if(topSizeNode->Attribute("id"))
          {
             topSizeIDRef_ = topSizeNode->Attribute("id");
             topSize_ = boost::shared_ptr<CoalAttributeDecimal>(new CoalAttributeDecimal(topSizeNode));
             topSize_->setID(topSizeIDRef_);
             IDManager::instance().setID(topSizeIDRef_,topSize_);
          }
          else if(topSizeNode->Attribute("href")) { topSizeIDRef_ = topSizeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { topSize_ = boost::shared_ptr<CoalAttributeDecimal>(new CoalAttributeDecimal(topSizeNode));}
   }

   //finesPassingScreenNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* finesPassingScreenNode = xmlNode->FirstChildElement("finesPassingScreen");

   if(finesPassingScreenNode){finesPassingScreenIsNull_ = false;}
   else{finesPassingScreenIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- finesPassingScreenNode , address : " << finesPassingScreenNode << std::endl;
   #endif
   if(finesPassingScreenNode)
   {
      if(finesPassingScreenNode->Attribute("href") || finesPassingScreenNode->Attribute("id"))
      {
          if(finesPassingScreenNode->Attribute("id"))
          {
             finesPassingScreenIDRef_ = finesPassingScreenNode->Attribute("id");
             finesPassingScreen_ = boost::shared_ptr<CoalAttributeDecimal>(new CoalAttributeDecimal(finesPassingScreenNode));
             finesPassingScreen_->setID(finesPassingScreenIDRef_);
             IDManager::instance().setID(finesPassingScreenIDRef_,finesPassingScreen_);
          }
          else if(finesPassingScreenNode->Attribute("href")) { finesPassingScreenIDRef_ = finesPassingScreenNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { finesPassingScreen_ = boost::shared_ptr<CoalAttributeDecimal>(new CoalAttributeDecimal(finesPassingScreenNode));}
   }

   //grindabilityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* grindabilityNode = xmlNode->FirstChildElement("grindability");

   if(grindabilityNode){grindabilityIsNull_ = false;}
   else{grindabilityIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- grindabilityNode , address : " << grindabilityNode << std::endl;
   #endif
   if(grindabilityNode)
   {
      if(grindabilityNode->Attribute("href") || grindabilityNode->Attribute("id"))
      {
          if(grindabilityNode->Attribute("id"))
          {
             grindabilityIDRef_ = grindabilityNode->Attribute("id");
             grindability_ = boost::shared_ptr<CoalAttributeDecimal>(new CoalAttributeDecimal(grindabilityNode));
             grindability_->setID(grindabilityIDRef_);
             IDManager::instance().setID(grindabilityIDRef_,grindability_);
          }
          else if(grindabilityNode->Attribute("href")) { grindabilityIDRef_ = grindabilityNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { grindability_ = boost::shared_ptr<CoalAttributeDecimal>(new CoalAttributeDecimal(grindabilityNode));}
   }

   //ashFusionTemperatureNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* ashFusionTemperatureNode = xmlNode->FirstChildElement("ashFusionTemperature");

   if(ashFusionTemperatureNode){ashFusionTemperatureIsNull_ = false;}
   else{ashFusionTemperatureIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- ashFusionTemperatureNode , address : " << ashFusionTemperatureNode << std::endl;
   #endif
   if(ashFusionTemperatureNode)
   {
      if(ashFusionTemperatureNode->Attribute("href") || ashFusionTemperatureNode->Attribute("id"))
      {
          if(ashFusionTemperatureNode->Attribute("id"))
          {
             ashFusionTemperatureIDRef_ = ashFusionTemperatureNode->Attribute("id");
             ashFusionTemperature_ = boost::shared_ptr<CoalAttributeDecimal>(new CoalAttributeDecimal(ashFusionTemperatureNode));
             ashFusionTemperature_->setID(ashFusionTemperatureIDRef_);
             IDManager::instance().setID(ashFusionTemperatureIDRef_,ashFusionTemperature_);
          }
          else if(ashFusionTemperatureNode->Attribute("href")) { ashFusionTemperatureIDRef_ = ashFusionTemperatureNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { ashFusionTemperature_ = boost::shared_ptr<CoalAttributeDecimal>(new CoalAttributeDecimal(ashFusionTemperatureNode));}
   }

   //initialDeformationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* initialDeformationNode = xmlNode->FirstChildElement("initialDeformation");

   if(initialDeformationNode){initialDeformationIsNull_ = false;}
   else{initialDeformationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- initialDeformationNode , address : " << initialDeformationNode << std::endl;
   #endif
   if(initialDeformationNode)
   {
      if(initialDeformationNode->Attribute("href") || initialDeformationNode->Attribute("id"))
      {
          if(initialDeformationNode->Attribute("id"))
          {
             initialDeformationIDRef_ = initialDeformationNode->Attribute("id");
             initialDeformation_ = boost::shared_ptr<CoalAttributeDecimal>(new CoalAttributeDecimal(initialDeformationNode));
             initialDeformation_->setID(initialDeformationIDRef_);
             IDManager::instance().setID(initialDeformationIDRef_,initialDeformation_);
          }
          else if(initialDeformationNode->Attribute("href")) { initialDeformationIDRef_ = initialDeformationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { initialDeformation_ = boost::shared_ptr<CoalAttributeDecimal>(new CoalAttributeDecimal(initialDeformationNode));}
   }

   //softeningHeightWidthNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* softeningHeightWidthNode = xmlNode->FirstChildElement("softeningHeightWidth");

   if(softeningHeightWidthNode){softeningHeightWidthIsNull_ = false;}
   else{softeningHeightWidthIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- softeningHeightWidthNode , address : " << softeningHeightWidthNode << std::endl;
   #endif
   if(softeningHeightWidthNode)
   {
      if(softeningHeightWidthNode->Attribute("href") || softeningHeightWidthNode->Attribute("id"))
      {
          if(softeningHeightWidthNode->Attribute("id"))
          {
             softeningHeightWidthIDRef_ = softeningHeightWidthNode->Attribute("id");
             softeningHeightWidth_ = boost::shared_ptr<CoalAttributeDecimal>(new CoalAttributeDecimal(softeningHeightWidthNode));
             softeningHeightWidth_->setID(softeningHeightWidthIDRef_);
             IDManager::instance().setID(softeningHeightWidthIDRef_,softeningHeightWidth_);
          }
          else if(softeningHeightWidthNode->Attribute("href")) { softeningHeightWidthIDRef_ = softeningHeightWidthNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { softeningHeightWidth_ = boost::shared_ptr<CoalAttributeDecimal>(new CoalAttributeDecimal(softeningHeightWidthNode));}
   }

   //softeningHeightHalfWidthNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* softeningHeightHalfWidthNode = xmlNode->FirstChildElement("softeningHeightHalfWidth");

   if(softeningHeightHalfWidthNode){softeningHeightHalfWidthIsNull_ = false;}
   else{softeningHeightHalfWidthIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- softeningHeightHalfWidthNode , address : " << softeningHeightHalfWidthNode << std::endl;
   #endif
   if(softeningHeightHalfWidthNode)
   {
      if(softeningHeightHalfWidthNode->Attribute("href") || softeningHeightHalfWidthNode->Attribute("id"))
      {
          if(softeningHeightHalfWidthNode->Attribute("id"))
          {
             softeningHeightHalfWidthIDRef_ = softeningHeightHalfWidthNode->Attribute("id");
             softeningHeightHalfWidth_ = boost::shared_ptr<CoalAttributeDecimal>(new CoalAttributeDecimal(softeningHeightHalfWidthNode));
             softeningHeightHalfWidth_->setID(softeningHeightHalfWidthIDRef_);
             IDManager::instance().setID(softeningHeightHalfWidthIDRef_,softeningHeightHalfWidth_);
          }
          else if(softeningHeightHalfWidthNode->Attribute("href")) { softeningHeightHalfWidthIDRef_ = softeningHeightHalfWidthNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { softeningHeightHalfWidth_ = boost::shared_ptr<CoalAttributeDecimal>(new CoalAttributeDecimal(softeningHeightHalfWidthNode));}
   }

   //fluidNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fluidNode = xmlNode->FirstChildElement("fluid");

   if(fluidNode){fluidIsNull_ = false;}
   else{fluidIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fluidNode , address : " << fluidNode << std::endl;
   #endif
   if(fluidNode)
   {
      if(fluidNode->Attribute("href") || fluidNode->Attribute("id"))
      {
          if(fluidNode->Attribute("id"))
          {
             fluidIDRef_ = fluidNode->Attribute("id");
             fluid_ = boost::shared_ptr<CoalAttributeDecimal>(new CoalAttributeDecimal(fluidNode));
             fluid_->setID(fluidIDRef_);
             IDManager::instance().setID(fluidIDRef_,fluid_);
          }
          else if(fluidNode->Attribute("href")) { fluidIDRef_ = fluidNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fluid_ = boost::shared_ptr<CoalAttributeDecimal>(new CoalAttributeDecimal(fluidNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<CoalAttributePercentage> CoalStandardQuality::getMoisture()
{
   if(!this->moistureIsNull_){
        if(moistureIDRef_ != ""){
             return boost::shared_static_cast<CoalAttributePercentage>(IDManager::instance().getID(moistureIDRef_));
        }else{
             return this->moisture_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CoalAttributePercentage>();
   }
}
boost::shared_ptr<CoalAttributePercentage> CoalStandardQuality::getAsh()
{
   if(!this->ashIsNull_){
        if(ashIDRef_ != ""){
             return boost::shared_static_cast<CoalAttributePercentage>(IDManager::instance().getID(ashIDRef_));
        }else{
             return this->ash_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CoalAttributePercentage>();
   }
}
boost::shared_ptr<CoalAttributePercentage> CoalStandardQuality::getSulfur()
{
   if(!this->sulfurIsNull_){
        if(sulfurIDRef_ != ""){
             return boost::shared_static_cast<CoalAttributePercentage>(IDManager::instance().getID(sulfurIDRef_));
        }else{
             return this->sulfur_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CoalAttributePercentage>();
   }
}
boost::shared_ptr<CoalAttributePercentage> CoalStandardQuality::getSO2()
{
   if(!this->SO2IsNull_){
        if(SO2IDRef_ != ""){
             return boost::shared_static_cast<CoalAttributePercentage>(IDManager::instance().getID(SO2IDRef_));
        }else{
             return this->SO2_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CoalAttributePercentage>();
   }
}
boost::shared_ptr<CoalAttributePercentage> CoalStandardQuality::getVolatile()
{
   if(!this->volatileIsNull_){
        if(volatileIDRef_ != ""){
             return boost::shared_static_cast<CoalAttributePercentage>(IDManager::instance().getID(volatileIDRef_));
        }else{
             return this->volatile_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CoalAttributePercentage>();
   }
}
boost::shared_ptr<CoalAttributeDecimal> CoalStandardQuality::getBTUperLB()
{
   if(!this->BTUperLBIsNull_){
        if(BTUperLBIDRef_ != ""){
             return boost::shared_static_cast<CoalAttributeDecimal>(IDManager::instance().getID(BTUperLBIDRef_));
        }else{
             return this->BTUperLB_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CoalAttributeDecimal>();
   }
}
boost::shared_ptr<CoalAttributeDecimal> CoalStandardQuality::getTopSize()
{
   if(!this->topSizeIsNull_){
        if(topSizeIDRef_ != ""){
             return boost::shared_static_cast<CoalAttributeDecimal>(IDManager::instance().getID(topSizeIDRef_));
        }else{
             return this->topSize_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CoalAttributeDecimal>();
   }
}
boost::shared_ptr<CoalAttributeDecimal> CoalStandardQuality::getFinesPassingScreen()
{
   if(!this->finesPassingScreenIsNull_){
        if(finesPassingScreenIDRef_ != ""){
             return boost::shared_static_cast<CoalAttributeDecimal>(IDManager::instance().getID(finesPassingScreenIDRef_));
        }else{
             return this->finesPassingScreen_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CoalAttributeDecimal>();
   }
}
boost::shared_ptr<CoalAttributeDecimal> CoalStandardQuality::getGrindability()
{
   if(!this->grindabilityIsNull_){
        if(grindabilityIDRef_ != ""){
             return boost::shared_static_cast<CoalAttributeDecimal>(IDManager::instance().getID(grindabilityIDRef_));
        }else{
             return this->grindability_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CoalAttributeDecimal>();
   }
}
boost::shared_ptr<CoalAttributeDecimal> CoalStandardQuality::getAshFusionTemperature()
{
   if(!this->ashFusionTemperatureIsNull_){
        if(ashFusionTemperatureIDRef_ != ""){
             return boost::shared_static_cast<CoalAttributeDecimal>(IDManager::instance().getID(ashFusionTemperatureIDRef_));
        }else{
             return this->ashFusionTemperature_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CoalAttributeDecimal>();
   }
}
boost::shared_ptr<CoalAttributeDecimal> CoalStandardQuality::getInitialDeformation()
{
   if(!this->initialDeformationIsNull_){
        if(initialDeformationIDRef_ != ""){
             return boost::shared_static_cast<CoalAttributeDecimal>(IDManager::instance().getID(initialDeformationIDRef_));
        }else{
             return this->initialDeformation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CoalAttributeDecimal>();
   }
}
boost::shared_ptr<CoalAttributeDecimal> CoalStandardQuality::getSofteningHeightWidth()
{
   if(!this->softeningHeightWidthIsNull_){
        if(softeningHeightWidthIDRef_ != ""){
             return boost::shared_static_cast<CoalAttributeDecimal>(IDManager::instance().getID(softeningHeightWidthIDRef_));
        }else{
             return this->softeningHeightWidth_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CoalAttributeDecimal>();
   }
}
boost::shared_ptr<CoalAttributeDecimal> CoalStandardQuality::getSofteningHeightHalfWidth()
{
   if(!this->softeningHeightHalfWidthIsNull_){
        if(softeningHeightHalfWidthIDRef_ != ""){
             return boost::shared_static_cast<CoalAttributeDecimal>(IDManager::instance().getID(softeningHeightHalfWidthIDRef_));
        }else{
             return this->softeningHeightHalfWidth_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CoalAttributeDecimal>();
   }
}
boost::shared_ptr<CoalAttributeDecimal> CoalStandardQuality::getFluid()
{
   if(!this->fluidIsNull_){
        if(fluidIDRef_ != ""){
             return boost::shared_static_cast<CoalAttributeDecimal>(IDManager::instance().getID(fluidIDRef_));
        }else{
             return this->fluid_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CoalAttributeDecimal>();
   }
}
}

