#ifndef quantlib_OverWriteVariableEventInfo_hpp
#define quantlib_OverWriteVariableEventInfo_hpp

#include <valarray>
#include <string>
#include <src/Engine/MonteCarlo/PathGeneratorFactory.hpp>
#include <src/Engine/MonteCarlo/variableInfo/variableEventInfo.hpp>

namespace QuantLib {

	//µ¤¾î , ´õÇØ , ³ª´²
	class OverWriteVariableEventInfo : public VariableEventInfo 
	{
		public:
			OverWriteVariableEventInfo(const std::string& usingRefVarName,
									const std::string& refInstanceName,
									bool initialTF);

			//void initialize(const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

			bool execute(bool tf);
			
			

	};
}

#endif