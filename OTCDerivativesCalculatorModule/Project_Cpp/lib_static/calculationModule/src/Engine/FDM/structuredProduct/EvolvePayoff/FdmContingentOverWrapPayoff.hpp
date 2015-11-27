#ifndef quantlib_fdm_contigent_evolve_payoff_hpp
#define quantlib_fdm_contigent_evolve_payoff_hpp

#include <ql/math/array.hpp>
#include <ql/instruments/payoffs.hpp>

namespace QuantLib {

	//evolve 추가용임..

	class FdmContingentOverWrapPayoff : public FdmContingentPayoff {
		public:

			FdmContingentOverWrapPayoff(const Date& payoffDate,
								const std::vector<FdmPayoffFunction>& payoffFunction,
								const std::vector<boost::shared_ptr<Domain>>& domain,
								Size fixingDays,
								const ContingentEvent& eventInfo,
								const FdmStepConditionComposite& conditions)

			void applyTo(std::valarray<Array>& a , Time t) const;
			std::vector<Time> stoppingTimes();

		private:

			ContingentEvent eventInfo_;

			std::valarray<Time> overwrap_t;
			std::valarray<Size> indexPosition_;

	};




}


#endif
