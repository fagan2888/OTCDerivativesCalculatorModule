#include <ql/processes/blackscholesprocess.hpp>
#include <ql/math/interpolations/bicubicsplineinterpolation.hpp>
#include <ql/methods/finitedifferences/finitedifferencemodel.hpp>
#include <ql/experimental/finitedifferences/fdmmesher.hpp>
#include <ql/experimental/finitedifferences/fdminnervaluecalculator.hpp>
#include <ql/experimental/finitedifferences/fdmdirichletboundary.hpp>
#include <ql/experimental/finitedifferences/fdmblackscholesop.hpp>
#include <ql/experimental/finitedifferences/fdm2dblackscholesop.hpp>

#include <ql/experimental/finitedifferences/secondordermixedderivativeop.hpp>
#include <ql/experimental/finitedifferences/fdmstepconditioncomposite.hpp>
#include <ql/experimental/finitedifferences/fdmsnapshotcondition.hpp>

#include "Fdm2dParallelSolver.hpp"

namespace QuantLib {

    Fdm2dParallelSolver::Fdm2dParallelSolver(
        const Handle<GeneralizedBlackScholesProcess>& p1,
        const Handle<GeneralizedBlackScholesProcess>& p2,
        const Real correlation,
		const boost::shared_ptr<FdmMesher>& mesher,
		const FdmBoundaryConditionSet & bcSet,
		const boost::shared_ptr<FdmContingentPayoffComposite> & contingentPayoff,
        Time maturity,
        Size timeSteps,
        Size dampingSteps,
        const FdmSchemeDesc& schemeDesc)
    : p1_(p1), p2_(p2), correlation_(correlation),
      mesher_(mesher),
      bcSet_(bcSet),
      maturity_(maturity),
      timeSteps_(timeSteps),
      dampingSteps_(dampingSteps),
      schemeDesc_(schemeDesc),
      initialValues_(mesher->layout()->size()),
      resultValues_(mesher->layout()->dim()[1], mesher->layout()->dim()[0]) 
	
	{

        registerWith(p1_);
        registerWith(p2_);

		this->map_ = new Fdm2dBlackScholesOp(mesher_, 
											p1_.currentLink(), 
											p2_.currentLink(), 
											correlation_, maturity_));

		typedef FiniteDifferenceModel<ParallelEvolverOverWrap<ImplicitEulerScheme>> model_type;

		typename model_type::operator_type operatorSet;
        typename model_type::array_type arraySet;
        typename model_type::bc_set bcSet;
        typename model_type::condition_type conditionSet;

		initialValues_ = contingentPayoff->lastPayoff();

		for(Size i = 0 ; i < initialValues_.size() ; ++i)
		{
			operatorSet.push_back(map);
		}

		ParallelEvolverOverWrap<ImplicitEulerScheme> parallelEvolver(operatorSet, bcSet);
		
		const std::valarray<Date> eventDates = contingentPayoff_->eventDates();

		parallel_model_ = model_type(parallelEvolver, eventDates);

    }

    void Fdm2dParallelSolver::performCalculations() const {
        
		std::valarray<Array> rhs(contingentPayoff_->size());

		contingentPayoff_->payoffCalculate(rhs);

		//Array rhs(initialValues_.size());
        //std::copy(initialValues_.begin(), initialValues_.end(), rhs.begin());

		std::vector<Time> eventTimes = contingentPayoff_->eventTimes();

		// 이건 새로운 조건이 추가되거나 evolve 가 변경될때까지만 끊어서 사용함.
		// 그외에 event들은 condition 으로 조정함.
		const Time deltaT = from - to;
		const Size allSteps = steps + dampingSteps;
		const Time dampingTo = from - (deltaT*dampingSteps)/allSteps;

		this->rollback(rhs, 
						evolveModifyTimes[i] , 
						evolveModifyTimes[i+1],
						conditionSet);
			
		this->model_update(evolveModifyTimes[i],rhs);

        interpolation_ = boost::shared_ptr<BicubicSpline> (
            new BicubicSpline(x_.begin(), x_.end(),
                              y_.begin(), y_.end(),
                              resultValues_));
    }

	//void Fdm2dParallelSolver::model_update(const Date& date, std::valarray<Array>& Rhs)
	//{
	//	Evolver& evolver = finiteDifferenceModel.evolver();

	//	Rhs.push_back(contingentPayoff_->payoffs(eventDates[i]));

	//	evolver.addEvolver(operatorL_,bct_);
	//	
	//}

    Real Fdm2dParallelSolver::valueAt(Real u, Real v) const {
        calculate();
        const Real x = std::log(u);
        const Real y = std::log(v);

        return interpolation_->operator()(x, y);
    }
    
    Real Fdm2dParallelSolver::thetaAt(Real u, Real v) const {
        QL_REQUIRE(condition_->stoppingTimes().front() > 0.0,
                   "stopping time at zero-> can't calculate theta");

        calculate();
        Matrix thetaValues(resultValues_.rows(), resultValues_.columns());

        const Array& rhs = thetaCondition_->getValues();
        std::copy(rhs.begin(), rhs.end(), thetaValues.begin());

        const Real x = std::log(u);
        const Real y = std::log(v);

        return (BicubicSpline(x_.begin(), x_.end(), y_.begin(), y_.end(),
                              thetaValues)(x, y) - valueAt(u, v))
              / thetaCondition_->getTime();
    }


    Real Fdm2dParallelSolver::deltaXat(Real u, Real v) const {
        calculate();

        const Real x = std::log(u);
        const Real y = std::log(v);

        return interpolation_->derivativeX(x, y)/u;
    }

    Real Fdm2dParallelSolver::deltaYat(Real u, Real v) const {
        calculate();

        const Real x = std::log(u);
        const Real y = std::log(v);

        return interpolation_->derivativeY(x, y)/v;
    }

    Real Fdm2dParallelSolver::gammaXat(Real u, Real v) const {
        calculate();
        
        const Real x = std::log(u);
        const Real y = std::log(v);
        
        return (interpolation_->secondDerivativeX(x, y)
                -interpolation_->derivativeX(x, y))/(u*u);
    }

    Real Fdm2dParallelSolver::gammaYat(Real u, Real v) const {
        calculate();
        
        const Real x = std::log(u);
        const Real y = std::log(v);
        
        return (interpolation_->secondDerivativeY(x, y)
                -interpolation_->derivativeY(x, y))/(v*v);
    }
}
