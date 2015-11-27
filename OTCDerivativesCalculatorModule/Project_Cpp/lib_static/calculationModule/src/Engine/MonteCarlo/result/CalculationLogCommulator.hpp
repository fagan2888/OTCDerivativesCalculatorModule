#ifndef quantlib_CalculationLogCommulator_hpp
#define quantlib_CalculationLogCommulator_hpp

#include <vector>
#include <string>
#include <ql/types.hpp>

namespace QuantLib 
{
	class CalculationLogCommulator
	{
		public:
			CalculationLogCommulator();

			void save(const std::string& name,const std::vector<std::vector<std::string>>& log);

		//private:	
		//	std::vector<std::vector<string>> log_;
	};
}

#endif
