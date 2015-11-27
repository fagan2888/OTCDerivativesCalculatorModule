#ifndef quantlib_OverWriteVariableInfo_hpp
#define quantlib_OverWriteVariableInfo_hpp

#include <src/Engine/MonteCarlo/variableInfo/variableInfo.hpp>

namespace QuantLib {

	//µ¤¾î , ´õÇØ , ³ª´²
	class OverWriteVariableInfo : public VariableInfo 
	{
		public:
			OverWriteVariableInfo(const std::string& usingRefVarName,
									const std::string& refInstanceName,
									//Real initialValue,
									bool saveFlag);

			//void initialize(const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

			Real execute(Real value);
			
			

	};
}

#endif