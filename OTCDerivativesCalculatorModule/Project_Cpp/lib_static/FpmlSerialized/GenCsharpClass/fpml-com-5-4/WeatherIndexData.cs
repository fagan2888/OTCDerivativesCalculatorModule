using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class WeatherIndexData
    {
        public WeatherIndexData(XmlNode xmlNode)
        {
            XmlNodeList referenceLevelNodeList = xmlNode.SelectNodes("referenceLevel");
            if (referenceLevelNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in referenceLevelNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        referenceLevelIDRef = item.Attributes["id"].Name;
                        ReferenceLevel ob = ReferenceLevel();
                        IDManager.SetID(referenceLevelIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        referenceLevelIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        referenceLevel = new ReferenceLevel(item);
                    }
                }
            }
            
        
            XmlNodeList dataProviderNodeList = xmlNode.SelectNodes("dataProvider");
            if (dataProviderNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dataProviderNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dataProviderIDRef = item.Attributes["id"].Name;
                        DataProvider ob = DataProvider();
                        IDManager.SetID(dataProviderIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dataProviderIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        dataProvider = new DataProvider(item);
                    }
                }
            }
            
        
            XmlNodeList finalEditedDataNodeList = xmlNode.SelectNodes("finalEditedData");
            if (finalEditedDataNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in finalEditedDataNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        finalEditedDataIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(finalEditedDataIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        finalEditedDataIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        finalEditedData = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList weatherStationNodeList = xmlNode.SelectNodes("weatherStation");
            if (weatherStationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in weatherStationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        weatherStationIDRef = item.Attributes["id"].Name;
                        WeatherStation ob = WeatherStation();
                        IDManager.SetID(weatherStationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        weatherStationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        weatherStation = new WeatherStation(item);
                    }
                }
            }
            
        
            XmlNodeList weatherStationFallbackNodeList = xmlNode.SelectNodes("weatherStationFallback");
            if (weatherStationFallbackNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in weatherStationFallbackNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        weatherStationFallbackIDRef = item.Attributes["id"].Name;
                        WeatherStation ob = WeatherStation();
                        IDManager.SetID(weatherStationFallbackIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        weatherStationFallbackIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        weatherStationFallback = new WeatherStation(item);
                    }
                }
            }
            
        
            XmlNodeList weatherStationSecondFallbackNodeList = xmlNode.SelectNodes("weatherStationSecondFallback");
            if (weatherStationSecondFallbackNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in weatherStationSecondFallbackNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        weatherStationSecondFallbackIDRef = item.Attributes["id"].Name;
                        WeatherStation ob = WeatherStation();
                        IDManager.SetID(weatherStationSecondFallbackIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        weatherStationSecondFallbackIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        weatherStationSecondFallback = new WeatherStation(item);
                    }
                }
            }
            
        
            XmlNodeList alternativeDataProviderNodeList = xmlNode.SelectNodes("alternativeDataProvider");
            if (alternativeDataProviderNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in alternativeDataProviderNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        alternativeDataProviderIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(alternativeDataProviderIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        alternativeDataProviderIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        alternativeDataProvider = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList synopticDataFallbackNodeList = xmlNode.SelectNodes("synopticDataFallback");
            if (synopticDataFallbackNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in synopticDataFallbackNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        synopticDataFallbackIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(synopticDataFallbackIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        synopticDataFallbackIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        synopticDataFallback = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList adjustmentToFallbackWeatherStationNodeList = xmlNode.SelectNodes("adjustmentToFallbackWeatherStation");
            if (adjustmentToFallbackWeatherStationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in adjustmentToFallbackWeatherStationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        adjustmentToFallbackWeatherStationIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(adjustmentToFallbackWeatherStationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        adjustmentToFallbackWeatherStationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        adjustmentToFallbackWeatherStation = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList primaryDisruptionFallbacksNodeList = xmlNode.SelectNodes("primaryDisruptionFallbacks");
            if (primaryDisruptionFallbacksNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in primaryDisruptionFallbacksNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        primaryDisruptionFallbacksIDRef = item.Attributes["id"].Name;
                        DisruptionFallback ob = DisruptionFallback();
                        IDManager.SetID(primaryDisruptionFallbacksIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        primaryDisruptionFallbacksIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        primaryDisruptionFallbacks = new DisruptionFallback(item);
                    }
                }
            }
            
        
            XmlNodeList secondaryDisruptionFallbacksNodeList = xmlNode.SelectNodes("secondaryDisruptionFallbacks");
            if (secondaryDisruptionFallbacksNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in secondaryDisruptionFallbacksNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        secondaryDisruptionFallbacksIDRef = item.Attributes["id"].Name;
                        DisruptionFallback ob = DisruptionFallback();
                        IDManager.SetID(secondaryDisruptionFallbacksIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        secondaryDisruptionFallbacksIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        secondaryDisruptionFallbacks = new DisruptionFallback(item);
                    }
                }
            }
            
        
        }
        
    
        #region ReferenceLevel
        private ReferenceLevel referenceLevel;
        public ReferenceLevel ReferenceLevel
        {
            get
            {
                if (this.referenceLevel != null)
                {
                    return this.referenceLevel; 
                }
                else if (this.referenceLevelIDRef != null)
                {
                    referenceLevel = IDManager.getID(referenceLevelIDRef) as ReferenceLevel;
                    return this.referenceLevel; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.referenceLevel != value)
                {
                    this.referenceLevel = value;
                }
            }
        }
        #endregion
        
        public string ReferenceLevelIDRef { get; set; }
        #region DataProvider
        private DataProvider dataProvider;
        public DataProvider DataProvider
        {
            get
            {
                if (this.dataProvider != null)
                {
                    return this.dataProvider; 
                }
                else if (this.dataProviderIDRef != null)
                {
                    dataProvider = IDManager.getID(dataProviderIDRef) as DataProvider;
                    return this.dataProvider; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dataProvider != value)
                {
                    this.dataProvider = value;
                }
            }
        }
        #endregion
        
        public string DataProviderIDRef { get; set; }
        #region FinalEditedData
        private XsdTypeBoolean finalEditedData;
        public XsdTypeBoolean FinalEditedData
        {
            get
            {
                if (this.finalEditedData != null)
                {
                    return this.finalEditedData; 
                }
                else if (this.finalEditedDataIDRef != null)
                {
                    finalEditedData = IDManager.getID(finalEditedDataIDRef) as XsdTypeBoolean;
                    return this.finalEditedData; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.finalEditedData != value)
                {
                    this.finalEditedData = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region WeatherStation
        private WeatherStation weatherStation;
        public WeatherStation WeatherStation
        {
            get
            {
                if (this.weatherStation != null)
                {
                    return this.weatherStation; 
                }
                else if (this.weatherStationIDRef != null)
                {
                    weatherStation = IDManager.getID(weatherStationIDRef) as WeatherStation;
                    return this.weatherStation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.weatherStation != value)
                {
                    this.weatherStation = value;
                }
            }
        }
        #endregion
        
        public string WeatherStationIDRef { get; set; }
        #region WeatherStationFallback
        private WeatherStation weatherStationFallback;
        public WeatherStation WeatherStationFallback
        {
            get
            {
                if (this.weatherStationFallback != null)
                {
                    return this.weatherStationFallback; 
                }
                else if (this.weatherStationFallbackIDRef != null)
                {
                    weatherStationFallback = IDManager.getID(weatherStationFallbackIDRef) as WeatherStation;
                    return this.weatherStationFallback; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.weatherStationFallback != value)
                {
                    this.weatherStationFallback = value;
                }
            }
        }
        #endregion
        
        public string WeatherStationIDRef { get; set; }
        #region WeatherStationSecondFallback
        private WeatherStation weatherStationSecondFallback;
        public WeatherStation WeatherStationSecondFallback
        {
            get
            {
                if (this.weatherStationSecondFallback != null)
                {
                    return this.weatherStationSecondFallback; 
                }
                else if (this.weatherStationSecondFallbackIDRef != null)
                {
                    weatherStationSecondFallback = IDManager.getID(weatherStationSecondFallbackIDRef) as WeatherStation;
                    return this.weatherStationSecondFallback; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.weatherStationSecondFallback != value)
                {
                    this.weatherStationSecondFallback = value;
                }
            }
        }
        #endregion
        
        public string WeatherStationIDRef { get; set; }
        #region AlternativeDataProvider
        private XsdTypeBoolean alternativeDataProvider;
        public XsdTypeBoolean AlternativeDataProvider
        {
            get
            {
                if (this.alternativeDataProvider != null)
                {
                    return this.alternativeDataProvider; 
                }
                else if (this.alternativeDataProviderIDRef != null)
                {
                    alternativeDataProvider = IDManager.getID(alternativeDataProviderIDRef) as XsdTypeBoolean;
                    return this.alternativeDataProvider; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.alternativeDataProvider != value)
                {
                    this.alternativeDataProvider = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region SynopticDataFallback
        private XsdTypeBoolean synopticDataFallback;
        public XsdTypeBoolean SynopticDataFallback
        {
            get
            {
                if (this.synopticDataFallback != null)
                {
                    return this.synopticDataFallback; 
                }
                else if (this.synopticDataFallbackIDRef != null)
                {
                    synopticDataFallback = IDManager.getID(synopticDataFallbackIDRef) as XsdTypeBoolean;
                    return this.synopticDataFallback; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.synopticDataFallback != value)
                {
                    this.synopticDataFallback = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region AdjustmentToFallbackWeatherStation
        private XsdTypeBoolean adjustmentToFallbackWeatherStation;
        public XsdTypeBoolean AdjustmentToFallbackWeatherStation
        {
            get
            {
                if (this.adjustmentToFallbackWeatherStation != null)
                {
                    return this.adjustmentToFallbackWeatherStation; 
                }
                else if (this.adjustmentToFallbackWeatherStationIDRef != null)
                {
                    adjustmentToFallbackWeatherStation = IDManager.getID(adjustmentToFallbackWeatherStationIDRef) as XsdTypeBoolean;
                    return this.adjustmentToFallbackWeatherStation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.adjustmentToFallbackWeatherStation != value)
                {
                    this.adjustmentToFallbackWeatherStation = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region PrimaryDisruptionFallbacks
        private DisruptionFallback primaryDisruptionFallbacks;
        public DisruptionFallback PrimaryDisruptionFallbacks
        {
            get
            {
                if (this.primaryDisruptionFallbacks != null)
                {
                    return this.primaryDisruptionFallbacks; 
                }
                else if (this.primaryDisruptionFallbacksIDRef != null)
                {
                    primaryDisruptionFallbacks = IDManager.getID(primaryDisruptionFallbacksIDRef) as DisruptionFallback;
                    return this.primaryDisruptionFallbacks; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.primaryDisruptionFallbacks != value)
                {
                    this.primaryDisruptionFallbacks = value;
                }
            }
        }
        #endregion
        
        public string DisruptionFallbackIDRef { get; set; }
        #region SecondaryDisruptionFallbacks
        private DisruptionFallback secondaryDisruptionFallbacks;
        public DisruptionFallback SecondaryDisruptionFallbacks
        {
            get
            {
                if (this.secondaryDisruptionFallbacks != null)
                {
                    return this.secondaryDisruptionFallbacks; 
                }
                else if (this.secondaryDisruptionFallbacksIDRef != null)
                {
                    secondaryDisruptionFallbacks = IDManager.getID(secondaryDisruptionFallbacksIDRef) as DisruptionFallback;
                    return this.secondaryDisruptionFallbacks; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.secondaryDisruptionFallbacks != value)
                {
                    this.secondaryDisruptionFallbacks = value;
                }
            }
        }
        #endregion
        
        public string DisruptionFallbackIDRef { get; set; }
        
    
        
    
    }
    
}

