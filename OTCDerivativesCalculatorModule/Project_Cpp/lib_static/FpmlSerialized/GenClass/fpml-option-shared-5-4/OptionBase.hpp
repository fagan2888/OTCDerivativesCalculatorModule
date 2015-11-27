// OptionBase.hpp 
#ifndef FpmlSerialized_OptionBase_hpp
#define FpmlSerialized_OptionBase_hpp

#include <fpml-option-shared-5-4/Option.hpp>
#include <fpml-enum-5-4/OptionTypeEnum.hpp>

namespace FpmlSerialized {

class OptionBase : public Option { 
   public: 
       OptionBase(TiXmlNode* xmlNode);

       bool isOptionType(){return this->optionTypeIsNull_;}
       boost::shared_ptr<OptionTypeEnum> getOptionType();
      std::string getOptionTypeIDRef(){return optionTypeIDRef_;}

   protected: 
       boost::shared_ptr<OptionTypeEnum> optionType_;
       std::string optionTypeIDRef_;
       bool optionTypeIsNull_;

};

} //namespaceFpmlSerialized end
#endif

