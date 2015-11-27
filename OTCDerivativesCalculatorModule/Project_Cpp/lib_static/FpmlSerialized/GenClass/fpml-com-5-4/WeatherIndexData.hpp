// WeatherIndexData.hpp 
#ifndef FpmlSerialized_WeatherIndexData_hpp
#define FpmlSerialized_WeatherIndexData_hpp

#include <ISerialized.hpp>
#include <fpml-com-5-4/ReferenceLevel.hpp>
#include <fpml-com-5-4/DataProvider.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-com-5-4/WeatherStation.hpp>
#include <fpml-com-5-4/DisruptionFallback.hpp>

namespace FpmlSerialized {

class WeatherIndexData : public ISerialized { 
   public: 
       WeatherIndexData(TiXmlNode* xmlNode);

       bool isReferenceLevel(){return this->referenceLevelIsNull_;}
       boost::shared_ptr<ReferenceLevel> getReferenceLevel();
      std::string getReferenceLevelIDRef(){return referenceLevelIDRef_;}

       bool isDataProvider(){return this->dataProviderIsNull_;}
       boost::shared_ptr<DataProvider> getDataProvider();
      std::string getDataProviderIDRef(){return dataProviderIDRef_;}

       bool isFinalEditedData(){return this->finalEditedDataIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getFinalEditedData();
      std::string getFinalEditedDataIDRef(){return finalEditedDataIDRef_;}

       bool isWeatherStation(){return this->weatherStationIsNull_;}
       boost::shared_ptr<WeatherStation> getWeatherStation();
      std::string getWeatherStationIDRef(){return weatherStationIDRef_;}

       bool isWeatherStationFallback(){return this->weatherStationFallbackIsNull_;}
       boost::shared_ptr<WeatherStation> getWeatherStationFallback();
      std::string getWeatherStationFallbackIDRef(){return weatherStationFallbackIDRef_;}

       bool isWeatherStationSecondFallback(){return this->weatherStationSecondFallbackIsNull_;}
       boost::shared_ptr<WeatherStation> getWeatherStationSecondFallback();
      std::string getWeatherStationSecondFallbackIDRef(){return weatherStationSecondFallbackIDRef_;}

       bool isAlternativeDataProvider(){return this->alternativeDataProviderIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getAlternativeDataProvider();
      std::string getAlternativeDataProviderIDRef(){return alternativeDataProviderIDRef_;}

       bool isSynopticDataFallback(){return this->synopticDataFallbackIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getSynopticDataFallback();
      std::string getSynopticDataFallbackIDRef(){return synopticDataFallbackIDRef_;}

       bool isAdjustmentToFallbackWeatherStation(){return this->adjustmentToFallbackWeatherStationIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getAdjustmentToFallbackWeatherStation();
      std::string getAdjustmentToFallbackWeatherStationIDRef(){return adjustmentToFallbackWeatherStationIDRef_;}

       bool isPrimaryDisruptionFallbacks(){return this->primaryDisruptionFallbacksIsNull_;}
       boost::shared_ptr<DisruptionFallback> getPrimaryDisruptionFallbacks();
      std::string getPrimaryDisruptionFallbacksIDRef(){return primaryDisruptionFallbacksIDRef_;}

       bool isSecondaryDisruptionFallbacks(){return this->secondaryDisruptionFallbacksIsNull_;}
       boost::shared_ptr<DisruptionFallback> getSecondaryDisruptionFallbacks();
      std::string getSecondaryDisruptionFallbacksIDRef(){return secondaryDisruptionFallbacksIDRef_;}

   protected: 
       boost::shared_ptr<ReferenceLevel> referenceLevel_;
       std::string referenceLevelIDRef_;
       bool referenceLevelIsNull_;
       boost::shared_ptr<DataProvider> dataProvider_;
       std::string dataProviderIDRef_;
       bool dataProviderIsNull_;
       boost::shared_ptr<XsdTypeBoolean> finalEditedData_;
       std::string finalEditedDataIDRef_;
       bool finalEditedDataIsNull_;
       boost::shared_ptr<WeatherStation> weatherStation_;
       std::string weatherStationIDRef_;
       bool weatherStationIsNull_;
       boost::shared_ptr<WeatherStation> weatherStationFallback_;
       std::string weatherStationFallbackIDRef_;
       bool weatherStationFallbackIsNull_;
       boost::shared_ptr<WeatherStation> weatherStationSecondFallback_;
       std::string weatherStationSecondFallbackIDRef_;
       bool weatherStationSecondFallbackIsNull_;
       boost::shared_ptr<XsdTypeBoolean> alternativeDataProvider_;
       std::string alternativeDataProviderIDRef_;
       bool alternativeDataProviderIsNull_;
       boost::shared_ptr<XsdTypeBoolean> synopticDataFallback_;
       std::string synopticDataFallbackIDRef_;
       bool synopticDataFallbackIsNull_;
       boost::shared_ptr<XsdTypeBoolean> adjustmentToFallbackWeatherStation_;
       std::string adjustmentToFallbackWeatherStationIDRef_;
       bool adjustmentToFallbackWeatherStationIsNull_;
       boost::shared_ptr<DisruptionFallback> primaryDisruptionFallbacks_;
       std::string primaryDisruptionFallbacksIDRef_;
       bool primaryDisruptionFallbacksIsNull_;
       boost::shared_ptr<DisruptionFallback> secondaryDisruptionFallbacks_;
       std::string secondaryDisruptionFallbacksIDRef_;
       bool secondaryDisruptionFallbacksIsNull_;

};

} //namespaceFpmlSerialized end
#endif

