// RateInfo.hpp 
#ifndef FpmlSerialized_RateInfo_hpp
#define FpmlSerialized_RateInfo_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class RateInfo : public ISerialized { 
   public: 
       RateInfo(TiXmlNode* xmlNode);

       bool isCurrency(){return this->currencyIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCurrency();


       bool isIndexType(){return this->indexTypeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getIndexType();


       bool isTenor(){return this->tenorIsNull_;}
       boost::shared_ptr<XsdTypeToken> getTenor();


       bool isLegTenor(){return this->legTenorIsNull_;}
       boost::shared_ptr<XsdTypeToken> getLegTenor();


   protected: 
       boost::shared_ptr<XsdTypeToken> currency_;
       
       bool currencyIsNull_;
       boost::shared_ptr<XsdTypeToken> indexType_;
       
       bool indexTypeIsNull_;
       boost::shared_ptr<XsdTypeToken> tenor_;
       
       bool tenorIsNull_;
       boost::shared_ptr<XsdTypeToken> legTenor_;
       
       bool legTenorIsNull_;

};

} //namespaceFpmlSerialized end
#endif

