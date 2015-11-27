using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class WeatherStation : ISerialized
    {
        public WeatherStation(XmlNode xmlNode)
        {
            XmlNode weatherStationCityNode = xmlNode.SelectSingleNode("weatherStationCity");
            
            if (weatherStationCityNode != null)
            {
                if (weatherStationCityNode.Attributes["href"] != null || weatherStationCityNode.Attributes["id"] != null) 
                {
                    if (weatherStationCityNode.Attributes["id"] != null) 
                    {
                        weatherStationCityIDRef_ = weatherStationCityNode.Attributes["id"].Value;
                        BusinessCenter ob = new BusinessCenter(weatherStationCityNode);
                        IDManager.SetID(weatherStationCityIDRef_, ob);
                    }
                    else if (weatherStationCityNode.Attributes["href"] != null)
                    {
                        weatherStationCityIDRef_ = weatherStationCityNode.Attributes["href"].Value;
                    }
                    else
                    {
                        weatherStationCity_ = new BusinessCenter(weatherStationCityNode);
                    }
                }
                else
                {
                    weatherStationCity_ = new BusinessCenter(weatherStationCityNode);
                }
            }
            
        
            XmlNode weatherStationAirportNode = xmlNode.SelectSingleNode("weatherStationAirport");
            
            if (weatherStationAirportNode != null)
            {
                if (weatherStationAirportNode.Attributes["href"] != null || weatherStationAirportNode.Attributes["id"] != null) 
                {
                    if (weatherStationAirportNode.Attributes["id"] != null) 
                    {
                        weatherStationAirportIDRef_ = weatherStationAirportNode.Attributes["id"].Value;
                        WeatherStationAirport ob = new WeatherStationAirport(weatherStationAirportNode);
                        IDManager.SetID(weatherStationAirportIDRef_, ob);
                    }
                    else if (weatherStationAirportNode.Attributes["href"] != null)
                    {
                        weatherStationAirportIDRef_ = weatherStationAirportNode.Attributes["href"].Value;
                    }
                    else
                    {
                        weatherStationAirport_ = new WeatherStationAirport(weatherStationAirportNode);
                    }
                }
                else
                {
                    weatherStationAirport_ = new WeatherStationAirport(weatherStationAirportNode);
                }
            }
            
        
            XmlNode weatherStationWBANNode = xmlNode.SelectSingleNode("weatherStationWBAN");
            
            if (weatherStationWBANNode != null)
            {
                if (weatherStationWBANNode.Attributes["href"] != null || weatherStationWBANNode.Attributes["id"] != null) 
                {
                    if (weatherStationWBANNode.Attributes["id"] != null) 
                    {
                        weatherStationWBANIDRef_ = weatherStationWBANNode.Attributes["id"].Value;
                        WeatherStationWBAN ob = new WeatherStationWBAN(weatherStationWBANNode);
                        IDManager.SetID(weatherStationWBANIDRef_, ob);
                    }
                    else if (weatherStationWBANNode.Attributes["href"] != null)
                    {
                        weatherStationWBANIDRef_ = weatherStationWBANNode.Attributes["href"].Value;
                    }
                    else
                    {
                        weatherStationWBAN_ = new WeatherStationWBAN(weatherStationWBANNode);
                    }
                }
                else
                {
                    weatherStationWBAN_ = new WeatherStationWBAN(weatherStationWBANNode);
                }
            }
            
        
            XmlNode weatherStationWMONode = xmlNode.SelectSingleNode("weatherStationWMO");
            
            if (weatherStationWMONode != null)
            {
                if (weatherStationWMONode.Attributes["href"] != null || weatherStationWMONode.Attributes["id"] != null) 
                {
                    if (weatherStationWMONode.Attributes["id"] != null) 
                    {
                        weatherStationWMOIDRef_ = weatherStationWMONode.Attributes["id"].Value;
                        WeatherStationWMO ob = new WeatherStationWMO(weatherStationWMONode);
                        IDManager.SetID(weatherStationWMOIDRef_, ob);
                    }
                    else if (weatherStationWMONode.Attributes["href"] != null)
                    {
                        weatherStationWMOIDRef_ = weatherStationWMONode.Attributes["href"].Value;
                    }
                    else
                    {
                        weatherStationWMO_ = new WeatherStationWMO(weatherStationWMONode);
                    }
                }
                else
                {
                    weatherStationWMO_ = new WeatherStationWMO(weatherStationWMONode);
                }
            }
            
        
        }
        
    
        #region WeatherStationCity_
        private BusinessCenter weatherStationCity_;
        public BusinessCenter WeatherStationCity_
        {
            get
            {
                if (this.weatherStationCity_ != null)
                {
                    return this.weatherStationCity_; 
                }
                else if (this.weatherStationCityIDRef_ != null)
                {
                    weatherStationCity_ = IDManager.getID(weatherStationCityIDRef_) as BusinessCenter;
                    return this.weatherStationCity_; 
                }
                else
                {
                      return this.weatherStationCity_; 
                }
            }
            set
            {
                if (this.weatherStationCity_ != value)
                {
                    this.weatherStationCity_ = value;
                }
            }
        }
        #endregion
        
        public string weatherStationCityIDRef_ { get; set; }
        #region WeatherStationAirport_
        private WeatherStationAirport weatherStationAirport_;
        public WeatherStationAirport WeatherStationAirport_
        {
            get
            {
                if (this.weatherStationAirport_ != null)
                {
                    return this.weatherStationAirport_; 
                }
                else if (this.weatherStationAirportIDRef_ != null)
                {
                    weatherStationAirport_ = IDManager.getID(weatherStationAirportIDRef_) as WeatherStationAirport;
                    return this.weatherStationAirport_; 
                }
                else
                {
                      return this.weatherStationAirport_; 
                }
            }
            set
            {
                if (this.weatherStationAirport_ != value)
                {
                    this.weatherStationAirport_ = value;
                }
            }
        }
        #endregion
        
        public string weatherStationAirportIDRef_ { get; set; }
        #region WeatherStationWBAN_
        private WeatherStationWBAN weatherStationWBAN_;
        public WeatherStationWBAN WeatherStationWBAN_
        {
            get
            {
                if (this.weatherStationWBAN_ != null)
                {
                    return this.weatherStationWBAN_; 
                }
                else if (this.weatherStationWBANIDRef_ != null)
                {
                    weatherStationWBAN_ = IDManager.getID(weatherStationWBANIDRef_) as WeatherStationWBAN;
                    return this.weatherStationWBAN_; 
                }
                else
                {
                      return this.weatherStationWBAN_; 
                }
            }
            set
            {
                if (this.weatherStationWBAN_ != value)
                {
                    this.weatherStationWBAN_ = value;
                }
            }
        }
        #endregion
        
        public string weatherStationWBANIDRef_ { get; set; }
        #region WeatherStationWMO_
        private WeatherStationWMO weatherStationWMO_;
        public WeatherStationWMO WeatherStationWMO_
        {
            get
            {
                if (this.weatherStationWMO_ != null)
                {
                    return this.weatherStationWMO_; 
                }
                else if (this.weatherStationWMOIDRef_ != null)
                {
                    weatherStationWMO_ = IDManager.getID(weatherStationWMOIDRef_) as WeatherStationWMO;
                    return this.weatherStationWMO_; 
                }
                else
                {
                      return this.weatherStationWMO_; 
                }
            }
            set
            {
                if (this.weatherStationWMO_ != value)
                {
                    this.weatherStationWMO_ = value;
                }
            }
        }
        #endregion
        
        public string weatherStationWMOIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

