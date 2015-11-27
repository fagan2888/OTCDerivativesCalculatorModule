// DataValueInfo.hpp 
#ifndef FpmlSerialized_DataValueInfo_hpp
#define FpmlSerialized_DataValueInfo_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/DataValue.hpp>

namespace FpmlSerialized {

class DataValueInfo : public ISerialized { 
   public: 
       DataValueInfo(TiXmlNode* xmlNode);

       bool isDataValue(){return this->dataValueIsNull_;}
       std::vector<boost::shared_ptr<DataValue>> getDataValue();


   protected: 
       std::vector<boost::shared_ptr<DataValue>> dataValue_;
       
       bool dataValueIsNull_;

};

} //namespaceFpmlSerialized end
#endif

