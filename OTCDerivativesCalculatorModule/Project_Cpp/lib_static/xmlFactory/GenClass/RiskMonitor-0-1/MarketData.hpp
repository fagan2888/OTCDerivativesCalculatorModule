// MarketData.hpp 
#ifndef FpmlSerialized_MarketData_hpp
#define FpmlSerialized_MarketData_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/DataValueInfo.hpp>

namespace FpmlSerialized {

class MarketData : public ISerialized { 
   public: 
       MarketData(TiXmlNode* xmlNode);

       bool isKrcode(){return this->krcodeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getKrcode();


       bool isName(){return this->nameIsNull_;}
       boost::shared_ptr<XsdTypeToken> getName();


       bool isDataValueInfo(){return this->dataValueInfoIsNull_;}
       boost::shared_ptr<DataValueInfo> getDataValueInfo();


   protected: 
       boost::shared_ptr<XsdTypeToken> krcode_;
       
       bool krcodeIsNull_;
       boost::shared_ptr<XsdTypeToken> name_;
       
       bool nameIsNull_;
       boost::shared_ptr<DataValueInfo> dataValueInfo_;
       
       bool dataValueInfoIsNull_;

};

} //namespaceFpmlSerialized end
#endif

