// Excel_geometricBM.hpp 
#ifndef FpmlSerialized_Excel_geometricBM_hpp
#define FpmlSerialized_Excel_geometricBM_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class Excel_geometricBM : public ISerialized { 
   public: 
       Excel_geometricBM(TiXmlNode* xmlNode);

       bool isCurrentValue(){return this->currentValueIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCurrentValue();


       bool isDrift(){return this->driftIsNull_;}
       boost::shared_ptr<XsdTypeToken> getDrift();


       bool isDividend(){return this->dividendIsNull_;}
       boost::shared_ptr<XsdTypeToken> getDividend();


       bool isVolatility(){return this->volatilityIsNull_;}
       boost::shared_ptr<XsdTypeToken> getVolatility();


       bool isVba_description(){return this->vba_descriptionIsNull_;}
       boost::shared_ptr<XsdTypeToken> getVba_description();


   protected: 
       boost::shared_ptr<XsdTypeToken> currentValue_;
       
       bool currentValueIsNull_;
       boost::shared_ptr<XsdTypeToken> drift_;
       
       bool driftIsNull_;
       boost::shared_ptr<XsdTypeToken> dividend_;
       
       bool dividendIsNull_;
       boost::shared_ptr<XsdTypeToken> volatility_;
       
       bool volatilityIsNull_;
       boost::shared_ptr<XsdTypeToken> vba_description_;
       
       bool vba_descriptionIsNull_;

};

} //namespaceFpmlSerialized end
#endif

