#ifndef calculationModule_fdm_structuredproduct_engine_hpp
#define calculationModule_fdm_structuredproduct_engine_hpp

#include <ql/pricingengine.hpp>
#include <ql/processes/blackscholesprocess.hpp>
#include <ql/experimental/finitedifferences/fdmbackwardsolver.hpp>

namespace QuantLib {

    //! Two dimensional finite-differences Black Scholes vanilla option engine

    /*! \ingroup basketengines

        \test the correctness of the returned value is tested by
              reproducing results available in web/literature
              and comparison with Kirk approximation.
    */
    class FdmStructuredProductEngine : public BasketOption::engine {
      public:
          FdmStructuredProductEngine(const boost::shared_ptr<StochasticProcess>& processes,
									 std::vector<Size> underGrid = 100,
									 Size timeGrid = 50, Size dampingSteps = 0,
									 const FdmSchemeDesc& schemeDesc = FdmSchemeDesc::Hundsdorfer());

        void calculate() const;

      private:
        const boost::shared_ptr<StochasticProcess> processes_;
        const std::vector<Size> xGrid_;
		const Size tGrid_;
        const Size dampingSteps_;
        const FdmSchemeDesc schemeDesc_; // ? ÀÌ°Ô ¹¹Áö
    };
}

#endif
