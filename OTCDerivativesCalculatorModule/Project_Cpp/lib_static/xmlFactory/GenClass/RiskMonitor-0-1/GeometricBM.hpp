// GeometricBM.hpp 
#ifndef FpmlSerialized_GeometricBM_hpp
#define FpmlSerialized_GeometricBM_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDouble.hpp>

namespace FpmlSerialized {

class GeometricBM : public ISerialized { 
   public: 
       GeometricBM(TiXmlNode* xmlNode);

       bool isCurrentValue(){return this->currentValueIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getCurrentValue();


       bool isDrift(){return this->driftIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getDrift();


       bool isDividend(){return this->dividendIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getDividend();


       bool isVolatility(){return this->volatilityIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getVolatility();


   protected: 
       boost::shared_ptr<XsdTypeDouble> currentValue_;
       
       bool currentValueIsNull_;
       boost::shared_ptr<XsdTypeDouble> drift_;
       
       bool driftIsNull_;
       boost::shared_ptr<XsdTypeDouble> dividend_;
       
       bool dividendIsNull_;
       boost::shared_ptr<XsdTypeDouble> volatility_;
       
       bool volatilityIsNull_;

};

} //namespaceFpmlSerialized end
#endif

