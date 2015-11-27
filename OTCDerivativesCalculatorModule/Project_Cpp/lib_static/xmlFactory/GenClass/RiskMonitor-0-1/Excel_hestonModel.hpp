// Excel_hestonModel.hpp 
#ifndef FpmlSerialized_Excel_hestonModel_hpp
#define FpmlSerialized_Excel_hestonModel_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class Excel_hestonModel : public ISerialized { 
   public: 
       Excel_hestonModel(TiXmlNode* xmlNode);

       bool isCurrentValue(){return this->currentValueIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCurrentValue();


       bool isVba_description(){return this->vba_descriptionIsNull_;}
       boost::shared_ptr<XsdTypeToken> getVba_description();


   protected: 
       boost::shared_ptr<XsdTypeToken> currentValue_;
       
       bool currentValueIsNull_;
       boost::shared_ptr<XsdTypeToken> vba_description_;
       
       bool vba_descriptionIsNull_;

};

} //namespaceFpmlSerialized end
#endif

