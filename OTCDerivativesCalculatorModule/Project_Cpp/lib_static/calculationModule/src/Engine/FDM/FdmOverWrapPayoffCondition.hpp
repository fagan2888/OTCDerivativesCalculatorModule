#ifndef quantlib_fdm_overwrappayoffcondition_hpp
#define quantlib_fdm_overwrappayoffcondition_hpp

#include <ql/math/array.hpp>
#include <ql/instruments/payoffs.hpp>

namespace QuantLib {
    
	class OverWrapPayoffCondition : public StepCondition<Array> {
      public:
		OverWrapPayoffCondition(const boost::shared_ptr<FdmExprInnerValue>& payoff,
							  const std::vector<boost::shared_ptr<Domain>>& domain,
							  Time t);

		OverWrapPayoffCondition(Real payoff,
							  const boost::shared_ptr<FdmMesher>& mesher,
							  const std::vector<boost::shared_ptr<Domain>>& domain,
							  Time t);

        void applyTo(Array& a , Time t ) const;

		valarray<Size> locationIndexes_;
		valarray<Real> payoffValues_;

		valarray<Time> locationTimes_;
    };
}

#endif