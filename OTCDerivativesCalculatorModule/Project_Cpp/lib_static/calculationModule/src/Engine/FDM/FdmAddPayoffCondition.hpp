#ifndef quantlib_fdm_addpayoffcondition_hpp
#define quantlib_fdm_addpayoffcondition_hpp

#include <ql/math/array.hpp>
#include <ql/instruments/payoffs.hpp>

namespace QuantLib {
    
	//당일날 조건부임... 전날 조건부...? 전날 조건부는 FdmContingentPayoff에서 처리함.
	//어차피 더해서 덮어 씌울거임.
	class FdmAddPayoffCondition : public ContingentStepCondition<Array> {
      public:
		FdmAddPayoffCondition(const boost::shared_ptr<FdmExprInnerValue>& payoff, //이놈이 mesher를 들고옴.
							  const std::vector<boost::shared_ptr<Domain>>& domain,
							  Time t);

		FdmAddPayoffCondition(Real payoff,
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