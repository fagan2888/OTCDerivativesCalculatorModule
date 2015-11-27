// GbmGreekResult.hpp 
#ifndef FpmlSerialized_GbmGreekResult_hpp
#define FpmlSerialized_GbmGreekResult_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <built_in_type/XsdTypeDouble.hpp>

namespace FpmlSerialized {

class GbmGreekResult : public ISerialized { 
   public: 
       GbmGreekResult(TiXmlNode* xmlNode);

       bool isUnderlyingName(){return this->underlyingNameIsNull_;}
       boost::shared_ptr<XsdTypeToken> getUnderlyingName();


       bool isDelta(){return this->deltaIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getDelta();


       bool isGamma(){return this->gammaIsNull_;}
       boost::shared_ptr<XsdTypeToken> getGamma();


       bool isVega(){return this->vegaIsNull_;}
       boost::shared_ptr<XsdTypeToken> getVega();


   protected: 
       boost::shared_ptr<XsdTypeToken> underlyingName_;
       
       bool underlyingNameIsNull_;
       boost::shared_ptr<XsdTypeDouble> delta_;
       
       bool deltaIsNull_;
       boost::shared_ptr<XsdTypeToken> gamma_;
       
       bool gammaIsNull_;
       boost::shared_ptr<XsdTypeToken> vega_;
       
       bool vegaIsNull_;

};

} //namespaceFpmlSerialized end
#endif

