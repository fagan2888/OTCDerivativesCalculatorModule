#ifndef quantlib_AdditionVariableInfo_hpp
#define quantlib_AdditionVariableInfo_hpp

#include <src/Engine/MonteCarlo/variableInfo/variableInfo.hpp>

namespace QuantLib {

	//µ¤¾î , ´õÇØ , ³ª´²
	class AdditionVariableInfo : public VariableInfo
	{
		public:
			//AdditionVariableInfo(const std::string& usingRefVarName,
			//					const std::string& refInstanceName,
			//					const boost::shared_ptr<FixingInformation>& fixingInfo,
			//					bool saveFlag);

			AdditionVariableInfo(const std::string& usingRefVarName,
						 const std::string& refInstanceName,
						 bool saveFlag);
			
			Real execute(Real v);

	};
}

#endif