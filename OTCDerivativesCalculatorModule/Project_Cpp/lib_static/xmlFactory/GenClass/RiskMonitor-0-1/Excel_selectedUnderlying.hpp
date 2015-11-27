// Excel_selectedUnderlying.hpp 
#ifndef FpmlSerialized_Excel_selectedUnderlying_hpp
#define FpmlSerialized_Excel_selectedUnderlying_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class Excel_selectedUnderlying : public ISerialized { 
   public: 
       Excel_selectedUnderlying(TiXmlNode* xmlNode);

       bool isCode(){return this->codeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCode();


       bool isName(){return this->nameIsNull_;}
       boost::shared_ptr<XsdTypeToken> getName();


       bool isChecked(){return this->checkedIsNull_;}
       boost::shared_ptr<XsdTypeToken> getChecked();


   protected: 
       boost::shared_ptr<XsdTypeToken> code_;
       
       bool codeIsNull_;
       boost::shared_ptr<XsdTypeToken> name_;
       
       bool nameIsNull_;
       boost::shared_ptr<XsdTypeToken> checked_;
       
       bool checkedIsNull_;

};

} //namespaceFpmlSerialized end
#endif

