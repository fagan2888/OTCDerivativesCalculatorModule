// RateData.hpp 
#ifndef FpmlSerialized_RateData_hpp
#define FpmlSerialized_RateData_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeInteger.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <built_in_type/XsdTypeDouble.hpp>

namespace FpmlSerialized {

class RateData : public ISerialized { 
   public: 
       RateData(TiXmlNode* xmlNode);

       bool isPeriodMultiplier(){return this->periodMultiplierIsNull_;}
       boost::shared_ptr<XsdTypeInteger> getPeriodMultiplier();


       bool isPeriod(){return this->periodIsNull_;}
       boost::shared_ptr<XsdTypeToken> getPeriod();


       bool isData(){return this->dataIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getData();


   protected: 
       boost::shared_ptr<XsdTypeInteger> periodMultiplier_;
       
       bool periodMultiplierIsNull_;
       boost::shared_ptr<XsdTypeToken> period_;
       
       bool periodIsNull_;
       boost::shared_ptr<XsdTypeDouble> data_;
       
       bool dataIsNull_;

};

} //namespaceFpmlSerialized end
#endif

