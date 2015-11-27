#ifndef quantlib_contigent_payoff_hpp
#define quantlib_contigent_payoff_hpp

#include <ql/math/array.hpp>
#include <ql/instruments/payoffs.hpp>

namespace QuantLib {

	//evolve 추가용임..

	class ContingentPayoff {
		public:
			ContingentPayoff(const Date& payoffDate,
							const std::string& expr,
							Size fixingDays,
							const ContingentEvent& eventInfo,
							const FdmStepConditionComposite& conditions)
			
	};




}


#endif
