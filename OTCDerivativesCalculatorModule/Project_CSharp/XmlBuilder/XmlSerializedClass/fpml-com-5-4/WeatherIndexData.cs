using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class WeatherIndexData : ISerialized
    {
        public WeatherIndexData(XmlNode xmlNode)
        {
            XmlNode referenceLevelNode = xmlNode.SelectSingleNode("referenceLevel");
            
            if (referenceLevelNode != null)
            {
                if (referenceLevelNode.Attributes["href"] != null || referenceLevelNode.Attributes["id"] != null) 
                {
                    if (referenceLevelNode.Attributes["id"] != null) 
                    {
                        referenceLevelIDRef_ = referenceLevelNode.Attributes["id"].Value;
                        ReferenceLevel ob = new ReferenceLevel(referenceLevelNode);
                        IDManager.SetID(referenceLevelIDRef_, ob);
                    }
                    else if (referenceLevelNode.Attributes["href"] != null)
                    {
                        referenceLevelIDRef_ = referenceLevelNode.Attributes["href"].Value;
                    }
                    else
                    {
                        referenceLevel_ = new ReferenceLevel(referenceLevelNode);
                    }
                }
                else
                {
                    referenceLevel_ = new ReferenceLevel(referenceLevelNode);
                }
            }
            
        
            XmlNode dataProviderNode = xmlNode.SelectSingleNode("dataProvider");
            
            if (dataProviderNode != null)
            {
                if (dataProviderNode.Attributes["href"] != null || dataProviderNode.Attributes["id"] != null) 
                {
                    if (dataProviderNode.Attributes["id"] != null) 
                    {
                        dataProviderIDRef_ = dataProviderNode.Attributes["id"].Value;
                        DataProvider ob = new DataProvider(dataProviderNode);
                        IDManager.SetID(dataProviderIDRef_, ob);
                    }
                    else if (dataProviderNode.Attributes["href"] != null)
                    {
                        dataProviderIDRef_ = dataProviderNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dataProvider_ = new DataProvider(dataProviderNode);
                    }
                }
                else
                {
                    dataProvider_ = new DataProvider(dataProviderNode);
                }
            }
            
        
            XmlNode finalEditedDataNode = xmlNode.SelectSingleNode("finalEditedData");
            
            if (finalEditedDataNode != null)
            {
                if (finalEditedDataNode.Attributes["href"] != null || finalEditedDataNode.Attributes["id"] != null) 
                {
                    if (finalEditedDataNode.Attributes["id"] != null) 
                    {
                        finalEditedDataIDRef_ = finalEditedDataNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(finalEditedDataNode);
                        IDManager.SetID(finalEditedDataIDRef_, ob);
                    }
                    else if (finalEditedDataNode.Attributes["href"] != null)
                    {
                        finalEditedDataIDRef_ = finalEditedDataNode.Attributes["href"].Value;
                    }
                    else
                    {
                        finalEditedData_ = new XsdTypeBoolean(finalEditedDataNode);
                    }
                }
                else
                {
                    finalEditedData_ = new XsdTypeBoolean(finalEditedDataNode);
                }
            }
            
        
            XmlNode weatherStationNode = xmlNode.SelectSingleNode("weatherStation");
            
            if (weatherStationNode != null)
            {
                if (weatherStationNode.Attributes["href"] != null || weatherStationNode.Attributes["id"] != null) 
                {
                    if (weatherStationNode.Attributes["id"] != null) 
                    {
                        weatherStationIDRef_ = weatherStationNode.Attributes["id"].Value;
                        WeatherStation ob = new WeatherStation(weatherStationNode);
                        IDManager.SetID(weatherStationIDRef_, ob);
                    }
                    else if (weatherStationNode.Attributes["href"] != null)
                    {
                        weatherStationIDRef_ = weatherStationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        weatherStation_ = new WeatherStation(weatherStationNode);
                    }
                }
                else
                {
                    weatherStation_ = new WeatherStation(weatherStationNode);
                }
            }
            
        
            XmlNode weatherStationFallbackNode = xmlNode.SelectSingleNode("weatherStationFallback");
            
            if (weatherStationFallbackNode != null)
            {
                if (weatherStationFallbackNode.Attributes["href"] != null || weatherStationFallbackNode.Attributes["id"] != null) 
                {
                    if (weatherStationFallbackNode.Attributes["id"] != null) 
                    {
                        weatherStationFallbackIDRef_ = weatherStationFallbackNode.Attributes["id"].Value;
                        WeatherStation ob = new WeatherStation(weatherStationFallbackNode);
                        IDManager.SetID(weatherStationFallbackIDRef_, ob);
                    }
                    else if (weatherStationFallbackNode.Attributes["href"] != null)
                    {
                        weatherStationFallbackIDRef_ = weatherStationFallbackNode.Attributes["href"].Value;
                    }
                    else
                    {
                        weatherStationFallback_ = new WeatherStation(weatherStationFallbackNode);
                    }
                }
                else
                {
                    weatherStationFallback_ = new WeatherStation(weatherStationFallbackNode);
                }
            }
            
        
            XmlNode weatherStationSecondFallbackNode = xmlNode.SelectSingleNode("weatherStationSecondFallback");
            
            if (weatherStationSecondFallbackNode != null)
            {
                if (weatherStationSecondFallbackNode.Attributes["href"] != null || weatherStationSecondFallbackNode.Attributes["id"] != null) 
                {
                    if (weatherStationSecondFallbackNode.Attributes["id"] != null) 
                    {
                        weatherStationSecondFallbackIDRef_ = weatherStationSecondFallbackNode.Attributes["id"].Value;
                        WeatherStation ob = new WeatherStation(weatherStationSecondFallbackNode);
                        IDManager.SetID(weatherStationSecondFallbackIDRef_, ob);
                    }
                    else if (weatherStationSecondFallbackNode.Attributes["href"] != null)
                    {
                        weatherStationSecondFallbackIDRef_ = weatherStationSecondFallbackNode.Attributes["href"].Value;
                    }
                    else
                    {
                        weatherStationSecondFallback_ = new WeatherStation(weatherStationSecondFallbackNode);
                    }
                }
                else
                {
                    weatherStationSecondFallback_ = new WeatherStation(weatherStationSecondFallbackNode);
                }
            }
            
        
            XmlNode alternativeDataProviderNode = xmlNode.SelectSingleNode("alternativeDataProvider");
            
            if (alternativeDataProviderNode != null)
            {
                if (alternativeDataProviderNode.Attributes["href"] != null || alternativeDataProviderNode.Attributes["id"] != null) 
                {
                    if (alternativeDataProviderNode.Attributes["id"] != null) 
                    {
                        alternativeDataProviderIDRef_ = alternativeDataProviderNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(alternativeDataProviderNode);
                        IDManager.SetID(alternativeDataProviderIDRef_, ob);
                    }
                    else if (alternativeDataProviderNode.Attributes["href"] != null)
                    {
                        alternativeDataProviderIDRef_ = alternativeDataProviderNode.Attributes["href"].Value;
                    }
                    else
                    {
                        alternativeDataProvider_ = new XsdTypeBoolean(alternativeDataProviderNode);
                    }
                }
                else
                {
                    alternativeDataProvider_ = new XsdTypeBoolean(alternativeDataProviderNode);
                }
            }
            
        
            XmlNode synopticDataFallbackNode = xmlNode.SelectSingleNode("synopticDataFallback");
            
            if (synopticDataFallbackNode != null)
            {
                if (synopticDataFallbackNode.Attributes["href"] != null || synopticDataFallbackNode.Attributes["id"] != null) 
                {
                    if (synopticDataFallbackNode.Attributes["id"] != null) 
                    {
                        synopticDataFallbackIDRef_ = synopticDataFallbackNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(synopticDataFallbackNode);
                        IDManager.SetID(synopticDataFallbackIDRef_, ob);
                    }
                    else if (synopticDataFallbackNode.Attributes["href"] != null)
                    {
                        synopticDataFallbackIDRef_ = synopticDataFallbackNode.Attributes["href"].Value;
                    }
                    else
                    {
                        synopticDataFallback_ = new XsdTypeBoolean(synopticDataFallbackNode);
                    }
                }
                else
                {
                    synopticDataFallback_ = new XsdTypeBoolean(synopticDataFallbackNode);
                }
            }
            
        
            XmlNode adjustmentToFallbackWeatherStationNode = xmlNode.SelectSingleNode("adjustmentToFallbackWeatherStation");
            
            if (adjustmentToFallbackWeatherStationNode != null)
            {
                if (adjustmentToFallbackWeatherStationNode.Attributes["href"] != null || adjustmentToFallbackWeatherStationNode.Attributes["id"] != null) 
                {
                    if (adjustmentToFallbackWeatherStationNode.Attributes["id"] != null) 
                    {
                        adjustmentToFallbackWeatherStationIDRef_ = adjustmentToFallbackWeatherStationNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(adjustmentToFallbackWeatherStationNode);
                        IDManager.SetID(adjustmentToFallbackWeatherStationIDRef_, ob);
                    }
                    else if (adjustmentToFallbackWeatherStationNode.Attributes["href"] != null)
                    {
                        adjustmentToFallbackWeatherStationIDRef_ = adjustmentToFallbackWeatherStationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        adjustmentToFallbackWeatherStation_ = new XsdTypeBoolean(adjustmentToFallbackWeatherStationNode);
                    }
                }
                else
                {
                    adjustmentToFallbackWeatherStation_ = new XsdTypeBoolean(adjustmentToFallbackWeatherStationNode);
                }
            }
            
        
            XmlNode primaryDisruptionFallbacksNode = xmlNode.SelectSingleNode("primaryDisruptionFallbacks");
            
            if (primaryDisruptionFallbacksNode != null)
            {
                if (primaryDisruptionFallbacksNode.Attributes["href"] != null || primaryDisruptionFallbacksNode.Attributes["id"] != null) 
                {
                    if (primaryDisruptionFallbacksNode.Attributes["id"] != null) 
                    {
                        primaryDisruptionFallbacksIDRef_ = primaryDisruptionFallbacksNode.Attributes["id"].Value;
                        DisruptionFallback ob = new DisruptionFallback(primaryDisruptionFallbacksNode);
                        IDManager.SetID(primaryDisruptionFallbacksIDRef_, ob);
                    }
                    else if (primaryDisruptionFallbacksNode.Attributes["href"] != null)
                    {
                        primaryDisruptionFallbacksIDRef_ = primaryDisruptionFallbacksNode.Attributes["href"].Value;
                    }
                    else
                    {
                        primaryDisruptionFallbacks_ = new DisruptionFallback(primaryDisruptionFallbacksNode);
                    }
                }
                else
                {
                    primaryDisruptionFallbacks_ = new DisruptionFallback(primaryDisruptionFallbacksNode);
                }
            }
            
        
            XmlNode secondaryDisruptionFallbacksNode = xmlNode.SelectSingleNode("secondaryDisruptionFallbacks");
            
            if (secondaryDisruptionFallbacksNode != null)
            {
                if (secondaryDisruptionFallbacksNode.Attributes["href"] != null || secondaryDisruptionFallbacksNode.Attributes["id"] != null) 
                {
                    if (secondaryDisruptionFallbacksNode.Attributes["id"] != null) 
                    {
                        secondaryDisruptionFallbacksIDRef_ = secondaryDisruptionFallbacksNode.Attributes["id"].Value;
                        DisruptionFallback ob = new DisruptionFallback(secondaryDisruptionFallbacksNode);
                        IDManager.SetID(secondaryDisruptionFallbacksIDRef_, ob);
                    }
                    else if (secondaryDisruptionFallbacksNode.Attributes["href"] != null)
                    {
                        secondaryDisruptionFallbacksIDRef_ = secondaryDisruptionFallbacksNode.Attributes["href"].Value;
                    }
                    else
                    {
                        secondaryDisruptionFallbacks_ = new DisruptionFallback(secondaryDisruptionFallbacksNode);
                    }
                }
                else
                {
                    secondaryDisruptionFallbacks_ = new DisruptionFallback(secondaryDisruptionFallbacksNode);
                }
            }
            
        
        }
        
    
        #region ReferenceLevel_
        private ReferenceLevel referenceLevel_;
        public ReferenceLevel ReferenceLevel_
        {
            get
            {
                if (this.referenceLevel_ != null)
                {
                    return this.referenceLevel_; 
                }
                else if (this.referenceLevelIDRef_ != null)
                {
                    referenceLevel_ = IDManager.getID(referenceLevelIDRef_) as ReferenceLevel;
                    return this.referenceLevel_; 
                }
                else
                {
                      return this.referenceLevel_; 
                }
            }
            set
            {
                if (this.referenceLevel_ != value)
                {
                    this.referenceLevel_ = value;
                }
            }
        }
        #endregion
        
        public string referenceLevelIDRef_ { get; set; }
        #region DataProvider_
        private DataProvider dataProvider_;
        public DataProvider DataProvider_
        {
            get
            {
                if (this.dataProvider_ != null)
                {
                    return this.dataProvider_; 
                }
                else if (this.dataProviderIDRef_ != null)
                {
                    dataProvider_ = IDManager.getID(dataProviderIDRef_) as DataProvider;
                    return this.dataProvider_; 
                }
                else
                {
                      return this.dataProvider_; 
                }
            }
            set
            {
                if (this.dataProvider_ != value)
                {
                    this.dataProvider_ = value;
                }
            }
        }
        #endregion
        
        public string dataProviderIDRef_ { get; set; }
        #region FinalEditedData_
        private XsdTypeBoolean finalEditedData_;
        public XsdTypeBoolean FinalEditedData_
        {
            get
            {
                if (this.finalEditedData_ != null)
                {
                    return this.finalEditedData_; 
                }
                else if (this.finalEditedDataIDRef_ != null)
                {
                    finalEditedData_ = IDManager.getID(finalEditedDataIDRef_) as XsdTypeBoolean;
                    return this.finalEditedData_; 
                }
                else
                {
                      return this.finalEditedData_; 
                }
            }
            set
            {
                if (this.finalEditedData_ != value)
                {
                    this.finalEditedData_ = value;
                }
            }
        }
        #endregion
        
        public string finalEditedDataIDRef_ { get; set; }
        #region WeatherStation_
        private WeatherStation weatherStation_;
        public WeatherStation WeatherStation_
        {
            get
            {
                if (this.weatherStation_ != null)
                {
                    return this.weatherStation_; 
                }
                else if (this.weatherStationIDRef_ != null)
                {
                    weatherStation_ = IDManager.getID(weatherStationIDRef_) as WeatherStation;
                    return this.weatherStation_; 
                }
                else
                {
                      return this.weatherStation_; 
                }
            }
            set
            {
                if (this.weatherStation_ != value)
                {
                    this.weatherStation_ = value;
                }
            }
        }
        #endregion
        
        public string weatherStationIDRef_ { get; set; }
        #region WeatherStationFallback_
        private WeatherStation weatherStationFallback_;
        public WeatherStation WeatherStationFallback_
        {
            get
            {
                if (this.weatherStationFallback_ != null)
                {
                    return this.weatherStationFallback_; 
                }
                else if (this.weatherStationFallbackIDRef_ != null)
                {
                    weatherStationFallback_ = IDManager.getID(weatherStationFallbackIDRef_) as WeatherStation;
                    return this.weatherStationFallback_; 
                }
                else
                {
                      return this.weatherStationFallback_; 
                }
            }
            set
            {
                if (this.weatherStationFallback_ != value)
                {
                    this.weatherStationFallback_ = value;
                }
            }
        }
        #endregion
        
        public string weatherStationFallbackIDRef_ { get; set; }
        #region WeatherStationSecondFallback_
        private WeatherStation weatherStationSecondFallback_;
        public WeatherStation WeatherStationSecondFallback_
        {
            get
            {
                if (this.weatherStationSecondFallback_ != null)
                {
                    return this.weatherStationSecondFallback_; 
                }
                else if (this.weatherStationSecondFallbackIDRef_ != null)
                {
                    weatherStationSecondFallback_ = IDManager.getID(weatherStationSecondFallbackIDRef_) as WeatherStation;
                    return this.weatherStationSecondFallback_; 
                }
                else
                {
                      return this.weatherStationSecondFallback_; 
                }
            }
            set
            {
                if (this.weatherStationSecondFallback_ != value)
                {
                    this.weatherStationSecondFallback_ = value;
                }
            }
        }
        #endregion
        
        public string weatherStationSecondFallbackIDRef_ { get; set; }
        #region AlternativeDataProvider_
        private XsdTypeBoolean alternativeDataProvider_;
        public XsdTypeBoolean AlternativeDataProvider_
        {
            get
            {
                if (this.alternativeDataProvider_ != null)
                {
                    return this.alternativeDataProvider_; 
                }
                else if (this.alternativeDataProviderIDRef_ != null)
                {
                    alternativeDataProvider_ = IDManager.getID(alternativeDataProviderIDRef_) as XsdTypeBoolean;
                    return this.alternativeDataProvider_; 
                }
                else
                {
                      return this.alternativeDataProvider_; 
                }
            }
            set
            {
                if (this.alternativeDataProvider_ != value)
                {
                    this.alternativeDataProvider_ = value;
                }
            }
        }
        #endregion
        
        public string alternativeDataProviderIDRef_ { get; set; }
        #region SynopticDataFallback_
        private XsdTypeBoolean synopticDataFallback_;
        public XsdTypeBoolean SynopticDataFallback_
        {
            get
            {
                if (this.synopticDataFallback_ != null)
                {
                    return this.synopticDataFallback_; 
                }
                else if (this.synopticDataFallbackIDRef_ != null)
                {
                    synopticDataFallback_ = IDManager.getID(synopticDataFallbackIDRef_) as XsdTypeBoolean;
                    return this.synopticDataFallback_; 
                }
                else
                {
                      return this.synopticDataFallback_; 
                }
            }
            set
            {
                if (this.synopticDataFallback_ != value)
                {
                    this.synopticDataFallback_ = value;
                }
            }
        }
        #endregion
        
        public string synopticDataFallbackIDRef_ { get; set; }
        #region AdjustmentToFallbackWeatherStation_
        private XsdTypeBoolean adjustmentToFallbackWeatherStation_;
        public XsdTypeBoolean AdjustmentToFallbackWeatherStation_
        {
            get
            {
                if (this.adjustmentToFallbackWeatherStation_ != null)
                {
                    return this.adjustmentToFallbackWeatherStation_; 
                }
                else if (this.adjustmentToFallbackWeatherStationIDRef_ != null)
                {
                    adjustmentToFallbackWeatherStation_ = IDManager.getID(adjustmentToFallbackWeatherStationIDRef_) as XsdTypeBoolean;
                    return this.adjustmentToFallbackWeatherStation_; 
                }
                else
                {
                      return this.adjustmentToFallbackWeatherStation_; 
                }
            }
            set
            {
                if (this.adjustmentToFallbackWeatherStation_ != value)
                {
                    this.adjustmentToFallbackWeatherStation_ = value;
                }
            }
        }
        #endregion
        
        public string adjustmentToFallbackWeatherStationIDRef_ { get; set; }
        #region PrimaryDisruptionFallbacks_
        private DisruptionFallback primaryDisruptionFallbacks_;
        public DisruptionFallback PrimaryDisruptionFallbacks_
        {
            get
            {
                if (this.primaryDisruptionFallbacks_ != null)
                {
                    return this.primaryDisruptionFallbacks_; 
                }
                else if (this.primaryDisruptionFallbacksIDRef_ != null)
                {
                    primaryDisruptionFallbacks_ = IDManager.getID(primaryDisruptionFallbacksIDRef_) as DisruptionFallback;
                    return this.primaryDisruptionFallbacks_; 
                }
                else
                {
                      return this.primaryDisruptionFallbacks_; 
                }
            }
            set
            {
                if (this.primaryDisruptionFallbacks_ != value)
                {
                    this.primaryDisruptionFallbacks_ = value;
                }
            }
        }
        #endregion
        
        public string primaryDisruptionFallbacksIDRef_ { get; set; }
        #region SecondaryDisruptionFallbacks_
        private DisruptionFallback secondaryDisruptionFallbacks_;
        public DisruptionFallback SecondaryDisruptionFallbacks_
        {
            get
            {
                if (this.secondaryDisruptionFallbacks_ != null)
                {
                    return this.secondaryDisruptionFallbacks_; 
                }
                else if (this.secondaryDisruptionFallbacksIDRef_ != null)
                {
                    secondaryDisruptionFallbacks_ = IDManager.getID(secondaryDisruptionFallbacksIDRef_) as DisruptionFallback;
                    return this.secondaryDisruptionFallbacks_; 
                }
                else
                {
                      return this.secondaryDisruptionFallbacks_; 
                }
            }
            set
            {
                if (this.secondaryDisruptionFallbacks_ != value)
                {
                    this.secondaryDisruptionFallbacks_ = value;
                }
            }
        }
        #endregion
        
        public string secondaryDisruptionFallbacksIDRef_ { get; set; }
        
    
        
    
    }
    
}

