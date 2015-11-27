#ifndef quantlib_ResetVariableInfo_hpp
#define quantlib_ResetVariableInfo_hpp

#include <src/Engine/MonteCarlo/variableInfo/variableInfo.hpp>

namespace QuantLib {

	//µ¤¾î , ´õÇØ , ³ª´²
	class ResetVariableInfo : public VariableInfo 
	{
		public:
			ResetVariableInfo(const std::string& refInstanceName,
								Real resetValue);

			//void initialize(const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

			Real execute(Real value = 0.0);

		private:
			Real resetValue_;

			
			

	};
}

#endif