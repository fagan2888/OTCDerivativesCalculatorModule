// Greek_underlying.hpp 
#ifndef FpmlSerialized_Greek_underlying_hpp
#define FpmlSerialized_Greek_underlying_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class Greek_underlying : public ISerialized { 
   public: 
       Greek_underlying(TiXmlNode* xmlNode);

       bool isDelta(){return this->deltaIsNull_;}
       boost::shared_ptr<XsdTypeToken> getDelta();


       bool isGamma(){return this->gammaIsNull_;}
       boost::shared_ptr<XsdTypeToken> getGamma();


       bool isVega(){return this->vegaIsNull_;}
       boost::shared_ptr<XsdTypeToken> getVega();


   protected: 
       boost::shared_ptr<XsdTypeToken> delta_;
       
       bool deltaIsNull_;
       boost::shared_ptr<XsdTypeToken> gamma_;
       
       bool gammaIsNull_;
       boost::shared_ptr<XsdTypeToken> vega_;
       
       bool vegaIsNull_;

};

} //namespaceFpmlSerialized end
#endif

