#ifndef quantlib_VariableEventInfo_hpp
#define quantlib_VariableEventInfo_hpp

#include <valarray>
#include <string>
#include <src/Engine/MonteCarlo/PathGeneratorFactory.hpp>

namespace QuantLib {

	//µ¤¾î , ´õÇØ , ³ª´²
	class VariableEventInfo 
	{
		public:
			VariableEventInfo(const std::string& usingRefVarName,
							 const std::string& refInstanceName,
							 bool initialTF);

			virtual void initialize(const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

			virtual bool execute(bool tf) = 0;
			virtual void reset();

			boost::shared_ptr<variableStore> valueTypeRefPosition_;

			std::string usingRefVarName_;
			std::string refInstanceName_;
			bool initialTF_;
			

	};
}

#endif