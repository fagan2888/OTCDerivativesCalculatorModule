#ifndef quantlib_additionalOption_hpp
#define quantlib_additionalOption_hpp

//#include <src/Engine/MonteCarlo/pricer/event/eventTriggerInfo.hpp>
#include <string>

namespace QuantLib {

    class AdditionalOption {
      public:
		~AdditionalOption() {}
		AdditionalOption() {}
		
		std::string optionType() { return this->optionType_; }
		
		//interface

	  protected:
		std::string optionType_;


	};
}

#endif