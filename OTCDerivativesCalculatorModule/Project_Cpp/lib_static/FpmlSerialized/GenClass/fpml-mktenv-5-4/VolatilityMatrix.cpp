// VolatilityMatrix.cpp 
#include "VolatilityMatrix.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

VolatilityMatrix::VolatilityMatrix(TiXmlNode* xmlNode)
: PricingStructureValuation(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //dataPointsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dataPointsNode = xmlNode->FirstChildElement("dataPoints");

   if(dataPointsNode){dataPointsIsNull_ = false;}
   else{dataPointsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dataPointsNode , address : " << dataPointsNode << std::endl;
   #endif
   if(dataPointsNode)
   {
      if(dataPointsNode->Attribute("href") || dataPointsNode->Attribute("id"))
      {
          if(dataPointsNode->Attribute("id"))
          {
             dataPointsIDRef_ = dataPointsNode->Attribute("id");
             dataPoints_ = boost::shared_ptr<MultiDimensionalPricingData>(new MultiDimensionalPricingData(dataPointsNode));
             dataPoints_->setID(dataPointsIDRef_);
             IDManager::instance().setID(dataPointsIDRef_,dataPoints_);
          }
          else if(dataPointsNode->Attribute("href")) { dataPointsIDRef_ = dataPointsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { dataPoints_ = boost::shared_ptr<MultiDimensionalPricingData>(new MultiDimensionalPricingData(dataPointsNode));}
   }

   //adjustmentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* adjustmentNode = xmlNode->FirstChildElement("adjustment");

   if(adjustmentNode){adjustmentIsNull_ = false;}
   else{adjustmentIsNull_ = true;}

   if(adjustmentNode)
   {
      for(adjustmentNode; adjustmentNode; adjustmentNode = adjustmentNode->NextSiblingElement("adjustment")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- adjustmentNode , address : " << adjustmentNode << std::endl;
          #endif
          if(adjustmentNode->Attribute("href") || adjustmentNode->Attribute("id"))
          {
              if(adjustmentNode->Attribute("id"))
              {
                  adjustmentIDRef_ = adjustmentNode->Attribute("id");
                  adjustment_.push_back(boost::shared_ptr<ParametricAdjustment>(new ParametricAdjustment(adjustmentNode)));
                  adjustment_.back()->setID(adjustmentIDRef_);
                  IDManager::instance().setID(adjustmentIDRef_, adjustment_.back());
              }
              else if(adjustmentNode->Attribute("href")) { adjustmentIDRef_ = adjustmentNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { adjustment_.push_back(boost::shared_ptr<ParametricAdjustment>(new ParametricAdjustment(adjustmentNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- adjustmentNode , address : " << adjustmentNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<MultiDimensionalPricingData> VolatilityMatrix::getDataPoints()
{
   if(!this->dataPointsIsNull_){
        if(dataPointsIDRef_ != ""){
             return boost::shared_static_cast<MultiDimensionalPricingData>(IDManager::instance().getID(dataPointsIDRef_));
        }else{
             return this->dataPoints_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<MultiDimensionalPricingData>();
   }
}
std::vector<boost::shared_ptr<ParametricAdjustment>> VolatilityMatrix::getAdjustment()
{
   if(!this->adjustmentIsNull_){
        if(adjustmentIDRef_ != ""){
             return this->adjustment_;
        }else{
             return this->adjustment_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<ParametricAdjustment>>();
   }
}
}

