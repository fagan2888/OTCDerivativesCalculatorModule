// Excel_referenceSet.hpp 
#ifndef FpmlSerialized_Excel_referenceSet_hpp
#define FpmlSerialized_Excel_referenceSet_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class Excel_referenceSet : public ISerialized { 
   public: 
       Excel_referenceSet(TiXmlNode* xmlNode);

       bool isKrCode(){return this->krCodeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getKrCode();


       bool isUsingTF(){return this->usingTFIsNull_;}
       boost::shared_ptr<XsdTypeToken> getUsingTF();


   protected: 
       boost::shared_ptr<XsdTypeToken> krCode_;
       
       bool krCodeIsNull_;
       boost::shared_ptr<XsdTypeToken> usingTF_;
       
       bool usingTFIsNull_;

};

} //namespaceFpmlSerialized end
#endif

