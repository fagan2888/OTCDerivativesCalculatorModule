// WeatherStation.cpp 
#include "WeatherStation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

WeatherStation::WeatherStation(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //weatherStationCityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* weatherStationCityNode = xmlNode->FirstChildElement("weatherStationCity");

   if(weatherStationCityNode){weatherStationCityIsNull_ = false;}
   else{weatherStationCityIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- weatherStationCityNode , address : " << weatherStationCityNode << std::endl;
   #endif
   if(weatherStationCityNode)
   {
      if(weatherStationCityNode->Attribute("href") || weatherStationCityNode->Attribute("id"))
      {
          if(weatherStationCityNode->Attribute("id"))
          {
             weatherStationCityIDRef_ = weatherStationCityNode->Attribute("id");
             weatherStationCity_ = boost::shared_ptr<BusinessCenter>(new BusinessCenter(weatherStationCityNode));
             weatherStationCity_->setID(weatherStationCityIDRef_);
             IDManager::instance().setID(weatherStationCityIDRef_,weatherStationCity_);
          }
          else if(weatherStationCityNode->Attribute("href")) { weatherStationCityIDRef_ = weatherStationCityNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { weatherStationCity_ = boost::shared_ptr<BusinessCenter>(new BusinessCenter(weatherStationCityNode));}
   }

   //weatherStationAirportNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* weatherStationAirportNode = xmlNode->FirstChildElement("weatherStationAirport");

   if(weatherStationAirportNode){weatherStationAirportIsNull_ = false;}
   else{weatherStationAirportIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- weatherStationAirportNode , address : " << weatherStationAirportNode << std::endl;
   #endif
   if(weatherStationAirportNode)
   {
      if(weatherStationAirportNode->Attribute("href") || weatherStationAirportNode->Attribute("id"))
      {
          if(weatherStationAirportNode->Attribute("id"))
          {
             weatherStationAirportIDRef_ = weatherStationAirportNode->Attribute("id");
             weatherStationAirport_ = boost::shared_ptr<WeatherStationAirport>(new WeatherStationAirport(weatherStationAirportNode));
             weatherStationAirport_->setID(weatherStationAirportIDRef_);
             IDManager::instance().setID(weatherStationAirportIDRef_,weatherStationAirport_);
          }
          else if(weatherStationAirportNode->Attribute("href")) { weatherStationAirportIDRef_ = weatherStationAirportNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { weatherStationAirport_ = boost::shared_ptr<WeatherStationAirport>(new WeatherStationAirport(weatherStationAirportNode));}
   }

   //weatherStationWBANNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* weatherStationWBANNode = xmlNode->FirstChildElement("weatherStationWBAN");

   if(weatherStationWBANNode){weatherStationWBANIsNull_ = false;}
   else{weatherStationWBANIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- weatherStationWBANNode , address : " << weatherStationWBANNode << std::endl;
   #endif
   if(weatherStationWBANNode)
   {
      if(weatherStationWBANNode->Attribute("href") || weatherStationWBANNode->Attribute("id"))
      {
          if(weatherStationWBANNode->Attribute("id"))
          {
             weatherStationWBANIDRef_ = weatherStationWBANNode->Attribute("id");
             weatherStationWBAN_ = boost::shared_ptr<WeatherStationWBAN>(new WeatherStationWBAN(weatherStationWBANNode));
             weatherStationWBAN_->setID(weatherStationWBANIDRef_);
             IDManager::instance().setID(weatherStationWBANIDRef_,weatherStationWBAN_);
          }
          else if(weatherStationWBANNode->Attribute("href")) { weatherStationWBANIDRef_ = weatherStationWBANNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { weatherStationWBAN_ = boost::shared_ptr<WeatherStationWBAN>(new WeatherStationWBAN(weatherStationWBANNode));}
   }

   //weatherStationWMONode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* weatherStationWMONode = xmlNode->FirstChildElement("weatherStationWMO");

   if(weatherStationWMONode){weatherStationWMOIsNull_ = false;}
   else{weatherStationWMOIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- weatherStationWMONode , address : " << weatherStationWMONode << std::endl;
   #endif
   if(weatherStationWMONode)
   {
      if(weatherStationWMONode->Attribute("href") || weatherStationWMONode->Attribute("id"))
      {
          if(weatherStationWMONode->Attribute("id"))
          {
             weatherStationWMOIDRef_ = weatherStationWMONode->Attribute("id");
             weatherStationWMO_ = boost::shared_ptr<WeatherStationWMO>(new WeatherStationWMO(weatherStationWMONode));
             weatherStationWMO_->setID(weatherStationWMOIDRef_);
             IDManager::instance().setID(weatherStationWMOIDRef_,weatherStationWMO_);
          }
          else if(weatherStationWMONode->Attribute("href")) { weatherStationWMOIDRef_ = weatherStationWMONode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { weatherStationWMO_ = boost::shared_ptr<WeatherStationWMO>(new WeatherStationWMO(weatherStationWMONode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<BusinessCenter> WeatherStation::getWeatherStationCity()
{
   if(!this->weatherStationCityIsNull_){
        if(weatherStationCityIDRef_ != ""){
             return boost::shared_static_cast<BusinessCenter>(IDManager::instance().getID(weatherStationCityIDRef_));
        }else{
             return this->weatherStationCity_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BusinessCenter>();
   }
}
boost::shared_ptr<WeatherStationAirport> WeatherStation::getWeatherStationAirport()
{
   if(!this->weatherStationAirportIsNull_){
        if(weatherStationAirportIDRef_ != ""){
             return boost::shared_static_cast<WeatherStationAirport>(IDManager::instance().getID(weatherStationAirportIDRef_));
        }else{
             return this->weatherStationAirport_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<WeatherStationAirport>();
   }
}
boost::shared_ptr<WeatherStationWBAN> WeatherStation::getWeatherStationWBAN()
{
   if(!this->weatherStationWBANIsNull_){
        if(weatherStationWBANIDRef_ != ""){
             return boost::shared_static_cast<WeatherStationWBAN>(IDManager::instance().getID(weatherStationWBANIDRef_));
        }else{
             return this->weatherStationWBAN_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<WeatherStationWBAN>();
   }
}
boost::shared_ptr<WeatherStationWMO> WeatherStation::getWeatherStationWMO()
{
   if(!this->weatherStationWMOIsNull_){
        if(weatherStationWMOIDRef_ != ""){
             return boost::shared_static_cast<WeatherStationWMO>(IDManager::instance().getID(weatherStationWMOIDRef_));
        }else{
             return this->weatherStationWMO_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<WeatherStationWMO>();
   }
}
}

