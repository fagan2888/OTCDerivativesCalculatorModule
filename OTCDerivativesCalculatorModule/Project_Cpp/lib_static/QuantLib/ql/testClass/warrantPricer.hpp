#ifndef quantlib_warrantpricer_hpp
#define quantlib_warrantpricer_hpp

#include <ql/testClass/warrantPricer.hpp>
#include <ql/math/functional.hpp>
#include <ql/math/linearleastsquaresregression.hpp>
#include <ql/testClass/Pricer.hpp>
#include <boost/bind.hpp>
#include <boost/function.hpp>

namespace QuantLib {

    class WarrantPricer : public Pricer {
      public:
        WarrantPricer(const std::vector<Time> & times,
					   const boost::shared_ptr<StochasticProcess>& process,
					   const Array & S0,
					   const Array & discounts,
					   const Array & strikeVals,
					   Size pastFixingNum,
					   Size seed,
					   std::vector<Statistics>& additionalStats);

        Real values(const std::vector<Real>& rand,Size simul) const;
		void transformPath(const std::vector<Real>& rand,Size simul) const;
        virtual void calibrate(Size);

      protected:
        bool  calibrationPhase_;

        boost::scoped_array<Array> coeff_;
        boost::scoped_array<DiscountFactor> dF_;

		std::vector<Array> driftDt_;
		std::vector<Array> sigmaDt_;

        mutable std::vector<PathType> paths_;
        const   std::vector<boost::function1<Real, Real> > v_;
    };

    
#endif
