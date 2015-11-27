#ifndef quantlib_fdm_contigent_payoff_hpp
#define quantlib_fdm_contigent_payoff_hpp

#include <ql/math/array.hpp>
#include <ql/instruments/payoffs.hpp>

namespace QuantLib {

	//evolve 추가용임..

	class FdmContingentPayoff : public StepCondition<std::valarray<Array>> {
		
		public:
			FdmContingentPayoff(const Date& payoffDate,
								const std::vector<FdmPayoffFunction>& payoffFunction,
								const std::vector<boost::shared_ptr<Domain>>& domain,
								Size fixingDays,
								const ContingentEvent& eventInfo,
								const FdmStepConditionComposite& conditions)

			void build(const boost::shared_ptr<FdmMesher>& mesher);
			virtual std::vector<Time> stoppingTimes();
			void payoffRhs(Array& rhs);
			
			void applyTo(std::valarray<Array>& a , Time t ) const = 0;

		protected:
			boost::shared_ptr<FdmMesher> mesher_;
			Size fixingDays_;
			Date payoffDate_;
			std::vector<boost::shared_ptr<Domain>> domains_;
			
			FdmContingentStepConditionComposite conditions_;
	};




}


#endif
