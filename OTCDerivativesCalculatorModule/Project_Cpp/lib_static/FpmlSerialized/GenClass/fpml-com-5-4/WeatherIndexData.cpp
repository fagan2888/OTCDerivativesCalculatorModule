// WeatherIndexData.cpp 
#include "WeatherIndexData.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

WeatherIndexData::WeatherIndexData(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //referenceLevelNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* referenceLevelNode = xmlNode->FirstChildElement("referenceLevel");

   if(referenceLevelNode){referenceLevelIsNull_ = false;}
   else{referenceLevelIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- referenceLevelNode , address : " << referenceLevelNode << std::endl;
   #endif
   if(referenceLevelNode)
   {
      if(referenceLevelNode->Attribute("href") || referenceLevelNode->Attribute("id"))
      {
          if(referenceLevelNode->Attribute("id"))
          {
             referenceLevelIDRef_ = referenceLevelNode->Attribute("id");
             referenceLevel_ = boost::shared_ptr<ReferenceLevel>(new ReferenceLevel(referenceLevelNode));
             referenceLevel_->setID(referenceLevelIDRef_);
             IDManager::instance().setID(referenceLevelIDRef_,referenceLevel_);
          }
          else if(referenceLevelNode->Attribute("href")) { referenceLevelIDRef_ = referenceLevelNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { referenceLevel_ = boost::shared_ptr<ReferenceLevel>(new ReferenceLevel(referenceLevelNode));}
   }

   //dataProviderNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dataProviderNode = xmlNode->FirstChildElement("dataProvider");

   if(dataProviderNode){dataProviderIsNull_ = false;}
   else{dataProviderIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dataProviderNode , address : " << dataProviderNode << std::endl;
   #endif
   if(dataProviderNode)
   {
      if(dataProviderNode->Attribute("href") || dataProviderNode->Attribute("id"))
      {
          if(dataProviderNode->Attribute("id"))
          {
             dataProviderIDRef_ = dataProviderNode->Attribute("id");
             dataProvider_ = boost::shared_ptr<DataProvider>(new DataProvider(dataProviderNode));
             dataProvider_->setID(dataProviderIDRef_);
             IDManager::instance().setID(dataProviderIDRef_,dataProvider_);
          }
          else if(dataProviderNode->Attribute("href")) { dataProviderIDRef_ = dataProviderNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { dataProvider_ = boost::shared_ptr<DataProvider>(new DataProvider(dataProviderNode));}
   }

   //finalEditedDataNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* finalEditedDataNode = xmlNode->FirstChildElement("finalEditedData");

   if(finalEditedDataNode){finalEditedDataIsNull_ = false;}
   else{finalEditedDataIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- finalEditedDataNode , address : " << finalEditedDataNode << std::endl;
   #endif
   if(finalEditedDataNode)
   {
      if(finalEditedDataNode->Attribute("href") || finalEditedDataNode->Attribute("id"))
      {
          if(finalEditedDataNode->Attribute("id"))
          {
             finalEditedDataIDRef_ = finalEditedDataNode->Attribute("id");
             finalEditedData_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(finalEditedDataNode));
             finalEditedData_->setID(finalEditedDataIDRef_);
             IDManager::instance().setID(finalEditedDataIDRef_,finalEditedData_);
          }
          else if(finalEditedDataNode->Attribute("href")) { finalEditedDataIDRef_ = finalEditedDataNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { finalEditedData_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(finalEditedDataNode));}
   }

   //weatherStationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* weatherStationNode = xmlNode->FirstChildElement("weatherStation");

   if(weatherStationNode){weatherStationIsNull_ = false;}
   else{weatherStationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- weatherStationNode , address : " << weatherStationNode << std::endl;
   #endif
   if(weatherStationNode)
   {
      if(weatherStationNode->Attribute("href") || weatherStationNode->Attribute("id"))
      {
          if(weatherStationNode->Attribute("id"))
          {
             weatherStationIDRef_ = weatherStationNode->Attribute("id");
             weatherStation_ = boost::shared_ptr<WeatherStation>(new WeatherStation(weatherStationNode));
             weatherStation_->setID(weatherStationIDRef_);
             IDManager::instance().setID(weatherStationIDRef_,weatherStation_);
          }
          else if(weatherStationNode->Attribute("href")) { weatherStationIDRef_ = weatherStationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { weatherStation_ = boost::shared_ptr<WeatherStation>(new WeatherStation(weatherStationNode));}
   }

   //weatherStationFallbackNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* weatherStationFallbackNode = xmlNode->FirstChildElement("weatherStationFallback");

   if(weatherStationFallbackNode){weatherStationFallbackIsNull_ = false;}
   else{weatherStationFallbackIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- weatherStationFallbackNode , address : " << weatherStationFallbackNode << std::endl;
   #endif
   if(weatherStationFallbackNode)
   {
      if(weatherStationFallbackNode->Attribute("href") || weatherStationFallbackNode->Attribute("id"))
      {
          if(weatherStationFallbackNode->Attribute("id"))
          {
             weatherStationFallbackIDRef_ = weatherStationFallbackNode->Attribute("id");
             weatherStationFallback_ = boost::shared_ptr<WeatherStation>(new WeatherStation(weatherStationFallbackNode));
             weatherStationFallback_->setID(weatherStationFallbackIDRef_);
             IDManager::instance().setID(weatherStationFallbackIDRef_,weatherStationFallback_);
          }
          else if(weatherStationFallbackNode->Attribute("href")) { weatherStationFallbackIDRef_ = weatherStationFallbackNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { weatherStationFallback_ = boost::shared_ptr<WeatherStation>(new WeatherStation(weatherStationFallbackNode));}
   }

   //weatherStationSecondFallbackNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* weatherStationSecondFallbackNode = xmlNode->FirstChildElement("weatherStationSecondFallback");

   if(weatherStationSecondFallbackNode){weatherStationSecondFallbackIsNull_ = false;}
   else{weatherStationSecondFallbackIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- weatherStationSecondFallbackNode , address : " << weatherStationSecondFallbackNode << std::endl;
   #endif
   if(weatherStationSecondFallbackNode)
   {
      if(weatherStationSecondFallbackNode->Attribute("href") || weatherStationSecondFallbackNode->Attribute("id"))
      {
          if(weatherStationSecondFallbackNode->Attribute("id"))
          {
             weatherStationSecondFallbackIDRef_ = weatherStationSecondFallbackNode->Attribute("id");
             weatherStationSecondFallback_ = boost::shared_ptr<WeatherStation>(new WeatherStation(weatherStationSecondFallbackNode));
             weatherStationSecondFallback_->setID(weatherStationSecondFallbackIDRef_);
             IDManager::instance().setID(weatherStationSecondFallbackIDRef_,weatherStationSecondFallback_);
          }
          else if(weatherStationSecondFallbackNode->Attribute("href")) { weatherStationSecondFallbackIDRef_ = weatherStationSecondFallbackNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { weatherStationSecondFallback_ = boost::shared_ptr<WeatherStation>(new WeatherStation(weatherStationSecondFallbackNode));}
   }

   //alternativeDataProviderNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* alternativeDataProviderNode = xmlNode->FirstChildElement("alternativeDataProvider");

   if(alternativeDataProviderNode){alternativeDataProviderIsNull_ = false;}
   else{alternativeDataProviderIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- alternativeDataProviderNode , address : " << alternativeDataProviderNode << std::endl;
   #endif
   if(alternativeDataProviderNode)
   {
      if(alternativeDataProviderNode->Attribute("href") || alternativeDataProviderNode->Attribute("id"))
      {
          if(alternativeDataProviderNode->Attribute("id"))
          {
             alternativeDataProviderIDRef_ = alternativeDataProviderNode->Attribute("id");
             alternativeDataProvider_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(alternativeDataProviderNode));
             alternativeDataProvider_->setID(alternativeDataProviderIDRef_);
             IDManager::instance().setID(alternativeDataProviderIDRef_,alternativeDataProvider_);
          }
          else if(alternativeDataProviderNode->Attribute("href")) { alternativeDataProviderIDRef_ = alternativeDataProviderNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { alternativeDataProvider_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(alternativeDataProviderNode));}
   }

   //synopticDataFallbackNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* synopticDataFallbackNode = xmlNode->FirstChildElement("synopticDataFallback");

   if(synopticDataFallbackNode){synopticDataFallbackIsNull_ = false;}
   else{synopticDataFallbackIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- synopticDataFallbackNode , address : " << synopticDataFallbackNode << std::endl;
   #endif
   if(synopticDataFallbackNode)
   {
      if(synopticDataFallbackNode->Attribute("href") || synopticDataFallbackNode->Attribute("id"))
      {
          if(synopticDataFallbackNode->Attribute("id"))
          {
             synopticDataFallbackIDRef_ = synopticDataFallbackNode->Attribute("id");
             synopticDataFallback_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(synopticDataFallbackNode));
             synopticDataFallback_->setID(synopticDataFallbackIDRef_);
             IDManager::instance().setID(synopticDataFallbackIDRef_,synopticDataFallback_);
          }
          else if(synopticDataFallbackNode->Attribute("href")) { synopticDataFallbackIDRef_ = synopticDataFallbackNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { synopticDataFallback_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(synopticDataFallbackNode));}
   }

   //adjustmentToFallbackWeatherStationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* adjustmentToFallbackWeatherStationNode = xmlNode->FirstChildElement("adjustmentToFallbackWeatherStation");

   if(adjustmentToFallbackWeatherStationNode){adjustmentToFallbackWeatherStationIsNull_ = false;}
   else{adjustmentToFallbackWeatherStationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- adjustmentToFallbackWeatherStationNode , address : " << adjustmentToFallbackWeatherStationNode << std::endl;
   #endif
   if(adjustmentToFallbackWeatherStationNode)
   {
      if(adjustmentToFallbackWeatherStationNode->Attribute("href") || adjustmentToFallbackWeatherStationNode->Attribute("id"))
      {
          if(adjustmentToFallbackWeatherStationNode->Attribute("id"))
          {
             adjustmentToFallbackWeatherStationIDRef_ = adjustmentToFallbackWeatherStationNode->Attribute("id");
             adjustmentToFallbackWeatherStation_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(adjustmentToFallbackWeatherStationNode));
             adjustmentToFallbackWeatherStation_->setID(adjustmentToFallbackWeatherStationIDRef_);
             IDManager::instance().setID(adjustmentToFallbackWeatherStationIDRef_,adjustmentToFallbackWeatherStation_);
          }
          else if(adjustmentToFallbackWeatherStationNode->Attribute("href")) { adjustmentToFallbackWeatherStationIDRef_ = adjustmentToFallbackWeatherStationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { adjustmentToFallbackWeatherStation_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(adjustmentToFallbackWeatherStationNode));}
   }

   //primaryDisruptionFallbacksNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* primaryDisruptionFallbacksNode = xmlNode->FirstChildElement("primaryDisruptionFallbacks");

   if(primaryDisruptionFallbacksNode){primaryDisruptionFallbacksIsNull_ = false;}
   else{primaryDisruptionFallbacksIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- primaryDisruptionFallbacksNode , address : " << primaryDisruptionFallbacksNode << std::endl;
   #endif
   if(primaryDisruptionFallbacksNode)
   {
      if(primaryDisruptionFallbacksNode->Attribute("href") || primaryDisruptionFallbacksNode->Attribute("id"))
      {
          if(primaryDisruptionFallbacksNode->Attribute("id"))
          {
             primaryDisruptionFallbacksIDRef_ = primaryDisruptionFallbacksNode->Attribute("id");
             primaryDisruptionFallbacks_ = boost::shared_ptr<DisruptionFallback>(new DisruptionFallback(primaryDisruptionFallbacksNode));
             primaryDisruptionFallbacks_->setID(primaryDisruptionFallbacksIDRef_);
             IDManager::instance().setID(primaryDisruptionFallbacksIDRef_,primaryDisruptionFallbacks_);
          }
          else if(primaryDisruptionFallbacksNode->Attribute("href")) { primaryDisruptionFallbacksIDRef_ = primaryDisruptionFallbacksNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { primaryDisruptionFallbacks_ = boost::shared_ptr<DisruptionFallback>(new DisruptionFallback(primaryDisruptionFallbacksNode));}
   }

   //secondaryDisruptionFallbacksNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* secondaryDisruptionFallbacksNode = xmlNode->FirstChildElement("secondaryDisruptionFallbacks");

   if(secondaryDisruptionFallbacksNode){secondaryDisruptionFallbacksIsNull_ = false;}
   else{secondaryDisruptionFallbacksIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- secondaryDisruptionFallbacksNode , address : " << secondaryDisruptionFallbacksNode << std::endl;
   #endif
   if(secondaryDisruptionFallbacksNode)
   {
      if(secondaryDisruptionFallbacksNode->Attribute("href") || secondaryDisruptionFallbacksNode->Attribute("id"))
      {
          if(secondaryDisruptionFallbacksNode->Attribute("id"))
          {
             secondaryDisruptionFallbacksIDRef_ = secondaryDisruptionFallbacksNode->Attribute("id");
             secondaryDisruptionFallbacks_ = boost::shared_ptr<DisruptionFallback>(new DisruptionFallback(secondaryDisruptionFallbacksNode));
             secondaryDisruptionFallbacks_->setID(secondaryDisruptionFallbacksIDRef_);
             IDManager::instance().setID(secondaryDisruptionFallbacksIDRef_,secondaryDisruptionFallbacks_);
          }
          else if(secondaryDisruptionFallbacksNode->Attribute("href")) { secondaryDisruptionFallbacksIDRef_ = secondaryDisruptionFallbacksNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { secondaryDisruptionFallbacks_ = boost::shared_ptr<DisruptionFallback>(new DisruptionFallback(secondaryDisruptionFallbacksNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<ReferenceLevel> WeatherIndexData::getReferenceLevel()
{
   if(!this->referenceLevelIsNull_){
        if(referenceLevelIDRef_ != ""){
             return boost::shared_static_cast<ReferenceLevel>(IDManager::instance().getID(referenceLevelIDRef_));
        }else{
             return this->referenceLevel_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ReferenceLevel>();
   }
}
boost::shared_ptr<DataProvider> WeatherIndexData::getDataProvider()
{
   if(!this->dataProviderIsNull_){
        if(dataProviderIDRef_ != ""){
             return boost::shared_static_cast<DataProvider>(IDManager::instance().getID(dataProviderIDRef_));
        }else{
             return this->dataProvider_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DataProvider>();
   }
}
boost::shared_ptr<XsdTypeBoolean> WeatherIndexData::getFinalEditedData()
{
   if(!this->finalEditedDataIsNull_){
        if(finalEditedDataIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(finalEditedDataIDRef_));
        }else{
             return this->finalEditedData_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<WeatherStation> WeatherIndexData::getWeatherStation()
{
   if(!this->weatherStationIsNull_){
        if(weatherStationIDRef_ != ""){
             return boost::shared_static_cast<WeatherStation>(IDManager::instance().getID(weatherStationIDRef_));
        }else{
             return this->weatherStation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<WeatherStation>();
   }
}
boost::shared_ptr<WeatherStation> WeatherIndexData::getWeatherStationFallback()
{
   if(!this->weatherStationFallbackIsNull_){
        if(weatherStationFallbackIDRef_ != ""){
             return boost::shared_static_cast<WeatherStation>(IDManager::instance().getID(weatherStationFallbackIDRef_));
        }else{
             return this->weatherStationFallback_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<WeatherStation>();
   }
}
boost::shared_ptr<WeatherStation> WeatherIndexData::getWeatherStationSecondFallback()
{
   if(!this->weatherStationSecondFallbackIsNull_){
        if(weatherStationSecondFallbackIDRef_ != ""){
             return boost::shared_static_cast<WeatherStation>(IDManager::instance().getID(weatherStationSecondFallbackIDRef_));
        }else{
             return this->weatherStationSecondFallback_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<WeatherStation>();
   }
}
boost::shared_ptr<XsdTypeBoolean> WeatherIndexData::getAlternativeDataProvider()
{
   if(!this->alternativeDataProviderIsNull_){
        if(alternativeDataProviderIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(alternativeDataProviderIDRef_));
        }else{
             return this->alternativeDataProvider_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> WeatherIndexData::getSynopticDataFallback()
{
   if(!this->synopticDataFallbackIsNull_){
        if(synopticDataFallbackIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(synopticDataFallbackIDRef_));
        }else{
             return this->synopticDataFallback_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> WeatherIndexData::getAdjustmentToFallbackWeatherStation()
{
   if(!this->adjustmentToFallbackWeatherStationIsNull_){
        if(adjustmentToFallbackWeatherStationIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(adjustmentToFallbackWeatherStationIDRef_));
        }else{
             return this->adjustmentToFallbackWeatherStation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<DisruptionFallback> WeatherIndexData::getPrimaryDisruptionFallbacks()
{
   if(!this->primaryDisruptionFallbacksIsNull_){
        if(primaryDisruptionFallbacksIDRef_ != ""){
             return boost::shared_static_cast<DisruptionFallback>(IDManager::instance().getID(primaryDisruptionFallbacksIDRef_));
        }else{
             return this->primaryDisruptionFallbacks_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DisruptionFallback>();
   }
}
boost::shared_ptr<DisruptionFallback> WeatherIndexData::getSecondaryDisruptionFallbacks()
{
   if(!this->secondaryDisruptionFallbacksIsNull_){
        if(secondaryDisruptionFallbacksIDRef_ != ""){
             return boost::shared_static_cast<DisruptionFallback>(IDManager::instance().getID(secondaryDisruptionFallbacksIDRef_));
        }else{
             return this->secondaryDisruptionFallbacks_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DisruptionFallback>();
   }
}
}

