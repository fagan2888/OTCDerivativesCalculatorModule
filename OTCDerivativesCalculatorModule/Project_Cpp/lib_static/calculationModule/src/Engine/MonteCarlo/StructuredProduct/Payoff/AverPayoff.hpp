#ifndef calculationModule_averPayoff_hpp
#define calculationModule_averPayoff_hpp

#include <ql/time/date.hpp>
#include <string>

#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/IndexTran/eventIndexTransformation.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/Payoff/payoffBase.hpp>

namespace QuantLib {

	class AverPayoff : public PayoffBase {
	  public:
		AverPayoff(const std::string& symbolName,
					const Date& payoffDate,
					Real constValue)
		: symbolName_(symbolName), payoffDate_(payoffDate), constValue_(constValue)
		{
			
		}

		Real value()
		{
			//#ifndef DEBUG
			//	if(!this->expired());
			//	QLERROR("")
			//#endif
			return constValue_;

		}
	private:
		const std::string& symbolName_;
		const Date& payoffDate_;
		Real constValue_;
	};

}
#endif
