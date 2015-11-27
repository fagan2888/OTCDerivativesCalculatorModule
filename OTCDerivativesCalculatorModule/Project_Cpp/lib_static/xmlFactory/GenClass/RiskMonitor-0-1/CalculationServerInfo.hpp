// CalculationServerInfo.hpp 
#ifndef FpmlSerialized_CalculationServerInfo_hpp
#define FpmlSerialized_CalculationServerInfo_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class CalculationServerInfo : public ISerialized { 
   public: 
       CalculationServerInfo(TiXmlNode* xmlNode);

       bool isServer_name(){return this->server_nameIsNull_;}
       boost::shared_ptr<XsdTypeToken> getServer_name();


       bool isServer_ip(){return this->server_ipIsNull_;}
       boost::shared_ptr<XsdTypeToken> getServer_ip();


       bool isServer_port(){return this->server_portIsNull_;}
       boost::shared_ptr<XsdTypeToken> getServer_port();


       bool isServer_status(){return this->server_statusIsNull_;}
       boost::shared_ptr<XsdTypeToken> getServer_status();


       bool isServer_coreNum(){return this->server_coreNumIsNull_;}
       boost::shared_ptr<XsdTypeToken> getServer_coreNum();


       bool isServer_use(){return this->server_useIsNull_;}
       boost::shared_ptr<XsdTypeToken> getServer_use();


       bool isServer_aliveTime(){return this->server_aliveTimeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getServer_aliveTime();


       bool isServer_description(){return this->server_descriptionIsNull_;}
       boost::shared_ptr<XsdTypeToken> getServer_description();


   protected: 
       boost::shared_ptr<XsdTypeToken> server_name_;
       
       bool server_nameIsNull_;
       boost::shared_ptr<XsdTypeToken> server_ip_;
       
       bool server_ipIsNull_;
       boost::shared_ptr<XsdTypeToken> server_port_;
       
       bool server_portIsNull_;
       boost::shared_ptr<XsdTypeToken> server_status_;
       
       bool server_statusIsNull_;
       boost::shared_ptr<XsdTypeToken> server_coreNum_;
       
       bool server_coreNumIsNull_;
       boost::shared_ptr<XsdTypeToken> server_use_;
       
       bool server_useIsNull_;
       boost::shared_ptr<XsdTypeToken> server_aliveTime_;
       
       bool server_aliveTimeIsNull_;
       boost::shared_ptr<XsdTypeToken> server_description_;
       
       bool server_descriptionIsNull_;

};

} //namespaceFpmlSerialized end
#endif

