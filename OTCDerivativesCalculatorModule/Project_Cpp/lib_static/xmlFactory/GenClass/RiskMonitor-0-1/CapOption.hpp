// CapOption.hpp 
#ifndef FpmlSerialized_CapOption_hpp
#define FpmlSerialized_CapOption_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class CapOption : public ISerialized { 
   public: 
       CapOption(TiXmlNode* xmlNode);

       bool isReferenceStr(){return this->referenceStrIsNull_;}
       boost::shared_ptr<XsdTypeToken> getReferenceStr();


       bool isCapRate(){return this->capRateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCapRate();


       bool isVol(){return this->volIsNull_;}
       boost::shared_ptr<XsdTypeToken> getVol();


   protected: 
       boost::shared_ptr<XsdTypeToken> referenceStr_;
       
       bool referenceStrIsNull_;
       boost::shared_ptr<XsdTypeToken> capRate_;
       
       bool capRateIsNull_;
       boost::shared_ptr<XsdTypeToken> vol_;
       
       bool volIsNull_;

};

} //namespaceFpmlSerialized end
#endif

