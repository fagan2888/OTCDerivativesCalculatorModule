// Excel_rateData.hpp 
#ifndef FpmlSerialized_Excel_rateData_hpp
#define FpmlSerialized_Excel_rateData_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class Excel_rateData : public ISerialized { 
   public: 
       Excel_rateData(TiXmlNode* xmlNode);

       bool isTenor(){return this->tenorIsNull_;}
       boost::shared_ptr<XsdTypeToken> getTenor();


       bool isRateType(){return this->rateTypeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getRateType();


       bool isValue(){return this->valueIsNull_;}
       boost::shared_ptr<XsdTypeToken> getValue();


   protected: 
       boost::shared_ptr<XsdTypeToken> tenor_;
       
       bool tenorIsNull_;
       boost::shared_ptr<XsdTypeToken> rateType_;
       
       bool rateTypeIsNull_;
       boost::shared_ptr<XsdTypeToken> value_;
       
       bool valueIsNull_;

};

} //namespaceFpmlSerialized end
#endif

