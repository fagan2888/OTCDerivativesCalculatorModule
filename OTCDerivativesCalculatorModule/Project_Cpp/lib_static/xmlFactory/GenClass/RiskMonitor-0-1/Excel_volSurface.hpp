// Excel_volSurface.hpp 
#ifndef FpmlSerialized_Excel_volSurface_hpp
#define FpmlSerialized_Excel_volSurface_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class Excel_volSurface : public ISerialized { 
   public: 
       Excel_volSurface(TiXmlNode* xmlNode);

       bool isRefDate(){return this->refDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getRefDate();


       bool isCode(){return this->codeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCode();


       bool isName(){return this->nameIsNull_;}
       boost::shared_ptr<XsdTypeToken> getName();


       bool isTenor(){return this->tenorIsNull_;}
       std::vector<boost::shared_ptr<XsdTypeToken>> getTenor();


       bool isStrike(){return this->strikeIsNull_;}
       std::vector<boost::shared_ptr<XsdTypeToken>> getStrike();


   protected: 
       boost::shared_ptr<XsdTypeToken> refDate_;
       
       bool refDateIsNull_;
       boost::shared_ptr<XsdTypeToken> code_;
       
       bool codeIsNull_;
       boost::shared_ptr<XsdTypeToken> name_;
       
       bool nameIsNull_;
       std::vector<boost::shared_ptr<XsdTypeToken>> tenor_;
       
       bool tenorIsNull_;
       std::vector<boost::shared_ptr<XsdTypeToken>> strike_;
       
       bool strikeIsNull_;

};

} //namespaceFpmlSerialized end
#endif

