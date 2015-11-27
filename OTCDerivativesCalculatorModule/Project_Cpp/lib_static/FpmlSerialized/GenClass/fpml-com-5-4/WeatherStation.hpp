// WeatherStation.hpp 
#ifndef FpmlSerialized_WeatherStation_hpp
#define FpmlSerialized_WeatherStation_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/BusinessCenter.hpp>
#include <fpml-com-5-4/WeatherStationAirport.hpp>
#include <fpml-com-5-4/WeatherStationWBAN.hpp>
#include <fpml-com-5-4/WeatherStationWMO.hpp>

namespace FpmlSerialized {

class WeatherStation : public ISerialized { 
   public: 
       WeatherStation(TiXmlNode* xmlNode);

       bool isWeatherStationCity(){return this->weatherStationCityIsNull_;}
       boost::shared_ptr<BusinessCenter> getWeatherStationCity();
      std::string getWeatherStationCityIDRef(){return weatherStationCityIDRef_;}

       bool isWeatherStationAirport(){return this->weatherStationAirportIsNull_;}
       boost::shared_ptr<WeatherStationAirport> getWeatherStationAirport();
      std::string getWeatherStationAirportIDRef(){return weatherStationAirportIDRef_;}

       bool isWeatherStationWBAN(){return this->weatherStationWBANIsNull_;}
       boost::shared_ptr<WeatherStationWBAN> getWeatherStationWBAN();
      std::string getWeatherStationWBANIDRef(){return weatherStationWBANIDRef_;}

       bool isWeatherStationWMO(){return this->weatherStationWMOIsNull_;}
       boost::shared_ptr<WeatherStationWMO> getWeatherStationWMO();
      std::string getWeatherStationWMOIDRef(){return weatherStationWMOIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!weatherStationCityIsNull_){
                count += 1;
                str = "weatherStationCity" ;
           }
           if(!weatherStationAirportIsNull_){
                count += 1;
                str = "weatherStationAirport" ;
           }
           if(!weatherStationWBANIsNull_){
                count += 1;
                str = "weatherStationWBAN" ;
           }
           if(!weatherStationWMOIsNull_){
                count += 1;
                str = "weatherStationWMO" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<BusinessCenter> weatherStationCity_;     //choice
       std::string weatherStationCityIDRef_;
       bool weatherStationCityIsNull_;
         boost::shared_ptr<WeatherStationAirport> weatherStationAirport_;     //choice
       std::string weatherStationAirportIDRef_;
       bool weatherStationAirportIsNull_;
         boost::shared_ptr<WeatherStationWBAN> weatherStationWBAN_;     //choice
       std::string weatherStationWBANIDRef_;
       bool weatherStationWBANIsNull_;
         boost::shared_ptr<WeatherStationWMO> weatherStationWMO_;     //choice
       std::string weatherStationWMOIDRef_;
       bool weatherStationWMOIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

