using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class WeatherStation
    {
        public WeatherStation(XmlNode xmlNode)
        {
            XmlNodeList weatherStationCityNodeList = xmlNode.SelectNodes("weatherStationCity");
            if (weatherStationCityNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in weatherStationCityNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        weatherStationCityIDRef = item.Attributes["id"].Name;
                        BusinessCenter ob = BusinessCenter();
                        IDManager.SetID(weatherStationCityIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        weatherStationCityIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        weatherStationCity = new BusinessCenter(item);
                    }
                }
            }
            
        
            XmlNodeList weatherStationAirportNodeList = xmlNode.SelectNodes("weatherStationAirport");
            if (weatherStationAirportNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in weatherStationAirportNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        weatherStationAirportIDRef = item.Attributes["id"].Name;
                        WeatherStationAirport ob = WeatherStationAirport();
                        IDManager.SetID(weatherStationAirportIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        weatherStationAirportIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        weatherStationAirport = new WeatherStationAirport(item);
                    }
                }
            }
            
        
            XmlNodeList weatherStationWBANNodeList = xmlNode.SelectNodes("weatherStationWBAN");
            if (weatherStationWBANNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in weatherStationWBANNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        weatherStationWBANIDRef = item.Attributes["id"].Name;
                        WeatherStationWBAN ob = WeatherStationWBAN();
                        IDManager.SetID(weatherStationWBANIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        weatherStationWBANIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        weatherStationWBAN = new WeatherStationWBAN(item);
                    }
                }
            }
            
        
            XmlNodeList weatherStationWMONodeList = xmlNode.SelectNodes("weatherStationWMO");
            if (weatherStationWMONodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in weatherStationWMONodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        weatherStationWMOIDRef = item.Attributes["id"].Name;
                        WeatherStationWMO ob = WeatherStationWMO();
                        IDManager.SetID(weatherStationWMOIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        weatherStationWMOIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        weatherStationWMO = new WeatherStationWMO(item);
                    }
                }
            }
            
        
        }
        
    
        #region WeatherStationCity
        private BusinessCenter weatherStationCity;
        public BusinessCenter WeatherStationCity
        {
            get
            {
                if (this.weatherStationCity != null)
                {
                    return this.weatherStationCity; 
                }
                else if (this.weatherStationCityIDRef != null)
                {
                    weatherStationCity = IDManager.getID(weatherStationCityIDRef) as BusinessCenter;
                    return this.weatherStationCity; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.weatherStationCity != value)
                {
                    this.weatherStationCity = value;
                }
            }
        }
        #endregion
        
        public string BusinessCenterIDRef { get; set; }
        #region WeatherStationAirport
        private WeatherStationAirport weatherStationAirport;
        public WeatherStationAirport WeatherStationAirport
        {
            get
            {
                if (this.weatherStationAirport != null)
                {
                    return this.weatherStationAirport; 
                }
                else if (this.weatherStationAirportIDRef != null)
                {
                    weatherStationAirport = IDManager.getID(weatherStationAirportIDRef) as WeatherStationAirport;
                    return this.weatherStationAirport; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.weatherStationAirport != value)
                {
                    this.weatherStationAirport = value;
                }
            }
        }
        #endregion
        
        public string WeatherStationAirportIDRef { get; set; }
        #region WeatherStationWBAN
        private WeatherStationWBAN weatherStationWBAN;
        public WeatherStationWBAN WeatherStationWBAN
        {
            get
            {
                if (this.weatherStationWBAN != null)
                {
                    return this.weatherStationWBAN; 
                }
                else if (this.weatherStationWBANIDRef != null)
                {
                    weatherStationWBAN = IDManager.getID(weatherStationWBANIDRef) as WeatherStationWBAN;
                    return this.weatherStationWBAN; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.weatherStationWBAN != value)
                {
                    this.weatherStationWBAN = value;
                }
            }
        }
        #endregion
        
        public string WeatherStationWBANIDRef { get; set; }
        #region WeatherStationWMO
        private WeatherStationWMO weatherStationWMO;
        public WeatherStationWMO WeatherStationWMO
        {
            get
            {
                if (this.weatherStationWMO != null)
                {
                    return this.weatherStationWMO; 
                }
                else if (this.weatherStationWMOIDRef != null)
                {
                    weatherStationWMO = IDManager.getID(weatherStationWMOIDRef) as WeatherStationWMO;
                    return this.weatherStationWMO; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.weatherStationWMO != value)
                {
                    this.weatherStationWMO = value;
                }
            }
        }
        #endregion
        
        public string WeatherStationWMOIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

