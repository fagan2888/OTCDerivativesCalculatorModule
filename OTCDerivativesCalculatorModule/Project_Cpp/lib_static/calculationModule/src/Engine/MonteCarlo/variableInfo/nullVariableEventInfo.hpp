#ifndef quantlib_NullVariableEventInfo_hpp
#define quantlib_NullVariableEventInfo_hpp

#include <src/Engine/MonteCarlo/variableInfo/variableEventInfo.hpp>

namespace QuantLib {

	//µ¤¾î , ´õÇØ , ³ª´²
	class NullVariableEventInfo : public VariableEventInfo
	{
		public:
			NullVariableEventInfo();

			void initialize(const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

			bool execute(bool tf);

	};
}

#endif