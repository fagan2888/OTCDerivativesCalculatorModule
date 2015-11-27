#ifndef quantlib_dls_callable_pricer_hpp
#define quantlib_dls_callable_pricer_hpp

#include <ql/termstructures/yieldtermstructure.hpp>
#include <ql/math/functional.hpp>
#include <ql/math/linearleastsquaresregression.hpp>
#include <ql/methods/montecarlo/lsmbasissystem.hpp>
#include <ql/processes/stochasticprocessarray.hpp>
#include <boost/bind.hpp>
#include <boost/function.hpp>
#include <ql/testClass/Pricer.hpp>
#include <ql/testClass/PayoffLeg.hpp>
#include <ql/math/statistics/statistics.hpp>

namespace QuantLib {

    class IRDLSCallablePricer : public Pricer {
      public:

        IRDLSCallablePricer(
            const boost::shared_ptr<PayoffLeg>& ,
            const std::vector<Size> &,
            const boost::shared_ptr<StochasticProcessArray>& ,
            const Array &,
			std::vector<Statistics>&,
            Size ,
            LsmBasisSystem::PolynomType );

        Real values(const std::vector<Real>& rand,Size simul) const;
        virtual void calibrate(Size);
		std::vector<Real>& earlyExProbability() const{return earlyExProbability_;}
		Real expectedBondPrice(){return expectedBondPrice_;}

      protected:
        struct PathInfo {
            PathInfo(Size numberOfTimes);

            Size pathLength() const;

            Array                   payments;
            Array                   exercises;
            std::vector<Array>      states;
        };

		void transformPath(const std::vector<Real>& rand,Size simul) const;

        bool  calibrationPhase_;

        const boost::shared_ptr<PayoffLeg> payoff_;
		const boost::shared_ptr<StochasticProcessArray>& process_;
        boost::scoped_array<Array> coeff_;
        boost::scoped_array<Real> lowerBounds_;

        const std::vector<Size> timePositions_;
        //사용안할듯.
		//const std::vector<Handle<YieldTermStructure> > forwardTermStructures_;

        const Array dF_;

		mutable std::vector<PathInfo> paths_;
		mutable std::vector<Statistics>& additionalStats_;
		mutable std::vector<Real> earlyExProbability_;
        
		mutable Real expectedBondPrice_;
		const   std::vector<boost::function1<Real, Array> > v_;
		Matrix chol_;
		Array corrCoff_;
		std::vector<IndexType> indexType_;

	private:
		Array dummydF_;

    };

}


#endif
