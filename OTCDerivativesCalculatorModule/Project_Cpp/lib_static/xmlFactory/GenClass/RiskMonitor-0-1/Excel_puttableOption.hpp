// Excel_puttableOption.hpp 
#ifndef FpmlSerialized_Excel_puttableOption_hpp
#define FpmlSerialized_Excel_puttableOption_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class Excel_puttableOption : public ISerialized { 
   public: 
       Excel_puttableOption(TiXmlNode* xmlNode);

       bool isOptionType(){return this->optionTypeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getOptionType();


   protected: 
       boost::shared_ptr<XsdTypeToken> optionType_;
       
       bool optionTypeIsNull_;

};

} //namespaceFpmlSerialized end
#endif

