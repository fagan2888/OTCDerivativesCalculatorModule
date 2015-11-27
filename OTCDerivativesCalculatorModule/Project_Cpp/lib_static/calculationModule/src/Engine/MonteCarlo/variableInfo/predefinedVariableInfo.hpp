#ifndef quantlib_PreDefinedVariableInfo_hpp
#define quantlib_PreDefinedVariableInfo_hpp

#include <src/Engine/MonteCarlo/variableInfo/variableInfo.hpp>

namespace QuantLib {

	//µ¤¾î , ´õÇØ , ³ª´²
	class PreDefinedVariableInfo : public VariableInfo 
	{
		public:
			PreDefinedVariableInfo(const std::string& refInstanceName,
								   const boost::shared_ptr<FixingInformation>& fixingInfo);

			//PreDefinedVariableInfo(const std::string& usingRefVarName,
			//							 const std::string& refInstanceName,
			//							 const boost::shared_ptr<FixingInformation>& fixingInfo,
			//							 bool saveFlag);

			Real execute(Real value);
			
			

	};
}

#endif