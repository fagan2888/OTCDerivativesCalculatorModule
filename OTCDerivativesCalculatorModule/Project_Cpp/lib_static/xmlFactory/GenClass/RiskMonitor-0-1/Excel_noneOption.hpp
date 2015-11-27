// Excel_noneOption.hpp 
#ifndef FpmlSerialized_Excel_noneOption_hpp
#define FpmlSerialized_Excel_noneOption_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class Excel_noneOption : public ISerialized { 
   public: 
       Excel_noneOption(TiXmlNode* xmlNode);

       bool isOptionType(){return this->optionTypeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getOptionType();


   protected: 
       boost::shared_ptr<XsdTypeToken> optionType_;
       
       bool optionTypeIsNull_;

};

} //namespaceFpmlSerialized end
#endif

