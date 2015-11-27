#ifndef quantlib_fdm_addpayoffcondition_hpp
#define quantlib_fdm_addpayoffcondition_hpp

#include <ql/math/array.hpp>
#include <ql/instruments/payoffs.hpp>

namespace QuantLib {
    
	//���ϳ� ���Ǻ���... ���� ���Ǻ�...? ���� ���Ǻδ� FdmContingentPayoff���� ó����.
	//������ ���ؼ� ���� �������.
	class FdmAddPayoffCondition : public ContingentStepCondition<Array> {
      public:
		FdmAddPayoffCondition(const boost::shared_ptr<FdmExprInnerValue>& payoff, //�̳��� mesher�� ����.
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