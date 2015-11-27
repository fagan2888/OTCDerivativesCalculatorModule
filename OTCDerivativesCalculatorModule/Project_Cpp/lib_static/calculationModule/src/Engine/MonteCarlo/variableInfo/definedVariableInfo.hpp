#ifndef quantlib_DefinedVariableInfo_hpp
#define quantlib_DefinedVariableInfo_hpp

#include <src/Engine/MonteCarlo/variableInfo/variableInfo.hpp>

namespace QuantLib {

	//µ¤¾î , ´õÇØ , ³ª´²
	class DefinedVariableInfo : public VariableInfo 
	{
		public:
			DefinedVariableInfo(const std::string& refInstanceName);

			Real execute(Real value);
	};
}

#endif