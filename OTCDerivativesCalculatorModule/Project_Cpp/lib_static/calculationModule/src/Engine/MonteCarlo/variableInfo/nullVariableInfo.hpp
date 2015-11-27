#ifndef quantlib_NullVariableInfo_hpp
#define quantlib_NullVariableInfo_hpp

#include <src/Engine/MonteCarlo/variableInfo/variableInfo.hpp>

namespace QuantLib {

	//���� , ���� , ����
	class NullVariableInfo : public VariableInfo
	{
		public:
			NullVariableInfo();

			void initialize(const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

			Real execute(Real value);

	};
}

#endif